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

namespace fb
{
	[ContainerType(4, 72)]
	public class DialogSamplerNodeData :
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort Pitch { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public AudioGraphNodePort Amplitude { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public AudioGraphNodePort Continue { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public AudioGraphNodePort Output { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public AudioGraphNodePort Triggered { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public AudioGraphNodePort Finished { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public SoundGraphPluginRef SndPlayerPlugin { get; set; } = new();

		[ContainerField(59), JsonProperty(Order = 59)]
		public SoundGraphPluginRef ResamplePlugin { get; set; } = new();

		[ContainerField(62), JsonProperty(Order = 62)]
		public SoundGraphPluginRef PausePlugin { get; set; } = new();

		[ContainerField(65), JsonProperty(Order = 65)]
		public SoundGraphPluginRef GainPlugin { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float TailLength { get; set; }

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
