///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class MedicBagHealingSphereWeaponData : 
		WeaponData
	{
		[ContainerField(16)]
		public HealingSphereData Healer { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float HealthPointsRefillSpeed { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float HealthPointsPerBag { get; set; }

		public static void Deserialize(MedicBagHealingSphereWeaponData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.HealingSphereData.Deserialize(p_Instance.Healer, p_Reader, p_Parser);
			p_Instance.HealthPointsRefillSpeed = p_Reader.ReadSingle();
			p_Instance.HealthPointsPerBag = p_Reader.ReadSingle();
		}

	}
}
