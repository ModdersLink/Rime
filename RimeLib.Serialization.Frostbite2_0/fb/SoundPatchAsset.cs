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
	public partial class SoundPatchAsset :
		SoundGraphAsset
	{
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private RefArray<AudioGraphNodeData> _OutputNodes = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _Loudness;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _AILoudness;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _Radius;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _DopplerFactor;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _MasterPitch;

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private CtrRef<MixGroup> _MixGroup = new();

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private CtrRef<AudioGraphEvent> _DefaultStopEvent = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private CtrRef<AudioGraphEvent> _DefaultStartEvent = new();

		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private CtrRef<AudioGraphEvent> _DefaultForceInitEvent = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private CtrRef<AudioGraphEvent> _DefaultEnterScopeEvent = new();

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private bool _IsPersistent;

		[ObservableProperty]
		[property: ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		private bool _IsLooping;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_OutputNodes = p_EbxWriter.GetArrayWriter(OutputNodes.GetType(), OutputNodes.Count);
			p_Writer.Write(s_OutputNodes.ArrayIndex);
			foreach (var s_Entry in OutputNodes)
			{
				s_OutputNodes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(Loudness);
			p_Writer.Write(AILoudness);
			p_Writer.Write(Radius);
			p_Writer.Write(DopplerFactor);
			p_Writer.Write(MasterPitch);
			p_Writer.Write(p_EbxWriter.WriteImport(MixGroup));
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultStopEvent));
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultStartEvent));
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultForceInitEvent));
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultEnterScopeEvent));
			p_Writer.Write(IsPersistent);
			p_Writer.Write(IsLooping);
			p_Writer.WriteNullBytes(2);
		}
	}
}
