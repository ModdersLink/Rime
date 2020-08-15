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
	[ContainerType(4)]
	public class MedicBagHealingSphereWeaponData : 
		WeaponData
	{
		protected HealingSphereData m_Healer = new HealingSphereData();
		[ContainerField(16), ContainerFieldNameHash(3054336626)]
		public HealingSphereData Healer { get { return m_Healer; } set { if (OnPropertyChanging("MedicBagHealingSphereWeaponData." + nameof(Healer), this, m_Healer, value)) m_Healer = value; } } // 0x10 (16)
		
		protected float m_HealthPointsRefillSpeed = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(677121433)]
		public float HealthPointsRefillSpeed { get { return m_HealthPointsRefillSpeed; } set { if (OnPropertyChanging("MedicBagHealingSphereWeaponData." + nameof(HealthPointsRefillSpeed), this, m_HealthPointsRefillSpeed, value)) m_HealthPointsRefillSpeed = value; } } // 0x18 (24)
		
		protected float m_HealthPointsPerBag = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(134333413)]
		public float HealthPointsPerBag { get { return m_HealthPointsPerBag; } set { if (OnPropertyChanging("MedicBagHealingSphereWeaponData." + nameof(HealthPointsPerBag), this, m_HealthPointsPerBag, value)) m_HealthPointsPerBag = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3054336626:
					Healer = (HealingSphereData) p_Value;
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
					return typeof(MedicBagHealingSphereWeaponData).GetProperty(nameof(Healer));

				case 677121433:
					return typeof(MedicBagHealingSphereWeaponData).GetProperty(nameof(HealthPointsRefillSpeed));

				case 134333413:
					return typeof(MedicBagHealingSphereWeaponData).GetProperty(nameof(HealthPointsPerBag));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
