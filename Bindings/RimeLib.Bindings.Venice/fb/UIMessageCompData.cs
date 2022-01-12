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
	[ContainerType(4, 296)]
	public class UIMessageCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ScoreAggregateTime { get; set; }

		[ContainerField(32)]
		public MessageInfo ChatMessageInfo { get; set; } = new();

		[ContainerField(48)]
		public MessageInfo KillMessageInfo { get; set; } = new();

		[ContainerField(64)]
		public MessageInfo ScoreMessageInfo { get; set; } = new();

		[ContainerField(80)]
		public MessageInfo ScoreMinorMessageInfo { get; set; } = new();

		[ContainerField(96)]
		public MessageInfo ScoreMajorMessageInfo { get; set; } = new();

		[ContainerField(112)]
		public MessageInfo GameMessageInfo { get; set; } = new();

		[ContainerField(128)]
		public MessageInfo StaticMessageInfo { get; set; } = new();

		[ContainerField(144)]
		public MessageInfo OutOfBoundsMessageInfo { get; set; } = new();

		[ContainerField(160)]
		public MessageInfo KillScoreMessageInfo { get; set; } = new();

		[ContainerField(176)]
		public MessageInfo LogLinesMessageInfo { get; set; } = new();

		[ContainerField(192)]
		public MessageInfo TooltipMessageInfo { get; set; } = new();

		[ContainerField(208)]
		public MessageInfo SubtitleMessageInfo { get; set; } = new();

		[ContainerField(224)]
		public MessageInfo RewardMessageInfo { get; set; } = new();

		[ContainerField(240)]
		public MessageInfo LocalKillMessageInfo { get; set; } = new();

		[ContainerField(256)]
		public MessageInfo ServerAdminYellMessageInfo { get; set; } = new();

		[ContainerField(272)]
		public MessageInfo GunMasterMessageInfo { get; set; } = new();

		[ContainerField(288)]
		public List<string> ForceSubtitlesForTheseLevels { get; set; } = new();

		[ContainerField(292)]
		public List<string> ForceSubtitlesOffForTheseLevels { get; set; } = new();

	}
}
