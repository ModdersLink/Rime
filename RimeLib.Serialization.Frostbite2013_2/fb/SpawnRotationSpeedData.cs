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

[ContainerType(8, 48)]
public class SpawnRotationSpeedData
	: fb.Emitter.ProcessorData
{
	public SpawnRotationSpeedData()
	{
		//ProcessorData
		EvaluatorInput = EmittableField.EfOne;
	}
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float RotationSpeed { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RotationSpeed);
		p_Writer.WriteNullBytes(4);
	}
}

