# GameHelper2 — Resume Phase 1 Bug Fixes (Session Handoff)

> **For the new Claude Code session reading this:** this document hands off context from a prior session. Read it fully before doing anything else. It tells you exactly what to do, what's been done, what NOT to touch, and how to run.

---

## TL;DR (one-paragraph)

You are resuming work on a Path of Exile overlay (`GameHelper2`). The .NET 10 migration is **done**. A 188-finding bug audit is **done**. A 16-task plan to fix 12 high+medium findings (Phase 1 of 4 phases) is **written and committed but NOT executed**. **Your job:** execute that plan via the `superpowers:subagent-driven-development` skill, dispatching opus-model subagents per task with two-stage review. Stop at the end of Phase 1 and wait for user smoke-test before proceeding to Phase 2.

---

## What you're doing now

**Execute Phase 1 of the audit-fix plan.**

- **Plan file (your bible):** `C:\Users\D\Desktop\GameHelper2\docs\superpowers\plans\2026-04-28-fix-all-phase1.md`
- **Spec file (the why):** `C:\Users\D\Desktop\GameHelper2\docs\superpowers\specs\2026-04-28-fix-all-high-medium-design.md`
- **Audit doc (finding details):** `C:\Users\D\Desktop\GameHelper2\docs\audit\2026-04-27-bug-audit.md`

The plan has 16 tasks landing 12 fixes across 3 clusters:
- **C3** (3 findings): JsonHelper atomic write + parse error handling — Tasks 1-4
- **C2** (3 findings): SafeMemoryHandle robustness — Tasks 5-8
- **C1a** (1 finding, base class): RemoteObjectBase.Address try/catch — Task 9
- **C1b** (5 findings, coroutine wrappers): per-coroutine try/catch at 12 sites — Tasks 10-13
- **Final** (audit doc updates + verify): Tasks 14-16

Total: **5 fix-commits + 1 audit-doc commit**.

---

## How to execute

1. Invoke the `superpowers:subagent-driven-development` skill with the Phase 1 plan path. If that skill isn't available in your environment, fall back to direct `Agent` tool dispatching with manual two-stage review (spec compliance reviewer + code quality reviewer subagents) after each task.
2. Use `TaskCreate` to track all 16 tasks (subjects can be `[Phase1 Task N] <short>`).
3. For each task:
   - Mark `in_progress`.
   - Dispatch implementer subagent (`general-purpose`, `model: "opus"`).
   - Pass full task text from the plan file.
   - On `DONE`: dispatch spec compliance reviewer (`general-purpose`, opus). On `BLOCKED` or `NEEDS_CONTEXT`: provide context or escalate to user.
   - On spec ✓: dispatch code quality reviewer (`superpowers:code-reviewer`, opus). 
   - On code quality ✓: mark task `completed`. Move to next.
4. Each commit must leave `dotnet build GameOverlay.sln` 0/0 on Debug AND Release.
5. After Task 16 (final commit), STOP. Report Phase 1 completion to user. Wait for user smoke-test before proceeding to Phase 2.

---

## Working directory

**ALL commands run from `C:\Users\D\Desktop\GameHelper2`.**

Each shell command must explicitly `cd /c/Users/D/Desktop/GameHelper2 && ...` because bash sessions reset cwd between calls. This is true even if your starting CWD already is the project — bash tools reset between calls.

---

## Pre-conditions (run these FIRST)

```bash
cd /c/Users/D/Desktop/GameHelper2
pwd                         # → /c/Users/D/Desktop/GameHelper2
git status --short          # MUST be clean
git log -1 --oneline        # MUST show: 6148091 docs(plan): Phase 1 fix-all implementation plan
dotnet --list-sdks          # MUST include 10.0.203
dotnet build GameOverlay.sln -c Debug --no-restore 2>&1 | tail -5
# Expected last lines:
#   GameHelper -> ...\GameHelper.dll
#   ...
#   Build succeeded.
#       0 Warning(s)
#       0 Error(s)
```

If ANY pre-condition fails, **stop and report to the user**. Do not start execution on a dirty tree or a broken build.

---

## What's been done (project history)

