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
using fb.GameShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 136)]
public class UIBattledashFriendDetailsWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<UIBattledashDetailPane> FriendDetailsItems { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIWidgetBlueprint> ListPaneWidget { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<UIElementFontStyle> InfoFont { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float LoadingIndicatorTimeout { get; set; } = 8.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_FriendDetailsItems = p_EbxWriter.GetArrayWriter(FriendDetailsItems.GetType(), FriendDetailsItems.Count);
		p_Writer.Write(s_FriendDetailsItems.ArrayIndex);
		foreach (var s_Entry in FriendDetailsItems)
		{
			s_Entry.Serialize(s_FriendDetailsItems.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ListPaneWidget));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(InfoFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(LoadingIndicatorTimeout);
		p_Writer.WriteNullBytes(4);
	}
}

