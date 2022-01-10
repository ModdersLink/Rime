///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 64)]
	public class VoiceOverConversationNode : 
		VoiceOverStructureNode
	{
		[ContainerField(12)]
		public List<CtrRef<VoiceOverDialogGroup>> Groups { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<VoiceOverValueConnection>> Condition { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<VoiceOverIntervalNode> Interval { get; set; } = new();

		[ContainerField(24)]
		public List<CtrRef<VoiceOverStructureNode>> FinishedRelationship { get; set; } = new();

		[ContainerField(28)]
		public List<CtrRef<VoiceOverStructureNode>> BlockedRelationship { get; set; } = new();

		[ContainerField(32)]
		public VoiceOverContainerConditionMode ConditionMode { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Probability { get; set; }

		[ContainerField(40)]
		public CtrRef<VoiceOverPronunciation> Pronunciation { get; set; } = new();

		[ContainerField(44)]
		public VoiceOverConversationInterruptMode InterruptMode { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public int Priority { get; set; }

		[ContainerField(52)]
		public VoiceOverConversationQueueMode QueueMode { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable]
		public float Relevancy { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public sbyte TrackCount { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable]
		public sbyte LastSequenceIndex { get; set; }

		public static void Deserialize(VoiceOverConversationNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Groups.Clear();
			(RimeReader Reader, uint Count) s_Groups = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Groups.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverDialogGroup>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Groups.Reader.ReadUInt32()));
				p_Instance.Groups.Add(s_CtrRef);
			}
			
			s_Groups.Reader.Dispose();
			p_Instance.Condition.Clear();
			(RimeReader Reader, uint Count) s_Condition = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Condition.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverValueConnection>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Condition.Reader.ReadUInt32()));
				p_Instance.Condition.Add(s_CtrRef);
			}
			
			s_Condition.Reader.Dispose();
			p_Instance.Interval.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.FinishedRelationship.Clear();
			(RimeReader Reader, uint Count) s_FinishedRelationship = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_FinishedRelationship.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverStructureNode>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_FinishedRelationship.Reader.ReadUInt32()));
				p_Instance.FinishedRelationship.Add(s_CtrRef);
			}
			
			s_FinishedRelationship.Reader.Dispose();
			p_Instance.BlockedRelationship.Clear();
			(RimeReader Reader, uint Count) s_BlockedRelationship = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BlockedRelationship.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverStructureNode>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_BlockedRelationship.Reader.ReadUInt32()));
				p_Instance.BlockedRelationship.Add(s_CtrRef);
			}
			
			s_BlockedRelationship.Reader.Dispose();
			p_Instance.ConditionMode = (VoiceOverContainerConditionMode) p_Reader.ReadInt32();
			p_Instance.Probability = p_Reader.ReadSingle();
			p_Instance.Pronunciation.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.InterruptMode = (VoiceOverConversationInterruptMode) p_Reader.ReadInt32();
			p_Instance.Priority = p_Reader.ReadInt32();
			p_Instance.QueueMode = (VoiceOverConversationQueueMode) p_Reader.ReadInt32();
			p_Instance.Relevancy = p_Reader.ReadSingle();
			p_Instance.TrackCount = p_Reader.ReadSByte();
			p_Instance.LastSequenceIndex = p_Reader.ReadSByte();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
