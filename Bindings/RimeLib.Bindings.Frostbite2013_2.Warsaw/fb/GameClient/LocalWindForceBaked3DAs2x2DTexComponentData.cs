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

namespace fb.GameClient;

[ContainerType(16, 208)]
public class LocalWindForceBaked3DAs2x2DTexComponentData
	: fb.Entity.LocalWindForceComponentBaseData
{
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 VolumeSliceZXScale { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec3 VolumeSliceZYScale { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float SizeX { get; set; } = 1.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float SizeY { get; set; } = 1.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float SizeZ { get; set; } = 1.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float Attenuation { get; set; } = 0.100f;
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public CtrRef<TextureAsset> VolumeSliceZX { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CtrRef<TextureAsset> VolumeSliceZY { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		VolumeSliceZXScale.Serialize(p_Writer, p_EbxWriter);
		VolumeSliceZYScale.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SizeX);
		p_Writer.Write(SizeY);
		p_Writer.Write(SizeZ);
		p_Writer.Write(Attenuation);
		p_Writer.Write(p_EbxWriter.WriteImport(VolumeSliceZX));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(VolumeSliceZY));
		p_Writer.WriteNullBytes(4);
	}
}

