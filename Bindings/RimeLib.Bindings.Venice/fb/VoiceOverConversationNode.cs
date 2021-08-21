///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 64)]
	public class VoiceOverConversationNode : 
		VoiceOverStructureNode
	{
		protected RefArray<VoiceOverDialogGroup> m_Groups = new RefArray<VoiceOverDialogGroup>();
		[ContainerField(Name: "Groups", Offset: 12, NameHash: 2573340009, Flags: 65)]
		public RefArray<VoiceOverDialogGroup> Groups { get { return m_Groups; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(Groups), this, m_Groups, value)) m_Groups = value; } } // 0xC (12)
		
		protected RefArray<VoiceOverValueConnection> m_Condition = new RefArray<VoiceOverValueConnection>();
		[ContainerField(Name: "Condition", Offset: 16, NameHash: 1800624758, Flags: 65)]
		public RefArray<VoiceOverValueConnection> Condition { get { return m_Condition; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(Condition), this, m_Condition, value)) m_Condition = value; } } // 0x10 (16)
		
		protected CtrRef<VoiceOverIntervalNode> m_Interval = new CtrRef<VoiceOverIntervalNode>();
		[ContainerField(Name: "Interval", Offset: 20, NameHash: 4280103418, Flags: 53)]
		public CtrRef<VoiceOverIntervalNode> Interval { get { return m_Interval; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(Interval), this, m_Interval, value)) m_Interval = value; } } // 0x14 (20)
		
		protected RefArray<VoiceOverStructureNode> m_FinishedRelationship = new RefArray<VoiceOverStructureNode>();
		[ContainerField(Name: "FinishedRelationship", Offset: 24, NameHash: 1799875187, Flags: 65)]
		public RefArray<VoiceOverStructureNode> FinishedRelationship { get { return m_FinishedRelationship; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(FinishedRelationship), this, m_FinishedRelationship, value)) m_FinishedRelationship = value; } } // 0x18 (24)
		
		protected RefArray<VoiceOverStructureNode> m_BlockedRelationship = new RefArray<VoiceOverStructureNode>();
		[ContainerField(Name: "BlockedRelationship", Offset: 28, NameHash: 3157137449, Flags: 65)]
		public RefArray<VoiceOverStructureNode> BlockedRelationship { get { return m_BlockedRelationship; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(BlockedRelationship), this, m_BlockedRelationship, value)) m_BlockedRelationship = value; } } // 0x1C (28)
		
		protected VoiceOverContainerConditionMode m_ConditionMode = new VoiceOverContainerConditionMode();
		[ContainerField(Name: "ConditionMode", Offset: 32, NameHash: 1106041141, Flags: 137)]
		public VoiceOverContainerConditionMode ConditionMode { get { return m_ConditionMode; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(ConditionMode), this, m_ConditionMode, value)) m_ConditionMode = value; } } // 0x20 (32)
		
		protected float m_Probability = new float();
		[ContainerField(Name: "Probability", Offset: 36, NameHash: 35957416, Flags: 49469), LayoutImmutable, Blittable]
		public float Probability { get { return m_Probability; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(Probability), this, m_Probability, value)) m_Probability = value; } } // 0x24 (36)
		
		protected CtrRef<VoiceOverPronunciation> m_Pronunciation = new CtrRef<VoiceOverPronunciation>();
		[ContainerField(Name: "Pronunciation", Offset: 40, NameHash: 1030690794, Flags: 53)]
		public CtrRef<VoiceOverPronunciation> Pronunciation { get { return m_Pronunciation; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(Pronunciation), this, m_Pronunciation, value)) m_Pronunciation = value; } } // 0x28 (40)
		
		protected VoiceOverConversationInterruptMode m_InterruptMode = new VoiceOverConversationInterruptMode();
		[ContainerField(Name: "InterruptMode", Offset: 44, NameHash: 1567415617, Flags: 137)]
		public VoiceOverConversationInterruptMode InterruptMode { get { return m_InterruptMode; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(InterruptMode), this, m_InterruptMode, value)) m_InterruptMode = value; } } // 0x2C (44)
		
		protected int m_Priority = new int();
		[ContainerField(Name: "Priority", Offset: 48, NameHash: 3062102871, Flags: 49405), LayoutImmutable, Blittable]
		public int Priority { get { return m_Priority; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(Priority), this, m_Priority, value)) m_Priority = value; } } // 0x30 (48)
		
		protected VoiceOverConversationQueueMode m_QueueMode = new VoiceOverConversationQueueMode();
		[ContainerField(Name: "QueueMode", Offset: 52, NameHash: 451916407, Flags: 137)]
		public VoiceOverConversationQueueMode QueueMode { get { return m_QueueMode; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(QueueMode), this, m_QueueMode, value)) m_QueueMode = value; } } // 0x34 (52)
		
		protected float m_Relevancy = new float();
		[ContainerField(Name: "Relevancy", Offset: 56, NameHash: 2394072376, Flags: 49469), LayoutImmutable, Blittable]
		public float Relevancy { get { return m_Relevancy; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(Relevancy), this, m_Relevancy, value)) m_Relevancy = value; } } // 0x38 (56)
		
		protected sbyte m_TrackCount = new sbyte();
		[ContainerField(Name: "TrackCount", Offset: 60, NameHash: 2101390953, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte TrackCount { get { return m_TrackCount; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(TrackCount), this, m_TrackCount, value)) m_TrackCount = value; } } // 0x3C (60)
		
		protected sbyte m_LastSequenceIndex = new sbyte();
		[ContainerField(Name: "LastSequenceIndex", Offset: 61, NameHash: 1436490318, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte LastSequenceIndex { get { return m_LastSequenceIndex; } set { if (OnPropertyChanging("VoiceOverConversationNode." + nameof(LastSequenceIndex), this, m_LastSequenceIndex, value)) m_LastSequenceIndex = value; } } // 0x3D (61)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2573340009:
					Groups = (RefArray<VoiceOverDialogGroup>) p_Value;
					break;

				case 1800624758:
					Condition = (RefArray<VoiceOverValueConnection>) p_Value;
					break;

				case 4280103418:
					Interval = (CtrRef<VoiceOverIntervalNode>) p_Value;
					break;

				case 1799875187:
					FinishedRelationship = (RefArray<VoiceOverStructureNode>) p_Value;
					break;

				case 3157137449:
					BlockedRelationship = (RefArray<VoiceOverStructureNode>) p_Value;
					break;

				case 1106041141:
					ConditionMode = (VoiceOverContainerConditionMode) Enum.ToObject(typeof(VoiceOverContainerConditionMode), p_Value);
					break;

				case 35957416:
					Probability = (float) p_Value;
					break;

				case 1030690794:
					Pronunciation = (CtrRef<VoiceOverPronunciation>) p_Value;
					break;

				case 1567415617:
					InterruptMode = (VoiceOverConversationInterruptMode) Enum.ToObject(typeof(VoiceOverConversationInterruptMode), p_Value);
					break;

				case 3062102871:
					Priority = (int) p_Value;
					break;

				case 451916407:
					QueueMode = (VoiceOverConversationQueueMode) Enum.ToObject(typeof(VoiceOverConversationQueueMode), p_Value);
					break;

				case 2394072376:
					Relevancy = (float) p_Value;
					break;

				case 2101390953:
					TrackCount = (sbyte) p_Value;
					break;

				case 1436490318:
					LastSequenceIndex = (sbyte) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2573340009:
					return Groups;

				case 1800624758:
					return Condition;

				case 4280103418:
					return Interval;

				case 1799875187:
					return FinishedRelationship;

				case 3157137449:
					return BlockedRelationship;

				case 1106041141:
					return ConditionMode;

				case 35957416:
					return Probability;

				case 1030690794:
					return Pronunciation;

				case 1567415617:
					return InterruptMode;

				case 3062102871:
					return Priority;

				case 451916407:
					return QueueMode;

				case 2394072376:
					return Relevancy;

				case 2101390953:
					return TrackCount;

				case 1436490318:
					return LastSequenceIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2573340009:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(Groups));

				case 1800624758:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(Condition));

				case 4280103418:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(Interval));

				case 1799875187:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(FinishedRelationship));

				case 3157137449:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(BlockedRelationship));

				case 1106041141:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(ConditionMode));

				case 35957416:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(Probability));

				case 1030690794:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(Pronunciation));

				case 1567415617:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(InterruptMode));

				case 3062102871:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(Priority));

				case 451916407:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(QueueMode));

				case 2394072376:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(Relevancy));

				case 2101390953:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(TrackCount));

				case 1436490318:
					return typeof(VoiceOverConversationNode).GetProperty(nameof(LastSequenceIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