- **Phase 0 (migration)** — DONE. All 9 csproj migrated from `net8.0` to `net10.0-windows` LTS. ~144 nullability warnings + 6 NU1902/NU1903 vulnerabilities resolved. `SixLabors.ImageSharp` bumped 3.1.6 → 3.1.12 (CVE fix). `Nullable=enable` permanent.
- **Phase 0 (audit)** — DONE. 188 findings documented (0 critical, 17 high, 34 medium, 104 low, 33 nit). Coverage 134/134 source files in `GameHelper/` + `GameOffsets/`.
- **Phase 1 (fix high+medium)** — NOT STARTED. Plan written + committed; **your job is to execute it**.

The git tag `pre-net10-migration` exists as a rollback anchor.

---

## Scope decisions (CRITICAL — do not change without explicit user input)

- **Fix scope:** 17 high + 34 medium = **51 findings total**. The remaining 137 (104 low + 33 nit) are **DEFERRED** and out of scope for this work.
- **Phase 1 fix scope (this plan):** 12 of those 51 (clusters C1, C2, C3). Phases 2-4 (clusters C4-C12) get separate plans later — written via `superpowers:writing-plans` AFTER Phase 1 smoke-test passes.
- **Testing:** **No tests added.** The codebase has zero tests today. Verification is `dotnet build` clean + user manual smoke test with PoE running. Do NOT introduce a test framework.
- **Plugin SDK:** Source-compatible changes ONLY. F-086 (field-vs-property) and F-087 (lifecycle methods) are LOW severity, deferred. Do NOT touch `IPCore` / `PCore` public surface.
- **F-001:** Stays under existing `#pragma warning disable` in `GameHelper/Ui/KrangledPassiveDetector.cs`. Do NOT include in fix scope.
- **Audit-out-of-scope code:** `Launcher/` and `Plugins/` (the user-plugin folder at repo root) are NOT audited and have NO fix tasks for them. The host-side `GameHelper/Plugin/` (inside the GameHelper csproj) IS in scope; do not confuse the two.

---

## Build commands (memorize these)

**Critical: NEVER pass `-p:Platform=x64` to `dotnet build`.** Several csproj declare `<OutputType>` only inside `Platform==AnyCPU` conditional `<PropertyGroup>` blocks; passing `x64` triggers `CS2017` (Cannot specify /main when building a module/library). The csproj emit x64 binaries via `<PlatformTarget>x64</PlatformTarget>` inside the AnyCPU groups.

```bash
# Correct:
dotnet build GameOverlay.sln -c Debug --no-restore
dotnet build GameOverlay.sln -c Release --no-restore

# WRONG — never do this:
dotnet build GameOverlay.sln -c Debug -p:Platform=x64 --no-restore   # CS2017 trap!
```

---

## User preferences (carried over from prior sessions)

- **Language:** Russian conversation with the user, English in code/commits/comments.
- **Subagent model:** ALL spawned subagents (implementer, reviewers) MUST use `model: "opus"` (Opus 4.7).
- **Git policy:** Full commit/tag authority. Claude commits autonomously. **DO NOT push** — push requires explicit user go-ahead.
- **No memory storage for this project:** GameHelper2 has been excluded from auto-memory. Do NOT save memory entries about this project regardless of how interesting findings might seem.
- **Test instructions to user:** After major work, end with a concrete test checklist (files + steps + expected results). For Phase 1, the smoke checklist is in the plan's "Phase 1 Hand-off" section.
- **Code review thoroughness:** User wants careful refactoring. Triple-check changes; spec compliance and code quality reviews are NOT optional after each task.
- **Pixel-perfect ImGui UI:** N/A for Phase 1 (no UI changes), but flag if a fix accidentally affects rendering.
- **No server in wiki:** N/A for this project (no server here), but mentioned for completeness.

---

## Recent commit log (for context)

```
6148091  docs(plan): Phase 1 fix-all implementation plan         ← latest, your starting point
067a662  docs(spec): plan to fix 51 high+medium audit findings
17b6fd3  docs(audit): add 2026-04-27 bug audit report            ← 188 findings logged
c31a9f2  chore: gitignore docs/ and adjust plan to use git add -f
a52aea4  chore(gitignore): drop Plugins-specific entries
d5a0396  docs(plan): add .NET 10 migration + audit implementation plan
9a6a84d  docs(spec): add .NET 10 migration + audit design
ffc02c9  docs(spec+plan): expand migration scope to Launcher + Plugins
20483db  chore(net): migrate all 9 csproj to .NET 10 LTS (net10.0-windows)
c5b1a6f  chore(net): enable warnings-as-errors during migration cleanup
91a8f74  fix(net10): resolve compiler warnings from net10 migration
d238cee  chore(net): relax warnings-as-errors post-migration
... (older repo history)
```

