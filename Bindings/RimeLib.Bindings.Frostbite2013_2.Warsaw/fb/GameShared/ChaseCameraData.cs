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
using fb.Render;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 352)]
public class ChaseCameraData
	: fb.GameShared.TargetCameraData
{
	[ContainerField(0xd0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public Vec3 TargetOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 1.500f,
		x = 0.000f,
	};
	
	[ContainerField(0xe0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public Vec3 ToWantedPositionScale { get; set; } = new()
	{
		z = 300.000f,
		y = 300.000f,
		x = 300.000f,
	};
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float TargetRotationOffset { get; set; } = 0.000f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public float MaxViewRotationAngleDeg { get; set; } = 30.000f;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float WantedAngleDeg { get; set; } = 25.000f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float WantedDistance { get; set; } = 4.000f;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float MaxDistance { get; set; } = 10.000f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float SnapDistance { get; set; } = 20.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float ResetDistance { get; set; } = 50.000f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float ForceFieldRadius { get; set; } = 2.000f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float CollisionRadius { get; set; } = 0.100f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float ForceFieldForceScale { get; set; } = 80.000f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float AwayFromTargetForceScale { get; set; } = 100.000f;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public float VelocityDrag { get; set; } = 25.000f;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float MaxVelocity { get; set; } = 9.500f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float PillMinimumCollisionRadius { get; set; } = 0.500f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public float PillMaximumCollisionRadius { get; set; } = 1.500f;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public float PillMinimumCollisionLength { get; set; } = 0.300f;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float PillExpandSizeSpeedAcceleration { get; set; } = 50.000f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public float LookDistanceScale { get; set; } = 0.000f;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public float LookDistanceInFrontOfTarget { get; set; } = 0.000f;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public string RollWithTargetOptionControl { get; set; } = string.Empty;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public uint UpdateRate { get; set; } = 200;
	
	[ContainerField(0x14c), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
	public bool KeepTargetPitch { get; set; } = false;
	
	[ContainerField(0x14d), LayoutImmutable, Blittable, JsonProperty(Order = 333)]
	public bool ShouldRollWithTarget { get; set; } = false;
	
	[ContainerField(0x14e), LayoutImmutable, Blittable, JsonProperty(Order = 334)]
	public bool InheritTargetVelocity { get; set; } = true;
	
	[ContainerField(0x14f), LayoutImmutable, Blittable, JsonProperty(Order = 335)]
	public bool BypassChaseCalculations { get; set; } = false;
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public bool BypassChaseCalculationsX { get; set; } = false;
	
	[ContainerField(0x151), LayoutImmutable, Blittable, JsonProperty(Order = 337)]
	public bool BypassChaseCalculationsY { get; set; } = false;
	
	[ContainerField(0x152), LayoutImmutable, Blittable, JsonProperty(Order = 338)]
	public bool BypassChaseCalculationsZ { get; set; } = false;
	
	[ContainerField(0x153), LayoutImmutable, Blittable, JsonProperty(Order = 339)]
	public bool AltBypassChaseCalculationsX { get; set; } = false;
	
	[ContainerField(0x154), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
	public bool AltBypassChaseCalculationsY { get; set; } = false;
	
	[ContainerField(0x155), LayoutImmutable, Blittable, JsonProperty(Order = 341)]
	public bool AltBypassChaseCalculationsZ { get; set; } = false;
	
	[ContainerField(0x156), LayoutImmutable, Blittable, JsonProperty(Order = 342)]
	public bool HasCollisionAgainstTarget { get; set; } = false;
	
	[ContainerField(0x157), LayoutImmutable, Blittable, JsonProperty(Order = 343)]
	public bool IgnoreCollisionInChaseCalculations { get; set; } = false;
	
	[ContainerField(0x158), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
	public bool HasCollision { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		TargetOffset.Serialize(p_Writer, p_EbxWriter);
		ToWantedPositionScale.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TargetRotationOffset);
		p_Writer.Write(MaxViewRotationAngleDeg);
		p_Writer.Write(WantedAngleDeg);
		p_Writer.Write(WantedDistance);
		p_Writer.Write(MaxDistance);
		p_Writer.Write(SnapDistance);
		p_Writer.Write(ResetDistance);
		p_Writer.Write(ForceFieldRadius);
		p_Writer.Write(CollisionRadius);
		p_Writer.Write(ForceFieldForceScale);
		p_Writer.Write(AwayFromTargetForceScale);
		p_Writer.Write(VelocityDrag);
		p_Writer.Write(MaxVelocity);
		p_Writer.Write(PillMinimumCollisionRadius);
		p_Writer.Write(PillMaximumCollisionRadius);
		p_Writer.Write(PillMinimumCollisionLength);
		p_Writer.Write(PillExpandSizeSpeedAcceleration);
		p_Writer.Write(LookDistanceScale);
		p_Writer.Write(LookDistanceInFrontOfTarget);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(RollWithTargetOptionControl));
		p_Writer.Write(UpdateRate);
		p_Writer.Write(KeepTargetPitch);
		p_Writer.Write(ShouldRollWithTarget);
		p_Writer.Write(InheritTargetVelocity);
		p_Writer.Write(BypassChaseCalculations);
		p_Writer.Write(BypassChaseCalculationsX);
		p_Writer.Write(BypassChaseCalculationsY);
		p_Writer.Write(BypassChaseCalculationsZ);
		p_Writer.Write(AltBypassChaseCalculationsX);
		p_Writer.Write(AltBypassChaseCalculationsY);
		p_Writer.Write(AltBypassChaseCalculationsZ);
		p_Writer.Write(HasCollisionAgainstTarget);
		p_Writer.Write(IgnoreCollisionInChaseCalculations);
		p_Writer.Write(HasCollision);
		p_Writer.WriteNullBytes(7);
	}
}

