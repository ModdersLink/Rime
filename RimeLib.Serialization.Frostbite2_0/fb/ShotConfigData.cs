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

namespace fb
{
	[ContainerType(16, 96)]
	public class ShotConfigData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 InitialPosition { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 InitialDirection { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 InitialSpeed { get; set; } = new();
		
		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float InheritWeaponSpeedAmount { get; set; }
		
		[ContainerField(52), JsonProperty(Order = 52)]
		public CtrRef<ExplosionEntityData> MuzzleExplosion { get; set; } = new();
		
		[ContainerField(56), JsonProperty(Order = 56)]
		public CtrRef<ProjectileEntityData> ProjectileData { get; set; } = new();
		
		[ContainerField(60), JsonProperty(Order = 60)]
		public CtrRef<ProjectileEntityData> SecondaryProjectileData { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public CtrRef<ProjectileBlueprint> Projectile { get; set; } = new();
		
		[ContainerField(68), JsonProperty(Order = 68)]
		public CtrRef<ProjectileBlueprint> SecondaryProjectile { get; set; } = new();
		
		[ContainerField(72), JsonProperty(Order = 72)]
		public List<UnlockableProjectile> AlternateProjectiles { get; set; } = new();
		
		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float SpawnDelay { get; set; }
		
		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public uint NumberOfBulletsPerShell { get; set; }
		
		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public uint NumberOfBulletsPerShot { get; set; }
		
		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public uint NumberOfBulletsPerBurst { get; set; }
		
		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public bool RelativeTargetAiming { get; set; }
		
		[ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		public bool ForceSpawnToCamera { get; set; }
		
		[ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		public bool SpawnVisualAtWeaponBone { get; set; }
		
		[ContainerField(95), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
		public bool ActiveForceSpawnToCamera { get; set; }
		
	}
}
