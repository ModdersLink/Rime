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
	[ContainerType(4, 52)]
	public class PathfindingBuildSettingsAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float EntityRadius { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float EntityHeight { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float MaxWalkableSlope { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxStep { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MinIslandSurfaceArea { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float VoxSize { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float GridSideLength { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AdditionalInwardsSmoothingDist { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public uint TerrainSamplingStep { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool TesselateForPathingAccuracy { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool UseEnhancedTerrainTracking { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable]
		public bool OptimizeForAxisAligned { get; set; }

		[ContainerField(51), LayoutImmutable, Blittable]
		public bool LeaveSmallIslandsTouchingPortals { get; set; }

	}
}
