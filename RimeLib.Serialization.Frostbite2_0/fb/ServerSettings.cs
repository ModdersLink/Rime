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
	[ContainerType(4, 180)]
	public class ServerSettings :
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string InstancePath { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint RemoteControlPort { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float DuplicationChance { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint MaxQueriesPerSecond { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float CorruptionChance { get; set; }

		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string RemoteAdministrationPort { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float MaxDropDuration { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float ReorderingChance { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float HumanHealthMultiplier { get; set; }

		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string ServerName { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float MinDropDuration { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public uint SaveGameVersion { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float PacketDrops { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float DropSpikeChance { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float MaxLatency { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public uint OutgoingRate { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public uint IncomingRate { get; set; }

		[ContainerField(80), LayoutImmutable, JsonProperty(Order = 80)]
		public string Playlist { get; set; } = string.Empty;

		[ContainerField(84), LayoutImmutable, JsonProperty(Order = 84)]
		public string SavePoint { get; set; } = string.Empty;

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float IngameTimeout { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float OutgoingFrequency { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float RespawnTimeModifier { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float MinLatency { get; set; }

		[ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		public string ServerPassword { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float TimeoutTime { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public uint PlayerCountNeededForMultiplayer { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float VehicleSpawnDelayModifier { get; set; }

		[ContainerField(120), LayoutImmutable, JsonProperty(Order = 120)]
		public string DebugMenuClick { get; set; } = string.Empty;

		[ContainerField(124), LayoutImmutable, JsonProperty(Order = 124)]
		public string AdministrationPassword { get; set; } = string.Empty;

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float LoadingTimeout { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public int DedicatedServerCpu { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public bool DeathmatchDebugInfo { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		public bool TimeoutGame { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		public bool AILooksIntoCamera { get; set; }

		[ContainerField(139), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
		public bool IsStatsEnabled { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public bool IsTreeDestructionEnabled { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		public bool HavokCaptureToFile { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		public bool ShowTriggerDebugText { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		public bool IsInternetSimulationEnabled { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public bool DisableCutscenes { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		public bool JobEnable { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
		public bool ThreadingEnable { get; set; }

		[ContainerField(147), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
		public bool DrawActivePhysicsObjects { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public bool IsRanked { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		public bool UnlockResolver { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		public bool ScoringLogEnabled { get; set; }

		[ContainerField(151), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
		public bool HavokVisualDebugger { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public bool IsSoldierDetailedCollisionEnabled { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		public bool LoadSavePoint { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		public bool IsSoldierAnimationEnabled { get; set; }

		[ContainerField(155), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
		public bool IsAiEnabled { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public bool IsReconfigurable { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		public bool IsDestructionEnabled { get; set; }

		[ContainerField(158), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
		public bool ForcePlaylist { get; set; }

		[ContainerField(159), LayoutImmutable, Blittable, JsonProperty(Order = 159)]
		public bool IsNetworkStatsEnabled { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public bool AutoUnspawnBangers { get; set; }

		[ContainerField(161), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
		public bool RegulatedAIThrottle { get; set; }

		[ContainerField(162), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
		public bool EnableAnimationCulling { get; set; }

		[ContainerField(163), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
		public bool FallBackToSquadSpawn { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public bool AllowIndestructibleParts { get; set; }

		[ContainerField(165), LayoutImmutable, Blittable, JsonProperty(Order = 165)]
		public bool IsPresenceEnabled { get; set; }

		[ContainerField(166), LayoutImmutable, Blittable, JsonProperty(Order = 166)]
		public bool WaterPhysicsEnabled { get; set; }

		[ContainerField(167), LayoutImmutable, Blittable, JsonProperty(Order = 167)]
		public bool RespawnOnDeathPosition { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public bool IsRenderDamageEvents { get; set; }

		[ContainerField(169), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
		public bool VehicleSpawnAllowed { get; set; }

		[ContainerField(170), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
		public bool QueryProviderEnabled { get; set; }

		[ContainerField(171), LayoutImmutable, Blittable, JsonProperty(Order = 171)]
		public bool IsDesertingAllowed { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public bool DebrisClusterEnabled { get; set; }

		[ContainerField(173), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
		public bool AdministrationEnabled { get; set; }

		[ContainerField(174), LayoutImmutable, Blittable, JsonProperty(Order = 174)]
		public bool AdministrationLogEnabled { get; set; }

		[ContainerField(175), LayoutImmutable, Blittable, JsonProperty(Order = 175)]
		public bool AdministrationTimeStampLogNames { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public bool AdministrationEventsEnabled { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
		public bool AdministrationServerNameRestricted { get; set; }

		[ContainerField(178), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
		public bool ThreadedLoadingEnable { get; set; }

		[ContainerField(179), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
		public bool VegetationEnabled { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(InstancePath));
			p_Writer.Write(RemoteControlPort);
			p_Writer.Write(DuplicationChance);
			p_Writer.Write(MaxQueriesPerSecond);
			p_Writer.Write(CorruptionChance);
			p_Writer.Write(p_EbxWriter.WriteString(RemoteAdministrationPort));
			p_Writer.Write(MaxDropDuration);
			p_Writer.Write(ReorderingChance);
			p_Writer.Write(HumanHealthMultiplier);
			p_Writer.Write(p_EbxWriter.WriteString(ServerName));
			p_Writer.Write(MinDropDuration);
			p_Writer.Write(SaveGameVersion);
			p_Writer.Write(PacketDrops);
			p_Writer.Write(DropSpikeChance);
			p_Writer.Write(MaxLatency);
			p_Writer.Write(OutgoingRate);
			p_Writer.Write(IncomingRate);
			p_Writer.Write(p_EbxWriter.WriteString(Playlist));
			p_Writer.Write(p_EbxWriter.WriteString(SavePoint));
			p_Writer.Write(IngameTimeout);
			p_Writer.Write(OutgoingFrequency);
			p_Writer.Write(RespawnTimeModifier);
			p_Writer.Write(MinLatency);
			p_Writer.Write(p_EbxWriter.WriteString(ServerPassword));
			p_Writer.Write(TimeoutTime);
			p_Writer.Write(PlayerCountNeededForMultiplayer);
			p_Writer.Write(VehicleSpawnDelayModifier);
			p_Writer.Write(p_EbxWriter.WriteString(DebugMenuClick));
			p_Writer.Write(p_EbxWriter.WriteString(AdministrationPassword));
			p_Writer.Write(LoadingTimeout);
			p_Writer.Write(DedicatedServerCpu);
			p_Writer.Write(DeathmatchDebugInfo);
			p_Writer.Write(TimeoutGame);
			p_Writer.Write(AILooksIntoCamera);
			p_Writer.Write(IsStatsEnabled);
			p_Writer.Write(IsTreeDestructionEnabled);
			p_Writer.Write(HavokCaptureToFile);
			p_Writer.Write(ShowTriggerDebugText);
			p_Writer.Write(IsInternetSimulationEnabled);
			p_Writer.Write(DisableCutscenes);
			p_Writer.Write(JobEnable);
			p_Writer.Write(ThreadingEnable);
			p_Writer.Write(DrawActivePhysicsObjects);
			p_Writer.Write(IsRanked);
			p_Writer.Write(UnlockResolver);
			p_Writer.Write(ScoringLogEnabled);
			p_Writer.Write(HavokVisualDebugger);
			p_Writer.Write(IsSoldierDetailedCollisionEnabled);
			p_Writer.Write(LoadSavePoint);
			p_Writer.Write(IsSoldierAnimationEnabled);
			p_Writer.Write(IsAiEnabled);
			p_Writer.Write(IsReconfigurable);
			p_Writer.Write(IsDestructionEnabled);
			p_Writer.Write(ForcePlaylist);
			p_Writer.Write(IsNetworkStatsEnabled);
			p_Writer.Write(AutoUnspawnBangers);
			p_Writer.Write(RegulatedAIThrottle);
			p_Writer.Write(EnableAnimationCulling);
			p_Writer.Write(FallBackToSquadSpawn);
			p_Writer.Write(AllowIndestructibleParts);
			p_Writer.Write(IsPresenceEnabled);
			p_Writer.Write(WaterPhysicsEnabled);
			p_Writer.Write(RespawnOnDeathPosition);
			p_Writer.Write(IsRenderDamageEvents);
			p_Writer.Write(VehicleSpawnAllowed);
			p_Writer.Write(QueryProviderEnabled);
			p_Writer.Write(IsDesertingAllowed);
			p_Writer.Write(DebrisClusterEnabled);
			p_Writer.Write(AdministrationEnabled);
			p_Writer.Write(AdministrationLogEnabled);
			p_Writer.Write(AdministrationTimeStampLogNames);
			p_Writer.Write(AdministrationEventsEnabled);
			p_Writer.Write(AdministrationServerNameRestricted);
			p_Writer.Write(ThreadedLoadingEnable);
			p_Writer.Write(VegetationEnabled);
		}
	}
}
