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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 24)]
	public class WeaponPickupData : FrostbiteContainer
	{
		[ContainerField(Name: "Weapon", Offset: 0, NameHash: 3190562823, Flags: 53)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get; set; } = new CtrRef<SoldierWeaponBlueprint>(); // 0x0 (0)
		
		[ContainerField(Name: "WeaponSlot", Offset: 4, NameHash: 933194083, Flags: 49421), LayoutImmutable, Blittable]
		public uint WeaponSlot { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "AltWeaponSlot", Offset: 8, NameHash: 2588912794, Flags: 49405), LayoutImmutable, Blittable]
		public int AltWeaponSlot { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "LinkedToWeaponSlot", Offset: 12, NameHash: 3974693081, Flags: 49405), LayoutImmutable, Blittable]
		public int LinkedToWeaponSlot { get; set; } // 0xC (12)
		
		[ContainerField(Name: "MinAmmo", Offset: 16, NameHash: 1012759905, Flags: 49421), LayoutImmutable, Blittable]
		public uint MinAmmo { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "MaxAmmo", Offset: 20, NameHash: 1314148735, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxAmmo { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3190562823:
					Weapon = (CtrRef<SoldierWeaponBlueprint>) p_Value;
					break;

				case 933194083:
					WeaponSlot = (uint) p_Value;
					break;

				case 2588912794:
					AltWeaponSlot = (int) p_Value;
					break;

				case 3974693081:
					LinkedToWeaponSlot = (int) p_Value;
					break;

				case 1012759905:
					MinAmmo = (uint) p_Value;
					break;

				case 1314148735:
					MaxAmmo = (uint) p_Value;
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

				case 933194083:
					return WeaponSlot;

				case 2588912794:
					return AltWeaponSlot;

				case 3974693081:
					return LinkedToWeaponSlot;

				case 1012759905:
					return MinAmmo;

				case 1314148735:
					return MaxAmmo;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3190562823:
					return typeof(WeaponPickupData).GetProperty(nameof(Weapon));

				case 933194083:
					return typeof(WeaponPickupData).GetProperty(nameof(WeaponSlot));

				case 2588912794:
					return typeof(WeaponPickupData).GetProperty(nameof(AltWeaponSlot));

				case 3974693081:
					return typeof(WeaponPickupData).GetProperty(nameof(LinkedToWeaponSlot));

				case 1012759905:
					return typeof(WeaponPickupData).GetProperty(nameof(MinAmmo));

				case 1314148735:
					return typeof(WeaponPickupData).GetProperty(nameof(MaxAmmo));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
