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
	[ContainerType(4, 108)]
	public class TextureStreamingSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float FadeMipmapTime { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float MipmapBias { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint MaxTextureSizeKb { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint MaxFrameTextureCreateCount { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MaxPendingLoadCount { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint MinMipmapCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint MaxMipmapCount { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint XenonFinalPoolSizeAdjustment { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint XenonRetailPoolSizeAdjustment { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public uint PoolHeadroomSize { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public uint OnDemandPoolSize { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public uint ListViewPageIndex { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public uint PoolSize { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public int ForceMipmap { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float PriorityThreshold { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public uint DefragFrameTransferLimit { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public uint MinTextureSize { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public uint MaxFrameTextureCreateSize { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public bool OnlyWantedInPool { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable]
		public bool DxImmutableUsageEnable { get; set; }

		[ContainerField(82), LayoutImmutable, Blittable]
		public bool MipmapsEnable { get; set; }

		[ContainerField(83), LayoutImmutable, Blittable]
		public bool UploadMipmapsEnable { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public bool TextureUpdateEnable { get; set; }

		[ContainerField(85), LayoutImmutable, Blittable]
		public bool AsyncCreatesEnable { get; set; }

		[ContainerField(86), LayoutImmutable, Blittable]
		public bool LoadMipmapsEnable { get; set; }

		[ContainerField(87), LayoutImmutable, Blittable]
		public bool ForceWantedEnable { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public bool UpdateEnable { get; set; }

		[ContainerField(89), LayoutImmutable, Blittable]
		public bool PoolEnable { get; set; }

		[ContainerField(90), LayoutImmutable, Blittable]
		public bool DefragEnable { get; set; }

		[ContainerField(91), LayoutImmutable, Blittable]
		public bool DefragTransfersEnable { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public bool ChunkLoadEnable { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable]
		public bool InstantUnloadingEnable { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable]
		public bool FadeMipmapsEnable { get; set; }

		[ContainerField(95), LayoutImmutable, Blittable]
		public bool DynamicLoadingEnable { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable]
		public bool DrawStatsEnable { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable]
		public bool DrawTextureGroupStatsEnable { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable]
		public bool DrawTextureFormatStatsEnable { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool DrawLoadingListEnable { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable]
		public bool DrawPriorityListEnable { get; set; }

		[ContainerField(102), LayoutImmutable, Blittable]
		public bool OverridePoolSize { get; set; }

		[ContainerField(103), LayoutImmutable, Blittable]
		public bool DumpLoadedList { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool UseConditionalStreaming { get; set; }

	}
}
