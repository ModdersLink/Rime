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
		public RefArray<InputConfigurationAsset> InputConfiguration { get; set; } = new();

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
		public RefArray<BlueprintBundleMetadataContainer> MetadataContainers { get; set; } = new();

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

	}
}
