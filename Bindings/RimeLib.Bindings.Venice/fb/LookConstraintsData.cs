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
	public class LookConstraintsData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MinLookYaw { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaxLookYaw { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MinLookPitch { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MaxLookPitch { get; set; }
		
		public static void Deserialize(LookConstraintsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MinLookYaw = p_Reader.ReadSingle();
			p_Instance.MaxLookYaw = p_Reader.ReadSingle();
			p_Instance.MinLookPitch = p_Reader.ReadSingle();
			p_Instance.MaxLookPitch = p_Reader.ReadSingle();
		}
	}
}
