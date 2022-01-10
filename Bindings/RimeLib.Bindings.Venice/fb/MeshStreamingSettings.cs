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
	[ContainerType(4, 88)]
	public class MeshStreamingSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint DefragTransferLimit { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint ListViewPageIndex { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint PoolSize { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int ForceLod { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint PoolHeadroomSize { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ListViewSortOrder { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint Ps3CellDefragTransferLimit { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint XenonFinalPoolSizeAdjustment { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint MaxUnloadCountPerFrame { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public uint XenonRetailPoolSizeAdjustment { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public uint MaxPendingLoadCount { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public uint Ps3CellPoolSize { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public uint Ps3CellPoolHeadroomSize { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool InstantUnloadingEnable { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable]
		public bool AsyncCreatesEnable { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable]
		public bool DxImmutableUsageEnable { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable]
		public bool OverridePoolSizes { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public bool UseSlowTexturePrio { get; set; }

		[ContainerField(65), LayoutImmutable, Blittable]
		public bool UpdateEnable { get; set; }

		[ContainerField(66), LayoutImmutable, Blittable]
		public bool DynamicLoadingEnable { get; set; }

		[ContainerField(67), LayoutImmutable, Blittable]
		public bool PriorityJobEnable { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public bool PrioritySpuJobEnable { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable]
		public bool UpdateJobEnable { get; set; }

		[ContainerField(70), LayoutImmutable, Blittable]
		public bool DefragTransfersEnable { get; set; }

		[ContainerField(71), LayoutImmutable, Blittable]
		public bool PrioritizeVisibleMeshesFirstEnable { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public bool PrioritizeVisibleLodsFirstEnable { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable]
		public bool PrioritizeVisibleLoadsEnable { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable]
		public bool PrioritizeTexturesEnable { get; set; }

		[ContainerField(75), LayoutImmutable, Blittable]
		public bool HighestPriorityEnable { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public bool PrioritizeNearestPointEnable { get; set; }

		[ContainerField(77), LayoutImmutable, Blittable]
		public bool DrawInstanceBoxesEnable { get; set; }

		[ContainerField(78), LayoutImmutable, Blittable]
		public bool DrawStatsEnable { get; set; }

		[ContainerField(79), LayoutImmutable, Blittable]
		public bool DrawMissingListEnable { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public bool DrawPriorityListEnable { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable]
		public bool DrawLoadingListEnable { get; set; }

		[ContainerField(82), LayoutImmutable, Blittable]
		public bool DrawMeshListEnable { get; set; }

		[ContainerField(83), LayoutImmutable, Blittable]
		public bool DrawNonStreamedListEnable { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public bool DefragEnable { get; set; }

		[ContainerField(85), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(86), LayoutImmutable, Blittable]
		public bool DumpLoadedList { get; set; }

		[ContainerField(87), LayoutImmutable, Blittable]
		public bool UseConditionalStreaming { get; set; }

		public static void Deserialize(MeshStreamingSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DefragTransferLimit = p_Reader.ReadUInt32();
			p_Instance.ListViewPageIndex = p_Reader.ReadUInt32();
			p_Instance.PoolSize = p_Reader.ReadUInt32();
			p_Instance.ForceLod = p_Reader.ReadInt32();
			p_Instance.PoolHeadroomSize = p_Reader.ReadUInt32();
			p_Instance.ListViewSortOrder = p_Reader.ReadUInt32();
			p_Instance.Ps3CellDefragTransferLimit = p_Reader.ReadUInt32();
			p_Instance.XenonFinalPoolSizeAdjustment = p_Reader.ReadUInt32();
			p_Instance.MaxUnloadCountPerFrame = p_Reader.ReadUInt32();
			p_Instance.XenonRetailPoolSizeAdjustment = p_Reader.ReadUInt32();
			p_Instance.MaxPendingLoadCount = p_Reader.ReadUInt32();
			p_Instance.Ps3CellPoolSize = p_Reader.ReadUInt32();
			p_Instance.Ps3CellPoolHeadroomSize = p_Reader.ReadUInt32();
			p_Instance.InstantUnloadingEnable = p_Reader.ReadBool();
			p_Instance.AsyncCreatesEnable = p_Reader.ReadBool();
			p_Instance.DxImmutableUsageEnable = p_Reader.ReadBool();
			p_Instance.OverridePoolSizes = p_Reader.ReadBool();
			p_Instance.UseSlowTexturePrio = p_Reader.ReadBool();
			p_Instance.UpdateEnable = p_Reader.ReadBool();
			p_Instance.DynamicLoadingEnable = p_Reader.ReadBool();
			p_Instance.PriorityJobEnable = p_Reader.ReadBool();
			p_Instance.PrioritySpuJobEnable = p_Reader.ReadBool();
			p_Instance.UpdateJobEnable = p_Reader.ReadBool();
			p_Instance.DefragTransfersEnable = p_Reader.ReadBool();
			p_Instance.PrioritizeVisibleMeshesFirstEnable = p_Reader.ReadBool();
			p_Instance.PrioritizeVisibleLodsFirstEnable = p_Reader.ReadBool();
			p_Instance.PrioritizeVisibleLoadsEnable = p_Reader.ReadBool();
			p_Instance.PrioritizeTexturesEnable = p_Reader.ReadBool();
			p_Instance.HighestPriorityEnable = p_Reader.ReadBool();
			p_Instance.PrioritizeNearestPointEnable = p_Reader.ReadBool();
			p_Instance.DrawInstanceBoxesEnable = p_Reader.ReadBool();
			p_Instance.DrawStatsEnable = p_Reader.ReadBool();
			p_Instance.DrawMissingListEnable = p_Reader.ReadBool();
			p_Instance.DrawPriorityListEnable = p_Reader.ReadBool();
			p_Instance.DrawLoadingListEnable = p_Reader.ReadBool();
			p_Instance.DrawMeshListEnable = p_Reader.ReadBool();
			p_Instance.DrawNonStreamedListEnable = p_Reader.ReadBool();
			p_Instance.DefragEnable = p_Reader.ReadBool();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Instance.DumpLoadedList = p_Reader.ReadBool();
			p_Instance.UseConditionalStreaming = p_Reader.ReadBool();
		}

	}
}
