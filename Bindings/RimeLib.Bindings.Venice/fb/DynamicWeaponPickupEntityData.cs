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
	public class DynamicWeaponPickupEntityData : 
		PickupEntityData
	{
		protected List<DynamicWeaponPickupSlotData> m_WeaponSlots = new List<DynamicWeaponPickupSlotData>();
		[ContainerField(Name: "WeaponSlots", Offset: 176, NameHash: 730633648, Flags: 65)]
		public List<DynamicWeaponPickupSlotData> WeaponSlots { get { return m_WeaponSlots; } set { if (OnPropertyChanging("DynamicWeaponPickupEntityData." + nameof(WeaponSlots), this, m_WeaponSlots, value)) m_WeaponSlots = value; } } // 0xB0 (176)
		
		protected bool m_KeepAmmoState = new bool();
		[ContainerField(Name: "KeepAmmoState", Offset: 180, NameHash: 2997013959, Flags: 49325), LayoutImmutable, Blittable]
		public bool KeepAmmoState { get { return m_KeepAmmoState; } set { if (OnPropertyChanging("DynamicWeaponPickupEntityData." + nameof(KeepAmmoState), this, m_KeepAmmoState, value)) m_KeepAmmoState = value; } } // 0xB4 (180)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 730633648:
					WeaponSlots = (List<DynamicWeaponPickupSlotData>) p_Value;
					break;

				case 2997013959:
					KeepAmmoState = (bool) p_Value;
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
				case 730633648:
					return WeaponSlots;

				case 2997013959:
					return KeepAmmoState;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 730633648:
					return typeof(DynamicWeaponPickupEntityData).GetProperty(nameof(WeaponSlots));

				case 2997013959:
					return typeof(DynamicWeaponPickupEntityData).GetProperty(nameof(KeepAmmoState));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
