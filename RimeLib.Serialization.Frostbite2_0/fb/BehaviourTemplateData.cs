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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 344)]
	public partial class BehaviourTemplateData :
		GameBehaviourTemplateData
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _StandProbability;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _CrouchProbability;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _TurnAgainstTargetDistance;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _InvestigateStopDelay;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _ExplosiveObjectChance;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _MinAttackBursts;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _MaxAttackBursts;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _AttackUrgencyModifier;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _AltAttackProbability;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _ReadinessReactionTimeMultiplier;

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private UIntRange _FireBlindOverBurstCount = new();

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _CloseRangeAccuracyDistanceOverride;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _MeleeRange;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _MeleeMaxTime;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _MeleeProbability;

		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private FloatRangeDefaultZero _CoverSwitchTime = new();

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _FireStyleTimeout;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _FireLeanChance;

		[ObservableProperty]
		[property: ContainerField(92), JsonProperty(Order = 92)]
		private UIntRange _FireLeanBurstCount = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _FireStepOutChance;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private UIntRange _FireStepOutBurstCount = new();

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _FireStepOutSlowChance;

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private UIntRange _FireStepOutSlowBurstCount = new();

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _FireStepOutUrgentChance;

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private UIntRange _FireStepOutUrgentBurstCount = new();

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _FireStepOutFireFromHipChance;

		[ObservableProperty]
		[property: ContainerField(140), JsonProperty(Order = 140)]
		private UIntRange _FireStepOutFireFromHipBurstCount = new();

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _FireStepOutStandToCrouchChance;

		[ObservableProperty]
		[property: ContainerField(152), JsonProperty(Order = 152)]
		private UIntRange _FireStepOutStandToCrouchBurstCount = new();

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private CoverFireType _AlwaysInFirePose = new();

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _FireGrenadeStepOutChance;

		[ObservableProperty]
		[property: ContainerField(168), JsonProperty(Order = 168)]
		private UIntRange _FireGrenadeStepOutBurstCount = new();

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _FireOverChance;

		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private UIntRange _FireOverBurstCount = new();

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _FireBlindOutChance;

		[ObservableProperty]
		[property: ContainerField(192), JsonProperty(Order = 192)]
		private UIntRange _FireBlindOutBurstCount = new();

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _FireBlindOverChance;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private int _SuppressingBurstCount;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _FireGrenadeBlindOverChance;

		[ObservableProperty]
		[property: ContainerField(212), JsonProperty(Order = 212)]
		private UIntRange _FireGrenadeBlindOverBurstCount = new();

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _FireLmgChance;

		[ObservableProperty]
		[property: ContainerField(224), JsonProperty(Order = 224)]
		private UIntRange _FireLmgBurstCount = new();

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private float _ShotAtFireGrenadeBlindOverChance;

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private int _SuppressingBurstCountMin;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private int _SuppressingBurstCountMax;

		[ObservableProperty]
		[property: ContainerField(244), JsonProperty(Order = 244)]
		private FloatRange _CoverWaitTime = new();

		[ObservableProperty]
		[property: ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		private float _MaxAngleDiffForBlindFire;

		[ObservableProperty]
		[property: ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private float _StrafeToCoverProbablity;

		[ObservableProperty]
		[property: ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		private float _MaxSuppressTime;

		[ObservableProperty]
		[property: ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		private float _InvestigateVisualTestDist;

		[ObservableProperty]
		[property: ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		private float _AlwaysStrafeToCoversWithinDistance;

		[ObservableProperty]
		[property: ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		private float _ChargeSurpriseVelocity;

		[ObservableProperty]
		[property: ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		private float _ChargeSurpriseNearDistance;

		[ObservableProperty]
		[property: ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		private float _ChargeSurpriseFlankedDistance;

		[ObservableProperty]
		[property: ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		private float _ShotAtFireBlindOutChance;

		[ObservableProperty]
		[property: ContainerField(288), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		private float _ShotAtFireBlindOverChance;

		[ObservableProperty]
		[property: ContainerField(292), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
		private float _AccuracyIncreaseTime;

		[ObservableProperty]
		[property: ContainerField(296), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		private float _TargetStrengthFactor;

		[ObservableProperty]
		[property: ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		private float _ReloadBelowPercent;

		[ObservableProperty]
		[property: ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		private float _TargetDistanceFactor;

		[ObservableProperty]
		[property: ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		private float _SuppressIndirectProbability;

		[ObservableProperty]
		[property: ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		private float _TargetDangerFactor;

		[ObservableProperty]
		[property: ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		private float _TargetIsAttackingFactor;

		[ObservableProperty]
		[property: ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		private float _AccuracyModifierVsNonHumans;

		[ObservableProperty]
		[property: ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		private float _AccuracyModifier;

		[ObservableProperty]
		[property: ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		private float _SoldierMovementVolumeOverride;

		[ObservableProperty]
		[property: ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		private bool _AlwaysUpdate;

		[ObservableProperty]
		[property: ContainerField(333), LayoutImmutable, Blittable, JsonProperty(Order = 333)]
		private bool _LeaveVehicleOnSearchAndDestroyOrder;

		[ObservableProperty]
		[property: ContainerField(334), LayoutImmutable, Blittable, JsonProperty(Order = 334)]
		private bool _ShouldFireThroughSmoke;

		[ObservableProperty]
		[property: ContainerField(335), LayoutImmutable, Blittable, JsonProperty(Order = 335)]
		private bool _AlwaysStrafeToFirstCover;

		[ObservableProperty]
		[property: ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		private bool _CanMeleeFromScriptedCover;

		[ObservableProperty]
		[property: ContainerField(337), LayoutImmutable, Blittable, JsonProperty(Order = 337)]
		private bool _AlwaysStrafeToCoversBehindMe;

		[ObservableProperty]
		[property: ContainerField(338), LayoutImmutable, Blittable, JsonProperty(Order = 338)]
		private bool _UseShotAtSettings;

		[ObservableProperty]
		[property: ContainerField(339), LayoutImmutable, Blittable, JsonProperty(Order = 339)]
		private bool _StepBackIfBeingShot;

		[ObservableProperty]
		[property: ContainerField(340), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
		private bool _DisableMissileGravity;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(StandProbability);
			p_Writer.Write(CrouchProbability);
			p_Writer.Write(TurnAgainstTargetDistance);
			p_Writer.Write(InvestigateStopDelay);
			p_Writer.Write(ExplosiveObjectChance);
			p_Writer.Write(MinAttackBursts);
			p_Writer.Write(MaxAttackBursts);
			p_Writer.Write(AttackUrgencyModifier);
			p_Writer.Write(AltAttackProbability);
			p_Writer.Write(ReadinessReactionTimeMultiplier);
			FireBlindOverBurstCount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CloseRangeAccuracyDistanceOverride);
			p_Writer.Write(MeleeRange);
			p_Writer.Write(MeleeMaxTime);
			p_Writer.Write(MeleeProbability);
			CoverSwitchTime.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FireStyleTimeout);
			p_Writer.Write(FireLeanChance);
			FireLeanBurstCount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FireStepOutChance);
			FireStepOutBurstCount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FireStepOutSlowChance);
			FireStepOutSlowBurstCount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FireStepOutUrgentChance);
			FireStepOutUrgentBurstCount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FireStepOutFireFromHipChance);
			FireStepOutFireFromHipBurstCount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FireStepOutStandToCrouchChance);
			FireStepOutStandToCrouchBurstCount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) AlwaysInFirePose);
			p_Writer.Write(FireGrenadeStepOutChance);
			FireGrenadeStepOutBurstCount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FireOverChance);
			FireOverBurstCount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FireBlindOutChance);
			FireBlindOutBurstCount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FireBlindOverChance);
			p_Writer.Write(SuppressingBurstCount);
			p_Writer.Write(FireGrenadeBlindOverChance);
			FireGrenadeBlindOverBurstCount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FireLmgChance);
			FireLmgBurstCount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ShotAtFireGrenadeBlindOverChance);
			p_Writer.Write(SuppressingBurstCountMin);
			p_Writer.Write(SuppressingBurstCountMax);
			CoverWaitTime.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MaxAngleDiffForBlindFire);
			p_Writer.Write(StrafeToCoverProbablity);
			p_Writer.Write(MaxSuppressTime);
			p_Writer.Write(InvestigateVisualTestDist);
			p_Writer.Write(AlwaysStrafeToCoversWithinDistance);
			p_Writer.Write(ChargeSurpriseVelocity);
			p_Writer.Write(ChargeSurpriseNearDistance);
			p_Writer.Write(ChargeSurpriseFlankedDistance);
			p_Writer.Write(ShotAtFireBlindOutChance);
			p_Writer.Write(ShotAtFireBlindOverChance);
			p_Writer.Write(AccuracyIncreaseTime);
			p_Writer.Write(TargetStrengthFactor);
			p_Writer.Write(ReloadBelowPercent);
			p_Writer.Write(TargetDistanceFactor);
			p_Writer.Write(SuppressIndirectProbability);
			p_Writer.Write(TargetDangerFactor);
			p_Writer.Write(TargetIsAttackingFactor);
			p_Writer.Write(AccuracyModifierVsNonHumans);
			p_Writer.Write(AccuracyModifier);
			p_Writer.Write(SoldierMovementVolumeOverride);
			p_Writer.Write(AlwaysUpdate);
			p_Writer.Write(LeaveVehicleOnSearchAndDestroyOrder);
			p_Writer.Write(ShouldFireThroughSmoke);
			p_Writer.Write(AlwaysStrafeToFirstCover);
			p_Writer.Write(CanMeleeFromScriptedCover);
			p_Writer.Write(AlwaysStrafeToCoversBehindMe);
			p_Writer.Write(UseShotAtSettings);
			p_Writer.Write(StepBackIfBeingShot);
			p_Writer.Write(DisableMissileGravity);
			p_Writer.WriteNullBytes(3);
		}
	}
}
