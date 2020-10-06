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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(44), ContainerClass]
	public class VoiceOverDialogTrack : 
		DataContainer
	{
		protected CtrRef<VoiceOverValueConnection> m_Source = new CtrRef<VoiceOverValueConnection>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(3339738264), ContainerCtrRef]
		public CtrRef<VoiceOverValueConnection> Source { get { return m_Source; } set { if (OnPropertyChanging("VoiceOverDialogTrack." + nameof(Source), this, m_Source, value)) m_Source = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverValueConnection> m_TakeControl = new CtrRef<VoiceOverValueConnection>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(777187609), ContainerCtrRef]
		public CtrRef<VoiceOverValueConnection> TakeControl { get { return m_TakeControl; } set { if (OnPropertyChanging("VoiceOverDialogTrack." + nameof(TakeControl), this, m_TakeControl, value)) m_TakeControl = value; } } // 0xC (12)
		
		protected List<VoiceOverDialogTakeMapping> m_TakeIndexMapping = new List<VoiceOverDialogTakeMapping>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(1460629004), ContainerArray]
		public List<VoiceOverDialogTakeMapping> TakeIndexMapping { get { return m_TakeIndexMapping; } set { if (OnPropertyChanging("VoiceOverDialogTrack." + nameof(TakeIndexMapping), this, m_TakeIndexMapping, value)) m_TakeIndexMapping = value; } } // 0x10 (16)
		
		protected VoiceOverDialogTakeBehavior m_TakeSwitching = new VoiceOverDialogTakeBehavior();
		[ContainerField(20), MemberInfoFlag(137), ContainerFieldNameHash(1993728428)]
		public VoiceOverDialogTakeBehavior TakeSwitching { get { return m_TakeSwitching; } set { if (OnPropertyChanging("VoiceOverDialogTrack." + nameof(TakeSwitching), this, m_TakeSwitching, value)) m_TakeSwitching = value; } } // 0x14 (20)
		
		protected RefArray<VoiceOverDialogClip> m_Clips = new RefArray<VoiceOverDialogClip>();
		[ContainerField(24), MemberInfoFlag(65), ContainerFieldNameHash(212627296), ContainerRefArray]
		public RefArray<VoiceOverDialogClip> Clips { get { return m_Clips; } set { if (OnPropertyChanging("VoiceOverDialogTrack." + nameof(Clips), this, m_Clips, value)) m_Clips = value; } } // 0x18 (24)
		
		protected CtrRef<AudioGraphNodeData> m_SamplerNode = new CtrRef<AudioGraphNodeData>();
		[ContainerField(28), MemberInfoFlag(53), ContainerFieldNameHash(2812102673), ContainerCtrRef]
		public CtrRef<AudioGraphNodeData> SamplerNode { get { return m_SamplerNode; } set { if (OnPropertyChanging("VoiceOverDialogTrack." + nameof(SamplerNode), this, m_SamplerNode, value)) m_SamplerNode = value; } } // 0x1C (28)
		
		protected CtrRef<AudioGraphNodeData> m_Output = new CtrRef<AudioGraphNodeData>();
		[ContainerField(32), MemberInfoFlag(53), ContainerFieldNameHash(2895736442), ContainerCtrRef]
		public CtrRef<AudioGraphNodeData> Output { get { return m_Output; } set { if (OnPropertyChanging("VoiceOverDialogTrack." + nameof(Output), this, m_Output, value)) m_Output = value; } } // 0x20 (32)
		
		protected CtrRef<VoiceOverConversationQueueGroup> m_QueueGroup = new CtrRef<VoiceOverConversationQueueGroup>();
		[ContainerField(36), MemberInfoFlag(53), ContainerFieldNameHash(2016027659), ContainerCtrRef]
		public CtrRef<VoiceOverConversationQueueGroup> QueueGroup { get { return m_QueueGroup; } set { if (OnPropertyChanging("VoiceOverDialogTrack." + nameof(QueueGroup), this, m_QueueGroup, value)) m_QueueGroup = value; } } // 0x24 (36)
		
		protected sbyte m_ParentTrackIndex = new sbyte();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(3800885128)]
		public sbyte ParentTrackIndex { get { return m_ParentTrackIndex; } set { if (OnPropertyChanging("VoiceOverDialogTrack." + nameof(ParentTrackIndex), this, m_ParentTrackIndex, value)) m_ParentTrackIndex = value; } } // 0x28 (40)
		
		protected bool m_TakeSwitchingOnResume = new bool();
		[ContainerField(41), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3503965716)]
		public bool TakeSwitchingOnResume { get { return m_TakeSwitchingOnResume; } set { if (OnPropertyChanging("VoiceOverDialogTrack." + nameof(TakeSwitchingOnResume), this, m_TakeSwitchingOnResume, value)) m_TakeSwitchingOnResume = value; } } // 0x29 (41)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3339738264:
					Source = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 777187609:
					TakeControl = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 1460629004:
					TakeIndexMapping = (List<VoiceOverDialogTakeMapping>) p_Value;
					break;

				case 1993728428:
					TakeSwitching = (VoiceOverDialogTakeBehavior) Enum.ToObject(typeof(VoiceOverDialogTakeBehavior), p_Value);
					break;

				case 212627296:
					Clips = (RefArray<VoiceOverDialogClip>) p_Value;
					break;

				case 2812102673:
					SamplerNode = (CtrRef<AudioGraphNodeData>) p_Value;
					break;

				case 2895736442:
					Output = (CtrRef<AudioGraphNodeData>) p_Value;
					break;

				case 2016027659:
					QueueGroup = (CtrRef<VoiceOverConversationQueueGroup>) p_Value;
					break;

				case 3800885128:
					ParentTrackIndex = (sbyte) p_Value;
					break;

				case 3503965716:
					TakeSwitchingOnResume = (bool) p_Value;
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
				case 3339738264:
					return Source;

				case 777187609:
					return TakeControl;

				case 1460629004:
					return TakeIndexMapping;

				case 1993728428:
					return TakeSwitching;

				case 212627296:
					return Clips;

				case 2812102673:
					return SamplerNode;

				case 2895736442:
					return Output;

				case 2016027659:
					return QueueGroup;

				case 3800885128:
					return ParentTrackIndex;

				case 3503965716:
					return TakeSwitchingOnResume;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3339738264:
					return typeof(VoiceOverDialogTrack).GetProperty(nameof(Source));

				case 777187609:
					return typeof(VoiceOverDialogTrack).GetProperty(nameof(TakeControl));

				case 1460629004:
					return typeof(VoiceOverDialogTrack).GetProperty(nameof(TakeIndexMapping));

				case 1993728428:
					return typeof(VoiceOverDialogTrack).GetProperty(nameof(TakeSwitching));

				case 212627296:
					return typeof(VoiceOverDialogTrack).GetProperty(nameof(Clips));

				case 2812102673:
					return typeof(VoiceOverDialogTrack).GetProperty(nameof(SamplerNode));

				case 2895736442:
					return typeof(VoiceOverDialogTrack).GetProperty(nameof(Output));

				case 2016027659:
					return typeof(VoiceOverDialogTrack).GetProperty(nameof(QueueGroup));

				case 3800885128:
					return typeof(VoiceOverDialogTrack).GetProperty(nameof(ParentTrackIndex));

				case 3503965716:
					return typeof(VoiceOverDialogTrack).GetProperty(nameof(TakeSwitchingOnResume));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
