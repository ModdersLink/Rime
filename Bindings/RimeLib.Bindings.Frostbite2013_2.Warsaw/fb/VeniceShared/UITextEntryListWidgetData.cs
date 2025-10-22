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
using fb.GameShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 272)]
public class UITextEntryListWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float ScrollSpeed { get; set; } = 10.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public uint ScrollBarWidth { get; set; } = 15;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public UIElementColor EntryFontColor { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public UIElementColor HeaderFontColor { get; set; } = new();
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public uint ScrollBarMargin { get; set; } = 5;
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<UIElementScrollbarStyle> ScrollBarStyle { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public List<string> Entries { get; set; } = new();
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public uint EntryHeight { get; set; } = 32;
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<UIElementFillData> EntryRowFill { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<UIElementFontStyle> EntryFontStyle { get; set; } = new();
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public uint RowSpacing { get; set; } = 0;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public string Header { get; set; } = string.Empty;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public uint HeaderHeight { get; set; } = 32;
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public CtrRef<UIElementFillData> HeaderRowFill { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public CtrRef<UIElementFontStyle> HeaderFontStyle { get; set; } = new();
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public UIInputAction ScrollUpAction { get; set; } = UIInputAction.UIInputAction_NavigateRUp;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public UIInputAction ScrollDownAction { get; set; } = UIInputAction.UIInputAction_NavigateRDown;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ScrollSpeed);
		p_Writer.Write(ScrollBarWidth);
		EntryFontColor.Serialize(p_Writer, p_EbxWriter);
		HeaderFontColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ScrollBarMargin);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ScrollBarStyle));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Entries = p_EbxWriter.GetArrayWriter(Entries.GetType(), Entries.Count);
		p_Writer.Write(s_Entries.ArrayIndex);
		foreach (var s_Entry in Entries)
		{
			s_Entries.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(EntryHeight);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(EntryRowFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(EntryFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RowSpacing);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(Header));
		p_Writer.Write(HeaderHeight);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HeaderRowFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HeaderFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) ScrollUpAction);
		p_Writer.Write((int) ScrollDownAction);
	}
}

