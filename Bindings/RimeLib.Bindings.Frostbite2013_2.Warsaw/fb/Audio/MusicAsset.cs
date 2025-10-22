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

[ContainerType(8, 104)]
public class MusicAsset
	: fb.Audio.MusicBaseAsset
{
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<MusicInterfaceAsset> Interface { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint NameHash { get; set; } = 0;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint BeatsPerMinute { get; set; } = 0;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint BeatsPerBar { get; set; } = 0;
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<MusicStreamableData> Playables { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public RefArray<MusicOverlayData> Overlays { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public RefArray<MusicSelector> Selectors { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<MusicSelector> DefaultSelector { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public RefArray<MusicTransition> FallbackTransitions { get; set; } = new();
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public byte ChannelCount { get; set; } = 0;
	
	[ContainerField(0x61), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
	public byte OverlayChannelCount { get; set; } = 0;
	
	[ContainerField(0x62), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
	public byte VoicePriority { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Interface));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(NameHash);
		p_Writer.Write(BeatsPerMinute);
		p_Writer.Write(BeatsPerBar);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Playables = p_EbxWriter.GetArrayWriter(Playables.GetType(), Playables.Count);
		p_Writer.Write(s_Playables.ArrayIndex);
		foreach (var s_Entry in Playables)
		{
			s_Playables.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Overlays = p_EbxWriter.GetArrayWriter(Overlays.GetType(), Overlays.Count);
		p_Writer.Write(s_Overlays.ArrayIndex);
		foreach (var s_Entry in Overlays)
		{
			s_Overlays.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Selectors = p_EbxWriter.GetArrayWriter(Selectors.GetType(), Selectors.Count);
		p_Writer.Write(s_Selectors.ArrayIndex);
		foreach (var s_Entry in Selectors)
		{
			s_Selectors.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultSelector));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_FallbackTransitions = p_EbxWriter.GetArrayWriter(FallbackTransitions.GetType(), FallbackTransitions.Count);
		p_Writer.Write(s_FallbackTransitions.ArrayIndex);
		foreach (var s_Entry in FallbackTransitions)
		{
			s_FallbackTransitions.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ChannelCount);
		p_Writer.Write(OverlayChannelCount);
		p_Writer.Write(VoicePriority);
		p_Writer.WriteNullBytes(5);
	}
}

