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
	[ContainerType(4, 88)]
	public partial class MeshStreamingSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private uint _DefragTransferLimit;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _ListViewPageIndex;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _PoolSize;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private int _ForceLod;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _PoolHeadroomSize;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _ListViewSortOrder;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _Ps3CellDefragTransferLimit;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _XenonFinalPoolSizeAdjustment;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private uint _MaxUnloadCountPerFrame;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private uint _XenonRetailPoolSizeAdjustment;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private uint _MaxPendingLoadCount;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private uint _Ps3CellPoolSize;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private uint _Ps3CellPoolHeadroomSize;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private bool _InstantUnloadingEnable;

		[ObservableProperty]
		[property: ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		private bool _AsyncCreatesEnable;

		[ObservableProperty]
		[property: ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		private bool _DxImmutableUsageEnable;

		[ObservableProperty]
		[property: ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		private bool _OverridePoolSizes;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private bool _UseSlowTexturePrio;

		[ObservableProperty]
		[property: ContainerField(65), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
		private bool _UpdateEnable;

		[ObservableProperty]
		[property: ContainerField(66), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
		private bool _DynamicLoadingEnable;

		[ObservableProperty]
		[property: ContainerField(67), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
		private bool _PriorityJobEnable;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private bool _PrioritySpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		private bool _UpdateJobEnable;

		[ObservableProperty]
		[property: ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		private bool _DefragTransfersEnable;

		[ObservableProperty]
		[property: ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		private bool _PrioritizeVisibleMeshesFirstEnable;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private bool _PrioritizeVisibleLodsFirstEnable;

		[ObservableProperty]
		[property: ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		private bool _PrioritizeVisibleLoadsEnable;

		[ObservableProperty]
		[property: ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		private bool _PrioritizeTexturesEnable;

		[ObservableProperty]
		[property: ContainerField(75), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
		private bool _HighestPriorityEnable;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private bool _PrioritizeNearestPointEnable;

		[ObservableProperty]
		[property: ContainerField(77), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
		private bool _DrawInstanceBoxesEnable;

		[ObservableProperty]
		[property: ContainerField(78), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
		private bool _DrawStatsEnable;

		[ObservableProperty]
		[property: ContainerField(79), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
		private bool _DrawMissingListEnable;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private bool _DrawPriorityListEnable;

		[ObservableProperty]
		[property: ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		private bool _DrawLoadingListEnable;

		[ObservableProperty]
		[property: ContainerField(82), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
		private bool _DrawMeshListEnable;

		[ObservableProperty]
		[property: ContainerField(83), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
		private bool _DrawNonStreamedListEnable;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private bool _DefragEnable;

		[ObservableProperty]
		[property: ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(86), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
		private bool _DumpLoadedList;

		[ObservableProperty]
		[property: ContainerField(87), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
		private bool _UseConditionalStreaming;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
