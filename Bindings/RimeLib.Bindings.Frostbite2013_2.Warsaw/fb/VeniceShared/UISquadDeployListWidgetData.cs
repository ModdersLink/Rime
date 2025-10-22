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
public class UISquadDeployListWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIWidgetBlueprint> RowTemplate { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIElementScrollbarStyle> ScrollBarStyle { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public uint ScrollbarWidth { get; set; } = 0;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public uint ScrollbarMargin { get; set; } = 5;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public List<SquadIcon> ExistingSquadIcons { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(RowTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ScrollBarStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ScrollbarWidth);
		p_Writer.Write(ScrollbarMargin);
		(RimeWriter Writer, uint ArrayIndex) s_ExistingSquadIcons = p_EbxWriter.GetArrayWriter(ExistingSquadIcons.GetType(), ExistingSquadIcons.Count);
		p_Writer.Write(s_ExistingSquadIcons.ArrayIndex);
		foreach (var s_Entry in ExistingSquadIcons)
		{
			s_Entry.Serialize(s_ExistingSquadIcons.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

