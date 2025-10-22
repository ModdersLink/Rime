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
using fb.Entity;

namespace fb.WorldRender;

[ContainerType(16, 288)]
public class OutdoorLightComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 SunColor { get; set; } = new()
	{
		z = 0.914f,
		y = 0.971f,
		x = 1.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 SkyColor { get; set; } = new()
	{
		z = 0.400f,
		y = 0.341f,
		x = 0.318f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec3 GroundColor { get; set; } = new()
	{
		z = 0.050f,
		y = 0.050f,
		x = 0.050f,
	};
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float SunRotationX { get; set; } = 0.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float SunRotationY { get; set; } = 60.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float ShadowSunRotationX { get; set; } = 0.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float ShadowSunRotationY { get; set; } = 60.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float SkyLightAngleFactor { get; set; } = 0.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float SunSpecularScale { get; set; } = 1.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float SkyEnvmapShadowScale { get; set; } = 1.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float SunShadowHeightScale { get; set; } = 0.500f;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<TextureAsset> CloudShadowTexture { get; set; } = new();
	
	[ContainerField(0xe0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public Vec2 CloudShadowSpeed { get; set; } = new()
	{
		y = 2.000f,
		x = 2.000f,
	};
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float CloudShadowSize { get; set; } = 500.000f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float CloudShadowCoverage { get; set; } = 0.300f;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float CloudShadowExponent { get; set; } = 8.000f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public float CloudShadowStartFade { get; set; } = -1.000f;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float CloudShadowsFadeDistance { get; set; } = 0.000f;
	
	[ContainerField(0xfc), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public Vec2 CloudXZTranslation { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public TextureAddress CloudShadowAddressingMode { get; set; } = TextureAddress.TaWrap;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float TranslucencyAmbient { get; set; } = 0.000f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float TranslucencyScale { get; set; } = 0.000f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float TranslucencyPower { get; set; } = 8.000f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float TranslucencyDistortion { get; set; } = 0.100f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x119), LayoutImmutable, Blittable, JsonProperty(Order = 281)]
	public bool ShadowSunRotationEnable { get; set; } = false;
	
	[ContainerField(0x11a), LayoutImmutable, Blittable, JsonProperty(Order = 282)]
	public bool CloudShadowEnable { get; set; } = true;
	
	[ContainerField(0x11b), LayoutImmutable, Blittable, JsonProperty(Order = 283)]
	public bool CloudShadowIsTopDown { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		SunColor.Serialize(p_Writer, p_EbxWriter);
		SkyColor.Serialize(p_Writer, p_EbxWriter);
		GroundColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(SunRotationX);
		p_Writer.Write(SunRotationY);
		p_Writer.Write(ShadowSunRotationX);
		p_Writer.Write(ShadowSunRotationY);
		p_Writer.Write(SkyLightAngleFactor);
		p_Writer.Write(SunSpecularScale);
		p_Writer.Write(SkyEnvmapShadowScale);
		p_Writer.Write(SunShadowHeightScale);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CloudShadowTexture));
		p_Writer.WriteNullBytes(4);
		CloudShadowSpeed.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CloudShadowSize);
		p_Writer.Write(CloudShadowCoverage);
		p_Writer.Write(CloudShadowExponent);
		p_Writer.Write(CloudShadowStartFade);
		p_Writer.Write(CloudShadowsFadeDistance);
		CloudXZTranslation.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) CloudShadowAddressingMode);
		p_Writer.Write(TranslucencyAmbient);
		p_Writer.Write(TranslucencyScale);
		p_Writer.Write(TranslucencyPower);
		p_Writer.Write(TranslucencyDistortion);
		p_Writer.Write(Enable);
		p_Writer.Write(ShadowSunRotationEnable);
		p_Writer.Write(CloudShadowEnable);
		p_Writer.Write(CloudShadowIsTopDown);
		p_Writer.WriteNullBytes(4);
	}
}

