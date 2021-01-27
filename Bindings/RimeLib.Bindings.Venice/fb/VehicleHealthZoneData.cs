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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class VehicleHealthZoneData : FrostbiteContainer
	{
		[ContainerField(Name: "MaxHealth", Offset: 0, NameHash: 1153188365, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxHealth { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "MaxShieldHealth", Offset: 4, NameHash: 170435442, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxShieldHealth { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "DamageAngleMultiplier", Offset: 8, NameHash: 1111808420, Flags: 49469), LayoutImmutable, Blittable]
		public float DamageAngleMultiplier { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "MinDamageAngle", Offset: 12, NameHash: 922661029, Flags: 49469), LayoutImmutable, Blittable]
		public float MinDamageAngle { get; set; } // 0xC (12)
		
		[ContainerField(Name: "UseDamageAngleCalculation", Offset: 16, NameHash: 983192421, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseDamageAngleCalculation { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1153188365:
					MaxHealth = (float) p_Value;
					break;

				case 170435442:
					MaxShieldHealth = (float) p_Value;
					break;

				case 1111808420:
					DamageAngleMultiplier = (float) p_Value;
					break;

				case 922661029:
					MinDamageAngle = (float) p_Value;
					break;

				case 983192421:
					UseDamageAngleCalculation = (bool) p_Value;
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
				case 1153188365:
					return MaxHealth;

				case 170435442:
					return MaxShieldHealth;

				case 1111808420:
					return DamageAngleMultiplier;

				case 922661029:
					return MinDamageAngle;

				case 983192421:
					return UseDamageAngleCalculation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1153188365:
					return typeof(VehicleHealthZoneData).GetProperty(nameof(MaxHealth));

				case 170435442:
					return typeof(VehicleHealthZoneData).GetProperty(nameof(MaxShieldHealth));

				case 1111808420:
					return typeof(VehicleHealthZoneData).GetProperty(nameof(DamageAngleMultiplier));

				case 922661029:
					return typeof(VehicleHealthZoneData).GetProperty(nameof(MinDamageAngle));

				case 983192421:
					return typeof(VehicleHealthZoneData).GetProperty(nameof(UseDamageAngleCalculation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
