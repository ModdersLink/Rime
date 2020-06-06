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
	public class WeaponPickupEntityData : 
		PickupEntityData
	{
		[ContainerField(176)]
		public List<WeaponPickupData> Weapons { get; set; } = new List<WeaponPickupData>(); // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public bool UseForPersistence { get; set; } // 0xB4 (180)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2209357972:
					Weapons = (List<WeaponPickupData>) p_Value;
					break;

				case 2840570666:
					UseForPersistence = (bool) p_Value;
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

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2209357972:
					return typeof(WeaponPickupEntityData).GetProperty(nameof(Weapons));

				case 2840570666:
					return typeof(WeaponPickupEntityData).GetProperty(nameof(UseForPersistence));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
