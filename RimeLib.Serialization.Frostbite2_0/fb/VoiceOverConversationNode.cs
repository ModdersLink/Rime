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

	}
}
