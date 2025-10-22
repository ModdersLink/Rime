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

[ContainerType(8, 136)]
public class OutputNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort In { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort BypassHeadroom { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float MinDistance { get; set; } = 1.000f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioCurve AttenuationCurve { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float HFDampingDistance { get; set; } = 1.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float HFDampingObstruction { get; set; } = 1.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float HFDampingOcclusion { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float HFObstructionAmplitudeReduction { get; set; } = 0.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float Gain { get; set; } = 0.000f;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<SoundBusData> MainSend { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public OutputTransformSource TransformSource { get; set; } = OutputTransformSource.OutputTransformSource_Sound;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string OutputName { get; set; } = string.Empty;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public uint OutputNameHash { get; set; } = 0;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<MixGroup> MixGroup { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public bool Solo { get; set; } = false;
	
	[ContainerField(0x79), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
	public bool EnableHdr { get; set; } = true;
	
	[ContainerField(0x7a), JsonProperty(Order = 122)]
	public SoundGraphPluginRef LowPassPlugin { get; set; } = new();
	
	[ContainerField(0x7d), JsonProperty(Order = 125)]
	public SoundGraphPluginRef VuPlugin { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public SoundGraphPluginRef MainSendPlugin { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		In.Serialize(p_Writer, p_EbxWriter);
		BypassHeadroom.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MinDistance);
		p_Writer.WriteNullBytes(4);
		AttenuationCurve.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(HFDampingDistance);
		p_Writer.Write(HFDampingObstruction);
		p_Writer.Write(HFDampingOcclusion);
		p_Writer.Write(HFObstructionAmplitudeReduction);
		p_Writer.Write(Gain);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MainSend));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) TransformSource);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(OutputName));
		p_Writer.Write(OutputNameHash);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MixGroup));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Solo);
		p_Writer.Write(EnableHdr);
		LowPassPlugin.Serialize(p_Writer, p_EbxWriter);
		VuPlugin.Serialize(p_Writer, p_EbxWriter);
		MainSendPlugin.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(5);
	}
}

