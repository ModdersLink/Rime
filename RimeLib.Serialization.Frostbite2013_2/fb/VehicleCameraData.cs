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

[ContainerType(16, 304)]
public class VehicleCameraData
	: fb.GameShared.TargetCameraData
{
	[ContainerField(0xd0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public Vec3 MoveToPosition { get; set; } = new()
	{
		z = -4.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xe0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public Vec3 MoveToPositionSlopeFactor { get; set; } = new()
	{
		z = 5.000f,
		y = 5.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xf0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public Vec3 TargetOffset { get; set; } = new()
	{
		z = 2.000f,
		y = 1.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x100), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public Vec3 TargetOffsetSlopeFactor { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x110), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public Vec3 RotationFactor { get; set; } = new()
	{
		z = 32.000f,
		y = 32.000f,
		x = 32.000f,
	};
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float PositionFactor { get; set; } = 6.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float ResetDistance { get; set; } = 30.000f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public bool FixedPosition { get; set; } = false;
	
	[ContainerField(0x129), LayoutImmutable, Blittable, JsonProperty(Order = 297)]
	public bool FixedAngleZ { get; set; } = false;
	
	[ContainerField(0x12a), LayoutImmutable, Blittable, JsonProperty(Order = 298)]
	public bool UseTerrainAdjustment { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		MoveToPosition.Serialize(p_Writer, p_EbxWriter);
		MoveToPositionSlopeFactor.Serialize(p_Writer, p_EbxWriter);
		TargetOffset.Serialize(p_Writer, p_EbxWriter);
		TargetOffsetSlopeFactor.Serialize(p_Writer, p_EbxWriter);
		RotationFactor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PositionFactor);
		p_Writer.Write(ResetDistance);
		p_Writer.Write(FixedPosition);
		p_Writer.Write(FixedAngleZ);
		p_Writer.Write(UseTerrainAdjustment);
		p_Writer.WriteNullBytes(5);
	}
}

