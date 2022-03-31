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

namespace fb
{
	[ContainerType(4, 120)]
	public class GameSettings :
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint MaxPlayerCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint MaxSpectatorCount { get; set; }

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<SubWorldInclusion> LayerInclusionTable { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public LogFileCollisionMode LogFileCollisionMode { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint LogFileRotationHistoryLength { get; set; }

		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string Level { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string DefaultLayerInclusion { get; set; } = string.Empty;

		[ContainerField(40), JsonProperty(Order = 40)]
		public RefArray<InputConfigurationAsset> InputConfiguration { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public TeamId DefaultTeamId { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float LevelWarmUpTime { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float TimeToWaitForQuitTaskCompletion { get; set; }

		[ContainerField(56), JsonProperty(Order = 56)]
		public GamePlatform Platform { get; set; } = new();

		[ContainerField(60), JsonProperty(Order = 60)]
		public CtrRef<VersionData> Version { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public uint PS3ContentRatingAge { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public int DifficultyIndex { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float TimeBeforeSpawnIsAllowed { get; set; }

		[ContainerField(76), JsonProperty(Order = 76)]
		public CtrRef<SoldierWeaponSwitchingData> SoldierWeaponSwitching { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public uint LogHistory { get; set; }

		[ContainerField(84), JsonProperty(Order = 84)]
		public CtrRef<DifficultyDatas> DifficultySettings { get; set; } = new();

		[ContainerField(88), JsonProperty(Order = 88)]
		public RefArray<BlueprintBundleMetadataContainer> MetadataContainers { get; set; } = new();

		[ContainerField(92), JsonProperty(Order = 92)]
		public SKU CurrentSKU { get; set; } = new();

		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<PlayerData> Player { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public bool LogFileEnable { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		public bool RotateLogs { get; set; }

		[ContainerField(102), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
		public bool EnableLoadingProfile { get; set; }

		[ContainerField(103), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
		public bool AdjustVehicleCenterOfMass { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public bool AutoAimEnabled { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		public bool HasUnlimitedAmmo { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
		public bool HasUnlimitedMags { get; set; }

		[ContainerField(107), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
		public bool ResourceRefreshAlwaysAllowed { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool UseSpeedBasedDetailedCollision { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		public bool AimAssistEnabled { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
		public bool AimAssistUsePolynomials { get; set; }

		[ContainerField(111), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
		public bool ForceFreeStreaming { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public bool ForceDisableFreeStreaming { get; set; }

		[ContainerField(113), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
		public bool IsGodMode { get; set; }

		[ContainerField(114), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
		public bool IsJesusMode { get; set; }

		[ContainerField(115), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
		public bool IsJesusModeAi { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public bool UseSingleWeaponSelector { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		public bool GameAdministrationEnabled { get; set; }

		[ContainerField(118), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
		public bool AllowDestructionOutsideCombatArea { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MaxPlayerCount);
			p_Writer.Write(MaxSpectatorCount);
			p_Writer.Write(p_EbxWriter.WriteImport(LayerInclusionTable));
			p_Writer.Write((int) LogFileCollisionMode);
			p_Writer.Write(LogFileRotationHistoryLength);
			p_Writer.Write(p_EbxWriter.WriteString(Level));
			p_Writer.Write(p_EbxWriter.WriteString(DefaultLayerInclusion));
			(RimeWriter Writer, uint ArrayIndex) s_InputConfiguration = p_EbxWriter.GetArrayWriter(InputConfiguration.GetType(), InputConfiguration.Count);
			p_Writer.Write(s_InputConfiguration.ArrayIndex);
			foreach (var s_Entry in InputConfiguration)
			{
				s_InputConfiguration.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) DefaultTeamId);
			p_Writer.Write(LevelWarmUpTime);
			p_Writer.Write(TimeToWaitForQuitTaskCompletion);
			p_Writer.Write((int) Platform);
			p_Writer.Write(p_EbxWriter.WriteImport(Version));
			p_Writer.Write(PS3ContentRatingAge);
			p_Writer.Write(DifficultyIndex);
			p_Writer.Write(TimeBeforeSpawnIsAllowed);
			p_Writer.Write(p_EbxWriter.WriteImport(SoldierWeaponSwitching));
			p_Writer.Write(LogHistory);
			p_Writer.Write(p_EbxWriter.WriteImport(DifficultySettings));
			(RimeWriter Writer, uint ArrayIndex) s_MetadataContainers = p_EbxWriter.GetArrayWriter(MetadataContainers.GetType(), MetadataContainers.Count);
			p_Writer.Write(s_MetadataContainers.ArrayIndex);
			foreach (var s_Entry in MetadataContainers)
			{
				s_MetadataContainers.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) CurrentSKU);
			p_Writer.Write(p_EbxWriter.WriteImport(Player));
			p_Writer.Write(LogFileEnable);
			p_Writer.Write(RotateLogs);
			p_Writer.Write(EnableLoadingProfile);
			p_Writer.Write(AdjustVehicleCenterOfMass);
			p_Writer.Write(AutoAimEnabled);
			p_Writer.Write(HasUnlimitedAmmo);
			p_Writer.Write(HasUnlimitedMags);
			p_Writer.Write(ResourceRefreshAlwaysAllowed);
			p_Writer.Write(UseSpeedBasedDetailedCollision);
			p_Writer.Write(AimAssistEnabled);
			p_Writer.Write(AimAssistUsePolynomials);
			p_Writer.Write(ForceFreeStreaming);
			p_Writer.Write(ForceDisableFreeStreaming);
			p_Writer.Write(IsGodMode);
			p_Writer.Write(IsJesusMode);
			p_Writer.Write(IsJesusModeAi);
			p_Writer.Write(UseSingleWeaponSelector);
			p_Writer.Write(GameAdministrationEnabled);
			p_Writer.Write(AllowDestructionOutsideCombatArea);
			p_Writer.WriteNullBytes(1);
		}
	}
}
