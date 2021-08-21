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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 336)]
	public class SoldierWeaponData : 
		WeaponEntityData
	{
		protected Vec3 m_InteractionOffset = new Vec3();
		[ContainerField(Name: "InteractionOffset", Offset: 128, NameHash: 696984818, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InteractionOffset { get { return m_InteractionOffset; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(InteractionOffset), this, m_InteractionOffset, value)) m_InteractionOffset = value; } } // 0x80 (128)
		
		protected List<WeaponModifierData> m_WeaponModifierData = new List<WeaponModifierData>();
		[ContainerField(Name: "WeaponModifierData", Offset: 144, NameHash: 76897728, Flags: 65)]
		public List<WeaponModifierData> WeaponModifierData { get { return m_WeaponModifierData; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(WeaponModifierData), this, m_WeaponModifierData, value)) m_WeaponModifierData = value; } } // 0x90 (144)
		
		protected CtrRef<SoldierAimingSimulationData> m_AimingController = new CtrRef<SoldierAimingSimulationData>();
		[ContainerField(Name: "AimingController", Offset: 148, NameHash: 3247374364, Flags: 53)]
		public CtrRef<SoldierAimingSimulationData> AimingController { get { return m_AimingController; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(AimingController), this, m_AimingController, value)) m_AimingController = value; } } // 0x94 (148)
		
		protected CtrRef<FirstPersonCameraData> m_FirstPersonCamera = new CtrRef<FirstPersonCameraData>();
		[ContainerField(Name: "FirstPersonCamera", Offset: 152, NameHash: 2683382291, Flags: 53)]
		public CtrRef<FirstPersonCameraData> FirstPersonCamera { get { return m_FirstPersonCamera; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(FirstPersonCamera), this, m_FirstPersonCamera, value)) m_FirstPersonCamera = value; } } // 0x98 (152)
		
		protected HudData m_Hud = new HudData();
		[ContainerField(Name: "Hud", Offset: 156, NameHash: 193458844, Flags: 41)]
		public HudData Hud { get { return m_Hud; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(Hud), this, m_Hud, value)) m_Hud = value; } } // 0x9C (156)
		
		protected string m_DamageGiverName = string.Empty;
		[ContainerField(Name: "DamageGiverName", Offset: 224, NameHash: 38100006, Flags: 16509), LayoutImmutable]
		public string DamageGiverName { get { return m_DamageGiverName; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(DamageGiverName), this, m_DamageGiverName, value)) m_DamageGiverName = value; } } // 0xE0 (224)
		
		protected PickupSettingsData m_PickupSettings = new PickupSettingsData();
		[ContainerField(Name: "PickupSettings", Offset: 240, NameHash: 2511884468, Flags: 41)]
		public PickupSettingsData PickupSettings { get { return m_PickupSettings; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(PickupSettings), this, m_PickupSettings, value)) m_PickupSettings = value; } } // 0xF0 (240)
		
		protected WeaponAnimBaseSetEnum m_AnimBaseSet = new WeaponAnimBaseSetEnum();
		[ContainerField(Name: "AnimBaseSet", Offset: 272, NameHash: 482025337, Flags: 137)]
		public WeaponAnimBaseSetEnum AnimBaseSet { get { return m_AnimBaseSet; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(AnimBaseSet), this, m_AnimBaseSet, value)) m_AnimBaseSet = value; } } // 0x110 (272)
		
		protected CtrRef<AntPackageAsset> m_AnimationData = new CtrRef<AntPackageAsset>();
		[ContainerField(Name: "AnimationData", Offset: 276, NameHash: 2826644739, Flags: 53)]
		public CtrRef<AntPackageAsset> AnimationData { get { return m_AnimationData; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(AnimationData), this, m_AnimationData, value)) m_AnimationData = value; } } // 0x114 (276)
		
		protected float m_RenderFov = new float();
		[ContainerField(Name: "RenderFov", Offset: 280, NameHash: 278615376, Flags: 49469), LayoutImmutable, Blittable]
		public float RenderFov { get { return m_RenderFov; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(RenderFov), this, m_RenderFov, value)) m_RenderFov = value; } } // 0x118 (280)
		
		protected float m_ZoomRenderFov = new float();
		[ContainerField(Name: "ZoomRenderFov", Offset: 284, NameHash: 956290279, Flags: 49469), LayoutImmutable, Blittable]
		public float ZoomRenderFov { get { return m_ZoomRenderFov; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(ZoomRenderFov), this, m_ZoomRenderFov, value)) m_ZoomRenderFov = value; } } // 0x11C (284)
		
		protected CtrRef<StreamGroupData> m_StreamGroup1p = new CtrRef<StreamGroupData>();
		[ContainerField(Name: "StreamGroup1p", Offset: 288, NameHash: 3004812039, Flags: 53)]
		public CtrRef<StreamGroupData> StreamGroup1p { get { return m_StreamGroup1p; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(StreamGroup1p), this, m_StreamGroup1p, value)) m_StreamGroup1p = value; } } // 0x120 (288)
		
		protected CtrRef<EntityVoiceOverInfo> m_VoiceOverInfo = new CtrRef<EntityVoiceOverInfo>();
		[ContainerField(Name: "VoiceOverInfo", Offset: 292, NameHash: 1260547539, Flags: 53)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get { return m_VoiceOverInfo; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(VoiceOverInfo), this, m_VoiceOverInfo, value)) m_VoiceOverInfo = value; } } // 0x124 (292)
		
		protected QuickThrowTypeEnum m_QuickThrowType = new QuickThrowTypeEnum();
		[ContainerField(Name: "QuickThrowType", Offset: 296, NameHash: 1948331758, Flags: 137)]
		public QuickThrowTypeEnum QuickThrowType { get { return m_QuickThrowType; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(QuickThrowType), this, m_QuickThrowType, value)) m_QuickThrowType = value; } } // 0x128 (296)
		
		protected CtrRef<SoldierWeaponCustomizationAsset> m_Customization = new CtrRef<SoldierWeaponCustomizationAsset>();
		[ContainerField(Name: "Customization", Offset: 300, NameHash: 1998291608, Flags: 53)]
		public CtrRef<SoldierWeaponCustomizationAsset> Customization { get { return m_Customization; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(Customization), this, m_Customization, value)) m_Customization = value; } } // 0x12C (300)
		
		protected float m_WeaponFloatParam = new float();
		[ContainerField(Name: "WeaponFloatParam", Offset: 304, NameHash: 1981440952, Flags: 49469), LayoutImmutable, Blittable]
		public float WeaponFloatParam { get { return m_WeaponFloatParam; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(WeaponFloatParam), this, m_WeaponFloatParam, value)) m_WeaponFloatParam = value; } } // 0x130 (304)
		
		protected RefArray<SocketData> m_Sockets = new RefArray<SocketData>();
		[ContainerField(Name: "Sockets", Offset: 308, NameHash: 2848151347, Flags: 65)]
		public RefArray<SocketData> Sockets { get { return m_Sockets; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(Sockets), this, m_Sockets, value)) m_Sockets = value; } } // 0x134 (308)
		
		protected EntryInputActionEnum m_SwitchWeaponStateInputAction = new EntryInputActionEnum();
		[ContainerField(Name: "SwitchWeaponStateInputAction", Offset: 312, NameHash: 521739946, Flags: 137)]
		public EntryInputActionEnum SwitchWeaponStateInputAction { get { return m_SwitchWeaponStateInputAction; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(SwitchWeaponStateInputAction), this, m_SwitchWeaponStateInputAction, value)) m_SwitchWeaponStateInputAction = value; } } // 0x138 (312)
		
		protected CtrRef<SoldierWeaponBlueprint> m_SoldierWeaponBlueprint = new CtrRef<SoldierWeaponBlueprint>();
		[ContainerField(Name: "SoldierWeaponBlueprint", Offset: 316, NameHash: 1382654562, Flags: 53)]
		public CtrRef<SoldierWeaponBlueprint> SoldierWeaponBlueprint { get { return m_SoldierWeaponBlueprint; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(SoldierWeaponBlueprint), this, m_SoldierWeaponBlueprint, value)) m_SoldierWeaponBlueprint = value; } } // 0x13C (316)
		
		protected string m_PersistenceId = string.Empty;
		[ContainerField(Name: "PersistenceId", Offset: 320, NameHash: 526010015, Flags: 16509), LayoutImmutable]
		public string PersistenceId { get { return m_PersistenceId; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(PersistenceId), this, m_PersistenceId, value)) m_PersistenceId = value; } } // 0x140 (320)
		
		protected bool m_AllowSwitchingToWeaponOutOfAmmo = new bool();
		[ContainerField(Name: "AllowSwitchingToWeaponOutOfAmmo", Offset: 324, NameHash: 2054159870, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowSwitchingToWeaponOutOfAmmo { get { return m_AllowSwitchingToWeaponOutOfAmmo; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(AllowSwitchingToWeaponOutOfAmmo), this, m_AllowSwitchingToWeaponOutOfAmmo, value)) m_AllowSwitchingToWeaponOutOfAmmo = value; } } // 0x144 (324)
		
		protected bool m_HideWhenOutOfAmmo = new bool();
		[ContainerField(Name: "HideWhenOutOfAmmo", Offset: 325, NameHash: 4001370040, Flags: 49325), LayoutImmutable, Blittable]
		public bool HideWhenOutOfAmmo { get { return m_HideWhenOutOfAmmo; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(HideWhenOutOfAmmo), this, m_HideWhenOutOfAmmo, value)) m_HideWhenOutOfAmmo = value; } } // 0x145 (325)
		
		protected bool m_LowerOnOwnTeam = new bool();
		[ContainerField(Name: "LowerOnOwnTeam", Offset: 326, NameHash: 233183148, Flags: 49325), LayoutImmutable, Blittable]
		public bool LowerOnOwnTeam { get { return m_LowerOnOwnTeam; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(LowerOnOwnTeam), this, m_LowerOnOwnTeam, value)) m_LowerOnOwnTeam = value; } } // 0x146 (326)
		
		protected bool m_RedeployWhenSwitchingWeaponStates = new bool();
		[ContainerField(Name: "RedeployWhenSwitchingWeaponStates", Offset: 327, NameHash: 1289128377, Flags: 49325), LayoutImmutable, Blittable]
		public bool RedeployWhenSwitchingWeaponStates { get { return m_RedeployWhenSwitchingWeaponStates; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(RedeployWhenSwitchingWeaponStates), this, m_RedeployWhenSwitchingWeaponStates, value)) m_RedeployWhenSwitchingWeaponStates = value; } } // 0x147 (327)
		
		protected bool m_UseQuickThrowOnAutomaticSwitchback = new bool();
		[ContainerField(Name: "UseQuickThrowOnAutomaticSwitchback", Offset: 328, NameHash: 224772656, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseQuickThrowOnAutomaticSwitchback { get { return m_UseQuickThrowOnAutomaticSwitchback; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(UseQuickThrowOnAutomaticSwitchback), this, m_UseQuickThrowOnAutomaticSwitchback, value)) m_UseQuickThrowOnAutomaticSwitchback = value; } } // 0x148 (328)
		
		protected bool m_EnableBreathControl = new bool();
		[ContainerField(Name: "EnableBreathControl", Offset: 329, NameHash: 613505579, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnableBreathControl { get { return m_EnableBreathControl; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(EnableBreathControl), this, m_EnableBreathControl, value)) m_EnableBreathControl = value; } } // 0x149 (329)
		
		protected bool m_CanBeInSupportedShooting = new bool();
		[ContainerField(Name: "CanBeInSupportedShooting", Offset: 330, NameHash: 2187452328, Flags: 49325), LayoutImmutable, Blittable]
		public bool CanBeInSupportedShooting { get { return m_CanBeInSupportedShooting; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(CanBeInSupportedShooting), this, m_CanBeInSupportedShooting, value)) m_CanBeInSupportedShooting = value; } } // 0x14A (330)
		
		protected bool m_AllowSwitchingToWeaponReloading = new bool();
		[ContainerField(Name: "AllowSwitchingToWeaponReloading", Offset: 331, NameHash: 2126896102, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowSwitchingToWeaponReloading { get { return m_AllowSwitchingToWeaponReloading; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(AllowSwitchingToWeaponReloading), this, m_AllowSwitchingToWeaponReloading, value)) m_AllowSwitchingToWeaponReloading = value; } } // 0x14B (331)
		
		protected bool m_SwitchToPrimaryWhenOutOfAmmo = new bool();
		[ContainerField(Name: "SwitchToPrimaryWhenOutOfAmmo", Offset: 332, NameHash: 2447281789, Flags: 49325), LayoutImmutable, Blittable]
		public bool SwitchToPrimaryWhenOutOfAmmo { get { return m_SwitchToPrimaryWhenOutOfAmmo; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(SwitchToPrimaryWhenOutOfAmmo), this, m_SwitchToPrimaryWhenOutOfAmmo, value)) m_SwitchToPrimaryWhenOutOfAmmo = value; } } // 0x14C (332)
		
		protected bool m_AllowSwitchingToWeaponInVehicles = new bool();
		[ContainerField(Name: "AllowSwitchingToWeaponInVehicles", Offset: 333, NameHash: 1398995195, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowSwitchingToWeaponInVehicles { get { return m_AllowSwitchingToWeaponInVehicles; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(AllowSwitchingToWeaponInVehicles), this, m_AllowSwitchingToWeaponInVehicles, value)) m_AllowSwitchingToWeaponInVehicles = value; } } // 0x14D (333)
		
		protected bool m_IsSilenced = new bool();
		[ContainerField(Name: "IsSilenced", Offset: 334, NameHash: 1644964768, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsSilenced { get { return m_IsSilenced; } set { if (OnPropertyChanging("SoldierWeaponData." + nameof(IsSilenced), this, m_IsSilenced, value)) m_IsSilenced = value; } } // 0x14E (334)
		
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
