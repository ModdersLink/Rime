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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 172)]
	public partial class MasterUnitNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _SettingsIndex = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _Amplitude = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AudioGraphNodePort _MasterGain = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AudioGraphNodePort _MasterLfeGain = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AudioGraphNodePort _MasterDialogGain = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AudioGraphNodePort _MainMixGain = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private AudioGraphNodePort _PostEffectsGain = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private AudioGraphNodePort _ReverbGain = new();

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private AudioGraphNodePort _FadeTime = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private AudioGraphNodePort _HighPassFreq = new();

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private AudioGraphNodePort _LowShelfFreq = new();

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private AudioGraphNodePort _LowShelfGain = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private AudioGraphNodePort _HighShelfFreq = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private AudioGraphNodePort _HighShelfGain = new();

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private AudioGraphNodePort _CompThreshold = new();

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private AudioGraphNodePort _CompRatio = new();

		[ObservableProperty]
		[property: ContainerField(136), JsonProperty(Order = 136)]
		private AudioGraphNodePort _CompAttack = new();

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private AudioGraphNodePort _CompRelease = new();

		[ObservableProperty]
		[property: ContainerField(152), JsonProperty(Order = 152)]
		private AudioGraphNodePort _DistClipLevel = new();

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private AudioGraphNodePort _ParallelDistortionGain = new();

		[ObservableProperty]
		[property: ContainerField(168), JsonProperty(Order = 168)]
		private RefArray<MasterUnitSettings> _Settings = new();

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
