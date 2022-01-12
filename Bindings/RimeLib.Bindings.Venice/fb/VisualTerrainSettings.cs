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
	[ContainerType(4, 356)]
	public class VisualTerrainSettings : 
		DataContainer
	{
		[ContainerField(8), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 DebugOverlayBrushCoverageMin { get; set; } = new();

		[ContainerField(16)]
		public TerrainRenderMode RenderMode { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint MeshScatteringInstanceCullJobCount { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float PatchErrorFov { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float TriangleSizeMin { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float LodScale { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float LodCenterExtrapolationDistanceMax { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float LodCenterExtrapolationTime { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float MeshScatteringDensityScaleFactor { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float DxTessellatedTriWidth { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float DxTessellationPatchShrink { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public uint DxTessellationPatchFacesPerSide { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float ZPassDistance { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float DebugOverlayGridSize { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public uint TextureAtlasSampleCountXFactor { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public uint TextureAtlasSampleCountYFactor { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float TextureSamplesPerMeterMax { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float TextureDetailFalloffFactor { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float TextureDetailFalloffDistance { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float TextureDetailFalloffCurve { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float TextureInvisibleDetailReductionFactor { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float TextureOccludedDetailReductionFactor { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public uint TextureRenderJobCount { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float MeshScatteringDistanceScaleFactor { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float DebugOverlayIsolineSpacing { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public uint TextureRenderJobsLaunchedPerFrameCountMax { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public uint TextureTileSamplesPerSide { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public uint TextureTileBorderWidth { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public int TextureLevelOffset { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public uint TextureClodFrameCount { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float MeshScatteringDensityMarginFactor { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float TextureClodCutoffPriority { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float MeshScatteringWindSpeed { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public uint TextureCompressJobCount { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public uint MeshScatteringInstancesPerCellMax { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public int TextureCompressionQuality { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float TextureDetailSlopeBoost { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float TextureGenerationMipBias { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float DebugOverlayBrushSize { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public uint MeshScatteringBuildChannelCount { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public uint MeshScatteringTreeNodePoolCapacity { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float MeshScatteringInvisibleCellFovFactor { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public uint MeshScatteringInstanceCullListCount { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float MeshScatteringPregenerationDistanceRatio { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public uint TessellationFacesPerSideMin { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public uint MaxNonVisibleTextureUpdateCount { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public uint TextureQuadsPerTileLevel { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public float WaterDepthMetersPerSample { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public float DynamicMaskDecalWidthScale { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public int DrawQuadtreeZoomIndex { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public uint MeshScatteringClodFrameCount { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public uint MeshScatteringBuildChannelsLaunchedPerFrameCountMax { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public uint SlotReuseWaitCount { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public uint MeshScatteringCellPoolCapacity { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable]
		public uint MeshScatteringCullRecordCount { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable]
		public uint PatchSlotCount { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public uint BuildJobCount { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public uint OccluderLodBoostLevelCount { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public float DecalZPassDrawDistance { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable]
		public float DecalOffsetY { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable]
		public float Decal3dFarDrawDistanceScaleFactor { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable]
		public float OccludedMinDistance { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable]
		public uint PatchFacesPerSide { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable]
		public bool DrawOnlyDecalZPassEnable { get; set; }

		[ContainerField(265), LayoutImmutable, Blittable]
		public bool DrawDecal3dEnable { get; set; }

		[ContainerField(266), LayoutImmutable, Blittable]
		public bool DrawTextureTileBoxesEnable { get; set; }

		[ContainerField(267), LayoutImmutable, Blittable]
		public bool DrawEnable { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable]
		public bool DrawPatchBoxesEnable { get; set; }

		[ContainerField(269), LayoutImmutable, Blittable]
		public bool DrawDebugTextEnable { get; set; }

		[ContainerField(270), LayoutImmutable, Blittable]
		public bool DrawWaterEnable { get; set; }

		[ContainerField(271), LayoutImmutable, Blittable]
		public bool PrioritizationSpuJobEnable { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable]
		public bool DrawDecalZPassEnable { get; set; }

		[ContainerField(273), LayoutImmutable, Blittable]
		public bool DrawQuadtreesEnable { get; set; }

		[ContainerField(274), LayoutImmutable, Blittable]
		public bool TextureVtIndirectionJobEnable { get; set; }

		[ContainerField(275), LayoutImmutable, Blittable]
		public bool VertexBufferHeightsEnable { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable]
		public bool DrawDebugTexturesEnable { get; set; }

		[ContainerField(277), LayoutImmutable, Blittable]
		public bool ForceDecalReducedQuality { get; set; }

		[ContainerField(278), LayoutImmutable, Blittable]
		public bool DebugOverlayIsolinesEnable { get; set; }

		[ContainerField(279), LayoutImmutable, Blittable]
		public bool TextureClodEnable { get; set; }

		[ContainerField(280), LayoutImmutable, Blittable]
		public bool DebugOverlayWireframeEnable { get; set; }

		[ContainerField(281), LayoutImmutable, Blittable]
		public bool DebugOverlaySketchTextureEnable { get; set; }

		[ContainerField(282), LayoutImmutable, Blittable]
		public bool DrawDecal2dEnable { get; set; }

		[ContainerField(283), LayoutImmutable, Blittable]
		public bool DetailOverlayEnable { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable]
		public bool DecalEnable { get; set; }

		[ContainerField(285), LayoutImmutable, Blittable]
		public bool DrawPatchesEnable { get; set; }

		[ContainerField(286), LayoutImmutable, Blittable]
		public bool DrawQuadtreeStatsEnable { get; set; }

		[ContainerField(287), LayoutImmutable, Blittable]
		public bool DestroyAll { get; set; }

		[ContainerField(288), LayoutImmutable, Blittable]
		public bool DrawQuadtreeAtlasTexturesEnable { get; set; }

		[ContainerField(289), LayoutImmutable, Blittable]
		public bool SlotDebugOutputEnable { get; set; }

		[ContainerField(290), LayoutImmutable, Blittable]
		public bool UpdateJobsEnable { get; set; }

		[ContainerField(291), LayoutImmutable, Blittable]
		public bool PrioritizationOcclusionEnable { get; set; }

		[ContainerField(292), LayoutImmutable, Blittable]
		public bool CullSpuJobEnable { get; set; }

		[ContainerField(293), LayoutImmutable, Blittable]
		public bool PrepareBuildSpuJobEnable { get; set; }

		[ContainerField(294), LayoutImmutable, Blittable]
		public bool BuildSpuJobEnable { get; set; }

		[ContainerField(295), LayoutImmutable, Blittable]
		public bool RegenerateTexturesEnable { get; set; }

		[ContainerField(296), LayoutImmutable, Blittable]
		public bool DynamicMaskEnable { get; set; }

		[ContainerField(297), LayoutImmutable, Blittable]
		public bool GpuTextureCompressionEnable { get; set; }

		[ContainerField(298), LayoutImmutable, Blittable]
		public bool TextureBlockOnStreamingEnable { get; set; }

		[ContainerField(299), LayoutImmutable, Blittable]
		public bool PatchErrorFovEnable { get; set; }

		[ContainerField(300), LayoutImmutable, Blittable]
		public bool DxDisplacementMappingEnable { get; set; }

		[ContainerField(301), LayoutImmutable, Blittable]
		public bool TextureKeepPoolFullEnable { get; set; }

		[ContainerField(302), LayoutImmutable, Blittable]
		public bool PatchLodTransitionsEnable { get; set; }

		[ContainerField(303), LayoutImmutable, Blittable]
		public bool PatchMaterialSortingEnable { get; set; }

		[ContainerField(304), LayoutImmutable, Blittable]
		public bool CullSampleBoundingBoxHeightEnable { get; set; }

		[ContainerField(305), LayoutImmutable, Blittable]
		public bool CastShadowsEnable { get; set; }

		[ContainerField(306), LayoutImmutable, Blittable]
		public bool GlobalColormapEnable { get; set; }

		[ContainerField(307), LayoutImmutable, Blittable]
		public bool OccluderEnable { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable]
		public bool OccluderJobEnable { get; set; }

		[ContainerField(309), LayoutImmutable, Blittable]
		public bool OccluderSpuJobEnable { get; set; }

		[ContainerField(310), LayoutImmutable, Blittable]
		public bool TextureLayerCullingEnable { get; set; }

		[ContainerField(311), LayoutImmutable, Blittable]
		public bool OccludedEnable { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable]
		public bool DrawTextureDebugDepthComplexity { get; set; }

		[ContainerField(313), LayoutImmutable, Blittable]
		public bool MeshScatteringEnable { get; set; }

		[ContainerField(314), LayoutImmutable, Blittable]
		public bool MeshScatteringJobsEnable { get; set; }

		[ContainerField(315), LayoutImmutable, Blittable]
		public bool MeshScatteringCastShadowsEnable { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringEnable { get; set; }

		[ContainerField(317), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringCellBoxesEnable { get; set; }

		[ContainerField(318), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringNodeBoxesEnable { get; set; }

		[ContainerField(319), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringCulledCellBoxesEnable { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringDebugMaskScaleTexturesEnable { get; set; }

		[ContainerField(321), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringStatsEnable { get; set; }

		[ContainerField(322), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringQuadtreeEnable { get; set; }

		[ContainerField(323), LayoutImmutable, Blittable]
		public bool TextureDrawTerrainLayersEnable { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable]
		public bool TextureForceUpdateEnable { get; set; }

		[ContainerField(325), LayoutImmutable, Blittable]
		public bool TextureCompressFastAlgorithmEnable { get; set; }

		[ContainerField(326), LayoutImmutable, Blittable]
		public bool MeshScatteringForceUpdateEnable { get; set; }

		[ContainerField(327), LayoutImmutable, Blittable]
		public bool TextureCompressSpuJobsEnable { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable]
		public bool DrawTextureDebugColors { get; set; }

		[ContainerField(329), LayoutImmutable, Blittable]
		public bool ForceGraphicsDriverCrash { get; set; }

		[ContainerField(330), LayoutImmutable, Blittable]
		public bool MeshScatteringBuildVisibleFirst { get; set; }

		[ContainerField(331), LayoutImmutable, Blittable]
		public bool ForcePatchRebuildEnable { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable]
		public bool DebugOverlayBrushEnable { get; set; }

		[ContainerField(333), LayoutImmutable, Blittable]
		public bool WireframeEnable { get; set; }

		[ContainerField(334), LayoutImmutable, Blittable]
		public bool TextureVtIndirectionSpuJobEnable { get; set; }

		[ContainerField(335), LayoutImmutable, Blittable]
		public bool DrawVertexYTextureEnable { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceCountLodEnable { get; set; }

		[ContainerField(337), LayoutImmutable, Blittable]
		public bool MeshScatteringCullSpuJobEnable { get; set; }

		[ContainerField(338), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceCullSpuJobEnable { get; set; }

		[ContainerField(339), LayoutImmutable, Blittable]
		public bool MeshScatteringPrioritizationSpuJobEnable { get; set; }

		[ContainerField(340), LayoutImmutable, Blittable]
		public bool MeshScatteringSpuJobEnable { get; set; }

		[ContainerField(341), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(342), LayoutImmutable, Blittable]
		public bool EditServiceEnable { get; set; }

		[ContainerField(343), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceCullEnable { get; set; }

		[ContainerField(344), LayoutImmutable, Blittable]
		public bool ZeroViewportEnable { get; set; }

		[ContainerField(345), LayoutImmutable, Blittable]
		public bool DebugOverlayGridEnable { get; set; }

		[ContainerField(346), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceCullBoxTestEnable { get; set; }

		[ContainerField(347), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceFrustumCullEnable { get; set; }

		[ContainerField(348), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceOcclusionCullEnable { get; set; }

		[ContainerField(349), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceAdditionalCullEnable { get; set; }

		[ContainerField(350), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringInstanceBoxesEnable { get; set; }

		[ContainerField(351), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceCullDynamicAllocEnable { get; set; }

		[ContainerField(352), LayoutImmutable, Blittable]
		public bool Ps3MeshScatteringInstanceCellMemoryEnable { get; set; }

	}
}
