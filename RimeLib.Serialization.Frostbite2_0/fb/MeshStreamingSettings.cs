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

namespace fb
{
	[ContainerType(4, 88)]
	public class MeshStreamingSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint DefragTransferLimit { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint ListViewPageIndex { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint PoolSize { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public int ForceLod { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint PoolHeadroomSize { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint ListViewSortOrder { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint Ps3CellDefragTransferLimit { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint XenonFinalPoolSizeAdjustment { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public uint MaxUnloadCountPerFrame { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public uint XenonRetailPoolSizeAdjustment { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public uint MaxPendingLoadCount { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public uint Ps3CellPoolSize { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public uint Ps3CellPoolHeadroomSize { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool InstantUnloadingEnable { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		public bool AsyncCreatesEnable { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		public bool DxImmutableUsageEnable { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		public bool OverridePoolSizes { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public bool UseSlowTexturePrio { get; set; }

		[ContainerField(65), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
		public bool UpdateEnable { get; set; }

		[ContainerField(66), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
		public bool DynamicLoadingEnable { get; set; }

		[ContainerField(67), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
		public bool PriorityJobEnable { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool PrioritySpuJobEnable { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		public bool UpdateJobEnable { get; set; }

		[ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		public bool DefragTransfersEnable { get; set; }

		[ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		public bool PrioritizeVisibleMeshesFirstEnable { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public bool PrioritizeVisibleLodsFirstEnable { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		public bool PrioritizeVisibleLoadsEnable { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		public bool PrioritizeTexturesEnable { get; set; }

		[ContainerField(75), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
		public bool HighestPriorityEnable { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public bool PrioritizeNearestPointEnable { get; set; }

		[ContainerField(77), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
		public bool DrawInstanceBoxesEnable { get; set; }

		[ContainerField(78), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
		public bool DrawStatsEnable { get; set; }

		[ContainerField(79), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
		public bool DrawMissingListEnable { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public bool DrawPriorityListEnable { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		public bool DrawLoadingListEnable { get; set; }

		[ContainerField(82), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
		public bool DrawMeshListEnable { get; set; }

		[ContainerField(83), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
		public bool DrawNonStreamedListEnable { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public bool DefragEnable { get; set; }

		[ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		public bool Enable { get; set; }

		[ContainerField(86), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
		public bool DumpLoadedList { get; set; }

		[ContainerField(87), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
		public bool UseConditionalStreaming { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DefragTransferLimit);
			p_Writer.Write(ListViewPageIndex);
			p_Writer.Write(PoolSize);
			p_Writer.Write(ForceLod);
			p_Writer.Write(PoolHeadroomSize);
			p_Writer.Write(ListViewSortOrder);
			p_Writer.Write(Ps3CellDefragTransferLimit);
			p_Writer.Write(XenonFinalPoolSizeAdjustment);
			p_Writer.Write(MaxUnloadCountPerFrame);
			p_Writer.Write(XenonRetailPoolSizeAdjustment);
			p_Writer.Write(MaxPendingLoadCount);
			p_Writer.Write(Ps3CellPoolSize);
			p_Writer.Write(Ps3CellPoolHeadroomSize);
			p_Writer.Write(InstantUnloadingEnable);
			p_Writer.Write(AsyncCreatesEnable);
			p_Writer.Write(DxImmutableUsageEnable);
			p_Writer.Write(OverridePoolSizes);
			p_Writer.Write(UseSlowTexturePrio);
			p_Writer.Write(UpdateEnable);
			p_Writer.Write(DynamicLoadingEnable);
			p_Writer.Write(PriorityJobEnable);
			p_Writer.Write(PrioritySpuJobEnable);
			p_Writer.Write(UpdateJobEnable);
			p_Writer.Write(DefragTransfersEnable);
			p_Writer.Write(PrioritizeVisibleMeshesFirstEnable);
			p_Writer.Write(PrioritizeVisibleLodsFirstEnable);
			p_Writer.Write(PrioritizeVisibleLoadsEnable);
			p_Writer.Write(PrioritizeTexturesEnable);
			p_Writer.Write(HighestPriorityEnable);
			p_Writer.Write(PrioritizeNearestPointEnable);
			p_Writer.Write(DrawInstanceBoxesEnable);
			p_Writer.Write(DrawStatsEnable);
			p_Writer.Write(DrawMissingListEnable);
			p_Writer.Write(DrawPriorityListEnable);
			p_Writer.Write(DrawLoadingListEnable);
			p_Writer.Write(DrawMeshListEnable);
			p_Writer.Write(DrawNonStreamedListEnable);
			p_Writer.Write(DefragEnable);
			p_Writer.Write(Enable);
			p_Writer.Write(DumpLoadedList);
			p_Writer.Write(UseConditionalStreaming);
		}
	}
}
