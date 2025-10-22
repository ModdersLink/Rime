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

using fb.Core;
using fb.Entity;

namespace fb.Physics;

[ContainerType(16, 416)]
public class WheelConfigData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<RotationBodyData> RotationBody { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public SphereCollisionData SphereCollision { get; set; } = new();
	
	[ContainerField(0x24), JsonProperty(Order = 36)]
	public SpringData Spring { get; set; } = new();
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float Mass { get; set; } = 10.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float Radius { get; set; } = 0.500f;
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec3 Offset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 Inertia { get; set; } = new()
	{
		z = 2.000f,
		y = 2.000f,
		x = 2.000f,
	};
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float Width { get; set; } = 0.200f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float RollingResistanceInternalBaseFactor { get; set; } = 15.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float RollingResistanceBaseFactor { get; set; } = 15.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float RollingResistanceVelocityFactor { get; set; } = 150.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float EngineBrakeVelocityFactor { get; set; } = 25.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float EngineBrakeMinFactor { get; set; } = 0.500f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float EngineBrakeMaxFactor { get; set; } = 1.000f;
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public List<Vec2> TransmissionLoss { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float DiffGearRatio { get; set; } = 5.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float LowSpeedSteeringSensitivity { get; set; } = 1.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float MidSpeedSteeringSensitivity { get; set; } = 1.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float HighSpeedSteeringSensitivity { get; set; } = 1.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float SensitivityRangeScale { get; set; } = 1.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float LowSpeedSteeringSensitivityLimit { get; set; } = 20.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float MidSpeedSteeringSensitivityLimit { get; set; } = 50.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float HighSpeedSteeringSensitivityLimit { get; set; } = 70.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float TrackedTurnSpeedLimit { get; set; } = 1.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float TrackedForwardSpeedLimit { get; set; } = 1.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float TrackedSlipSteerReductionScale { get; set; } = 1.000f;
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CtrRef<Curve2D> SteerInertia { get; set; } = new();
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public List<SensitivityAtVelocity> SteeringSensitivity { get; set; } = new();
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float TrackedSteeringBoostOnOppositeTorque { get; set; } = 0.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float SlopeGripMinAngle { get; set; } = 89.000f;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float SlopeGripMaxAngle { get; set; } = 90.000f;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public int SlopeGripExponent { get; set; } = 1;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float OffGroundGravityModifier { get; set; } = 1.000f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float SideSlipAngleMaxSlipCondition { get; set; } = 13.750f;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float AngularVelocityMinSlipCondition { get; set; } = 2.850f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public float WheelVelocityXMinSlipCondition { get; set; } = 0.180f;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float WheelSlipRatioMaxSlipCondition { get; set; } = 0.125f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float LongitudinalFrictionForceMaxFactor { get; set; } = 100.000f;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float LateralFrictionForceMaxFactor { get; set; } = 200.000f;
	
	[ContainerField(0x108), JsonProperty(Order = 264)]
	public List<FrictionScaleAtVelocity> LongitudeFrictionScale { get; set; } = new();
	
	[ContainerField(0x110), JsonProperty(Order = 272)]
	public List<FrictionScaleAtVelocity> LattitudeFrictionScale { get; set; } = new();
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float WheelFrictionLattitudeBrakeScale { get; set; } = 1.000f;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public float Resistance { get; set; } = 0.000f;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float FxTorqueRadiusMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float FrictionMomentVelocityMin { get; set; } = 50.000f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public float FrictionMomentVelocityMax { get; set; } = 250.000f;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public float FrictionMomentMultiplier { get; set; } = 100.000f;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float FrictionMomentMaxFactor { get; set; } = 20000.000f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public float BrakeFactor { get; set; } = 0.125f;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public float BrakeForce { get; set; } = 4000.000f;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public float HandBrakeFactor { get; set; } = 0.000f;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public float HandBrakeForce { get; set; } = 0.000f;
	
	[ContainerField(0x144), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
	public float TotalFrictionScale { get; set; } = 1.000f;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public float TotalLateralFrictionScale { get; set; } = 1.000f;
	
	[ContainerField(0x14c), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
	public float LateralPosK { get; set; } = 5.002f;
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public float LateralNegK { get; set; } = 0.054f;
	
	[ContainerField(0x154), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
	public float LongitudinalPosK { get; set; } = 5.396f;
	
	[ContainerField(0x158), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
	public float LongitudinalNegK { get; set; } = 0.177f;
	
	[ContainerField(0x15c), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
	public float AlignMomScale { get; set; } = 0.127f;
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float WheelBaseLateral { get; set; } = 0.000f;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public float WheelBaseLongitudinal { get; set; } = 0.000f;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public int DrivingType { get; set; } = 1;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public int SteeringType { get; set; } = 1;
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public int FrictionMethod { get; set; } = 0;
	
	[ContainerField(0x174), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
	public int RotationDirectionIndex { get; set; } = 0;
	
	[ContainerField(0x178), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
	public int SteeringAngleIndex { get; set; } = 1;
	
	[ContainerField(0x17c), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
	public int PacejkaConfigIndex { get; set; } = 0;
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public int EngineIndex { get; set; } = 0;
	
	[ContainerField(0x184), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
	public int AckermanDeviceType { get; set; } = 0;
	
	[ContainerField(0x188), JsonProperty(Order = 392)]
	public MaterialDecl CollisionMaterialPair { get; set; } = new();
	
	[ContainerField(0x18c), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
	public bool AllowGripSlipTransition { get; set; } = true;
	
	[ContainerField(0x18d), LayoutImmutable, Blittable, JsonProperty(Order = 397)]
	public bool AutoHandBrakeIfNoThrottleAndSteer { get; set; } = false;
	
	[ContainerField(0x18e), LayoutImmutable, Blittable, JsonProperty(Order = 398)]
	public bool UseRollingResistanceVelocityFactor { get; set; } = true;
	
	[ContainerField(0x18f), LayoutImmutable, Blittable, JsonProperty(Order = 399)]
	public bool UseRollingResistanceBaseFactor { get; set; } = true;
	
	[ContainerField(0x190), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
	public bool UseEngineBrake { get; set; } = true;
	
	[ContainerField(0x191), LayoutImmutable, Blittable, JsonProperty(Order = 401)]
	public bool IsAllowedToSpin { get; set; } = false;
	
	[ContainerField(0x192), LayoutImmutable, Blittable, JsonProperty(Order = 402)]
	public bool HasSteeringInverted { get; set; } = false;
	
	[ContainerField(0x193), LayoutImmutable, Blittable, JsonProperty(Order = 403)]
	public bool UseFrictionMoment { get; set; } = true;
	
	[ContainerField(0x194), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
	public bool UseLowSpeedAutoBrake { get; set; } = true;
	
	[ContainerField(0x195), LayoutImmutable, Blittable, JsonProperty(Order = 405)]
	public bool AdjustWheelRotation { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(RotationBody));
		p_Writer.WriteNullBytes(4);
		SphereCollision.Serialize(p_Writer, p_EbxWriter);
		Spring.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Mass);
		p_Writer.Write(Radius);
		p_Writer.WriteNullBytes(4);
		Offset.Serialize(p_Writer, p_EbxWriter);
		Inertia.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Width);
		p_Writer.Write(RollingResistanceInternalBaseFactor);
		p_Writer.Write(RollingResistanceBaseFactor);
		p_Writer.Write(RollingResistanceVelocityFactor);
		p_Writer.Write(EngineBrakeVelocityFactor);
		p_Writer.Write(EngineBrakeMinFactor);
		p_Writer.Write(EngineBrakeMaxFactor);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_TransmissionLoss = p_EbxWriter.GetArrayWriter(TransmissionLoss.GetType(), TransmissionLoss.Count);
		p_Writer.Write(s_TransmissionLoss.ArrayIndex);
		foreach (var s_Entry in TransmissionLoss)
		{
			s_Entry.Serialize(s_TransmissionLoss.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
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
		p_Writer.Write(TrackedSlipSteerReductionScale);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SteerInertia));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_SteeringSensitivity = p_EbxWriter.GetArrayWriter(SteeringSensitivity.GetType(), SteeringSensitivity.Count);
		p_Writer.Write(s_SteeringSensitivity.ArrayIndex);
		foreach (var s_Entry in SteeringSensitivity)
		{
			s_Entry.Serialize(s_SteeringSensitivity.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TrackedSteeringBoostOnOppositeTorque);
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
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LongitudeFrictionScale = p_EbxWriter.GetArrayWriter(LongitudeFrictionScale.GetType(), LongitudeFrictionScale.Count);
		p_Writer.Write(s_LongitudeFrictionScale.ArrayIndex);
		foreach (var s_Entry in LongitudeFrictionScale)
		{
			s_Entry.Serialize(s_LongitudeFrictionScale.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LattitudeFrictionScale = p_EbxWriter.GetArrayWriter(LattitudeFrictionScale.GetType(), LattitudeFrictionScale.Count);
		p_Writer.Write(s_LattitudeFrictionScale.ArrayIndex);
		foreach (var s_Entry in LattitudeFrictionScale)
		{
			s_Entry.Serialize(s_LattitudeFrictionScale.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(WheelFrictionLattitudeBrakeScale);
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
		p_Writer.Write(TotalFrictionScale);
		p_Writer.Write(TotalLateralFrictionScale);
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
		p_Writer.Write(RotationDirectionIndex);
		p_Writer.Write(SteeringAngleIndex);
		p_Writer.Write(PacejkaConfigIndex);
		p_Writer.Write(EngineIndex);
		p_Writer.Write(AckermanDeviceType);
		CollisionMaterialPair.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AllowGripSlipTransition);
		p_Writer.Write(AutoHandBrakeIfNoThrottleAndSteer);
		p_Writer.Write(UseRollingResistanceVelocityFactor);
		p_Writer.Write(UseRollingResistanceBaseFactor);
		p_Writer.Write(UseEngineBrake);
		p_Writer.Write(IsAllowedToSpin);
		p_Writer.Write(HasSteeringInverted);
		p_Writer.Write(UseFrictionMoment);
		p_Writer.Write(UseLowSpeedAutoBrake);
		p_Writer.Write(AdjustWheelRotation);
		p_Writer.WriteNullBytes(10);
	}
}

