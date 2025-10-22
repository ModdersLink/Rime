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

[ContainerType(16, 448)]
public class UIScoringWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float LineSpeed { get; set; } = 250.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float LineHeight { get; set; } = 30.000f;
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec4 ScoreEventRect { get; set; } = new()
	{
		w = 40.000f,
		z = 300.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec4 ScoreAmountRect { get; set; } = new()
	{
		w = 40.000f,
		z = 350.000f,
		y = 0.000f,
		x = 300.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec4 BoostIconRect { get; set; } = new()
	{
		w = 20.000f,
		z = 370.000f,
		y = 0.000f,
		x = 350.000f,
	};
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UIElementColor WeaponTextColor { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIElementColor ScoreTextColor { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public UIElementColor ScoreAmountColor { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public UIElementColor BoostIconColor { get; set; } = new();
	
	[ContainerField(0x120), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public Vec4 SwipeStartRect { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x130), JsonProperty(Order = 304)]
	public UIElementColor AggregatorColor { get; set; } = new();
	
	[ContainerField(0x150), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public Vec4 AggregatorDrawRect { get; set; } = new()
	{
		w = 80.000f,
		z = 500.000f,
		y = 0.000f,
		x = 400.000f,
	};
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public uint TableSize { get; set; } = 5;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public float AlphaScale { get; set; } = 0.001f;
	
	[ContainerField(0x168), JsonProperty(Order = 360)]
	public CtrRef<UIElementFontStyle> LineMajorFontStyle { get; set; } = new();
	
	[ContainerField(0x170), JsonProperty(Order = 368)]
	public CtrRef<UIElementFontStyle> LineMinorFontStyle { get; set; } = new();
	
	[ContainerField(0x178), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
	public float LineDisplayTime { get; set; } = 5.000f;
	
	[ContainerField(0x17c), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
	public float LineStartFadeTime { get; set; } = 2.500f;
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public float LineAlphaDecreaseSpeed { get; set; } = 5.000f;
	
	[ContainerField(0x184), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
	public float LineScaleSpeed { get; set; } = 2.500f;
	
	[ContainerField(0x188), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
	public float LineTargetScale { get; set; } = 1.300f;
	
	[ContainerField(0x18c), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
	public float SwipeSpeed { get; set; } = 1000.000f;
	
	[ContainerField(0x190), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
	public float SwipeTarget { get; set; } = 400.000f;
	
	[ContainerField(0x194), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
	public float ShowEventTime { get; set; } = 1.000f;
	
	[ContainerField(0x198), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
	public float AggregatorAlphaDecreaseSpeed { get; set; } = 5.000f;
	
	[ContainerField(0x1a0), JsonProperty(Order = 416)]
	public CtrRef<UIElementFontStyle> AggregatorFont { get; set; } = new();
	
	[ContainerField(0x1a8), LayoutImmutable, Blittable, JsonProperty(Order = 424)]
	public float AggregatorScaleSpeed { get; set; } = 2.500f;
	
	[ContainerField(0x1ac), LayoutImmutable, Blittable, JsonProperty(Order = 428)]
	public float AggregatorTargetScale { get; set; } = 1.300f;
	
	[ContainerField(0x1b0), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
	public float AggregatorLifetime { get; set; } = 2.000f;
	
	[ContainerField(0x1b4), LayoutImmutable, Blittable, JsonProperty(Order = 436)]
	public float CursorFrameRate { get; set; } = 30.000f;
	
	[ContainerField(0x1b8), LayoutImmutable, Blittable, JsonProperty(Order = 440)]
	public bool DisplayKillInfo { get; set; } = true;
	
	[ContainerField(0x1b9), LayoutImmutable, Blittable, JsonProperty(Order = 441)]
	public bool DrawCursor { get; set; } = true;
	
	[ContainerField(0x1ba), LayoutImmutable, Blittable, JsonProperty(Order = 442)]
	public bool BlinkCursor { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LineSpeed);
		p_Writer.Write(LineHeight);
		ScoreEventRect.Serialize(p_Writer, p_EbxWriter);
		ScoreAmountRect.Serialize(p_Writer, p_EbxWriter);
		BoostIconRect.Serialize(p_Writer, p_EbxWriter);
		WeaponTextColor.Serialize(p_Writer, p_EbxWriter);
		ScoreTextColor.Serialize(p_Writer, p_EbxWriter);
		ScoreAmountColor.Serialize(p_Writer, p_EbxWriter);
		BoostIconColor.Serialize(p_Writer, p_EbxWriter);
		SwipeStartRect.Serialize(p_Writer, p_EbxWriter);
		AggregatorColor.Serialize(p_Writer, p_EbxWriter);
		AggregatorDrawRect.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TableSize);
		p_Writer.Write(AlphaScale);
		p_Writer.Write(p_EbxWriter.WriteImport(LineMajorFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LineMinorFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(LineDisplayTime);
		p_Writer.Write(LineStartFadeTime);
		p_Writer.Write(LineAlphaDecreaseSpeed);
		p_Writer.Write(LineScaleSpeed);
		p_Writer.Write(LineTargetScale);
		p_Writer.Write(SwipeSpeed);
		p_Writer.Write(SwipeTarget);
		p_Writer.Write(ShowEventTime);
		p_Writer.Write(AggregatorAlphaDecreaseSpeed);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AggregatorFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AggregatorScaleSpeed);
		p_Writer.Write(AggregatorTargetScale);
		p_Writer.Write(AggregatorLifetime);
		p_Writer.Write(CursorFrameRate);
		p_Writer.Write(DisplayKillInfo);
		p_Writer.Write(DrawCursor);
		p_Writer.Write(BlinkCursor);
		p_Writer.WriteNullBytes(5);
	}
}

