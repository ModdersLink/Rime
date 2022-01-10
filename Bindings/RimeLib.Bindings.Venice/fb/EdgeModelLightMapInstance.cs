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
	[ContainerType(16, 32)]
	public class EdgeModelLightMapInstance
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 LightMapUv { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get; set; } = new();
		
		public static void Deserialize(EdgeModelLightMapInstance p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.LightMapUv, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.Position, p_Reader, p_Parser);
		}
	}
}
