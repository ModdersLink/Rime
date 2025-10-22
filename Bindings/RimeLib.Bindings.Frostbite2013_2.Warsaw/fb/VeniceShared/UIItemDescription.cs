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
public class UIItemDescription
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<uint> ItemIds { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<uint> HiddenInProgressionIds { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool IgnoreBuild { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ItemIds = p_EbxWriter.GetArrayWriter(ItemIds.GetType(), ItemIds.Count);
		p_Writer.Write(s_ItemIds.ArrayIndex);
		foreach (var s_Entry in ItemIds)
		{
			s_ItemIds.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_HiddenInProgressionIds = p_EbxWriter.GetArrayWriter(HiddenInProgressionIds.GetType(), HiddenInProgressionIds.Count);
		p_Writer.Write(s_HiddenInProgressionIds.ArrayIndex);
		foreach (var s_Entry in HiddenInProgressionIds)
		{
			s_HiddenInProgressionIds.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(IgnoreBuild);
		p_Writer.WriteNullBytes(7);
	}
}

