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
using fb.VeniceShared;
using fb.Entity;

namespace fb.Venice;

[ContainerType(8, 56)]
public class BFPlayerFilterExtEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<string> Licenses { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<string> Consumables { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<AwardData> Awards { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool ForwardToSpectators { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Licenses = p_EbxWriter.GetArrayWriter(Licenses.GetType(), Licenses.Count);
		p_Writer.Write(s_Licenses.ArrayIndex);
		foreach (var s_Entry in Licenses)
		{
			s_Licenses.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Consumables = p_EbxWriter.GetArrayWriter(Consumables.GetType(), Consumables.Count);
		p_Writer.Write(s_Consumables.ArrayIndex);
		foreach (var s_Entry in Consumables)
		{
			s_Consumables.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Awards = p_EbxWriter.GetArrayWriter(Awards.GetType(), Awards.Count);
		p_Writer.Write(s_Awards.ArrayIndex);
		foreach (var s_Entry in Awards)
		{
			s_Awards.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ForwardToSpectators);
		p_Writer.WriteNullBytes(7);
	}
}

