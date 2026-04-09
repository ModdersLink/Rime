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
	[ContainerType(16, 192)]
	public partial class ConeOutputNodeData :
		OutputNodeData
	{
		[ObservableProperty]
		[property: ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private Vec3 _Direction = new();

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private AudioGraphNodePort _PositionY = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private AudioGraphNodePort _PositionX = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private AudioGraphNodePort _PositionZ = new();

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private AudioGraphNodePort _OuterAngle = new();

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private AudioGraphNodePort _InnerAngle = new();

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _OutsideGain;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _PanSize;

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private AudioGraphNodePort _CenterLevel = new();

		[ObservableProperty]
		[property: ContainerField(152), JsonProperty(Order = 152)]
		private AudioGraphNodePort _LfeLevel = new();

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _HFDampingAngle;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _ReverbGain;

		[ObservableProperty]
		[property: ContainerField(168), JsonProperty(Order = 168)]
		private CtrRef<SoundBusData> _ReverbSend = new();

		[ObservableProperty]
		[property: ContainerField(172), JsonProperty(Order = 172)]
		private SoundGraphPluginRef _PanPlugin = new();

		[ObservableProperty]
		[property: ContainerField(175), JsonProperty(Order = 175)]
		private SoundGraphPluginRef _ReverbSendPlugin = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Direction.Serialize(p_Writer, p_EbxWriter);
			PositionY.Serialize(p_Writer, p_EbxWriter);
			PositionX.Serialize(p_Writer, p_EbxWriter);
			PositionZ.Serialize(p_Writer, p_EbxWriter);
			OuterAngle.Serialize(p_Writer, p_EbxWriter);
			InnerAngle.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(OutsideGain);
			p_Writer.Write(PanSize);
			CenterLevel.Serialize(p_Writer, p_EbxWriter);
			LfeLevel.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(HFDampingAngle);
			p_Writer.Write(ReverbGain);
			p_Writer.Write(p_EbxWriter.WriteImport(ReverbSend));
			PanPlugin.Serialize(p_Writer, p_EbxWriter);
			ReverbSendPlugin.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(14);
		}
	}
}
