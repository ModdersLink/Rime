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
using fb.Audio;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 96)]
public class VoiceOverConversationEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public VoiceOverConversationInfo Conversation { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public List<VoiceOverConversationEntityTrackInfo> TrackInfos { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float TriggerDelay { get; set; } = 0.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float FinishedDelay { get; set; } = 0.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public int PronunciationIndex { get; set; } = 0;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool RunOnce { get; set; } = false;
	
	[ContainerField(0x5d), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
	public bool NeedsTriggerResult { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Conversation.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_TrackInfos = p_EbxWriter.GetArrayWriter(TrackInfos.GetType(), TrackInfos.Count);
		p_Writer.Write(s_TrackInfos.ArrayIndex);
		foreach (var s_Entry in TrackInfos)
		{
			s_Entry.Serialize(s_TrackInfos.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TriggerDelay);
		p_Writer.Write(FinishedDelay);
		p_Writer.Write(PronunciationIndex);
		p_Writer.Write(RunOnce);
		p_Writer.Write(NeedsTriggerResult);
		p_Writer.WriteNullBytes(2);
	}
}

