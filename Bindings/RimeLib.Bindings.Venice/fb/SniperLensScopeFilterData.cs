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
	public class SniperLensScopeFilterData : 
		ScopeFilterData
	{
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationStrengths { get; set; } = new();

		[ContainerField(20), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 BlurCenter { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ChromaticAberrationColor1 { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ChromaticAberrationColor2 { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 RadialBlendDistanceCoefficients { get; set; } = new();

		[ContainerField(72), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationDisplacement1 { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationDisplacement2 { get; set; } = new();

		[ContainerField(88), LayoutImmutable, Blittable]
		public float BlurScale { get; set; }

		[ContainerField(96)]
		public ColorTintData ColorTintData { get; set; } = new();

	}
}
