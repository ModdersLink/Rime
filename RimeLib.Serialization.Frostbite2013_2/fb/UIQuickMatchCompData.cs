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

[ContainerType(8, 120)]
public class UIQuickMatchCompData
	: fb.UI.UIComponentData
{
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string NormalWithTutorialButtons { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string NormalNoTutorialButtons { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string BuyDlcWithTutorialButtons { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string BuyDlcNoTutorialButtons { get; set; } = string.Empty;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public List<QuickMatchFilterInfo> Filters { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string NewbiePopupTitle { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string NewbiePopupDescription { get; set; } = string.Empty;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string NormalPopupTitle { get; set; } = string.Empty;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public string NormalPopupDescription { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(NormalWithTutorialButtons));
		p_Writer.Write(p_EbxWriter.WriteString(NormalNoTutorialButtons));
		p_Writer.Write(p_EbxWriter.WriteString(BuyDlcWithTutorialButtons));
		p_Writer.Write(p_EbxWriter.WriteString(BuyDlcNoTutorialButtons));
		(RimeWriter Writer, uint ArrayIndex) s_Filters = p_EbxWriter.GetArrayWriter(Filters.GetType(), Filters.Count);
		p_Writer.Write(s_Filters.ArrayIndex);
		foreach (var s_Entry in Filters)
		{
			s_Entry.Serialize(s_Filters.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(NewbiePopupTitle));
		p_Writer.Write(p_EbxWriter.WriteString(NewbiePopupDescription));
		p_Writer.Write(p_EbxWriter.WriteString(NormalPopupTitle));
		p_Writer.Write(p_EbxWriter.WriteString(NormalPopupDescription));
	}
}

