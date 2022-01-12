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
	[ContainerType(16, 336)]
	public class SoldierWeaponData : 
		WeaponEntityData
	{
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InteractionOffset { get; set; } = new();

		[ContainerField(144)]
		public List<WeaponModifierData> WeaponModifierData { get; set; } = new();

		[ContainerField(148)]
		public CtrRef<SoldierAimingSimulationData> AimingController { get; set; } = new();

		[ContainerField(152)]
		public CtrRef<FirstPersonCameraData> FirstPersonCamera { get; set; } = new();

		[ContainerField(156)]
		public HudData Hud { get; set; } = new();

		[ContainerField(224), LayoutImmutable]
		public string DamageGiverName { get; set; } = string.Empty;

		[ContainerField(240)]
		public PickupSettingsData PickupSettings { get; set; } = new();

		[ContainerField(272)]
		public WeaponAnimBaseSetEnum AnimBaseSet { get; set; } = new();

		[ContainerField(276)]
		public CtrRef<AntPackageAsset> AnimationData { get; set; } = new();

		[ContainerField(280), LayoutImmutable, Blittable]
		public float RenderFov { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable]
		public float ZoomRenderFov { get; set; }

		[ContainerField(288)]
		public CtrRef<StreamGroupData> StreamGroup1p { get; set; } = new();

		[ContainerField(292)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new();

		[ContainerField(296)]
		public QuickThrowTypeEnum QuickThrowType { get; set; } = new();

		[ContainerField(300)]
		public CtrRef<SoldierWeaponCustomizationAsset> Customization { get; set; } = new();

		[ContainerField(304), LayoutImmutable, Blittable]
		public float WeaponFloatParam { get; set; }

		[ContainerField(308)]
		public RefArray<SocketData> Sockets { get; set; } = new();

		[ContainerField(312)]
		public EntryInputActionEnum SwitchWeaponStateInputAction { get; set; } = new();

		[ContainerField(316)]
		public CtrRef<SoldierWeaponBlueprint> SoldierWeaponBlueprint { get; set; } = new();

		[ContainerField(320), LayoutImmutable]
		public string PersistenceId { get; set; } = string.Empty;

		[ContainerField(324), LayoutImmutable, Blittable]
		public bool AllowSwitchingToWeaponOutOfAmmo { get; set; }

		[ContainerField(325), LayoutImmutable, Blittable]
		public bool HideWhenOutOfAmmo { get; set; }

		[ContainerField(326), LayoutImmutable, Blittable]
		public bool LowerOnOwnTeam { get; set; }

		[ContainerField(327), LayoutImmutable, Blittable]
		public bool RedeployWhenSwitchingWeaponStates { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable]
		public bool UseQuickThrowOnAutomaticSwitchback { get; set; }

		[ContainerField(329), LayoutImmutable, Blittable]
		public bool EnableBreathControl { get; set; }

		[ContainerField(330), LayoutImmutable, Blittable]
		public bool CanBeInSupportedShooting { get; set; }

		[ContainerField(331), LayoutImmutable, Blittable]
		public bool AllowSwitchingToWeaponReloading { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable]
		public bool SwitchToPrimaryWhenOutOfAmmo { get; set; }

		[ContainerField(333), LayoutImmutable, Blittable]
		public bool AllowSwitchingToWeaponInVehicles { get; set; }

		[ContainerField(334), LayoutImmutable, Blittable]
		public bool IsSilenced { get; set; }

	}
}
