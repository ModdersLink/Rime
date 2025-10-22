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
public class VibratoNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort In { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Out { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float MaxModulationDepth { get; set; } = 0.100f;
	
	[ContainerField(0x24), JsonProperty(Order = 36)]
	public AudioGraphNodePort ModulationDepth { get; set; } = new();
	
	[ContainerField(0x2c), JsonProperty(Order = 44)]
	public AudioGraphNodePort ModulationFrequency { get; set; } = new();
	
	[ContainerField(0x34), JsonProperty(Order = 52)]
	public SoundGraphPluginRef Plugin { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		In.Serialize(p_Writer, p_EbxWriter);
		Out.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxModulationDepth);
		ModulationDepth.Serialize(p_Writer, p_EbxWriter);
		ModulationFrequency.Serialize(p_Writer, p_EbxWriter);
		Plugin.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(1);
	}
}

