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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class UIMessageCompData : 
		UIComponentData
	{
		protected float m_ScoreAggregateTime = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3131045625)]
		public float ScoreAggregateTime { get { return m_ScoreAggregateTime; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(ScoreAggregateTime), this, m_ScoreAggregateTime, value)) m_ScoreAggregateTime = value; } } // 0x1C (28)
		
		protected MessageInfo m_ChatMessageInfo = new MessageInfo();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(3764641406)]
		public MessageInfo ChatMessageInfo { get { return m_ChatMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(ChatMessageInfo), this, m_ChatMessageInfo, value)) m_ChatMessageInfo = value; } } // 0x20 (32)
		
		protected MessageInfo m_KillMessageInfo = new MessageInfo();
		[ContainerField(48), MemberInfoFlag(41), ContainerFieldNameHash(2923375554)]
		public MessageInfo KillMessageInfo { get { return m_KillMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(KillMessageInfo), this, m_KillMessageInfo, value)) m_KillMessageInfo = value; } } // 0x30 (48)
		
		protected MessageInfo m_ScoreMessageInfo = new MessageInfo();
		[ContainerField(64), MemberInfoFlag(41), ContainerFieldNameHash(2405334152)]
		public MessageInfo ScoreMessageInfo { get { return m_ScoreMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(ScoreMessageInfo), this, m_ScoreMessageInfo, value)) m_ScoreMessageInfo = value; } } // 0x40 (64)
		
		protected MessageInfo m_ScoreMinorMessageInfo = new MessageInfo();
		[ContainerField(80), MemberInfoFlag(41), ContainerFieldNameHash(2692979999)]
		public MessageInfo ScoreMinorMessageInfo { get { return m_ScoreMinorMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(ScoreMinorMessageInfo), this, m_ScoreMinorMessageInfo, value)) m_ScoreMinorMessageInfo = value; } } // 0x50 (80)
		
		protected MessageInfo m_ScoreMajorMessageInfo = new MessageInfo();
		[ContainerField(96), MemberInfoFlag(41), ContainerFieldNameHash(191604115)]
		public MessageInfo ScoreMajorMessageInfo { get { return m_ScoreMajorMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(ScoreMajorMessageInfo), this, m_ScoreMajorMessageInfo, value)) m_ScoreMajorMessageInfo = value; } } // 0x60 (96)
		
		protected MessageInfo m_GameMessageInfo = new MessageInfo();
		[ContainerField(112), MemberInfoFlag(41), ContainerFieldNameHash(1382841390)]
		public MessageInfo GameMessageInfo { get { return m_GameMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(GameMessageInfo), this, m_GameMessageInfo, value)) m_GameMessageInfo = value; } } // 0x70 (112)
		
		protected MessageInfo m_StaticMessageInfo = new MessageInfo();
		[ContainerField(128), MemberInfoFlag(41), ContainerFieldNameHash(426555416)]
		public MessageInfo StaticMessageInfo { get { return m_StaticMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(StaticMessageInfo), this, m_StaticMessageInfo, value)) m_StaticMessageInfo = value; } } // 0x80 (128)
		
		protected MessageInfo m_OutOfBoundsMessageInfo = new MessageInfo();
		[ContainerField(144), MemberInfoFlag(41), ContainerFieldNameHash(3480040454)]
		public MessageInfo OutOfBoundsMessageInfo { get { return m_OutOfBoundsMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(OutOfBoundsMessageInfo), this, m_OutOfBoundsMessageInfo, value)) m_OutOfBoundsMessageInfo = value; } } // 0x90 (144)
		
		protected MessageInfo m_KillScoreMessageInfo = new MessageInfo();
		[ContainerField(160), MemberInfoFlag(41), ContainerFieldNameHash(1841860426)]
		public MessageInfo KillScoreMessageInfo { get { return m_KillScoreMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(KillScoreMessageInfo), this, m_KillScoreMessageInfo, value)) m_KillScoreMessageInfo = value; } } // 0xA0 (160)
		
		protected MessageInfo m_LogLinesMessageInfo = new MessageInfo();
		[ContainerField(176), MemberInfoFlag(41), ContainerFieldNameHash(30304793)]
		public MessageInfo LogLinesMessageInfo { get { return m_LogLinesMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(LogLinesMessageInfo), this, m_LogLinesMessageInfo, value)) m_LogLinesMessageInfo = value; } } // 0xB0 (176)
		
		protected MessageInfo m_TooltipMessageInfo = new MessageInfo();
		[ContainerField(192), MemberInfoFlag(41), ContainerFieldNameHash(4183774805)]
		public MessageInfo TooltipMessageInfo { get { return m_TooltipMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(TooltipMessageInfo), this, m_TooltipMessageInfo, value)) m_TooltipMessageInfo = value; } } // 0xC0 (192)
		
		protected MessageInfo m_SubtitleMessageInfo = new MessageInfo();
		[ContainerField(208), MemberInfoFlag(41), ContainerFieldNameHash(2325786660)]
		public MessageInfo SubtitleMessageInfo { get { return m_SubtitleMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(SubtitleMessageInfo), this, m_SubtitleMessageInfo, value)) m_SubtitleMessageInfo = value; } } // 0xD0 (208)
		
		protected MessageInfo m_RewardMessageInfo = new MessageInfo();
		[ContainerField(224), MemberInfoFlag(41), ContainerFieldNameHash(962275703)]
		public MessageInfo RewardMessageInfo { get { return m_RewardMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(RewardMessageInfo), this, m_RewardMessageInfo, value)) m_RewardMessageInfo = value; } } // 0xE0 (224)
		
		protected MessageInfo m_LocalKillMessageInfo = new MessageInfo();
		[ContainerField(240), MemberInfoFlag(41), ContainerFieldNameHash(2709134607)]
		public MessageInfo LocalKillMessageInfo { get { return m_LocalKillMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(LocalKillMessageInfo), this, m_LocalKillMessageInfo, value)) m_LocalKillMessageInfo = value; } } // 0xF0 (240)
		
		protected MessageInfo m_ServerAdminYellMessageInfo = new MessageInfo();
		[ContainerField(256), MemberInfoFlag(41), ContainerFieldNameHash(4122512086)]
		public MessageInfo ServerAdminYellMessageInfo { get { return m_ServerAdminYellMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(ServerAdminYellMessageInfo), this, m_ServerAdminYellMessageInfo, value)) m_ServerAdminYellMessageInfo = value; } } // 0x100 (256)
		
		protected MessageInfo m_GunMasterMessageInfo = new MessageInfo();
		[ContainerField(272), MemberInfoFlag(41), ContainerFieldNameHash(1757877952)]
		public MessageInfo GunMasterMessageInfo { get { return m_GunMasterMessageInfo; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(GunMasterMessageInfo), this, m_GunMasterMessageInfo, value)) m_GunMasterMessageInfo = value; } } // 0x110 (272)
		
		protected List<string> m_ForceSubtitlesForTheseLevels = new List<string>();
		[ContainerField(288), MemberInfoFlag(65), ContainerFieldNameHash(1052581054), ContainerArray]
		public List<string> ForceSubtitlesForTheseLevels { get { return m_ForceSubtitlesForTheseLevels; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(ForceSubtitlesForTheseLevels), this, m_ForceSubtitlesForTheseLevels, value)) m_ForceSubtitlesForTheseLevels = value; } } // 0x120 (288)
		
		protected List<string> m_ForceSubtitlesOffForTheseLevels = new List<string>();
		[ContainerField(292), MemberInfoFlag(65), ContainerFieldNameHash(3087549201), ContainerArray]
		public List<string> ForceSubtitlesOffForTheseLevels { get { return m_ForceSubtitlesOffForTheseLevels; } set { if (OnPropertyChanging("UIMessageCompData." + nameof(ForceSubtitlesOffForTheseLevels), this, m_ForceSubtitlesOffForTheseLevels, value)) m_ForceSubtitlesOffForTheseLevels = value; } } // 0x124 (292)
		
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
