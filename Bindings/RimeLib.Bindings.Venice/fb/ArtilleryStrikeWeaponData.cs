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
	public class ArtilleryStrikeWeaponData : 
		WeaponData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MaxStrikeDistance { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float StrikeRadius { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float SpawnHeight { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxRandomSpawnHeight { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float StrikeCameraOffset { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float SpawnHeightMultiplier { get; set; } // 0x24 (36)
		
		[ContainerField(40)]
		public CtrRef<TargetCameraData> Camera { get; set; } = new CtrRef<TargetCameraData>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float AimingCameraHeight { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float StrikeCameraHeight { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float AimingCameraOffset { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float StrikeCameraFov { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float AimingCameraFov { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float DelayBeforeAimingCamera { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float ValidMinDistance { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float FireCameraTime { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float StrikeCameraTime { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float ValidMaxDistance { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float ValidMaxAngle { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public bool IncreaseSpawnHeightWithDistance { get; set; } // 0x58 (88)
		
		[ContainerField(89), LayoutImmutable, Blittable]
		public bool EnableProjectileTrails { get; set; } // 0x59 (89)
		
		[ContainerField(90), LayoutImmutable, Blittable]
		public bool EnableCameraRotation { get; set; } // 0x5A (90)
		
		[ContainerField(91), LayoutImmutable, Blittable]
		public bool FireProjectileFromWeapon { get; set; } // 0x5B (91)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3419412896:
					MaxStrikeDistance = (float) p_Value;
					break;

				case 4030357871:
					StrikeRadius = (float) p_Value;
					break;

				case 2780846849:
					SpawnHeight = (float) p_Value;
					break;

				case 2881356526:
					MaxRandomSpawnHeight = (float) p_Value;
					break;

				case 2966290851:
					StrikeCameraOffset = (float) p_Value;
					break;

				case 167841610:
					SpawnHeightMultiplier = (float) p_Value;
					break;

				case 2716359356:
					Camera = (CtrRef<TargetCameraData>) p_Value;
					break;

				case 1398477510:
					AimingCameraHeight = (float) p_Value;
					break;

				case 3381601297:
					StrikeCameraHeight = (float) p_Value;
					break;

				case 1509617716:
					AimingCameraOffset = (float) p_Value;
					break;

				case 441695729:
					StrikeCameraFov = (float) p_Value;
					break;

				case 2378493510:
					AimingCameraFov = (float) p_Value;
					break;

				case 619983381:
					DelayBeforeAimingCamera = (float) p_Value;
					break;

				case 3318112506:
					ValidMinDistance = (float) p_Value;
					break;

				case 3536152465:
					FireCameraTime = (float) p_Value;
					break;

				case 1691832603:
					StrikeCameraTime = (float) p_Value;
					break;

				case 1927644132:
					ValidMaxDistance = (float) p_Value;
					break;

				case 815739846:
					ValidMaxAngle = (float) p_Value;
					break;

				case 398131684:
					IncreaseSpawnHeightWithDistance = (bool) p_Value;
					break;

				case 2901124096:
					EnableProjectileTrails = (bool) p_Value;
					break;

				case 3948441033:
					EnableCameraRotation = (bool) p_Value;
					break;

				case 2258656860:
					FireProjectileFromWeapon = (bool) p_Value;
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
				case 3419412896:
					return MaxStrikeDistance;

				case 4030357871:
					return StrikeRadius;

				case 2780846849:
					return SpawnHeight;

				case 2881356526:
					return MaxRandomSpawnHeight;

				case 2966290851:
					return StrikeCameraOffset;

				case 167841610:
					return SpawnHeightMultiplier;

				case 2716359356:
					return Camera;

				case 1398477510:
					return AimingCameraHeight;

				case 3381601297:
					return StrikeCameraHeight;

				case 1509617716:
					return AimingCameraOffset;

				case 441695729:
					return StrikeCameraFov;

				case 2378493510:
					return AimingCameraFov;

				case 619983381:
					return DelayBeforeAimingCamera;

				case 3318112506:
					return ValidMinDistance;

				case 3536152465:
					return FireCameraTime;

				case 1691832603:
					return StrikeCameraTime;

				case 1927644132:
					return ValidMaxDistance;

				case 815739846:
					return ValidMaxAngle;

				case 398131684:
					return IncreaseSpawnHeightWithDistance;

				case 2901124096:
					return EnableProjectileTrails;

				case 3948441033:
					return EnableCameraRotation;

				case 2258656860:
					return FireProjectileFromWeapon;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3419412896:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(MaxStrikeDistance));

				case 4030357871:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(StrikeRadius));

				case 2780846849:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(SpawnHeight));

				case 2881356526:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(MaxRandomSpawnHeight));

				case 2966290851:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(StrikeCameraOffset));

				case 167841610:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(SpawnHeightMultiplier));

				case 2716359356:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(Camera));

				case 1398477510:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(AimingCameraHeight));

				case 3381601297:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(StrikeCameraHeight));

				case 1509617716:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(AimingCameraOffset));

				case 441695729:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(StrikeCameraFov));

				case 2378493510:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(AimingCameraFov));

				case 619983381:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(DelayBeforeAimingCamera));

				case 3318112506:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(ValidMinDistance));

				case 3536152465:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(FireCameraTime));

				case 1691832603:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(StrikeCameraTime));

				case 1927644132:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(ValidMaxDistance));

				case 815739846:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(ValidMaxAngle));

				case 398131684:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(IncreaseSpawnHeightWithDistance));

				case 2901124096:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(EnableProjectileTrails));

				case 3948441033:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(EnableCameraRotation));

				case 2258656860:
					return typeof(ArtilleryStrikeWeaponData).GetProperty(nameof(FireProjectileFromWeapon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
