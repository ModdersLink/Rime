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

namespace fb.WorldRender;

[ContainerType(16, 176)]
public class LocalLightEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 Color { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 EnlightenColorScale { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 ParticleColorScale { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float Radius { get; set; } = 10.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float Intensity { get; set; } = 5.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float AttenuationOffset { get; set; } = 0.010f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public EnlightenColorMode EnlightenColorMode { get; set; } = fb.WorldRender.EnlightenColorMode.EnlightenColorMode_Multiply;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public bool Visible { get; set; } = true;
	
	[ContainerField(0xa1), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
	public bool DirectLightEnable { get; set; } = true;
	
	[ContainerField(0xa2), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
	public bool SpecularEnable { get; set; } = true;
	
	[ContainerField(0xa3), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
	public bool EnlightenEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Color.Serialize(p_Writer, p_EbxWriter);
		EnlightenColorScale.Serialize(p_Writer, p_EbxWriter);
		ParticleColorScale.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Radius);
		p_Writer.Write(Intensity);
		p_Writer.Write(AttenuationOffset);
		p_Writer.Write((int) EnlightenColorMode);
		p_Writer.Write(Visible);
		p_Writer.Write(DirectLightEnable);
		p_Writer.Write(SpecularEnable);
		p_Writer.Write(EnlightenEnable);
		p_Writer.WriteNullBytes(12);
	}
}

