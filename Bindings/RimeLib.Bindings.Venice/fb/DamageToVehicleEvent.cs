///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(8)]
	public class DamageToVehicleEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable]
		public string VehicleName { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string WeaponName { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float DamageAmount { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 926391226:
					VehicleName = (string) p_Value;
					break;

				case 932725504:
					WeaponName = (string) p_Value;
					break;

				case 4282691970:
					DamageAmount = (float) p_Value;
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
				case 926391226:
					return VehicleName;

				case 932725504:
					return WeaponName;

				case 4282691970:
					return DamageAmount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 926391226:
					return typeof(DamageToVehicleEvent).GetProperty(nameof(VehicleName));

				case 932725504:
					return typeof(DamageToVehicleEvent).GetProperty(nameof(WeaponName));

				case 4282691970:
					return typeof(DamageToVehicleEvent).GetProperty(nameof(DamageAmount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
