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
	[ContainerType(4, 52)]
	public class WaveSwitcherNodeData :
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort Index { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public AudioGraphNodePort Advance { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public AudioGraphNodePort Wave { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public AudioGraphNodePort IndexChanged { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public RefArray<SoundWaveAsset> Waves { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float DefaultIndex { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public bool IsRandom { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		public bool RandomStartIndex { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Index.Serialize(p_Writer, p_EbxWriter);
			Advance.Serialize(p_Writer, p_EbxWriter);
			Wave.Serialize(p_Writer, p_EbxWriter);
			IndexChanged.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Waves = p_EbxWriter.GetArrayWriter(Waves.GetType(), Waves.Count);
			p_Writer.Write(s_Waves.ArrayIndex);
			foreach (var s_Entry in Waves)
			{
				s_Waves.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(DefaultIndex);
			p_Writer.Write(IsRandom);
			p_Writer.Write(RandomStartIndex);
			p_Writer.WriteNullBytes(2);
		}
	}
}
