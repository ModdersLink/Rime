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
	[ContainerType(16, 160)]
	public class DynamicEnvmapComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 KeyColorEnvmap { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 GroundColorEnvmap { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyColorEnvmap { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

	}
}
