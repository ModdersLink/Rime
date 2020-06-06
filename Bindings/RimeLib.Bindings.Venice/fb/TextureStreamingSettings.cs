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
	public class TextureStreamingSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float FadeMipmapTime { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MipmapBias { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint MaxTextureSizeKb { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint MaxFrameTextureCreateCount { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MaxPendingLoadCount { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint MinMipmapCount { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint MaxMipmapCount { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint XenonFinalPoolSizeAdjustment { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint XenonRetailPoolSizeAdjustment { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public uint PoolHeadroomSize { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public uint OnDemandPoolSize { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public uint ListViewPageIndex { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public uint PoolSize { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public int ForceMipmap { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float PriorityThreshold { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public uint DefragFrameTransferLimit { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public uint MinTextureSize { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public uint MaxFrameTextureCreateSize { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public bool OnlyWantedInPool { get; set; } // 0x50 (80)
		
		[ContainerField(81), LayoutImmutable, Blittable]
		public bool DxImmutableUsageEnable { get; set; } // 0x51 (81)
		
		[ContainerField(82), LayoutImmutable, Blittable]
		public bool MipmapsEnable { get; set; } // 0x52 (82)
		
		[ContainerField(83), LayoutImmutable, Blittable]
		public bool UploadMipmapsEnable { get; set; } // 0x53 (83)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public bool TextureUpdateEnable { get; set; } // 0x54 (84)
		
		[ContainerField(85), LayoutImmutable, Blittable]
		public bool AsyncCreatesEnable { get; set; } // 0x55 (85)
		
		[ContainerField(86), LayoutImmutable, Blittable]
		public bool LoadMipmapsEnable { get; set; } // 0x56 (86)
		
		[ContainerField(87), LayoutImmutable, Blittable]
		public bool ForceWantedEnable { get; set; } // 0x57 (87)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public bool UpdateEnable { get; set; } // 0x58 (88)
		
		[ContainerField(89), LayoutImmutable, Blittable]
		public bool PoolEnable { get; set; } // 0x59 (89)
		
		[ContainerField(90), LayoutImmutable, Blittable]
		public bool DefragEnable { get; set; } // 0x5A (90)
		
		[ContainerField(91), LayoutImmutable, Blittable]
		public bool DefragTransfersEnable { get; set; } // 0x5B (91)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public bool ChunkLoadEnable { get; set; } // 0x5C (92)
		
		[ContainerField(93), LayoutImmutable, Blittable]
		public bool InstantUnloadingEnable { get; set; } // 0x5D (93)
		
		[ContainerField(94), LayoutImmutable, Blittable]
		public bool FadeMipmapsEnable { get; set; } // 0x5E (94)
		
		[ContainerField(95), LayoutImmutable, Blittable]
		public bool DynamicLoadingEnable { get; set; } // 0x5F (95)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x60 (96)
		
		[ContainerField(97), LayoutImmutable, Blittable]
		public bool DrawStatsEnable { get; set; } // 0x61 (97)
		
		[ContainerField(98), LayoutImmutable, Blittable]
		public bool DrawTextureGroupStatsEnable { get; set; } // 0x62 (98)
		
		[ContainerField(99), LayoutImmutable, Blittable]
		public bool DrawTextureFormatStatsEnable { get; set; } // 0x63 (99)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public bool DrawLoadingListEnable { get; set; } // 0x64 (100)
		
		[ContainerField(101), LayoutImmutable, Blittable]
		public bool DrawPriorityListEnable { get; set; } // 0x65 (101)
		
		[ContainerField(102), LayoutImmutable, Blittable]
		public bool OverridePoolSize { get; set; } // 0x66 (102)
		
		[ContainerField(103), LayoutImmutable, Blittable]
		public bool DumpLoadedList { get; set; } // 0x67 (103)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool UseConditionalStreaming { get; set; } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1423865630:
					FadeMipmapTime = (float) p_Value;
					break;

				case 196267572:
					MipmapBias = (float) p_Value;
					break;

				case 4282010818:
					MaxTextureSizeKb = (uint) p_Value;
					break;

				case 3751103508:
					MaxFrameTextureCreateCount = (uint) p_Value;
					break;

				case 4194764075:
					MaxPendingLoadCount = (uint) p_Value;
					break;

				case 591426852:
					MinMipmapCount = (uint) p_Value;
					break;

				case 1664310522:
					MaxMipmapCount = (uint) p_Value;
					break;

				case 842975117:
					XenonFinalPoolSizeAdjustment = (uint) p_Value;
					break;

				case 1487508902:
					XenonRetailPoolSizeAdjustment = (uint) p_Value;
					break;

				case 1426093803:
					PoolHeadroomSize = (uint) p_Value;
					break;

				case 4216286938:
					OnDemandPoolSize = (uint) p_Value;
					break;

				case 1203229703:
					ListViewPageIndex = (uint) p_Value;
					break;

				case 3885339292:
					PoolSize = (uint) p_Value;
					break;

				case 110383696:
					ForceMipmap = (int) p_Value;
					break;

				case 1199765120:
					PriorityThreshold = (float) p_Value;
					break;

				case 2853798261:
					DefragFrameTransferLimit = (uint) p_Value;
					break;

				case 2473279061:
					MinTextureSize = (uint) p_Value;
					break;

				case 2716103826:
					MaxFrameTextureCreateSize = (uint) p_Value;
					break;

				case 1706087527:
					OnlyWantedInPool = (bool) p_Value;
					break;

				case 2665891903:
					DxImmutableUsageEnable = (bool) p_Value;
					break;

				case 2827470175:
					MipmapsEnable = (bool) p_Value;
					break;

				case 1826880860:
					UploadMipmapsEnable = (bool) p_Value;
					break;

				case 2198109482:
					TextureUpdateEnable = (bool) p_Value;
					break;

				case 2241018389:
					AsyncCreatesEnable = (bool) p_Value;
					break;

				case 403460441:
					LoadMipmapsEnable = (bool) p_Value;
					break;

				case 4278311412:
					ForceWantedEnable = (bool) p_Value;
					break;

				case 3724816309:
					UpdateEnable = (bool) p_Value;
					break;

				case 1137936504:
					PoolEnable = (bool) p_Value;
					break;

				case 485927863:
					DefragEnable = (bool) p_Value;
					break;

				case 539744815:
					DefragTransfersEnable = (bool) p_Value;
					break;

				case 1805392921:
					ChunkLoadEnable = (bool) p_Value;
					break;

				case 329282338:
					InstantUnloadingEnable = (bool) p_Value;
					break;

				case 4120232697:
					FadeMipmapsEnable = (bool) p_Value;
					break;

				case 677951191:
					DynamicLoadingEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 711726149:
					DrawStatsEnable = (bool) p_Value;
					break;

				case 1301826533:
					DrawTextureGroupStatsEnable = (bool) p_Value;
					break;

				case 781840665:
					DrawTextureFormatStatsEnable = (bool) p_Value;
					break;

				case 2993570912:
					DrawLoadingListEnable = (bool) p_Value;
					break;

				case 2687194932:
					DrawPriorityListEnable = (bool) p_Value;
					break;

				case 3027039592:
					OverridePoolSize = (bool) p_Value;
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
				case 1423865630:
					return FadeMipmapTime;

				case 196267572:
					return MipmapBias;

				case 4282010818:
					return MaxTextureSizeKb;

				case 3751103508:
					return MaxFrameTextureCreateCount;

				case 4194764075:
					return MaxPendingLoadCount;

				case 591426852:
					return MinMipmapCount;

				case 1664310522:
					return MaxMipmapCount;

				case 842975117:
					return XenonFinalPoolSizeAdjustment;

				case 1487508902:
					return XenonRetailPoolSizeAdjustment;

				case 1426093803:
					return PoolHeadroomSize;

				case 4216286938:
					return OnDemandPoolSize;

				case 1203229703:
					return ListViewPageIndex;

				case 3885339292:
					return PoolSize;

				case 110383696:
					return ForceMipmap;

				case 1199765120:
					return PriorityThreshold;

				case 2853798261:
					return DefragFrameTransferLimit;

				case 2473279061:
					return MinTextureSize;

				case 2716103826:
					return MaxFrameTextureCreateSize;

				case 1706087527:
					return OnlyWantedInPool;

				case 2665891903:
					return DxImmutableUsageEnable;

				case 2827470175:
					return MipmapsEnable;

				case 1826880860:
					return UploadMipmapsEnable;

				case 2198109482:
					return TextureUpdateEnable;

				case 2241018389:
					return AsyncCreatesEnable;

				case 403460441:
					return LoadMipmapsEnable;

				case 4278311412:
					return ForceWantedEnable;

				case 3724816309:
					return UpdateEnable;

				case 1137936504:
					return PoolEnable;

				case 485927863:
					return DefragEnable;

				case 539744815:
					return DefragTransfersEnable;

				case 1805392921:
					return ChunkLoadEnable;

				case 329282338:
					return InstantUnloadingEnable;

				case 4120232697:
					return FadeMipmapsEnable;

				case 677951191:
					return DynamicLoadingEnable;

				case 2342790116:
					return Enable;

				case 711726149:
					return DrawStatsEnable;

				case 1301826533:
					return DrawTextureGroupStatsEnable;

				case 781840665:
					return DrawTextureFormatStatsEnable;

				case 2993570912:
					return DrawLoadingListEnable;

				case 2687194932:
					return DrawPriorityListEnable;

				case 3027039592:
					return OverridePoolSize;

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
				case 1423865630:
					return typeof(TextureStreamingSettings).GetProperty(nameof(FadeMipmapTime));

				case 196267572:
					return typeof(TextureStreamingSettings).GetProperty(nameof(MipmapBias));

				case 4282010818:
					return typeof(TextureStreamingSettings).GetProperty(nameof(MaxTextureSizeKb));

				case 3751103508:
					return typeof(TextureStreamingSettings).GetProperty(nameof(MaxFrameTextureCreateCount));

				case 4194764075:
					return typeof(TextureStreamingSettings).GetProperty(nameof(MaxPendingLoadCount));

				case 591426852:
					return typeof(TextureStreamingSettings).GetProperty(nameof(MinMipmapCount));

				case 1664310522:
					return typeof(TextureStreamingSettings).GetProperty(nameof(MaxMipmapCount));

				case 842975117:
					return typeof(TextureStreamingSettings).GetProperty(nameof(XenonFinalPoolSizeAdjustment));

				case 1487508902:
					return typeof(TextureStreamingSettings).GetProperty(nameof(XenonRetailPoolSizeAdjustment));

				case 1426093803:
					return typeof(TextureStreamingSettings).GetProperty(nameof(PoolHeadroomSize));

				case 4216286938:
					return typeof(TextureStreamingSettings).GetProperty(nameof(OnDemandPoolSize));

				case 1203229703:
					return typeof(TextureStreamingSettings).GetProperty(nameof(ListViewPageIndex));

				case 3885339292:
					return typeof(TextureStreamingSettings).GetProperty(nameof(PoolSize));

				case 110383696:
					return typeof(TextureStreamingSettings).GetProperty(nameof(ForceMipmap));

				case 1199765120:
					return typeof(TextureStreamingSettings).GetProperty(nameof(PriorityThreshold));

				case 2853798261:
					return typeof(TextureStreamingSettings).GetProperty(nameof(DefragFrameTransferLimit));

				case 2473279061:
					return typeof(TextureStreamingSettings).GetProperty(nameof(MinTextureSize));

				case 2716103826:
					return typeof(TextureStreamingSettings).GetProperty(nameof(MaxFrameTextureCreateSize));

				case 1706087527:
					return typeof(TextureStreamingSettings).GetProperty(nameof(OnlyWantedInPool));

				case 2665891903:
					return typeof(TextureStreamingSettings).GetProperty(nameof(DxImmutableUsageEnable));

				case 2827470175:
					return typeof(TextureStreamingSettings).GetProperty(nameof(MipmapsEnable));

				case 1826880860:
					return typeof(TextureStreamingSettings).GetProperty(nameof(UploadMipmapsEnable));

				case 2198109482:
					return typeof(TextureStreamingSettings).GetProperty(nameof(TextureUpdateEnable));

				case 2241018389:
					return typeof(TextureStreamingSettings).GetProperty(nameof(AsyncCreatesEnable));

				case 403460441:
					return typeof(TextureStreamingSettings).GetProperty(nameof(LoadMipmapsEnable));

				case 4278311412:
					return typeof(TextureStreamingSettings).GetProperty(nameof(ForceWantedEnable));

				case 3724816309:
					return typeof(TextureStreamingSettings).GetProperty(nameof(UpdateEnable));

				case 1137936504:
					return typeof(TextureStreamingSettings).GetProperty(nameof(PoolEnable));

				case 485927863:
					return typeof(TextureStreamingSettings).GetProperty(nameof(DefragEnable));

				case 539744815:
					return typeof(TextureStreamingSettings).GetProperty(nameof(DefragTransfersEnable));

				case 1805392921:
					return typeof(TextureStreamingSettings).GetProperty(nameof(ChunkLoadEnable));

				case 329282338:
					return typeof(TextureStreamingSettings).GetProperty(nameof(InstantUnloadingEnable));

				case 4120232697:
					return typeof(TextureStreamingSettings).GetProperty(nameof(FadeMipmapsEnable));

				case 677951191:
					return typeof(TextureStreamingSettings).GetProperty(nameof(DynamicLoadingEnable));

				case 2342790116:
					return typeof(TextureStreamingSettings).GetProperty(nameof(Enable));

				case 711726149:
					return typeof(TextureStreamingSettings).GetProperty(nameof(DrawStatsEnable));

				case 1301826533:
					return typeof(TextureStreamingSettings).GetProperty(nameof(DrawTextureGroupStatsEnable));

				case 781840665:
					return typeof(TextureStreamingSettings).GetProperty(nameof(DrawTextureFormatStatsEnable));

				case 2993570912:
					return typeof(TextureStreamingSettings).GetProperty(nameof(DrawLoadingListEnable));

				case 2687194932:
					return typeof(TextureStreamingSettings).GetProperty(nameof(DrawPriorityListEnable));

				case 3027039592:
					return typeof(TextureStreamingSettings).GetProperty(nameof(OverridePoolSize));

				case 3865360236:
					return typeof(TextureStreamingSettings).GetProperty(nameof(DumpLoadedList));

				case 3302650340:
					return typeof(TextureStreamingSettings).GetProperty(nameof(UseConditionalStreaming));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
