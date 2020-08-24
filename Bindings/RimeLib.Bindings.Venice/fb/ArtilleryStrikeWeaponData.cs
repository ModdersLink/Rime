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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class ArtilleryStrikeWeaponData : 
		WeaponData
	{
		protected float m_MaxStrikeDistance = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3419412896)]
		public float MaxStrikeDistance { get { return m_MaxStrikeDistance; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(MaxStrikeDistance), this, m_MaxStrikeDistance, value)) m_MaxStrikeDistance = value; } } // 0x10 (16)
		
		protected float m_StrikeRadius = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4030357871)]
		public float StrikeRadius { get { return m_StrikeRadius; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(StrikeRadius), this, m_StrikeRadius, value)) m_StrikeRadius = value; } } // 0x14 (20)
		
		protected float m_SpawnHeight = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2780846849)]
		public float SpawnHeight { get { return m_SpawnHeight; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(SpawnHeight), this, m_SpawnHeight, value)) m_SpawnHeight = value; } } // 0x18 (24)
		
		protected float m_MaxRandomSpawnHeight = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2881356526)]
		public float MaxRandomSpawnHeight { get { return m_MaxRandomSpawnHeight; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(MaxRandomSpawnHeight), this, m_MaxRandomSpawnHeight, value)) m_MaxRandomSpawnHeight = value; } } // 0x1C (28)
		
		protected float m_StrikeCameraOffset = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2966290851)]
		public float StrikeCameraOffset { get { return m_StrikeCameraOffset; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(StrikeCameraOffset), this, m_StrikeCameraOffset, value)) m_StrikeCameraOffset = value; } } // 0x20 (32)
		
		protected float m_SpawnHeightMultiplier = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(167841610)]
		public float SpawnHeightMultiplier { get { return m_SpawnHeightMultiplier; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(SpawnHeightMultiplier), this, m_SpawnHeightMultiplier, value)) m_SpawnHeightMultiplier = value; } } // 0x24 (36)
		
		protected CtrRef<TargetCameraData> m_Camera = new CtrRef<TargetCameraData>();
		[ContainerField(40), MemberInfoFlag(53), ContainerFieldNameHash(2716359356), ContainerCtrRef]
		public CtrRef<TargetCameraData> Camera { get { return m_Camera; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(Camera), this, m_Camera, value)) m_Camera = value; } } // 0x28 (40)
		
		protected float m_AimingCameraHeight = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1398477510)]
		public float AimingCameraHeight { get { return m_AimingCameraHeight; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(AimingCameraHeight), this, m_AimingCameraHeight, value)) m_AimingCameraHeight = value; } } // 0x2C (44)
		
		protected float m_StrikeCameraHeight = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3381601297)]
		public float StrikeCameraHeight { get { return m_StrikeCameraHeight; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(StrikeCameraHeight), this, m_StrikeCameraHeight, value)) m_StrikeCameraHeight = value; } } // 0x30 (48)
		
		protected float m_AimingCameraOffset = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1509617716)]
		public float AimingCameraOffset { get { return m_AimingCameraOffset; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(AimingCameraOffset), this, m_AimingCameraOffset, value)) m_AimingCameraOffset = value; } } // 0x34 (52)
		
		protected float m_StrikeCameraFov = new float();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(441695729)]
		public float StrikeCameraFov { get { return m_StrikeCameraFov; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(StrikeCameraFov), this, m_StrikeCameraFov, value)) m_StrikeCameraFov = value; } } // 0x38 (56)
		
		protected float m_AimingCameraFov = new float();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2378493510)]
		public float AimingCameraFov { get { return m_AimingCameraFov; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(AimingCameraFov), this, m_AimingCameraFov, value)) m_AimingCameraFov = value; } } // 0x3C (60)
		
		protected float m_DelayBeforeAimingCamera = new float();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(619983381)]
		public float DelayBeforeAimingCamera { get { return m_DelayBeforeAimingCamera; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(DelayBeforeAimingCamera), this, m_DelayBeforeAimingCamera, value)) m_DelayBeforeAimingCamera = value; } } // 0x40 (64)
		
		protected float m_ValidMinDistance = new float();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3318112506)]
		public float ValidMinDistance { get { return m_ValidMinDistance; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(ValidMinDistance), this, m_ValidMinDistance, value)) m_ValidMinDistance = value; } } // 0x44 (68)
		
		protected float m_FireCameraTime = new float();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3536152465)]
		public float FireCameraTime { get { return m_FireCameraTime; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(FireCameraTime), this, m_FireCameraTime, value)) m_FireCameraTime = value; } } // 0x48 (72)
		
		protected float m_StrikeCameraTime = new float();
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1691832603)]
		public float StrikeCameraTime { get { return m_StrikeCameraTime; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(StrikeCameraTime), this, m_StrikeCameraTime, value)) m_StrikeCameraTime = value; } } // 0x4C (76)
		
		protected float m_ValidMaxDistance = new float();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1927644132)]
		public float ValidMaxDistance { get { return m_ValidMaxDistance; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(ValidMaxDistance), this, m_ValidMaxDistance, value)) m_ValidMaxDistance = value; } } // 0x50 (80)
		
		protected float m_ValidMaxAngle = new float();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(815739846)]
		public float ValidMaxAngle { get { return m_ValidMaxAngle; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(ValidMaxAngle), this, m_ValidMaxAngle, value)) m_ValidMaxAngle = value; } } // 0x54 (84)
		
		protected bool m_IncreaseSpawnHeightWithDistance = new bool();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(398131684)]
		public bool IncreaseSpawnHeightWithDistance { get { return m_IncreaseSpawnHeightWithDistance; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(IncreaseSpawnHeightWithDistance), this, m_IncreaseSpawnHeightWithDistance, value)) m_IncreaseSpawnHeightWithDistance = value; } } // 0x58 (88)
		
		protected bool m_EnableProjectileTrails = new bool();
		[ContainerField(89), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2901124096)]
		public bool EnableProjectileTrails { get { return m_EnableProjectileTrails; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(EnableProjectileTrails), this, m_EnableProjectileTrails, value)) m_EnableProjectileTrails = value; } } // 0x59 (89)
		
		protected bool m_EnableCameraRotation = new bool();
		[ContainerField(90), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3948441033)]
		public bool EnableCameraRotation { get { return m_EnableCameraRotation; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(EnableCameraRotation), this, m_EnableCameraRotation, value)) m_EnableCameraRotation = value; } } // 0x5A (90)
		
		protected bool m_FireProjectileFromWeapon = new bool();
		[ContainerField(91), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2258656860)]
		public bool FireProjectileFromWeapon { get { return m_FireProjectileFromWeapon; } set { if (OnPropertyChanging("ArtilleryStrikeWeaponData." + nameof(FireProjectileFromWeapon), this, m_FireProjectileFromWeapon, value)) m_FireProjectileFromWeapon = value; } } // 0x5B (91)
		
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
