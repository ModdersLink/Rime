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

namespace fb.Render;

[ContainerType(16, 224)]
public class LensScopeComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 ChromaticAberrationColor1 { get; set; } = new()
	{
		z = 0.707f,
		y = 0.707f,
		x = 0.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 ChromaticAberrationColor2 { get; set; } = new()
	{
		z = 0.707f,
		y = 0.000f,
		x = 0.707f,
	};
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float BlurScale { get; set; } = 0.999f;
	
	[ContainerField(0xa8), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public Vec2 BlurCenter { get; set; } = new()
	{
		y = 0.500f,
		x = 0.500f,
	};
	
	[ContainerField(0xb0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Vec2 ChromaticAberrationStrengths { get; set; } = new()
	{
		y = 0.200f,
		x = 0.200f,
	};
	
	[ContainerField(0xb8), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public Vec2 ChromaticAberrationDisplacement1 { get; set; } = new()
	{
		y = 0.004f,
		x = -0.002f,
	};
	
	[ContainerField(0xc0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public Vec2 ChromaticAberrationDisplacement2 { get; set; } = new()
	{
		y = 0.000f,
		x = 0.006f,
	};
	
	[ContainerField(0xc8), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public Vec2 RadialBlendDistanceCoefficients { get; set; } = new()
	{
		y = -0.500f,
		x = 4.000f,
	};
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public bool Enable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		ChromaticAberrationColor1.Serialize(p_Writer, p_EbxWriter);
		ChromaticAberrationColor2.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(BlurScale);
		BlurCenter.Serialize(p_Writer, p_EbxWriter);
		ChromaticAberrationStrengths.Serialize(p_Writer, p_EbxWriter);
		ChromaticAberrationDisplacement1.Serialize(p_Writer, p_EbxWriter);
		ChromaticAberrationDisplacement2.Serialize(p_Writer, p_EbxWriter);
		RadialBlendDistanceCoefficients.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Enable);
		p_Writer.WriteNullBytes(15);
	}
}

