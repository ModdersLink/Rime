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
		public List<CtrRef<SocketData>> Sockets { get; set; } = new();

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

		public static void Deserialize(SoldierWeaponData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.InteractionOffset, p_Reader, p_Parser);
			p_Instance.WeaponModifierData.Clear();
			(RimeReader Reader, uint Count) s_WeaponModifierData = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_WeaponModifierData.Count; ++i)
			{
				var s_Value = new WeaponModifierData();
				fb.WeaponModifierData.Deserialize(s_Value, s_WeaponModifierData.Reader, p_Parser);
				p_Instance.WeaponModifierData.Add(s_Value);
			}
			
			s_WeaponModifierData.Reader.Dispose();
			p_Instance.AimingController.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.FirstPersonCamera.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.HudData.Deserialize(p_Instance.Hud, p_Reader, p_Parser);
			p_Instance.DamageGiverName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(12, SeekOrigin.Current);
			fb.PickupSettingsData.Deserialize(p_Instance.PickupSettings, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.AnimBaseSet = (WeaponAnimBaseSetEnum) p_Reader.ReadInt32();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.AnimationData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.RenderFov = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.ZoomRenderFov = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.StreamGroup1p.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.VoiceOverInfo.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.QuickThrowType = (QuickThrowTypeEnum) p_Reader.ReadInt32();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.Customization.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.WeaponFloatParam = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.Sockets.Clear();
			(RimeReader Reader, uint Count) s_Sockets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Sockets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SocketData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Sockets.Reader.ReadUInt32()));
				p_Instance.Sockets.Add(s_CtrRef);
			}
			
			s_Sockets.Reader.Dispose();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.SwitchWeaponStateInputAction = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.SoldierWeaponBlueprint.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.PersistenceId = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.AllowSwitchingToWeaponOutOfAmmo = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.HideWhenOutOfAmmo = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.LowerOnOwnTeam = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.RedeployWhenSwitchingWeaponStates = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.UseQuickThrowOnAutomaticSwitchback = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.EnableBreathControl = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.CanBeInSupportedShooting = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.AllowSwitchingToWeaponReloading = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.SwitchToPrimaryWhenOutOfAmmo = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.AllowSwitchingToWeaponInVehicles = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.IsSilenced = p_Reader.ReadBool();
			p_Reader.Seek(13, SeekOrigin.Current);
		}

	}
}
