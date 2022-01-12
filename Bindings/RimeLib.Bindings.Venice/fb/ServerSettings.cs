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
	[ContainerType(4, 180)]
	public class ServerSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable]
		public string InstancePath { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint RemoteControlPort { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float DuplicationChance { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MaxQueriesPerSecond { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float CorruptionChance { get; set; }

		[ContainerField(32), LayoutImmutable]
		public string RemoteAdministrationPort { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, Blittable]
		public float MaxDropDuration { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float ReorderingChance { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float HumanHealthMultiplier { get; set; }

		[ContainerField(48), LayoutImmutable]
		public string ServerName { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable, Blittable]
		public float MinDropDuration { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public uint SaveGameVersion { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float PacketDrops { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float DropSpikeChance { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float MaxLatency { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public uint OutgoingRate { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public uint IncomingRate { get; set; }

		[ContainerField(80), LayoutImmutable]
		public string Playlist { get; set; } = string.Empty;

		[ContainerField(84), LayoutImmutable]
		public string SavePoint { get; set; } = string.Empty;

		[ContainerField(88), LayoutImmutable, Blittable]
		public float IngameTimeout { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float OutgoingFrequency { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float RespawnTimeModifier { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float MinLatency { get; set; }

		[ContainerField(104), LayoutImmutable]
		public string ServerPassword { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, Blittable]
		public float TimeoutTime { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public uint PlayerCountNeededForMultiplayer { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float VehicleSpawnDelayModifier { get; set; }

		[ContainerField(120), LayoutImmutable]
		public string DebugMenuClick { get; set; } = string.Empty;

		[ContainerField(124), LayoutImmutable]
		public string AdministrationPassword { get; set; } = string.Empty;

		[ContainerField(128), LayoutImmutable, Blittable]
		public float LoadingTimeout { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public int DedicatedServerCpu { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public bool DeathmatchDebugInfo { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable]
		public bool TimeoutGame { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable]
		public bool AILooksIntoCamera { get; set; }

		[ContainerField(139), LayoutImmutable, Blittable]
		public bool IsStatsEnabled { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public bool IsTreeDestructionEnabled { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable]
		public bool HavokCaptureToFile { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable]
		public bool ShowTriggerDebugText { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable]
		public bool IsInternetSimulationEnabled { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool DisableCutscenes { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable]
		public bool JobEnable { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable]
		public bool ThreadingEnable { get; set; }

		[ContainerField(147), LayoutImmutable, Blittable]
		public bool DrawActivePhysicsObjects { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public bool IsRanked { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable]
		public bool UnlockResolver { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable]
		public bool ScoringLogEnabled { get; set; }

		[ContainerField(151), LayoutImmutable, Blittable]
		public bool HavokVisualDebugger { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public bool IsSoldierDetailedCollisionEnabled { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable]
		public bool LoadSavePoint { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable]
		public bool IsSoldierAnimationEnabled { get; set; }

		[ContainerField(155), LayoutImmutable, Blittable]
		public bool IsAiEnabled { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public bool IsReconfigurable { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable]
		public bool IsDestructionEnabled { get; set; }

		[ContainerField(158), LayoutImmutable, Blittable]
		public bool ForcePlaylist { get; set; }

		[ContainerField(159), LayoutImmutable, Blittable]
		public bool IsNetworkStatsEnabled { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public bool AutoUnspawnBangers { get; set; }

		[ContainerField(161), LayoutImmutable, Blittable]
		public bool RegulatedAIThrottle { get; set; }

		[ContainerField(162), LayoutImmutable, Blittable]
		public bool EnableAnimationCulling { get; set; }

		[ContainerField(163), LayoutImmutable, Blittable]
		public bool FallBackToSquadSpawn { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public bool AllowIndestructibleParts { get; set; }

		[ContainerField(165), LayoutImmutable, Blittable]
		public bool IsPresenceEnabled { get; set; }

		[ContainerField(166), LayoutImmutable, Blittable]
		public bool WaterPhysicsEnabled { get; set; }

		[ContainerField(167), LayoutImmutable, Blittable]
		public bool RespawnOnDeathPosition { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public bool IsRenderDamageEvents { get; set; }

		[ContainerField(169), LayoutImmutable, Blittable]
		public bool VehicleSpawnAllowed { get; set; }

		[ContainerField(170), LayoutImmutable, Blittable]
		public bool QueryProviderEnabled { get; set; }

		[ContainerField(171), LayoutImmutable, Blittable]
		public bool IsDesertingAllowed { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public bool DebrisClusterEnabled { get; set; }

		[ContainerField(173), LayoutImmutable, Blittable]
		public bool AdministrationEnabled { get; set; }

		[ContainerField(174), LayoutImmutable, Blittable]
		public bool AdministrationLogEnabled { get; set; }

		[ContainerField(175), LayoutImmutable, Blittable]
		public bool AdministrationTimeStampLogNames { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public bool AdministrationEventsEnabled { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable]
		public bool AdministrationServerNameRestricted { get; set; }

		[ContainerField(178), LayoutImmutable, Blittable]
		public bool ThreadedLoadingEnable { get; set; }

		[ContainerField(179), LayoutImmutable, Blittable]
		public bool VegetationEnabled { get; set; }

	}
}
