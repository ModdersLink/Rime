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
	[ContainerType(16, 192)]
	public class LensScopeComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ChromaticAberrationColor1 { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 RadialBlendDistanceCoefficients { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ChromaticAberrationColor2 { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 BlurCenter { get; set; } = new();

		[ContainerField(152), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationDisplacement2 { get; set; } = new();

		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationDisplacement1 { get; set; } = new();

		[ContainerField(168), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationStrengths { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public float BlurScale { get; set; }

		[ContainerField(180)]
		public Realm Realm { get; set; } = new();

		[ContainerField(184), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

	}
}
