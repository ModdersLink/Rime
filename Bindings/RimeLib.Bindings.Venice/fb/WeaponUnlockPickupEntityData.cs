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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 192)]
	public class WeaponUnlockPickupEntityData : 
		PickupEntityData
	{
		protected List<WeaponUnlockPickupData> m_Weapons = new List<WeaponUnlockPickupData>();
		[ContainerField(Name: "Weapons", Offset: 176, NameHash: 2209357972, Flags: 65)]
		public List<WeaponUnlockPickupData> Weapons { get { return m_Weapons; } set { if (OnPropertyChanging("WeaponUnlockPickupEntityData." + nameof(Weapons), this, m_Weapons, value)) m_Weapons = value; } } // 0xB0 (176)
		
		protected bool m_UseForPersistence = new bool();
		[ContainerField(Name: "UseForPersistence", Offset: 180, NameHash: 2840570666, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseForPersistence { get { return m_UseForPersistence; } set { if (OnPropertyChanging("WeaponUnlockPickupEntityData." + nameof(UseForPersistence), this, m_UseForPersistence, value)) m_UseForPersistence = value; } } // 0xB4 (180)
		
		protected bool m_RandomlySelectOneWeapon = new bool();
		[ContainerField(Name: "RandomlySelectOneWeapon", Offset: 181, NameHash: 979545285, Flags: 49325), LayoutImmutable, Blittable]
		public bool RandomlySelectOneWeapon { get { return m_RandomlySelectOneWeapon; } set { if (OnPropertyChanging("WeaponUnlockPickupEntityData." + nameof(RandomlySelectOneWeapon), this, m_RandomlySelectOneWeapon, value)) m_RandomlySelectOneWeapon = value; } } // 0xB5 (181)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2209357972:
					Weapons = (List<WeaponUnlockPickupData>) p_Value;
					break;

				case 2840570666:
					UseForPersistence = (bool) p_Value;
					break;

				case 979545285:
					RandomlySelectOneWeapon = (bool) p_Value;
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
				case 2209357972:
					return Weapons;

				case 2840570666:
					return UseForPersistence;

				case 979545285:
					return RandomlySelectOneWeapon;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2209357972:
					return typeof(WeaponUnlockPickupEntityData).GetProperty(nameof(Weapons));

				case 2840570666:
					return typeof(WeaponUnlockPickupEntityData).GetProperty(nameof(UseForPersistence));

				case 979545285:
					return typeof(WeaponUnlockPickupEntityData).GetProperty(nameof(RandomlySelectOneWeapon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
