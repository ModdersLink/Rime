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

[ContainerType(8, 112)]
public class SoundWaveAsset
	: fb.Audio.SoundDataAsset
{
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<SoundWaveRuntimeVariation> RuntimeVariations { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<SoundWaveLocalizationInfo> Localization { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<string> SubtitleStringIds { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public List<SoundWaveSubtitle> Subtitles { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public SoundWaveVariationSelection Selection { get; set; } = SoundWaveVariationSelection.SoundWaveVariationSelection_Random;
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<StreamPoolAsset> StreamPool { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public List<SoundWaveVariationSegment> Segments { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool Seekable { get; set; } = false;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public byte PersistentVariationCount { get; set; } = 0;
	
	[ContainerField(0x6a), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
	public bool PreferAvailableVariations { get; set; } = true;
	
	[ContainerField(0x6b), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
	public byte StreamingMode { get; set; } = 0;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public byte ChannelCount { get; set; } = 0;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public byte VoicePriority { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_RuntimeVariations = p_EbxWriter.GetArrayWriter(RuntimeVariations.GetType(), RuntimeVariations.Count);
		p_Writer.Write(s_RuntimeVariations.ArrayIndex);
		foreach (var s_Entry in RuntimeVariations)
		{
			s_Entry.Serialize(s_RuntimeVariations.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Localization = p_EbxWriter.GetArrayWriter(Localization.GetType(), Localization.Count);
		p_Writer.Write(s_Localization.ArrayIndex);
		foreach (var s_Entry in Localization)
		{
			s_Entry.Serialize(s_Localization.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_SubtitleStringIds = p_EbxWriter.GetArrayWriter(SubtitleStringIds.GetType(), SubtitleStringIds.Count);
		p_Writer.Write(s_SubtitleStringIds.ArrayIndex);
		foreach (var s_Entry in SubtitleStringIds)
		{
			s_SubtitleStringIds.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Subtitles = p_EbxWriter.GetArrayWriter(Subtitles.GetType(), Subtitles.Count);
		p_Writer.Write(s_Subtitles.ArrayIndex);
		foreach (var s_Entry in Subtitles)
		{
			s_Entry.Serialize(s_Subtitles.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Selection);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StreamPool));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Segments = p_EbxWriter.GetArrayWriter(Segments.GetType(), Segments.Count);
		p_Writer.Write(s_Segments.ArrayIndex);
		foreach (var s_Entry in Segments)
		{
			s_Entry.Serialize(s_Segments.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Seekable);
		p_Writer.Write(PersistentVariationCount);
		p_Writer.Write(PreferAvailableVariations);
		p_Writer.Write(StreamingMode);
		p_Writer.Write(ChannelCount);
		p_Writer.Write(VoicePriority);
		p_Writer.WriteNullBytes(2);
	}
}

