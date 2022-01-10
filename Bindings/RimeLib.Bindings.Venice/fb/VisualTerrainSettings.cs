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

		public static void Deserialize(VisualTerrainSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec2.Deserialize(p_Instance.DebugOverlayBrushCoverageMin, p_Reader, p_Parser);
			p_Instance.RenderMode = (TerrainRenderMode) p_Reader.ReadInt32();
			p_Instance.MeshScatteringInstanceCullJobCount = p_Reader.ReadUInt32();
			p_Instance.PatchErrorFov = p_Reader.ReadSingle();
			p_Instance.TriangleSizeMin = p_Reader.ReadSingle();
			p_Instance.LodScale = p_Reader.ReadSingle();
			p_Instance.LodCenterExtrapolationDistanceMax = p_Reader.ReadSingle();
			p_Instance.LodCenterExtrapolationTime = p_Reader.ReadSingle();
			p_Instance.MeshScatteringDensityScaleFactor = p_Reader.ReadSingle();
			p_Instance.DxTessellatedTriWidth = p_Reader.ReadSingle();
			p_Instance.DxTessellationPatchShrink = p_Reader.ReadSingle();
			p_Instance.DxTessellationPatchFacesPerSide = p_Reader.ReadUInt32();
			p_Instance.ZPassDistance = p_Reader.ReadSingle();
			p_Instance.DebugOverlayGridSize = p_Reader.ReadSingle();
			p_Instance.TextureAtlasSampleCountXFactor = p_Reader.ReadUInt32();
			p_Instance.TextureAtlasSampleCountYFactor = p_Reader.ReadUInt32();
			p_Instance.TextureSamplesPerMeterMax = p_Reader.ReadSingle();
			p_Instance.TextureDetailFalloffFactor = p_Reader.ReadSingle();
			p_Instance.TextureDetailFalloffDistance = p_Reader.ReadSingle();
			p_Instance.TextureDetailFalloffCurve = p_Reader.ReadSingle();
			p_Instance.TextureInvisibleDetailReductionFactor = p_Reader.ReadSingle();
			p_Instance.TextureOccludedDetailReductionFactor = p_Reader.ReadSingle();
			p_Instance.TextureRenderJobCount = p_Reader.ReadUInt32();
			p_Instance.MeshScatteringDistanceScaleFactor = p_Reader.ReadSingle();
			p_Instance.DebugOverlayIsolineSpacing = p_Reader.ReadSingle();
			p_Instance.TextureRenderJobsLaunchedPerFrameCountMax = p_Reader.ReadUInt32();
			p_Instance.TextureTileSamplesPerSide = p_Reader.ReadUInt32();
			p_Instance.TextureTileBorderWidth = p_Reader.ReadUInt32();
			p_Instance.TextureLevelOffset = p_Reader.ReadInt32();
			p_Instance.TextureClodFrameCount = p_Reader.ReadUInt32();
			p_Instance.MeshScatteringDensityMarginFactor = p_Reader.ReadSingle();
			p_Instance.TextureClodCutoffPriority = p_Reader.ReadSingle();
			p_Instance.MeshScatteringWindSpeed = p_Reader.ReadSingle();
			p_Instance.TextureCompressJobCount = p_Reader.ReadUInt32();
			p_Instance.MeshScatteringInstancesPerCellMax = p_Reader.ReadUInt32();
			p_Instance.TextureCompressionQuality = p_Reader.ReadInt32();
			p_Instance.TextureDetailSlopeBoost = p_Reader.ReadSingle();
			p_Instance.TextureGenerationMipBias = p_Reader.ReadSingle();
			p_Instance.DebugOverlayBrushSize = p_Reader.ReadSingle();
			p_Instance.MeshScatteringBuildChannelCount = p_Reader.ReadUInt32();
			p_Instance.MeshScatteringTreeNodePoolCapacity = p_Reader.ReadUInt32();
			p_Instance.MeshScatteringInvisibleCellFovFactor = p_Reader.ReadSingle();
			p_Instance.MeshScatteringInstanceCullListCount = p_Reader.ReadUInt32();
			p_Instance.MeshScatteringPregenerationDistanceRatio = p_Reader.ReadSingle();
			p_Instance.TessellationFacesPerSideMin = p_Reader.ReadUInt32();
			p_Instance.MaxNonVisibleTextureUpdateCount = p_Reader.ReadUInt32();
			p_Instance.TextureQuadsPerTileLevel = p_Reader.ReadUInt32();
			p_Instance.WaterDepthMetersPerSample = p_Reader.ReadSingle();
			p_Instance.DynamicMaskDecalWidthScale = p_Reader.ReadSingle();
			p_Instance.DrawQuadtreeZoomIndex = p_Reader.ReadInt32();
			p_Instance.MeshScatteringClodFrameCount = p_Reader.ReadUInt32();
			p_Instance.MeshScatteringBuildChannelsLaunchedPerFrameCountMax = p_Reader.ReadUInt32();
			p_Instance.SlotReuseWaitCount = p_Reader.ReadUInt32();
			p_Instance.MeshScatteringCellPoolCapacity = p_Reader.ReadUInt32();
			p_Instance.MeshScatteringCullRecordCount = p_Reader.ReadUInt32();
			p_Instance.PatchSlotCount = p_Reader.ReadUInt32();
			p_Instance.BuildJobCount = p_Reader.ReadUInt32();
			p_Instance.OccluderLodBoostLevelCount = p_Reader.ReadUInt32();
			p_Instance.DecalZPassDrawDistance = p_Reader.ReadSingle();
			p_Instance.DecalOffsetY = p_Reader.ReadSingle();
			p_Instance.Decal3dFarDrawDistanceScaleFactor = p_Reader.ReadSingle();
			p_Instance.OccludedMinDistance = p_Reader.ReadSingle();
			p_Instance.PatchFacesPerSide = p_Reader.ReadUInt32();
			p_Instance.DrawOnlyDecalZPassEnable = p_Reader.ReadBool();
			p_Instance.DrawDecal3dEnable = p_Reader.ReadBool();
			p_Instance.DrawTextureTileBoxesEnable = p_Reader.ReadBool();
			p_Instance.DrawEnable = p_Reader.ReadBool();
			p_Instance.DrawPatchBoxesEnable = p_Reader.ReadBool();
			p_Instance.DrawDebugTextEnable = p_Reader.ReadBool();
			p_Instance.DrawWaterEnable = p_Reader.ReadBool();
			p_Instance.PrioritizationSpuJobEnable = p_Reader.ReadBool();
			p_Instance.DrawDecalZPassEnable = p_Reader.ReadBool();
			p_Instance.DrawQuadtreesEnable = p_Reader.ReadBool();
			p_Instance.TextureVtIndirectionJobEnable = p_Reader.ReadBool();
			p_Instance.VertexBufferHeightsEnable = p_Reader.ReadBool();
			p_Instance.DrawDebugTexturesEnable = p_Reader.ReadBool();
			p_Instance.ForceDecalReducedQuality = p_Reader.ReadBool();
			p_Instance.DebugOverlayIsolinesEnable = p_Reader.ReadBool();
			p_Instance.TextureClodEnable = p_Reader.ReadBool();
			p_Instance.DebugOverlayWireframeEnable = p_Reader.ReadBool();
			p_Instance.DebugOverlaySketchTextureEnable = p_Reader.ReadBool();
			p_Instance.DrawDecal2dEnable = p_Reader.ReadBool();
			p_Instance.DetailOverlayEnable = p_Reader.ReadBool();
			p_Instance.DecalEnable = p_Reader.ReadBool();
			p_Instance.DrawPatchesEnable = p_Reader.ReadBool();
			p_Instance.DrawQuadtreeStatsEnable = p_Reader.ReadBool();
			p_Instance.DestroyAll = p_Reader.ReadBool();
			p_Instance.DrawQuadtreeAtlasTexturesEnable = p_Reader.ReadBool();
			p_Instance.SlotDebugOutputEnable = p_Reader.ReadBool();
			p_Instance.UpdateJobsEnable = p_Reader.ReadBool();
			p_Instance.PrioritizationOcclusionEnable = p_Reader.ReadBool();
			p_Instance.CullSpuJobEnable = p_Reader.ReadBool();
			p_Instance.PrepareBuildSpuJobEnable = p_Reader.ReadBool();
			p_Instance.BuildSpuJobEnable = p_Reader.ReadBool();
			p_Instance.RegenerateTexturesEnable = p_Reader.ReadBool();
			p_Instance.DynamicMaskEnable = p_Reader.ReadBool();
			p_Instance.GpuTextureCompressionEnable = p_Reader.ReadBool();
			p_Instance.TextureBlockOnStreamingEnable = p_Reader.ReadBool();
			p_Instance.PatchErrorFovEnable = p_Reader.ReadBool();
			p_Instance.DxDisplacementMappingEnable = p_Reader.ReadBool();
			p_Instance.TextureKeepPoolFullEnable = p_Reader.ReadBool();
			p_Instance.PatchLodTransitionsEnable = p_Reader.ReadBool();
			p_Instance.PatchMaterialSortingEnable = p_Reader.ReadBool();
			p_Instance.CullSampleBoundingBoxHeightEnable = p_Reader.ReadBool();
			p_Instance.CastShadowsEnable = p_Reader.ReadBool();
			p_Instance.GlobalColormapEnable = p_Reader.ReadBool();
			p_Instance.OccluderEnable = p_Reader.ReadBool();
			p_Instance.OccluderJobEnable = p_Reader.ReadBool();
			p_Instance.OccluderSpuJobEnable = p_Reader.ReadBool();
			p_Instance.TextureLayerCullingEnable = p_Reader.ReadBool();
			p_Instance.OccludedEnable = p_Reader.ReadBool();
			p_Instance.DrawTextureDebugDepthComplexity = p_Reader.ReadBool();
			p_Instance.MeshScatteringEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringJobsEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringCastShadowsEnable = p_Reader.ReadBool();
			p_Instance.DrawMeshScatteringEnable = p_Reader.ReadBool();
			p_Instance.DrawMeshScatteringCellBoxesEnable = p_Reader.ReadBool();
			p_Instance.DrawMeshScatteringNodeBoxesEnable = p_Reader.ReadBool();
			p_Instance.DrawMeshScatteringCulledCellBoxesEnable = p_Reader.ReadBool();
			p_Instance.DrawMeshScatteringDebugMaskScaleTexturesEnable = p_Reader.ReadBool();
			p_Instance.DrawMeshScatteringStatsEnable = p_Reader.ReadBool();
			p_Instance.DrawMeshScatteringQuadtreeEnable = p_Reader.ReadBool();
			p_Instance.TextureDrawTerrainLayersEnable = p_Reader.ReadBool();
			p_Instance.TextureForceUpdateEnable = p_Reader.ReadBool();
			p_Instance.TextureCompressFastAlgorithmEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringForceUpdateEnable = p_Reader.ReadBool();
			p_Instance.TextureCompressSpuJobsEnable = p_Reader.ReadBool();
			p_Instance.DrawTextureDebugColors = p_Reader.ReadBool();
			p_Instance.ForceGraphicsDriverCrash = p_Reader.ReadBool();
			p_Instance.MeshScatteringBuildVisibleFirst = p_Reader.ReadBool();
			p_Instance.ForcePatchRebuildEnable = p_Reader.ReadBool();
			p_Instance.DebugOverlayBrushEnable = p_Reader.ReadBool();
			p_Instance.WireframeEnable = p_Reader.ReadBool();
			p_Instance.TextureVtIndirectionSpuJobEnable = p_Reader.ReadBool();
			p_Instance.DrawVertexYTextureEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringInstanceCountLodEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringCullSpuJobEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringInstanceCullSpuJobEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringPrioritizationSpuJobEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringSpuJobEnable = p_Reader.ReadBool();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Instance.EditServiceEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringInstanceCullEnable = p_Reader.ReadBool();
			p_Instance.ZeroViewportEnable = p_Reader.ReadBool();
			p_Instance.DebugOverlayGridEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringInstanceCullBoxTestEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringInstanceFrustumCullEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringInstanceOcclusionCullEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringInstanceAdditionalCullEnable = p_Reader.ReadBool();
			p_Instance.DrawMeshScatteringInstanceBoxesEnable = p_Reader.ReadBool();
			p_Instance.MeshScatteringInstanceCullDynamicAllocEnable = p_Reader.ReadBool();
			p_Instance.Ps3MeshScatteringInstanceCellMemoryEnable = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
