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

[ContainerType(16, 192)]
public class LocalWindForceBaked3DAs2x2DTexEntityData
	: fb.Entity.LocalWindForceEntityBaseData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 VolumeSliceZXScale { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 VolumeSliceZYScale { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float SizeX { get; set; } = 1.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float SizeY { get; set; } = 1.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float SizeZ { get; set; } = 1.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float Attenuation { get; set; } = 0.100f;
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<TextureAsset> VolumeSliceZX { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
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

