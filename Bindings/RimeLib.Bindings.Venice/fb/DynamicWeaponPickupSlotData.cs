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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class DynamicWeaponPickupSlotData : FrostbiteContainer
	{
		[ContainerField(Name: "WeaponSlot", Offset: 0, NameHash: 933194083, Flags: 49421), LayoutImmutable, Blittable]
		public uint WeaponSlot { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "AltWeaponSlot", Offset: 4, NameHash: 2588912794, Flags: 49405), LayoutImmutable, Blittable]
		public int AltWeaponSlot { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "LinkedToWeaponSlot", Offset: 8, NameHash: 3974693081, Flags: 49405), LayoutImmutable, Blittable]
		public int LinkedToWeaponSlot { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 933194083:
					WeaponSlot = (uint) p_Value;
					break;

				case 2588912794:
					AltWeaponSlot = (int) p_Value;
					break;

				case 3974693081:
					LinkedToWeaponSlot = (int) p_Value;
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
				case 933194083:
					return WeaponSlot;

				case 2588912794:
					return AltWeaponSlot;

				case 3974693081:
					return LinkedToWeaponSlot;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 933194083:
					return typeof(DynamicWeaponPickupSlotData).GetProperty(nameof(WeaponSlot));

				case 2588912794:
					return typeof(DynamicWeaponPickupSlotData).GetProperty(nameof(AltWeaponSlot));

				case 3974693081:
					return typeof(DynamicWeaponPickupSlotData).GetProperty(nameof(LinkedToWeaponSlot));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
