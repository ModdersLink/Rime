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
	public class DynamicWeaponPickupSlotData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public uint WeaponSlot { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int AltWeaponSlot { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
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
