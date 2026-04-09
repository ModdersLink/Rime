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
	[ContainerType(4, 72)]
	public partial class DialogSamplerNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _Pitch = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _Amplitude = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AudioGraphNodePort _Continue = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AudioGraphNodePort _Output = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AudioGraphNodePort _Triggered = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AudioGraphNodePort _Finished = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private SoundGraphPluginRef _SndPlayerPlugin = new();

		[ObservableProperty]
		[property: ContainerField(59), JsonProperty(Order = 59)]
		private SoundGraphPluginRef _ResamplePlugin = new();

		[ObservableProperty]
		[property: ContainerField(62), JsonProperty(Order = 62)]
		private SoundGraphPluginRef _PausePlugin = new();

		[ObservableProperty]
		[property: ContainerField(65), JsonProperty(Order = 65)]
		private SoundGraphPluginRef _GainPlugin = new();

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _TailLength;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Pitch.Serialize(p_Writer, p_EbxWriter);
			Amplitude.Serialize(p_Writer, p_EbxWriter);
			Continue.Serialize(p_Writer, p_EbxWriter);
			Output.Serialize(p_Writer, p_EbxWriter);
			Triggered.Serialize(p_Writer, p_EbxWriter);
			Finished.Serialize(p_Writer, p_EbxWriter);
			SndPlayerPlugin.Serialize(p_Writer, p_EbxWriter);
			ResamplePlugin.Serialize(p_Writer, p_EbxWriter);
			PausePlugin.Serialize(p_Writer, p_EbxWriter);
			GainPlugin.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TailLength);
		}
	}
}
