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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 48)]
	public class CustomizeSoldierData : 
		CustomizeCharacterData
	{
		protected List<UnlockWeaponAndSlot> m_Weapons = new List<UnlockWeaponAndSlot>();
		[ContainerField(Name: "Weapons", Offset: 32, NameHash: 2209357972, Flags: 65)]
		public List<UnlockWeaponAndSlot> Weapons { get { return m_Weapons; } set { if (OnPropertyChanging("CustomizeSoldierData." + nameof(Weapons), this, m_Weapons, value)) m_Weapons = value; } } // 0x20 (32)
		
		protected WeaponSlot m_ActiveSlot = new WeaponSlot();
		[ContainerField(Name: "ActiveSlot", Offset: 36, NameHash: 824022701, Flags: 137)]
		public WeaponSlot ActiveSlot { get { return m_ActiveSlot; } set { if (OnPropertyChanging("CustomizeSoldierData." + nameof(ActiveSlot), this, m_ActiveSlot, value)) m_ActiveSlot = value; } } // 0x24 (36)
		
		protected CtrRef<PickupEntityAsset> m_DeathPickup = new CtrRef<PickupEntityAsset>();
		[ContainerField(Name: "DeathPickup", Offset: 40, NameHash: 507619053, Flags: 53)]
		public CtrRef<PickupEntityAsset> DeathPickup { get { return m_DeathPickup; } set { if (OnPropertyChanging("CustomizeSoldierData." + nameof(DeathPickup), this, m_DeathPickup, value)) m_DeathPickup = value; } } // 0x28 (40)
		
		protected bool m_RemoveAllExistingWeapons = new bool();
		[ContainerField(Name: "RemoveAllExistingWeapons", Offset: 44, NameHash: 913454208, Flags: 49325), LayoutImmutable, Blittable]
		public bool RemoveAllExistingWeapons { get { return m_RemoveAllExistingWeapons; } set { if (OnPropertyChanging("CustomizeSoldierData." + nameof(RemoveAllExistingWeapons), this, m_RemoveAllExistingWeapons, value)) m_RemoveAllExistingWeapons = value; } } // 0x2C (44)
		
		protected bool m_DisableDeathPickup = new bool();
		[ContainerField(Name: "DisableDeathPickup", Offset: 45, NameHash: 2771455705, Flags: 49325), LayoutImmutable, Blittable]
		public bool DisableDeathPickup { get { return m_DisableDeathPickup; } set { if (OnPropertyChanging("CustomizeSoldierData." + nameof(DisableDeathPickup), this, m_DisableDeathPickup, value)) m_DisableDeathPickup = value; } } // 0x2D (45)
		
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
