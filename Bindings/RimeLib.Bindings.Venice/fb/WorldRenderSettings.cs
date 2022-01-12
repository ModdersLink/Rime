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
	[ContainerType(16, 576)]
	public class WorldRenderSettings : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DynamicEnvmapDefaultPosition { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SubSurfaceColor { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public float ViewportScale { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float ShadowMinScreenArea { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float ShadowViewportScale { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public uint FxaaQuality { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float CullScreenAreaScale { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float PlanarReflectionCullFOV { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public uint GenericEntityMaxVisibleEntityCount { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float ShadowmapSizeZScale { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public uint ShadowmapResolution { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public uint ShadowmapQuality { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float ShadowmapPoissonFilterScale { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public uint ShadowmapSliceCount { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float ShadowmapSliceSchemeWeight { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float ShadowmapFirstSliceScale { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float ShadowmapViewDistance { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public uint PlanarReflectionWidth { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float ShadowmapExtrusionLength { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float ShadowmapMinScreenArea { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float TempPlanarReflectionY { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float SubSurfaceRolloffKeyLight { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public int FxaaForceVendor { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public uint PlanarReflectionHeight { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float LightIntensityScale { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float LightLodSpecularFadeAreaEnd { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float ShadowmapMinFov { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float LightLodSpecularFadeAreaStart { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float LightLodRadiusFactor { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float LightForceIntensity { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float LightLodFadeArea { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float LightLodMinArea { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public int DrawDebugDynamicEnvmapMipLevel { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public uint MaxDecalVolumeCount { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float MotionBlurScale { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float MotionBlurMax { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float MotionBlurNoiseScale { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public uint MotionBlurQuality { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public uint MaxSpotLightShadowCount { get; set; }

		[ContainerField(196)]
		public MipmapFilterMode DynamicEnvmapFilterMode { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable]
		public uint MotionBlurMaxSampleCount { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public uint MotionBlurFrameAverageCount { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public float MotionBlurMaxFrameTime { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public float ForceMotionBlurDepthCutoff { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public float ForceMotionBlurCutoffGradientScale { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public uint MultisampleCount { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public float MultisampleThreshold { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable]
		public uint MaxPointLightCount { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable]
		public uint ReflectionEnvmapSize { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public float SpotLightNearPlane { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public float SpotLightShadowmapPoissonFilterScale { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public int OnlyShadowmapSlice { get; set; }

		[ContainerField(248)]
		public WorldViewMode ViewMode { get; set; } = new();

		[ContainerField(252), LayoutImmutable, Blittable]
		public uint SpotLightShadowmapResolution { get; set; }

		[ContainerField(256)]
		public QualityLevel SpotLightShadomapLevel { get; set; } = new();

		[ContainerField(260), LayoutImmutable, Blittable]
		public uint SpotLightShadowmapQuality { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable]
		public int OnlyLightTileY { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable]
		public int OnlyLightTileX { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable]
		public float XenonHdrColorScale { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable]
		public float XenonHdrColorScaleFactor { get; set; }

		[ContainerField(280), LayoutImmutable, Blittable]
		public uint Ps3LightTileJobMaxFbTileCount { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable]
		public int OnlyLightTileIndex { get; set; }

		[ContainerField(288), LayoutImmutable, Blittable]
		public uint Ps3LightTileJobCount { get; set; }

		[ContainerField(292), LayoutImmutable, Blittable]
		public uint Ps3LightTileJobPriority { get; set; }

		[ContainerField(296), LayoutImmutable, Blittable]
		public uint XenonLightTileMaxLineLightCount { get; set; }

		[ContainerField(300), LayoutImmutable, Blittable]
		public uint XenonLightTileMaxSpotLightCount { get; set; }

		[ContainerField(304), LayoutImmutable, Blittable]
		public uint XenonLightTileConstantBufferSize { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable]
		public uint XenonLightTileMaxPointLightCount { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable]
		public uint MaxDestructionVolumeCount { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable]
		public float DynamicEnvmapFilterWidth { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable]
		public float LightTileMinArea { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable]
		public uint DynamicEnvmapResolution { get; set; }

		[ContainerField(328)]
		public ShaderGBufferLayout GBufferLayout { get; set; } = new();

		[ContainerField(332), LayoutImmutable, Blittable]
		public int DrawDebugSkyEnvmapMipLevel { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable]
		public float DecalVolumeScale { get; set; }

		[ContainerField(340), LayoutImmutable, Blittable]
		public uint LightOverdrawMaxLayerCount { get; set; }

		[ContainerField(344), LayoutImmutable, Blittable]
		public float LightRadiusScale { get; set; }

		[ContainerField(348), LayoutImmutable, Blittable]
		public float LightAttenuationThreshold { get; set; }

		[ContainerField(352), LayoutImmutable, Blittable]
		public uint Ps3LightTileMethod { get; set; }

		[ContainerField(356), LayoutImmutable, Blittable]
		public float Ps3LightTileJobYieldGranularity { get; set; }

		[ContainerField(360), LayoutImmutable, Blittable]
		public uint OutdoorLightTileBatchCount { get; set; }

		[ContainerField(364), LayoutImmutable, Blittable]
		public uint XenonDrawDebugLightTileGridMode { get; set; }

		[ContainerField(368), LayoutImmutable, Blittable]
		public float LightStencilMinArea { get; set; }

		[ContainerField(372), LayoutImmutable, Blittable]
		public uint MaxSpotLightCount { get; set; }

		[ContainerField(376)]
		public MipmapFilterMode SkyEnvmapFilterMode { get; set; } = new();

		[ContainerField(380), LayoutImmutable, Blittable]
		public float SkyEnvmapFilterWidth { get; set; }

		[ContainerField(384), LayoutImmutable, Blittable]
		public uint GBufferTestCount { get; set; }

		[ContainerField(388), LayoutImmutable, Blittable]
		public uint SkyEnvmapResolution { get; set; }

		[ContainerField(392), LayoutImmutable, Blittable]
		public uint SkyEnvmapSidesPerFrameCount { get; set; }

		[ContainerField(396), LayoutImmutable, Blittable]
		public float SubSurfaceRolloffLocalLight { get; set; }

		[ContainerField(400), LayoutImmutable, Blittable]
		public int OnlyTileIndex { get; set; }

		[ContainerField(404), LayoutImmutable, Blittable]
		public bool OccluderMeshZPrepassEnable { get; set; }

		[ContainerField(405), LayoutImmutable, Blittable]
		public bool OccluderMeshZPrepassDebugEnable { get; set; }

		[ContainerField(406), LayoutImmutable, Blittable]
		public bool WireframeEnable { get; set; }

		[ContainerField(407), LayoutImmutable, Blittable]
		public bool HalfResEnable { get; set; }

		[ContainerField(408), LayoutImmutable, Blittable]
		public bool HalfResLensFlaresEnable { get; set; }

		[ContainerField(409), LayoutImmutable, Blittable]
		public bool ZPassEnable { get; set; }

		[ContainerField(410), LayoutImmutable, Blittable]
		public bool ForegroundEnable { get; set; }

		[ContainerField(411), LayoutImmutable, Blittable]
		public bool TiledHalfResCompositeEnable { get; set; }

		[ContainerField(412), LayoutImmutable, Blittable]
		public bool ForegroundZPassEnable { get; set; }

		[ContainerField(413), LayoutImmutable, Blittable]
		public bool DrawDebugVelocityBuffer { get; set; }

		[ContainerField(414), LayoutImmutable, Blittable]
		public bool ForegroundDepthClearEnable { get; set; }

		[ContainerField(415), LayoutImmutable, Blittable]
		public bool ForegroundAsMainEnable { get; set; }

		[ContainerField(416), LayoutImmutable, Blittable]
		public bool CustomEnvmapEnable { get; set; }

		[ContainerField(417), LayoutImmutable, Blittable]
		public bool SkyEnvmapEnable { get; set; }

		[ContainerField(418), LayoutImmutable, Blittable]
		public bool DrawDebugVisibleEntityTypes { get; set; }

		[ContainerField(419), LayoutImmutable, Blittable]
		public bool DrawDebugHalfResEnvironment { get; set; }

		[ContainerField(420), LayoutImmutable, Blittable]
		public bool DrawSolidBoundingBoxes { get; set; }

		[ContainerField(421), LayoutImmutable, Blittable]
		public bool BilateralHalfResCompositeEnable { get; set; }

		[ContainerField(422), LayoutImmutable, Blittable]
		public bool ForegroundTransparentEnable { get; set; }

		[ContainerField(423), LayoutImmutable, Blittable]
		public bool TiledHalfResStencilOccludersEnable { get; set; }

		[ContainerField(424), LayoutImmutable, Blittable]
		public bool SkyEnvmapUpdateEnable { get; set; }

		[ContainerField(425), LayoutImmutable, Blittable]
		public bool SkyEnvmapForceUpdateEnable { get; set; }

		[ContainerField(426), LayoutImmutable, Blittable]
		public bool SkyEnvmapUse8BitTexture { get; set; }

		[ContainerField(427), LayoutImmutable, Blittable]
		public bool DynamicEnvmapEnable { get; set; }

		[ContainerField(428), LayoutImmutable, Blittable]
		public bool ScreenEffectEnable { get; set; }

		[ContainerField(429), LayoutImmutable, Blittable]
		public bool DrawDebugZBufferEnable { get; set; }

		[ContainerField(430), LayoutImmutable, Blittable]
		public bool MotionBlurStencilPassEnable { get; set; }

		[ContainerField(431), LayoutImmutable, Blittable]
		public bool FinalPostEnable { get; set; }

		[ContainerField(432), LayoutImmutable, Blittable]
		public bool DrawDebugQuarterShadowmaps { get; set; }

		[ContainerField(433), LayoutImmutable, Blittable]
		public bool DrawDebugSkyEnvmap { get; set; }

		[ContainerField(434), LayoutImmutable, Blittable]
		public bool DxShadowmap16BitEnable { get; set; }

		[ContainerField(435), LayoutImmutable, Blittable]
		public bool DrawDebugTransShadowmap { get; set; }

		[ContainerField(436), LayoutImmutable, Blittable]
		public bool DrawDebugSpotLightShadowmaps { get; set; }

		[ContainerField(437), LayoutImmutable, Blittable]
		public bool DrawShadowFrustums { get; set; }

		[ContainerField(438), LayoutImmutable, Blittable]
		public bool DrawDebugShadowmaps { get; set; }

		[ContainerField(439), LayoutImmutable, Blittable]
		public bool SkyEnable { get; set; }

		[ContainerField(440), LayoutImmutable, Blittable]
		public bool DrawBoundingSpheres { get; set; }

		[ContainerField(441), LayoutImmutable, Blittable]
		public bool DrawFrustums { get; set; }

		[ContainerField(442), LayoutImmutable, Blittable]
		public bool StaticEnvmapEnable { get; set; }

		[ContainerField(443), LayoutImmutable, Blittable]
		public bool SkyFogEnable { get; set; }

		[ContainerField(444), LayoutImmutable, Blittable]
		public bool DrawLineBoundingBoxes { get; set; }

		[ContainerField(445), LayoutImmutable, Blittable]
		public bool DrawDebugDestructionVolumes { get; set; }

		[ContainerField(446), LayoutImmutable, Blittable]
		public bool LensFlaresEnable { get; set; }

		[ContainerField(447), LayoutImmutable, Blittable]
		public bool DrawDebugLensFlareOccluders { get; set; }

		[ContainerField(448), LayoutImmutable, Blittable]
		public bool DrawDebugLensFlares { get; set; }

		[ContainerField(449), LayoutImmutable, Blittable]
		public bool LensFlareOcclusionEnable { get; set; }

		[ContainerField(450), LayoutImmutable, Blittable]
		public bool DrawDebugWorldOcclusions { get; set; }

		[ContainerField(451), LayoutImmutable, Blittable]
		public bool CloudShadowEnable { get; set; }

		[ContainerField(452), LayoutImmutable, Blittable]
		public bool OverrideDynamicAO { get; set; }

		[ContainerField(453), LayoutImmutable, Blittable]
		public bool DrawDebugDynamicAO { get; set; }

		[ContainerField(454), LayoutImmutable, Blittable]
		public bool EmissiveEnable { get; set; }

		[ContainerField(455), LayoutImmutable, Blittable]
		public bool UnlitEnable { get; set; }

		[ContainerField(456), LayoutImmutable, Blittable]
		public bool SkyEnvmapMipmapGenEnable { get; set; }

		[ContainerField(457), LayoutImmutable, Blittable]
		public bool DrawLightSources { get; set; }

		[ContainerField(458), LayoutImmutable, Blittable]
		public bool GBufferClearEnable { get; set; }

		[ContainerField(459), LayoutImmutable, Blittable]
		public bool DxGBufferLight16BitEnable { get; set; }

		[ContainerField(460), LayoutImmutable, Blittable]
		public bool DxGBufferNormal16BitEnable { get; set; }

		[ContainerField(461), LayoutImmutable, Blittable]
		public bool GBufferAlphaTestSimpleEnable { get; set; }

		[ContainerField(462), LayoutImmutable, Blittable]
		public bool SpecularLightingEnable { get; set; }

		[ContainerField(463), LayoutImmutable, Blittable]
		public bool SkinLightingEnable { get; set; }

		[ContainerField(464), LayoutImmutable, Blittable]
		public bool TranslucencyLightingEnable { get; set; }

		[ContainerField(465), LayoutImmutable, Blittable]
		public bool DynamicEnvmapLightingEnable { get; set; }

		[ContainerField(466), LayoutImmutable, Blittable]
		public bool OutdoorLightEnable { get; set; }

		[ContainerField(467), LayoutImmutable, Blittable]
		public bool PointLightsEnable { get; set; }

		[ContainerField(468), LayoutImmutable, Blittable]
		public bool LineLightsEnable { get; set; }

		[ContainerField(469), LayoutImmutable, Blittable]
		public bool ConeLightsEnable { get; set; }

		[ContainerField(470), LayoutImmutable, Blittable]
		public bool SpotLightsEnable { get; set; }

		[ContainerField(471), LayoutImmutable, Blittable]
		public bool LightProbesEnable { get; set; }

		[ContainerField(472), LayoutImmutable, Blittable]
		public bool LightStencilMethodEnable { get; set; }

		[ContainerField(473), LayoutImmutable, Blittable]
		public bool LightVolumeMethodEnable { get; set; }

		[ContainerField(474), LayoutImmutable, Blittable]
		public bool LightVolumeDepthTestEnable { get; set; }

		[ContainerField(475), LayoutImmutable, Blittable]
		public bool OutputGammaCorrectionEnable { get; set; }

		[ContainerField(476), LayoutImmutable, Blittable]
		public bool DrawDebugMultisampleClassify { get; set; }

		[ContainerField(477), LayoutImmutable, Blittable]
		public bool OutdoorKeyLightEnable { get; set; }

		[ContainerField(478), LayoutImmutable, Blittable]
		public bool OutdoorSkyLightEnable { get; set; }

		[ContainerField(479), LayoutImmutable, Blittable]
		public bool OutdoorLightSpecularEnable { get; set; }

		[ContainerField(480), LayoutImmutable, Blittable]
		public bool OutdoorLightTilingEnable { get; set; }

		[ContainerField(481), LayoutImmutable, Blittable]
		public bool OutdoorLightTileRenderEnable { get; set; }

		[ContainerField(482), LayoutImmutable, Blittable]
		public bool OutdoorLightTileBlendEnable { get; set; }

		[ContainerField(483), LayoutImmutable, Blittable]
		public bool OutdoorLightTileSimpleShaderEnable { get; set; }

		[ContainerField(484), LayoutImmutable, Blittable]
		public bool Ps3TiledHalfTargetEnable { get; set; }

		[ContainerField(485), LayoutImmutable, Blittable]
		public bool XenonOutdoorLightTilingEnable { get; set; }

		[ContainerField(486), LayoutImmutable, Blittable]
		public bool XenonPointLightsTilingEnable { get; set; }

		[ContainerField(487), LayoutImmutable, Blittable]
		public bool XenonSpotLightsTilingEnable { get; set; }

		[ContainerField(488), LayoutImmutable, Blittable]
		public bool XenonLineLightsTilingEnable { get; set; }

		[ContainerField(489), LayoutImmutable, Blittable]
		public bool XenonAsyncLightJobsEnable { get; set; }

		[ContainerField(490), LayoutImmutable, Blittable]
		public bool XenonLightTileDownsampleSpecularCheckEnable { get; set; }

		[ContainerField(491), LayoutImmutable, Blittable]
		public bool XenonLightTileCpuPointLightCullingEnable { get; set; }

		[ContainerField(492), LayoutImmutable, Blittable]
		public bool Ps3TiledSSAOTargetsEnable { get; set; }

		[ContainerField(493), LayoutImmutable, Blittable]
		public bool Ps3SCullEnable { get; set; }

		[ContainerField(494), LayoutImmutable, Blittable]
		public bool Ps3ColorCompressionEnable { get; set; }

		[ContainerField(495), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(496), LayoutImmutable, Blittable]
		public bool Ps3TilingEnable { get; set; }

		[ContainerField(497), LayoutImmutable, Blittable]
		public bool Ps3DepthBoundsLightCullingEnable { get; set; }

		[ContainerField(498), LayoutImmutable, Blittable]
		public bool Ps3ZCullEnable { get; set; }

		[ContainerField(499), LayoutImmutable, Blittable]
		public bool ConsoleRenderTargetPoolSharingEnable { get; set; }

		[ContainerField(500), LayoutImmutable, Blittable]
		public bool XenonFloatDepthBufferEnable { get; set; }

		[ContainerField(501), LayoutImmutable, Blittable]
		public bool Ps3LightTileJobYieldEnable { get; set; }

		[ContainerField(502), LayoutImmutable, Blittable]
		public bool Ps3HdrClearEnable { get; set; }

		[ContainerField(503), LayoutImmutable, Blittable]
		public bool XenonFastHdrEnable { get; set; }

		[ContainerField(504), LayoutImmutable, Blittable]
		public bool ShadowmapViewDistanceScaleEnable { get; set; }

		[ContainerField(505), LayoutImmutable, Blittable]
		public bool Ps3RenderTargetPoolGBufferOffsetEnable { get; set; }

		[ContainerField(506), LayoutImmutable, Blittable]
		public bool HdrEnable { get; set; }

		[ContainerField(507), LayoutImmutable, Blittable]
		public bool SpotLightShadowmapEnable { get; set; }

		[ContainerField(508), LayoutImmutable, Blittable]
		public bool SimpleShadowmapsEnable { get; set; }

		[ContainerField(509), LayoutImmutable, Blittable]
		public bool DrawTransparent { get; set; }

		[ContainerField(510), LayoutImmutable, Blittable]
		public bool DrawTransparentDecal { get; set; }

		[ContainerField(511), LayoutImmutable, Blittable]
		public bool ShadowmapFixedDepthEnable { get; set; }

		[ContainerField(512), LayoutImmutable, Blittable]
		public bool DrawDebugDynamicEnvmap { get; set; }

		[ContainerField(513), LayoutImmutable, Blittable]
		public bool MotionBlurGeometryPassEnable { get; set; }

		[ContainerField(514), LayoutImmutable, Blittable]
		public bool DxLinearDepth32BitFormatEnable { get; set; }

		[ContainerField(515), LayoutImmutable, Blittable]
		public bool DynamicEnvmapMipmapGenEnable { get; set; }

		[ContainerField(516), LayoutImmutable, Blittable]
		public bool MotionBlurEnable { get; set; }

		[ContainerField(517), LayoutImmutable, Blittable]
		public bool ColoredShadowmapSlicesEnable { get; set; }

		[ContainerField(518), LayoutImmutable, Blittable]
		public bool DxDeferredCsPathEnable { get; set; }

		[ContainerField(519), LayoutImmutable, Blittable]
		public bool DrawDebugGBuffer { get; set; }

		[ContainerField(520), LayoutImmutable, Blittable]
		public bool DrawDebugLightSources { get; set; }

		[ContainerField(521), LayoutImmutable, Blittable]
		public bool DrawDebugLightShadowSources { get; set; }

		[ContainerField(522), LayoutImmutable, Blittable]
		public bool DrawDebugLightStats { get; set; }

		[ContainerField(523), LayoutImmutable, Blittable]
		public bool DrawDebugLightTiles { get; set; }

		[ContainerField(524), LayoutImmutable, Blittable]
		public bool DrawDebugLightTileVolumes { get; set; }

		[ContainerField(525), LayoutImmutable, Blittable]
		public bool DrawDebugLightTileFbGrid { get; set; }

		[ContainerField(526), LayoutImmutable, Blittable]
		public bool DrawDebugLightTileGrid { get; set; }

		[ContainerField(527), LayoutImmutable, Blittable]
		public bool DrawDebugLightTileSources { get; set; }

		[ContainerField(528), LayoutImmutable, Blittable]
		public bool ApplyShadowmapsEnable { get; set; }

		[ContainerField(529), LayoutImmutable, Blittable]
		public bool GenerateShadowmapsEnable { get; set; }

		[ContainerField(530), LayoutImmutable, Blittable]
		public bool DxSpotLightShadowmap16BitEnable { get; set; }

		[ContainerField(531), LayoutImmutable, Blittable]
		public bool Ps3Shadowmap16BitEnable { get; set; }

		[ContainerField(532), LayoutImmutable, Blittable]
		public bool Ps3SpotLightShadowmap16BitEnable { get; set; }

		[ContainerField(533), LayoutImmutable, Blittable]
		public bool GenericEntityRendererEnable { get; set; }

		[ContainerField(534), LayoutImmutable, Blittable]
		public bool SetupJobEnable { get; set; }

		[ContainerField(535), LayoutImmutable, Blittable]
		public bool ShadowmapAccumBilinearEnable { get; set; }

		[ContainerField(536), LayoutImmutable, Blittable]
		public bool LightWidthEnable { get; set; }

		[ContainerField(537), LayoutImmutable, Blittable]
		public bool LightIntensityNormalizationEnable { get; set; }

		[ContainerField(538), LayoutImmutable, Blittable]
		public bool LightCullEnable { get; set; }

		[ContainerField(539), LayoutImmutable, Blittable]
		public bool LightDepthCullEnable { get; set; }

		[ContainerField(540), LayoutImmutable, Blittable]
		public bool LightNormalCullEnable { get; set; }

		[ContainerField(541), LayoutImmutable, Blittable]
		public bool LightConeCullEnable { get; set; }

		[ContainerField(542), LayoutImmutable, Blittable]
		public bool LightTileOverlayEnable { get; set; }

		[ContainerField(543), LayoutImmutable, Blittable]
		public bool Ps3ShadowmapTilingEnable { get; set; }

		[ContainerField(544), LayoutImmutable, Blittable]
		public bool LightAttenuationThresholdEnable { get; set; }

		[ContainerField(545), LayoutImmutable, Blittable]
		public bool SkyVisibilityEnvmapScalingEnable { get; set; }

		[ContainerField(546), LayoutImmutable, Blittable]
		public bool ZBufferShadowTestEnable { get; set; }

		[ContainerField(547), LayoutImmutable, Blittable]
		public bool ShadowmapsEnable { get; set; }

		[ContainerField(548), LayoutImmutable, Blittable]
		public bool ShadowmapAccumEnable { get; set; }

		[ContainerField(549), LayoutImmutable, Blittable]
		public bool ShadowmapCullVolumeEnable { get; set; }

		[ContainerField(550), LayoutImmutable, Blittable]
		public bool OpaqueSortBySolutionEnable { get; set; }

		[ContainerField(551), LayoutImmutable, Blittable]
		public bool MainOpaqueZPassEnable { get; set; }

		[ContainerField(552), LayoutImmutable, Blittable]
		public bool DrawDebugDecalVolumes { get; set; }

		[ContainerField(553), LayoutImmutable, Blittable]
		public bool PlanarReflectionEnable { get; set; }

		[ContainerField(554), LayoutImmutable, Blittable]
		public bool TransparencyShadowmapsEnable { get; set; }

		[ContainerField(555), LayoutImmutable, Blittable]
		public bool DynamicCullDrawOccludedBoxesEnable { get; set; }

		[ContainerField(556), LayoutImmutable, Blittable]
		public bool PlanarReflectionBlur { get; set; }

		[ContainerField(557), LayoutImmutable, Blittable]
		public bool DrawDebugPlanarReflectionCullFrustum { get; set; }

		[ContainerField(558), LayoutImmutable, Blittable]
		public bool FreezePlanarReflectionCullFrustum { get; set; }

		[ContainerField(559), LayoutImmutable, Blittable]
		public bool PlanarReflectionDebugCullMode { get; set; }

		[ContainerField(560), LayoutImmutable, Blittable]
		public bool ShadowmapFixedMovementEnable { get; set; }

		[ContainerField(561), LayoutImmutable, Blittable]
		public bool DecalVolumeEnable { get; set; }

		[ContainerField(562), LayoutImmutable, Blittable]
		public bool DrawDebugPlanarReflection { get; set; }

		[ContainerField(563), LayoutImmutable, Blittable]
		public bool FxaaEnable { get; set; }

		[ContainerField(564), LayoutImmutable, Blittable]
		public bool DynamicCullSpuJobEnable { get; set; }

		[ContainerField(565), LayoutImmutable, Blittable]
		public bool DynamicCullZBufferTestEnable { get; set; }

		[ContainerField(566), LayoutImmutable, Blittable]
		public bool ViewFxEnable { get; set; }

	}
}
