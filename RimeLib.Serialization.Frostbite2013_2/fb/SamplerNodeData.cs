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

[ContainerType(8, 184)]
public class SamplerNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort ExternalWave { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Variation { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort Offset { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort Delay { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort Pitch { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AudioGraphNodePort Amplitude { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public AudioGraphNodePort EnableStep { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public AudioGraphNodePort ShuffleSegments { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AudioGraphNodePort Buffer { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public AudioGraphNodePort Trigger { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public AudioGraphNodePort Release { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public AudioGraphNodePort Step { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public AudioGraphNodePort Output { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public AudioGraphNodePort Finished { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public AudioGraphNodePort Buffered { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public AudioGraphNodePort Position { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<SoundWaveAsset> Wave { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public LoopType Loop { get; set; } = LoopType.LtNone;
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public List<SamplerPlugins> Plugins { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<OutputNodeData> PitchSource { get; set; } = new();
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public SamplerNodeVersion Version { get; set; } = SamplerNodeVersion.SamplerNodeVersion_2010_2;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		ExternalWave.Serialize(p_Writer, p_EbxWriter);
		Variation.Serialize(p_Writer, p_EbxWriter);
		Offset.Serialize(p_Writer, p_EbxWriter);
		Delay.Serialize(p_Writer, p_EbxWriter);
		Pitch.Serialize(p_Writer, p_EbxWriter);
		Amplitude.Serialize(p_Writer, p_EbxWriter);
		EnableStep.Serialize(p_Writer, p_EbxWriter);
		ShuffleSegments.Serialize(p_Writer, p_EbxWriter);
		Buffer.Serialize(p_Writer, p_EbxWriter);
		Trigger.Serialize(p_Writer, p_EbxWriter);
		Release.Serialize(p_Writer, p_EbxWriter);
		Step.Serialize(p_Writer, p_EbxWriter);
		Output.Serialize(p_Writer, p_EbxWriter);
		Finished.Serialize(p_Writer, p_EbxWriter);
		Buffered.Serialize(p_Writer, p_EbxWriter);
		Position.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Wave));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Loop);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Plugins = p_EbxWriter.GetArrayWriter(Plugins.GetType(), Plugins.Count);
		p_Writer.Write(s_Plugins.ArrayIndex);
		foreach (var s_Entry in Plugins)
		{
			s_Entry.Serialize(s_Plugins.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PitchSource));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Version);
		p_Writer.WriteNullBytes(4);
	}
}

