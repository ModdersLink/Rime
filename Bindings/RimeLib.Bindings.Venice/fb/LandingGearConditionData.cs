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
	[ContainerType(4, 12)]
	public class LandingGearConditionData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Height { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Velocity { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Angle { get; set; }
		
		public static void Deserialize(LandingGearConditionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Height = p_Reader.ReadSingle();
			p_Instance.Velocity = p_Reader.ReadSingle();
			p_Instance.Angle = p_Reader.ReadSingle();
		}
	}
}
