///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VoiceOverDialogTrack : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverValueConnection> Source { get; set; } = new CtrRef<VoiceOverValueConnection>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<VoiceOverValueConnection> TakeControl { get; set; } = new CtrRef<VoiceOverValueConnection>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<VoiceOverDialogTakeMapping> TakeIndexMapping { get; set; } = new List<VoiceOverDialogTakeMapping>(); // 0x10 (16)
		
		[ContainerField(20)]
		public VoiceOverDialogTakeBehavior TakeSwitching { get; set; } = new VoiceOverDialogTakeBehavior(); // 0x14 (20)
		
		[ContainerField(24)]
		public RefArray<VoiceOverDialogClip> Clips { get; set; } = new RefArray<VoiceOverDialogClip>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<AudioGraphNodeData> SamplerNode { get; set; } = new CtrRef<AudioGraphNodeData>(); // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<AudioGraphNodeData> Output { get; set; } = new CtrRef<AudioGraphNodeData>(); // 0x20 (32)
		
		[ContainerField(36)]
		public CtrRef<VoiceOverConversationQueueGroup> QueueGroup { get; set; } = new CtrRef<VoiceOverConversationQueueGroup>(); // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public sbyte ParentTrackIndex { get; set; } // 0x28 (40)
		
		[ContainerField(41), LayoutImmutable, Blittable]
		public bool TakeSwitchingOnResume { get; set; } // 0x29 (41)
		
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
