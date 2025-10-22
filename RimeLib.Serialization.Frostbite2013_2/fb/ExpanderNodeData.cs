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

[ContainerType(8, 88)]
public class ExpanderNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort In { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Sidechain { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort Threshold { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort Ratio { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort AttackTime { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AudioGraphNodePort ReleaseTime { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public AudioGraphNodePort UseSidechain { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public AudioGraphNodePort Out { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public ExpanderChannelMode ChannelMode { get; set; } = ExpanderChannelMode.ExpanderChannelMode_Grouped;
	
	[ContainerField(0x54), JsonProperty(Order = 84)]
	public SoundGraphPluginRef Plugin { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		In.Serialize(p_Writer, p_EbxWriter);
		Sidechain.Serialize(p_Writer, p_EbxWriter);
		Threshold.Serialize(p_Writer, p_EbxWriter);
		Ratio.Serialize(p_Writer, p_EbxWriter);
		AttackTime.Serialize(p_Writer, p_EbxWriter);
		ReleaseTime.Serialize(p_Writer, p_EbxWriter);
		UseSidechain.Serialize(p_Writer, p_EbxWriter);
		Out.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) ChannelMode);
		Plugin.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(1);
	}
}

