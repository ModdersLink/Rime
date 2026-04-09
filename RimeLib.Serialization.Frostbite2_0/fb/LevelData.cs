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
	public partial class LevelData :
		WorldData
	{
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private CtrRef<ReferenceObjectData> _LevelReference = new();

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private PathfindingBlob _PathfindingBlobInfo = new();

		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private CtrRef<GameAISystem> _AISystem = new();

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _WorldSizeXZ;

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private LevelDescription _LevelDescription = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, JsonProperty(Order = 100)]
		private string _GameConfigurationName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private CtrRef<EmitterSystemAsset> _EmitterSystemAsset = new();

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private RefArray<EmitterExclusionVolumeData> _EmitterExclusionVolumes = new();

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _DefaultFOV;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _InfantryFOVMultiplier;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private uint _MaxEntityBusNetworkCount;

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private CtrRef<SoundStateSettingsAsset> _SoundStates = new();

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private CtrRef<VoiceOverSystemAsset> _VoiceOverSystem = new();

		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private RefArray<VoiceOverLogicAsset> _VoiceOverLogic = new();

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _MaxVehicleHeight;

		[ObservableProperty]
		[property: ContainerField(140), JsonProperty(Order = 140)]
		private CtrRef<AnimatedSkeletonDatabase> _AnimatedSkeletonDatabase = new();

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private CtrRef<EnlightenShaderDatabaseAsset> _EnlightenShaderDatabase = new();

		[ObservableProperty]
		[property: ContainerField(148), JsonProperty(Order = 148)]
		private RefArray<AntProjectAsset> _AntProjectAssets = new();

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, JsonProperty(Order = 152)]
		private string _AerialHeightmapData = string.Empty;

		[ObservableProperty]
		[property: ContainerField(156), JsonProperty(Order = 156)]
		private CtrRef<LevelAudioObstructionAsset> _AudioObstructionInfo = new();

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private RefArray<CameraTransition> _CameraTransitions = new();

		[ObservableProperty]
		[property: ContainerField(164), JsonProperty(Order = 164)]
		private RefArray<CameraModeAsset> _CameraModes = new();

		[ObservableProperty]
		[property: ContainerField(168), JsonProperty(Order = 168)]
		private CtrRef<FaceAnimationWaveMappings> _FaceAnimationsWaveMappings = new();

		[ObservableProperty]
		[property: ContainerField(172), JsonProperty(Order = 172)]
		private CtrRef<Asset> _HackForceBuild = new();

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private bool _HugeBroadPhase;

		[ObservableProperty]
		[property: ContainerField(177), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
		private bool _FreeStreamingEnable;

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
