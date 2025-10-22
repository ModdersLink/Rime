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
public class CrossfaderNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort In1 { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort In2 { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort Ctrl { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort Out { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public SoundGraphPluginRef Plugin1 { get; set; } = new();
	
	[ContainerField(0x33), JsonProperty(Order = 51)]
	public SoundGraphPluginRef Plugin2 { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		In1.Serialize(p_Writer, p_EbxWriter);
		In2.Serialize(p_Writer, p_EbxWriter);
		Ctrl.Serialize(p_Writer, p_EbxWriter);
		Out.Serialize(p_Writer, p_EbxWriter);
		Plugin1.Serialize(p_Writer, p_EbxWriter);
		Plugin2.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(2);
	}
}

