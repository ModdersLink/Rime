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
using fb.UI;

namespace fb.VeniceShared;

[ContainerType(8, 64)]
public class UISquadCompData
	: fb.UI.UIComponentData
{
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<string> SquadNames { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool HideLocalSquadBoostData { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_SquadNames = p_EbxWriter.GetArrayWriter(SquadNames.GetType(), SquadNames.Count);
		p_Writer.Write(s_SquadNames.ArrayIndex);
		foreach (var s_Entry in SquadNames)
		{
			s_SquadNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(HideLocalSquadBoostData);
		p_Writer.WriteNullBytes(7);
	}
}

