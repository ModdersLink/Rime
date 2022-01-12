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
	public class HullFloatPhysicsData : 
		FloatPhysicsData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WaterResistanceAxisMod { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WaterFrictionAxisMod { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable]
		public int SubSurfaceSplits { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float Depth { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float Width { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float Length { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float FrontCurveDegree { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float SideCurveDegree { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float NonEngineSteer { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float NonEngineSteerMinSpeed { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float NonEngineSteerMaxSpeed { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float WaterDampeningMod { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float LiftModifier { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float SupportSizeMod { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float AngularDampening { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float FrictionThrottleModifier { get; set; }

	}
}
