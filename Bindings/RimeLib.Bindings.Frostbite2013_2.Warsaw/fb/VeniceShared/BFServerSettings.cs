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

using fb.Core;
using fb.GameShared;

namespace fb.VeniceShared;

[ContainerType(8, 320)]
public class BFServerSettings
	: fb.Core.SystemSettings
{
	public BFServerSettings()
	{
		//SystemSettings
		Name = @"BFServer";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string ForceTeamForPlayerTag { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int ForceTeamForPlayerTagTeam { get; set; } = 1;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string ForceSquadForPlayerTag { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int ForceSquadForPlayerTagSquad { get; set; } = 1;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string ForceTeamAndSquadForPlayers { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float NoInteractivityTimeoutTime { get; set; } = 300.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public int NoInteractivityTimeoutPlayerCountPerc { get; set; } = 22;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float NoInteractivityThresholdLimit { get; set; } = 0.100f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public uint NoInteractivityBanRoundCount { get; set; } = 0;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public uint TeamKillCountForKick { get; set; } = 6;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float TeamKillValueForKick { get; set; } = 5.100f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float TeamKillValueIncrease { get; set; } = 1.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float TeamKillValueDecreasePerSecond { get; set; } = 0.050f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public uint TeamKillKickForBan { get; set; } = 3;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public int RoundMaxPlayerCount { get; set; } = -1;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public int RoundMinPlayerCount { get; set; } = -1;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public int RoundLockdownCountdown { get; set; } = 15;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public int RoundRestartCountdown { get; set; } = -1;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public int RoundWarmupTimeout { get; set; } = 600;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public int RoundPlayersReadyPercent { get; set; } = 33;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public int RoundPlayersReadyMinCount { get; set; } = 1;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public int RoundPlayersReadyBypassTimer { get; set; } = 180;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public string BannerUrl { get; set; } = string.Empty;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public string ServerPreset { get; set; } = @"NORMAL";
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public string ServerType { get; set; } = @"RANKED";
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public string ServerExperience { get; set; } = string.Empty;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public string ServerDescription { get; set; } = string.Empty;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public string ServerMessage { get; set; } = string.Empty;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public string ServerAdministrationSettings { get; set; } = string.Empty;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public string ServerAdministrationMapRotation { get; set; } = string.Empty;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public string ServerAdministrationMapRotationInformation { get; set; } = string.Empty;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public string Spectators { get; set; } = string.Empty;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public string PunkBusterVersion { get; set; } = string.Empty;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public uint TeamSwitchImbalanceLimit { get; set; } = 2;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public uint GameSize { get; set; } = 0;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public string GameMod { get; set; } = string.Empty;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public VoiceChannel DefaultVoiceChannel { get; set; } = VoiceChannel.VoiceChannel_Team;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public int DeathmatchFriendZoneFallbackCount { get; set; } = -1;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public int ServerConfigurationRefreshInterval { get; set; } = -1;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public string OverrideServerConfigurationStartTime { get; set; } = string.Empty;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float AlternateEORTimeout { get; set; } = -1.000f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public int MaxNumSoldierCorpses { get; set; } = 10;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public int CommanderRankThreshold { get; set; } = 10;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public float TicketBleedRateModifier { get; set; } = 1.000f;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float BackendConnectDelay { get; set; } = 0.000f;
	
	[ContainerField(0x128), JsonProperty(Order = 296)]
	public List<string> DisabledLevels { get; set; } = new();
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public uint GunMasterWeaponsPresetIndex { get; set; } = 0;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public bool AutoBalance { get; set; } = true;
	
	[ContainerField(0x135), LayoutImmutable, Blittable, JsonProperty(Order = 309)]
	public bool OverrideAutoBalance { get; set; } = false;
	
	[ContainerField(0x136), LayoutImmutable, Blittable, JsonProperty(Order = 310)]
	public bool UseSkillBasedBalancing { get; set; } = false;
	
	[ContainerField(0x137), LayoutImmutable, Blittable, JsonProperty(Order = 311)]
	public bool DisableBattlePickups { get; set; } = false;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public bool IsManDownRotationEnabled { get; set; } = true;
	
	[ContainerField(0x139), LayoutImmutable, Blittable, JsonProperty(Order = 313)]
	public bool IsKillerCameraEnabled { get; set; } = true;
	
	[ContainerField(0x13a), LayoutImmutable, Blittable, JsonProperty(Order = 314)]
	public bool MapSequencerEnabled { get; set; } = true;
	
	[ContainerField(0x13b), LayoutImmutable, Blittable, JsonProperty(Order = 315)]
	public bool KickAPlayerOnVIPJoin { get; set; } = false;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public bool AlwaysAllowedToSpectate { get; set; } = false;
	
	[ContainerField(0x13d), LayoutImmutable, Blittable, JsonProperty(Order = 317)]
	public bool DataSanityCheckEnabled { get; set; } = false;
	
	[ContainerField(0x13e), LayoutImmutable, Blittable, JsonProperty(Order = 318)]
	public bool HostEjectionOnMapRotationChangeEnabled { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ForceTeamForPlayerTag));
		p_Writer.Write(ForceTeamForPlayerTagTeam);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(ForceSquadForPlayerTag));
		p_Writer.Write(ForceSquadForPlayerTagSquad);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(ForceTeamAndSquadForPlayers));
		p_Writer.Write(NoInteractivityTimeoutTime);
		p_Writer.Write(NoInteractivityTimeoutPlayerCountPerc);
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
		p_Writer.Write(RoundPlayersReadyPercent);
		p_Writer.Write(RoundPlayersReadyMinCount);
		p_Writer.Write(RoundPlayersReadyBypassTimer);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(BannerUrl));
		p_Writer.Write(p_EbxWriter.WriteString(ServerPreset));
		p_Writer.Write(p_EbxWriter.WriteString(ServerType));
		p_Writer.Write(p_EbxWriter.WriteString(ServerExperience));
		p_Writer.Write(p_EbxWriter.WriteString(ServerDescription));
		p_Writer.Write(p_EbxWriter.WriteString(ServerMessage));
		p_Writer.Write(p_EbxWriter.WriteString(ServerAdministrationSettings));
		p_Writer.Write(p_EbxWriter.WriteString(ServerAdministrationMapRotation));
		p_Writer.Write(p_EbxWriter.WriteString(ServerAdministrationMapRotationInformation));
		p_Writer.Write(p_EbxWriter.WriteString(Spectators));
		p_Writer.Write(p_EbxWriter.WriteString(PunkBusterVersion));
		p_Writer.Write(TeamSwitchImbalanceLimit);
		p_Writer.Write(GameSize);
		p_Writer.Write(p_EbxWriter.WriteString(GameMod));
		p_Writer.Write((int) DefaultVoiceChannel);
		p_Writer.Write(DeathmatchFriendZoneFallbackCount);
		p_Writer.Write(ServerConfigurationRefreshInterval);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(OverrideServerConfigurationStartTime));
		p_Writer.Write(AlternateEORTimeout);
		p_Writer.Write(MaxNumSoldierCorpses);
		p_Writer.Write(CommanderRankThreshold);
		p_Writer.Write(TicketBleedRateModifier);
		p_Writer.Write(BackendConnectDelay);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_DisabledLevels = p_EbxWriter.GetArrayWriter(DisabledLevels.GetType(), DisabledLevels.Count);
		p_Writer.Write(s_DisabledLevels.ArrayIndex);
		foreach (var s_Entry in DisabledLevels)
		{
			s_DisabledLevels.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(GunMasterWeaponsPresetIndex);
		p_Writer.Write(AutoBalance);
		p_Writer.Write(OverrideAutoBalance);
		p_Writer.Write(UseSkillBasedBalancing);
		p_Writer.Write(DisableBattlePickups);
		p_Writer.Write(IsManDownRotationEnabled);
		p_Writer.Write(IsKillerCameraEnabled);
		p_Writer.Write(MapSequencerEnabled);
		p_Writer.Write(KickAPlayerOnVIPJoin);
		p_Writer.Write(AlwaysAllowedToSpectate);
		p_Writer.Write(DataSanityCheckEnabled);
		p_Writer.Write(HostEjectionOnMapRotationChangeEnabled);
		p_Writer.WriteNullBytes(1);
	}
}

