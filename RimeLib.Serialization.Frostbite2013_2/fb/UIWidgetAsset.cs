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

namespace fb.UI;

[ContainerType(8, 40)]
public class UIWidgetAsset
	: fb.UI.UIAsset
{
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<WidgetEventQueryPair> WidgetEvents { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_WidgetEvents = p_EbxWriter.GetArrayWriter(WidgetEvents.GetType(), WidgetEvents.Count);
		p_Writer.Write(s_WidgetEvents.ArrayIndex);
		foreach (var s_Entry in WidgetEvents)
		{
			s_Entry.Serialize(s_WidgetEvents.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

