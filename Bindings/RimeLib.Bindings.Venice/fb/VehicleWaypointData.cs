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
	[ContainerType(4, 44)]
	public class VehicleWaypointData : 
		WaypointData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Speed { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float SpeedOverrideMovingTowards { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Angleoffset { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float StopHereRadius { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float StoppingDeceleration { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float MinSlowdownSpeed { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool StopHere { get; set; }

		public static void Deserialize(VehicleWaypointData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Speed = p_Reader.ReadSingle();
			p_Instance.SpeedOverrideMovingTowards = p_Reader.ReadSingle();
			p_Instance.Angleoffset = p_Reader.ReadSingle();
			p_Instance.StopHereRadius = p_Reader.ReadSingle();
			p_Instance.StoppingDeceleration = p_Reader.ReadSingle();
			p_Instance.MinSlowdownSpeed = p_Reader.ReadSingle();
			p_Instance.StopHere = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
