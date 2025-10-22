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

namespace fb.WorldRender;

[ContainerType(16, 128)]
public class EnlightenState
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float BounceScale { get; set; } = 1.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float SunScale { get; set; } = 1.000f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 SkyBoxSkyColor { get; set; } = new()
	{
		z = 0.400f,
		y = 0.341f,
		x = 0.318f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 SkyBoxGroundColor { get; set; } = new()
	{
		z = 0.050f,
		y = 0.050f,
		x = 0.050f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 SkyBoxSunLightColor { get; set; } = new()
	{
		z = 0.914f,
		y = 0.971f,
		x = 1.000f,
	};
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec3 SkyBoxBackLightColor { get; set; } = new()
	{
		z = 0.914f,
		y = 0.971f,
		x = 1.000f,
	};
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float OutputScale { get; set; } = 1.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float SkyBoxSunLightColorSize { get; set; } = 0.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float SkyBoxBackLightColorSize { get; set; } = 0.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float SkyBoxBackLightRotationX { get; set; } = 0.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float SkyBoxBackLightRotationY { get; set; } = 60.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public bool SkyBoxEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(BounceScale);
		p_Writer.Write(SunScale);
		p_Writer.WriteNullBytes(8);
		SkyBoxSkyColor.Serialize(p_Writer, p_EbxWriter);
		SkyBoxGroundColor.Serialize(p_Writer, p_EbxWriter);
		SkyBoxSunLightColor.Serialize(p_Writer, p_EbxWriter);
		SkyBoxBackLightColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(OutputScale);
		p_Writer.Write(SkyBoxSunLightColorSize);
		p_Writer.Write(SkyBoxBackLightColorSize);
		p_Writer.Write(SkyBoxBackLightRotationX);
		p_Writer.Write(SkyBoxBackLightRotationY);
		p_Writer.Write(SkyBoxEnable);
		p_Writer.WriteNullBytes(11);
	}
}

