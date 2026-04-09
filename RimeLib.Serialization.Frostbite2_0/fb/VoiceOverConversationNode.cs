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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 64)]
	public partial class VoiceOverConversationNode :
		VoiceOverStructureNode
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<VoiceOverDialogGroup> _Groups = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<VoiceOverValueConnection> _Condition = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<VoiceOverIntervalNode> _Interval = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private RefArray<VoiceOverStructureNode> _FinishedRelationship = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private RefArray<VoiceOverStructureNode> _BlockedRelationship = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private VoiceOverContainerConditionMode _ConditionMode = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _Probability;

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private CtrRef<VoiceOverPronunciation> _Pronunciation = new();

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private VoiceOverConversationInterruptMode _InterruptMode = new();

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private int _Priority;

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private VoiceOverConversationQueueMode _QueueMode = new();

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _Relevancy;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private sbyte _TrackCount;

		[ObservableProperty]
		[property: ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		private sbyte _LastSequenceIndex;

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
