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

[ContainerType(8, 120)]
public class TextureStreamingSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public int ForceMipmap { get; set; } = -1;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint MinMipmapCount { get; set; } = 7;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint MaxMipmapCount { get; set; } = 15;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float MipmapBias { get; set; } = -0.500f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint MaxTextureSizeKb { get; set; } = 0;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float FadeMipmapTime { get; set; } = 0.500f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint MinTextureSize { get; set; } = 0;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint PoolSize { get; set; } = 5000;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint PoolHeadroomSize { get; set; } = 2000;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public uint OnDemandPoolSize { get; set; } = 2048;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint XenonFinalPoolSizeAdjustment { get; set; } = 0;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public uint XenonRetailPoolSizeAdjustment { get; set; } = 0;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint DefragFrameTransferLimit { get; set; } = 1500;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public uint MaxPendingLoadCount { get; set; } = 4;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public uint MaxPendingUnloadCount { get; set; } = 4;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public uint MaxFrameTextureCreateSize { get; set; } = 0;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public uint MaxFrameTextureCreateCount { get; set; } = 20;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float PriorityThreshold { get; set; } = 1.250f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public uint ListViewPageIndex { get; set; } = 0;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x5d), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
	public bool UpdateEnable { get; set; } = true;
	
	[ContainerField(0x5e), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
	public bool DynamicLoadingEnable { get; set; } = false;
	
	[ContainerField(0x5f), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
	public bool ChunkLoadEnable { get; set; } = true;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool InstantUnloadingEnable { get; set; } = false;
	
	[ContainerField(0x61), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
	public bool OnlyWantedInPool { get; set; } = true;
	
	[ContainerField(0x62), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
	public bool ForceWantedEnable { get; set; } = false;
	
	[ContainerField(0x63), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
	public bool AsyncCreatesEnable { get; set; } = false;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public bool LoadMipmapsEnable { get; set; } = true;
	
	[ContainerField(0x65), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
	public bool UploadMipmapsEnable { get; set; } = true;
	
	[ContainerField(0x66), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
	public bool UnloadInPlaceEnable { get; set; } = true;
	
	[ContainerField(0x67), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
	public bool TextureUpdateEnable { get; set; } = true;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool ImmutableUsageEnable { get; set; } = true;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public bool MipmapsEnable { get; set; } = true;
	
	[ContainerField(0x6a), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
	public bool FadeMipmapsEnable { get; set; } = false;
	
	[ContainerField(0x6b), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
	public bool OverridePoolSize { get; set; } = false;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool PoolEnable { get; set; } = true;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public bool DefragEnable { get; set; } = true;
	
	[ContainerField(0x6e), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
	public bool DefragTransfersEnable { get; set; } = true;
	
	[ContainerField(0x6f), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
	public bool DrawStatsEnable { get; set; } = false;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool DrawTextureGroupStatsEnable { get; set; } = false;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool DrawTextureFormatStatsEnable { get; set; } = false;
	
	[ContainerField(0x72), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
	public bool DrawLoadingListEnable { get; set; } = false;
	
	[ContainerField(0x73), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
	public bool DrawPriorityListEnable { get; set; } = false;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public bool DumpLoadedList { get; set; } = false;
	
	[ContainerField(0x75), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
	public bool UseConditionalStreaming { get; set; } = false;
	
	[ContainerField(0x76), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
	public bool EnableGen4aPoolSizeOverrideSupport { get; set; } = true;
	
	[ContainerField(0x77), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
	public bool EnableGen4bPoolSizeOverrideSupport { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ForceMipmap);
		p_Writer.Write(MinMipmapCount);
		p_Writer.Write(MaxMipmapCount);
		p_Writer.Write(MipmapBias);
		p_Writer.Write(MaxTextureSizeKb);
		p_Writer.Write(FadeMipmapTime);
		p_Writer.Write(MinTextureSize);
		p_Writer.Write(PoolSize);
		p_Writer.Write(PoolHeadroomSize);
		p_Writer.Write(OnDemandPoolSize);
		p_Writer.Write(XenonFinalPoolSizeAdjustment);
		p_Writer.Write(XenonRetailPoolSizeAdjustment);
		p_Writer.Write(DefragFrameTransferLimit);
		p_Writer.Write(MaxPendingLoadCount);
		p_Writer.Write(MaxPendingUnloadCount);
		p_Writer.Write(MaxFrameTextureCreateSize);
		p_Writer.Write(MaxFrameTextureCreateCount);
		p_Writer.Write(PriorityThreshold);
		p_Writer.Write(ListViewPageIndex);
		p_Writer.Write(Enable);
		p_Writer.Write(UpdateEnable);
		p_Writer.Write(DynamicLoadingEnable);
		p_Writer.Write(ChunkLoadEnable);
		p_Writer.Write(InstantUnloadingEnable);
		p_Writer.Write(OnlyWantedInPool);
		p_Writer.Write(ForceWantedEnable);
		p_Writer.Write(AsyncCreatesEnable);
		p_Writer.Write(LoadMipmapsEnable);
		p_Writer.Write(UploadMipmapsEnable);
		p_Writer.Write(UnloadInPlaceEnable);
		p_Writer.Write(TextureUpdateEnable);
		p_Writer.Write(ImmutableUsageEnable);
		p_Writer.Write(MipmapsEnable);
		p_Writer.Write(FadeMipmapsEnable);
		p_Writer.Write(OverridePoolSize);
		p_Writer.Write(PoolEnable);
		p_Writer.Write(DefragEnable);
		p_Writer.Write(DefragTransfersEnable);
		p_Writer.Write(DrawStatsEnable);
		p_Writer.Write(DrawTextureGroupStatsEnable);
		p_Writer.Write(DrawTextureFormatStatsEnable);
		p_Writer.Write(DrawLoadingListEnable);
		p_Writer.Write(DrawPriorityListEnable);
		p_Writer.Write(DumpLoadedList);
		p_Writer.Write(UseConditionalStreaming);
		p_Writer.Write(EnableGen4aPoolSizeOverrideSupport);
		p_Writer.Write(EnableGen4bPoolSizeOverrideSupport);
	}
}

