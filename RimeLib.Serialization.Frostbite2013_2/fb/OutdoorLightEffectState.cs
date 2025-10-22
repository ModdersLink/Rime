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

[ContainerType(16, 128)]
public class OutdoorLightEffectState
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float SunRotationX { get; set; } = 0.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float SunRotationY { get; set; } = 60.000f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 SunColor { get; set; } = new()
	{
		z = 0.914f,
		y = 0.971f,
		x = 1.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 SkyColor { get; set; } = new()
	{
		z = 0.400f,
		y = 0.341f,
		x = 0.318f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 GroundColor { get; set; } = new()
	{
		z = 0.050f,
		y = 0.050f,
		x = 0.050f,
	};
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float SkyLightAngleFactor { get; set; } = 0.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float SunShadowHeightScale { get; set; } = 0.500f;
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<TextureAsset> CloudShadowTexture { get; set; } = new();
	
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec2 CloudShadowSpeed { get; set; } = new()
	{
		y = 2.000f,
		x = 2.000f,
	};
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float CloudShadowSize { get; set; } = 500.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float CloudShadowCoverage { get; set; } = 0.300f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float CloudShadowExponent { get; set; } = 8.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x75), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
	public bool CloudShadowEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SunRotationX);
		p_Writer.Write(SunRotationY);
		p_Writer.WriteNullBytes(8);
		SunColor.Serialize(p_Writer, p_EbxWriter);
		SkyColor.Serialize(p_Writer, p_EbxWriter);
		GroundColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SkyLightAngleFactor);
		p_Writer.Write(SunShadowHeightScale);
		p_Writer.Write(p_EbxWriter.WriteImport(CloudShadowTexture));
		p_Writer.WriteNullBytes(4);
		CloudShadowSpeed.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CloudShadowSize);
		p_Writer.Write(CloudShadowCoverage);
		p_Writer.Write(CloudShadowExponent);
		p_Writer.Write(Enable);
		p_Writer.Write(CloudShadowEnable);
		p_Writer.WriteNullBytes(10);
	}
}

