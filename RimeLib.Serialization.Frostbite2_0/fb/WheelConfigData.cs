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
	[ContainerType(16, 384)]
	public partial class WheelConfigData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _Offset = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _Inertia = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private CtrRef<RotationBodyData> _RotationBody = new();

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private SphereCollisionData _SphereCollision = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private SpringData _Spring = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _Mass;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _Radius;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _Width;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _RollingResistanceInternalBaseFactor;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _RollingResistanceBaseFactor;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _RollingResistanceVelocityFactor;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _EngineBrakeVelocityFactor;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _EngineBrakeMinFactor;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _EngineBrakeMaxFactor;

		[ObservableProperty]
		[property: ContainerField(136), JsonProperty(Order = 136)]
		private List<Vec2> _TransmissionLoss = new();

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _DiffGearRatio;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _LowSpeedSteeringSensitivity;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _MidSpeedSteeringSensitivity;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _HighSpeedSteeringSensitivity;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _SensitivityRangeScale;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _LowSpeedSteeringSensitivityLimit;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _MidSpeedSteeringSensitivityLimit;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _HighSpeedSteeringSensitivityLimit;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private float _TrackedTurnSpeedLimit;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _TrackedForwardSpeedLimit;

		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private CtrRef<Curve2D> _SteerInertia = new();

		[ObservableProperty]
		[property: ContainerField(184), JsonProperty(Order = 184)]
		private List<SensitivityAtVelocity> _SteeringSensitivity = new();

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _SlopeGripMinAngle;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _SlopeGripMaxAngle;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private int _SlopeGripExponent;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _OffGroundGravityModifier;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private float _SideSlipAngleMaxSlipCondition;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _AngularVelocityMinSlipCondition;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _WheelVelocityXMinSlipCondition;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _WheelSlipRatioMaxSlipCondition;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _LongitudinalFrictionForceMaxFactor;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private float _LateralFrictionForceMaxFactor;

		[ObservableProperty]
		[property: ContainerField(228), JsonProperty(Order = 228)]
		private List<FrictionScaleAtVelocity> _LongitudeFrictionScale = new();

		[ObservableProperty]
		[property: ContainerField(232), JsonProperty(Order = 232)]
		private List<FrictionScaleAtVelocity> _LattitudeFrictionScale = new();

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private float _WheelFrictionLattitudeBrakeScale;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private float _MaxSlipRatio;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private float _Resistance;

		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private float _FxTorqueRadiusMultiplier;

		[ObservableProperty]
		[property: ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		private float _FrictionMomentVelocityMin;

		[ObservableProperty]
		[property: ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private float _FrictionMomentVelocityMax;

		[ObservableProperty]
		[property: ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		private float _FrictionMomentMultiplier;

		[ObservableProperty]
		[property: ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		private float _FrictionMomentMaxFactor;

		[ObservableProperty]
		[property: ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		private float _BrakeFactor;

		[ObservableProperty]
		[property: ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		private float _BrakeForce;

		[ObservableProperty]
		[property: ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		private float _HandBrakeFactor;

		[ObservableProperty]
		[property: ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		private float _HandBrakeForce;

		[ObservableProperty]
		[property: ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		private float _LateralPosK;

		[ObservableProperty]
		[property: ContainerField(288), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		private float _LateralNegK;

		[ObservableProperty]
		[property: ContainerField(292), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
		private float _LongitudinalPosK;

		[ObservableProperty]
		[property: ContainerField(296), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		private float _LongitudinalNegK;

		[ObservableProperty]
		[property: ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		private float _AlignMomScale;

		[ObservableProperty]
		[property: ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		private float _WheelBaseLateral;

		[ObservableProperty]
		[property: ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		private float _WheelBaseLongitudinal;

		[ObservableProperty]
		[property: ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		private int _DrivingType;

		[ObservableProperty]
		[property: ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		private int _SteeringType;

		[ObservableProperty]
		[property: ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		private int _FrictionMethod;

		[ObservableProperty]
		[property: ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		private int _AckermanDeviceType;

		[ObservableProperty]
		[property: ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		private float _CollisionYawDampeningDuration;

		[ObservableProperty]
		[property: ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		private float _CollisionYawDampening;

		[ObservableProperty]
		[property: ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		private float _ConstantSpringForceFrictionScale;

		[ObservableProperty]
		[property: ContainerField(340), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
		private int _RotationDirectionIndex;

		[ObservableProperty]
		[property: ContainerField(344), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
		private int _SteeringAngleIndex;

		[ObservableProperty]
		[property: ContainerField(348), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
		private int _PacejkaConfigIndex;

		[ObservableProperty]
		[property: ContainerField(352), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		private int _EngineIndex;

		[ObservableProperty]
		[property: ContainerField(356), JsonProperty(Order = 356)]
		private CtrRef<MaterialContainerPair> _CollisionMaterialPair = new();

		[ObservableProperty]
		[property: ContainerField(360), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
		private bool _AlwaysGrip;

		[ObservableProperty]
		[property: ContainerField(361), LayoutImmutable, Blittable, JsonProperty(Order = 361)]
		private bool _UseRollingResistanceBaseFactor;

		[ObservableProperty]
		[property: ContainerField(362), LayoutImmutable, Blittable, JsonProperty(Order = 362)]
		private bool _UseEngineBrake;

		[ObservableProperty]
		[property: ContainerField(363), LayoutImmutable, Blittable, JsonProperty(Order = 363)]
		private bool _IsAllowedToSpin;

		[ObservableProperty]
		[property: ContainerField(364), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
		private bool _HasSteeringInverted;

		[ObservableProperty]
		[property: ContainerField(365), LayoutImmutable, Blittable, JsonProperty(Order = 365)]
		private bool _UseFrictionMoment;

		[ObservableProperty]
		[property: ContainerField(366), LayoutImmutable, Blittable, JsonProperty(Order = 366)]
		private bool _UseLowSpeedAutoBrake;

		[ObservableProperty]
		[property: ContainerField(367), LayoutImmutable, Blittable, JsonProperty(Order = 367)]
		private bool _AdjustWheelRotation;

		[ObservableProperty]
		[property: ContainerField(368), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
		private bool _UseRollingResistanceVelocityFactor;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			Offset.Serialize(p_Writer, p_EbxWriter);
			Inertia.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(RotationBody));
			SphereCollision.Serialize(p_Writer, p_EbxWriter);
			Spring.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Mass);
			p_Writer.Write(Radius);
			p_Writer.Write(Width);
			p_Writer.Write(RollingResistanceInternalBaseFactor);
			p_Writer.Write(RollingResistanceBaseFactor);
			p_Writer.Write(RollingResistanceVelocityFactor);
			p_Writer.Write(EngineBrakeVelocityFactor);
			p_Writer.Write(EngineBrakeMinFactor);
			p_Writer.Write(EngineBrakeMaxFactor);
			(RimeWriter Writer, uint ArrayIndex) s_TransmissionLoss = p_EbxWriter.GetArrayWriter(TransmissionLoss.GetType(), TransmissionLoss.Count);
			p_Writer.Write(s_TransmissionLoss.ArrayIndex);
			foreach (var s_Entry in TransmissionLoss)
			{
				s_Entry.Serialize(s_TransmissionLoss.Writer, p_EbxWriter);
			}
			p_Writer.Write(DiffGearRatio);
			p_Writer.Write(LowSpeedSteeringSensitivity);
			p_Writer.Write(MidSpeedSteeringSensitivity);
			p_Writer.Write(HighSpeedSteeringSensitivity);
			p_Writer.Write(SensitivityRangeScale);
			p_Writer.Write(LowSpeedSteeringSensitivityLimit);
			p_Writer.Write(MidSpeedSteeringSensitivityLimit);
			p_Writer.Write(HighSpeedSteeringSensitivityLimit);
			p_Writer.Write(TrackedTurnSpeedLimit);
			p_Writer.Write(TrackedForwardSpeedLimit);
			p_Writer.Write(p_EbxWriter.WriteImport(SteerInertia));
			(RimeWriter Writer, uint ArrayIndex) s_SteeringSensitivity = p_EbxWriter.GetArrayWriter(SteeringSensitivity.GetType(), SteeringSensitivity.Count);
			p_Writer.Write(s_SteeringSensitivity.ArrayIndex);
			foreach (var s_Entry in SteeringSensitivity)
			{
				s_Entry.Serialize(s_SteeringSensitivity.Writer, p_EbxWriter);
			}
			p_Writer.Write(SlopeGripMinAngle);
			p_Writer.Write(SlopeGripMaxAngle);
			p_Writer.Write(SlopeGripExponent);
			p_Writer.Write(OffGroundGravityModifier);
			p_Writer.Write(SideSlipAngleMaxSlipCondition);
			p_Writer.Write(AngularVelocityMinSlipCondition);
			p_Writer.Write(WheelVelocityXMinSlipCondition);
			p_Writer.Write(WheelSlipRatioMaxSlipCondition);
			p_Writer.Write(LongitudinalFrictionForceMaxFactor);
			p_Writer.Write(LateralFrictionForceMaxFactor);
			(RimeWriter Writer, uint ArrayIndex) s_LongitudeFrictionScale = p_EbxWriter.GetArrayWriter(LongitudeFrictionScale.GetType(), LongitudeFrictionScale.Count);
			p_Writer.Write(s_LongitudeFrictionScale.ArrayIndex);
			foreach (var s_Entry in LongitudeFrictionScale)
			{
				s_Entry.Serialize(s_LongitudeFrictionScale.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_LattitudeFrictionScale = p_EbxWriter.GetArrayWriter(LattitudeFrictionScale.GetType(), LattitudeFrictionScale.Count);
			p_Writer.Write(s_LattitudeFrictionScale.ArrayIndex);
			foreach (var s_Entry in LattitudeFrictionScale)
			{
				s_Entry.Serialize(s_LattitudeFrictionScale.Writer, p_EbxWriter);
			}
			p_Writer.Write(WheelFrictionLattitudeBrakeScale);
			p_Writer.Write(MaxSlipRatio);
			p_Writer.Write(Resistance);
			p_Writer.Write(FxTorqueRadiusMultiplier);
			p_Writer.Write(FrictionMomentVelocityMin);
			p_Writer.Write(FrictionMomentVelocityMax);
			p_Writer.Write(FrictionMomentMultiplier);
			p_Writer.Write(FrictionMomentMaxFactor);
			p_Writer.Write(BrakeFactor);
			p_Writer.Write(BrakeForce);
			p_Writer.Write(HandBrakeFactor);
			p_Writer.Write(HandBrakeForce);
			p_Writer.Write(LateralPosK);
			p_Writer.Write(LateralNegK);
			p_Writer.Write(LongitudinalPosK);
			p_Writer.Write(LongitudinalNegK);
			p_Writer.Write(AlignMomScale);
			p_Writer.Write(WheelBaseLateral);
			p_Writer.Write(WheelBaseLongitudinal);
			p_Writer.Write(DrivingType);
			p_Writer.Write(SteeringType);
			p_Writer.Write(FrictionMethod);
			p_Writer.Write(AckermanDeviceType);
			p_Writer.Write(CollisionYawDampeningDuration);
			p_Writer.Write(CollisionYawDampening);
			p_Writer.Write(ConstantSpringForceFrictionScale);
			p_Writer.Write(RotationDirectionIndex);
			p_Writer.Write(SteeringAngleIndex);
			p_Writer.Write(PacejkaConfigIndex);
			p_Writer.Write(EngineIndex);
			p_Writer.Write(p_EbxWriter.WriteImport(CollisionMaterialPair));
			p_Writer.Write(AlwaysGrip);
			p_Writer.Write(UseRollingResistanceBaseFactor);
			p_Writer.Write(UseEngineBrake);
			p_Writer.Write(IsAllowedToSpin);
			p_Writer.Write(HasSteeringInverted);
			p_Writer.Write(UseFrictionMoment);
			p_Writer.Write(UseLowSpeedAutoBrake);
			p_Writer.Write(AdjustWheelRotation);
			p_Writer.Write(UseRollingResistanceVelocityFactor);
			p_Writer.WriteNullBytes(15);
		}
	}
}
