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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 180)]
	public class ServerSettings : 
		SystemSettings
	{
		protected string m_InstancePath = string.Empty;
		[ContainerField(Name: "InstancePath", Offset: 12, NameHash: 1188027073, Flags: 16509), LayoutImmutable]
		public string InstancePath { get { return m_InstancePath; } set { if (OnPropertyChanging("ServerSettings." + nameof(InstancePath), this, m_InstancePath, value)) m_InstancePath = value; } } // 0xC (12)
		
		protected uint m_RemoteControlPort = new uint();
		[ContainerField(Name: "RemoteControlPort", Offset: 16, NameHash: 2050172703, Flags: 49421), LayoutImmutable, Blittable]
		public uint RemoteControlPort { get { return m_RemoteControlPort; } set { if (OnPropertyChanging("ServerSettings." + nameof(RemoteControlPort), this, m_RemoteControlPort, value)) m_RemoteControlPort = value; } } // 0x10 (16)
		
		protected float m_DuplicationChance = new float();
		[ContainerField(Name: "DuplicationChance", Offset: 20, NameHash: 4025157277, Flags: 49469), LayoutImmutable, Blittable]
		public float DuplicationChance { get { return m_DuplicationChance; } set { if (OnPropertyChanging("ServerSettings." + nameof(DuplicationChance), this, m_DuplicationChance, value)) m_DuplicationChance = value; } } // 0x14 (20)
		
		protected uint m_MaxQueriesPerSecond = new uint();
		[ContainerField(Name: "MaxQueriesPerSecond", Offset: 24, NameHash: 1108763338, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxQueriesPerSecond { get { return m_MaxQueriesPerSecond; } set { if (OnPropertyChanging("ServerSettings." + nameof(MaxQueriesPerSecond), this, m_MaxQueriesPerSecond, value)) m_MaxQueriesPerSecond = value; } } // 0x18 (24)
		
		protected float m_CorruptionChance = new float();
		[ContainerField(Name: "CorruptionChance", Offset: 28, NameHash: 2028383634, Flags: 49469), LayoutImmutable, Blittable]
		public float CorruptionChance { get { return m_CorruptionChance; } set { if (OnPropertyChanging("ServerSettings." + nameof(CorruptionChance), this, m_CorruptionChance, value)) m_CorruptionChance = value; } } // 0x1C (28)
		
		protected string m_RemoteAdministrationPort = string.Empty;
		[ContainerField(Name: "RemoteAdministrationPort", Offset: 32, NameHash: 947290198, Flags: 16509), LayoutImmutable]
		public string RemoteAdministrationPort { get { return m_RemoteAdministrationPort; } set { if (OnPropertyChanging("ServerSettings." + nameof(RemoteAdministrationPort), this, m_RemoteAdministrationPort, value)) m_RemoteAdministrationPort = value; } } // 0x20 (32)
		
		protected float m_MaxDropDuration = new float();
		[ContainerField(Name: "MaxDropDuration", Offset: 36, NameHash: 3255041222, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxDropDuration { get { return m_MaxDropDuration; } set { if (OnPropertyChanging("ServerSettings." + nameof(MaxDropDuration), this, m_MaxDropDuration, value)) m_MaxDropDuration = value; } } // 0x24 (36)
		
		protected float m_ReorderingChance = new float();
		[ContainerField(Name: "ReorderingChance", Offset: 40, NameHash: 3536539614, Flags: 49469), LayoutImmutable, Blittable]
		public float ReorderingChance { get { return m_ReorderingChance; } set { if (OnPropertyChanging("ServerSettings." + nameof(ReorderingChance), this, m_ReorderingChance, value)) m_ReorderingChance = value; } } // 0x28 (40)
		
		protected float m_HumanHealthMultiplier = new float();
		[ContainerField(Name: "HumanHealthMultiplier", Offset: 44, NameHash: 1831700397, Flags: 49469), LayoutImmutable, Blittable]
		public float HumanHealthMultiplier { get { return m_HumanHealthMultiplier; } set { if (OnPropertyChanging("ServerSettings." + nameof(HumanHealthMultiplier), this, m_HumanHealthMultiplier, value)) m_HumanHealthMultiplier = value; } } // 0x2C (44)
		
		protected string m_ServerName = string.Empty;
		[ContainerField(Name: "ServerName", Offset: 48, NameHash: 1802252391, Flags: 16509), LayoutImmutable]
		public string ServerName { get { return m_ServerName; } set { if (OnPropertyChanging("ServerSettings." + nameof(ServerName), this, m_ServerName, value)) m_ServerName = value; } } // 0x30 (48)
		
		protected float m_MinDropDuration = new float();
		[ContainerField(Name: "MinDropDuration", Offset: 52, NameHash: 32856408, Flags: 49469), LayoutImmutable, Blittable]
		public float MinDropDuration { get { return m_MinDropDuration; } set { if (OnPropertyChanging("ServerSettings." + nameof(MinDropDuration), this, m_MinDropDuration, value)) m_MinDropDuration = value; } } // 0x34 (52)
		
		protected uint m_SaveGameVersion = new uint();
		[ContainerField(Name: "SaveGameVersion", Offset: 56, NameHash: 1621131600, Flags: 49421), LayoutImmutable, Blittable]
		public uint SaveGameVersion { get { return m_SaveGameVersion; } set { if (OnPropertyChanging("ServerSettings." + nameof(SaveGameVersion), this, m_SaveGameVersion, value)) m_SaveGameVersion = value; } } // 0x38 (56)
		
		protected float m_PacketDrops = new float();
		[ContainerField(Name: "PacketDrops", Offset: 60, NameHash: 2325561751, Flags: 49469), LayoutImmutable, Blittable]
		public float PacketDrops { get { return m_PacketDrops; } set { if (OnPropertyChanging("ServerSettings." + nameof(PacketDrops), this, m_PacketDrops, value)) m_PacketDrops = value; } } // 0x3C (60)
		
		protected float m_DropSpikeChance = new float();
		[ContainerField(Name: "DropSpikeChance", Offset: 64, NameHash: 2554650602, Flags: 49469), LayoutImmutable, Blittable]
		public float DropSpikeChance { get { return m_DropSpikeChance; } set { if (OnPropertyChanging("ServerSettings." + nameof(DropSpikeChance), this, m_DropSpikeChance, value)) m_DropSpikeChance = value; } } // 0x40 (64)
		
		protected float m_MaxLatency = new float();
		[ContainerField(Name: "MaxLatency", Offset: 68, NameHash: 92818329, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxLatency { get { return m_MaxLatency; } set { if (OnPropertyChanging("ServerSettings." + nameof(MaxLatency), this, m_MaxLatency, value)) m_MaxLatency = value; } } // 0x44 (68)
		
		protected uint m_OutgoingRate = new uint();
		[ContainerField(Name: "OutgoingRate", Offset: 72, NameHash: 3079887233, Flags: 49421), LayoutImmutable, Blittable]
		public uint OutgoingRate { get { return m_OutgoingRate; } set { if (OnPropertyChanging("ServerSettings." + nameof(OutgoingRate), this, m_OutgoingRate, value)) m_OutgoingRate = value; } } // 0x48 (72)
		
		protected uint m_IncomingRate = new uint();
		[ContainerField(Name: "IncomingRate", Offset: 76, NameHash: 2958796769, Flags: 49421), LayoutImmutable, Blittable]
		public uint IncomingRate { get { return m_IncomingRate; } set { if (OnPropertyChanging("ServerSettings." + nameof(IncomingRate), this, m_IncomingRate, value)) m_IncomingRate = value; } } // 0x4C (76)
		
		protected string m_Playlist = string.Empty;
		[ContainerField(Name: "Playlist", Offset: 80, NameHash: 927771683, Flags: 16509), LayoutImmutable]
		public string Playlist { get { return m_Playlist; } set { if (OnPropertyChanging("ServerSettings." + nameof(Playlist), this, m_Playlist, value)) m_Playlist = value; } } // 0x50 (80)
		
		protected string m_SavePoint = string.Empty;
		[ContainerField(Name: "SavePoint", Offset: 84, NameHash: 1886045224, Flags: 16509), LayoutImmutable]
		public string SavePoint { get { return m_SavePoint; } set { if (OnPropertyChanging("ServerSettings." + nameof(SavePoint), this, m_SavePoint, value)) m_SavePoint = value; } } // 0x54 (84)
		
		protected float m_IngameTimeout = new float();
		[ContainerField(Name: "IngameTimeout", Offset: 88, NameHash: 178921847, Flags: 49469), LayoutImmutable, Blittable]
		public float IngameTimeout { get { return m_IngameTimeout; } set { if (OnPropertyChanging("ServerSettings." + nameof(IngameTimeout), this, m_IngameTimeout, value)) m_IngameTimeout = value; } } // 0x58 (88)
		
		protected float m_OutgoingFrequency = new float();
		[ContainerField(Name: "OutgoingFrequency", Offset: 92, NameHash: 657578791, Flags: 49469), LayoutImmutable, Blittable]
		public float OutgoingFrequency { get { return m_OutgoingFrequency; } set { if (OnPropertyChanging("ServerSettings." + nameof(OutgoingFrequency), this, m_OutgoingFrequency, value)) m_OutgoingFrequency = value; } } // 0x5C (92)
		
		protected float m_RespawnTimeModifier = new float();
		[ContainerField(Name: "RespawnTimeModifier", Offset: 96, NameHash: 3384743563, Flags: 49469), LayoutImmutable, Blittable]
		public float RespawnTimeModifier { get { return m_RespawnTimeModifier; } set { if (OnPropertyChanging("ServerSettings." + nameof(RespawnTimeModifier), this, m_RespawnTimeModifier, value)) m_RespawnTimeModifier = value; } } // 0x60 (96)
		
		protected float m_MinLatency = new float();
		[ContainerField(Name: "MinLatency", Offset: 100, NameHash: 715003463, Flags: 49469), LayoutImmutable, Blittable]
		public float MinLatency { get { return m_MinLatency; } set { if (OnPropertyChanging("ServerSettings." + nameof(MinLatency), this, m_MinLatency, value)) m_MinLatency = value; } } // 0x64 (100)
		
		protected string m_ServerPassword = string.Empty;
		[ContainerField(Name: "ServerPassword", Offset: 104, NameHash: 82517919, Flags: 16509), LayoutImmutable]
		public string ServerPassword { get { return m_ServerPassword; } set { if (OnPropertyChanging("ServerSettings." + nameof(ServerPassword), this, m_ServerPassword, value)) m_ServerPassword = value; } } // 0x68 (104)
		
		protected float m_TimeoutTime = new float();
		[ContainerField(Name: "TimeoutTime", Offset: 108, NameHash: 2552048779, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeoutTime { get { return m_TimeoutTime; } set { if (OnPropertyChanging("ServerSettings." + nameof(TimeoutTime), this, m_TimeoutTime, value)) m_TimeoutTime = value; } } // 0x6C (108)
		
		protected uint m_PlayerCountNeededForMultiplayer = new uint();
		[ContainerField(Name: "PlayerCountNeededForMultiplayer", Offset: 112, NameHash: 2906149535, Flags: 49421), LayoutImmutable, Blittable]
		public uint PlayerCountNeededForMultiplayer { get { return m_PlayerCountNeededForMultiplayer; } set { if (OnPropertyChanging("ServerSettings." + nameof(PlayerCountNeededForMultiplayer), this, m_PlayerCountNeededForMultiplayer, value)) m_PlayerCountNeededForMultiplayer = value; } } // 0x70 (112)
		
		protected float m_VehicleSpawnDelayModifier = new float();
		[ContainerField(Name: "VehicleSpawnDelayModifier", Offset: 116, NameHash: 1247328452, Flags: 49469), LayoutImmutable, Blittable]
		public float VehicleSpawnDelayModifier { get { return m_VehicleSpawnDelayModifier; } set { if (OnPropertyChanging("ServerSettings." + nameof(VehicleSpawnDelayModifier), this, m_VehicleSpawnDelayModifier, value)) m_VehicleSpawnDelayModifier = value; } } // 0x74 (116)
		
		protected string m_DebugMenuClick = string.Empty;
		[ContainerField(Name: "DebugMenuClick", Offset: 120, NameHash: 219459689, Flags: 16509), LayoutImmutable]
		public string DebugMenuClick { get { return m_DebugMenuClick; } set { if (OnPropertyChanging("ServerSettings." + nameof(DebugMenuClick), this, m_DebugMenuClick, value)) m_DebugMenuClick = value; } } // 0x78 (120)
		
		protected string m_AdministrationPassword = string.Empty;
		[ContainerField(Name: "AdministrationPassword", Offset: 124, NameHash: 1271615764, Flags: 16509), LayoutImmutable]
		public string AdministrationPassword { get { return m_AdministrationPassword; } set { if (OnPropertyChanging("ServerSettings." + nameof(AdministrationPassword), this, m_AdministrationPassword, value)) m_AdministrationPassword = value; } } // 0x7C (124)
		
		protected float m_LoadingTimeout = new float();
		[ContainerField(Name: "LoadingTimeout", Offset: 128, NameHash: 1203409176, Flags: 49469), LayoutImmutable, Blittable]
		public float LoadingTimeout { get { return m_LoadingTimeout; } set { if (OnPropertyChanging("ServerSettings." + nameof(LoadingTimeout), this, m_LoadingTimeout, value)) m_LoadingTimeout = value; } } // 0x80 (128)
		
		protected int m_DedicatedServerCpu = new int();
		[ContainerField(Name: "DedicatedServerCpu", Offset: 132, NameHash: 4012132925, Flags: 49405), LayoutImmutable, Blittable]
		public int DedicatedServerCpu { get { return m_DedicatedServerCpu; } set { if (OnPropertyChanging("ServerSettings." + nameof(DedicatedServerCpu), this, m_DedicatedServerCpu, value)) m_DedicatedServerCpu = value; } } // 0x84 (132)
		
		protected bool m_DeathmatchDebugInfo = new bool();
		[ContainerField(Name: "DeathmatchDebugInfo", Offset: 136, NameHash: 167269973, Flags: 49325), LayoutImmutable, Blittable]
		public bool DeathmatchDebugInfo { get { return m_DeathmatchDebugInfo; } set { if (OnPropertyChanging("ServerSettings." + nameof(DeathmatchDebugInfo), this, m_DeathmatchDebugInfo, value)) m_DeathmatchDebugInfo = value; } } // 0x88 (136)
		
		protected bool m_TimeoutGame = new bool();
		[ContainerField(Name: "TimeoutGame", Offset: 137, NameHash: 2552389232, Flags: 49325), LayoutImmutable, Blittable]
		public bool TimeoutGame { get { return m_TimeoutGame; } set { if (OnPropertyChanging("ServerSettings." + nameof(TimeoutGame), this, m_TimeoutGame, value)) m_TimeoutGame = value; } } // 0x89 (137)
		
		protected bool m_AILooksIntoCamera = new bool();
		[ContainerField(Name: "AILooksIntoCamera", Offset: 138, NameHash: 2811501308, Flags: 49325), LayoutImmutable, Blittable]
		public bool AILooksIntoCamera { get { return m_AILooksIntoCamera; } set { if (OnPropertyChanging("ServerSettings." + nameof(AILooksIntoCamera), this, m_AILooksIntoCamera, value)) m_AILooksIntoCamera = value; } } // 0x8A (138)
		
		protected bool m_IsStatsEnabled = new bool();
		[ContainerField(Name: "IsStatsEnabled", Offset: 139, NameHash: 18279707, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsStatsEnabled { get { return m_IsStatsEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsStatsEnabled), this, m_IsStatsEnabled, value)) m_IsStatsEnabled = value; } } // 0x8B (139)
		
		protected bool m_IsTreeDestructionEnabled = new bool();
		[ContainerField(Name: "IsTreeDestructionEnabled", Offset: 140, NameHash: 210715778, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsTreeDestructionEnabled { get { return m_IsTreeDestructionEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsTreeDestructionEnabled), this, m_IsTreeDestructionEnabled, value)) m_IsTreeDestructionEnabled = value; } } // 0x8C (140)
		
		protected bool m_HavokCaptureToFile = new bool();
		[ContainerField(Name: "HavokCaptureToFile", Offset: 141, NameHash: 199879943, Flags: 49325), LayoutImmutable, Blittable]
		public bool HavokCaptureToFile { get { return m_HavokCaptureToFile; } set { if (OnPropertyChanging("ServerSettings." + nameof(HavokCaptureToFile), this, m_HavokCaptureToFile, value)) m_HavokCaptureToFile = value; } } // 0x8D (141)
		
		protected bool m_ShowTriggerDebugText = new bool();
		[ContainerField(Name: "ShowTriggerDebugText", Offset: 142, NameHash: 379584722, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowTriggerDebugText { get { return m_ShowTriggerDebugText; } set { if (OnPropertyChanging("ServerSettings." + nameof(ShowTriggerDebugText), this, m_ShowTriggerDebugText, value)) m_ShowTriggerDebugText = value; } } // 0x8E (142)
		
		protected bool m_IsInternetSimulationEnabled = new bool();
		[ContainerField(Name: "IsInternetSimulationEnabled", Offset: 143, NameHash: 1270028082, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsInternetSimulationEnabled { get { return m_IsInternetSimulationEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsInternetSimulationEnabled), this, m_IsInternetSimulationEnabled, value)) m_IsInternetSimulationEnabled = value; } } // 0x8F (143)
		
		protected bool m_DisableCutscenes = new bool();
		[ContainerField(Name: "DisableCutscenes", Offset: 144, NameHash: 2592294494, Flags: 49325), LayoutImmutable, Blittable]
		public bool DisableCutscenes { get { return m_DisableCutscenes; } set { if (OnPropertyChanging("ServerSettings." + nameof(DisableCutscenes), this, m_DisableCutscenes, value)) m_DisableCutscenes = value; } } // 0x90 (144)
		
		protected bool m_JobEnable = new bool();
		[ContainerField(Name: "JobEnable", Offset: 145, NameHash: 442685923, Flags: 49325), LayoutImmutable, Blittable]
		public bool JobEnable { get { return m_JobEnable; } set { if (OnPropertyChanging("ServerSettings." + nameof(JobEnable), this, m_JobEnable, value)) m_JobEnable = value; } } // 0x91 (145)
		
		protected bool m_ThreadingEnable = new bool();
		[ContainerField(Name: "ThreadingEnable", Offset: 146, NameHash: 3470873770, Flags: 49325), LayoutImmutable, Blittable]
		public bool ThreadingEnable { get { return m_ThreadingEnable; } set { if (OnPropertyChanging("ServerSettings." + nameof(ThreadingEnable), this, m_ThreadingEnable, value)) m_ThreadingEnable = value; } } // 0x92 (146)
		
		protected bool m_DrawActivePhysicsObjects = new bool();
		[ContainerField(Name: "DrawActivePhysicsObjects", Offset: 147, NameHash: 3563516612, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawActivePhysicsObjects { get { return m_DrawActivePhysicsObjects; } set { if (OnPropertyChanging("ServerSettings." + nameof(DrawActivePhysicsObjects), this, m_DrawActivePhysicsObjects, value)) m_DrawActivePhysicsObjects = value; } } // 0x93 (147)
		
		protected bool m_IsRanked = new bool();
		[ContainerField(Name: "IsRanked", Offset: 148, NameHash: 421704968, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsRanked { get { return m_IsRanked; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsRanked), this, m_IsRanked, value)) m_IsRanked = value; } } // 0x94 (148)
		
		protected bool m_UnlockResolver = new bool();
		[ContainerField(Name: "UnlockResolver", Offset: 149, NameHash: 3015574227, Flags: 49325), LayoutImmutable, Blittable]
		public bool UnlockResolver { get { return m_UnlockResolver; } set { if (OnPropertyChanging("ServerSettings." + nameof(UnlockResolver), this, m_UnlockResolver, value)) m_UnlockResolver = value; } } // 0x95 (149)
		
		protected bool m_ScoringLogEnabled = new bool();
		[ContainerField(Name: "ScoringLogEnabled", Offset: 150, NameHash: 3740384009, Flags: 49325), LayoutImmutable, Blittable]
		public bool ScoringLogEnabled { get { return m_ScoringLogEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(ScoringLogEnabled), this, m_ScoringLogEnabled, value)) m_ScoringLogEnabled = value; } } // 0x96 (150)
		
		protected bool m_HavokVisualDebugger = new bool();
		[ContainerField(Name: "HavokVisualDebugger", Offset: 151, NameHash: 1929453227, Flags: 49325), LayoutImmutable, Blittable]
		public bool HavokVisualDebugger { get { return m_HavokVisualDebugger; } set { if (OnPropertyChanging("ServerSettings." + nameof(HavokVisualDebugger), this, m_HavokVisualDebugger, value)) m_HavokVisualDebugger = value; } } // 0x97 (151)
		
		protected bool m_IsSoldierDetailedCollisionEnabled = new bool();
		[ContainerField(Name: "IsSoldierDetailedCollisionEnabled", Offset: 152, NameHash: 2603752286, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsSoldierDetailedCollisionEnabled { get { return m_IsSoldierDetailedCollisionEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsSoldierDetailedCollisionEnabled), this, m_IsSoldierDetailedCollisionEnabled, value)) m_IsSoldierDetailedCollisionEnabled = value; } } // 0x98 (152)
		
		protected bool m_LoadSavePoint = new bool();
		[ContainerField(Name: "LoadSavePoint", Offset: 153, NameHash: 740179758, Flags: 49325), LayoutImmutable, Blittable]
		public bool LoadSavePoint { get { return m_LoadSavePoint; } set { if (OnPropertyChanging("ServerSettings." + nameof(LoadSavePoint), this, m_LoadSavePoint, value)) m_LoadSavePoint = value; } } // 0x99 (153)
		
		protected bool m_IsSoldierAnimationEnabled = new bool();
		[ContainerField(Name: "IsSoldierAnimationEnabled", Offset: 154, NameHash: 3800480326, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsSoldierAnimationEnabled { get { return m_IsSoldierAnimationEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsSoldierAnimationEnabled), this, m_IsSoldierAnimationEnabled, value)) m_IsSoldierAnimationEnabled = value; } } // 0x9A (154)
		
		protected bool m_IsAiEnabled = new bool();
		[ContainerField(Name: "IsAiEnabled", Offset: 155, NameHash: 2380226514, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsAiEnabled { get { return m_IsAiEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsAiEnabled), this, m_IsAiEnabled, value)) m_IsAiEnabled = value; } } // 0x9B (155)
		
		protected bool m_IsReconfigurable = new bool();
		[ContainerField(Name: "IsReconfigurable", Offset: 156, NameHash: 2944642543, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsReconfigurable { get { return m_IsReconfigurable; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsReconfigurable), this, m_IsReconfigurable, value)) m_IsReconfigurable = value; } } // 0x9C (156)
		
		protected bool m_IsDestructionEnabled = new bool();
		[ContainerField(Name: "IsDestructionEnabled", Offset: 157, NameHash: 3503383684, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsDestructionEnabled { get { return m_IsDestructionEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsDestructionEnabled), this, m_IsDestructionEnabled, value)) m_IsDestructionEnabled = value; } } // 0x9D (157)
		
		protected bool m_ForcePlaylist = new bool();
		[ContainerField(Name: "ForcePlaylist", Offset: 158, NameHash: 2185859614, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForcePlaylist { get { return m_ForcePlaylist; } set { if (OnPropertyChanging("ServerSettings." + nameof(ForcePlaylist), this, m_ForcePlaylist, value)) m_ForcePlaylist = value; } } // 0x9E (158)
		
		protected bool m_IsNetworkStatsEnabled = new bool();
		[ContainerField(Name: "IsNetworkStatsEnabled", Offset: 159, NameHash: 3782966053, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsNetworkStatsEnabled { get { return m_IsNetworkStatsEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsNetworkStatsEnabled), this, m_IsNetworkStatsEnabled, value)) m_IsNetworkStatsEnabled = value; } } // 0x9F (159)
		
		protected bool m_AutoUnspawnBangers = new bool();
		[ContainerField(Name: "AutoUnspawnBangers", Offset: 160, NameHash: 2106862756, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoUnspawnBangers { get { return m_AutoUnspawnBangers; } set { if (OnPropertyChanging("ServerSettings." + nameof(AutoUnspawnBangers), this, m_AutoUnspawnBangers, value)) m_AutoUnspawnBangers = value; } } // 0xA0 (160)
		
		protected bool m_RegulatedAIThrottle = new bool();
		[ContainerField(Name: "RegulatedAIThrottle", Offset: 161, NameHash: 3666128056, Flags: 49325), LayoutImmutable, Blittable]
		public bool RegulatedAIThrottle { get { return m_RegulatedAIThrottle; } set { if (OnPropertyChanging("ServerSettings." + nameof(RegulatedAIThrottle), this, m_RegulatedAIThrottle, value)) m_RegulatedAIThrottle = value; } } // 0xA1 (161)
		
		protected bool m_EnableAnimationCulling = new bool();
		[ContainerField(Name: "EnableAnimationCulling", Offset: 162, NameHash: 4034860932, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnableAnimationCulling { get { return m_EnableAnimationCulling; } set { if (OnPropertyChanging("ServerSettings." + nameof(EnableAnimationCulling), this, m_EnableAnimationCulling, value)) m_EnableAnimationCulling = value; } } // 0xA2 (162)
		
		protected bool m_FallBackToSquadSpawn = new bool();
		[ContainerField(Name: "FallBackToSquadSpawn", Offset: 163, NameHash: 2693064955, Flags: 49325), LayoutImmutable, Blittable]
		public bool FallBackToSquadSpawn { get { return m_FallBackToSquadSpawn; } set { if (OnPropertyChanging("ServerSettings." + nameof(FallBackToSquadSpawn), this, m_FallBackToSquadSpawn, value)) m_FallBackToSquadSpawn = value; } } // 0xA3 (163)
		
		protected bool m_AllowIndestructibleParts = new bool();
		[ContainerField(Name: "AllowIndestructibleParts", Offset: 164, NameHash: 4066263915, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowIndestructibleParts { get { return m_AllowIndestructibleParts; } set { if (OnPropertyChanging("ServerSettings." + nameof(AllowIndestructibleParts), this, m_AllowIndestructibleParts, value)) m_AllowIndestructibleParts = value; } } // 0xA4 (164)
		
		protected bool m_IsPresenceEnabled = new bool();
		[ContainerField(Name: "IsPresenceEnabled", Offset: 165, NameHash: 343956131, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsPresenceEnabled { get { return m_IsPresenceEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsPresenceEnabled), this, m_IsPresenceEnabled, value)) m_IsPresenceEnabled = value; } } // 0xA5 (165)
		
		protected bool m_WaterPhysicsEnabled = new bool();
		[ContainerField(Name: "WaterPhysicsEnabled", Offset: 166, NameHash: 4150371006, Flags: 49325), LayoutImmutable, Blittable]
		public bool WaterPhysicsEnabled { get { return m_WaterPhysicsEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(WaterPhysicsEnabled), this, m_WaterPhysicsEnabled, value)) m_WaterPhysicsEnabled = value; } } // 0xA6 (166)
		
		protected bool m_RespawnOnDeathPosition = new bool();
		[ContainerField(Name: "RespawnOnDeathPosition", Offset: 167, NameHash: 4145685869, Flags: 49325), LayoutImmutable, Blittable]
		public bool RespawnOnDeathPosition { get { return m_RespawnOnDeathPosition; } set { if (OnPropertyChanging("ServerSettings." + nameof(RespawnOnDeathPosition), this, m_RespawnOnDeathPosition, value)) m_RespawnOnDeathPosition = value; } } // 0xA7 (167)
		
		protected bool m_IsRenderDamageEvents = new bool();
		[ContainerField(Name: "IsRenderDamageEvents", Offset: 168, NameHash: 1150027009, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsRenderDamageEvents { get { return m_IsRenderDamageEvents; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsRenderDamageEvents), this, m_IsRenderDamageEvents, value)) m_IsRenderDamageEvents = value; } } // 0xA8 (168)
		
		protected bool m_VehicleSpawnAllowed = new bool();
		[ContainerField(Name: "VehicleSpawnAllowed", Offset: 169, NameHash: 108238142, Flags: 49325), LayoutImmutable, Blittable]
		public bool VehicleSpawnAllowed { get { return m_VehicleSpawnAllowed; } set { if (OnPropertyChanging("ServerSettings." + nameof(VehicleSpawnAllowed), this, m_VehicleSpawnAllowed, value)) m_VehicleSpawnAllowed = value; } } // 0xA9 (169)
		
		protected bool m_QueryProviderEnabled = new bool();
		[ContainerField(Name: "QueryProviderEnabled", Offset: 170, NameHash: 2501867691, Flags: 49325), LayoutImmutable, Blittable]
		public bool QueryProviderEnabled { get { return m_QueryProviderEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(QueryProviderEnabled), this, m_QueryProviderEnabled, value)) m_QueryProviderEnabled = value; } } // 0xAA (170)
		
		protected bool m_IsDesertingAllowed = new bool();
		[ContainerField(Name: "IsDesertingAllowed", Offset: 171, NameHash: 686355126, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsDesertingAllowed { get { return m_IsDesertingAllowed; } set { if (OnPropertyChanging("ServerSettings." + nameof(IsDesertingAllowed), this, m_IsDesertingAllowed, value)) m_IsDesertingAllowed = value; } } // 0xAB (171)
		
		protected bool m_DebrisClusterEnabled = new bool();
		[ContainerField(Name: "DebrisClusterEnabled", Offset: 172, NameHash: 3885754465, Flags: 49325), LayoutImmutable, Blittable]
		public bool DebrisClusterEnabled { get { return m_DebrisClusterEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(DebrisClusterEnabled), this, m_DebrisClusterEnabled, value)) m_DebrisClusterEnabled = value; } } // 0xAC (172)
		
		protected bool m_AdministrationEnabled = new bool();
		[ContainerField(Name: "AdministrationEnabled", Offset: 173, NameHash: 567396142, Flags: 49325), LayoutImmutable, Blittable]
		public bool AdministrationEnabled { get { return m_AdministrationEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(AdministrationEnabled), this, m_AdministrationEnabled, value)) m_AdministrationEnabled = value; } } // 0xAD (173)
		
		protected bool m_AdministrationLogEnabled = new bool();
		[ContainerField(Name: "AdministrationLogEnabled", Offset: 174, NameHash: 3026093994, Flags: 49325), LayoutImmutable, Blittable]
		public bool AdministrationLogEnabled { get { return m_AdministrationLogEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(AdministrationLogEnabled), this, m_AdministrationLogEnabled, value)) m_AdministrationLogEnabled = value; } } // 0xAE (174)
		
		protected bool m_AdministrationTimeStampLogNames = new bool();
		[ContainerField(Name: "AdministrationTimeStampLogNames", Offset: 175, NameHash: 1296337333, Flags: 49325), LayoutImmutable, Blittable]
		public bool AdministrationTimeStampLogNames { get { return m_AdministrationTimeStampLogNames; } set { if (OnPropertyChanging("ServerSettings." + nameof(AdministrationTimeStampLogNames), this, m_AdministrationTimeStampLogNames, value)) m_AdministrationTimeStampLogNames = value; } } // 0xAF (175)
		
		protected bool m_AdministrationEventsEnabled = new bool();
		[ContainerField(Name: "AdministrationEventsEnabled", Offset: 176, NameHash: 4266105137, Flags: 49325), LayoutImmutable, Blittable]
		public bool AdministrationEventsEnabled { get { return m_AdministrationEventsEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(AdministrationEventsEnabled), this, m_AdministrationEventsEnabled, value)) m_AdministrationEventsEnabled = value; } } // 0xB0 (176)
		
		protected bool m_AdministrationServerNameRestricted = new bool();
		[ContainerField(Name: "AdministrationServerNameRestricted", Offset: 177, NameHash: 3896564372, Flags: 49325), LayoutImmutable, Blittable]
		public bool AdministrationServerNameRestricted { get { return m_AdministrationServerNameRestricted; } set { if (OnPropertyChanging("ServerSettings." + nameof(AdministrationServerNameRestricted), this, m_AdministrationServerNameRestricted, value)) m_AdministrationServerNameRestricted = value; } } // 0xB1 (177)
		
		protected bool m_ThreadedLoadingEnable = new bool();
		[ContainerField(Name: "ThreadedLoadingEnable", Offset: 178, NameHash: 1104410157, Flags: 49325), LayoutImmutable, Blittable]
		public bool ThreadedLoadingEnable { get { return m_ThreadedLoadingEnable; } set { if (OnPropertyChanging("ServerSettings." + nameof(ThreadedLoadingEnable), this, m_ThreadedLoadingEnable, value)) m_ThreadedLoadingEnable = value; } } // 0xB2 (178)
		
		protected bool m_VegetationEnabled = new bool();
		[ContainerField(Name: "VegetationEnabled", Offset: 179, NameHash: 1260276984, Flags: 49325), LayoutImmutable, Blittable]
		public bool VegetationEnabled { get { return m_VegetationEnabled; } set { if (OnPropertyChanging("ServerSettings." + nameof(VegetationEnabled), this, m_VegetationEnabled, value)) m_VegetationEnabled = value; } } // 0xB3 (179)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1188027073:
					InstancePath = (string) p_Value;
					break;

				case 2050172703:
					RemoteControlPort = (uint) p_Value;
					break;

				case 4025157277:
					DuplicationChance = (float) p_Value;
					break;

				case 1108763338:
					MaxQueriesPerSecond = (uint) p_Value;
					break;

				case 2028383634:
					CorruptionChance = (float) p_Value;
					break;

				case 947290198:
					RemoteAdministrationPort = (string) p_Value;
					break;

				case 3255041222:
					MaxDropDuration = (float) p_Value;
					break;

				case 3536539614:
					ReorderingChance = (float) p_Value;
					break;

				case 1831700397:
					HumanHealthMultiplier = (float) p_Value;
					break;

				case 1802252391:
					ServerName = (string) p_Value;
					break;

				case 32856408:
					MinDropDuration = (float) p_Value;
					break;

				case 1621131600:
					SaveGameVersion = (uint) p_Value;
					break;

				case 2325561751:
					PacketDrops = (float) p_Value;
					break;

				case 2554650602:
					DropSpikeChance = (float) p_Value;
					break;

				case 92818329:
					MaxLatency = (float) p_Value;
					break;

				case 3079887233:
					OutgoingRate = (uint) p_Value;
					break;

				case 2958796769:
					IncomingRate = (uint) p_Value;
					break;

				case 927771683:
					Playlist = (string) p_Value;
					break;

				case 1886045224:
					SavePoint = (string) p_Value;
					break;

				case 178921847:
					IngameTimeout = (float) p_Value;
					break;

				case 657578791:
					OutgoingFrequency = (float) p_Value;
					break;

				case 3384743563:
					RespawnTimeModifier = (float) p_Value;
					break;

				case 715003463:
					MinLatency = (float) p_Value;
					break;

				case 82517919:
					ServerPassword = (string) p_Value;
					break;

				case 2552048779:
					TimeoutTime = (float) p_Value;
					break;

				case 2906149535:
					PlayerCountNeededForMultiplayer = (uint) p_Value;
					break;

				case 1247328452:
					VehicleSpawnDelayModifier = (float) p_Value;
					break;

				case 219459689:
					DebugMenuClick = (string) p_Value;
					break;

				case 1271615764:
					AdministrationPassword = (string) p_Value;
					break;

				case 1203409176:
					LoadingTimeout = (float) p_Value;
					break;

				case 4012132925:
					DedicatedServerCpu = (int) p_Value;
					break;

				case 167269973:
					DeathmatchDebugInfo = (bool) p_Value;
					break;

				case 2552389232:
					TimeoutGame = (bool) p_Value;
					break;

				case 2811501308:
					AILooksIntoCamera = (bool) p_Value;
					break;

				case 18279707:
					IsStatsEnabled = (bool) p_Value;
					break;

				case 210715778:
					IsTreeDestructionEnabled = (bool) p_Value;
					break;

				case 199879943:
					HavokCaptureToFile = (bool) p_Value;
					break;

				case 379584722:
					ShowTriggerDebugText = (bool) p_Value;
					break;

				case 1270028082:
					IsInternetSimulationEnabled = (bool) p_Value;
					break;

				case 2592294494:
					DisableCutscenes = (bool) p_Value;
					break;

				case 442685923:
					JobEnable = (bool) p_Value;
					break;

				case 3470873770:
					ThreadingEnable = (bool) p_Value;
					break;

				case 3563516612:
					DrawActivePhysicsObjects = (bool) p_Value;
					break;

				case 421704968:
					IsRanked = (bool) p_Value;
					break;

				case 3015574227:
					UnlockResolver = (bool) p_Value;
					break;

				case 3740384009:
					ScoringLogEnabled = (bool) p_Value;
					break;

				case 1929453227:
					HavokVisualDebugger = (bool) p_Value;
					break;

				case 2603752286:
					IsSoldierDetailedCollisionEnabled = (bool) p_Value;
					break;

				case 740179758:
					LoadSavePoint = (bool) p_Value;
					break;

				case 3800480326:
					IsSoldierAnimationEnabled = (bool) p_Value;
					break;

				case 2380226514:
					IsAiEnabled = (bool) p_Value;
					break;

				case 2944642543:
					IsReconfigurable = (bool) p_Value;
					break;

				case 3503383684:
					IsDestructionEnabled = (bool) p_Value;
					break;

				case 2185859614:
					ForcePlaylist = (bool) p_Value;
					break;

				case 3782966053:
					IsNetworkStatsEnabled = (bool) p_Value;
					break;

				case 2106862756:
					AutoUnspawnBangers = (bool) p_Value;
					break;

				case 3666128056:
					RegulatedAIThrottle = (bool) p_Value;
					break;

				case 4034860932:
					EnableAnimationCulling = (bool) p_Value;
					break;

				case 2693064955:
					FallBackToSquadSpawn = (bool) p_Value;
					break;

				case 4066263915:
					AllowIndestructibleParts = (bool) p_Value;
					break;

				case 343956131:
					IsPresenceEnabled = (bool) p_Value;
					break;

				case 4150371006:
					WaterPhysicsEnabled = (bool) p_Value;
					break;

				case 4145685869:
					RespawnOnDeathPosition = (bool) p_Value;
					break;

				case 1150027009:
					IsRenderDamageEvents = (bool) p_Value;
					break;

				case 108238142:
					VehicleSpawnAllowed = (bool) p_Value;
					break;

				case 2501867691:
					QueryProviderEnabled = (bool) p_Value;
					break;

				case 686355126:
					IsDesertingAllowed = (bool) p_Value;
					break;

				case 3885754465:
					DebrisClusterEnabled = (bool) p_Value;
					break;

				case 567396142:
					AdministrationEnabled = (bool) p_Value;
					break;

				case 3026093994:
					AdministrationLogEnabled = (bool) p_Value;
					break;

				case 1296337333:
					AdministrationTimeStampLogNames = (bool) p_Value;
					break;

				case 4266105137:
					AdministrationEventsEnabled = (bool) p_Value;
					break;

				case 3896564372:
					AdministrationServerNameRestricted = (bool) p_Value;
					break;

				case 1104410157:
					ThreadedLoadingEnable = (bool) p_Value;
					break;

				case 1260276984:
					VegetationEnabled = (bool) p_Value;
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
				case 1188027073:
					return InstancePath;

				case 2050172703:
					return RemoteControlPort;

				case 4025157277:
					return DuplicationChance;

				case 1108763338:
					return MaxQueriesPerSecond;

				case 2028383634:
					return CorruptionChance;

				case 947290198:
					return RemoteAdministrationPort;

				case 3255041222:
					return MaxDropDuration;

				case 3536539614:
					return ReorderingChance;

				case 1831700397:
					return HumanHealthMultiplier;

				case 1802252391:
					return ServerName;

				case 32856408:
					return MinDropDuration;

				case 1621131600:
					return SaveGameVersion;

				case 2325561751:
					return PacketDrops;

				case 2554650602:
					return DropSpikeChance;

				case 92818329:
					return MaxLatency;

				case 3079887233:
					return OutgoingRate;

				case 2958796769:
					return IncomingRate;

				case 927771683:
					return Playlist;

				case 1886045224:
					return SavePoint;

				case 178921847:
					return IngameTimeout;

				case 657578791:
					return OutgoingFrequency;

				case 3384743563:
					return RespawnTimeModifier;

				case 715003463:
					return MinLatency;

				case 82517919:
					return ServerPassword;

				case 2552048779:
					return TimeoutTime;

				case 2906149535:
					return PlayerCountNeededForMultiplayer;

				case 1247328452:
					return VehicleSpawnDelayModifier;

				case 219459689:
					return DebugMenuClick;

				case 1271615764:
					return AdministrationPassword;

				case 1203409176:
					return LoadingTimeout;

				case 4012132925:
					return DedicatedServerCpu;

				case 167269973:
					return DeathmatchDebugInfo;

				case 2552389232:
					return TimeoutGame;

				case 2811501308:
					return AILooksIntoCamera;

				case 18279707:
					return IsStatsEnabled;

				case 210715778:
					return IsTreeDestructionEnabled;

				case 199879943:
					return HavokCaptureToFile;

				case 379584722:
					return ShowTriggerDebugText;

				case 1270028082:
					return IsInternetSimulationEnabled;

				case 2592294494:
					return DisableCutscenes;

				case 442685923:
					return JobEnable;

				case 3470873770:
					return ThreadingEnable;

				case 3563516612:
					return DrawActivePhysicsObjects;

				case 421704968:
					return IsRanked;

				case 3015574227:
					return UnlockResolver;

				case 3740384009:
					return ScoringLogEnabled;

				case 1929453227:
					return HavokVisualDebugger;

				case 2603752286:
					return IsSoldierDetailedCollisionEnabled;

				case 740179758:
					return LoadSavePoint;

				case 3800480326:
					return IsSoldierAnimationEnabled;

				case 2380226514:
					return IsAiEnabled;

				case 2944642543:
					return IsReconfigurable;

				case 3503383684:
					return IsDestructionEnabled;

				case 2185859614:
					return ForcePlaylist;

				case 3782966053:
					return IsNetworkStatsEnabled;

				case 2106862756:
					return AutoUnspawnBangers;

				case 3666128056:
					return RegulatedAIThrottle;

				case 4034860932:
					return EnableAnimationCulling;

				case 2693064955:
					return FallBackToSquadSpawn;

				case 4066263915:
					return AllowIndestructibleParts;

				case 343956131:
					return IsPresenceEnabled;

				case 4150371006:
					return WaterPhysicsEnabled;

				case 4145685869:
					return RespawnOnDeathPosition;

				case 1150027009:
					return IsRenderDamageEvents;

				case 108238142:
					return VehicleSpawnAllowed;

				case 2501867691:
					return QueryProviderEnabled;

				case 686355126:
					return IsDesertingAllowed;

				case 3885754465:
					return DebrisClusterEnabled;

				case 567396142:
					return AdministrationEnabled;

				case 3026093994:
					return AdministrationLogEnabled;

				case 1296337333:
					return AdministrationTimeStampLogNames;

				case 4266105137:
					return AdministrationEventsEnabled;

				case 3896564372:
					return AdministrationServerNameRestricted;

				case 1104410157:
					return ThreadedLoadingEnable;

				case 1260276984:
					return VegetationEnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1188027073:
					return typeof(ServerSettings).GetProperty(nameof(InstancePath));

				case 2050172703:
					return typeof(ServerSettings).GetProperty(nameof(RemoteControlPort));

				case 4025157277:
					return typeof(ServerSettings).GetProperty(nameof(DuplicationChance));

				case 1108763338:
					return typeof(ServerSettings).GetProperty(nameof(MaxQueriesPerSecond));

				case 2028383634:
					return typeof(ServerSettings).GetProperty(nameof(CorruptionChance));

				case 947290198:
					return typeof(ServerSettings).GetProperty(nameof(RemoteAdministrationPort));

				case 3255041222:
					return typeof(ServerSettings).GetProperty(nameof(MaxDropDuration));

				case 3536539614:
					return typeof(ServerSettings).GetProperty(nameof(ReorderingChance));

				case 1831700397:
					return typeof(ServerSettings).GetProperty(nameof(HumanHealthMultiplier));

				case 1802252391:
					return typeof(ServerSettings).GetProperty(nameof(ServerName));

				case 32856408:
					return typeof(ServerSettings).GetProperty(nameof(MinDropDuration));

				case 1621131600:
					return typeof(ServerSettings).GetProperty(nameof(SaveGameVersion));

				case 2325561751:
					return typeof(ServerSettings).GetProperty(nameof(PacketDrops));

				case 2554650602:
					return typeof(ServerSettings).GetProperty(nameof(DropSpikeChance));

				case 92818329:
					return typeof(ServerSettings).GetProperty(nameof(MaxLatency));

				case 3079887233:
					return typeof(ServerSettings).GetProperty(nameof(OutgoingRate));

				case 2958796769:
					return typeof(ServerSettings).GetProperty(nameof(IncomingRate));

				case 927771683:
					return typeof(ServerSettings).GetProperty(nameof(Playlist));

				case 1886045224:
					return typeof(ServerSettings).GetProperty(nameof(SavePoint));

				case 178921847:
					return typeof(ServerSettings).GetProperty(nameof(IngameTimeout));

				case 657578791:
					return typeof(ServerSettings).GetProperty(nameof(OutgoingFrequency));

				case 3384743563:
					return typeof(ServerSettings).GetProperty(nameof(RespawnTimeModifier));

				case 715003463:
					return typeof(ServerSettings).GetProperty(nameof(MinLatency));

				case 82517919:
					return typeof(ServerSettings).GetProperty(nameof(ServerPassword));

				case 2552048779:
					return typeof(ServerSettings).GetProperty(nameof(TimeoutTime));

				case 2906149535:
					return typeof(ServerSettings).GetProperty(nameof(PlayerCountNeededForMultiplayer));

				case 1247328452:
					return typeof(ServerSettings).GetProperty(nameof(VehicleSpawnDelayModifier));

				case 219459689:
					return typeof(ServerSettings).GetProperty(nameof(DebugMenuClick));

				case 1271615764:
					return typeof(ServerSettings).GetProperty(nameof(AdministrationPassword));

				case 1203409176:
					return typeof(ServerSettings).GetProperty(nameof(LoadingTimeout));

				case 4012132925:
					return typeof(ServerSettings).GetProperty(nameof(DedicatedServerCpu));

				case 167269973:
					return typeof(ServerSettings).GetProperty(nameof(DeathmatchDebugInfo));

				case 2552389232:
					return typeof(ServerSettings).GetProperty(nameof(TimeoutGame));

				case 2811501308:
					return typeof(ServerSettings).GetProperty(nameof(AILooksIntoCamera));

				case 18279707:
					return typeof(ServerSettings).GetProperty(nameof(IsStatsEnabled));

				case 210715778:
					return typeof(ServerSettings).GetProperty(nameof(IsTreeDestructionEnabled));

				case 199879943:
					return typeof(ServerSettings).GetProperty(nameof(HavokCaptureToFile));

				case 379584722:
					return typeof(ServerSettings).GetProperty(nameof(ShowTriggerDebugText));

				case 1270028082:
					return typeof(ServerSettings).GetProperty(nameof(IsInternetSimulationEnabled));

				case 2592294494:
					return typeof(ServerSettings).GetProperty(nameof(DisableCutscenes));

				case 442685923:
					return typeof(ServerSettings).GetProperty(nameof(JobEnable));

				case 3470873770:
					return typeof(ServerSettings).GetProperty(nameof(ThreadingEnable));

				case 3563516612:
					return typeof(ServerSettings).GetProperty(nameof(DrawActivePhysicsObjects));

				case 421704968:
					return typeof(ServerSettings).GetProperty(nameof(IsRanked));

				case 3015574227:
					return typeof(ServerSettings).GetProperty(nameof(UnlockResolver));

				case 3740384009:
					return typeof(ServerSettings).GetProperty(nameof(ScoringLogEnabled));

				case 1929453227:
					return typeof(ServerSettings).GetProperty(nameof(HavokVisualDebugger));

				case 2603752286:
					return typeof(ServerSettings).GetProperty(nameof(IsSoldierDetailedCollisionEnabled));

				case 740179758:
					return typeof(ServerSettings).GetProperty(nameof(LoadSavePoint));

				case 3800480326:
					return typeof(ServerSettings).GetProperty(nameof(IsSoldierAnimationEnabled));

				case 2380226514:
					return typeof(ServerSettings).GetProperty(nameof(IsAiEnabled));

				case 2944642543:
					return typeof(ServerSettings).GetProperty(nameof(IsReconfigurable));

				case 3503383684:
					return typeof(ServerSettings).GetProperty(nameof(IsDestructionEnabled));

				case 2185859614:
					return typeof(ServerSettings).GetProperty(nameof(ForcePlaylist));

				case 3782966053:
					return typeof(ServerSettings).GetProperty(nameof(IsNetworkStatsEnabled));

				case 2106862756:
					return typeof(ServerSettings).GetProperty(nameof(AutoUnspawnBangers));

				case 3666128056:
					return typeof(ServerSettings).GetProperty(nameof(RegulatedAIThrottle));

				case 4034860932:
					return typeof(ServerSettings).GetProperty(nameof(EnableAnimationCulling));

				case 2693064955:
					return typeof(ServerSettings).GetProperty(nameof(FallBackToSquadSpawn));

				case 4066263915:
					return typeof(ServerSettings).GetProperty(nameof(AllowIndestructibleParts));

				case 343956131:
					return typeof(ServerSettings).GetProperty(nameof(IsPresenceEnabled));

				case 4150371006:
					return typeof(ServerSettings).GetProperty(nameof(WaterPhysicsEnabled));

				case 4145685869:
					return typeof(ServerSettings).GetProperty(nameof(RespawnOnDeathPosition));

				case 1150027009:
					return typeof(ServerSettings).GetProperty(nameof(IsRenderDamageEvents));

				case 108238142:
					return typeof(ServerSettings).GetProperty(nameof(VehicleSpawnAllowed));

				case 2501867691:
					return typeof(ServerSettings).GetProperty(nameof(QueryProviderEnabled));

				case 686355126:
					return typeof(ServerSettings).GetProperty(nameof(IsDesertingAllowed));

				case 3885754465:
					return typeof(ServerSettings).GetProperty(nameof(DebrisClusterEnabled));

				case 567396142:
					return typeof(ServerSettings).GetProperty(nameof(AdministrationEnabled));

				case 3026093994:
					return typeof(ServerSettings).GetProperty(nameof(AdministrationLogEnabled));

				case 1296337333:
					return typeof(ServerSettings).GetProperty(nameof(AdministrationTimeStampLogNames));

				case 4266105137:
					return typeof(ServerSettings).GetProperty(nameof(AdministrationEventsEnabled));

				case 3896564372:
					return typeof(ServerSettings).GetProperty(nameof(AdministrationServerNameRestricted));

				case 1104410157:
					return typeof(ServerSettings).GetProperty(nameof(ThreadedLoadingEnable));

				case 1260276984:
					return typeof(ServerSettings).GetProperty(nameof(VegetationEnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
