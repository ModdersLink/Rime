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
	[ContainerType(4, 44)]
	public class VoiceOverDialogTrack : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverValueConnection> Source { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<VoiceOverValueConnection> TakeControl { get; set; } = new();

		[ContainerField(16)]
		public List<VoiceOverDialogTakeMapping> TakeIndexMapping { get; set; } = new();

		[ContainerField(20)]
		public VoiceOverDialogTakeBehavior TakeSwitching { get; set; } = new();

		[ContainerField(24)]
		public RefArray<VoiceOverDialogClip> Clips { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<AudioGraphNodeData> SamplerNode { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<AudioGraphNodeData> Output { get; set; } = new();

		[ContainerField(36)]
		public CtrRef<VoiceOverConversationQueueGroup> QueueGroup { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public sbyte ParentTrackIndex { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable]
		public bool TakeSwitchingOnResume { get; set; }

	}
}
