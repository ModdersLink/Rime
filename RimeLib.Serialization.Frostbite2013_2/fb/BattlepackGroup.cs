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

[ContainerType(8, 40)]
public class BattlepackGroup
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string groupName { get; set; } = string.Empty;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<BattlepackData> Battlepacks { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(groupName));
		(RimeWriter Writer, uint ArrayIndex) s_Battlepacks = p_EbxWriter.GetArrayWriter(Battlepacks.GetType(), Battlepacks.Count);
		p_Writer.Write(s_Battlepacks.ArrayIndex);
		foreach (var s_Entry in Battlepacks)
		{
			s_Battlepacks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

