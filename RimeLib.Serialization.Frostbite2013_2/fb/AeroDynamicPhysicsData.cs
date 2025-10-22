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

namespace fb.Physics;

[ContainerType(16, 80)]
public class AeroDynamicPhysicsData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public Vec3 BodyDrag { get; set; } = new()
	{
		z = 0.000f,
		y = 0.500f,
		x = 0.100f,
	};
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 BodyDragOffsetYZ { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 BodyDragOffsetXZ { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 BodyDragOffsetXY { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		BodyDrag.Serialize(p_Writer, p_EbxWriter);
		BodyDragOffsetYZ.Serialize(p_Writer, p_EbxWriter);
		BodyDragOffsetXZ.Serialize(p_Writer, p_EbxWriter);
		BodyDragOffsetXY.Serialize(p_Writer, p_EbxWriter);
	}
}

