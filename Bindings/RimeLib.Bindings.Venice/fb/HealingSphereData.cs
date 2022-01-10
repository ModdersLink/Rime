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
	[ContainerType(4, 8)]
	public class HealingSphereData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Radius { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float HealthIncSpeed { get; set; }
		
		public static void Deserialize(HealingSphereData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Radius = p_Reader.ReadSingle();
			p_Instance.HealthIncSpeed = p_Reader.ReadSingle();
		}
	}
}
