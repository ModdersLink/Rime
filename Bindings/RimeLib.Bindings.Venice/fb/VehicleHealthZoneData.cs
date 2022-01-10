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
	[ContainerType(4, 20)]
	public class VehicleHealthZoneData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MaxHealth { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaxShieldHealth { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float DamageAngleMultiplier { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MinDamageAngle { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool UseDamageAngleCalculation { get; set; }
		
		public static void Deserialize(VehicleHealthZoneData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxHealth = p_Reader.ReadSingle();
			p_Instance.MaxShieldHealth = p_Reader.ReadSingle();
			p_Instance.DamageAngleMultiplier = p_Reader.ReadSingle();
			p_Instance.MinDamageAngle = p_Reader.ReadSingle();
			p_Instance.UseDamageAngleCalculation = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
