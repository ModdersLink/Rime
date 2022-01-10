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
	[ContainerType(16, 64)]
	public class LinearTransform
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 right { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 up { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 forward { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 trans { get; set; } = new();
		
		public static void Deserialize(LinearTransform p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.right, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.up, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.forward, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.trans, p_Reader, p_Parser);
		}
	}
}
