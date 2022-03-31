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

namespace fb
{
	[ContainerType(16, 384)]
	public class WheelConfigData :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 Offset { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 Inertia { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<RotationBodyData> RotationBody { get; set; } = new();

		[ContainerField(52), JsonProperty(Order = 52)]
		public SphereCollisionData SphereCollision { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public SpringData Spring { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float Mass { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float Radius { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float Width { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float RollingResistanceInternalBaseFactor { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float RollingResistanceBaseFactor { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float RollingResistanceVelocityFactor { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float EngineBrakeVelocityFactor { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float EngineBrakeMinFactor { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float EngineBrakeMaxFactor { get; set; }

		[ContainerField(136), JsonProperty(Order = 136)]
		public List<Vec2> TransmissionLoss { get; set; } = new();

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float DiffGearRatio { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float LowSpeedSteeringSensitivity { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float MidSpeedSteeringSensitivity { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float HighSpeedSteeringSensitivity { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float SensitivityRangeScale { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float LowSpeedSteeringSensitivityLimit { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float MidSpeedSteeringSensitivityLimit { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float HighSpeedSteeringSensitivityLimit { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public float TrackedTurnSpeedLimit { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float TrackedForwardSpeedLimit { get; set; }

		[ContainerField(180), JsonProperty(Order = 180)]
		public CtrRef<Curve2D> SteerInertia { get; set; } = new();

		[ContainerField(184), JsonProperty(Order = 184)]
		public List<SensitivityAtVelocity> SteeringSensitivity { get; set; } = new();

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float SlopeGripMinAngle { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float SlopeGripMaxAngle { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public int SlopeGripExponent { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public float OffGroundGravityModifier { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public float SideSlipAngleMaxSlipCondition { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float AngularVelocityMinSlipCondition { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public float WheelVelocityXMinSlipCondition { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float WheelSlipRatioMaxSlipCondition { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public float LongitudinalFrictionForceMaxFactor { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public float LateralFrictionForceMaxFactor { get; set; }

		[ContainerField(228), JsonProperty(Order = 228)]
		public List<FrictionScaleAtVelocity> LongitudeFrictionScale { get; set; } = new();

		[ContainerField(232), JsonProperty(Order = 232)]
		public List<FrictionScaleAtVelocity> LattitudeFrictionScale { get; set; } = new();

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public float WheelFrictionLattitudeBrakeScale { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public float MaxSlipRatio { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public float Resistance { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		public float FxTorqueRadiusMultiplier { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		public float FrictionMomentVelocityMin { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public float FrictionMomentVelocityMax { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		public float FrictionMomentMultiplier { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		public float FrictionMomentMaxFactor { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		public float BrakeFactor { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		public float BrakeForce { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		public float HandBrakeFactor { get; set; }

		[ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		public float HandBrakeForce { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		public float LateralPosK { get; set; }

		[ContainerField(288), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		public float LateralNegK { get; set; }

		[ContainerField(292), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
		public float LongitudinalPosK { get; set; }

		[ContainerField(296), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		public float LongitudinalNegK { get; set; }

		[ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		public float AlignMomScale { get; set; }

		[ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		public float WheelBaseLateral { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		public float WheelBaseLongitudinal { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		public int DrivingType { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		public int SteeringType { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		public int FrictionMethod { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		public int AckermanDeviceType { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		public float CollisionYawDampeningDuration { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		public float CollisionYawDampening { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		public float ConstantSpringForceFrictionScale { get; set; }

		[ContainerField(340), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
		public int RotationDirectionIndex { get; set; }

		[ContainerField(344), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
		public int SteeringAngleIndex { get; set; }

		[ContainerField(348), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
		public int PacejkaConfigIndex { get; set; }

		[ContainerField(352), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		public int EngineIndex { get; set; }

		[ContainerField(356), JsonProperty(Order = 356)]
		public CtrRef<MaterialContainerPair> CollisionMaterialPair { get; set; } = new();

		[ContainerField(360), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
		public bool AlwaysGrip { get; set; }

		[ContainerField(361), LayoutImmutable, Blittable, JsonProperty(Order = 361)]
		public bool UseRollingResistanceBaseFactor { get; set; }

		[ContainerField(362), LayoutImmutable, Blittable, JsonProperty(Order = 362)]
		public bool UseEngineBrake { get; set; }

		[ContainerField(363), LayoutImmutable, Blittable, JsonProperty(Order = 363)]
		public bool IsAllowedToSpin { get; set; }

		[ContainerField(364), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
		public bool HasSteeringInverted { get; set; }

		[ContainerField(365), LayoutImmutable, Blittable, JsonProperty(Order = 365)]
		public bool UseFrictionMoment { get; set; }

		[ContainerField(366), LayoutImmutable, Blittable, JsonProperty(Order = 366)]
		public bool UseLowSpeedAutoBrake { get; set; }

		[ContainerField(367), LayoutImmutable, Blittable, JsonProperty(Order = 367)]
		public bool AdjustWheelRotation { get; set; }

		[ContainerField(368), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
		public bool UseRollingResistanceVelocityFactor { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
