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

using fb.Core;

namespace fb.Render;

[ContainerType(8, 112)]
public class MeshStreamingSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint MaxUnloadCountPerFrame { get; set; } = 0;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint PoolSize { get; set; } = 100000;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint PoolHeadroomSize { get; set; } = 1500;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public uint Ps3CellPoolSize { get; set; } = 3200;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint Ps3CellPoolHeadroomSize { get; set; } = 400;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint XenonFinalPoolSizeAdjustment { get; set; } = 0;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint XenonRetailPoolSizeAdjustment { get; set; } = 0;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint DefragTransferLimit { get; set; } = 1000;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint Ps3CellDefragTransferLimit { get; set; } = 250;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int ForceLod { get; set; } = -1;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint MaxPendingLoadCount { get; set; } = 4;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float DistanceMin { get; set; } = 0.100f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint ListViewPageIndex { get; set; } = 0;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public uint ListViewSortOrder { get; set; } = 2;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public uint ReservedPositionedInstanceCount { get; set; } = 12288;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public uint ReservedDistancedInstanceCount { get; set; } = 128;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool UpdateEnable { get; set; } = true;
	
	[ContainerField(0x52), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
	public bool UpdateJobEnable { get; set; } = true;
	
	[ContainerField(0x53), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
	public bool PriorityJobEnable { get; set; } = true;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool PrioritySpuJobEnable { get; set; } = true;
	
	[ContainerField(0x55), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
	public bool UseSlowTexturePrio { get; set; } = false;
	
	[ContainerField(0x56), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
	public bool DynamicLoadingEnable { get; set; } = false;
	
	[ContainerField(0x57), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
	public bool InstantUnloadingEnable { get; set; } = false;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public bool AsyncCreatesEnable { get; set; } = true;
	
	[ContainerField(0x59), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
	public bool DxImmutableUsageEnable { get; set; } = true;
	
	[ContainerField(0x5a), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
	public bool OverridePoolSizes { get; set; } = false;
	
	[ContainerField(0x5b), LayoutImmutable, Blittable, JsonProperty(Order = 91)]
	public bool DefragEnable { get; set; } = true;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool DefragTransfersEnable { get; set; } = true;
	
	[ContainerField(0x5d), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
	public bool PrioritizeVisibleMeshesFirstEnable { get; set; } = false;
	
	[ContainerField(0x5e), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
	public bool PrioritizeVisibleLodsFirstEnable { get; set; } = false;
	
	[ContainerField(0x5f), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
	public bool PrioritizeVisibleLoadsEnable { get; set; } = true;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool PrioritizeTexturesEnable { get; set; } = true;
	
	[ContainerField(0x61), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
	public bool HighestPriorityEnable { get; set; } = true;
	
	[ContainerField(0x62), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
	public bool PrioritizeNearestPointEnable { get; set; } = true;
	
	[ContainerField(0x63), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
	public bool DrawInstanceBoxesEnable { get; set; } = false;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public bool DrawStatsEnable { get; set; } = false;
	
	[ContainerField(0x65), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
	public bool DrawMissingListEnable { get; set; } = false;
	
	[ContainerField(0x66), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
	public bool DrawPriorityListEnable { get; set; } = false;
	
	[ContainerField(0x67), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
	public bool DrawLoadingListEnable { get; set; } = false;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool DrawMeshListEnable { get; set; } = false;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public bool DrawNonStreamedListEnable { get; set; } = false;
	
	[ContainerField(0x6a), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
	public bool DumpLoadedList { get; set; } = false;
	
	[ContainerField(0x6b), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
	public bool UseConditionalStreaming { get; set; } = false;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool EnablePcPoolSizeOverrideSupport { get; set; } = true;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public bool EnableGen4aPoolSizeOverrideSupport { get; set; } = true;
	
	[ContainerField(0x6e), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
	public bool EnableGen4bPoolSizeOverrideSupport { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxUnloadCountPerFrame);
		p_Writer.Write(PoolSize);
		p_Writer.Write(PoolHeadroomSize);
		p_Writer.Write(Ps3CellPoolSize);
		p_Writer.Write(Ps3CellPoolHeadroomSize);
		p_Writer.Write(XenonFinalPoolSizeAdjustment);
		p_Writer.Write(XenonRetailPoolSizeAdjustment);
		p_Writer.Write(DefragTransferLimit);
		p_Writer.Write(Ps3CellDefragTransferLimit);
		p_Writer.Write(ForceLod);
		p_Writer.Write(MaxPendingLoadCount);
		p_Writer.Write(DistanceMin);
		p_Writer.Write(ListViewPageIndex);
		p_Writer.Write(ListViewSortOrder);
		p_Writer.Write(ReservedPositionedInstanceCount);
		p_Writer.Write(ReservedDistancedInstanceCount);
		p_Writer.Write(Enable);
		p_Writer.Write(UpdateEnable);
		p_Writer.Write(UpdateJobEnable);
		p_Writer.Write(PriorityJobEnable);
		p_Writer.Write(PrioritySpuJobEnable);
		p_Writer.Write(UseSlowTexturePrio);
		p_Writer.Write(DynamicLoadingEnable);
		p_Writer.Write(InstantUnloadingEnable);
		p_Writer.Write(AsyncCreatesEnable);
		p_Writer.Write(DxImmutableUsageEnable);
		p_Writer.Write(OverridePoolSizes);
		p_Writer.Write(DefragEnable);
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
		p_Writer.Write(DumpLoadedList);
		p_Writer.Write(UseConditionalStreaming);
		p_Writer.Write(EnablePcPoolSizeOverrideSupport);
		p_Writer.Write(EnableGen4aPoolSizeOverrideSupport);
		p_Writer.Write(EnableGen4bPoolSizeOverrideSupport);
		p_Writer.WriteNullBytes(1);
	}
}

