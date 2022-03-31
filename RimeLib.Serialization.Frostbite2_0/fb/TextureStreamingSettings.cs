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
	[ContainerType(4, 108)]
	public class TextureStreamingSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float FadeMipmapTime { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float MipmapBias { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint MaxTextureSizeKb { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint MaxFrameTextureCreateCount { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint MaxPendingLoadCount { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint MinMipmapCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint MaxMipmapCount { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint XenonFinalPoolSizeAdjustment { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public uint XenonRetailPoolSizeAdjustment { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public uint PoolHeadroomSize { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public uint OnDemandPoolSize { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public uint ListViewPageIndex { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public uint PoolSize { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public int ForceMipmap { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float PriorityThreshold { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public uint DefragFrameTransferLimit { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public uint MinTextureSize { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public uint MaxFrameTextureCreateSize { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public bool OnlyWantedInPool { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		public bool DxImmutableUsageEnable { get; set; }

		[ContainerField(82), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
		public bool MipmapsEnable { get; set; }

		[ContainerField(83), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
		public bool UploadMipmapsEnable { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public bool TextureUpdateEnable { get; set; }

		[ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		public bool AsyncCreatesEnable { get; set; }

		[ContainerField(86), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
		public bool LoadMipmapsEnable { get; set; }

		[ContainerField(87), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
		public bool ForceWantedEnable { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public bool UpdateEnable { get; set; }

		[ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		public bool PoolEnable { get; set; }

		[ContainerField(90), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
		public bool DefragEnable { get; set; }

		[ContainerField(91), LayoutImmutable, Blittable, JsonProperty(Order = 91)]
		public bool DefragTransfersEnable { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public bool ChunkLoadEnable { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		public bool InstantUnloadingEnable { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		public bool FadeMipmapsEnable { get; set; }

		[ContainerField(95), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
		public bool DynamicLoadingEnable { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool Enable { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		public bool DrawStatsEnable { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		public bool DrawTextureGroupStatsEnable { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
		public bool DrawTextureFormatStatsEnable { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public bool DrawLoadingListEnable { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		public bool DrawPriorityListEnable { get; set; }

		[ContainerField(102), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
		public bool OverridePoolSize { get; set; }

		[ContainerField(103), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
		public bool DumpLoadedList { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public bool UseConditionalStreaming { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FadeMipmapTime);
			p_Writer.Write(MipmapBias);
			p_Writer.Write(MaxTextureSizeKb);
			p_Writer.Write(MaxFrameTextureCreateCount);
			p_Writer.Write(MaxPendingLoadCount);
			p_Writer.Write(MinMipmapCount);
			p_Writer.Write(MaxMipmapCount);
			p_Writer.Write(XenonFinalPoolSizeAdjustment);
			p_Writer.Write(XenonRetailPoolSizeAdjustment);
			p_Writer.Write(PoolHeadroomSize);
			p_Writer.Write(OnDemandPoolSize);
			p_Writer.Write(ListViewPageIndex);
			p_Writer.Write(PoolSize);
			p_Writer.Write(ForceMipmap);
			p_Writer.Write(PriorityThreshold);
			p_Writer.Write(DefragFrameTransferLimit);
			p_Writer.Write(MinTextureSize);
			p_Writer.Write(MaxFrameTextureCreateSize);
			p_Writer.Write(OnlyWantedInPool);
			p_Writer.Write(DxImmutableUsageEnable);
			p_Writer.Write(MipmapsEnable);
			p_Writer.Write(UploadMipmapsEnable);
			p_Writer.Write(TextureUpdateEnable);
			p_Writer.Write(AsyncCreatesEnable);
			p_Writer.Write(LoadMipmapsEnable);
			p_Writer.Write(ForceWantedEnable);
			p_Writer.Write(UpdateEnable);
			p_Writer.Write(PoolEnable);
			p_Writer.Write(DefragEnable);
			p_Writer.Write(DefragTransfersEnable);
			p_Writer.Write(ChunkLoadEnable);
			p_Writer.Write(InstantUnloadingEnable);
			p_Writer.Write(FadeMipmapsEnable);
			p_Writer.Write(DynamicLoadingEnable);
			p_Writer.Write(Enable);
			p_Writer.Write(DrawStatsEnable);
			p_Writer.Write(DrawTextureGroupStatsEnable);
			p_Writer.Write(DrawTextureFormatStatsEnable);
			p_Writer.Write(DrawLoadingListEnable);
			p_Writer.Write(DrawPriorityListEnable);
			p_Writer.Write(OverridePoolSize);
			p_Writer.Write(DumpLoadedList);
			p_Writer.Write(UseConditionalStreaming);
			p_Writer.WriteNullBytes(3);
		}
	}
}
