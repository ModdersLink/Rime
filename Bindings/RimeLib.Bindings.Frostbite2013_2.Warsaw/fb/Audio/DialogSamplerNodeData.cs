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

[ContainerType(8, 96)]
public class DialogSamplerNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort Pitch { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Amplitude { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort Continue { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort Output { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort Triggered { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AudioGraphNodePort Finished { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float TailLength { get; set; } = 0.000f;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<OutputNodeData> PitchSource { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public SoundGraphPluginRef SndPlayerPlugin { get; set; } = new();
	
	[ContainerField(0x53), JsonProperty(Order = 83)]
	public SoundGraphPluginRef ResamplePlugin { get; set; } = new();
	
	[ContainerField(0x56), JsonProperty(Order = 86)]
	public SoundGraphPluginRef PausePlugin { get; set; } = new();
	
	[ContainerField(0x59), JsonProperty(Order = 89)]
	public SoundGraphPluginRef GainPlugin { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Pitch.Serialize(p_Writer, p_EbxWriter);
		Amplitude.Serialize(p_Writer, p_EbxWriter);
		Continue.Serialize(p_Writer, p_EbxWriter);
		Output.Serialize(p_Writer, p_EbxWriter);
		Triggered.Serialize(p_Writer, p_EbxWriter);
		Finished.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TailLength);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PitchSource));
		p_Writer.WriteNullBytes(4);
		SndPlayerPlugin.Serialize(p_Writer, p_EbxWriter);
		ResamplePlugin.Serialize(p_Writer, p_EbxWriter);
		PausePlugin.Serialize(p_Writer, p_EbxWriter);
		GainPlugin.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
	}
}

