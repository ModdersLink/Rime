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

[ContainerType(16, 224)]
public class UIElementButtonStyle
	: fb.GameShared.UIElementStyle
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string TextureId { get; set; } = string.Empty;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public UIElementColor NormalTextColor { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public UIElementColor HoveredTextColor { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public UIElementColor PressedTextColor { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor DisabledTextColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<UIElementFillData> FillDataNormal { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<UIElementFillData> FillDataHovered { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<UIElementFillData> FillDataPressed { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<UIElementFillData> FillDataDisabled { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public CtrRef<UIElementFontStyle> NormalFontStyle { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CtrRef<UIElementFontStyle> HoveredFontStyle { get; set; } = new();
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<UIElementFontStyle> PressedFontStyle { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<UIElementFontStyle> DisabledFontStyle { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(TextureId));
		NormalTextColor.Serialize(p_Writer, p_EbxWriter);
		HoveredTextColor.Serialize(p_Writer, p_EbxWriter);
		PressedTextColor.Serialize(p_Writer, p_EbxWriter);
		DisabledTextColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(FillDataNormal));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FillDataHovered));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FillDataPressed));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FillDataDisabled));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(NormalFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HoveredFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PressedFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DisabledFontStyle));
		p_Writer.WriteNullBytes(4);
	}
}

