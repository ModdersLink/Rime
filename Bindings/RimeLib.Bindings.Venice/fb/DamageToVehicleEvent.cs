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
	[ContainerType(8)]
	public class DamageToVehicleEvent : 
		MetricEvent
	{
		protected string m_VehicleName = new string();
		[ContainerField(16), LayoutImmutable, ContainerFieldNameHash(926391226)]
		public string VehicleName { get { return m_VehicleName; } set { if (OnPropertyChanging("DamageToVehicleEvent." + nameof(VehicleName), this, m_VehicleName, value)) m_VehicleName = value; } } // 0x10 (16)
		
		protected string m_WeaponName = new string();
		[ContainerField(20), LayoutImmutable, ContainerFieldNameHash(932725504)]
		public string WeaponName { get { return m_WeaponName; } set { if (OnPropertyChanging("DamageToVehicleEvent." + nameof(WeaponName), this, m_WeaponName, value)) m_WeaponName = value; } } // 0x14 (20)
		
		protected float m_DamageAmount = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(4282691970)]
		public float DamageAmount { get { return m_DamageAmount; } set { if (OnPropertyChanging("DamageToVehicleEvent." + nameof(DamageAmount), this, m_DamageAmount, value)) m_DamageAmount = value; } } // 0x18 (24)
		
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
