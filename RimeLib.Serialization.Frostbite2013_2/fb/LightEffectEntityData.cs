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
using fb.WorldRender;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 224)]
public class LightEffectEntityData
	: fb.Entity.EffectEntityData
{
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec4 IntensityCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<LocalLightEntityData> Light { get; set; } = new();
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float Lifetime { get; set; } = -1.000f;
	
	[ContainerField(0xbc), JsonProperty(Order = 188)]
	public QualityScalableFloat SpawnProbability { get; set; } = new()
	{
		Ultra = 1.000f,
		High = 1.000f,
		Medium = 1.000f,
		Low = 1.000f,
	};
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float RandomIntensityMin { get; set; } = 1.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float RandomIntensityMax { get; set; } = 1.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float IntensityMin { get; set; } = 0.000f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float IntensityMax { get; set; } = 1.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public bool Looping { get; set; } = false;
	
	[ContainerField(0xdd), LayoutImmutable, Blittable, JsonProperty(Order = 221)]
	public bool LocalPlayerOnly { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		IntensityCurve.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Light));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Lifetime);
		SpawnProbability.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RandomIntensityMin);
		p_Writer.Write(RandomIntensityMax);
		p_Writer.Write(IntensityMin);
		p_Writer.Write(IntensityMax);
		p_Writer.Write(Looping);
		p_Writer.Write(LocalPlayerOnly);
		p_Writer.WriteNullBytes(2);
	}
}

