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

[ContainerType(16, 160)]
public class ConeOutputNodeConfigData
	: fb.Audio.OutputNodeConfigData
{
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float OutsideGain { get; set; } = -12.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float PanSize { get; set; } = 2.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float BleedMinDistance { get; set; } = 2.500f;
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 Direction { get; set; } = new()
	{
		z = 0.000f,
		y = 1.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float BleedMaxDistance { get; set; } = 3.500f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float HFDampingAngle { get; set; } = 1.000f;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public AudioCurve ReverbAttenuationCurve { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float ReverbGain { get; set; } = -12.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(OutsideGain);
		p_Writer.Write(PanSize);
		p_Writer.Write(BleedMinDistance);
		p_Writer.WriteNullBytes(12);
		Direction.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(BleedMaxDistance);
		p_Writer.Write(HFDampingAngle);
		ReverbAttenuationCurve.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ReverbGain);
		p_Writer.WriteNullBytes(4);
	}
}

