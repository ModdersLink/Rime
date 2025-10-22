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

namespace fb.GameShared;

[ContainerType(16, 96)]
public class UIElementFontDefinition
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<UIImmediateModeFontLookup> FontLookup { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public UIElementFont Font { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float LetterSpacing { get; set; } = 0.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public int RowSpacing { get; set; } = 0;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<UIElementTextFilter> Filters { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public UIElementColor Color { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_FontLookup = p_EbxWriter.GetArrayWriter(FontLookup.GetType(), FontLookup.Count);
		p_Writer.Write(s_FontLookup.ArrayIndex);
		foreach (var s_Entry in FontLookup)
		{
			s_Entry.Serialize(s_FontLookup.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		Font.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LetterSpacing);
		p_Writer.Write(RowSpacing);
		(RimeWriter Writer, uint ArrayIndex) s_Filters = p_EbxWriter.GetArrayWriter(Filters.GetType(), Filters.Count);
		p_Writer.Write(s_Filters.ArrayIndex);
		foreach (var s_Entry in Filters)
		{
			s_Filters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(12);
		Color.Serialize(p_Writer, p_EbxWriter);
	}
}

