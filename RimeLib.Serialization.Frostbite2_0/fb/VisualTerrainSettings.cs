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
	[ContainerType(4, 356)]
	public partial class VisualTerrainSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private Vec2 _DebugOverlayBrushCoverageMin = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private TerrainRenderMode _RenderMode = new();

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _MeshScatteringInstanceCullJobCount;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _PatchErrorFov;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _TriangleSizeMin;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _LodScale;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _LodCenterExtrapolationDistanceMax;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _LodCenterExtrapolationTime;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _MeshScatteringDensityScaleFactor;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _DxTessellatedTriWidth;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _DxTessellationPatchShrink;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private uint _DxTessellationPatchFacesPerSide;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _ZPassDistance;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _DebugOverlayGridSize;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private uint _TextureAtlasSampleCountXFactor;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private uint _TextureAtlasSampleCountYFactor;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _TextureSamplesPerMeterMax;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _TextureDetailFalloffFactor;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _TextureDetailFalloffDistance;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _TextureDetailFalloffCurve;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _TextureInvisibleDetailReductionFactor;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _TextureOccludedDetailReductionFactor;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private uint _TextureRenderJobCount;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _MeshScatteringDistanceScaleFactor;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _DebugOverlayIsolineSpacing;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private uint _TextureRenderJobsLaunchedPerFrameCountMax;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private uint _TextureTileSamplesPerSide;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private uint _TextureTileBorderWidth;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private int _TextureLevelOffset;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private uint _TextureClodFrameCount;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _MeshScatteringDensityMarginFactor;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _TextureClodCutoffPriority;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _MeshScatteringWindSpeed;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private uint _TextureCompressJobCount;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private uint _MeshScatteringInstancesPerCellMax;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private int _TextureCompressionQuality;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _TextureDetailSlopeBoost;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _TextureGenerationMipBias;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _DebugOverlayBrushSize;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private uint _MeshScatteringBuildChannelCount;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private uint _MeshScatteringTreeNodePoolCapacity;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _MeshScatteringInvisibleCellFovFactor;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private uint _MeshScatteringInstanceCullListCount;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _MeshScatteringPregenerationDistanceRatio;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private uint _TessellationFacesPerSideMin;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private uint _MaxNonVisibleTextureUpdateCount;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private uint _TextureQuadsPerTileLevel;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _WaterDepthMetersPerSample;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private float _DynamicMaskDecalWidthScale;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private int _DrawQuadtreeZoomIndex;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private uint _MeshScatteringClodFrameCount;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private uint _MeshScatteringBuildChannelsLaunchedPerFrameCountMax;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private uint _SlotReuseWaitCount;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private uint _MeshScatteringCellPoolCapacity;

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private uint _MeshScatteringCullRecordCount;

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private uint _PatchSlotCount;

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private uint _BuildJobCount;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private uint _OccluderLodBoostLevelCount;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private float _DecalZPassDrawDistance;

		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private float _DecalOffsetY;

		[ObservableProperty]
		[property: ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		private float _Decal3dFarDrawDistanceScaleFactor;

		[ObservableProperty]
		[property: ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private float _OccludedMinDistance;

		[ObservableProperty]
		[property: ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		private uint _PatchFacesPerSide;

		[ObservableProperty]
		[property: ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		private bool _DrawOnlyDecalZPassEnable;

		[ObservableProperty]
		[property: ContainerField(265), LayoutImmutable, Blittable, JsonProperty(Order = 265)]
		private bool _DrawDecal3dEnable;

		[ObservableProperty]
		[property: ContainerField(266), LayoutImmutable, Blittable, JsonProperty(Order = 266)]
		private bool _DrawTextureTileBoxesEnable;

		[ObservableProperty]
		[property: ContainerField(267), LayoutImmutable, Blittable, JsonProperty(Order = 267)]
		private bool _DrawEnable;

		[ObservableProperty]
		[property: ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		private bool _DrawPatchBoxesEnable;

		[ObservableProperty]
		[property: ContainerField(269), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
		private bool _DrawDebugTextEnable;

		[ObservableProperty]
		[property: ContainerField(270), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
		private bool _DrawWaterEnable;

		[ObservableProperty]
		[property: ContainerField(271), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
		private bool _PrioritizationSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		private bool _DrawDecalZPassEnable;

		[ObservableProperty]
		[property: ContainerField(273), LayoutImmutable, Blittable, JsonProperty(Order = 273)]
		private bool _DrawQuadtreesEnable;

		[ObservableProperty]
		[property: ContainerField(274), LayoutImmutable, Blittable, JsonProperty(Order = 274)]
		private bool _TextureVtIndirectionJobEnable;

		[ObservableProperty]
		[property: ContainerField(275), LayoutImmutable, Blittable, JsonProperty(Order = 275)]
		private bool _VertexBufferHeightsEnable;

		[ObservableProperty]
		[property: ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		private bool _DrawDebugTexturesEnable;

		[ObservableProperty]
		[property: ContainerField(277), LayoutImmutable, Blittable, JsonProperty(Order = 277)]
		private bool _ForceDecalReducedQuality;

		[ObservableProperty]
		[property: ContainerField(278), LayoutImmutable, Blittable, JsonProperty(Order = 278)]
		private bool _DebugOverlayIsolinesEnable;

		[ObservableProperty]
		[property: ContainerField(279), LayoutImmutable, Blittable, JsonProperty(Order = 279)]
		private bool _TextureClodEnable;

		[ObservableProperty]
		[property: ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		private bool _DebugOverlayWireframeEnable;

		[ObservableProperty]
		[property: ContainerField(281), LayoutImmutable, Blittable, JsonProperty(Order = 281)]
		private bool _DebugOverlaySketchTextureEnable;

		[ObservableProperty]
		[property: ContainerField(282), LayoutImmutable, Blittable, JsonProperty(Order = 282)]
		private bool _DrawDecal2dEnable;

		[ObservableProperty]
		[property: ContainerField(283), LayoutImmutable, Blittable, JsonProperty(Order = 283)]
		private bool _DetailOverlayEnable;

		[ObservableProperty]
		[property: ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		private bool _DecalEnable;

		[ObservableProperty]
		[property: ContainerField(285), LayoutImmutable, Blittable, JsonProperty(Order = 285)]
		private bool _DrawPatchesEnable;

		[ObservableProperty]
		[property: ContainerField(286), LayoutImmutable, Blittable, JsonProperty(Order = 286)]
		private bool _DrawQuadtreeStatsEnable;

		[ObservableProperty]
		[property: ContainerField(287), LayoutImmutable, Blittable, JsonProperty(Order = 287)]
		private bool _DestroyAll;

		[ObservableProperty]
		[property: ContainerField(288), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		private bool _DrawQuadtreeAtlasTexturesEnable;

		[ObservableProperty]
		[property: ContainerField(289), LayoutImmutable, Blittable, JsonProperty(Order = 289)]
		private bool _SlotDebugOutputEnable;

		[ObservableProperty]
		[property: ContainerField(290), LayoutImmutable, Blittable, JsonProperty(Order = 290)]
		private bool _UpdateJobsEnable;

		[ObservableProperty]
		[property: ContainerField(291), LayoutImmutable, Blittable, JsonProperty(Order = 291)]
		private bool _PrioritizationOcclusionEnable;

		[ObservableProperty]
		[property: ContainerField(292), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
		private bool _CullSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(293), LayoutImmutable, Blittable, JsonProperty(Order = 293)]
		private bool _PrepareBuildSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(294), LayoutImmutable, Blittable, JsonProperty(Order = 294)]
		private bool _BuildSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(295), LayoutImmutable, Blittable, JsonProperty(Order = 295)]
		private bool _RegenerateTexturesEnable;

		[ObservableProperty]
		[property: ContainerField(296), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		private bool _DynamicMaskEnable;

		[ObservableProperty]
		[property: ContainerField(297), LayoutImmutable, Blittable, JsonProperty(Order = 297)]
		private bool _GpuTextureCompressionEnable;

		[ObservableProperty]
		[property: ContainerField(298), LayoutImmutable, Blittable, JsonProperty(Order = 298)]
		private bool _TextureBlockOnStreamingEnable;

		[ObservableProperty]
		[property: ContainerField(299), LayoutImmutable, Blittable, JsonProperty(Order = 299)]
		private bool _PatchErrorFovEnable;

		[ObservableProperty]
		[property: ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		private bool _DxDisplacementMappingEnable;

		[ObservableProperty]
		[property: ContainerField(301), LayoutImmutable, Blittable, JsonProperty(Order = 301)]
		private bool _TextureKeepPoolFullEnable;

		[ObservableProperty]
		[property: ContainerField(302), LayoutImmutable, Blittable, JsonProperty(Order = 302)]
		private bool _PatchLodTransitionsEnable;

		[ObservableProperty]
		[property: ContainerField(303), LayoutImmutable, Blittable, JsonProperty(Order = 303)]
		private bool _PatchMaterialSortingEnable;

		[ObservableProperty]
		[property: ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		private bool _CullSampleBoundingBoxHeightEnable;

		[ObservableProperty]
		[property: ContainerField(305), LayoutImmutable, Blittable, JsonProperty(Order = 305)]
		private bool _CastShadowsEnable;

		[ObservableProperty]
		[property: ContainerField(306), LayoutImmutable, Blittable, JsonProperty(Order = 306)]
		private bool _GlobalColormapEnable;

		[ObservableProperty]
		[property: ContainerField(307), LayoutImmutable, Blittable, JsonProperty(Order = 307)]
		private bool _OccluderEnable;

		[ObservableProperty]
		[property: ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		private bool _OccluderJobEnable;

		[ObservableProperty]
		[property: ContainerField(309), LayoutImmutable, Blittable, JsonProperty(Order = 309)]
		private bool _OccluderSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(310), LayoutImmutable, Blittable, JsonProperty(Order = 310)]
		private bool _TextureLayerCullingEnable;

		[ObservableProperty]
		[property: ContainerField(311), LayoutImmutable, Blittable, JsonProperty(Order = 311)]
		private bool _OccludedEnable;

		[ObservableProperty]
		[property: ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		private bool _DrawTextureDebugDepthComplexity;

		[ObservableProperty]
		[property: ContainerField(313), LayoutImmutable, Blittable, JsonProperty(Order = 313)]
		private bool _MeshScatteringEnable;

		[ObservableProperty]
		[property: ContainerField(314), LayoutImmutable, Blittable, JsonProperty(Order = 314)]
		private bool _MeshScatteringJobsEnable;

		[ObservableProperty]
		[property: ContainerField(315), LayoutImmutable, Blittable, JsonProperty(Order = 315)]
		private bool _MeshScatteringCastShadowsEnable;

		[ObservableProperty]
		[property: ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		private bool _DrawMeshScatteringEnable;

		[ObservableProperty]
		[property: ContainerField(317), LayoutImmutable, Blittable, JsonProperty(Order = 317)]
		private bool _DrawMeshScatteringCellBoxesEnable;

		[ObservableProperty]
		[property: ContainerField(318), LayoutImmutable, Blittable, JsonProperty(Order = 318)]
		private bool _DrawMeshScatteringNodeBoxesEnable;

		[ObservableProperty]
		[property: ContainerField(319), LayoutImmutable, Blittable, JsonProperty(Order = 319)]
		private bool _DrawMeshScatteringCulledCellBoxesEnable;

		[ObservableProperty]
		[property: ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		private bool _DrawMeshScatteringDebugMaskScaleTexturesEnable;

		[ObservableProperty]
		[property: ContainerField(321), LayoutImmutable, Blittable, JsonProperty(Order = 321)]
		private bool _DrawMeshScatteringStatsEnable;

		[ObservableProperty]
		[property: ContainerField(322), LayoutImmutable, Blittable, JsonProperty(Order = 322)]
		private bool _DrawMeshScatteringQuadtreeEnable;

		[ObservableProperty]
		[property: ContainerField(323), LayoutImmutable, Blittable, JsonProperty(Order = 323)]
		private bool _TextureDrawTerrainLayersEnable;

		[ObservableProperty]
		[property: ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		private bool _TextureForceUpdateEnable;

		[ObservableProperty]
		[property: ContainerField(325), LayoutImmutable, Blittable, JsonProperty(Order = 325)]
		private bool _TextureCompressFastAlgorithmEnable;

		[ObservableProperty]
		[property: ContainerField(326), LayoutImmutable, Blittable, JsonProperty(Order = 326)]
		private bool _MeshScatteringForceUpdateEnable;

		[ObservableProperty]
		[property: ContainerField(327), LayoutImmutable, Blittable, JsonProperty(Order = 327)]
		private bool _TextureCompressSpuJobsEnable;

		[ObservableProperty]
		[property: ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		private bool _DrawTextureDebugColors;

		[ObservableProperty]
		[property: ContainerField(329), LayoutImmutable, Blittable, JsonProperty(Order = 329)]
		private bool _ForceGraphicsDriverCrash;

		[ObservableProperty]
		[property: ContainerField(330), LayoutImmutable, Blittable, JsonProperty(Order = 330)]
		private bool _MeshScatteringBuildVisibleFirst;

		[ObservableProperty]
		[property: ContainerField(331), LayoutImmutable, Blittable, JsonProperty(Order = 331)]
		private bool _ForcePatchRebuildEnable;

		[ObservableProperty]
		[property: ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		private bool _DebugOverlayBrushEnable;

		[ObservableProperty]
		[property: ContainerField(333), LayoutImmutable, Blittable, JsonProperty(Order = 333)]
		private bool _WireframeEnable;

		[ObservableProperty]
		[property: ContainerField(334), LayoutImmutable, Blittable, JsonProperty(Order = 334)]
		private bool _TextureVtIndirectionSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(335), LayoutImmutable, Blittable, JsonProperty(Order = 335)]
		private bool _DrawVertexYTextureEnable;

		[ObservableProperty]
		[property: ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		private bool _MeshScatteringInstanceCountLodEnable;

		[ObservableProperty]
		[property: ContainerField(337), LayoutImmutable, Blittable, JsonProperty(Order = 337)]
		private bool _MeshScatteringCullSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(338), LayoutImmutable, Blittable, JsonProperty(Order = 338)]
		private bool _MeshScatteringInstanceCullSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(339), LayoutImmutable, Blittable, JsonProperty(Order = 339)]
		private bool _MeshScatteringPrioritizationSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(340), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
		private bool _MeshScatteringSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(341), LayoutImmutable, Blittable, JsonProperty(Order = 341)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(342), LayoutImmutable, Blittable, JsonProperty(Order = 342)]
		private bool _EditServiceEnable;

		[ObservableProperty]
		[property: ContainerField(343), LayoutImmutable, Blittable, JsonProperty(Order = 343)]
		private bool _MeshScatteringInstanceCullEnable;

		[ObservableProperty]
		[property: ContainerField(344), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
		private bool _ZeroViewportEnable;

		[ObservableProperty]
		[property: ContainerField(345), LayoutImmutable, Blittable, JsonProperty(Order = 345)]
		private bool _DebugOverlayGridEnable;

		[ObservableProperty]
		[property: ContainerField(346), LayoutImmutable, Blittable, JsonProperty(Order = 346)]
		private bool _MeshScatteringInstanceCullBoxTestEnable;

		[ObservableProperty]
		[property: ContainerField(347), LayoutImmutable, Blittable, JsonProperty(Order = 347)]
		private bool _MeshScatteringInstanceFrustumCullEnable;

		[ObservableProperty]
		[property: ContainerField(348), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
		private bool _MeshScatteringInstanceOcclusionCullEnable;

		[ObservableProperty]
		[property: ContainerField(349), LayoutImmutable, Blittable, JsonProperty(Order = 349)]
		private bool _MeshScatteringInstanceAdditionalCullEnable;

		[ObservableProperty]
		[property: ContainerField(350), LayoutImmutable, Blittable, JsonProperty(Order = 350)]
		private bool _DrawMeshScatteringInstanceBoxesEnable;

		[ObservableProperty]
		[property: ContainerField(351), LayoutImmutable, Blittable, JsonProperty(Order = 351)]
		private bool _MeshScatteringInstanceCullDynamicAllocEnable;

		[ObservableProperty]
		[property: ContainerField(352), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		private bool _Ps3MeshScatteringInstanceCellMemoryEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			DebugOverlayBrushCoverageMin.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) RenderMode);
			p_Writer.Write(MeshScatteringInstanceCullJobCount);
			p_Writer.Write(PatchErrorFov);
			p_Writer.Write(TriangleSizeMin);
			p_Writer.Write(LodScale);
			p_Writer.Write(LodCenterExtrapolationDistanceMax);
			p_Writer.Write(LodCenterExtrapolationTime);
			p_Writer.Write(MeshScatteringDensityScaleFactor);
			p_Writer.Write(DxTessellatedTriWidth);
			p_Writer.Write(DxTessellationPatchShrink);
			p_Writer.Write(DxTessellationPatchFacesPerSide);
			p_Writer.Write(ZPassDistance);
			p_Writer.Write(DebugOverlayGridSize);
			p_Writer.Write(TextureAtlasSampleCountXFactor);
			p_Writer.Write(TextureAtlasSampleCountYFactor);
			p_Writer.Write(TextureSamplesPerMeterMax);
			p_Writer.Write(TextureDetailFalloffFactor);
			p_Writer.Write(TextureDetailFalloffDistance);
			p_Writer.Write(TextureDetailFalloffCurve);
			p_Writer.Write(TextureInvisibleDetailReductionFactor);
			p_Writer.Write(TextureOccludedDetailReductionFactor);
			p_Writer.Write(TextureRenderJobCount);
			p_Writer.Write(MeshScatteringDistanceScaleFactor);
			p_Writer.Write(DebugOverlayIsolineSpacing);
			p_Writer.Write(TextureRenderJobsLaunchedPerFrameCountMax);
			p_Writer.Write(TextureTileSamplesPerSide);
			p_Writer.Write(TextureTileBorderWidth);
			p_Writer.Write(TextureLevelOffset);
			p_Writer.Write(TextureClodFrameCount);
			p_Writer.Write(MeshScatteringDensityMarginFactor);
			p_Writer.Write(TextureClodCutoffPriority);
			p_Writer.Write(MeshScatteringWindSpeed);
			p_Writer.Write(TextureCompressJobCount);
			p_Writer.Write(MeshScatteringInstancesPerCellMax);
			p_Writer.Write(TextureCompressionQuality);
			p_Writer.Write(TextureDetailSlopeBoost);
			p_Writer.Write(TextureGenerationMipBias);
			p_Writer.Write(DebugOverlayBrushSize);
			p_Writer.Write(MeshScatteringBuildChannelCount);
			p_Writer.Write(MeshScatteringTreeNodePoolCapacity);
			p_Writer.Write(MeshScatteringInvisibleCellFovFactor);
			p_Writer.Write(MeshScatteringInstanceCullListCount);
			p_Writer.Write(MeshScatteringPregenerationDistanceRatio);
			p_Writer.Write(TessellationFacesPerSideMin);
			p_Writer.Write(MaxNonVisibleTextureUpdateCount);
			p_Writer.Write(TextureQuadsPerTileLevel);
			p_Writer.Write(WaterDepthMetersPerSample);
			p_Writer.Write(DynamicMaskDecalWidthScale);
			p_Writer.Write(DrawQuadtreeZoomIndex);
			p_Writer.Write(MeshScatteringClodFrameCount);
			p_Writer.Write(MeshScatteringBuildChannelsLaunchedPerFrameCountMax);
			p_Writer.Write(SlotReuseWaitCount);
			p_Writer.Write(MeshScatteringCellPoolCapacity);
			p_Writer.Write(MeshScatteringCullRecordCount);
			p_Writer.Write(PatchSlotCount);
			p_Writer.Write(BuildJobCount);
			p_Writer.Write(OccluderLodBoostLevelCount);
			p_Writer.Write(DecalZPassDrawDistance);
			p_Writer.Write(DecalOffsetY);
			p_Writer.Write(Decal3dFarDrawDistanceScaleFactor);
			p_Writer.Write(OccludedMinDistance);
			p_Writer.Write(PatchFacesPerSide);
			p_Writer.Write(DrawOnlyDecalZPassEnable);
			p_Writer.Write(DrawDecal3dEnable);
			p_Writer.Write(DrawTextureTileBoxesEnable);
			p_Writer.Write(DrawEnable);
			p_Writer.Write(DrawPatchBoxesEnable);
			p_Writer.Write(DrawDebugTextEnable);
			p_Writer.Write(DrawWaterEnable);
			p_Writer.Write(PrioritizationSpuJobEnable);
			p_Writer.Write(DrawDecalZPassEnable);
			p_Writer.Write(DrawQuadtreesEnable);
			p_Writer.Write(TextureVtIndirectionJobEnable);
			p_Writer.Write(VertexBufferHeightsEnable);
			p_Writer.Write(DrawDebugTexturesEnable);
			p_Writer.Write(ForceDecalReducedQuality);
			p_Writer.Write(DebugOverlayIsolinesEnable);
			p_Writer.Write(TextureClodEnable);
			p_Writer.Write(DebugOverlayWireframeEnable);
			p_Writer.Write(DebugOverlaySketchTextureEnable);
			p_Writer.Write(DrawDecal2dEnable);
			p_Writer.Write(DetailOverlayEnable);
			p_Writer.Write(DecalEnable);
			p_Writer.Write(DrawPatchesEnable);
			p_Writer.Write(DrawQuadtreeStatsEnable);
			p_Writer.Write(DestroyAll);
			p_Writer.Write(DrawQuadtreeAtlasTexturesEnable);
			p_Writer.Write(SlotDebugOutputEnable);
			p_Writer.Write(UpdateJobsEnable);
			p_Writer.Write(PrioritizationOcclusionEnable);
			p_Writer.Write(CullSpuJobEnable);
			p_Writer.Write(PrepareBuildSpuJobEnable);
			p_Writer.Write(BuildSpuJobEnable);
			p_Writer.Write(RegenerateTexturesEnable);
			p_Writer.Write(DynamicMaskEnable);
			p_Writer.Write(GpuTextureCompressionEnable);
			p_Writer.Write(TextureBlockOnStreamingEnable);
			p_Writer.Write(PatchErrorFovEnable);
			p_Writer.Write(DxDisplacementMappingEnable);
			p_Writer.Write(TextureKeepPoolFullEnable);
			p_Writer.Write(PatchLodTransitionsEnable);
			p_Writer.Write(PatchMaterialSortingEnable);
			p_Writer.Write(CullSampleBoundingBoxHeightEnable);
			p_Writer.Write(CastShadowsEnable);
			p_Writer.Write(GlobalColormapEnable);
			p_Writer.Write(OccluderEnable);
			p_Writer.Write(OccluderJobEnable);
			p_Writer.Write(OccluderSpuJobEnable);
			p_Writer.Write(TextureLayerCullingEnable);
			p_Writer.Write(OccludedEnable);
			p_Writer.Write(DrawTextureDebugDepthComplexity);
			p_Writer.Write(MeshScatteringEnable);
			p_Writer.Write(MeshScatteringJobsEnable);
			p_Writer.Write(MeshScatteringCastShadowsEnable);
			p_Writer.Write(DrawMeshScatteringEnable);
			p_Writer.Write(DrawMeshScatteringCellBoxesEnable);
			p_Writer.Write(DrawMeshScatteringNodeBoxesEnable);
			p_Writer.Write(DrawMeshScatteringCulledCellBoxesEnable);
			p_Writer.Write(DrawMeshScatteringDebugMaskScaleTexturesEnable);
			p_Writer.Write(DrawMeshScatteringStatsEnable);
			p_Writer.Write(DrawMeshScatteringQuadtreeEnable);
			p_Writer.Write(TextureDrawTerrainLayersEnable);
			p_Writer.Write(TextureForceUpdateEnable);
			p_Writer.Write(TextureCompressFastAlgorithmEnable);
			p_Writer.Write(MeshScatteringForceUpdateEnable);
			p_Writer.Write(TextureCompressSpuJobsEnable);
			p_Writer.Write(DrawTextureDebugColors);
			p_Writer.Write(ForceGraphicsDriverCrash);
			p_Writer.Write(MeshScatteringBuildVisibleFirst);
			p_Writer.Write(ForcePatchRebuildEnable);
			p_Writer.Write(DebugOverlayBrushEnable);
			p_Writer.Write(WireframeEnable);
			p_Writer.Write(TextureVtIndirectionSpuJobEnable);
			p_Writer.Write(DrawVertexYTextureEnable);
			p_Writer.Write(MeshScatteringInstanceCountLodEnable);
			p_Writer.Write(MeshScatteringCullSpuJobEnable);
			p_Writer.Write(MeshScatteringInstanceCullSpuJobEnable);
			p_Writer.Write(MeshScatteringPrioritizationSpuJobEnable);
			p_Writer.Write(MeshScatteringSpuJobEnable);
			p_Writer.Write(Enable);
			p_Writer.Write(EditServiceEnable);
			p_Writer.Write(MeshScatteringInstanceCullEnable);
			p_Writer.Write(ZeroViewportEnable);
			p_Writer.Write(DebugOverlayGridEnable);
			p_Writer.Write(MeshScatteringInstanceCullBoxTestEnable);
			p_Writer.Write(MeshScatteringInstanceFrustumCullEnable);
			p_Writer.Write(MeshScatteringInstanceOcclusionCullEnable);
			p_Writer.Write(MeshScatteringInstanceAdditionalCullEnable);
			p_Writer.Write(DrawMeshScatteringInstanceBoxesEnable);
			p_Writer.Write(MeshScatteringInstanceCullDynamicAllocEnable);
			p_Writer.Write(Ps3MeshScatteringInstanceCellMemoryEnable);
			p_Writer.WriteNullBytes(3);
		}
	}
}
