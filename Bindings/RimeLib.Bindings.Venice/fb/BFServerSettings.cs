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
	[ContainerType(4, 160)]
	public class BFServerSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string ServerMessage { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float CTFRoundTimeModifier { get; set; }

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string ForceTeamForPlayerTag { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int ForceTeamForPlayerTagTeam { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float NoInteractivityTimeoutTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float NoInteractivityThresholdLimit { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint NoInteractivityBanRoundCount { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public uint TeamKillCountForKick { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float TeamKillValueForKick { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float TeamKillValueIncrease { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float TeamKillValueDecreasePerSecond { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public uint TeamKillKickForBan { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public int RoundMaxPlayerCount { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public int RoundMinPlayerCount { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public int RoundLockdownCountdown { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public int RoundRestartCountdown { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public int RoundWarmupTimeout { get; set; }

		[ContainerField(80), LayoutImmutable, JsonProperty(Order = 80)]
		public string BannerUrl { get; set; } = string.Empty;

		[ContainerField(84), LayoutImmutable, JsonProperty(Order = 84)]
		public string ServerPreset { get; set; } = string.Empty;

		[ContainerField(88), LayoutImmutable, JsonProperty(Order = 88)]
		public string ServerDescription { get; set; } = string.Empty;

		[ContainerField(92), LayoutImmutable, JsonProperty(Order = 92)]
		public string ServerAdministrationSettings { get; set; } = string.Empty;

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public uint GameSize { get; set; }

		[ContainerField(100), LayoutImmutable, JsonProperty(Order = 100)]
		public string ServerAdministrationMapRotation { get; set; } = string.Empty;

		[ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		public string ServerAdministrationMapRotationInformation { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public uint ServerAdministrationRoundsPerMap { get; set; }

		[ContainerField(112), LayoutImmutable, JsonProperty(Order = 112)]
		public string Spectators { get; set; } = string.Empty;

		[ContainerField(116), LayoutImmutable, JsonProperty(Order = 116)]
		public string PunkBusterVersion { get; set; } = string.Empty;

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public uint TeamSwitchImbalanceLimit { get; set; }

		[ContainerField(124), LayoutImmutable, JsonProperty(Order = 124)]
		public string GameMod { get; set; } = string.Empty;

		[ContainerField(128), LayoutImmutable, JsonProperty(Order = 128)]
		public string PingSite { get; set; } = string.Empty;

		[ContainerField(132), LayoutImmutable, JsonProperty(Order = 132)]
		public string OverrideServerConfigurationStartTime { get; set; } = string.Empty;

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public uint GunMasterWeaponsPresetIndex { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public int ServerConfigurationRefreshInterval { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public int DeathmatchFriendZoneFallbackCount { get; set; }

		[ContainerField(148), JsonProperty(Order = 148)]
		public VoiceChannel DefaultVoiceChannel { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public bool MapSequencerEnabled { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		public bool KickAPlayerOnVIPJoin { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		public bool IsManDownRotationEnabled { get; set; }

		[ContainerField(155), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
		public bool IsKillerCameraEnabled { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public bool PremiumStatus { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		public bool OverrideAutoBalance { get; set; }

		[ContainerField(158), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
		public bool AutoBalance { get; set; }

	}
}
