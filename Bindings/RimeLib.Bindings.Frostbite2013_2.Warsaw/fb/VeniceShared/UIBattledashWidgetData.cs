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

[ContainerType(16, 320)]
public class UIBattledashWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float PaneSpacing { get; set; } = 1.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float IconPadding { get; set; } = 2.000f;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public UIElementColor IconColor { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public UIElementColor IconHighlightColor { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public UIElementColor PaneBackgroundColor { get; set; } = new();
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float IconNumberPadding { get; set; } = 1.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float OverrideLabelWidth { get; set; } = 0.000f;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<UIElementFontStyle> IndicatorFont { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<UIElementFontStyle> IndicatorHighlightFont { get; set; } = new();
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public List<UIBattledashIndicatorData> Indicators { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public List<UIBattledashIndicatorData> Gen3Indicators { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float LoadingDisplayUpdateFrequency { get; set; } = 0.500f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float ScaleUpSpeed { get; set; } = 1.000f;
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public CtrRef<UIElementFontStyle> NotificationFont { get; set; } = new();
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float NotificationDisplayTime { get; set; } = 10.000f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float TabContextTimeout { get; set; } = 8.000f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float NotificationAnimationTime { get; set; } = 0.300f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float NotificationVOffset { get; set; } = 30.000f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float NotificationFadeOutTime { get; set; } = 0.160f;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public uint inGame { get; set; } = 1;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float SpinAngle { get; set; } = 4.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float StartPointX { get; set; } = 200.000f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public float StartPointY { get; set; } = 50.000f;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public float Rotation { get; set; } = 1.000f;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float AnimationSpeed { get; set; } = 0.500f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public bool DrawPanesInGame { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PaneSpacing);
		p_Writer.Write(IconPadding);
		IconColor.Serialize(p_Writer, p_EbxWriter);
		IconHighlightColor.Serialize(p_Writer, p_EbxWriter);
		PaneBackgroundColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(IconNumberPadding);
		p_Writer.Write(OverrideLabelWidth);
		p_Writer.Write(p_EbxWriter.WriteImport(IndicatorFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(IndicatorHighlightFont));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Indicators = p_EbxWriter.GetArrayWriter(Indicators.GetType(), Indicators.Count);
		p_Writer.Write(s_Indicators.ArrayIndex);
		foreach (var s_Entry in Indicators)
		{
			s_Entry.Serialize(s_Indicators.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Gen3Indicators = p_EbxWriter.GetArrayWriter(Gen3Indicators.GetType(), Gen3Indicators.Count);
		p_Writer.Write(s_Gen3Indicators.ArrayIndex);
		foreach (var s_Entry in Gen3Indicators)
		{
			s_Entry.Serialize(s_Gen3Indicators.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(LoadingDisplayUpdateFrequency);
		p_Writer.Write(ScaleUpSpeed);
		p_Writer.Write(p_EbxWriter.WriteImport(NotificationFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(NotificationDisplayTime);
		p_Writer.Write(TabContextTimeout);
		p_Writer.Write(NotificationAnimationTime);
		p_Writer.Write(NotificationVOffset);
		p_Writer.Write(NotificationFadeOutTime);
		p_Writer.Write(inGame);
		p_Writer.Write(SpinAngle);
		p_Writer.Write(StartPointX);
		p_Writer.Write(StartPointY);
		p_Writer.Write(Rotation);
		p_Writer.Write(AnimationSpeed);
		p_Writer.Write(DrawPanesInGame);
		p_Writer.WriteNullBytes(11);
	}
}

