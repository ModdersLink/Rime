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
	public class LevelData : 
		WorldData
	{
		[ContainerField(48)]
		public CtrRef<ReferenceObjectData> LevelReference { get; set; } = new CtrRef<ReferenceObjectData>(); // 0x30 (48)
		
		[ContainerField(52)]
		public PathfindingBlob PathfindingBlobInfo { get; set; } = new PathfindingBlob(); // 0x34 (52)
		
		[ContainerField(76)]
		public CtrRef<GameAISystem> AISystem { get; set; } = new CtrRef<GameAISystem>(); // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float WorldSizeXZ { get; set; } // 0x50 (80)
		
		[ContainerField(84)]
		public LevelDescription LevelDescription { get; set; } = new LevelDescription(); // 0x54 (84)
		
		[ContainerField(100), LayoutImmutable]
		public string GameConfigurationName { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<EmitterSystemAsset> EmitterSystemAsset { get; set; } = new CtrRef<EmitterSystemAsset>(); // 0x68 (104)
		
		[ContainerField(108)]
		public RefArray<EmitterExclusionVolumeData> EmitterExclusionVolumes { get; set; } = new RefArray<EmitterExclusionVolumeData>(); // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float DefaultFOV { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float InfantryFOVMultiplier { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public uint MaxEntityBusNetworkCount { get; set; } // 0x78 (120)
		
		[ContainerField(124)]
		public CtrRef<SoundStateSettingsAsset> SoundStates { get; set; } = new CtrRef<SoundStateSettingsAsset>(); // 0x7C (124)
		
		[ContainerField(128)]
		public CtrRef<VoiceOverSystemAsset> VoiceOverSystem { get; set; } = new CtrRef<VoiceOverSystemAsset>(); // 0x80 (128)
		
		[ContainerField(132)]
		public RefArray<VoiceOverLogicAsset> VoiceOverLogic { get; set; } = new RefArray<VoiceOverLogicAsset>(); // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float MaxVehicleHeight { get; set; } // 0x88 (136)
		
		[ContainerField(140)]
		public CtrRef<AnimatedSkeletonDatabase> AnimatedSkeletonDatabase { get; set; } = new CtrRef<AnimatedSkeletonDatabase>(); // 0x8C (140)
		
		[ContainerField(144)]
		public CtrRef<EnlightenShaderDatabaseAsset> EnlightenShaderDatabase { get; set; } = new CtrRef<EnlightenShaderDatabaseAsset>(); // 0x90 (144)
		
		[ContainerField(148)]
		public RefArray<AntProjectAsset> AntProjectAssets { get; set; } = new RefArray<AntProjectAsset>(); // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable]
		public string AerialHeightmapData { get; set; } // 0x98 (152)
		
		[ContainerField(156)]
		public CtrRef<LevelAudioObstructionAsset> AudioObstructionInfo { get; set; } = new CtrRef<LevelAudioObstructionAsset>(); // 0x9C (156)
		
		[ContainerField(160)]
		public RefArray<CameraTransition> CameraTransitions { get; set; } = new RefArray<CameraTransition>(); // 0xA0 (160)
		
		[ContainerField(164)]
		public RefArray<CameraModeAsset> CameraModes { get; set; } = new RefArray<CameraModeAsset>(); // 0xA4 (164)
		
		[ContainerField(168)]
		public CtrRef<FaceAnimationWaveMappings> FaceAnimationsWaveMappings { get; set; } = new CtrRef<FaceAnimationWaveMappings>(); // 0xA8 (168)
		
		[ContainerField(172)]
		public CtrRef<Asset> HackForceBuild { get; set; } = new CtrRef<Asset>(); // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public bool HugeBroadPhase { get; set; } // 0xB0 (176)
		
		[ContainerField(177), LayoutImmutable, Blittable]
		public bool FreeStreamingEnable { get; set; } // 0xB1 (177)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4191653592:
					LevelReference = (CtrRef<ReferenceObjectData>) p_Value;
					break;

				case 2411470432:
					PathfindingBlobInfo = (PathfindingBlob) p_Value;
					break;

				case 2765605864:
					AISystem = (CtrRef<GameAISystem>) p_Value;
					break;

				case 3734169344:
					WorldSizeXZ = (float) p_Value;
					break;

				case 1741285141:
					LevelDescription = (LevelDescription) p_Value;
					break;

				case 2876236092:
					GameConfigurationName = (string) p_Value;
					break;

				case 858786790:
					EmitterSystemAsset = (CtrRef<EmitterSystemAsset>) p_Value;
					break;

				case 247503444:
					EmitterExclusionVolumes = (RefArray<EmitterExclusionVolumeData>) p_Value;
					break;

				case 2143448529:
					DefaultFOV = (float) p_Value;
					break;

				case 3538640096:
					InfantryFOVMultiplier = (float) p_Value;
					break;

				case 109652627:
					MaxEntityBusNetworkCount = (uint) p_Value;
					break;

				case 4087884162:
					SoundStates = (CtrRef<SoundStateSettingsAsset>) p_Value;
					break;

				case 2563745432:
					VoiceOverSystem = (CtrRef<VoiceOverSystemAsset>) p_Value;
					break;

				case 2947014771:
					VoiceOverLogic = (RefArray<VoiceOverLogicAsset>) p_Value;
					break;

				case 3489491638:
					MaxVehicleHeight = (float) p_Value;
					break;

				case 3542888158:
					AnimatedSkeletonDatabase = (CtrRef<AnimatedSkeletonDatabase>) p_Value;
					break;

				case 3999247479:
					EnlightenShaderDatabase = (CtrRef<EnlightenShaderDatabaseAsset>) p_Value;
					break;

				case 1261757736:
					AntProjectAssets = (RefArray<AntProjectAsset>) p_Value;
					break;

				case 716637124:
					AerialHeightmapData = (string) p_Value;
					break;

				case 1104450255:
					AudioObstructionInfo = (CtrRef<LevelAudioObstructionAsset>) p_Value;
					break;

				case 2235180064:
					CameraTransitions = (RefArray<CameraTransition>) p_Value;
					break;

				case 3182808108:
					CameraModes = (RefArray<CameraModeAsset>) p_Value;
					break;

				case 1607015163:
					FaceAnimationsWaveMappings = (CtrRef<FaceAnimationWaveMappings>) p_Value;
					break;

				case 1034978383:
					HackForceBuild = (CtrRef<Asset>) p_Value;
					break;

				case 428788623:
					HugeBroadPhase = (bool) p_Value;
					break;

				case 2148797772:
					FreeStreamingEnable = (bool) p_Value;
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
				case 4191653592:
					return LevelReference;

				case 2411470432:
					return PathfindingBlobInfo;

				case 2765605864:
					return AISystem;

				case 3734169344:
					return WorldSizeXZ;

				case 1741285141:
					return LevelDescription;

				case 2876236092:
					return GameConfigurationName;

				case 858786790:
					return EmitterSystemAsset;

				case 247503444:
					return EmitterExclusionVolumes;

				case 2143448529:
					return DefaultFOV;

				case 3538640096:
					return InfantryFOVMultiplier;

				case 109652627:
					return MaxEntityBusNetworkCount;

				case 4087884162:
					return SoundStates;

				case 2563745432:
					return VoiceOverSystem;

				case 2947014771:
					return VoiceOverLogic;

				case 3489491638:
					return MaxVehicleHeight;

				case 3542888158:
					return AnimatedSkeletonDatabase;

				case 3999247479:
					return EnlightenShaderDatabase;

				case 1261757736:
					return AntProjectAssets;

				case 716637124:
					return AerialHeightmapData;

				case 1104450255:
					return AudioObstructionInfo;

				case 2235180064:
					return CameraTransitions;

				case 3182808108:
					return CameraModes;

				case 1607015163:
					return FaceAnimationsWaveMappings;

				case 1034978383:
					return HackForceBuild;

				case 428788623:
					return HugeBroadPhase;

				case 2148797772:
					return FreeStreamingEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4191653592:
					return typeof(LevelData).GetProperty(nameof(LevelReference));

				case 2411470432:
					return typeof(LevelData).GetProperty(nameof(PathfindingBlobInfo));

				case 2765605864:
					return typeof(LevelData).GetProperty(nameof(AISystem));

				case 3734169344:
					return typeof(LevelData).GetProperty(nameof(WorldSizeXZ));

				case 1741285141:
					return typeof(LevelData).GetProperty(nameof(LevelDescription));

				case 2876236092:
					return typeof(LevelData).GetProperty(nameof(GameConfigurationName));

				case 858786790:
					return typeof(LevelData).GetProperty(nameof(EmitterSystemAsset));

				case 247503444:
					return typeof(LevelData).GetProperty(nameof(EmitterExclusionVolumes));

				case 2143448529:
					return typeof(LevelData).GetProperty(nameof(DefaultFOV));

				case 3538640096:
					return typeof(LevelData).GetProperty(nameof(InfantryFOVMultiplier));

				case 109652627:
					return typeof(LevelData).GetProperty(nameof(MaxEntityBusNetworkCount));

				case 4087884162:
					return typeof(LevelData).GetProperty(nameof(SoundStates));

				case 2563745432:
					return typeof(LevelData).GetProperty(nameof(VoiceOverSystem));

				case 2947014771:
					return typeof(LevelData).GetProperty(nameof(VoiceOverLogic));

				case 3489491638:
					return typeof(LevelData).GetProperty(nameof(MaxVehicleHeight));

				case 3542888158:
					return typeof(LevelData).GetProperty(nameof(AnimatedSkeletonDatabase));

				case 3999247479:
					return typeof(LevelData).GetProperty(nameof(EnlightenShaderDatabase));

				case 1261757736:
					return typeof(LevelData).GetProperty(nameof(AntProjectAssets));

				case 716637124:
					return typeof(LevelData).GetProperty(nameof(AerialHeightmapData));

				case 1104450255:
					return typeof(LevelData).GetProperty(nameof(AudioObstructionInfo));

				case 2235180064:
					return typeof(LevelData).GetProperty(nameof(CameraTransitions));

				case 3182808108:
					return typeof(LevelData).GetProperty(nameof(CameraModes));

				case 1607015163:
					return typeof(LevelData).GetProperty(nameof(FaceAnimationsWaveMappings));

				case 1034978383:
					return typeof(LevelData).GetProperty(nameof(HackForceBuild));

				case 428788623:
					return typeof(LevelData).GetProperty(nameof(HugeBroadPhase));

				case 2148797772:
					return typeof(LevelData).GetProperty(nameof(FreeStreamingEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
