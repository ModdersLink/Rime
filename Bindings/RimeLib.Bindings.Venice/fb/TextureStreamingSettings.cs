///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 108)]
	public class TextureStreamingSettings : 
		DataContainer
	{
		protected float m_FadeMipmapTime = new float();
		[ContainerField(Name: "FadeMipmapTime", Offset: 8, NameHash: 1423865630, Flags: 49469), LayoutImmutable, Blittable]
		public float FadeMipmapTime { get { return m_FadeMipmapTime; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(FadeMipmapTime), this, m_FadeMipmapTime, value)) m_FadeMipmapTime = value; } } // 0x8 (8)
		
		protected float m_MipmapBias = new float();
		[ContainerField(Name: "MipmapBias", Offset: 12, NameHash: 196267572, Flags: 49469), LayoutImmutable, Blittable]
		public float MipmapBias { get { return m_MipmapBias; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(MipmapBias), this, m_MipmapBias, value)) m_MipmapBias = value; } } // 0xC (12)
		
		protected uint m_MaxTextureSizeKb = new uint();
		[ContainerField(Name: "MaxTextureSizeKb", Offset: 16, NameHash: 4282010818, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxTextureSizeKb { get { return m_MaxTextureSizeKb; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(MaxTextureSizeKb), this, m_MaxTextureSizeKb, value)) m_MaxTextureSizeKb = value; } } // 0x10 (16)
		
		protected uint m_MaxFrameTextureCreateCount = new uint();
		[ContainerField(Name: "MaxFrameTextureCreateCount", Offset: 20, NameHash: 3751103508, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxFrameTextureCreateCount { get { return m_MaxFrameTextureCreateCount; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(MaxFrameTextureCreateCount), this, m_MaxFrameTextureCreateCount, value)) m_MaxFrameTextureCreateCount = value; } } // 0x14 (20)
		
		protected uint m_MaxPendingLoadCount = new uint();
		[ContainerField(Name: "MaxPendingLoadCount", Offset: 24, NameHash: 4194764075, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxPendingLoadCount { get { return m_MaxPendingLoadCount; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(MaxPendingLoadCount), this, m_MaxPendingLoadCount, value)) m_MaxPendingLoadCount = value; } } // 0x18 (24)
		
		protected uint m_MinMipmapCount = new uint();
		[ContainerField(Name: "MinMipmapCount", Offset: 28, NameHash: 591426852, Flags: 49421), LayoutImmutable, Blittable]
		public uint MinMipmapCount { get { return m_MinMipmapCount; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(MinMipmapCount), this, m_MinMipmapCount, value)) m_MinMipmapCount = value; } } // 0x1C (28)
		
		protected uint m_MaxMipmapCount = new uint();
		[ContainerField(Name: "MaxMipmapCount", Offset: 32, NameHash: 1664310522, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxMipmapCount { get { return m_MaxMipmapCount; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(MaxMipmapCount), this, m_MaxMipmapCount, value)) m_MaxMipmapCount = value; } } // 0x20 (32)
		
		protected uint m_XenonFinalPoolSizeAdjustment = new uint();
		[ContainerField(Name: "XenonFinalPoolSizeAdjustment", Offset: 36, NameHash: 842975117, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonFinalPoolSizeAdjustment { get { return m_XenonFinalPoolSizeAdjustment; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(XenonFinalPoolSizeAdjustment), this, m_XenonFinalPoolSizeAdjustment, value)) m_XenonFinalPoolSizeAdjustment = value; } } // 0x24 (36)
		
		protected uint m_XenonRetailPoolSizeAdjustment = new uint();
		[ContainerField(Name: "XenonRetailPoolSizeAdjustment", Offset: 40, NameHash: 1487508902, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonRetailPoolSizeAdjustment { get { return m_XenonRetailPoolSizeAdjustment; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(XenonRetailPoolSizeAdjustment), this, m_XenonRetailPoolSizeAdjustment, value)) m_XenonRetailPoolSizeAdjustment = value; } } // 0x28 (40)
		
		protected uint m_PoolHeadroomSize = new uint();
		[ContainerField(Name: "PoolHeadroomSize", Offset: 44, NameHash: 1426093803, Flags: 49421), LayoutImmutable, Blittable]
		public uint PoolHeadroomSize { get { return m_PoolHeadroomSize; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(PoolHeadroomSize), this, m_PoolHeadroomSize, value)) m_PoolHeadroomSize = value; } } // 0x2C (44)
		
		protected uint m_OnDemandPoolSize = new uint();
		[ContainerField(Name: "OnDemandPoolSize", Offset: 48, NameHash: 4216286938, Flags: 49421), LayoutImmutable, Blittable]
		public uint OnDemandPoolSize { get { return m_OnDemandPoolSize; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(OnDemandPoolSize), this, m_OnDemandPoolSize, value)) m_OnDemandPoolSize = value; } } // 0x30 (48)
		
		protected uint m_ListViewPageIndex = new uint();
		[ContainerField(Name: "ListViewPageIndex", Offset: 52, NameHash: 1203229703, Flags: 49421), LayoutImmutable, Blittable]
		public uint ListViewPageIndex { get { return m_ListViewPageIndex; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(ListViewPageIndex), this, m_ListViewPageIndex, value)) m_ListViewPageIndex = value; } } // 0x34 (52)
		
		protected uint m_PoolSize = new uint();
		[ContainerField(Name: "PoolSize", Offset: 56, NameHash: 3885339292, Flags: 49421), LayoutImmutable, Blittable]
		public uint PoolSize { get { return m_PoolSize; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(PoolSize), this, m_PoolSize, value)) m_PoolSize = value; } } // 0x38 (56)
		
		protected int m_ForceMipmap = new int();
		[ContainerField(Name: "ForceMipmap", Offset: 60, NameHash: 110383696, Flags: 49405), LayoutImmutable, Blittable]
		public int ForceMipmap { get { return m_ForceMipmap; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(ForceMipmap), this, m_ForceMipmap, value)) m_ForceMipmap = value; } } // 0x3C (60)
		
		protected float m_PriorityThreshold = new float();
		[ContainerField(Name: "PriorityThreshold", Offset: 64, NameHash: 1199765120, Flags: 49469), LayoutImmutable, Blittable]
		public float PriorityThreshold { get { return m_PriorityThreshold; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(PriorityThreshold), this, m_PriorityThreshold, value)) m_PriorityThreshold = value; } } // 0x40 (64)
		
		protected uint m_DefragFrameTransferLimit = new uint();
		[ContainerField(Name: "DefragFrameTransferLimit", Offset: 68, NameHash: 2853798261, Flags: 49421), LayoutImmutable, Blittable]
		public uint DefragFrameTransferLimit { get { return m_DefragFrameTransferLimit; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(DefragFrameTransferLimit), this, m_DefragFrameTransferLimit, value)) m_DefragFrameTransferLimit = value; } } // 0x44 (68)
		
		protected uint m_MinTextureSize = new uint();
		[ContainerField(Name: "MinTextureSize", Offset: 72, NameHash: 2473279061, Flags: 49421), LayoutImmutable, Blittable]
		public uint MinTextureSize { get { return m_MinTextureSize; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(MinTextureSize), this, m_MinTextureSize, value)) m_MinTextureSize = value; } } // 0x48 (72)
		
		protected uint m_MaxFrameTextureCreateSize = new uint();
		[ContainerField(Name: "MaxFrameTextureCreateSize", Offset: 76, NameHash: 2716103826, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxFrameTextureCreateSize { get { return m_MaxFrameTextureCreateSize; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(MaxFrameTextureCreateSize), this, m_MaxFrameTextureCreateSize, value)) m_MaxFrameTextureCreateSize = value; } } // 0x4C (76)
		
		protected bool m_OnlyWantedInPool = new bool();
		[ContainerField(Name: "OnlyWantedInPool", Offset: 80, NameHash: 1706087527, Flags: 49325), LayoutImmutable, Blittable]
		public bool OnlyWantedInPool { get { return m_OnlyWantedInPool; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(OnlyWantedInPool), this, m_OnlyWantedInPool, value)) m_OnlyWantedInPool = value; } } // 0x50 (80)
		
		protected bool m_DxImmutableUsageEnable = new bool();
		[ContainerField(Name: "DxImmutableUsageEnable", Offset: 81, NameHash: 2665891903, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxImmutableUsageEnable { get { return m_DxImmutableUsageEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(DxImmutableUsageEnable), this, m_DxImmutableUsageEnable, value)) m_DxImmutableUsageEnable = value; } } // 0x51 (81)
		
		protected bool m_MipmapsEnable = new bool();
		[ContainerField(Name: "MipmapsEnable", Offset: 82, NameHash: 2827470175, Flags: 49325), LayoutImmutable, Blittable]
		public bool MipmapsEnable { get { return m_MipmapsEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(MipmapsEnable), this, m_MipmapsEnable, value)) m_MipmapsEnable = value; } } // 0x52 (82)
		
		protected bool m_UploadMipmapsEnable = new bool();
		[ContainerField(Name: "UploadMipmapsEnable", Offset: 83, NameHash: 1826880860, Flags: 49325), LayoutImmutable, Blittable]
		public bool UploadMipmapsEnable { get { return m_UploadMipmapsEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(UploadMipmapsEnable), this, m_UploadMipmapsEnable, value)) m_UploadMipmapsEnable = value; } } // 0x53 (83)
		
		protected bool m_TextureUpdateEnable = new bool();
		[ContainerField(Name: "TextureUpdateEnable", Offset: 84, NameHash: 2198109482, Flags: 49325), LayoutImmutable, Blittable]
		public bool TextureUpdateEnable { get { return m_TextureUpdateEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(TextureUpdateEnable), this, m_TextureUpdateEnable, value)) m_TextureUpdateEnable = value; } } // 0x54 (84)
		
		protected bool m_AsyncCreatesEnable = new bool();
		[ContainerField(Name: "AsyncCreatesEnable", Offset: 85, NameHash: 2241018389, Flags: 49325), LayoutImmutable, Blittable]
		public bool AsyncCreatesEnable { get { return m_AsyncCreatesEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(AsyncCreatesEnable), this, m_AsyncCreatesEnable, value)) m_AsyncCreatesEnable = value; } } // 0x55 (85)
		
		protected bool m_LoadMipmapsEnable = new bool();
		[ContainerField(Name: "LoadMipmapsEnable", Offset: 86, NameHash: 403460441, Flags: 49325), LayoutImmutable, Blittable]
		public bool LoadMipmapsEnable { get { return m_LoadMipmapsEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(LoadMipmapsEnable), this, m_LoadMipmapsEnable, value)) m_LoadMipmapsEnable = value; } } // 0x56 (86)
		
		protected bool m_ForceWantedEnable = new bool();
		[ContainerField(Name: "ForceWantedEnable", Offset: 87, NameHash: 4278311412, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceWantedEnable { get { return m_ForceWantedEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(ForceWantedEnable), this, m_ForceWantedEnable, value)) m_ForceWantedEnable = value; } } // 0x57 (87)
		
		protected bool m_UpdateEnable = new bool();
		[ContainerField(Name: "UpdateEnable", Offset: 88, NameHash: 3724816309, Flags: 49325), LayoutImmutable, Blittable]
		public bool UpdateEnable { get { return m_UpdateEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(UpdateEnable), this, m_UpdateEnable, value)) m_UpdateEnable = value; } } // 0x58 (88)
		
		protected bool m_PoolEnable = new bool();
		[ContainerField(Name: "PoolEnable", Offset: 89, NameHash: 1137936504, Flags: 49325), LayoutImmutable, Blittable]
		public bool PoolEnable { get { return m_PoolEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(PoolEnable), this, m_PoolEnable, value)) m_PoolEnable = value; } } // 0x59 (89)
		
		protected bool m_DefragEnable = new bool();
		[ContainerField(Name: "DefragEnable", Offset: 90, NameHash: 485927863, Flags: 49325), LayoutImmutable, Blittable]
		public bool DefragEnable { get { return m_DefragEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(DefragEnable), this, m_DefragEnable, value)) m_DefragEnable = value; } } // 0x5A (90)
		
		protected bool m_DefragTransfersEnable = new bool();
		[ContainerField(Name: "DefragTransfersEnable", Offset: 91, NameHash: 539744815, Flags: 49325), LayoutImmutable, Blittable]
		public bool DefragTransfersEnable { get { return m_DefragTransfersEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(DefragTransfersEnable), this, m_DefragTransfersEnable, value)) m_DefragTransfersEnable = value; } } // 0x5B (91)
		
		protected bool m_ChunkLoadEnable = new bool();
		[ContainerField(Name: "ChunkLoadEnable", Offset: 92, NameHash: 1805392921, Flags: 49325), LayoutImmutable, Blittable]
		public bool ChunkLoadEnable { get { return m_ChunkLoadEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(ChunkLoadEnable), this, m_ChunkLoadEnable, value)) m_ChunkLoadEnable = value; } } // 0x5C (92)
		
		protected bool m_InstantUnloadingEnable = new bool();
		[ContainerField(Name: "InstantUnloadingEnable", Offset: 93, NameHash: 329282338, Flags: 49325), LayoutImmutable, Blittable]
		public bool InstantUnloadingEnable { get { return m_InstantUnloadingEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(InstantUnloadingEnable), this, m_InstantUnloadingEnable, value)) m_InstantUnloadingEnable = value; } } // 0x5D (93)
		
		protected bool m_FadeMipmapsEnable = new bool();
		[ContainerField(Name: "FadeMipmapsEnable", Offset: 94, NameHash: 4120232697, Flags: 49325), LayoutImmutable, Blittable]
		public bool FadeMipmapsEnable { get { return m_FadeMipmapsEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(FadeMipmapsEnable), this, m_FadeMipmapsEnable, value)) m_FadeMipmapsEnable = value; } } // 0x5E (94)
		
		protected bool m_DynamicLoadingEnable = new bool();
		[ContainerField(Name: "DynamicLoadingEnable", Offset: 95, NameHash: 677951191, Flags: 49325), LayoutImmutable, Blittable]
		public bool DynamicLoadingEnable { get { return m_DynamicLoadingEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(DynamicLoadingEnable), this, m_DynamicLoadingEnable, value)) m_DynamicLoadingEnable = value; } } // 0x5F (95)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 96, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x60 (96)
		
		protected bool m_DrawStatsEnable = new bool();
		[ContainerField(Name: "DrawStatsEnable", Offset: 97, NameHash: 711726149, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawStatsEnable { get { return m_DrawStatsEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(DrawStatsEnable), this, m_DrawStatsEnable, value)) m_DrawStatsEnable = value; } } // 0x61 (97)
		
		protected bool m_DrawTextureGroupStatsEnable = new bool();
		[ContainerField(Name: "DrawTextureGroupStatsEnable", Offset: 98, NameHash: 1301826533, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawTextureGroupStatsEnable { get { return m_DrawTextureGroupStatsEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(DrawTextureGroupStatsEnable), this, m_DrawTextureGroupStatsEnable, value)) m_DrawTextureGroupStatsEnable = value; } } // 0x62 (98)
		
		protected bool m_DrawTextureFormatStatsEnable = new bool();
		[ContainerField(Name: "DrawTextureFormatStatsEnable", Offset: 99, NameHash: 781840665, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawTextureFormatStatsEnable { get { return m_DrawTextureFormatStatsEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(DrawTextureFormatStatsEnable), this, m_DrawTextureFormatStatsEnable, value)) m_DrawTextureFormatStatsEnable = value; } } // 0x63 (99)
		
		protected bool m_DrawLoadingListEnable = new bool();
		[ContainerField(Name: "DrawLoadingListEnable", Offset: 100, NameHash: 2993570912, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawLoadingListEnable { get { return m_DrawLoadingListEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(DrawLoadingListEnable), this, m_DrawLoadingListEnable, value)) m_DrawLoadingListEnable = value; } } // 0x64 (100)
		
		protected bool m_DrawPriorityListEnable = new bool();
		[ContainerField(Name: "DrawPriorityListEnable", Offset: 101, NameHash: 2687194932, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawPriorityListEnable { get { return m_DrawPriorityListEnable; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(DrawPriorityListEnable), this, m_DrawPriorityListEnable, value)) m_DrawPriorityListEnable = value; } } // 0x65 (101)
		
		protected bool m_OverridePoolSize = new bool();
		[ContainerField(Name: "OverridePoolSize", Offset: 102, NameHash: 3027039592, Flags: 49325), LayoutImmutable, Blittable]
		public bool OverridePoolSize { get { return m_OverridePoolSize; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(OverridePoolSize), this, m_OverridePoolSize, value)) m_OverridePoolSize = value; } } // 0x66 (102)
		
		protected bool m_DumpLoadedList = new bool();
		[ContainerField(Name: "DumpLoadedList", Offset: 103, NameHash: 3865360236, Flags: 49325), LayoutImmutable, Blittable]
		public bool DumpLoadedList { get { return m_DumpLoadedList; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(DumpLoadedList), this, m_DumpLoadedList, value)) m_DumpLoadedList = value; } } // 0x67 (103)
		
		protected bool m_UseConditionalStreaming = new bool();
		[ContainerField(Name: "UseConditionalStreaming", Offset: 104, NameHash: 3302650340, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseConditionalStreaming { get { return m_UseConditionalStreaming; } set { if (OnPropertyChanging("TextureStreamingSettings." + nameof(UseConditionalStreaming), this, m_UseConditionalStreaming, value)) m_UseConditionalStreaming = value; } } // 0x68 (104)
		
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
