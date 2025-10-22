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

using fb.Render;
using fb.Core;

namespace fb.WorldRender;

[ContainerType(16, 64)]
public class SkyCloudLayer
	: EbxSerializable
{
	[ContainerField(0x0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public Vec3 Color { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float Altitude { get; set; } = 10000.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float TileFactor { get; set; } = 0.250f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float Rotation { get; set; } = 0.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float Speed { get; set; } = 0.010f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float SunLightIntensity { get; set; } = 4.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float SunLightPower { get; set; } = 50.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float AmbientLightIntensity { get; set; } = 0.200f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float AlphaMul { get; set; } = 1.000f;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<TextureAsset> Texture { get; set; } = new();
	
}

