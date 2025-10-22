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
using fb.Entity;

namespace fb.Emitter;

[ContainerType(16, 80)]
public class SampleTextureData
	: fb.Emitter.EvaluatorData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<Vec4> GradientData { get; set; } = new();
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 ColorIntensityMax { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 ColorIntensityMin { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec2 TextureDimensions { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float TextureOriginU { get; set; } = 0.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float TextureOriginV { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_GradientData = p_EbxWriter.GetArrayWriter(GradientData.GetType(), GradientData.Count);
		p_Writer.Write(s_GradientData.ArrayIndex);
		foreach (var s_Entry in GradientData)
		{
			s_Entry.Serialize(s_GradientData.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		ColorIntensityMax.Serialize(p_Writer, p_EbxWriter);
		ColorIntensityMin.Serialize(p_Writer, p_EbxWriter);
		TextureDimensions.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TextureOriginU);
		p_Writer.Write(TextureOriginV);
	}
}

