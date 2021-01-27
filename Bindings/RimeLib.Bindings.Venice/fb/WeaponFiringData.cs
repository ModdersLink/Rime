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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 64)]
	public class WeaponFiringData : 
		GameDataContainer
	{
		protected CtrRef<FiringFunctionData> m_PrimaryFire = new CtrRef<FiringFunctionData>();
		[ContainerField(Name: "PrimaryFire", Offset: 8, NameHash: 1894912945, Flags: 53)]
		public CtrRef<FiringFunctionData> PrimaryFire { get { return m_PrimaryFire; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(PrimaryFire), this, m_PrimaryFire, value)) m_PrimaryFire = value; } } // 0x8 (8)
		
		protected float m_DeployTime = new float();
		[ContainerField(Name: "DeployTime", Offset: 12, NameHash: 2275884507, Flags: 49469), LayoutImmutable, Blittable]
		public float DeployTime { get { return m_DeployTime; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(DeployTime), this, m_DeployTime, value)) m_DeployTime = value; } } // 0xC (12)
		
		protected float m_ReactivateCooldownTime = new float();
		[ContainerField(Name: "ReactivateCooldownTime", Offset: 16, NameHash: 732426371, Flags: 49469), LayoutImmutable, Blittable]
		public float ReactivateCooldownTime { get { return m_ReactivateCooldownTime; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(ReactivateCooldownTime), this, m_ReactivateCooldownTime, value)) m_ReactivateCooldownTime = value; } } // 0x10 (16)
		
		protected float m_DisableZoomOnDeployTime = new float();
		[ContainerField(Name: "DisableZoomOnDeployTime", Offset: 20, NameHash: 3731232633, Flags: 49469), LayoutImmutable, Blittable]
		public float DisableZoomOnDeployTime { get { return m_DisableZoomOnDeployTime; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(DisableZoomOnDeployTime), this, m_DisableZoomOnDeployTime, value)) m_DisableZoomOnDeployTime = value; } } // 0x14 (20)
		
		protected float m_AltDeployTime = new float();
		[ContainerField(Name: "AltDeployTime", Offset: 24, NameHash: 1924470306, Flags: 49469), LayoutImmutable, Blittable]
		public float AltDeployTime { get { return m_AltDeployTime; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(AltDeployTime), this, m_AltDeployTime, value)) m_AltDeployTime = value; } } // 0x18 (24)
		
		protected int m_AltDeployId = new int();
		[ContainerField(Name: "AltDeployId", Offset: 28, NameHash: 1819931514, Flags: 49405), LayoutImmutable, Blittable]
		public int AltDeployId { get { return m_AltDeployId; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(AltDeployId), this, m_AltDeployId, value)) m_AltDeployId = value; } } // 0x1C (28)
		
		protected CtrRef<WeaponSwayData> m_WeaponSway = new CtrRef<WeaponSwayData>();
		[ContainerField(Name: "WeaponSway", Offset: 32, NameHash: 933173371, Flags: 53)]
		public CtrRef<WeaponSwayData> WeaponSway { get { return m_WeaponSway; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(WeaponSway), this, m_WeaponSway, value)) m_WeaponSway = value; } } // 0x20 (32)
		
		protected float m_SupportDelayProne = new float();
		[ContainerField(Name: "SupportDelayProne", Offset: 36, NameHash: 3926871609, Flags: 49469), LayoutImmutable, Blittable]
		public float SupportDelayProne { get { return m_SupportDelayProne; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(SupportDelayProne), this, m_SupportDelayProne, value)) m_SupportDelayProne = value; } } // 0x24 (36)
		
		protected float m_SupportDelayStand = new float();
		[ContainerField(Name: "SupportDelayStand", Offset: 40, NameHash: 3920813299, Flags: 49469), LayoutImmutable, Blittable]
		public float SupportDelayStand { get { return m_SupportDelayStand; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(SupportDelayStand), this, m_SupportDelayStand, value)) m_SupportDelayStand = value; } } // 0x28 (40)
		
		protected RumbleFiringData m_Rumble = new RumbleFiringData();
		[ContainerField(Name: "Rumble", Offset: 44, NameHash: 3275215748, Flags: 41)]
		public RumbleFiringData Rumble { get { return m_Rumble; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(Rumble), this, m_Rumble, value)) m_Rumble = value; } } // 0x2C (44)
		
		protected bool m_InflictSelfDamage = new bool();
		[ContainerField(Name: "InflictSelfDamage", Offset: 56, NameHash: 4046344033, Flags: 49325), LayoutImmutable, Blittable]
		public bool InflictSelfDamage { get { return m_InflictSelfDamage; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(InflictSelfDamage), this, m_InflictSelfDamage, value)) m_InflictSelfDamage = value; } } // 0x38 (56)
		
		protected bool m_UseAutoAiming = new bool();
		[ContainerField(Name: "UseAutoAiming", Offset: 57, NameHash: 2972101868, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseAutoAiming { get { return m_UseAutoAiming; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(UseAutoAiming), this, m_UseAutoAiming, value)) m_UseAutoAiming = value; } } // 0x39 (57)
		
		protected bool m_ShowEnemyNametagOnAim = new bool();
		[ContainerField(Name: "ShowEnemyNametagOnAim", Offset: 58, NameHash: 64653709, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowEnemyNametagOnAim { get { return m_ShowEnemyNametagOnAim; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(ShowEnemyNametagOnAim), this, m_ShowEnemyNametagOnAim, value)) m_ShowEnemyNametagOnAim = value; } } // 0x3A (58)
		
		protected bool m_ReloadWholeMags = new bool();
		[ContainerField(Name: "ReloadWholeMags", Offset: 59, NameHash: 3901798901, Flags: 49325), LayoutImmutable, Blittable]
		public bool ReloadWholeMags { get { return m_ReloadWholeMags; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(ReloadWholeMags), this, m_ReloadWholeMags, value)) m_ReloadWholeMags = value; } } // 0x3B (59)
		
		protected bool m_DisableReloadWhileSprinting = new bool();
		[ContainerField(Name: "DisableReloadWhileSprinting", Offset: 60, NameHash: 2335508285, Flags: 49325), LayoutImmutable, Blittable]
		public bool DisableReloadWhileSprinting { get { return m_DisableReloadWhileSprinting; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(DisableReloadWhileSprinting), this, m_DisableReloadWhileSprinting, value)) m_DisableReloadWhileSprinting = value; } } // 0x3C (60)
		
		protected bool m_AbortReloadOnSprint = new bool();
		[ContainerField(Name: "AbortReloadOnSprint", Offset: 61, NameHash: 923004157, Flags: 49325), LayoutImmutable, Blittable]
		public bool AbortReloadOnSprint { get { return m_AbortReloadOnSprint; } set { if (OnPropertyChanging("WeaponFiringData." + nameof(AbortReloadOnSprint), this, m_AbortReloadOnSprint, value)) m_AbortReloadOnSprint = value; } } // 0x3D (61)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1894912945:
					PrimaryFire = (CtrRef<FiringFunctionData>) p_Value;
					break;

				case 2275884507:
					DeployTime = (float) p_Value;
					break;

				case 732426371:
					ReactivateCooldownTime = (float) p_Value;
					break;

				case 3731232633:
					DisableZoomOnDeployTime = (float) p_Value;
					break;

				case 1924470306:
					AltDeployTime = (float) p_Value;
					break;

				case 1819931514:
					AltDeployId = (int) p_Value;
					break;

				case 933173371:
					WeaponSway = (CtrRef<WeaponSwayData>) p_Value;
					break;

				case 3926871609:
					SupportDelayProne = (float) p_Value;
					break;

				case 3920813299:
					SupportDelayStand = (float) p_Value;
					break;

				case 3275215748:
					Rumble = (RumbleFiringData) p_Value;
					break;

				case 4046344033:
					InflictSelfDamage = (bool) p_Value;
					break;

				case 2972101868:
					UseAutoAiming = (bool) p_Value;
					break;

				case 64653709:
					ShowEnemyNametagOnAim = (bool) p_Value;
					break;

				case 3901798901:
					ReloadWholeMags = (bool) p_Value;
					break;

				case 2335508285:
					DisableReloadWhileSprinting = (bool) p_Value;
					break;

				case 923004157:
					AbortReloadOnSprint = (bool) p_Value;
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
				case 1894912945:
					return PrimaryFire;

				case 2275884507:
					return DeployTime;

				case 732426371:
					return ReactivateCooldownTime;

				case 3731232633:
					return DisableZoomOnDeployTime;

				case 1924470306:
					return AltDeployTime;

				case 1819931514:
					return AltDeployId;

				case 933173371:
					return WeaponSway;

				case 3926871609:
					return SupportDelayProne;

				case 3920813299:
					return SupportDelayStand;

				case 3275215748:
					return Rumble;

				case 4046344033:
					return InflictSelfDamage;

				case 2972101868:
					return UseAutoAiming;

				case 64653709:
					return ShowEnemyNametagOnAim;

				case 3901798901:
					return ReloadWholeMags;

				case 2335508285:
					return DisableReloadWhileSprinting;

				case 923004157:
					return AbortReloadOnSprint;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1894912945:
					return typeof(WeaponFiringData).GetProperty(nameof(PrimaryFire));

				case 2275884507:
					return typeof(WeaponFiringData).GetProperty(nameof(DeployTime));

				case 732426371:
					return typeof(WeaponFiringData).GetProperty(nameof(ReactivateCooldownTime));

				case 3731232633:
					return typeof(WeaponFiringData).GetProperty(nameof(DisableZoomOnDeployTime));

				case 1924470306:
					return typeof(WeaponFiringData).GetProperty(nameof(AltDeployTime));

				case 1819931514:
					return typeof(WeaponFiringData).GetProperty(nameof(AltDeployId));

				case 933173371:
					return typeof(WeaponFiringData).GetProperty(nameof(WeaponSway));

				case 3926871609:
					return typeof(WeaponFiringData).GetProperty(nameof(SupportDelayProne));

				case 3920813299:
					return typeof(WeaponFiringData).GetProperty(nameof(SupportDelayStand));

				case 3275215748:
					return typeof(WeaponFiringData).GetProperty(nameof(Rumble));

				case 4046344033:
					return typeof(WeaponFiringData).GetProperty(nameof(InflictSelfDamage));

				case 2972101868:
					return typeof(WeaponFiringData).GetProperty(nameof(UseAutoAiming));

				case 64653709:
					return typeof(WeaponFiringData).GetProperty(nameof(ShowEnemyNametagOnAim));

				case 3901798901:
					return typeof(WeaponFiringData).GetProperty(nameof(ReloadWholeMags));

				case 2335508285:
					return typeof(WeaponFiringData).GetProperty(nameof(DisableReloadWhileSprinting));

				case 923004157:
					return typeof(WeaponFiringData).GetProperty(nameof(AbortReloadOnSprint));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
