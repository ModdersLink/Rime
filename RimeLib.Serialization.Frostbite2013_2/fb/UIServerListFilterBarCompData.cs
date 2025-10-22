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

using fb.UI;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 56)]
public class UIServerListFilterBarCompData
	: fb.UI.UIComponentData
{
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<SlotRange> SlotRanges { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_SlotRanges = p_EbxWriter.GetArrayWriter(SlotRanges.GetType(), SlotRanges.Count);
		p_Writer.Write(s_SlotRanges.ArrayIndex);
		foreach (var s_Entry in SlotRanges)
		{
			s_Entry.Serialize(s_SlotRanges.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

