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
using fb.Render;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 128)]
public class CollidableFreeCameraData
	: fb.GameShared.CameraData
{
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 MaxBounceVelocity { get; set; } = new()
	{
		z = 100.000f,
		y = 100.000f,
		x = 100.000f,
	};
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float CollisionRadius { get; set; } = 1.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float RotateYLimit { get; set; } = -0.260f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float ConstraintDynamicFriction { get; set; } = 0.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float ConstraintVelocityMultiplier { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		MaxBounceVelocity.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CollisionRadius);
		p_Writer.Write(RotateYLimit);
		p_Writer.Write(ConstraintDynamicFriction);
		p_Writer.Write(ConstraintVelocityMultiplier);
	}
}

