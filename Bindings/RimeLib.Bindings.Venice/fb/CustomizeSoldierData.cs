///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class CustomizeSoldierData : 
		CustomizeCharacterData
	{
		[ContainerField(32)]
		public List<UnlockWeaponAndSlot> Weapons { get; set; } = new List<UnlockWeaponAndSlot>(); // 0x20 (32)
		
		[ContainerField(36)]
		public WeaponSlot ActiveSlot { get; set; } = new WeaponSlot(); // 0x24 (36)
		
		[ContainerField(40)]
		public CtrRef<PickupEntityAsset> DeathPickup { get; set; } = new CtrRef<PickupEntityAsset>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool RemoveAllExistingWeapons { get; set; } // 0x2C (44)
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public bool DisableDeathPickup { get; set; } // 0x2D (45)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2209357972:
					Weapons = (List<UnlockWeaponAndSlot>) p_Value;
					break;

				case 824022701:
					ActiveSlot = (WeaponSlot) Enum.ToObject(typeof(WeaponSlot), p_Value);
					break;

				case 507619053:
					DeathPickup = (CtrRef<PickupEntityAsset>) p_Value;
					break;

				case 913454208:
					RemoveAllExistingWeapons = (bool) p_Value;
					break;

				case 2771455705:
					DisableDeathPickup = (bool) p_Value;
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

				case 824022701:
					return ActiveSlot;

				case 507619053:
					return DeathPickup;

				case 913454208:
					return RemoveAllExistingWeapons;

				case 2771455705:
					return DisableDeathPickup;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2209357972:
					return typeof(CustomizeSoldierData).GetProperty(nameof(Weapons));

				case 824022701:
					return typeof(CustomizeSoldierData).GetProperty(nameof(ActiveSlot));

				case 507619053:
					return typeof(CustomizeSoldierData).GetProperty(nameof(DeathPickup));

				case 913454208:
					return typeof(CustomizeSoldierData).GetProperty(nameof(RemoveAllExistingWeapons));

				case 2771455705:
					return typeof(CustomizeSoldierData).GetProperty(nameof(DisableDeathPickup));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
