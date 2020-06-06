///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SoldierWeaponData : 
		WeaponEntityData
	{
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InteractionOffset { get; set; } = new Vec3(); // 0x80 (128)
		
		[ContainerField(144)]
		public List<WeaponModifierData> WeaponModifierData { get; set; } = new List<WeaponModifierData>(); // 0x90 (144)
		
		[ContainerField(148)]
		public CtrRef<SoldierAimingSimulationData> AimingController { get; set; } = new CtrRef<SoldierAimingSimulationData>(); // 0x94 (148)
		
		[ContainerField(152)]
		public CtrRef<FirstPersonCameraData> FirstPersonCamera { get; set; } = new CtrRef<FirstPersonCameraData>(); // 0x98 (152)
		
		[ContainerField(156)]
		public HudData Hud { get; set; } = new HudData(); // 0x9C (156)
		
		[ContainerField(224), LayoutImmutable]
		public string DamageGiverName { get; set; } // 0xE0 (224)
		
		[ContainerField(240)]
		public PickupSettingsData PickupSettings { get; set; } = new PickupSettingsData(); // 0xF0 (240)
		
		[ContainerField(272)]
		public WeaponAnimBaseSetEnum AnimBaseSet { get; set; } = new WeaponAnimBaseSetEnum(); // 0x110 (272)
		
		[ContainerField(276)]
		public CtrRef<AntPackageAsset> AnimationData { get; set; } = new CtrRef<AntPackageAsset>(); // 0x114 (276)
		
		[ContainerField(280), LayoutImmutable, Blittable]
		public float RenderFov { get; set; } // 0x118 (280)
		
		[ContainerField(284), LayoutImmutable, Blittable]
		public float ZoomRenderFov { get; set; } // 0x11C (284)
		
		[ContainerField(288)]
		public CtrRef<StreamGroupData> StreamGroup1p { get; set; } = new CtrRef<StreamGroupData>(); // 0x120 (288)
		
		[ContainerField(292)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new CtrRef<EntityVoiceOverInfo>(); // 0x124 (292)
		
		[ContainerField(296)]
		public QuickThrowTypeEnum QuickThrowType { get; set; } = new QuickThrowTypeEnum(); // 0x128 (296)
		
		[ContainerField(300)]
		public CtrRef<SoldierWeaponCustomizationAsset> Customization { get; set; } = new CtrRef<SoldierWeaponCustomizationAsset>(); // 0x12C (300)
		
		[ContainerField(304), LayoutImmutable, Blittable]
		public float WeaponFloatParam { get; set; } // 0x130 (304)
		
		[ContainerField(308)]
		public RefArray<SocketData> Sockets { get; set; } = new RefArray<SocketData>(); // 0x134 (308)
		
		[ContainerField(312)]
		public EntryInputActionEnum SwitchWeaponStateInputAction { get; set; } = new EntryInputActionEnum(); // 0x138 (312)
		
		[ContainerField(316)]
		public CtrRef<SoldierWeaponBlueprint> SoldierWeaponBlueprint { get; set; } = new CtrRef<SoldierWeaponBlueprint>(); // 0x13C (316)
		
		[ContainerField(320), LayoutImmutable]
		public string PersistenceId { get; set; } // 0x140 (320)
		
		[ContainerField(324), LayoutImmutable, Blittable]
		public bool AllowSwitchingToWeaponOutOfAmmo { get; set; } // 0x144 (324)
		
		[ContainerField(325), LayoutImmutable, Blittable]
		public bool HideWhenOutOfAmmo { get; set; } // 0x145 (325)
		
		[ContainerField(326), LayoutImmutable, Blittable]
		public bool LowerOnOwnTeam { get; set; } // 0x146 (326)
		
		[ContainerField(327), LayoutImmutable, Blittable]
		public bool RedeployWhenSwitchingWeaponStates { get; set; } // 0x147 (327)
		
		[ContainerField(328), LayoutImmutable, Blittable]
		public bool UseQuickThrowOnAutomaticSwitchback { get; set; } // 0x148 (328)
		
		[ContainerField(329), LayoutImmutable, Blittable]
		public bool EnableBreathControl { get; set; } // 0x149 (329)
		
		[ContainerField(330), LayoutImmutable, Blittable]
		public bool CanBeInSupportedShooting { get; set; } // 0x14A (330)
		
		[ContainerField(331), LayoutImmutable, Blittable]
		public bool AllowSwitchingToWeaponReloading { get; set; } // 0x14B (331)
		
		[ContainerField(332), LayoutImmutable, Blittable]
		public bool SwitchToPrimaryWhenOutOfAmmo { get; set; } // 0x14C (332)
		
		[ContainerField(333), LayoutImmutable, Blittable]
		public bool AllowSwitchingToWeaponInVehicles { get; set; } // 0x14D (333)
		
		[ContainerField(334), LayoutImmutable, Blittable]
		public bool IsSilenced { get; set; } // 0x14E (334)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 696984818:
					InteractionOffset = (Vec3) p_Value;
					break;

				case 76897728:
					WeaponModifierData = (List<WeaponModifierData>) p_Value;
					break;

				case 3247374364:
					AimingController = (CtrRef<SoldierAimingSimulationData>) p_Value;
					break;

				case 2683382291:
					FirstPersonCamera = (CtrRef<FirstPersonCameraData>) p_Value;
					break;

				case 193458844:
					Hud = (HudData) p_Value;
					break;

				case 38100006:
					DamageGiverName = (string) p_Value;
					break;

				case 2511884468:
					PickupSettings = (PickupSettingsData) p_Value;
					break;

				case 482025337:
					AnimBaseSet = (WeaponAnimBaseSetEnum) Enum.ToObject(typeof(WeaponAnimBaseSetEnum), p_Value);
					break;

				case 2826644739:
					AnimationData = (CtrRef<AntPackageAsset>) p_Value;
					break;

				case 278615376:
					RenderFov = (float) p_Value;
					break;

				case 956290279:
					ZoomRenderFov = (float) p_Value;
					break;

				case 3004812039:
					StreamGroup1p = (CtrRef<StreamGroupData>) p_Value;
					break;

				case 1260547539:
					VoiceOverInfo = (CtrRef<EntityVoiceOverInfo>) p_Value;
					break;

				case 1948331758:
					QuickThrowType = (QuickThrowTypeEnum) Enum.ToObject(typeof(QuickThrowTypeEnum), p_Value);
					break;

				case 1998291608:
					Customization = (CtrRef<SoldierWeaponCustomizationAsset>) p_Value;
					break;

				case 1981440952:
					WeaponFloatParam = (float) p_Value;
					break;

				case 2848151347:
					Sockets = (RefArray<SocketData>) p_Value;
					break;

				case 521739946:
					SwitchWeaponStateInputAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 1382654562:
					SoldierWeaponBlueprint = (CtrRef<SoldierWeaponBlueprint>) p_Value;
					break;

				case 526010015:
					PersistenceId = (string) p_Value;
					break;

				case 2054159870:
					AllowSwitchingToWeaponOutOfAmmo = (bool) p_Value;
					break;

				case 4001370040:
					HideWhenOutOfAmmo = (bool) p_Value;
					break;

				case 233183148:
					LowerOnOwnTeam = (bool) p_Value;
					break;

				case 1289128377:
					RedeployWhenSwitchingWeaponStates = (bool) p_Value;
					break;

				case 224772656:
					UseQuickThrowOnAutomaticSwitchback = (bool) p_Value;
					break;

				case 613505579:
					EnableBreathControl = (bool) p_Value;
					break;

				case 2187452328:
					CanBeInSupportedShooting = (bool) p_Value;
					break;

				case 2126896102:
					AllowSwitchingToWeaponReloading = (bool) p_Value;
					break;

				case 2447281789:
					SwitchToPrimaryWhenOutOfAmmo = (bool) p_Value;
					break;

				case 1398995195:
					AllowSwitchingToWeaponInVehicles = (bool) p_Value;
					break;

				case 1644964768:
					IsSilenced = (bool) p_Value;
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
				case 696984818:
					return InteractionOffset;

				case 76897728:
					return WeaponModifierData;

				case 3247374364:
					return AimingController;

				case 2683382291:
					return FirstPersonCamera;

				case 193458844:
					return Hud;

				case 38100006:
					return DamageGiverName;

				case 2511884468:
					return PickupSettings;

				case 482025337:
					return AnimBaseSet;

				case 2826644739:
					return AnimationData;

				case 278615376:
					return RenderFov;

				case 956290279:
					return ZoomRenderFov;

				case 3004812039:
					return StreamGroup1p;

				case 1260547539:
					return VoiceOverInfo;

				case 1948331758:
					return QuickThrowType;

				case 1998291608:
					return Customization;

				case 1981440952:
					return WeaponFloatParam;

				case 2848151347:
					return Sockets;

				case 521739946:
					return SwitchWeaponStateInputAction;

				case 1382654562:
					return SoldierWeaponBlueprint;

				case 526010015:
					return PersistenceId;

				case 2054159870:
					return AllowSwitchingToWeaponOutOfAmmo;

				case 4001370040:
					return HideWhenOutOfAmmo;

				case 233183148:
					return LowerOnOwnTeam;

				case 1289128377:
					return RedeployWhenSwitchingWeaponStates;

				case 224772656:
					return UseQuickThrowOnAutomaticSwitchback;

				case 613505579:
					return EnableBreathControl;

				case 2187452328:
					return CanBeInSupportedShooting;

				case 2126896102:
					return AllowSwitchingToWeaponReloading;

				case 2447281789:
					return SwitchToPrimaryWhenOutOfAmmo;

				case 1398995195:
					return AllowSwitchingToWeaponInVehicles;

				case 1644964768:
					return IsSilenced;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 696984818:
					return typeof(SoldierWeaponData).GetProperty(nameof(InteractionOffset));

				case 76897728:
					return typeof(SoldierWeaponData).GetProperty(nameof(WeaponModifierData));

				case 3247374364:
					return typeof(SoldierWeaponData).GetProperty(nameof(AimingController));

				case 2683382291:
					return typeof(SoldierWeaponData).GetProperty(nameof(FirstPersonCamera));

				case 193458844:
					return typeof(SoldierWeaponData).GetProperty(nameof(Hud));

				case 38100006:
					return typeof(SoldierWeaponData).GetProperty(nameof(DamageGiverName));

				case 2511884468:
					return typeof(SoldierWeaponData).GetProperty(nameof(PickupSettings));

				case 482025337:
					return typeof(SoldierWeaponData).GetProperty(nameof(AnimBaseSet));

				case 2826644739:
					return typeof(SoldierWeaponData).GetProperty(nameof(AnimationData));

				case 278615376:
					return typeof(SoldierWeaponData).GetProperty(nameof(RenderFov));

				case 956290279:
					return typeof(SoldierWeaponData).GetProperty(nameof(ZoomRenderFov));

				case 3004812039:
					return typeof(SoldierWeaponData).GetProperty(nameof(StreamGroup1p));

				case 1260547539:
					return typeof(SoldierWeaponData).GetProperty(nameof(VoiceOverInfo));

				case 1948331758:
					return typeof(SoldierWeaponData).GetProperty(nameof(QuickThrowType));

				case 1998291608:
					return typeof(SoldierWeaponData).GetProperty(nameof(Customization));

				case 1981440952:
					return typeof(SoldierWeaponData).GetProperty(nameof(WeaponFloatParam));

				case 2848151347:
					return typeof(SoldierWeaponData).GetProperty(nameof(Sockets));

				case 521739946:
					return typeof(SoldierWeaponData).GetProperty(nameof(SwitchWeaponStateInputAction));

				case 1382654562:
					return typeof(SoldierWeaponData).GetProperty(nameof(SoldierWeaponBlueprint));

				case 526010015:
					return typeof(SoldierWeaponData).GetProperty(nameof(PersistenceId));

				case 2054159870:
					return typeof(SoldierWeaponData).GetProperty(nameof(AllowSwitchingToWeaponOutOfAmmo));

				case 4001370040:
					return typeof(SoldierWeaponData).GetProperty(nameof(HideWhenOutOfAmmo));

				case 233183148:
					return typeof(SoldierWeaponData).GetProperty(nameof(LowerOnOwnTeam));

				case 1289128377:
					return typeof(SoldierWeaponData).GetProperty(nameof(RedeployWhenSwitchingWeaponStates));

				case 224772656:
					return typeof(SoldierWeaponData).GetProperty(nameof(UseQuickThrowOnAutomaticSwitchback));

				case 613505579:
					return typeof(SoldierWeaponData).GetProperty(nameof(EnableBreathControl));

				case 2187452328:
					return typeof(SoldierWeaponData).GetProperty(nameof(CanBeInSupportedShooting));

				case 2126896102:
					return typeof(SoldierWeaponData).GetProperty(nameof(AllowSwitchingToWeaponReloading));

				case 2447281789:
					return typeof(SoldierWeaponData).GetProperty(nameof(SwitchToPrimaryWhenOutOfAmmo));

				case 1398995195:
					return typeof(SoldierWeaponData).GetProperty(nameof(AllowSwitchingToWeaponInVehicles));

				case 1644964768:
					return typeof(SoldierWeaponData).GetProperty(nameof(IsSilenced));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
