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

[ContainerType(16, 304)]
public class EnlightenComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 TerrainColor { get; set; } = new()
	{
		z = 0.100f,
		y = 0.100f,
		x = 0.100f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 SkyBoxSkyColor { get; set; } = new()
	{
		z = 0.400f,
		y = 0.341f,
		x = 0.318f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec3 SkyBoxGroundColor { get; set; } = new()
	{
		z = 0.050f,
		y = 0.050f,
		x = 0.050f,
	};
	
	[ContainerField(0xb0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Vec3 SkyBoxSunLightColor { get; set; } = new()
	{
		z = 0.914f,
		y = 0.971f,
		x = 1.000f,
	};
	
	[ContainerField(0xc0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public Vec3 SkyBoxBackLightColor { get; set; } = new()
	{
		z = 0.914f,
		y = 0.971f,
		x = 1.000f,
	};
	
	[ContainerField(0xd0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public Vec3 OpaqueAlphaTestSimpleScale { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xe0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public Vec3 OverrideLightProbe { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public float BounceScale { get; set; } = 1.000f;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float SunScale { get; set; } = 1.000f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float CullDistance { get; set; } = -1.000f;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float CullRadius { get; set; } = 0.000f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float SkyBoxSunLightColorSize { get; set; } = 0.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float SkyBoxBackLightColorSize { get; set; } = 0.000f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float SkyBoxBackLightRotationX { get; set; } = 0.000f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float SkyBoxBackLightRotationY { get; set; } = 60.000f;
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public CtrRef<TextureAsset> OverrideIrradianceChromaTexture { get; set; } = new();
	
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public CtrRef<TextureAsset> OverrideIrradianceLumaTexture { get; set; } = new();
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public bool SkyBoxEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		TerrainColor.Serialize(p_Writer, p_EbxWriter);
		SkyBoxSkyColor.Serialize(p_Writer, p_EbxWriter);
		SkyBoxGroundColor.Serialize(p_Writer, p_EbxWriter);
		SkyBoxSunLightColor.Serialize(p_Writer, p_EbxWriter);
		SkyBoxBackLightColor.Serialize(p_Writer, p_EbxWriter);
		OpaqueAlphaTestSimpleScale.Serialize(p_Writer, p_EbxWriter);
		OverrideLightProbe.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(BounceScale);
		p_Writer.Write(SunScale);
		p_Writer.Write(CullDistance);
		p_Writer.Write(CullRadius);
		p_Writer.Write(SkyBoxSunLightColorSize);
		p_Writer.Write(SkyBoxBackLightColorSize);
		p_Writer.Write(SkyBoxBackLightRotationX);
		p_Writer.Write(SkyBoxBackLightRotationY);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(OverrideIrradianceChromaTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(OverrideIrradianceLumaTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SkyBoxEnable);
		p_Writer.WriteNullBytes(7);
	}
}

