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
public class AdsrNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort Trigger { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Release { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort A { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort D { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort S { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AudioGraphNodePort R { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public AudioGraphNodePort Value { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public AudioGraphNodePort Finished { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float Scale { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Trigger.Serialize(p_Writer, p_EbxWriter);
		Release.Serialize(p_Writer, p_EbxWriter);
		A.Serialize(p_Writer, p_EbxWriter);
		D.Serialize(p_Writer, p_EbxWriter);
		S.Serialize(p_Writer, p_EbxWriter);
		R.Serialize(p_Writer, p_EbxWriter);
		Value.Serialize(p_Writer, p_EbxWriter);
		Finished.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Scale);
		p_Writer.WriteNullBytes(4);
	}
}

