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

[ContainerType(16, 368)]
public class SkyComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 CloudLayerSunColor { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 CloudLayer1Color { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec3 CloudLayer2Color { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float BrightnessScale { get; set; } = 2.000f;
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<TextureAsset> SkyGradientTexture { get; set; } = new();
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float SunSize { get; set; } = 0.004f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float SunScale { get; set; } = 1.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float PanoramicUVMinX { get; set; } = 0.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float PanoramicUVMaxX { get; set; } = 1.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float PanoramicUVMinY { get; set; } = 0.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float PanoramicUVMaxY { get; set; } = 1.000f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float PanoramicTileFactor { get; set; } = 1.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float PanoramicRotation { get; set; } = 0.000f;
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<TextureAsset> PanoramicTexture { get; set; } = new();
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public CtrRef<TextureAsset> PanoramicAlphaTexture { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public CtrRef<TextureAsset> CloudLayerMaskTexture { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float CloudLayer1Altitude { get; set; } = 10000.000f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float CloudLayer1TileFactor { get; set; } = 0.250f;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float CloudLayer1Rotation { get; set; } = 0.000f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float CloudLayer1Speed { get; set; } = 0.010f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float CloudLayer1SunLightIntensity { get; set; } = 4.000f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float CloudLayer1SunLightPower { get; set; } = 50.000f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float CloudLayer1AmbientLightIntensity { get; set; } = 0.200f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float CloudLayer1AlphaMul { get; set; } = 1.000f;
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public CtrRef<TextureAsset> CloudLayer1Texture { get; set; } = new();
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float CloudLayer2Altitude { get; set; } = 10000.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float CloudLayer2TileFactor { get; set; } = 0.250f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public float CloudLayer2Rotation { get; set; } = 0.000f;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public float CloudLayer2Speed { get; set; } = 0.010f;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float CloudLayer2SunLightIntensity { get; set; } = 4.000f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public float CloudLayer2SunLightPower { get; set; } = 50.000f;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public float CloudLayer2AmbientLightIntensity { get; set; } = 0.200f;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public float CloudLayer2AlphaMul { get; set; } = 1.000f;
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public CtrRef<TextureAsset> CloudLayer2Texture { get; set; } = new();
	
	[ContainerField(0x148), JsonProperty(Order = 328)]
	public CtrRef<TextureAsset> StaticEnvmapTexture { get; set; } = new();
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public float StaticEnvmapScale { get; set; } = 1.000f;
	
	[ContainerField(0x154), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
	public float SkyEnvmap8BitTexScale { get; set; } = 0.250f;
	
	[ContainerField(0x158), JsonProperty(Order = 344)]
	public CtrRef<TextureAsset> CustomEnvmapTexture { get; set; } = new();
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float CustomEnvmapScale { get; set; } = 1.000f;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public float CustomEnvmapAmbient { get; set; } = 0.000f;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public float SkyVisibilityExponent { get; set; } = 1.000f;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x16d), LayoutImmutable, Blittable, JsonProperty(Order = 365)]
	public bool IndirectCubeMapOverride { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		CloudLayerSunColor.Serialize(p_Writer, p_EbxWriter);
		CloudLayer1Color.Serialize(p_Writer, p_EbxWriter);
		CloudLayer2Color.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(BrightnessScale);
		p_Writer.Write(p_EbxWriter.WriteImport(SkyGradientTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SunSize);
		p_Writer.Write(SunScale);
		p_Writer.Write(PanoramicUVMinX);
		p_Writer.Write(PanoramicUVMaxX);
		p_Writer.Write(PanoramicUVMinY);
		p_Writer.Write(PanoramicUVMaxY);
		p_Writer.Write(PanoramicTileFactor);
		p_Writer.Write(PanoramicRotation);
		p_Writer.Write(p_EbxWriter.WriteImport(PanoramicTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PanoramicAlphaTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CloudLayerMaskTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CloudLayer1Altitude);
		p_Writer.Write(CloudLayer1TileFactor);
		p_Writer.Write(CloudLayer1Rotation);
		p_Writer.Write(CloudLayer1Speed);
		p_Writer.Write(CloudLayer1SunLightIntensity);
		p_Writer.Write(CloudLayer1SunLightPower);
		p_Writer.Write(CloudLayer1AmbientLightIntensity);
		p_Writer.Write(CloudLayer1AlphaMul);
		p_Writer.Write(p_EbxWriter.WriteImport(CloudLayer1Texture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CloudLayer2Altitude);
		p_Writer.Write(CloudLayer2TileFactor);
		p_Writer.Write(CloudLayer2Rotation);
		p_Writer.Write(CloudLayer2Speed);
		p_Writer.Write(CloudLayer2SunLightIntensity);
		p_Writer.Write(CloudLayer2SunLightPower);
		p_Writer.Write(CloudLayer2AmbientLightIntensity);
		p_Writer.Write(CloudLayer2AlphaMul);
		p_Writer.Write(p_EbxWriter.WriteImport(CloudLayer2Texture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StaticEnvmapTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(StaticEnvmapScale);
		p_Writer.Write(SkyEnvmap8BitTexScale);
		p_Writer.Write(p_EbxWriter.WriteImport(CustomEnvmapTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CustomEnvmapScale);
		p_Writer.Write(CustomEnvmapAmbient);
		p_Writer.Write(SkyVisibilityExponent);
		p_Writer.Write(Enable);
		p_Writer.Write(IndirectCubeMapOverride);
		p_Writer.WriteNullBytes(2);
	}
}

