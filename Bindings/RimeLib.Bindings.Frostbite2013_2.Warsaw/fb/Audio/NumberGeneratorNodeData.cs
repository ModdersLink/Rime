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

namespace fb.Audio;

[ContainerType(8, 48)]
public class NumberGeneratorNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort Trigger { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float Min { get; set; } = 0.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float Max { get; set; } = 1.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public NumberGeneratorMode Mode { get; set; } = NumberGeneratorMode.NumberGeneratorMode_RandomUniform;
	
	[ContainerField(0x24), JsonProperty(Order = 36)]
	public AudioGraphNodePort Y { get; set; } = new();
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public NumberGeneratorNodeVersion Version { get; set; } = NumberGeneratorNodeVersion.NumberGeneratorNodeVersion_2010_2;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Trigger.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Min);
		p_Writer.Write(Max);
		p_Writer.Write((int) Mode);
		Y.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Version);
	}
}

