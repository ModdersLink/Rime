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
	[ContainerType(4, 116)]
	public partial class FlatOutputNodeData :
		OutputNodeData
	{
		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _Angle;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _ReverbGain;

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private CtrRef<SoundBusData> _ReverbSend = new();

		[ObservableProperty]
		[property: ContainerField(92), JsonProperty(Order = 92)]
		private AudioGraphNodePort _CenterLevel = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private AudioGraphNodePort _LfeLevel = new();

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private SoundGraphPluginRef _PanPlugin = new();

		[ObservableProperty]
		[property: ContainerField(111), JsonProperty(Order = 111)]
		private SoundGraphPluginRef _ReverbSendPlugin = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Angle);
			p_Writer.Write(ReverbGain);
			p_Writer.Write(p_EbxWriter.WriteImport(ReverbSend));
			CenterLevel.Serialize(p_Writer, p_EbxWriter);
			LfeLevel.Serialize(p_Writer, p_EbxWriter);
			PanPlugin.Serialize(p_Writer, p_EbxWriter);
			ReverbSendPlugin.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(2);
		}
	}
}
