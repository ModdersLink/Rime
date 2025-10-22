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

[ContainerType(8, 80)]
public class ChorusNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort In { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Out { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float MaxDelay { get; set; } = 0.100f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float MaxModulationDepth { get; set; } = 0.100f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort TapCount { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort DelayTime { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AudioGraphNodePort ModulationDepth { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public AudioGraphNodePort ModulationFrequency { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public SoundGraphPluginRef Plugin { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		In.Serialize(p_Writer, p_EbxWriter);
		Out.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxDelay);
		p_Writer.Write(MaxModulationDepth);
		TapCount.Serialize(p_Writer, p_EbxWriter);
		DelayTime.Serialize(p_Writer, p_EbxWriter);
		ModulationDepth.Serialize(p_Writer, p_EbxWriter);
		ModulationFrequency.Serialize(p_Writer, p_EbxWriter);
		Plugin.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(5);
	}
}

