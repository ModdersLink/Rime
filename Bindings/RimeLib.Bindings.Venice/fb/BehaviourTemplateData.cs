///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 344)]
	public class BehaviourTemplateData : 
		GameBehaviourTemplateData
	{
		protected float m_StandProbability = new float();
		[ContainerField(Name: "StandProbability", Offset: 12, NameHash: 2246572228, Flags: 49469), LayoutImmutable, Blittable]
		public float StandProbability { get { return m_StandProbability; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(StandProbability), this, m_StandProbability, value)) m_StandProbability = value; } } // 0xC (12)
		
		protected float m_CrouchProbability = new float();
		[ContainerField(Name: "CrouchProbability", Offset: 16, NameHash: 106078632, Flags: 49469), LayoutImmutable, Blittable]
		public float CrouchProbability { get { return m_CrouchProbability; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(CrouchProbability), this, m_CrouchProbability, value)) m_CrouchProbability = value; } } // 0x10 (16)
		
		protected float m_TurnAgainstTargetDistance = new float();
		[ContainerField(Name: "TurnAgainstTargetDistance", Offset: 20, NameHash: 2785468173, Flags: 49469), LayoutImmutable, Blittable]
		public float TurnAgainstTargetDistance { get { return m_TurnAgainstTargetDistance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(TurnAgainstTargetDistance), this, m_TurnAgainstTargetDistance, value)) m_TurnAgainstTargetDistance = value; } } // 0x14 (20)
		
		protected float m_InvestigateStopDelay = new float();
		[ContainerField(Name: "InvestigateStopDelay", Offset: 24, NameHash: 3076243205, Flags: 49469), LayoutImmutable, Blittable]
		public float InvestigateStopDelay { get { return m_InvestigateStopDelay; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(InvestigateStopDelay), this, m_InvestigateStopDelay, value)) m_InvestigateStopDelay = value; } } // 0x18 (24)
		
		protected float m_ExplosiveObjectChance = new float();
		[ContainerField(Name: "ExplosiveObjectChance", Offset: 28, NameHash: 1925970549, Flags: 49469), LayoutImmutable, Blittable]
		public float ExplosiveObjectChance { get { return m_ExplosiveObjectChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(ExplosiveObjectChance), this, m_ExplosiveObjectChance, value)) m_ExplosiveObjectChance = value; } } // 0x1C (28)
		
		protected uint m_MinAttackBursts = new uint();
		[ContainerField(Name: "MinAttackBursts", Offset: 32, NameHash: 1048477270, Flags: 49421), LayoutImmutable, Blittable]
		public uint MinAttackBursts { get { return m_MinAttackBursts; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(MinAttackBursts), this, m_MinAttackBursts, value)) m_MinAttackBursts = value; } } // 0x20 (32)
		
		protected uint m_MaxAttackBursts = new uint();
		[ContainerField(Name: "MaxAttackBursts", Offset: 36, NameHash: 2789865160, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxAttackBursts { get { return m_MaxAttackBursts; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(MaxAttackBursts), this, m_MaxAttackBursts, value)) m_MaxAttackBursts = value; } } // 0x24 (36)
		
		protected float m_AttackUrgencyModifier = new float();
		[ContainerField(Name: "AttackUrgencyModifier", Offset: 40, NameHash: 1339312363, Flags: 49469), LayoutImmutable, Blittable]
		public float AttackUrgencyModifier { get { return m_AttackUrgencyModifier; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(AttackUrgencyModifier), this, m_AttackUrgencyModifier, value)) m_AttackUrgencyModifier = value; } } // 0x28 (40)
		
		protected float m_AltAttackProbability = new float();
		[ContainerField(Name: "AltAttackProbability", Offset: 44, NameHash: 4293933145, Flags: 49469), LayoutImmutable, Blittable]
		public float AltAttackProbability { get { return m_AltAttackProbability; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(AltAttackProbability), this, m_AltAttackProbability, value)) m_AltAttackProbability = value; } } // 0x2C (44)
		
		protected float m_ReadinessReactionTimeMultiplier = new float();
		[ContainerField(Name: "ReadinessReactionTimeMultiplier", Offset: 48, NameHash: 2192704706, Flags: 49469), LayoutImmutable, Blittable]
		public float ReadinessReactionTimeMultiplier { get { return m_ReadinessReactionTimeMultiplier; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(ReadinessReactionTimeMultiplier), this, m_ReadinessReactionTimeMultiplier, value)) m_ReadinessReactionTimeMultiplier = value; } } // 0x30 (48)
		
		protected UIntRange m_FireBlindOverBurstCount = new UIntRange();
		[ContainerField(Name: "FireBlindOverBurstCount", Offset: 52, NameHash: 3205426975, Flags: 41)]
		public UIntRange FireBlindOverBurstCount { get { return m_FireBlindOverBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireBlindOverBurstCount), this, m_FireBlindOverBurstCount, value)) m_FireBlindOverBurstCount = value; } } // 0x34 (52)
		
		protected float m_CloseRangeAccuracyDistanceOverride = new float();
		[ContainerField(Name: "CloseRangeAccuracyDistanceOverride", Offset: 60, NameHash: 1917637638, Flags: 49469), LayoutImmutable, Blittable]
		public float CloseRangeAccuracyDistanceOverride { get { return m_CloseRangeAccuracyDistanceOverride; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(CloseRangeAccuracyDistanceOverride), this, m_CloseRangeAccuracyDistanceOverride, value)) m_CloseRangeAccuracyDistanceOverride = value; } } // 0x3C (60)
		
		protected float m_MeleeRange = new float();
		[ContainerField(Name: "MeleeRange", Offset: 64, NameHash: 960532638, Flags: 49469), LayoutImmutable, Blittable]
		public float MeleeRange { get { return m_MeleeRange; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(MeleeRange), this, m_MeleeRange, value)) m_MeleeRange = value; } } // 0x40 (64)
		
		protected float m_MeleeMaxTime = new float();
		[ContainerField(Name: "MeleeMaxTime", Offset: 68, NameHash: 3607661600, Flags: 49469), LayoutImmutable, Blittable]
		public float MeleeMaxTime { get { return m_MeleeMaxTime; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(MeleeMaxTime), this, m_MeleeMaxTime, value)) m_MeleeMaxTime = value; } } // 0x44 (68)
		
		protected float m_MeleeProbability = new float();
		[ContainerField(Name: "MeleeProbability", Offset: 72, NameHash: 1871998476, Flags: 49469), LayoutImmutable, Blittable]
		public float MeleeProbability { get { return m_MeleeProbability; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(MeleeProbability), this, m_MeleeProbability, value)) m_MeleeProbability = value; } } // 0x48 (72)
		
		protected FloatRangeDefaultZero m_CoverSwitchTime = new FloatRangeDefaultZero();
		[ContainerField(Name: "CoverSwitchTime", Offset: 76, NameHash: 3956228463, Flags: 41)]
		public FloatRangeDefaultZero CoverSwitchTime { get { return m_CoverSwitchTime; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(CoverSwitchTime), this, m_CoverSwitchTime, value)) m_CoverSwitchTime = value; } } // 0x4C (76)
		
		protected float m_FireStyleTimeout = new float();
		[ContainerField(Name: "FireStyleTimeout", Offset: 84, NameHash: 3698926705, Flags: 49469), LayoutImmutable, Blittable]
		public float FireStyleTimeout { get { return m_FireStyleTimeout; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireStyleTimeout), this, m_FireStyleTimeout, value)) m_FireStyleTimeout = value; } } // 0x54 (84)
		
		protected float m_FireLeanChance = new float();
		[ContainerField(Name: "FireLeanChance", Offset: 88, NameHash: 2963103673, Flags: 49469), LayoutImmutable, Blittable]
		public float FireLeanChance { get { return m_FireLeanChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireLeanChance), this, m_FireLeanChance, value)) m_FireLeanChance = value; } } // 0x58 (88)
		
		protected UIntRange m_FireLeanBurstCount = new UIntRange();
		[ContainerField(Name: "FireLeanBurstCount", Offset: 92, NameHash: 737987738, Flags: 41)]
		public UIntRange FireLeanBurstCount { get { return m_FireLeanBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireLeanBurstCount), this, m_FireLeanBurstCount, value)) m_FireLeanBurstCount = value; } } // 0x5C (92)
		
		protected float m_FireStepOutChance = new float();
		[ContainerField(Name: "FireStepOutChance", Offset: 100, NameHash: 1614197955, Flags: 49469), LayoutImmutable, Blittable]
		public float FireStepOutChance { get { return m_FireStepOutChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireStepOutChance), this, m_FireStepOutChance, value)) m_FireStepOutChance = value; } } // 0x64 (100)
		
		protected UIntRange m_FireStepOutBurstCount = new UIntRange();
		[ContainerField(Name: "FireStepOutBurstCount", Offset: 104, NameHash: 206337888, Flags: 41)]
		public UIntRange FireStepOutBurstCount { get { return m_FireStepOutBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireStepOutBurstCount), this, m_FireStepOutBurstCount, value)) m_FireStepOutBurstCount = value; } } // 0x68 (104)
		
		protected float m_FireStepOutSlowChance = new float();
		[ContainerField(Name: "FireStepOutSlowChance", Offset: 112, NameHash: 4253321444, Flags: 49469), LayoutImmutable, Blittable]
		public float FireStepOutSlowChance { get { return m_FireStepOutSlowChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireStepOutSlowChance), this, m_FireStepOutSlowChance, value)) m_FireStepOutSlowChance = value; } } // 0x70 (112)
		
		protected UIntRange m_FireStepOutSlowBurstCount = new UIntRange();
		[ContainerField(Name: "FireStepOutSlowBurstCount", Offset: 116, NameHash: 1727148359, Flags: 41)]
		public UIntRange FireStepOutSlowBurstCount { get { return m_FireStepOutSlowBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireStepOutSlowBurstCount), this, m_FireStepOutSlowBurstCount, value)) m_FireStepOutSlowBurstCount = value; } } // 0x74 (116)
		
		protected float m_FireStepOutUrgentChance = new float();
		[ContainerField(Name: "FireStepOutUrgentChance", Offset: 124, NameHash: 4064538876, Flags: 49469), LayoutImmutable, Blittable]
		public float FireStepOutUrgentChance { get { return m_FireStepOutUrgentChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireStepOutUrgentChance), this, m_FireStepOutUrgentChance, value)) m_FireStepOutUrgentChance = value; } } // 0x7C (124)
		
		protected UIntRange m_FireStepOutUrgentBurstCount = new UIntRange();
		[ContainerField(Name: "FireStepOutUrgentBurstCount", Offset: 128, NameHash: 452711775, Flags: 41)]
		public UIntRange FireStepOutUrgentBurstCount { get { return m_FireStepOutUrgentBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireStepOutUrgentBurstCount), this, m_FireStepOutUrgentBurstCount, value)) m_FireStepOutUrgentBurstCount = value; } } // 0x80 (128)
		
		protected float m_FireStepOutFireFromHipChance = new float();
		[ContainerField(Name: "FireStepOutFireFromHipChance", Offset: 136, NameHash: 2484763260, Flags: 49469), LayoutImmutable, Blittable]
		public float FireStepOutFireFromHipChance { get { return m_FireStepOutFireFromHipChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireStepOutFireFromHipChance), this, m_FireStepOutFireFromHipChance, value)) m_FireStepOutFireFromHipChance = value; } } // 0x88 (136)
		
		protected UIntRange m_FireStepOutFireFromHipBurstCount = new UIntRange();
		[ContainerField(Name: "FireStepOutFireFromHipBurstCount", Offset: 140, NameHash: 1878728415, Flags: 41)]
		public UIntRange FireStepOutFireFromHipBurstCount { get { return m_FireStepOutFireFromHipBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireStepOutFireFromHipBurstCount), this, m_FireStepOutFireFromHipBurstCount, value)) m_FireStepOutFireFromHipBurstCount = value; } } // 0x8C (140)
		
		protected float m_FireStepOutStandToCrouchChance = new float();
		[ContainerField(Name: "FireStepOutStandToCrouchChance", Offset: 148, NameHash: 3237569684, Flags: 49469), LayoutImmutable, Blittable]
		public float FireStepOutStandToCrouchChance { get { return m_FireStepOutStandToCrouchChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireStepOutStandToCrouchChance), this, m_FireStepOutStandToCrouchChance, value)) m_FireStepOutStandToCrouchChance = value; } } // 0x94 (148)
		
		protected UIntRange m_FireStepOutStandToCrouchBurstCount = new UIntRange();
		[ContainerField(Name: "FireStepOutStandToCrouchBurstCount", Offset: 152, NameHash: 1054344887, Flags: 41)]
		public UIntRange FireStepOutStandToCrouchBurstCount { get { return m_FireStepOutStandToCrouchBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireStepOutStandToCrouchBurstCount), this, m_FireStepOutStandToCrouchBurstCount, value)) m_FireStepOutStandToCrouchBurstCount = value; } } // 0x98 (152)
		
		protected CoverFireType m_AlwaysInFirePose = new CoverFireType();
		[ContainerField(Name: "AlwaysInFirePose", Offset: 160, NameHash: 3257836322, Flags: 137)]
		public CoverFireType AlwaysInFirePose { get { return m_AlwaysInFirePose; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(AlwaysInFirePose), this, m_AlwaysInFirePose, value)) m_AlwaysInFirePose = value; } } // 0xA0 (160)
		
		protected float m_FireGrenadeStepOutChance = new float();
		[ContainerField(Name: "FireGrenadeStepOutChance", Offset: 164, NameHash: 538888317, Flags: 49469), LayoutImmutable, Blittable]
		public float FireGrenadeStepOutChance { get { return m_FireGrenadeStepOutChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireGrenadeStepOutChance), this, m_FireGrenadeStepOutChance, value)) m_FireGrenadeStepOutChance = value; } } // 0xA4 (164)
		
		protected UIntRange m_FireGrenadeStepOutBurstCount = new UIntRange();
		[ContainerField(Name: "FireGrenadeStepOutBurstCount", Offset: 168, NameHash: 2890954334, Flags: 41)]
		public UIntRange FireGrenadeStepOutBurstCount { get { return m_FireGrenadeStepOutBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireGrenadeStepOutBurstCount), this, m_FireGrenadeStepOutBurstCount, value)) m_FireGrenadeStepOutBurstCount = value; } } // 0xA8 (168)
		
		protected float m_FireOverChance = new float();
		[ContainerField(Name: "FireOverChance", Offset: 176, NameHash: 4010500561, Flags: 49469), LayoutImmutable, Blittable]
		public float FireOverChance { get { return m_FireOverChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireOverChance), this, m_FireOverChance, value)) m_FireOverChance = value; } } // 0xB0 (176)
		
		protected UIntRange m_FireOverBurstCount = new UIntRange();
		[ContainerField(Name: "FireOverBurstCount", Offset: 180, NameHash: 3580603250, Flags: 41)]
		public UIntRange FireOverBurstCount { get { return m_FireOverBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireOverBurstCount), this, m_FireOverBurstCount, value)) m_FireOverBurstCount = value; } } // 0xB4 (180)
		
		protected float m_FireBlindOutChance = new float();
		[ContainerField(Name: "FireBlindOutChance", Offset: 188, NameHash: 73996732, Flags: 49469), LayoutImmutable, Blittable]
		public float FireBlindOutChance { get { return m_FireBlindOutChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireBlindOutChance), this, m_FireBlindOutChance, value)) m_FireBlindOutChance = value; } } // 0xBC (188)
		
		protected UIntRange m_FireBlindOutBurstCount = new UIntRange();
		[ContainerField(Name: "FireBlindOutBurstCount", Offset: 192, NameHash: 682065439, Flags: 41)]
		public UIntRange FireBlindOutBurstCount { get { return m_FireBlindOutBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireBlindOutBurstCount), this, m_FireBlindOutBurstCount, value)) m_FireBlindOutBurstCount = value; } } // 0xC0 (192)
		
		protected float m_FireBlindOverChance = new float();
		[ContainerField(Name: "FireBlindOverChance", Offset: 200, NameHash: 1455426236, Flags: 49469), LayoutImmutable, Blittable]
		public float FireBlindOverChance { get { return m_FireBlindOverChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireBlindOverChance), this, m_FireBlindOverChance, value)) m_FireBlindOverChance = value; } } // 0xC8 (200)
		
		protected int m_SuppressingBurstCount = new int();
		[ContainerField(Name: "SuppressingBurstCount", Offset: 204, NameHash: 2130576437, Flags: 49405), LayoutImmutable, Blittable]
		public int SuppressingBurstCount { get { return m_SuppressingBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(SuppressingBurstCount), this, m_SuppressingBurstCount, value)) m_SuppressingBurstCount = value; } } // 0xCC (204)
		
		protected float m_FireGrenadeBlindOverChance = new float();
		[ContainerField(Name: "FireGrenadeBlindOverChance", Offset: 208, NameHash: 1822898498, Flags: 49469), LayoutImmutable, Blittable]
		public float FireGrenadeBlindOverChance { get { return m_FireGrenadeBlindOverChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireGrenadeBlindOverChance), this, m_FireGrenadeBlindOverChance, value)) m_FireGrenadeBlindOverChance = value; } } // 0xD0 (208)
		
		protected UIntRange m_FireGrenadeBlindOverBurstCount = new UIntRange();
		[ContainerField(Name: "FireGrenadeBlindOverBurstCount", Offset: 212, NameHash: 788190561, Flags: 41)]
		public UIntRange FireGrenadeBlindOverBurstCount { get { return m_FireGrenadeBlindOverBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireGrenadeBlindOverBurstCount), this, m_FireGrenadeBlindOverBurstCount, value)) m_FireGrenadeBlindOverBurstCount = value; } } // 0xD4 (212)
		
		protected float m_FireLmgChance = new float();
		[ContainerField(Name: "FireLmgChance", Offset: 220, NameHash: 4038590905, Flags: 49469), LayoutImmutable, Blittable]
		public float FireLmgChance { get { return m_FireLmgChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireLmgChance), this, m_FireLmgChance, value)) m_FireLmgChance = value; } } // 0xDC (220)
		
		protected UIntRange m_FireLmgBurstCount = new UIntRange();
		[ContainerField(Name: "FireLmgBurstCount", Offset: 224, NameHash: 1553493658, Flags: 41)]
		public UIntRange FireLmgBurstCount { get { return m_FireLmgBurstCount; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(FireLmgBurstCount), this, m_FireLmgBurstCount, value)) m_FireLmgBurstCount = value; } } // 0xE0 (224)
		
		protected float m_ShotAtFireGrenadeBlindOverChance = new float();
		[ContainerField(Name: "ShotAtFireGrenadeBlindOverChance", Offset: 232, NameHash: 525072119, Flags: 49469), LayoutImmutable, Blittable]
		public float ShotAtFireGrenadeBlindOverChance { get { return m_ShotAtFireGrenadeBlindOverChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(ShotAtFireGrenadeBlindOverChance), this, m_ShotAtFireGrenadeBlindOverChance, value)) m_ShotAtFireGrenadeBlindOverChance = value; } } // 0xE8 (232)
		
		protected int m_SuppressingBurstCountMin = new int();
		[ContainerField(Name: "SuppressingBurstCountMin", Offset: 236, NameHash: 143367295, Flags: 49405), LayoutImmutable, Blittable]
		public int SuppressingBurstCountMin { get { return m_SuppressingBurstCountMin; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(SuppressingBurstCountMin), this, m_SuppressingBurstCountMin, value)) m_SuppressingBurstCountMin = value; } } // 0xEC (236)
		
		protected int m_SuppressingBurstCountMax = new int();
		[ContainerField(Name: "SuppressingBurstCountMax", Offset: 240, NameHash: 143367521, Flags: 49405), LayoutImmutable, Blittable]
		public int SuppressingBurstCountMax { get { return m_SuppressingBurstCountMax; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(SuppressingBurstCountMax), this, m_SuppressingBurstCountMax, value)) m_SuppressingBurstCountMax = value; } } // 0xF0 (240)
		
		protected FloatRange m_CoverWaitTime = new FloatRange();
		[ContainerField(Name: "CoverWaitTime", Offset: 244, NameHash: 3316478678, Flags: 41)]
		public FloatRange CoverWaitTime { get { return m_CoverWaitTime; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(CoverWaitTime), this, m_CoverWaitTime, value)) m_CoverWaitTime = value; } } // 0xF4 (244)
		
		protected float m_MaxAngleDiffForBlindFire = new float();
		[ContainerField(Name: "MaxAngleDiffForBlindFire", Offset: 252, NameHash: 1126523123, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxAngleDiffForBlindFire { get { return m_MaxAngleDiffForBlindFire; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(MaxAngleDiffForBlindFire), this, m_MaxAngleDiffForBlindFire, value)) m_MaxAngleDiffForBlindFire = value; } } // 0xFC (252)
		
		protected float m_StrafeToCoverProbablity = new float();
		[ContainerField(Name: "StrafeToCoverProbablity", Offset: 256, NameHash: 2666140512, Flags: 49469), LayoutImmutable, Blittable]
		public float StrafeToCoverProbablity { get { return m_StrafeToCoverProbablity; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(StrafeToCoverProbablity), this, m_StrafeToCoverProbablity, value)) m_StrafeToCoverProbablity = value; } } // 0x100 (256)
		
		protected float m_MaxSuppressTime = new float();
		[ContainerField(Name: "MaxSuppressTime", Offset: 260, NameHash: 909096565, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxSuppressTime { get { return m_MaxSuppressTime; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(MaxSuppressTime), this, m_MaxSuppressTime, value)) m_MaxSuppressTime = value; } } // 0x104 (260)
		
		protected float m_InvestigateVisualTestDist = new float();
		[ContainerField(Name: "InvestigateVisualTestDist", Offset: 264, NameHash: 2917499264, Flags: 49469), LayoutImmutable, Blittable]
		public float InvestigateVisualTestDist { get { return m_InvestigateVisualTestDist; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(InvestigateVisualTestDist), this, m_InvestigateVisualTestDist, value)) m_InvestigateVisualTestDist = value; } } // 0x108 (264)
		
		protected float m_AlwaysStrafeToCoversWithinDistance = new float();
		[ContainerField(Name: "AlwaysStrafeToCoversWithinDistance", Offset: 268, NameHash: 344268096, Flags: 49469), LayoutImmutable, Blittable]
		public float AlwaysStrafeToCoversWithinDistance { get { return m_AlwaysStrafeToCoversWithinDistance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(AlwaysStrafeToCoversWithinDistance), this, m_AlwaysStrafeToCoversWithinDistance, value)) m_AlwaysStrafeToCoversWithinDistance = value; } } // 0x10C (268)
		
		protected float m_ChargeSurpriseVelocity = new float();
		[ContainerField(Name: "ChargeSurpriseVelocity", Offset: 272, NameHash: 1982778017, Flags: 49469), LayoutImmutable, Blittable]
		public float ChargeSurpriseVelocity { get { return m_ChargeSurpriseVelocity; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(ChargeSurpriseVelocity), this, m_ChargeSurpriseVelocity, value)) m_ChargeSurpriseVelocity = value; } } // 0x110 (272)
		
		protected float m_ChargeSurpriseNearDistance = new float();
		[ContainerField(Name: "ChargeSurpriseNearDistance", Offset: 276, NameHash: 4033255853, Flags: 49469), LayoutImmutable, Blittable]
		public float ChargeSurpriseNearDistance { get { return m_ChargeSurpriseNearDistance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(ChargeSurpriseNearDistance), this, m_ChargeSurpriseNearDistance, value)) m_ChargeSurpriseNearDistance = value; } } // 0x114 (276)
		
		protected float m_ChargeSurpriseFlankedDistance = new float();
		[ContainerField(Name: "ChargeSurpriseFlankedDistance", Offset: 280, NameHash: 3616177114, Flags: 49469), LayoutImmutable, Blittable]
		public float ChargeSurpriseFlankedDistance { get { return m_ChargeSurpriseFlankedDistance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(ChargeSurpriseFlankedDistance), this, m_ChargeSurpriseFlankedDistance, value)) m_ChargeSurpriseFlankedDistance = value; } } // 0x118 (280)
		
		protected float m_ShotAtFireBlindOutChance = new float();
		[ContainerField(Name: "ShotAtFireBlindOutChance", Offset: 284, NameHash: 794700105, Flags: 49469), LayoutImmutable, Blittable]
		public float ShotAtFireBlindOutChance { get { return m_ShotAtFireBlindOutChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(ShotAtFireBlindOutChance), this, m_ShotAtFireBlindOutChance, value)) m_ShotAtFireBlindOutChance = value; } } // 0x11C (284)
		
		protected float m_ShotAtFireBlindOverChance = new float();
		[ContainerField(Name: "ShotAtFireBlindOverChance", Offset: 288, NameHash: 2819196649, Flags: 49469), LayoutImmutable, Blittable]
		public float ShotAtFireBlindOverChance { get { return m_ShotAtFireBlindOverChance; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(ShotAtFireBlindOverChance), this, m_ShotAtFireBlindOverChance, value)) m_ShotAtFireBlindOverChance = value; } } // 0x120 (288)
		
		protected float m_AccuracyIncreaseTime = new float();
		[ContainerField(Name: "AccuracyIncreaseTime", Offset: 292, NameHash: 3344065321, Flags: 49469), LayoutImmutable, Blittable]
		public float AccuracyIncreaseTime { get { return m_AccuracyIncreaseTime; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(AccuracyIncreaseTime), this, m_AccuracyIncreaseTime, value)) m_AccuracyIncreaseTime = value; } } // 0x124 (292)
		
		protected float m_TargetStrengthFactor = new float();
		[ContainerField(Name: "TargetStrengthFactor", Offset: 296, NameHash: 654935356, Flags: 49469), LayoutImmutable, Blittable]
		public float TargetStrengthFactor { get { return m_TargetStrengthFactor; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(TargetStrengthFactor), this, m_TargetStrengthFactor, value)) m_TargetStrengthFactor = value; } } // 0x128 (296)
		
		protected float m_ReloadBelowPercent = new float();
		[ContainerField(Name: "ReloadBelowPercent", Offset: 300, NameHash: 1582035964, Flags: 49469), LayoutImmutable, Blittable]
		public float ReloadBelowPercent { get { return m_ReloadBelowPercent; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(ReloadBelowPercent), this, m_ReloadBelowPercent, value)) m_ReloadBelowPercent = value; } } // 0x12C (300)
		
		protected float m_TargetDistanceFactor = new float();
		[ContainerField(Name: "TargetDistanceFactor", Offset: 304, NameHash: 3104589626, Flags: 49469), LayoutImmutable, Blittable]
		public float TargetDistanceFactor { get { return m_TargetDistanceFactor; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(TargetDistanceFactor), this, m_TargetDistanceFactor, value)) m_TargetDistanceFactor = value; } } // 0x130 (304)
		
		protected float m_SuppressIndirectProbability = new float();
		[ContainerField(Name: "SuppressIndirectProbability", Offset: 308, NameHash: 1814084307, Flags: 49469), LayoutImmutable, Blittable]
		public float SuppressIndirectProbability { get { return m_SuppressIndirectProbability; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(SuppressIndirectProbability), this, m_SuppressIndirectProbability, value)) m_SuppressIndirectProbability = value; } } // 0x134 (308)
		
		protected float m_TargetDangerFactor = new float();
		[ContainerField(Name: "TargetDangerFactor", Offset: 312, NameHash: 1320203042, Flags: 49469), LayoutImmutable, Blittable]
		public float TargetDangerFactor { get { return m_TargetDangerFactor; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(TargetDangerFactor), this, m_TargetDangerFactor, value)) m_TargetDangerFactor = value; } } // 0x138 (312)
		
		protected float m_TargetIsAttackingFactor = new float();
		[ContainerField(Name: "TargetIsAttackingFactor", Offset: 316, NameHash: 1079385451, Flags: 49469), LayoutImmutable, Blittable]
		public float TargetIsAttackingFactor { get { return m_TargetIsAttackingFactor; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(TargetIsAttackingFactor), this, m_TargetIsAttackingFactor, value)) m_TargetIsAttackingFactor = value; } } // 0x13C (316)
		
		protected float m_AccuracyModifierVsNonHumans = new float();
		[ContainerField(Name: "AccuracyModifierVsNonHumans", Offset: 320, NameHash: 3748050345, Flags: 49469), LayoutImmutable, Blittable]
		public float AccuracyModifierVsNonHumans { get { return m_AccuracyModifierVsNonHumans; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(AccuracyModifierVsNonHumans), this, m_AccuracyModifierVsNonHumans, value)) m_AccuracyModifierVsNonHumans = value; } } // 0x140 (320)
		
		protected float m_AccuracyModifier = new float();
		[ContainerField(Name: "AccuracyModifier", Offset: 324, NameHash: 2169418607, Flags: 49469), LayoutImmutable, Blittable]
		public float AccuracyModifier { get { return m_AccuracyModifier; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(AccuracyModifier), this, m_AccuracyModifier, value)) m_AccuracyModifier = value; } } // 0x144 (324)
		
		protected float m_SoldierMovementVolumeOverride = new float();
		[ContainerField(Name: "SoldierMovementVolumeOverride", Offset: 328, NameHash: 4284188016, Flags: 49469), LayoutImmutable, Blittable]
		public float SoldierMovementVolumeOverride { get { return m_SoldierMovementVolumeOverride; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(SoldierMovementVolumeOverride), this, m_SoldierMovementVolumeOverride, value)) m_SoldierMovementVolumeOverride = value; } } // 0x148 (328)
		
		protected bool m_AlwaysUpdate = new bool();
		[ContainerField(Name: "AlwaysUpdate", Offset: 332, NameHash: 4022042757, Flags: 49325), LayoutImmutable, Blittable]
		public bool AlwaysUpdate { get { return m_AlwaysUpdate; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(AlwaysUpdate), this, m_AlwaysUpdate, value)) m_AlwaysUpdate = value; } } // 0x14C (332)
		
		protected bool m_LeaveVehicleOnSearchAndDestroyOrder = new bool();
		[ContainerField(Name: "LeaveVehicleOnSearchAndDestroyOrder", Offset: 333, NameHash: 3002545486, Flags: 49325), LayoutImmutable, Blittable]
		public bool LeaveVehicleOnSearchAndDestroyOrder { get { return m_LeaveVehicleOnSearchAndDestroyOrder; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(LeaveVehicleOnSearchAndDestroyOrder), this, m_LeaveVehicleOnSearchAndDestroyOrder, value)) m_LeaveVehicleOnSearchAndDestroyOrder = value; } } // 0x14D (333)
		
		protected bool m_ShouldFireThroughSmoke = new bool();
		[ContainerField(Name: "ShouldFireThroughSmoke", Offset: 334, NameHash: 3722528240, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShouldFireThroughSmoke { get { return m_ShouldFireThroughSmoke; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(ShouldFireThroughSmoke), this, m_ShouldFireThroughSmoke, value)) m_ShouldFireThroughSmoke = value; } } // 0x14E (334)
		
		protected bool m_AlwaysStrafeToFirstCover = new bool();
		[ContainerField(Name: "AlwaysStrafeToFirstCover", Offset: 335, NameHash: 352766831, Flags: 49325), LayoutImmutable, Blittable]
		public bool AlwaysStrafeToFirstCover { get { return m_AlwaysStrafeToFirstCover; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(AlwaysStrafeToFirstCover), this, m_AlwaysStrafeToFirstCover, value)) m_AlwaysStrafeToFirstCover = value; } } // 0x14F (335)
		
		protected bool m_CanMeleeFromScriptedCover = new bool();
		[ContainerField(Name: "CanMeleeFromScriptedCover", Offset: 336, NameHash: 4010783416, Flags: 49325), LayoutImmutable, Blittable]
		public bool CanMeleeFromScriptedCover { get { return m_CanMeleeFromScriptedCover; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(CanMeleeFromScriptedCover), this, m_CanMeleeFromScriptedCover, value)) m_CanMeleeFromScriptedCover = value; } } // 0x150 (336)
		
		protected bool m_AlwaysStrafeToCoversBehindMe = new bool();
		[ContainerField(Name: "AlwaysStrafeToCoversBehindMe", Offset: 337, NameHash: 4133324674, Flags: 49325), LayoutImmutable, Blittable]
		public bool AlwaysStrafeToCoversBehindMe { get { return m_AlwaysStrafeToCoversBehindMe; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(AlwaysStrafeToCoversBehindMe), this, m_AlwaysStrafeToCoversBehindMe, value)) m_AlwaysStrafeToCoversBehindMe = value; } } // 0x151 (337)
		
		protected bool m_UseShotAtSettings = new bool();
		[ContainerField(Name: "UseShotAtSettings", Offset: 338, NameHash: 2495588022, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseShotAtSettings { get { return m_UseShotAtSettings; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(UseShotAtSettings), this, m_UseShotAtSettings, value)) m_UseShotAtSettings = value; } } // 0x152 (338)
		
		protected bool m_StepBackIfBeingShot = new bool();
		[ContainerField(Name: "StepBackIfBeingShot", Offset: 339, NameHash: 1259696724, Flags: 49325), LayoutImmutable, Blittable]
		public bool StepBackIfBeingShot { get { return m_StepBackIfBeingShot; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(StepBackIfBeingShot), this, m_StepBackIfBeingShot, value)) m_StepBackIfBeingShot = value; } } // 0x153 (339)
		
		protected bool m_DisableMissileGravity = new bool();
		[ContainerField(Name: "DisableMissileGravity", Offset: 340, NameHash: 887985651, Flags: 49325), LayoutImmutable, Blittable]
		public bool DisableMissileGravity { get { return m_DisableMissileGravity; } set { if (OnPropertyChanging("BehaviourTemplateData." + nameof(DisableMissileGravity), this, m_DisableMissileGravity, value)) m_DisableMissileGravity = value; } } // 0x154 (340)
		
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
