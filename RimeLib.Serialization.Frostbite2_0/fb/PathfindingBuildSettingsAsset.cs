///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 52)]
	public class PathfindingBuildSettingsAsset :
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float EntityRadius { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float EntityHeight { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float MaxWalkableSlope { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float MaxStep { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float MinIslandSurfaceArea { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float VoxSize { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float GridSideLength { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float AdditionalInwardsSmoothingDist { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public uint TerrainSamplingStep { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public bool TesselateForPathingAccuracy { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		public bool UseEnhancedTerrainTracking { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
		public bool OptimizeForAxisAligned { get; set; }

		[ContainerField(51), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
		public bool LeaveSmallIslandsTouchingPortals { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(EntityRadius);
			p_Writer.Write(EntityHeight);
			p_Writer.Write(MaxWalkableSlope);
			p_Writer.Write(MaxStep);
			p_Writer.Write(MinIslandSurfaceArea);
			p_Writer.Write(VoxSize);
			p_Writer.Write(GridSideLength);
			p_Writer.Write(AdditionalInwardsSmoothingDist);
			p_Writer.Write(TerrainSamplingStep);
			p_Writer.Write(TesselateForPathingAccuracy);
			p_Writer.Write(UseEnhancedTerrainTracking);
			p_Writer.Write(OptimizeForAxisAligned);
			p_Writer.Write(LeaveSmallIslandsTouchingPortals);
		}
	}
}
