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

[ContainerType(8, 80)]
public class EventSequencerNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort Start { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Stop { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort Interval { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort IntervalVariation { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort Repeat { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AudioGraphNodePort RepeatVariation { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public RefArray<EventSequencerOutEvent> OutEvents { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public EventSequencerPlayback Playback { get; set; } = EventSequencerPlayback.EventSequencerPlayback_Sequential;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool IgnoreFirstInterval { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Start.Serialize(p_Writer, p_EbxWriter);
		Stop.Serialize(p_Writer, p_EbxWriter);
		Interval.Serialize(p_Writer, p_EbxWriter);
		IntervalVariation.Serialize(p_Writer, p_EbxWriter);
		Repeat.Serialize(p_Writer, p_EbxWriter);
		RepeatVariation.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_OutEvents = p_EbxWriter.GetArrayWriter(OutEvents.GetType(), OutEvents.Count);
		p_Writer.Write(s_OutEvents.ArrayIndex);
		foreach (var s_Entry in OutEvents)
		{
			s_OutEvents.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Playback);
		p_Writer.Write(IgnoreFirstInterval);
		p_Writer.WriteNullBytes(3);
	}
}

