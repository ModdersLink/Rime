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
	[ContainerType(16, 16)]
	public class Vec4
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float x { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float y { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float z { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float w { get; set; }
		
		public static void Deserialize(Vec4 p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.x = p_Reader.ReadSingle();
			p_Instance.y = p_Reader.ReadSingle();
			p_Instance.z = p_Reader.ReadSingle();
			p_Instance.w = p_Reader.ReadSingle();
		}
	}
}
