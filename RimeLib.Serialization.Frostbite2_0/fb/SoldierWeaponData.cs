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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 336)]
	public class SoldierWeaponData :
		WeaponEntityData
	{
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec3 InteractionOffset { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public List<WeaponModifierData> WeaponModifierData { get; set; } = new();

		[ContainerField(148), JsonProperty(Order = 148)]
		public CtrRef<SoldierAimingSimulationData> AimingController { get; set; } = new();

		[ContainerField(152), JsonProperty(Order = 152)]
		public CtrRef<FirstPersonCameraData> FirstPersonCamera { get; set; } = new();

		[ContainerField(156), JsonProperty(Order = 156)]
		public HudData Hud { get; set; } = new();

		[ContainerField(224), LayoutImmutable, JsonProperty(Order = 224)]
		public string DamageGiverName { get; set; } = string.Empty;

		[ContainerField(240), JsonProperty(Order = 240)]
		public PickupSettingsData PickupSettings { get; set; } = new();

		[ContainerField(272), JsonProperty(Order = 272)]
		public WeaponAnimBaseSetEnum AnimBaseSet { get; set; } = new();

		[ContainerField(276), JsonProperty(Order = 276)]
		public CtrRef<AntPackageAsset> AnimationData { get; set; } = new();

		[ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		public float RenderFov { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		public float ZoomRenderFov { get; set; }

		[ContainerField(288), JsonProperty(Order = 288)]
		public CtrRef<StreamGroupData> StreamGroup1p { get; set; } = new();

		[ContainerField(292), JsonProperty(Order = 292)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new();

		[ContainerField(296), JsonProperty(Order = 296)]
		public QuickThrowTypeEnum QuickThrowType { get; set; } = new();

		[ContainerField(300), JsonProperty(Order = 300)]
		public CtrRef<SoldierWeaponCustomizationAsset> Customization { get; set; } = new();

		[ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		public float WeaponFloatParam { get; set; }

		[ContainerField(308), JsonProperty(Order = 308)]
		public RefArray<SocketData> Sockets { get; set; } = new();

		[ContainerField(312), JsonProperty(Order = 312)]
		public EntryInputActionEnum SwitchWeaponStateInputAction { get; set; } = new();

		[ContainerField(316), JsonProperty(Order = 316)]
		public CtrRef<SoldierWeaponBlueprint> SoldierWeaponBlueprint { get; set; } = new();

		[ContainerField(320), LayoutImmutable, JsonProperty(Order = 320)]
		public string PersistenceId { get; set; } = string.Empty;

		[ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		public bool AllowSwitchingToWeaponOutOfAmmo { get; set; }

		[ContainerField(325), LayoutImmutable, Blittable, JsonProperty(Order = 325)]
		public bool HideWhenOutOfAmmo { get; set; }

		[ContainerField(326), LayoutImmutable, Blittable, JsonProperty(Order = 326)]
		public bool LowerOnOwnTeam { get; set; }

		[ContainerField(327), LayoutImmutable, Blittable, JsonProperty(Order = 327)]
		public bool RedeployWhenSwitchingWeaponStates { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		public bool UseQuickThrowOnAutomaticSwitchback { get; set; }

		[ContainerField(329), LayoutImmutable, Blittable, JsonProperty(Order = 329)]
		public bool EnableBreathControl { get; set; }

		[ContainerField(330), LayoutImmutable, Blittable, JsonProperty(Order = 330)]
		public bool CanBeInSupportedShooting { get; set; }

		[ContainerField(331), LayoutImmutable, Blittable, JsonProperty(Order = 331)]
		public bool AllowSwitchingToWeaponReloading { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		public bool SwitchToPrimaryWhenOutOfAmmo { get; set; }

		[ContainerField(333), LayoutImmutable, Blittable, JsonProperty(Order = 333)]
		public bool AllowSwitchingToWeaponInVehicles { get; set; }

		[ContainerField(334), LayoutImmutable, Blittable, JsonProperty(Order = 334)]
		public bool IsSilenced { get; set; }

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
