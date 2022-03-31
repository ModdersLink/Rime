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
	[ContainerType(4, 296)]
	public class UIMessageCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ScoreAggregateTime { get; set; }

		[ContainerField(32), JsonProperty(Order = 32)]
		public MessageInfo ChatMessageInfo { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public MessageInfo KillMessageInfo { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public MessageInfo ScoreMessageInfo { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public MessageInfo ScoreMinorMessageInfo { get; set; } = new();

		[ContainerField(96), JsonProperty(Order = 96)]
		public MessageInfo ScoreMajorMessageInfo { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public MessageInfo GameMessageInfo { get; set; } = new();

		[ContainerField(128), JsonProperty(Order = 128)]
		public MessageInfo StaticMessageInfo { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public MessageInfo OutOfBoundsMessageInfo { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public MessageInfo KillScoreMessageInfo { get; set; } = new();

		[ContainerField(176), JsonProperty(Order = 176)]
		public MessageInfo LogLinesMessageInfo { get; set; } = new();

		[ContainerField(192), JsonProperty(Order = 192)]
		public MessageInfo TooltipMessageInfo { get; set; } = new();

		[ContainerField(208), JsonProperty(Order = 208)]
		public MessageInfo SubtitleMessageInfo { get; set; } = new();

		[ContainerField(224), JsonProperty(Order = 224)]
		public MessageInfo RewardMessageInfo { get; set; } = new();

		[ContainerField(240), JsonProperty(Order = 240)]
		public MessageInfo LocalKillMessageInfo { get; set; } = new();

		[ContainerField(256), JsonProperty(Order = 256)]
		public MessageInfo ServerAdminYellMessageInfo { get; set; } = new();

		[ContainerField(272), JsonProperty(Order = 272)]
		public MessageInfo GunMasterMessageInfo { get; set; } = new();

		[ContainerField(288), JsonProperty(Order = 288)]
		public List<string> ForceSubtitlesForTheseLevels { get; set; } = new();

		[ContainerField(292), JsonProperty(Order = 292)]
		public List<string> ForceSubtitlesOffForTheseLevels { get; set; } = new();

	}
}
