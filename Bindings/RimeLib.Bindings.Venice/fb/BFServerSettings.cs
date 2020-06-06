///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class BFServerSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable]
		public string ServerMessage { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float CTFRoundTimeModifier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string ForceTeamForPlayerTag { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int ForceTeamForPlayerTagTeam { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float NoInteractivityTimeoutTime { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float NoInteractivityThresholdLimit { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint NoInteractivityBanRoundCount { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint TeamKillCountForKick { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float TeamKillValueForKick { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float TeamKillValueIncrease { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float TeamKillValueDecreasePerSecond { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public uint TeamKillKickForBan { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public int RoundMaxPlayerCount { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public int RoundMinPlayerCount { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public int RoundLockdownCountdown { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public int RoundRestartCountdown { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public int RoundWarmupTimeout { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable]
		public string BannerUrl { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable]
		public string ServerPreset { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable]
		public string ServerDescription { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable]
		public string ServerAdministrationSettings { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public uint GameSize { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable]
		public string ServerAdministrationMapRotation { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable]
		public string ServerAdministrationMapRotationInformation { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public uint ServerAdministrationRoundsPerMap { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable]
		public string Spectators { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable]
		public string PunkBusterVersion { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public uint TeamSwitchImbalanceLimit { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable]
		public string GameMod { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable]
		public string PingSite { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable]
		public string OverrideServerConfigurationStartTime { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public uint GunMasterWeaponsPresetIndex { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public int ServerConfigurationRefreshInterval { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public int DeathmatchFriendZoneFallbackCount { get; set; } // 0x90 (144)
		
		[ContainerField(148)]
		public VoiceChannel DefaultVoiceChannel { get; set; } = new VoiceChannel(); // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public bool MapSequencerEnabled { get; set; } // 0x98 (152)
		
		[ContainerField(153), LayoutImmutable, Blittable]
		public bool KickAPlayerOnVIPJoin { get; set; } // 0x99 (153)
		
		[ContainerField(154), LayoutImmutable, Blittable]
		public bool IsManDownRotationEnabled { get; set; } // 0x9A (154)
		
		[ContainerField(155), LayoutImmutable, Blittable]
		public bool IsKillerCameraEnabled { get; set; } // 0x9B (155)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public bool PremiumStatus { get; set; } // 0x9C (156)
		
		[ContainerField(157), LayoutImmutable, Blittable]
		public bool OverrideAutoBalance { get; set; } // 0x9D (157)
		
		[ContainerField(158), LayoutImmutable, Blittable]
		public bool AutoBalance { get; set; } // 0x9E (158)
		
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
