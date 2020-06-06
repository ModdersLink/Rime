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
	public class MeshStreamingSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint DefragTransferLimit { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint ListViewPageIndex { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint PoolSize { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int ForceLod { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint PoolHeadroomSize { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ListViewSortOrder { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint Ps3CellDefragTransferLimit { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint XenonFinalPoolSizeAdjustment { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint MaxUnloadCountPerFrame { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public uint XenonRetailPoolSizeAdjustment { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public uint MaxPendingLoadCount { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public uint Ps3CellPoolSize { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public uint Ps3CellPoolHeadroomSize { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool InstantUnloadingEnable { get; set; } // 0x3C (60)
		
		[ContainerField(61), LayoutImmutable, Blittable]
		public bool AsyncCreatesEnable { get; set; } // 0x3D (61)
		
		[ContainerField(62), LayoutImmutable, Blittable]
		public bool DxImmutableUsageEnable { get; set; } // 0x3E (62)
		
		[ContainerField(63), LayoutImmutable, Blittable]
		public bool OverridePoolSizes { get; set; } // 0x3F (63)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public bool UseSlowTexturePrio { get; set; } // 0x40 (64)
		
		[ContainerField(65), LayoutImmutable, Blittable]
		public bool UpdateEnable { get; set; } // 0x41 (65)
		
		[ContainerField(66), LayoutImmutable, Blittable]
		public bool DynamicLoadingEnable { get; set; } // 0x42 (66)
		
		[ContainerField(67), LayoutImmutable, Blittable]
		public bool PriorityJobEnable { get; set; } // 0x43 (67)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool PrioritySpuJobEnable { get; set; } // 0x44 (68)
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool UpdateJobEnable { get; set; } // 0x45 (69)
		
		[ContainerField(70), LayoutImmutable, Blittable]
		public bool DefragTransfersEnable { get; set; } // 0x46 (70)
		
		[ContainerField(71), LayoutImmutable, Blittable]
		public bool PrioritizeVisibleMeshesFirstEnable { get; set; } // 0x47 (71)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public bool PrioritizeVisibleLodsFirstEnable { get; set; } // 0x48 (72)
		
		[ContainerField(73), LayoutImmutable, Blittable]
		public bool PrioritizeVisibleLoadsEnable { get; set; } // 0x49 (73)
		
		[ContainerField(74), LayoutImmutable, Blittable]
		public bool PrioritizeTexturesEnable { get; set; } // 0x4A (74)
		
		[ContainerField(75), LayoutImmutable, Blittable]
		public bool HighestPriorityEnable { get; set; } // 0x4B (75)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public bool PrioritizeNearestPointEnable { get; set; } // 0x4C (76)
		
		[ContainerField(77), LayoutImmutable, Blittable]
		public bool DrawInstanceBoxesEnable { get; set; } // 0x4D (77)
		
		[ContainerField(78), LayoutImmutable, Blittable]
		public bool DrawStatsEnable { get; set; } // 0x4E (78)
		
		[ContainerField(79), LayoutImmutable, Blittable]
		public bool DrawMissingListEnable { get; set; } // 0x4F (79)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public bool DrawPriorityListEnable { get; set; } // 0x50 (80)
		
		[ContainerField(81), LayoutImmutable, Blittable]
		public bool DrawLoadingListEnable { get; set; } // 0x51 (81)
		
		[ContainerField(82), LayoutImmutable, Blittable]
		public bool DrawMeshListEnable { get; set; } // 0x52 (82)
		
		[ContainerField(83), LayoutImmutable, Blittable]
		public bool DrawNonStreamedListEnable { get; set; } // 0x53 (83)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public bool DefragEnable { get; set; } // 0x54 (84)
		
		[ContainerField(85), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x55 (85)
		
		[ContainerField(86), LayoutImmutable, Blittable]
		public bool DumpLoadedList { get; set; } // 0x56 (86)
		
		[ContainerField(87), LayoutImmutable, Blittable]
		public bool UseConditionalStreaming { get; set; } // 0x57 (87)
		
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
