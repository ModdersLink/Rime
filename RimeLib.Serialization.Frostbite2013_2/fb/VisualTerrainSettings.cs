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

using fb.Core;

namespace fb.TerrainRender;

[ContainerType(8, 400)]
public class VisualTerrainSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public QualityLevel MeshScatteringQualityLevel { get; set; } = QualityLevel.QualityLevel_Low;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public TerrainRenderMode RenderMode { get; set; } = TerrainRenderMode.TerrainRenderMode_Default;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float TriangleSizeMin { get; set; } = -1.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float LodScale { get; set; } = 1.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float LodCenterExtrapolationDistanceMax { get; set; } = 50.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float LodCenterExtrapolationTime { get; set; } = 0.500f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float TextureSkipMipSpeed { get; set; } = 20.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float DxTessellatedTriWidth { get; set; } = 6.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float DxTessellationPatchShrink { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public uint DxTessellationPatchFacesPerSide { get; set; } = 8;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint TextureAtlasSampleCountXFactor { get; set; } = 1;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public uint TextureAtlasSampleCountYFactor { get; set; } = 1;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float TextureSamplesPerMeterMax { get; set; } = -1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float TextureDetailFalloffFactor { get; set; } = -1.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float TextureDetailFalloffDistance { get; set; } = -1.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float TextureDetailFalloffCurve { get; set; } = -1.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float TextureInvisibleDetailReductionFactor { get; set; } = -1.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float TextureOccludedDetailReductionFactor { get; set; } = -1.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public uint TextureRenderJobCount { get; set; } = 1;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public uint TextureRenderJobsLaunchedPerFrameCountMax { get; set; } = 1;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public uint TextureTileSamplesPerSide { get; set; } = 256;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public uint TextureTileBorderWidth { get; set; } = 1;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public int TextureLevelOffset { get; set; } = 1;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public uint TextureClodFrameCount { get; set; } = 7;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float TextureClodCutoffPriority { get; set; } = 4.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public uint TextureStreamableTextureInstanceBufferSize { get; set; } = 65536;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public uint TextureCompressJobCount { get; set; } = 4;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public int TextureCompressionQuality { get; set; } = 0;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float TextureDetailSlopeBoost { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float TextureGenerationMipBias { get; set; } = -1.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float TextureDirtyRetryRate { get; set; } = 0.100f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public int TextureForceDrawPass { get; set; } = -1;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public uint TextureQuadsPerTileLevel { get; set; } = 0;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float DecalZPassDrawDistance { get; set; } = 30.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float DecalOffsetY { get; set; } = 0.020f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float Decal3dFarDrawDistanceScaleFactor { get; set; } = 1.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public int DrawQuadtreeZoomIndex { get; set; } = -1;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float PatchErrorFov { get; set; } = 0.010f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float ZPassDistance { get; set; } = 10.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float DebugOverlayGridSize { get; set; } = 1.280f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float DebugOverlayIsolineSpacing { get; set; } = 1.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public uint SlotReuseWaitCount { get; set; } = 1;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public uint BuildJobCount { get; set; } = 5;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float DynamicMaskDecalWidthScale { get; set; } = 1.900f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public uint MaxNonVisibleTextureUpdateCount { get; set; } = 1;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public uint PatchFacesPerSide { get; set; } = 16;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public uint TessellationFacesPerSideMin { get; set; } = 1;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public uint PatchSlotCount { get; set; } = 368;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public uint OccluderJobCount { get; set; } = 5;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public uint OccluderPatchFacesPerSide { get; set; } = 4;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float OccluderLodScale { get; set; } = 0.500f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float OccludedMinDistance { get; set; } = 32.000f;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public uint MeshScatteringCellPoolCapacity { get; set; } = 512;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public uint MeshScatteringTreeNodePoolCapacity { get; set; } = 512;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float MeshScatteringInvisibleCellFovFactor { get; set; } = 5.000f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public uint MeshScatteringCullRecordCount { get; set; } = 512;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public uint MeshScatteringBuildChannelCount { get; set; } = 2;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public uint MeshScatteringBuildChannelsLaunchedPerFrameCountMax { get; set; } = 1;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public uint MeshScatteringClodFrameCount { get; set; } = 15;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float MeshScatteringWindSpeed { get; set; } = 1.000f;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public uint MeshScatteringInstancesPerCellMax { get; set; } = 2048;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float MeshScatteringDensityMarginFactor { get; set; } = 1.300f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float MeshScatteringPregenerationDistanceRatio { get; set; } = 0.050f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float MeshScatteringKeepDistanceRatio { get; set; } = 0.050f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public int MeshScatteringVirtualTextureBlurriness { get; set; } = -1;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float MeshScatteringDistanceScaleFactor { get; set; } = 1.000f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public uint MeshScatteringInstanceCullJobCount { get; set; } = 6;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public uint MeshScatteringInstanceCullListCount { get; set; } = 350;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float MeshScatteringSnappingGridMultiplierVertical { get; set; } = 1.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float MeshScatteringSnappingGridMultiplierHorizontal { get; set; } = 8.000f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public bool WireframeEnable { get; set; } = false;
	
