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
	public class LevelData : 
		WorldData
	{
		[ContainerField(48)]
		public CtrRef<ReferenceObjectData> LevelReference { get; set; } = new();

		[ContainerField(52)]
		public PathfindingBlob PathfindingBlobInfo { get; set; } = new();

		[ContainerField(76)]
		public CtrRef<GameAISystem> AISystem { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable]
		public float WorldSizeXZ { get; set; }

		[ContainerField(84)]
		public LevelDescription LevelDescription { get; set; } = new();

		[ContainerField(100), LayoutImmutable]
		public string GameConfigurationName { get; set; } = string.Empty;

		[ContainerField(104)]
		public CtrRef<EmitterSystemAsset> EmitterSystemAsset { get; set; } = new();

		[ContainerField(108)]
		public RefArray<EmitterExclusionVolumeData> EmitterExclusionVolumes { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public float DefaultFOV { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float InfantryFOVMultiplier { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public uint MaxEntityBusNetworkCount { get; set; }

		[ContainerField(124)]
		public CtrRef<SoundStateSettingsAsset> SoundStates { get; set; } = new();

		[ContainerField(128)]
		public CtrRef<VoiceOverSystemAsset> VoiceOverSystem { get; set; } = new();

		[ContainerField(132)]
		public RefArray<VoiceOverLogicAsset> VoiceOverLogic { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable]
		public float MaxVehicleHeight { get; set; }

		[ContainerField(140)]
		public CtrRef<AnimatedSkeletonDatabase> AnimatedSkeletonDatabase { get; set; } = new();

		[ContainerField(144)]
		public CtrRef<EnlightenShaderDatabaseAsset> EnlightenShaderDatabase { get; set; } = new();

		[ContainerField(148)]
		public RefArray<AntProjectAsset> AntProjectAssets { get; set; } = new();

		[ContainerField(152), LayoutImmutable]
		public string AerialHeightmapData { get; set; } = string.Empty;

		[ContainerField(156)]
		public CtrRef<LevelAudioObstructionAsset> AudioObstructionInfo { get; set; } = new();

		[ContainerField(160)]
		public RefArray<CameraTransition> CameraTransitions { get; set; } = new();

		[ContainerField(164)]
		public RefArray<CameraModeAsset> CameraModes { get; set; } = new();

		[ContainerField(168)]
		public CtrRef<FaceAnimationWaveMappings> FaceAnimationsWaveMappings { get; set; } = new();

		[ContainerField(172)]
		public CtrRef<Asset> HackForceBuild { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public bool HugeBroadPhase { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable]
		public bool FreeStreamingEnable { get; set; }

	}
}
