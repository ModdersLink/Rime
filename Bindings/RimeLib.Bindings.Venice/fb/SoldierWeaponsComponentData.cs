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
	[ContainerType(16, 480)]
	public class SoldierWeaponsComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AimDir { get; set; } = new();

		[ContainerField(160)]
		public CtrRef<SkeletonAsset> WeaponSkeleton { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable]
		public int PrimaryWeaponId { get; set; }

		[ContainerField(168)]
		public AnimatedWeaponBinding AnimatedWeaponBinding { get; set; } = new();

		[ContainerField(424)]
		public Animated1pOnlyWeaponBinding Animated1pOnlyWeaponBinding { get; set; } = new();

		[ContainerField(440)]
		public Animated3pOnlyWeaponBinding Animated3pOnlyWeaponBinding { get; set; } = new();

		[ContainerField(448), LayoutImmutable, Blittable]
		public float LockTimeMultiplier { get; set; }

		[ContainerField(452), LayoutImmutable, Blittable]
		public int GrenadeIncrease { get; set; }

		[ContainerField(456), LayoutImmutable, Blittable]
		public float AmmoClipIncreaseMultiplier { get; set; }

		[ContainerField(460), LayoutImmutable, Blittable]
		public float ExplosiveIncreaseMultiplier { get; set; }

		[ContainerField(464), LayoutImmutable, Blittable]
		public int UnderslungGrenadeIncrease { get; set; }

		[ContainerField(468), LayoutImmutable, Blittable]
		public bool UseExternalAimDir { get; set; }

		[ContainerField(469), LayoutImmutable, Blittable]
		public bool UnlimitedAmmo { get; set; }

		[ContainerField(470), LayoutImmutable, Blittable]
		public bool UnlimitedMags { get; set; }

	}
}
