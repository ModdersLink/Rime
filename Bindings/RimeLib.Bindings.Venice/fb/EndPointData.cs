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
	[ContainerType(4, 20)]
	public class EndPointData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Pos { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float EndDamping { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float SpringLength { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float SpringAcceleration { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float SpringDamping { get; set; }
		
		public static void Deserialize(EndPointData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Pos = p_Reader.ReadSingle();
			p_Instance.EndDamping = p_Reader.ReadSingle();
			p_Instance.SpringLength = p_Reader.ReadSingle();
			p_Instance.SpringAcceleration = p_Reader.ReadSingle();
			p_Instance.SpringDamping = p_Reader.ReadSingle();
		}
	}
}
