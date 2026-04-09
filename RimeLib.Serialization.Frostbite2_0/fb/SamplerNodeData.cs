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
	[ContainerType(4, 148)]
	public partial class SamplerNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _ExternalWave = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _Variation = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AudioGraphNodePort _Offset = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AudioGraphNodePort _Delay = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AudioGraphNodePort _Pitch = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AudioGraphNodePort _Amplitude = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private AudioGraphNodePort _EnableStep = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private AudioGraphNodePort _Buffer = new();

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private AudioGraphNodePort _Trigger = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private AudioGraphNodePort _Release = new();

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private AudioGraphNodePort _Step = new();

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private AudioGraphNodePort _Output = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private AudioGraphNodePort _Finished = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private AudioGraphNodePort _Buffered = new();

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private AudioGraphNodePort _Position = new();

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private CtrRef<SoundWaveAsset> _Wave = new();

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _BasePitch;

		[ObservableProperty]
		[property: ContainerField(136), JsonProperty(Order = 136)]
		private LoopType _Loop = new();

		[ObservableProperty]
		[property: ContainerField(140), JsonProperty(Order = 140)]
		private List<SamplerPlugins> _Plugins = new();

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private bool _ShuffleSegments;

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
			Buffer.Serialize(p_Writer, p_EbxWriter);
			Trigger.Serialize(p_Writer, p_EbxWriter);
			Release.Serialize(p_Writer, p_EbxWriter);
			Step.Serialize(p_Writer, p_EbxWriter);
			Output.Serialize(p_Writer, p_EbxWriter);
			Finished.Serialize(p_Writer, p_EbxWriter);
			Buffered.Serialize(p_Writer, p_EbxWriter);
			Position.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Wave));
			p_Writer.Write(BasePitch);
			p_Writer.Write((int) Loop);
			(RimeWriter Writer, uint ArrayIndex) s_Plugins = p_EbxWriter.GetArrayWriter(Plugins.GetType(), Plugins.Count);
			p_Writer.Write(s_Plugins.ArrayIndex);
			foreach (var s_Entry in Plugins)
			{
				s_Entry.Serialize(s_Plugins.Writer, p_EbxWriter);
			}
			p_Writer.Write(ShuffleSegments);
			p_Writer.WriteNullBytes(3);
		}
	}
}
