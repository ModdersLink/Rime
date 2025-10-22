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


namespace fb.Core;

[ContainerType(8, 24)]
public class DynamicDataContainer
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<DataField> Fields { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Fields = p_EbxWriter.GetArrayWriter(Fields.GetType(), Fields.Count);
		p_Writer.Write(s_Fields.ArrayIndex);
		foreach (var s_Entry in Fields)
		{
			s_Entry.Serialize(s_Fields.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

