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
	[ContainerType(16, 96)]
	public class ShotConfigData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialPosition { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialDirection { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialSpeed { get; set; } = new();
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float InheritWeaponSpeedAmount { get; set; }
		
		[ContainerField(52)]
		public CtrRef<ExplosionEntityData> MuzzleExplosion { get; set; } = new();
		
		[ContainerField(56)]
		public CtrRef<ProjectileEntityData> ProjectileData { get; set; } = new();
		
		[ContainerField(60)]
		public CtrRef<ProjectileEntityData> SecondaryProjectileData { get; set; } = new();
		
		[ContainerField(64)]
		public CtrRef<ProjectileBlueprint> Projectile { get; set; } = new();
		
		[ContainerField(68)]
		public CtrRef<ProjectileBlueprint> SecondaryProjectile { get; set; } = new();
		
		[ContainerField(72)]
		public List<UnlockableProjectile> AlternateProjectiles { get; set; } = new();
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float SpawnDelay { get; set; }
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public uint NumberOfBulletsPerShell { get; set; }
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public uint NumberOfBulletsPerShot { get; set; }
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public uint NumberOfBulletsPerBurst { get; set; }
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public bool RelativeTargetAiming { get; set; }
		
		[ContainerField(93), LayoutImmutable, Blittable]
		public bool ForceSpawnToCamera { get; set; }
		
		[ContainerField(94), LayoutImmutable, Blittable]
		public bool SpawnVisualAtWeaponBone { get; set; }
		
		[ContainerField(95), LayoutImmutable, Blittable]
		public bool ActiveForceSpawnToCamera { get; set; }
		
	}
}
