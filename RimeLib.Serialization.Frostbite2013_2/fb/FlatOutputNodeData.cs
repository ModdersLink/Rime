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

[ContainerType(8, 200)]
public class FlatOutputNodeData
	: fb.Audio.OutputNodeData
{
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float WorldAngle { get; set; } = 0.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float Angle { get; set; } = 0.000f;
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public AudioCurve ReverbAttenuationCurve { get; set; } = new();
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float ReverbGain { get; set; } = -12.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public OutputReverbMode ReverbMode { get; set; } = OutputReverbMode.OutputReverbMode_PostGain;
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<SoundBusData> ReverbSend { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public AudioGraphNodePort CenterLevel { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public AudioGraphNodePort LfeLevel { get; set; } = new();
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public bool IsWorldAligned { get; set; } = false;
	
	[ContainerField(0xc1), JsonProperty(Order = 193)]
	public SoundGraphPluginRef PanPlugin { get; set; } = new();
	
	[ContainerField(0xc4), JsonProperty(Order = 196)]
	public SoundGraphPluginRef ReverbSendPlugin { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WorldAngle);
		p_Writer.Write(Angle);
		ReverbAttenuationCurve.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ReverbGain);
		p_Writer.Write((int) ReverbMode);
		p_Writer.Write(p_EbxWriter.WriteImport(ReverbSend));
		p_Writer.WriteNullBytes(4);
		CenterLevel.Serialize(p_Writer, p_EbxWriter);
		LfeLevel.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(IsWorldAligned);
		PanPlugin.Serialize(p_Writer, p_EbxWriter);
		ReverbSendPlugin.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(1);
	}
}

