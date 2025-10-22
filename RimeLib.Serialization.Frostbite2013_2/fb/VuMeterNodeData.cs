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
public class VuMeterNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort In { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Out { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort FrontLeft { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort Center { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort FrontRight { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AudioGraphNodePort RearLeft { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public AudioGraphNodePort RearRight { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public AudioGraphNodePort Lfe { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public VuMeterMode Mode { get; set; } = VuMeterMode.VuMeterMode_Rms;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public int Efficiency { get; set; } = 1;
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public SoundGraphPluginRef Plugin { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		In.Serialize(p_Writer, p_EbxWriter);
		Out.Serialize(p_Writer, p_EbxWriter);
		FrontLeft.Serialize(p_Writer, p_EbxWriter);
		Center.Serialize(p_Writer, p_EbxWriter);
		FrontRight.Serialize(p_Writer, p_EbxWriter);
		RearLeft.Serialize(p_Writer, p_EbxWriter);
		RearRight.Serialize(p_Writer, p_EbxWriter);
		Lfe.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Mode);
		p_Writer.Write(Efficiency);
		Plugin.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(5);
	}
}

