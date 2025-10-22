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
public class MixerPreset
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint NameHash { get; set; } = 0;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<MixerPresetGroupData> Groups { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<MixerPresetNodeData> Nodes { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(NameHash);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Groups = p_EbxWriter.GetArrayWriter(Groups.GetType(), Groups.Count);
		p_Writer.Write(s_Groups.ArrayIndex);
		foreach (var s_Entry in Groups)
		{
			s_Entry.Serialize(s_Groups.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Nodes = p_EbxWriter.GetArrayWriter(Nodes.GetType(), Nodes.Count);
		p_Writer.Write(s_Nodes.ArrayIndex);
		foreach (var s_Entry in Nodes)
		{
			s_Entry.Serialize(s_Nodes.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

