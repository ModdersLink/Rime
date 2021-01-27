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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 88)]
	public class MeshStreamingSettings : 
		DataContainer
	{
		protected uint m_DefragTransferLimit = new uint();
		[ContainerField(Name: "DefragTransferLimit", Offset: 8, NameHash: 4263683176, Flags: 49421), LayoutImmutable, Blittable]
		public uint DefragTransferLimit { get { return m_DefragTransferLimit; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DefragTransferLimit), this, m_DefragTransferLimit, value)) m_DefragTransferLimit = value; } } // 0x8 (8)
		
		protected uint m_ListViewPageIndex = new uint();
		[ContainerField(Name: "ListViewPageIndex", Offset: 12, NameHash: 1203229703, Flags: 49421), LayoutImmutable, Blittable]
		public uint ListViewPageIndex { get { return m_ListViewPageIndex; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(ListViewPageIndex), this, m_ListViewPageIndex, value)) m_ListViewPageIndex = value; } } // 0xC (12)
		
		protected uint m_PoolSize = new uint();
		[ContainerField(Name: "PoolSize", Offset: 16, NameHash: 3885339292, Flags: 49421), LayoutImmutable, Blittable]
		public uint PoolSize { get { return m_PoolSize; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(PoolSize), this, m_PoolSize, value)) m_PoolSize = value; } } // 0x10 (16)
		
		protected int m_ForceLod = new int();
		[ContainerField(Name: "ForceLod", Offset: 20, NameHash: 1152595167, Flags: 49405), LayoutImmutable, Blittable]
		public int ForceLod { get { return m_ForceLod; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(ForceLod), this, m_ForceLod, value)) m_ForceLod = value; } } // 0x14 (20)
		
		protected uint m_PoolHeadroomSize = new uint();
		[ContainerField(Name: "PoolHeadroomSize", Offset: 24, NameHash: 1426093803, Flags: 49421), LayoutImmutable, Blittable]
		public uint PoolHeadroomSize { get { return m_PoolHeadroomSize; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(PoolHeadroomSize), this, m_PoolHeadroomSize, value)) m_PoolHeadroomSize = value; } } // 0x18 (24)
		
		protected uint m_ListViewSortOrder = new uint();
		[ContainerField(Name: "ListViewSortOrder", Offset: 28, NameHash: 2700744638, Flags: 49421), LayoutImmutable, Blittable]
		public uint ListViewSortOrder { get { return m_ListViewSortOrder; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(ListViewSortOrder), this, m_ListViewSortOrder, value)) m_ListViewSortOrder = value; } } // 0x1C (28)
		
		protected uint m_Ps3CellDefragTransferLimit = new uint();
		[ContainerField(Name: "Ps3CellDefragTransferLimit", Offset: 32, NameHash: 2920453886, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3CellDefragTransferLimit { get { return m_Ps3CellDefragTransferLimit; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(Ps3CellDefragTransferLimit), this, m_Ps3CellDefragTransferLimit, value)) m_Ps3CellDefragTransferLimit = value; } } // 0x20 (32)
		
		protected uint m_XenonFinalPoolSizeAdjustment = new uint();
		[ContainerField(Name: "XenonFinalPoolSizeAdjustment", Offset: 36, NameHash: 842975117, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonFinalPoolSizeAdjustment { get { return m_XenonFinalPoolSizeAdjustment; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(XenonFinalPoolSizeAdjustment), this, m_XenonFinalPoolSizeAdjustment, value)) m_XenonFinalPoolSizeAdjustment = value; } } // 0x24 (36)
		
		protected uint m_MaxUnloadCountPerFrame = new uint();
		[ContainerField(Name: "MaxUnloadCountPerFrame", Offset: 40, NameHash: 3872196917, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxUnloadCountPerFrame { get { return m_MaxUnloadCountPerFrame; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(MaxUnloadCountPerFrame), this, m_MaxUnloadCountPerFrame, value)) m_MaxUnloadCountPerFrame = value; } } // 0x28 (40)
		
		protected uint m_XenonRetailPoolSizeAdjustment = new uint();
		[ContainerField(Name: "XenonRetailPoolSizeAdjustment", Offset: 44, NameHash: 1487508902, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonRetailPoolSizeAdjustment { get { return m_XenonRetailPoolSizeAdjustment; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(XenonRetailPoolSizeAdjustment), this, m_XenonRetailPoolSizeAdjustment, value)) m_XenonRetailPoolSizeAdjustment = value; } } // 0x2C (44)
		
		protected uint m_MaxPendingLoadCount = new uint();
		[ContainerField(Name: "MaxPendingLoadCount", Offset: 48, NameHash: 4194764075, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxPendingLoadCount { get { return m_MaxPendingLoadCount; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(MaxPendingLoadCount), this, m_MaxPendingLoadCount, value)) m_MaxPendingLoadCount = value; } } // 0x30 (48)
		
		protected uint m_Ps3CellPoolSize = new uint();
		[ContainerField(Name: "Ps3CellPoolSize", Offset: 52, NameHash: 152499402, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3CellPoolSize { get { return m_Ps3CellPoolSize; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(Ps3CellPoolSize), this, m_Ps3CellPoolSize, value)) m_Ps3CellPoolSize = value; } } // 0x34 (52)
		
		protected uint m_Ps3CellPoolHeadroomSize = new uint();
		[ContainerField(Name: "Ps3CellPoolHeadroomSize", Offset: 56, NameHash: 3796226877, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3CellPoolHeadroomSize { get { return m_Ps3CellPoolHeadroomSize; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(Ps3CellPoolHeadroomSize), this, m_Ps3CellPoolHeadroomSize, value)) m_Ps3CellPoolHeadroomSize = value; } } // 0x38 (56)
		
		protected bool m_InstantUnloadingEnable = new bool();
		[ContainerField(Name: "InstantUnloadingEnable", Offset: 60, NameHash: 329282338, Flags: 49325), LayoutImmutable, Blittable]
		public bool InstantUnloadingEnable { get { return m_InstantUnloadingEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(InstantUnloadingEnable), this, m_InstantUnloadingEnable, value)) m_InstantUnloadingEnable = value; } } // 0x3C (60)
		
		protected bool m_AsyncCreatesEnable = new bool();
		[ContainerField(Name: "AsyncCreatesEnable", Offset: 61, NameHash: 2241018389, Flags: 49325), LayoutImmutable, Blittable]
		public bool AsyncCreatesEnable { get { return m_AsyncCreatesEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(AsyncCreatesEnable), this, m_AsyncCreatesEnable, value)) m_AsyncCreatesEnable = value; } } // 0x3D (61)
		
		protected bool m_DxImmutableUsageEnable = new bool();
		[ContainerField(Name: "DxImmutableUsageEnable", Offset: 62, NameHash: 2665891903, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxImmutableUsageEnable { get { return m_DxImmutableUsageEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DxImmutableUsageEnable), this, m_DxImmutableUsageEnable, value)) m_DxImmutableUsageEnable = value; } } // 0x3E (62)
		
		protected bool m_OverridePoolSizes = new bool();
		[ContainerField(Name: "OverridePoolSizes", Offset: 63, NameHash: 1108058651, Flags: 49325), LayoutImmutable, Blittable]
		public bool OverridePoolSizes { get { return m_OverridePoolSizes; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(OverridePoolSizes), this, m_OverridePoolSizes, value)) m_OverridePoolSizes = value; } } // 0x3F (63)
		
		protected bool m_UseSlowTexturePrio = new bool();
		[ContainerField(Name: "UseSlowTexturePrio", Offset: 64, NameHash: 1157390778, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseSlowTexturePrio { get { return m_UseSlowTexturePrio; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(UseSlowTexturePrio), this, m_UseSlowTexturePrio, value)) m_UseSlowTexturePrio = value; } } // 0x40 (64)
		
		protected bool m_UpdateEnable = new bool();
		[ContainerField(Name: "UpdateEnable", Offset: 65, NameHash: 3724816309, Flags: 49325), LayoutImmutable, Blittable]
		public bool UpdateEnable { get { return m_UpdateEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(UpdateEnable), this, m_UpdateEnable, value)) m_UpdateEnable = value; } } // 0x41 (65)
		
		protected bool m_DynamicLoadingEnable = new bool();
		[ContainerField(Name: "DynamicLoadingEnable", Offset: 66, NameHash: 677951191, Flags: 49325), LayoutImmutable, Blittable]
		public bool DynamicLoadingEnable { get { return m_DynamicLoadingEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DynamicLoadingEnable), this, m_DynamicLoadingEnable, value)) m_DynamicLoadingEnable = value; } } // 0x42 (66)
		
		protected bool m_PriorityJobEnable = new bool();
		[ContainerField(Name: "PriorityJobEnable", Offset: 67, NameHash: 1075653105, Flags: 49325), LayoutImmutable, Blittable]
		public bool PriorityJobEnable { get { return m_PriorityJobEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(PriorityJobEnable), this, m_PriorityJobEnable, value)) m_PriorityJobEnable = value; } } // 0x43 (67)
		
		protected bool m_PrioritySpuJobEnable = new bool();
		[ContainerField(Name: "PrioritySpuJobEnable", Offset: 68, NameHash: 68648327, Flags: 49325), LayoutImmutable, Blittable]
		public bool PrioritySpuJobEnable { get { return m_PrioritySpuJobEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(PrioritySpuJobEnable), this, m_PrioritySpuJobEnable, value)) m_PrioritySpuJobEnable = value; } } // 0x44 (68)
		
		protected bool m_UpdateJobEnable = new bool();
		[ContainerField(Name: "UpdateJobEnable", Offset: 69, NameHash: 4205084690, Flags: 49325), LayoutImmutable, Blittable]
		public bool UpdateJobEnable { get { return m_UpdateJobEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(UpdateJobEnable), this, m_UpdateJobEnable, value)) m_UpdateJobEnable = value; } } // 0x45 (69)
		
		protected bool m_DefragTransfersEnable = new bool();
		[ContainerField(Name: "DefragTransfersEnable", Offset: 70, NameHash: 539744815, Flags: 49325), LayoutImmutable, Blittable]
		public bool DefragTransfersEnable { get { return m_DefragTransfersEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DefragTransfersEnable), this, m_DefragTransfersEnable, value)) m_DefragTransfersEnable = value; } } // 0x46 (70)
		
		protected bool m_PrioritizeVisibleMeshesFirstEnable = new bool();
		[ContainerField(Name: "PrioritizeVisibleMeshesFirstEnable", Offset: 71, NameHash: 2262241096, Flags: 49325), LayoutImmutable, Blittable]
		public bool PrioritizeVisibleMeshesFirstEnable { get { return m_PrioritizeVisibleMeshesFirstEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(PrioritizeVisibleMeshesFirstEnable), this, m_PrioritizeVisibleMeshesFirstEnable, value)) m_PrioritizeVisibleMeshesFirstEnable = value; } } // 0x47 (71)
		
		protected bool m_PrioritizeVisibleLodsFirstEnable = new bool();
		[ContainerField(Name: "PrioritizeVisibleLodsFirstEnable", Offset: 72, NameHash: 3525977945, Flags: 49325), LayoutImmutable, Blittable]
		public bool PrioritizeVisibleLodsFirstEnable { get { return m_PrioritizeVisibleLodsFirstEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(PrioritizeVisibleLodsFirstEnable), this, m_PrioritizeVisibleLodsFirstEnable, value)) m_PrioritizeVisibleLodsFirstEnable = value; } } // 0x48 (72)
		
		protected bool m_PrioritizeVisibleLoadsEnable = new bool();
		[ContainerField(Name: "PrioritizeVisibleLoadsEnable", Offset: 73, NameHash: 4195609538, Flags: 49325), LayoutImmutable, Blittable]
		public bool PrioritizeVisibleLoadsEnable { get { return m_PrioritizeVisibleLoadsEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(PrioritizeVisibleLoadsEnable), this, m_PrioritizeVisibleLoadsEnable, value)) m_PrioritizeVisibleLoadsEnable = value; } } // 0x49 (73)
		
		protected bool m_PrioritizeTexturesEnable = new bool();
		[ContainerField(Name: "PrioritizeTexturesEnable", Offset: 74, NameHash: 2099438869, Flags: 49325), LayoutImmutable, Blittable]
		public bool PrioritizeTexturesEnable { get { return m_PrioritizeTexturesEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(PrioritizeTexturesEnable), this, m_PrioritizeTexturesEnable, value)) m_PrioritizeTexturesEnable = value; } } // 0x4A (74)
		
		protected bool m_HighestPriorityEnable = new bool();
		[ContainerField(Name: "HighestPriorityEnable", Offset: 75, NameHash: 2569265882, Flags: 49325), LayoutImmutable, Blittable]
		public bool HighestPriorityEnable { get { return m_HighestPriorityEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(HighestPriorityEnable), this, m_HighestPriorityEnable, value)) m_HighestPriorityEnable = value; } } // 0x4B (75)
		
		protected bool m_PrioritizeNearestPointEnable = new bool();
		[ContainerField(Name: "PrioritizeNearestPointEnable", Offset: 76, NameHash: 3869981839, Flags: 49325), LayoutImmutable, Blittable]
		public bool PrioritizeNearestPointEnable { get { return m_PrioritizeNearestPointEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(PrioritizeNearestPointEnable), this, m_PrioritizeNearestPointEnable, value)) m_PrioritizeNearestPointEnable = value; } } // 0x4C (76)
		
		protected bool m_DrawInstanceBoxesEnable = new bool();
		[ContainerField(Name: "DrawInstanceBoxesEnable", Offset: 77, NameHash: 2192259470, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawInstanceBoxesEnable { get { return m_DrawInstanceBoxesEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DrawInstanceBoxesEnable), this, m_DrawInstanceBoxesEnable, value)) m_DrawInstanceBoxesEnable = value; } } // 0x4D (77)
		
		protected bool m_DrawStatsEnable = new bool();
		[ContainerField(Name: "DrawStatsEnable", Offset: 78, NameHash: 711726149, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawStatsEnable { get { return m_DrawStatsEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DrawStatsEnable), this, m_DrawStatsEnable, value)) m_DrawStatsEnable = value; } } // 0x4E (78)
		
		protected bool m_DrawMissingListEnable = new bool();
		[ContainerField(Name: "DrawMissingListEnable", Offset: 79, NameHash: 114735618, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawMissingListEnable { get { return m_DrawMissingListEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DrawMissingListEnable), this, m_DrawMissingListEnable, value)) m_DrawMissingListEnable = value; } } // 0x4F (79)
		
		protected bool m_DrawPriorityListEnable = new bool();
		[ContainerField(Name: "DrawPriorityListEnable", Offset: 80, NameHash: 2687194932, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawPriorityListEnable { get { return m_DrawPriorityListEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DrawPriorityListEnable), this, m_DrawPriorityListEnable, value)) m_DrawPriorityListEnable = value; } } // 0x50 (80)
		
		protected bool m_DrawLoadingListEnable = new bool();
		[ContainerField(Name: "DrawLoadingListEnable", Offset: 81, NameHash: 2993570912, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawLoadingListEnable { get { return m_DrawLoadingListEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DrawLoadingListEnable), this, m_DrawLoadingListEnable, value)) m_DrawLoadingListEnable = value; } } // 0x51 (81)
		
		protected bool m_DrawMeshListEnable = new bool();
		[ContainerField(Name: "DrawMeshListEnable", Offset: 82, NameHash: 1722044565, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawMeshListEnable { get { return m_DrawMeshListEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DrawMeshListEnable), this, m_DrawMeshListEnable, value)) m_DrawMeshListEnable = value; } } // 0x52 (82)
		
		protected bool m_DrawNonStreamedListEnable = new bool();
		[ContainerField(Name: "DrawNonStreamedListEnable", Offset: 83, NameHash: 1340688884, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawNonStreamedListEnable { get { return m_DrawNonStreamedListEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DrawNonStreamedListEnable), this, m_DrawNonStreamedListEnable, value)) m_DrawNonStreamedListEnable = value; } } // 0x53 (83)
		
		protected bool m_DefragEnable = new bool();
		[ContainerField(Name: "DefragEnable", Offset: 84, NameHash: 485927863, Flags: 49325), LayoutImmutable, Blittable]
		public bool DefragEnable { get { return m_DefragEnable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DefragEnable), this, m_DefragEnable, value)) m_DefragEnable = value; } } // 0x54 (84)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 85, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x55 (85)
		
		protected bool m_DumpLoadedList = new bool();
		[ContainerField(Name: "DumpLoadedList", Offset: 86, NameHash: 3865360236, Flags: 49325), LayoutImmutable, Blittable]
		public bool DumpLoadedList { get { return m_DumpLoadedList; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(DumpLoadedList), this, m_DumpLoadedList, value)) m_DumpLoadedList = value; } } // 0x56 (86)
		
		protected bool m_UseConditionalStreaming = new bool();
		[ContainerField(Name: "UseConditionalStreaming", Offset: 87, NameHash: 3302650340, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseConditionalStreaming { get { return m_UseConditionalStreaming; } set { if (OnPropertyChanging("MeshStreamingSettings." + nameof(UseConditionalStreaming), this, m_UseConditionalStreaming, value)) m_UseConditionalStreaming = value; } } // 0x57 (87)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4263683176:
					DefragTransferLimit = (uint) p_Value;
					break;

				case 1203229703:
					ListViewPageIndex = (uint) p_Value;
					break;

				case 3885339292:
					PoolSize = (uint) p_Value;
					break;

				case 1152595167:
					ForceLod = (int) p_Value;
					break;

				case 1426093803:
					PoolHeadroomSize = (uint) p_Value;
					break;

				case 2700744638:
					ListViewSortOrder = (uint) p_Value;
					break;

				case 2920453886:
					Ps3CellDefragTransferLimit = (uint) p_Value;
					break;

				case 842975117:
					XenonFinalPoolSizeAdjustment = (uint) p_Value;
					break;

				case 3872196917:
					MaxUnloadCountPerFrame = (uint) p_Value;
					break;

				case 1487508902:
					XenonRetailPoolSizeAdjustment = (uint) p_Value;
					break;

				case 4194764075:
					MaxPendingLoadCount = (uint) p_Value;
					break;

				case 152499402:
					Ps3CellPoolSize = (uint) p_Value;
					break;

				case 3796226877:
					Ps3CellPoolHeadroomSize = (uint) p_Value;
					break;

				case 329282338:
					InstantUnloadingEnable = (bool) p_Value;
					break;

				case 2241018389:
					AsyncCreatesEnable = (bool) p_Value;
					break;

				case 2665891903:
					DxImmutableUsageEnable = (bool) p_Value;
					break;

				case 1108058651:
					OverridePoolSizes = (bool) p_Value;
					break;

				case 1157390778:
					UseSlowTexturePrio = (bool) p_Value;
					break;

				case 3724816309:
					UpdateEnable = (bool) p_Value;
					break;

				case 677951191:
					DynamicLoadingEnable = (bool) p_Value;
					break;

				case 1075653105:
					PriorityJobEnable = (bool) p_Value;
					break;

				case 68648327:
					PrioritySpuJobEnable = (bool) p_Value;
					break;

				case 4205084690:
					UpdateJobEnable = (bool) p_Value;
					break;

				case 539744815:
					DefragTransfersEnable = (bool) p_Value;
					break;

				case 2262241096:
					PrioritizeVisibleMeshesFirstEnable = (bool) p_Value;
					break;

				case 3525977945:
					PrioritizeVisibleLodsFirstEnable = (bool) p_Value;
					break;

				case 4195609538:
					PrioritizeVisibleLoadsEnable = (bool) p_Value;
					break;

				case 2099438869:
					PrioritizeTexturesEnable = (bool) p_Value;
					break;

				case 2569265882:
					HighestPriorityEnable = (bool) p_Value;
					break;

				case 3869981839:
					PrioritizeNearestPointEnable = (bool) p_Value;
					break;

				case 2192259470:
					DrawInstanceBoxesEnable = (bool) p_Value;
					break;

				case 711726149:
					DrawStatsEnable = (bool) p_Value;
					break;

				case 114735618:
					DrawMissingListEnable = (bool) p_Value;
					break;

				case 2687194932:
					DrawPriorityListEnable = (bool) p_Value;
					break;

				case 2993570912:
					DrawLoadingListEnable = (bool) p_Value;
					break;

				case 1722044565:
					DrawMeshListEnable = (bool) p_Value;
					break;

				case 1340688884:
					DrawNonStreamedListEnable = (bool) p_Value;
					break;

				case 485927863:
					DefragEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 3865360236:
					DumpLoadedList = (bool) p_Value;
					break;

				case 3302650340:
					UseConditionalStreaming = (bool) p_Value;
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
				case 4263683176:
					return DefragTransferLimit;

				case 1203229703:
					return ListViewPageIndex;

				case 3885339292:
					return PoolSize;

				case 1152595167:
					return ForceLod;

				case 1426093803:
					return PoolHeadroomSize;

				case 2700744638:
					return ListViewSortOrder;

				case 2920453886:
					return Ps3CellDefragTransferLimit;

				case 842975117:
					return XenonFinalPoolSizeAdjustment;

				case 3872196917:
					return MaxUnloadCountPerFrame;

				case 1487508902:
					return XenonRetailPoolSizeAdjustment;

				case 4194764075:
					return MaxPendingLoadCount;

				case 152499402:
					return Ps3CellPoolSize;

				case 3796226877:
					return Ps3CellPoolHeadroomSize;

				case 329282338:
					return InstantUnloadingEnable;

				case 2241018389:
					return AsyncCreatesEnable;

				case 2665891903:
					return DxImmutableUsageEnable;

				case 1108058651:
					return OverridePoolSizes;

				case 1157390778:
					return UseSlowTexturePrio;

				case 3724816309:
					return UpdateEnable;

				case 677951191:
					return DynamicLoadingEnable;

				case 1075653105:
					return PriorityJobEnable;

				case 68648327:
					return PrioritySpuJobEnable;

				case 4205084690:
					return UpdateJobEnable;

				case 539744815:
					return DefragTransfersEnable;

				case 2262241096:
					return PrioritizeVisibleMeshesFirstEnable;

				case 3525977945:
					return PrioritizeVisibleLodsFirstEnable;

				case 4195609538:
					return PrioritizeVisibleLoadsEnable;

				case 2099438869:
					return PrioritizeTexturesEnable;

				case 2569265882:
					return HighestPriorityEnable;

				case 3869981839:
					return PrioritizeNearestPointEnable;

				case 2192259470:
					return DrawInstanceBoxesEnable;

				case 711726149:
					return DrawStatsEnable;

				case 114735618:
					return DrawMissingListEnable;

				case 2687194932:
					return DrawPriorityListEnable;

				case 2993570912:
					return DrawLoadingListEnable;

				case 1722044565:
					return DrawMeshListEnable;

				case 1340688884:
					return DrawNonStreamedListEnable;

				case 485927863:
					return DefragEnable;

				case 2342790116:
					return Enable;

				case 3865360236:
					return DumpLoadedList;

				case 3302650340:
					return UseConditionalStreaming;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4263683176:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DefragTransferLimit));

				case 1203229703:
					return typeof(MeshStreamingSettings).GetProperty(nameof(ListViewPageIndex));

				case 3885339292:
					return typeof(MeshStreamingSettings).GetProperty(nameof(PoolSize));

				case 1152595167:
					return typeof(MeshStreamingSettings).GetProperty(nameof(ForceLod));

				case 1426093803:
					return typeof(MeshStreamingSettings).GetProperty(nameof(PoolHeadroomSize));

				case 2700744638:
					return typeof(MeshStreamingSettings).GetProperty(nameof(ListViewSortOrder));

				case 2920453886:
					return typeof(MeshStreamingSettings).GetProperty(nameof(Ps3CellDefragTransferLimit));

				case 842975117:
					return typeof(MeshStreamingSettings).GetProperty(nameof(XenonFinalPoolSizeAdjustment));

				case 3872196917:
					return typeof(MeshStreamingSettings).GetProperty(nameof(MaxUnloadCountPerFrame));

				case 1487508902:
					return typeof(MeshStreamingSettings).GetProperty(nameof(XenonRetailPoolSizeAdjustment));

				case 4194764075:
					return typeof(MeshStreamingSettings).GetProperty(nameof(MaxPendingLoadCount));

				case 152499402:
					return typeof(MeshStreamingSettings).GetProperty(nameof(Ps3CellPoolSize));

				case 3796226877:
					return typeof(MeshStreamingSettings).GetProperty(nameof(Ps3CellPoolHeadroomSize));

				case 329282338:
					return typeof(MeshStreamingSettings).GetProperty(nameof(InstantUnloadingEnable));

				case 2241018389:
					return typeof(MeshStreamingSettings).GetProperty(nameof(AsyncCreatesEnable));

				case 2665891903:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DxImmutableUsageEnable));

				case 1108058651:
					return typeof(MeshStreamingSettings).GetProperty(nameof(OverridePoolSizes));

				case 1157390778:
					return typeof(MeshStreamingSettings).GetProperty(nameof(UseSlowTexturePrio));

				case 3724816309:
					return typeof(MeshStreamingSettings).GetProperty(nameof(UpdateEnable));

				case 677951191:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DynamicLoadingEnable));

				case 1075653105:
					return typeof(MeshStreamingSettings).GetProperty(nameof(PriorityJobEnable));

				case 68648327:
					return typeof(MeshStreamingSettings).GetProperty(nameof(PrioritySpuJobEnable));

				case 4205084690:
					return typeof(MeshStreamingSettings).GetProperty(nameof(UpdateJobEnable));

				case 539744815:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DefragTransfersEnable));

				case 2262241096:
					return typeof(MeshStreamingSettings).GetProperty(nameof(PrioritizeVisibleMeshesFirstEnable));

				case 3525977945:
					return typeof(MeshStreamingSettings).GetProperty(nameof(PrioritizeVisibleLodsFirstEnable));

				case 4195609538:
					return typeof(MeshStreamingSettings).GetProperty(nameof(PrioritizeVisibleLoadsEnable));

				case 2099438869:
					return typeof(MeshStreamingSettings).GetProperty(nameof(PrioritizeTexturesEnable));

				case 2569265882:
					return typeof(MeshStreamingSettings).GetProperty(nameof(HighestPriorityEnable));

				case 3869981839:
					return typeof(MeshStreamingSettings).GetProperty(nameof(PrioritizeNearestPointEnable));

				case 2192259470:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DrawInstanceBoxesEnable));

				case 711726149:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DrawStatsEnable));

				case 114735618:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DrawMissingListEnable));

				case 2687194932:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DrawPriorityListEnable));

				case 2993570912:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DrawLoadingListEnable));

				case 1722044565:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DrawMeshListEnable));

				case 1340688884:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DrawNonStreamedListEnable));

				case 485927863:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DefragEnable));

				case 2342790116:
					return typeof(MeshStreamingSettings).GetProperty(nameof(Enable));

				case 3865360236:
					return typeof(MeshStreamingSettings).GetProperty(nameof(DumpLoadedList));

				case 3302650340:
					return typeof(MeshStreamingSettings).GetProperty(nameof(UseConditionalStreaming));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
