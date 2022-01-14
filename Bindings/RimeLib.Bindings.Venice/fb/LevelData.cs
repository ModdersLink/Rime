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
	[ContainerType(4, 180)]
	public class LevelData : 
		WorldData
	{
		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<ReferenceObjectData> LevelReference { get; set; } = new();

		[ContainerField(52), JsonProperty(Order = 52)]
		public PathfindingBlob PathfindingBlobInfo { get; set; } = new();

		[ContainerField(76), JsonProperty(Order = 76)]
		public CtrRef<GameAISystem> AISystem { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float WorldSizeXZ { get; set; }

		[ContainerField(84), JsonProperty(Order = 84)]
		public LevelDescription LevelDescription { get; set; } = new();

		[ContainerField(100), LayoutImmutable, JsonProperty(Order = 100)]
		public string GameConfigurationName { get; set; } = string.Empty;

		[ContainerField(104), JsonProperty(Order = 104)]
		public CtrRef<EmitterSystemAsset> EmitterSystemAsset { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public RefArray<EmitterExclusionVolumeData> EmitterExclusionVolumes { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float DefaultFOV { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float InfantryFOVMultiplier { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public uint MaxEntityBusNetworkCount { get; set; }

		[ContainerField(124), JsonProperty(Order = 124)]
		public CtrRef<SoundStateSettingsAsset> SoundStates { get; set; } = new();

		[ContainerField(128), JsonProperty(Order = 128)]
		public CtrRef<VoiceOverSystemAsset> VoiceOverSystem { get; set; } = new();

		[ContainerField(132), JsonProperty(Order = 132)]
		public RefArray<VoiceOverLogicAsset> VoiceOverLogic { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float MaxVehicleHeight { get; set; }

		[ContainerField(140), JsonProperty(Order = 140)]
		public CtrRef<AnimatedSkeletonDatabase> AnimatedSkeletonDatabase { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public CtrRef<EnlightenShaderDatabaseAsset> EnlightenShaderDatabase { get; set; } = new();

		[ContainerField(148), JsonProperty(Order = 148)]
		public RefArray<AntProjectAsset> AntProjectAssets { get; set; } = new();

		[ContainerField(152), LayoutImmutable, JsonProperty(Order = 152)]
		public string AerialHeightmapData { get; set; } = string.Empty;

		[ContainerField(156), JsonProperty(Order = 156)]
		public CtrRef<LevelAudioObstructionAsset> AudioObstructionInfo { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public RefArray<CameraTransition> CameraTransitions { get; set; } = new();

		[ContainerField(164), JsonProperty(Order = 164)]
		public RefArray<CameraModeAsset> CameraModes { get; set; } = new();

		[ContainerField(168), JsonProperty(Order = 168)]
		public CtrRef<FaceAnimationWaveMappings> FaceAnimationsWaveMappings { get; set; } = new();

		[ContainerField(172), JsonProperty(Order = 172)]
		public CtrRef<Asset> HackForceBuild { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public bool HugeBroadPhase { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
		public bool FreeStreamingEnable { get; set; }

	}
}
