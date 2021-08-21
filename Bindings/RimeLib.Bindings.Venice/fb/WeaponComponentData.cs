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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 192)]
	public class WeaponComponentData : 
		PartComponentData
	{
		protected Vec3 m_ProjectileSpawnOffset = new Vec3();
		[ContainerField(Name: "ProjectileSpawnOffset", Offset: 112, NameHash: 36316966, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ProjectileSpawnOffset { get { return m_ProjectileSpawnOffset; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(ProjectileSpawnOffset), this, m_ProjectileSpawnOffset, value)) m_ProjectileSpawnOffset = value; } } // 0x70 (112)
		
		protected float m_ImpulseStrength = new float();
		[ContainerField(Name: "ImpulseStrength", Offset: 128, NameHash: 722393051, Flags: 49469), LayoutImmutable, Blittable]
		public float ImpulseStrength { get { return m_ImpulseStrength; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(ImpulseStrength), this, m_ImpulseStrength, value)) m_ImpulseStrength = value; } } // 0x80 (128)
		
		protected CtrRef<MeshAsset> m_WeaponMesh = new CtrRef<MeshAsset>();
		[ContainerField(Name: "WeaponMesh", Offset: 132, NameHash: 932694772, Flags: 53)]
		public CtrRef<MeshAsset> WeaponMesh { get { return m_WeaponMesh; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(WeaponMesh), this, m_WeaponMesh, value)) m_WeaponMesh = value; } } // 0x84 (132)
		
		protected CtrRef<WeaponFiringData> m_WeaponFiring = new CtrRef<WeaponFiringData>();
		[ContainerField(Name: "WeaponFiring", Offset: 136, NameHash: 1823157050, Flags: 53)]
		public CtrRef<WeaponFiringData> WeaponFiring { get { return m_WeaponFiring; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(WeaponFiring), this, m_WeaponFiring, value)) m_WeaponFiring = value; } } // 0x88 (136)
		
		protected string m_DamageGiverName = string.Empty;
		[ContainerField(Name: "DamageGiverName", Offset: 140, NameHash: 38100006, Flags: 16509), LayoutImmutable]
		public string DamageGiverName { get { return m_DamageGiverName; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(DamageGiverName), this, m_DamageGiverName, value)) m_DamageGiverName = value; } } // 0x8C (140)
		
		protected CtrRef<GameAIWeaponData> m_AIData = new CtrRef<GameAIWeaponData>();
		[ContainerField(Name: "AIData", Offset: 144, NameHash: 2529950045, Flags: 53)]
		public CtrRef<GameAIWeaponData> AIData { get { return m_AIData; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(AIData), this, m_AIData, value)) m_AIData = value; } } // 0x90 (144)
		
		protected CtrRef<WeaponData> m_CustomWeaponType = new CtrRef<WeaponData>();
		[ContainerField(Name: "CustomWeaponType", Offset: 148, NameHash: 3603058156, Flags: 53)]
		public CtrRef<WeaponData> CustomWeaponType { get { return m_CustomWeaponType; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(CustomWeaponType), this, m_CustomWeaponType, value)) m_CustomWeaponType = value; } } // 0x94 (148)
		
		protected WeaponClassification m_Classification = new WeaponClassification();
		[ContainerField(Name: "Classification", Offset: 152, NameHash: 1196599827, Flags: 137)]
		public WeaponClassification Classification { get { return m_Classification; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(Classification), this, m_Classification, value)) m_Classification = value; } } // 0x98 (152)
		
		protected float m_ExplosionDamageMultiplier = new float();
		[ContainerField(Name: "ExplosionDamageMultiplier", Offset: 156, NameHash: 1685883856, Flags: 49469), LayoutImmutable, Blittable]
		public float ExplosionDamageMultiplier { get { return m_ExplosionDamageMultiplier; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(ExplosionDamageMultiplier), this, m_ExplosionDamageMultiplier, value)) m_ExplosionDamageMultiplier = value; } } // 0x9C (156)
		
		protected float m_ReloadTimeMultiplier = new float();
		[ContainerField(Name: "ReloadTimeMultiplier", Offset: 160, NameHash: 2574353098, Flags: 49469), LayoutImmutable, Blittable]
		public float ReloadTimeMultiplier { get { return m_ReloadTimeMultiplier; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(ReloadTimeMultiplier), this, m_ReloadTimeMultiplier, value)) m_ReloadTimeMultiplier = value; } } // 0xA0 (160)
		
		protected float m_DamageMultiplier = new float();
		[ContainerField(Name: "DamageMultiplier", Offset: 164, NameHash: 2936063845, Flags: 49469), LayoutImmutable, Blittable]
		public float DamageMultiplier { get { return m_DamageMultiplier; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(DamageMultiplier), this, m_DamageMultiplier, value)) m_DamageMultiplier = value; } } // 0xA4 (164)
		
		protected uint m_WeaponItemHash = new uint();
		[ContainerField(Name: "WeaponItemHash", Offset: 168, NameHash: 3522794400, Flags: 49421), LayoutImmutable, Blittable]
		public uint WeaponItemHash { get { return m_WeaponItemHash; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(WeaponItemHash), this, m_WeaponItemHash, value)) m_WeaponItemHash = value; } } // 0xA8 (168)
		
		protected float m_OverheatDropPerSecondMultiplier = new float();
		[ContainerField(Name: "OverheatDropPerSecondMultiplier", Offset: 172, NameHash: 273863558, Flags: 49469), LayoutImmutable, Blittable]
		public float OverheatDropPerSecondMultiplier { get { return m_OverheatDropPerSecondMultiplier; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(OverheatDropPerSecondMultiplier), this, m_OverheatDropPerSecondMultiplier, value)) m_OverheatDropPerSecondMultiplier = value; } } // 0xAC (172)
		
		protected float m_LockTimeMultiplier = new float();
		[ContainerField(Name: "LockTimeMultiplier", Offset: 176, NameHash: 1309101584, Flags: 49469), LayoutImmutable, Blittable]
		public float LockTimeMultiplier { get { return m_LockTimeMultiplier; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(LockTimeMultiplier), this, m_LockTimeMultiplier, value)) m_LockTimeMultiplier = value; } } // 0xB0 (176)
		
		protected float m_LockingAcceptanceAngleMultiplier = new float();
		[ContainerField(Name: "LockingAcceptanceAngleMultiplier", Offset: 180, NameHash: 4054344813, Flags: 49469), LayoutImmutable, Blittable]
		public float LockingAcceptanceAngleMultiplier { get { return m_LockingAcceptanceAngleMultiplier; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(LockingAcceptanceAngleMultiplier), this, m_LockingAcceptanceAngleMultiplier, value)) m_LockingAcceptanceAngleMultiplier = value; } } // 0xB4 (180)
		
		protected bool m_SequentialFiring = new bool();
		[ContainerField(Name: "SequentialFiring", Offset: 184, NameHash: 2022632657, Flags: 49325), LayoutImmutable, Blittable]
		public bool SequentialFiring { get { return m_SequentialFiring; } set { if (OnPropertyChanging("WeaponComponentData." + nameof(SequentialFiring), this, m_SequentialFiring, value)) m_SequentialFiring = value; } } // 0xB8 (184)
		
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
