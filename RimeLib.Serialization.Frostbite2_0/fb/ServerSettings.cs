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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 180)]
	public partial class ServerSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _InstancePath = string.Empty;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _RemoteControlPort;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _DuplicationChance;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _MaxQueriesPerSecond;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _CorruptionChance;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		private string _RemoteAdministrationPort = string.Empty;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _MaxDropDuration;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _ReorderingChance;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _HumanHealthMultiplier;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		private string _ServerName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _MinDropDuration;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private uint _SaveGameVersion;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _PacketDrops;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _DropSpikeChance;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _MaxLatency;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private uint _OutgoingRate;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private uint _IncomingRate;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, JsonProperty(Order = 80)]
		private string _Playlist = string.Empty;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, JsonProperty(Order = 84)]
		private string _SavePoint = string.Empty;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _IngameTimeout;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _OutgoingFrequency;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _RespawnTimeModifier;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _MinLatency;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		private string _ServerPassword = string.Empty;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _TimeoutTime;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private uint _PlayerCountNeededForMultiplayer;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _VehicleSpawnDelayModifier;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, JsonProperty(Order = 120)]
		private string _DebugMenuClick = string.Empty;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, JsonProperty(Order = 124)]
		private string _AdministrationPassword = string.Empty;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _LoadingTimeout;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private int _DedicatedServerCpu;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private bool _DeathmatchDebugInfo;

		[ObservableProperty]
		[property: ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		private bool _TimeoutGame;

		[ObservableProperty]
		[property: ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		private bool _AILooksIntoCamera;

		[ObservableProperty]
		[property: ContainerField(139), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
		private bool _IsStatsEnabled;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private bool _IsTreeDestructionEnabled;

		[ObservableProperty]
		[property: ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		private bool _HavokCaptureToFile;

		[ObservableProperty]
		[property: ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		private bool _ShowTriggerDebugText;

		[ObservableProperty]
		[property: ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		private bool _IsInternetSimulationEnabled;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private bool _DisableCutscenes;

		[ObservableProperty]
		[property: ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		private bool _JobEnable;

		[ObservableProperty]
		[property: ContainerField(146), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
		private bool _ThreadingEnable;

		[ObservableProperty]
		[property: ContainerField(147), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
		private bool _DrawActivePhysicsObjects;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private bool _IsRanked;

		[ObservableProperty]
		[property: ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		private bool _UnlockResolver;

		[ObservableProperty]
		[property: ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		private bool _ScoringLogEnabled;

		[ObservableProperty]
		[property: ContainerField(151), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
		private bool _HavokVisualDebugger;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private bool _IsSoldierDetailedCollisionEnabled;

		[ObservableProperty]
		[property: ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		private bool _LoadSavePoint;

		[ObservableProperty]
		[property: ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		private bool _IsSoldierAnimationEnabled;

		[ObservableProperty]
		[property: ContainerField(155), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
		private bool _IsAiEnabled;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private bool _IsReconfigurable;

		[ObservableProperty]
		[property: ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		private bool _IsDestructionEnabled;

		[ObservableProperty]
		[property: ContainerField(158), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
		private bool _ForcePlaylist;

		[ObservableProperty]
		[property: ContainerField(159), LayoutImmutable, Blittable, JsonProperty(Order = 159)]
		private bool _IsNetworkStatsEnabled;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private bool _AutoUnspawnBangers;

		[ObservableProperty]
		[property: ContainerField(161), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
		private bool _RegulatedAIThrottle;

		[ObservableProperty]
		[property: ContainerField(162), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
		private bool _EnableAnimationCulling;

		[ObservableProperty]
		[property: ContainerField(163), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
		private bool _FallBackToSquadSpawn;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private bool _AllowIndestructibleParts;

		[ObservableProperty]
		[property: ContainerField(165), LayoutImmutable, Blittable, JsonProperty(Order = 165)]
		private bool _IsPresenceEnabled;

		[ObservableProperty]
		[property: ContainerField(166), LayoutImmutable, Blittable, JsonProperty(Order = 166)]
		private bool _WaterPhysicsEnabled;

		[ObservableProperty]
		[property: ContainerField(167), LayoutImmutable, Blittable, JsonProperty(Order = 167)]
		private bool _RespawnOnDeathPosition;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private bool _IsRenderDamageEvents;

		[ObservableProperty]
		[property: ContainerField(169), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
		private bool _VehicleSpawnAllowed;

		[ObservableProperty]
		[property: ContainerField(170), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
		private bool _QueryProviderEnabled;

		[ObservableProperty]
		[property: ContainerField(171), LayoutImmutable, Blittable, JsonProperty(Order = 171)]
		private bool _IsDesertingAllowed;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private bool _DebrisClusterEnabled;

		[ObservableProperty]
		[property: ContainerField(173), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
		private bool _AdministrationEnabled;

		[ObservableProperty]
		[property: ContainerField(174), LayoutImmutable, Blittable, JsonProperty(Order = 174)]
		private bool _AdministrationLogEnabled;

		[ObservableProperty]
		[property: ContainerField(175), LayoutImmutable, Blittable, JsonProperty(Order = 175)]
		private bool _AdministrationTimeStampLogNames;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private bool _AdministrationEventsEnabled;

		[ObservableProperty]
		[property: ContainerField(177), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
		private bool _AdministrationServerNameRestricted;

		[ObservableProperty]
		[property: ContainerField(178), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
		private bool _ThreadedLoadingEnable;

		[ObservableProperty]
		[property: ContainerField(179), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
		private bool _VegetationEnabled;

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
