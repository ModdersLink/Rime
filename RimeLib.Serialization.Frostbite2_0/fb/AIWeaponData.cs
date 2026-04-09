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
	[ContainerType(4, 156)]
	public partial class AIWeaponData :
		GameAIWeaponData
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private Strengths _Strengths = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _MaxBurstCoolDownTime;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _LostTargetBurstCoolDownModifier;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _FinalAccuracyPercentage;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _AimTransitionFireDelay;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _MinRange;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _MaxRange;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _OptimalRangePercentage;

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private ReloadBehavior _ReloadBehavior = new();

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _MinExtraReloadTime;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _MaxExtraReloadTime;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _MinBurstCoolDownTime;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _AimAngularVelocity;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _InnerInaccurateDistance;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _AngleToTargetSnap;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _SweepDistance;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _SweepTime;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _WaitTimeBeforeFire;

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private BurstLimit _BurstLimitNear = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private BurstLimit _BurstLimitFar = new();

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _StartAccuracyPercentage;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _MinimumAccuracyBeforeFiring;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _OuterInaccurateDistance;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _AdditionalMinimumAccuracyAtMinRange;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _GravityModifier;

		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private SweepSelectionType _SweepType = new();

		[ObservableProperty]
		[property: ContainerField(136), JsonProperty(Order = 136)]
		private AimOrigin _AimOrigin = new();

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private bool _UseZoom;

		[ObservableProperty]
		[property: ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		private bool _AllowedAgainstImmortals;

		[ObservableProperty]
		[property: ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		private bool _AimWhileReloading;

		[ObservableProperty]
		[property: ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		private bool _AimHighIndirectPath;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private bool _Indirect;

		[ObservableProperty]
		[property: ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		private bool _IsMelee;

		[ObservableProperty]
		[property: ContainerField(146), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
		private bool _SweepFirstAttack;

		[ObservableProperty]
		[property: ContainerField(147), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
		private bool _IsBlindFireAllowed;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private bool _CanAltAttack;

		[ObservableProperty]
		[property: ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		private bool _IsStandStill;

		[ObservableProperty]
		[property: ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		private bool _CanSuppress;

		[ObservableProperty]
		[property: ContainerField(151), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
		private bool _UseFromCover;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private bool _InaccuracyFollowsTarget;

		[ObservableProperty]
		[property: ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		private bool _UseInaccuracyAtCloseRange;

		[ObservableProperty]
		[property: ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		private bool _DisableWeaponSway;

		[ObservableProperty]
		[property: ContainerField(155), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
		private bool _IsAiAllowed;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Strengths.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MaxBurstCoolDownTime);
			p_Writer.Write(LostTargetBurstCoolDownModifier);
			p_Writer.Write(FinalAccuracyPercentage);
			p_Writer.Write(AimTransitionFireDelay);
			p_Writer.Write(MinRange);
			p_Writer.Write(MaxRange);
			p_Writer.Write(OptimalRangePercentage);
			p_Writer.Write((int) ReloadBehavior);
			p_Writer.Write(MinExtraReloadTime);
			p_Writer.Write(MaxExtraReloadTime);
			p_Writer.Write(MinBurstCoolDownTime);
			p_Writer.Write(AimAngularVelocity);
			p_Writer.Write(InnerInaccurateDistance);
			p_Writer.Write(AngleToTargetSnap);
			p_Writer.Write(SweepDistance);
			p_Writer.Write(SweepTime);
			p_Writer.Write(WaitTimeBeforeFire);
			BurstLimitNear.Serialize(p_Writer, p_EbxWriter);
			BurstLimitFar.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(StartAccuracyPercentage);
			p_Writer.Write(MinimumAccuracyBeforeFiring);
			p_Writer.Write(OuterInaccurateDistance);
			p_Writer.Write(AdditionalMinimumAccuracyAtMinRange);
			p_Writer.Write(GravityModifier);
			p_Writer.Write((int) SweepType);
			p_Writer.Write((int) AimOrigin);
			p_Writer.Write(UseZoom);
			p_Writer.Write(AllowedAgainstImmortals);
			p_Writer.Write(AimWhileReloading);
			p_Writer.Write(AimHighIndirectPath);
			p_Writer.Write(Indirect);
			p_Writer.Write(IsMelee);
			p_Writer.Write(SweepFirstAttack);
			p_Writer.Write(IsBlindFireAllowed);
			p_Writer.Write(CanAltAttack);
			p_Writer.Write(IsStandStill);
			p_Writer.Write(CanSuppress);
			p_Writer.Write(UseFromCover);
			p_Writer.Write(InaccuracyFollowsTarget);
			p_Writer.Write(UseInaccuracyAtCloseRange);
			p_Writer.Write(DisableWeaponSway);
			p_Writer.Write(IsAiAllowed);
		}
	}
}
