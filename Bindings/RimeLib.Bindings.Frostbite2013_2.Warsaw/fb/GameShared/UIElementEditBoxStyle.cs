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

[ContainerType(16, 112)]
public class UIElementEditBoxStyle
	: fb.GameShared.UIElementStyle
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<UIElementFillData> FillDataNormal { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public UIElementColor BarColor { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<UIElementFillData> FillDataHovered { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<UIElementFillData> FillDataActive { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<UIElementFontStyle> FontStyleNormal { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float MarginTop { get; set; } = 0.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float MarginLeft { get; set; } = 0.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float MarginRight { get; set; } = 0.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float MarginBottom { get; set; } = 0.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float BarThickness { get; set; } = 2.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float BarOffsetX { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(FillDataNormal));
		p_Writer.WriteNullBytes(4);
		BarColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(FillDataHovered));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FillDataActive));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FontStyleNormal));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MarginTop);
		p_Writer.Write(MarginLeft);
		p_Writer.Write(MarginRight);
		p_Writer.Write(MarginBottom);
		p_Writer.Write(BarThickness);
		p_Writer.Write(BarOffsetX);
	}
}

