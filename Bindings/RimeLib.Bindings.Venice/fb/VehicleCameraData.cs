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
	[ContainerType(16, 256)]
	public class VehicleCameraData : 
		TargetCameraData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MoveToPosition { get; set; } = new();

		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MoveToPositionSlopeFactor { get; set; } = new();

		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TargetOffset { get; set; } = new();

		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TargetOffsetSlopeFactor { get; set; } = new();

		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 RotationFactor { get; set; } = new();

		[ContainerField(240), LayoutImmutable, Blittable]
		public float PositionFactor { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public float ResetDistance { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable]
		public bool FixedPosition { get; set; }

		[ContainerField(249), LayoutImmutable, Blittable]
		public bool FixedAngleZ { get; set; }

		[ContainerField(250), LayoutImmutable, Blittable]
		public bool UseTerrainAdjustment { get; set; }

	}
}
