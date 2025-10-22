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

[ContainerType(8, 160)]
public class UISPLoadingWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIElementFontStyle> IconLabelFontStyle { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float ScanDelay { get; set; } = 1.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float ScanSpeed { get; set; } = 0.250f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float DistortPowerMin { get; set; } = 0.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float DistortPowerMax { get; set; } = 10.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float ScanlineAlphaMin { get; set; } = 0.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float ScanlineAlphaMax { get; set; } = 0.200f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float RedShiftStart { get; set; } = -0.002f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float RedShiftEnd { get; set; } = -0.002f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float GreenShiftStart { get; set; } = 0.200f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float GreenShiftEnd { get; set; } = 0.200f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float BlueShiftStart { get; set; } = -0.300f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float BlueShiftEnd { get; set; } = -0.300f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(IconLabelFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ScanDelay);
		p_Writer.Write(ScanSpeed);
		p_Writer.Write(DistortPowerMin);
		p_Writer.Write(DistortPowerMax);
		p_Writer.Write(ScanlineAlphaMin);
		p_Writer.Write(ScanlineAlphaMax);
		p_Writer.Write(RedShiftStart);
		p_Writer.Write(RedShiftEnd);
		p_Writer.Write(GreenShiftStart);
		p_Writer.Write(GreenShiftEnd);
		p_Writer.Write(BlueShiftStart);
		p_Writer.Write(BlueShiftEnd);
	}
}

