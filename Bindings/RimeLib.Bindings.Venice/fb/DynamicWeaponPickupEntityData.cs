///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class DynamicWeaponPickupEntityData : 
		PickupEntityData
	{
		[ContainerField(176)]
		public List<DynamicWeaponPickupSlotData> WeaponSlots { get; set; } = new List<DynamicWeaponPickupSlotData>(); // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public bool KeepAmmoState { get; set; } // 0xB4 (180)
		
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
