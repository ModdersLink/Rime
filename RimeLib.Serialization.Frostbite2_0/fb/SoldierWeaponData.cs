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
	[ContainerType(16, 336)]
	public partial class SoldierWeaponData :
		WeaponEntityData
	{
		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec3 _InteractionOffset = new();

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private List<WeaponModifierData> _WeaponModifierData = new();

		[ObservableProperty]
		[property: ContainerField(148), JsonProperty(Order = 148)]
		private CtrRef<SoldierAimingSimulationData> _AimingController = new();

		[ObservableProperty]
		[property: ContainerField(152), JsonProperty(Order = 152)]
		private CtrRef<FirstPersonCameraData> _FirstPersonCamera = new();

		[ObservableProperty]
		[property: ContainerField(156), JsonProperty(Order = 156)]
		private HudData _Hud = new();

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, JsonProperty(Order = 224)]
		private string _DamageGiverName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(240), JsonProperty(Order = 240)]
		private PickupSettingsData _PickupSettings = new();

		[ObservableProperty]
		[property: ContainerField(272), JsonProperty(Order = 272)]
		private WeaponAnimBaseSetEnum _AnimBaseSet = new();

		[ObservableProperty]
		[property: ContainerField(276), JsonProperty(Order = 276)]
		private CtrRef<AntPackageAsset> _AnimationData = new();

		[ObservableProperty]
		[property: ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		private float _RenderFov;

		[ObservableProperty]
		[property: ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		private float _ZoomRenderFov;

		[ObservableProperty]
		[property: ContainerField(288), JsonProperty(Order = 288)]
		private CtrRef<StreamGroupData> _StreamGroup1p = new();

		[ObservableProperty]
		[property: ContainerField(292), JsonProperty(Order = 292)]
		private CtrRef<EntityVoiceOverInfo> _VoiceOverInfo = new();

		[ObservableProperty]
		[property: ContainerField(296), JsonProperty(Order = 296)]
		private QuickThrowTypeEnum _QuickThrowType = new();

		[ObservableProperty]
		[property: ContainerField(300), JsonProperty(Order = 300)]
		private CtrRef<SoldierWeaponCustomizationAsset> _Customization = new();

		[ObservableProperty]
		[property: ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		private float _WeaponFloatParam;

		[ObservableProperty]
		[property: ContainerField(308), JsonProperty(Order = 308)]
		private RefArray<SocketData> _Sockets = new();

		[ObservableProperty]
		[property: ContainerField(312), JsonProperty(Order = 312)]
		private EntryInputActionEnum _SwitchWeaponStateInputAction = new();

		[ObservableProperty]
		[property: ContainerField(316), JsonProperty(Order = 316)]
		private CtrRef<SoldierWeaponBlueprint> _SoldierWeaponBlueprint = new();

		[ObservableProperty]
		[property: ContainerField(320), LayoutImmutable, JsonProperty(Order = 320)]
		private string _PersistenceId = string.Empty;

		[ObservableProperty]
		[property: ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		private bool _AllowSwitchingToWeaponOutOfAmmo;

		[ObservableProperty]
		[property: ContainerField(325), LayoutImmutable, Blittable, JsonProperty(Order = 325)]
		private bool _HideWhenOutOfAmmo;

		[ObservableProperty]
		[property: ContainerField(326), LayoutImmutable, Blittable, JsonProperty(Order = 326)]
		private bool _LowerOnOwnTeam;

		[ObservableProperty]
		[property: ContainerField(327), LayoutImmutable, Blittable, JsonProperty(Order = 327)]
		private bool _RedeployWhenSwitchingWeaponStates;

		[ObservableProperty]
		[property: ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		private bool _UseQuickThrowOnAutomaticSwitchback;

		[ObservableProperty]
		[property: ContainerField(329), LayoutImmutable, Blittable, JsonProperty(Order = 329)]
		private bool _EnableBreathControl;

		[ObservableProperty]
		[property: ContainerField(330), LayoutImmutable, Blittable, JsonProperty(Order = 330)]
		private bool _CanBeInSupportedShooting;

		[ObservableProperty]
		[property: ContainerField(331), LayoutImmutable, Blittable, JsonProperty(Order = 331)]
		private bool _AllowSwitchingToWeaponReloading;

		[ObservableProperty]
		[property: ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		private bool _SwitchToPrimaryWhenOutOfAmmo;

		[ObservableProperty]
		[property: ContainerField(333), LayoutImmutable, Blittable, JsonProperty(Order = 333)]
		private bool _AllowSwitchingToWeaponInVehicles;

		[ObservableProperty]
		[property: ContainerField(334), LayoutImmutable, Blittable, JsonProperty(Order = 334)]
		private bool _IsSilenced;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			InteractionOffset.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_WeaponModifierData = p_EbxWriter.GetArrayWriter(WeaponModifierData.GetType(), WeaponModifierData.Count);
			p_Writer.Write(s_WeaponModifierData.ArrayIndex);
			foreach (var s_Entry in WeaponModifierData)
			{
				s_Entry.Serialize(s_WeaponModifierData.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(AimingController));
			p_Writer.Write(p_EbxWriter.WriteImport(FirstPersonCamera));
			Hud.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(DamageGiverName));
			p_Writer.WriteNullBytes(12);
			PickupSettings.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) AnimBaseSet);
			p_Writer.Write(p_EbxWriter.WriteImport(AnimationData));
			p_Writer.Write(RenderFov);
			p_Writer.Write(ZoomRenderFov);
			p_Writer.Write(p_EbxWriter.WriteImport(StreamGroup1p));
			p_Writer.Write(p_EbxWriter.WriteImport(VoiceOverInfo));
			p_Writer.Write((int) QuickThrowType);
			p_Writer.Write(p_EbxWriter.WriteImport(Customization));
			p_Writer.Write(WeaponFloatParam);
			(RimeWriter Writer, uint ArrayIndex) s_Sockets = p_EbxWriter.GetArrayWriter(Sockets.GetType(), Sockets.Count);
			p_Writer.Write(s_Sockets.ArrayIndex);
			foreach (var s_Entry in Sockets)
			{
				s_Sockets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) SwitchWeaponStateInputAction);
			p_Writer.Write(p_EbxWriter.WriteImport(SoldierWeaponBlueprint));
			p_Writer.Write(p_EbxWriter.WriteString(PersistenceId));
			p_Writer.Write(AllowSwitchingToWeaponOutOfAmmo);
			p_Writer.Write(HideWhenOutOfAmmo);
			p_Writer.Write(LowerOnOwnTeam);
			p_Writer.Write(RedeployWhenSwitchingWeaponStates);
			p_Writer.Write(UseQuickThrowOnAutomaticSwitchback);
			p_Writer.Write(EnableBreathControl);
			p_Writer.Write(CanBeInSupportedShooting);
			p_Writer.Write(AllowSwitchingToWeaponReloading);
			p_Writer.Write(SwitchToPrimaryWhenOutOfAmmo);
			p_Writer.Write(AllowSwitchingToWeaponInVehicles);
			p_Writer.Write(IsSilenced);
			p_Writer.WriteNullBytes(1);
		}
	}
}
