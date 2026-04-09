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
	[ContainerType(4, 80)]
	public partial class OutputNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _In = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _BypassHeadroom = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _MinDistance;

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AudioCurve _AttenuationCurve = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _Gain;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _HFDampingDistance;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _HFDampingObstruction;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _HFDampingOcclusion;

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private SoundGraphPluginRef _MainSendPlugin = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private CtrRef<SoundBusData> _MainSend = new();

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, JsonProperty(Order = 60)]
		private string _OutputName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private OutputTransformSource _TransformSource = new();

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private uint _OutputNameHash;

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private SoundGraphPluginRef _LowPassPlugin = new();

		[ObservableProperty]
		[property: ContainerField(75), JsonProperty(Order = 75)]
		private SoundGraphPluginRef _VuPlugin = new();

		[ObservableProperty]
		[property: ContainerField(78), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
		private bool _Solo;

		[ObservableProperty]
		[property: ContainerField(79), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
		private bool _EnableHdr;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			In.Serialize(p_Writer, p_EbxWriter);
			BypassHeadroom.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MinDistance);
			AttenuationCurve.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Gain);
			p_Writer.Write(HFDampingDistance);
			p_Writer.Write(HFDampingObstruction);
			p_Writer.Write(HFDampingOcclusion);
			MainSendPlugin.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(1);
			p_Writer.Write(p_EbxWriter.WriteImport(MainSend));
			p_Writer.Write(p_EbxWriter.WriteString(OutputName));
			p_Writer.Write((int) TransformSource);
			p_Writer.Write(OutputNameHash);
			LowPassPlugin.Serialize(p_Writer, p_EbxWriter);
			VuPlugin.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Solo);
			p_Writer.Write(EnableHdr);
		}
	}
}
