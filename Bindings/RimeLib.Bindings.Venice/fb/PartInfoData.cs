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
	[ContainerType(16, 48)]
	public class PartInfoData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox Aabb { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Translation { get; set; } = new();
		
		public static void Deserialize(PartInfoData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AxisAlignedBox.Deserialize(p_Instance.Aabb, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.Translation, p_Reader, p_Parser);
		}
	}
}
