# GameHelper2 — .NET 10 LTS migration + bug audit (design)

**Date:** 2026-04-27
**Scope:** `GameHelper/` and `GameOffsets/` projects only. `Launcher/` and `Plugins/` are explicitly **out of scope** for both migration and audit.
**Outcome:** project builds clean on `net10.0-windows` with current diagnostics enabled, plus a curated audit document listing bugs the compiler cannot detect, ready for the user to triage.

---

## 1. Background

The repository is a Path of Exile overlay written in C# targeting `net8.0`. Two projects make up the engine:

- **GameHelper** — overlay app (`WinExe` Release / `Exe` Debug, x64). Uses `ClickableTransparentOverlay` for the rendering host, `ImGui.NET`, `Coroutine` for cooperative scheduling, `ProcessMemoryUtilities.Net` for memory reads, Win32 P/Invoke, and `System.Drawing` types (`Rectangle`, `Point`, `Size`).
- **GameOffsets** — plain class library with offset structs and pattern definitions, referenced by GameHelper.

Total source surface in scope: 134 C# files (87 in GameHelper, 47 in GameOffsets).

The user wants two outcomes:
1. Move to the latest stable LTS .NET.
2. Get a categorized list of bugs in the in-scope code so they can pick what to fix.

The user has explicitly excluded `Launcher/` and `Plugins/` from both deliverables.

## 2. Goals and non-goals

**Goals:**
- Both csproj target `net10.0-windows` (LTS, EOL 2028-11-14, `latest-sdk` 10.0.203 as of 2026-04-21).
- Build succeeds with `0 errors / 0 warnings` after migration.
- Modern diagnostics enabled: `Nullable=enable`, `LangVersion=latest`, default code analyzers active.
- Compiler-/analyzer-visible defects fixed mechanically as part of migration (the migration commit cleans them up; they are not re-listed in the audit).
- A separate audit document lists bugs that the compiler/analyzers cannot catch (concurrency, lifecycle, logic, P/Invoke semantics, etc.).
- Audit document is sortable by severity and category so the user can triage.

**Non-goals:**
- No manual code fixes for audit findings during this work (those become a separate plan after triage).
- No changes to `Launcher/` or `Plugins/`.
- No architectural rewrites (no DI introduction, no replacing Coroutine, no rewriting reflection-driven UI scaffolding).
- No mandatory migration off `Newtonsoft.Json`. May be flagged in audit; not implemented here.
- No runtime smoke-test against the live game. The user will validate that the overlay still attaches and renders correctly.

## 3. Environment

- Local SDKs after install of .NET 10: `8.0.405`, `9.0.313`, `10.0.203`. Build will use `10.0.203`.
- A `global.json` is **not** added — using the latest installed SDK is acceptable. If determinism becomes an issue later, `global.json` can be added in a separate change.
- `Directory.Build.props` already pins `RuntimeIdentifier=win-x64` — kept as is.

## 4. Approach

Single development branch, ordered phases. No parallel tracks.

### Phase 1 — Migration (mechanical)

1. **csproj changes**
   - `GameHelper/GameHelper.csproj`: `TargetFramework` → `net10.0-windows`.
   - `GameOffsets/GameOffsets.csproj`: `TargetFramework` → `net10.0-windows`.
   - Both: add `<Nullable>enable</Nullable>` and `<LangVersion>latest</LangVersion>`.
   - Defer `<ImplicitUsings>enable</ImplicitUsings>` to a separate step after audit (it would mass-edit `using` blocks and pollute the migration diff).

