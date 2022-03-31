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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 172)]
	public class MasterUnitNodeData :
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort SettingsIndex { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public AudioGraphNodePort Amplitude { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public AudioGraphNodePort MasterGain { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public AudioGraphNodePort MasterLfeGain { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public AudioGraphNodePort MasterDialogGain { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public AudioGraphNodePort MainMixGain { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public AudioGraphNodePort PostEffectsGain { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public AudioGraphNodePort ReverbGain { get; set; } = new();

		[ContainerField(72), JsonProperty(Order = 72)]
		public AudioGraphNodePort FadeTime { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public AudioGraphNodePort HighPassFreq { get; set; } = new();

		[ContainerField(88), JsonProperty(Order = 88)]
		public AudioGraphNodePort LowShelfFreq { get; set; } = new();

		[ContainerField(96), JsonProperty(Order = 96)]
		public AudioGraphNodePort LowShelfGain { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public AudioGraphNodePort HighShelfFreq { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public AudioGraphNodePort HighShelfGain { get; set; } = new();

		[ContainerField(120), JsonProperty(Order = 120)]
		public AudioGraphNodePort CompThreshold { get; set; } = new();

		[ContainerField(128), JsonProperty(Order = 128)]
		public AudioGraphNodePort CompRatio { get; set; } = new();

		[ContainerField(136), JsonProperty(Order = 136)]
		public AudioGraphNodePort CompAttack { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public AudioGraphNodePort CompRelease { get; set; } = new();

		[ContainerField(152), JsonProperty(Order = 152)]
		public AudioGraphNodePort DistClipLevel { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public AudioGraphNodePort ParallelDistortionGain { get; set; } = new();

		[ContainerField(168), JsonProperty(Order = 168)]
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
		}
	}
}
