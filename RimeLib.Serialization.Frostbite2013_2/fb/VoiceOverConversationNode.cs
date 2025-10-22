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
public class VoiceOverConversationNode
	: fb.Audio.VoiceOverStructureNode
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<VoiceOverValueConnection> Condition { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public VoiceOverValueConnection PronunciationIndex { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<VoiceOverIntervalNode> Interval { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<VoiceOverStructureNode> FinishedRelationship { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public RefArray<VoiceOverStructureNode> BlockedRelationship { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public VoiceOverContainerConditionMode ConditionMode { get; set; } = VoiceOverContainerConditionMode.VoiceOverContainerConditionMode_All;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float Probability { get; set; } = 100.000f;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public VoiceOverConversationInfo Conversation { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Condition = p_EbxWriter.GetArrayWriter(Condition.GetType(), Condition.Count);
		p_Writer.Write(s_Condition.ArrayIndex);
		foreach (var s_Entry in Condition)
		{
			s_Entry.Serialize(s_Condition.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		PronunciationIndex.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Interval));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_FinishedRelationship = p_EbxWriter.GetArrayWriter(FinishedRelationship.GetType(), FinishedRelationship.Count);
		p_Writer.Write(s_FinishedRelationship.ArrayIndex);
		foreach (var s_Entry in FinishedRelationship)
		{
			s_FinishedRelationship.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_BlockedRelationship = p_EbxWriter.GetArrayWriter(BlockedRelationship.GetType(), BlockedRelationship.Count);
		p_Writer.Write(s_BlockedRelationship.ArrayIndex);
		foreach (var s_Entry in BlockedRelationship)
		{
			s_BlockedRelationship.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) ConditionMode);
		p_Writer.Write(Probability);
		Conversation.Serialize(p_Writer, p_EbxWriter);
	}
}

