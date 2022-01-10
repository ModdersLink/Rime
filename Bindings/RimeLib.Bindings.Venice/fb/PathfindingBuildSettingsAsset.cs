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

		public static void Deserialize(PathfindingBuildSettingsAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.EntityRadius = p_Reader.ReadSingle();
			p_Instance.EntityHeight = p_Reader.ReadSingle();
			p_Instance.MaxWalkableSlope = p_Reader.ReadSingle();
			p_Instance.MaxStep = p_Reader.ReadSingle();
			p_Instance.MinIslandSurfaceArea = p_Reader.ReadSingle();
			p_Instance.VoxSize = p_Reader.ReadSingle();
			p_Instance.GridSideLength = p_Reader.ReadSingle();
			p_Instance.AdditionalInwardsSmoothingDist = p_Reader.ReadSingle();
			p_Instance.TerrainSamplingStep = p_Reader.ReadUInt32();
			p_Instance.TesselateForPathingAccuracy = p_Reader.ReadBool();
			p_Instance.UseEnhancedTerrainTracking = p_Reader.ReadBool();
			p_Instance.OptimizeForAxisAligned = p_Reader.ReadBool();
			p_Instance.LeaveSmallIslandsTouchingPortals = p_Reader.ReadBool();
		}

	}
}
