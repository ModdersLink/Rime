///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 52)]
	public class PathfindingBuildSettingsAsset : 
		Asset
	{
		protected float m_EntityRadius = new float();
		[ContainerField(Name: "EntityRadius", Offset: 12, NameHash: 1657367494, Flags: 49469), LayoutImmutable, Blittable]
		public float EntityRadius { get { return m_EntityRadius; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(EntityRadius), this, m_EntityRadius, value)) m_EntityRadius = value; } } // 0xC (12)
		
		protected float m_EntityHeight = new float();
		[ContainerField(Name: "EntityHeight", Offset: 16, NameHash: 1892517569, Flags: 49469), LayoutImmutable, Blittable]
		public float EntityHeight { get { return m_EntityHeight; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(EntityHeight), this, m_EntityHeight, value)) m_EntityHeight = value; } } // 0x10 (16)
		
		protected float m_MaxWalkableSlope = new float();
		[ContainerField(Name: "MaxWalkableSlope", Offset: 20, NameHash: 4231342063, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxWalkableSlope { get { return m_MaxWalkableSlope; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(MaxWalkableSlope), this, m_MaxWalkableSlope, value)) m_MaxWalkableSlope = value; } } // 0x14 (20)
		
		protected float m_MaxStep = new float();
		[ContainerField(Name: "MaxStep", Offset: 24, NameHash: 1313516259, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxStep { get { return m_MaxStep; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(MaxStep), this, m_MaxStep, value)) m_MaxStep = value; } } // 0x18 (24)
		
		protected float m_MinIslandSurfaceArea = new float();
		[ContainerField(Name: "MinIslandSurfaceArea", Offset: 28, NameHash: 4012611888, Flags: 49469), LayoutImmutable, Blittable]
		public float MinIslandSurfaceArea { get { return m_MinIslandSurfaceArea; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(MinIslandSurfaceArea), this, m_MinIslandSurfaceArea, value)) m_MinIslandSurfaceArea = value; } } // 0x1C (28)
		
		protected float m_VoxSize = new float();
		[ContainerField(Name: "VoxSize", Offset: 32, NameHash: 1120800449, Flags: 49469), LayoutImmutable, Blittable]
		public float VoxSize { get { return m_VoxSize; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(VoxSize), this, m_VoxSize, value)) m_VoxSize = value; } } // 0x20 (32)
		
		protected float m_GridSideLength = new float();
		[ContainerField(Name: "GridSideLength", Offset: 36, NameHash: 272494682, Flags: 49469), LayoutImmutable, Blittable]
		public float GridSideLength { get { return m_GridSideLength; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(GridSideLength), this, m_GridSideLength, value)) m_GridSideLength = value; } } // 0x24 (36)
		
		protected float m_AdditionalInwardsSmoothingDist = new float();
		[ContainerField(Name: "AdditionalInwardsSmoothingDist", Offset: 40, NameHash: 2989176800, Flags: 49469), LayoutImmutable, Blittable]
		public float AdditionalInwardsSmoothingDist { get { return m_AdditionalInwardsSmoothingDist; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(AdditionalInwardsSmoothingDist), this, m_AdditionalInwardsSmoothingDist, value)) m_AdditionalInwardsSmoothingDist = value; } } // 0x28 (40)
		
		protected uint m_TerrainSamplingStep = new uint();
		[ContainerField(Name: "TerrainSamplingStep", Offset: 44, NameHash: 2825496355, Flags: 49421), LayoutImmutable, Blittable]
		public uint TerrainSamplingStep { get { return m_TerrainSamplingStep; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(TerrainSamplingStep), this, m_TerrainSamplingStep, value)) m_TerrainSamplingStep = value; } } // 0x2C (44)
		
		protected bool m_TesselateForPathingAccuracy = new bool();
		[ContainerField(Name: "TesselateForPathingAccuracy", Offset: 48, NameHash: 2360234118, Flags: 49325), LayoutImmutable, Blittable]
		public bool TesselateForPathingAccuracy { get { return m_TesselateForPathingAccuracy; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(TesselateForPathingAccuracy), this, m_TesselateForPathingAccuracy, value)) m_TesselateForPathingAccuracy = value; } } // 0x30 (48)
		
		protected bool m_UseEnhancedTerrainTracking = new bool();
		[ContainerField(Name: "UseEnhancedTerrainTracking", Offset: 49, NameHash: 543071632, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseEnhancedTerrainTracking { get { return m_UseEnhancedTerrainTracking; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(UseEnhancedTerrainTracking), this, m_UseEnhancedTerrainTracking, value)) m_UseEnhancedTerrainTracking = value; } } // 0x31 (49)
		
		protected bool m_OptimizeForAxisAligned = new bool();
		[ContainerField(Name: "OptimizeForAxisAligned", Offset: 50, NameHash: 425521512, Flags: 49325), LayoutImmutable, Blittable]
		public bool OptimizeForAxisAligned { get { return m_OptimizeForAxisAligned; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(OptimizeForAxisAligned), this, m_OptimizeForAxisAligned, value)) m_OptimizeForAxisAligned = value; } } // 0x32 (50)
		
		protected bool m_LeaveSmallIslandsTouchingPortals = new bool();
		[ContainerField(Name: "LeaveSmallIslandsTouchingPortals", Offset: 51, NameHash: 2918504877, Flags: 49325), LayoutImmutable, Blittable]
		public bool LeaveSmallIslandsTouchingPortals { get { return m_LeaveSmallIslandsTouchingPortals; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(LeaveSmallIslandsTouchingPortals), this, m_LeaveSmallIslandsTouchingPortals, value)) m_LeaveSmallIslandsTouchingPortals = value; } } // 0x33 (51)
		
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
