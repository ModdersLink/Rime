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

[ContainerType(8, 40)]
public class EventSwitcherNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<EventSwitcherEntry> Inputs { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Value { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float DefaultValue { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Inputs = p_EbxWriter.GetArrayWriter(Inputs.GetType(), Inputs.Count);
		p_Writer.Write(s_Inputs.ArrayIndex);
		foreach (var s_Entry in Inputs)
		{
			s_Inputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		Value.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DefaultValue);
		p_Writer.WriteNullBytes(4);
	}
}

