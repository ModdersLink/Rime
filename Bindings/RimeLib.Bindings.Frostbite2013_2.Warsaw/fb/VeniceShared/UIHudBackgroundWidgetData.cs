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

[ContainerType(16, 224)]
public class UIHudBackgroundWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string UseOpacitySettingProfileOption { get; set; } = string.Empty;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float ScanlineSpeed { get; set; } = 0.050f;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor BackgroundColor { get; set; } = new();
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float ScanlineUVWrap { get; set; } = 3.500f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float ScanlineAlpha { get; set; } = 0.120f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float ColorScanlineSpeed { get; set; } = 0.500f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float ColorScanlineUVWrap { get; set; } = 6.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float ColorScanlineAlpha { get; set; } = 0.100f;
	
	[ContainerField(0xb4), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public Vec2 Expand { get; set; } = new()
	{
		y = 16.000f,
		x = 16.000f,
	};
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float CutoffMargin { get; set; } = 2.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public string ShapeId { get; set; } = string.Empty;
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CtrRef<UIElementGenericStyle> Style { get; set; } = new();
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public bool UseOpacitySetting { get; set; } = true;
	
	[ContainerField(0xd1), LayoutImmutable, Blittable, JsonProperty(Order = 209)]
	public bool RenderDummiesSeparately { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(UseOpacitySettingProfileOption));
		p_Writer.Write(ScanlineSpeed);
		p_Writer.WriteNullBytes(12);
		BackgroundColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ScanlineUVWrap);
		p_Writer.Write(ScanlineAlpha);
		p_Writer.Write(ColorScanlineSpeed);
		p_Writer.Write(ColorScanlineUVWrap);
		p_Writer.Write(ColorScanlineAlpha);
		Expand.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CutoffMargin);
		p_Writer.Write(p_EbxWriter.WriteString(ShapeId));
		p_Writer.Write(p_EbxWriter.WriteImport(Style));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(UseOpacitySetting);
		p_Writer.Write(RenderDummiesSeparately);
		p_Writer.WriteNullBytes(14);
	}
}

