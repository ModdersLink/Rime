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

[ContainerType(8, 56)]
public class DelayNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort In { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort DelayTime { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort Feedback { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort Out { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float MaxDelayTime { get; set; } = 0.000f;
	
	[ContainerField(0x34), JsonProperty(Order = 52)]
	public SoundGraphPluginRef Plugin { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		In.Serialize(p_Writer, p_EbxWriter);
		DelayTime.Serialize(p_Writer, p_EbxWriter);
		Feedback.Serialize(p_Writer, p_EbxWriter);
		Out.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxDelayTime);
		Plugin.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(1);
	}
}

