///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
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
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float StandProbability { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float CrouchProbability { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float TurnAgainstTargetDistance { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float InvestigateStopDelay { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ExplosiveObjectChance { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint MinAttackBursts { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint MaxAttackBursts { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float AttackUrgencyModifier { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float AltAttackProbability { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float ReadinessReactionTimeMultiplier { get; set; }

		[ContainerField(52), JsonProperty(Order = 52)]
		public UIntRange FireBlindOverBurstCount { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float CloseRangeAccuracyDistanceOverride { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float MeleeRange { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float MeleeMaxTime { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float MeleeProbability { get; set; }

		[ContainerField(76), JsonProperty(Order = 76)]
		public FloatRangeDefaultZero CoverSwitchTime { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float FireStyleTimeout { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float FireLeanChance { get; set; }

		[ContainerField(92), JsonProperty(Order = 92)]
		public UIntRange FireLeanBurstCount { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float FireStepOutChance { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public UIntRange FireStepOutBurstCount { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float FireStepOutSlowChance { get; set; }

		[ContainerField(116), JsonProperty(Order = 116)]
		public UIntRange FireStepOutSlowBurstCount { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float FireStepOutUrgentChance { get; set; }

		[ContainerField(128), JsonProperty(Order = 128)]
		public UIntRange FireStepOutUrgentBurstCount { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float FireStepOutFireFromHipChance { get; set; }

		[ContainerField(140), JsonProperty(Order = 140)]
		public UIntRange FireStepOutFireFromHipBurstCount { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float FireStepOutStandToCrouchChance { get; set; }

		[ContainerField(152), JsonProperty(Order = 152)]
		public UIntRange FireStepOutStandToCrouchBurstCount { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public CoverFireType AlwaysInFirePose { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float FireGrenadeStepOutChance { get; set; }

		[ContainerField(168), JsonProperty(Order = 168)]
		public UIntRange FireGrenadeStepOutBurstCount { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float FireOverChance { get; set; }

		[ContainerField(180), JsonProperty(Order = 180)]
		public UIntRange FireOverBurstCount { get; set; } = new();

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float FireBlindOutChance { get; set; }

		[ContainerField(192), JsonProperty(Order = 192)]
		public UIntRange FireBlindOutBurstCount { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public float FireBlindOverChance { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public int SuppressingBurstCount { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float FireGrenadeBlindOverChance { get; set; }

		[ContainerField(212), JsonProperty(Order = 212)]
		public UIntRange FireGrenadeBlindOverBurstCount { get; set; } = new();

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public float FireLmgChance { get; set; }

		[ContainerField(224), JsonProperty(Order = 224)]
		public UIntRange FireLmgBurstCount { get; set; } = new();

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public float ShotAtFireGrenadeBlindOverChance { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public int SuppressingBurstCountMin { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public int SuppressingBurstCountMax { get; set; }

		[ContainerField(244), JsonProperty(Order = 244)]
		public FloatRange CoverWaitTime { get; set; } = new();

		[ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		public float MaxAngleDiffForBlindFire { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public float StrafeToCoverProbablity { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		public float MaxSuppressTime { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		public float InvestigateVisualTestDist { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		public float AlwaysStrafeToCoversWithinDistance { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		public float ChargeSurpriseVelocity { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		public float ChargeSurpriseNearDistance { get; set; }

		[ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		public float ChargeSurpriseFlankedDistance { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		public float ShotAtFireBlindOutChance { get; set; }

		[ContainerField(288), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		public float ShotAtFireBlindOverChance { get; set; }

		[ContainerField(292), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
		public float AccuracyIncreaseTime { get; set; }

		[ContainerField(296), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		public float TargetStrengthFactor { get; set; }

		[ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		public float ReloadBelowPercent { get; set; }

		[ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		public float TargetDistanceFactor { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		public float SuppressIndirectProbability { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		public float TargetDangerFactor { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		public float TargetIsAttackingFactor { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		public float AccuracyModifierVsNonHumans { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		public float AccuracyModifier { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		public float SoldierMovementVolumeOverride { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		public bool AlwaysUpdate { get; set; }

		[ContainerField(333), LayoutImmutable, Blittable, JsonProperty(Order = 333)]
		public bool LeaveVehicleOnSearchAndDestroyOrder { get; set; }

		[ContainerField(334), LayoutImmutable, Blittable, JsonProperty(Order = 334)]
		public bool ShouldFireThroughSmoke { get; set; }

		[ContainerField(335), LayoutImmutable, Blittable, JsonProperty(Order = 335)]
		public bool AlwaysStrafeToFirstCover { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		public bool CanMeleeFromScriptedCover { get; set; }

		[ContainerField(337), LayoutImmutable, Blittable, JsonProperty(Order = 337)]
		public bool AlwaysStrafeToCoversBehindMe { get; set; }

		[ContainerField(338), LayoutImmutable, Blittable, JsonProperty(Order = 338)]
		public bool UseShotAtSettings { get; set; }

		[ContainerField(339), LayoutImmutable, Blittable, JsonProperty(Order = 339)]
		public bool StepBackIfBeingShot { get; set; }

		[ContainerField(340), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
		public bool DisableMissileGravity { get; set; }

	}
}
