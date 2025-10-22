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

namespace fb.GameShared;

[ContainerType(8, 288)]
public class ServerSettings
	: fb.Core.SystemSettings
{
	public ServerSettings()
	{
		//SystemSettings
		Name = @"Server";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string InstancePath { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint RemoteControlPort { get; set; } = 0;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string SavePoint { get; set; } = @"1st";
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float TimeoutTime { get; set; } = 600.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public uint PlayerCountNeededForMultiplayer { get; set; } = 8;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string DebugMenuClick { get; set; } = string.Empty;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CongestionControlSettings CongestionCtrl { get; set; } = new();
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float FrameHistoryTime { get; set; } = 1.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float FrameHistoryTimeSoldiers { get; set; } = 0.125f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float LoadingTimeout { get; set; } = 15.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float IngameTimeout { get; set; } = 15.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float OutgoingFrequency { get; set; } = 15.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float OutgoingHighFrequency { get; set; } = 30.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float OutgoingHighFrequencyRconCap { get; set; } = 30.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public uint IncomingRate { get; set; } = 30000;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public uint OutgoingRate { get; set; } = 80000;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public uint OutgoingHighFrequencyRate { get; set; } = 0;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public string Playlist { get; set; } = @"Default";
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public int DedicatedServerCpu { get; set; } = -1;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public uint SaveGameVersion { get; set; } = 3;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public string ServerName { get; set; } = string.Empty;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public string ServerPassword { get; set; } = string.Empty;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float VehicleSpawnDelayModifier { get; set; } = 1.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float HumanHealthMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float RespawnTimeModifier { get; set; } = 1.000f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public string AdministrationPassword { get; set; } = string.Empty;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public string RemoteAdministrationPort { get; set; } = string.Empty;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float ServerFpsLowThresholdPerc { get; set; } = 1.000f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float ServerFpsLowThresholdCritPerc { get; set; } = 0.920f;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float ServerFpsStallThreshold { get; set; } = 100.000f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public bool DebrisClusterEnabled { get; set; } = true;
	
	[ContainerField(0xf5), LayoutImmutable, Blittable, JsonProperty(Order = 245)]
	public bool VegetationEnabled { get; set; } = true;
	
	[ContainerField(0xf6), LayoutImmutable, Blittable, JsonProperty(Order = 246)]
	public bool WaterPhysicsEnabled { get; set; } = true;
	
	[ContainerField(0xf7), LayoutImmutable, Blittable, JsonProperty(Order = 247)]
	public bool IsDesertingAllowed { get; set; } = false;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public bool IsRenderDamageEvents { get; set; } = false;
	
	[ContainerField(0xf9), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
	public bool RespawnOnDeathPosition { get; set; } = false;
	
	[ContainerField(0xfa), LayoutImmutable, Blittable, JsonProperty(Order = 250)]
	public bool IsStatsEnabled { get; set; } = false;
	
	[ContainerField(0xfb), LayoutImmutable, Blittable, JsonProperty(Order = 251)]
	public bool IsNetworkStatsEnabled { get; set; } = false;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public bool IsAiEnabled { get; set; } = true;
	
	[ContainerField(0xfd), LayoutImmutable, Blittable, JsonProperty(Order = 253)]
	public bool IsDestructionEnabled { get; set; } = true;
	
	[ContainerField(0xfe), LayoutImmutable, Blittable, JsonProperty(Order = 254)]
	public bool IsSoldierAnimationEnabled { get; set; } = true;
	
	[ContainerField(0xff), LayoutImmutable, Blittable, JsonProperty(Order = 255)]
	public bool IsSoldierDetailedCollisionEnabled { get; set; } = false;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public bool LoadSavePoint { get; set; } = false;
	
	[ContainerField(0x101), LayoutImmutable, Blittable, JsonProperty(Order = 257)]
	public bool DisableCutscenes { get; set; } = false;
	
	[ContainerField(0x102), LayoutImmutable, Blittable, JsonProperty(Order = 258)]
	public bool HavokVisualDebugger { get; set; } = false;
	
	[ContainerField(0x103), LayoutImmutable, Blittable, JsonProperty(Order = 259)]
	public bool HavokCaptureToFile { get; set; } = false;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public bool ShowTriggerDebugText { get; set; } = false;
	
	[ContainerField(0x105), LayoutImmutable, Blittable, JsonProperty(Order = 261)]
	public bool TimeoutGame { get; set; } = false;
	
	[ContainerField(0x106), LayoutImmutable, Blittable, JsonProperty(Order = 262)]
	public bool AILooksIntoCamera { get; set; } = true;
	
	[ContainerField(0x107), LayoutImmutable, Blittable, JsonProperty(Order = 263)]
	public bool DeathmatchDebugInfo { get; set; } = false;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public bool JobEnable { get; set; } = true;
	
	[ContainerField(0x109), LayoutImmutable, Blittable, JsonProperty(Order = 265)]
	public bool ThreadingEnable { get; set; } = false;
	
	[ContainerField(0x10a), LayoutImmutable, Blittable, JsonProperty(Order = 266)]
	public bool DrawActivePhysicsObjects { get; set; } = false;
	
	[ContainerField(0x10b), LayoutImmutable, Blittable, JsonProperty(Order = 267)]
	public bool IsRanked { get; set; } = true;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public bool UnlockResolver { get; set; } = false;
	
	[ContainerField(0x10d), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
	public bool ScoringLogEnabled { get; set; } = false;
	
	[ContainerField(0x10e), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
	public bool HighFrequencyUpdateEnabled { get; set; } = false;
	
	[ContainerField(0x10f), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
	public bool HighFrequencyUpdateAllowedOnGen3 { get; set; } = false;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public bool ServerStallSmoothingEnabled { get; set; } = true;
	
	[ContainerField(0x111), LayoutImmutable, Blittable, JsonProperty(Order = 273)]
	public bool TrialAccountOnUnofficialKick { get; set; } = true;
	
	[ContainerField(0x112), LayoutImmutable, Blittable, JsonProperty(Order = 274)]
	public bool ForcePlaylist { get; set; } = false;
	
	[ContainerField(0x113), LayoutImmutable, Blittable, JsonProperty(Order = 275)]
	public bool AutoUnspawnBangers { get; set; } = true;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public bool RegulatedAIThrottle { get; set; } = true;
	
	[ContainerField(0x115), LayoutImmutable, Blittable, JsonProperty(Order = 277)]
	public bool EnableAnimationCulling { get; set; } = false;
	
	[ContainerField(0x116), LayoutImmutable, Blittable, JsonProperty(Order = 278)]
	public bool FallBackToSquadSpawn { get; set; } = false;
	
	[ContainerField(0x117), LayoutImmutable, Blittable, JsonProperty(Order = 279)]
	public bool VehicleSpawnAllowed { get; set; } = true;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public bool AdministrationEnabled { get; set; } = true;
	
	[ContainerField(0x119), LayoutImmutable, Blittable, JsonProperty(Order = 281)]
	public bool AdministrationLogEnabled { get; set; } = false;
	
	[ContainerField(0x11a), LayoutImmutable, Blittable, JsonProperty(Order = 282)]
	public bool AdministrationTimeStampLogNames { get; set; } = false;
	
	[ContainerField(0x11b), LayoutImmutable, Blittable, JsonProperty(Order = 283)]
	public bool AdministrationEventsEnabled { get; set; } = false;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public bool AdministrationServerNameRestricted { get; set; } = false;
	
	[ContainerField(0x11d), LayoutImmutable, Blittable, JsonProperty(Order = 285)]
	public bool ServerSidePatchingEnabled { get; set; } = true;
	
	[ContainerField(0x11e), LayoutImmutable, Blittable, JsonProperty(Order = 286)]
	public bool EnableServerFpsTracking { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(InstancePath));
		p_Writer.Write(RemoteControlPort);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(SavePoint));
		p_Writer.Write(TimeoutTime);
		p_Writer.Write(PlayerCountNeededForMultiplayer);
		p_Writer.Write(p_EbxWriter.WriteString(DebugMenuClick));
		CongestionCtrl.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FrameHistoryTime);
		p_Writer.Write(FrameHistoryTimeSoldiers);
		p_Writer.Write(LoadingTimeout);
		p_Writer.Write(IngameTimeout);
		p_Writer.Write(OutgoingFrequency);
		p_Writer.Write(OutgoingHighFrequency);
		p_Writer.Write(OutgoingHighFrequencyRconCap);
		p_Writer.Write(IncomingRate);
		p_Writer.Write(OutgoingRate);
		p_Writer.Write(OutgoingHighFrequencyRate);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(Playlist));
		p_Writer.Write(DedicatedServerCpu);
		p_Writer.Write(SaveGameVersion);
		p_Writer.Write(p_EbxWriter.WriteString(ServerName));
		p_Writer.Write(p_EbxWriter.WriteString(ServerPassword));
		p_Writer.Write(VehicleSpawnDelayModifier);
		p_Writer.Write(HumanHealthMultiplier);
		p_Writer.Write(RespawnTimeModifier);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(AdministrationPassword));
		p_Writer.Write(p_EbxWriter.WriteString(RemoteAdministrationPort));
		p_Writer.Write(ServerFpsLowThresholdPerc);
		p_Writer.Write(ServerFpsLowThresholdCritPerc);
		p_Writer.Write(ServerFpsStallThreshold);
		p_Writer.Write(DebrisClusterEnabled);
		p_Writer.Write(VegetationEnabled);
		p_Writer.Write(WaterPhysicsEnabled);
		p_Writer.Write(IsDesertingAllowed);
		p_Writer.Write(IsRenderDamageEvents);
		p_Writer.Write(RespawnOnDeathPosition);
		p_Writer.Write(IsStatsEnabled);
		p_Writer.Write(IsNetworkStatsEnabled);
		p_Writer.Write(IsAiEnabled);
		p_Writer.Write(IsDestructionEnabled);
		p_Writer.Write(IsSoldierAnimationEnabled);
		p_Writer.Write(IsSoldierDetailedCollisionEnabled);
		p_Writer.Write(LoadSavePoint);
		p_Writer.Write(DisableCutscenes);
		p_Writer.Write(HavokVisualDebugger);
		p_Writer.Write(HavokCaptureToFile);
		p_Writer.Write(ShowTriggerDebugText);
		p_Writer.Write(TimeoutGame);
		p_Writer.Write(AILooksIntoCamera);
		p_Writer.Write(DeathmatchDebugInfo);
		p_Writer.Write(JobEnable);
		p_Writer.Write(ThreadingEnable);
		p_Writer.Write(DrawActivePhysicsObjects);
		p_Writer.Write(IsRanked);
		p_Writer.Write(UnlockResolver);
		p_Writer.Write(ScoringLogEnabled);
		p_Writer.Write(HighFrequencyUpdateEnabled);
		p_Writer.Write(HighFrequencyUpdateAllowedOnGen3);
		p_Writer.Write(ServerStallSmoothingEnabled);
		p_Writer.Write(TrialAccountOnUnofficialKick);
		p_Writer.Write(ForcePlaylist);
		p_Writer.Write(AutoUnspawnBangers);
		p_Writer.Write(RegulatedAIThrottle);
		p_Writer.Write(EnableAnimationCulling);
		p_Writer.Write(FallBackToSquadSpawn);
		p_Writer.Write(VehicleSpawnAllowed);
		p_Writer.Write(AdministrationEnabled);
		p_Writer.Write(AdministrationLogEnabled);
		p_Writer.Write(AdministrationTimeStampLogNames);
		p_Writer.Write(AdministrationEventsEnabled);
		p_Writer.Write(AdministrationServerNameRestricted);
		p_Writer.Write(ServerSidePatchingEnabled);
		p_Writer.Write(EnableServerFpsTracking);
		p_Writer.WriteNullBytes(1);
	}
}

