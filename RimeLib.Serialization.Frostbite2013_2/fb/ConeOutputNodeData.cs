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

[ContainerType(16, 272)]
public class ConeOutputNodeData
	: fb.Audio.OutputNodeData
{
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public AudioGraphNodePort PositionX { get; set; } = new();
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 Direction { get; set; } = new()
	{
		z = 0.000f,
		y = 1.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public AudioGraphNodePort PositionY { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public AudioGraphNodePort PositionZ { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public AudioGraphNodePort InnerAngle { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public AudioGraphNodePort OuterAngle { get; set; } = new();
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float OutsideGain { get; set; } = -12.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float PanSize { get; set; } = 2.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float BleedMinDistance { get; set; } = 2.500f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float BleedMaxDistance { get; set; } = 3.500f;
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public AudioGraphNodePort CenterLevel { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public AudioGraphNodePort LfeLevel { get; set; } = new();
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float HFDampingAngle { get; set; } = 1.000f;
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public AudioCurve ReverbAttenuationCurve { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float ReverbGain { get; set; } = -12.000f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public OutputReverbMode ReverbMode { get; set; } = OutputReverbMode.OutputReverbMode_PostGain;
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public CtrRef<SoundBusData> ReverbSend { get; set; } = new();
	
	[ContainerField(0x108), JsonProperty(Order = 264)]
	public SoundGraphPluginRef PanPlugin { get; set; } = new();
	
	[ContainerField(0x10b), JsonProperty(Order = 267)]
	public SoundGraphPluginRef ReverbSendPlugin { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		PositionX.Serialize(p_Writer, p_EbxWriter);
		Direction.Serialize(p_Writer, p_EbxWriter);
		PositionY.Serialize(p_Writer, p_EbxWriter);
		PositionZ.Serialize(p_Writer, p_EbxWriter);
		InnerAngle.Serialize(p_Writer, p_EbxWriter);
		OuterAngle.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(OutsideGain);
		p_Writer.Write(PanSize);
		p_Writer.Write(BleedMinDistance);
		p_Writer.Write(BleedMaxDistance);
		CenterLevel.Serialize(p_Writer, p_EbxWriter);
		LfeLevel.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(HFDampingAngle);
		p_Writer.WriteNullBytes(4);
		ReverbAttenuationCurve.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ReverbGain);
		p_Writer.Write((int) ReverbMode);
		p_Writer.Write(p_EbxWriter.WriteImport(ReverbSend));
		p_Writer.WriteNullBytes(4);
		PanPlugin.Serialize(p_Writer, p_EbxWriter);
		ReverbSendPlugin.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(2);
	}
}

