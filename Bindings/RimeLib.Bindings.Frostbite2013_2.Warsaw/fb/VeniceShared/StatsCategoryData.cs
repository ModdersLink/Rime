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
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 48)]
public class StatsCategoryData
	: fb.VeniceShared.StatsCategoryBaseData
{
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<StatsCategoryData> Categories { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<string> Members { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Categories = p_EbxWriter.GetArrayWriter(Categories.GetType(), Categories.Count);
		p_Writer.Write(s_Categories.ArrayIndex);
		foreach (var s_Entry in Categories)
		{
			s_Categories.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Members = p_EbxWriter.GetArrayWriter(Members.GetType(), Members.Count);
		p_Writer.Write(s_Members.ArrayIndex);
		foreach (var s_Entry in Members)
		{
			s_Members.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

