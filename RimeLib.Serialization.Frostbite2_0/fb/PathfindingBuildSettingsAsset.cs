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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 52)]
	public partial class PathfindingBuildSettingsAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _EntityRadius;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _EntityHeight;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _MaxWalkableSlope;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _MaxStep;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _MinIslandSurfaceArea;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _VoxSize;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _GridSideLength;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _AdditionalInwardsSmoothingDist;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private uint _TerrainSamplingStep;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private bool _TesselateForPathingAccuracy;

		[ObservableProperty]
		[property: ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		private bool _UseEnhancedTerrainTracking;

		[ObservableProperty]
		[property: ContainerField(50), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
		private bool _OptimizeForAxisAligned;

		[ObservableProperty]
		[property: ContainerField(51), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
		private bool _LeaveSmallIslandsTouchingPortals;

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
