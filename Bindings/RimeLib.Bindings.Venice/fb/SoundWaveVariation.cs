///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class SoundWaveVariation : 
		DataContainer
	{
		[ContainerField(8)]
		public List<SoundWaveSubtitle> Subtitles { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint SeekTablesSize { get; set; }

		[ContainerField(16)]
		public List<SoundWaveVariationSegment> Segments { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public sbyte ChunkIndex { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public sbyte FirstLoopSegmentIndex { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public sbyte LastLoopSegmentIndex { get; set; }

		public static void Deserialize(SoundWaveVariation p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Subtitles.Clear();
			(RimeReader Reader, uint Count) s_Subtitles = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Subtitles.Count; ++i)
			{
				var s_Value = new SoundWaveSubtitle();
				fb.SoundWaveSubtitle.Deserialize(s_Value, s_Subtitles.Reader, p_Parser);
				p_Instance.Subtitles.Add(s_Value);
			}
			
			s_Subtitles.Reader.Dispose();
			p_Instance.SeekTablesSize = p_Reader.ReadUInt32();
			p_Instance.Segments.Clear();
			(RimeReader Reader, uint Count) s_Segments = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Segments.Count; ++i)
			{
				var s_Value = new SoundWaveVariationSegment();
				fb.SoundWaveVariationSegment.Deserialize(s_Value, s_Segments.Reader, p_Parser);
				p_Instance.Segments.Add(s_Value);
			}
			
			s_Segments.Reader.Dispose();
			p_Instance.ChunkIndex = p_Reader.ReadSByte();
			p_Instance.FirstLoopSegmentIndex = p_Reader.ReadSByte();
			p_Instance.LastLoopSegmentIndex = p_Reader.ReadSByte();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
