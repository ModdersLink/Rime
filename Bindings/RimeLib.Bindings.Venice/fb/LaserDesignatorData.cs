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
	public class LaserDesignatorData : 
		LockingWeaponData
	{
		[ContainerField(32), LayoutImmutable, Blittable]
		public float PostLockTime { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float BomberTime { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float BombWarnTime { get; set; } // 0x28 (40)
		
		[ContainerField(44)]
		public CtrRef<SoundAsset> BomberSound { get; set; } = new CtrRef<SoundAsset>(); // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4004851651:
					PostLockTime = (float) p_Value;
					break;

				case 3089415333:
					BomberTime = (float) p_Value;
					break;

				case 2755941208:
					BombWarnTime = (float) p_Value;
					break;

				case 3167598099:
					BomberSound = (CtrRef<SoundAsset>) p_Value;
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
				case 4004851651:
					return PostLockTime;

				case 3089415333:
					return BomberTime;

				case 2755941208:
					return BombWarnTime;

				case 3167598099:
					return BomberSound;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4004851651:
					return typeof(LaserDesignatorData).GetProperty(nameof(PostLockTime));

				case 3089415333:
					return typeof(LaserDesignatorData).GetProperty(nameof(BomberTime));

				case 2755941208:
					return typeof(LaserDesignatorData).GetProperty(nameof(BombWarnTime));

				case 3167598099:
					return typeof(LaserDesignatorData).GetProperty(nameof(BomberSound));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
