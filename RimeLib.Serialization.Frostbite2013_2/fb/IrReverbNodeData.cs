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
public class IrReverbNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort In { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Out { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort Reverb0 { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort Amplitude0 { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort Reverb1 { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AudioGraphNodePort Amplitude1 { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float MaxReverbLength { get; set; } = 0.000f;
	
	[ContainerField(0x44), JsonProperty(Order = 68)]
	public SoundGraphPluginRef ReverbPlugin { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		In.Serialize(p_Writer, p_EbxWriter);
		Out.Serialize(p_Writer, p_EbxWriter);
		Reverb0.Serialize(p_Writer, p_EbxWriter);
		Amplitude0.Serialize(p_Writer, p_EbxWriter);
		Reverb1.Serialize(p_Writer, p_EbxWriter);
		Amplitude1.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxReverbLength);
		ReverbPlugin.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(1);
	}
}

