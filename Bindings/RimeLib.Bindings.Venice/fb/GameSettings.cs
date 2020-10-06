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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(120), ContainerClass]
	public class GameSettings : 
		SystemSettings
	{
		protected uint m_MaxPlayerCount = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4192814593)]
		public uint MaxPlayerCount { get { return m_MaxPlayerCount; } set { if (OnPropertyChanging("GameSettings." + nameof(MaxPlayerCount), this, m_MaxPlayerCount, value)) m_MaxPlayerCount = value; } } // 0xC (12)
		
		protected uint m_MaxSpectatorCount = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3946650923)]
		public uint MaxSpectatorCount { get { return m_MaxSpectatorCount; } set { if (OnPropertyChanging("GameSettings." + nameof(MaxSpectatorCount), this, m_MaxSpectatorCount, value)) m_MaxSpectatorCount = value; } } // 0x10 (16)
		
		protected CtrRef<SubWorldInclusion> m_LayerInclusionTable = new CtrRef<SubWorldInclusion>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(1500062686), ContainerCtrRef]
		public CtrRef<SubWorldInclusion> LayerInclusionTable { get { return m_LayerInclusionTable; } set { if (OnPropertyChanging("GameSettings." + nameof(LayerInclusionTable), this, m_LayerInclusionTable, value)) m_LayerInclusionTable = value; } } // 0x14 (20)
		
		protected LogFileCollisionMode m_LogFileCollisionMode = new LogFileCollisionMode();
		[ContainerField(24), MemberInfoFlag(137), ContainerFieldNameHash(3429178042)]
		public LogFileCollisionMode LogFileCollisionMode { get { return m_LogFileCollisionMode; } set { if (OnPropertyChanging("GameSettings." + nameof(LogFileCollisionMode), this, m_LogFileCollisionMode, value)) m_LogFileCollisionMode = value; } } // 0x18 (24)
		
		protected uint m_LogFileRotationHistoryLength = new uint();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3548846413)]
		public uint LogFileRotationHistoryLength { get { return m_LogFileRotationHistoryLength; } set { if (OnPropertyChanging("GameSettings." + nameof(LogFileRotationHistoryLength), this, m_LogFileRotationHistoryLength, value)) m_LogFileRotationHistoryLength = value; } } // 0x1C (28)
		
		protected string m_Level = string.Empty;
		[ContainerField(32), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(218262515)]
		public string Level { get { return m_Level; } set { if (OnPropertyChanging("GameSettings." + nameof(Level), this, m_Level, value)) m_Level = value; } } // 0x20 (32)
		
		protected string m_DefaultLayerInclusion = string.Empty;
		[ContainerField(36), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(4278341003)]
		public string DefaultLayerInclusion { get { return m_DefaultLayerInclusion; } set { if (OnPropertyChanging("GameSettings." + nameof(DefaultLayerInclusion), this, m_DefaultLayerInclusion, value)) m_DefaultLayerInclusion = value; } } // 0x24 (36)
		
		protected RefArray<InputConfigurationAsset> m_InputConfiguration = new RefArray<InputConfigurationAsset>();
		[ContainerField(40), MemberInfoFlag(65), ContainerFieldNameHash(2676875651), ContainerRefArray]
		public RefArray<InputConfigurationAsset> InputConfiguration { get { return m_InputConfiguration; } set { if (OnPropertyChanging("GameSettings." + nameof(InputConfiguration), this, m_InputConfiguration, value)) m_InputConfiguration = value; } } // 0x28 (40)
		
		protected TeamId m_DefaultTeamId = new TeamId();
		[ContainerField(44), MemberInfoFlag(137), ContainerFieldNameHash(3990246590)]
		public TeamId DefaultTeamId { get { return m_DefaultTeamId; } set { if (OnPropertyChanging("GameSettings." + nameof(DefaultTeamId), this, m_DefaultTeamId, value)) m_DefaultTeamId = value; } } // 0x2C (44)
		
		protected float m_LevelWarmUpTime = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3353881322)]
		public float LevelWarmUpTime { get { return m_LevelWarmUpTime; } set { if (OnPropertyChanging("GameSettings." + nameof(LevelWarmUpTime), this, m_LevelWarmUpTime, value)) m_LevelWarmUpTime = value; } } // 0x30 (48)
		
		protected float m_TimeToWaitForQuitTaskCompletion = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2225926219)]
		public float TimeToWaitForQuitTaskCompletion { get { return m_TimeToWaitForQuitTaskCompletion; } set { if (OnPropertyChanging("GameSettings." + nameof(TimeToWaitForQuitTaskCompletion), this, m_TimeToWaitForQuitTaskCompletion, value)) m_TimeToWaitForQuitTaskCompletion = value; } } // 0x34 (52)
		
		protected GamePlatform m_Platform = new GamePlatform();
		[ContainerField(56), MemberInfoFlag(137), ContainerFieldNameHash(942751002)]
		public GamePlatform Platform { get { return m_Platform; } set { if (OnPropertyChanging("GameSettings." + nameof(Platform), this, m_Platform, value)) m_Platform = value; } } // 0x38 (56)
		
		protected CtrRef<VersionData> m_Version = new CtrRef<VersionData>();
		[ContainerField(60), MemberInfoFlag(53), ContainerFieldNameHash(747123679), ContainerCtrRef]
		public CtrRef<VersionData> Version { get { return m_Version; } set { if (OnPropertyChanging("GameSettings." + nameof(Version), this, m_Version, value)) m_Version = value; } } // 0x3C (60)
		
		protected uint m_PS3ContentRatingAge = new uint();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(534892568)]
		public uint PS3ContentRatingAge { get { return m_PS3ContentRatingAge; } set { if (OnPropertyChanging("GameSettings." + nameof(PS3ContentRatingAge), this, m_PS3ContentRatingAge, value)) m_PS3ContentRatingAge = value; } } // 0x40 (64)
		
		protected int m_DifficultyIndex = new int();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(302070728)]
		public int DifficultyIndex { get { return m_DifficultyIndex; } set { if (OnPropertyChanging("GameSettings." + nameof(DifficultyIndex), this, m_DifficultyIndex, value)) m_DifficultyIndex = value; } } // 0x44 (68)
		
		protected float m_TimeBeforeSpawnIsAllowed = new float();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3672151792)]
		public float TimeBeforeSpawnIsAllowed { get { return m_TimeBeforeSpawnIsAllowed; } set { if (OnPropertyChanging("GameSettings." + nameof(TimeBeforeSpawnIsAllowed), this, m_TimeBeforeSpawnIsAllowed, value)) m_TimeBeforeSpawnIsAllowed = value; } } // 0x48 (72)
		
		protected CtrRef<SoldierWeaponSwitchingData> m_SoldierWeaponSwitching = new CtrRef<SoldierWeaponSwitchingData>();
		[ContainerField(76), MemberInfoFlag(53), ContainerFieldNameHash(2122873599), ContainerCtrRef]
		public CtrRef<SoldierWeaponSwitchingData> SoldierWeaponSwitching { get { return m_SoldierWeaponSwitching; } set { if (OnPropertyChanging("GameSettings." + nameof(SoldierWeaponSwitching), this, m_SoldierWeaponSwitching, value)) m_SoldierWeaponSwitching = value; } } // 0x4C (76)
		
		protected uint m_LogHistory = new uint();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1374192771)]
		public uint LogHistory { get { return m_LogHistory; } set { if (OnPropertyChanging("GameSettings." + nameof(LogHistory), this, m_LogHistory, value)) m_LogHistory = value; } } // 0x50 (80)
		
		protected CtrRef<DifficultyDatas> m_DifficultySettings = new CtrRef<DifficultyDatas>();
		[ContainerField(84), MemberInfoFlag(53), ContainerFieldNameHash(1244447411), ContainerCtrRef]
		public CtrRef<DifficultyDatas> DifficultySettings { get { return m_DifficultySettings; } set { if (OnPropertyChanging("GameSettings." + nameof(DifficultySettings), this, m_DifficultySettings, value)) m_DifficultySettings = value; } } // 0x54 (84)
		
		protected RefArray<BlueprintBundleMetadataContainer> m_MetadataContainers = new RefArray<BlueprintBundleMetadataContainer>();
		[ContainerField(88), MemberInfoFlag(65), ContainerFieldNameHash(2114222460), ContainerRefArray]
		public RefArray<BlueprintBundleMetadataContainer> MetadataContainers { get { return m_MetadataContainers; } set { if (OnPropertyChanging("GameSettings." + nameof(MetadataContainers), this, m_MetadataContainers, value)) m_MetadataContainers = value; } } // 0x58 (88)
		
		protected SKU m_CurrentSKU = new SKU();
		[ContainerField(92), MemberInfoFlag(137), ContainerFieldNameHash(1385383009)]
		public SKU CurrentSKU { get { return m_CurrentSKU; } set { if (OnPropertyChanging("GameSettings." + nameof(CurrentSKU), this, m_CurrentSKU, value)) m_CurrentSKU = value; } } // 0x5C (92)
		
		protected CtrRef<PlayerData> m_Player = new CtrRef<PlayerData>();
		[ContainerField(96), MemberInfoFlag(53), ContainerFieldNameHash(3384765366), ContainerCtrRef]
		public CtrRef<PlayerData> Player { get { return m_Player; } set { if (OnPropertyChanging("GameSettings." + nameof(Player), this, m_Player, value)) m_Player = value; } } // 0x60 (96)
		
		protected bool m_LogFileEnable = new bool();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2156101894)]
		public bool LogFileEnable { get { return m_LogFileEnable; } set { if (OnPropertyChanging("GameSettings." + nameof(LogFileEnable), this, m_LogFileEnable, value)) m_LogFileEnable = value; } } // 0x64 (100)
		
		protected bool m_RotateLogs = new bool();
		[ContainerField(101), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1480400363)]
		public bool RotateLogs { get { return m_RotateLogs; } set { if (OnPropertyChanging("GameSettings." + nameof(RotateLogs), this, m_RotateLogs, value)) m_RotateLogs = value; } } // 0x65 (101)
		
		protected bool m_EnableLoadingProfile = new bool();
		[ContainerField(102), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(456285193)]
		public bool EnableLoadingProfile { get { return m_EnableLoadingProfile; } set { if (OnPropertyChanging("GameSettings." + nameof(EnableLoadingProfile), this, m_EnableLoadingProfile, value)) m_EnableLoadingProfile = value; } } // 0x66 (102)
		
		protected bool m_AdjustVehicleCenterOfMass = new bool();
		[ContainerField(103), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(589491054)]
		public bool AdjustVehicleCenterOfMass { get { return m_AdjustVehicleCenterOfMass; } set { if (OnPropertyChanging("GameSettings." + nameof(AdjustVehicleCenterOfMass), this, m_AdjustVehicleCenterOfMass, value)) m_AdjustVehicleCenterOfMass = value; } } // 0x67 (103)
		
		protected bool m_AutoAimEnabled = new bool();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2330232810)]
		public bool AutoAimEnabled { get { return m_AutoAimEnabled; } set { if (OnPropertyChanging("GameSettings." + nameof(AutoAimEnabled), this, m_AutoAimEnabled, value)) m_AutoAimEnabled = value; } } // 0x68 (104)
		
		protected bool m_HasUnlimitedAmmo = new bool();
		[ContainerField(105), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3689258814)]
		public bool HasUnlimitedAmmo { get { return m_HasUnlimitedAmmo; } set { if (OnPropertyChanging("GameSettings." + nameof(HasUnlimitedAmmo), this, m_HasUnlimitedAmmo, value)) m_HasUnlimitedAmmo = value; } } // 0x69 (105)
		
		protected bool m_HasUnlimitedMags = new bool();
		[ContainerField(106), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3689677416)]
		public bool HasUnlimitedMags { get { return m_HasUnlimitedMags; } set { if (OnPropertyChanging("GameSettings." + nameof(HasUnlimitedMags), this, m_HasUnlimitedMags, value)) m_HasUnlimitedMags = value; } } // 0x6A (106)
		
		protected bool m_ResourceRefreshAlwaysAllowed = new bool();
		[ContainerField(107), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3415354971)]
		public bool ResourceRefreshAlwaysAllowed { get { return m_ResourceRefreshAlwaysAllowed; } set { if (OnPropertyChanging("GameSettings." + nameof(ResourceRefreshAlwaysAllowed), this, m_ResourceRefreshAlwaysAllowed, value)) m_ResourceRefreshAlwaysAllowed = value; } } // 0x6B (107)
		
		protected bool m_UseSpeedBasedDetailedCollision = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(801331358)]
		public bool UseSpeedBasedDetailedCollision { get { return m_UseSpeedBasedDetailedCollision; } set { if (OnPropertyChanging("GameSettings." + nameof(UseSpeedBasedDetailedCollision), this, m_UseSpeedBasedDetailedCollision, value)) m_UseSpeedBasedDetailedCollision = value; } } // 0x6C (108)
		
		protected bool m_AimAssistEnabled = new bool();
		[ContainerField(109), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3924289354)]
		public bool AimAssistEnabled { get { return m_AimAssistEnabled; } set { if (OnPropertyChanging("GameSettings." + nameof(AimAssistEnabled), this, m_AimAssistEnabled, value)) m_AimAssistEnabled = value; } } // 0x6D (109)
		
		protected bool m_AimAssistUsePolynomials = new bool();
		[ContainerField(110), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1082705757)]
		public bool AimAssistUsePolynomials { get { return m_AimAssistUsePolynomials; } set { if (OnPropertyChanging("GameSettings." + nameof(AimAssistUsePolynomials), this, m_AimAssistUsePolynomials, value)) m_AimAssistUsePolynomials = value; } } // 0x6E (110)
		
		protected bool m_ForceFreeStreaming = new bool();
		[ContainerField(111), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(428656304)]
		public bool ForceFreeStreaming { get { return m_ForceFreeStreaming; } set { if (OnPropertyChanging("GameSettings." + nameof(ForceFreeStreaming), this, m_ForceFreeStreaming, value)) m_ForceFreeStreaming = value; } } // 0x6F (111)
		
		protected bool m_ForceDisableFreeStreaming = new bool();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2029153572)]
		public bool ForceDisableFreeStreaming { get { return m_ForceDisableFreeStreaming; } set { if (OnPropertyChanging("GameSettings." + nameof(ForceDisableFreeStreaming), this, m_ForceDisableFreeStreaming, value)) m_ForceDisableFreeStreaming = value; } } // 0x70 (112)
		
		protected bool m_IsGodMode = new bool();
		[ContainerField(113), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(568328144)]
		public bool IsGodMode { get { return m_IsGodMode; } set { if (OnPropertyChanging("GameSettings." + nameof(IsGodMode), this, m_IsGodMode, value)) m_IsGodMode = value; } } // 0x71 (113)
		
		protected bool m_IsJesusMode = new bool();
		[ContainerField(114), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(314138150)]
		public bool IsJesusMode { get { return m_IsJesusMode; } set { if (OnPropertyChanging("GameSettings." + nameof(IsJesusMode), this, m_IsJesusMode, value)) m_IsJesusMode = value; } } // 0x72 (114)
		
		protected bool m_IsJesusModeAi = new bool();
		[ContainerField(115), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2794026990)]
		public bool IsJesusModeAi { get { return m_IsJesusModeAi; } set { if (OnPropertyChanging("GameSettings." + nameof(IsJesusModeAi), this, m_IsJesusModeAi, value)) m_IsJesusModeAi = value; } } // 0x73 (115)
		
		protected bool m_UseSingleWeaponSelector = new bool();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1670669515)]
		public bool UseSingleWeaponSelector { get { return m_UseSingleWeaponSelector; } set { if (OnPropertyChanging("GameSettings." + nameof(UseSingleWeaponSelector), this, m_UseSingleWeaponSelector, value)) m_UseSingleWeaponSelector = value; } } // 0x74 (116)
		
		protected bool m_GameAdministrationEnabled = new bool();
		[ContainerField(117), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2064959744)]
		public bool GameAdministrationEnabled { get { return m_GameAdministrationEnabled; } set { if (OnPropertyChanging("GameSettings." + nameof(GameAdministrationEnabled), this, m_GameAdministrationEnabled, value)) m_GameAdministrationEnabled = value; } } // 0x75 (117)
		
		protected bool m_AllowDestructionOutsideCombatArea = new bool();
		[ContainerField(118), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1836790742)]
		public bool AllowDestructionOutsideCombatArea { get { return m_AllowDestructionOutsideCombatArea; } set { if (OnPropertyChanging("GameSettings." + nameof(AllowDestructionOutsideCombatArea), this, m_AllowDestructionOutsideCombatArea, value)) m_AllowDestructionOutsideCombatArea = value; } } // 0x76 (118)
		
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
