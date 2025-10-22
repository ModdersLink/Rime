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
using fb.GameShared;

namespace fb.SoldierShared;

[ContainerType(16, 288)]
public class SoldierAimAssistData
	: fb.Core.GameDataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<float> InputPolynomial { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<float> ZoomedInputPolynomial { get; set; } = new();
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 StickyBoxScale { get; set; } = new()
	{
		z = 1.900f,
		y = 1.000f,
		x = 1.900f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 StickyDistanceScale { get; set; } = new()
	{
		z = 0.500f,
		y = 0.000f,
		x = 0.500f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 SnapBoxScale { get; set; } = new()
	{
		z = 1.900f,
		y = 1.000f,
		x = 1.900f,
	};
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec3 SnapDistanceScale { get; set; } = new()
	{
		z = 0.500f,
		y = 0.000f,
		x = 0.500f,
	};
	
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 EyePosOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.400f,
		x = 0.600f,
	};
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float AccelerationInputThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float AccelerationMultiplier { get; set; } = 0.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float AccelerationDamping { get; set; } = 0.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float AccelerationTimeThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float SquaredAcceleration { get; set; } = 0.000f;
	
	[ContainerField(0x84), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public Vec2 MaxAcceleration { get; set; } = new()
	{
		y = 100.000f,
		x = 100.000f,
	};
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float YawSpeedStrength { get; set; } = 20.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float PitchSpeedStrength { get; set; } = 20.000f;
	
	[ContainerField(0x94), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public Vec2 AttractDistanceFallOffs { get; set; } = new()
	{
		y = 1.200f,
		x = 1.000f,
	};
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float AttractSoftZone { get; set; } = 0.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float AttractUserInputMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float AttractUserInputMultiplier_NoZoom { get; set; } = -1.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float AttractOwnSpeedInfluence { get; set; } = 0.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float AttractTargetSpeedInfluence { get; set; } = 0.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float AttractOwnRequiredMovementForMaximumAttract { get; set; } = 0.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float AttractStartInputThreshold { get; set; } = 0.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float AttractMoveInputCap { get; set; } = 0.900f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float AttractYawStrength { get; set; } = 0.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float AttractPitchStrength { get; set; } = 0.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float MaxToTargetAngle { get; set; } = 90.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float MaxToTargetXZAngle { get; set; } = 90.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float ViewObstructedKeepTime { get; set; } = 0.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float SnapZoomLateralSpeedLimit { get; set; } = 1000.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float SnapZoomTime { get; set; } = 0.200f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float SnapZoomPostTimeNoInput { get; set; } = 0.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float SnapZoomPostTime { get; set; } = 0.000f;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public uint SnapZoomReticlePointPriority { get; set; } = 999;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public float SnapZoomAutoEngageTime { get; set; } = 0.000f;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float SnapZoomBreakTimeAtMaxInput { get; set; } = -1.000f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float SnapZoomBreakMaxInput { get; set; } = 0.200f;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float SnapZoomBreakMinAngle { get; set; } = 90.000f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public float SnapZoomSpamGuardTime { get; set; } = 0.500f;
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public CtrRef<SkeletonCollisionData> SoldierBackupSkeletonCollisionData { get; set; } = new();
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float CheckBoneCenterOnlyDistance { get; set; } = 40.000f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float DisableForcedTargetRecalcDistance { get; set; } = 7.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float OverrideAimingRange { get; set; } = 0.000f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float OverrideAimingRangeCrouch { get; set; } = 0.000f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float OverrideAimingRangeProne { get; set; } = 0.000f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public bool UseYawAcceleration { get; set; } = false;
	
	[ContainerField(0x115), LayoutImmutable, Blittable, JsonProperty(Order = 277)]
	public bool UsePitchAcceleration { get; set; } = false;
	
	[ContainerField(0x116), LayoutImmutable, Blittable, JsonProperty(Order = 278)]
	public bool SnapZoomUserShorterWeaponTime { get; set; } = true;
	
	[ContainerField(0x117), LayoutImmutable, Blittable, JsonProperty(Order = 279)]
	public bool SnapZoomPostTimeDynamicPoint { get; set; } = true;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public bool ForceSoldierBackupSkeletonCollisionUse { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_InputPolynomial = p_EbxWriter.GetArrayWriter(InputPolynomial.GetType(), InputPolynomial.Count);
		p_Writer.Write(s_InputPolynomial.ArrayIndex);
		foreach (var s_Entry in InputPolynomial)
		{
			s_InputPolynomial.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ZoomedInputPolynomial = p_EbxWriter.GetArrayWriter(ZoomedInputPolynomial.GetType(), ZoomedInputPolynomial.Count);
		p_Writer.Write(s_ZoomedInputPolynomial.ArrayIndex);
		foreach (var s_Entry in ZoomedInputPolynomial)
		{
			s_ZoomedInputPolynomial.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		StickyBoxScale.Serialize(p_Writer, p_EbxWriter);
		StickyDistanceScale.Serialize(p_Writer, p_EbxWriter);
		SnapBoxScale.Serialize(p_Writer, p_EbxWriter);
		SnapDistanceScale.Serialize(p_Writer, p_EbxWriter);
		EyePosOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AccelerationInputThreshold);
		p_Writer.Write(AccelerationMultiplier);
		p_Writer.Write(AccelerationDamping);
		p_Writer.Write(AccelerationTimeThreshold);
		p_Writer.Write(SquaredAcceleration);
		MaxAcceleration.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(YawSpeedStrength);
		p_Writer.Write(PitchSpeedStrength);
		AttractDistanceFallOffs.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AttractSoftZone);
		p_Writer.Write(AttractUserInputMultiplier);
		p_Writer.Write(AttractUserInputMultiplier_NoZoom);
		p_Writer.Write(AttractOwnSpeedInfluence);
		p_Writer.Write(AttractTargetSpeedInfluence);
		p_Writer.Write(AttractOwnRequiredMovementForMaximumAttract);
		p_Writer.Write(AttractStartInputThreshold);
		p_Writer.Write(AttractMoveInputCap);
		p_Writer.Write(AttractYawStrength);
		p_Writer.Write(AttractPitchStrength);
		p_Writer.Write(MaxToTargetAngle);
		p_Writer.Write(MaxToTargetXZAngle);
		p_Writer.Write(ViewObstructedKeepTime);
		p_Writer.Write(SnapZoomLateralSpeedLimit);
		p_Writer.Write(SnapZoomTime);
		p_Writer.Write(SnapZoomPostTimeNoInput);
		p_Writer.Write(SnapZoomPostTime);
		p_Writer.Write(SnapZoomReticlePointPriority);
		p_Writer.Write(SnapZoomAutoEngageTime);
		p_Writer.Write(SnapZoomBreakTimeAtMaxInput);
		p_Writer.Write(SnapZoomBreakMaxInput);
		p_Writer.Write(SnapZoomBreakMinAngle);
		p_Writer.Write(SnapZoomSpamGuardTime);
		p_Writer.Write(p_EbxWriter.WriteImport(SoldierBackupSkeletonCollisionData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CheckBoneCenterOnlyDistance);
		p_Writer.Write(DisableForcedTargetRecalcDistance);
		p_Writer.Write(OverrideAimingRange);
		p_Writer.Write(OverrideAimingRangeCrouch);
		p_Writer.Write(OverrideAimingRangeProne);
		p_Writer.Write(UseYawAcceleration);
		p_Writer.Write(UsePitchAcceleration);
		p_Writer.Write(SnapZoomUserShorterWeaponTime);
		p_Writer.Write(SnapZoomPostTimeDynamicPoint);
		p_Writer.Write(ForceSoldierBackupSkeletonCollisionUse);
		p_Writer.WriteNullBytes(7);
	}
}

