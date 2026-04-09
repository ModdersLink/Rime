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
	[ContainerType(4, 120)]
	public partial class GameSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _MaxPlayerCount;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _MaxSpectatorCount;

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<SubWorldInclusion> _LayerInclusionTable = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private LogFileCollisionMode _LogFileCollisionMode = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _LogFileRotationHistoryLength;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		private string _Level = string.Empty;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		private string _DefaultLayerInclusion = string.Empty;

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private RefArray<InputConfigurationAsset> _InputConfiguration = new();

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private TeamId _DefaultTeamId = new();

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _LevelWarmUpTime;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _TimeToWaitForQuitTaskCompletion;

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private GamePlatform _Platform = new();

		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private CtrRef<VersionData> _Version = new();

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private uint _PS3ContentRatingAge;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private int _DifficultyIndex;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _TimeBeforeSpawnIsAllowed;

		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private CtrRef<SoldierWeaponSwitchingData> _SoldierWeaponSwitching = new();

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private uint _LogHistory;

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private CtrRef<DifficultyDatas> _DifficultySettings = new();

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private RefArray<BlueprintBundleMetadataContainer> _MetadataContainers = new();

		[ObservableProperty]
		[property: ContainerField(92), JsonProperty(Order = 92)]
		private SKU _CurrentSKU = new();

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private CtrRef<PlayerData> _Player = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private bool _LogFileEnable;

		[ObservableProperty]
		[property: ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		private bool _RotateLogs;

		[ObservableProperty]
		[property: ContainerField(102), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
		private bool _EnableLoadingProfile;

		[ObservableProperty]
		[property: ContainerField(103), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
		private bool _AdjustVehicleCenterOfMass;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private bool _AutoAimEnabled;

		[ObservableProperty]
		[property: ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		private bool _HasUnlimitedAmmo;

		[ObservableProperty]
		[property: ContainerField(106), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
		private bool _HasUnlimitedMags;

		[ObservableProperty]
		[property: ContainerField(107), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
		private bool _ResourceRefreshAlwaysAllowed;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private bool _UseSpeedBasedDetailedCollision;

		[ObservableProperty]
		[property: ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		private bool _AimAssistEnabled;

		[ObservableProperty]
		[property: ContainerField(110), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
		private bool _AimAssistUsePolynomials;

		[ObservableProperty]
		[property: ContainerField(111), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
		private bool _ForceFreeStreaming;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private bool _ForceDisableFreeStreaming;

		[ObservableProperty]
		[property: ContainerField(113), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
		private bool _IsGodMode;

		[ObservableProperty]
		[property: ContainerField(114), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
		private bool _IsJesusMode;

		[ObservableProperty]
		[property: ContainerField(115), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
		private bool _IsJesusModeAi;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private bool _UseSingleWeaponSelector;

		[ObservableProperty]
		[property: ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		private bool _GameAdministrationEnabled;

		[ObservableProperty]
		[property: ContainerField(118), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
		private bool _AllowDestructionOutsideCombatArea;

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
