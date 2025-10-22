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

[ContainerType(8, 120)]
public class FlatOutputNodeConfigData
	: fb.Audio.OutputNodeConfigData
{
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float WorldAngle { get; set; } = 0.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float Angle { get; set; } = 0.000f;
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public AudioCurve ReverbAttenuationCurve { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float ReverbGain { get; set; } = -12.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public bool IsWorldAligned { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WorldAngle);
		p_Writer.Write(Angle);
		ReverbAttenuationCurve.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ReverbGain);
		p_Writer.Write(IsWorldAligned);
		p_Writer.WriteNullBytes(3);
	}
}

