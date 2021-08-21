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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 52)]
	public class SoldierWeaponUnlockAsset : 
		UnlockAssetBase
	{
		protected CtrRef<SoldierWeaponBlueprint> m_Weapon = new CtrRef<SoldierWeaponBlueprint>();
		[ContainerField(Name: "Weapon", Offset: 40, NameHash: 3190562823, Flags: 53)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get { return m_Weapon; } set { if (OnPropertyChanging("SoldierWeaponUnlockAsset." + nameof(Weapon), this, m_Weapon, value)) m_Weapon = value; } } // 0x28 (40)
		
		protected CtrRef<UnlockAssetBase> m_Extra = new CtrRef<UnlockAssetBase>();
		[ContainerField(Name: "Extra", Offset: 44, NameHash: 201622975, Flags: 53)]
		public CtrRef<UnlockAssetBase> Extra { get { return m_Extra; } set { if (OnPropertyChanging("SoldierWeaponUnlockAsset." + nameof(Extra), this, m_Extra, value)) m_Extra = value; } } // 0x2C (44)
		
		protected uint m_WeaponIdentifier = new uint();
		[ContainerField(Name: "WeaponIdentifier", Offset: 48, NameHash: 222597316, Flags: 49421), LayoutImmutable, Blittable]
		public uint WeaponIdentifier { get { return m_WeaponIdentifier; } set { if (OnPropertyChanging("SoldierWeaponUnlockAsset." + nameof(WeaponIdentifier), this, m_WeaponIdentifier, value)) m_WeaponIdentifier = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3190562823:
					Weapon = (CtrRef<SoldierWeaponBlueprint>) p_Value;
					break;

				case 201622975:
					Extra = (CtrRef<UnlockAssetBase>) p_Value;
					break;

				case 222597316:
					WeaponIdentifier = (uint) p_Value;
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
				case 3190562823:
					return Weapon;

				case 201622975:
					return Extra;

				case 222597316:
					return WeaponIdentifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3190562823:
					return typeof(SoldierWeaponUnlockAsset).GetProperty(nameof(Weapon));

				case 201622975:
					return typeof(SoldierWeaponUnlockAsset).GetProperty(nameof(Extra));

				case 222597316:
					return typeof(SoldierWeaponUnlockAsset).GetProperty(nameof(WeaponIdentifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
