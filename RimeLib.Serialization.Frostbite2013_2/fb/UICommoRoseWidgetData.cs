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

[ContainerType(16, 272)]
public class UICommoRoseWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<UICommoRoseButtonInfo> ButtonInfo { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public UIElementRect InactiveRect { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementRect ActiveRect { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<UIElementFontStyle> InactiveFontStyle { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UIElementColor InactiveRectColor { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIElementColor ActiveRectColor { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<UIElementFontStyle> ActiveFontStyle { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public uint DeadzoneSize { get; set; } = 50;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float ButtonStickyness { get; set; } = 0.500f;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float InputReturnDelay { get; set; } = 0.200f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public float FastFadeSeconds { get; set; } = 0.200f;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float SlowFadeSeconds { get; set; } = 0.500f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float HighlightBumpSeconds { get; set; } = 0.300f;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public int HighlightBumps { get; set; } = 2;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public bool DrawDirectionArrow { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ButtonInfo = p_EbxWriter.GetArrayWriter(ButtonInfo.GetType(), ButtonInfo.Count);
		p_Writer.Write(s_ButtonInfo.ArrayIndex);
		foreach (var s_Entry in ButtonInfo)
		{
			s_Entry.Serialize(s_ButtonInfo.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		InactiveRect.Serialize(p_Writer, p_EbxWriter);
		ActiveRect.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(InactiveFontStyle));
		p_Writer.WriteNullBytes(12);
		InactiveRectColor.Serialize(p_Writer, p_EbxWriter);
		ActiveRectColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(ActiveFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DeadzoneSize);
		p_Writer.Write(ButtonStickyness);
		p_Writer.Write(InputReturnDelay);
		p_Writer.Write(FastFadeSeconds);
		p_Writer.Write(SlowFadeSeconds);
		p_Writer.Write(HighlightBumpSeconds);
		p_Writer.Write(HighlightBumps);
		p_Writer.Write(DrawDirectionArrow);
		p_Writer.WriteNullBytes(11);
	}
}

