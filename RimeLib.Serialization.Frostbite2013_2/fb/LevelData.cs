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

using fb.Entity;
using fb.Core;
using fb.Audio;
using fb.Render;
using fb.Ant;

namespace fb.GameShared;

[ContainerType(8, 304)]
public class LevelData
	: fb.Entity.WorldData
{
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<SubWorldReferenceObjectData> LevelReference { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<PathfindingBlobAsset> PathfindingBlobs { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<GameAISystem> AISystem { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<GameAISystem> AI2System { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float WorldSizeXZ { get; set; } = 0.000f;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public LevelDescription LevelDescription { get; set; } = new();
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public string GameConfigurationName { get; set; } = string.Empty;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float DefaultFOV { get; set; } = 55.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float InfantryFOVMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<StreamPoolPreset> StreamPoolPreset { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public CtrRef<VoiceOverSystemAsset> VoiceOverSystem { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public RefArray<VoiceOverLogicAsset> VoiceOverLogic { get; set; } = new();
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float MaxVehicleHeight { get; set; } = 1000.000f;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<EnlightenShaderDatabaseAsset> EnlightenShaderDatabase { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<AntProjectAsset> AntProjectAsset { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public string AerialHeightmapData { get; set; } = string.Empty;
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public RefArray<CameraModeAsset> CameraModes { get; set; } = new();
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public RefArray<CameraTransition> CameraTransitions { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public LevelPreloadInfo PreloadInfo { get; set; } = new();
	
	[ContainerField(0x110), JsonProperty(Order = 272)]
	public CtrRef<FaceAnimationWaveMappings> FaceAnimationsWaveMappings { get; set; } = new();
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public List<string> AutoLoadBundles { get; set; } = new();
	
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public UnlockIdTable UnlockIdTable { get; set; } = new();
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public float MaxFreeCameraHeight { get; set; } = 0.000f;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public bool HugeBroadPhase { get; set; } = false;
	
	[ContainerField(0x12d), LayoutImmutable, Blittable, JsonProperty(Order = 301)]
	public bool FreeStreamingEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(LevelReference));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PathfindingBlobs));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AISystem));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AI2System));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(WorldSizeXZ);
		p_Writer.WriteNullBytes(4);
		LevelDescription.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(GameConfigurationName));
		p_Writer.Write(DefaultFOV);
		p_Writer.Write(InfantryFOVMultiplier);
		p_Writer.Write(p_EbxWriter.WriteImport(StreamPoolPreset));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(VoiceOverSystem));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_VoiceOverLogic = p_EbxWriter.GetArrayWriter(VoiceOverLogic.GetType(), VoiceOverLogic.Count);
		p_Writer.Write(s_VoiceOverLogic.ArrayIndex);
		foreach (var s_Entry in VoiceOverLogic)
		{
			s_VoiceOverLogic.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MaxVehicleHeight);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(EnlightenShaderDatabase));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AntProjectAsset));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(AerialHeightmapData));
		(RimeWriter Writer, uint ArrayIndex) s_CameraModes = p_EbxWriter.GetArrayWriter(CameraModes.GetType(), CameraModes.Count);
		p_Writer.Write(s_CameraModes.ArrayIndex);
		foreach (var s_Entry in CameraModes)
		{
			s_CameraModes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_CameraTransitions = p_EbxWriter.GetArrayWriter(CameraTransitions.GetType(), CameraTransitions.Count);
		p_Writer.Write(s_CameraTransitions.ArrayIndex);
		foreach (var s_Entry in CameraTransitions)
		{
			s_CameraTransitions.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		PreloadInfo.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(FaceAnimationsWaveMappings));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_AutoLoadBundles = p_EbxWriter.GetArrayWriter(AutoLoadBundles.GetType(), AutoLoadBundles.Count);
		p_Writer.Write(s_AutoLoadBundles.ArrayIndex);
		foreach (var s_Entry in AutoLoadBundles)
		{
			s_AutoLoadBundles.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		UnlockIdTable.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxFreeCameraHeight);
		p_Writer.Write(HugeBroadPhase);
		p_Writer.Write(FreeStreamingEnable);
		p_Writer.WriteNullBytes(2);
	}
}

