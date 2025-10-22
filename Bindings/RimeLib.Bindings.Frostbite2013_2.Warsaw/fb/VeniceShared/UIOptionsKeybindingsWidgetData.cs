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

[ContainerType(16, 240)]
public class UIOptionsKeybindingsWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string ActivationString { get; set; } = string.Empty;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public string TabName { get; set; } = string.Empty;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor HeaderFontColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public List<string> Headers { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<UIElementFontStyle> HeaderFont { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<UIElementFillData> HeaderFill { get; set; } = new();
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float HeaderHeight { get; set; } = 32.000f;
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public CtrRef<UIElementButtonStyle> RowButtonStyle { get; set; } = new();
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float RowHeight { get; set; } = 32.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float AutoScrollSpeed { get; set; } = 20.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public uint ScrollBarWidth { get; set; } = 15;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public uint ScrollBarMargin { get; set; } = 5;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<UIElementScrollbarStyle> ScrollBarStyle { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public List<UIOptionTableColumn> Columns { get; set; } = new();
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public List<UIOptionKeyBindingsType> Types { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ActivationString));
		p_Writer.Write(p_EbxWriter.WriteString(TabName));
		p_Writer.WriteNullBytes(8);
		HeaderFontColor.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Headers = p_EbxWriter.GetArrayWriter(Headers.GetType(), Headers.Count);
		p_Writer.Write(s_Headers.ArrayIndex);
		foreach (var s_Entry in Headers)
		{
			s_Headers.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HeaderFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HeaderFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(HeaderHeight);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(RowButtonStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RowHeight);
		p_Writer.Write(AutoScrollSpeed);
		p_Writer.Write(ScrollBarWidth);
		p_Writer.Write(ScrollBarMargin);
		p_Writer.Write(p_EbxWriter.WriteImport(ScrollBarStyle));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Columns = p_EbxWriter.GetArrayWriter(Columns.GetType(), Columns.Count);
		p_Writer.Write(s_Columns.ArrayIndex);
		foreach (var s_Entry in Columns)
		{
			s_Entry.Serialize(s_Columns.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Types = p_EbxWriter.GetArrayWriter(Types.GetType(), Types.Count);
		p_Writer.Write(s_Types.ArrayIndex);
		foreach (var s_Entry in Types)
		{
			s_Entry.Serialize(s_Types.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

