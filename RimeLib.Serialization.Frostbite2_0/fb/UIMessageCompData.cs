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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 296)]
	public partial class UIMessageCompData :
		UIComponentData
	{
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _ScoreAggregateTime;

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private MessageInfo _ChatMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private MessageInfo _KillMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private MessageInfo _ScoreMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private MessageInfo _ScoreMinorMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private MessageInfo _ScoreMajorMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private MessageInfo _GameMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private MessageInfo _StaticMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private MessageInfo _OutOfBoundsMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private MessageInfo _KillScoreMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(176), JsonProperty(Order = 176)]
		private MessageInfo _LogLinesMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(192), JsonProperty(Order = 192)]
		private MessageInfo _TooltipMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(208), JsonProperty(Order = 208)]
		private MessageInfo _SubtitleMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(224), JsonProperty(Order = 224)]
		private MessageInfo _RewardMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(240), JsonProperty(Order = 240)]
		private MessageInfo _LocalKillMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(256), JsonProperty(Order = 256)]
		private MessageInfo _ServerAdminYellMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(272), JsonProperty(Order = 272)]
		private MessageInfo _GunMasterMessageInfo = new();

		[ObservableProperty]
		[property: ContainerField(288), JsonProperty(Order = 288)]
		private List<string> _ForceSubtitlesForTheseLevels = new();

		[ObservableProperty]
		[property: ContainerField(292), JsonProperty(Order = 292)]
		private List<string> _ForceSubtitlesOffForTheseLevels = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ScoreAggregateTime);
			ChatMessageInfo.Serialize(p_Writer, p_EbxWriter);
			KillMessageInfo.Serialize(p_Writer, p_EbxWriter);
			ScoreMessageInfo.Serialize(p_Writer, p_EbxWriter);
			ScoreMinorMessageInfo.Serialize(p_Writer, p_EbxWriter);
			ScoreMajorMessageInfo.Serialize(p_Writer, p_EbxWriter);
			GameMessageInfo.Serialize(p_Writer, p_EbxWriter);
			StaticMessageInfo.Serialize(p_Writer, p_EbxWriter);
			OutOfBoundsMessageInfo.Serialize(p_Writer, p_EbxWriter);
			KillScoreMessageInfo.Serialize(p_Writer, p_EbxWriter);
			LogLinesMessageInfo.Serialize(p_Writer, p_EbxWriter);
			TooltipMessageInfo.Serialize(p_Writer, p_EbxWriter);
			SubtitleMessageInfo.Serialize(p_Writer, p_EbxWriter);
			RewardMessageInfo.Serialize(p_Writer, p_EbxWriter);
			LocalKillMessageInfo.Serialize(p_Writer, p_EbxWriter);
			ServerAdminYellMessageInfo.Serialize(p_Writer, p_EbxWriter);
			GunMasterMessageInfo.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_ForceSubtitlesForTheseLevels = p_EbxWriter.GetArrayWriter(ForceSubtitlesForTheseLevels.GetType(), ForceSubtitlesForTheseLevels.Count);
			p_Writer.Write(s_ForceSubtitlesForTheseLevels.ArrayIndex);
			foreach (var s_Entry in ForceSubtitlesForTheseLevels)
			{
				s_ForceSubtitlesForTheseLevels.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_ForceSubtitlesOffForTheseLevels = p_EbxWriter.GetArrayWriter(ForceSubtitlesOffForTheseLevels.GetType(), ForceSubtitlesOffForTheseLevels.Count);
			p_Writer.Write(s_ForceSubtitlesOffForTheseLevels.ArrayIndex);
			foreach (var s_Entry in ForceSubtitlesOffForTheseLevels)
			{
				s_ForceSubtitlesOffForTheseLevels.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
		}
	}
}
