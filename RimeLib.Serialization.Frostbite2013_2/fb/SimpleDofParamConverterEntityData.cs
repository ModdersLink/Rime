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

namespace fb.Entity;

[ContainerType(8, 48)]
public class SimpleDofParamConverterEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float FocusDistance { get; set; } = 5.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float BlurFilterDeviation { get; set; } = 3.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float NearDistanceScale { get; set; } = 0.300f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float FarDistanceScale { get; set; } = 2.500f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float Scale { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FocusDistance);
		p_Writer.Write(BlurFilterDeviation);
		p_Writer.Write(NearDistanceScale);
		p_Writer.Write(FarDistanceScale);
		p_Writer.Write(Scale);
		p_Writer.WriteNullBytes(4);
	}
}

