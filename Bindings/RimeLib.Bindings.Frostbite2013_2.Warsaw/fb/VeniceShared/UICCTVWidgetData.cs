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

[ContainerType(16, 208)]
public class UICCTVWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float NoiseSpeed { get; set; } = 0.100f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float ScanlineWrapAmount { get; set; } = 8.000f;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public UIElementColor Color { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float ScanlineSpeed { get; set; } = 0.100f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float ScanlinePower { get; set; } = 1.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float ColorScanlineWrapAmount { get; set; } = 8.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float ColorScanlineSpeed { get; set; } = 0.100f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float ColorScanlinePower { get; set; } = 0.100f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float RgbSaturation { get; set; } = 1.500f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float RgbContrast { get; set; } = 1.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float RDistortAmount { get; set; } = 0.100f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float Power { get; set; } = 0.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float ExternalPowerSpeed { get; set; } = 2.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float DistortMinTime { get; set; } = 3.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float DistortMaxTime { get; set; } = 6.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float TVNoiseSpeed { get; set; } = 1.750f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public bool EnableNoise { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(NoiseSpeed);
		p_Writer.Write(ScanlineWrapAmount);
		Color.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ScanlineSpeed);
		p_Writer.Write(ScanlinePower);
		p_Writer.Write(ColorScanlineWrapAmount);
		p_Writer.Write(ColorScanlineSpeed);
		p_Writer.Write(ColorScanlinePower);
		p_Writer.Write(RgbSaturation);
		p_Writer.Write(RgbContrast);
		p_Writer.Write(RDistortAmount);
		p_Writer.Write(Power);
		p_Writer.Write(ExternalPowerSpeed);
		p_Writer.Write(DistortMinTime);
		p_Writer.Write(DistortMaxTime);
		p_Writer.Write(TVNoiseSpeed);
		p_Writer.Write(EnableNoise);
		p_Writer.WriteNullBytes(11);
	}
}

