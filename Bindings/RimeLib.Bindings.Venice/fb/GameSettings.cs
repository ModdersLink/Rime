///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class GameSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint MaxPlayerCount { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint MaxSpectatorCount { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<SubWorldInclusion> LayerInclusionTable { get; set; } = new CtrRef<SubWorldInclusion>(); // 0x14 (20)
		
		[ContainerField(24)]
		public LogFileCollisionMode LogFileCollisionMode { get; set; } = new LogFileCollisionMode(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint LogFileRotationHistoryLength { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable]
		public string Level { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable]
		public string DefaultLayerInclusion { get; set; } // 0x24 (36)
		
		[ContainerField(40)]
		public RefArray<InputConfigurationAsset> InputConfiguration { get; set; } = new RefArray<InputConfigurationAsset>(); // 0x28 (40)
		
		[ContainerField(44)]
		public TeamId DefaultTeamId { get; set; } = new TeamId(); // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float LevelWarmUpTime { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float TimeToWaitForQuitTaskCompletion { get; set; } // 0x34 (52)
		
		[ContainerField(56)]
		public GamePlatform Platform { get; set; } = new GamePlatform(); // 0x38 (56)
		
		[ContainerField(60)]
		public CtrRef<VersionData> Version { get; set; } = new CtrRef<VersionData>(); // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public uint PS3ContentRatingAge { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public int DifficultyIndex { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float TimeBeforeSpawnIsAllowed { get; set; } // 0x48 (72)
		
		[ContainerField(76)]
		public CtrRef<SoldierWeaponSwitchingData> SoldierWeaponSwitching { get; set; } = new CtrRef<SoldierWeaponSwitchingData>(); // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public uint LogHistory { get; set; } // 0x50 (80)
		
		[ContainerField(84)]
		public CtrRef<DifficultyDatas> DifficultySettings { get; set; } = new CtrRef<DifficultyDatas>(); // 0x54 (84)
		
		[ContainerField(88)]
		public RefArray<BlueprintBundleMetadataContainer> MetadataContainers { get; set; } = new RefArray<BlueprintBundleMetadataContainer>(); // 0x58 (88)
		
		[ContainerField(92)]
		public SKU CurrentSKU { get; set; } = new SKU(); // 0x5C (92)
		
		[ContainerField(96)]
		public CtrRef<PlayerData> Player { get; set; } = new CtrRef<PlayerData>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public bool LogFileEnable { get; set; } // 0x64 (100)
		
		[ContainerField(101), LayoutImmutable, Blittable]
		public bool RotateLogs { get; set; } // 0x65 (101)
		
		[ContainerField(102), LayoutImmutable, Blittable]
		public bool EnableLoadingProfile { get; set; } // 0x66 (102)
		
		[ContainerField(103), LayoutImmutable, Blittable]
		public bool AdjustVehicleCenterOfMass { get; set; } // 0x67 (103)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool AutoAimEnabled { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool HasUnlimitedAmmo { get; set; } // 0x69 (105)
		
		[ContainerField(106), LayoutImmutable, Blittable]
		public bool HasUnlimitedMags { get; set; } // 0x6A (106)
		
		[ContainerField(107), LayoutImmutable, Blittable]
		public bool ResourceRefreshAlwaysAllowed { get; set; } // 0x6B (107)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool UseSpeedBasedDetailedCollision { get; set; } // 0x6C (108)
		
		[ContainerField(109), LayoutImmutable, Blittable]
		public bool AimAssistEnabled { get; set; } // 0x6D (109)
		
		[ContainerField(110), LayoutImmutable, Blittable]
		public bool AimAssistUsePolynomials { get; set; } // 0x6E (110)
		
		[ContainerField(111), LayoutImmutable, Blittable]
		public bool ForceFreeStreaming { get; set; } // 0x6F (111)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public bool ForceDisableFreeStreaming { get; set; } // 0x70 (112)
		
		[ContainerField(113), LayoutImmutable, Blittable]
		public bool IsGodMode { get; set; } // 0x71 (113)
		
		[ContainerField(114), LayoutImmutable, Blittable]
		public bool IsJesusMode { get; set; } // 0x72 (114)
		
		[ContainerField(115), LayoutImmutable, Blittable]
		public bool IsJesusModeAi { get; set; } // 0x73 (115)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public bool UseSingleWeaponSelector { get; set; } // 0x74 (116)
		
		[ContainerField(117), LayoutImmutable, Blittable]
		public bool GameAdministrationEnabled { get; set; } // 0x75 (117)
		
		[ContainerField(118), LayoutImmutable, Blittable]
		public bool AllowDestructionOutsideCombatArea { get; set; } // 0x76 (118)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4192814593:
					MaxPlayerCount = (uint) p_Value;
					break;

				case 3946650923:
					MaxSpectatorCount = (uint) p_Value;
					break;

				case 1500062686:
					LayerInclusionTable = (CtrRef<SubWorldInclusion>) p_Value;
					break;

				case 3429178042:
					LogFileCollisionMode = (LogFileCollisionMode) Enum.ToObject(typeof(LogFileCollisionMode), p_Value);
					break;

				case 3548846413:
					LogFileRotationHistoryLength = (uint) p_Value;
					break;

				case 218262515:
					Level = (string) p_Value;
					break;

				case 4278341003:
					DefaultLayerInclusion = (string) p_Value;
					break;

				case 2676875651:
					InputConfiguration = (RefArray<InputConfigurationAsset>) p_Value;
					break;

				case 3990246590:
					DefaultTeamId = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 3353881322:
					LevelWarmUpTime = (float) p_Value;
					break;

				case 2225926219:
					TimeToWaitForQuitTaskCompletion = (float) p_Value;
					break;

				case 942751002:
					Platform = (GamePlatform) Enum.ToObject(typeof(GamePlatform), p_Value);
					break;

				case 747123679:
					Version = (CtrRef<VersionData>) p_Value;
					break;

				case 534892568:
					PS3ContentRatingAge = (uint) p_Value;
					break;

				case 302070728:
					DifficultyIndex = (int) p_Value;
					break;

				case 3672151792:
					TimeBeforeSpawnIsAllowed = (float) p_Value;
					break;

				case 2122873599:
					SoldierWeaponSwitching = (CtrRef<SoldierWeaponSwitchingData>) p_Value;
					break;

				case 1374192771:
					LogHistory = (uint) p_Value;
					break;

				case 1244447411:
					DifficultySettings = (CtrRef<DifficultyDatas>) p_Value;
					break;

				case 2114222460:
					MetadataContainers = (RefArray<BlueprintBundleMetadataContainer>) p_Value;
					break;

				case 1385383009:
					CurrentSKU = (SKU) Enum.ToObject(typeof(SKU), p_Value);
					break;

				case 3384765366:
					Player = (CtrRef<PlayerData>) p_Value;
					break;

				case 2156101894:
					LogFileEnable = (bool) p_Value;
					break;

				case 1480400363:
					RotateLogs = (bool) p_Value;
					break;

				case 456285193:
					EnableLoadingProfile = (bool) p_Value;
					break;

				case 589491054:
					AdjustVehicleCenterOfMass = (bool) p_Value;
					break;

				case 2330232810:
					AutoAimEnabled = (bool) p_Value;
					break;

				case 3689258814:
					HasUnlimitedAmmo = (bool) p_Value;
					break;

				case 3689677416:
					HasUnlimitedMags = (bool) p_Value;
					break;

				case 3415354971:
					ResourceRefreshAlwaysAllowed = (bool) p_Value;
					break;

				case 801331358:
					UseSpeedBasedDetailedCollision = (bool) p_Value;
					break;

				case 3924289354:
					AimAssistEnabled = (bool) p_Value;
					break;

				case 1082705757:
					AimAssistUsePolynomials = (bool) p_Value;
					break;

				case 428656304:
					ForceFreeStreaming = (bool) p_Value;
					break;

				case 2029153572:
					ForceDisableFreeStreaming = (bool) p_Value;
					break;

				case 568328144:
					IsGodMode = (bool) p_Value;
					break;

				case 314138150:
					IsJesusMode = (bool) p_Value;
					break;

				case 2794026990:
					IsJesusModeAi = (bool) p_Value;
					break;

				case 1670669515:
					UseSingleWeaponSelector = (bool) p_Value;
					break;

				case 2064959744:
					GameAdministrationEnabled = (bool) p_Value;
					break;

				case 1836790742:
					AllowDestructionOutsideCombatArea = (bool) p_Value;
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
				case 4192814593:
					return MaxPlayerCount;

				case 3946650923:
					return MaxSpectatorCount;

				case 1500062686:
					return LayerInclusionTable;

				case 3429178042:
					return LogFileCollisionMode;

				case 3548846413:
					return LogFileRotationHistoryLength;

				case 218262515:
					return Level;

				case 4278341003:
					return DefaultLayerInclusion;

				case 2676875651:
					return InputConfiguration;

				case 3990246590:
					return DefaultTeamId;

				case 3353881322:
					return LevelWarmUpTime;

				case 2225926219:
					return TimeToWaitForQuitTaskCompletion;

				case 942751002:
					return Platform;

				case 747123679:
					return Version;

				case 534892568:
					return PS3ContentRatingAge;

				case 302070728:
					return DifficultyIndex;

				case 3672151792:
					return TimeBeforeSpawnIsAllowed;

				case 2122873599:
					return SoldierWeaponSwitching;

				case 1374192771:
					return LogHistory;

				case 1244447411:
					return DifficultySettings;

				case 2114222460:
					return MetadataContainers;

				case 1385383009:
					return CurrentSKU;

				case 3384765366:
					return Player;

				case 2156101894:
					return LogFileEnable;

				case 1480400363:
					return RotateLogs;

				case 456285193:
					return EnableLoadingProfile;

				case 589491054:
					return AdjustVehicleCenterOfMass;

				case 2330232810:
					return AutoAimEnabled;

				case 3689258814:
					return HasUnlimitedAmmo;

				case 3689677416:
					return HasUnlimitedMags;

				case 3415354971:
					return ResourceRefreshAlwaysAllowed;

				case 801331358:
					return UseSpeedBasedDetailedCollision;

				case 3924289354:
					return AimAssistEnabled;

				case 1082705757:
					return AimAssistUsePolynomials;

				case 428656304:
					return ForceFreeStreaming;

				case 2029153572:
					return ForceDisableFreeStreaming;

				case 568328144:
					return IsGodMode;

				case 314138150:
					return IsJesusMode;

				case 2794026990:
					return IsJesusModeAi;

				case 1670669515:
					return UseSingleWeaponSelector;

				case 2064959744:
					return GameAdministrationEnabled;

				case 1836790742:
					return AllowDestructionOutsideCombatArea;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4192814593:
					return typeof(GameSettings).GetProperty(nameof(MaxPlayerCount));

				case 3946650923:
					return typeof(GameSettings).GetProperty(nameof(MaxSpectatorCount));

				case 1500062686:
					return typeof(GameSettings).GetProperty(nameof(LayerInclusionTable));

				case 3429178042:
					return typeof(GameSettings).GetProperty(nameof(LogFileCollisionMode));

				case 3548846413:
					return typeof(GameSettings).GetProperty(nameof(LogFileRotationHistoryLength));

				case 218262515:
					return typeof(GameSettings).GetProperty(nameof(Level));

				case 4278341003:
					return typeof(GameSettings).GetProperty(nameof(DefaultLayerInclusion));

				case 2676875651:
					return typeof(GameSettings).GetProperty(nameof(InputConfiguration));

				case 3990246590:
					return typeof(GameSettings).GetProperty(nameof(DefaultTeamId));

				case 3353881322:
					return typeof(GameSettings).GetProperty(nameof(LevelWarmUpTime));

				case 2225926219:
					return typeof(GameSettings).GetProperty(nameof(TimeToWaitForQuitTaskCompletion));

				case 942751002:
					return typeof(GameSettings).GetProperty(nameof(Platform));

				case 747123679:
					return typeof(GameSettings).GetProperty(nameof(Version));

				case 534892568:
					return typeof(GameSettings).GetProperty(nameof(PS3ContentRatingAge));

				case 302070728:
					return typeof(GameSettings).GetProperty(nameof(DifficultyIndex));

				case 3672151792:
					return typeof(GameSettings).GetProperty(nameof(TimeBeforeSpawnIsAllowed));

				case 2122873599:
					return typeof(GameSettings).GetProperty(nameof(SoldierWeaponSwitching));

				case 1374192771:
					return typeof(GameSettings).GetProperty(nameof(LogHistory));

				case 1244447411:
					return typeof(GameSettings).GetProperty(nameof(DifficultySettings));

				case 2114222460:
					return typeof(GameSettings).GetProperty(nameof(MetadataContainers));

				case 1385383009:
					return typeof(GameSettings).GetProperty(nameof(CurrentSKU));

				case 3384765366:
					return typeof(GameSettings).GetProperty(nameof(Player));

				case 2156101894:
					return typeof(GameSettings).GetProperty(nameof(LogFileEnable));

				case 1480400363:
					return typeof(GameSettings).GetProperty(nameof(RotateLogs));

				case 456285193:
					return typeof(GameSettings).GetProperty(nameof(EnableLoadingProfile));

				case 589491054:
					return typeof(GameSettings).GetProperty(nameof(AdjustVehicleCenterOfMass));

				case 2330232810:
					return typeof(GameSettings).GetProperty(nameof(AutoAimEnabled));

				case 3689258814:
					return typeof(GameSettings).GetProperty(nameof(HasUnlimitedAmmo));

				case 3689677416:
					return typeof(GameSettings).GetProperty(nameof(HasUnlimitedMags));

				case 3415354971:
					return typeof(GameSettings).GetProperty(nameof(ResourceRefreshAlwaysAllowed));

				case 801331358:
					return typeof(GameSettings).GetProperty(nameof(UseSpeedBasedDetailedCollision));

				case 3924289354:
					return typeof(GameSettings).GetProperty(nameof(AimAssistEnabled));

				case 1082705757:
					return typeof(GameSettings).GetProperty(nameof(AimAssistUsePolynomials));

				case 428656304:
					return typeof(GameSettings).GetProperty(nameof(ForceFreeStreaming));

				case 2029153572:
					return typeof(GameSettings).GetProperty(nameof(ForceDisableFreeStreaming));

				case 568328144:
					return typeof(GameSettings).GetProperty(nameof(IsGodMode));

				case 314138150:
					return typeof(GameSettings).GetProperty(nameof(IsJesusMode));

				case 2794026990:
					return typeof(GameSettings).GetProperty(nameof(IsJesusModeAi));

				case 1670669515:
					return typeof(GameSettings).GetProperty(nameof(UseSingleWeaponSelector));

				case 2064959744:
					return typeof(GameSettings).GetProperty(nameof(GameAdministrationEnabled));

				case 1836790742:
					return typeof(GameSettings).GetProperty(nameof(AllowDestructionOutsideCombatArea));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
