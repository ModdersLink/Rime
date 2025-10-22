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

namespace fb.WorldRender;

[ContainerType(16, 256)]
public class SkyEffectState
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float SunSize { get; set; } = 0.004f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float SunScale { get; set; } = 1.000f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 CloudLayerSunColor { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public SkyCloudLayer CloudLayer1 { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public SkyCloudLayer CloudLayer2 { get; set; } = new();
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float SkyGradientScale { get; set; } = 2.000f;
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<TextureAsset> SkyGradientTexture { get; set; } = new();
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float PanoramicUVMinX { get; set; } = 0.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float PanoramicUVMaxX { get; set; } = 1.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float PanoramicUVMinY { get; set; } = 0.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float PanoramicUVMaxY { get; set; } = 1.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float PanoramicTileFactor { get; set; } = 1.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float PanoramicRotation { get; set; } = 0.000f;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<TextureAsset> PanoramicTexture { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<TextureAsset> PanoramicAlphaTexture { get; set; } = new();
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public CtrRef<TextureAsset> CloudLayerMaskTexture { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public CtrRef<TextureAsset> StaticEnvmapTexture { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float WindDirection { get; set; } = 0.000f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public bool Enable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SunSize);
		p_Writer.Write(SunScale);
		p_Writer.WriteNullBytes(8);
		CloudLayerSunColor.Serialize(p_Writer, p_EbxWriter);
		CloudLayer1.Serialize(p_Writer, p_EbxWriter);
		CloudLayer2.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SkyGradientScale);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SkyGradientTexture));
		p_Writer.WriteNullBytes(4);
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
		p_Writer.Write(p_EbxWriter.WriteImport(StaticEnvmapTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(WindDirection);
		p_Writer.Write(Enable);
		p_Writer.WriteNullBytes(3);
	}
}

