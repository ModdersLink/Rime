///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ServerSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable]
		public string InstancePath { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint RemoteControlPort { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float DuplicationChance { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MaxQueriesPerSecond { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float CorruptionChance { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable]
		public string RemoteAdministrationPort { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float MaxDropDuration { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float ReorderingChance { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float HumanHealthMultiplier { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable]
		public string ServerName { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float MinDropDuration { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public uint SaveGameVersion { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float PacketDrops { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float DropSpikeChance { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float MaxLatency { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public uint OutgoingRate { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public uint IncomingRate { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable]
		public string Playlist { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable]
		public string SavePoint { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float IngameTimeout { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float OutgoingFrequency { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float RespawnTimeModifier { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float MinLatency { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable]
		public string ServerPassword { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float TimeoutTime { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public uint PlayerCountNeededForMultiplayer { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float VehicleSpawnDelayModifier { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable]
		public string DebugMenuClick { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable]
		public string AdministrationPassword { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float LoadingTimeout { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public int DedicatedServerCpu { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public bool DeathmatchDebugInfo { get; set; } // 0x88 (136)
		
		[ContainerField(137), LayoutImmutable, Blittable]
		public bool TimeoutGame { get; set; } // 0x89 (137)
		
		[ContainerField(138), LayoutImmutable, Blittable]
		public bool AILooksIntoCamera { get; set; } // 0x8A (138)
		
		[ContainerField(139), LayoutImmutable, Blittable]
		public bool IsStatsEnabled { get; set; } // 0x8B (139)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public bool IsTreeDestructionEnabled { get; set; } // 0x8C (140)
		
		[ContainerField(141), LayoutImmutable, Blittable]
		public bool HavokCaptureToFile { get; set; } // 0x8D (141)
		
		[ContainerField(142), LayoutImmutable, Blittable]
		public bool ShowTriggerDebugText { get; set; } // 0x8E (142)
		
		[ContainerField(143), LayoutImmutable, Blittable]
		public bool IsInternetSimulationEnabled { get; set; } // 0x8F (143)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public bool DisableCutscenes { get; set; } // 0x90 (144)
		
		[ContainerField(145), LayoutImmutable, Blittable]
		public bool JobEnable { get; set; } // 0x91 (145)
		
		[ContainerField(146), LayoutImmutable, Blittable]
		public bool ThreadingEnable { get; set; } // 0x92 (146)
		
		[ContainerField(147), LayoutImmutable, Blittable]
		public bool DrawActivePhysicsObjects { get; set; } // 0x93 (147)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool IsRanked { get; set; } // 0x94 (148)
		
		[ContainerField(149), LayoutImmutable, Blittable]
		public bool UnlockResolver { get; set; } // 0x95 (149)
		
		[ContainerField(150), LayoutImmutable, Blittable]
		public bool ScoringLogEnabled { get; set; } // 0x96 (150)
		
		[ContainerField(151), LayoutImmutable, Blittable]
		public bool HavokVisualDebugger { get; set; } // 0x97 (151)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public bool IsSoldierDetailedCollisionEnabled { get; set; } // 0x98 (152)
		
		[ContainerField(153), LayoutImmutable, Blittable]
		public bool LoadSavePoint { get; set; } // 0x99 (153)
		
		[ContainerField(154), LayoutImmutable, Blittable]
		public bool IsSoldierAnimationEnabled { get; set; } // 0x9A (154)
		
		[ContainerField(155), LayoutImmutable, Blittable]
		public bool IsAiEnabled { get; set; } // 0x9B (155)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public bool IsReconfigurable { get; set; } // 0x9C (156)
		
		[ContainerField(157), LayoutImmutable, Blittable]
		public bool IsDestructionEnabled { get; set; } // 0x9D (157)
		
		[ContainerField(158), LayoutImmutable, Blittable]
		public bool ForcePlaylist { get; set; } // 0x9E (158)
		
		[ContainerField(159), LayoutImmutable, Blittable]
		public bool IsNetworkStatsEnabled { get; set; } // 0x9F (159)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public bool AutoUnspawnBangers { get; set; } // 0xA0 (160)
		
		[ContainerField(161), LayoutImmutable, Blittable]
		public bool RegulatedAIThrottle { get; set; } // 0xA1 (161)
		
		[ContainerField(162), LayoutImmutable, Blittable]
		public bool EnableAnimationCulling { get; set; } // 0xA2 (162)
		
		[ContainerField(163), LayoutImmutable, Blittable]
		public bool FallBackToSquadSpawn { get; set; } // 0xA3 (163)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public bool AllowIndestructibleParts { get; set; } // 0xA4 (164)
		
		[ContainerField(165), LayoutImmutable, Blittable]
		public bool IsPresenceEnabled { get; set; } // 0xA5 (165)
		
		[ContainerField(166), LayoutImmutable, Blittable]
		public bool WaterPhysicsEnabled { get; set; } // 0xA6 (166)
		
		[ContainerField(167), LayoutImmutable, Blittable]
		public bool RespawnOnDeathPosition { get; set; } // 0xA7 (167)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public bool IsRenderDamageEvents { get; set; } // 0xA8 (168)
		
		[ContainerField(169), LayoutImmutable, Blittable]
		public bool VehicleSpawnAllowed { get; set; } // 0xA9 (169)
		
		[ContainerField(170), LayoutImmutable, Blittable]
		public bool QueryProviderEnabled { get; set; } // 0xAA (170)
		
		[ContainerField(171), LayoutImmutable, Blittable]
		public bool IsDesertingAllowed { get; set; } // 0xAB (171)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public bool DebrisClusterEnabled { get; set; } // 0xAC (172)
		
		[ContainerField(173), LayoutImmutable, Blittable]
		public bool AdministrationEnabled { get; set; } // 0xAD (173)
		
		[ContainerField(174), LayoutImmutable, Blittable]
		public bool AdministrationLogEnabled { get; set; } // 0xAE (174)
		
		[ContainerField(175), LayoutImmutable, Blittable]
		public bool AdministrationTimeStampLogNames { get; set; } // 0xAF (175)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public bool AdministrationEventsEnabled { get; set; } // 0xB0 (176)
		
		[ContainerField(177), LayoutImmutable, Blittable]
		public bool AdministrationServerNameRestricted { get; set; } // 0xB1 (177)
		
		[ContainerField(178), LayoutImmutable, Blittable]
		public bool ThreadedLoadingEnable { get; set; } // 0xB2 (178)
		
		[ContainerField(179), LayoutImmutable, Blittable]
		public bool VegetationEnabled { get; set; } // 0xB3 (179)
		
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
