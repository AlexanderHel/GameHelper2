using System;

namespace GameHelper.RemoteEnums
{
	// Token: 0x0200004D RID: 77
	public enum Animation
	{
		// Token: 0x0400011D RID: 285
		Idle,
		// Token: 0x0400011E RID: 286
		Melee,
		// Token: 0x0400011F RID: 287
		MeleeWithStep,
		// Token: 0x04000120 RID: 288
		OffMelee,
		// Token: 0x04000121 RID: 289
		Run,
		// Token: 0x04000122 RID: 290
		TakeHit,
		// Token: 0x04000123 RID: 291
		Death,
		// Token: 0x04000124 RID: 292
		Stomp,
		// Token: 0x04000125 RID: 293
		Impale,
		// Token: 0x04000126 RID: 294
		Cleave,
		// Token: 0x04000127 RID: 295
		Charge,
		// Token: 0x04000128 RID: 296
		ChargeEnd,
		// Token: 0x04000129 RID: 297
		ChargeEndAlt,
		// Token: 0x0400012A RID: 298
		GroundSlam,
		// Token: 0x0400012B RID: 299
		LeapSlam,
		// Token: 0x0400012C RID: 300
		LeapSlamNear,
		// Token: 0x0400012D RID: 301
		MoltenCrash,
		// Token: 0x0400012E RID: 302
		MoltenCrashNear,
		// Token: 0x0400012F RID: 303
		MoltenCrashMoving,
		// Token: 0x04000130 RID: 304
		MoltenCrashMovingNear,
		// Token: 0x04000131 RID: 305
		ShapeshiftMoltenCrash,
		// Token: 0x04000132 RID: 306
		ShapeshiftMoltenCrashNear,
		// Token: 0x04000133 RID: 307
		ShapeshiftMoltenCrashMoving,
		// Token: 0x04000134 RID: 308
		ShapeshiftMoltenCrashMovingNear,
		// Token: 0x04000135 RID: 309
		DoubleStrike,
		// Token: 0x04000136 RID: 310
		DoubleSlash,
		// Token: 0x04000137 RID: 311
		DoubleSlashOffhand,
		// Token: 0x04000138 RID: 312
		DoubleSlashMainhand,
		// Token: 0x04000139 RID: 313
		Sweep,
		// Token: 0x0400013A RID: 314
		SpellProjectile,
		// Token: 0x0400013B RID: 315
		SpellProjectileUpward,
		// Token: 0x0400013C RID: 316
		SpellAreaOfEffect,
		// Token: 0x0400013D RID: 317
		SpellBuff,
		// Token: 0x0400013E RID: 318
		SpellProjectileFire,
		// Token: 0x0400013F RID: 319
		SpellProjectileCold,
		// Token: 0x04000140 RID: 320
		SpellProjectileLightning,
		// Token: 0x04000141 RID: 321
		SpellProjectileChaos,
		// Token: 0x04000142 RID: 322
		SpellProjectileUpwardFire,
		// Token: 0x04000143 RID: 323
		SpellProjectileUpwardCold,
		// Token: 0x04000144 RID: 324
		SpellProjectileUpwardLightning,
		// Token: 0x04000145 RID: 325
		SpellProjectileUpwardChaos,
		// Token: 0x04000146 RID: 326
		SpellAreaOfEffectFire,
		// Token: 0x04000147 RID: 327
		SpellAreaOfEffectCold,
		// Token: 0x04000148 RID: 328
		SpellAreaOfEffectLightning,
		// Token: 0x04000149 RID: 329
		SpellAreaOfEffectChaos,
		// Token: 0x0400014A RID: 330
		SpellNova,
		// Token: 0x0400014B RID: 331
		SpellNovaFire,
		// Token: 0x0400014C RID: 332
		SpellNovaCold,
		// Token: 0x0400014D RID: 333
		SpellNovaLightning,
		// Token: 0x0400014E RID: 334
		SpellNovaChaos,
		// Token: 0x0400014F RID: 335
		SpellBuffFire,
		// Token: 0x04000150 RID: 336
		SpellBuffCold,
		// Token: 0x04000151 RID: 337
		SpellBuffLightning,
		// Token: 0x04000152 RID: 338
		SpellBuffChaos,
		// Token: 0x04000153 RID: 339
		Throw,
		// Token: 0x04000154 RID: 340
		Flurry,
		// Token: 0x04000155 RID: 341
		LayTrap,
		// Token: 0x04000156 RID: 342
		LayTotem,
		// Token: 0x04000157 RID: 343
		LayBallista,
		// Token: 0x04000158 RID: 344
		Emerge,
		// Token: 0x04000159 RID: 345
		DualStrike,
		// Token: 0x0400015A RID: 346
		Snipe,
		// Token: 0x0400015B RID: 347
		SnipeChannel,
		// Token: 0x0400015C RID: 348
		SnipeChannelEnd,
		// Token: 0x0400015D RID: 349
		Block,
		// Token: 0x0400015E RID: 350
		GlacialHammer,
		// Token: 0x0400015F RID: 351
		OffGlacialHammer,
		// Token: 0x04000160 RID: 352
		Emerge2,
		// Token: 0x04000161 RID: 353
		Emerge3,
		// Token: 0x04000162 RID: 354
		HeavyStrike,
		// Token: 0x04000163 RID: 355
		OffHeavyStrike,
		// Token: 0x04000164 RID: 356
		RainOfArrows,
		// Token: 0x04000165 RID: 357
		RainOfArrowsAdditive,
		// Token: 0x04000166 RID: 358
		BlastRain,
		// Token: 0x04000167 RID: 359
		CloneShot,
		// Token: 0x04000168 RID: 360
		Backstab,
		// Token: 0x04000169 RID: 361
		OffBackstab,
		// Token: 0x0400016A RID: 362
		Frenzy,
		// Token: 0x0400016B RID: 363
		OffFrenzy,
		// Token: 0x0400016C RID: 364
		PowerShot,
		// Token: 0x0400016D RID: 365
		OffPowerShot,
		// Token: 0x0400016E RID: 366
		Taunt,
		// Token: 0x0400016F RID: 367
		ChangeToStance1,
		// Token: 0x04000170 RID: 368
		ChangeToStance2,
		// Token: 0x04000171 RID: 369
		ChangeToStance3,
		// Token: 0x04000172 RID: 370
		Revive,
		// Token: 0x04000173 RID: 371
		ShadowProjectiles,
		// Token: 0x04000174 RID: 372
		HookOut,
		// Token: 0x04000175 RID: 373
		HookIn,
		// Token: 0x04000176 RID: 374
		HookInNear,
		// Token: 0x04000177 RID: 375
		Dance,
		// Token: 0x04000178 RID: 376
		Channel,
		// Token: 0x04000179 RID: 377
		AttackChannel,
		// Token: 0x0400017A RID: 378
		Cyclone,
		// Token: 0x0400017B RID: 379
		Hide,
		// Token: 0x0400017C RID: 380
		Hide2,
		// Token: 0x0400017D RID: 381
		Hide3,
		// Token: 0x0400017E RID: 382
		BarrageStart,
		// Token: 0x0400017F RID: 383
		BarrageFireMain,
		// Token: 0x04000180 RID: 384
		BarrageFireOff,
		// Token: 0x04000181 RID: 385
		BarrageActivate,
		// Token: 0x04000182 RID: 386
		BarrageActivateFlipped,
		// Token: 0x04000183 RID: 387
		LongOpen,
		// Token: 0x04000184 RID: 388
		Submerge,
		// Token: 0x04000185 RID: 389
		Puncture,
		// Token: 0x04000186 RID: 390
		OffPuncture,
		// Token: 0x04000187 RID: 391
		DodgeLeft,
		// Token: 0x04000188 RID: 392
		DodgeRight,
		// Token: 0x04000189 RID: 393
		DodgeForward,
		// Token: 0x0400018A RID: 394
		DodgeBack,
		// Token: 0x0400018B RID: 395
		SpellBuffFast,
		// Token: 0x0400018C RID: 396
		IncreasingPulses,
		// Token: 0x0400018D RID: 397
		Pant,
		// Token: 0x0400018E RID: 398
		CastFast,
		// Token: 0x0400018F RID: 399
		ChannelEnd,
		// Token: 0x04000190 RID: 400
		ChannelUnleash,
		// Token: 0x04000191 RID: 401
		ChannelAttackUnleash,
		// Token: 0x04000192 RID: 402
		SpectralThrow,
		// Token: 0x04000193 RID: 403
		SpectralThrowOff,
		// Token: 0x04000194 RID: 404
		Teleport,
		// Token: 0x04000195 RID: 405
		Knockdown,
		// Token: 0x04000196 RID: 406
		ThrowOff,
		// Token: 0x04000197 RID: 407
		IdleRelaxed,
		// Token: 0x04000198 RID: 408
		ChannelBow,
		// Token: 0x04000199 RID: 409
		ChannelBowEnd,
		// Token: 0x0400019A RID: 410
		RainOfSpores,
		// Token: 0x0400019B RID: 411
		GroundSlamOffhand,
		// Token: 0x0400019C RID: 412
		LeapSlamOffhand,
		// Token: 0x0400019D RID: 413
		DoubleStrikeOffhand,
		// Token: 0x0400019E RID: 414
		AttackChannelEnd,
		// Token: 0x0400019F RID: 415
		ChangeToStance4,
		// Token: 0x040001A0 RID: 416
		ChainStrikeThrow,
		// Token: 0x040001A1 RID: 417
		SliceAndDice,
		// Token: 0x040001A2 RID: 418
		ChargeStart,
		// Token: 0x040001A3 RID: 419
		CoilingAssault,
		// Token: 0x040001A4 RID: 420
		AttackProjectileUpward,
		// Token: 0x040001A5 RID: 421
		ChannelBowUpwards,
		// Token: 0x040001A6 RID: 422
		ChannelBowUpwardsEnd,
		// Token: 0x040001A7 RID: 423
		DeathFromDegen,
		// Token: 0x040001A8 RID: 424
		DeathWhileMoving,
		// Token: 0x040001A9 RID: 425
		DeathForward,
		// Token: 0x040001AA RID: 426
		DeathBackward,
		// Token: 0x040001AB RID: 427
		DeathLeft,
		// Token: 0x040001AC RID: 428
		DeathRight,
		// Token: 0x040001AD RID: 429
		TakeHitForward,
		// Token: 0x040001AE RID: 430
		TakeHitBackward,
		// Token: 0x040001AF RID: 431
		TakeHitLeft,
		// Token: 0x040001B0 RID: 432
		TakeHitRight,
		// Token: 0x040001B1 RID: 433
		Warcry,
		// Token: 0x040001B2 RID: 434
		RunBackwards,
		// Token: 0x040001B3 RID: 435
		ChangeToStance5,
		// Token: 0x040001B4 RID: 436
		SummonMinion,
		// Token: 0x040001B5 RID: 437
		RunLeft,
		// Token: 0x040001B6 RID: 438
		RunRight,
		// Token: 0x040001B7 RID: 439
		ShieldBash,
		// Token: 0x040001B8 RID: 440
		ReviveFromDegen,
		// Token: 0x040001B9 RID: 441
		ReviveWhileMoving,
		// Token: 0x040001BA RID: 442
		ReviveForward,
		// Token: 0x040001BB RID: 443
		ReviveBackward,
		// Token: 0x040001BC RID: 444
		ReviveLeft,
		// Token: 0x040001BD RID: 445
		ReviveRight,
		// Token: 0x040001BE RID: 446
		Fling,
		// Token: 0x040001BF RID: 447
		ChargeEndLeft,
		// Token: 0x040001C0 RID: 448
		ChargeEndRight,
		// Token: 0x040001C1 RID: 449
		ChargeEnd180,
		// Token: 0x040001C2 RID: 450
		WhirlwindSpear,
		// Token: 0x040001C3 RID: 451
		SpearCleaveRight,
		// Token: 0x040001C4 RID: 452
		SpearCleaveLeft,
		// Token: 0x040001C5 RID: 453
		GuardedAssaultChannel,
		// Token: 0x040001C6 RID: 454
		GuardedAssaultChannelEnd,
		// Token: 0x040001C7 RID: 455
		SpearWall,
		// Token: 0x040001C8 RID: 456
		SpearWallMoving,
		// Token: 0x040001C9 RID: 457
		SpearDoubleThrow,
		// Token: 0x040001CA RID: 458
		FlinchForward,
		// Token: 0x040001CB RID: 459
		FlinchBackward,
		// Token: 0x040001CC RID: 460
		FlinchLeft,
		// Token: 0x040001CD RID: 461
		FlinchRight,
		// Token: 0x040001CE RID: 462
		ChangeAmmoDefault,
		// Token: 0x040001CF RID: 463
		ChangeAmmoDefaultMoving,
		// Token: 0x040001D0 RID: 464
		TreeToTreeJumpLeft,
		// Token: 0x040001D1 RID: 465
		TreeToTreeJumpRight,
		// Token: 0x040001D2 RID: 466
		TreeToVineJumpLeft,
		// Token: 0x040001D3 RID: 467
		TreeToVineJumpRight,
		// Token: 0x040001D4 RID: 468
		VineToTreeJump,
		// Token: 0x040001D5 RID: 469
		VineToVineJump,
		// Token: 0x040001D6 RID: 470
		TreeToGroundJumpLeft,
		// Token: 0x040001D7 RID: 471
		TreeToGroundJumpRight,
		// Token: 0x040001D8 RID: 472
		VineToGroundJumpLeft,
		// Token: 0x040001D9 RID: 473
		VineToGroundJumpRight,
		// Token: 0x040001DA RID: 474
		InteractPlaceGemstone,
		// Token: 0x040001DB RID: 475
		Chop,
		// Token: 0x040001DC RID: 476
		Slash,
		// Token: 0x040001DD RID: 477
		Sunder,
		// Token: 0x040001DE RID: 478
		FixedRun,
		// Token: 0x040001DF RID: 479
		WhirlingAssault,
		// Token: 0x040001E0 RID: 480
		LightningStrike,
		// Token: 0x040001E1 RID: 481
		DoubleSlam,
		// Token: 0x040001E2 RID: 482
		WeaponSpell,
		// Token: 0x040001E3 RID: 483
		EscapeShot,
		// Token: 0x040001E4 RID: 484
		FlaskDash,
		// Token: 0x040001E5 RID: 485
		InteractPullLever,
		// Token: 0x040001E6 RID: 486
		SpellNovaEpic,
		// Token: 0x040001E7 RID: 487
		SpellNovaEpicFire,
		// Token: 0x040001E8 RID: 488
		SpellNovaEpicCold,
		// Token: 0x040001E9 RID: 489
		SpellNovaEpicLightning,
		// Token: 0x040001EA RID: 490
		SpellNovaEpicChaos,
		// Token: 0x040001EB RID: 491
		SpreadShot,
		// Token: 0x040001EC RID: 492
		GaleStrike,
		// Token: 0x040001ED RID: 493
		BladeDance,
		// Token: 0x040001EE RID: 494
		ClawRake,
		// Token: 0x040001EF RID: 495
		DoubleSlamMoving,
		// Token: 0x040001F0 RID: 496
		DoubleSlamMovingNear,
		// Token: 0x040001F1 RID: 497
		LeapSlamMoving,
		// Token: 0x040001F2 RID: 498
		LeapSlamMovingNear,
		// Token: 0x040001F3 RID: 499
		GlacialStrikeChannel,
		// Token: 0x040001F4 RID: 500
		GlacialStrikeChannelEnd,
		// Token: 0x040001F5 RID: 501
		RingOfIce,
		// Token: 0x040001F6 RID: 502
		RingOfIceStatueWindup,
		// Token: 0x040001F7 RID: 503
		RingOfIceStatueAttack,
		// Token: 0x040001F8 RID: 504
		Execute,
		// Token: 0x040001F9 RID: 505
		LeapingChop,
		// Token: 0x040001FA RID: 506
		WhirlingSlash,
		// Token: 0x040001FB RID: 507
		RaisedChop,
		// Token: 0x040001FC RID: 508
		HeavyCleave,
		// Token: 0x040001FD RID: 509
		ThrowNear,
		// Token: 0x040001FE RID: 510
		ChannelUpward,
		// Token: 0x040001FF RID: 511
		ChannelUpwardEnd,
		// Token: 0x04000200 RID: 512
		ChannelProjectile,
		// Token: 0x04000201 RID: 513
		ChannelProjectileEnd,
		// Token: 0x04000202 RID: 514
		HeavyStun,
		// Token: 0x04000203 RID: 515
		HeavyStunBack,
		// Token: 0x04000204 RID: 516
		HeavyStunForward,
		// Token: 0x04000205 RID: 517
		HeavyStunDeath,
		// Token: 0x04000206 RID: 518
		HeavyStunBackDeath,
		// Token: 0x04000207 RID: 519
		HeavyStunForwardDeath,
		// Token: 0x04000208 RID: 520
		ShieldBuff,
		// Token: 0x04000209 RID: 521
		FlickerStrike,
		// Token: 0x0400020A RID: 522
		FlickerStrikeFirst,
		// Token: 0x0400020B RID: 523
		PalmStrike,
		// Token: 0x0400020C RID: 524
		Vortex,
		// Token: 0x0400020D RID: 525
		BackflipKnifeThrow,
		// Token: 0x0400020E RID: 526
		WeaponBuff,
		// Token: 0x0400020F RID: 527
		WeaponAreaOfEffect,
		// Token: 0x04000210 RID: 528
		BurstShot,
		// Token: 0x04000211 RID: 529
		SpellAoeEpic,
		// Token: 0x04000212 RID: 530
		SpellAoeEpicBackflip,
		// Token: 0x04000213 RID: 531
		SpellAoeEpicFire,
		// Token: 0x04000214 RID: 532
		SpellAoeEpicCold,
		// Token: 0x04000215 RID: 533
		SpellAoeEpicLightning,
		// Token: 0x04000216 RID: 534
		SpellAoeEpicChaos,
		// Token: 0x04000217 RID: 535
		BladeNova,
		// Token: 0x04000218 RID: 536
		SpellWall,
		// Token: 0x04000219 RID: 537
		SunderMoving,
		// Token: 0x0400021A RID: 538
		GroundSlamMoving,
		// Token: 0x0400021B RID: 539
		LightningStrikeStationary,
		// Token: 0x0400021C RID: 540
		LightningStrikeMoving,
		// Token: 0x0400021D RID: 541
		WeaponSwap,
		// Token: 0x0400021E RID: 542
		Meditate,
		// Token: 0x0400021F RID: 543
		MeditateEnd,
		// Token: 0x04000220 RID: 544
		SpellChannelEpicEnd,
		// Token: 0x04000221 RID: 545
		ElectrocuteForward,
		// Token: 0x04000222 RID: 546
		ElectrocuteBackward,
		// Token: 0x04000223 RID: 547
		ElectrocuteLeft,
		// Token: 0x04000224 RID: 548
		ElectrocuteRight,
		// Token: 0x04000225 RID: 549
		PestilentSlash,
		// Token: 0x04000226 RID: 550
		ViperStrike,
		// Token: 0x04000227 RID: 551
		DodgeRoll,
		// Token: 0x04000228 RID: 552
		IcePath,
		// Token: 0x04000229 RID: 553
		InteractPullLeverWallMounted,
		// Token: 0x0400022A RID: 554
		LeapingCatch,
		// Token: 0x0400022B RID: 555
		ShadowThiefSlash,
		// Token: 0x0400022C RID: 556
		PlungingBlade,
		// Token: 0x0400022D RID: 557
		PlungingBladeMoving,
		// Token: 0x0400022E RID: 558
		ShadowDash,
		// Token: 0x0400022F RID: 559
		ShadowDashStationary,
		// Token: 0x04000230 RID: 560
		BearMaul,
		// Token: 0x04000231 RID: 561
		BearMaulMoving,
		// Token: 0x04000232 RID: 562
		ShadowThiefSlashClone,
		// Token: 0x04000233 RID: 563
		ChannelVolcano,
		// Token: 0x04000234 RID: 564
		ChannelVolcanoShake,
		// Token: 0x04000235 RID: 565
		ChannelStart,
		// Token: 0x04000236 RID: 566
		SpiralVolley,
		// Token: 0x04000237 RID: 567
		SpiralVolleyEmpowered,
		// Token: 0x04000238 RID: 568
		HeatSeeking,
		// Token: 0x04000239 RID: 569
		HeatSeekingEnd,
		// Token: 0x0400023A RID: 570
		HeatSeekingStart,
		// Token: 0x0400023B RID: 571
		LeapAttack,
		// Token: 0x0400023C RID: 572
		LeapAttackFar,
		// Token: 0x0400023D RID: 573
		SummonMinionLightning,
		// Token: 0x0400023E RID: 574
		SummonMinionCold,
		// Token: 0x0400023F RID: 575
		SummonMinionFire,
		// Token: 0x04000240 RID: 576
		SummonMinionChaos,
		// Token: 0x04000241 RID: 577
		SpellWallLightning,
		// Token: 0x04000242 RID: 578
		SpellWallCold,
		// Token: 0x04000243 RID: 579
		SpellWallFire,
		// Token: 0x04000244 RID: 580
		SpellWallChaos,
		// Token: 0x04000245 RID: 581
		Spark,
		// Token: 0x04000246 RID: 582
		SparkAdditive,
		// Token: 0x04000247 RID: 583
		SparkInfused,
		// Token: 0x04000248 RID: 584
		Arc,
		// Token: 0x04000249 RID: 585
		IceNova,
		// Token: 0x0400024A RID: 586
		WhirlingAssaultMoving,
		// Token: 0x0400024B RID: 587
		RampageStart,
		// Token: 0x0400024C RID: 588
		RampageLoop,
		// Token: 0x0400024D RID: 589
		RampageEnd,
		// Token: 0x0400024E RID: 590
		FrostBomb,
		// Token: 0x0400024F RID: 591
		ComboAttack,
		// Token: 0x04000250 RID: 592
		ComboAttackMoving,
		// Token: 0x04000251 RID: 593
		LightningStorm,
		// Token: 0x04000252 RID: 594
		MinionSurplusDeath,
		// Token: 0x04000253 RID: 595
		MinionDiedAfterTime,
		// Token: 0x04000254 RID: 596
		UnleashBuff,
		// Token: 0x04000255 RID: 597
		JumpOffBoat,
		// Token: 0x04000256 RID: 598
		ExitRowboat,
		// Token: 0x04000257 RID: 599
		ShapeshiftBearToHuman,
		// Token: 0x04000258 RID: 600
		ShapeshiftBearMaul,
		// Token: 0x04000259 RID: 601
		ShapeshiftBearMaulMoving,
		// Token: 0x0400025A RID: 602
		ShapeshiftBearRampageStart,
		// Token: 0x0400025B RID: 603
		ShapeshiftBearRampageLoop,
		// Token: 0x0400025C RID: 604
		ShapeshiftBearSlam,
		// Token: 0x0400025D RID: 605
		ShapeshiftBearSlamEnraged,
		// Token: 0x0400025E RID: 606
		ShapeshiftBearWarcry,
		// Token: 0x0400025F RID: 607
		ShapeshiftWolfToHuman,
		// Token: 0x04000260 RID: 608
		ShapeshiftWolfHowl,
		// Token: 0x04000261 RID: 609
		ShapeshiftWolfLeapAttack,
		// Token: 0x04000262 RID: 610
		LookLeft,
		// Token: 0x04000263 RID: 611
		LookRight,
		// Token: 0x04000264 RID: 612
		ChannelVolcanoStart,
		// Token: 0x04000265 RID: 613
		Tornado,
		// Token: 0x04000266 RID: 614
		FungalTerrain,
		// Token: 0x04000267 RID: 615
		SummonWolf,
		// Token: 0x04000268 RID: 616
		LightningBolt,
		// Token: 0x04000269 RID: 617
		LightningBoltAdditive,
		// Token: 0x0400026A RID: 618
		InteractPlaceGemstoneJungleOutskirts,
		// Token: 0x0400026B RID: 619
		InteractPlaceGemstoneGenerator,
		// Token: 0x0400026C RID: 620
		WhirlwindSpearMoving,
		// Token: 0x0400026D RID: 621
		FrostWall,
		// Token: 0x0400026E RID: 622
		Comet,
		// Token: 0x0400026F RID: 623
		FoulEmergence,
		// Token: 0x04000270 RID: 624
		Engage,
		// Token: 0x04000271 RID: 625
		EngageFar,
		// Token: 0x04000272 RID: 626
		EngageFarMoving,
		// Token: 0x04000273 RID: 627
		BearSlam,
		// Token: 0x04000274 RID: 628
		BearSlamEnraged,
		// Token: 0x04000275 RID: 629
		CometStationary,
		// Token: 0x04000276 RID: 630
		CrushingEarth,
		// Token: 0x04000277 RID: 631
		CrushingEarthStationary,
		// Token: 0x04000278 RID: 632
		FoulEmergenceStationary,
		// Token: 0x04000279 RID: 633
		ManaTempest,
		// Token: 0x0400027A RID: 634
		DarkTempest,
		// Token: 0x0400027B RID: 635
		TownPortal,
		// Token: 0x0400027C RID: 636
		InteractStabPrison,
		// Token: 0x0400027D RID: 637
		ArcticArmour,
		// Token: 0x0400027E RID: 638
		Hex,
		// Token: 0x0400027F RID: 639
		Bladestorm,
		// Token: 0x04000280 RID: 640
		PhalanxBash,
		// Token: 0x04000281 RID: 641
		AdvancingWhirlLoop,
		// Token: 0x04000282 RID: 642
		AdvancingWhirlEnd,
		// Token: 0x04000283 RID: 643
		PowerShotDefault,
		// Token: 0x04000284 RID: 644
		PowerShotPiercing,
		// Token: 0x04000285 RID: 645
		PowerShotFire,
		// Token: 0x04000286 RID: 646
		PowerShotLightning,
		// Token: 0x04000287 RID: 647
		PowerShotIce,
		// Token: 0x04000288 RID: 648
		BurstShotDefault,
		// Token: 0x04000289 RID: 649
		BurstShotPiercing,
		// Token: 0x0400028A RID: 650
		BurstShotFire,
		// Token: 0x0400028B RID: 651
		BurstShotLightning,
		// Token: 0x0400028C RID: 652
		BurstShotIce,
		// Token: 0x0400028D RID: 653
		RapidShotDefault,
		// Token: 0x0400028E RID: 654
		RapidShotPiercing,
		// Token: 0x0400028F RID: 655
		RapidShotFire,
		// Token: 0x04000290 RID: 656
		RapidShotLightning,
		// Token: 0x04000291 RID: 657
		RapidShotIce,
		// Token: 0x04000292 RID: 658
		SiegeCascadeDefault,
		// Token: 0x04000293 RID: 659
		SiegeCascadePiercing,
		// Token: 0x04000294 RID: 660
		SiegeCascadeFire,
		// Token: 0x04000295 RID: 661
		SiegeCascadeLightning,
		// Token: 0x04000296 RID: 662
		SiegeCascadeIce,
		// Token: 0x04000297 RID: 663
		ChangeAmmoPiercing,
		// Token: 0x04000298 RID: 664
		ChangeAmmoFire,
		// Token: 0x04000299 RID: 665
		ChangeAmmoLightning,
		// Token: 0x0400029A RID: 666
		ChangeAmmoIce,
		// Token: 0x0400029B RID: 667
		ChangeAmmoPiercingMoving,
		// Token: 0x0400029C RID: 668
		ChangeAmmoFireMoving,
		// Token: 0x0400029D RID: 669
		ChangeAmmoLightningMoving,
		// Token: 0x0400029E RID: 670
		ChangeAmmoIceMoving,
		// Token: 0x0400029F RID: 671
		PowerShotLightningChannelEnd,
		// Token: 0x040002A0 RID: 672
		RaiseSpectre,
		// Token: 0x040002A1 RID: 673
		BindSpectre,
		// Token: 0x040002A2 RID: 674
		AimUp,
		// Token: 0x040002A3 RID: 675
		AimDown,
		// Token: 0x040002A4 RID: 676
		ExplosiveGrenade,
		// Token: 0x040002A5 RID: 677
		FlashGrenade,
		// Token: 0x040002A6 RID: 678
		ToxicGrenade,
		// Token: 0x040002A7 RID: 679
		OilGrenade,
		// Token: 0x040002A8 RID: 680
		ShockGrenade,
		// Token: 0x040002A9 RID: 681
		RaiseZombie,
		// Token: 0x040002AA RID: 682
		SummonSkeletonsEnd,
		// Token: 0x040002AB RID: 683
		RapidShotChargeFire,
		// Token: 0x040002AC RID: 684
		DodgeRollBack,
		// Token: 0x040002AD RID: 685
		RollingMagma,
		// Token: 0x040002AE RID: 686
		ShapeshiftRollingMagma,
		// Token: 0x040002AF RID: 687
		Firestorm,
		// Token: 0x040002B0 RID: 688
		CommandMinion,
		// Token: 0x040002B1 RID: 689
		SummonOffering,
		// Token: 0x040002B2 RID: 690
		TempestFlurry,
		// Token: 0x040002B3 RID: 691
		TempestFlurryMoving,
		// Token: 0x040002B4 RID: 692
		CommandMinionChannel,
		// Token: 0x040002B5 RID: 693
		CommandMinionChannelEnd,
		// Token: 0x040002B6 RID: 694
		ChargedStrike,
		// Token: 0x040002B7 RID: 695
		ChargedStrikeStationary,
		// Token: 0x040002B8 RID: 696
		ChargedStrikeFlourish,
		// Token: 0x040002B9 RID: 697
		TempestBellSlam,
		// Token: 0x040002BA RID: 698
		TempestBellSlamStationary,
		// Token: 0x040002BB RID: 699
		RapidAssault,
		// Token: 0x040002BC RID: 700
		IceSpear,
		// Token: 0x040002BD RID: 701
		StormSpear,
		// Token: 0x040002BE RID: 702
		FreezingBackflip,
		// Token: 0x040002BF RID: 703
		GlacialCascade,
		// Token: 0x040002C0 RID: 704
		ChargeStaff,
		// Token: 0x040002C1 RID: 705
		Chaosbolt,
		// Token: 0x040002C2 RID: 706
		Witchbolt,
		// Token: 0x040002C3 RID: 707
		Frostbolt,
		// Token: 0x040002C4 RID: 708
		BoneSpike,
		// Token: 0x040002C5 RID: 709
		BoneSpikeEnd,
		// Token: 0x040002C6 RID: 710
		Contagion,
		// Token: 0x040002C7 RID: 711
		EssenceDrain,
		// Token: 0x040002C8 RID: 712
		OrbOfIce,
		// Token: 0x040002C9 RID: 713
		Hexblast,
		// Token: 0x040002CA RID: 714
		ForbiddenRite,
		// Token: 0x040002CB RID: 715
		ForbiddenRiteEnd,
		// Token: 0x040002CC RID: 716
		ConsumeCorpse,
		// Token: 0x040002CD RID: 717
		WindPalm,
		// Token: 0x040002CE RID: 718
		BoneCone,
		// Token: 0x040002CF RID: 719
		FixedRunLayerBase,
		// Token: 0x040002D0 RID: 720
		FixedRunLayerNoTwist,
		// Token: 0x040002D1 RID: 721
		IdleLayerBase,
		// Token: 0x040002D2 RID: 722
		IdleLayerBaseStatic,
		// Token: 0x040002D3 RID: 723
		MeleeAdditive,
		// Token: 0x040002D4 RID: 724
		DetonatingArrow,
		// Token: 0x040002D5 RID: 725
		DetonatingArrowStart,
		// Token: 0x040002D6 RID: 726
		DetonatingArrowEnd,
		// Token: 0x040002D7 RID: 727
		LightningArrow,
		// Token: 0x040002D8 RID: 728
		ShockingArrow,
		// Token: 0x040002D9 RID: 729
		RipwireArrow,
		// Token: 0x040002DA RID: 730
		PoisonArrow,
		// Token: 0x040002DB RID: 731
		StormRain,
		// Token: 0x040002DC RID: 732
		Mark,
		// Token: 0x040002DD RID: 733
		SnipersMark,
		// Token: 0x040002DE RID: 734
		SnipersMarkFlipped,
		// Token: 0x040002DF RID: 735
		FixedRunLayerBaseSwitched,
		// Token: 0x040002E0 RID: 736
		FixedRunLayerNoTwistSwitched,
		// Token: 0x040002E1 RID: 737
		FixedRunLayerBaseFrontal,
		// Token: 0x040002E2 RID: 738
		FixedRunLayerNoTwistFrontal,
		// Token: 0x040002E3 RID: 739
		ElectrocutingArrow,
		// Token: 0x040002E4 RID: 740
		PerfectStrike,
		// Token: 0x040002E5 RID: 741
		PerfectStrikeEnd,
		// Token: 0x040002E6 RID: 742
		PerfectStrikePerfectEnd,
		// Token: 0x040002E7 RID: 743
		SolarOrb,
		// Token: 0x040002E8 RID: 744
		GreaterFireball,
		// Token: 0x040002E9 RID: 745
		Shatter,
		// Token: 0x040002EA RID: 746
		ShatteringSpite,
		// Token: 0x040002EB RID: 747
		VileDisruption,
		// Token: 0x040002EC RID: 748
		LightningWarp,
		// Token: 0x040002ED RID: 749
		ChannelFlameblast,
		// Token: 0x040002EE RID: 750
		ChannelFlameblastEnd,
		// Token: 0x040002EF RID: 751
		Flamewall,
		// Token: 0x040002F0 RID: 752
		FrozenOrb,
		// Token: 0x040002F1 RID: 753
		OrbOfStorms,
		// Token: 0x040002F2 RID: 754
		ShockingRemnants,
		// Token: 0x040002F3 RID: 755
		LightningConduit,
		// Token: 0x040002F4 RID: 756
		LightningConduitStationary,
		// Token: 0x040002F5 RID: 757
		Boneshatter,
		// Token: 0x040002F6 RID: 758
		ActiveBlockChannel,
		// Token: 0x040002F7 RID: 759
		ActiveBlockEnd,
		// Token: 0x040002F8 RID: 760
		ActiveBlockChannelMoving,
		// Token: 0x040002F9 RID: 761
		ActiveBlockEndMoving,
		// Token: 0x040002FA RID: 762
		GreaterFrostbolt,
		// Token: 0x040002FB RID: 763
		PlagueNova,
		// Token: 0x040002FC RID: 764
		ShieldDrum,
		// Token: 0x040002FD RID: 765
		ShieldDrumEnd,
		// Token: 0x040002FE RID: 766
		BaronSwordImpaledStart,
		// Token: 0x040002FF RID: 767
		BaronSwordImpaledLoop,
		// Token: 0x04000300 RID: 768
		BaronSwordImpaledEnd,
		// Token: 0x04000301 RID: 769
		PlaceTotemStomp,
		// Token: 0x04000302 RID: 770
		FlameblastOrbStart,
		// Token: 0x04000303 RID: 771
		FlameblastOrb,
		// Token: 0x04000304 RID: 772
		FlameblastOrbEnd,
		// Token: 0x04000305 RID: 773
		VineArrow,
		// Token: 0x04000306 RID: 774
		SnipeChannelEndPerfect,
		// Token: 0x04000307 RID: 775
		FreezingShards,
		// Token: 0x04000308 RID: 776
		VineRain,
		// Token: 0x04000309 RID: 777
		BoneshatterMoving,
		// Token: 0x0400030A RID: 778
		PowerSiphon,
		// Token: 0x0400030B RID: 779
		IdleLayerBaseSwitched,
		// Token: 0x0400030C RID: 780
		IdleLayerBaseStaticSwitched,
		// Token: 0x0400030D RID: 781
		VineArrowStationary,
		// Token: 0x0400030E RID: 782
		Mount,
		// Token: 0x0400030F RID: 783
		Dismount,
		// Token: 0x04000310 RID: 784
		MountedLayerIdleSync,
		// Token: 0x04000311 RID: 785
		MountedLayerRunSync,
		// Token: 0x04000312 RID: 786
		FixedIdle,
		// Token: 0x04000313 RID: 787
		FixedIdleLayerBase,
		// Token: 0x04000314 RID: 788
		VolcanicFissure,
		// Token: 0x04000315 RID: 789
		AssassinsMark,
		// Token: 0x04000316 RID: 790
		EssenceDrainAdditive,
		// Token: 0x04000317 RID: 791
		BoneRing,
		// Token: 0x04000318 RID: 792
		DetonateDead,
		// Token: 0x04000319 RID: 793
		SummonRagingSpirit,
		// Token: 0x0400031A RID: 794
		Vulnerability,
		// Token: 0x0400031B RID: 795
		Enfeeble,
		// Token: 0x0400031C RID: 796
		Despair,
		// Token: 0x0400031D RID: 797
		InteractUseHornOfTheVastiri,
		// Token: 0x0400031E RID: 798
		KnockdownStart,
		// Token: 0x0400031F RID: 799
		KnockdownLoop,
		// Token: 0x04000320 RID: 800
		KnockdownEnd,
		// Token: 0x04000321 RID: 801
		CorpseCloud,
		// Token: 0x04000322 RID: 802
		CommandMinionPoint,
		// Token: 0x04000323 RID: 803
		FlickerStrikeFirstMoving,
		// Token: 0x04000324 RID: 804
		DoryaniHumanBossCrystalTossLeft,
		// Token: 0x04000325 RID: 805
		DoryaniHumanBossCrystalTossRight,
		// Token: 0x04000326 RID: 806
		DoryaniHumanBossFlamethrower,
		// Token: 0x04000327 RID: 807
		DoryaniHumanBossLightningTendrils,
		// Token: 0x04000328 RID: 808
		Spearstorm,
		// Token: 0x04000329 RID: 809
		DoryaniHumanBossLightningZap,
		// Token: 0x0400032A RID: 810
		RaiseZombieAdditive,
		// Token: 0x0400032B RID: 811
		RemoteSpearMine,
		// Token: 0x0400032C RID: 812
		DoryaniHumanBossDodgeLeft,
		// Token: 0x0400032D RID: 813
		DoryaniHumanBossDodgeRight,
		// Token: 0x0400032E RID: 814
		DoryaniHumanBossFireball,
		// Token: 0x0400032F RID: 815
		DoryaniHumanBossFlameblastSelf,
		// Token: 0x04000330 RID: 816
		DoryaniHumanBossFlameblastTargeted,
		// Token: 0x04000331 RID: 817
		DoryaniHumanBossSolarOrb,
		// Token: 0x04000332 RID: 818
		DoryaniHumanBossSoulCoresArena,
		// Token: 0x04000333 RID: 819
		DoryaniHumanBossSoulCoresLeft,
		// Token: 0x04000334 RID: 820
		DoryaniHumanBossSoulCoresRight,
		// Token: 0x04000335 RID: 821
		SuperchargedSlam,
		// Token: 0x04000336 RID: 822
		SuperchargedSlamEnd,
		// Token: 0x04000337 RID: 823
		FloatIdle,
		// Token: 0x04000338 RID: 824
		FixedFloat,
		// Token: 0x04000339 RID: 825
		FloatRun,
		// Token: 0x0400033A RID: 826
		SpearLightningWarp,
		// Token: 0x0400033B RID: 827
		SpearLightningWarpNear,
		// Token: 0x0400033C RID: 828
		SpearWindVortex,
		// Token: 0x0400033D RID: 829
		Earthquake,
		// Token: 0x0400033E RID: 830
		RitualOfPower,
		// Token: 0x0400033F RID: 831
		SpellProjectileAimUp,
		// Token: 0x04000340 RID: 832
		SpellProjectileAimDown,
		// Token: 0x04000341 RID: 833
		CartIdle,
		// Token: 0x04000342 RID: 834
		CartJump,
		// Token: 0x04000343 RID: 835
		CommandSkeletalReavers,
		// Token: 0x04000344 RID: 836
		CommandSkeletalSniper,
		// Token: 0x04000345 RID: 837
		CommandSkeletalFrostMage,
		// Token: 0x04000346 RID: 838
		CommandSkeletalStormMage,
		// Token: 0x04000347 RID: 839
		CommandSkeletalArsonist,
		// Token: 0x04000348 RID: 840
		PlaceTotemSummon,
		// Token: 0x04000349 RID: 841
		WarcryAdditive,
		// Token: 0x0400034A RID: 842
		Flammability,
		// Token: 0x0400034B RID: 843
		Frostbite,
		// Token: 0x0400034C RID: 844
		Conductivity,
		// Token: 0x0400034D RID: 845
		TeleportForward,
		// Token: 0x0400034E RID: 846
		TeleportBackward,
		// Token: 0x0400034F RID: 847
		TeleportLeft,
		// Token: 0x04000350 RID: 848
		TeleportRight,
		// Token: 0x04000351 RID: 849
		BoneBlast,
		// Token: 0x04000352 RID: 850
		ManaDrain,
		// Token: 0x04000353 RID: 851
		VolatileDead,
		// Token: 0x04000354 RID: 852
		GalvanicField,
		// Token: 0x04000355 RID: 853
		Exsanguinate,
		// Token: 0x04000356 RID: 854
		ArcticBurst,
		// Token: 0x04000357 RID: 855
		EmpowerWand,
		// Token: 0x04000358 RID: 856
		Wither,
		// Token: 0x04000359 RID: 857
		WitherStart,
		// Token: 0x0400035A RID: 858
		WitherEnd,
		// Token: 0x0400035B RID: 859
		Spellslinger,
		// Token: 0x0400035C RID: 860
		LivingBomb,
		// Token: 0x0400035D RID: 861
		SigilOfPower,
		// Token: 0x0400035E RID: 862
		Soulrend,
		// Token: 0x0400035F RID: 863
		Reap,
		// Token: 0x04000360 RID: 864
		ReapMoving,
		// Token: 0x04000361 RID: 865
		ReapDash,
		// Token: 0x04000362 RID: 866
		WinnowingFlame,
		// Token: 0x04000363 RID: 867
		WinnowingFlameMoving,
		// Token: 0x04000364 RID: 868
		WinnowingFlameDash,
		// Token: 0x04000365 RID: 869
		IceStorm,
		// Token: 0x04000366 RID: 870
		ShockNova,
		// Token: 0x04000367 RID: 871
		ConsecratedGround,
		// Token: 0x04000368 RID: 872
		DarkPact,
		// Token: 0x04000369 RID: 873
		DarkPactSelf,
		// Token: 0x0400036A RID: 874
		SpinningInferno,
		// Token: 0x0400036B RID: 875
		SpinningInfernoMoving,
		// Token: 0x0400036C RID: 876
		MoltenBlast,
		// Token: 0x0400036D RID: 877
		MoltenBlastBackward,
		// Token: 0x0400036E RID: 878
		AncestralCry,
		// Token: 0x0400036F RID: 879
		ShieldingCry,
		// Token: 0x04000370 RID: 880
		HammerOfTheGods,
		// Token: 0x04000371 RID: 881
		ShieldBarricade,
		// Token: 0x04000372 RID: 882
		StampedeStart,
		// Token: 0x04000373 RID: 883
		StampedeStartMoving,
		// Token: 0x04000374 RID: 884
		Stampede,
		// Token: 0x04000375 RID: 885
		StampedeEnd,
		// Token: 0x04000376 RID: 886
		BallLightning,
		// Token: 0x04000377 RID: 887
		IncinerateStart,
		// Token: 0x04000378 RID: 888
		Incinerate,
		// Token: 0x04000379 RID: 889
		IncinerateEnd,
		// Token: 0x0400037A RID: 890
		EyeOfWinter,
		// Token: 0x0400037B RID: 891
		SeismicCry,
		// Token: 0x0400037C RID: 892
		InfernalCry,
		// Token: 0x0400037D RID: 893
		InteractPlaceTempleDoorKey,
		// Token: 0x0400037E RID: 894
		ArmourBreaker,
		// Token: 0x0400037F RID: 895
		ArmourBreakerMoving,
		// Token: 0x04000380 RID: 896
		ArmourBreakerShort,
		// Token: 0x04000381 RID: 897
		InteractWaterwaysFinalLever,
		// Token: 0x04000382 RID: 898
		InteractSacrificialHeartPlacement,
		// Token: 0x04000383 RID: 899
		InteractSacrificialHeartDestroy,
		// Token: 0x04000384 RID: 900
		MoltenSlam,
		// Token: 0x04000385 RID: 901
		FreezingMark,
		// Token: 0x04000386 RID: 902
		FreezingMarkFlipped,
		// Token: 0x04000387 RID: 903
		ToxicDomain,
		// Token: 0x04000388 RID: 904
		TornadoShot,
		// Token: 0x04000389 RID: 905
		LightningWall,
		// Token: 0x0400038A RID: 906
		IceShot,
		// Token: 0x0400038B RID: 907
		TrickShot,
		// Token: 0x0400038C RID: 908
		MagneticSalvo,
		// Token: 0x0400038D RID: 909
		FreezingSalvo,
		// Token: 0x0400038E RID: 910
		ChangeAmmoAfterFireDefault,
		// Token: 0x0400038F RID: 911
		ChangeAmmoAfterFireDefaultMoving,
		// Token: 0x04000390 RID: 912
		ChangeAmmoAfterFirePiercing,
		// Token: 0x04000391 RID: 913
		ChangeAmmoAfterFireFire,
		// Token: 0x04000392 RID: 914
		ChangeAmmoAfterFireLightning,
		// Token: 0x04000393 RID: 915
		ChangeAmmoAfterFireIce,
		// Token: 0x04000394 RID: 916
		ChangeAmmoAfterFirePiercingMoving,
		// Token: 0x04000395 RID: 917
		ChangeAmmoAfterFireFireMoving,
		// Token: 0x04000396 RID: 918
		ChangeAmmoAfterFireLightningMoving,
		// Token: 0x04000397 RID: 919
		ChangeAmmoAfterFireIceMoving,
		// Token: 0x04000398 RID: 920
		DoryaniHumanBossActivateMechanism,
		// Token: 0x04000399 RID: 921
		DoryaniHumanBossBeamBlast,
		// Token: 0x0400039A RID: 922
		BlazingCluster,
		// Token: 0x0400039B RID: 923
		ScatteringCalamity,
		// Token: 0x0400039C RID: 924
		VaultingImpact,
		// Token: 0x0400039D RID: 925
		VaultingImpactMoving,
		// Token: 0x0400039E RID: 926
		VaultingImpactShort,
		// Token: 0x0400039F RID: 927
		VaultingImpactMovingShort,
		// Token: 0x040003A0 RID: 928
		StormWave,
		// Token: 0x040003A1 RID: 929
		MantraOfDestruction,
		// Token: 0x040003A2 RID: 930
		DodgeRollMoveCancel,
		// Token: 0x040003A3 RID: 931
		DodgeRollBackMoveCancel,
		// Token: 0x040003A4 RID: 932
		WarBanner,
		// Token: 0x040003A5 RID: 933
		BreakingWave,
		// Token: 0x040003A6 RID: 934
		FreezingWord,
		// Token: 0x040003A7 RID: 935
		IceSpikes,
		// Token: 0x040003A8 RID: 936
		ThrowFlask,
		// Token: 0x040003A9 RID: 937
		VoltaicMark,
		// Token: 0x040003AA RID: 938
		VoltaicMarkFlipped,
		// Token: 0x040003AB RID: 939
		HandOfChayula,
		// Token: 0x040003AC RID: 940
		DefianceBanner,
		// Token: 0x040003AD RID: 941
		TemporalChains,
		// Token: 0x040003AE RID: 942
		InevitableAgony,
		// Token: 0x040003AF RID: 943
		PlayerBedIdle,
		// Token: 0x040003B0 RID: 944
		PlayerBedGetup,
		// Token: 0x040003B1 RID: 945
		TimeSnap,
		// Token: 0x040003B2 RID: 946
		SpellAreaOfEffectMoving,
		// Token: 0x040003B3 RID: 947
		DreadBanner,
		// Token: 0x040003B4 RID: 948
		PowerShotLightningCharge,
		// Token: 0x040003B5 RID: 949
		ShapeshiftHumanToDemon,
		// Token: 0x040003B6 RID: 950
		ShapeshiftDemonToHuman,
		// Token: 0x040003B7 RID: 951
		ClusterGrenade,
		// Token: 0x040003B8 RID: 952
		ThroneIdle,
		// Token: 0x040003B9 RID: 953
		ThroneSitDown,
		// Token: 0x040003BA RID: 954
		ThroneGetUp,
		// Token: 0x040003BB RID: 955
		ExplosiveConcoction,
		// Token: 0x040003BC RID: 956
		FulminatingConcoction,
		// Token: 0x040003BD RID: 957
		ShatteringConcoction,
		// Token: 0x040003BE RID: 958
		PoisonousConcoction,
		// Token: 0x040003BF RID: 959
		BleedingConcoction,
		// Token: 0x040003C0 RID: 960
		ThrowFlaskAimUpMainHand,
		// Token: 0x040003C1 RID: 961
		ThrowFlaskAimUpOffHand,
		// Token: 0x040003C2 RID: 962
		ThrowFlaskAimDownMainHand,
		// Token: 0x040003C3 RID: 963
		ThrowFlaskAimDownOffHand,
		// Token: 0x040003C4 RID: 964
		InteractSanctumHonourShrine,
		// Token: 0x040003C5 RID: 965
		BoatIdle,
		// Token: 0x040003C6 RID: 966
		PersistentIdleFemale,
		// Token: 0x040003C7 RID: 967
		PersistentIdleDemonSkill,
		// Token: 0x040003C8 RID: 968
		PersistentIdleDemonEmerge,
		// Token: 0x040003C9 RID: 969
		GatheringStorm,
		// Token: 0x040003CA RID: 970
		GatheringStormEnd,
		// Token: 0x040003CB RID: 971
		GatheringStormPerfectEnd,
		// Token: 0x040003CC RID: 972
		ShockwaveTotem,
		// Token: 0x040003CD RID: 973
		ShockwaveTotemFOW,
		// Token: 0x040003CE RID: 974
		FixedRunLayerBaseChannelBuff,
		// Token: 0x040003CF RID: 975
		Ascend,
		// Token: 0x040003D0 RID: 976
		AscendEnd,
		// Token: 0x040003D1 RID: 977
		DeliriumBossFireStart,
		// Token: 0x040003D2 RID: 978
		DeliriumBossFireLoop,
		// Token: 0x040003D3 RID: 979
		DeliriumBossFireEnd,
		// Token: 0x040003D4 RID: 980
		DeliriumBossLightningStart,
		// Token: 0x040003D5 RID: 981
		DeliriumBossLightningLoop,
		// Token: 0x040003D6 RID: 982
		DeliriumBossLightningEnd,
		// Token: 0x040003D7 RID: 983
		JadeArmour,
		// Token: 0x040003D8 RID: 984
		JadeArmourEnd,
		// Token: 0x040003D9 RID: 985
		InteractUltimatumPlaceSoulCore,
		// Token: 0x040003DA RID: 986
		TeleportStationary,
		// Token: 0x040003DB RID: 987
		TeleportBackStationary,
		// Token: 0x040003DC RID: 988
		Cataclysm,
		// Token: 0x040003DD RID: 989
		CataclysmLoop,
		// Token: 0x040003DE RID: 990
		IntroZombieStab,
		// Token: 0x040003DF RID: 991
		IdleLayerBaseStaticChannelBuff,
		// Token: 0x040003E0 RID: 992
		SanctumDeath,
		// Token: 0x040003E1 RID: 993
		FloatIdleLayer,
		// Token: 0x040003E2 RID: 994
		FloatHeightLayer,
		// Token: 0x040003E3 RID: 995
		FloatDodgeRoll,
		// Token: 0x040003E4 RID: 996
		FloatDodgeRollBack,
		// Token: 0x040003E5 RID: 997
		ShapeshiftWyvernToHuman,
		// Token: 0x040003E6 RID: 998
		HeadHuntHeartStab,
		// Token: 0x040003E7 RID: 999
		HeadHuntSelfStabMoving,
		// Token: 0x040003E8 RID: 1000
		EngageStationary,
		// Token: 0x040003E9 RID: 1001
		HeadHuntSelfStabStationary,
		// Token: 0x040003EA RID: 1002
		WindstormLance,
		// Token: 0x040003EB RID: 1003
		PrimalStrikes,
		// Token: 0x040003EC RID: 1004
		FrostWhirl,
		// Token: 0x040003ED RID: 1005
		SerpentSpear,
		// Token: 0x040003EE RID: 1006
		SerpentSpearMoving,
		// Token: 0x040003EF RID: 1007
		Rake,
		// Token: 0x040003F0 RID: 1008
		RakeShortDash,
		// Token: 0x040003F1 RID: 1009
		RakeStationary,
		// Token: 0x040003F2 RID: 1010
		SpearWindVortexMoving,
		// Token: 0x040003F3 RID: 1011
		ParryChannel,
		// Token: 0x040003F4 RID: 1012
		ParryEnd,
		// Token: 0x040003F5 RID: 1013
		PerfectParryEnd,
		// Token: 0x040003F6 RID: 1014
		OverchargedSpear,
		// Token: 0x040003F7 RID: 1015
		HuntersMark,
		// Token: 0x040003F8 RID: 1016
		HuntersMarkFlipped,
		// Token: 0x040003F9 RID: 1017
		TameBeast,
		// Token: 0x040003FA RID: 1018
		GraveCommand,
		// Token: 0x040003FB RID: 1019
		SolarisSpear,
		// Token: 0x040003FC RID: 1020
		ExtractElements,
		// Token: 0x040003FD RID: 1021
		BlazingLance,
		// Token: 0x040003FE RID: 1022
		SpearStanceSwitch,
		// Token: 0x040003FF RID: 1023
		MeleeCombo,
		// Token: 0x04000400 RID: 1024
		MeleeFire,
		// Token: 0x04000401 RID: 1025
		MeleeFireCombo,
		// Token: 0x04000402 RID: 1026
		MeleeCold,
		// Token: 0x04000403 RID: 1027
		MeleeColdCombo,
		// Token: 0x04000404 RID: 1028
		MeleeLightning,
		// Token: 0x04000405 RID: 1029
		MeleeLightningCombo,
		// Token: 0x04000406 RID: 1030
		MeleeChaos,
		// Token: 0x04000407 RID: 1031
		MeleeChaosCombo,
		// Token: 0x04000408 RID: 1032
		InfusingStrike,
		// Token: 0x04000409 RID: 1033
		InfusingStrikeMoving,
		// Token: 0x0400040A RID: 1034
		Haunt,
		// Token: 0x0400040B RID: 1035
		BasicSpearThrow,
		// Token: 0x0400040C RID: 1036
		InteractHandCut,
		// Token: 0x0400040D RID: 1037
		SpectreDeath,
		// Token: 0x0400040E RID: 1038
		SpectreSurplusDeath,
		// Token: 0x0400040F RID: 1039
		ChannelImbueWeapon,
		// Token: 0x04000410 RID: 1040
		ChannelImbueWeaponEnd,
		// Token: 0x04000411 RID: 1041
		FixedIdleLayerBaseMountedAlt,
		// Token: 0x04000412 RID: 1042
		Convalescence,
		// Token: 0x04000413 RID: 1043
		Firebolt,
		// Token: 0x04000414 RID: 1044
		ConsumePet,
		// Token: 0x04000415 RID: 1045
		WingBlast,
		// Token: 0x04000416 RID: 1046
		ShapeshiftWingBlast,
		// Token: 0x04000417 RID: 1047
		WingBlastEmpowered,
		// Token: 0x04000418 RID: 1048
		ShapeshiftWingBlastEmpowered,
		// Token: 0x04000419 RID: 1049
		FrenziedLunge,
		// Token: 0x0400041A RID: 1050
		FrenziedLungeMoving,
		// Token: 0x0400041B RID: 1051
		ShapeshiftTreeToHuman,
		// Token: 0x0400041C RID: 1052
		TreeWhip,
		// Token: 0x0400041D RID: 1053
		ShapeshiftTreeWhip,
		// Token: 0x0400041E RID: 1054
		ShapeshiftFallback,
		// Token: 0x0400041F RID: 1055
		WyvernSwipe,
		// Token: 0x04000420 RID: 1056
		ShapeshiftWyvernSwipe,
		// Token: 0x04000421 RID: 1057
		WyvernEmpoweredSwipe,
		// Token: 0x04000422 RID: 1058
		ShapeshiftWyvernEmpoweredSwipe,
		// Token: 0x04000423 RID: 1059
		WyvernSwipeMoving,
		// Token: 0x04000424 RID: 1060
		ShapeshiftWyvernSwipeMoving,
		// Token: 0x04000425 RID: 1061
		WyvernEmpoweredSwipeMoving,
		// Token: 0x04000426 RID: 1062
		ShapeshiftWyvernEmpoweredSwipeMoving,
		// Token: 0x04000427 RID: 1063
		WyvernSwipeFar,
		// Token: 0x04000428 RID: 1064
		ShapeshiftWyvernSwipeFar,
		// Token: 0x04000429 RID: 1065
		WyvernEmpoweredSwipeFar,
		// Token: 0x0400042A RID: 1066
		ShapeshiftWyvernEmpoweredSwipeFar,
		// Token: 0x0400042B RID: 1067
		WyvernSwipeMovingFar,
		// Token: 0x0400042C RID: 1068
		ShapeshiftWyvernSwipeMovingFar,
		// Token: 0x0400042D RID: 1069
		WyvernEmpoweredSwipeMovingFar,
		// Token: 0x0400042E RID: 1070
		ShapeshiftWyvernEmpoweredSwipeMovingFar,
		// Token: 0x0400042F RID: 1071
		ElectricSpit,
		// Token: 0x04000430 RID: 1072
		ShapeshiftElectricSpit,
		// Token: 0x04000431 RID: 1073
		DodgeRollSprint,
		// Token: 0x04000432 RID: 1074
		WyvernFlameBreathStart,
		// Token: 0x04000433 RID: 1075
		ShapeshiftWyvernFlameBreathStart,
		// Token: 0x04000434 RID: 1076
		WyvernFlameBreathAttack,
		// Token: 0x04000435 RID: 1077
		WyvernFlameBreathEnd,
		// Token: 0x04000436 RID: 1078
		ShapeshiftWyvernFlameBreathAttack,
		// Token: 0x04000437 RID: 1079
		ShapeshiftWyvernFlameBreathAttackEmpowered,
		// Token: 0x04000438 RID: 1080
		WardingSteel,
		// Token: 0x04000439 RID: 1081
		FixedRunLayerBaseForward,
		// Token: 0x0400043A RID: 1082
		FixedRunLayerBaseBackward,
		// Token: 0x0400043B RID: 1083
		DodgeRollBackSprint,
		// Token: 0x0400043C RID: 1084
		BearFuryOfTheMountainStart,
		// Token: 0x0400043D RID: 1085
		BearFuryOfTheMountainStartMoving,
		// Token: 0x0400043E RID: 1086
		BearFuryOfTheMountainLoop,
		// Token: 0x0400043F RID: 1087
		BearFuryOfTheMountainEndLeft,
		// Token: 0x04000440 RID: 1088
		BearFuryOfTheMountainEndRight,
		// Token: 0x04000441 RID: 1089
		ShapeshiftBearFuryOfTheMountainStart,
		// Token: 0x04000442 RID: 1090
		ShapeshiftBearFuryOfTheMountainStartMoving,
		// Token: 0x04000443 RID: 1091
		ShapeshiftBearFuryOfTheMountainLoop,
		// Token: 0x04000444 RID: 1092
		RapidShotRequiem,
		// Token: 0x04000445 RID: 1093
		ChangeAmmoRequiem,
		// Token: 0x04000446 RID: 1094
		ChangeAmmoRequiemMoving,
		// Token: 0x04000447 RID: 1095
		ChangeAmmoAfterFireRequiem,
		// Token: 0x04000448 RID: 1096
		ChangeAmmoAfterFireRequiemMoving,
		// Token: 0x04000449 RID: 1097
		Entangle,
		// Token: 0x0400044A RID: 1098
		ElementalPower,
		// Token: 0x0400044B RID: 1099
		WyvernDevour,
		// Token: 0x0400044C RID: 1100
		ShapeshiftWyvernDevour,
		// Token: 0x0400044D RID: 1101
		WyvernDevourMid,
		// Token: 0x0400044E RID: 1102
		ShapeshiftWyvernDevourMid,
		// Token: 0x0400044F RID: 1103
		WyvernDevourFar,
		// Token: 0x04000450 RID: 1104
		ShapeshiftWyvernDevourFar,
		// Token: 0x04000451 RID: 1105
		WyvernDevourEnd,
		// Token: 0x04000452 RID: 1106
		AwakenedForest,
		// Token: 0x04000453 RID: 1107
		WyvernFlameBreathStartEmpowered,
		// Token: 0x04000454 RID: 1108
		ShapeshiftWyvernFlameBreathStartEmpowered,
		// Token: 0x04000455 RID: 1109
		WyvernFlameBreathAttackEmpowered,
		// Token: 0x04000456 RID: 1110
		WyvernFlameBreathEndEmpowered,
		// Token: 0x04000457 RID: 1111
		ElectricSpitEmpowered,
		// Token: 0x04000458 RID: 1112
		ShapeshiftElectricSpitEmpowered,
		// Token: 0x04000459 RID: 1113
		FrozenClaws,
		// Token: 0x0400045A RID: 1114
		ShapeshiftFrozenClaws,
		// Token: 0x0400045B RID: 1115
		LunarAssault,
		// Token: 0x0400045C RID: 1116
		ShapeshiftLunarAssault,
		// Token: 0x0400045D RID: 1117
		CrossSlash,
		// Token: 0x0400045E RID: 1118
		ShapeshiftCrossSlash,
		// Token: 0x0400045F RID: 1119
		LunarBlessing,
		// Token: 0x04000460 RID: 1120
		ShapeshiftLunarBlessing,
		// Token: 0x04000461 RID: 1121
		TurnaroundLeft,
		// Token: 0x04000462 RID: 1122
		TurnaroundRight,
		// Token: 0x04000463 RID: 1123
		TundraHunter,
		// Token: 0x04000464 RID: 1124
		ShapeshiftTundraHunter,
		// Token: 0x04000465 RID: 1125
		FrozenClawsDash,
		// Token: 0x04000466 RID: 1126
		ShapeshiftFrozenClawsDash,
		// Token: 0x04000467 RID: 1127
		FlameLink,
		// Token: 0x04000468 RID: 1128
		SoulLink,
		// Token: 0x04000469 RID: 1129
		ForgeHammer,
		// Token: 0x0400046A RID: 1130
		ForgeHammerRecall,
		// Token: 0x0400046B RID: 1131
		GrimFeastResummon,
		// Token: 0x0400046C RID: 1132
		FeastOfFlesh,
		// Token: 0x0400046D RID: 1133
		InteractSit,
		// Token: 0x0400046E RID: 1134
		ShearingBolts,
		// Token: 0x0400046F RID: 1135
		ResurrectAbyssForward,
		// Token: 0x04000470 RID: 1136
		ResurrectAbyssBackward,
		// Token: 0x04000471 RID: 1137
		ResurrectAbyssLeft,
		// Token: 0x04000472 RID: 1138
		ResurrectAbyssRight,
		// Token: 0x04000473 RID: 1139
		CannonDodgeRoll,
		// Token: 0x04000474 RID: 1140
		CannonDodgeRollBack,
		// Token: 0x04000475 RID: 1141
		CannonFloatDodgeRoll,
		// Token: 0x04000476 RID: 1142
		CannonFloatDodgeRollBack,
		// Token: 0x04000477 RID: 1143
		AbyssThrowItems,
		// Token: 0x04000478 RID: 1144
		AbyssJump,
		// Token: 0x04000479 RID: 1145
		Sprint,
		// Token: 0x0400047A RID: 1146
		DealersHandDraw,
		// Token: 0x0400047B RID: 1147
		SprintEnd,
		// Token: 0x0400047C RID: 1148
		SprintEndBonk,
		// Token: 0x0400047D RID: 1149
		ChannelRunicTempering,
		// Token: 0x0400047E RID: 1150
		ChannelRunicTemperingEnd,
		// Token: 0x0400047F RID: 1151
		FloatDodgeRollSprint,
		// Token: 0x04000480 RID: 1152
		FloatDodgeRollBackSprint,
		// Token: 0x04000481 RID: 1153
		FloatSprint,
		// Token: 0x04000482 RID: 1154
		FloatSprintEnd,
		// Token: 0x04000483 RID: 1155
		FloatSprintEndBonk,
		// Token: 0x04000484 RID: 1156
		HeavyStunForesight,
		// Token: 0x04000485 RID: 1157
		FrostDart,
		// Token: 0x04000486 RID: 1158
		CommandSkeletalBrute,
		// Token: 0x04000487 RID: 1159
		RavenousSwarmAttackAggro,
		// Token: 0x04000488 RID: 1160
		TeleportSprintStart,
		// Token: 0x04000489 RID: 1161
		TeleportBackSprintStart,
		// Token: 0x0400048A RID: 1162
		ElementalWeakness,
		// Token: 0x0400048B RID: 1163
		InteractLeanWellStart,
		// Token: 0x0400048C RID: 1164
		InteractLeanWell,
		// Token: 0x0400048D RID: 1165
		InteractLeanWellEnd,
		// Token: 0x0400048E RID: 1166
		InteractPresentObject,
		// Token: 0x0400048F RID: 1167
		FloatTeleportSprintStart,
		// Token: 0x04000490 RID: 1168
		FloatTeleportBackSprintStart,
		// Token: 0x04000491 RID: 1169
		InteractPresentObjectAbyss,
		// Token: 0x04000492 RID: 1170
		PlayerKnockedDownIdle,
		// Token: 0x04000493 RID: 1171
		PlayerKnockedDownGetUp,
		// Token: 0x04000494 RID: 1172
		InteractKneelWorship,
		// Token: 0x04000495 RID: 1173
		KnockdownAltStart,
		// Token: 0x04000496 RID: 1174
		KnockdownAltLoop,
		// Token: 0x04000497 RID: 1175
		KnockdownAltEnd,
		// Token: 0x04000498 RID: 1176
		AbyssDive,
		// Token: 0x04000499 RID: 1177
		FloatTeleportForward,
		// Token: 0x0400049A RID: 1178
		FloatTeleportBackward,
		// Token: 0x0400049B RID: 1179
		BodyLookLeft,
		// Token: 0x0400049C RID: 1180
		BodyLookRight,
		// Token: 0x0400049D RID: 1181
		Landslide,
		// Token: 0x0400049E RID: 1182
		ShapeshiftLandslide,
		// Token: 0x0400049F RID: 1183
		WolfPounce,
		// Token: 0x040004A0 RID: 1184
		ShapeshiftWolfPounce,
		// Token: 0x040004A1 RID: 1185
		PrimalAvatarAction,
		// Token: 0x040004A2 RID: 1186
		Commanded,
		// Token: 0x040004A3 RID: 1187
		ShapeshiftToBear,
		// Token: 0x040004A4 RID: 1188
		ShapeshiftToBearStanding,
		// Token: 0x040004A5 RID: 1189
		ShapeshiftToWolf,
		// Token: 0x040004A6 RID: 1190
		ShapeshiftToWyvern,
		// Token: 0x040004A7 RID: 1191
		ElectricSpitStart,
		// Token: 0x040004A8 RID: 1192
		ElectricSpitStartForward,
		// Token: 0x040004A9 RID: 1193
		ElectricSpitStartBackward,
		// Token: 0x040004AA RID: 1194
		ShapeshiftElectricSpitStart,
		// Token: 0x040004AB RID: 1195
		ShapeshiftElectricSpitStartForward,
		// Token: 0x040004AC RID: 1196
		ShapeshiftElectricSpitStartBackward,
		// Token: 0x040004AD RID: 1197
		ElectricSpitLoop,
		// Token: 0x040004AE RID: 1198
		ElectricSpitEnd,
		// Token: 0x040004AF RID: 1199
		ElectricSpitStartEmpowered,
		// Token: 0x040004B0 RID: 1200
		ElectricSpitStartForwardEmpowered,
		// Token: 0x040004B1 RID: 1201
		ElectricSpitStartBackwardEmpowered,
		// Token: 0x040004B2 RID: 1202
		ShapeshiftElectricSpitStartEmpowered,
		// Token: 0x040004B3 RID: 1203
		ShapeshiftElectricSpitStartForwardEmpowered,
		// Token: 0x040004B4 RID: 1204
		ShapeshiftElectricSpitStartBackwardEmpowered,
		// Token: 0x040004B5 RID: 1205
		ElectricSpitLoopEmpowered,
		// Token: 0x040004B6 RID: 1206
		ElectricSpitEndEmpowered,
		// Token: 0x040004B7 RID: 1207
		WildBeast,
		// Token: 0x040004B8 RID: 1208
		ShapeshiftElectricSpitLoop,
		// Token: 0x040004B9 RID: 1209
		ShapeshiftElectricSpitLoopEmpowered,
		// Token: 0x040004BA RID: 1210
		MeleeDashAttack,
		// Token: 0x040004BB RID: 1211
		BiteLungeMelee,
		// Token: 0x040004BC RID: 1212
		WildBeastBear,
		// Token: 0x040004BD RID: 1213
		WildBeastWolf,
		// Token: 0x040004BE RID: 1214
		WildBeastWyvern,
		// Token: 0x040004BF RID: 1215
		BearWarcry,
		// Token: 0x040004C0 RID: 1216
		AnimatedMove,
		// Token: 0x040004C1 RID: 1217
		AnimatedMoveStart,
		// Token: 0x040004C2 RID: 1218
		AnimatedMoveEnd,
		// Token: 0x040004C3 RID: 1219
		RipFromTime,
		// Token: 0x040004C4 RID: 1220
		PlaceTotemStompMoving,
		// Token: 0x040004C5 RID: 1221
		OperationBenchStart,
		// Token: 0x040004C6 RID: 1222
		OperationBenchLoop,
		// Token: 0x040004C7 RID: 1223
		OperationBenchEnd,
		// Token: 0x040004C8 RID: 1224
		UnleashTheElements,
		// Token: 0x040004C9 RID: 1225
		WalkingCalamity,
		// Token: 0x040004CA RID: 1226
		ShapeshiftWalkingCalamity,
		// Token: 0x040004CB RID: 1227
		InteractAtziriTreasure,
		// Token: 0x040004CC RID: 1228
		EmoteWave,
		// Token: 0x040004CD RID: 1229
		EmoteLaugh,
		// Token: 0x040004CE RID: 1230
		EmoteClap,
		// Token: 0x040004CF RID: 1231
		EmoteBow,
		// Token: 0x040004D0 RID: 1232
		EmoteDisrespect,
		// Token: 0x040004D1 RID: 1233
		EmoteThreaten,
		// Token: 0x040004D2 RID: 1234
		SavageFury,
		// Token: 0x040004D3 RID: 1235
		ShapeshiftSavageFury,
		// Token: 0x040004D4 RID: 1236
		ShapeshiftToHumanStandalone,
		// Token: 0x040004D5 RID: 1237
		BearDodgeRolyPoly
	}
}
