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
	[ContainerType(4, 56)]
	public class VoiceOverSystemAsset : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<VoiceOverInterval> Intervals { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<VoiceOverLabel> Labels { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<VoiceOverObject> Types { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public RefArray<VoiceOverObject> Objects { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public RefArray<VoiceOverGlobalConstantValue> Constants { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<AudioLanguage> MasterLanguage { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<VoiceOverPronunciation> DefaultPronunciation { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public RefArray<VoiceOverPronunciation> Pronunciations { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public RefArray<VoiceOverConversationQueueGroup> QueueGroups { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<VoiceOverConversationQueueGroup> DefaultPositionedQueueGroup { get; set; } = new();

		[ContainerField(52), JsonProperty(Order = 52)]
		public CtrRef<VoiceOverConversationQueueGroup> DefaultUnpositionedQueueGroup { get; set; } = new();

	}
}
