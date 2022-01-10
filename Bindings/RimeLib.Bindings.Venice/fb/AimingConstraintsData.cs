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
	[ContainerType(4, 16)]
	public class AimingConstraintsData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MinYaw { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaxYaw { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MinPitch { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MaxPitch { get; set; }
		
		public static void Deserialize(AimingConstraintsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MinYaw = p_Reader.ReadSingle();
			p_Instance.MaxYaw = p_Reader.ReadSingle();
			p_Instance.MinPitch = p_Reader.ReadSingle();
			p_Instance.MaxPitch = p_Reader.ReadSingle();
		}
	}
}
