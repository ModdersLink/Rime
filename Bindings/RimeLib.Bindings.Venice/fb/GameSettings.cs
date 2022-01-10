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
	[ContainerType(4, 120)]
	public class GameSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint MaxPlayerCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint MaxSpectatorCount { get; set; }

		[ContainerField(20)]
		public CtrRef<SubWorldInclusion> LayerInclusionTable { get; set; } = new();

		[ContainerField(24)]
		public LogFileCollisionMode LogFileCollisionMode { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint LogFileRotationHistoryLength { get; set; }

		[ContainerField(32), LayoutImmutable]
		public string Level { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable]
		public string DefaultLayerInclusion { get; set; } = string.Empty;

		[ContainerField(40)]
		public List<CtrRef<InputConfigurationAsset>> InputConfiguration { get; set; } = new();

		[ContainerField(44)]
		public TeamId DefaultTeamId { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public float LevelWarmUpTime { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float TimeToWaitForQuitTaskCompletion { get; set; }

		[ContainerField(56)]
		public GamePlatform Platform { get; set; } = new();

		[ContainerField(60)]
		public CtrRef<VersionData> Version { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable]
		public uint PS3ContentRatingAge { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public int DifficultyIndex { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float TimeBeforeSpawnIsAllowed { get; set; }

		[ContainerField(76)]
		public CtrRef<SoldierWeaponSwitchingData> SoldierWeaponSwitching { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable]
		public uint LogHistory { get; set; }

		[ContainerField(84)]
		public CtrRef<DifficultyDatas> DifficultySettings { get; set; } = new();

		[ContainerField(88)]
		public List<CtrRef<BlueprintBundleMetadataContainer>> MetadataContainers { get; set; } = new();

		[ContainerField(92)]
		public SKU CurrentSKU { get; set; } = new();

		[ContainerField(96)]
		public CtrRef<PlayerData> Player { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool LogFileEnable { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable]
		public bool RotateLogs { get; set; }

		[ContainerField(102), LayoutImmutable, Blittable]
		public bool EnableLoadingProfile { get; set; }

		[ContainerField(103), LayoutImmutable, Blittable]
		public bool AdjustVehicleCenterOfMass { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool AutoAimEnabled { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool HasUnlimitedAmmo { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable]
		public bool HasUnlimitedMags { get; set; }

		[ContainerField(107), LayoutImmutable, Blittable]
		public bool ResourceRefreshAlwaysAllowed { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool UseSpeedBasedDetailedCollision { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool AimAssistEnabled { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable]
		public bool AimAssistUsePolynomials { get; set; }

		[ContainerField(111), LayoutImmutable, Blittable]
		public bool ForceFreeStreaming { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public bool ForceDisableFreeStreaming { get; set; }

		[ContainerField(113), LayoutImmutable, Blittable]
		public bool IsGodMode { get; set; }

		[ContainerField(114), LayoutImmutable, Blittable]
		public bool IsJesusMode { get; set; }

		[ContainerField(115), LayoutImmutable, Blittable]
		public bool IsJesusModeAi { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public bool UseSingleWeaponSelector { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable]
		public bool GameAdministrationEnabled { get; set; }

		[ContainerField(118), LayoutImmutable, Blittable]
		public bool AllowDestructionOutsideCombatArea { get; set; }

		public static void Deserialize(GameSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxPlayerCount = p_Reader.ReadUInt32();
			p_Instance.MaxSpectatorCount = p_Reader.ReadUInt32();
			p_Instance.LayerInclusionTable.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LogFileCollisionMode = (LogFileCollisionMode) p_Reader.ReadInt32();
			p_Instance.LogFileRotationHistoryLength = p_Reader.ReadUInt32();
			p_Instance.Level = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.DefaultLayerInclusion = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.InputConfiguration.Clear();
			(RimeReader Reader, uint Count) s_InputConfiguration = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InputConfiguration.Count; ++i)
			{
				var s_CtrRef = new CtrRef<InputConfigurationAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_InputConfiguration.Reader.ReadUInt32()));
				p_Instance.InputConfiguration.Add(s_CtrRef);
			}
			
			s_InputConfiguration.Reader.Dispose();
			p_Instance.DefaultTeamId = (TeamId) p_Reader.ReadInt32();
			p_Instance.LevelWarmUpTime = p_Reader.ReadSingle();
			p_Instance.TimeToWaitForQuitTaskCompletion = p_Reader.ReadSingle();
			p_Instance.Platform = (GamePlatform) p_Reader.ReadInt32();
			p_Instance.Version.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PS3ContentRatingAge = p_Reader.ReadUInt32();
			p_Instance.DifficultyIndex = p_Reader.ReadInt32();
			p_Instance.TimeBeforeSpawnIsAllowed = p_Reader.ReadSingle();
			p_Instance.SoldierWeaponSwitching.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LogHistory = p_Reader.ReadUInt32();
			p_Instance.DifficultySettings.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MetadataContainers.Clear();
			(RimeReader Reader, uint Count) s_MetadataContainers = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MetadataContainers.Count; ++i)
			{
				var s_CtrRef = new CtrRef<BlueprintBundleMetadataContainer>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_MetadataContainers.Reader.ReadUInt32()));
				p_Instance.MetadataContainers.Add(s_CtrRef);
			}
			
			s_MetadataContainers.Reader.Dispose();
			p_Instance.CurrentSKU = (SKU) p_Reader.ReadInt32();
			p_Instance.Player.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LogFileEnable = p_Reader.ReadBool();
			p_Instance.RotateLogs = p_Reader.ReadBool();
			p_Instance.EnableLoadingProfile = p_Reader.ReadBool();
			p_Instance.AdjustVehicleCenterOfMass = p_Reader.ReadBool();
			p_Instance.AutoAimEnabled = p_Reader.ReadBool();
			p_Instance.HasUnlimitedAmmo = p_Reader.ReadBool();
			p_Instance.HasUnlimitedMags = p_Reader.ReadBool();
			p_Instance.ResourceRefreshAlwaysAllowed = p_Reader.ReadBool();
			p_Instance.UseSpeedBasedDetailedCollision = p_Reader.ReadBool();
			p_Instance.AimAssistEnabled = p_Reader.ReadBool();
			p_Instance.AimAssistUsePolynomials = p_Reader.ReadBool();
			p_Instance.ForceFreeStreaming = p_Reader.ReadBool();
			p_Instance.ForceDisableFreeStreaming = p_Reader.ReadBool();
			p_Instance.IsGodMode = p_Reader.ReadBool();
			p_Instance.IsJesusMode = p_Reader.ReadBool();
			p_Instance.IsJesusModeAi = p_Reader.ReadBool();
			p_Instance.UseSingleWeaponSelector = p_Reader.ReadBool();
			p_Instance.GameAdministrationEnabled = p_Reader.ReadBool();
			p_Instance.AllowDestructionOutsideCombatArea = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
