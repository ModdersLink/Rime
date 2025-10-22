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

[ContainerType(8, 56)]
public class SpawnRibbonRateData
	: fb.Emitter.ProcessorData
{
	public SpawnRibbonRateData()
	{
		//ProcessorData
		EvaluatorInput = EmittableField.EfOne;
	}
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float SpawnRate { get; set; } = 20.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float AngleDeviation { get; set; } = 0.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool DistributeOverDistance { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SpawnRate);
		p_Writer.Write(AngleDeviation);
		p_Writer.Write(DistributeOverDistance);
		p_Writer.WriteNullBytes(7);
	}
}

