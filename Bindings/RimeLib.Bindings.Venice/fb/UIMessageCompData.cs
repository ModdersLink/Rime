///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIMessageCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ScoreAggregateTime { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public MessageInfo ChatMessageInfo { get; set; } = new MessageInfo(); // 0x20 (32)
		
		[ContainerField(48)]
		public MessageInfo KillMessageInfo { get; set; } = new MessageInfo(); // 0x30 (48)
		
		[ContainerField(64)]
		public MessageInfo ScoreMessageInfo { get; set; } = new MessageInfo(); // 0x40 (64)
		
		[ContainerField(80)]
		public MessageInfo ScoreMinorMessageInfo { get; set; } = new MessageInfo(); // 0x50 (80)
		
		[ContainerField(96)]
		public MessageInfo ScoreMajorMessageInfo { get; set; } = new MessageInfo(); // 0x60 (96)
		
		[ContainerField(112)]
		public MessageInfo GameMessageInfo { get; set; } = new MessageInfo(); // 0x70 (112)
		
		[ContainerField(128)]
		public MessageInfo StaticMessageInfo { get; set; } = new MessageInfo(); // 0x80 (128)
		
		[ContainerField(144)]
		public MessageInfo OutOfBoundsMessageInfo { get; set; } = new MessageInfo(); // 0x90 (144)
		
		[ContainerField(160)]
		public MessageInfo KillScoreMessageInfo { get; set; } = new MessageInfo(); // 0xA0 (160)
		
		[ContainerField(176)]
		public MessageInfo LogLinesMessageInfo { get; set; } = new MessageInfo(); // 0xB0 (176)
		
		[ContainerField(192)]
		public MessageInfo TooltipMessageInfo { get; set; } = new MessageInfo(); // 0xC0 (192)
		
		[ContainerField(208)]
		public MessageInfo SubtitleMessageInfo { get; set; } = new MessageInfo(); // 0xD0 (208)
		
		[ContainerField(224)]
		public MessageInfo RewardMessageInfo { get; set; } = new MessageInfo(); // 0xE0 (224)
		
		[ContainerField(240)]
		public MessageInfo LocalKillMessageInfo { get; set; } = new MessageInfo(); // 0xF0 (240)
		
		[ContainerField(256)]
		public MessageInfo ServerAdminYellMessageInfo { get; set; } = new MessageInfo(); // 0x100 (256)
		
		[ContainerField(272)]
		public MessageInfo GunMasterMessageInfo { get; set; } = new MessageInfo(); // 0x110 (272)
		
		[ContainerField(288)]
		public List<string> ForceSubtitlesForTheseLevels { get; set; } = new List<string>(); // 0x120 (288)
		
		[ContainerField(292)]
		public List<string> ForceSubtitlesOffForTheseLevels { get; set; } = new List<string>(); // 0x124 (292)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3131045625:
					ScoreAggregateTime = (float) p_Value;
					break;

				case 3764641406:
					ChatMessageInfo = (MessageInfo) p_Value;
					break;

				case 2923375554:
					KillMessageInfo = (MessageInfo) p_Value;
					break;

				case 2405334152:
					ScoreMessageInfo = (MessageInfo) p_Value;
					break;

				case 2692979999:
					ScoreMinorMessageInfo = (MessageInfo) p_Value;
					break;

				case 191604115:
					ScoreMajorMessageInfo = (MessageInfo) p_Value;
					break;

				case 1382841390:
					GameMessageInfo = (MessageInfo) p_Value;
					break;

				case 426555416:
					StaticMessageInfo = (MessageInfo) p_Value;
					break;

				case 3480040454:
					OutOfBoundsMessageInfo = (MessageInfo) p_Value;
					break;

				case 1841860426:
					KillScoreMessageInfo = (MessageInfo) p_Value;
					break;

				case 30304793:
					LogLinesMessageInfo = (MessageInfo) p_Value;
					break;

				case 4183774805:
					TooltipMessageInfo = (MessageInfo) p_Value;
					break;

				case 2325786660:
					SubtitleMessageInfo = (MessageInfo) p_Value;
					break;

				case 962275703:
					RewardMessageInfo = (MessageInfo) p_Value;
					break;

				case 2709134607:
					LocalKillMessageInfo = (MessageInfo) p_Value;
					break;

				case 4122512086:
					ServerAdminYellMessageInfo = (MessageInfo) p_Value;
					break;

				case 1757877952:
					GunMasterMessageInfo = (MessageInfo) p_Value;
					break;

				case 1052581054:
					ForceSubtitlesForTheseLevels = (List<string>) p_Value;
					break;

				case 3087549201:
					ForceSubtitlesOffForTheseLevels = (List<string>) p_Value;
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
				case 3131045625:
					return ScoreAggregateTime;

				case 3764641406:
					return ChatMessageInfo;

				case 2923375554:
					return KillMessageInfo;

				case 2405334152:
					return ScoreMessageInfo;

				case 2692979999:
					return ScoreMinorMessageInfo;

				case 191604115:
					return ScoreMajorMessageInfo;

				case 1382841390:
					return GameMessageInfo;

				case 426555416:
					return StaticMessageInfo;

				case 3480040454:
					return OutOfBoundsMessageInfo;

				case 1841860426:
					return KillScoreMessageInfo;

				case 30304793:
					return LogLinesMessageInfo;

				case 4183774805:
					return TooltipMessageInfo;

				case 2325786660:
					return SubtitleMessageInfo;

				case 962275703:
					return RewardMessageInfo;

				case 2709134607:
					return LocalKillMessageInfo;

				case 4122512086:
					return ServerAdminYellMessageInfo;

				case 1757877952:
					return GunMasterMessageInfo;

				case 1052581054:
					return ForceSubtitlesForTheseLevels;

				case 3087549201:
					return ForceSubtitlesOffForTheseLevels;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3131045625:
					return typeof(UIMessageCompData).GetProperty(nameof(ScoreAggregateTime));

				case 3764641406:
					return typeof(UIMessageCompData).GetProperty(nameof(ChatMessageInfo));

				case 2923375554:
					return typeof(UIMessageCompData).GetProperty(nameof(KillMessageInfo));

				case 2405334152:
					return typeof(UIMessageCompData).GetProperty(nameof(ScoreMessageInfo));

				case 2692979999:
					return typeof(UIMessageCompData).GetProperty(nameof(ScoreMinorMessageInfo));

				case 191604115:
					return typeof(UIMessageCompData).GetProperty(nameof(ScoreMajorMessageInfo));

				case 1382841390:
					return typeof(UIMessageCompData).GetProperty(nameof(GameMessageInfo));

				case 426555416:
					return typeof(UIMessageCompData).GetProperty(nameof(StaticMessageInfo));

				case 3480040454:
					return typeof(UIMessageCompData).GetProperty(nameof(OutOfBoundsMessageInfo));

				case 1841860426:
					return typeof(UIMessageCompData).GetProperty(nameof(KillScoreMessageInfo));

				case 30304793:
					return typeof(UIMessageCompData).GetProperty(nameof(LogLinesMessageInfo));

				case 4183774805:
					return typeof(UIMessageCompData).GetProperty(nameof(TooltipMessageInfo));

				case 2325786660:
					return typeof(UIMessageCompData).GetProperty(nameof(SubtitleMessageInfo));

				case 962275703:
					return typeof(UIMessageCompData).GetProperty(nameof(RewardMessageInfo));

				case 2709134607:
					return typeof(UIMessageCompData).GetProperty(nameof(LocalKillMessageInfo));

				case 4122512086:
					return typeof(UIMessageCompData).GetProperty(nameof(ServerAdminYellMessageInfo));

				case 1757877952:
					return typeof(UIMessageCompData).GetProperty(nameof(GunMasterMessageInfo));

				case 1052581054:
					return typeof(UIMessageCompData).GetProperty(nameof(ForceSubtitlesForTheseLevels));

				case 3087549201:
					return typeof(UIMessageCompData).GetProperty(nameof(ForceSubtitlesOffForTheseLevels));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
