///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class PathfindingBuildSettingsAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float EntityRadius { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float EntityHeight { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MaxWalkableSlope { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxStep { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MinIslandSurfaceArea { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float VoxSize { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float GridSideLength { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float AdditionalInwardsSmoothingDist { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public uint TerrainSamplingStep { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool TesselateForPathingAccuracy { get; set; } // 0x30 (48)
		
		[ContainerField(49), LayoutImmutable, Blittable]
		public bool UseEnhancedTerrainTracking { get; set; } // 0x31 (49)
		
		[ContainerField(50), LayoutImmutable, Blittable]
		public bool OptimizeForAxisAligned { get; set; } // 0x32 (50)
		
		[ContainerField(51), LayoutImmutable, Blittable]
		public bool LeaveSmallIslandsTouchingPortals { get; set; } // 0x33 (51)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1657367494:
					EntityRadius = (float) p_Value;
					break;

				case 1892517569:
					EntityHeight = (float) p_Value;
					break;

				case 4231342063:
					MaxWalkableSlope = (float) p_Value;
					break;

				case 1313516259:
					MaxStep = (float) p_Value;
					break;

				case 4012611888:
					MinIslandSurfaceArea = (float) p_Value;
					break;

				case 1120800449:
					VoxSize = (float) p_Value;
					break;

				case 272494682:
					GridSideLength = (float) p_Value;
					break;

				case 2989176800:
					AdditionalInwardsSmoothingDist = (float) p_Value;
					break;

				case 2825496355:
					TerrainSamplingStep = (uint) p_Value;
					break;

				case 2360234118:
					TesselateForPathingAccuracy = (bool) p_Value;
					break;

				case 543071632:
					UseEnhancedTerrainTracking = (bool) p_Value;
					break;

				case 425521512:
					OptimizeForAxisAligned = (bool) p_Value;
					break;

				case 2918504877:
					LeaveSmallIslandsTouchingPortals = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1657367494:
					return EntityRadius;

				case 1892517569:
					return EntityHeight;

				case 4231342063:
					return MaxWalkableSlope;

				case 1313516259:
					return MaxStep;

				case 4012611888:
					return MinIslandSurfaceArea;

				case 1120800449:
					return VoxSize;

				case 272494682:
					return GridSideLength;

				case 2989176800:
					return AdditionalInwardsSmoothingDist;

				case 2825496355:
					return TerrainSamplingStep;

				case 2360234118:
					return TesselateForPathingAccuracy;

				case 543071632:
					return UseEnhancedTerrainTracking;

				case 425521512:
					return OptimizeForAxisAligned;

				case 2918504877:
					return LeaveSmallIslandsTouchingPortals;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1657367494:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(EntityRadius));

				case 1892517569:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(EntityHeight));

				case 4231342063:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(MaxWalkableSlope));

				case 1313516259:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(MaxStep));

				case 4012611888:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(MinIslandSurfaceArea));

				case 1120800449:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(VoxSize));

				case 272494682:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(GridSideLength));

				case 2989176800:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(AdditionalInwardsSmoothingDist));

				case 2825496355:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(TerrainSamplingStep));

				case 2360234118:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(TesselateForPathingAccuracy));

				case 543071632:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(UseEnhancedTerrainTracking));

				case 425521512:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(OptimizeForAxisAligned));

				case 2918504877:
					return typeof(PathfindingBuildSettingsAsset).GetProperty(nameof(LeaveSmallIslandsTouchingPortals));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
