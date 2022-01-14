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
using RimeLib.Serialization.Frostbite2_0.Ebx;

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
