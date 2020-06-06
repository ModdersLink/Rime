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
	public class MedicBagWeaponData : 
		WeaponData
	{
		[ContainerField(16)]
		public HealerData Healer { get; set; } = new HealerData(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float HealthPointsRefillSpeed { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float HealthPointsPerBag { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3054336626:
					Healer = (HealerData) p_Value;
					break;

				case 677121433:
					HealthPointsRefillSpeed = (float) p_Value;
					break;

				case 134333413:
					HealthPointsPerBag = (float) p_Value;
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
				case 3054336626:
					return Healer;

				case 677121433:
					return HealthPointsRefillSpeed;

				case 134333413:
					return HealthPointsPerBag;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3054336626:
					return typeof(MedicBagWeaponData).GetProperty(nameof(Healer));

				case 677121433:
					return typeof(MedicBagWeaponData).GetProperty(nameof(HealthPointsRefillSpeed));

				case 134333413:
					return typeof(MedicBagWeaponData).GetProperty(nameof(HealthPointsPerBag));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
