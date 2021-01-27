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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 96)]
	public class ShotConfigData : FrostbiteContainer
	{
		[ContainerField(Name: "InitialPosition", Offset: 0, NameHash: 3791803234, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialPosition { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "InitialDirection", Offset: 16, NameHash: 1073214622, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialDirection { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(Name: "InitialSpeed", Offset: 32, NameHash: 3681055580, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialSpeed { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(Name: "InheritWeaponSpeedAmount", Offset: 48, NameHash: 3681006953, Flags: 49469), LayoutImmutable, Blittable]
		public float InheritWeaponSpeedAmount { get; set; } // 0x30 (48)
		
		[ContainerField(Name: "MuzzleExplosion", Offset: 52, NameHash: 2257917377, Flags: 53)]
		public CtrRef<ExplosionEntityData> MuzzleExplosion { get; set; } = new CtrRef<ExplosionEntityData>(); // 0x34 (52)
		
		[ContainerField(Name: "ProjectileData", Offset: 56, NameHash: 2690942720, Flags: 53)]
		public CtrRef<ProjectileEntityData> ProjectileData { get; set; } = new CtrRef<ProjectileEntityData>(); // 0x38 (56)
		
		[ContainerField(Name: "SecondaryProjectileData", Offset: 60, NameHash: 2405794234, Flags: 53)]
		public CtrRef<ProjectileEntityData> SecondaryProjectileData { get; set; } = new CtrRef<ProjectileEntityData>(); // 0x3C (60)
		
		[ContainerField(Name: "Projectile", Offset: 64, NameHash: 3883939888, Flags: 53)]
		public CtrRef<ProjectileBlueprint> Projectile { get; set; } = new CtrRef<ProjectileBlueprint>(); // 0x40 (64)
		
		[ContainerField(Name: "SecondaryProjectile", Offset: 68, NameHash: 2606311818, Flags: 53)]
		public CtrRef<ProjectileBlueprint> SecondaryProjectile { get; set; } = new CtrRef<ProjectileBlueprint>(); // 0x44 (68)
		
		[ContainerField(Name: "AlternateProjectiles", Offset: 72, NameHash: 1066262867, Flags: 65)]
		public List<UnlockableProjectile> AlternateProjectiles { get; set; } = new List<UnlockableProjectile>(); // 0x48 (72)
		
		[ContainerField(Name: "SpawnDelay", Offset: 76, NameHash: 3473198411, Flags: 49469), LayoutImmutable, Blittable]
		public float SpawnDelay { get; set; } // 0x4C (76)
		
		[ContainerField(Name: "NumberOfBulletsPerShell", Offset: 80, NameHash: 464437027, Flags: 49421), LayoutImmutable, Blittable]
		public uint NumberOfBulletsPerShell { get; set; } // 0x50 (80)
		
		[ContainerField(Name: "NumberOfBulletsPerShot", Offset: 84, NameHash: 404525501, Flags: 49421), LayoutImmutable, Blittable]
		public uint NumberOfBulletsPerShot { get; set; } // 0x54 (84)
		
		[ContainerField(Name: "NumberOfBulletsPerBurst", Offset: 88, NameHash: 491113727, Flags: 49421), LayoutImmutable, Blittable]
		public uint NumberOfBulletsPerBurst { get; set; } // 0x58 (88)
		
		[ContainerField(Name: "RelativeTargetAiming", Offset: 92, NameHash: 3309775045, Flags: 49325), LayoutImmutable, Blittable]
		public bool RelativeTargetAiming { get; set; } // 0x5C (92)
		
		[ContainerField(Name: "ForceSpawnToCamera", Offset: 93, NameHash: 1364356545, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceSpawnToCamera { get; set; } // 0x5D (93)
		
		[ContainerField(Name: "SpawnVisualAtWeaponBone", Offset: 94, NameHash: 3532019419, Flags: 49325), LayoutImmutable, Blittable]
		public bool SpawnVisualAtWeaponBone { get; set; } // 0x5E (94)
		
		[ContainerField(Name: "ActiveForceSpawnToCamera", Offset: 95, NameHash: 2063799309, Flags: 49325), LayoutImmutable, Blittable]
		public bool ActiveForceSpawnToCamera { get; set; } // 0x5F (95)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3791803234:
					InitialPosition = (Vec3) p_Value;
					break;

				case 1073214622:
					InitialDirection = (Vec3) p_Value;
					break;

				case 3681055580:
					InitialSpeed = (Vec3) p_Value;
					break;

				case 3681006953:
					InheritWeaponSpeedAmount = (float) p_Value;
					break;

				case 2257917377:
					MuzzleExplosion = (CtrRef<ExplosionEntityData>) p_Value;
					break;

				case 2690942720:
					ProjectileData = (CtrRef<ProjectileEntityData>) p_Value;
					break;

				case 2405794234:
					SecondaryProjectileData = (CtrRef<ProjectileEntityData>) p_Value;
					break;

				case 3883939888:
					Projectile = (CtrRef<ProjectileBlueprint>) p_Value;
					break;

				case 2606311818:
					SecondaryProjectile = (CtrRef<ProjectileBlueprint>) p_Value;
					break;

				case 1066262867:
					AlternateProjectiles = (List<UnlockableProjectile>) p_Value;
					break;

				case 3473198411:
					SpawnDelay = (float) p_Value;
					break;

				case 464437027:
					NumberOfBulletsPerShell = (uint) p_Value;
					break;

				case 404525501:
					NumberOfBulletsPerShot = (uint) p_Value;
					break;

				case 491113727:
					NumberOfBulletsPerBurst = (uint) p_Value;
					break;

				case 3309775045:
					RelativeTargetAiming = (bool) p_Value;
					break;

				case 1364356545:
					ForceSpawnToCamera = (bool) p_Value;
					break;

				case 3532019419:
					SpawnVisualAtWeaponBone = (bool) p_Value;
					break;

				case 2063799309:
					ActiveForceSpawnToCamera = (bool) p_Value;
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
				case 3791803234:
					return InitialPosition;

				case 1073214622:
					return InitialDirection;

				case 3681055580:
					return InitialSpeed;

				case 3681006953:
					return InheritWeaponSpeedAmount;

				case 2257917377:
					return MuzzleExplosion;

				case 2690942720:
					return ProjectileData;

				case 2405794234:
					return SecondaryProjectileData;

				case 3883939888:
					return Projectile;

				case 2606311818:
					return SecondaryProjectile;

				case 1066262867:
					return AlternateProjectiles;

				case 3473198411:
					return SpawnDelay;

				case 464437027:
					return NumberOfBulletsPerShell;

				case 404525501:
					return NumberOfBulletsPerShot;

				case 491113727:
					return NumberOfBulletsPerBurst;

				case 3309775045:
					return RelativeTargetAiming;

				case 1364356545:
					return ForceSpawnToCamera;

				case 3532019419:
					return SpawnVisualAtWeaponBone;

				case 2063799309:
					return ActiveForceSpawnToCamera;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3791803234:
					return typeof(ShotConfigData).GetProperty(nameof(InitialPosition));

				case 1073214622:
					return typeof(ShotConfigData).GetProperty(nameof(InitialDirection));

				case 3681055580:
					return typeof(ShotConfigData).GetProperty(nameof(InitialSpeed));

				case 3681006953:
					return typeof(ShotConfigData).GetProperty(nameof(InheritWeaponSpeedAmount));

				case 2257917377:
					return typeof(ShotConfigData).GetProperty(nameof(MuzzleExplosion));

				case 2690942720:
					return typeof(ShotConfigData).GetProperty(nameof(ProjectileData));

				case 2405794234:
					return typeof(ShotConfigData).GetProperty(nameof(SecondaryProjectileData));

				case 3883939888:
					return typeof(ShotConfigData).GetProperty(nameof(Projectile));

				case 2606311818:
					return typeof(ShotConfigData).GetProperty(nameof(SecondaryProjectile));

				case 1066262867:
					return typeof(ShotConfigData).GetProperty(nameof(AlternateProjectiles));

				case 3473198411:
					return typeof(ShotConfigData).GetProperty(nameof(SpawnDelay));

				case 464437027:
					return typeof(ShotConfigData).GetProperty(nameof(NumberOfBulletsPerShell));

				case 404525501:
					return typeof(ShotConfigData).GetProperty(nameof(NumberOfBulletsPerShot));

				case 491113727:
					return typeof(ShotConfigData).GetProperty(nameof(NumberOfBulletsPerBurst));

				case 3309775045:
					return typeof(ShotConfigData).GetProperty(nameof(RelativeTargetAiming));

				case 1364356545:
					return typeof(ShotConfigData).GetProperty(nameof(ForceSpawnToCamera));

				case 3532019419:
					return typeof(ShotConfigData).GetProperty(nameof(SpawnVisualAtWeaponBone));

				case 2063799309:
					return typeof(ShotConfigData).GetProperty(nameof(ActiveForceSpawnToCamera));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
