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
	[ContainerType(4, 160)]
	public partial class BFServerSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _ServerMessage = string.Empty;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _CTFRoundTimeModifier;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _ForceTeamForPlayerTag = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private int _ForceTeamForPlayerTagTeam;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _NoInteractivityTimeoutTime;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _NoInteractivityThresholdLimit;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _NoInteractivityBanRoundCount;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private uint _TeamKillCountForKick;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _TeamKillValueForKick;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _TeamKillValueIncrease;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _TeamKillValueDecreasePerSecond;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private uint _TeamKillKickForBan;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private int _RoundMaxPlayerCount;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private int _RoundMinPlayerCount;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private int _RoundLockdownCountdown;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private int _RoundRestartCountdown;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private int _RoundWarmupTimeout;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, JsonProperty(Order = 80)]
		private string _BannerUrl = string.Empty;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, JsonProperty(Order = 84)]
		private string _ServerPreset = string.Empty;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, JsonProperty(Order = 88)]
		private string _ServerDescription = string.Empty;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, JsonProperty(Order = 92)]
		private string _ServerAdministrationSettings = string.Empty;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private uint _GameSize;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, JsonProperty(Order = 100)]
		private string _ServerAdministrationMapRotation = string.Empty;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		private string _ServerAdministrationMapRotationInformation = string.Empty;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private uint _ServerAdministrationRoundsPerMap;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, JsonProperty(Order = 112)]
		private string _Spectators = string.Empty;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, JsonProperty(Order = 116)]
		private string _PunkBusterVersion = string.Empty;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private uint _TeamSwitchImbalanceLimit;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, JsonProperty(Order = 124)]
		private string _GameMod = string.Empty;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, JsonProperty(Order = 128)]
		private string _PingSite = string.Empty;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, JsonProperty(Order = 132)]
		private string _OverrideServerConfigurationStartTime = string.Empty;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private uint _GunMasterWeaponsPresetIndex;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private int _ServerConfigurationRefreshInterval;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private int _DeathmatchFriendZoneFallbackCount;

		[ObservableProperty]
		[property: ContainerField(148), JsonProperty(Order = 148)]
		private VoiceChannel _DefaultVoiceChannel = new();

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private bool _MapSequencerEnabled;

		[ObservableProperty]
		[property: ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		private bool _KickAPlayerOnVIPJoin;

		[ObservableProperty]
		[property: ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		private bool _IsManDownRotationEnabled;

		[ObservableProperty]
		[property: ContainerField(155), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
		private bool _IsKillerCameraEnabled;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private bool _PremiumStatus;

		[ObservableProperty]
		[property: ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		private bool _OverrideAutoBalance;

		[ObservableProperty]
		[property: ContainerField(158), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
		private bool _AutoBalance;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(ServerMessage));
			p_Writer.Write(CTFRoundTimeModifier);
			p_Writer.Write(p_EbxWriter.WriteString(ForceTeamForPlayerTag));
			p_Writer.Write(ForceTeamForPlayerTagTeam);
			p_Writer.Write(NoInteractivityTimeoutTime);
			p_Writer.Write(NoInteractivityThresholdLimit);
			p_Writer.Write(NoInteractivityBanRoundCount);
			p_Writer.Write(TeamKillCountForKick);
			p_Writer.Write(TeamKillValueForKick);
			p_Writer.Write(TeamKillValueIncrease);
			p_Writer.Write(TeamKillValueDecreasePerSecond);
			p_Writer.Write(TeamKillKickForBan);
			p_Writer.Write(RoundMaxPlayerCount);
			p_Writer.Write(RoundMinPlayerCount);
			p_Writer.Write(RoundLockdownCountdown);
			p_Writer.Write(RoundRestartCountdown);
			p_Writer.Write(RoundWarmupTimeout);
			p_Writer.Write(p_EbxWriter.WriteString(BannerUrl));
			p_Writer.Write(p_EbxWriter.WriteString(ServerPreset));
			p_Writer.Write(p_EbxWriter.WriteString(ServerDescription));
			p_Writer.Write(p_EbxWriter.WriteString(ServerAdministrationSettings));
			p_Writer.Write(GameSize);
			p_Writer.Write(p_EbxWriter.WriteString(ServerAdministrationMapRotation));
			p_Writer.Write(p_EbxWriter.WriteString(ServerAdministrationMapRotationInformation));
			p_Writer.Write(ServerAdministrationRoundsPerMap);
			p_Writer.Write(p_EbxWriter.WriteString(Spectators));
			p_Writer.Write(p_EbxWriter.WriteString(PunkBusterVersion));
			p_Writer.Write(TeamSwitchImbalanceLimit);
			p_Writer.Write(p_EbxWriter.WriteString(GameMod));
			p_Writer.Write(p_EbxWriter.WriteString(PingSite));
			p_Writer.Write(p_EbxWriter.WriteString(OverrideServerConfigurationStartTime));
			p_Writer.Write(GunMasterWeaponsPresetIndex);
			p_Writer.Write(ServerConfigurationRefreshInterval);
			p_Writer.Write(DeathmatchFriendZoneFallbackCount);
			p_Writer.Write((int) DefaultVoiceChannel);
			p_Writer.Write(MapSequencerEnabled);
			p_Writer.Write(KickAPlayerOnVIPJoin);
			p_Writer.Write(IsManDownRotationEnabled);
			p_Writer.Write(IsKillerCameraEnabled);
			p_Writer.Write(PremiumStatus);
			p_Writer.Write(OverrideAutoBalance);
			p_Writer.Write(AutoBalance);
			p_Writer.WriteNullBytes(1);
		}
	}
}
