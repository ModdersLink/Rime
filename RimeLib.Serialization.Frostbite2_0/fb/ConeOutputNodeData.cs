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
	[ContainerType(16, 192)]
	public class ConeOutputNodeData :
		OutputNodeData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public Vec3 Direction { get; set; } = new();

		[ContainerField(96), JsonProperty(Order = 96)]
		public AudioGraphNodePort PositionY { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public AudioGraphNodePort PositionX { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public AudioGraphNodePort PositionZ { get; set; } = new();

		[ContainerField(120), JsonProperty(Order = 120)]
		public AudioGraphNodePort OuterAngle { get; set; } = new();

		[ContainerField(128), JsonProperty(Order = 128)]
		public AudioGraphNodePort InnerAngle { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float OutsideGain { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float PanSize { get; set; }

		[ContainerField(144), JsonProperty(Order = 144)]
		public AudioGraphNodePort CenterLevel { get; set; } = new();

		[ContainerField(152), JsonProperty(Order = 152)]
		public AudioGraphNodePort LfeLevel { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float HFDampingAngle { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float ReverbGain { get; set; }

		[ContainerField(168), JsonProperty(Order = 168)]
		public CtrRef<SoundBusData> ReverbSend { get; set; } = new();

		[ContainerField(172), JsonProperty(Order = 172)]
		public SoundGraphPluginRef PanPlugin { get; set; } = new();

		[ContainerField(175), JsonProperty(Order = 175)]
		public SoundGraphPluginRef ReverbSendPlugin { get; set; } = new();

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
