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
public class MasterUnitNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort SettingsIndex { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Amplitude { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort MasterGain { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort MasterLfeGain { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort MasterDialogGain { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AudioGraphNodePort MainMixGain { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public AudioGraphNodePort PostEffectsGain { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public AudioGraphNodePort ReverbGain { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AudioGraphNodePort FadeTime { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public AudioGraphNodePort HighPassFreq { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public AudioGraphNodePort LowShelfFreq { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public AudioGraphNodePort LowShelfGain { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public AudioGraphNodePort HighShelfFreq { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public AudioGraphNodePort HighShelfGain { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public AudioGraphNodePort CompThreshold { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public AudioGraphNodePort CompRatio { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public AudioGraphNodePort CompAttack { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public AudioGraphNodePort CompRelease { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public AudioGraphNodePort DistClipLevel { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public AudioGraphNodePort ParallelDistortionGain { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public RefArray<MasterUnitSettings> Settings { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		SettingsIndex.Serialize(p_Writer, p_EbxWriter);
		Amplitude.Serialize(p_Writer, p_EbxWriter);
		MasterGain.Serialize(p_Writer, p_EbxWriter);
		MasterLfeGain.Serialize(p_Writer, p_EbxWriter);
		MasterDialogGain.Serialize(p_Writer, p_EbxWriter);
		MainMixGain.Serialize(p_Writer, p_EbxWriter);
		PostEffectsGain.Serialize(p_Writer, p_EbxWriter);
		ReverbGain.Serialize(p_Writer, p_EbxWriter);
		FadeTime.Serialize(p_Writer, p_EbxWriter);
		HighPassFreq.Serialize(p_Writer, p_EbxWriter);
		LowShelfFreq.Serialize(p_Writer, p_EbxWriter);
		LowShelfGain.Serialize(p_Writer, p_EbxWriter);
		HighShelfFreq.Serialize(p_Writer, p_EbxWriter);
		HighShelfGain.Serialize(p_Writer, p_EbxWriter);
		CompThreshold.Serialize(p_Writer, p_EbxWriter);
		CompRatio.Serialize(p_Writer, p_EbxWriter);
		CompAttack.Serialize(p_Writer, p_EbxWriter);
		CompRelease.Serialize(p_Writer, p_EbxWriter);
		DistClipLevel.Serialize(p_Writer, p_EbxWriter);
		ParallelDistortionGain.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Settings = p_EbxWriter.GetArrayWriter(Settings.GetType(), Settings.Count);
		p_Writer.Write(s_Settings.ArrayIndex);
		foreach (var s_Entry in Settings)
		{
			s_Settings.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

