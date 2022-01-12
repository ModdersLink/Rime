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
	[ContainerType(16, 144)]
	public class VignetteComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Scale { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Color { get; set; } = new();

		[ContainerField(128)]
		public Realm Realm { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable]
		public float Exponent { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float Opacity { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

	}
}
