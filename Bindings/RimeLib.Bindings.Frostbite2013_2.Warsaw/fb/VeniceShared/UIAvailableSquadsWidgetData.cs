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

[ContainerType(16, 272)]
public class UIAvailableSquadsWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public uint RowHeight { get; set; } = 24;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIElementFontStyle> Font { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor SelectedSquadDisabledColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<UIElementFontStyle> FontLocalSquad { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<UIElementFontStyle> SelectedRowFontLocalSquad { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<UIElementFontStyle> SelectedRowFontNoFocusLocalSquad { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<UIElementTableStyle> TableStyle { get; set; } = new();
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public uint CellSpacing { get; set; } = 1;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public uint KillsCellWidth { get; set; } = 32;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public uint DeathsCellWidth { get; set; } = 32;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public uint ScoreCellWidth { get; set; } = 64;
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<UIElementFillData> SelectedRowFill { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<UIElementFontStyle> SelectedRowFont { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<UIElementFillData> SelectedRowFillNoFocus { get; set; } = new();
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public CtrRef<UIElementFontStyle> SelectedRowFontNoFocus { get; set; } = new();
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public uint ScrollbarWidth { get; set; } = 0;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public uint ScrollbarMargin { get; set; } = 5;
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public CtrRef<UIElementFillData> ListBackgroundFill { get; set; } = new();
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float SquadPlayersIconWidth { get; set; } = 26.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RowHeight);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Font));
		p_Writer.WriteNullBytes(12);
		SelectedSquadDisabledColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(FontLocalSquad));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedRowFontLocalSquad));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedRowFontNoFocusLocalSquad));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TableStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CellSpacing);
		p_Writer.Write(KillsCellWidth);
		p_Writer.Write(DeathsCellWidth);
		p_Writer.Write(ScoreCellWidth);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedRowFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedRowFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedRowFillNoFocus));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedRowFontNoFocus));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ScrollbarWidth);
		p_Writer.Write(ScrollbarMargin);
		p_Writer.Write(p_EbxWriter.WriteImport(ListBackgroundFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SquadPlayersIconWidth);
		p_Writer.WriteNullBytes(12);
	}
}

