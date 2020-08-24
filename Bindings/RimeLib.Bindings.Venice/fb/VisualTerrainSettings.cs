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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class VisualTerrainSettings : 
		DataContainer
	{
		protected Vec2 m_DebugOverlayBrushCoverageMin = new Vec2();
		[ContainerField(8), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2292390516)]
		public Vec2 DebugOverlayBrushCoverageMin { get { return m_DebugOverlayBrushCoverageMin; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DebugOverlayBrushCoverageMin), this, m_DebugOverlayBrushCoverageMin, value)) m_DebugOverlayBrushCoverageMin = value; } } // 0x8 (8)
		
		protected TerrainRenderMode m_RenderMode = new TerrainRenderMode();
		[ContainerField(16), MemberInfoFlag(137), ContainerFieldNameHash(604062156)]
		public TerrainRenderMode RenderMode { get { return m_RenderMode; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(RenderMode), this, m_RenderMode, value)) m_RenderMode = value; } } // 0x10 (16)
		
		protected uint m_MeshScatteringInstanceCullJobCount = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1377403979)]
		public uint MeshScatteringInstanceCullJobCount { get { return m_MeshScatteringInstanceCullJobCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringInstanceCullJobCount), this, m_MeshScatteringInstanceCullJobCount, value)) m_MeshScatteringInstanceCullJobCount = value; } } // 0x14 (20)
		
		protected float m_PatchErrorFov = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2153498668)]
		public float PatchErrorFov { get { return m_PatchErrorFov; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(PatchErrorFov), this, m_PatchErrorFov, value)) m_PatchErrorFov = value; } } // 0x18 (24)
		
		protected float m_TriangleSizeMin = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2507615716)]
		public float TriangleSizeMin { get { return m_TriangleSizeMin; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TriangleSizeMin), this, m_TriangleSizeMin, value)) m_TriangleSizeMin = value; } } // 0x1C (28)
		
		protected float m_LodScale = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2060016442)]
		public float LodScale { get { return m_LodScale; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(LodScale), this, m_LodScale, value)) m_LodScale = value; } } // 0x20 (32)
		
		protected float m_LodCenterExtrapolationDistanceMax = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2770522378)]
		public float LodCenterExtrapolationDistanceMax { get { return m_LodCenterExtrapolationDistanceMax; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(LodCenterExtrapolationDistanceMax), this, m_LodCenterExtrapolationDistanceMax, value)) m_LodCenterExtrapolationDistanceMax = value; } } // 0x24 (36)
		
		protected float m_LodCenterExtrapolationTime = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2945679848)]
		public float LodCenterExtrapolationTime { get { return m_LodCenterExtrapolationTime; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(LodCenterExtrapolationTime), this, m_LodCenterExtrapolationTime, value)) m_LodCenterExtrapolationTime = value; } } // 0x28 (40)
		
		protected float m_MeshScatteringDensityScaleFactor = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(507726237)]
		public float MeshScatteringDensityScaleFactor { get { return m_MeshScatteringDensityScaleFactor; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringDensityScaleFactor), this, m_MeshScatteringDensityScaleFactor, value)) m_MeshScatteringDensityScaleFactor = value; } } // 0x2C (44)
		
		protected float m_DxTessellatedTriWidth = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1343805712)]
		public float DxTessellatedTriWidth { get { return m_DxTessellatedTriWidth; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DxTessellatedTriWidth), this, m_DxTessellatedTriWidth, value)) m_DxTessellatedTriWidth = value; } } // 0x30 (48)
		
		protected float m_DxTessellationPatchShrink = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(463576443)]
		public float DxTessellationPatchShrink { get { return m_DxTessellationPatchShrink; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DxTessellationPatchShrink), this, m_DxTessellationPatchShrink, value)) m_DxTessellationPatchShrink = value; } } // 0x34 (52)
		
		protected uint m_DxTessellationPatchFacesPerSide = new uint();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1178395664)]
		public uint DxTessellationPatchFacesPerSide { get { return m_DxTessellationPatchFacesPerSide; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DxTessellationPatchFacesPerSide), this, m_DxTessellationPatchFacesPerSide, value)) m_DxTessellationPatchFacesPerSide = value; } } // 0x38 (56)
		
		protected float m_ZPassDistance = new float();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1654643757)]
		public float ZPassDistance { get { return m_ZPassDistance; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(ZPassDistance), this, m_ZPassDistance, value)) m_ZPassDistance = value; } } // 0x3C (60)
		
		protected float m_DebugOverlayGridSize = new float();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2911590195)]
		public float DebugOverlayGridSize { get { return m_DebugOverlayGridSize; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DebugOverlayGridSize), this, m_DebugOverlayGridSize, value)) m_DebugOverlayGridSize = value; } } // 0x40 (64)
		
		protected uint m_TextureAtlasSampleCountXFactor = new uint();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4126069025)]
		public uint TextureAtlasSampleCountXFactor { get { return m_TextureAtlasSampleCountXFactor; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureAtlasSampleCountXFactor), this, m_TextureAtlasSampleCountXFactor, value)) m_TextureAtlasSampleCountXFactor = value; } } // 0x44 (68)
		
		protected uint m_TextureAtlasSampleCountYFactor = new uint();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1269765600)]
		public uint TextureAtlasSampleCountYFactor { get { return m_TextureAtlasSampleCountYFactor; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureAtlasSampleCountYFactor), this, m_TextureAtlasSampleCountYFactor, value)) m_TextureAtlasSampleCountYFactor = value; } } // 0x48 (72)
		
		protected float m_TextureSamplesPerMeterMax = new float();
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088559383)]
		public float TextureSamplesPerMeterMax { get { return m_TextureSamplesPerMeterMax; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureSamplesPerMeterMax), this, m_TextureSamplesPerMeterMax, value)) m_TextureSamplesPerMeterMax = value; } } // 0x4C (76)
		
		protected float m_TextureDetailFalloffFactor = new float();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3967520750)]
		public float TextureDetailFalloffFactor { get { return m_TextureDetailFalloffFactor; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureDetailFalloffFactor), this, m_TextureDetailFalloffFactor, value)) m_TextureDetailFalloffFactor = value; } } // 0x50 (80)
		
		protected float m_TextureDetailFalloffDistance = new float();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3751298432)]
		public float TextureDetailFalloffDistance { get { return m_TextureDetailFalloffDistance; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureDetailFalloffDistance), this, m_TextureDetailFalloffDistance, value)) m_TextureDetailFalloffDistance = value; } } // 0x54 (84)
		
		protected float m_TextureDetailFalloffCurve = new float();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1149518228)]
		public float TextureDetailFalloffCurve { get { return m_TextureDetailFalloffCurve; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureDetailFalloffCurve), this, m_TextureDetailFalloffCurve, value)) m_TextureDetailFalloffCurve = value; } } // 0x58 (88)
		
		protected float m_TextureInvisibleDetailReductionFactor = new float();
		[ContainerField(92), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1457469398)]
		public float TextureInvisibleDetailReductionFactor { get { return m_TextureInvisibleDetailReductionFactor; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureInvisibleDetailReductionFactor), this, m_TextureInvisibleDetailReductionFactor, value)) m_TextureInvisibleDetailReductionFactor = value; } } // 0x5C (92)
		
		protected float m_TextureOccludedDetailReductionFactor = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3033666796)]
		public float TextureOccludedDetailReductionFactor { get { return m_TextureOccludedDetailReductionFactor; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureOccludedDetailReductionFactor), this, m_TextureOccludedDetailReductionFactor, value)) m_TextureOccludedDetailReductionFactor = value; } } // 0x60 (96)
		
		protected uint m_TextureRenderJobCount = new uint();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(778957684)]
		public uint TextureRenderJobCount { get { return m_TextureRenderJobCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureRenderJobCount), this, m_TextureRenderJobCount, value)) m_TextureRenderJobCount = value; } } // 0x64 (100)
		
		protected float m_MeshScatteringDistanceScaleFactor = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1827110374)]
		public float MeshScatteringDistanceScaleFactor { get { return m_MeshScatteringDistanceScaleFactor; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringDistanceScaleFactor), this, m_MeshScatteringDistanceScaleFactor, value)) m_MeshScatteringDistanceScaleFactor = value; } } // 0x68 (104)
		
		protected float m_DebugOverlayIsolineSpacing = new float();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3407931572)]
		public float DebugOverlayIsolineSpacing { get { return m_DebugOverlayIsolineSpacing; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DebugOverlayIsolineSpacing), this, m_DebugOverlayIsolineSpacing, value)) m_DebugOverlayIsolineSpacing = value; } } // 0x6C (108)
		
		protected uint m_TextureRenderJobsLaunchedPerFrameCountMax = new uint();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1745442869)]
		public uint TextureRenderJobsLaunchedPerFrameCountMax { get { return m_TextureRenderJobsLaunchedPerFrameCountMax; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureRenderJobsLaunchedPerFrameCountMax), this, m_TextureRenderJobsLaunchedPerFrameCountMax, value)) m_TextureRenderJobsLaunchedPerFrameCountMax = value; } } // 0x70 (112)
		
		protected uint m_TextureTileSamplesPerSide = new uint();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(633376999)]
		public uint TextureTileSamplesPerSide { get { return m_TextureTileSamplesPerSide; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureTileSamplesPerSide), this, m_TextureTileSamplesPerSide, value)) m_TextureTileSamplesPerSide = value; } } // 0x74 (116)
		
		protected uint m_TextureTileBorderWidth = new uint();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3406986756)]
		public uint TextureTileBorderWidth { get { return m_TextureTileBorderWidth; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureTileBorderWidth), this, m_TextureTileBorderWidth, value)) m_TextureTileBorderWidth = value; } } // 0x78 (120)
		
		protected int m_TextureLevelOffset = new int();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3661664545)]
		public int TextureLevelOffset { get { return m_TextureLevelOffset; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureLevelOffset), this, m_TextureLevelOffset, value)) m_TextureLevelOffset = value; } } // 0x7C (124)
		
		protected uint m_TextureClodFrameCount = new uint();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3652441920)]
		public uint TextureClodFrameCount { get { return m_TextureClodFrameCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureClodFrameCount), this, m_TextureClodFrameCount, value)) m_TextureClodFrameCount = value; } } // 0x80 (128)
		
		protected float m_MeshScatteringDensityMarginFactor = new float();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1439647963)]
		public float MeshScatteringDensityMarginFactor { get { return m_MeshScatteringDensityMarginFactor; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringDensityMarginFactor), this, m_MeshScatteringDensityMarginFactor, value)) m_MeshScatteringDensityMarginFactor = value; } } // 0x84 (132)
		
		protected float m_TextureClodCutoffPriority = new float();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1567177377)]
		public float TextureClodCutoffPriority { get { return m_TextureClodCutoffPriority; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureClodCutoffPriority), this, m_TextureClodCutoffPriority, value)) m_TextureClodCutoffPriority = value; } } // 0x88 (136)
		
		protected float m_MeshScatteringWindSpeed = new float();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3680082659)]
		public float MeshScatteringWindSpeed { get { return m_MeshScatteringWindSpeed; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringWindSpeed), this, m_MeshScatteringWindSpeed, value)) m_MeshScatteringWindSpeed = value; } } // 0x8C (140)
		
		protected uint m_TextureCompressJobCount = new uint();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1333447608)]
		public uint TextureCompressJobCount { get { return m_TextureCompressJobCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureCompressJobCount), this, m_TextureCompressJobCount, value)) m_TextureCompressJobCount = value; } } // 0x90 (144)
		
		protected uint m_MeshScatteringInstancesPerCellMax = new uint();
		[ContainerField(148), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2571985055)]
		public uint MeshScatteringInstancesPerCellMax { get { return m_MeshScatteringInstancesPerCellMax; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringInstancesPerCellMax), this, m_MeshScatteringInstancesPerCellMax, value)) m_MeshScatteringInstancesPerCellMax = value; } } // 0x94 (148)
		
		protected int m_TextureCompressionQuality = new int();
		[ContainerField(152), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4190509689)]
		public int TextureCompressionQuality { get { return m_TextureCompressionQuality; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureCompressionQuality), this, m_TextureCompressionQuality, value)) m_TextureCompressionQuality = value; } } // 0x98 (152)
		
		protected float m_TextureDetailSlopeBoost = new float();
		[ContainerField(156), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3715363243)]
		public float TextureDetailSlopeBoost { get { return m_TextureDetailSlopeBoost; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureDetailSlopeBoost), this, m_TextureDetailSlopeBoost, value)) m_TextureDetailSlopeBoost = value; } } // 0x9C (156)
		
		protected float m_TextureGenerationMipBias = new float();
		[ContainerField(160), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3761799249)]
		public float TextureGenerationMipBias { get { return m_TextureGenerationMipBias; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureGenerationMipBias), this, m_TextureGenerationMipBias, value)) m_TextureGenerationMipBias = value; } } // 0xA0 (160)
		
		protected float m_DebugOverlayBrushSize = new float();
		[ContainerField(164), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1150079989)]
		public float DebugOverlayBrushSize { get { return m_DebugOverlayBrushSize; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DebugOverlayBrushSize), this, m_DebugOverlayBrushSize, value)) m_DebugOverlayBrushSize = value; } } // 0xA4 (164)
		
		protected uint m_MeshScatteringBuildChannelCount = new uint();
		[ContainerField(168), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2977144390)]
		public uint MeshScatteringBuildChannelCount { get { return m_MeshScatteringBuildChannelCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringBuildChannelCount), this, m_MeshScatteringBuildChannelCount, value)) m_MeshScatteringBuildChannelCount = value; } } // 0xA8 (168)
		
		protected uint m_MeshScatteringTreeNodePoolCapacity = new uint();
		[ContainerField(172), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2717031518)]
		public uint MeshScatteringTreeNodePoolCapacity { get { return m_MeshScatteringTreeNodePoolCapacity; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringTreeNodePoolCapacity), this, m_MeshScatteringTreeNodePoolCapacity, value)) m_MeshScatteringTreeNodePoolCapacity = value; } } // 0xAC (172)
		
		protected float m_MeshScatteringInvisibleCellFovFactor = new float();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2520908205)]
		public float MeshScatteringInvisibleCellFovFactor { get { return m_MeshScatteringInvisibleCellFovFactor; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringInvisibleCellFovFactor), this, m_MeshScatteringInvisibleCellFovFactor, value)) m_MeshScatteringInvisibleCellFovFactor = value; } } // 0xB0 (176)
		
		protected uint m_MeshScatteringInstanceCullListCount = new uint();
		[ContainerField(180), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(543625838)]
		public uint MeshScatteringInstanceCullListCount { get { return m_MeshScatteringInstanceCullListCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringInstanceCullListCount), this, m_MeshScatteringInstanceCullListCount, value)) m_MeshScatteringInstanceCullListCount = value; } } // 0xB4 (180)
		
		protected float m_MeshScatteringPregenerationDistanceRatio = new float();
		[ContainerField(184), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(363504787)]
		public float MeshScatteringPregenerationDistanceRatio { get { return m_MeshScatteringPregenerationDistanceRatio; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringPregenerationDistanceRatio), this, m_MeshScatteringPregenerationDistanceRatio, value)) m_MeshScatteringPregenerationDistanceRatio = value; } } // 0xB8 (184)
		
		protected uint m_TessellationFacesPerSideMin = new uint();
		[ContainerField(188), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1446211144)]
		public uint TessellationFacesPerSideMin { get { return m_TessellationFacesPerSideMin; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TessellationFacesPerSideMin), this, m_TessellationFacesPerSideMin, value)) m_TessellationFacesPerSideMin = value; } } // 0xBC (188)
		
		protected uint m_MaxNonVisibleTextureUpdateCount = new uint();
		[ContainerField(192), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(950337437)]
		public uint MaxNonVisibleTextureUpdateCount { get { return m_MaxNonVisibleTextureUpdateCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MaxNonVisibleTextureUpdateCount), this, m_MaxNonVisibleTextureUpdateCount, value)) m_MaxNonVisibleTextureUpdateCount = value; } } // 0xC0 (192)
		
		protected uint m_TextureQuadsPerTileLevel = new uint();
		[ContainerField(196), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(580148365)]
		public uint TextureQuadsPerTileLevel { get { return m_TextureQuadsPerTileLevel; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureQuadsPerTileLevel), this, m_TextureQuadsPerTileLevel, value)) m_TextureQuadsPerTileLevel = value; } } // 0xC4 (196)
		
		protected float m_WaterDepthMetersPerSample = new float();
		[ContainerField(200), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2438392036)]
		public float WaterDepthMetersPerSample { get { return m_WaterDepthMetersPerSample; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(WaterDepthMetersPerSample), this, m_WaterDepthMetersPerSample, value)) m_WaterDepthMetersPerSample = value; } } // 0xC8 (200)
		
		protected float m_DynamicMaskDecalWidthScale = new float();
		[ContainerField(204), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3977963893)]
		public float DynamicMaskDecalWidthScale { get { return m_DynamicMaskDecalWidthScale; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DynamicMaskDecalWidthScale), this, m_DynamicMaskDecalWidthScale, value)) m_DynamicMaskDecalWidthScale = value; } } // 0xCC (204)
		
		protected int m_DrawQuadtreeZoomIndex = new int();
		[ContainerField(208), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2453680075)]
		public int DrawQuadtreeZoomIndex { get { return m_DrawQuadtreeZoomIndex; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawQuadtreeZoomIndex), this, m_DrawQuadtreeZoomIndex, value)) m_DrawQuadtreeZoomIndex = value; } } // 0xD0 (208)
		
		protected uint m_MeshScatteringClodFrameCount = new uint();
		[ContainerField(212), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1935237962)]
		public uint MeshScatteringClodFrameCount { get { return m_MeshScatteringClodFrameCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringClodFrameCount), this, m_MeshScatteringClodFrameCount, value)) m_MeshScatteringClodFrameCount = value; } } // 0xD4 (212)
		
		protected uint m_MeshScatteringBuildChannelsLaunchedPerFrameCountMax = new uint();
		[ContainerField(216), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3623633927)]
		public uint MeshScatteringBuildChannelsLaunchedPerFrameCountMax { get { return m_MeshScatteringBuildChannelsLaunchedPerFrameCountMax; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringBuildChannelsLaunchedPerFrameCountMax), this, m_MeshScatteringBuildChannelsLaunchedPerFrameCountMax, value)) m_MeshScatteringBuildChannelsLaunchedPerFrameCountMax = value; } } // 0xD8 (216)
		
		protected uint m_SlotReuseWaitCount = new uint();
		[ContainerField(220), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(324602333)]
		public uint SlotReuseWaitCount { get { return m_SlotReuseWaitCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(SlotReuseWaitCount), this, m_SlotReuseWaitCount, value)) m_SlotReuseWaitCount = value; } } // 0xDC (220)
		
		protected uint m_MeshScatteringCellPoolCapacity = new uint();
		[ContainerField(224), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3904151486)]
		public uint MeshScatteringCellPoolCapacity { get { return m_MeshScatteringCellPoolCapacity; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringCellPoolCapacity), this, m_MeshScatteringCellPoolCapacity, value)) m_MeshScatteringCellPoolCapacity = value; } } // 0xE0 (224)
		
		protected uint m_MeshScatteringCullRecordCount = new uint();
		[ContainerField(228), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1187414408)]
		public uint MeshScatteringCullRecordCount { get { return m_MeshScatteringCullRecordCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringCullRecordCount), this, m_MeshScatteringCullRecordCount, value)) m_MeshScatteringCullRecordCount = value; } } // 0xE4 (228)
		
		protected uint m_PatchSlotCount = new uint();
		[ContainerField(232), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3311018828)]
		public uint PatchSlotCount { get { return m_PatchSlotCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(PatchSlotCount), this, m_PatchSlotCount, value)) m_PatchSlotCount = value; } } // 0xE8 (232)
		
		protected uint m_BuildJobCount = new uint();
		[ContainerField(236), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2337955959)]
		public uint BuildJobCount { get { return m_BuildJobCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(BuildJobCount), this, m_BuildJobCount, value)) m_BuildJobCount = value; } } // 0xEC (236)
		
		protected uint m_OccluderLodBoostLevelCount = new uint();
		[ContainerField(240), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3793961047)]
		public uint OccluderLodBoostLevelCount { get { return m_OccluderLodBoostLevelCount; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(OccluderLodBoostLevelCount), this, m_OccluderLodBoostLevelCount, value)) m_OccluderLodBoostLevelCount = value; } } // 0xF0 (240)
		
		protected float m_DecalZPassDrawDistance = new float();
		[ContainerField(244), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2366775586)]
		public float DecalZPassDrawDistance { get { return m_DecalZPassDrawDistance; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DecalZPassDrawDistance), this, m_DecalZPassDrawDistance, value)) m_DecalZPassDrawDistance = value; } } // 0xF4 (244)
		
		protected float m_DecalOffsetY = new float();
		[ContainerField(248), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3938450814)]
		public float DecalOffsetY { get { return m_DecalOffsetY; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DecalOffsetY), this, m_DecalOffsetY, value)) m_DecalOffsetY = value; } } // 0xF8 (248)
		
		protected float m_Decal3dFarDrawDistanceScaleFactor = new float();
		[ContainerField(252), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2283574846)]
		public float Decal3dFarDrawDistanceScaleFactor { get { return m_Decal3dFarDrawDistanceScaleFactor; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(Decal3dFarDrawDistanceScaleFactor), this, m_Decal3dFarDrawDistanceScaleFactor, value)) m_Decal3dFarDrawDistanceScaleFactor = value; } } // 0xFC (252)
		
		protected float m_OccludedMinDistance = new float();
		[ContainerField(256), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(409552415)]
		public float OccludedMinDistance { get { return m_OccludedMinDistance; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(OccludedMinDistance), this, m_OccludedMinDistance, value)) m_OccludedMinDistance = value; } } // 0x100 (256)
		
		protected uint m_PatchFacesPerSide = new uint();
		[ContainerField(260), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3215467205)]
		public uint PatchFacesPerSide { get { return m_PatchFacesPerSide; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(PatchFacesPerSide), this, m_PatchFacesPerSide, value)) m_PatchFacesPerSide = value; } } // 0x104 (260)
		
		protected bool m_DrawOnlyDecalZPassEnable = new bool();
		[ContainerField(264), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4246212052)]
		public bool DrawOnlyDecalZPassEnable { get { return m_DrawOnlyDecalZPassEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawOnlyDecalZPassEnable), this, m_DrawOnlyDecalZPassEnable, value)) m_DrawOnlyDecalZPassEnable = value; } } // 0x108 (264)
		
		protected bool m_DrawDecal3dEnable = new bool();
		[ContainerField(265), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(64506876)]
		public bool DrawDecal3dEnable { get { return m_DrawDecal3dEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawDecal3dEnable), this, m_DrawDecal3dEnable, value)) m_DrawDecal3dEnable = value; } } // 0x109 (265)
		
		protected bool m_DrawTextureTileBoxesEnable = new bool();
		[ContainerField(266), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1396482636)]
		public bool DrawTextureTileBoxesEnable { get { return m_DrawTextureTileBoxesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawTextureTileBoxesEnable), this, m_DrawTextureTileBoxesEnable, value)) m_DrawTextureTileBoxesEnable = value; } } // 0x10A (266)
		
		protected bool m_DrawEnable = new bool();
		[ContainerField(267), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1347356004)]
		public bool DrawEnable { get { return m_DrawEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawEnable), this, m_DrawEnable, value)) m_DrawEnable = value; } } // 0x10B (267)
		
		protected bool m_DrawPatchBoxesEnable = new bool();
		[ContainerField(268), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1919767209)]
		public bool DrawPatchBoxesEnable { get { return m_DrawPatchBoxesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawPatchBoxesEnable), this, m_DrawPatchBoxesEnable, value)) m_DrawPatchBoxesEnable = value; } } // 0x10C (268)
		
		protected bool m_DrawDebugTextEnable = new bool();
		[ContainerField(269), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2597896872)]
		public bool DrawDebugTextEnable { get { return m_DrawDebugTextEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawDebugTextEnable), this, m_DrawDebugTextEnable, value)) m_DrawDebugTextEnable = value; } } // 0x10D (269)
		
		protected bool m_DrawWaterEnable = new bool();
		[ContainerField(270), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1556803281)]
		public bool DrawWaterEnable { get { return m_DrawWaterEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawWaterEnable), this, m_DrawWaterEnable, value)) m_DrawWaterEnable = value; } } // 0x10E (270)
		
		protected bool m_PrioritizationSpuJobEnable = new bool();
		[ContainerField(271), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1044773552)]
		public bool PrioritizationSpuJobEnable { get { return m_PrioritizationSpuJobEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(PrioritizationSpuJobEnable), this, m_PrioritizationSpuJobEnable, value)) m_PrioritizationSpuJobEnable = value; } } // 0x10F (271)
		
		protected bool m_DrawDecalZPassEnable = new bool();
		[ContainerField(272), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4204328704)]
		public bool DrawDecalZPassEnable { get { return m_DrawDecalZPassEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawDecalZPassEnable), this, m_DrawDecalZPassEnable, value)) m_DrawDecalZPassEnable = value; } } // 0x110 (272)
		
		protected bool m_DrawQuadtreesEnable = new bool();
		[ContainerField(273), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2200842704)]
		public bool DrawQuadtreesEnable { get { return m_DrawQuadtreesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawQuadtreesEnable), this, m_DrawQuadtreesEnable, value)) m_DrawQuadtreesEnable = value; } } // 0x111 (273)
		
		protected bool m_TextureVtIndirectionJobEnable = new bool();
		[ContainerField(274), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3774251356)]
		public bool TextureVtIndirectionJobEnable { get { return m_TextureVtIndirectionJobEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureVtIndirectionJobEnable), this, m_TextureVtIndirectionJobEnable, value)) m_TextureVtIndirectionJobEnable = value; } } // 0x112 (274)
		
		protected bool m_VertexBufferHeightsEnable = new bool();
		[ContainerField(275), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2068984320)]
		public bool VertexBufferHeightsEnable { get { return m_VertexBufferHeightsEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(VertexBufferHeightsEnable), this, m_VertexBufferHeightsEnable, value)) m_VertexBufferHeightsEnable = value; } } // 0x113 (275)
		
		protected bool m_DrawDebugTexturesEnable = new bool();
		[ContainerField(276), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3201068793)]
		public bool DrawDebugTexturesEnable { get { return m_DrawDebugTexturesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawDebugTexturesEnable), this, m_DrawDebugTexturesEnable, value)) m_DrawDebugTexturesEnable = value; } } // 0x114 (276)
		
		protected bool m_ForceDecalReducedQuality = new bool();
		[ContainerField(277), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3956171390)]
		public bool ForceDecalReducedQuality { get { return m_ForceDecalReducedQuality; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(ForceDecalReducedQuality), this, m_ForceDecalReducedQuality, value)) m_ForceDecalReducedQuality = value; } } // 0x115 (277)
		
		protected bool m_DebugOverlayIsolinesEnable = new bool();
		[ContainerField(278), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(34449415)]
		public bool DebugOverlayIsolinesEnable { get { return m_DebugOverlayIsolinesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DebugOverlayIsolinesEnable), this, m_DebugOverlayIsolinesEnable, value)) m_DebugOverlayIsolinesEnable = value; } } // 0x116 (278)
		
		protected bool m_TextureClodEnable = new bool();
		[ContainerField(279), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(653057119)]
		public bool TextureClodEnable { get { return m_TextureClodEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureClodEnable), this, m_TextureClodEnable, value)) m_TextureClodEnable = value; } } // 0x117 (279)
		
		protected bool m_DebugOverlayWireframeEnable = new bool();
		[ContainerField(280), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(655785883)]
		public bool DebugOverlayWireframeEnable { get { return m_DebugOverlayWireframeEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DebugOverlayWireframeEnable), this, m_DebugOverlayWireframeEnable, value)) m_DebugOverlayWireframeEnable = value; } } // 0x118 (280)
		
		protected bool m_DebugOverlaySketchTextureEnable = new bool();
		[ContainerField(281), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(143726866)]
		public bool DebugOverlaySketchTextureEnable { get { return m_DebugOverlaySketchTextureEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DebugOverlaySketchTextureEnable), this, m_DebugOverlaySketchTextureEnable, value)) m_DebugOverlaySketchTextureEnable = value; } } // 0x119 (281)
		
		protected bool m_DrawDecal2dEnable = new bool();
		[ContainerField(282), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1750994717)]
		public bool DrawDecal2dEnable { get { return m_DrawDecal2dEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawDecal2dEnable), this, m_DrawDecal2dEnable, value)) m_DrawDecal2dEnable = value; } } // 0x11A (282)
		
		protected bool m_DetailOverlayEnable = new bool();
		[ContainerField(283), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3002464783)]
		public bool DetailOverlayEnable { get { return m_DetailOverlayEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DetailOverlayEnable), this, m_DetailOverlayEnable, value)) m_DetailOverlayEnable = value; } } // 0x11B (283)
		
		protected bool m_DecalEnable = new bool();
		[ContainerField(284), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4161996939)]
		public bool DecalEnable { get { return m_DecalEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DecalEnable), this, m_DecalEnable, value)) m_DecalEnable = value; } } // 0x11C (284)
		
		protected bool m_DrawPatchesEnable = new bool();
		[ContainerField(285), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(446402236)]
		public bool DrawPatchesEnable { get { return m_DrawPatchesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawPatchesEnable), this, m_DrawPatchesEnable, value)) m_DrawPatchesEnable = value; } } // 0x11D (285)
		
		protected bool m_DrawQuadtreeStatsEnable = new bool();
		[ContainerField(286), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3164917602)]
		public bool DrawQuadtreeStatsEnable { get { return m_DrawQuadtreeStatsEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawQuadtreeStatsEnable), this, m_DrawQuadtreeStatsEnable, value)) m_DrawQuadtreeStatsEnable = value; } } // 0x11E (286)
		
		protected bool m_DestroyAll = new bool();
		[ContainerField(287), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2267365766)]
		public bool DestroyAll { get { return m_DestroyAll; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DestroyAll), this, m_DestroyAll, value)) m_DestroyAll = value; } } // 0x11F (287)
		
		protected bool m_DrawQuadtreeAtlasTexturesEnable = new bool();
		[ContainerField(288), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(971211428)]
		public bool DrawQuadtreeAtlasTexturesEnable { get { return m_DrawQuadtreeAtlasTexturesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawQuadtreeAtlasTexturesEnable), this, m_DrawQuadtreeAtlasTexturesEnable, value)) m_DrawQuadtreeAtlasTexturesEnable = value; } } // 0x120 (288)
		
		protected bool m_SlotDebugOutputEnable = new bool();
		[ContainerField(289), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2581919758)]
		public bool SlotDebugOutputEnable { get { return m_SlotDebugOutputEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(SlotDebugOutputEnable), this, m_SlotDebugOutputEnable, value)) m_SlotDebugOutputEnable = value; } } // 0x121 (289)
		
		protected bool m_UpdateJobsEnable = new bool();
		[ContainerField(290), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1022084865)]
		public bool UpdateJobsEnable { get { return m_UpdateJobsEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(UpdateJobsEnable), this, m_UpdateJobsEnable, value)) m_UpdateJobsEnable = value; } } // 0x122 (290)
		
		protected bool m_PrioritizationOcclusionEnable = new bool();
		[ContainerField(291), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1362931244)]
		public bool PrioritizationOcclusionEnable { get { return m_PrioritizationOcclusionEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(PrioritizationOcclusionEnable), this, m_PrioritizationOcclusionEnable, value)) m_PrioritizationOcclusionEnable = value; } } // 0x123 (291)
		
		protected bool m_CullSpuJobEnable = new bool();
		[ContainerField(292), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(119814531)]
		public bool CullSpuJobEnable { get { return m_CullSpuJobEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(CullSpuJobEnable), this, m_CullSpuJobEnable, value)) m_CullSpuJobEnable = value; } } // 0x124 (292)
		
		protected bool m_PrepareBuildSpuJobEnable = new bool();
		[ContainerField(293), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3547915906)]
		public bool PrepareBuildSpuJobEnable { get { return m_PrepareBuildSpuJobEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(PrepareBuildSpuJobEnable), this, m_PrepareBuildSpuJobEnable, value)) m_PrepareBuildSpuJobEnable = value; } } // 0x125 (293)
		
		protected bool m_BuildSpuJobEnable = new bool();
		[ContainerField(294), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(939986499)]
		public bool BuildSpuJobEnable { get { return m_BuildSpuJobEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(BuildSpuJobEnable), this, m_BuildSpuJobEnable, value)) m_BuildSpuJobEnable = value; } } // 0x126 (294)
		
		protected bool m_RegenerateTexturesEnable = new bool();
		[ContainerField(295), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1326175188)]
		public bool RegenerateTexturesEnable { get { return m_RegenerateTexturesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(RegenerateTexturesEnable), this, m_RegenerateTexturesEnable, value)) m_RegenerateTexturesEnable = value; } } // 0x127 (295)
		
		protected bool m_DynamicMaskEnable = new bool();
		[ContainerField(296), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(755434949)]
		public bool DynamicMaskEnable { get { return m_DynamicMaskEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DynamicMaskEnable), this, m_DynamicMaskEnable, value)) m_DynamicMaskEnable = value; } } // 0x128 (296)
		
		protected bool m_GpuTextureCompressionEnable = new bool();
		[ContainerField(297), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2080181719)]
		public bool GpuTextureCompressionEnable { get { return m_GpuTextureCompressionEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(GpuTextureCompressionEnable), this, m_GpuTextureCompressionEnable, value)) m_GpuTextureCompressionEnable = value; } } // 0x129 (297)
		
		protected bool m_TextureBlockOnStreamingEnable = new bool();
		[ContainerField(298), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3748992655)]
		public bool TextureBlockOnStreamingEnable { get { return m_TextureBlockOnStreamingEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureBlockOnStreamingEnable), this, m_TextureBlockOnStreamingEnable, value)) m_TextureBlockOnStreamingEnable = value; } } // 0x12A (298)
		
		protected bool m_PatchErrorFovEnable = new bool();
		[ContainerField(299), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1743796749)]
		public bool PatchErrorFovEnable { get { return m_PatchErrorFovEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(PatchErrorFovEnable), this, m_PatchErrorFovEnable, value)) m_PatchErrorFovEnable = value; } } // 0x12B (299)
		
		protected bool m_DxDisplacementMappingEnable = new bool();
		[ContainerField(300), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1873123555)]
		public bool DxDisplacementMappingEnable { get { return m_DxDisplacementMappingEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DxDisplacementMappingEnable), this, m_DxDisplacementMappingEnable, value)) m_DxDisplacementMappingEnable = value; } } // 0x12C (300)
		
		protected bool m_TextureKeepPoolFullEnable = new bool();
		[ContainerField(301), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1911658543)]
		public bool TextureKeepPoolFullEnable { get { return m_TextureKeepPoolFullEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureKeepPoolFullEnable), this, m_TextureKeepPoolFullEnable, value)) m_TextureKeepPoolFullEnable = value; } } // 0x12D (301)
		
		protected bool m_PatchLodTransitionsEnable = new bool();
		[ContainerField(302), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3695690641)]
		public bool PatchLodTransitionsEnable { get { return m_PatchLodTransitionsEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(PatchLodTransitionsEnable), this, m_PatchLodTransitionsEnable, value)) m_PatchLodTransitionsEnable = value; } } // 0x12E (302)
		
		protected bool m_PatchMaterialSortingEnable = new bool();
		[ContainerField(303), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2618635803)]
		public bool PatchMaterialSortingEnable { get { return m_PatchMaterialSortingEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(PatchMaterialSortingEnable), this, m_PatchMaterialSortingEnable, value)) m_PatchMaterialSortingEnable = value; } } // 0x12F (303)
		
		protected bool m_CullSampleBoundingBoxHeightEnable = new bool();
		[ContainerField(304), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(183771340)]
		public bool CullSampleBoundingBoxHeightEnable { get { return m_CullSampleBoundingBoxHeightEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(CullSampleBoundingBoxHeightEnable), this, m_CullSampleBoundingBoxHeightEnable, value)) m_CullSampleBoundingBoxHeightEnable = value; } } // 0x130 (304)
		
		protected bool m_CastShadowsEnable = new bool();
		[ContainerField(305), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3967009076)]
		public bool CastShadowsEnable { get { return m_CastShadowsEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(CastShadowsEnable), this, m_CastShadowsEnable, value)) m_CastShadowsEnable = value; } } // 0x131 (305)
		
		protected bool m_GlobalColormapEnable = new bool();
		[ContainerField(306), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3709871502)]
		public bool GlobalColormapEnable { get { return m_GlobalColormapEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(GlobalColormapEnable), this, m_GlobalColormapEnable, value)) m_GlobalColormapEnable = value; } } // 0x132 (306)
		
		protected bool m_OccluderEnable = new bool();
		[ContainerField(307), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4076210433)]
		public bool OccluderEnable { get { return m_OccluderEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(OccluderEnable), this, m_OccluderEnable, value)) m_OccluderEnable = value; } } // 0x133 (307)
		
		protected bool m_OccluderJobEnable = new bool();
		[ContainerField(308), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2334652646)]
		public bool OccluderJobEnable { get { return m_OccluderJobEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(OccluderJobEnable), this, m_OccluderJobEnable, value)) m_OccluderJobEnable = value; } } // 0x134 (308)
		
		protected bool m_OccluderSpuJobEnable = new bool();
		[ContainerField(309), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1367673200)]
		public bool OccluderSpuJobEnable { get { return m_OccluderSpuJobEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(OccluderSpuJobEnable), this, m_OccluderSpuJobEnable, value)) m_OccluderSpuJobEnable = value; } } // 0x135 (309)
		
		protected bool m_TextureLayerCullingEnable = new bool();
		[ContainerField(310), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3031132270)]
		public bool TextureLayerCullingEnable { get { return m_TextureLayerCullingEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureLayerCullingEnable), this, m_TextureLayerCullingEnable, value)) m_TextureLayerCullingEnable = value; } } // 0x136 (310)
		
		protected bool m_OccludedEnable = new bool();
		[ContainerField(311), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1405632023)]
		public bool OccludedEnable { get { return m_OccludedEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(OccludedEnable), this, m_OccludedEnable, value)) m_OccludedEnable = value; } } // 0x137 (311)
		
		protected bool m_DrawTextureDebugDepthComplexity = new bool();
		[ContainerField(312), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1060566562)]
		public bool DrawTextureDebugDepthComplexity { get { return m_DrawTextureDebugDepthComplexity; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawTextureDebugDepthComplexity), this, m_DrawTextureDebugDepthComplexity, value)) m_DrawTextureDebugDepthComplexity = value; } } // 0x138 (312)
		
		protected bool m_MeshScatteringEnable = new bool();
		[ContainerField(313), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1582374769)]
		public bool MeshScatteringEnable { get { return m_MeshScatteringEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringEnable), this, m_MeshScatteringEnable, value)) m_MeshScatteringEnable = value; } } // 0x139 (313)
		
		protected bool m_MeshScatteringJobsEnable = new bool();
		[ContainerField(314), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(680367813)]
		public bool MeshScatteringJobsEnable { get { return m_MeshScatteringJobsEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringJobsEnable), this, m_MeshScatteringJobsEnable, value)) m_MeshScatteringJobsEnable = value; } } // 0x13A (314)
		
		protected bool m_MeshScatteringCastShadowsEnable = new bool();
		[ContainerField(315), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(260504321)]
		public bool MeshScatteringCastShadowsEnable { get { return m_MeshScatteringCastShadowsEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringCastShadowsEnable), this, m_MeshScatteringCastShadowsEnable, value)) m_MeshScatteringCastShadowsEnable = value; } } // 0x13B (315)
		
		protected bool m_DrawMeshScatteringEnable = new bool();
		[ContainerField(316), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1873322225)]
		public bool DrawMeshScatteringEnable { get { return m_DrawMeshScatteringEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawMeshScatteringEnable), this, m_DrawMeshScatteringEnable, value)) m_DrawMeshScatteringEnable = value; } } // 0x13C (316)
		
		protected bool m_DrawMeshScatteringCellBoxesEnable = new bool();
		[ContainerField(317), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1056407860)]
		public bool DrawMeshScatteringCellBoxesEnable { get { return m_DrawMeshScatteringCellBoxesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawMeshScatteringCellBoxesEnable), this, m_DrawMeshScatteringCellBoxesEnable, value)) m_DrawMeshScatteringCellBoxesEnable = value; } } // 0x13D (317)
		
		protected bool m_DrawMeshScatteringNodeBoxesEnable = new bool();
		[ContainerField(318), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3766978642)]
		public bool DrawMeshScatteringNodeBoxesEnable { get { return m_DrawMeshScatteringNodeBoxesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawMeshScatteringNodeBoxesEnable), this, m_DrawMeshScatteringNodeBoxesEnable, value)) m_DrawMeshScatteringNodeBoxesEnable = value; } } // 0x13E (318)
		
		protected bool m_DrawMeshScatteringCulledCellBoxesEnable = new bool();
		[ContainerField(319), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4172400931)]
		public bool DrawMeshScatteringCulledCellBoxesEnable { get { return m_DrawMeshScatteringCulledCellBoxesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawMeshScatteringCulledCellBoxesEnable), this, m_DrawMeshScatteringCulledCellBoxesEnable, value)) m_DrawMeshScatteringCulledCellBoxesEnable = value; } } // 0x13F (319)
		
		protected bool m_DrawMeshScatteringDebugMaskScaleTexturesEnable = new bool();
		[ContainerField(320), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(203952608)]
		public bool DrawMeshScatteringDebugMaskScaleTexturesEnable { get { return m_DrawMeshScatteringDebugMaskScaleTexturesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawMeshScatteringDebugMaskScaleTexturesEnable), this, m_DrawMeshScatteringDebugMaskScaleTexturesEnable, value)) m_DrawMeshScatteringDebugMaskScaleTexturesEnable = value; } } // 0x140 (320)
		
		protected bool m_DrawMeshScatteringStatsEnable = new bool();
		[ContainerField(321), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(784005232)]
		public bool DrawMeshScatteringStatsEnable { get { return m_DrawMeshScatteringStatsEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawMeshScatteringStatsEnable), this, m_DrawMeshScatteringStatsEnable, value)) m_DrawMeshScatteringStatsEnable = value; } } // 0x141 (321)
		
		protected bool m_DrawMeshScatteringQuadtreeEnable = new bool();
		[ContainerField(322), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3030268342)]
		public bool DrawMeshScatteringQuadtreeEnable { get { return m_DrawMeshScatteringQuadtreeEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawMeshScatteringQuadtreeEnable), this, m_DrawMeshScatteringQuadtreeEnable, value)) m_DrawMeshScatteringQuadtreeEnable = value; } } // 0x142 (322)
		
		protected bool m_TextureDrawTerrainLayersEnable = new bool();
		[ContainerField(323), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3034227900)]
		public bool TextureDrawTerrainLayersEnable { get { return m_TextureDrawTerrainLayersEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureDrawTerrainLayersEnable), this, m_TextureDrawTerrainLayersEnable, value)) m_TextureDrawTerrainLayersEnable = value; } } // 0x143 (323)
		
		protected bool m_TextureForceUpdateEnable = new bool();
		[ContainerField(324), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2932131575)]
		public bool TextureForceUpdateEnable { get { return m_TextureForceUpdateEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureForceUpdateEnable), this, m_TextureForceUpdateEnable, value)) m_TextureForceUpdateEnable = value; } } // 0x144 (324)
		
		protected bool m_TextureCompressFastAlgorithmEnable = new bool();
		[ContainerField(325), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1230349042)]
		public bool TextureCompressFastAlgorithmEnable { get { return m_TextureCompressFastAlgorithmEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureCompressFastAlgorithmEnable), this, m_TextureCompressFastAlgorithmEnable, value)) m_TextureCompressFastAlgorithmEnable = value; } } // 0x145 (325)
		
		protected bool m_MeshScatteringForceUpdateEnable = new bool();
		[ContainerField(326), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3436118205)]
		public bool MeshScatteringForceUpdateEnable { get { return m_MeshScatteringForceUpdateEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringForceUpdateEnable), this, m_MeshScatteringForceUpdateEnable, value)) m_MeshScatteringForceUpdateEnable = value; } } // 0x146 (326)
		
		protected bool m_TextureCompressSpuJobsEnable = new bool();
		[ContainerField(327), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1126887967)]
		public bool TextureCompressSpuJobsEnable { get { return m_TextureCompressSpuJobsEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureCompressSpuJobsEnable), this, m_TextureCompressSpuJobsEnable, value)) m_TextureCompressSpuJobsEnable = value; } } // 0x147 (327)
		
		protected bool m_DrawTextureDebugColors = new bool();
		[ContainerField(328), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3000540485)]
		public bool DrawTextureDebugColors { get { return m_DrawTextureDebugColors; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawTextureDebugColors), this, m_DrawTextureDebugColors, value)) m_DrawTextureDebugColors = value; } } // 0x148 (328)
		
		protected bool m_ForceGraphicsDriverCrash = new bool();
		[ContainerField(329), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2083607384)]
		public bool ForceGraphicsDriverCrash { get { return m_ForceGraphicsDriverCrash; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(ForceGraphicsDriverCrash), this, m_ForceGraphicsDriverCrash, value)) m_ForceGraphicsDriverCrash = value; } } // 0x149 (329)
		
		protected bool m_MeshScatteringBuildVisibleFirst = new bool();
		[ContainerField(330), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2409600562)]
		public bool MeshScatteringBuildVisibleFirst { get { return m_MeshScatteringBuildVisibleFirst; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringBuildVisibleFirst), this, m_MeshScatteringBuildVisibleFirst, value)) m_MeshScatteringBuildVisibleFirst = value; } } // 0x14A (330)
		
		protected bool m_ForcePatchRebuildEnable = new bool();
		[ContainerField(331), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2610802454)]
		public bool ForcePatchRebuildEnable { get { return m_ForcePatchRebuildEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(ForcePatchRebuildEnable), this, m_ForcePatchRebuildEnable, value)) m_ForcePatchRebuildEnable = value; } } // 0x14B (331)
		
		protected bool m_DebugOverlayBrushEnable = new bool();
		[ContainerField(332), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3458508561)]
		public bool DebugOverlayBrushEnable { get { return m_DebugOverlayBrushEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DebugOverlayBrushEnable), this, m_DebugOverlayBrushEnable, value)) m_DebugOverlayBrushEnable = value; } } // 0x14C (332)
		
		protected bool m_WireframeEnable = new bool();
		[ContainerField(333), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1610721584)]
		public bool WireframeEnable { get { return m_WireframeEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(WireframeEnable), this, m_WireframeEnable, value)) m_WireframeEnable = value; } } // 0x14D (333)
		
		protected bool m_TextureVtIndirectionSpuJobEnable = new bool();
		[ContainerField(334), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3592129930)]
		public bool TextureVtIndirectionSpuJobEnable { get { return m_TextureVtIndirectionSpuJobEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(TextureVtIndirectionSpuJobEnable), this, m_TextureVtIndirectionSpuJobEnable, value)) m_TextureVtIndirectionSpuJobEnable = value; } } // 0x14E (334)
		
		protected bool m_DrawVertexYTextureEnable = new bool();
		[ContainerField(335), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2458934506)]
		public bool DrawVertexYTextureEnable { get { return m_DrawVertexYTextureEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawVertexYTextureEnable), this, m_DrawVertexYTextureEnable, value)) m_DrawVertexYTextureEnable = value; } } // 0x14F (335)
		
		protected bool m_MeshScatteringInstanceCountLodEnable = new bool();
		[ContainerField(336), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(579572668)]
		public bool MeshScatteringInstanceCountLodEnable { get { return m_MeshScatteringInstanceCountLodEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringInstanceCountLodEnable), this, m_MeshScatteringInstanceCountLodEnable, value)) m_MeshScatteringInstanceCountLodEnable = value; } } // 0x150 (336)
		
		protected bool m_MeshScatteringCullSpuJobEnable = new bool();
		[ContainerField(337), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1878981910)]
		public bool MeshScatteringCullSpuJobEnable { get { return m_MeshScatteringCullSpuJobEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringCullSpuJobEnable), this, m_MeshScatteringCullSpuJobEnable, value)) m_MeshScatteringCullSpuJobEnable = value; } } // 0x151 (337)
		
		protected bool m_MeshScatteringInstanceCullSpuJobEnable = new bool();
		[ContainerField(338), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(752518783)]
		public bool MeshScatteringInstanceCullSpuJobEnable { get { return m_MeshScatteringInstanceCullSpuJobEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringInstanceCullSpuJobEnable), this, m_MeshScatteringInstanceCullSpuJobEnable, value)) m_MeshScatteringInstanceCullSpuJobEnable = value; } } // 0x152 (338)
		
		protected bool m_MeshScatteringPrioritizationSpuJobEnable = new bool();
		[ContainerField(339), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(216759141)]
		public bool MeshScatteringPrioritizationSpuJobEnable { get { return m_MeshScatteringPrioritizationSpuJobEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringPrioritizationSpuJobEnable), this, m_MeshScatteringPrioritizationSpuJobEnable, value)) m_MeshScatteringPrioritizationSpuJobEnable = value; } } // 0x153 (339)
		
		protected bool m_MeshScatteringSpuJobEnable = new bool();
		[ContainerField(340), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4065237440)]
		public bool MeshScatteringSpuJobEnable { get { return m_MeshScatteringSpuJobEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringSpuJobEnable), this, m_MeshScatteringSpuJobEnable, value)) m_MeshScatteringSpuJobEnable = value; } } // 0x154 (340)
		
		protected bool m_Enable = new bool();
		[ContainerField(341), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x155 (341)
		
		protected bool m_EditServiceEnable = new bool();
		[ContainerField(342), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4261474725)]
		public bool EditServiceEnable { get { return m_EditServiceEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(EditServiceEnable), this, m_EditServiceEnable, value)) m_EditServiceEnable = value; } } // 0x156 (342)
		
		protected bool m_MeshScatteringInstanceCullEnable = new bool();
		[ContainerField(343), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1955478670)]
		public bool MeshScatteringInstanceCullEnable { get { return m_MeshScatteringInstanceCullEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringInstanceCullEnable), this, m_MeshScatteringInstanceCullEnable, value)) m_MeshScatteringInstanceCullEnable = value; } } // 0x157 (343)
		
		protected bool m_ZeroViewportEnable = new bool();
		[ContainerField(344), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(967736082)]
		public bool ZeroViewportEnable { get { return m_ZeroViewportEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(ZeroViewportEnable), this, m_ZeroViewportEnable, value)) m_ZeroViewportEnable = value; } } // 0x158 (344)
		
		protected bool m_DebugOverlayGridEnable = new bool();
		[ContainerField(345), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1437495895)]
		public bool DebugOverlayGridEnable { get { return m_DebugOverlayGridEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DebugOverlayGridEnable), this, m_DebugOverlayGridEnable, value)) m_DebugOverlayGridEnable = value; } } // 0x159 (345)
		
		protected bool m_MeshScatteringInstanceCullBoxTestEnable = new bool();
		[ContainerField(346), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(505056013)]
		public bool MeshScatteringInstanceCullBoxTestEnable { get { return m_MeshScatteringInstanceCullBoxTestEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringInstanceCullBoxTestEnable), this, m_MeshScatteringInstanceCullBoxTestEnable, value)) m_MeshScatteringInstanceCullBoxTestEnable = value; } } // 0x15A (346)
		
		protected bool m_MeshScatteringInstanceFrustumCullEnable = new bool();
		[ContainerField(347), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1467206000)]
		public bool MeshScatteringInstanceFrustumCullEnable { get { return m_MeshScatteringInstanceFrustumCullEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringInstanceFrustumCullEnable), this, m_MeshScatteringInstanceFrustumCullEnable, value)) m_MeshScatteringInstanceFrustumCullEnable = value; } } // 0x15B (347)
		
		protected bool m_MeshScatteringInstanceOcclusionCullEnable = new bool();
		[ContainerField(348), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(647474307)]
		public bool MeshScatteringInstanceOcclusionCullEnable { get { return m_MeshScatteringInstanceOcclusionCullEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringInstanceOcclusionCullEnable), this, m_MeshScatteringInstanceOcclusionCullEnable, value)) m_MeshScatteringInstanceOcclusionCullEnable = value; } } // 0x15C (348)
		
		protected bool m_MeshScatteringInstanceAdditionalCullEnable = new bool();
		[ContainerField(349), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(264156247)]
		public bool MeshScatteringInstanceAdditionalCullEnable { get { return m_MeshScatteringInstanceAdditionalCullEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringInstanceAdditionalCullEnable), this, m_MeshScatteringInstanceAdditionalCullEnable, value)) m_MeshScatteringInstanceAdditionalCullEnable = value; } } // 0x15D (349)
		
		protected bool m_DrawMeshScatteringInstanceBoxesEnable = new bool();
		[ContainerField(350), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2317267771)]
		public bool DrawMeshScatteringInstanceBoxesEnable { get { return m_DrawMeshScatteringInstanceBoxesEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(DrawMeshScatteringInstanceBoxesEnable), this, m_DrawMeshScatteringInstanceBoxesEnable, value)) m_DrawMeshScatteringInstanceBoxesEnable = value; } } // 0x15E (350)
		
		protected bool m_MeshScatteringInstanceCullDynamicAllocEnable = new bool();
		[ContainerField(351), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4110771126)]
		public bool MeshScatteringInstanceCullDynamicAllocEnable { get { return m_MeshScatteringInstanceCullDynamicAllocEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(MeshScatteringInstanceCullDynamicAllocEnable), this, m_MeshScatteringInstanceCullDynamicAllocEnable, value)) m_MeshScatteringInstanceCullDynamicAllocEnable = value; } } // 0x15F (351)
		
		protected bool m_Ps3MeshScatteringInstanceCellMemoryEnable = new bool();
		[ContainerField(352), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2081082415)]
		public bool Ps3MeshScatteringInstanceCellMemoryEnable { get { return m_Ps3MeshScatteringInstanceCellMemoryEnable; } set { if (OnPropertyChanging("VisualTerrainSettings." + nameof(Ps3MeshScatteringInstanceCellMemoryEnable), this, m_Ps3MeshScatteringInstanceCellMemoryEnable, value)) m_Ps3MeshScatteringInstanceCellMemoryEnable = value; } } // 0x160 (352)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2292390516:
					DebugOverlayBrushCoverageMin = (Vec2) p_Value;
					break;

				case 604062156:
					RenderMode = (TerrainRenderMode) Enum.ToObject(typeof(TerrainRenderMode), p_Value);
					break;

				case 1377403979:
					MeshScatteringInstanceCullJobCount = (uint) p_Value;
					break;

				case 2153498668:
					PatchErrorFov = (float) p_Value;
					break;

				case 2507615716:
					TriangleSizeMin = (float) p_Value;
					break;

				case 2060016442:
					LodScale = (float) p_Value;
					break;

				case 2770522378:
					LodCenterExtrapolationDistanceMax = (float) p_Value;
					break;

				case 2945679848:
					LodCenterExtrapolationTime = (float) p_Value;
					break;

				case 507726237:
					MeshScatteringDensityScaleFactor = (float) p_Value;
					break;

				case 1343805712:
					DxTessellatedTriWidth = (float) p_Value;
					break;

				case 463576443:
					DxTessellationPatchShrink = (float) p_Value;
					break;

				case 1178395664:
					DxTessellationPatchFacesPerSide = (uint) p_Value;
					break;

				case 1654643757:
					ZPassDistance = (float) p_Value;
					break;

				case 2911590195:
					DebugOverlayGridSize = (float) p_Value;
					break;

				case 4126069025:
					TextureAtlasSampleCountXFactor = (uint) p_Value;
					break;

				case 1269765600:
					TextureAtlasSampleCountYFactor = (uint) p_Value;
					break;

				case 2088559383:
					TextureSamplesPerMeterMax = (float) p_Value;
					break;

				case 3967520750:
					TextureDetailFalloffFactor = (float) p_Value;
					break;

				case 3751298432:
					TextureDetailFalloffDistance = (float) p_Value;
					break;

				case 1149518228:
					TextureDetailFalloffCurve = (float) p_Value;
					break;

				case 1457469398:
					TextureInvisibleDetailReductionFactor = (float) p_Value;
					break;

				case 3033666796:
					TextureOccludedDetailReductionFactor = (float) p_Value;
					break;

				case 778957684:
					TextureRenderJobCount = (uint) p_Value;
					break;

				case 1827110374:
					MeshScatteringDistanceScaleFactor = (float) p_Value;
					break;

				case 3407931572:
					DebugOverlayIsolineSpacing = (float) p_Value;
					break;

				case 1745442869:
					TextureRenderJobsLaunchedPerFrameCountMax = (uint) p_Value;
					break;

				case 633376999:
					TextureTileSamplesPerSide = (uint) p_Value;
					break;

				case 3406986756:
					TextureTileBorderWidth = (uint) p_Value;
					break;

				case 3661664545:
					TextureLevelOffset = (int) p_Value;
					break;

				case 3652441920:
					TextureClodFrameCount = (uint) p_Value;
					break;

				case 1439647963:
					MeshScatteringDensityMarginFactor = (float) p_Value;
					break;

				case 1567177377:
					TextureClodCutoffPriority = (float) p_Value;
					break;

				case 3680082659:
					MeshScatteringWindSpeed = (float) p_Value;
					break;

				case 1333447608:
					TextureCompressJobCount = (uint) p_Value;
					break;

				case 2571985055:
					MeshScatteringInstancesPerCellMax = (uint) p_Value;
					break;

				case 4190509689:
					TextureCompressionQuality = (int) p_Value;
					break;

				case 3715363243:
					TextureDetailSlopeBoost = (float) p_Value;
					break;

				case 3761799249:
					TextureGenerationMipBias = (float) p_Value;
					break;

				case 1150079989:
					DebugOverlayBrushSize = (float) p_Value;
					break;

				case 2977144390:
					MeshScatteringBuildChannelCount = (uint) p_Value;
					break;

				case 2717031518:
					MeshScatteringTreeNodePoolCapacity = (uint) p_Value;
					break;

				case 2520908205:
					MeshScatteringInvisibleCellFovFactor = (float) p_Value;
					break;

				case 543625838:
					MeshScatteringInstanceCullListCount = (uint) p_Value;
					break;

				case 363504787:
					MeshScatteringPregenerationDistanceRatio = (float) p_Value;
					break;

				case 1446211144:
					TessellationFacesPerSideMin = (uint) p_Value;
					break;

				case 950337437:
					MaxNonVisibleTextureUpdateCount = (uint) p_Value;
					break;

				case 580148365:
					TextureQuadsPerTileLevel = (uint) p_Value;
					break;

				case 2438392036:
					WaterDepthMetersPerSample = (float) p_Value;
					break;

				case 3977963893:
					DynamicMaskDecalWidthScale = (float) p_Value;
					break;

				case 2453680075:
					DrawQuadtreeZoomIndex = (int) p_Value;
					break;

				case 1935237962:
					MeshScatteringClodFrameCount = (uint) p_Value;
					break;

				case 3623633927:
					MeshScatteringBuildChannelsLaunchedPerFrameCountMax = (uint) p_Value;
					break;

				case 324602333:
					SlotReuseWaitCount = (uint) p_Value;
					break;

				case 3904151486:
					MeshScatteringCellPoolCapacity = (uint) p_Value;
					break;

				case 1187414408:
					MeshScatteringCullRecordCount = (uint) p_Value;
					break;

				case 3311018828:
					PatchSlotCount = (uint) p_Value;
					break;

				case 2337955959:
					BuildJobCount = (uint) p_Value;
					break;

				case 3793961047:
					OccluderLodBoostLevelCount = (uint) p_Value;
					break;

				case 2366775586:
					DecalZPassDrawDistance = (float) p_Value;
					break;

				case 3938450814:
					DecalOffsetY = (float) p_Value;
					break;

				case 2283574846:
					Decal3dFarDrawDistanceScaleFactor = (float) p_Value;
					break;

				case 409552415:
					OccludedMinDistance = (float) p_Value;
					break;

				case 3215467205:
					PatchFacesPerSide = (uint) p_Value;
					break;

				case 4246212052:
					DrawOnlyDecalZPassEnable = (bool) p_Value;
					break;

				case 64506876:
					DrawDecal3dEnable = (bool) p_Value;
					break;

				case 1396482636:
					DrawTextureTileBoxesEnable = (bool) p_Value;
					break;

				case 1347356004:
					DrawEnable = (bool) p_Value;
					break;

				case 1919767209:
					DrawPatchBoxesEnable = (bool) p_Value;
					break;

				case 2597896872:
					DrawDebugTextEnable = (bool) p_Value;
					break;

				case 1556803281:
					DrawWaterEnable = (bool) p_Value;
					break;

				case 1044773552:
					PrioritizationSpuJobEnable = (bool) p_Value;
					break;

				case 4204328704:
					DrawDecalZPassEnable = (bool) p_Value;
					break;

				case 2200842704:
					DrawQuadtreesEnable = (bool) p_Value;
					break;

				case 3774251356:
					TextureVtIndirectionJobEnable = (bool) p_Value;
					break;

				case 2068984320:
					VertexBufferHeightsEnable = (bool) p_Value;
					break;

				case 3201068793:
					DrawDebugTexturesEnable = (bool) p_Value;
					break;

				case 3956171390:
					ForceDecalReducedQuality = (bool) p_Value;
					break;

				case 34449415:
					DebugOverlayIsolinesEnable = (bool) p_Value;
					break;

				case 653057119:
					TextureClodEnable = (bool) p_Value;
					break;

				case 655785883:
					DebugOverlayWireframeEnable = (bool) p_Value;
					break;

				case 143726866:
					DebugOverlaySketchTextureEnable = (bool) p_Value;
					break;

				case 1750994717:
					DrawDecal2dEnable = (bool) p_Value;
					break;

				case 3002464783:
					DetailOverlayEnable = (bool) p_Value;
					break;

				case 4161996939:
					DecalEnable = (bool) p_Value;
					break;

				case 446402236:
					DrawPatchesEnable = (bool) p_Value;
					break;

				case 3164917602:
					DrawQuadtreeStatsEnable = (bool) p_Value;
					break;

				case 2267365766:
					DestroyAll = (bool) p_Value;
					break;

				case 971211428:
					DrawQuadtreeAtlasTexturesEnable = (bool) p_Value;
					break;

				case 2581919758:
					SlotDebugOutputEnable = (bool) p_Value;
					break;

				case 1022084865:
					UpdateJobsEnable = (bool) p_Value;
					break;

				case 1362931244:
					PrioritizationOcclusionEnable = (bool) p_Value;
					break;

				case 119814531:
					CullSpuJobEnable = (bool) p_Value;
					break;

				case 3547915906:
					PrepareBuildSpuJobEnable = (bool) p_Value;
					break;

				case 939986499:
					BuildSpuJobEnable = (bool) p_Value;
					break;

				case 1326175188:
					RegenerateTexturesEnable = (bool) p_Value;
					break;

				case 755434949:
					DynamicMaskEnable = (bool) p_Value;
					break;

				case 2080181719:
					GpuTextureCompressionEnable = (bool) p_Value;
					break;

				case 3748992655:
					TextureBlockOnStreamingEnable = (bool) p_Value;
					break;

				case 1743796749:
					PatchErrorFovEnable = (bool) p_Value;
					break;

				case 1873123555:
					DxDisplacementMappingEnable = (bool) p_Value;
					break;

				case 1911658543:
					TextureKeepPoolFullEnable = (bool) p_Value;
					break;

				case 3695690641:
					PatchLodTransitionsEnable = (bool) p_Value;
					break;

				case 2618635803:
					PatchMaterialSortingEnable = (bool) p_Value;
					break;

				case 183771340:
					CullSampleBoundingBoxHeightEnable = (bool) p_Value;
					break;

				case 3967009076:
					CastShadowsEnable = (bool) p_Value;
					break;

				case 3709871502:
					GlobalColormapEnable = (bool) p_Value;
					break;

				case 4076210433:
					OccluderEnable = (bool) p_Value;
					break;

				case 2334652646:
					OccluderJobEnable = (bool) p_Value;
					break;

				case 1367673200:
					OccluderSpuJobEnable = (bool) p_Value;
					break;

				case 3031132270:
					TextureLayerCullingEnable = (bool) p_Value;
					break;

				case 1405632023:
					OccludedEnable = (bool) p_Value;
					break;

				case 1060566562:
					DrawTextureDebugDepthComplexity = (bool) p_Value;
					break;

				case 1582374769:
					MeshScatteringEnable = (bool) p_Value;
					break;

				case 680367813:
					MeshScatteringJobsEnable = (bool) p_Value;
					break;

				case 260504321:
					MeshScatteringCastShadowsEnable = (bool) p_Value;
					break;

				case 1873322225:
					DrawMeshScatteringEnable = (bool) p_Value;
					break;

				case 1056407860:
					DrawMeshScatteringCellBoxesEnable = (bool) p_Value;
					break;

				case 3766978642:
					DrawMeshScatteringNodeBoxesEnable = (bool) p_Value;
					break;

				case 4172400931:
					DrawMeshScatteringCulledCellBoxesEnable = (bool) p_Value;
					break;

				case 203952608:
					DrawMeshScatteringDebugMaskScaleTexturesEnable = (bool) p_Value;
					break;

				case 784005232:
					DrawMeshScatteringStatsEnable = (bool) p_Value;
					break;

				case 3030268342:
					DrawMeshScatteringQuadtreeEnable = (bool) p_Value;
					break;

				case 3034227900:
					TextureDrawTerrainLayersEnable = (bool) p_Value;
					break;

				case 2932131575:
					TextureForceUpdateEnable = (bool) p_Value;
					break;

				case 1230349042:
					TextureCompressFastAlgorithmEnable = (bool) p_Value;
					break;

				case 3436118205:
					MeshScatteringForceUpdateEnable = (bool) p_Value;
					break;

				case 1126887967:
					TextureCompressSpuJobsEnable = (bool) p_Value;
					break;

				case 3000540485:
					DrawTextureDebugColors = (bool) p_Value;
					break;

				case 2083607384:
					ForceGraphicsDriverCrash = (bool) p_Value;
					break;

				case 2409600562:
					MeshScatteringBuildVisibleFirst = (bool) p_Value;
					break;

				case 2610802454:
					ForcePatchRebuildEnable = (bool) p_Value;
					break;

				case 3458508561:
					DebugOverlayBrushEnable = (bool) p_Value;
					break;

				case 1610721584:
					WireframeEnable = (bool) p_Value;
					break;

				case 3592129930:
					TextureVtIndirectionSpuJobEnable = (bool) p_Value;
					break;

				case 2458934506:
					DrawVertexYTextureEnable = (bool) p_Value;
					break;

				case 579572668:
					MeshScatteringInstanceCountLodEnable = (bool) p_Value;
					break;

				case 1878981910:
					MeshScatteringCullSpuJobEnable = (bool) p_Value;
					break;

				case 752518783:
					MeshScatteringInstanceCullSpuJobEnable = (bool) p_Value;
					break;

				case 216759141:
					MeshScatteringPrioritizationSpuJobEnable = (bool) p_Value;
					break;

				case 4065237440:
					MeshScatteringSpuJobEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 4261474725:
					EditServiceEnable = (bool) p_Value;
					break;

				case 1955478670:
					MeshScatteringInstanceCullEnable = (bool) p_Value;
					break;

				case 967736082:
					ZeroViewportEnable = (bool) p_Value;
					break;

				case 1437495895:
					DebugOverlayGridEnable = (bool) p_Value;
					break;

				case 505056013:
					MeshScatteringInstanceCullBoxTestEnable = (bool) p_Value;
					break;

				case 1467206000:
					MeshScatteringInstanceFrustumCullEnable = (bool) p_Value;
					break;

				case 647474307:
					MeshScatteringInstanceOcclusionCullEnable = (bool) p_Value;
					break;

				case 264156247:
					MeshScatteringInstanceAdditionalCullEnable = (bool) p_Value;
					break;

				case 2317267771:
					DrawMeshScatteringInstanceBoxesEnable = (bool) p_Value;
					break;

				case 4110771126:
					MeshScatteringInstanceCullDynamicAllocEnable = (bool) p_Value;
					break;

				case 2081082415:
					Ps3MeshScatteringInstanceCellMemoryEnable = (bool) p_Value;
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
				case 2292390516:
					return DebugOverlayBrushCoverageMin;

				case 604062156:
					return RenderMode;

				case 1377403979:
					return MeshScatteringInstanceCullJobCount;

				case 2153498668:
					return PatchErrorFov;

				case 2507615716:
					return TriangleSizeMin;

				case 2060016442:
					return LodScale;

				case 2770522378:
					return LodCenterExtrapolationDistanceMax;

				case 2945679848:
					return LodCenterExtrapolationTime;

				case 507726237:
					return MeshScatteringDensityScaleFactor;

				case 1343805712:
					return DxTessellatedTriWidth;

				case 463576443:
					return DxTessellationPatchShrink;

				case 1178395664:
					return DxTessellationPatchFacesPerSide;

				case 1654643757:
					return ZPassDistance;

				case 2911590195:
					return DebugOverlayGridSize;

				case 4126069025:
					return TextureAtlasSampleCountXFactor;

				case 1269765600:
					return TextureAtlasSampleCountYFactor;

				case 2088559383:
					return TextureSamplesPerMeterMax;

				case 3967520750:
					return TextureDetailFalloffFactor;

				case 3751298432:
					return TextureDetailFalloffDistance;

				case 1149518228:
					return TextureDetailFalloffCurve;

				case 1457469398:
					return TextureInvisibleDetailReductionFactor;

				case 3033666796:
					return TextureOccludedDetailReductionFactor;

				case 778957684:
					return TextureRenderJobCount;

				case 1827110374:
					return MeshScatteringDistanceScaleFactor;

				case 3407931572:
					return DebugOverlayIsolineSpacing;

				case 1745442869:
					return TextureRenderJobsLaunchedPerFrameCountMax;

				case 633376999:
					return TextureTileSamplesPerSide;

				case 3406986756:
					return TextureTileBorderWidth;

				case 3661664545:
					return TextureLevelOffset;

				case 3652441920:
					return TextureClodFrameCount;

				case 1439647963:
					return MeshScatteringDensityMarginFactor;

				case 1567177377:
					return TextureClodCutoffPriority;

				case 3680082659:
					return MeshScatteringWindSpeed;

				case 1333447608:
					return TextureCompressJobCount;

				case 2571985055:
					return MeshScatteringInstancesPerCellMax;

				case 4190509689:
					return TextureCompressionQuality;

				case 3715363243:
					return TextureDetailSlopeBoost;

				case 3761799249:
					return TextureGenerationMipBias;

				case 1150079989:
					return DebugOverlayBrushSize;

				case 2977144390:
					return MeshScatteringBuildChannelCount;

				case 2717031518:
					return MeshScatteringTreeNodePoolCapacity;

				case 2520908205:
					return MeshScatteringInvisibleCellFovFactor;

				case 543625838:
					return MeshScatteringInstanceCullListCount;

				case 363504787:
					return MeshScatteringPregenerationDistanceRatio;

				case 1446211144:
					return TessellationFacesPerSideMin;

				case 950337437:
					return MaxNonVisibleTextureUpdateCount;

				case 580148365:
					return TextureQuadsPerTileLevel;

				case 2438392036:
					return WaterDepthMetersPerSample;

				case 3977963893:
					return DynamicMaskDecalWidthScale;

				case 2453680075:
					return DrawQuadtreeZoomIndex;

				case 1935237962:
					return MeshScatteringClodFrameCount;

				case 3623633927:
					return MeshScatteringBuildChannelsLaunchedPerFrameCountMax;

				case 324602333:
					return SlotReuseWaitCount;

				case 3904151486:
					return MeshScatteringCellPoolCapacity;

				case 1187414408:
					return MeshScatteringCullRecordCount;

				case 3311018828:
					return PatchSlotCount;

				case 2337955959:
					return BuildJobCount;

				case 3793961047:
					return OccluderLodBoostLevelCount;

				case 2366775586:
					return DecalZPassDrawDistance;

				case 3938450814:
					return DecalOffsetY;

				case 2283574846:
					return Decal3dFarDrawDistanceScaleFactor;

				case 409552415:
					return OccludedMinDistance;

				case 3215467205:
					return PatchFacesPerSide;

				case 4246212052:
					return DrawOnlyDecalZPassEnable;

				case 64506876:
					return DrawDecal3dEnable;

				case 1396482636:
					return DrawTextureTileBoxesEnable;

				case 1347356004:
					return DrawEnable;

				case 1919767209:
					return DrawPatchBoxesEnable;

				case 2597896872:
					return DrawDebugTextEnable;

				case 1556803281:
					return DrawWaterEnable;

				case 1044773552:
					return PrioritizationSpuJobEnable;

				case 4204328704:
					return DrawDecalZPassEnable;

				case 2200842704:
					return DrawQuadtreesEnable;

				case 3774251356:
					return TextureVtIndirectionJobEnable;

				case 2068984320:
					return VertexBufferHeightsEnable;

				case 3201068793:
					return DrawDebugTexturesEnable;

				case 3956171390:
					return ForceDecalReducedQuality;

				case 34449415:
					return DebugOverlayIsolinesEnable;

				case 653057119:
					return TextureClodEnable;

				case 655785883:
					return DebugOverlayWireframeEnable;

				case 143726866:
					return DebugOverlaySketchTextureEnable;

				case 1750994717:
					return DrawDecal2dEnable;

				case 3002464783:
					return DetailOverlayEnable;

				case 4161996939:
					return DecalEnable;

				case 446402236:
					return DrawPatchesEnable;

				case 3164917602:
					return DrawQuadtreeStatsEnable;

				case 2267365766:
					return DestroyAll;

				case 971211428:
					return DrawQuadtreeAtlasTexturesEnable;

				case 2581919758:
					return SlotDebugOutputEnable;

				case 1022084865:
					return UpdateJobsEnable;

				case 1362931244:
					return PrioritizationOcclusionEnable;

				case 119814531:
					return CullSpuJobEnable;

				case 3547915906:
					return PrepareBuildSpuJobEnable;

				case 939986499:
					return BuildSpuJobEnable;

				case 1326175188:
					return RegenerateTexturesEnable;

				case 755434949:
					return DynamicMaskEnable;

				case 2080181719:
					return GpuTextureCompressionEnable;

				case 3748992655:
					return TextureBlockOnStreamingEnable;

				case 1743796749:
					return PatchErrorFovEnable;

				case 1873123555:
					return DxDisplacementMappingEnable;

				case 1911658543:
					return TextureKeepPoolFullEnable;

				case 3695690641:
					return PatchLodTransitionsEnable;

				case 2618635803:
					return PatchMaterialSortingEnable;

				case 183771340:
					return CullSampleBoundingBoxHeightEnable;

				case 3967009076:
					return CastShadowsEnable;

				case 3709871502:
					return GlobalColormapEnable;

				case 4076210433:
					return OccluderEnable;

				case 2334652646:
					return OccluderJobEnable;

				case 1367673200:
					return OccluderSpuJobEnable;

				case 3031132270:
					return TextureLayerCullingEnable;

				case 1405632023:
					return OccludedEnable;

				case 1060566562:
					return DrawTextureDebugDepthComplexity;

				case 1582374769:
					return MeshScatteringEnable;

				case 680367813:
					return MeshScatteringJobsEnable;

				case 260504321:
					return MeshScatteringCastShadowsEnable;

				case 1873322225:
					return DrawMeshScatteringEnable;

				case 1056407860:
					return DrawMeshScatteringCellBoxesEnable;

				case 3766978642:
					return DrawMeshScatteringNodeBoxesEnable;

				case 4172400931:
					return DrawMeshScatteringCulledCellBoxesEnable;

				case 203952608:
					return DrawMeshScatteringDebugMaskScaleTexturesEnable;

				case 784005232:
					return DrawMeshScatteringStatsEnable;

				case 3030268342:
					return DrawMeshScatteringQuadtreeEnable;

				case 3034227900:
					return TextureDrawTerrainLayersEnable;

				case 2932131575:
					return TextureForceUpdateEnable;

				case 1230349042:
					return TextureCompressFastAlgorithmEnable;

				case 3436118205:
					return MeshScatteringForceUpdateEnable;

				case 1126887967:
					return TextureCompressSpuJobsEnable;

				case 3000540485:
					return DrawTextureDebugColors;

				case 2083607384:
					return ForceGraphicsDriverCrash;

				case 2409600562:
					return MeshScatteringBuildVisibleFirst;

				case 2610802454:
					return ForcePatchRebuildEnable;

				case 3458508561:
					return DebugOverlayBrushEnable;

				case 1610721584:
					return WireframeEnable;

				case 3592129930:
					return TextureVtIndirectionSpuJobEnable;

				case 2458934506:
					return DrawVertexYTextureEnable;

				case 579572668:
					return MeshScatteringInstanceCountLodEnable;

				case 1878981910:
					return MeshScatteringCullSpuJobEnable;

				case 752518783:
					return MeshScatteringInstanceCullSpuJobEnable;

				case 216759141:
					return MeshScatteringPrioritizationSpuJobEnable;

				case 4065237440:
					return MeshScatteringSpuJobEnable;

				case 2342790116:
					return Enable;

				case 4261474725:
					return EditServiceEnable;

				case 1955478670:
					return MeshScatteringInstanceCullEnable;

				case 967736082:
					return ZeroViewportEnable;

				case 1437495895:
					return DebugOverlayGridEnable;

				case 505056013:
					return MeshScatteringInstanceCullBoxTestEnable;

				case 1467206000:
					return MeshScatteringInstanceFrustumCullEnable;

				case 647474307:
					return MeshScatteringInstanceOcclusionCullEnable;

				case 264156247:
					return MeshScatteringInstanceAdditionalCullEnable;

				case 2317267771:
					return DrawMeshScatteringInstanceBoxesEnable;

				case 4110771126:
					return MeshScatteringInstanceCullDynamicAllocEnable;

				case 2081082415:
					return Ps3MeshScatteringInstanceCellMemoryEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2292390516:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DebugOverlayBrushCoverageMin));

				case 604062156:
					return typeof(VisualTerrainSettings).GetProperty(nameof(RenderMode));

				case 1377403979:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringInstanceCullJobCount));

				case 2153498668:
					return typeof(VisualTerrainSettings).GetProperty(nameof(PatchErrorFov));

				case 2507615716:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TriangleSizeMin));

				case 2060016442:
					return typeof(VisualTerrainSettings).GetProperty(nameof(LodScale));

				case 2770522378:
					return typeof(VisualTerrainSettings).GetProperty(nameof(LodCenterExtrapolationDistanceMax));

				case 2945679848:
					return typeof(VisualTerrainSettings).GetProperty(nameof(LodCenterExtrapolationTime));

				case 507726237:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringDensityScaleFactor));

				case 1343805712:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DxTessellatedTriWidth));

				case 463576443:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DxTessellationPatchShrink));

				case 1178395664:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DxTessellationPatchFacesPerSide));

				case 1654643757:
					return typeof(VisualTerrainSettings).GetProperty(nameof(ZPassDistance));

				case 2911590195:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DebugOverlayGridSize));

				case 4126069025:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureAtlasSampleCountXFactor));

				case 1269765600:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureAtlasSampleCountYFactor));

				case 2088559383:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureSamplesPerMeterMax));

				case 3967520750:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureDetailFalloffFactor));

				case 3751298432:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureDetailFalloffDistance));

				case 1149518228:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureDetailFalloffCurve));

				case 1457469398:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureInvisibleDetailReductionFactor));

				case 3033666796:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureOccludedDetailReductionFactor));

				case 778957684:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureRenderJobCount));

				case 1827110374:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringDistanceScaleFactor));

				case 3407931572:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DebugOverlayIsolineSpacing));

				case 1745442869:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureRenderJobsLaunchedPerFrameCountMax));

				case 633376999:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureTileSamplesPerSide));

				case 3406986756:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureTileBorderWidth));

				case 3661664545:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureLevelOffset));

				case 3652441920:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureClodFrameCount));

				case 1439647963:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringDensityMarginFactor));

				case 1567177377:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureClodCutoffPriority));

				case 3680082659:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringWindSpeed));

				case 1333447608:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureCompressJobCount));

				case 2571985055:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringInstancesPerCellMax));

				case 4190509689:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureCompressionQuality));

				case 3715363243:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureDetailSlopeBoost));

				case 3761799249:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureGenerationMipBias));

				case 1150079989:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DebugOverlayBrushSize));

				case 2977144390:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringBuildChannelCount));

				case 2717031518:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringTreeNodePoolCapacity));

				case 2520908205:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringInvisibleCellFovFactor));

				case 543625838:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringInstanceCullListCount));

				case 363504787:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringPregenerationDistanceRatio));

				case 1446211144:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TessellationFacesPerSideMin));

				case 950337437:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MaxNonVisibleTextureUpdateCount));

				case 580148365:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureQuadsPerTileLevel));

				case 2438392036:
					return typeof(VisualTerrainSettings).GetProperty(nameof(WaterDepthMetersPerSample));

				case 3977963893:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DynamicMaskDecalWidthScale));

				case 2453680075:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawQuadtreeZoomIndex));

				case 1935237962:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringClodFrameCount));

				case 3623633927:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringBuildChannelsLaunchedPerFrameCountMax));

				case 324602333:
					return typeof(VisualTerrainSettings).GetProperty(nameof(SlotReuseWaitCount));

				case 3904151486:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringCellPoolCapacity));

				case 1187414408:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringCullRecordCount));

				case 3311018828:
					return typeof(VisualTerrainSettings).GetProperty(nameof(PatchSlotCount));

				case 2337955959:
					return typeof(VisualTerrainSettings).GetProperty(nameof(BuildJobCount));

				case 3793961047:
					return typeof(VisualTerrainSettings).GetProperty(nameof(OccluderLodBoostLevelCount));

				case 2366775586:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DecalZPassDrawDistance));

				case 3938450814:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DecalOffsetY));

				case 2283574846:
					return typeof(VisualTerrainSettings).GetProperty(nameof(Decal3dFarDrawDistanceScaleFactor));

				case 409552415:
					return typeof(VisualTerrainSettings).GetProperty(nameof(OccludedMinDistance));

				case 3215467205:
					return typeof(VisualTerrainSettings).GetProperty(nameof(PatchFacesPerSide));

				case 4246212052:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawOnlyDecalZPassEnable));

				case 64506876:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawDecal3dEnable));

				case 1396482636:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawTextureTileBoxesEnable));

				case 1347356004:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawEnable));

				case 1919767209:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawPatchBoxesEnable));

				case 2597896872:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawDebugTextEnable));

				case 1556803281:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawWaterEnable));

				case 1044773552:
					return typeof(VisualTerrainSettings).GetProperty(nameof(PrioritizationSpuJobEnable));

				case 4204328704:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawDecalZPassEnable));

				case 2200842704:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawQuadtreesEnable));

				case 3774251356:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureVtIndirectionJobEnable));

				case 2068984320:
					return typeof(VisualTerrainSettings).GetProperty(nameof(VertexBufferHeightsEnable));

				case 3201068793:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawDebugTexturesEnable));

				case 3956171390:
					return typeof(VisualTerrainSettings).GetProperty(nameof(ForceDecalReducedQuality));

				case 34449415:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DebugOverlayIsolinesEnable));

				case 653057119:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureClodEnable));

				case 655785883:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DebugOverlayWireframeEnable));

				case 143726866:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DebugOverlaySketchTextureEnable));

				case 1750994717:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawDecal2dEnable));

				case 3002464783:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DetailOverlayEnable));

				case 4161996939:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DecalEnable));

				case 446402236:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawPatchesEnable));

				case 3164917602:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawQuadtreeStatsEnable));

				case 2267365766:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DestroyAll));

				case 971211428:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawQuadtreeAtlasTexturesEnable));

				case 2581919758:
					return typeof(VisualTerrainSettings).GetProperty(nameof(SlotDebugOutputEnable));

				case 1022084865:
					return typeof(VisualTerrainSettings).GetProperty(nameof(UpdateJobsEnable));

				case 1362931244:
					return typeof(VisualTerrainSettings).GetProperty(nameof(PrioritizationOcclusionEnable));

				case 119814531:
					return typeof(VisualTerrainSettings).GetProperty(nameof(CullSpuJobEnable));

				case 3547915906:
					return typeof(VisualTerrainSettings).GetProperty(nameof(PrepareBuildSpuJobEnable));

				case 939986499:
					return typeof(VisualTerrainSettings).GetProperty(nameof(BuildSpuJobEnable));

				case 1326175188:
					return typeof(VisualTerrainSettings).GetProperty(nameof(RegenerateTexturesEnable));

				case 755434949:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DynamicMaskEnable));

				case 2080181719:
					return typeof(VisualTerrainSettings).GetProperty(nameof(GpuTextureCompressionEnable));

				case 3748992655:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureBlockOnStreamingEnable));

				case 1743796749:
					return typeof(VisualTerrainSettings).GetProperty(nameof(PatchErrorFovEnable));

				case 1873123555:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DxDisplacementMappingEnable));

				case 1911658543:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureKeepPoolFullEnable));

				case 3695690641:
					return typeof(VisualTerrainSettings).GetProperty(nameof(PatchLodTransitionsEnable));

				case 2618635803:
					return typeof(VisualTerrainSettings).GetProperty(nameof(PatchMaterialSortingEnable));

				case 183771340:
					return typeof(VisualTerrainSettings).GetProperty(nameof(CullSampleBoundingBoxHeightEnable));

				case 3967009076:
					return typeof(VisualTerrainSettings).GetProperty(nameof(CastShadowsEnable));

				case 3709871502:
					return typeof(VisualTerrainSettings).GetProperty(nameof(GlobalColormapEnable));

				case 4076210433:
					return typeof(VisualTerrainSettings).GetProperty(nameof(OccluderEnable));

				case 2334652646:
					return typeof(VisualTerrainSettings).GetProperty(nameof(OccluderJobEnable));

				case 1367673200:
					return typeof(VisualTerrainSettings).GetProperty(nameof(OccluderSpuJobEnable));

				case 3031132270:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureLayerCullingEnable));

				case 1405632023:
					return typeof(VisualTerrainSettings).GetProperty(nameof(OccludedEnable));

				case 1060566562:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawTextureDebugDepthComplexity));

				case 1582374769:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringEnable));

				case 680367813:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringJobsEnable));

				case 260504321:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringCastShadowsEnable));

				case 1873322225:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawMeshScatteringEnable));

				case 1056407860:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawMeshScatteringCellBoxesEnable));

				case 3766978642:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawMeshScatteringNodeBoxesEnable));

				case 4172400931:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawMeshScatteringCulledCellBoxesEnable));

				case 203952608:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawMeshScatteringDebugMaskScaleTexturesEnable));

				case 784005232:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawMeshScatteringStatsEnable));

				case 3030268342:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawMeshScatteringQuadtreeEnable));

				case 3034227900:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureDrawTerrainLayersEnable));

				case 2932131575:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureForceUpdateEnable));

				case 1230349042:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureCompressFastAlgorithmEnable));

				case 3436118205:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringForceUpdateEnable));

				case 1126887967:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureCompressSpuJobsEnable));

				case 3000540485:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawTextureDebugColors));

				case 2083607384:
					return typeof(VisualTerrainSettings).GetProperty(nameof(ForceGraphicsDriverCrash));

				case 2409600562:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringBuildVisibleFirst));

				case 2610802454:
					return typeof(VisualTerrainSettings).GetProperty(nameof(ForcePatchRebuildEnable));

				case 3458508561:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DebugOverlayBrushEnable));

				case 1610721584:
					return typeof(VisualTerrainSettings).GetProperty(nameof(WireframeEnable));

				case 3592129930:
					return typeof(VisualTerrainSettings).GetProperty(nameof(TextureVtIndirectionSpuJobEnable));

				case 2458934506:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawVertexYTextureEnable));

				case 579572668:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringInstanceCountLodEnable));

				case 1878981910:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringCullSpuJobEnable));

				case 752518783:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringInstanceCullSpuJobEnable));

				case 216759141:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringPrioritizationSpuJobEnable));

				case 4065237440:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringSpuJobEnable));

				case 2342790116:
					return typeof(VisualTerrainSettings).GetProperty(nameof(Enable));

				case 4261474725:
					return typeof(VisualTerrainSettings).GetProperty(nameof(EditServiceEnable));

				case 1955478670:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringInstanceCullEnable));

				case 967736082:
					return typeof(VisualTerrainSettings).GetProperty(nameof(ZeroViewportEnable));

				case 1437495895:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DebugOverlayGridEnable));

				case 505056013:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringInstanceCullBoxTestEnable));

				case 1467206000:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringInstanceFrustumCullEnable));

				case 647474307:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringInstanceOcclusionCullEnable));

				case 264156247:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringInstanceAdditionalCullEnable));

				case 2317267771:
					return typeof(VisualTerrainSettings).GetProperty(nameof(DrawMeshScatteringInstanceBoxesEnable));

				case 4110771126:
					return typeof(VisualTerrainSettings).GetProperty(nameof(MeshScatteringInstanceCullDynamicAllocEnable));

				case 2081082415:
					return typeof(VisualTerrainSettings).GetProperty(nameof(Ps3MeshScatteringInstanceCellMemoryEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
