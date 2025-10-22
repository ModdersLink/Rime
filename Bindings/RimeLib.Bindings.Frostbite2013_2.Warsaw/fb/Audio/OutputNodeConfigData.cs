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
public class OutputNodeConfigData
	: fb.Audio.AudioGraphNodeConfigData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float MinDistance { get; set; } = 1.000f;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioCurve AttenuationCurve { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float HFDampingDistance { get; set; } = 1.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float HFDampingObstruction { get; set; } = 1.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float HFDampingOcclusion { get; set; } = 1.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float HFObstructionAmplitudeReduction { get; set; } = 0.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float Gain { get; set; } = 0.000f;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<MixGroup> MixGroup { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool EnableHdr { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MinDistance);
		p_Writer.WriteNullBytes(4);
		AttenuationCurve.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(HFDampingDistance);
		p_Writer.Write(HFDampingObstruction);
		p_Writer.Write(HFDampingOcclusion);
		p_Writer.Write(HFObstructionAmplitudeReduction);
		p_Writer.Write(Gain);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MixGroup));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(EnableHdr);
		p_Writer.WriteNullBytes(7);
	}
}

