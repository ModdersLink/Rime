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
public class VoiceOverDialogTrack
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public VoiceOverValueConnection Source { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public VoiceOverValueConnection TakeControl { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<VoiceOverDialogTakeMapping> TakeIndexMapping { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public VoiceOverDialogTakeBehavior TakeSwitching { get; set; } = VoiceOverDialogTakeBehavior.VoiceOverDialogTakeBehavior_Start;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<AudioGraphNodeData> Output { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<AudioGraphNodeData> SamplerNode { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<VoiceOverConversationQueueGroup> QueueGroup { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public RefArray<VoiceOverDialogClip> Clips { get; set; } = new();
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool TakeSwitchingOnResume { get; set; } = false;
	
	[ContainerField(0x61), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
	public byte ParentTrackIndex { get; set; } = 0;
	
	[ContainerField(0x62), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
	public byte GroupIndex { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Source.Serialize(p_Writer, p_EbxWriter);
		TakeControl.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_TakeIndexMapping = p_EbxWriter.GetArrayWriter(TakeIndexMapping.GetType(), TakeIndexMapping.Count);
		p_Writer.Write(s_TakeIndexMapping.ArrayIndex);
		foreach (var s_Entry in TakeIndexMapping)
		{
			s_Entry.Serialize(s_TakeIndexMapping.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) TakeSwitching);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Output));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SamplerNode));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(QueueGroup));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Clips = p_EbxWriter.GetArrayWriter(Clips.GetType(), Clips.Count);
		p_Writer.Write(s_Clips.ArrayIndex);
		foreach (var s_Entry in Clips)
		{
			s_Clips.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TakeSwitchingOnResume);
		p_Writer.Write(ParentTrackIndex);
		p_Writer.Write(GroupIndex);
		p_Writer.WriteNullBytes(5);
	}
}

