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

[ContainerType(16, 432)]
public class UIScoreboardWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIElementTableStyle> TableStyle { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public uint CellSpacing { get; set; } = 0;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor PingColumnFontColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<UIElementFillData> LocalPlayerFill { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<UIElementFontStyle> LocalPlayerNumberFont { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<UIElementFontStyle> LocalPlayerSquadFont { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<UIElementFillData> SelectedPlayerFill { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public CtrRef<UIElementFontStyle> SelectedPlayerFont { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CtrRef<UIElementFillData> SelectedPlayerNotSpectatableFill { get; set; } = new();
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<UIElementFillData> FriendlyHeaderFill { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<UIElementFillData> EnemyHeaderFill { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<UIElementFillData> SpectatorHeaderFill { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float TeamNameLeftPadding { get; set; } = 6.000f;
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public CtrRef<UIElementFillData> ScoreColumnFill { get; set; } = new();
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public CtrRef<UIElementFontStyle> NumbersFont { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public CtrRef<UIElementFontStyle> SelectedPlayerNumbersFont { get; set; } = new();
	
	[ContainerField(0x108), JsonProperty(Order = 264)]
	public CtrRef<UIElementFontStyle> LocalPlayerSquadNumbersFont { get; set; } = new();
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public uint ScrollbarWidth { get; set; } = 0;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public uint ScrollbarMargin { get; set; } = 5;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float EndOfRoundPreScrollTime { get; set; } = 1.000f;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public float EndOfRoundScrollTime { get; set; } = 2.000f;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float EndOfRoundScrollDA { get; set; } = -100.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float EndOfRoundScrollDB { get; set; } = -100.000f;
	
	[ContainerField(0x128), JsonProperty(Order = 296)]
	public UIScoreboardColumnStyle NumberColumnStyle { get; set; } = new()
	{
		TextAlignment = UIElementAlignment.UIElementAlignment_Center,
		Width = 25.000f,
	};
	
	[ContainerField(0x138), JsonProperty(Order = 312)]
	public UIScoreboardColumnStyle RankColumnStyle { get; set; } = new()
	{
		HasLine = false,
		TextAlignment = UIElementAlignment.UIElementAlignment_Center,
		Width = 35.000f,
	};
	
	[ContainerField(0x148), JsonProperty(Order = 328)]
	public UIScoreboardColumnStyle VoipColumnStyle { get; set; } = new()
	{
		HasLine = false,
		TextAlignment = UIElementAlignment.UIElementAlignment_Center,
	};
	
	[ContainerField(0x158), JsonProperty(Order = 344)]
	public UIScoreboardColumnStyle NameColumnStyle { get; set; } = new()
	{
		HasLine = false,
		Width = 50.000f,
	};
	
	[ContainerField(0x168), JsonProperty(Order = 360)]
	public UIScoreboardColumnStyle KillsColumnStyle { get; set; } = new()
	{
		HasLine = false,
		TextOffset = 5.000f,
		TextAlignment = UIElementAlignment.UIElementAlignment_Right,
		Width = 35.000f,
	};
	
	[ContainerField(0x178), JsonProperty(Order = 376)]
	public UIScoreboardColumnStyle DeathsColumnStyle { get; set; } = new()
	{
		HasLine = false,
		TextOffset = 5.000f,
		TextAlignment = UIElementAlignment.UIElementAlignment_Right,
		Width = 35.000f,
	};
	
	[ContainerField(0x188), JsonProperty(Order = 392)]
	public UIScoreboardColumnStyle ScoreColumnStyle { get; set; } = new()
	{
		TextAlignment = UIElementAlignment.UIElementAlignment_Right,
		Width = 52.000f,
	};
	
	[ContainerField(0x198), JsonProperty(Order = 408)]
	public UIScoreboardColumnStyle PingColumnStyle { get; set; } = new()
	{
		HasLine = false,
		TextAlignment = UIElementAlignment.UIElementAlignment_Right,
		Width = 34.000f,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(TableStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CellSpacing);
		p_Writer.WriteNullBytes(12);
		PingColumnFontColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(LocalPlayerFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LocalPlayerNumberFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LocalPlayerSquadFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedPlayerFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedPlayerFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedPlayerNotSpectatableFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FriendlyHeaderFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(EnemyHeaderFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SpectatorHeaderFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TeamNameLeftPadding);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ScoreColumnFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(NumbersFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedPlayerNumbersFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LocalPlayerSquadNumbersFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ScrollbarWidth);
		p_Writer.Write(ScrollbarMargin);
		p_Writer.Write(EndOfRoundPreScrollTime);
		p_Writer.Write(EndOfRoundScrollTime);
		p_Writer.Write(EndOfRoundScrollDA);
		p_Writer.Write(EndOfRoundScrollDB);
		NumberColumnStyle.Serialize(p_Writer, p_EbxWriter);
		RankColumnStyle.Serialize(p_Writer, p_EbxWriter);
		VoipColumnStyle.Serialize(p_Writer, p_EbxWriter);
		NameColumnStyle.Serialize(p_Writer, p_EbxWriter);
		KillsColumnStyle.Serialize(p_Writer, p_EbxWriter);
		DeathsColumnStyle.Serialize(p_Writer, p_EbxWriter);
		ScoreColumnStyle.Serialize(p_Writer, p_EbxWriter);
		PingColumnStyle.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(8);
	}
}

