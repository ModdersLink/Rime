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

[ContainerType(8, 184)]
public class UITextListWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public uint RowHeight { get; set; } = 24;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public uint CategoryHeight { get; set; } = 20;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIElementFontStyle> Font { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<UIElementTableStyle> TableStyle { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public uint CellSpacing { get; set; } = 1;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<UIElementFillData> SelectedRowFill { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<UIElementFontStyle> SelectedRowFont { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public uint XOffset { get; set; } = 5;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public uint XOffsetRight { get; set; } = 5;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public uint ScrollbarWidth { get; set; } = 15;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public int ScrollbarMargin { get; set; } = 5;
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<UIWidgetBlueprint> WidgetTemplate { get; set; } = new();
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public bool AlwaysShowScrollbar { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RowHeight);
		p_Writer.Write(CategoryHeight);
		p_Writer.Write(p_EbxWriter.WriteImport(Font));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TableStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CellSpacing);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedRowFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedRowFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(XOffset);
		p_Writer.Write(XOffsetRight);
		p_Writer.Write(ScrollbarWidth);
		p_Writer.Write(ScrollbarMargin);
		p_Writer.Write(p_EbxWriter.WriteImport(WidgetTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AlwaysShowScrollbar);
		p_Writer.WriteNullBytes(7);
	}
}

