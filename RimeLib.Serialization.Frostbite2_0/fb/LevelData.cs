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

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(LevelReference));
			PathfindingBlobInfo.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(AISystem));
			p_Writer.Write(WorldSizeXZ);
			LevelDescription.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(GameConfigurationName));
			p_Writer.Write(p_EbxWriter.WriteImport(EmitterSystemAsset));
			(RimeWriter Writer, uint ArrayIndex) s_EmitterExclusionVolumes = p_EbxWriter.GetArrayWriter(EmitterExclusionVolumes.GetType(), EmitterExclusionVolumes.Count);
			p_Writer.Write(s_EmitterExclusionVolumes.ArrayIndex);
			foreach (var s_Entry in EmitterExclusionVolumes)
			{
				s_EmitterExclusionVolumes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(DefaultFOV);
			p_Writer.Write(InfantryFOVMultiplier);
			p_Writer.Write(MaxEntityBusNetworkCount);
			p_Writer.Write(p_EbxWriter.WriteImport(SoundStates));
			p_Writer.Write(p_EbxWriter.WriteImport(VoiceOverSystem));
			(RimeWriter Writer, uint ArrayIndex) s_VoiceOverLogic = p_EbxWriter.GetArrayWriter(VoiceOverLogic.GetType(), VoiceOverLogic.Count);
			p_Writer.Write(s_VoiceOverLogic.ArrayIndex);
			foreach (var s_Entry in VoiceOverLogic)
			{
				s_VoiceOverLogic.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(MaxVehicleHeight);
			p_Writer.Write(p_EbxWriter.WriteImport(AnimatedSkeletonDatabase));
			p_Writer.Write(p_EbxWriter.WriteImport(EnlightenShaderDatabase));
			(RimeWriter Writer, uint ArrayIndex) s_AntProjectAssets = p_EbxWriter.GetArrayWriter(AntProjectAssets.GetType(), AntProjectAssets.Count);
			p_Writer.Write(s_AntProjectAssets.ArrayIndex);
			foreach (var s_Entry in AntProjectAssets)
			{
				s_AntProjectAssets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteString(AerialHeightmapData));
			p_Writer.Write(p_EbxWriter.WriteImport(AudioObstructionInfo));
			(RimeWriter Writer, uint ArrayIndex) s_CameraTransitions = p_EbxWriter.GetArrayWriter(CameraTransitions.GetType(), CameraTransitions.Count);
			p_Writer.Write(s_CameraTransitions.ArrayIndex);
			foreach (var s_Entry in CameraTransitions)
			{
				s_CameraTransitions.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_CameraModes = p_EbxWriter.GetArrayWriter(CameraModes.GetType(), CameraModes.Count);
			p_Writer.Write(s_CameraModes.ArrayIndex);
			foreach (var s_Entry in CameraModes)
			{
				s_CameraModes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(FaceAnimationsWaveMappings));
			p_Writer.Write(p_EbxWriter.WriteImport(HackForceBuild));
			p_Writer.Write(HugeBroadPhase);
			p_Writer.Write(FreeStreamingEnable);
			p_Writer.WriteNullBytes(2);
		}
	}
}
