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

[ContainerType(8, 72)]
public class SequenceGeneratorNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort Trigger { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Reset { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort Min { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort Max { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort Step { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AudioGraphNodePort Value { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool UpdateValueOnEvents { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Trigger.Serialize(p_Writer, p_EbxWriter);
		Reset.Serialize(p_Writer, p_EbxWriter);
		Min.Serialize(p_Writer, p_EbxWriter);
		Max.Serialize(p_Writer, p_EbxWriter);
		Step.Serialize(p_Writer, p_EbxWriter);
		Value.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(UpdateValueOnEvents);
		p_Writer.WriteNullBytes(7);
	}
}

