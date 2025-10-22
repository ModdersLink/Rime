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

[ContainerType(8, 32)]
public class StatsCategoryBaseData
	: fb.Entity.TreeNodeBase
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<StatsCategoryBaseData> BaseSubCategories { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string Code { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_BaseSubCategories = p_EbxWriter.GetArrayWriter(BaseSubCategories.GetType(), BaseSubCategories.Count);
		p_Writer.Write(s_BaseSubCategories.ArrayIndex);
		foreach (var s_Entry in BaseSubCategories)
		{
			s_BaseSubCategories.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(Code));
	}
}

