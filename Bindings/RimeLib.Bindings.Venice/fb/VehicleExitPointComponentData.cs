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
	[ContainerType(16, 128)]
	public class VehicleExitPointComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Impulse { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public float TerrainHeight { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public int Ordinal { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float Velocity { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool InheritCameraDirection { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool CheckForVehicleOverrun { get; set; }

		public static void Deserialize(VehicleExitPointComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.Impulse, p_Reader, p_Parser);
			p_Instance.TerrainHeight = p_Reader.ReadSingle();
			p_Instance.Ordinal = p_Reader.ReadInt32();
			p_Instance.Velocity = p_Reader.ReadSingle();
			p_Instance.InheritCameraDirection = p_Reader.ReadBool();
			p_Instance.CheckForVehicleOverrun = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
