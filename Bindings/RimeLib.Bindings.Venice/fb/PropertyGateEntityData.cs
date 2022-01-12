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
	[ContainerType(16, 128)]
	public class PropertyGateEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform TransformIn { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Vec4In { get; set; } = new();

		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Vec3In { get; set; } = new();

		[ContainerField(112)]
		public Realm Realm { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public float FloatIn { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public int IntIn { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool BoolIn { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool Default { get; set; }

	}
}
