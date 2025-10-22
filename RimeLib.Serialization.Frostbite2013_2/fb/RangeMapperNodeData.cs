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

[ContainerType(8, 48)]
public class RangeMapperNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort In { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Out { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<RangeMapperEntry> Ranges { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float DefaultOutputValue { get; set; } = 0.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public bool DefaultOutputValueEnabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		In.Serialize(p_Writer, p_EbxWriter);
		Out.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Ranges = p_EbxWriter.GetArrayWriter(Ranges.GetType(), Ranges.Count);
		p_Writer.Write(s_Ranges.ArrayIndex);
		foreach (var s_Entry in Ranges)
		{
			s_Entry.Serialize(s_Ranges.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DefaultOutputValue);
		p_Writer.Write(DefaultOutputValueEnabled);
		p_Writer.WriteNullBytes(3);
	}
}

