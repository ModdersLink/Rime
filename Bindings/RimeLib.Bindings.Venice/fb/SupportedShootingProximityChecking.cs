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
	public class SupportedShootingProximityChecking
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float RayAboveGunHeightOffset { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float RayAboveLength { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float RayBelowGunHeightOffset { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float RayBelowLength { get; set; }
		
		public static void Deserialize(SupportedShootingProximityChecking p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RayAboveGunHeightOffset = p_Reader.ReadSingle();
			p_Instance.RayAboveLength = p_Reader.ReadSingle();
			p_Instance.RayBelowGunHeightOffset = p_Reader.ReadSingle();
			p_Instance.RayBelowLength = p_Reader.ReadSingle();
		}
	}
}
