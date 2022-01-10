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
	public class SpeedModifierData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float ForwardConstant { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float BackwardConstant { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float LeftConstant { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float RightConstant { get; set; }
		
		public static void Deserialize(SpeedModifierData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ForwardConstant = p_Reader.ReadSingle();
			p_Instance.BackwardConstant = p_Reader.ReadSingle();
			p_Instance.LeftConstant = p_Reader.ReadSingle();
			p_Instance.RightConstant = p_Reader.ReadSingle();
		}
	}
}
