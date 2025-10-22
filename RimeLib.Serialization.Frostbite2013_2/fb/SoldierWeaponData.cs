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
using fb.Audio;
using fb.GameShared;
using fb.Entity;

namespace fb.SoldierShared;

[ContainerType(16, 544)]
public class SoldierWeaponData
	: fb.SoldierShared.WeaponEntityData
{
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public PickupSettingsData PickupSettings { get; set; } = new();
	
	[ContainerField(0xd0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public Vec3 InteractionOffset { get; set; } = new()
	{
		z = 0.450f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CustomizationAccessoryPivots CustomizationAccessoryPivots { get; set; } = new();
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public string DamageGiverName { get; set; } = string.Empty;
	
	[ContainerField(0x138), JsonProperty(Order = 312)]
	public RefArray<WeaponZoomLevelData> ZoomLevels { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public List<WeaponModifierData> WeaponModifierData { get; set; } = new();
	
	[ContainerField(0x148), JsonProperty(Order = 328)]
	public CtrRef<SoldierAimingSimulationData> AimingController { get; set; } = new();
	
	[ContainerField(0x150), JsonProperty(Order = 336)]
	public CtrRef<FirstPersonCameraData> FirstPersonCamera { get; set; } = new();
	
	[ContainerField(0x158), JsonProperty(Order = 344)]
	public HudData Hud { get; set; } = new();
	
	[ContainerField(0x1c8), LayoutImmutable, Blittable, JsonProperty(Order = 456)]
	public WeaponAnimBaseSetEnum AnimBaseSet { get; set; } = WeaponAnimBaseSetEnum.wabsRif;
	
	[ContainerField(0x1cc), LayoutImmutable, Blittable, JsonProperty(Order = 460)]
	public QuickThrowTypeEnum QuickThrowType { get; set; } = QuickThrowTypeEnum.QttHand;
	
	[ContainerField(0x1d0), JsonProperty(Order = 464)]
	public CtrRef<SoldierWeaponBlueprint> SoldierWeaponBlueprint { get; set; } = new();
	
	[ContainerField(0x1d8), LayoutImmutable, Blittable, JsonProperty(Order = 472)]
	public string PersistenceId { get; set; } = string.Empty;
	
	[ContainerField(0x1e0), LayoutImmutable, Blittable, JsonProperty(Order = 480)]
	public int SecondaryActionInputAction { get; set; } = -1341426433;
	
	[ContainerField(0x1e8), JsonProperty(Order = 488)]
	public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new();
	
	[ContainerField(0x1f0), LayoutImmutable, Blittable, JsonProperty(Order = 496)]
	public float WeaponFloatParam { get; set; } = 1.000f;
	
	[ContainerField(0x1f4), LayoutImmutable, Blittable, JsonProperty(Order = 500)]
	public float MaxRangeMeterDistance { get; set; } = 200.000f;
	
	[ContainerField(0x1f8), JsonProperty(Order = 504)]
	public RefArray<SocketData> SocketsInWeapon { get; set; } = new();
	
	[ContainerField(0x200), LayoutImmutable, Blittable, JsonProperty(Order = 512)]
	public bool HideWhenOutOfAmmo { get; set; } = false;
	
	[ContainerField(0x201), LayoutImmutable, Blittable, JsonProperty(Order = 513)]
	public bool AllowSwitchingToWeaponOutOfAmmo { get; set; } = true;
	
	[ContainerField(0x202), LayoutImmutable, Blittable, JsonProperty(Order = 514)]
	public bool AllowSwitchingToWeaponReloading { get; set; } = true;
	
	[ContainerField(0x203), LayoutImmutable, Blittable, JsonProperty(Order = 515)]
	public bool SwitchToPrimaryWhenOutOfAmmo { get; set; } = true;
	
	[ContainerField(0x204), LayoutImmutable, Blittable, JsonProperty(Order = 516)]
	public bool WaitForFireBeforeSwitchToPrimaryWhenOutOfAmmo { get; set; } = true;
	
	[ContainerField(0x205), LayoutImmutable, Blittable, JsonProperty(Order = 517)]
	public bool SwitchToSecondaryWhenPrimaryOutOfAmmo { get; set; } = false;
	
	[ContainerField(0x206), LayoutImmutable, Blittable, JsonProperty(Order = 518)]
	public bool FireAndSwitchBackToPrevSupported { get; set; } = false;
	
	[ContainerField(0x207), LayoutImmutable, Blittable, JsonProperty(Order = 519)]
	public bool AllowSwitchingToWeaponInVehicles { get; set; } = true;
	
	[ContainerField(0x208), LayoutImmutable, Blittable, JsonProperty(Order = 520)]
	public bool AllowSwitchingToWeaponInWater { get; set; } = false;
	
	[ContainerField(0x209), LayoutImmutable, Blittable, JsonProperty(Order = 521)]
	public bool LowerOnOwnTeam { get; set; } = true;
	
	[ContainerField(0x20a), LayoutImmutable, Blittable, JsonProperty(Order = 522)]
	public bool RedeployWhenSwitchingWeaponStates { get; set; } = true;
	
	[ContainerField(0x20b), LayoutImmutable, Blittable, JsonProperty(Order = 523)]
	public bool UseQuickThrowOnAutomaticSwitchback { get; set; } = false;
	
	[ContainerField(0x20c), LayoutImmutable, Blittable, JsonProperty(Order = 524)]
	public bool EnableBreathControl { get; set; } = false;
	
	[ContainerField(0x20d), LayoutImmutable, Blittable, JsonProperty(Order = 525)]
	public bool CanBeInSupportedShooting { get; set; } = false;
	
	[ContainerField(0x20e), LayoutImmutable, Blittable, JsonProperty(Order = 526)]
	public bool UseDetailedRangeMeterQuery { get; set; } = false;
	
	[ContainerField(0x20f), LayoutImmutable, Blittable, JsonProperty(Order = 527)]
	public bool IsSilenced { get; set; } = false;
	
	[ContainerField(0x210), LayoutImmutable, Blittable, JsonProperty(Order = 528)]
	public bool SkipFirstZoomLevel { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		PickupSettings.Serialize(p_Writer, p_EbxWriter);
		InteractionOffset.Serialize(p_Writer, p_EbxWriter);
		CustomizationAccessoryPivots.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(DamageGiverName));
		(RimeWriter Writer, uint ArrayIndex) s_ZoomLevels = p_EbxWriter.GetArrayWriter(ZoomLevels.GetType(), ZoomLevels.Count);
		p_Writer.Write(s_ZoomLevels.ArrayIndex);
		foreach (var s_Entry in ZoomLevels)
		{
			s_ZoomLevels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_WeaponModifierData = p_EbxWriter.GetArrayWriter(WeaponModifierData.GetType(), WeaponModifierData.Count);
		p_Writer.Write(s_WeaponModifierData.ArrayIndex);
		foreach (var s_Entry in WeaponModifierData)
		{
			s_Entry.Serialize(s_WeaponModifierData.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AimingController));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FirstPersonCamera));
		p_Writer.WriteNullBytes(4);
		Hud.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) AnimBaseSet);
		p_Writer.Write((int) QuickThrowType);
		p_Writer.Write(p_EbxWriter.WriteImport(SoldierWeaponBlueprint));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(PersistenceId));
		p_Writer.Write(SecondaryActionInputAction);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(VoiceOverInfo));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(WeaponFloatParam);
		p_Writer.Write(MaxRangeMeterDistance);
		(RimeWriter Writer, uint ArrayIndex) s_SocketsInWeapon = p_EbxWriter.GetArrayWriter(SocketsInWeapon.GetType(), SocketsInWeapon.Count);
		p_Writer.Write(s_SocketsInWeapon.ArrayIndex);
		foreach (var s_Entry in SocketsInWeapon)
		{
			s_SocketsInWeapon.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(HideWhenOutOfAmmo);
		p_Writer.Write(AllowSwitchingToWeaponOutOfAmmo);
		p_Writer.Write(AllowSwitchingToWeaponReloading);
		p_Writer.Write(SwitchToPrimaryWhenOutOfAmmo);
		p_Writer.Write(WaitForFireBeforeSwitchToPrimaryWhenOutOfAmmo);
		p_Writer.Write(SwitchToSecondaryWhenPrimaryOutOfAmmo);
		p_Writer.Write(FireAndSwitchBackToPrevSupported);
		p_Writer.Write(AllowSwitchingToWeaponInVehicles);
		p_Writer.Write(AllowSwitchingToWeaponInWater);
		p_Writer.Write(LowerOnOwnTeam);
		p_Writer.Write(RedeployWhenSwitchingWeaponStates);
		p_Writer.Write(UseQuickThrowOnAutomaticSwitchback);
		p_Writer.Write(EnableBreathControl);
		p_Writer.Write(CanBeInSupportedShooting);
		p_Writer.Write(UseDetailedRangeMeterQuery);
		p_Writer.Write(IsSilenced);
		p_Writer.Write(SkipFirstZoomLevel);
		p_Writer.WriteNullBytes(15);
	}
}

