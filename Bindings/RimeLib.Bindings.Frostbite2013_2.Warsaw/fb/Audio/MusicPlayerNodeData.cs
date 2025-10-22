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

[ContainerType(8, 128)]
public class MusicPlayerNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort Pitch { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Amplitude { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort Buffer { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort Start { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort Stop { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AudioGraphNodePort Output { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public AudioGraphNodePort Overlay { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public AudioGraphNodePort IsBuffered { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AudioGraphNodePort IsFinished { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<MusicBaseAsset> Asset { get; set; } = new();
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public uint DefaultStartEventNameHash { get; set; } = 0;
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public RefArray<MusicPlayerEntry> Entries { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public List<MusicPlayerPlugins> Plugins { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<OutputNodeData> PitchSource { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Pitch.Serialize(p_Writer, p_EbxWriter);
		Amplitude.Serialize(p_Writer, p_EbxWriter);
		Buffer.Serialize(p_Writer, p_EbxWriter);
		Start.Serialize(p_Writer, p_EbxWriter);
		Stop.Serialize(p_Writer, p_EbxWriter);
		Output.Serialize(p_Writer, p_EbxWriter);
		Overlay.Serialize(p_Writer, p_EbxWriter);
		IsBuffered.Serialize(p_Writer, p_EbxWriter);
		IsFinished.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Asset));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DefaultStartEventNameHash);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Entries = p_EbxWriter.GetArrayWriter(Entries.GetType(), Entries.Count);
		p_Writer.Write(s_Entries.ArrayIndex);
		foreach (var s_Entry in Entries)
		{
			s_Entries.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Plugins = p_EbxWriter.GetArrayWriter(Plugins.GetType(), Plugins.Count);
		p_Writer.Write(s_Plugins.ArrayIndex);
		foreach (var s_Entry in Plugins)
		{
			s_Entry.Serialize(s_Plugins.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PitchSource));
		p_Writer.WriteNullBytes(4);
	}
}

