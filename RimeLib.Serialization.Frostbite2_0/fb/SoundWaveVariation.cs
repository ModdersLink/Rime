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
	[ContainerType(4, 24)]
	public class SoundWaveVariation :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<SoundWaveSubtitle> Subtitles { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint SeekTablesSize { get; set; }

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<SoundWaveVariationSegment> Segments { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public sbyte ChunkIndex { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		public sbyte FirstLoopSegmentIndex { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
		public sbyte LastLoopSegmentIndex { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Subtitles = p_EbxWriter.GetArrayWriter(Subtitles.GetType(), Subtitles.Count);
			p_Writer.Write(s_Subtitles.ArrayIndex);
			foreach (var s_Entry in Subtitles)
			{
				s_Entry.Serialize(s_Subtitles.Writer, p_EbxWriter);
			}
			p_Writer.Write(SeekTablesSize);
			(RimeWriter Writer, uint ArrayIndex) s_Segments = p_EbxWriter.GetArrayWriter(Segments.GetType(), Segments.Count);
			p_Writer.Write(s_Segments.ArrayIndex);
			foreach (var s_Entry in Segments)
			{
				s_Entry.Serialize(s_Segments.Writer, p_EbxWriter);
			}
			p_Writer.Write(ChunkIndex);
			p_Writer.Write(FirstLoopSegmentIndex);
			p_Writer.Write(LastLoopSegmentIndex);
			p_Writer.WriteNullBytes(1);
		}
	}
}
