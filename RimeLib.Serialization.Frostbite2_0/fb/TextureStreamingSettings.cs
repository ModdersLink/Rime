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
	[ContainerType(4, 108)]
	public partial class TextureStreamingSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _FadeMipmapTime;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _MipmapBias;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _MaxTextureSizeKb;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _MaxFrameTextureCreateCount;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _MaxPendingLoadCount;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _MinMipmapCount;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _MaxMipmapCount;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _XenonFinalPoolSizeAdjustment;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private uint _XenonRetailPoolSizeAdjustment;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private uint _PoolHeadroomSize;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private uint _OnDemandPoolSize;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private uint _ListViewPageIndex;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private uint _PoolSize;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private int _ForceMipmap;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _PriorityThreshold;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private uint _DefragFrameTransferLimit;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private uint _MinTextureSize;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private uint _MaxFrameTextureCreateSize;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private bool _OnlyWantedInPool;

		[ObservableProperty]
		[property: ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		private bool _DxImmutableUsageEnable;

		[ObservableProperty]
		[property: ContainerField(82), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
		private bool _MipmapsEnable;

		[ObservableProperty]
		[property: ContainerField(83), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
		private bool _UploadMipmapsEnable;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private bool _TextureUpdateEnable;

		[ObservableProperty]
		[property: ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		private bool _AsyncCreatesEnable;

		[ObservableProperty]
		[property: ContainerField(86), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
		private bool _LoadMipmapsEnable;

		[ObservableProperty]
		[property: ContainerField(87), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
		private bool _ForceWantedEnable;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private bool _UpdateEnable;

		[ObservableProperty]
		[property: ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		private bool _PoolEnable;

		[ObservableProperty]
		[property: ContainerField(90), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
		private bool _DefragEnable;

		[ObservableProperty]
		[property: ContainerField(91), LayoutImmutable, Blittable, JsonProperty(Order = 91)]
		private bool _DefragTransfersEnable;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private bool _ChunkLoadEnable;

		[ObservableProperty]
		[property: ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		private bool _InstantUnloadingEnable;

		[ObservableProperty]
		[property: ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		private bool _FadeMipmapsEnable;

		[ObservableProperty]
		[property: ContainerField(95), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
		private bool _DynamicLoadingEnable;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		private bool _DrawStatsEnable;

		[ObservableProperty]
		[property: ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		private bool _DrawTextureGroupStatsEnable;

		[ObservableProperty]
		[property: ContainerField(99), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
		private bool _DrawTextureFormatStatsEnable;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private bool _DrawLoadingListEnable;

		[ObservableProperty]
		[property: ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		private bool _DrawPriorityListEnable;

		[ObservableProperty]
		[property: ContainerField(102), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
		private bool _OverridePoolSize;

		[ObservableProperty]
		[property: ContainerField(103), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
		private bool _DumpLoadedList;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private bool _UseConditionalStreaming;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
