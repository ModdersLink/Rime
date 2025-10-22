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

namespace fb.GameShared;

[ContainerType(8, 48)]
public class ProfileOptionDataEnum
	: fb.GameShared.ProfileOptionData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<ProfileOptionDataEnumItem> Items { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Items = p_EbxWriter.GetArrayWriter(Items.GetType(), Items.Count);
		p_Writer.Write(s_Items.ArrayIndex);
		foreach (var s_Entry in Items)
		{
			s_Entry.Serialize(s_Items.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

