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
	[ContainerType(4, 160)]
	public class BFServerSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable]
		public string ServerMessage { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable]
		public float CTFRoundTimeModifier { get; set; }

		[ContainerField(20), LayoutImmutable]
		public string ForceTeamForPlayerTag { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable]
		public int ForceTeamForPlayerTagTeam { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float NoInteractivityTimeoutTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float NoInteractivityThresholdLimit { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint NoInteractivityBanRoundCount { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint TeamKillCountForKick { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float TeamKillValueForKick { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float TeamKillValueIncrease { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float TeamKillValueDecreasePerSecond { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public uint TeamKillKickForBan { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public int RoundMaxPlayerCount { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public int RoundMinPlayerCount { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public int RoundLockdownCountdown { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public int RoundRestartCountdown { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public int RoundWarmupTimeout { get; set; }

		[ContainerField(80), LayoutImmutable]
		public string BannerUrl { get; set; } = string.Empty;

		[ContainerField(84), LayoutImmutable]
		public string ServerPreset { get; set; } = string.Empty;

		[ContainerField(88), LayoutImmutable]
		public string ServerDescription { get; set; } = string.Empty;

		[ContainerField(92), LayoutImmutable]
		public string ServerAdministrationSettings { get; set; } = string.Empty;

		[ContainerField(96), LayoutImmutable, Blittable]
		public uint GameSize { get; set; }

		[ContainerField(100), LayoutImmutable]
		public string ServerAdministrationMapRotation { get; set; } = string.Empty;

		[ContainerField(104), LayoutImmutable]
		public string ServerAdministrationMapRotationInformation { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, Blittable]
		public uint ServerAdministrationRoundsPerMap { get; set; }

		[ContainerField(112), LayoutImmutable]
		public string Spectators { get; set; } = string.Empty;

		[ContainerField(116), LayoutImmutable]
		public string PunkBusterVersion { get; set; } = string.Empty;

		[ContainerField(120), LayoutImmutable, Blittable]
		public uint TeamSwitchImbalanceLimit { get; set; }

		[ContainerField(124), LayoutImmutable]
		public string GameMod { get; set; } = string.Empty;

		[ContainerField(128), LayoutImmutable]
		public string PingSite { get; set; } = string.Empty;

		[ContainerField(132), LayoutImmutable]
		public string OverrideServerConfigurationStartTime { get; set; } = string.Empty;

		[ContainerField(136), LayoutImmutable, Blittable]
		public uint GunMasterWeaponsPresetIndex { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public int ServerConfigurationRefreshInterval { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public int DeathmatchFriendZoneFallbackCount { get; set; }

		[ContainerField(148)]
		public VoiceChannel DefaultVoiceChannel { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable]
		public bool MapSequencerEnabled { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable]
		public bool KickAPlayerOnVIPJoin { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable]
		public bool IsManDownRotationEnabled { get; set; }

		[ContainerField(155), LayoutImmutable, Blittable]
		public bool IsKillerCameraEnabled { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public bool PremiumStatus { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable]
		public bool OverrideAutoBalance { get; set; }

		[ContainerField(158), LayoutImmutable, Blittable]
		public bool AutoBalance { get; set; }

		public static void Deserialize(BFServerSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ServerMessage = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.CTFRoundTimeModifier = p_Reader.ReadSingle();
			p_Instance.ForceTeamForPlayerTag = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ForceTeamForPlayerTagTeam = p_Reader.ReadInt32();
			p_Instance.NoInteractivityTimeoutTime = p_Reader.ReadSingle();
			p_Instance.NoInteractivityThresholdLimit = p_Reader.ReadSingle();
			p_Instance.NoInteractivityBanRoundCount = p_Reader.ReadUInt32();
			p_Instance.TeamKillCountForKick = p_Reader.ReadUInt32();
			p_Instance.TeamKillValueForKick = p_Reader.ReadSingle();
			p_Instance.TeamKillValueIncrease = p_Reader.ReadSingle();
			p_Instance.TeamKillValueDecreasePerSecond = p_Reader.ReadSingle();
			p_Instance.TeamKillKickForBan = p_Reader.ReadUInt32();
			p_Instance.RoundMaxPlayerCount = p_Reader.ReadInt32();
			p_Instance.RoundMinPlayerCount = p_Reader.ReadInt32();
			p_Instance.RoundLockdownCountdown = p_Reader.ReadInt32();
			p_Instance.RoundRestartCountdown = p_Reader.ReadInt32();
			p_Instance.RoundWarmupTimeout = p_Reader.ReadInt32();
			p_Instance.BannerUrl = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ServerPreset = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ServerDescription = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ServerAdministrationSettings = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.GameSize = p_Reader.ReadUInt32();
			p_Instance.ServerAdministrationMapRotation = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ServerAdministrationMapRotationInformation = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ServerAdministrationRoundsPerMap = p_Reader.ReadUInt32();
			p_Instance.Spectators = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.PunkBusterVersion = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.TeamSwitchImbalanceLimit = p_Reader.ReadUInt32();
			p_Instance.GameMod = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.PingSite = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.OverrideServerConfigurationStartTime = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.GunMasterWeaponsPresetIndex = p_Reader.ReadUInt32();
			p_Instance.ServerConfigurationRefreshInterval = p_Reader.ReadInt32();
			p_Instance.DeathmatchFriendZoneFallbackCount = p_Reader.ReadInt32();
			p_Instance.DefaultVoiceChannel = (VoiceChannel) p_Reader.ReadInt32();
			p_Instance.MapSequencerEnabled = p_Reader.ReadBool();
			p_Instance.KickAPlayerOnVIPJoin = p_Reader.ReadBool();
			p_Instance.IsManDownRotationEnabled = p_Reader.ReadBool();
			p_Instance.IsKillerCameraEnabled = p_Reader.ReadBool();
			p_Instance.PremiumStatus = p_Reader.ReadBool();
			p_Instance.OverrideAutoBalance = p_Reader.ReadBool();
			p_Instance.AutoBalance = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
