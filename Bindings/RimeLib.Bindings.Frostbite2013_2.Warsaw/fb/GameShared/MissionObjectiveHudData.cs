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

namespace fb.GameShared;

[ContainerType(16, 80)]
public class MissionObjectiveHudData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float CameraRotation { get; set; } = 0.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float CameraFov { get; set; } = 45.000f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 CameraPosition { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float CameraDistance { get; set; } = 1000.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float CameraLookDistance { get; set; } = 150.000f;
	
	[ContainerField(0x38), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public Vec2 VerticalBoundaries { get; set; } = new()
	{
		y = 300.000f,
		x = -300.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec2 HorizontalBoundaries { get; set; } = new()
	{
		y = 300.000f,
		x = -300.000f,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CameraRotation);
		p_Writer.Write(CameraFov);
		p_Writer.WriteNullBytes(8);
		CameraPosition.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CameraDistance);
		p_Writer.Write(CameraLookDistance);
		VerticalBoundaries.Serialize(p_Writer, p_EbxWriter);
		HorizontalBoundaries.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(8);
	}
}

