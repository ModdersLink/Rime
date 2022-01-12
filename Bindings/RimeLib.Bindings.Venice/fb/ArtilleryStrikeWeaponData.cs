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
	[ContainerType(4, 92)]
	public class ArtilleryStrikeWeaponData : 
		WeaponData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MaxStrikeDistance { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float StrikeRadius { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float SpawnHeight { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxRandomSpawnHeight { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float StrikeCameraOffset { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float SpawnHeightMultiplier { get; set; }

		[ContainerField(40)]
		public CtrRef<TargetCameraData> Camera { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public float AimingCameraHeight { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float StrikeCameraHeight { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float AimingCameraOffset { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float StrikeCameraFov { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float AimingCameraFov { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float DelayBeforeAimingCamera { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float ValidMinDistance { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float FireCameraTime { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float StrikeCameraTime { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float ValidMaxDistance { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float ValidMaxAngle { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public bool IncreaseSpawnHeightWithDistance { get; set; }

		[ContainerField(89), LayoutImmutable, Blittable]
		public bool EnableProjectileTrails { get; set; }

		[ContainerField(90), LayoutImmutable, Blittable]
		public bool EnableCameraRotation { get; set; }

		[ContainerField(91), LayoutImmutable, Blittable]
		public bool FireProjectileFromWeapon { get; set; }

	}
}
