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

namespace fb.VeniceShared;

[ContainerType(8, 56)]
public class BattlepackSet
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string Key { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string Label { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string Description { get; set; } = string.Empty;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<BattlepackSlot> Slots { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Key));
		p_Writer.Write(p_EbxWriter.WriteString(Label));
		p_Writer.Write(p_EbxWriter.WriteString(Description));
		(RimeWriter Writer, uint ArrayIndex) s_Slots = p_EbxWriter.GetArrayWriter(Slots.GetType(), Slots.Count);
		p_Writer.Write(s_Slots.ArrayIndex);
		foreach (var s_Entry in Slots)
		{
			s_Slots.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

