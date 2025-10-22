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

[ContainerType(8, 96)]
public class Pan2dNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort In { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Out { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Pan2dOutputChannelCount OutputChannelCount { get; set; } = Pan2dOutputChannelCount.Pan2dOutputChannelCount_Six;
	
	[ContainerField(0x24), JsonProperty(Order = 36)]
	public AudioGraphNodePort PanAngle { get; set; } = new();
	
	[ContainerField(0x2c), JsonProperty(Order = 44)]
	public AudioGraphNodePort PanDistance { get; set; } = new();
	
	[ContainerField(0x34), JsonProperty(Order = 52)]
	public AudioGraphNodePort PanSize { get; set; } = new();
	
	[ContainerField(0x3c), JsonProperty(Order = 60)]
	public AudioGraphNodePort PanTwist { get; set; } = new();
	
	[ContainerField(0x44), JsonProperty(Order = 68)]
	public AudioGraphNodePort CenterAmplitude { get; set; } = new();
	
	[ContainerField(0x4c), JsonProperty(Order = 76)]
	public AudioGraphNodePort MainAmplitude { get; set; } = new();
	
	[ContainerField(0x54), JsonProperty(Order = 84)]
	public AudioGraphNodePort LfeAmplitude { get; set; } = new();
	
	[ContainerField(0x5c), JsonProperty(Order = 92)]
	public SoundGraphPluginRef Plugin { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		In.Serialize(p_Writer, p_EbxWriter);
		Out.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) OutputChannelCount);
		PanAngle.Serialize(p_Writer, p_EbxWriter);
		PanDistance.Serialize(p_Writer, p_EbxWriter);
		PanSize.Serialize(p_Writer, p_EbxWriter);
		PanTwist.Serialize(p_Writer, p_EbxWriter);
		CenterAmplitude.Serialize(p_Writer, p_EbxWriter);
		MainAmplitude.Serialize(p_Writer, p_EbxWriter);
		LfeAmplitude.Serialize(p_Writer, p_EbxWriter);
		Plugin.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(1);
	}
}

