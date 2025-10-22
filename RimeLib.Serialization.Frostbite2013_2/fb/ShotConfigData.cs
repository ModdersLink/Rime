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

using fb.Core;

namespace fb.GameShared;

[ContainerType(16, 144)]
public class ShotConfigData
	: EbxSerializable
{
	[ContainerField(0x0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public Vec3 InitialPosition { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x10), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public Vec3 InitialDirection { get; set; } = new()
	{
		z = 1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 InitialSpeed { get; set; } = new()
	{
		z = 350.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<InitialDirectionScaleByPitchData> InitialDirectionScaleByPitch { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<InitialSpeedScaleByPitchData> InitialSpeedScaleByPitch { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float InheritWeaponSpeedAmount { get; set; } = 0.000f;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<ExplosionEntityData> MuzzleExplosion { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<ProjectileEntityData> ProjectileData { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<ProjectileEntityData> SecondaryProjectileData { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<ProjectileBlueprint> Projectile { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<ProjectileBlueprint> SecondaryProjectile { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float SpawnDelay { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float SpawnDelayZoomed { get; set; } = -1.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public uint NumberOfBulletsPerShell { get; set; } = 1;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public uint NumberOfBulletsPerShot { get; set; } = 1;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public uint NumberOfBulletsPerBurst { get; set; } = 3;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public bool RelativeTargetAiming { get; set; } = false;
	
	[ContainerField(0x85), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
	public bool ForceSpawnToCamera { get; set; } = false;
	
	[ContainerField(0x86), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
	public bool SpawnVisualAtWeaponBone { get; set; } = false;
	
	[ContainerField(0x87), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
	public bool ActiveForceSpawnToCamera { get; set; } = true;
	
}

