///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VisualTerrainSettings : 
		DataContainer
	{
		[ContainerField(8), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 DebugOverlayBrushCoverageMin { get; set; } = new Vec2(); // 0x8 (8)
		
		[ContainerField(16)]
		public TerrainRenderMode RenderMode { get; set; } = new TerrainRenderMode(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint MeshScatteringInstanceCullJobCount { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float PatchErrorFov { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float TriangleSizeMin { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float LodScale { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float LodCenterExtrapolationDistanceMax { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float LodCenterExtrapolationTime { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float MeshScatteringDensityScaleFactor { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float DxTessellatedTriWidth { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float DxTessellationPatchShrink { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public uint DxTessellationPatchFacesPerSide { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float ZPassDistance { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float DebugOverlayGridSize { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public uint TextureAtlasSampleCountXFactor { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public uint TextureAtlasSampleCountYFactor { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float TextureSamplesPerMeterMax { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float TextureDetailFalloffFactor { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float TextureDetailFalloffDistance { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float TextureDetailFalloffCurve { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float TextureInvisibleDetailReductionFactor { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float TextureOccludedDetailReductionFactor { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public uint TextureRenderJobCount { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float MeshScatteringDistanceScaleFactor { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float DebugOverlayIsolineSpacing { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public uint TextureRenderJobsLaunchedPerFrameCountMax { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public uint TextureTileSamplesPerSide { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public uint TextureTileBorderWidth { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public int TextureLevelOffset { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public uint TextureClodFrameCount { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float MeshScatteringDensityMarginFactor { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float TextureClodCutoffPriority { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float MeshScatteringWindSpeed { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public uint TextureCompressJobCount { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public uint MeshScatteringInstancesPerCellMax { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public int TextureCompressionQuality { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float TextureDetailSlopeBoost { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float TextureGenerationMipBias { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float DebugOverlayBrushSize { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public uint MeshScatteringBuildChannelCount { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public uint MeshScatteringTreeNodePoolCapacity { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float MeshScatteringInvisibleCellFovFactor { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public uint MeshScatteringInstanceCullListCount { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float MeshScatteringPregenerationDistanceRatio { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public uint TessellationFacesPerSideMin { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public uint MaxNonVisibleTextureUpdateCount { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public uint TextureQuadsPerTileLevel { get; set; } // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float WaterDepthMetersPerSample { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float DynamicMaskDecalWidthScale { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public int DrawQuadtreeZoomIndex { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public uint MeshScatteringClodFrameCount { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public uint MeshScatteringBuildChannelsLaunchedPerFrameCountMax { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public uint SlotReuseWaitCount { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public uint MeshScatteringCellPoolCapacity { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public uint MeshScatteringCullRecordCount { get; set; } // 0xE4 (228)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public uint PatchSlotCount { get; set; } // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public uint BuildJobCount { get; set; } // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public uint OccluderLodBoostLevelCount { get; set; } // 0xF0 (240)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public float DecalZPassDrawDistance { get; set; } // 0xF4 (244)
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public float DecalOffsetY { get; set; } // 0xF8 (248)
		
		[ContainerField(252), LayoutImmutable, Blittable]
		public float Decal3dFarDrawDistanceScaleFactor { get; set; } // 0xFC (252)
		
		[ContainerField(256), LayoutImmutable, Blittable]
		public float OccludedMinDistance { get; set; } // 0x100 (256)
		
		[ContainerField(260), LayoutImmutable, Blittable]
		public uint PatchFacesPerSide { get; set; } // 0x104 (260)
		
		[ContainerField(264), LayoutImmutable, Blittable]
		public bool DrawOnlyDecalZPassEnable { get; set; } // 0x108 (264)
		
		[ContainerField(265), LayoutImmutable, Blittable]
		public bool DrawDecal3dEnable { get; set; } // 0x109 (265)
		
		[ContainerField(266), LayoutImmutable, Blittable]
		public bool DrawTextureTileBoxesEnable { get; set; } // 0x10A (266)
		
		[ContainerField(267), LayoutImmutable, Blittable]
		public bool DrawEnable { get; set; } // 0x10B (267)
		
		[ContainerField(268), LayoutImmutable, Blittable]
		public bool DrawPatchBoxesEnable { get; set; } // 0x10C (268)
		
		[ContainerField(269), LayoutImmutable, Blittable]
		public bool DrawDebugTextEnable { get; set; } // 0x10D (269)
		
		[ContainerField(270), LayoutImmutable, Blittable]
		public bool DrawWaterEnable { get; set; } // 0x10E (270)
		
		[ContainerField(271), LayoutImmutable, Blittable]
		public bool PrioritizationSpuJobEnable { get; set; } // 0x10F (271)
		
		[ContainerField(272), LayoutImmutable, Blittable]
		public bool DrawDecalZPassEnable { get; set; } // 0x110 (272)
		
		[ContainerField(273), LayoutImmutable, Blittable]
		public bool DrawQuadtreesEnable { get; set; } // 0x111 (273)
		
		[ContainerField(274), LayoutImmutable, Blittable]
		public bool TextureVtIndirectionJobEnable { get; set; } // 0x112 (274)
		
		[ContainerField(275), LayoutImmutable, Blittable]
		public bool VertexBufferHeightsEnable { get; set; } // 0x113 (275)
		
		[ContainerField(276), LayoutImmutable, Blittable]
		public bool DrawDebugTexturesEnable { get; set; } // 0x114 (276)
		
		[ContainerField(277), LayoutImmutable, Blittable]
		public bool ForceDecalReducedQuality { get; set; } // 0x115 (277)
		
		[ContainerField(278), LayoutImmutable, Blittable]
		public bool DebugOverlayIsolinesEnable { get; set; } // 0x116 (278)
		
		[ContainerField(279), LayoutImmutable, Blittable]
		public bool TextureClodEnable { get; set; } // 0x117 (279)
		
		[ContainerField(280), LayoutImmutable, Blittable]
		public bool DebugOverlayWireframeEnable { get; set; } // 0x118 (280)
		
		[ContainerField(281), LayoutImmutable, Blittable]
		public bool DebugOverlaySketchTextureEnable { get; set; } // 0x119 (281)
		
		[ContainerField(282), LayoutImmutable, Blittable]
		public bool DrawDecal2dEnable { get; set; } // 0x11A (282)
		
		[ContainerField(283), LayoutImmutable, Blittable]
		public bool DetailOverlayEnable { get; set; } // 0x11B (283)
		
		[ContainerField(284), LayoutImmutable, Blittable]
		public bool DecalEnable { get; set; } // 0x11C (284)
		
		[ContainerField(285), LayoutImmutable, Blittable]
		public bool DrawPatchesEnable { get; set; } // 0x11D (285)
		
		[ContainerField(286), LayoutImmutable, Blittable]
		public bool DrawQuadtreeStatsEnable { get; set; } // 0x11E (286)
		
		[ContainerField(287), LayoutImmutable, Blittable]
		public bool DestroyAll { get; set; } // 0x11F (287)
		
		[ContainerField(288), LayoutImmutable, Blittable]
		public bool DrawQuadtreeAtlasTexturesEnable { get; set; } // 0x120 (288)
		
		[ContainerField(289), LayoutImmutable, Blittable]
		public bool SlotDebugOutputEnable { get; set; } // 0x121 (289)
		
		[ContainerField(290), LayoutImmutable, Blittable]
		public bool UpdateJobsEnable { get; set; } // 0x122 (290)
		
		[ContainerField(291), LayoutImmutable, Blittable]
		public bool PrioritizationOcclusionEnable { get; set; } // 0x123 (291)
		
		[ContainerField(292), LayoutImmutable, Blittable]
		public bool CullSpuJobEnable { get; set; } // 0x124 (292)
		
		[ContainerField(293), LayoutImmutable, Blittable]
		public bool PrepareBuildSpuJobEnable { get; set; } // 0x125 (293)
		
		[ContainerField(294), LayoutImmutable, Blittable]
		public bool BuildSpuJobEnable { get; set; } // 0x126 (294)
		
		[ContainerField(295), LayoutImmutable, Blittable]
		public bool RegenerateTexturesEnable { get; set; } // 0x127 (295)
		
		[ContainerField(296), LayoutImmutable, Blittable]
		public bool DynamicMaskEnable { get; set; } // 0x128 (296)
		
		[ContainerField(297), LayoutImmutable, Blittable]
		public bool GpuTextureCompressionEnable { get; set; } // 0x129 (297)
		
		[ContainerField(298), LayoutImmutable, Blittable]
		public bool TextureBlockOnStreamingEnable { get; set; } // 0x12A (298)
		
		[ContainerField(299), LayoutImmutable, Blittable]
		public bool PatchErrorFovEnable { get; set; } // 0x12B (299)
		
		[ContainerField(300), LayoutImmutable, Blittable]
		public bool DxDisplacementMappingEnable { get; set; } // 0x12C (300)
		
		[ContainerField(301), LayoutImmutable, Blittable]
		public bool TextureKeepPoolFullEnable { get; set; } // 0x12D (301)
		
		[ContainerField(302), LayoutImmutable, Blittable]
		public bool PatchLodTransitionsEnable { get; set; } // 0x12E (302)
		
		[ContainerField(303), LayoutImmutable, Blittable]
		public bool PatchMaterialSortingEnable { get; set; } // 0x12F (303)
		
		[ContainerField(304), LayoutImmutable, Blittable]
		public bool CullSampleBoundingBoxHeightEnable { get; set; } // 0x130 (304)
		
		[ContainerField(305), LayoutImmutable, Blittable]
		public bool CastShadowsEnable { get; set; } // 0x131 (305)
		
		[ContainerField(306), LayoutImmutable, Blittable]
		public bool GlobalColormapEnable { get; set; } // 0x132 (306)
		
		[ContainerField(307), LayoutImmutable, Blittable]
		public bool OccluderEnable { get; set; } // 0x133 (307)
		
		[ContainerField(308), LayoutImmutable, Blittable]
		public bool OccluderJobEnable { get; set; } // 0x134 (308)
		
		[ContainerField(309), LayoutImmutable, Blittable]
		public bool OccluderSpuJobEnable { get; set; } // 0x135 (309)
		
		[ContainerField(310), LayoutImmutable, Blittable]
		public bool TextureLayerCullingEnable { get; set; } // 0x136 (310)
		
		[ContainerField(311), LayoutImmutable, Blittable]
		public bool OccludedEnable { get; set; } // 0x137 (311)
		
		[ContainerField(312), LayoutImmutable, Blittable]
		public bool DrawTextureDebugDepthComplexity { get; set; } // 0x138 (312)
		
		[ContainerField(313), LayoutImmutable, Blittable]
		public bool MeshScatteringEnable { get; set; } // 0x139 (313)
		
		[ContainerField(314), LayoutImmutable, Blittable]
		public bool MeshScatteringJobsEnable { get; set; } // 0x13A (314)
		
		[ContainerField(315), LayoutImmutable, Blittable]
		public bool MeshScatteringCastShadowsEnable { get; set; } // 0x13B (315)
		
		[ContainerField(316), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringEnable { get; set; } // 0x13C (316)
		
		[ContainerField(317), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringCellBoxesEnable { get; set; } // 0x13D (317)
		
		[ContainerField(318), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringNodeBoxesEnable { get; set; } // 0x13E (318)
		
		[ContainerField(319), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringCulledCellBoxesEnable { get; set; } // 0x13F (319)
		
		[ContainerField(320), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringDebugMaskScaleTexturesEnable { get; set; } // 0x140 (320)
		
		[ContainerField(321), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringStatsEnable { get; set; } // 0x141 (321)
		
		[ContainerField(322), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringQuadtreeEnable { get; set; } // 0x142 (322)
		
		[ContainerField(323), LayoutImmutable, Blittable]
		public bool TextureDrawTerrainLayersEnable { get; set; } // 0x143 (323)
		
		[ContainerField(324), LayoutImmutable, Blittable]
		public bool TextureForceUpdateEnable { get; set; } // 0x144 (324)
		
		[ContainerField(325), LayoutImmutable, Blittable]
		public bool TextureCompressFastAlgorithmEnable { get; set; } // 0x145 (325)
		
		[ContainerField(326), LayoutImmutable, Blittable]
		public bool MeshScatteringForceUpdateEnable { get; set; } // 0x146 (326)
		
		[ContainerField(327), LayoutImmutable, Blittable]
		public bool TextureCompressSpuJobsEnable { get; set; } // 0x147 (327)
		
		[ContainerField(328), LayoutImmutable, Blittable]
		public bool DrawTextureDebugColors { get; set; } // 0x148 (328)
		
		[ContainerField(329), LayoutImmutable, Blittable]
		public bool ForceGraphicsDriverCrash { get; set; } // 0x149 (329)
		
		[ContainerField(330), LayoutImmutable, Blittable]
		public bool MeshScatteringBuildVisibleFirst { get; set; } // 0x14A (330)
		
		[ContainerField(331), LayoutImmutable, Blittable]
		public bool ForcePatchRebuildEnable { get; set; } // 0x14B (331)
		
		[ContainerField(332), LayoutImmutable, Blittable]
		public bool DebugOverlayBrushEnable { get; set; } // 0x14C (332)
		
		[ContainerField(333), LayoutImmutable, Blittable]
		public bool WireframeEnable { get; set; } // 0x14D (333)
		
		[ContainerField(334), LayoutImmutable, Blittable]
		public bool TextureVtIndirectionSpuJobEnable { get; set; } // 0x14E (334)
		
		[ContainerField(335), LayoutImmutable, Blittable]
		public bool DrawVertexYTextureEnable { get; set; } // 0x14F (335)
		
		[ContainerField(336), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceCountLodEnable { get; set; } // 0x150 (336)
		
		[ContainerField(337), LayoutImmutable, Blittable]
		public bool MeshScatteringCullSpuJobEnable { get; set; } // 0x151 (337)
		
		[ContainerField(338), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceCullSpuJobEnable { get; set; } // 0x152 (338)
		
		[ContainerField(339), LayoutImmutable, Blittable]
		public bool MeshScatteringPrioritizationSpuJobEnable { get; set; } // 0x153 (339)
		
		[ContainerField(340), LayoutImmutable, Blittable]
		public bool MeshScatteringSpuJobEnable { get; set; } // 0x154 (340)
		
		[ContainerField(341), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x155 (341)
		
		[ContainerField(342), LayoutImmutable, Blittable]
		public bool EditServiceEnable { get; set; } // 0x156 (342)
		
		[ContainerField(343), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceCullEnable { get; set; } // 0x157 (343)
		
		[ContainerField(344), LayoutImmutable, Blittable]
		public bool ZeroViewportEnable { get; set; } // 0x158 (344)
		
		[ContainerField(345), LayoutImmutable, Blittable]
		public bool DebugOverlayGridEnable { get; set; } // 0x159 (345)
		
		[ContainerField(346), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceCullBoxTestEnable { get; set; } // 0x15A (346)
		
		[ContainerField(347), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceFrustumCullEnable { get; set; } // 0x15B (347)
		
		[ContainerField(348), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceOcclusionCullEnable { get; set; } // 0x15C (348)
		
		[ContainerField(349), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceAdditionalCullEnable { get; set; } // 0x15D (349)
		
		[ContainerField(350), LayoutImmutable, Blittable]
		public bool DrawMeshScatteringInstanceBoxesEnable { get; set; } // 0x15E (350)
		
		[ContainerField(351), LayoutImmutable, Blittable]
		public bool MeshScatteringInstanceCullDynamicAllocEnable { get; set; } // 0x15F (351)
		
		[ContainerField(352), LayoutImmutable, Blittable]
		public bool Ps3MeshScatteringInstanceCellMemoryEnable { get; set; } // 0x160 (352)
		
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
