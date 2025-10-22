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

using fb.Core;

namespace fb.Audio;

[ContainerType(8, 40)]
public class SoundWaveVariation
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<SoundWaveSubtitle> Subtitles { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<SoundWaveVariationSegment> Segments { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint PersistentDataSize { get; set; } = 0;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public byte ChunkIndex { get; set; } = 0;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public byte FirstLoopSegmentIndex { get; set; } = 0;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public byte LastLoopSegmentIndex { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Subtitles = p_EbxWriter.GetArrayWriter(Subtitles.GetType(), Subtitles.Count);
		p_Writer.Write(s_Subtitles.ArrayIndex);
		foreach (var s_Entry in Subtitles)
		{
			s_Entry.Serialize(s_Subtitles.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Segments = p_EbxWriter.GetArrayWriter(Segments.GetType(), Segments.Count);
		p_Writer.Write(s_Segments.ArrayIndex);
		foreach (var s_Entry in Segments)
		{
			s_Entry.Serialize(s_Segments.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(PersistentDataSize);
		p_Writer.Write(ChunkIndex);
		p_Writer.Write(FirstLoopSegmentIndex);
		p_Writer.Write(LastLoopSegmentIndex);
		p_Writer.WriteNullBytes(1);
	}
}

