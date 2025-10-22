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

using fb.GameShared;
using fb.Core;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 128)]
public class UIBattledashChallengeDetailsWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<UIBattledashDetailPane> ChallengeDetailsItems { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIWidgetBlueprint> ListPaneWidget { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<UIElementFontStyle> InfoFont { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ChallengeDetailsItems = p_EbxWriter.GetArrayWriter(ChallengeDetailsItems.GetType(), ChallengeDetailsItems.Count);
		p_Writer.Write(s_ChallengeDetailsItems.ArrayIndex);
		foreach (var s_Entry in ChallengeDetailsItems)
		{
			s_Entry.Serialize(s_ChallengeDetailsItems.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ListPaneWidget));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(InfoFont));
		p_Writer.WriteNullBytes(4);
	}
}

