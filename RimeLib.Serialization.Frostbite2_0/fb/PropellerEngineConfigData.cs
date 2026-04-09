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
	[ContainerType(16, 256)]
	public partial class PropellerEngineConfigData :
		EngineConfigData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _HorisontalForceOffset = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private PropellerType _PropellerType = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private CtrRef<RotorParameters> _RotorConfig = new();

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private ForceMagnitudeInputType _ForceMagnitudeInputType = new();

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private uint _DirectionVectorIndex;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _ForceMagnitudeMultiplier;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _LiftForceSpringConstant;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _LiftForceDampingConstant;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _CyclicInputScaleRoll;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _CyclicRollLiftMod;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _CyclicRollStrafeMod;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _CyclicInputScalePitch;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _CyclicPitchLiftMod;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _CyclicPitchStrafeMod;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _CyclicPitchStrafeBrakeMod;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _CollectiveInputIdle;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private float _CollectiveThrottleInputScale;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _CollectiveBrakeInputScale;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _DefaultAngleOfAttack;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _AttackAngleMod;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _StabilizerMod;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _HorisontalMinEffectVelocity;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private float _HorisontalMinEffectMod;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _PitchStrength;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private float _PitchFromVel;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _GravityMod;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _SPForwardStrength;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _SPSidewaysStrength;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _SPVerticalStrength;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private float _VelocityFromPitch;

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private float _PitchLimit;

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private float _BankingStrength;

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private float _BankingLimit;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private float _RollStrength;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private float _PitchUpWhenBankStrength;

		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private float _PitchUpWhenBankLimit;

		[ObservableProperty]
		[property: ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		private bool _SPDefault;

		[ObservableProperty]
		[property: ContainerField(253), LayoutImmutable, Blittable, JsonProperty(Order = 253)]
		private bool _EnableNewHelicopter;

		[ObservableProperty]
		[property: ContainerField(254), LayoutImmutable, Blittable, JsonProperty(Order = 254)]
		private bool _SPAllowed;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			HorisontalForceOffset.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) PropellerType);
			p_Writer.Write(p_EbxWriter.WriteImport(RotorConfig));
			p_Writer.Write((int) ForceMagnitudeInputType);
			p_Writer.Write(DirectionVectorIndex);
			p_Writer.Write(ForceMagnitudeMultiplier);
			p_Writer.Write(LiftForceSpringConstant);
			p_Writer.Write(LiftForceDampingConstant);
			p_Writer.Write(CyclicInputScaleRoll);
			p_Writer.Write(CyclicRollLiftMod);
			p_Writer.Write(CyclicRollStrafeMod);
			p_Writer.Write(CyclicInputScalePitch);
			p_Writer.Write(CyclicPitchLiftMod);
			p_Writer.Write(CyclicPitchStrafeMod);
			p_Writer.Write(CyclicPitchStrafeBrakeMod);
			p_Writer.Write(CollectiveInputIdle);
			p_Writer.Write(CollectiveThrottleInputScale);
			p_Writer.Write(CollectiveBrakeInputScale);
			p_Writer.Write(DefaultAngleOfAttack);
			p_Writer.Write(AttackAngleMod);
			p_Writer.Write(StabilizerMod);
			p_Writer.Write(HorisontalMinEffectVelocity);
			p_Writer.Write(HorisontalMinEffectMod);
			p_Writer.Write(PitchStrength);
			p_Writer.Write(PitchFromVel);
			p_Writer.Write(GravityMod);
			p_Writer.Write(SPForwardStrength);
			p_Writer.Write(SPSidewaysStrength);
			p_Writer.Write(SPVerticalStrength);
			p_Writer.Write(VelocityFromPitch);
			p_Writer.Write(PitchLimit);
			p_Writer.Write(BankingStrength);
			p_Writer.Write(BankingLimit);
			p_Writer.Write(RollStrength);
			p_Writer.Write(PitchUpWhenBankStrength);
			p_Writer.Write(PitchUpWhenBankLimit);
			p_Writer.Write(SPDefault);
			p_Writer.Write(EnableNewHelicopter);
			p_Writer.Write(SPAllowed);
			p_Writer.WriteNullBytes(1);
		}
	}
}
