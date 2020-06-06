///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class WeaponComponentData : 
		PartComponentData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ProjectileSpawnOffset { get; set; } = new Vec3(); // 0x70 (112)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float ImpulseStrength { get; set; } // 0x80 (128)
		
		[ContainerField(132)]
		public CtrRef<MeshAsset> WeaponMesh { get; set; } = new CtrRef<MeshAsset>(); // 0x84 (132)
		
		[ContainerField(136)]
		public CtrRef<WeaponFiringData> WeaponFiring { get; set; } = new CtrRef<WeaponFiringData>(); // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable]
		public string DamageGiverName { get; set; } // 0x8C (140)
		
		[ContainerField(144)]
		public CtrRef<GameAIWeaponData> AIData { get; set; } = new CtrRef<GameAIWeaponData>(); // 0x90 (144)
		
		[ContainerField(148)]
		public CtrRef<WeaponData> CustomWeaponType { get; set; } = new CtrRef<WeaponData>(); // 0x94 (148)
		
		[ContainerField(152)]
		public WeaponClassification Classification { get; set; } = new WeaponClassification(); // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float ExplosionDamageMultiplier { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float ReloadTimeMultiplier { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float DamageMultiplier { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public uint WeaponItemHash { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public float OverheatDropPerSecondMultiplier { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float LockTimeMultiplier { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float LockingAcceptanceAngleMultiplier { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public bool SequentialFiring { get; set; } // 0xB8 (184)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 36316966:
					ProjectileSpawnOffset = (Vec3) p_Value;
					break;

				case 722393051:
					ImpulseStrength = (float) p_Value;
					break;

				case 932694772:
					WeaponMesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 1823157050:
					WeaponFiring = (CtrRef<WeaponFiringData>) p_Value;
					break;

				case 38100006:
					DamageGiverName = (string) p_Value;
					break;

				case 2529950045:
					AIData = (CtrRef<GameAIWeaponData>) p_Value;
					break;

				case 3603058156:
					CustomWeaponType = (CtrRef<WeaponData>) p_Value;
					break;

				case 1196599827:
					Classification = (WeaponClassification) Enum.ToObject(typeof(WeaponClassification), p_Value);
					break;

				case 1685883856:
					ExplosionDamageMultiplier = (float) p_Value;
					break;

				case 2574353098:
					ReloadTimeMultiplier = (float) p_Value;
					break;

				case 2936063845:
					DamageMultiplier = (float) p_Value;
					break;

				case 3522794400:
					WeaponItemHash = (uint) p_Value;
					break;

				case 273863558:
					OverheatDropPerSecondMultiplier = (float) p_Value;
					break;

				case 1309101584:
					LockTimeMultiplier = (float) p_Value;
					break;

				case 4054344813:
					LockingAcceptanceAngleMultiplier = (float) p_Value;
					break;

				case 2022632657:
					SequentialFiring = (bool) p_Value;
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
				case 36316966:
					return ProjectileSpawnOffset;

				case 722393051:
					return ImpulseStrength;

				case 932694772:
					return WeaponMesh;

				case 1823157050:
					return WeaponFiring;

				case 38100006:
					return DamageGiverName;

				case 2529950045:
					return AIData;

				case 3603058156:
					return CustomWeaponType;

				case 1196599827:
					return Classification;

				case 1685883856:
					return ExplosionDamageMultiplier;

				case 2574353098:
					return ReloadTimeMultiplier;

				case 2936063845:
					return DamageMultiplier;

				case 3522794400:
					return WeaponItemHash;

				case 273863558:
					return OverheatDropPerSecondMultiplier;

				case 1309101584:
					return LockTimeMultiplier;

				case 4054344813:
					return LockingAcceptanceAngleMultiplier;

				case 2022632657:
					return SequentialFiring;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 36316966:
					return typeof(WeaponComponentData).GetProperty(nameof(ProjectileSpawnOffset));

				case 722393051:
					return typeof(WeaponComponentData).GetProperty(nameof(ImpulseStrength));

				case 932694772:
					return typeof(WeaponComponentData).GetProperty(nameof(WeaponMesh));

				case 1823157050:
					return typeof(WeaponComponentData).GetProperty(nameof(WeaponFiring));

				case 38100006:
					return typeof(WeaponComponentData).GetProperty(nameof(DamageGiverName));

				case 2529950045:
					return typeof(WeaponComponentData).GetProperty(nameof(AIData));

				case 3603058156:
					return typeof(WeaponComponentData).GetProperty(nameof(CustomWeaponType));

				case 1196599827:
					return typeof(WeaponComponentData).GetProperty(nameof(Classification));

				case 1685883856:
					return typeof(WeaponComponentData).GetProperty(nameof(ExplosionDamageMultiplier));

				case 2574353098:
					return typeof(WeaponComponentData).GetProperty(nameof(ReloadTimeMultiplier));

				case 2936063845:
					return typeof(WeaponComponentData).GetProperty(nameof(DamageMultiplier));

				case 3522794400:
					return typeof(WeaponComponentData).GetProperty(nameof(WeaponItemHash));

				case 273863558:
					return typeof(WeaponComponentData).GetProperty(nameof(OverheatDropPerSecondMultiplier));

				case 1309101584:
					return typeof(WeaponComponentData).GetProperty(nameof(LockTimeMultiplier));

				case 4054344813:
					return typeof(WeaponComponentData).GetProperty(nameof(LockingAcceptanceAngleMultiplier));

				case 2022632657:
					return typeof(WeaponComponentData).GetProperty(nameof(SequentialFiring));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
