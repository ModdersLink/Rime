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

[ContainerType(8, 192)]
public class UICreditsWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIElementFontStyle> HeaderFontStyle { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIElementFontStyle> TitleFontStyle { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<UIElementFontStyle> NameFontStyle { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<UIElementFontStyle> LeadsNameFontStyleLeft { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<UIElementFontStyle> LeadsNameFontStyleRight { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float ScrollSpeed { get; set; } = 100.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float ExtraSpaceBetweenRows { get; set; } = 0.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float EmptyRowHeight { get; set; } = 10.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float SpaceBetweenColumns { get; set; } = 10.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float HeaderRowHeight { get; set; } = 18.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float TitleRowHeight { get; set; } = 18.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float NameRowHeight { get; set; } = 18.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float LeadsNameRowHeight { get; set; } = 18.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float StartOffset { get; set; } = 0.000f;
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public List<string> CreditsAssetPaths { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(HeaderFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TitleFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(NameFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LeadsNameFontStyleLeft));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LeadsNameFontStyleRight));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ScrollSpeed);
		p_Writer.Write(ExtraSpaceBetweenRows);
		p_Writer.Write(EmptyRowHeight);
		p_Writer.Write(SpaceBetweenColumns);
		p_Writer.Write(HeaderRowHeight);
		p_Writer.Write(TitleRowHeight);
		p_Writer.Write(NameRowHeight);
		p_Writer.Write(LeadsNameRowHeight);
		p_Writer.Write(StartOffset);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_CreditsAssetPaths = p_EbxWriter.GetArrayWriter(CreditsAssetPaths.GetType(), CreditsAssetPaths.Count);
		p_Writer.Write(s_CreditsAssetPaths.ArrayIndex);
		foreach (var s_Entry in CreditsAssetPaths)
		{
			s_CreditsAssetPaths.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

