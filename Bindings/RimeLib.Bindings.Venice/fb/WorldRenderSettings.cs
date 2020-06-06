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
    [ContainerType(16)]
	public class WorldRenderSettings : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DynamicEnvmapDefaultPosition { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SubSurfaceColor { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float ViewportScale { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float ShadowMinScreenArea { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float ShadowViewportScale { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public uint FxaaQuality { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float CullScreenAreaScale { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float PlanarReflectionCullFOV { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public uint GenericEntityMaxVisibleEntityCount { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float ShadowmapSizeZScale { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public uint ShadowmapResolution { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public uint ShadowmapQuality { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float ShadowmapPoissonFilterScale { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public uint ShadowmapSliceCount { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float ShadowmapSliceSchemeWeight { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float ShadowmapFirstSliceScale { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float ShadowmapViewDistance { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public uint PlanarReflectionWidth { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float ShadowmapExtrusionLength { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float ShadowmapMinScreenArea { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float TempPlanarReflectionY { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float SubSurfaceRolloffKeyLight { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public int FxaaForceVendor { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public uint PlanarReflectionHeight { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float LightIntensityScale { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float LightLodSpecularFadeAreaEnd { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float ShadowmapMinFov { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float LightLodSpecularFadeAreaStart { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float LightLodRadiusFactor { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float LightForceIntensity { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float LightLodFadeArea { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float LightLodMinArea { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public int DrawDebugDynamicEnvmapMipLevel { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public uint MaxDecalVolumeCount { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float MotionBlurScale { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float MotionBlurMax { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float MotionBlurNoiseScale { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public uint MotionBlurQuality { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public uint MaxSpotLightShadowCount { get; set; } // 0xC0 (192)
		
		[ContainerField(196)]
		public MipmapFilterMode DynamicEnvmapFilterMode { get; set; } = new MipmapFilterMode(); // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public uint MotionBlurMaxSampleCount { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public uint MotionBlurFrameAverageCount { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float MotionBlurMaxFrameTime { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float ForceMotionBlurDepthCutoff { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float ForceMotionBlurCutoffGradientScale { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public uint MultisampleCount { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public float MultisampleThreshold { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public uint MaxPointLightCount { get; set; } // 0xE4 (228)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public uint ReflectionEnvmapSize { get; set; } // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public float SpotLightNearPlane { get; set; } // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public float SpotLightShadowmapPoissonFilterScale { get; set; } // 0xF0 (240)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public int OnlyShadowmapSlice { get; set; } // 0xF4 (244)
		
		[ContainerField(248)]
		public WorldViewMode ViewMode { get; set; } = new WorldViewMode(); // 0xF8 (248)
		
		[ContainerField(252), LayoutImmutable, Blittable]
		public uint SpotLightShadowmapResolution { get; set; } // 0xFC (252)
		
		[ContainerField(256)]
		public QualityLevel SpotLightShadomapLevel { get; set; } = new QualityLevel(); // 0x100 (256)
		
		[ContainerField(260), LayoutImmutable, Blittable]
		public uint SpotLightShadowmapQuality { get; set; } // 0x104 (260)
		
		[ContainerField(264), LayoutImmutable, Blittable]
		public int OnlyLightTileY { get; set; } // 0x108 (264)
		
		[ContainerField(268), LayoutImmutable, Blittable]
		public int OnlyLightTileX { get; set; } // 0x10C (268)
		
		[ContainerField(272), LayoutImmutable, Blittable]
		public float XenonHdrColorScale { get; set; } // 0x110 (272)
		
		[ContainerField(276), LayoutImmutable, Blittable]
		public float XenonHdrColorScaleFactor { get; set; } // 0x114 (276)
		
		[ContainerField(280), LayoutImmutable, Blittable]
		public uint Ps3LightTileJobMaxFbTileCount { get; set; } // 0x118 (280)
		
		[ContainerField(284), LayoutImmutable, Blittable]
		public int OnlyLightTileIndex { get; set; } // 0x11C (284)
		
		[ContainerField(288), LayoutImmutable, Blittable]
		public uint Ps3LightTileJobCount { get; set; } // 0x120 (288)
		
		[ContainerField(292), LayoutImmutable, Blittable]
		public uint Ps3LightTileJobPriority { get; set; } // 0x124 (292)
		
		[ContainerField(296), LayoutImmutable, Blittable]
		public uint XenonLightTileMaxLineLightCount { get; set; } // 0x128 (296)
		
		[ContainerField(300), LayoutImmutable, Blittable]
		public uint XenonLightTileMaxSpotLightCount { get; set; } // 0x12C (300)
		
		[ContainerField(304), LayoutImmutable, Blittable]
		public uint XenonLightTileConstantBufferSize { get; set; } // 0x130 (304)
		
		[ContainerField(308), LayoutImmutable, Blittable]
		public uint XenonLightTileMaxPointLightCount { get; set; } // 0x134 (308)
		
		[ContainerField(312), LayoutImmutable, Blittable]
		public uint MaxDestructionVolumeCount { get; set; } // 0x138 (312)
		
		[ContainerField(316), LayoutImmutable, Blittable]
		public float DynamicEnvmapFilterWidth { get; set; } // 0x13C (316)
		
		[ContainerField(320), LayoutImmutable, Blittable]
		public float LightTileMinArea { get; set; } // 0x140 (320)
		
		[ContainerField(324), LayoutImmutable, Blittable]
		public uint DynamicEnvmapResolution { get; set; } // 0x144 (324)
		
		[ContainerField(328)]
		public ShaderGBufferLayout GBufferLayout { get; set; } = new ShaderGBufferLayout(); // 0x148 (328)
		
		[ContainerField(332), LayoutImmutable, Blittable]
		public int DrawDebugSkyEnvmapMipLevel { get; set; } // 0x14C (332)
		
		[ContainerField(336), LayoutImmutable, Blittable]
		public float DecalVolumeScale { get; set; } // 0x150 (336)
		
		[ContainerField(340), LayoutImmutable, Blittable]
		public uint LightOverdrawMaxLayerCount { get; set; } // 0x154 (340)
		
		[ContainerField(344), LayoutImmutable, Blittable]
		public float LightRadiusScale { get; set; } // 0x158 (344)
		
		[ContainerField(348), LayoutImmutable, Blittable]
		public float LightAttenuationThreshold { get; set; } // 0x15C (348)
		
		[ContainerField(352), LayoutImmutable, Blittable]
		public uint Ps3LightTileMethod { get; set; } // 0x160 (352)
		
		[ContainerField(356), LayoutImmutable, Blittable]
		public float Ps3LightTileJobYieldGranularity { get; set; } // 0x164 (356)
		
		[ContainerField(360), LayoutImmutable, Blittable]
		public uint OutdoorLightTileBatchCount { get; set; } // 0x168 (360)
		
		[ContainerField(364), LayoutImmutable, Blittable]
		public uint XenonDrawDebugLightTileGridMode { get; set; } // 0x16C (364)
		
		[ContainerField(368), LayoutImmutable, Blittable]
		public float LightStencilMinArea { get; set; } // 0x170 (368)
		
		[ContainerField(372), LayoutImmutable, Blittable]
		public uint MaxSpotLightCount { get; set; } // 0x174 (372)
		
		[ContainerField(376)]
		public MipmapFilterMode SkyEnvmapFilterMode { get; set; } = new MipmapFilterMode(); // 0x178 (376)
		
		[ContainerField(380), LayoutImmutable, Blittable]
		public float SkyEnvmapFilterWidth { get; set; } // 0x17C (380)
		
		[ContainerField(384), LayoutImmutable, Blittable]
		public uint GBufferTestCount { get; set; } // 0x180 (384)
		
		[ContainerField(388), LayoutImmutable, Blittable]
		public uint SkyEnvmapResolution { get; set; } // 0x184 (388)
		
		[ContainerField(392), LayoutImmutable, Blittable]
		public uint SkyEnvmapSidesPerFrameCount { get; set; } // 0x188 (392)
		
		[ContainerField(396), LayoutImmutable, Blittable]
		public float SubSurfaceRolloffLocalLight { get; set; } // 0x18C (396)
		
		[ContainerField(400), LayoutImmutable, Blittable]
		public int OnlyTileIndex { get; set; } // 0x190 (400)
		
		[ContainerField(404), LayoutImmutable, Blittable]
		public bool OccluderMeshZPrepassEnable { get; set; } // 0x194 (404)
		
		[ContainerField(405), LayoutImmutable, Blittable]
		public bool OccluderMeshZPrepassDebugEnable { get; set; } // 0x195 (405)
		
		[ContainerField(406), LayoutImmutable, Blittable]
		public bool WireframeEnable { get; set; } // 0x196 (406)
		
		[ContainerField(407), LayoutImmutable, Blittable]
		public bool HalfResEnable { get; set; } // 0x197 (407)
		
		[ContainerField(408), LayoutImmutable, Blittable]
		public bool HalfResLensFlaresEnable { get; set; } // 0x198 (408)
		
		[ContainerField(409), LayoutImmutable, Blittable]
		public bool ZPassEnable { get; set; } // 0x199 (409)
		
		[ContainerField(410), LayoutImmutable, Blittable]
		public bool ForegroundEnable { get; set; } // 0x19A (410)
		
		[ContainerField(411), LayoutImmutable, Blittable]
		public bool TiledHalfResCompositeEnable { get; set; } // 0x19B (411)
		
		[ContainerField(412), LayoutImmutable, Blittable]
		public bool ForegroundZPassEnable { get; set; } // 0x19C (412)
		
		[ContainerField(413), LayoutImmutable, Blittable]
		public bool DrawDebugVelocityBuffer { get; set; } // 0x19D (413)
		
		[ContainerField(414), LayoutImmutable, Blittable]
		public bool ForegroundDepthClearEnable { get; set; } // 0x19E (414)
		
		[ContainerField(415), LayoutImmutable, Blittable]
		public bool ForegroundAsMainEnable { get; set; } // 0x19F (415)
		
		[ContainerField(416), LayoutImmutable, Blittable]
		public bool CustomEnvmapEnable { get; set; } // 0x1A0 (416)
		
		[ContainerField(417), LayoutImmutable, Blittable]
		public bool SkyEnvmapEnable { get; set; } // 0x1A1 (417)
		
		[ContainerField(418), LayoutImmutable, Blittable]
		public bool DrawDebugVisibleEntityTypes { get; set; } // 0x1A2 (418)
		
		[ContainerField(419), LayoutImmutable, Blittable]
		public bool DrawDebugHalfResEnvironment { get; set; } // 0x1A3 (419)
		
		[ContainerField(420), LayoutImmutable, Blittable]
		public bool DrawSolidBoundingBoxes { get; set; } // 0x1A4 (420)
		
		[ContainerField(421), LayoutImmutable, Blittable]
		public bool BilateralHalfResCompositeEnable { get; set; } // 0x1A5 (421)
		
		[ContainerField(422), LayoutImmutable, Blittable]
		public bool ForegroundTransparentEnable { get; set; } // 0x1A6 (422)
		
		[ContainerField(423), LayoutImmutable, Blittable]
		public bool TiledHalfResStencilOccludersEnable { get; set; } // 0x1A7 (423)
		
		[ContainerField(424), LayoutImmutable, Blittable]
		public bool SkyEnvmapUpdateEnable { get; set; } // 0x1A8 (424)
		
		[ContainerField(425), LayoutImmutable, Blittable]
		public bool SkyEnvmapForceUpdateEnable { get; set; } // 0x1A9 (425)
		
		[ContainerField(426), LayoutImmutable, Blittable]
		public bool SkyEnvmapUse8BitTexture { get; set; } // 0x1AA (426)
		
		[ContainerField(427), LayoutImmutable, Blittable]
		public bool DynamicEnvmapEnable { get; set; } // 0x1AB (427)
		
		[ContainerField(428), LayoutImmutable, Blittable]
		public bool ScreenEffectEnable { get; set; } // 0x1AC (428)
		
		[ContainerField(429), LayoutImmutable, Blittable]
		public bool DrawDebugZBufferEnable { get; set; } // 0x1AD (429)
		
		[ContainerField(430), LayoutImmutable, Blittable]
		public bool MotionBlurStencilPassEnable { get; set; } // 0x1AE (430)
		
		[ContainerField(431), LayoutImmutable, Blittable]
		public bool FinalPostEnable { get; set; } // 0x1AF (431)
		
		[ContainerField(432), LayoutImmutable, Blittable]
		public bool DrawDebugQuarterShadowmaps { get; set; } // 0x1B0 (432)
		
		[ContainerField(433), LayoutImmutable, Blittable]
		public bool DrawDebugSkyEnvmap { get; set; } // 0x1B1 (433)
		
		[ContainerField(434), LayoutImmutable, Blittable]
		public bool DxShadowmap16BitEnable { get; set; } // 0x1B2 (434)
		
		[ContainerField(435), LayoutImmutable, Blittable]
		public bool DrawDebugTransShadowmap { get; set; } // 0x1B3 (435)
		
		[ContainerField(436), LayoutImmutable, Blittable]
		public bool DrawDebugSpotLightShadowmaps { get; set; } // 0x1B4 (436)
		
		[ContainerField(437), LayoutImmutable, Blittable]
		public bool DrawShadowFrustums { get; set; } // 0x1B5 (437)
		
		[ContainerField(438), LayoutImmutable, Blittable]
		public bool DrawDebugShadowmaps { get; set; } // 0x1B6 (438)
		
		[ContainerField(439), LayoutImmutable, Blittable]
		public bool SkyEnable { get; set; } // 0x1B7 (439)
		
		[ContainerField(440), LayoutImmutable, Blittable]
		public bool DrawBoundingSpheres { get; set; } // 0x1B8 (440)
		
		[ContainerField(441), LayoutImmutable, Blittable]
		public bool DrawFrustums { get; set; } // 0x1B9 (441)
		
		[ContainerField(442), LayoutImmutable, Blittable]
		public bool StaticEnvmapEnable { get; set; } // 0x1BA (442)
		
		[ContainerField(443), LayoutImmutable, Blittable]
		public bool SkyFogEnable { get; set; } // 0x1BB (443)
		
		[ContainerField(444), LayoutImmutable, Blittable]
		public bool DrawLineBoundingBoxes { get; set; } // 0x1BC (444)
		
		[ContainerField(445), LayoutImmutable, Blittable]
		public bool DrawDebugDestructionVolumes { get; set; } // 0x1BD (445)
		
		[ContainerField(446), LayoutImmutable, Blittable]
		public bool LensFlaresEnable { get; set; } // 0x1BE (446)
		
		[ContainerField(447), LayoutImmutable, Blittable]
		public bool DrawDebugLensFlareOccluders { get; set; } // 0x1BF (447)
		
		[ContainerField(448), LayoutImmutable, Blittable]
		public bool DrawDebugLensFlares { get; set; } // 0x1C0 (448)
		
		[ContainerField(449), LayoutImmutable, Blittable]
		public bool LensFlareOcclusionEnable { get; set; } // 0x1C1 (449)
		
		[ContainerField(450), LayoutImmutable, Blittable]
		public bool DrawDebugWorldOcclusions { get; set; } // 0x1C2 (450)
		
		[ContainerField(451), LayoutImmutable, Blittable]
		public bool CloudShadowEnable { get; set; } // 0x1C3 (451)
		
		[ContainerField(452), LayoutImmutable, Blittable]
		public bool OverrideDynamicAO { get; set; } // 0x1C4 (452)
		
		[ContainerField(453), LayoutImmutable, Blittable]
		public bool DrawDebugDynamicAO { get; set; } // 0x1C5 (453)
		
		[ContainerField(454), LayoutImmutable, Blittable]
		public bool EmissiveEnable { get; set; } // 0x1C6 (454)
		
		[ContainerField(455), LayoutImmutable, Blittable]
		public bool UnlitEnable { get; set; } // 0x1C7 (455)
		
		[ContainerField(456), LayoutImmutable, Blittable]
		public bool SkyEnvmapMipmapGenEnable { get; set; } // 0x1C8 (456)
		
		[ContainerField(457), LayoutImmutable, Blittable]
		public bool DrawLightSources { get; set; } // 0x1C9 (457)
		
		[ContainerField(458), LayoutImmutable, Blittable]
		public bool GBufferClearEnable { get; set; } // 0x1CA (458)
		
		[ContainerField(459), LayoutImmutable, Blittable]
		public bool DxGBufferLight16BitEnable { get; set; } // 0x1CB (459)
		
		[ContainerField(460), LayoutImmutable, Blittable]
		public bool DxGBufferNormal16BitEnable { get; set; } // 0x1CC (460)
		
		[ContainerField(461), LayoutImmutable, Blittable]
		public bool GBufferAlphaTestSimpleEnable { get; set; } // 0x1CD (461)
		
		[ContainerField(462), LayoutImmutable, Blittable]
		public bool SpecularLightingEnable { get; set; } // 0x1CE (462)
		
		[ContainerField(463), LayoutImmutable, Blittable]
		public bool SkinLightingEnable { get; set; } // 0x1CF (463)
		
		[ContainerField(464), LayoutImmutable, Blittable]
		public bool TranslucencyLightingEnable { get; set; } // 0x1D0 (464)
		
		[ContainerField(465), LayoutImmutable, Blittable]
		public bool DynamicEnvmapLightingEnable { get; set; } // 0x1D1 (465)
		
		[ContainerField(466), LayoutImmutable, Blittable]
		public bool OutdoorLightEnable { get; set; } // 0x1D2 (466)
		
		[ContainerField(467), LayoutImmutable, Blittable]
		public bool PointLightsEnable { get; set; } // 0x1D3 (467)
		
		[ContainerField(468), LayoutImmutable, Blittable]
		public bool LineLightsEnable { get; set; } // 0x1D4 (468)
		
		[ContainerField(469), LayoutImmutable, Blittable]
		public bool ConeLightsEnable { get; set; } // 0x1D5 (469)
		
		[ContainerField(470), LayoutImmutable, Blittable]
		public bool SpotLightsEnable { get; set; } // 0x1D6 (470)
		
		[ContainerField(471), LayoutImmutable, Blittable]
		public bool LightProbesEnable { get; set; } // 0x1D7 (471)
		
		[ContainerField(472), LayoutImmutable, Blittable]
		public bool LightStencilMethodEnable { get; set; } // 0x1D8 (472)
		
		[ContainerField(473), LayoutImmutable, Blittable]
		public bool LightVolumeMethodEnable { get; set; } // 0x1D9 (473)
		
		[ContainerField(474), LayoutImmutable, Blittable]
		public bool LightVolumeDepthTestEnable { get; set; } // 0x1DA (474)
		
		[ContainerField(475), LayoutImmutable, Blittable]
		public bool OutputGammaCorrectionEnable { get; set; } // 0x1DB (475)
		
		[ContainerField(476), LayoutImmutable, Blittable]
		public bool DrawDebugMultisampleClassify { get; set; } // 0x1DC (476)
		
		[ContainerField(477), LayoutImmutable, Blittable]
		public bool OutdoorKeyLightEnable { get; set; } // 0x1DD (477)
		
		[ContainerField(478), LayoutImmutable, Blittable]
		public bool OutdoorSkyLightEnable { get; set; } // 0x1DE (478)
		
		[ContainerField(479), LayoutImmutable, Blittable]
		public bool OutdoorLightSpecularEnable { get; set; } // 0x1DF (479)
		
		[ContainerField(480), LayoutImmutable, Blittable]
		public bool OutdoorLightTilingEnable { get; set; } // 0x1E0 (480)
		
		[ContainerField(481), LayoutImmutable, Blittable]
		public bool OutdoorLightTileRenderEnable { get; set; } // 0x1E1 (481)
		
		[ContainerField(482), LayoutImmutable, Blittable]
		public bool OutdoorLightTileBlendEnable { get; set; } // 0x1E2 (482)
		
		[ContainerField(483), LayoutImmutable, Blittable]
		public bool OutdoorLightTileSimpleShaderEnable { get; set; } // 0x1E3 (483)
		
		[ContainerField(484), LayoutImmutable, Blittable]
		public bool Ps3TiledHalfTargetEnable { get; set; } // 0x1E4 (484)
		
		[ContainerField(485), LayoutImmutable, Blittable]
		public bool XenonOutdoorLightTilingEnable { get; set; } // 0x1E5 (485)
		
		[ContainerField(486), LayoutImmutable, Blittable]
		public bool XenonPointLightsTilingEnable { get; set; } // 0x1E6 (486)
		
		[ContainerField(487), LayoutImmutable, Blittable]
		public bool XenonSpotLightsTilingEnable { get; set; } // 0x1E7 (487)
		
		[ContainerField(488), LayoutImmutable, Blittable]
		public bool XenonLineLightsTilingEnable { get; set; } // 0x1E8 (488)
		
		[ContainerField(489), LayoutImmutable, Blittable]
		public bool XenonAsyncLightJobsEnable { get; set; } // 0x1E9 (489)
		
		[ContainerField(490), LayoutImmutable, Blittable]
		public bool XenonLightTileDownsampleSpecularCheckEnable { get; set; } // 0x1EA (490)
		
		[ContainerField(491), LayoutImmutable, Blittable]
		public bool XenonLightTileCpuPointLightCullingEnable { get; set; } // 0x1EB (491)
		
		[ContainerField(492), LayoutImmutable, Blittable]
		public bool Ps3TiledSSAOTargetsEnable { get; set; } // 0x1EC (492)
		
		[ContainerField(493), LayoutImmutable, Blittable]
		public bool Ps3SCullEnable { get; set; } // 0x1ED (493)
		
		[ContainerField(494), LayoutImmutable, Blittable]
		public bool Ps3ColorCompressionEnable { get; set; } // 0x1EE (494)
		
		[ContainerField(495), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x1EF (495)
		
		[ContainerField(496), LayoutImmutable, Blittable]
		public bool Ps3TilingEnable { get; set; } // 0x1F0 (496)
		
		[ContainerField(497), LayoutImmutable, Blittable]
		public bool Ps3DepthBoundsLightCullingEnable { get; set; } // 0x1F1 (497)
		
		[ContainerField(498), LayoutImmutable, Blittable]
		public bool Ps3ZCullEnable { get; set; } // 0x1F2 (498)
		
		[ContainerField(499), LayoutImmutable, Blittable]
		public bool ConsoleRenderTargetPoolSharingEnable { get; set; } // 0x1F3 (499)
		
		[ContainerField(500), LayoutImmutable, Blittable]
		public bool XenonFloatDepthBufferEnable { get; set; } // 0x1F4 (500)
		
		[ContainerField(501), LayoutImmutable, Blittable]
		public bool Ps3LightTileJobYieldEnable { get; set; } // 0x1F5 (501)
		
		[ContainerField(502), LayoutImmutable, Blittable]
		public bool Ps3HdrClearEnable { get; set; } // 0x1F6 (502)
		
		[ContainerField(503), LayoutImmutable, Blittable]
		public bool XenonFastHdrEnable { get; set; } // 0x1F7 (503)
		
		[ContainerField(504), LayoutImmutable, Blittable]
		public bool ShadowmapViewDistanceScaleEnable { get; set; } // 0x1F8 (504)
		
		[ContainerField(505), LayoutImmutable, Blittable]
		public bool Ps3RenderTargetPoolGBufferOffsetEnable { get; set; } // 0x1F9 (505)
		
		[ContainerField(506), LayoutImmutable, Blittable]
		public bool HdrEnable { get; set; } // 0x1FA (506)
		
		[ContainerField(507), LayoutImmutable, Blittable]
		public bool SpotLightShadowmapEnable { get; set; } // 0x1FB (507)
		
		[ContainerField(508), LayoutImmutable, Blittable]
		public bool SimpleShadowmapsEnable { get; set; } // 0x1FC (508)
		
		[ContainerField(509), LayoutImmutable, Blittable]
		public bool DrawTransparent { get; set; } // 0x1FD (509)
		
		[ContainerField(510), LayoutImmutable, Blittable]
		public bool DrawTransparentDecal { get; set; } // 0x1FE (510)
		
		[ContainerField(511), LayoutImmutable, Blittable]
		public bool ShadowmapFixedDepthEnable { get; set; } // 0x1FF (511)
		
		[ContainerField(512), LayoutImmutable, Blittable]
		public bool DrawDebugDynamicEnvmap { get; set; } // 0x200 (512)
		
		[ContainerField(513), LayoutImmutable, Blittable]
		public bool MotionBlurGeometryPassEnable { get; set; } // 0x201 (513)
		
		[ContainerField(514), LayoutImmutable, Blittable]
		public bool DxLinearDepth32BitFormatEnable { get; set; } // 0x202 (514)
		
		[ContainerField(515), LayoutImmutable, Blittable]
		public bool DynamicEnvmapMipmapGenEnable { get; set; } // 0x203 (515)
		
		[ContainerField(516), LayoutImmutable, Blittable]
		public bool MotionBlurEnable { get; set; } // 0x204 (516)
		
		[ContainerField(517), LayoutImmutable, Blittable]
		public bool ColoredShadowmapSlicesEnable { get; set; } // 0x205 (517)
		
		[ContainerField(518), LayoutImmutable, Blittable]
		public bool DxDeferredCsPathEnable { get; set; } // 0x206 (518)
		
		[ContainerField(519), LayoutImmutable, Blittable]
		public bool DrawDebugGBuffer { get; set; } // 0x207 (519)
		
		[ContainerField(520), LayoutImmutable, Blittable]
		public bool DrawDebugLightSources { get; set; } // 0x208 (520)
		
		[ContainerField(521), LayoutImmutable, Blittable]
		public bool DrawDebugLightShadowSources { get; set; } // 0x209 (521)
		
		[ContainerField(522), LayoutImmutable, Blittable]
		public bool DrawDebugLightStats { get; set; } // 0x20A (522)
		
		[ContainerField(523), LayoutImmutable, Blittable]
		public bool DrawDebugLightTiles { get; set; } // 0x20B (523)
		
		[ContainerField(524), LayoutImmutable, Blittable]
		public bool DrawDebugLightTileVolumes { get; set; } // 0x20C (524)
		
		[ContainerField(525), LayoutImmutable, Blittable]
		public bool DrawDebugLightTileFbGrid { get; set; } // 0x20D (525)
		
		[ContainerField(526), LayoutImmutable, Blittable]
		public bool DrawDebugLightTileGrid { get; set; } // 0x20E (526)
		
		[ContainerField(527), LayoutImmutable, Blittable]
		public bool DrawDebugLightTileSources { get; set; } // 0x20F (527)
		
		[ContainerField(528), LayoutImmutable, Blittable]
		public bool ApplyShadowmapsEnable { get; set; } // 0x210 (528)
		
		[ContainerField(529), LayoutImmutable, Blittable]
		public bool GenerateShadowmapsEnable { get; set; } // 0x211 (529)
		
		[ContainerField(530), LayoutImmutable, Blittable]
		public bool DxSpotLightShadowmap16BitEnable { get; set; } // 0x212 (530)
		
		[ContainerField(531), LayoutImmutable, Blittable]
		public bool Ps3Shadowmap16BitEnable { get; set; } // 0x213 (531)
		
		[ContainerField(532), LayoutImmutable, Blittable]
		public bool Ps3SpotLightShadowmap16BitEnable { get; set; } // 0x214 (532)
		
		[ContainerField(533), LayoutImmutable, Blittable]
		public bool GenericEntityRendererEnable { get; set; } // 0x215 (533)
		
		[ContainerField(534), LayoutImmutable, Blittable]
		public bool SetupJobEnable { get; set; } // 0x216 (534)
		
		[ContainerField(535), LayoutImmutable, Blittable]
		public bool ShadowmapAccumBilinearEnable { get; set; } // 0x217 (535)
		
		[ContainerField(536), LayoutImmutable, Blittable]
		public bool LightWidthEnable { get; set; } // 0x218 (536)
		
		[ContainerField(537), LayoutImmutable, Blittable]
		public bool LightIntensityNormalizationEnable { get; set; } // 0x219 (537)
		
		[ContainerField(538), LayoutImmutable, Blittable]
		public bool LightCullEnable { get; set; } // 0x21A (538)
		
		[ContainerField(539), LayoutImmutable, Blittable]
		public bool LightDepthCullEnable { get; set; } // 0x21B (539)
		
		[ContainerField(540), LayoutImmutable, Blittable]
		public bool LightNormalCullEnable { get; set; } // 0x21C (540)
		
		[ContainerField(541), LayoutImmutable, Blittable]
		public bool LightConeCullEnable { get; set; } // 0x21D (541)
		
		[ContainerField(542), LayoutImmutable, Blittable]
		public bool LightTileOverlayEnable { get; set; } // 0x21E (542)
		
		[ContainerField(543), LayoutImmutable, Blittable]
		public bool Ps3ShadowmapTilingEnable { get; set; } // 0x21F (543)
		
		[ContainerField(544), LayoutImmutable, Blittable]
		public bool LightAttenuationThresholdEnable { get; set; } // 0x220 (544)
		
		[ContainerField(545), LayoutImmutable, Blittable]
		public bool SkyVisibilityEnvmapScalingEnable { get; set; } // 0x221 (545)
		
		[ContainerField(546), LayoutImmutable, Blittable]
		public bool ZBufferShadowTestEnable { get; set; } // 0x222 (546)
		
		[ContainerField(547), LayoutImmutable, Blittable]
		public bool ShadowmapsEnable { get; set; } // 0x223 (547)
		
		[ContainerField(548), LayoutImmutable, Blittable]
		public bool ShadowmapAccumEnable { get; set; } // 0x224 (548)
		
		[ContainerField(549), LayoutImmutable, Blittable]
		public bool ShadowmapCullVolumeEnable { get; set; } // 0x225 (549)
		
		[ContainerField(550), LayoutImmutable, Blittable]
		public bool OpaqueSortBySolutionEnable { get; set; } // 0x226 (550)
		
		[ContainerField(551), LayoutImmutable, Blittable]
		public bool MainOpaqueZPassEnable { get; set; } // 0x227 (551)
		
		[ContainerField(552), LayoutImmutable, Blittable]
		public bool DrawDebugDecalVolumes { get; set; } // 0x228 (552)
		
		[ContainerField(553), LayoutImmutable, Blittable]
		public bool PlanarReflectionEnable { get; set; } // 0x229 (553)
		
		[ContainerField(554), LayoutImmutable, Blittable]
		public bool TransparencyShadowmapsEnable { get; set; } // 0x22A (554)
		
		[ContainerField(555), LayoutImmutable, Blittable]
		public bool DynamicCullDrawOccludedBoxesEnable { get; set; } // 0x22B (555)
		
		[ContainerField(556), LayoutImmutable, Blittable]
		public bool PlanarReflectionBlur { get; set; } // 0x22C (556)
		
		[ContainerField(557), LayoutImmutable, Blittable]
		public bool DrawDebugPlanarReflectionCullFrustum { get; set; } // 0x22D (557)
		
		[ContainerField(558), LayoutImmutable, Blittable]
		public bool FreezePlanarReflectionCullFrustum { get; set; } // 0x22E (558)
		
		[ContainerField(559), LayoutImmutable, Blittable]
		public bool PlanarReflectionDebugCullMode { get; set; } // 0x22F (559)
		
		[ContainerField(560), LayoutImmutable, Blittable]
		public bool ShadowmapFixedMovementEnable { get; set; } // 0x230 (560)
		
		[ContainerField(561), LayoutImmutable, Blittable]
		public bool DecalVolumeEnable { get; set; } // 0x231 (561)
		
		[ContainerField(562), LayoutImmutable, Blittable]
		public bool DrawDebugPlanarReflection { get; set; } // 0x232 (562)
		
		[ContainerField(563), LayoutImmutable, Blittable]
		public bool FxaaEnable { get; set; } // 0x233 (563)
		
		[ContainerField(564), LayoutImmutable, Blittable]
		public bool DynamicCullSpuJobEnable { get; set; } // 0x234 (564)
		
		[ContainerField(565), LayoutImmutable, Blittable]
		public bool DynamicCullZBufferTestEnable { get; set; } // 0x235 (565)
		
		[ContainerField(566), LayoutImmutable, Blittable]
		public bool ViewFxEnable { get; set; } // 0x236 (566)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2442804067:
					DynamicEnvmapDefaultPosition = (Vec3) p_Value;
					break;

				case 1116837929:
					SubSurfaceColor = (Vec3) p_Value;
					break;

				case 372747593:
					ViewportScale = (float) p_Value;
					break;

				case 1763892754:
					ShadowMinScreenArea = (float) p_Value;
					break;

				case 1275076751:
					ShadowViewportScale = (float) p_Value;
					break;

				case 1713753686:
					FxaaQuality = (uint) p_Value;
					break;

				case 989651568:
					CullScreenAreaScale = (float) p_Value;
					break;

				case 3291231915:
					PlanarReflectionCullFOV = (float) p_Value;
					break;

				case 3254270605:
					GenericEntityMaxVisibleEntityCount = (uint) p_Value;
					break;

				case 3508619736:
					ShadowmapSizeZScale = (float) p_Value;
					break;

				case 3880013969:
					ShadowmapResolution = (uint) p_Value;
					break;

				case 4159686514:
					ShadowmapQuality = (uint) p_Value;
					break;

				case 3460109328:
					ShadowmapPoissonFilterScale = (float) p_Value;
					break;

				case 1754397676:
					ShadowmapSliceCount = (uint) p_Value;
					break;

				case 4103828218:
					ShadowmapSliceSchemeWeight = (float) p_Value;
					break;

				case 2040081677:
					ShadowmapFirstSliceScale = (float) p_Value;
					break;

				case 1554572465:
					ShadowmapViewDistance = (float) p_Value;
					break;

				case 1134551908:
					PlanarReflectionWidth = (uint) p_Value;
					break;

				case 658753014:
					ShadowmapExtrusionLength = (float) p_Value;
					break;

				case 2714094958:
					ShadowmapMinScreenArea = (float) p_Value;
					break;

				case 2965318295:
					TempPlanarReflectionY = (float) p_Value;
					break;

				case 1376512303:
					SubSurfaceRolloffKeyLight = (float) p_Value;
					break;

				case 3453976226:
					FxaaForceVendor = (int) p_Value;
					break;

				case 2870536605:
					PlanarReflectionHeight = (uint) p_Value;
					break;

				case 4224101580:
					LightIntensityScale = (float) p_Value;
					break;

				case 340957037:
					LightLodSpecularFadeAreaEnd = (float) p_Value;
					break;

				case 4182219946:
					ShadowmapMinFov = (float) p_Value;
					break;

				case 1941638882:
					LightLodSpecularFadeAreaStart = (float) p_Value;
					break;

				case 2574597545:
					LightLodRadiusFactor = (float) p_Value;
					break;

				case 1015351721:
					LightForceIntensity = (float) p_Value;
					break;

				case 3993094733:
					LightLodFadeArea = (float) p_Value;
					break;

				case 1014960449:
					LightLodMinArea = (float) p_Value;
					break;

				case 1647206466:
					DrawDebugDynamicEnvmapMipLevel = (int) p_Value;
					break;

				case 1711167253:
					MaxDecalVolumeCount = (uint) p_Value;
					break;

				case 922077962:
					MotionBlurScale = (float) p_Value;
					break;

				case 1677064646:
					MotionBlurMax = (float) p_Value;
					break;

				case 4082261780:
					MotionBlurNoiseScale = (float) p_Value;
					break;

				case 3278537567:
					MotionBlurQuality = (uint) p_Value;
					break;

				case 2418772786:
					MaxSpotLightShadowCount = (uint) p_Value;
					break;

				case 3729378162:
					DynamicEnvmapFilterMode = (MipmapFilterMode) Enum.ToObject(typeof(MipmapFilterMode), p_Value);
					break;

				case 1447314883:
					MotionBlurMaxSampleCount = (uint) p_Value;
					break;

				case 1914506031:
					MotionBlurFrameAverageCount = (uint) p_Value;
					break;

				case 771939886:
					MotionBlurMaxFrameTime = (float) p_Value;
					break;

				case 3772079119:
					ForceMotionBlurDepthCutoff = (float) p_Value;
					break;

				case 3044262524:
					ForceMotionBlurCutoffGradientScale = (float) p_Value;
					break;

				case 1049323753:
					MultisampleCount = (uint) p_Value;
					break;

				case 3044955837:
					MultisampleThreshold = (float) p_Value;
					break;

				case 2623363008:
					MaxPointLightCount = (uint) p_Value;
					break;

				case 2418170502:
					ReflectionEnvmapSize = (uint) p_Value;
					break;

				case 4277463821:
					SpotLightNearPlane = (float) p_Value;
					break;

				case 984299638:
					SpotLightShadowmapPoissonFilterScale = (float) p_Value;
					break;

				case 883213115:
					OnlyShadowmapSlice = (int) p_Value;
					break;

				case 381898379:
					ViewMode = (WorldViewMode) Enum.ToObject(typeof(WorldViewMode), p_Value);
					break;

				case 2435232759:
					SpotLightShadowmapResolution = (uint) p_Value;
					break;

				case 2998747480:
					SpotLightShadomapLevel = (QualityLevel) Enum.ToObject(typeof(QualityLevel), p_Value);
					break;

				case 4007866708:
					SpotLightShadowmapQuality = (uint) p_Value;
					break;

				case 1921288514:
					OnlyLightTileY = (int) p_Value;
					break;

				case 1921288515:
					OnlyLightTileX = (int) p_Value;
					break;

				case 2994673228:
					XenonHdrColorScale = (float) p_Value;
					break;

				case 357430561:
					XenonHdrColorScaleFactor = (float) p_Value;
					break;

				case 1822791039:
					Ps3LightTileJobMaxFbTileCount = (uint) p_Value;
					break;

				case 3383060069:
					OnlyLightTileIndex = (int) p_Value;
					break;

				case 3257825371:
					Ps3LightTileJobCount = (uint) p_Value;
					break;

				case 2438614122:
					Ps3LightTileJobPriority = (uint) p_Value;
					break;

				case 2351028858:
					XenonLightTileMaxLineLightCount = (uint) p_Value;
					break;

				case 429843884:
					XenonLightTileMaxSpotLightCount = (uint) p_Value;
					break;

				case 2424724230:
					XenonLightTileConstantBufferSize = (uint) p_Value;
					break;

				case 2040884056:
					XenonLightTileMaxPointLightCount = (uint) p_Value;
					break;

				case 3613038148:
					MaxDestructionVolumeCount = (uint) p_Value;
					break;

				case 2780479095:
					DynamicEnvmapFilterWidth = (float) p_Value;
					break;

				case 2423538194:
					LightTileMinArea = (float) p_Value;
					break;

				case 1892805023:
					DynamicEnvmapResolution = (uint) p_Value;
					break;

				case 923722776:
					GBufferLayout = (ShaderGBufferLayout) Enum.ToObject(typeof(ShaderGBufferLayout), p_Value);
					break;

				case 1631282070:
					DrawDebugSkyEnvmapMipLevel = (int) p_Value;
					break;

				case 4202430106:
					DecalVolumeScale = (float) p_Value;
					break;

				case 3901576513:
					LightOverdrawMaxLayerCount = (uint) p_Value;
					break;

				case 2395431963:
					LightRadiusScale = (float) p_Value;
					break;

				case 1982068814:
					LightAttenuationThreshold = (float) p_Value;
					break;

				case 3693875840:
					Ps3LightTileMethod = (uint) p_Value;
					break;

				case 1369534961:
					Ps3LightTileJobYieldGranularity = (float) p_Value;
					break;

				case 3807845992:
					OutdoorLightTileBatchCount = (uint) p_Value;
					break;

				case 357937911:
					XenonDrawDebugLightTileGridMode = (uint) p_Value;
					break;

				case 1614588396:
					LightStencilMinArea = (float) p_Value;
					break;

				case 1180048180:
					MaxSpotLightCount = (uint) p_Value;
					break;

				case 3938625702:
					SkyEnvmapFilterMode = (MipmapFilterMode) Enum.ToObject(typeof(MipmapFilterMode), p_Value);
					break;

				case 1142320547:
					SkyEnvmapFilterWidth = (float) p_Value;
					break;

				case 518179735:
					GBufferTestCount = (uint) p_Value;
					break;

				case 2394614219:
					SkyEnvmapResolution = (uint) p_Value;
					break;

				case 1555842164:
					SkyEnvmapSidesPerFrameCount = (uint) p_Value;
					break;

				case 2057182293:
					SubSurfaceRolloffLocalLight = (float) p_Value;
					break;

				case 4080551099:
					OnlyTileIndex = (int) p_Value;
					break;

				case 1868101726:
					OccluderMeshZPrepassEnable = (bool) p_Value;
					break;

				case 3504488559:
					OccluderMeshZPrepassDebugEnable = (bool) p_Value;
					break;

				case 1610721584:
					WireframeEnable = (bool) p_Value;
					break;

				case 593088739:
					HalfResEnable = (bool) p_Value;
					break;

				case 4061822776:
					HalfResLensFlaresEnable = (bool) p_Value;
					break;

				case 4286745103:
					ZPassEnable = (bool) p_Value;
					break;

				case 1970522271:
					ForegroundEnable = (bool) p_Value;
					break;

				case 2587067910:
					TiledHalfResCompositeEnable = (bool) p_Value;
					break;

				case 3501185556:
					ForegroundZPassEnable = (bool) p_Value;
					break;

				case 2582875939:
					DrawDebugVelocityBuffer = (bool) p_Value;
					break;

				case 1792351467:
					ForegroundDepthClearEnable = (bool) p_Value;
					break;

				case 3412436838:
					ForegroundAsMainEnable = (bool) p_Value;
					break;

				case 942753814:
					CustomEnvmapEnable = (bool) p_Value;
					break;

				case 24872004:
					SkyEnvmapEnable = (bool) p_Value;
					break;

				case 1503612810:
					DrawDebugVisibleEntityTypes = (bool) p_Value;
					break;

				case 4269064774:
					DrawDebugHalfResEnvironment = (bool) p_Value;
					break;

				case 774505577:
					DrawSolidBoundingBoxes = (bool) p_Value;
					break;

				case 744838686:
					BilateralHalfResCompositeEnable = (bool) p_Value;
					break;

				case 103034393:
					ForegroundTransparentEnable = (bool) p_Value;
					break;

				case 3104302735:
					TiledHalfResStencilOccludersEnable = (bool) p_Value;
					break;

				case 1443363541:
					SkyEnvmapUpdateEnable = (bool) p_Value;
					break;

				case 2268461288:
					SkyEnvmapForceUpdateEnable = (bool) p_Value;
					break;

				case 486850942:
					SkyEnvmapUse8BitTexture = (bool) p_Value;
					break;

				case 2364859152:
					DynamicEnvmapEnable = (bool) p_Value;
					break;

				case 2601139327:
					ScreenEffectEnable = (bool) p_Value;
					break;

				case 1169913743:
					DrawDebugZBufferEnable = (bool) p_Value;
					break;

				case 2767114856:
					MotionBlurStencilPassEnable = (bool) p_Value;
					break;

				case 3552597328:
					FinalPostEnable = (bool) p_Value;
					break;

				case 1883382345:
					DrawDebugQuarterShadowmaps = (bool) p_Value;
					break;

				case 1029929588:
					DrawDebugSkyEnvmap = (bool) p_Value;
					break;

				case 3461804538:
					DxShadowmap16BitEnable = (bool) p_Value;
					break;

				case 3838688308:
					DrawDebugTransShadowmap = (bool) p_Value;
					break;

				case 2380030875:
					DrawDebugSpotLightShadowmaps = (bool) p_Value;
					break;

				case 2870709294:
					DrawShadowFrustums = (bool) p_Value;
					break;

				case 3102950941:
					DrawDebugShadowmaps = (bool) p_Value;
					break;

				case 4052097317:
					SkyEnable = (bool) p_Value;
					break;

				case 815981309:
					DrawBoundingSpheres = (bool) p_Value;
					break;

				case 2141195304:
					DrawFrustums = (bool) p_Value;
					break;

				case 959292189:
					StaticEnvmapEnable = (bool) p_Value;
					break;

				case 3354775883:
					SkyFogEnable = (bool) p_Value;
					break;

				case 320578522:
					DrawLineBoundingBoxes = (bool) p_Value;
					break;

				case 3877557809:
					DrawDebugDestructionVolumes = (bool) p_Value;
					break;

				case 3334093503:
					LensFlaresEnable = (bool) p_Value;
					break;

				case 242868074:
					DrawDebugLensFlareOccluders = (bool) p_Value;
					break;

				case 2716428527:
					DrawDebugLensFlares = (bool) p_Value;
					break;

				case 1840684577:
					LensFlareOcclusionEnable = (bool) p_Value;
					break;

				case 1836462056:
					DrawDebugWorldOcclusions = (bool) p_Value;
					break;

				case 380549299:
					CloudShadowEnable = (bool) p_Value;
					break;

				case 4100682570:
					OverrideDynamicAO = (bool) p_Value;
					break;

				case 2076410863:
					DrawDebugDynamicAO = (bool) p_Value;
					break;

				case 3278293887:
					EmissiveEnable = (bool) p_Value;
					break;

				case 1089017582:
					UnlitEnable = (bool) p_Value;
					break;

				case 1514667872:
					SkyEnvmapMipmapGenEnable = (bool) p_Value;
					break;

				case 2462812853:
					DrawLightSources = (bool) p_Value;
					break;

				case 1575849658:
					GBufferClearEnable = (bool) p_Value;
					break;

				case 108346297:
					DxGBufferLight16BitEnable = (bool) p_Value;
					break;

				case 1352763380:
					DxGBufferNormal16BitEnable = (bool) p_Value;
					break;

				case 4261956399:
					GBufferAlphaTestSimpleEnable = (bool) p_Value;
					break;

				case 4059295125:
					SpecularLightingEnable = (bool) p_Value;
					break;

				case 1314853573:
					SkinLightingEnable = (bool) p_Value;
					break;

				case 2183602155:
					TranslucencyLightingEnable = (bool) p_Value;
					break;

				case 498214414:
					DynamicEnvmapLightingEnable = (bool) p_Value;
					break;

				case 430661890:
					OutdoorLightEnable = (bool) p_Value;
					break;

				case 4141437477:
					PointLightsEnable = (bool) p_Value;
					break;

				case 3741175111:
					LineLightsEnable = (bool) p_Value;
					break;

				case 3836085742:
					ConeLightsEnable = (bool) p_Value;
					break;

				case 3322632337:
					SpotLightsEnable = (bool) p_Value;
					break;

				case 2698387843:
					LightProbesEnable = (bool) p_Value;
					break;

				case 2357499407:
					LightStencilMethodEnable = (bool) p_Value;
					break;

				case 4215208333:
					LightVolumeMethodEnable = (bool) p_Value;
					break;

				case 2053389737:
					LightVolumeDepthTestEnable = (bool) p_Value;
					break;

				case 1247904586:
					OutputGammaCorrectionEnable = (bool) p_Value;
					break;

				case 2597933379:
					DrawDebugMultisampleClassify = (bool) p_Value;
					break;

				case 3309610805:
					OutdoorKeyLightEnable = (bool) p_Value;
					break;

				case 3067691555:
					OutdoorSkyLightEnable = (bool) p_Value;
					break;

				case 4075788653:
					OutdoorLightSpecularEnable = (bool) p_Value;
					break;

				case 916476147:
					OutdoorLightTilingEnable = (bool) p_Value;
					break;

				case 2607928252:
					OutdoorLightTileRenderEnable = (bool) p_Value;
					break;

				case 2912986711:
					OutdoorLightTileBlendEnable = (bool) p_Value;
					break;

				case 3559242705:
					OutdoorLightTileSimpleShaderEnable = (bool) p_Value;
					break;

				case 3181214902:
					Ps3TiledHalfTargetEnable = (bool) p_Value;
					break;

				case 4098755329:
					XenonOutdoorLightTilingEnable = (bool) p_Value;
					break;

				case 1965396134:
					XenonPointLightsTilingEnable = (bool) p_Value;
					break;

				case 1124054354:
					XenonSpotLightsTilingEnable = (bool) p_Value;
					break;

				case 251521284:
					XenonLineLightsTilingEnable = (bool) p_Value;
					break;

				case 415268666:
					XenonAsyncLightJobsEnable = (bool) p_Value;
					break;

				case 2247224033:
					XenonLightTileDownsampleSpecularCheckEnable = (bool) p_Value;
					break;

				case 3217869342:
					XenonLightTileCpuPointLightCullingEnable = (bool) p_Value;
					break;

				case 146196904:
					Ps3TiledSSAOTargetsEnable = (bool) p_Value;
					break;

				case 3556523217:
					Ps3SCullEnable = (bool) p_Value;
					break;

				case 1639633735:
					Ps3ColorCompressionEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 5401221:
					Ps3TilingEnable = (bool) p_Value;
					break;

				case 3033595312:
					Ps3DepthBoundsLightCullingEnable = (bool) p_Value;
					break;

				case 3239977624:
					Ps3ZCullEnable = (bool) p_Value;
					break;

				case 1444307324:
					ConsoleRenderTargetPoolSharingEnable = (bool) p_Value;
					break;

				case 1905490891:
					XenonFloatDepthBufferEnable = (bool) p_Value;
					break;

				case 2197108900:
					Ps3LightTileJobYieldEnable = (bool) p_Value;
					break;

				case 2730638227:
					Ps3HdrClearEnable = (bool) p_Value;
					break;

				case 519764264:
					XenonFastHdrEnable = (bool) p_Value;
					break;

				case 2533957960:
					ShadowmapViewDistanceScaleEnable = (bool) p_Value;
					break;

				case 1147234777:
					Ps3RenderTargetPoolGBufferOffsetEnable = (bool) p_Value;
					break;

				case 1387874714:
					HdrEnable = (bool) p_Value;
					break;

				case 735168888:
					SpotLightShadowmapEnable = (bool) p_Value;
					break;

				case 2195346787:
					SimpleShadowmapsEnable = (bool) p_Value;
					break;

				case 3651089763:
					DrawTransparent = (bool) p_Value;
					break;

				case 954292812:
					DrawTransparentDecal = (bool) p_Value;
					break;

				case 3040423717:
					ShadowmapFixedDepthEnable = (bool) p_Value;
					break;

				case 4284307744:
					DrawDebugDynamicEnvmap = (bool) p_Value;
					break;

				case 609671128:
					MotionBlurGeometryPassEnable = (bool) p_Value;
					break;

				case 353279157:
					DxLinearDepth32BitFormatEnable = (bool) p_Value;
					break;

				case 661192244:
					DynamicEnvmapMipmapGenEnable = (bool) p_Value;
					break;

				case 1384583315:
					MotionBlurEnable = (bool) p_Value;
					break;

				case 4228439617:
					ColoredShadowmapSlicesEnable = (bool) p_Value;
					break;

				case 3732955238:
					DxDeferredCsPathEnable = (bool) p_Value;
					break;

				case 1319030707:
					DrawDebugGBuffer = (bool) p_Value;
					break;

				case 2851277444:
					DrawDebugLightSources = (bool) p_Value;
					break;

				case 2743133634:
					DrawDebugLightShadowSources = (bool) p_Value;
					break;

				case 2758934155:
					DrawDebugLightStats = (bool) p_Value;
					break;

				case 2762953485:
					DrawDebugLightTiles = (bool) p_Value;
					break;

				case 2679360389:
					DrawDebugLightTileVolumes = (bool) p_Value;
					break;

				case 191247138:
					DrawDebugLightTileFbGrid = (bool) p_Value;
					break;

				case 1206975558:
					DrawDebugLightTileGrid = (bool) p_Value;
					break;

				case 1808094512:
					DrawDebugLightTileSources = (bool) p_Value;
					break;

				case 3574633209:
					ApplyShadowmapsEnable = (bool) p_Value;
					break;

				case 935873350:
					GenerateShadowmapsEnable = (bool) p_Value;
					break;

				case 1505079004:
					DxSpotLightShadowmap16BitEnable = (bool) p_Value;
					break;

				case 1210230998:
					Ps3Shadowmap16BitEnable = (bool) p_Value;
					break;

				case 93128048:
					Ps3SpotLightShadowmap16BitEnable = (bool) p_Value;
					break;

				case 3722054547:
					GenericEntityRendererEnable = (bool) p_Value;
					break;

				case 2809035620:
					SetupJobEnable = (bool) p_Value;
					break;

				case 3053945073:
					ShadowmapAccumBilinearEnable = (bool) p_Value;
					break;

				case 1310979964:
					LightWidthEnable = (bool) p_Value;
					break;

				case 2426904168:
					LightIntensityNormalizationEnable = (bool) p_Value;
					break;

				case 1558282924:
					LightCullEnable = (bool) p_Value;
					break;

				case 3065319457:
					LightDepthCullEnable = (bool) p_Value;
					break;

				case 2049659007:
					LightNormalCullEnable = (bool) p_Value;
					break;

				case 3640240491:
					LightConeCullEnable = (bool) p_Value;
					break;

				case 2508672340:
					LightTileOverlayEnable = (bool) p_Value;
					break;

				case 1756923903:
					Ps3ShadowmapTilingEnable = (bool) p_Value;
					break;

				case 3010075503:
					LightAttenuationThresholdEnable = (bool) p_Value;
					break;

				case 3650245535:
					SkyVisibilityEnvmapScalingEnable = (bool) p_Value;
					break;

				case 1654494478:
					ZBufferShadowTestEnable = (bool) p_Value;
					break;

				case 3081289741:
					ShadowmapsEnable = (bool) p_Value;
					break;

				case 504767143:
					ShadowmapAccumEnable = (bool) p_Value;
					break;

				case 2203514112:
					ShadowmapCullVolumeEnable = (bool) p_Value;
					break;

				case 3545910115:
					OpaqueSortBySolutionEnable = (bool) p_Value;
					break;

				case 1636817275:
					MainOpaqueZPassEnable = (bool) p_Value;
					break;

				case 2986167328:
					DrawDebugDecalVolumes = (bool) p_Value;
					break;

				case 2671877731:
					PlanarReflectionEnable = (bool) p_Value;
					break;

				case 3061910277:
					TransparencyShadowmapsEnable = (bool) p_Value;
					break;

				case 2516195767:
					DynamicCullDrawOccludedBoxesEnable = (bool) p_Value;
					break;

				case 1985957131:
					PlanarReflectionBlur = (bool) p_Value;
					break;

				case 564945563:
					DrawDebugPlanarReflectionCullFrustum = (bool) p_Value;
					break;

				case 3746596769:
					FreezePlanarReflectionCullFrustum = (bool) p_Value;
					break;

				case 3399148678:
					PlanarReflectionDebugCullMode = (bool) p_Value;
					break;

				case 1299347787:
					ShadowmapFixedMovementEnable = (bool) p_Value;
					break;

				case 1009689091:
					DecalVolumeEnable = (bool) p_Value;
					break;

				case 1620291507:
					DrawDebugPlanarReflection = (bool) p_Value;
					break;

				case 3263642426:
					FxaaEnable = (bool) p_Value;
					break;

				case 633481110:
					DynamicCullSpuJobEnable = (bool) p_Value;
					break;

				case 4122507627:
					DynamicCullZBufferTestEnable = (bool) p_Value;
					break;

				case 326459607:
					ViewFxEnable = (bool) p_Value;
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
				case 2442804067:
					return DynamicEnvmapDefaultPosition;

				case 1116837929:
					return SubSurfaceColor;

				case 372747593:
					return ViewportScale;

				case 1763892754:
					return ShadowMinScreenArea;

				case 1275076751:
					return ShadowViewportScale;

				case 1713753686:
					return FxaaQuality;

				case 989651568:
					return CullScreenAreaScale;

				case 3291231915:
					return PlanarReflectionCullFOV;

				case 3254270605:
					return GenericEntityMaxVisibleEntityCount;

				case 3508619736:
					return ShadowmapSizeZScale;

				case 3880013969:
					return ShadowmapResolution;

				case 4159686514:
					return ShadowmapQuality;

				case 3460109328:
					return ShadowmapPoissonFilterScale;

				case 1754397676:
					return ShadowmapSliceCount;

				case 4103828218:
					return ShadowmapSliceSchemeWeight;

				case 2040081677:
					return ShadowmapFirstSliceScale;

				case 1554572465:
					return ShadowmapViewDistance;

				case 1134551908:
					return PlanarReflectionWidth;

				case 658753014:
					return ShadowmapExtrusionLength;

				case 2714094958:
					return ShadowmapMinScreenArea;

				case 2965318295:
					return TempPlanarReflectionY;

				case 1376512303:
					return SubSurfaceRolloffKeyLight;

				case 3453976226:
					return FxaaForceVendor;

				case 2870536605:
					return PlanarReflectionHeight;

				case 4224101580:
					return LightIntensityScale;

				case 340957037:
					return LightLodSpecularFadeAreaEnd;

				case 4182219946:
					return ShadowmapMinFov;

				case 1941638882:
					return LightLodSpecularFadeAreaStart;

				case 2574597545:
					return LightLodRadiusFactor;

				case 1015351721:
					return LightForceIntensity;

				case 3993094733:
					return LightLodFadeArea;

				case 1014960449:
					return LightLodMinArea;

				case 1647206466:
					return DrawDebugDynamicEnvmapMipLevel;

				case 1711167253:
					return MaxDecalVolumeCount;

				case 922077962:
					return MotionBlurScale;

				case 1677064646:
					return MotionBlurMax;

				case 4082261780:
					return MotionBlurNoiseScale;

				case 3278537567:
					return MotionBlurQuality;

				case 2418772786:
					return MaxSpotLightShadowCount;

				case 3729378162:
					return DynamicEnvmapFilterMode;

				case 1447314883:
					return MotionBlurMaxSampleCount;

				case 1914506031:
					return MotionBlurFrameAverageCount;

				case 771939886:
					return MotionBlurMaxFrameTime;

				case 3772079119:
					return ForceMotionBlurDepthCutoff;

				case 3044262524:
					return ForceMotionBlurCutoffGradientScale;

				case 1049323753:
					return MultisampleCount;

				case 3044955837:
					return MultisampleThreshold;

				case 2623363008:
					return MaxPointLightCount;

				case 2418170502:
					return ReflectionEnvmapSize;

				case 4277463821:
					return SpotLightNearPlane;

				case 984299638:
					return SpotLightShadowmapPoissonFilterScale;

				case 883213115:
					return OnlyShadowmapSlice;

				case 381898379:
					return ViewMode;

				case 2435232759:
					return SpotLightShadowmapResolution;

				case 2998747480:
					return SpotLightShadomapLevel;

				case 4007866708:
					return SpotLightShadowmapQuality;

				case 1921288514:
					return OnlyLightTileY;

				case 1921288515:
					return OnlyLightTileX;

				case 2994673228:
					return XenonHdrColorScale;

				case 357430561:
					return XenonHdrColorScaleFactor;

				case 1822791039:
					return Ps3LightTileJobMaxFbTileCount;

				case 3383060069:
					return OnlyLightTileIndex;

				case 3257825371:
					return Ps3LightTileJobCount;

				case 2438614122:
					return Ps3LightTileJobPriority;

				case 2351028858:
					return XenonLightTileMaxLineLightCount;

				case 429843884:
					return XenonLightTileMaxSpotLightCount;

				case 2424724230:
					return XenonLightTileConstantBufferSize;

				case 2040884056:
					return XenonLightTileMaxPointLightCount;

				case 3613038148:
					return MaxDestructionVolumeCount;

				case 2780479095:
					return DynamicEnvmapFilterWidth;

				case 2423538194:
					return LightTileMinArea;

				case 1892805023:
					return DynamicEnvmapResolution;

				case 923722776:
					return GBufferLayout;

				case 1631282070:
					return DrawDebugSkyEnvmapMipLevel;

				case 4202430106:
					return DecalVolumeScale;

				case 3901576513:
					return LightOverdrawMaxLayerCount;

				case 2395431963:
					return LightRadiusScale;

				case 1982068814:
					return LightAttenuationThreshold;

				case 3693875840:
					return Ps3LightTileMethod;

				case 1369534961:
					return Ps3LightTileJobYieldGranularity;

				case 3807845992:
					return OutdoorLightTileBatchCount;

				case 357937911:
					return XenonDrawDebugLightTileGridMode;

				case 1614588396:
					return LightStencilMinArea;

				case 1180048180:
					return MaxSpotLightCount;

				case 3938625702:
					return SkyEnvmapFilterMode;

				case 1142320547:
					return SkyEnvmapFilterWidth;

				case 518179735:
					return GBufferTestCount;

				case 2394614219:
					return SkyEnvmapResolution;

				case 1555842164:
					return SkyEnvmapSidesPerFrameCount;

				case 2057182293:
					return SubSurfaceRolloffLocalLight;

				case 4080551099:
					return OnlyTileIndex;

				case 1868101726:
					return OccluderMeshZPrepassEnable;

				case 3504488559:
					return OccluderMeshZPrepassDebugEnable;

				case 1610721584:
					return WireframeEnable;

				case 593088739:
					return HalfResEnable;

				case 4061822776:
					return HalfResLensFlaresEnable;

				case 4286745103:
					return ZPassEnable;

				case 1970522271:
					return ForegroundEnable;

				case 2587067910:
					return TiledHalfResCompositeEnable;

				case 3501185556:
					return ForegroundZPassEnable;

				case 2582875939:
					return DrawDebugVelocityBuffer;

				case 1792351467:
					return ForegroundDepthClearEnable;

				case 3412436838:
					return ForegroundAsMainEnable;

				case 942753814:
					return CustomEnvmapEnable;

				case 24872004:
					return SkyEnvmapEnable;

				case 1503612810:
					return DrawDebugVisibleEntityTypes;

				case 4269064774:
					return DrawDebugHalfResEnvironment;

				case 774505577:
					return DrawSolidBoundingBoxes;

				case 744838686:
					return BilateralHalfResCompositeEnable;

				case 103034393:
					return ForegroundTransparentEnable;

				case 3104302735:
					return TiledHalfResStencilOccludersEnable;

				case 1443363541:
					return SkyEnvmapUpdateEnable;

				case 2268461288:
					return SkyEnvmapForceUpdateEnable;

				case 486850942:
					return SkyEnvmapUse8BitTexture;

				case 2364859152:
					return DynamicEnvmapEnable;

				case 2601139327:
					return ScreenEffectEnable;

				case 1169913743:
					return DrawDebugZBufferEnable;

				case 2767114856:
					return MotionBlurStencilPassEnable;

				case 3552597328:
					return FinalPostEnable;

				case 1883382345:
					return DrawDebugQuarterShadowmaps;

				case 1029929588:
					return DrawDebugSkyEnvmap;

				case 3461804538:
					return DxShadowmap16BitEnable;

				case 3838688308:
					return DrawDebugTransShadowmap;

				case 2380030875:
					return DrawDebugSpotLightShadowmaps;

				case 2870709294:
					return DrawShadowFrustums;

				case 3102950941:
					return DrawDebugShadowmaps;

				case 4052097317:
					return SkyEnable;

				case 815981309:
					return DrawBoundingSpheres;

				case 2141195304:
					return DrawFrustums;

				case 959292189:
					return StaticEnvmapEnable;

				case 3354775883:
					return SkyFogEnable;

				case 320578522:
					return DrawLineBoundingBoxes;

				case 3877557809:
					return DrawDebugDestructionVolumes;

				case 3334093503:
					return LensFlaresEnable;

				case 242868074:
					return DrawDebugLensFlareOccluders;

				case 2716428527:
					return DrawDebugLensFlares;

				case 1840684577:
					return LensFlareOcclusionEnable;

				case 1836462056:
					return DrawDebugWorldOcclusions;

				case 380549299:
					return CloudShadowEnable;

				case 4100682570:
					return OverrideDynamicAO;

				case 2076410863:
					return DrawDebugDynamicAO;

				case 3278293887:
					return EmissiveEnable;

				case 1089017582:
					return UnlitEnable;

				case 1514667872:
					return SkyEnvmapMipmapGenEnable;

				case 2462812853:
					return DrawLightSources;

				case 1575849658:
					return GBufferClearEnable;

				case 108346297:
					return DxGBufferLight16BitEnable;

				case 1352763380:
					return DxGBufferNormal16BitEnable;

				case 4261956399:
					return GBufferAlphaTestSimpleEnable;

				case 4059295125:
					return SpecularLightingEnable;

				case 1314853573:
					return SkinLightingEnable;

				case 2183602155:
					return TranslucencyLightingEnable;

				case 498214414:
					return DynamicEnvmapLightingEnable;

				case 430661890:
					return OutdoorLightEnable;

				case 4141437477:
					return PointLightsEnable;

				case 3741175111:
					return LineLightsEnable;

				case 3836085742:
					return ConeLightsEnable;

				case 3322632337:
					return SpotLightsEnable;

				case 2698387843:
					return LightProbesEnable;

				case 2357499407:
					return LightStencilMethodEnable;

				case 4215208333:
					return LightVolumeMethodEnable;

				case 2053389737:
					return LightVolumeDepthTestEnable;

				case 1247904586:
					return OutputGammaCorrectionEnable;

				case 2597933379:
					return DrawDebugMultisampleClassify;

				case 3309610805:
					return OutdoorKeyLightEnable;

				case 3067691555:
					return OutdoorSkyLightEnable;

				case 4075788653:
					return OutdoorLightSpecularEnable;

				case 916476147:
					return OutdoorLightTilingEnable;

				case 2607928252:
					return OutdoorLightTileRenderEnable;

				case 2912986711:
					return OutdoorLightTileBlendEnable;

				case 3559242705:
					return OutdoorLightTileSimpleShaderEnable;

				case 3181214902:
					return Ps3TiledHalfTargetEnable;

				case 4098755329:
					return XenonOutdoorLightTilingEnable;

				case 1965396134:
					return XenonPointLightsTilingEnable;

				case 1124054354:
					return XenonSpotLightsTilingEnable;

				case 251521284:
					return XenonLineLightsTilingEnable;

				case 415268666:
					return XenonAsyncLightJobsEnable;

				case 2247224033:
					return XenonLightTileDownsampleSpecularCheckEnable;

				case 3217869342:
					return XenonLightTileCpuPointLightCullingEnable;

				case 146196904:
					return Ps3TiledSSAOTargetsEnable;

				case 3556523217:
					return Ps3SCullEnable;

				case 1639633735:
					return Ps3ColorCompressionEnable;

				case 2342790116:
					return Enable;

				case 5401221:
					return Ps3TilingEnable;

				case 3033595312:
					return Ps3DepthBoundsLightCullingEnable;

				case 3239977624:
					return Ps3ZCullEnable;

				case 1444307324:
					return ConsoleRenderTargetPoolSharingEnable;

				case 1905490891:
					return XenonFloatDepthBufferEnable;

				case 2197108900:
					return Ps3LightTileJobYieldEnable;

				case 2730638227:
					return Ps3HdrClearEnable;

				case 519764264:
					return XenonFastHdrEnable;

				case 2533957960:
					return ShadowmapViewDistanceScaleEnable;

				case 1147234777:
					return Ps3RenderTargetPoolGBufferOffsetEnable;

				case 1387874714:
					return HdrEnable;

				case 735168888:
					return SpotLightShadowmapEnable;

				case 2195346787:
					return SimpleShadowmapsEnable;

				case 3651089763:
					return DrawTransparent;

				case 954292812:
					return DrawTransparentDecal;

				case 3040423717:
					return ShadowmapFixedDepthEnable;

				case 4284307744:
					return DrawDebugDynamicEnvmap;

				case 609671128:
					return MotionBlurGeometryPassEnable;

				case 353279157:
					return DxLinearDepth32BitFormatEnable;

				case 661192244:
					return DynamicEnvmapMipmapGenEnable;

				case 1384583315:
					return MotionBlurEnable;

				case 4228439617:
					return ColoredShadowmapSlicesEnable;

				case 3732955238:
					return DxDeferredCsPathEnable;

				case 1319030707:
					return DrawDebugGBuffer;

				case 2851277444:
					return DrawDebugLightSources;

				case 2743133634:
					return DrawDebugLightShadowSources;

				case 2758934155:
					return DrawDebugLightStats;

				case 2762953485:
					return DrawDebugLightTiles;

				case 2679360389:
					return DrawDebugLightTileVolumes;

				case 191247138:
					return DrawDebugLightTileFbGrid;

				case 1206975558:
					return DrawDebugLightTileGrid;

				case 1808094512:
					return DrawDebugLightTileSources;

				case 3574633209:
					return ApplyShadowmapsEnable;

				case 935873350:
					return GenerateShadowmapsEnable;

				case 1505079004:
					return DxSpotLightShadowmap16BitEnable;

				case 1210230998:
					return Ps3Shadowmap16BitEnable;

				case 93128048:
					return Ps3SpotLightShadowmap16BitEnable;

				case 3722054547:
					return GenericEntityRendererEnable;

				case 2809035620:
					return SetupJobEnable;

				case 3053945073:
					return ShadowmapAccumBilinearEnable;

				case 1310979964:
					return LightWidthEnable;

				case 2426904168:
					return LightIntensityNormalizationEnable;

				case 1558282924:
					return LightCullEnable;

				case 3065319457:
					return LightDepthCullEnable;

				case 2049659007:
					return LightNormalCullEnable;

				case 3640240491:
					return LightConeCullEnable;

				case 2508672340:
					return LightTileOverlayEnable;

				case 1756923903:
					return Ps3ShadowmapTilingEnable;

				case 3010075503:
					return LightAttenuationThresholdEnable;

				case 3650245535:
					return SkyVisibilityEnvmapScalingEnable;

				case 1654494478:
					return ZBufferShadowTestEnable;

				case 3081289741:
					return ShadowmapsEnable;

				case 504767143:
					return ShadowmapAccumEnable;

				case 2203514112:
					return ShadowmapCullVolumeEnable;

				case 3545910115:
					return OpaqueSortBySolutionEnable;

				case 1636817275:
					return MainOpaqueZPassEnable;

				case 2986167328:
					return DrawDebugDecalVolumes;

				case 2671877731:
					return PlanarReflectionEnable;

				case 3061910277:
					return TransparencyShadowmapsEnable;

				case 2516195767:
					return DynamicCullDrawOccludedBoxesEnable;

				case 1985957131:
					return PlanarReflectionBlur;

				case 564945563:
					return DrawDebugPlanarReflectionCullFrustum;

				case 3746596769:
					return FreezePlanarReflectionCullFrustum;

				case 3399148678:
					return PlanarReflectionDebugCullMode;

				case 1299347787:
					return ShadowmapFixedMovementEnable;

				case 1009689091:
					return DecalVolumeEnable;

				case 1620291507:
					return DrawDebugPlanarReflection;

				case 3263642426:
					return FxaaEnable;

				case 633481110:
					return DynamicCullSpuJobEnable;

				case 4122507627:
					return DynamicCullZBufferTestEnable;

				case 326459607:
					return ViewFxEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2442804067:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapDefaultPosition));

				case 1116837929:
					return typeof(WorldRenderSettings).GetProperty(nameof(SubSurfaceColor));

				case 372747593:
					return typeof(WorldRenderSettings).GetProperty(nameof(ViewportScale));

				case 1763892754:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowMinScreenArea));

				case 1275076751:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowViewportScale));

				case 1713753686:
					return typeof(WorldRenderSettings).GetProperty(nameof(FxaaQuality));

				case 989651568:
					return typeof(WorldRenderSettings).GetProperty(nameof(CullScreenAreaScale));

				case 3291231915:
					return typeof(WorldRenderSettings).GetProperty(nameof(PlanarReflectionCullFOV));

				case 3254270605:
					return typeof(WorldRenderSettings).GetProperty(nameof(GenericEntityMaxVisibleEntityCount));

				case 3508619736:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapSizeZScale));

				case 3880013969:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapResolution));

				case 4159686514:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapQuality));

				case 3460109328:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapPoissonFilterScale));

				case 1754397676:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapSliceCount));

				case 4103828218:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapSliceSchemeWeight));

				case 2040081677:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapFirstSliceScale));

				case 1554572465:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapViewDistance));

				case 1134551908:
					return typeof(WorldRenderSettings).GetProperty(nameof(PlanarReflectionWidth));

				case 658753014:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapExtrusionLength));

				case 2714094958:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapMinScreenArea));

				case 2965318295:
					return typeof(WorldRenderSettings).GetProperty(nameof(TempPlanarReflectionY));

				case 1376512303:
					return typeof(WorldRenderSettings).GetProperty(nameof(SubSurfaceRolloffKeyLight));

				case 3453976226:
					return typeof(WorldRenderSettings).GetProperty(nameof(FxaaForceVendor));

				case 2870536605:
					return typeof(WorldRenderSettings).GetProperty(nameof(PlanarReflectionHeight));

				case 4224101580:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightIntensityScale));

				case 340957037:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightLodSpecularFadeAreaEnd));

				case 4182219946:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapMinFov));

				case 1941638882:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightLodSpecularFadeAreaStart));

				case 2574597545:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightLodRadiusFactor));

				case 1015351721:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightForceIntensity));

				case 3993094733:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightLodFadeArea));

				case 1014960449:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightLodMinArea));

				case 1647206466:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugDynamicEnvmapMipLevel));

				case 1711167253:
					return typeof(WorldRenderSettings).GetProperty(nameof(MaxDecalVolumeCount));

				case 922077962:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurScale));

				case 1677064646:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurMax));

				case 4082261780:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurNoiseScale));

				case 3278537567:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurQuality));

				case 2418772786:
					return typeof(WorldRenderSettings).GetProperty(nameof(MaxSpotLightShadowCount));

				case 3729378162:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapFilterMode));

				case 1447314883:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurMaxSampleCount));

				case 1914506031:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurFrameAverageCount));

				case 771939886:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurMaxFrameTime));

				case 3772079119:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForceMotionBlurDepthCutoff));

				case 3044262524:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForceMotionBlurCutoffGradientScale));

				case 1049323753:
					return typeof(WorldRenderSettings).GetProperty(nameof(MultisampleCount));

				case 3044955837:
					return typeof(WorldRenderSettings).GetProperty(nameof(MultisampleThreshold));

				case 2623363008:
					return typeof(WorldRenderSettings).GetProperty(nameof(MaxPointLightCount));

				case 2418170502:
					return typeof(WorldRenderSettings).GetProperty(nameof(ReflectionEnvmapSize));

				case 4277463821:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightNearPlane));

				case 984299638:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightShadowmapPoissonFilterScale));

				case 883213115:
					return typeof(WorldRenderSettings).GetProperty(nameof(OnlyShadowmapSlice));

				case 381898379:
					return typeof(WorldRenderSettings).GetProperty(nameof(ViewMode));

				case 2435232759:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightShadowmapResolution));

				case 2998747480:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightShadomapLevel));

				case 4007866708:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightShadowmapQuality));

				case 1921288514:
					return typeof(WorldRenderSettings).GetProperty(nameof(OnlyLightTileY));

				case 1921288515:
					return typeof(WorldRenderSettings).GetProperty(nameof(OnlyLightTileX));

				case 2994673228:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonHdrColorScale));

				case 357430561:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonHdrColorScaleFactor));

				case 1822791039:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3LightTileJobMaxFbTileCount));

				case 3383060069:
					return typeof(WorldRenderSettings).GetProperty(nameof(OnlyLightTileIndex));

				case 3257825371:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3LightTileJobCount));

				case 2438614122:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3LightTileJobPriority));

				case 2351028858:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLightTileMaxLineLightCount));

				case 429843884:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLightTileMaxSpotLightCount));

				case 2424724230:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLightTileConstantBufferSize));

				case 2040884056:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLightTileMaxPointLightCount));

				case 3613038148:
					return typeof(WorldRenderSettings).GetProperty(nameof(MaxDestructionVolumeCount));

				case 2780479095:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapFilterWidth));

				case 2423538194:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightTileMinArea));

				case 1892805023:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapResolution));

				case 923722776:
					return typeof(WorldRenderSettings).GetProperty(nameof(GBufferLayout));

				case 1631282070:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugSkyEnvmapMipLevel));

				case 4202430106:
					return typeof(WorldRenderSettings).GetProperty(nameof(DecalVolumeScale));

				case 3901576513:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightOverdrawMaxLayerCount));

				case 2395431963:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightRadiusScale));

				case 1982068814:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightAttenuationThreshold));

				case 3693875840:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3LightTileMethod));

				case 1369534961:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3LightTileJobYieldGranularity));

				case 3807845992:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightTileBatchCount));

				case 357937911:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonDrawDebugLightTileGridMode));

				case 1614588396:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightStencilMinArea));

				case 1180048180:
					return typeof(WorldRenderSettings).GetProperty(nameof(MaxSpotLightCount));

				case 3938625702:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapFilterMode));

				case 1142320547:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapFilterWidth));

				case 518179735:
					return typeof(WorldRenderSettings).GetProperty(nameof(GBufferTestCount));

				case 2394614219:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapResolution));

				case 1555842164:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapSidesPerFrameCount));

				case 2057182293:
					return typeof(WorldRenderSettings).GetProperty(nameof(SubSurfaceRolloffLocalLight));

				case 4080551099:
					return typeof(WorldRenderSettings).GetProperty(nameof(OnlyTileIndex));

				case 1868101726:
					return typeof(WorldRenderSettings).GetProperty(nameof(OccluderMeshZPrepassEnable));

				case 3504488559:
					return typeof(WorldRenderSettings).GetProperty(nameof(OccluderMeshZPrepassDebugEnable));

				case 1610721584:
					return typeof(WorldRenderSettings).GetProperty(nameof(WireframeEnable));

				case 593088739:
					return typeof(WorldRenderSettings).GetProperty(nameof(HalfResEnable));

				case 4061822776:
					return typeof(WorldRenderSettings).GetProperty(nameof(HalfResLensFlaresEnable));

				case 4286745103:
					return typeof(WorldRenderSettings).GetProperty(nameof(ZPassEnable));

				case 1970522271:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForegroundEnable));

				case 2587067910:
					return typeof(WorldRenderSettings).GetProperty(nameof(TiledHalfResCompositeEnable));

				case 3501185556:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForegroundZPassEnable));

				case 2582875939:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugVelocityBuffer));

				case 1792351467:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForegroundDepthClearEnable));

				case 3412436838:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForegroundAsMainEnable));

				case 942753814:
					return typeof(WorldRenderSettings).GetProperty(nameof(CustomEnvmapEnable));

				case 24872004:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapEnable));

				case 1503612810:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugVisibleEntityTypes));

				case 4269064774:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugHalfResEnvironment));

				case 774505577:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawSolidBoundingBoxes));

				case 744838686:
					return typeof(WorldRenderSettings).GetProperty(nameof(BilateralHalfResCompositeEnable));

				case 103034393:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForegroundTransparentEnable));

				case 3104302735:
					return typeof(WorldRenderSettings).GetProperty(nameof(TiledHalfResStencilOccludersEnable));

				case 1443363541:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapUpdateEnable));

				case 2268461288:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapForceUpdateEnable));

				case 486850942:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapUse8BitTexture));

				case 2364859152:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapEnable));

				case 2601139327:
					return typeof(WorldRenderSettings).GetProperty(nameof(ScreenEffectEnable));

				case 1169913743:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugZBufferEnable));

				case 2767114856:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurStencilPassEnable));

				case 3552597328:
					return typeof(WorldRenderSettings).GetProperty(nameof(FinalPostEnable));

				case 1883382345:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugQuarterShadowmaps));

				case 1029929588:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugSkyEnvmap));

				case 3461804538:
					return typeof(WorldRenderSettings).GetProperty(nameof(DxShadowmap16BitEnable));

				case 3838688308:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugTransShadowmap));

				case 2380030875:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugSpotLightShadowmaps));

				case 2870709294:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawShadowFrustums));

				case 3102950941:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugShadowmaps));

				case 4052097317:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnable));

				case 815981309:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawBoundingSpheres));

				case 2141195304:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawFrustums));

				case 959292189:
					return typeof(WorldRenderSettings).GetProperty(nameof(StaticEnvmapEnable));

				case 3354775883:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyFogEnable));

				case 320578522:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawLineBoundingBoxes));

				case 3877557809:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugDestructionVolumes));

				case 3334093503:
					return typeof(WorldRenderSettings).GetProperty(nameof(LensFlaresEnable));

				case 242868074:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLensFlareOccluders));

				case 2716428527:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLensFlares));

				case 1840684577:
					return typeof(WorldRenderSettings).GetProperty(nameof(LensFlareOcclusionEnable));

				case 1836462056:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugWorldOcclusions));

				case 380549299:
					return typeof(WorldRenderSettings).GetProperty(nameof(CloudShadowEnable));

				case 4100682570:
					return typeof(WorldRenderSettings).GetProperty(nameof(OverrideDynamicAO));

				case 2076410863:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugDynamicAO));

				case 3278293887:
					return typeof(WorldRenderSettings).GetProperty(nameof(EmissiveEnable));

				case 1089017582:
					return typeof(WorldRenderSettings).GetProperty(nameof(UnlitEnable));

				case 1514667872:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapMipmapGenEnable));

				case 2462812853:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawLightSources));

				case 1575849658:
					return typeof(WorldRenderSettings).GetProperty(nameof(GBufferClearEnable));

				case 108346297:
					return typeof(WorldRenderSettings).GetProperty(nameof(DxGBufferLight16BitEnable));

				case 1352763380:
					return typeof(WorldRenderSettings).GetProperty(nameof(DxGBufferNormal16BitEnable));

				case 4261956399:
					return typeof(WorldRenderSettings).GetProperty(nameof(GBufferAlphaTestSimpleEnable));

				case 4059295125:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpecularLightingEnable));

				case 1314853573:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkinLightingEnable));

				case 2183602155:
					return typeof(WorldRenderSettings).GetProperty(nameof(TranslucencyLightingEnable));

				case 498214414:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapLightingEnable));

				case 430661890:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightEnable));

				case 4141437477:
					return typeof(WorldRenderSettings).GetProperty(nameof(PointLightsEnable));

				case 3741175111:
					return typeof(WorldRenderSettings).GetProperty(nameof(LineLightsEnable));

				case 3836085742:
					return typeof(WorldRenderSettings).GetProperty(nameof(ConeLightsEnable));

				case 3322632337:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightsEnable));

				case 2698387843:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightProbesEnable));

				case 2357499407:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightStencilMethodEnable));

				case 4215208333:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightVolumeMethodEnable));

				case 2053389737:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightVolumeDepthTestEnable));

				case 1247904586:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutputGammaCorrectionEnable));

				case 2597933379:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugMultisampleClassify));

				case 3309610805:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorKeyLightEnable));

				case 3067691555:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorSkyLightEnable));

				case 4075788653:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightSpecularEnable));

				case 916476147:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightTilingEnable));

				case 2607928252:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightTileRenderEnable));

				case 2912986711:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightTileBlendEnable));

				case 3559242705:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightTileSimpleShaderEnable));

				case 3181214902:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3TiledHalfTargetEnable));

				case 4098755329:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonOutdoorLightTilingEnable));

				case 1965396134:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonPointLightsTilingEnable));

				case 1124054354:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonSpotLightsTilingEnable));

				case 251521284:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLineLightsTilingEnable));

				case 415268666:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonAsyncLightJobsEnable));

				case 2247224033:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLightTileDownsampleSpecularCheckEnable));

				case 3217869342:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLightTileCpuPointLightCullingEnable));

				case 146196904:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3TiledSSAOTargetsEnable));

				case 3556523217:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3SCullEnable));

				case 1639633735:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3ColorCompressionEnable));

				case 2342790116:
					return typeof(WorldRenderSettings).GetProperty(nameof(Enable));

				case 5401221:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3TilingEnable));

				case 3033595312:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3DepthBoundsLightCullingEnable));

				case 3239977624:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3ZCullEnable));

				case 1444307324:
					return typeof(WorldRenderSettings).GetProperty(nameof(ConsoleRenderTargetPoolSharingEnable));

				case 1905490891:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonFloatDepthBufferEnable));

				case 2197108900:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3LightTileJobYieldEnable));

				case 2730638227:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3HdrClearEnable));

				case 519764264:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonFastHdrEnable));

				case 2533957960:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapViewDistanceScaleEnable));

				case 1147234777:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3RenderTargetPoolGBufferOffsetEnable));

				case 1387874714:
					return typeof(WorldRenderSettings).GetProperty(nameof(HdrEnable));

				case 735168888:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightShadowmapEnable));

				case 2195346787:
					return typeof(WorldRenderSettings).GetProperty(nameof(SimpleShadowmapsEnable));

				case 3651089763:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawTransparent));

				case 954292812:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawTransparentDecal));

				case 3040423717:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapFixedDepthEnable));

				case 4284307744:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugDynamicEnvmap));

				case 609671128:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurGeometryPassEnable));

				case 353279157:
					return typeof(WorldRenderSettings).GetProperty(nameof(DxLinearDepth32BitFormatEnable));

				case 661192244:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapMipmapGenEnable));

				case 1384583315:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurEnable));

				case 4228439617:
					return typeof(WorldRenderSettings).GetProperty(nameof(ColoredShadowmapSlicesEnable));

				case 3732955238:
					return typeof(WorldRenderSettings).GetProperty(nameof(DxDeferredCsPathEnable));

				case 1319030707:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugGBuffer));

				case 2851277444:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightSources));

				case 2743133634:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightShadowSources));

				case 2758934155:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightStats));

				case 2762953485:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightTiles));

				case 2679360389:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightTileVolumes));

				case 191247138:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightTileFbGrid));

				case 1206975558:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightTileGrid));

				case 1808094512:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightTileSources));

				case 3574633209:
					return typeof(WorldRenderSettings).GetProperty(nameof(ApplyShadowmapsEnable));

				case 935873350:
					return typeof(WorldRenderSettings).GetProperty(nameof(GenerateShadowmapsEnable));

				case 1505079004:
					return typeof(WorldRenderSettings).GetProperty(nameof(DxSpotLightShadowmap16BitEnable));

				case 1210230998:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3Shadowmap16BitEnable));

				case 93128048:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3SpotLightShadowmap16BitEnable));

				case 3722054547:
					return typeof(WorldRenderSettings).GetProperty(nameof(GenericEntityRendererEnable));

				case 2809035620:
					return typeof(WorldRenderSettings).GetProperty(nameof(SetupJobEnable));

				case 3053945073:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapAccumBilinearEnable));

				case 1310979964:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightWidthEnable));

				case 2426904168:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightIntensityNormalizationEnable));

				case 1558282924:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightCullEnable));

				case 3065319457:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightDepthCullEnable));

				case 2049659007:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightNormalCullEnable));

				case 3640240491:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightConeCullEnable));

				case 2508672340:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightTileOverlayEnable));

				case 1756923903:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3ShadowmapTilingEnable));

				case 3010075503:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightAttenuationThresholdEnable));

				case 3650245535:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyVisibilityEnvmapScalingEnable));

				case 1654494478:
					return typeof(WorldRenderSettings).GetProperty(nameof(ZBufferShadowTestEnable));

				case 3081289741:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapsEnable));

				case 504767143:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapAccumEnable));

				case 2203514112:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapCullVolumeEnable));

				case 3545910115:
					return typeof(WorldRenderSettings).GetProperty(nameof(OpaqueSortBySolutionEnable));

				case 1636817275:
					return typeof(WorldRenderSettings).GetProperty(nameof(MainOpaqueZPassEnable));

				case 2986167328:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugDecalVolumes));

				case 2671877731:
					return typeof(WorldRenderSettings).GetProperty(nameof(PlanarReflectionEnable));

				case 3061910277:
					return typeof(WorldRenderSettings).GetProperty(nameof(TransparencyShadowmapsEnable));

				case 2516195767:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicCullDrawOccludedBoxesEnable));

				case 1985957131:
					return typeof(WorldRenderSettings).GetProperty(nameof(PlanarReflectionBlur));

				case 564945563:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugPlanarReflectionCullFrustum));

				case 3746596769:
					return typeof(WorldRenderSettings).GetProperty(nameof(FreezePlanarReflectionCullFrustum));

				case 3399148678:
					return typeof(WorldRenderSettings).GetProperty(nameof(PlanarReflectionDebugCullMode));

				case 1299347787:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapFixedMovementEnable));

				case 1009689091:
					return typeof(WorldRenderSettings).GetProperty(nameof(DecalVolumeEnable));

				case 1620291507:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugPlanarReflection));

				case 3263642426:
					return typeof(WorldRenderSettings).GetProperty(nameof(FxaaEnable));

				case 633481110:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicCullSpuJobEnable));

				case 4122507627:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicCullZBufferTestEnable));

				case 326459607:
					return typeof(WorldRenderSettings).GetProperty(nameof(ViewFxEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
