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

[ContainerType(8, 208)]
public class UIGunmasterScoreboardWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIElementTableStyle> TableStyle { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public uint CellSpacing { get; set; } = 0;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float TeamNameLeftPadding { get; set; } = 6.000f;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<UIElementFillData> ScoreColumnFill { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<UIElementFillData> HeaderFill { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<UIElementFontStyle> NumbersFont { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<UIElementFontStyle> SelectedPlayerNumbersFont { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public CtrRef<UIElementFontStyle> LocalPlayerSquadNumbersFont { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UIScoreboardColumnStyle NumberColumnStyle { get; set; } = new()
	{
		TextAlignment = UIElementAlignment.UIElementAlignment_Center,
		Width = 25.000f,
	};
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public UIScoreboardColumnStyle NameColumnStyle { get; set; } = new()
	{
		HasLine = false,
		Width = 50.000f,
	};
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIScoreboardColumnStyle LevelColumnStyle { get; set; } = new()
	{
		HasLine = false,
		TextAlignment = UIElementAlignment.UIElementAlignment_Center,
		Width = 35.000f,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(TableStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CellSpacing);
		p_Writer.Write(TeamNameLeftPadding);
		p_Writer.Write(p_EbxWriter.WriteImport(ScoreColumnFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HeaderFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(NumbersFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedPlayerNumbersFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LocalPlayerSquadNumbersFont));
		p_Writer.WriteNullBytes(4);
		NumberColumnStyle.Serialize(p_Writer, p_EbxWriter);
		NameColumnStyle.Serialize(p_Writer, p_EbxWriter);
		LevelColumnStyle.Serialize(p_Writer, p_EbxWriter);
	}
}

