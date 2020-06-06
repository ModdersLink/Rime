///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class WeaponFiringData : 
		GameDataContainer
	{
		[ContainerField(8)]
		public CtrRef<FiringFunctionData> PrimaryFire { get; set; } = new CtrRef<FiringFunctionData>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float DeployTime { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ReactivateCooldownTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float DisableZoomOnDeployTime { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float AltDeployTime { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int AltDeployId { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<WeaponSwayData> WeaponSway { get; set; } = new CtrRef<WeaponSwayData>(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float SupportDelayProne { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float SupportDelayStand { get; set; } // 0x28 (40)
		
		[ContainerField(44)]
		public RumbleFiringData Rumble { get; set; } = new RumbleFiringData(); // 0x2C (44)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public bool InflictSelfDamage { get; set; } // 0x38 (56)
		
		[ContainerField(57), LayoutImmutable, Blittable]
		public bool UseAutoAiming { get; set; } // 0x39 (57)
		
		[ContainerField(58), LayoutImmutable, Blittable]
		public bool ShowEnemyNametagOnAim { get; set; } // 0x3A (58)
		
		[ContainerField(59), LayoutImmutable, Blittable]
		public bool ReloadWholeMags { get; set; } // 0x3B (59)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool DisableReloadWhileSprinting { get; set; } // 0x3C (60)
		
		[ContainerField(61), LayoutImmutable, Blittable]
		public bool AbortReloadOnSprint { get; set; } // 0x3D (61)
		
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
