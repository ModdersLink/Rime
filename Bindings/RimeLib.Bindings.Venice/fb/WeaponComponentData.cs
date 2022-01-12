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
	[ContainerType(16, 192)]
	public class WeaponComponentData : 
		PartComponentData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ProjectileSpawnOffset { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public float ImpulseStrength { get; set; }

		[ContainerField(132)]
		public CtrRef<MeshAsset> WeaponMesh { get; set; } = new();

		[ContainerField(136)]
		public CtrRef<WeaponFiringData> WeaponFiring { get; set; } = new();

		[ContainerField(140), LayoutImmutable]
		public string DamageGiverName { get; set; } = string.Empty;

		[ContainerField(144)]
		public CtrRef<GameAIWeaponData> AIData { get; set; } = new();

		[ContainerField(148)]
		public CtrRef<WeaponData> CustomWeaponType { get; set; } = new();

		[ContainerField(152)]
		public WeaponClassification Classification { get; set; } = new();

		[ContainerField(156), LayoutImmutable, Blittable]
		public float ExplosionDamageMultiplier { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float ReloadTimeMultiplier { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float DamageMultiplier { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public uint WeaponItemHash { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public float OverheatDropPerSecondMultiplier { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float LockTimeMultiplier { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float LockingAcceptanceAngleMultiplier { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public bool SequentialFiring { get; set; }

	}
}
