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
	[ContainerType(4, 44)]
	public partial class DacNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _In = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _SpeakerCount = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AudioGraphNodePort _SampleRate = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private SoundGraphPluginRef _VuPlugin = new();

		[ObservableProperty]
		[property: ContainerField(35), JsonProperty(Order = 35)]
		private SoundGraphPluginRef _GainPlugin = new();

		[ObservableProperty]
		[property: ContainerField(38), JsonProperty(Order = 38)]
		private SoundGraphPluginRef _DacPlugin = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			In.Serialize(p_Writer, p_EbxWriter);
			SpeakerCount.Serialize(p_Writer, p_EbxWriter);
			SampleRate.Serialize(p_Writer, p_EbxWriter);
			VuPlugin.Serialize(p_Writer, p_EbxWriter);
			GainPlugin.Serialize(p_Writer, p_EbxWriter);
			DacPlugin.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(3);
		}
	}
}
