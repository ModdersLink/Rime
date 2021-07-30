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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 48)]
	public class BulletHitInfo : FrostbiteContainer
	{
		[ContainerField(Name: "Direction", Offset: 0, NameHash: 2698949952, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Direction { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "SpawnPosition", Offset: 16, NameHash: 4274978279, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SpawnPosition { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(Name: "WeaponUnlockAsset", Offset: 32, NameHash: 1477356935, Flags: 53)]
		public CtrRef<SoldierWeaponUnlockAsset> WeaponUnlockAsset { get; set; } = new CtrRef<SoldierWeaponUnlockAsset>(); // 0x20 (32)
		
		[ContainerField(Name: "WeaponType", Offset: 36, NameHash: 933216383, Flags: 137)]
		public AntHitReactionWeaponType WeaponType { get; set; } = new AntHitReactionWeaponType(); // 0x24 (36)
		
		[ContainerField(Name: "BoneType", Offset: 40, NameHash: 1590859931, Flags: 49405), LayoutImmutable, Blittable]
		public int BoneType { get; set; } // 0x28 (40)
		
		[ContainerField(Name: "ShooterPlayerId", Offset: 44, NameHash: 359819395, Flags: 49405), LayoutImmutable, Blittable]
		public int ShooterPlayerId { get; set; } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2698949952:
					Direction = (Vec3) p_Value;
					break;

				case 4274978279:
					SpawnPosition = (Vec3) p_Value;
					break;

				case 1477356935:
					WeaponUnlockAsset = (CtrRef<SoldierWeaponUnlockAsset>) p_Value;
					break;

				case 933216383:
						WeaponType = (AntHitReactionWeaponType) Enum.ToObject(typeof(AntHitReactionWeaponType), p_Value);
					break;

				case 1590859931:
					BoneType = (int) p_Value;
					break;

				case 359819395:
					ShooterPlayerId = (int) p_Value;
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
				case 2698949952:
					return Direction;

				case 4274978279:
					return SpawnPosition;

				case 1477356935:
					return WeaponUnlockAsset;

				case 933216383:
					return WeaponType;

				case 1590859931:
					return BoneType;

				case 359819395:
					return ShooterPlayerId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2698949952:
					return typeof(BulletHitInfo).GetProperty(nameof(Direction));

				case 4274978279:
					return typeof(BulletHitInfo).GetProperty(nameof(SpawnPosition));

				case 1477356935:
					return typeof(BulletHitInfo).GetProperty(nameof(WeaponUnlockAsset));

				case 933216383:
					return typeof(BulletHitInfo).GetProperty(nameof(WeaponType));

				case 1590859931:
					return typeof(BulletHitInfo).GetProperty(nameof(BoneType));

				case 359819395:
					return typeof(BulletHitInfo).GetProperty(nameof(ShooterPlayerId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