Tag: `pre-net10-migration` (rollback anchor; do not delete or push).

---

## After Phase 1 completes

1. **Final state of repo:** 5 new fix-commits + 1 audit-doc commit on top of `6148091`. Build still 0/0. Audit doc shows 12/188 fixed.
2. **Report to user:** "Phase 1 done. 12 findings fixed. Build green. Please run PoE smoke test (overlay attaches, plugins load, settings persist across mid-save crash, area transition works)."
3. **Wait for user smoke result.** DO NOT auto-proceed to Phase 2.
4. **If green:** invoke `superpowers:writing-plans` to plan Phase 2 (clusters C4, C5, C7, C8 — 17 fixes). User will direct.
5. **If smoke fails:** diagnose by reading the diff for the failing area; report regression and proposed fix to user. May need to roll back specific commit.

Phases 2-4 are NOT pre-planned. Each gets its own `writing-plans` cycle.

---

## Quick-start instruction for the new session (paste this to yourself)

> "Read `C:\Users\D\Desktop\GameHelper2\NEXT-SESSION-START-HERE.md`. Then verify pre-conditions. Then invoke `superpowers:subagent-driven-development` to execute the plan at `C:\Users\D\Desktop\GameHelper2\docs\superpowers\plans\2026-04-28-fix-all-phase1.md`. All subagents use `model: \"opus\"`. Track 16 tasks via `TaskCreate`. Stop and report after Task 16 (Phase 1 complete) — do NOT auto-start Phase 2."

---

## Open questions for the user (mention if you start)

None. All scope decisions are locked. Just execute.

If something genuinely ambiguous comes up during execution (e.g. a coroutine has a control flow that doesn't fit the plan's assumed pattern), the implementer subagent should report `BLOCKED` and you ask the user.

---

## Files in this folder you should know about

| File | Purpose |
|------|---------|
| `NEXT-SESSION-START-HERE.md` | THIS FILE — session handoff |
| `docs/superpowers/specs/2026-04-28-fix-all-high-medium-design.md` | Phase 1-4 design (the why) |
| `docs/superpowers/plans/2026-04-28-fix-all-phase1.md` | Phase 1 plan (your bible) |
| `docs/audit/2026-04-27-bug-audit.md` | 188 findings; F-NNN details |
| `docs/superpowers/specs/2026-04-27-gamehelper-net10-migration-and-audit-design.md` | Phase 0 design (historical) |
| `docs/superpowers/plans/2026-04-27-gamehelper-net10-migration-and-audit.md` | Phase 0 plan (historical) |
| `GameOverlay.sln` | Solution file (9 csproj) |
| `GameHelper/`, `GameOffsets/`, `Launcher/`, `Plugins/` | Source dirs |

The `docs/` directory is gitignored. The audit doc, spec, and plan files are tracked via earlier `git add -f` commits.

---

## Self-test (run this if uncertain about state)

```bash
cd /c/Users/D/Desktop/GameHelper2
echo "=== git state ==="
git log -1 --oneline
git status --short
echo "=== build state ==="
dotnet build GameOverlay.sln -c Debug --no-restore 2>&1 | tail -3
echo "=== plan exists ==="
ls -la docs/superpowers/plans/2026-04-28-fix-all-phase1.md
echo "=== audit doc state ==="
grep "^Coverage:\|^Total" docs/audit/2026-04-27-bug-audit.md | head -5
```

Expected output:
- Latest commit: `6148091 docs(plan): Phase 1 fix-all implementation plan`
- Status: clean
- Build: 0 Warning(s), 0 Error(s)
- Plan file exists, ~1150 lines
- Coverage: 134/134, Total findings: 188

If any of these don't match, **stop and report**.

---

**Good luck. Execute Phase 1, stop at Task 16, wait for smoke test.**
