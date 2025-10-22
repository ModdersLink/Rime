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

namespace fb.Audio;

[ContainerType(8, 88)]
public class HdrSetting
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float WindowMinTop { get; set; } = 80.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float WindowMinBottom { get; set; } = 20.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float WindowTopMinReleaseTime { get; set; } = 0.150f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float WindowTopMaxReleaseTime { get; set; } = 1.200f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float WindowTopAttackTime { get; set; } = 0.100f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float WindowBottomReleaseTime { get; set; } = 0.100f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioCurve WindowTopReleaseTimeCurve { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float DischargeFactor { get; set; } = 3.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float MaxAllowedEnergy { get; set; } = 100.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float WindowBottomAttackTime { get; set; } = 0.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float WindowSize { get; set; } = 40.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float CompressFactor { get; set; } = 1.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float Headroom { get; set; } = 3.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float AllowedOvershoot { get; set; } = 6.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WindowMinTop);
		p_Writer.Write(WindowMinBottom);
		p_Writer.Write(WindowTopMinReleaseTime);
		p_Writer.Write(WindowTopMaxReleaseTime);
		p_Writer.Write(WindowTopAttackTime);
		p_Writer.Write(WindowBottomReleaseTime);
		WindowTopReleaseTimeCurve.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DischargeFactor);
		p_Writer.Write(MaxAllowedEnergy);
		p_Writer.Write(WindowBottomAttackTime);
		p_Writer.Write(WindowSize);
		p_Writer.Write(CompressFactor);
		p_Writer.Write(Headroom);
		p_Writer.Write(AllowedOvershoot);
		p_Writer.WriteNullBytes(4);
	}
}

