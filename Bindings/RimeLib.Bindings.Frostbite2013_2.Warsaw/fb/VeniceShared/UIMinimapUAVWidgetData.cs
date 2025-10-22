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

[ContainerType(16, 304)]
public class UIMinimapUAVWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public UIVisualWidgetType VisualWidgetType { get; set; } = UIVisualWidgetType.UIVisualWidgetType_Default;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIMinimapLineStyle> FriendlyScanStyle { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor BackgroundColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<UIMinimapLineStyle> EnemyScanStyle { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<UIMinimapLineStyle> FriendlyJamStyle { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<UIMinimapLineStyle> EnemyJamStyle { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<UIMinimapLineStyle> FriendlyVehicleScanStyle { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public CtrRef<UIMinimapLineStyle> FriendlyInfantryScanStyle { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CtrRef<UIMinimapLineStyle> FriendlyRadarScanStyle { get; set; } = new();
	
	[ContainerField(0xd0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public Vec2 ArrowSize { get; set; } = new()
	{
		y = 32.000f,
		x = 32.000f,
	};
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public string ArrowTextue { get; set; } = string.Empty;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float ScanlineSpeed { get; set; } = 0.050f;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public float ScanlineUVWrap { get; set; } = 3.500f;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float EnemyScanlineAlpha { get; set; } = 0.120f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float FriendlyScanlineAlpha { get; set; } = 0.120f;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public string ColorScanlineTextureId { get; set; } = string.Empty;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public string ScanlineTextureId { get; set; } = string.Empty;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float ColorScanlineSpeed { get; set; } = 0.500f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float ColorScanlineUVWrap { get; set; } = 6.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float EnemyColorScanlineAlpha { get; set; } = 0.100f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float FriendlyColorScanlineAlpha { get; set; } = 0.100f;
	
	[ContainerField(0x110), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public Vec2 Expand { get; set; } = new()
	{
		y = 16.000f,
		x = 16.000f,
	};
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public string ShapeId { get; set; } = string.Empty;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public bool ScanlineVertical { get; set; } = false;
	
	[ContainerField(0x121), LayoutImmutable, Blittable, JsonProperty(Order = 289)]
	public bool ColorScanlineVertical { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) VisualWidgetType);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FriendlyScanStyle));
		p_Writer.WriteNullBytes(12);
		BackgroundColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(EnemyScanStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FriendlyJamStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(EnemyJamStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FriendlyVehicleScanStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FriendlyInfantryScanStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FriendlyRadarScanStyle));
		p_Writer.WriteNullBytes(4);
		ArrowSize.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ArrowTextue));
		p_Writer.Write(ScanlineSpeed);
		p_Writer.Write(ScanlineUVWrap);
		p_Writer.Write(EnemyScanlineAlpha);
		p_Writer.Write(FriendlyScanlineAlpha);
		p_Writer.Write(p_EbxWriter.WriteString(ColorScanlineTextureId));
		p_Writer.Write(p_EbxWriter.WriteString(ScanlineTextureId));
		p_Writer.Write(ColorScanlineSpeed);
		p_Writer.Write(ColorScanlineUVWrap);
		p_Writer.Write(EnemyColorScanlineAlpha);
		p_Writer.Write(FriendlyColorScanlineAlpha);
		Expand.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ShapeId));
		p_Writer.Write(ScanlineVertical);
		p_Writer.Write(ColorScanlineVertical);
		p_Writer.WriteNullBytes(14);
	}
}

