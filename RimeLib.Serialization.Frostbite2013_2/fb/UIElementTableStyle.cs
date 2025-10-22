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

[ContainerType(8, 80)]
public class UIElementTableStyle
	: fb.GameShared.UIElementStyle
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<UIElementScrollbarStyle> StyleScroll { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<UIElementFillData> FillHeader { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<UIElementFillData> FillCell { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<UIElementFontStyle> HeaderFontStyle { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<UIElementFontStyle> CellFontStyle { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<UIElementFillData> FillRowsBounds { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float HeaderHeight { get; set; } = 32.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float RowHeight { get; set; } = 31.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(StyleScroll));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FillHeader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FillCell));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HeaderFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CellFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FillRowsBounds));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(HeaderHeight);
		p_Writer.Write(RowHeight);
	}
}

