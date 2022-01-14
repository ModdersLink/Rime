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
	[ContainerType(4, 64)]
	public class VoiceOverConversationNode :
		VoiceOverStructureNode
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<VoiceOverDialogGroup> Groups { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<VoiceOverValueConnection> Condition { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<VoiceOverIntervalNode> Interval { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public RefArray<VoiceOverStructureNode> FinishedRelationship { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public RefArray<VoiceOverStructureNode> BlockedRelationship { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public VoiceOverContainerConditionMode ConditionMode { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float Probability { get; set; }

		[ContainerField(40), JsonProperty(Order = 40)]
		public CtrRef<VoiceOverPronunciation> Pronunciation { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public VoiceOverConversationInterruptMode InterruptMode { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public int Priority { get; set; }

		[ContainerField(52), JsonProperty(Order = 52)]
		public VoiceOverConversationQueueMode QueueMode { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float Relevancy { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public sbyte TrackCount { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		public sbyte LastSequenceIndex { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Groups = p_EbxWriter.GetArrayWriter(Groups.GetType(), Groups.Count);
			p_Writer.Write(s_Groups.ArrayIndex);
			foreach (var s_Entry in Groups)
			{
				s_Groups.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Condition = p_EbxWriter.GetArrayWriter(Condition.GetType(), Condition.Count);
			p_Writer.Write(s_Condition.ArrayIndex);
			foreach (var s_Entry in Condition)
			{
				s_Condition.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Interval));
			(RimeWriter Writer, uint ArrayIndex) s_FinishedRelationship = p_EbxWriter.GetArrayWriter(FinishedRelationship.GetType(), FinishedRelationship.Count);
			p_Writer.Write(s_FinishedRelationship.ArrayIndex);
			foreach (var s_Entry in FinishedRelationship)
			{
				s_FinishedRelationship.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_BlockedRelationship = p_EbxWriter.GetArrayWriter(BlockedRelationship.GetType(), BlockedRelationship.Count);
			p_Writer.Write(s_BlockedRelationship.ArrayIndex);
			foreach (var s_Entry in BlockedRelationship)
			{
				s_BlockedRelationship.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) ConditionMode);
			p_Writer.Write(Probability);
			p_Writer.Write(p_EbxWriter.WriteImport(Pronunciation));
			p_Writer.Write((int) InterruptMode);
			p_Writer.Write(Priority);
			p_Writer.Write((int) QueueMode);
			p_Writer.Write(Relevancy);
			p_Writer.Write(TrackCount);
			p_Writer.Write(LastSequenceIndex);
			p_Writer.WriteNullBytes(2);
		}
	}
}
