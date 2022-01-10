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
	[ContainerType(8, 32)]
	public class DamageToVehicleEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable]
		public string VehicleName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string WeaponName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable]
		public float DamageAmount { get; set; }

		public static void Deserialize(DamageToVehicleEvent p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.VehicleName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.WeaponName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.DamageAmount = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
