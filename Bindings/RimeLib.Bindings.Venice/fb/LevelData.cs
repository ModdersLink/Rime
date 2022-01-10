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
		public List<CtrRef<EmitterExclusionVolumeData>> EmitterExclusionVolumes { get; set; } = new();

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
		public List<CtrRef<VoiceOverLogicAsset>> VoiceOverLogic { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable]
		public float MaxVehicleHeight { get; set; }

		[ContainerField(140)]
		public CtrRef<AnimatedSkeletonDatabase> AnimatedSkeletonDatabase { get; set; } = new();

		[ContainerField(144)]
		public CtrRef<EnlightenShaderDatabaseAsset> EnlightenShaderDatabase { get; set; } = new();

		[ContainerField(148)]
		public List<CtrRef<AntProjectAsset>> AntProjectAssets { get; set; } = new();

		[ContainerField(152), LayoutImmutable]
		public string AerialHeightmapData { get; set; } = string.Empty;

		[ContainerField(156)]
		public CtrRef<LevelAudioObstructionAsset> AudioObstructionInfo { get; set; } = new();

		[ContainerField(160)]
		public List<CtrRef<CameraTransition>> CameraTransitions { get; set; } = new();

		[ContainerField(164)]
		public List<CtrRef<CameraModeAsset>> CameraModes { get; set; } = new();

		[ContainerField(168)]
		public CtrRef<FaceAnimationWaveMappings> FaceAnimationsWaveMappings { get; set; } = new();

		[ContainerField(172)]
		public CtrRef<Asset> HackForceBuild { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public bool HugeBroadPhase { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable]
		public bool FreeStreamingEnable { get; set; }

		public static void Deserialize(LevelData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LevelReference.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.PathfindingBlob.Deserialize(p_Instance.PathfindingBlobInfo, p_Reader, p_Parser);
			p_Instance.AISystem.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.WorldSizeXZ = p_Reader.ReadSingle();
			fb.LevelDescription.Deserialize(p_Instance.LevelDescription, p_Reader, p_Parser);
			p_Instance.GameConfigurationName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.EmitterSystemAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.EmitterExclusionVolumes.Clear();
			(RimeReader Reader, uint Count) s_EmitterExclusionVolumes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_EmitterExclusionVolumes.Count; ++i)
			{
				var s_CtrRef = new CtrRef<EmitterExclusionVolumeData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_EmitterExclusionVolumes.Reader.ReadUInt32()));
				p_Instance.EmitterExclusionVolumes.Add(s_CtrRef);
			}
			
			s_EmitterExclusionVolumes.Reader.Dispose();
			p_Instance.DefaultFOV = p_Reader.ReadSingle();
			p_Instance.InfantryFOVMultiplier = p_Reader.ReadSingle();
			p_Instance.MaxEntityBusNetworkCount = p_Reader.ReadUInt32();
			p_Instance.SoundStates.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.VoiceOverSystem.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.VoiceOverLogic.Clear();
			(RimeReader Reader, uint Count) s_VoiceOverLogic = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_VoiceOverLogic.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverLogicAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_VoiceOverLogic.Reader.ReadUInt32()));
				p_Instance.VoiceOverLogic.Add(s_CtrRef);
			}
			
			s_VoiceOverLogic.Reader.Dispose();
			p_Instance.MaxVehicleHeight = p_Reader.ReadSingle();
			p_Instance.AnimatedSkeletonDatabase.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.EnlightenShaderDatabase.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AntProjectAssets.Clear();
			(RimeReader Reader, uint Count) s_AntProjectAssets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AntProjectAssets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AntProjectAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_AntProjectAssets.Reader.ReadUInt32()));
				p_Instance.AntProjectAssets.Add(s_CtrRef);
			}
			
			s_AntProjectAssets.Reader.Dispose();
			p_Instance.AerialHeightmapData = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.AudioObstructionInfo.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CameraTransitions.Clear();
			(RimeReader Reader, uint Count) s_CameraTransitions = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_CameraTransitions.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CameraTransition>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_CameraTransitions.Reader.ReadUInt32()));
				p_Instance.CameraTransitions.Add(s_CtrRef);
			}
			
			s_CameraTransitions.Reader.Dispose();
			p_Instance.CameraModes.Clear();
			(RimeReader Reader, uint Count) s_CameraModes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_CameraModes.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CameraModeAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_CameraModes.Reader.ReadUInt32()));
				p_Instance.CameraModes.Add(s_CtrRef);
			}
			
			s_CameraModes.Reader.Dispose();
			p_Instance.FaceAnimationsWaveMappings.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.HackForceBuild.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.HugeBroadPhase = p_Reader.ReadBool();
			p_Instance.FreeStreamingEnable = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
