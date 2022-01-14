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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 356)]
	public class VisualTerrainSettings : 
		DataContainer
	{
		[ContainerField(8), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public Vec2 DebugOverlayBrushCoverageMin { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public TerrainRenderMode RenderMode { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint MeshScatteringInstanceCullJobCount { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float PatchErrorFov { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float TriangleSizeMin { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float LodScale { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float LodCenterExtrapolationDistanceMax { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float LodCenterExtrapolationTime { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float MeshScatteringDensityScaleFactor { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float DxTessellatedTriWidth { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float DxTessellationPatchShrink { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public uint DxTessellationPatchFacesPerSide { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float ZPassDistance { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float DebugOverlayGridSize { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public uint TextureAtlasSampleCountXFactor { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public uint TextureAtlasSampleCountYFactor { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float TextureSamplesPerMeterMax { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float TextureDetailFalloffFactor { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float TextureDetailFalloffDistance { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float TextureDetailFalloffCurve { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float TextureInvisibleDetailReductionFactor { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float TextureOccludedDetailReductionFactor { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public uint TextureRenderJobCount { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float MeshScatteringDistanceScaleFactor { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float DebugOverlayIsolineSpacing { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public uint TextureRenderJobsLaunchedPerFrameCountMax { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public uint TextureTileSamplesPerSide { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public uint TextureTileBorderWidth { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public int TextureLevelOffset { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public uint TextureClodFrameCount { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float MeshScatteringDensityMarginFactor { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float TextureClodCutoffPriority { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float MeshScatteringWindSpeed { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public uint TextureCompressJobCount { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public uint MeshScatteringInstancesPerCellMax { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public int TextureCompressionQuality { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float TextureDetailSlopeBoost { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float TextureGenerationMipBias { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float DebugOverlayBrushSize { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public uint MeshScatteringBuildChannelCount { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public uint MeshScatteringTreeNodePoolCapacity { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float MeshScatteringInvisibleCellFovFactor { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public uint MeshScatteringInstanceCullListCount { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float MeshScatteringPregenerationDistanceRatio { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public uint TessellationFacesPerSideMin { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public uint MaxNonVisibleTextureUpdateCount { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public uint TextureQuadsPerTileLevel { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public float WaterDepthMetersPerSample { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public float DynamicMaskDecalWidthScale { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public int DrawQuadtreeZoomIndex { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public uint MeshScatteringClodFrameCount { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public uint MeshScatteringBuildChannelsLaunchedPerFrameCountMax { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public uint SlotReuseWaitCount { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public uint MeshScatteringCellPoolCapacity { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public uint MeshScatteringCullRecordCount { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public uint PatchSlotCount { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public uint BuildJobCount { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public uint OccluderLodBoostLevelCount { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public float DecalZPassDrawDistance { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		public float DecalOffsetY { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		public float Decal3dFarDrawDistanceScaleFactor { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public float OccludedMinDistance { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		public uint PatchFacesPerSide { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		public bool DrawOnlyDecalZPassEnable { get; set; }

		[ContainerField(265), LayoutImmutable, Blittable, JsonProperty(Order = 265)]
		public bool DrawDecal3dEnable { get; set; }

		[ContainerField(266), LayoutImmutable, Blittable, JsonProperty(Order = 266)]
		public bool DrawTextureTileBoxesEnable { get; set; }

		[ContainerField(267), LayoutImmutable, Blittable, JsonProperty(Order = 267)]
		public bool DrawEnable { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		public bool DrawPatchBoxesEnable { get; set; }

		[ContainerField(269), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
		public bool DrawDebugTextEnable { get; set; }

		[ContainerField(270), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
		public bool DrawWaterEnable { get; set; }

		[ContainerField(271), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
		public bool PrioritizationSpuJobEnable { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		public bool DrawDecalZPassEnable { get; set; }

		[ContainerField(273), LayoutImmutable, Blittable, JsonProperty(Order = 273)]
		public bool DrawQuadtreesEnable { get; set; }

		[ContainerField(274), LayoutImmutable, Blittable, JsonProperty(Order = 274)]
		public bool TextureVtIndirectionJobEnable { get; set; }

		[ContainerField(275), LayoutImmutable, Blittable, JsonProperty(Order = 275)]
		public bool VertexBufferHeightsEnable { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		public bool DrawDebugTexturesEnable { get; set; }

		[ContainerField(277), LayoutImmutable, Blittable, JsonProperty(Order = 277)]
		public bool ForceDecalReducedQuality { get; set; }

		[ContainerField(278), LayoutImmutable, Blittable, JsonProperty(Order = 278)]
		public bool DebugOverlayIsolinesEnable { get; set; }

		[ContainerField(279), LayoutImmutable, Blittable, JsonProperty(Order = 279)]
		public bool TextureClodEnable { get; set; }

		[ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		public bool DebugOverlayWireframeEnable { get; set; }

		[ContainerField(281), LayoutImmutable, Blittable, JsonProperty(Order = 281)]
		public bool DebugOverlaySketchTextureEnable { get; set; }

		[ContainerField(282), LayoutImmutable, Blittable, JsonProperty(Order = 282)]
		public bool DrawDecal2dEnable { get; set; }

		[ContainerField(283), LayoutImmutable, Blittable, JsonProperty(Order = 283)]
		public bool DetailOverlayEnable { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		public bool DecalEnable { get; set; }

		[ContainerField(285), LayoutImmutable, Blittable, JsonProperty(Order = 285)]
		public bool DrawPatchesEnable { get; set; }

		[ContainerField(286), LayoutImmutable, Blittable, JsonProperty(Order = 286)]
		public bool DrawQuadtreeStatsEnable { get; set; }

		[ContainerField(287), LayoutImmutable, Blittable, JsonProperty(Order = 287)]
		public bool DestroyAll { get; set; }

		[ContainerField(288), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		public bool DrawQuadtreeAtlasTexturesEnable { get; set; }

		[ContainerField(289), LayoutImmutable, Blittable, JsonProperty(Order = 289)]
		public bool SlotDebugOutputEnable { get; set; }

		[ContainerField(290), LayoutImmutable, Blittable, JsonProperty(Order = 290)]
		public bool UpdateJobsEnable { get; set; }

		[ContainerField(291), LayoutImmutable, Blittable, JsonProperty(Order = 291)]
		public bool PrioritizationOcclusionEnable { get; set; }

		[ContainerField(292), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
		public bool CullSpuJobEnable { get; set; }

		[ContainerField(293), LayoutImmutable, Blittable, JsonProperty(Order = 293)]
		public bool PrepareBuildSpuJobEnable { get; set; }

		[ContainerField(294), LayoutImmutable, Blittable, JsonProperty(Order = 294)]
		public bool BuildSpuJobEnable { get; set; }

		[ContainerField(295), LayoutImmutable, Blittable, JsonProperty(Order = 295)]
		public bool RegenerateTexturesEnable { get; set; }

		[ContainerField(296), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		public bool DynamicMaskEnable { get; set; }

		[ContainerField(297), LayoutImmutable, Blittable, JsonProperty(Order = 297)]
		public bool GpuTextureCompressionEnable { get; set; }

		[ContainerField(298), LayoutImmutable, Blittable, JsonProperty(Order = 298)]
		public bool TextureBlockOnStreamingEnable { get; set; }

		[ContainerField(299), LayoutImmutable, Blittable, JsonProperty(Order = 299)]
		public bool PatchErrorFovEnable { get; set; }

		[ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		public bool DxDisplacementMappingEnable { get; set; }

		[ContainerField(301), LayoutImmutable, Blittable, JsonProperty(Order = 301)]
		public bool TextureKeepPoolFullEnable { get; set; }

		[ContainerField(302), LayoutImmutable, Blittable, JsonProperty(Order = 302)]
		public bool PatchLodTransitionsEnable { get; set; }

		[ContainerField(303), LayoutImmutable, Blittable, JsonProperty(Order = 303)]
		public bool PatchMaterialSortingEnable { get; set; }

		[ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		public bool CullSampleBoundingBoxHeightEnable { get; set; }

		[ContainerField(305), LayoutImmutable, Blittable, JsonProperty(Order = 305)]
		public bool CastShadowsEnable { get; set; }

		[ContainerField(306), LayoutImmutable, Blittable, JsonProperty(Order = 306)]
		public bool GlobalColormapEnable { get; set; }

		[ContainerField(307), LayoutImmutable, Blittable, JsonProperty(Order = 307)]
		public bool OccluderEnable { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		public bool OccluderJobEnable { get; set; }

		[ContainerField(309), LayoutImmutable, Blittable, JsonProperty(Order = 309)]
		public bool OccluderSpuJobEnable { get; set; }

		[ContainerField(310), LayoutImmutable, Blittable, JsonProperty(Order = 310)]
		public bool TextureLayerCullingEnable { get; set; }

		[ContainerField(311), LayoutImmutable, Blittable, JsonProperty(Order = 311)]
		public bool OccludedEnable { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		public bool DrawTextureDebugDepthComplexity { get; set; }

		[ContainerField(313), LayoutImmutable, Blittable, JsonProperty(Order = 313)]
		public bool MeshScatteringEnable { get; set; }

		[ContainerField(314), LayoutImmutable, Blittable, JsonProperty(Order = 314)]
		public bool MeshScatteringJobsEnable { get; set; }

		[ContainerField(315), LayoutImmutable, Blittable, JsonProperty(Order = 315)]
		public bool MeshScatteringCastShadowsEnable { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		public bool DrawMeshScatteringEnable { get; set; }

		[ContainerField(317), LayoutImmutable, Blittable, JsonProperty(Order = 317)]
		public bool DrawMeshScatteringCellBoxesEnable { get; set; }

		[ContainerField(318), LayoutImmutable, Blittable, JsonProperty(Order = 318)]
		public bool DrawMeshScatteringNodeBoxesEnable { get; set; }

		[ContainerField(319), LayoutImmutable, Blittable, JsonProperty(Order = 319)]
		public bool DrawMeshScatteringCulledCellBoxesEnable { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		public bool DrawMeshScatteringDebugMaskScaleTexturesEnable { get; set; }

		[ContainerField(321), LayoutImmutable, Blittable, JsonProperty(Order = 321)]
		public bool DrawMeshScatteringStatsEnable { get; set; }

		[ContainerField(322), LayoutImmutable, Blittable, JsonProperty(Order = 322)]
		public bool DrawMeshScatteringQuadtreeEnable { get; set; }

		[ContainerField(323), LayoutImmutable, Blittable, JsonProperty(Order = 323)]
		public bool TextureDrawTerrainLayersEnable { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		public bool TextureForceUpdateEnable { get; set; }

		[ContainerField(325), LayoutImmutable, Blittable, JsonProperty(Order = 325)]
		public bool TextureCompressFastAlgorithmEnable { get; set; }

		[ContainerField(326), LayoutImmutable, Blittable, JsonProperty(Order = 326)]
		public bool MeshScatteringForceUpdateEnable { get; set; }

		[ContainerField(327), LayoutImmutable, Blittable, JsonProperty(Order = 327)]
		public bool TextureCompressSpuJobsEnable { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		public bool DrawTextureDebugColors { get; set; }

		[ContainerField(329), LayoutImmutable, Blittable, JsonProperty(Order = 329)]
		public bool ForceGraphicsDriverCrash { get; set; }

		[ContainerField(330), LayoutImmutable, Blittable, JsonProperty(Order = 330)]
		public bool MeshScatteringBuildVisibleFirst { get; set; }

		[ContainerField(331), LayoutImmutable, Blittable, JsonProperty(Order = 331)]
		public bool ForcePatchRebuildEnable { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		public bool DebugOverlayBrushEnable { get; set; }

		[ContainerField(333), LayoutImmutable, Blittable, JsonProperty(Order = 333)]
		public bool WireframeEnable { get; set; }

		[ContainerField(334), LayoutImmutable, Blittable, JsonProperty(Order = 334)]
		public bool TextureVtIndirectionSpuJobEnable { get; set; }

		[ContainerField(335), LayoutImmutable, Blittable, JsonProperty(Order = 335)]
		public bool DrawVertexYTextureEnable { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		public bool MeshScatteringInstanceCountLodEnable { get; set; }

		[ContainerField(337), LayoutImmutable, Blittable, JsonProperty(Order = 337)]
		public bool MeshScatteringCullSpuJobEnable { get; set; }

		[ContainerField(338), LayoutImmutable, Blittable, JsonProperty(Order = 338)]
		public bool MeshScatteringInstanceCullSpuJobEnable { get; set; }

		[ContainerField(339), LayoutImmutable, Blittable, JsonProperty(Order = 339)]
		public bool MeshScatteringPrioritizationSpuJobEnable { get; set; }

		[ContainerField(340), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
		public bool MeshScatteringSpuJobEnable { get; set; }

		[ContainerField(341), LayoutImmutable, Blittable, JsonProperty(Order = 341)]
		public bool Enable { get; set; }

		[ContainerField(342), LayoutImmutable, Blittable, JsonProperty(Order = 342)]
		public bool EditServiceEnable { get; set; }

		[ContainerField(343), LayoutImmutable, Blittable, JsonProperty(Order = 343)]
		public bool MeshScatteringInstanceCullEnable { get; set; }

		[ContainerField(344), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
		public bool ZeroViewportEnable { get; set; }

		[ContainerField(345), LayoutImmutable, Blittable, JsonProperty(Order = 345)]
		public bool DebugOverlayGridEnable { get; set; }

		[ContainerField(346), LayoutImmutable, Blittable, JsonProperty(Order = 346)]
		public bool MeshScatteringInstanceCullBoxTestEnable { get; set; }

		[ContainerField(347), LayoutImmutable, Blittable, JsonProperty(Order = 347)]
		public bool MeshScatteringInstanceFrustumCullEnable { get; set; }

		[ContainerField(348), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
		public bool MeshScatteringInstanceOcclusionCullEnable { get; set; }

		[ContainerField(349), LayoutImmutable, Blittable, JsonProperty(Order = 349)]
		public bool MeshScatteringInstanceAdditionalCullEnable { get; set; }

		[ContainerField(350), LayoutImmutable, Blittable, JsonProperty(Order = 350)]
		public bool DrawMeshScatteringInstanceBoxesEnable { get; set; }

		[ContainerField(351), LayoutImmutable, Blittable, JsonProperty(Order = 351)]
		public bool MeshScatteringInstanceCullDynamicAllocEnable { get; set; }

		[ContainerField(352), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		public bool Ps3MeshScatteringInstanceCellMemoryEnable { get; set; }

	}
}
