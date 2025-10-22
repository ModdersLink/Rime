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

namespace fb.Render;

[ContainerType(16, 192)]
public class TonemapComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 BloomScale { get; set; } = new()
	{
		z = 0.050f,
		y = 0.050f,
		x = 0.050f,
	};
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public TonemapMethod TonemapMethod { get; set; } = fb.Render.TonemapMethod.TonemapMethod_FilmicNeutral;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float MiddleGray { get; set; } = 0.250f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float MinExposure { get; set; } = 0.300f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float MaxExposure { get; set; } = 3.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float ExposureAdjustTime { get; set; } = 2.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float ChromostereopsisScale { get; set; } = 1.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float ChromostereopsisOffset { get; set; } = 1.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public bool ChromostereopsisEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		BloomScale.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write((int) TonemapMethod);
		p_Writer.Write(MiddleGray);
		p_Writer.Write(MinExposure);
		p_Writer.Write(MaxExposure);
		p_Writer.Write(ExposureAdjustTime);
		p_Writer.Write(ChromostereopsisScale);
		p_Writer.Write(ChromostereopsisOffset);
		p_Writer.Write(ChromostereopsisEnable);
		p_Writer.WriteNullBytes(15);
	}
}

