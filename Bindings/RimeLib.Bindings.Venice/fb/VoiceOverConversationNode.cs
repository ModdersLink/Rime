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
		public RefArray<VoiceOverDialogGroup> Groups { get; set; } = new();

		[ContainerField(16)]
		public RefArray<VoiceOverValueConnection> Condition { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<VoiceOverIntervalNode> Interval { get; set; } = new();

		[ContainerField(24)]
		public RefArray<VoiceOverStructureNode> FinishedRelationship { get; set; } = new();

		[ContainerField(28)]
		public RefArray<VoiceOverStructureNode> BlockedRelationship { get; set; } = new();

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

	}
}
