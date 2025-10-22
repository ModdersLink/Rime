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

namespace fb.WorldRender;

[ContainerType(16, 208)]
public class PlanarReflectionComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 KeyColorReflection { get; set; } = new()
	{
		z = 0.914f,
		y = 0.971f,
		x = 1.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 SkyColorReflection { get; set; } = new()
	{
		z = 0.400f,
		y = 0.341f,
		x = 0.318f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec3 GroundColorReflection { get; set; } = new()
	{
		z = 0.050f,
		y = 0.050f,
		x = 0.050f,
	};
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float GroundHeight { get; set; } = 0.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float ViewDistance { get; set; } = 300.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public BlurFilter VerticalBlurFilter { get; set; } = BlurFilter.BfGaussian9Pixels;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float VerticalDeviation { get; set; } = 1.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public BlurFilter HorizontalBlurFilter { get; set; } = BlurFilter.BfGaussian9Pixels;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float HorizontalDeviation { get; set; } = 1.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public bool Enable { get; set; } = false;
	
	[ContainerField(0xcd), LayoutImmutable, Blittable, JsonProperty(Order = 205)]
	public bool TerrainReflectionsEnable { get; set; } = true;
	
	[ContainerField(0xce), LayoutImmutable, Blittable, JsonProperty(Order = 206)]
	public bool SkyRenderEnable { get; set; } = false;
	
	[ContainerField(0xcf), LayoutImmutable, Blittable, JsonProperty(Order = 207)]
	public bool OverideOutdoorLightColors { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		KeyColorReflection.Serialize(p_Writer, p_EbxWriter);
		SkyColorReflection.Serialize(p_Writer, p_EbxWriter);
		GroundColorReflection.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(GroundHeight);
		p_Writer.Write(ViewDistance);
		p_Writer.Write((int) VerticalBlurFilter);
		p_Writer.Write(VerticalDeviation);
		p_Writer.Write((int) HorizontalBlurFilter);
		p_Writer.Write(HorizontalDeviation);
		p_Writer.Write(Enable);
		p_Writer.Write(TerrainReflectionsEnable);
		p_Writer.Write(SkyRenderEnable);
		p_Writer.Write(OverideOutdoorLightColors);
	}
}

