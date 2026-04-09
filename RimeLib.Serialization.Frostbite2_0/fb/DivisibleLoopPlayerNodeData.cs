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
	public partial class DivisibleLoopPlayerNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _Start = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _Stop = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AudioGraphNodePort _Amplitude = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AudioGraphNodePort _FreezeSegment = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AudioGraphNodePort _Output = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private CtrRef<SoundWaveAsset> _Wave = new();

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private AudioGraphNodePort _ExternalWave = new();

		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private List<DivisibleLoopPlayerPlugins> _Plugins = new();

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _CrossFadeLength;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private bool _StartAtRandomPosition;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Start.Serialize(p_Writer, p_EbxWriter);
			Stop.Serialize(p_Writer, p_EbxWriter);
			Amplitude.Serialize(p_Writer, p_EbxWriter);
			FreezeSegment.Serialize(p_Writer, p_EbxWriter);
			Output.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Wave));
			ExternalWave.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Plugins = p_EbxWriter.GetArrayWriter(Plugins.GetType(), Plugins.Count);
			p_Writer.Write(s_Plugins.ArrayIndex);
			foreach (var s_Entry in Plugins)
			{
				s_Entry.Serialize(s_Plugins.Writer, p_EbxWriter);
			}
			p_Writer.Write(CrossFadeLength);
			p_Writer.Write(StartAtRandomPosition);
			p_Writer.WriteNullBytes(3);
		}
	}
}
