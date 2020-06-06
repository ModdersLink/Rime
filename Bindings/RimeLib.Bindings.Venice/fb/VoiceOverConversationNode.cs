///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VoiceOverConversationNode : 
		VoiceOverStructureNode
	{
		[ContainerField(12)]
		public RefArray<VoiceOverDialogGroup> Groups { get; set; } = new RefArray<VoiceOverDialogGroup>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<VoiceOverValueConnection> Condition { get; set; } = new RefArray<VoiceOverValueConnection>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<VoiceOverIntervalNode> Interval { get; set; } = new CtrRef<VoiceOverIntervalNode>(); // 0x14 (20)
		
		[ContainerField(24)]
		public RefArray<VoiceOverStructureNode> FinishedRelationship { get; set; } = new RefArray<VoiceOverStructureNode>(); // 0x18 (24)
		
		[ContainerField(28)]
		public RefArray<VoiceOverStructureNode> BlockedRelationship { get; set; } = new RefArray<VoiceOverStructureNode>(); // 0x1C (28)
		
		[ContainerField(32)]
		public VoiceOverContainerConditionMode ConditionMode { get; set; } = new VoiceOverContainerConditionMode(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float Probability { get; set; } // 0x24 (36)
		
		[ContainerField(40)]
		public CtrRef<VoiceOverPronunciation> Pronunciation { get; set; } = new CtrRef<VoiceOverPronunciation>(); // 0x28 (40)
		
		[ContainerField(44)]
		public VoiceOverConversationInterruptMode InterruptMode { get; set; } = new VoiceOverConversationInterruptMode(); // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public int Priority { get; set; } // 0x30 (48)
		
		[ContainerField(52)]
		public VoiceOverConversationQueueMode QueueMode { get; set; } = new VoiceOverConversationQueueMode(); // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float Relevancy { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public sbyte TrackCount { get; set; } // 0x3C (60)
		
		[ContainerField(61), LayoutImmutable, Blittable]
		public sbyte LastSequenceIndex { get; set; } // 0x3D (61)
		
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
