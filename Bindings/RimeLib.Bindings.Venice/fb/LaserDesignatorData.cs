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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 48)]
	public class LaserDesignatorData : 
		LockingWeaponData
	{
		protected float m_PostLockTime = new float();
		[ContainerField(Name: "PostLockTime", Offset: 32, NameHash: 4004851651, Flags: 49469), LayoutImmutable, Blittable]
		public float PostLockTime { get { return m_PostLockTime; } set { if (OnPropertyChanging("LaserDesignatorData." + nameof(PostLockTime), this, m_PostLockTime, value)) m_PostLockTime = value; } } // 0x20 (32)
		
		protected float m_BomberTime = new float();
		[ContainerField(Name: "BomberTime", Offset: 36, NameHash: 3089415333, Flags: 49469), LayoutImmutable, Blittable]
		public float BomberTime { get { return m_BomberTime; } set { if (OnPropertyChanging("LaserDesignatorData." + nameof(BomberTime), this, m_BomberTime, value)) m_BomberTime = value; } } // 0x24 (36)
		
		protected float m_BombWarnTime = new float();
		[ContainerField(Name: "BombWarnTime", Offset: 40, NameHash: 2755941208, Flags: 49469), LayoutImmutable, Blittable]
		public float BombWarnTime { get { return m_BombWarnTime; } set { if (OnPropertyChanging("LaserDesignatorData." + nameof(BombWarnTime), this, m_BombWarnTime, value)) m_BombWarnTime = value; } } // 0x28 (40)
		
		protected CtrRef<SoundAsset> m_BomberSound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "BomberSound", Offset: 44, NameHash: 3167598099, Flags: 53)]
		public CtrRef<SoundAsset> BomberSound { get { return m_BomberSound; } set { if (OnPropertyChanging("LaserDesignatorData." + nameof(BomberSound), this, m_BomberSound, value)) m_BomberSound = value; } } // 0x2C (44)
		
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
