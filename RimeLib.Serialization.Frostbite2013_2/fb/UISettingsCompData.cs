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
public class UISettingsCompData
	: fb.UI.UIComponentData
{
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<UISettingsPage> SettingsPages { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_SettingsPages = p_EbxWriter.GetArrayWriter(SettingsPages.GetType(), SettingsPages.Count);
		p_Writer.Write(s_SettingsPages.ArrayIndex);
		foreach (var s_Entry in SettingsPages)
		{
			s_Entry.Serialize(s_SettingsPages.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

