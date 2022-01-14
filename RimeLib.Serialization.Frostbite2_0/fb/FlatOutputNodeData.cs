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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 116)]
	public class FlatOutputNodeData :
		OutputNodeData
	{
		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float Angle { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float ReverbGain { get; set; }

		[ContainerField(88), JsonProperty(Order = 88)]
		public CtrRef<SoundBusData> ReverbSend { get; set; } = new();

		[ContainerField(92), JsonProperty(Order = 92)]
		public AudioGraphNodePort CenterLevel { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public AudioGraphNodePort LfeLevel { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public SoundGraphPluginRef PanPlugin { get; set; } = new();

		[ContainerField(111), JsonProperty(Order = 111)]
		public SoundGraphPluginRef ReverbSendPlugin { get; set; } = new();

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
