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

namespace fb.Emitter;

[ContainerType(16, 80)]
public class SpawnColorRandomData
	: fb.Emitter.ProcessorData
{
	public SpawnColorRandomData()
	{
		//ProcessorData
		EvaluatorInput = EmittableField.EfOne;
	}
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 Color0 { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 Color1 { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(8);
		Color0.Serialize(p_Writer, p_EbxWriter);
		Color1.Serialize(p_Writer, p_EbxWriter);
	}
}

