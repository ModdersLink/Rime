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

using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 192)]
public class GameSettings
	: fb.Core.SystemSettings
{
	public GameSettings()
	{
		//SystemSettings
		Name = @"Game";
		Platform = GamePlatform.GamePlatform_Invalid;
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint MaxPlayerCount { get; set; } = 70;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint MaxSpectatorCount { get; set; } = 0;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint MinPlayerCountElimination { get; set; } = 6;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public LogFileCollisionMode LogFileCollisionMode { get; set; } = fb.GameShared.LogFileCollisionMode.LFCM_Overwrite;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint LogFileRotationHistoryLength { get; set; } = 20;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string Level { get; set; } = @"Game.Level is not set in Game.cfg";
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string StartPoint { get; set; } = string.Empty;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public RefArray<InputConfigurationAsset> InputConfiguration { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public TeamId DefaultTeamId { get; set; } = TeamId.Team1;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public uint PS3ContentRatingAge { get; set; } = 0;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public uint LogHistory { get; set; } = 20;
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<VersionData> Version { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<SubWorldInclusion> LayerInclusionTable { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public string DefaultLayerInclusion { get; set; } = string.Empty;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float TimeBeforeSpawnIsAllowed { get; set; } = 10.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float LevelWarmUpTime { get; set; } = 10.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float TimeToWaitForQuitTaskCompletion { get; set; } = 10.000f;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<PlayerData> Player { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<DifficultyDatas> DifficultySettings { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public int DifficultyIndex { get; set; } = -1;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public SKU CurrentSKU { get; set; } = SKU.WW;
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public RefArray<GameSettingsComponent> GameSettingsComponents { get; set; } = new();
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public bool LogFileEnable { get; set; } = true;
	
	[ContainerField(0xa9), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
	public bool ResourceRefreshAlwaysAllowed { get; set; } = false;
	
	[ContainerField(0xaa), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
	public bool UseSpeedBasedDetailedCollision { get; set; } = false;
	
	[ContainerField(0xab), LayoutImmutable, Blittable, JsonProperty(Order = 171)]
	public bool UseSingleWeaponSelector { get; set; } = false;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public bool AutoAimEnabled { get; set; } = true;
	
	[ContainerField(0xad), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
	public bool HasUnlimitedAmmo { get; set; } = false;
	
	[ContainerField(0xae), LayoutImmutable, Blittable, JsonProperty(Order = 174)]
	public bool HasUnlimitedMags { get; set; } = false;
	
	[ContainerField(0xaf), LayoutImmutable, Blittable, JsonProperty(Order = 175)]
	public bool RotateLogs { get; set; } = false;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public bool AdjustVehicleCenterOfMass { get; set; } = true;
	
	[ContainerField(0xb1), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
	public bool AimAssistEnabled { get; set; } = true;
	
	[ContainerField(0xb2), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
	public bool AimAssistUsePolynomials { get; set; } = true;
	
	[ContainerField(0xb3), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
	public bool ForceFreeStreaming { get; set; } = false;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public bool ForceDisableFreeStreaming { get; set; } = false;
	
	[ContainerField(0xb5), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
	public bool IsGodMode { get; set; } = false;
	
	[ContainerField(0xb6), LayoutImmutable, Blittable, JsonProperty(Order = 182)]
	public bool IsJesusMode { get; set; } = false;
	
	[ContainerField(0xb7), LayoutImmutable, Blittable, JsonProperty(Order = 183)]
	public bool IsJesusModeAi { get; set; } = false;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public bool CoreParallelDispatchJobsEnabled { get; set; } = true;
	
	[ContainerField(0xb9), LayoutImmutable, Blittable, JsonProperty(Order = 185)]
	public bool GameAdministrationEnabled { get; set; } = true;
	
	[ContainerField(0xba), LayoutImmutable, Blittable, JsonProperty(Order = 186)]
	public bool AllowDestructionOutsideCombatArea { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxPlayerCount);
		p_Writer.Write(MaxSpectatorCount);
		p_Writer.Write(MinPlayerCountElimination);
		p_Writer.Write((int) LogFileCollisionMode);
		p_Writer.Write(LogFileRotationHistoryLength);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(Level));
		p_Writer.Write(p_EbxWriter.WriteString(StartPoint));
		(RimeWriter Writer, uint ArrayIndex) s_InputConfiguration = p_EbxWriter.GetArrayWriter(InputConfiguration.GetType(), InputConfiguration.Count);
		p_Writer.Write(s_InputConfiguration.ArrayIndex);
		foreach (var s_Entry in InputConfiguration)
		{
			s_InputConfiguration.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) DefaultTeamId);
		p_Writer.Write(PS3ContentRatingAge);
		p_Writer.Write(LogHistory);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Version));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LayerInclusionTable));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(DefaultLayerInclusion));
		p_Writer.Write(TimeBeforeSpawnIsAllowed);
		p_Writer.Write(LevelWarmUpTime);
		p_Writer.Write(TimeToWaitForQuitTaskCompletion);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Player));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DifficultySettings));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DifficultyIndex);
		p_Writer.Write((int) CurrentSKU);
		(RimeWriter Writer, uint ArrayIndex) s_GameSettingsComponents = p_EbxWriter.GetArrayWriter(GameSettingsComponents.GetType(), GameSettingsComponents.Count);
		p_Writer.Write(s_GameSettingsComponents.ArrayIndex);
		foreach (var s_Entry in GameSettingsComponents)
		{
			s_GameSettingsComponents.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(LogFileEnable);
		p_Writer.Write(ResourceRefreshAlwaysAllowed);
		p_Writer.Write(UseSpeedBasedDetailedCollision);
		p_Writer.Write(UseSingleWeaponSelector);
		p_Writer.Write(AutoAimEnabled);
		p_Writer.Write(HasUnlimitedAmmo);
		p_Writer.Write(HasUnlimitedMags);
		p_Writer.Write(RotateLogs);
		p_Writer.Write(AdjustVehicleCenterOfMass);
		p_Writer.Write(AimAssistEnabled);
		p_Writer.Write(AimAssistUsePolynomials);
		p_Writer.Write(ForceFreeStreaming);
		p_Writer.Write(ForceDisableFreeStreaming);
		p_Writer.Write(IsGodMode);
		p_Writer.Write(IsJesusMode);
		p_Writer.Write(IsJesusModeAi);
		p_Writer.Write(CoreParallelDispatchJobsEnabled);
		p_Writer.Write(GameAdministrationEnabled);
		p_Writer.Write(AllowDestructionOutsideCombatArea);
		p_Writer.WriteNullBytes(5);
	}
}