2. **Package versions**
   - `ClickableTransparentOverlay` stays at `11.1.0` (latest available; published with a `net8.0` target. NuGet's TFM compatibility rules treat `net8.0` as consumable from `net10.0` projects, so no shim is required).
   - `Coroutine` stays at `2.1.5` (latest; `net6.0`/`netstandard2.0` lib).
   - `Newtonsoft.Json` stays at `13.0.3` unless a newer 13.x patch is on NuGet at migration time (then bump to latest 13.x).
   - `ProcessMemoryUtilities.Net` stays at `1.3.4` (latest; `netstandard2.0`).
   - Transitive packages allowed to float; resolution is recorded in the lockfile via `dotnet restore`.

3. **Compile clean**
   - Temporarily set `<TreatWarningsAsErrors>true</TreatWarningsAsErrors>` in both csproj.
   - Run `dotnet build`. Iterate on every error and warning until zero.
   - Mechanical fixes only: nullable annotations (`?`/`!`), null-coalescing where the original code already assumed non-null, replacing obsolete API call sites, fixing P/Invoke signatures the analyzer flags, etc.
   - **Boundary rule:** if a warning requires a logic decision (e.g. "this could be null but the caller depends on it not being null in some specific case"), do **not** decide it inline — capture it as a finding in the audit doc and silence the warning at the call site with `#pragma warning disable <CODE> // TODO: see audit F-XXX` and re-enable immediately after.

4. **Relax WAE**
   - After phase 1 completes, switch `<TreatWarningsAsErrors>` back to `false` (matching original Debug behavior). Keep `<Nullable>enable</Nullable>` permanently. This avoids future contributors being blocked by every new warning, but keeps nullability protection.

**Phase 1 exit criteria:** `dotnet build -c Release -p:Platform=x64` and `dotnet build -c Debug -p:Platform=x64` both succeed with 0 errors / 0 warnings.

### Phase 2 — Manual audit (document only)

Walk the in-scope code file by file and capture findings the compiler cannot detect.

**Categories scanned:**

1. **Concurrency / coroutine sync** — `processesInfo` mutated by `FindAndOpen` while read by `AskUserToSelectClient`; multiple coroutines yielding on the same `OnStaticAddressFound` event; `while(true)` with no cancellation on game exit; ordering between handle-close and consumers.
2. **Process / memory handle lifecycle** — `SafeMemoryHandle` lifetime, double-`Open`, `Information.Close()` vs `Dispose`, leaked native handles on coroutine restart.
3. **Exception handling** — silent `catch { }` blocks, `catch (Exception)` swallowing P/Invoke errors, `Pid` getter returning `0` on failure (caller cannot distinguish "no game" from "access denied").
4. **Resource lifecycle / Dispose** — classes owning unmanaged state without `IDisposable`, asymmetric `using` usage.
5. **P/Invoke correctness** — missing `SetLastError`, missing `CharSet`, calling convention mismatches, unsafe handle marshaling, `IntPtr` vs `SafeHandle`.
6. **Logic bugs** — `private set { }` on `Address` (effectively read-only with confusing setter), unreachable branches, dead code, off-by-ones in offset math.
7. **Culture / globalization** — `string.ToLower()` without `Invariant`, parsing without `CultureInfo.InvariantCulture`, locale-dependent comparisons.
8. **Performance in hot loops** — reflection in render frame, repeated `Process.GetProcesses()` (expensive on Windows), boxing/allocation in 60fps coroutine bodies, repeated string formatting.
9. **API misuse** — `MainModule.ModuleMemorySize` access without elevation handling, `MainWindowTitle` after `HasExited`, `ReadProcessMemory` calls on a torn-down handle.
10. **Coroutine semantics** — multi-consumer events with shared subscribers, missing tear-down on `OnClose`, infinite `while` loops without `yield break` paths.
11. **Settings / IO** — `File.AppendAllText("Error.log")` with relative path (depends on CWD), JSON parse without `try`, settings save races.
12. **GameOffsets structs** — `[StructLayout(Pack=...)]` correctness, sizes against documented offsets, alignment, `unsafe` block invariants, `fixed` buffer bounds.

**Finding format (one per issue):**

```
### F-NNN — Short title (Severity: critical|high|medium|low|nit)
**File:** path/relative/to/repo:lineStart-lineEnd
**Category:** <one of the 12 above>
**Description:** What the code does today.
**Why it's a bug:** What goes wrong, under what conditions.
**Suggested fix:** Concrete change. May reference a class/method.
**Risk if left:** What user-visible effect persists if we don't fix.
```

**Severity rubric:**
- **critical** — causes a crash, hang, memory corruption, or data loss in a normal session.
- **high** — race, leak, or wrong-behavior that triggers in everyday use but doesn't crash.
- **medium** — incorrect behavior in edge cases (specific game states, locales, multi-monitor, etc.).
- **low** — style, defensive-coding, or hygiene issue with no observable impact.
- **nit** — purely cosmetic or pedantic.

**Output file:** `docs/audit/2026-04-27-bug-audit.md` (in the GameHelper2 repo). Structure:
1. Header: counts by severity, file coverage summary.
2. Findings grouped by category, sorted by severity descending within each category.
3. Index at top: list of `F-NNN — title (severity, file)` for fast scanning.

**Phase 2 exit criteria:** the audit document exists, every in-scope file has been read at least once, and the document has been committed.

### Phase 3 — User triage and fixes (out of scope here)

The user reviews the audit document and selects findings to fix. Each selected fix becomes a separate task, planned via the `writing-plans` skill. This phase is not part of this design.

## 5. Commits

Granular commits, no squashing:

| # | Subject | Contents |
|---|---------|----------|
| 1 | `chore(net): migrate to .NET 10 LTS (net10.0-windows)` | TFM bump, Nullable, LangVersion, package floats |
| 2 | `chore(net): enable warnings-as-errors during migration cleanup` | WAE on, nothing else |
| 3 | `fix(net10): resolve compiler/analyzer warnings from net10 migration` | The mechanical cleanup pass |
| 4 | `chore(net): relax WAE post-migration, keep nullable on` | WAE off, Nullable stays |
| 5 | `docs(audit): add 2026-04-27 bug audit report` | The audit document |

If commit 3 is large, it may be split per file or per category — but each split commit must still leave the build green.

## 6. Risks and assumptions

- **Risk: `ClickableTransparentOverlay` 11.1.0 was published targeting `net8.0`.** Runtime forward-compat with `net10.0-windows` is the stated NuGet behavior, but if the binary surfaces an issue (e.g. a Vortice transitive package conflicts), fallback is `net9.0-windows` (still LTS-adjacent — ships as STS though, EOL 2026-11). If that fails too, file an upstream issue and stay on `net8.0` for the migration commit and audit on `net8.0`. Decision lives with the user.
- **Risk: enabling `Nullable` may produce a large warning volume.** Treated as expected work for phase 1, not a blocker.
- **Risk: silenced warnings (with `#pragma`) leak into audit-as-future-work.** Mitigated by the `// TODO: see audit F-XXX` requirement so every silenced warning has a corresponding finding.
- **Assumption: project currently builds on `net8.0` with no errors.** Will be verified as the very first action before changing anything; if it doesn't build, that becomes a small pre-fix commit before phase 1.
- **Assumption: behavioral verification (overlay attaches, finds game, renders) is performed by the user.** I cannot run the game from this environment. The migration commit is "build-green", not "runtime-verified".

## 7. Out of scope (explicit)

- Changes under `Launcher/` or `Plugins/`, including any plugin SDK files.
- Replacing `Newtonsoft.Json` with `System.Text.Json`.
- Replacing the `Coroutine` library or rewriting the cooperative scheduler.
- Adding unit tests, integration tests, or CI configuration.
- Adding analyzers beyond the .NET SDK defaults (no StyleCop, no SonarAnalyzer.CSharp).
- Updating the `.editorconfig`.
- Touching `GameOverlay.sln` beyond what is required for the TFM change to be picked up.

## 8. Deliverables

1. Two updated csproj files on `net10.0-windows` with `Nullable` enabled.
2. Mechanical compiler-driven fixes across in-scope source.
3. `docs/audit/2026-04-27-bug-audit.md` — the audit document.
4. This design document, committed at `docs/superpowers/specs/2026-04-27-gamehelper-net10-migration-and-audit-design.md`.
5. (Implicit) A green `dotnet build` on the new TFM.

## 9. Hand-off

After user approval of this spec, control transfers to the `writing-plans` skill for an executable phased plan. No implementation skills are invoked from this brainstorming step directly.
