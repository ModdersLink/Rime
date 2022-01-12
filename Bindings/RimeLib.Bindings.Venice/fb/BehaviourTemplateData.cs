///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 344)]
	public class BehaviourTemplateData : 
		GameBehaviourTemplateData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float StandProbability { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float CrouchProbability { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float TurnAgainstTargetDistance { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float InvestigateStopDelay { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float ExplosiveObjectChance { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint MinAttackBursts { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint MaxAttackBursts { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AttackUrgencyModifier { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float AltAttackProbability { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float ReadinessReactionTimeMultiplier { get; set; }

		[ContainerField(52)]
		public UIntRange FireBlindOverBurstCount { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable]
		public float CloseRangeAccuracyDistanceOverride { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float MeleeRange { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float MeleeMaxTime { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float MeleeProbability { get; set; }

		[ContainerField(76)]
		public FloatRangeDefaultZero CoverSwitchTime { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public float FireStyleTimeout { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float FireLeanChance { get; set; }

		[ContainerField(92)]
		public UIntRange FireLeanBurstCount { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float FireStepOutChance { get; set; }

		[ContainerField(104)]
		public UIntRange FireStepOutBurstCount { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public float FireStepOutSlowChance { get; set; }

		[ContainerField(116)]
		public UIntRange FireStepOutSlowBurstCount { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable]
		public float FireStepOutUrgentChance { get; set; }

		[ContainerField(128)]
		public UIntRange FireStepOutUrgentBurstCount { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable]
		public float FireStepOutFireFromHipChance { get; set; }

		[ContainerField(140)]
		public UIntRange FireStepOutFireFromHipBurstCount { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public float FireStepOutStandToCrouchChance { get; set; }

		[ContainerField(152)]
		public UIntRange FireStepOutStandToCrouchBurstCount { get; set; } = new();

		[ContainerField(160)]
		public CoverFireType AlwaysInFirePose { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable]
		public float FireGrenadeStepOutChance { get; set; }

		[ContainerField(168)]
		public UIntRange FireGrenadeStepOutBurstCount { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public float FireOverChance { get; set; }

		[ContainerField(180)]
		public UIntRange FireOverBurstCount { get; set; } = new();

		[ContainerField(188), LayoutImmutable, Blittable]
		public float FireBlindOutChance { get; set; }

		[ContainerField(192)]
		public UIntRange FireBlindOutBurstCount { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable]
		public float FireBlindOverChance { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public int SuppressingBurstCount { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public float FireGrenadeBlindOverChance { get; set; }

		[ContainerField(212)]
		public UIntRange FireGrenadeBlindOverBurstCount { get; set; } = new();

		[ContainerField(220), LayoutImmutable, Blittable]
		public float FireLmgChance { get; set; }

		[ContainerField(224)]
		public UIntRange FireLmgBurstCount { get; set; } = new();

		[ContainerField(232), LayoutImmutable, Blittable]
		public float ShotAtFireGrenadeBlindOverChance { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public int SuppressingBurstCountMin { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public int SuppressingBurstCountMax { get; set; }

		[ContainerField(244)]
		public FloatRange CoverWaitTime { get; set; } = new();

		[ContainerField(252), LayoutImmutable, Blittable]
		public float MaxAngleDiffForBlindFire { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable]
		public float StrafeToCoverProbablity { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable]
		public float MaxSuppressTime { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable]
		public float InvestigateVisualTestDist { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable]
		public float AlwaysStrafeToCoversWithinDistance { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable]
		public float ChargeSurpriseVelocity { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable]
		public float ChargeSurpriseNearDistance { get; set; }

		[ContainerField(280), LayoutImmutable, Blittable]
		public float ChargeSurpriseFlankedDistance { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable]
		public float ShotAtFireBlindOutChance { get; set; }

		[ContainerField(288), LayoutImmutable, Blittable]
		public float ShotAtFireBlindOverChance { get; set; }

		[ContainerField(292), LayoutImmutable, Blittable]
		public float AccuracyIncreaseTime { get; set; }

		[ContainerField(296), LayoutImmutable, Blittable]
		public float TargetStrengthFactor { get; set; }

		[ContainerField(300), LayoutImmutable, Blittable]
		public float ReloadBelowPercent { get; set; }

		[ContainerField(304), LayoutImmutable, Blittable]
		public float TargetDistanceFactor { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable]
		public float SuppressIndirectProbability { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable]
		public float TargetDangerFactor { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable]
		public float TargetIsAttackingFactor { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable]
		public float AccuracyModifierVsNonHumans { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable]
		public float AccuracyModifier { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable]
		public float SoldierMovementVolumeOverride { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable]
		public bool AlwaysUpdate { get; set; }

		[ContainerField(333), LayoutImmutable, Blittable]
		public bool LeaveVehicleOnSearchAndDestroyOrder { get; set; }

		[ContainerField(334), LayoutImmutable, Blittable]
		public bool ShouldFireThroughSmoke { get; set; }

		[ContainerField(335), LayoutImmutable, Blittable]
		public bool AlwaysStrafeToFirstCover { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable]
		public bool CanMeleeFromScriptedCover { get; set; }

		[ContainerField(337), LayoutImmutable, Blittable]
		public bool AlwaysStrafeToCoversBehindMe { get; set; }

		[ContainerField(338), LayoutImmutable, Blittable]
		public bool UseShotAtSettings { get; set; }

		[ContainerField(339), LayoutImmutable, Blittable]
		public bool StepBackIfBeingShot { get; set; }

		[ContainerField(340), LayoutImmutable, Blittable]
		public bool DisableMissileGravity { get; set; }

	}
}
