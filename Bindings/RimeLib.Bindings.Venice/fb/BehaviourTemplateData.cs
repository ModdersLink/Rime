///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class BehaviourTemplateData : 
		GameBehaviourTemplateData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float StandProbability { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float CrouchProbability { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float TurnAgainstTargetDistance { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float InvestigateStopDelay { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ExplosiveObjectChance { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint MinAttackBursts { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint MaxAttackBursts { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float AttackUrgencyModifier { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float AltAttackProbability { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float ReadinessReactionTimeMultiplier { get; set; } // 0x30 (48)
		
		[ContainerField(52)]
		public UIntRange FireBlindOverBurstCount { get; set; } = new UIntRange(); // 0x34 (52)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float CloseRangeAccuracyDistanceOverride { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float MeleeRange { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float MeleeMaxTime { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float MeleeProbability { get; set; } // 0x48 (72)
		
		[ContainerField(76)]
		public FloatRangeDefaultZero CoverSwitchTime { get; set; } = new FloatRangeDefaultZero(); // 0x4C (76)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float FireStyleTimeout { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float FireLeanChance { get; set; } // 0x58 (88)
		
		[ContainerField(92)]
		public UIntRange FireLeanBurstCount { get; set; } = new UIntRange(); // 0x5C (92)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float FireStepOutChance { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public UIntRange FireStepOutBurstCount { get; set; } = new UIntRange(); // 0x68 (104)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float FireStepOutSlowChance { get; set; } // 0x70 (112)
		
		[ContainerField(116)]
		public UIntRange FireStepOutSlowBurstCount { get; set; } = new UIntRange(); // 0x74 (116)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float FireStepOutUrgentChance { get; set; } // 0x7C (124)
		
		[ContainerField(128)]
		public UIntRange FireStepOutUrgentBurstCount { get; set; } = new UIntRange(); // 0x80 (128)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float FireStepOutFireFromHipChance { get; set; } // 0x88 (136)
		
		[ContainerField(140)]
		public UIntRange FireStepOutFireFromHipBurstCount { get; set; } = new UIntRange(); // 0x8C (140)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float FireStepOutStandToCrouchChance { get; set; } // 0x94 (148)
		
		[ContainerField(152)]
		public UIntRange FireStepOutStandToCrouchBurstCount { get; set; } = new UIntRange(); // 0x98 (152)
		
		[ContainerField(160)]
		public CoverFireType AlwaysInFirePose { get; set; } = new CoverFireType(); // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float FireGrenadeStepOutChance { get; set; } // 0xA4 (164)
		
		[ContainerField(168)]
		public UIntRange FireGrenadeStepOutBurstCount { get; set; } = new UIntRange(); // 0xA8 (168)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float FireOverChance { get; set; } // 0xB0 (176)
		
		[ContainerField(180)]
		public UIntRange FireOverBurstCount { get; set; } = new UIntRange(); // 0xB4 (180)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float FireBlindOutChance { get; set; } // 0xBC (188)
		
		[ContainerField(192)]
		public UIntRange FireBlindOutBurstCount { get; set; } = new UIntRange(); // 0xC0 (192)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float FireBlindOverChance { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public int SuppressingBurstCount { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float FireGrenadeBlindOverChance { get; set; } // 0xD0 (208)
		
		[ContainerField(212)]
		public UIntRange FireGrenadeBlindOverBurstCount { get; set; } = new UIntRange(); // 0xD4 (212)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float FireLmgChance { get; set; } // 0xDC (220)
		
		[ContainerField(224)]
		public UIntRange FireLmgBurstCount { get; set; } = new UIntRange(); // 0xE0 (224)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public float ShotAtFireGrenadeBlindOverChance { get; set; } // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public int SuppressingBurstCountMin { get; set; } // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public int SuppressingBurstCountMax { get; set; } // 0xF0 (240)
		
		[ContainerField(244)]
		public FloatRange CoverWaitTime { get; set; } = new FloatRange(); // 0xF4 (244)
		
		[ContainerField(252), LayoutImmutable, Blittable]
		public float MaxAngleDiffForBlindFire { get; set; } // 0xFC (252)
		
		[ContainerField(256), LayoutImmutable, Blittable]
		public float StrafeToCoverProbablity { get; set; } // 0x100 (256)
		
		[ContainerField(260), LayoutImmutable, Blittable]
		public float MaxSuppressTime { get; set; } // 0x104 (260)
		
		[ContainerField(264), LayoutImmutable, Blittable]
		public float InvestigateVisualTestDist { get; set; } // 0x108 (264)
		
		[ContainerField(268), LayoutImmutable, Blittable]
		public float AlwaysStrafeToCoversWithinDistance { get; set; } // 0x10C (268)
		
		[ContainerField(272), LayoutImmutable, Blittable]
		public float ChargeSurpriseVelocity { get; set; } // 0x110 (272)
		
		[ContainerField(276), LayoutImmutable, Blittable]
		public float ChargeSurpriseNearDistance { get; set; } // 0x114 (276)
		
		[ContainerField(280), LayoutImmutable, Blittable]
		public float ChargeSurpriseFlankedDistance { get; set; } // 0x118 (280)
		
		[ContainerField(284), LayoutImmutable, Blittable]
		public float ShotAtFireBlindOutChance { get; set; } // 0x11C (284)
		
		[ContainerField(288), LayoutImmutable, Blittable]
		public float ShotAtFireBlindOverChance { get; set; } // 0x120 (288)
		
		[ContainerField(292), LayoutImmutable, Blittable]
		public float AccuracyIncreaseTime { get; set; } // 0x124 (292)
		
		[ContainerField(296), LayoutImmutable, Blittable]
		public float TargetStrengthFactor { get; set; } // 0x128 (296)
		
		[ContainerField(300), LayoutImmutable, Blittable]
		public float ReloadBelowPercent { get; set; } // 0x12C (300)
		
		[ContainerField(304), LayoutImmutable, Blittable]
		public float TargetDistanceFactor { get; set; } // 0x130 (304)
		
		[ContainerField(308), LayoutImmutable, Blittable]
		public float SuppressIndirectProbability { get; set; } // 0x134 (308)
		
		[ContainerField(312), LayoutImmutable, Blittable]
		public float TargetDangerFactor { get; set; } // 0x138 (312)
		
		[ContainerField(316), LayoutImmutable, Blittable]
		public float TargetIsAttackingFactor { get; set; } // 0x13C (316)
		
		[ContainerField(320), LayoutImmutable, Blittable]
		public float AccuracyModifierVsNonHumans { get; set; } // 0x140 (320)
		
		[ContainerField(324), LayoutImmutable, Blittable]
		public float AccuracyModifier { get; set; } // 0x144 (324)
		
		[ContainerField(328), LayoutImmutable, Blittable]
		public float SoldierMovementVolumeOverride { get; set; } // 0x148 (328)
		
		[ContainerField(332), LayoutImmutable, Blittable]
		public bool AlwaysUpdate { get; set; } // 0x14C (332)
		
		[ContainerField(333), LayoutImmutable, Blittable]
		public bool LeaveVehicleOnSearchAndDestroyOrder { get; set; } // 0x14D (333)
		
		[ContainerField(334), LayoutImmutable, Blittable]
		public bool ShouldFireThroughSmoke { get; set; } // 0x14E (334)
		
		[ContainerField(335), LayoutImmutable, Blittable]
		public bool AlwaysStrafeToFirstCover { get; set; } // 0x14F (335)
		
		[ContainerField(336), LayoutImmutable, Blittable]
		public bool CanMeleeFromScriptedCover { get; set; } // 0x150 (336)
		
		[ContainerField(337), LayoutImmutable, Blittable]
		public bool AlwaysStrafeToCoversBehindMe { get; set; } // 0x151 (337)
		
		[ContainerField(338), LayoutImmutable, Blittable]
		public bool UseShotAtSettings { get; set; } // 0x152 (338)
		
		[ContainerField(339), LayoutImmutable, Blittable]
		public bool StepBackIfBeingShot { get; set; } // 0x153 (339)
		
		[ContainerField(340), LayoutImmutable, Blittable]
		public bool DisableMissileGravity { get; set; } // 0x154 (340)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2246572228:
					StandProbability = (float) p_Value;
					break;

				case 106078632:
					CrouchProbability = (float) p_Value;
					break;

				case 2785468173:
					TurnAgainstTargetDistance = (float) p_Value;
					break;

				case 3076243205:
					InvestigateStopDelay = (float) p_Value;
					break;

				case 1925970549:
					ExplosiveObjectChance = (float) p_Value;
					break;

				case 1048477270:
					MinAttackBursts = (uint) p_Value;
					break;

				case 2789865160:
					MaxAttackBursts = (uint) p_Value;
					break;

				case 1339312363:
					AttackUrgencyModifier = (float) p_Value;
					break;

				case 4293933145:
					AltAttackProbability = (float) p_Value;
					break;

				case 2192704706:
					ReadinessReactionTimeMultiplier = (float) p_Value;
					break;

				case 3205426975:
					FireBlindOverBurstCount = (UIntRange) p_Value;
					break;

				case 1917637638:
					CloseRangeAccuracyDistanceOverride = (float) p_Value;
					break;

				case 960532638:
					MeleeRange = (float) p_Value;
					break;

				case 3607661600:
					MeleeMaxTime = (float) p_Value;
					break;

				case 1871998476:
					MeleeProbability = (float) p_Value;
					break;

				case 3956228463:
					CoverSwitchTime = (FloatRangeDefaultZero) p_Value;
					break;

				case 3698926705:
					FireStyleTimeout = (float) p_Value;
					break;

				case 2963103673:
					FireLeanChance = (float) p_Value;
					break;

				case 737987738:
					FireLeanBurstCount = (UIntRange) p_Value;
					break;

				case 1614197955:
					FireStepOutChance = (float) p_Value;
					break;

				case 206337888:
					FireStepOutBurstCount = (UIntRange) p_Value;
					break;

				case 4253321444:
					FireStepOutSlowChance = (float) p_Value;
					break;

				case 1727148359:
					FireStepOutSlowBurstCount = (UIntRange) p_Value;
					break;

				case 4064538876:
					FireStepOutUrgentChance = (float) p_Value;
					break;

				case 452711775:
					FireStepOutUrgentBurstCount = (UIntRange) p_Value;
					break;

				case 2484763260:
					FireStepOutFireFromHipChance = (float) p_Value;
					break;

				case 1878728415:
					FireStepOutFireFromHipBurstCount = (UIntRange) p_Value;
					break;

				case 3237569684:
					FireStepOutStandToCrouchChance = (float) p_Value;
					break;

				case 1054344887:
					FireStepOutStandToCrouchBurstCount = (UIntRange) p_Value;
					break;

				case 3257836322:
					AlwaysInFirePose = (CoverFireType) Enum.ToObject(typeof(CoverFireType), p_Value);
					break;

				case 538888317:
					FireGrenadeStepOutChance = (float) p_Value;
					break;

				case 2890954334:
					FireGrenadeStepOutBurstCount = (UIntRange) p_Value;
					break;

				case 4010500561:
					FireOverChance = (float) p_Value;
					break;

				case 3580603250:
					FireOverBurstCount = (UIntRange) p_Value;
					break;

				case 73996732:
					FireBlindOutChance = (float) p_Value;
					break;

				case 682065439:
					FireBlindOutBurstCount = (UIntRange) p_Value;
					break;

				case 1455426236:
					FireBlindOverChance = (float) p_Value;
					break;

				case 2130576437:
					SuppressingBurstCount = (int) p_Value;
					break;

				case 1822898498:
					FireGrenadeBlindOverChance = (float) p_Value;
					break;

				case 788190561:
					FireGrenadeBlindOverBurstCount = (UIntRange) p_Value;
					break;

				case 4038590905:
					FireLmgChance = (float) p_Value;
					break;

				case 1553493658:
					FireLmgBurstCount = (UIntRange) p_Value;
					break;

				case 525072119:
					ShotAtFireGrenadeBlindOverChance = (float) p_Value;
					break;

				case 143367295:
					SuppressingBurstCountMin = (int) p_Value;
					break;

				case 143367521:
					SuppressingBurstCountMax = (int) p_Value;
					break;

				case 3316478678:
					CoverWaitTime = (FloatRange) p_Value;
					break;

				case 1126523123:
					MaxAngleDiffForBlindFire = (float) p_Value;
					break;

				case 2666140512:
					StrafeToCoverProbablity = (float) p_Value;
					break;

				case 909096565:
					MaxSuppressTime = (float) p_Value;
					break;

				case 2917499264:
					InvestigateVisualTestDist = (float) p_Value;
					break;

				case 344268096:
					AlwaysStrafeToCoversWithinDistance = (float) p_Value;
					break;

				case 1982778017:
					ChargeSurpriseVelocity = (float) p_Value;
					break;

				case 4033255853:
					ChargeSurpriseNearDistance = (float) p_Value;
					break;

				case 3616177114:
					ChargeSurpriseFlankedDistance = (float) p_Value;
					break;

				case 794700105:
					ShotAtFireBlindOutChance = (float) p_Value;
					break;

				case 2819196649:
					ShotAtFireBlindOverChance = (float) p_Value;
					break;

				case 3344065321:
					AccuracyIncreaseTime = (float) p_Value;
					break;

				case 654935356:
					TargetStrengthFactor = (float) p_Value;
					break;

				case 1582035964:
					ReloadBelowPercent = (float) p_Value;
					break;

				case 3104589626:
					TargetDistanceFactor = (float) p_Value;
					break;

				case 1814084307:
					SuppressIndirectProbability = (float) p_Value;
					break;

				case 1320203042:
					TargetDangerFactor = (float) p_Value;
					break;

				case 1079385451:
					TargetIsAttackingFactor = (float) p_Value;
					break;

				case 3748050345:
					AccuracyModifierVsNonHumans = (float) p_Value;
					break;

				case 2169418607:
					AccuracyModifier = (float) p_Value;
					break;

				case 4284188016:
					SoldierMovementVolumeOverride = (float) p_Value;
					break;

				case 4022042757:
					AlwaysUpdate = (bool) p_Value;
					break;

				case 3002545486:
					LeaveVehicleOnSearchAndDestroyOrder = (bool) p_Value;
					break;

				case 3722528240:
					ShouldFireThroughSmoke = (bool) p_Value;
					break;

				case 352766831:
					AlwaysStrafeToFirstCover = (bool) p_Value;
					break;

				case 4010783416:
					CanMeleeFromScriptedCover = (bool) p_Value;
					break;

				case 4133324674:
					AlwaysStrafeToCoversBehindMe = (bool) p_Value;
					break;

				case 2495588022:
					UseShotAtSettings = (bool) p_Value;
					break;

				case 1259696724:
					StepBackIfBeingShot = (bool) p_Value;
					break;

				case 887985651:
					DisableMissileGravity = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2246572228:
					return StandProbability;

				case 106078632:
					return CrouchProbability;

				case 2785468173:
					return TurnAgainstTargetDistance;

				case 3076243205:
					return InvestigateStopDelay;

				case 1925970549:
					return ExplosiveObjectChance;

				case 1048477270:
					return MinAttackBursts;

				case 2789865160:
					return MaxAttackBursts;

				case 1339312363:
					return AttackUrgencyModifier;

				case 4293933145:
					return AltAttackProbability;

				case 2192704706:
					return ReadinessReactionTimeMultiplier;

				case 3205426975:
					return FireBlindOverBurstCount;

				case 1917637638:
					return CloseRangeAccuracyDistanceOverride;

				case 960532638:
					return MeleeRange;

				case 3607661600:
					return MeleeMaxTime;

				case 1871998476:
					return MeleeProbability;

				case 3956228463:
					return CoverSwitchTime;

				case 3698926705:
					return FireStyleTimeout;

				case 2963103673:
					return FireLeanChance;

				case 737987738:
					return FireLeanBurstCount;

				case 1614197955:
					return FireStepOutChance;

				case 206337888:
					return FireStepOutBurstCount;

				case 4253321444:
					return FireStepOutSlowChance;

				case 1727148359:
					return FireStepOutSlowBurstCount;

				case 4064538876:
					return FireStepOutUrgentChance;

				case 452711775:
					return FireStepOutUrgentBurstCount;

				case 2484763260:
					return FireStepOutFireFromHipChance;

				case 1878728415:
					return FireStepOutFireFromHipBurstCount;

				case 3237569684:
					return FireStepOutStandToCrouchChance;

				case 1054344887:
					return FireStepOutStandToCrouchBurstCount;

				case 3257836322:
					return AlwaysInFirePose;

				case 538888317:
					return FireGrenadeStepOutChance;

				case 2890954334:
					return FireGrenadeStepOutBurstCount;

				case 4010500561:
					return FireOverChance;

				case 3580603250:
					return FireOverBurstCount;

				case 73996732:
					return FireBlindOutChance;

				case 682065439:
					return FireBlindOutBurstCount;

				case 1455426236:
					return FireBlindOverChance;

				case 2130576437:
					return SuppressingBurstCount;

				case 1822898498:
					return FireGrenadeBlindOverChance;

				case 788190561:
					return FireGrenadeBlindOverBurstCount;

				case 4038590905:
					return FireLmgChance;

				case 1553493658:
					return FireLmgBurstCount;

				case 525072119:
					return ShotAtFireGrenadeBlindOverChance;

				case 143367295:
					return SuppressingBurstCountMin;

				case 143367521:
					return SuppressingBurstCountMax;

				case 3316478678:
					return CoverWaitTime;

				case 1126523123:
					return MaxAngleDiffForBlindFire;

				case 2666140512:
					return StrafeToCoverProbablity;

				case 909096565:
					return MaxSuppressTime;

				case 2917499264:
					return InvestigateVisualTestDist;

				case 344268096:
					return AlwaysStrafeToCoversWithinDistance;

				case 1982778017:
					return ChargeSurpriseVelocity;

				case 4033255853:
					return ChargeSurpriseNearDistance;

				case 3616177114:
					return ChargeSurpriseFlankedDistance;

				case 794700105:
					return ShotAtFireBlindOutChance;

				case 2819196649:
					return ShotAtFireBlindOverChance;

				case 3344065321:
					return AccuracyIncreaseTime;

				case 654935356:
					return TargetStrengthFactor;

				case 1582035964:
					return ReloadBelowPercent;

				case 3104589626:
					return TargetDistanceFactor;

				case 1814084307:
					return SuppressIndirectProbability;

				case 1320203042:
					return TargetDangerFactor;

				case 1079385451:
					return TargetIsAttackingFactor;

				case 3748050345:
					return AccuracyModifierVsNonHumans;

				case 2169418607:
					return AccuracyModifier;

				case 4284188016:
					return SoldierMovementVolumeOverride;

				case 4022042757:
					return AlwaysUpdate;

				case 3002545486:
					return LeaveVehicleOnSearchAndDestroyOrder;

				case 3722528240:
					return ShouldFireThroughSmoke;

				case 352766831:
					return AlwaysStrafeToFirstCover;

				case 4010783416:
					return CanMeleeFromScriptedCover;

				case 4133324674:
					return AlwaysStrafeToCoversBehindMe;

				case 2495588022:
					return UseShotAtSettings;

				case 1259696724:
					return StepBackIfBeingShot;

				case 887985651:
					return DisableMissileGravity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2246572228:
					return typeof(BehaviourTemplateData).GetProperty(nameof(StandProbability));

				case 106078632:
					return typeof(BehaviourTemplateData).GetProperty(nameof(CrouchProbability));

				case 2785468173:
					return typeof(BehaviourTemplateData).GetProperty(nameof(TurnAgainstTargetDistance));

				case 3076243205:
					return typeof(BehaviourTemplateData).GetProperty(nameof(InvestigateStopDelay));

				case 1925970549:
					return typeof(BehaviourTemplateData).GetProperty(nameof(ExplosiveObjectChance));

				case 1048477270:
					return typeof(BehaviourTemplateData).GetProperty(nameof(MinAttackBursts));

				case 2789865160:
					return typeof(BehaviourTemplateData).GetProperty(nameof(MaxAttackBursts));

				case 1339312363:
					return typeof(BehaviourTemplateData).GetProperty(nameof(AttackUrgencyModifier));

				case 4293933145:
					return typeof(BehaviourTemplateData).GetProperty(nameof(AltAttackProbability));

				case 2192704706:
					return typeof(BehaviourTemplateData).GetProperty(nameof(ReadinessReactionTimeMultiplier));

				case 3205426975:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireBlindOverBurstCount));

				case 1917637638:
					return typeof(BehaviourTemplateData).GetProperty(nameof(CloseRangeAccuracyDistanceOverride));

				case 960532638:
					return typeof(BehaviourTemplateData).GetProperty(nameof(MeleeRange));

				case 3607661600:
					return typeof(BehaviourTemplateData).GetProperty(nameof(MeleeMaxTime));

				case 1871998476:
					return typeof(BehaviourTemplateData).GetProperty(nameof(MeleeProbability));

				case 3956228463:
					return typeof(BehaviourTemplateData).GetProperty(nameof(CoverSwitchTime));

				case 3698926705:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireStyleTimeout));

				case 2963103673:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireLeanChance));

				case 737987738:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireLeanBurstCount));

				case 1614197955:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireStepOutChance));

				case 206337888:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireStepOutBurstCount));

				case 4253321444:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireStepOutSlowChance));

				case 1727148359:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireStepOutSlowBurstCount));

				case 4064538876:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireStepOutUrgentChance));

				case 452711775:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireStepOutUrgentBurstCount));

				case 2484763260:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireStepOutFireFromHipChance));

				case 1878728415:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireStepOutFireFromHipBurstCount));

				case 3237569684:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireStepOutStandToCrouchChance));

				case 1054344887:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireStepOutStandToCrouchBurstCount));

				case 3257836322:
					return typeof(BehaviourTemplateData).GetProperty(nameof(AlwaysInFirePose));

				case 538888317:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireGrenadeStepOutChance));

				case 2890954334:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireGrenadeStepOutBurstCount));

				case 4010500561:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireOverChance));

				case 3580603250:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireOverBurstCount));

				case 73996732:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireBlindOutChance));

				case 682065439:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireBlindOutBurstCount));

				case 1455426236:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireBlindOverChance));

				case 2130576437:
					return typeof(BehaviourTemplateData).GetProperty(nameof(SuppressingBurstCount));

				case 1822898498:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireGrenadeBlindOverChance));

				case 788190561:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireGrenadeBlindOverBurstCount));

				case 4038590905:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireLmgChance));

				case 1553493658:
					return typeof(BehaviourTemplateData).GetProperty(nameof(FireLmgBurstCount));

				case 525072119:
					return typeof(BehaviourTemplateData).GetProperty(nameof(ShotAtFireGrenadeBlindOverChance));

				case 143367295:
					return typeof(BehaviourTemplateData).GetProperty(nameof(SuppressingBurstCountMin));

				case 143367521:
					return typeof(BehaviourTemplateData).GetProperty(nameof(SuppressingBurstCountMax));

				case 3316478678:
					return typeof(BehaviourTemplateData).GetProperty(nameof(CoverWaitTime));

				case 1126523123:
					return typeof(BehaviourTemplateData).GetProperty(nameof(MaxAngleDiffForBlindFire));

				case 2666140512:
					return typeof(BehaviourTemplateData).GetProperty(nameof(StrafeToCoverProbablity));

				case 909096565:
					return typeof(BehaviourTemplateData).GetProperty(nameof(MaxSuppressTime));

				case 2917499264:
					return typeof(BehaviourTemplateData).GetProperty(nameof(InvestigateVisualTestDist));

				case 344268096:
					return typeof(BehaviourTemplateData).GetProperty(nameof(AlwaysStrafeToCoversWithinDistance));

				case 1982778017:
					return typeof(BehaviourTemplateData).GetProperty(nameof(ChargeSurpriseVelocity));

				case 4033255853:
					return typeof(BehaviourTemplateData).GetProperty(nameof(ChargeSurpriseNearDistance));

				case 3616177114:
					return typeof(BehaviourTemplateData).GetProperty(nameof(ChargeSurpriseFlankedDistance));

				case 794700105:
					return typeof(BehaviourTemplateData).GetProperty(nameof(ShotAtFireBlindOutChance));

				case 2819196649:
					return typeof(BehaviourTemplateData).GetProperty(nameof(ShotAtFireBlindOverChance));

				case 3344065321:
					return typeof(BehaviourTemplateData).GetProperty(nameof(AccuracyIncreaseTime));

				case 654935356:
					return typeof(BehaviourTemplateData).GetProperty(nameof(TargetStrengthFactor));

				case 1582035964:
					return typeof(BehaviourTemplateData).GetProperty(nameof(ReloadBelowPercent));

				case 3104589626:
					return typeof(BehaviourTemplateData).GetProperty(nameof(TargetDistanceFactor));

				case 1814084307:
					return typeof(BehaviourTemplateData).GetProperty(nameof(SuppressIndirectProbability));

				case 1320203042:
					return typeof(BehaviourTemplateData).GetProperty(nameof(TargetDangerFactor));

				case 1079385451:
					return typeof(BehaviourTemplateData).GetProperty(nameof(TargetIsAttackingFactor));

				case 3748050345:
					return typeof(BehaviourTemplateData).GetProperty(nameof(AccuracyModifierVsNonHumans));

				case 2169418607:
					return typeof(BehaviourTemplateData).GetProperty(nameof(AccuracyModifier));

				case 4284188016:
					return typeof(BehaviourTemplateData).GetProperty(nameof(SoldierMovementVolumeOverride));

				case 4022042757:
					return typeof(BehaviourTemplateData).GetProperty(nameof(AlwaysUpdate));

				case 3002545486:
					return typeof(BehaviourTemplateData).GetProperty(nameof(LeaveVehicleOnSearchAndDestroyOrder));

				case 3722528240:
					return typeof(BehaviourTemplateData).GetProperty(nameof(ShouldFireThroughSmoke));

				case 352766831:
					return typeof(BehaviourTemplateData).GetProperty(nameof(AlwaysStrafeToFirstCover));

				case 4010783416:
					return typeof(BehaviourTemplateData).GetProperty(nameof(CanMeleeFromScriptedCover));

				case 4133324674:
					return typeof(BehaviourTemplateData).GetProperty(nameof(AlwaysStrafeToCoversBehindMe));

				case 2495588022:
					return typeof(BehaviourTemplateData).GetProperty(nameof(UseShotAtSettings));

				case 1259696724:
					return typeof(BehaviourTemplateData).GetProperty(nameof(StepBackIfBeingShot));

				case 887985651:
					return typeof(BehaviourTemplateData).GetProperty(nameof(DisableMissileGravity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