	[ContainerField(0x129), LayoutImmutable, Blittable, JsonProperty(Order = 297)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x12a), LayoutImmutable, Blittable, JsonProperty(Order = 298)]
	public bool EditServiceEnable { get; set; } = false;
	
	[ContainerField(0x12b), LayoutImmutable, Blittable, JsonProperty(Order = 299)]
	public bool DxDisplacementMappingEnable { get; set; } = false;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public bool DxDensityMapEnable { get; set; } = true;
	
	[ContainerField(0x12d), LayoutImmutable, Blittable, JsonProperty(Order = 301)]
	public bool VertexBufferHeightsEnable { get; set; } = true;
	
	[ContainerField(0x12e), LayoutImmutable, Blittable, JsonProperty(Order = 302)]
	public bool DrawVertexYTextureEnable { get; set; } = false;
	
	[ContainerField(0x12f), LayoutImmutable, Blittable, JsonProperty(Order = 303)]
	public bool TextureVtIndirectionJobEnable { get; set; } = true;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public bool TextureVtIndirectionSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x131), LayoutImmutable, Blittable, JsonProperty(Order = 305)]
	public bool TextureStreamingPrioritizationJobEnable { get; set; } = true;
	
	[ContainerField(0x132), LayoutImmutable, Blittable, JsonProperty(Order = 306)]
	public bool TextureStreamingPrioritizationSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x133), LayoutImmutable, Blittable, JsonProperty(Order = 307)]
	public bool TextureClodEnable { get; set; } = true;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public bool TextureForceUpdateEnable { get; set; } = false;
	
	[ContainerField(0x135), LayoutImmutable, Blittable, JsonProperty(Order = 309)]
	public bool TextureCompressFastAlgorithmEnable { get; set; } = true;
	
	[ContainerField(0x136), LayoutImmutable, Blittable, JsonProperty(Order = 310)]
	public bool TextureCompressSpuJobsEnable { get; set; } = true;
	
	[ContainerField(0x137), LayoutImmutable, Blittable, JsonProperty(Order = 311)]
	public bool DrawTextureDebugColors { get; set; } = false;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public bool TextureDrawTerrainLayersEnable { get; set; } = true;
	
	[ContainerField(0x139), LayoutImmutable, Blittable, JsonProperty(Order = 313)]
	public bool TextureKeepPoolFullEnable { get; set; } = true;
	
	[ContainerField(0x13a), LayoutImmutable, Blittable, JsonProperty(Order = 314)]
	public bool TextureLayerCullingEnable { get; set; } = true;
	
	[ContainerField(0x13b), LayoutImmutable, Blittable, JsonProperty(Order = 315)]
	public bool GpuTextureCompressionEnable { get; set; } = true;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public bool TextureStreamingPrioritizationEnable { get; set; } = true;
	
	[ContainerField(0x13d), LayoutImmutable, Blittable, JsonProperty(Order = 317)]
	public bool DetailTextureStreamingPrioritizationEnable { get; set; } = true;
	
	[ContainerField(0x13e), LayoutImmutable, Blittable, JsonProperty(Order = 318)]
	public bool MeshScatteringMeshStreamingPrioritizationEnable { get; set; } = true;
	
	[ContainerField(0x13f), LayoutImmutable, Blittable, JsonProperty(Order = 319)]
	public bool PrioritizationSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public bool PrioritizationOcclusionEnable { get; set; } = true;
	
	[ContainerField(0x141), LayoutImmutable, Blittable, JsonProperty(Order = 321)]
	public bool DrawEnable { get; set; } = true;
	
	[ContainerField(0x142), LayoutImmutable, Blittable, JsonProperty(Order = 322)]
	public bool DrawPatchesEnable { get; set; } = true;
	
	[ContainerField(0x143), LayoutImmutable, Blittable, JsonProperty(Order = 323)]
	public bool DetailOverlayEnable { get; set; } = true;
	
	[ContainerField(0x144), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
	public bool DecalEnable { get; set; } = true;
	
	[ContainerField(0x145), LayoutImmutable, Blittable, JsonProperty(Order = 325)]
	public bool ForceDecalReducedQuality { get; set; } = false;
	
	[ContainerField(0x146), LayoutImmutable, Blittable, JsonProperty(Order = 326)]
	public bool DrawDecal2dEnable { get; set; } = true;
	
	[ContainerField(0x147), LayoutImmutable, Blittable, JsonProperty(Order = 327)]
	public bool DrawDecal3dEnable { get; set; } = true;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public bool DrawDecalZPassEnable { get; set; } = false;
	
	[ContainerField(0x149), LayoutImmutable, Blittable, JsonProperty(Order = 329)]
	public bool DrawOnlyDecalZPassEnable { get; set; } = false;
	
	[ContainerField(0x14a), LayoutImmutable, Blittable, JsonProperty(Order = 330)]
	public bool DrawPatchBoxesEnable { get; set; } = false;
	
	[ContainerField(0x14b), LayoutImmutable, Blittable, JsonProperty(Order = 331)]
	public bool DrawBadPatchesEnable { get; set; } = false;
	
	[ContainerField(0x14c), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
	public bool DrawTextureTileBoxesEnable { get; set; } = false;
	
	[ContainerField(0x14d), LayoutImmutable, Blittable, JsonProperty(Order = 333)]
	public bool DrawDebugTextEnable { get; set; } = false;
	
	[ContainerField(0x14e), LayoutImmutable, Blittable, JsonProperty(Order = 334)]
	public bool DrawDebugTexturesEnable { get; set; } = false;
	
	[ContainerField(0x14f), LayoutImmutable, Blittable, JsonProperty(Order = 335)]
	public bool DrawQuadtreesEnable { get; set; } = false;
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public bool DrawQuadtreeStatsEnable { get; set; } = false;
	
	[ContainerField(0x151), LayoutImmutable, Blittable, JsonProperty(Order = 337)]
	public bool DrawQuadtreeAtlasTexturesEnable { get; set; } = false;
	
	[ContainerField(0x152), LayoutImmutable, Blittable, JsonProperty(Order = 338)]
	public bool DrawDestructionMask { get; set; } = false;
	
	[ContainerField(0x153), LayoutImmutable, Blittable, JsonProperty(Order = 339)]
	public bool DrawWaterEnable { get; set; } = true;
	
	[ContainerField(0x154), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
	public bool PatchErrorFovEnable { get; set; } = false;
	
	[ContainerField(0x155), LayoutImmutable, Blittable, JsonProperty(Order = 341)]
	public bool DebugOverlayGridEnable { get; set; } = false;
	
	[ContainerField(0x156), LayoutImmutable, Blittable, JsonProperty(Order = 342)]
	public bool DebugOverlayIsolinesEnable { get; set; } = false;
	
	[ContainerField(0x157), LayoutImmutable, Blittable, JsonProperty(Order = 343)]
	public bool DebugOverlayWireframeEnable { get; set; } = false;
	
	[ContainerField(0x158), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
	public bool DebugOverlaySketchTextureEnable { get; set; } = false;
	
	[ContainerField(0x159), LayoutImmutable, Blittable, JsonProperty(Order = 345)]
	public bool DebugOverlayBrushEnable { get; set; } = false;
	
	[ContainerField(0x15a), LayoutImmutable, Blittable, JsonProperty(Order = 346)]
	public bool ForceGraphicsDriverCrash { get; set; } = false;
	
	[ContainerField(0x15b), LayoutImmutable, Blittable, JsonProperty(Order = 347)]
	public bool ForcePatchRebuildEnable { get; set; } = false;
	
	[ContainerField(0x15c), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
	public bool DestroyAll { get; set; } = false;
	
	[ContainerField(0x15d), LayoutImmutable, Blittable, JsonProperty(Order = 349)]
	public bool SlotDebugOutputEnable { get; set; } = false;
	
	[ContainerField(0x15e), LayoutImmutable, Blittable, JsonProperty(Order = 350)]
	public bool UpdateJobsEnable { get; set; } = true;
	
	[ContainerField(0x15f), LayoutImmutable, Blittable, JsonProperty(Order = 351)]
	public bool CullSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public bool PrepareBuildSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x161), LayoutImmutable, Blittable, JsonProperty(Order = 353)]
	public bool BuildSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x162), LayoutImmutable, Blittable, JsonProperty(Order = 354)]
	public bool RegenerateTexturesEnable { get; set; } = false;
	
	[ContainerField(0x163), LayoutImmutable, Blittable, JsonProperty(Order = 355)]
	public bool DynamicMaskEnable { get; set; } = true;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public bool PatchLodTransitionsEnable { get; set; } = true;
	
	[ContainerField(0x165), LayoutImmutable, Blittable, JsonProperty(Order = 357)]
	public bool PatchMaterialSortingEnable { get; set; } = false;
	
	[ContainerField(0x166), LayoutImmutable, Blittable, JsonProperty(Order = 358)]
	public bool CullSampleBoundingBoxHeightEnable { get; set; } = true;
	
	[ContainerField(0x167), LayoutImmutable, Blittable, JsonProperty(Order = 359)]
	public bool CastShadowsEnable { get; set; } = false;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public bool CastPlanarReflectionEnable { get; set; } = true;
	
	[ContainerField(0x169), LayoutImmutable, Blittable, JsonProperty(Order = 361)]
	public bool CastEnvmapReflectionEnable { get; set; } = true;
	
	[ContainerField(0x16a), LayoutImmutable, Blittable, JsonProperty(Order = 362)]
	public bool CastDecal3dPlanarReflectionEnable { get; set; } = false;
	
	[ContainerField(0x16b), LayoutImmutable, Blittable, JsonProperty(Order = 363)]
	public bool CastDecal3dEnvmapReflectionEnable { get; set; } = false;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public bool GlobalColormapEnable { get; set; } = true;
	
	[ContainerField(0x16d), LayoutImmutable, Blittable, JsonProperty(Order = 365)]
	public bool OccluderEnable { get; set; } = true;
	
	[ContainerField(0x16e), LayoutImmutable, Blittable, JsonProperty(Order = 366)]
	public bool OccluderJobEnable { get; set; } = true;
	
	[ContainerField(0x16f), LayoutImmutable, Blittable, JsonProperty(Order = 367)]
	public bool OccluderSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public bool OccludedEnable { get; set; } = true;
	
	[ContainerField(0x171), LayoutImmutable, Blittable, JsonProperty(Order = 369)]
	public bool MeshScatteringEnable { get; set; } = true;
	
	[ContainerField(0x172), LayoutImmutable, Blittable, JsonProperty(Order = 370)]
	public bool MeshScatteringJobsEnable { get; set; } = true;
	
	[ContainerField(0x173), LayoutImmutable, Blittable, JsonProperty(Order = 371)]
	public bool MeshScatteringCastShadowsEnable { get; set; } = true;
	
	[ContainerField(0x174), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
	public bool DrawMeshScatteringEnable { get; set; } = true;
	
	[ContainerField(0x175), LayoutImmutable, Blittable, JsonProperty(Order = 373)]
	public bool DrawMeshScatteringCellBoxesEnable { get; set; } = false;
	
	[ContainerField(0x176), LayoutImmutable, Blittable, JsonProperty(Order = 374)]
	public bool DrawMeshScatteringBatchBoxesEnable { get; set; } = false;
	
	[ContainerField(0x177), LayoutImmutable, Blittable, JsonProperty(Order = 375)]
	public bool DrawMeshScatteringNodeBoxesEnable { get; set; } = false;
	
	[ContainerField(0x178), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
	public bool DrawMeshScatteringCulledCellBoxesEnable { get; set; } = false;
	
	[ContainerField(0x179), LayoutImmutable, Blittable, JsonProperty(Order = 377)]
	public bool DrawMeshScatteringDebugMaskScaleTexturesEnable { get; set; } = false;
	
	[ContainerField(0x17a), LayoutImmutable, Blittable, JsonProperty(Order = 378)]
	public bool DrawMeshScatteringStatsEnable { get; set; } = false;
	
	[ContainerField(0x17b), LayoutImmutable, Blittable, JsonProperty(Order = 379)]
	public bool DrawMeshScatteringQuadtreeEnable { get; set; } = false;
	
	[ContainerField(0x17c), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
	public bool MeshScatteringForceUpdateEnable { get; set; } = false;
	
	[ContainerField(0x17d), LayoutImmutable, Blittable, JsonProperty(Order = 381)]
	public bool MeshScatteringBuildVisibleFirst { get; set; } = true;
	
	[ContainerField(0x17e), LayoutImmutable, Blittable, JsonProperty(Order = 382)]
	public bool MeshScatteringCullSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x17f), LayoutImmutable, Blittable, JsonProperty(Order = 383)]
	public bool MeshScatteringMergeInstanceLists { get; set; } = true;
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public bool MeshScatteringInstanceCullSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x181), LayoutImmutable, Blittable, JsonProperty(Order = 385)]
	public bool MeshScatteringPrioritizationSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x182), LayoutImmutable, Blittable, JsonProperty(Order = 386)]
	public bool MeshScatteringSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x183), LayoutImmutable, Blittable, JsonProperty(Order = 387)]
	public bool MeshScatteringInstanceCullBoxTestEnable { get; set; } = true;
	
	[ContainerField(0x184), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
	public bool MeshScatteringInstanceNewCodeEnable { get; set; } = true;
	
	[ContainerField(0x185), LayoutImmutable, Blittable, JsonProperty(Order = 389)]
	public bool MeshScatteringInstanceFrustumCullEnable { get; set; } = true;
	
	[ContainerField(0x186), LayoutImmutable, Blittable, JsonProperty(Order = 390)]
	public bool MeshScatteringInstanceOcclusionCullEnable { get; set; } = false;
	
	[ContainerField(0x187), LayoutImmutable, Blittable, JsonProperty(Order = 391)]
	public bool MeshScatteringInstanceAdditionalCullEnable { get; set; } = true;
	
	[ContainerField(0x188), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
	public bool DrawMeshScatteringInstanceBoxesEnable { get; set; } = false;
	
	[ContainerField(0x189), LayoutImmutable, Blittable, JsonProperty(Order = 393)]
	public bool MeshScatteringInstanceCullDynamicAllocEnable { get; set; } = false;
	
	[ContainerField(0x18a), LayoutImmutable, Blittable, JsonProperty(Order = 394)]
	public bool Ps3MeshScatteringInstanceCellMemoryEnable { get; set; } = true;
	
	[ContainerField(0x18b), LayoutImmutable, Blittable, JsonProperty(Order = 395)]
	public bool MeshScatteringWindEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) MeshScatteringQualityLevel);
		p_Writer.Write((int) RenderMode);
		p_Writer.Write(TriangleSizeMin);
		p_Writer.Write(LodScale);
		p_Writer.Write(LodCenterExtrapolationDistanceMax);
		p_Writer.Write(LodCenterExtrapolationTime);
		p_Writer.Write(TextureSkipMipSpeed);
		p_Writer.Write(DxTessellatedTriWidth);
		p_Writer.Write(DxTessellationPatchShrink);
		p_Writer.Write(DxTessellationPatchFacesPerSide);
		p_Writer.Write(TextureAtlasSampleCountXFactor);
		p_Writer.Write(TextureAtlasSampleCountYFactor);
		p_Writer.Write(TextureSamplesPerMeterMax);
		p_Writer.Write(TextureDetailFalloffFactor);
		p_Writer.Write(TextureDetailFalloffDistance);
		p_Writer.Write(TextureDetailFalloffCurve);
		p_Writer.Write(TextureInvisibleDetailReductionFactor);
		p_Writer.Write(TextureOccludedDetailReductionFactor);
		p_Writer.Write(TextureRenderJobCount);
		p_Writer.Write(TextureRenderJobsLaunchedPerFrameCountMax);
		p_Writer.Write(TextureTileSamplesPerSide);
		p_Writer.Write(TextureTileBorderWidth);
		p_Writer.Write(TextureLevelOffset);
		p_Writer.Write(TextureClodFrameCount);
		p_Writer.Write(TextureClodCutoffPriority);
		p_Writer.Write(TextureStreamableTextureInstanceBufferSize);
		p_Writer.Write(TextureCompressJobCount);
		p_Writer.Write(TextureCompressionQuality);
		p_Writer.Write(TextureDetailSlopeBoost);
		p_Writer.Write(TextureGenerationMipBias);
		p_Writer.Write(TextureDirtyRetryRate);
		p_Writer.Write(TextureForceDrawPass);
		p_Writer.Write(TextureQuadsPerTileLevel);
		p_Writer.Write(DecalZPassDrawDistance);
		p_Writer.Write(DecalOffsetY);
		p_Writer.Write(Decal3dFarDrawDistanceScaleFactor);
		p_Writer.Write(DrawQuadtreeZoomIndex);
		p_Writer.Write(PatchErrorFov);
		p_Writer.Write(ZPassDistance);
		p_Writer.Write(DebugOverlayGridSize);
		p_Writer.Write(DebugOverlayIsolineSpacing);
		p_Writer.Write(SlotReuseWaitCount);
		p_Writer.Write(BuildJobCount);
		p_Writer.Write(DynamicMaskDecalWidthScale);
		p_Writer.Write(MaxNonVisibleTextureUpdateCount);
		p_Writer.Write(PatchFacesPerSide);
		p_Writer.Write(TessellationFacesPerSideMin);
		p_Writer.Write(PatchSlotCount);
		p_Writer.Write(OccluderJobCount);
		p_Writer.Write(OccluderPatchFacesPerSide);
		p_Writer.Write(OccluderLodScale);
		p_Writer.Write(OccludedMinDistance);
		p_Writer.Write(MeshScatteringCellPoolCapacity);
		p_Writer.Write(MeshScatteringTreeNodePoolCapacity);
		p_Writer.Write(MeshScatteringInvisibleCellFovFactor);
		p_Writer.Write(MeshScatteringCullRecordCount);
		p_Writer.Write(MeshScatteringBuildChannelCount);
		p_Writer.Write(MeshScatteringBuildChannelsLaunchedPerFrameCountMax);
		p_Writer.Write(MeshScatteringClodFrameCount);
		p_Writer.Write(MeshScatteringWindSpeed);
		p_Writer.Write(MeshScatteringInstancesPerCellMax);
		p_Writer.Write(MeshScatteringDensityMarginFactor);
		p_Writer.Write(MeshScatteringPregenerationDistanceRatio);
		p_Writer.Write(MeshScatteringKeepDistanceRatio);
		p_Writer.Write(MeshScatteringVirtualTextureBlurriness);
		p_Writer.Write(MeshScatteringDistanceScaleFactor);
		p_Writer.Write(MeshScatteringInstanceCullJobCount);
		p_Writer.Write(MeshScatteringInstanceCullListCount);
		p_Writer.Write(MeshScatteringSnappingGridMultiplierVertical);
		p_Writer.Write(MeshScatteringSnappingGridMultiplierHorizontal);
		p_Writer.Write(WireframeEnable);
		p_Writer.Write(Enable);
		p_Writer.Write(EditServiceEnable);
		p_Writer.Write(DxDisplacementMappingEnable);
		p_Writer.Write(DxDensityMapEnable);
		p_Writer.Write(VertexBufferHeightsEnable);
		p_Writer.Write(DrawVertexYTextureEnable);
		p_Writer.Write(TextureVtIndirectionJobEnable);
		p_Writer.Write(TextureVtIndirectionSpuJobEnable);
		p_Writer.Write(TextureStreamingPrioritizationJobEnable);
		p_Writer.Write(TextureStreamingPrioritizationSpuJobEnable);
		p_Writer.Write(TextureClodEnable);
		p_Writer.Write(TextureForceUpdateEnable);
		p_Writer.Write(TextureCompressFastAlgorithmEnable);
		p_Writer.Write(TextureCompressSpuJobsEnable);
		p_Writer.Write(DrawTextureDebugColors);
		p_Writer.Write(TextureDrawTerrainLayersEnable);
		p_Writer.Write(TextureKeepPoolFullEnable);
		p_Writer.Write(TextureLayerCullingEnable);
		p_Writer.Write(GpuTextureCompressionEnable);
		p_Writer.Write(TextureStreamingPrioritizationEnable);
		p_Writer.Write(DetailTextureStreamingPrioritizationEnable);
		p_Writer.Write(MeshScatteringMeshStreamingPrioritizationEnable);
		p_Writer.Write(PrioritizationSpuJobEnable);
		p_Writer.Write(PrioritizationOcclusionEnable);
		p_Writer.Write(DrawEnable);
		p_Writer.Write(DrawPatchesEnable);
		p_Writer.Write(DetailOverlayEnable);
		p_Writer.Write(DecalEnable);
		p_Writer.Write(ForceDecalReducedQuality);
		p_Writer.Write(DrawDecal2dEnable);
		p_Writer.Write(DrawDecal3dEnable);
		p_Writer.Write(DrawDecalZPassEnable);
		p_Writer.Write(DrawOnlyDecalZPassEnable);
		p_Writer.Write(DrawPatchBoxesEnable);
		p_Writer.Write(DrawBadPatchesEnable);
		p_Writer.Write(DrawTextureTileBoxesEnable);
		p_Writer.Write(DrawDebugTextEnable);
		p_Writer.Write(DrawDebugTexturesEnable);
		p_Writer.Write(DrawQuadtreesEnable);
		p_Writer.Write(DrawQuadtreeStatsEnable);
		p_Writer.Write(DrawQuadtreeAtlasTexturesEnable);
		p_Writer.Write(DrawDestructionMask);
		p_Writer.Write(DrawWaterEnable);
		p_Writer.Write(PatchErrorFovEnable);
		p_Writer.Write(DebugOverlayGridEnable);
		p_Writer.Write(DebugOverlayIsolinesEnable);
		p_Writer.Write(DebugOverlayWireframeEnable);
		p_Writer.Write(DebugOverlaySketchTextureEnable);
		p_Writer.Write(DebugOverlayBrushEnable);
		p_Writer.Write(ForceGraphicsDriverCrash);
		p_Writer.Write(ForcePatchRebuildEnable);
		p_Writer.Write(DestroyAll);
		p_Writer.Write(SlotDebugOutputEnable);
		p_Writer.Write(UpdateJobsEnable);
		p_Writer.Write(CullSpuJobEnable);
		p_Writer.Write(PrepareBuildSpuJobEnable);
		p_Writer.Write(BuildSpuJobEnable);
		p_Writer.Write(RegenerateTexturesEnable);
		p_Writer.Write(DynamicMaskEnable);
		p_Writer.Write(PatchLodTransitionsEnable);
		p_Writer.Write(PatchMaterialSortingEnable);
		p_Writer.Write(CullSampleBoundingBoxHeightEnable);
		p_Writer.Write(CastShadowsEnable);
		p_Writer.Write(CastPlanarReflectionEnable);
		p_Writer.Write(CastEnvmapReflectionEnable);
		p_Writer.Write(CastDecal3dPlanarReflectionEnable);
		p_Writer.Write(CastDecal3dEnvmapReflectionEnable);
		p_Writer.Write(GlobalColormapEnable);
		p_Writer.Write(OccluderEnable);
		p_Writer.Write(OccluderJobEnable);
		p_Writer.Write(OccluderSpuJobEnable);
		p_Writer.Write(OccludedEnable);
		p_Writer.Write(MeshScatteringEnable);
		p_Writer.Write(MeshScatteringJobsEnable);
		p_Writer.Write(MeshScatteringCastShadowsEnable);
		p_Writer.Write(DrawMeshScatteringEnable);
		p_Writer.Write(DrawMeshScatteringCellBoxesEnable);
		p_Writer.Write(DrawMeshScatteringBatchBoxesEnable);
		p_Writer.Write(DrawMeshScatteringNodeBoxesEnable);
		p_Writer.Write(DrawMeshScatteringCulledCellBoxesEnable);
		p_Writer.Write(DrawMeshScatteringDebugMaskScaleTexturesEnable);
		p_Writer.Write(DrawMeshScatteringStatsEnable);
		p_Writer.Write(DrawMeshScatteringQuadtreeEnable);
		p_Writer.Write(MeshScatteringForceUpdateEnable);
		p_Writer.Write(MeshScatteringBuildVisibleFirst);
		p_Writer.Write(MeshScatteringCullSpuJobEnable);
		p_Writer.Write(MeshScatteringMergeInstanceLists);
		p_Writer.Write(MeshScatteringInstanceCullSpuJobEnable);
		p_Writer.Write(MeshScatteringPrioritizationSpuJobEnable);
		p_Writer.Write(MeshScatteringSpuJobEnable);
		p_Writer.Write(MeshScatteringInstanceCullBoxTestEnable);
		p_Writer.Write(MeshScatteringInstanceNewCodeEnable);
		p_Writer.Write(MeshScatteringInstanceFrustumCullEnable);
		p_Writer.Write(MeshScatteringInstanceOcclusionCullEnable);
		p_Writer.Write(MeshScatteringInstanceAdditionalCullEnable);
		p_Writer.Write(DrawMeshScatteringInstanceBoxesEnable);
		p_Writer.Write(MeshScatteringInstanceCullDynamicAllocEnable);
		p_Writer.Write(Ps3MeshScatteringInstanceCellMemoryEnable);
		p_Writer.Write(MeshScatteringWindEnable);
		p_Writer.WriteNullBytes(4);
	}
}

