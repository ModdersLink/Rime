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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class LevelData : 
		WorldData
	{
		protected CtrRef<ReferenceObjectData> m_LevelReference = new CtrRef<ReferenceObjectData>();
		[ContainerField(48), MemberInfoFlag(53), ContainerFieldNameHash(4191653592), ContainerCtrRef]
		public CtrRef<ReferenceObjectData> LevelReference { get { return m_LevelReference; } set { if (OnPropertyChanging("LevelData." + nameof(LevelReference), this, m_LevelReference, value)) m_LevelReference = value; } } // 0x30 (48)
		
		protected PathfindingBlob m_PathfindingBlobInfo = new PathfindingBlob();
		[ContainerField(52), MemberInfoFlag(41), ContainerFieldNameHash(2411470432)]
		public PathfindingBlob PathfindingBlobInfo { get { return m_PathfindingBlobInfo; } set { if (OnPropertyChanging("LevelData." + nameof(PathfindingBlobInfo), this, m_PathfindingBlobInfo, value)) m_PathfindingBlobInfo = value; } } // 0x34 (52)
		
		protected CtrRef<GameAISystem> m_AISystem = new CtrRef<GameAISystem>();
		[ContainerField(76), MemberInfoFlag(53), ContainerFieldNameHash(2765605864), ContainerCtrRef]
		public CtrRef<GameAISystem> AISystem { get { return m_AISystem; } set { if (OnPropertyChanging("LevelData." + nameof(AISystem), this, m_AISystem, value)) m_AISystem = value; } } // 0x4C (76)
		
		protected float m_WorldSizeXZ = new float();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3734169344)]
		public float WorldSizeXZ { get { return m_WorldSizeXZ; } set { if (OnPropertyChanging("LevelData." + nameof(WorldSizeXZ), this, m_WorldSizeXZ, value)) m_WorldSizeXZ = value; } } // 0x50 (80)
		
		protected LevelDescription m_LevelDescription = new LevelDescription();
		[ContainerField(84), MemberInfoFlag(41), ContainerFieldNameHash(1741285141)]
		public LevelDescription LevelDescription { get { return m_LevelDescription; } set { if (OnPropertyChanging("LevelData." + nameof(LevelDescription), this, m_LevelDescription, value)) m_LevelDescription = value; } } // 0x54 (84)
		
		protected string m_GameConfigurationName = string.Empty;
		[ContainerField(100), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2876236092)]
		public string GameConfigurationName { get { return m_GameConfigurationName; } set { if (OnPropertyChanging("LevelData." + nameof(GameConfigurationName), this, m_GameConfigurationName, value)) m_GameConfigurationName = value; } } // 0x64 (100)
		
		protected CtrRef<EmitterSystemAsset> m_EmitterSystemAsset = new CtrRef<EmitterSystemAsset>();
		[ContainerField(104), MemberInfoFlag(53), ContainerFieldNameHash(858786790), ContainerCtrRef]
		public CtrRef<EmitterSystemAsset> EmitterSystemAsset { get { return m_EmitterSystemAsset; } set { if (OnPropertyChanging("LevelData." + nameof(EmitterSystemAsset), this, m_EmitterSystemAsset, value)) m_EmitterSystemAsset = value; } } // 0x68 (104)
		
		protected RefArray<EmitterExclusionVolumeData> m_EmitterExclusionVolumes = new RefArray<EmitterExclusionVolumeData>();
		[ContainerField(108), MemberInfoFlag(65), ContainerFieldNameHash(247503444), ContainerRefArray]
		public RefArray<EmitterExclusionVolumeData> EmitterExclusionVolumes { get { return m_EmitterExclusionVolumes; } set { if (OnPropertyChanging("LevelData." + nameof(EmitterExclusionVolumes), this, m_EmitterExclusionVolumes, value)) m_EmitterExclusionVolumes = value; } } // 0x6C (108)
		
		protected float m_DefaultFOV = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2143448529)]
		public float DefaultFOV { get { return m_DefaultFOV; } set { if (OnPropertyChanging("LevelData." + nameof(DefaultFOV), this, m_DefaultFOV, value)) m_DefaultFOV = value; } } // 0x70 (112)
		
		protected float m_InfantryFOVMultiplier = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3538640096)]
		public float InfantryFOVMultiplier { get { return m_InfantryFOVMultiplier; } set { if (OnPropertyChanging("LevelData." + nameof(InfantryFOVMultiplier), this, m_InfantryFOVMultiplier, value)) m_InfantryFOVMultiplier = value; } } // 0x74 (116)
		
		protected uint m_MaxEntityBusNetworkCount = new uint();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(109652627)]
		public uint MaxEntityBusNetworkCount { get { return m_MaxEntityBusNetworkCount; } set { if (OnPropertyChanging("LevelData." + nameof(MaxEntityBusNetworkCount), this, m_MaxEntityBusNetworkCount, value)) m_MaxEntityBusNetworkCount = value; } } // 0x78 (120)
		
		protected CtrRef<SoundStateSettingsAsset> m_SoundStates = new CtrRef<SoundStateSettingsAsset>();
		[ContainerField(124), MemberInfoFlag(53), ContainerFieldNameHash(4087884162), ContainerCtrRef]
		public CtrRef<SoundStateSettingsAsset> SoundStates { get { return m_SoundStates; } set { if (OnPropertyChanging("LevelData." + nameof(SoundStates), this, m_SoundStates, value)) m_SoundStates = value; } } // 0x7C (124)
		
		protected CtrRef<VoiceOverSystemAsset> m_VoiceOverSystem = new CtrRef<VoiceOverSystemAsset>();
		[ContainerField(128), MemberInfoFlag(53), ContainerFieldNameHash(2563745432), ContainerCtrRef]
		public CtrRef<VoiceOverSystemAsset> VoiceOverSystem { get { return m_VoiceOverSystem; } set { if (OnPropertyChanging("LevelData." + nameof(VoiceOverSystem), this, m_VoiceOverSystem, value)) m_VoiceOverSystem = value; } } // 0x80 (128)
		
		protected RefArray<VoiceOverLogicAsset> m_VoiceOverLogic = new RefArray<VoiceOverLogicAsset>();
		[ContainerField(132), MemberInfoFlag(65), ContainerFieldNameHash(2947014771), ContainerRefArray]
		public RefArray<VoiceOverLogicAsset> VoiceOverLogic { get { return m_VoiceOverLogic; } set { if (OnPropertyChanging("LevelData." + nameof(VoiceOverLogic), this, m_VoiceOverLogic, value)) m_VoiceOverLogic = value; } } // 0x84 (132)
		
		protected float m_MaxVehicleHeight = new float();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3489491638)]
		public float MaxVehicleHeight { get { return m_MaxVehicleHeight; } set { if (OnPropertyChanging("LevelData." + nameof(MaxVehicleHeight), this, m_MaxVehicleHeight, value)) m_MaxVehicleHeight = value; } } // 0x88 (136)
		
		protected CtrRef<AnimatedSkeletonDatabase> m_AnimatedSkeletonDatabase = new CtrRef<AnimatedSkeletonDatabase>();
		[ContainerField(140), MemberInfoFlag(53), ContainerFieldNameHash(3542888158), ContainerCtrRef]
		public CtrRef<AnimatedSkeletonDatabase> AnimatedSkeletonDatabase { get { return m_AnimatedSkeletonDatabase; } set { if (OnPropertyChanging("LevelData." + nameof(AnimatedSkeletonDatabase), this, m_AnimatedSkeletonDatabase, value)) m_AnimatedSkeletonDatabase = value; } } // 0x8C (140)
		
		protected CtrRef<EnlightenShaderDatabaseAsset> m_EnlightenShaderDatabase = new CtrRef<EnlightenShaderDatabaseAsset>();
		[ContainerField(144), MemberInfoFlag(53), ContainerFieldNameHash(3999247479), ContainerCtrRef]
		public CtrRef<EnlightenShaderDatabaseAsset> EnlightenShaderDatabase { get { return m_EnlightenShaderDatabase; } set { if (OnPropertyChanging("LevelData." + nameof(EnlightenShaderDatabase), this, m_EnlightenShaderDatabase, value)) m_EnlightenShaderDatabase = value; } } // 0x90 (144)
		
		protected RefArray<AntProjectAsset> m_AntProjectAssets = new RefArray<AntProjectAsset>();
		[ContainerField(148), MemberInfoFlag(65), ContainerFieldNameHash(1261757736), ContainerRefArray]
		public RefArray<AntProjectAsset> AntProjectAssets { get { return m_AntProjectAssets; } set { if (OnPropertyChanging("LevelData." + nameof(AntProjectAssets), this, m_AntProjectAssets, value)) m_AntProjectAssets = value; } } // 0x94 (148)
		
		protected string m_AerialHeightmapData = string.Empty;
		[ContainerField(152), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(716637124)]
		public string AerialHeightmapData { get { return m_AerialHeightmapData; } set { if (OnPropertyChanging("LevelData." + nameof(AerialHeightmapData), this, m_AerialHeightmapData, value)) m_AerialHeightmapData = value; } } // 0x98 (152)
		
		protected CtrRef<LevelAudioObstructionAsset> m_AudioObstructionInfo = new CtrRef<LevelAudioObstructionAsset>();
		[ContainerField(156), MemberInfoFlag(53), ContainerFieldNameHash(1104450255), ContainerCtrRef]
		public CtrRef<LevelAudioObstructionAsset> AudioObstructionInfo { get { return m_AudioObstructionInfo; } set { if (OnPropertyChanging("LevelData." + nameof(AudioObstructionInfo), this, m_AudioObstructionInfo, value)) m_AudioObstructionInfo = value; } } // 0x9C (156)
		
		protected RefArray<CameraTransition> m_CameraTransitions = new RefArray<CameraTransition>();
		[ContainerField(160), MemberInfoFlag(65), ContainerFieldNameHash(2235180064), ContainerRefArray]
		public RefArray<CameraTransition> CameraTransitions { get { return m_CameraTransitions; } set { if (OnPropertyChanging("LevelData." + nameof(CameraTransitions), this, m_CameraTransitions, value)) m_CameraTransitions = value; } } // 0xA0 (160)
		
		protected RefArray<CameraModeAsset> m_CameraModes = new RefArray<CameraModeAsset>();
		[ContainerField(164), MemberInfoFlag(65), ContainerFieldNameHash(3182808108), ContainerRefArray]
		public RefArray<CameraModeAsset> CameraModes { get { return m_CameraModes; } set { if (OnPropertyChanging("LevelData." + nameof(CameraModes), this, m_CameraModes, value)) m_CameraModes = value; } } // 0xA4 (164)
		
		protected CtrRef<FaceAnimationWaveMappings> m_FaceAnimationsWaveMappings = new CtrRef<FaceAnimationWaveMappings>();
		[ContainerField(168), MemberInfoFlag(53), ContainerFieldNameHash(1607015163), ContainerCtrRef]
		public CtrRef<FaceAnimationWaveMappings> FaceAnimationsWaveMappings { get { return m_FaceAnimationsWaveMappings; } set { if (OnPropertyChanging("LevelData." + nameof(FaceAnimationsWaveMappings), this, m_FaceAnimationsWaveMappings, value)) m_FaceAnimationsWaveMappings = value; } } // 0xA8 (168)
		
		protected CtrRef<Asset> m_HackForceBuild = new CtrRef<Asset>();
		[ContainerField(172), MemberInfoFlag(53), ContainerFieldNameHash(1034978383), ContainerCtrRef]
		public CtrRef<Asset> HackForceBuild { get { return m_HackForceBuild; } set { if (OnPropertyChanging("LevelData." + nameof(HackForceBuild), this, m_HackForceBuild, value)) m_HackForceBuild = value; } } // 0xAC (172)
		
		protected bool m_HugeBroadPhase = new bool();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(428788623)]
		public bool HugeBroadPhase { get { return m_HugeBroadPhase; } set { if (OnPropertyChanging("LevelData." + nameof(HugeBroadPhase), this, m_HugeBroadPhase, value)) m_HugeBroadPhase = value; } } // 0xB0 (176)
		
		protected bool m_FreeStreamingEnable = new bool();
		[ContainerField(177), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2148797772)]
		public bool FreeStreamingEnable { get { return m_FreeStreamingEnable; } set { if (OnPropertyChanging("LevelData." + nameof(FreeStreamingEnable), this, m_FreeStreamingEnable, value)) m_FreeStreamingEnable = value; } } // 0xB1 (177)
		
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
