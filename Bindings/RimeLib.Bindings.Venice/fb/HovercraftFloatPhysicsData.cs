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
	[ContainerType(16, 176)]
	public class HovercraftFloatPhysicsData : 
		HullFloatPhysicsData
	{
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 LandResistanceAxisMod { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 LandFrictionAxisMod { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable]
		public float FrontLength { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float SideLength { get; set; }

		public static void Deserialize(HovercraftFloatPhysicsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.LandResistanceAxisMod, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.LandFrictionAxisMod, p_Reader, p_Parser);
			p_Instance.FrontLength = p_Reader.ReadSingle();
			p_Instance.SideLength = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
