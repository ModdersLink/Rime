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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 160)]
	public class BFServerSettings : 
		SystemSettings
	{
		protected string m_ServerMessage = string.Empty;
		[ContainerField(Name: "ServerMessage", Offset: 12, NameHash: 294234699, Flags: 16509), LayoutImmutable]
		public string ServerMessage { get { return m_ServerMessage; } set { if (OnPropertyChanging("BFServerSettings." + nameof(ServerMessage), this, m_ServerMessage, value)) m_ServerMessage = value; } } // 0xC (12)
		
		protected float m_CTFRoundTimeModifier = new float();
		[ContainerField(Name: "CTFRoundTimeModifier", Offset: 16, NameHash: 700307892, Flags: 49469), LayoutImmutable, Blittable]
		public float CTFRoundTimeModifier { get { return m_CTFRoundTimeModifier; } set { if (OnPropertyChanging("BFServerSettings." + nameof(CTFRoundTimeModifier), this, m_CTFRoundTimeModifier, value)) m_CTFRoundTimeModifier = value; } } // 0x10 (16)
		
		protected string m_ForceTeamForPlayerTag = string.Empty;
		[ContainerField(Name: "ForceTeamForPlayerTag", Offset: 20, NameHash: 3026740703, Flags: 16509), LayoutImmutable]
		public string ForceTeamForPlayerTag { get { return m_ForceTeamForPlayerTag; } set { if (OnPropertyChanging("BFServerSettings." + nameof(ForceTeamForPlayerTag), this, m_ForceTeamForPlayerTag, value)) m_ForceTeamForPlayerTag = value; } } // 0x14 (20)
		
		protected int m_ForceTeamForPlayerTagTeam = new int();
		[ContainerField(Name: "ForceTeamForPlayerTagTeam", Offset: 24, NameHash: 3689797122, Flags: 49405), LayoutImmutable, Blittable]
		public int ForceTeamForPlayerTagTeam { get { return m_ForceTeamForPlayerTagTeam; } set { if (OnPropertyChanging("BFServerSettings." + nameof(ForceTeamForPlayerTagTeam), this, m_ForceTeamForPlayerTagTeam, value)) m_ForceTeamForPlayerTagTeam = value; } } // 0x18 (24)
		
		protected float m_NoInteractivityTimeoutTime = new float();
		[ContainerField(Name: "NoInteractivityTimeoutTime", Offset: 28, NameHash: 4167575203, Flags: 49469), LayoutImmutable, Blittable]
		public float NoInteractivityTimeoutTime { get { return m_NoInteractivityTimeoutTime; } set { if (OnPropertyChanging("BFServerSettings." + nameof(NoInteractivityTimeoutTime), this, m_NoInteractivityTimeoutTime, value)) m_NoInteractivityTimeoutTime = value; } } // 0x1C (28)
		
		protected float m_NoInteractivityThresholdLimit = new float();
		[ContainerField(Name: "NoInteractivityThresholdLimit", Offset: 32, NameHash: 1482119343, Flags: 49469), LayoutImmutable, Blittable]
		public float NoInteractivityThresholdLimit { get { return m_NoInteractivityThresholdLimit; } set { if (OnPropertyChanging("BFServerSettings." + nameof(NoInteractivityThresholdLimit), this, m_NoInteractivityThresholdLimit, value)) m_NoInteractivityThresholdLimit = value; } } // 0x20 (32)
		
		protected uint m_NoInteractivityBanRoundCount = new uint();
		[ContainerField(Name: "NoInteractivityBanRoundCount", Offset: 36, NameHash: 905794337, Flags: 49421), LayoutImmutable, Blittable]
		public uint NoInteractivityBanRoundCount { get { return m_NoInteractivityBanRoundCount; } set { if (OnPropertyChanging("BFServerSettings." + nameof(NoInteractivityBanRoundCount), this, m_NoInteractivityBanRoundCount, value)) m_NoInteractivityBanRoundCount = value; } } // 0x24 (36)
		
		protected uint m_TeamKillCountForKick = new uint();
		[ContainerField(Name: "TeamKillCountForKick", Offset: 40, NameHash: 1971523848, Flags: 49421), LayoutImmutable, Blittable]
		public uint TeamKillCountForKick { get { return m_TeamKillCountForKick; } set { if (OnPropertyChanging("BFServerSettings." + nameof(TeamKillCountForKick), this, m_TeamKillCountForKick, value)) m_TeamKillCountForKick = value; } } // 0x28 (40)
		
		protected float m_TeamKillValueForKick = new float();
		[ContainerField(Name: "TeamKillValueForKick", Offset: 44, NameHash: 595759392, Flags: 49469), LayoutImmutable, Blittable]
		public float TeamKillValueForKick { get { return m_TeamKillValueForKick; } set { if (OnPropertyChanging("BFServerSettings." + nameof(TeamKillValueForKick), this, m_TeamKillValueForKick, value)) m_TeamKillValueForKick = value; } } // 0x2C (44)
		
		protected float m_TeamKillValueIncrease = new float();
		[ContainerField(Name: "TeamKillValueIncrease", Offset: 48, NameHash: 3705636661, Flags: 49469), LayoutImmutable, Blittable]
		public float TeamKillValueIncrease { get { return m_TeamKillValueIncrease; } set { if (OnPropertyChanging("BFServerSettings." + nameof(TeamKillValueIncrease), this, m_TeamKillValueIncrease, value)) m_TeamKillValueIncrease = value; } } // 0x30 (48)
		
		protected float m_TeamKillValueDecreasePerSecond = new float();
		[ContainerField(Name: "TeamKillValueDecreasePerSecond", Offset: 52, NameHash: 2344261092, Flags: 49469), LayoutImmutable, Blittable]
		public float TeamKillValueDecreasePerSecond { get { return m_TeamKillValueDecreasePerSecond; } set { if (OnPropertyChanging("BFServerSettings." + nameof(TeamKillValueDecreasePerSecond), this, m_TeamKillValueDecreasePerSecond, value)) m_TeamKillValueDecreasePerSecond = value; } } // 0x34 (52)
		
		protected uint m_TeamKillKickForBan = new uint();
		[ContainerField(Name: "TeamKillKickForBan", Offset: 56, NameHash: 409104006, Flags: 49421), LayoutImmutable, Blittable]
		public uint TeamKillKickForBan { get { return m_TeamKillKickForBan; } set { if (OnPropertyChanging("BFServerSettings." + nameof(TeamKillKickForBan), this, m_TeamKillKickForBan, value)) m_TeamKillKickForBan = value; } } // 0x38 (56)
		
		protected int m_RoundMaxPlayerCount = new int();
		[ContainerField(Name: "RoundMaxPlayerCount", Offset: 60, NameHash: 3644312963, Flags: 49405), LayoutImmutable, Blittable]
		public int RoundMaxPlayerCount { get { return m_RoundMaxPlayerCount; } set { if (OnPropertyChanging("BFServerSettings." + nameof(RoundMaxPlayerCount), this, m_RoundMaxPlayerCount, value)) m_RoundMaxPlayerCount = value; } } // 0x3C (60)
		
		protected int m_RoundMinPlayerCount = new int();
		[ContainerField(Name: "RoundMinPlayerCount", Offset: 64, NameHash: 1656551901, Flags: 49405), LayoutImmutable, Blittable]
		public int RoundMinPlayerCount { get { return m_RoundMinPlayerCount; } set { if (OnPropertyChanging("BFServerSettings." + nameof(RoundMinPlayerCount), this, m_RoundMinPlayerCount, value)) m_RoundMinPlayerCount = value; } } // 0x40 (64)
		
		protected int m_RoundLockdownCountdown = new int();
		[ContainerField(Name: "RoundLockdownCountdown", Offset: 68, NameHash: 3156188847, Flags: 49405), LayoutImmutable, Blittable]
		public int RoundLockdownCountdown { get { return m_RoundLockdownCountdown; } set { if (OnPropertyChanging("BFServerSettings." + nameof(RoundLockdownCountdown), this, m_RoundLockdownCountdown, value)) m_RoundLockdownCountdown = value; } } // 0x44 (68)
		
		protected int m_RoundRestartCountdown = new int();
		[ContainerField(Name: "RoundRestartCountdown", Offset: 72, NameHash: 1048503553, Flags: 49405), LayoutImmutable, Blittable]
		public int RoundRestartCountdown { get { return m_RoundRestartCountdown; } set { if (OnPropertyChanging("BFServerSettings." + nameof(RoundRestartCountdown), this, m_RoundRestartCountdown, value)) m_RoundRestartCountdown = value; } } // 0x48 (72)
		
		protected int m_RoundWarmupTimeout = new int();
		[ContainerField(Name: "RoundWarmupTimeout", Offset: 76, NameHash: 2371863664, Flags: 49405), LayoutImmutable, Blittable]
		public int RoundWarmupTimeout { get { return m_RoundWarmupTimeout; } set { if (OnPropertyChanging("BFServerSettings." + nameof(RoundWarmupTimeout), this, m_RoundWarmupTimeout, value)) m_RoundWarmupTimeout = value; } } // 0x4C (76)
		
		protected string m_BannerUrl = string.Empty;
		[ContainerField(Name: "BannerUrl", Offset: 80, NameHash: 524064634, Flags: 16509), LayoutImmutable]
		public string BannerUrl { get { return m_BannerUrl; } set { if (OnPropertyChanging("BFServerSettings." + nameof(BannerUrl), this, m_BannerUrl, value)) m_BannerUrl = value; } } // 0x50 (80)
		
		protected string m_ServerPreset = string.Empty;
		[ContainerField(Name: "ServerPreset", Offset: 84, NameHash: 4054803269, Flags: 16509), LayoutImmutable]
		public string ServerPreset { get { return m_ServerPreset; } set { if (OnPropertyChanging("BFServerSettings." + nameof(ServerPreset), this, m_ServerPreset, value)) m_ServerPreset = value; } } // 0x54 (84)
		
		protected string m_ServerDescription = string.Empty;
		[ContainerField(Name: "ServerDescription", Offset: 88, NameHash: 2053120230, Flags: 16509), LayoutImmutable]
		public string ServerDescription { get { return m_ServerDescription; } set { if (OnPropertyChanging("BFServerSettings." + nameof(ServerDescription), this, m_ServerDescription, value)) m_ServerDescription = value; } } // 0x58 (88)
		
		protected string m_ServerAdministrationSettings = string.Empty;
		[ContainerField(Name: "ServerAdministrationSettings", Offset: 92, NameHash: 1747142923, Flags: 16509), LayoutImmutable]
		public string ServerAdministrationSettings { get { return m_ServerAdministrationSettings; } set { if (OnPropertyChanging("BFServerSettings." + nameof(ServerAdministrationSettings), this, m_ServerAdministrationSettings, value)) m_ServerAdministrationSettings = value; } } // 0x5C (92)
		
		protected uint m_GameSize = new uint();
		[ContainerField(Name: "GameSize", Offset: 96, NameHash: 510337326, Flags: 49421), LayoutImmutable, Blittable]
		public uint GameSize { get { return m_GameSize; } set { if (OnPropertyChanging("BFServerSettings." + nameof(GameSize), this, m_GameSize, value)) m_GameSize = value; } } // 0x60 (96)
		
		protected string m_ServerAdministrationMapRotation = string.Empty;
		[ContainerField(Name: "ServerAdministrationMapRotation", Offset: 100, NameHash: 519997478, Flags: 16509), LayoutImmutable]
		public string ServerAdministrationMapRotation { get { return m_ServerAdministrationMapRotation; } set { if (OnPropertyChanging("BFServerSettings." + nameof(ServerAdministrationMapRotation), this, m_ServerAdministrationMapRotation, value)) m_ServerAdministrationMapRotation = value; } } // 0x64 (100)
		
		protected string m_ServerAdministrationMapRotationInformation = string.Empty;
		[ContainerField(Name: "ServerAdministrationMapRotationInformation", Offset: 104, NameHash: 3813127178, Flags: 16509), LayoutImmutable]
		public string ServerAdministrationMapRotationInformation { get { return m_ServerAdministrationMapRotationInformation; } set { if (OnPropertyChanging("BFServerSettings." + nameof(ServerAdministrationMapRotationInformation), this, m_ServerAdministrationMapRotationInformation, value)) m_ServerAdministrationMapRotationInformation = value; } } // 0x68 (104)
		
		protected uint m_ServerAdministrationRoundsPerMap = new uint();
		[ContainerField(Name: "ServerAdministrationRoundsPerMap", Offset: 108, NameHash: 992248100, Flags: 49421), LayoutImmutable, Blittable]
		public uint ServerAdministrationRoundsPerMap { get { return m_ServerAdministrationRoundsPerMap; } set { if (OnPropertyChanging("BFServerSettings." + nameof(ServerAdministrationRoundsPerMap), this, m_ServerAdministrationRoundsPerMap, value)) m_ServerAdministrationRoundsPerMap = value; } } // 0x6C (108)
		
		protected string m_Spectators = string.Empty;
		[ContainerField(Name: "Spectators", Offset: 112, NameHash: 2306821231, Flags: 16509), LayoutImmutable]
		public string Spectators { get { return m_Spectators; } set { if (OnPropertyChanging("BFServerSettings." + nameof(Spectators), this, m_Spectators, value)) m_Spectators = value; } } // 0x70 (112)
		
		protected string m_PunkBusterVersion = string.Empty;
		[ContainerField(Name: "PunkBusterVersion", Offset: 116, NameHash: 231433080, Flags: 16509), LayoutImmutable]
		public string PunkBusterVersion { get { return m_PunkBusterVersion; } set { if (OnPropertyChanging("BFServerSettings." + nameof(PunkBusterVersion), this, m_PunkBusterVersion, value)) m_PunkBusterVersion = value; } } // 0x74 (116)
		
		protected uint m_TeamSwitchImbalanceLimit = new uint();
		[ContainerField(Name: "TeamSwitchImbalanceLimit", Offset: 120, NameHash: 1639781149, Flags: 49421), LayoutImmutable, Blittable]
		public uint TeamSwitchImbalanceLimit { get { return m_TeamSwitchImbalanceLimit; } set { if (OnPropertyChanging("BFServerSettings." + nameof(TeamSwitchImbalanceLimit), this, m_TeamSwitchImbalanceLimit, value)) m_TeamSwitchImbalanceLimit = value; } } // 0x78 (120)
		
		protected string m_GameMod = string.Empty;
		[ContainerField(Name: "GameMod", Offset: 124, NameHash: 2878752685, Flags: 16509), LayoutImmutable]
		public string GameMod { get { return m_GameMod; } set { if (OnPropertyChanging("BFServerSettings." + nameof(GameMod), this, m_GameMod, value)) m_GameMod = value; } } // 0x7C (124)
		
		protected string m_PingSite = string.Empty;
		[ContainerField(Name: "PingSite", Offset: 128, NameHash: 1333330622, Flags: 16509), LayoutImmutable]
		public string PingSite { get { return m_PingSite; } set { if (OnPropertyChanging("BFServerSettings." + nameof(PingSite), this, m_PingSite, value)) m_PingSite = value; } } // 0x80 (128)
		
		protected string m_OverrideServerConfigurationStartTime = string.Empty;
		[ContainerField(Name: "OverrideServerConfigurationStartTime", Offset: 132, NameHash: 456186673, Flags: 16509), LayoutImmutable]
		public string OverrideServerConfigurationStartTime { get { return m_OverrideServerConfigurationStartTime; } set { if (OnPropertyChanging("BFServerSettings." + nameof(OverrideServerConfigurationStartTime), this, m_OverrideServerConfigurationStartTime, value)) m_OverrideServerConfigurationStartTime = value; } } // 0x84 (132)
		
		protected uint m_GunMasterWeaponsPresetIndex = new uint();
		[ContainerField(Name: "GunMasterWeaponsPresetIndex", Offset: 136, NameHash: 1836263279, Flags: 49421), LayoutImmutable, Blittable]
		public uint GunMasterWeaponsPresetIndex { get { return m_GunMasterWeaponsPresetIndex; } set { if (OnPropertyChanging("BFServerSettings." + nameof(GunMasterWeaponsPresetIndex), this, m_GunMasterWeaponsPresetIndex, value)) m_GunMasterWeaponsPresetIndex = value; } } // 0x88 (136)
		
		protected int m_ServerConfigurationRefreshInterval = new int();
		[ContainerField(Name: "ServerConfigurationRefreshInterval", Offset: 140, NameHash: 2755760498, Flags: 49405), LayoutImmutable, Blittable]
		public int ServerConfigurationRefreshInterval { get { return m_ServerConfigurationRefreshInterval; } set { if (OnPropertyChanging("BFServerSettings." + nameof(ServerConfigurationRefreshInterval), this, m_ServerConfigurationRefreshInterval, value)) m_ServerConfigurationRefreshInterval = value; } } // 0x8C (140)
		
		protected int m_DeathmatchFriendZoneFallbackCount = new int();
		[ContainerField(Name: "DeathmatchFriendZoneFallbackCount", Offset: 144, NameHash: 1236403401, Flags: 49405), LayoutImmutable, Blittable]
		public int DeathmatchFriendZoneFallbackCount { get { return m_DeathmatchFriendZoneFallbackCount; } set { if (OnPropertyChanging("BFServerSettings." + nameof(DeathmatchFriendZoneFallbackCount), this, m_DeathmatchFriendZoneFallbackCount, value)) m_DeathmatchFriendZoneFallbackCount = value; } } // 0x90 (144)
		
		protected VoiceChannel m_DefaultVoiceChannel = new VoiceChannel();
		[ContainerField(Name: "DefaultVoiceChannel", Offset: 148, NameHash: 2629887899, Flags: 137)]
		public VoiceChannel DefaultVoiceChannel { get { return m_DefaultVoiceChannel; } set { if (OnPropertyChanging("BFServerSettings." + nameof(DefaultVoiceChannel), this, m_DefaultVoiceChannel, value)) m_DefaultVoiceChannel = value; } } // 0x94 (148)
		
		protected bool m_MapSequencerEnabled = new bool();
		[ContainerField(Name: "MapSequencerEnabled", Offset: 152, NameHash: 4008184561, Flags: 49325), LayoutImmutable, Blittable]
		public bool MapSequencerEnabled { get { return m_MapSequencerEnabled; } set { if (OnPropertyChanging("BFServerSettings." + nameof(MapSequencerEnabled), this, m_MapSequencerEnabled, value)) m_MapSequencerEnabled = value; } } // 0x98 (152)
		
		protected bool m_KickAPlayerOnVIPJoin = new bool();
		[ContainerField(Name: "KickAPlayerOnVIPJoin", Offset: 153, NameHash: 1705443217, Flags: 49325), LayoutImmutable, Blittable]
		public bool KickAPlayerOnVIPJoin { get { return m_KickAPlayerOnVIPJoin; } set { if (OnPropertyChanging("BFServerSettings." + nameof(KickAPlayerOnVIPJoin), this, m_KickAPlayerOnVIPJoin, value)) m_KickAPlayerOnVIPJoin = value; } } // 0x99 (153)
		
		protected bool m_IsManDownRotationEnabled = new bool();
		[ContainerField(Name: "IsManDownRotationEnabled", Offset: 154, NameHash: 3176848926, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsManDownRotationEnabled { get { return m_IsManDownRotationEnabled; } set { if (OnPropertyChanging("BFServerSettings." + nameof(IsManDownRotationEnabled), this, m_IsManDownRotationEnabled, value)) m_IsManDownRotationEnabled = value; } } // 0x9A (154)
		
		protected bool m_IsKillerCameraEnabled = new bool();
		[ContainerField(Name: "IsKillerCameraEnabled", Offset: 155, NameHash: 3462209494, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsKillerCameraEnabled { get { return m_IsKillerCameraEnabled; } set { if (OnPropertyChanging("BFServerSettings." + nameof(IsKillerCameraEnabled), this, m_IsKillerCameraEnabled, value)) m_IsKillerCameraEnabled = value; } } // 0x9B (155)
		
		protected bool m_PremiumStatus = new bool();
		[ContainerField(Name: "PremiumStatus", Offset: 156, NameHash: 2767215594, Flags: 49325), LayoutImmutable, Blittable]
		public bool PremiumStatus { get { return m_PremiumStatus; } set { if (OnPropertyChanging("BFServerSettings." + nameof(PremiumStatus), this, m_PremiumStatus, value)) m_PremiumStatus = value; } } // 0x9C (156)
		
		protected bool m_OverrideAutoBalance = new bool();
		[ContainerField(Name: "OverrideAutoBalance", Offset: 157, NameHash: 2508529624, Flags: 49325), LayoutImmutable, Blittable]
		public bool OverrideAutoBalance { get { return m_OverrideAutoBalance; } set { if (OnPropertyChanging("BFServerSettings." + nameof(OverrideAutoBalance), this, m_OverrideAutoBalance, value)) m_OverrideAutoBalance = value; } } // 0x9D (157)
		
		protected bool m_AutoBalance = new bool();
		[ContainerField(Name: "AutoBalance", Offset: 158, NameHash: 2626919340, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoBalance { get { return m_AutoBalance; } set { if (OnPropertyChanging("BFServerSettings." + nameof(AutoBalance), this, m_AutoBalance, value)) m_AutoBalance = value; } } // 0x9E (158)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 294234699:
					ServerMessage = (string) p_Value;
					break;

				case 700307892:
					CTFRoundTimeModifier = (float) p_Value;
					break;

				case 3026740703:
					ForceTeamForPlayerTag = (string) p_Value;
					break;

				case 3689797122:
					ForceTeamForPlayerTagTeam = (int) p_Value;
					break;

				case 4167575203:
					NoInteractivityTimeoutTime = (float) p_Value;
					break;

				case 1482119343:
					NoInteractivityThresholdLimit = (float) p_Value;
					break;

				case 905794337:
					NoInteractivityBanRoundCount = (uint) p_Value;
					break;

				case 1971523848:
					TeamKillCountForKick = (uint) p_Value;
					break;

				case 595759392:
					TeamKillValueForKick = (float) p_Value;
					break;

				case 3705636661:
					TeamKillValueIncrease = (float) p_Value;
					break;

				case 2344261092:
					TeamKillValueDecreasePerSecond = (float) p_Value;
					break;

				case 409104006:
					TeamKillKickForBan = (uint) p_Value;
					break;

				case 3644312963:
					RoundMaxPlayerCount = (int) p_Value;
					break;

				case 1656551901:
					RoundMinPlayerCount = (int) p_Value;
					break;

				case 3156188847:
					RoundLockdownCountdown = (int) p_Value;
					break;

				case 1048503553:
					RoundRestartCountdown = (int) p_Value;
					break;

				case 2371863664:
					RoundWarmupTimeout = (int) p_Value;
					break;

				case 524064634:
					BannerUrl = (string) p_Value;
					break;

				case 4054803269:
					ServerPreset = (string) p_Value;
					break;

				case 2053120230:
					ServerDescription = (string) p_Value;
					break;

				case 1747142923:
					ServerAdministrationSettings = (string) p_Value;
					break;

				case 510337326:
					GameSize = (uint) p_Value;
					break;

				case 519997478:
					ServerAdministrationMapRotation = (string) p_Value;
					break;

				case 3813127178:
					ServerAdministrationMapRotationInformation = (string) p_Value;
					break;

				case 992248100:
					ServerAdministrationRoundsPerMap = (uint) p_Value;
					break;

				case 2306821231:
					Spectators = (string) p_Value;
					break;

				case 231433080:
					PunkBusterVersion = (string) p_Value;
					break;

				case 1639781149:
					TeamSwitchImbalanceLimit = (uint) p_Value;
					break;

				case 2878752685:
					GameMod = (string) p_Value;
					break;

				case 1333330622:
					PingSite = (string) p_Value;
					break;

				case 456186673:
					OverrideServerConfigurationStartTime = (string) p_Value;
					break;

				case 1836263279:
					GunMasterWeaponsPresetIndex = (uint) p_Value;
					break;

				case 2755760498:
					ServerConfigurationRefreshInterval = (int) p_Value;
					break;

				case 1236403401:
					DeathmatchFriendZoneFallbackCount = (int) p_Value;
					break;

				case 2629887899:
					DefaultVoiceChannel = (VoiceChannel) Enum.ToObject(typeof(VoiceChannel), p_Value);
					break;

				case 4008184561:
					MapSequencerEnabled = (bool) p_Value;
					break;

				case 1705443217:
					KickAPlayerOnVIPJoin = (bool) p_Value;
					break;

				case 3176848926:
					IsManDownRotationEnabled = (bool) p_Value;
					break;

				case 3462209494:
					IsKillerCameraEnabled = (bool) p_Value;
					break;

				case 2767215594:
					PremiumStatus = (bool) p_Value;
					break;

				case 2508529624:
					OverrideAutoBalance = (bool) p_Value;
					break;

				case 2626919340:
					AutoBalance = (bool) p_Value;
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
				case 294234699:
					return ServerMessage;

				case 700307892:
					return CTFRoundTimeModifier;

				case 3026740703:
					return ForceTeamForPlayerTag;

				case 3689797122:
					return ForceTeamForPlayerTagTeam;

				case 4167575203:
					return NoInteractivityTimeoutTime;

				case 1482119343:
					return NoInteractivityThresholdLimit;

				case 905794337:
					return NoInteractivityBanRoundCount;

				case 1971523848:
					return TeamKillCountForKick;

				case 595759392:
					return TeamKillValueForKick;

				case 3705636661:
					return TeamKillValueIncrease;

				case 2344261092:
					return TeamKillValueDecreasePerSecond;

				case 409104006:
					return TeamKillKickForBan;

				case 3644312963:
					return RoundMaxPlayerCount;

				case 1656551901:
					return RoundMinPlayerCount;

				case 3156188847:
					return RoundLockdownCountdown;

				case 1048503553:
					return RoundRestartCountdown;

				case 2371863664:
					return RoundWarmupTimeout;

				case 524064634:
					return BannerUrl;

				case 4054803269:
					return ServerPreset;

				case 2053120230:
					return ServerDescription;

				case 1747142923:
					return ServerAdministrationSettings;

				case 510337326:
					return GameSize;

				case 519997478:
					return ServerAdministrationMapRotation;

				case 3813127178:
					return ServerAdministrationMapRotationInformation;

				case 992248100:
					return ServerAdministrationRoundsPerMap;

				case 2306821231:
					return Spectators;

				case 231433080:
					return PunkBusterVersion;

				case 1639781149:
					return TeamSwitchImbalanceLimit;

				case 2878752685:
					return GameMod;

				case 1333330622:
					return PingSite;

				case 456186673:
					return OverrideServerConfigurationStartTime;

				case 1836263279:
					return GunMasterWeaponsPresetIndex;

				case 2755760498:
					return ServerConfigurationRefreshInterval;

				case 1236403401:
					return DeathmatchFriendZoneFallbackCount;

				case 2629887899:
					return DefaultVoiceChannel;

				case 4008184561:
					return MapSequencerEnabled;

				case 1705443217:
					return KickAPlayerOnVIPJoin;

				case 3176848926:
					return IsManDownRotationEnabled;

				case 3462209494:
					return IsKillerCameraEnabled;

				case 2767215594:
					return PremiumStatus;

				case 2508529624:
					return OverrideAutoBalance;

				case 2626919340:
					return AutoBalance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 294234699:
					return typeof(BFServerSettings).GetProperty(nameof(ServerMessage));

				case 700307892:
					return typeof(BFServerSettings).GetProperty(nameof(CTFRoundTimeModifier));

				case 3026740703:
					return typeof(BFServerSettings).GetProperty(nameof(ForceTeamForPlayerTag));

				case 3689797122:
					return typeof(BFServerSettings).GetProperty(nameof(ForceTeamForPlayerTagTeam));

				case 4167575203:
					return typeof(BFServerSettings).GetProperty(nameof(NoInteractivityTimeoutTime));

				case 1482119343:
					return typeof(BFServerSettings).GetProperty(nameof(NoInteractivityThresholdLimit));

				case 905794337:
					return typeof(BFServerSettings).GetProperty(nameof(NoInteractivityBanRoundCount));

				case 1971523848:
					return typeof(BFServerSettings).GetProperty(nameof(TeamKillCountForKick));

				case 595759392:
					return typeof(BFServerSettings).GetProperty(nameof(TeamKillValueForKick));

				case 3705636661:
					return typeof(BFServerSettings).GetProperty(nameof(TeamKillValueIncrease));

				case 2344261092:
					return typeof(BFServerSettings).GetProperty(nameof(TeamKillValueDecreasePerSecond));

				case 409104006:
					return typeof(BFServerSettings).GetProperty(nameof(TeamKillKickForBan));

				case 3644312963:
					return typeof(BFServerSettings).GetProperty(nameof(RoundMaxPlayerCount));

				case 1656551901:
					return typeof(BFServerSettings).GetProperty(nameof(RoundMinPlayerCount));

				case 3156188847:
					return typeof(BFServerSettings).GetProperty(nameof(RoundLockdownCountdown));

				case 1048503553:
					return typeof(BFServerSettings).GetProperty(nameof(RoundRestartCountdown));

				case 2371863664:
					return typeof(BFServerSettings).GetProperty(nameof(RoundWarmupTimeout));

				case 524064634:
					return typeof(BFServerSettings).GetProperty(nameof(BannerUrl));

				case 4054803269:
					return typeof(BFServerSettings).GetProperty(nameof(ServerPreset));

				case 2053120230:
					return typeof(BFServerSettings).GetProperty(nameof(ServerDescription));

				case 1747142923:
					return typeof(BFServerSettings).GetProperty(nameof(ServerAdministrationSettings));

				case 510337326:
					return typeof(BFServerSettings).GetProperty(nameof(GameSize));

				case 519997478:
					return typeof(BFServerSettings).GetProperty(nameof(ServerAdministrationMapRotation));

				case 3813127178:
					return typeof(BFServerSettings).GetProperty(nameof(ServerAdministrationMapRotationInformation));

				case 992248100:
					return typeof(BFServerSettings).GetProperty(nameof(ServerAdministrationRoundsPerMap));

				case 2306821231:
					return typeof(BFServerSettings).GetProperty(nameof(Spectators));

				case 231433080:
					return typeof(BFServerSettings).GetProperty(nameof(PunkBusterVersion));

				case 1639781149:
					return typeof(BFServerSettings).GetProperty(nameof(TeamSwitchImbalanceLimit));

				case 2878752685:
					return typeof(BFServerSettings).GetProperty(nameof(GameMod));

				case 1333330622:
					return typeof(BFServerSettings).GetProperty(nameof(PingSite));

				case 456186673:
					return typeof(BFServerSettings).GetProperty(nameof(OverrideServerConfigurationStartTime));

				case 1836263279:
					return typeof(BFServerSettings).GetProperty(nameof(GunMasterWeaponsPresetIndex));

				case 2755760498:
					return typeof(BFServerSettings).GetProperty(nameof(ServerConfigurationRefreshInterval));

				case 1236403401:
					return typeof(BFServerSettings).GetProperty(nameof(DeathmatchFriendZoneFallbackCount));

				case 2629887899:
					return typeof(BFServerSettings).GetProperty(nameof(DefaultVoiceChannel));

				case 4008184561:
					return typeof(BFServerSettings).GetProperty(nameof(MapSequencerEnabled));

				case 1705443217:
					return typeof(BFServerSettings).GetProperty(nameof(KickAPlayerOnVIPJoin));

				case 3176848926:
					return typeof(BFServerSettings).GetProperty(nameof(IsManDownRotationEnabled));

				case 3462209494:
					return typeof(BFServerSettings).GetProperty(nameof(IsKillerCameraEnabled));

				case 2767215594:
					return typeof(BFServerSettings).GetProperty(nameof(PremiumStatus));

				case 2508529624:
					return typeof(BFServerSettings).GetProperty(nameof(OverrideAutoBalance));

				case 2626919340:
					return typeof(BFServerSettings).GetProperty(nameof(AutoBalance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
