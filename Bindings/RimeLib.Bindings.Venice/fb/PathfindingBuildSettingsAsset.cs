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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class PathfindingBuildSettingsAsset : 
		Asset
	{
		protected float m_EntityRadius = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1657367494)]
		public float EntityRadius { get { return m_EntityRadius; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(EntityRadius), this, m_EntityRadius, value)) m_EntityRadius = value; } } // 0xC (12)
		
		protected float m_EntityHeight = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1892517569)]
		public float EntityHeight { get { return m_EntityHeight; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(EntityHeight), this, m_EntityHeight, value)) m_EntityHeight = value; } } // 0x10 (16)
		
		protected float m_MaxWalkableSlope = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4231342063)]
		public float MaxWalkableSlope { get { return m_MaxWalkableSlope; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(MaxWalkableSlope), this, m_MaxWalkableSlope, value)) m_MaxWalkableSlope = value; } } // 0x14 (20)
		
		protected float m_MaxStep = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1313516259)]
		public float MaxStep { get { return m_MaxStep; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(MaxStep), this, m_MaxStep, value)) m_MaxStep = value; } } // 0x18 (24)
		
		protected float m_MinIslandSurfaceArea = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4012611888)]
		public float MinIslandSurfaceArea { get { return m_MinIslandSurfaceArea; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(MinIslandSurfaceArea), this, m_MinIslandSurfaceArea, value)) m_MinIslandSurfaceArea = value; } } // 0x1C (28)
		
		protected float m_VoxSize = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1120800449)]
		public float VoxSize { get { return m_VoxSize; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(VoxSize), this, m_VoxSize, value)) m_VoxSize = value; } } // 0x20 (32)
		
		protected float m_GridSideLength = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(272494682)]
		public float GridSideLength { get { return m_GridSideLength; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(GridSideLength), this, m_GridSideLength, value)) m_GridSideLength = value; } } // 0x24 (36)
		
		protected float m_AdditionalInwardsSmoothingDist = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2989176800)]
		public float AdditionalInwardsSmoothingDist { get { return m_AdditionalInwardsSmoothingDist; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(AdditionalInwardsSmoothingDist), this, m_AdditionalInwardsSmoothingDist, value)) m_AdditionalInwardsSmoothingDist = value; } } // 0x28 (40)
		
		protected uint m_TerrainSamplingStep = new uint();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2825496355)]
		public uint TerrainSamplingStep { get { return m_TerrainSamplingStep; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(TerrainSamplingStep), this, m_TerrainSamplingStep, value)) m_TerrainSamplingStep = value; } } // 0x2C (44)
		
		protected bool m_TesselateForPathingAccuracy = new bool();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2360234118)]
		public bool TesselateForPathingAccuracy { get { return m_TesselateForPathingAccuracy; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(TesselateForPathingAccuracy), this, m_TesselateForPathingAccuracy, value)) m_TesselateForPathingAccuracy = value; } } // 0x30 (48)
		
		protected bool m_UseEnhancedTerrainTracking = new bool();
		[ContainerField(49), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(543071632)]
		public bool UseEnhancedTerrainTracking { get { return m_UseEnhancedTerrainTracking; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(UseEnhancedTerrainTracking), this, m_UseEnhancedTerrainTracking, value)) m_UseEnhancedTerrainTracking = value; } } // 0x31 (49)
		
		protected bool m_OptimizeForAxisAligned = new bool();
		[ContainerField(50), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(425521512)]
		public bool OptimizeForAxisAligned { get { return m_OptimizeForAxisAligned; } set { if (OnPropertyChanging("PathfindingBuildSettingsAsset." + nameof(OptimizeForAxisAligned), this, m_OptimizeForAxisAligned, value)) m_OptimizeForAxisAligned = value; } } // 0x32 (50)
		
		protected bool m_LeaveSmallIslandsTouchingPortals = new bool();
		[ContainerField(51), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2918504877)]
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
