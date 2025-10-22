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

[ContainerType(8, 64)]
public class SpawnDirectionData
	: fb.Emitter.ProcessorData
{
	public SpawnDirectionData()
	{
		//ProcessorData
		EvaluatorInput = EmittableField.EfOne;
	}
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float DirectionFromEmitterOrigin { get; set; } = 0.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float InheritSpeedAmount { get; set; } = 1.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float InheritSpeedSmoothingFactor { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float InheritSpeedRandomness { get; set; } = 0.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool InheritSpeedAndDirectionFromEmitter { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DirectionFromEmitterOrigin);
		p_Writer.Write(InheritSpeedAmount);
		p_Writer.Write(InheritSpeedSmoothingFactor);
		p_Writer.Write(InheritSpeedRandomness);
		p_Writer.Write(InheritSpeedAndDirectionFromEmitter);
		p_Writer.WriteNullBytes(7);
	}
}

