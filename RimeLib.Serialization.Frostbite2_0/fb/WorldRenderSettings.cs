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
	[ContainerType(16, 576)]
	public class WorldRenderSettings : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 DynamicEnvmapDefaultPosition { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 SubSurfaceColor { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float ViewportScale { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float ShadowMinScreenArea { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float ShadowViewportScale { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public uint FxaaQuality { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float CullScreenAreaScale { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float PlanarReflectionCullFOV { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public uint GenericEntityMaxVisibleEntityCount { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float ShadowmapSizeZScale { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public uint ShadowmapResolution { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public uint ShadowmapQuality { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float ShadowmapPoissonFilterScale { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public uint ShadowmapSliceCount { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float ShadowmapSliceSchemeWeight { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float ShadowmapFirstSliceScale { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float ShadowmapViewDistance { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public uint PlanarReflectionWidth { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float ShadowmapExtrusionLength { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float ShadowmapMinScreenArea { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float TempPlanarReflectionY { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float SubSurfaceRolloffKeyLight { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public int FxaaForceVendor { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public uint PlanarReflectionHeight { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float LightIntensityScale { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float LightLodSpecularFadeAreaEnd { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float ShadowmapMinFov { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float LightLodSpecularFadeAreaStart { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float LightLodRadiusFactor { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float LightForceIntensity { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float LightLodFadeArea { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float LightLodMinArea { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public int DrawDebugDynamicEnvmapMipLevel { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public uint MaxDecalVolumeCount { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float MotionBlurScale { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float MotionBlurMax { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float MotionBlurNoiseScale { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public uint MotionBlurQuality { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public uint MaxSpotLightShadowCount { get; set; }

		[ContainerField(196), JsonProperty(Order = 196)]
		public MipmapFilterMode DynamicEnvmapFilterMode { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public uint MotionBlurMaxSampleCount { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public uint MotionBlurFrameAverageCount { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float MotionBlurMaxFrameTime { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public float ForceMotionBlurDepthCutoff { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float ForceMotionBlurCutoffGradientScale { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public uint MultisampleCount { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public float MultisampleThreshold { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public uint MaxPointLightCount { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public uint ReflectionEnvmapSize { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public float SpotLightNearPlane { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public float SpotLightShadowmapPoissonFilterScale { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public int OnlyShadowmapSlice { get; set; }

		[ContainerField(248), JsonProperty(Order = 248)]
		public WorldViewMode ViewMode { get; set; } = new();

		[ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		public uint SpotLightShadowmapResolution { get; set; }

		[ContainerField(256), JsonProperty(Order = 256)]
		public QualityLevel SpotLightShadomapLevel { get; set; } = new();

		[ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		public uint SpotLightShadowmapQuality { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		public int OnlyLightTileY { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		public int OnlyLightTileX { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		public float XenonHdrColorScale { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		public float XenonHdrColorScaleFactor { get; set; }

		[ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		public uint Ps3LightTileJobMaxFbTileCount { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		public int OnlyLightTileIndex { get; set; }

		[ContainerField(288), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		public uint Ps3LightTileJobCount { get; set; }

		[ContainerField(292), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
		public uint Ps3LightTileJobPriority { get; set; }

		[ContainerField(296), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		public uint XenonLightTileMaxLineLightCount { get; set; }

		[ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		public uint XenonLightTileMaxSpotLightCount { get; set; }

		[ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		public uint XenonLightTileConstantBufferSize { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		public uint XenonLightTileMaxPointLightCount { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		public uint MaxDestructionVolumeCount { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		public float DynamicEnvmapFilterWidth { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		public float LightTileMinArea { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		public uint DynamicEnvmapResolution { get; set; }

		[ContainerField(328), JsonProperty(Order = 328)]
		public ShaderGBufferLayout GBufferLayout { get; set; } = new();

		[ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		public int DrawDebugSkyEnvmapMipLevel { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		public float DecalVolumeScale { get; set; }

		[ContainerField(340), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
		public uint LightOverdrawMaxLayerCount { get; set; }

		[ContainerField(344), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
		public float LightRadiusScale { get; set; }

		[ContainerField(348), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
		public float LightAttenuationThreshold { get; set; }

		[ContainerField(352), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		public uint Ps3LightTileMethod { get; set; }

		[ContainerField(356), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
		public float Ps3LightTileJobYieldGranularity { get; set; }

		[ContainerField(360), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
		public uint OutdoorLightTileBatchCount { get; set; }

		[ContainerField(364), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
		public uint XenonDrawDebugLightTileGridMode { get; set; }

		[ContainerField(368), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
		public float LightStencilMinArea { get; set; }

		[ContainerField(372), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
		public uint MaxSpotLightCount { get; set; }

		[ContainerField(376), JsonProperty(Order = 376)]
		public MipmapFilterMode SkyEnvmapFilterMode { get; set; } = new();

		[ContainerField(380), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
		public float SkyEnvmapFilterWidth { get; set; }

		[ContainerField(384), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
		public uint GBufferTestCount { get; set; }

		[ContainerField(388), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
		public uint SkyEnvmapResolution { get; set; }

		[ContainerField(392), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
		public uint SkyEnvmapSidesPerFrameCount { get; set; }

		[ContainerField(396), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
		public float SubSurfaceRolloffLocalLight { get; set; }

		[ContainerField(400), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
		public int OnlyTileIndex { get; set; }

		[ContainerField(404), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
		public bool OccluderMeshZPrepassEnable { get; set; }

		[ContainerField(405), LayoutImmutable, Blittable, JsonProperty(Order = 405)]
		public bool OccluderMeshZPrepassDebugEnable { get; set; }

		[ContainerField(406), LayoutImmutable, Blittable, JsonProperty(Order = 406)]
		public bool WireframeEnable { get; set; }

		[ContainerField(407), LayoutImmutable, Blittable, JsonProperty(Order = 407)]
		public bool HalfResEnable { get; set; }

		[ContainerField(408), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
		public bool HalfResLensFlaresEnable { get; set; }

		[ContainerField(409), LayoutImmutable, Blittable, JsonProperty(Order = 409)]
		public bool ZPassEnable { get; set; }

		[ContainerField(410), LayoutImmutable, Blittable, JsonProperty(Order = 410)]
		public bool ForegroundEnable { get; set; }

		[ContainerField(411), LayoutImmutable, Blittable, JsonProperty(Order = 411)]
		public bool TiledHalfResCompositeEnable { get; set; }

		[ContainerField(412), LayoutImmutable, Blittable, JsonProperty(Order = 412)]
		public bool ForegroundZPassEnable { get; set; }

		[ContainerField(413), LayoutImmutable, Blittable, JsonProperty(Order = 413)]
		public bool DrawDebugVelocityBuffer { get; set; }

		[ContainerField(414), LayoutImmutable, Blittable, JsonProperty(Order = 414)]
		public bool ForegroundDepthClearEnable { get; set; }

		[ContainerField(415), LayoutImmutable, Blittable, JsonProperty(Order = 415)]
		public bool ForegroundAsMainEnable { get; set; }

		[ContainerField(416), LayoutImmutable, Blittable, JsonProperty(Order = 416)]
		public bool CustomEnvmapEnable { get; set; }

		[ContainerField(417), LayoutImmutable, Blittable, JsonProperty(Order = 417)]
		public bool SkyEnvmapEnable { get; set; }

		[ContainerField(418), LayoutImmutable, Blittable, JsonProperty(Order = 418)]
		public bool DrawDebugVisibleEntityTypes { get; set; }

		[ContainerField(419), LayoutImmutable, Blittable, JsonProperty(Order = 419)]
		public bool DrawDebugHalfResEnvironment { get; set; }

		[ContainerField(420), LayoutImmutable, Blittable, JsonProperty(Order = 420)]
		public bool DrawSolidBoundingBoxes { get; set; }

		[ContainerField(421), LayoutImmutable, Blittable, JsonProperty(Order = 421)]
		public bool BilateralHalfResCompositeEnable { get; set; }

		[ContainerField(422), LayoutImmutable, Blittable, JsonProperty(Order = 422)]
		public bool ForegroundTransparentEnable { get; set; }

		[ContainerField(423), LayoutImmutable, Blittable, JsonProperty(Order = 423)]
		public bool TiledHalfResStencilOccludersEnable { get; set; }

		[ContainerField(424), LayoutImmutable, Blittable, JsonProperty(Order = 424)]
		public bool SkyEnvmapUpdateEnable { get; set; }

		[ContainerField(425), LayoutImmutable, Blittable, JsonProperty(Order = 425)]
		public bool SkyEnvmapForceUpdateEnable { get; set; }

		[ContainerField(426), LayoutImmutable, Blittable, JsonProperty(Order = 426)]
		public bool SkyEnvmapUse8BitTexture { get; set; }

		[ContainerField(427), LayoutImmutable, Blittable, JsonProperty(Order = 427)]
		public bool DynamicEnvmapEnable { get; set; }

		[ContainerField(428), LayoutImmutable, Blittable, JsonProperty(Order = 428)]
		public bool ScreenEffectEnable { get; set; }

		[ContainerField(429), LayoutImmutable, Blittable, JsonProperty(Order = 429)]
		public bool DrawDebugZBufferEnable { get; set; }

		[ContainerField(430), LayoutImmutable, Blittable, JsonProperty(Order = 430)]
		public bool MotionBlurStencilPassEnable { get; set; }

		[ContainerField(431), LayoutImmutable, Blittable, JsonProperty(Order = 431)]
		public bool FinalPostEnable { get; set; }

		[ContainerField(432), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
		public bool DrawDebugQuarterShadowmaps { get; set; }

		[ContainerField(433), LayoutImmutable, Blittable, JsonProperty(Order = 433)]
		public bool DrawDebugSkyEnvmap { get; set; }

		[ContainerField(434), LayoutImmutable, Blittable, JsonProperty(Order = 434)]
		public bool DxShadowmap16BitEnable { get; set; }

		[ContainerField(435), LayoutImmutable, Blittable, JsonProperty(Order = 435)]
		public bool DrawDebugTransShadowmap { get; set; }

		[ContainerField(436), LayoutImmutable, Blittable, JsonProperty(Order = 436)]
		public bool DrawDebugSpotLightShadowmaps { get; set; }

		[ContainerField(437), LayoutImmutable, Blittable, JsonProperty(Order = 437)]
		public bool DrawShadowFrustums { get; set; }

		[ContainerField(438), LayoutImmutable, Blittable, JsonProperty(Order = 438)]
		public bool DrawDebugShadowmaps { get; set; }

		[ContainerField(439), LayoutImmutable, Blittable, JsonProperty(Order = 439)]
		public bool SkyEnable { get; set; }

		[ContainerField(440), LayoutImmutable, Blittable, JsonProperty(Order = 440)]
		public bool DrawBoundingSpheres { get; set; }

		[ContainerField(441), LayoutImmutable, Blittable, JsonProperty(Order = 441)]
		public bool DrawFrustums { get; set; }

		[ContainerField(442), LayoutImmutable, Blittable, JsonProperty(Order = 442)]
		public bool StaticEnvmapEnable { get; set; }

		[ContainerField(443), LayoutImmutable, Blittable, JsonProperty(Order = 443)]
		public bool SkyFogEnable { get; set; }

		[ContainerField(444), LayoutImmutable, Blittable, JsonProperty(Order = 444)]
		public bool DrawLineBoundingBoxes { get; set; }

		[ContainerField(445), LayoutImmutable, Blittable, JsonProperty(Order = 445)]
		public bool DrawDebugDestructionVolumes { get; set; }

		[ContainerField(446), LayoutImmutable, Blittable, JsonProperty(Order = 446)]
		public bool LensFlaresEnable { get; set; }

		[ContainerField(447), LayoutImmutable, Blittable, JsonProperty(Order = 447)]
		public bool DrawDebugLensFlareOccluders { get; set; }

		[ContainerField(448), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
		public bool DrawDebugLensFlares { get; set; }

		[ContainerField(449), LayoutImmutable, Blittable, JsonProperty(Order = 449)]
		public bool LensFlareOcclusionEnable { get; set; }

		[ContainerField(450), LayoutImmutable, Blittable, JsonProperty(Order = 450)]
		public bool DrawDebugWorldOcclusions { get; set; }

		[ContainerField(451), LayoutImmutable, Blittable, JsonProperty(Order = 451)]
		public bool CloudShadowEnable { get; set; }

		[ContainerField(452), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
		public bool OverrideDynamicAO { get; set; }

		[ContainerField(453), LayoutImmutable, Blittable, JsonProperty(Order = 453)]
		public bool DrawDebugDynamicAO { get; set; }

		[ContainerField(454), LayoutImmutable, Blittable, JsonProperty(Order = 454)]
		public bool EmissiveEnable { get; set; }

		[ContainerField(455), LayoutImmutable, Blittable, JsonProperty(Order = 455)]
		public bool UnlitEnable { get; set; }

		[ContainerField(456), LayoutImmutable, Blittable, JsonProperty(Order = 456)]
		public bool SkyEnvmapMipmapGenEnable { get; set; }

		[ContainerField(457), LayoutImmutable, Blittable, JsonProperty(Order = 457)]
		public bool DrawLightSources { get; set; }

		[ContainerField(458), LayoutImmutable, Blittable, JsonProperty(Order = 458)]
		public bool GBufferClearEnable { get; set; }

		[ContainerField(459), LayoutImmutable, Blittable, JsonProperty(Order = 459)]
		public bool DxGBufferLight16BitEnable { get; set; }

		[ContainerField(460), LayoutImmutable, Blittable, JsonProperty(Order = 460)]
		public bool DxGBufferNormal16BitEnable { get; set; }

		[ContainerField(461), LayoutImmutable, Blittable, JsonProperty(Order = 461)]
		public bool GBufferAlphaTestSimpleEnable { get; set; }

		[ContainerField(462), LayoutImmutable, Blittable, JsonProperty(Order = 462)]
		public bool SpecularLightingEnable { get; set; }

		[ContainerField(463), LayoutImmutable, Blittable, JsonProperty(Order = 463)]
		public bool SkinLightingEnable { get; set; }

		[ContainerField(464), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
		public bool TranslucencyLightingEnable { get; set; }

		[ContainerField(465), LayoutImmutable, Blittable, JsonProperty(Order = 465)]
		public bool DynamicEnvmapLightingEnable { get; set; }

		[ContainerField(466), LayoutImmutable, Blittable, JsonProperty(Order = 466)]
		public bool OutdoorLightEnable { get; set; }

		[ContainerField(467), LayoutImmutable, Blittable, JsonProperty(Order = 467)]
		public bool PointLightsEnable { get; set; }

		[ContainerField(468), LayoutImmutable, Blittable, JsonProperty(Order = 468)]
		public bool LineLightsEnable { get; set; }

		[ContainerField(469), LayoutImmutable, Blittable, JsonProperty(Order = 469)]
		public bool ConeLightsEnable { get; set; }

		[ContainerField(470), LayoutImmutable, Blittable, JsonProperty(Order = 470)]
		public bool SpotLightsEnable { get; set; }

		[ContainerField(471), LayoutImmutable, Blittable, JsonProperty(Order = 471)]
		public bool LightProbesEnable { get; set; }

		[ContainerField(472), LayoutImmutable, Blittable, JsonProperty(Order = 472)]
		public bool LightStencilMethodEnable { get; set; }

		[ContainerField(473), LayoutImmutable, Blittable, JsonProperty(Order = 473)]
		public bool LightVolumeMethodEnable { get; set; }

		[ContainerField(474), LayoutImmutable, Blittable, JsonProperty(Order = 474)]
		public bool LightVolumeDepthTestEnable { get; set; }

		[ContainerField(475), LayoutImmutable, Blittable, JsonProperty(Order = 475)]
		public bool OutputGammaCorrectionEnable { get; set; }

		[ContainerField(476), LayoutImmutable, Blittable, JsonProperty(Order = 476)]
		public bool DrawDebugMultisampleClassify { get; set; }

		[ContainerField(477), LayoutImmutable, Blittable, JsonProperty(Order = 477)]
		public bool OutdoorKeyLightEnable { get; set; }

		[ContainerField(478), LayoutImmutable, Blittable, JsonProperty(Order = 478)]
		public bool OutdoorSkyLightEnable { get; set; }

		[ContainerField(479), LayoutImmutable, Blittable, JsonProperty(Order = 479)]
		public bool OutdoorLightSpecularEnable { get; set; }

		[ContainerField(480), LayoutImmutable, Blittable, JsonProperty(Order = 480)]
		public bool OutdoorLightTilingEnable { get; set; }

		[ContainerField(481), LayoutImmutable, Blittable, JsonProperty(Order = 481)]
		public bool OutdoorLightTileRenderEnable { get; set; }

		[ContainerField(482), LayoutImmutable, Blittable, JsonProperty(Order = 482)]
		public bool OutdoorLightTileBlendEnable { get; set; }

		[ContainerField(483), LayoutImmutable, Blittable, JsonProperty(Order = 483)]
		public bool OutdoorLightTileSimpleShaderEnable { get; set; }

		[ContainerField(484), LayoutImmutable, Blittable, JsonProperty(Order = 484)]
		public bool Ps3TiledHalfTargetEnable { get; set; }

		[ContainerField(485), LayoutImmutable, Blittable, JsonProperty(Order = 485)]
		public bool XenonOutdoorLightTilingEnable { get; set; }

		[ContainerField(486), LayoutImmutable, Blittable, JsonProperty(Order = 486)]
		public bool XenonPointLightsTilingEnable { get; set; }

		[ContainerField(487), LayoutImmutable, Blittable, JsonProperty(Order = 487)]
		public bool XenonSpotLightsTilingEnable { get; set; }

		[ContainerField(488), LayoutImmutable, Blittable, JsonProperty(Order = 488)]
		public bool XenonLineLightsTilingEnable { get; set; }

		[ContainerField(489), LayoutImmutable, Blittable, JsonProperty(Order = 489)]
		public bool XenonAsyncLightJobsEnable { get; set; }

		[ContainerField(490), LayoutImmutable, Blittable, JsonProperty(Order = 490)]
		public bool XenonLightTileDownsampleSpecularCheckEnable { get; set; }

		[ContainerField(491), LayoutImmutable, Blittable, JsonProperty(Order = 491)]
		public bool XenonLightTileCpuPointLightCullingEnable { get; set; }

		[ContainerField(492), LayoutImmutable, Blittable, JsonProperty(Order = 492)]
		public bool Ps3TiledSSAOTargetsEnable { get; set; }

		[ContainerField(493), LayoutImmutable, Blittable, JsonProperty(Order = 493)]
		public bool Ps3SCullEnable { get; set; }

		[ContainerField(494), LayoutImmutable, Blittable, JsonProperty(Order = 494)]
		public bool Ps3ColorCompressionEnable { get; set; }

		[ContainerField(495), LayoutImmutable, Blittable, JsonProperty(Order = 495)]
		public bool Enable { get; set; }

		[ContainerField(496), LayoutImmutable, Blittable, JsonProperty(Order = 496)]
		public bool Ps3TilingEnable { get; set; }

		[ContainerField(497), LayoutImmutable, Blittable, JsonProperty(Order = 497)]
		public bool Ps3DepthBoundsLightCullingEnable { get; set; }

		[ContainerField(498), LayoutImmutable, Blittable, JsonProperty(Order = 498)]
		public bool Ps3ZCullEnable { get; set; }

		[ContainerField(499), LayoutImmutable, Blittable, JsonProperty(Order = 499)]
		public bool ConsoleRenderTargetPoolSharingEnable { get; set; }

		[ContainerField(500), LayoutImmutable, Blittable, JsonProperty(Order = 500)]
		public bool XenonFloatDepthBufferEnable { get; set; }

		[ContainerField(501), LayoutImmutable, Blittable, JsonProperty(Order = 501)]
		public bool Ps3LightTileJobYieldEnable { get; set; }

		[ContainerField(502), LayoutImmutable, Blittable, JsonProperty(Order = 502)]
		public bool Ps3HdrClearEnable { get; set; }

		[ContainerField(503), LayoutImmutable, Blittable, JsonProperty(Order = 503)]
		public bool XenonFastHdrEnable { get; set; }

		[ContainerField(504), LayoutImmutable, Blittable, JsonProperty(Order = 504)]
		public bool ShadowmapViewDistanceScaleEnable { get; set; }

		[ContainerField(505), LayoutImmutable, Blittable, JsonProperty(Order = 505)]
		public bool Ps3RenderTargetPoolGBufferOffsetEnable { get; set; }

		[ContainerField(506), LayoutImmutable, Blittable, JsonProperty(Order = 506)]
		public bool HdrEnable { get; set; }

		[ContainerField(507), LayoutImmutable, Blittable, JsonProperty(Order = 507)]
		public bool SpotLightShadowmapEnable { get; set; }

		[ContainerField(508), LayoutImmutable, Blittable, JsonProperty(Order = 508)]
		public bool SimpleShadowmapsEnable { get; set; }

		[ContainerField(509), LayoutImmutable, Blittable, JsonProperty(Order = 509)]
		public bool DrawTransparent { get; set; }

		[ContainerField(510), LayoutImmutable, Blittable, JsonProperty(Order = 510)]
		public bool DrawTransparentDecal { get; set; }

		[ContainerField(511), LayoutImmutable, Blittable, JsonProperty(Order = 511)]
		public bool ShadowmapFixedDepthEnable { get; set; }

		[ContainerField(512), LayoutImmutable, Blittable, JsonProperty(Order = 512)]
		public bool DrawDebugDynamicEnvmap { get; set; }

		[ContainerField(513), LayoutImmutable, Blittable, JsonProperty(Order = 513)]
		public bool MotionBlurGeometryPassEnable { get; set; }

		[ContainerField(514), LayoutImmutable, Blittable, JsonProperty(Order = 514)]
		public bool DxLinearDepth32BitFormatEnable { get; set; }

		[ContainerField(515), LayoutImmutable, Blittable, JsonProperty(Order = 515)]
		public bool DynamicEnvmapMipmapGenEnable { get; set; }

		[ContainerField(516), LayoutImmutable, Blittable, JsonProperty(Order = 516)]
		public bool MotionBlurEnable { get; set; }

		[ContainerField(517), LayoutImmutable, Blittable, JsonProperty(Order = 517)]
		public bool ColoredShadowmapSlicesEnable { get; set; }

		[ContainerField(518), LayoutImmutable, Blittable, JsonProperty(Order = 518)]
		public bool DxDeferredCsPathEnable { get; set; }

		[ContainerField(519), LayoutImmutable, Blittable, JsonProperty(Order = 519)]
		public bool DrawDebugGBuffer { get; set; }

		[ContainerField(520), LayoutImmutable, Blittable, JsonProperty(Order = 520)]
		public bool DrawDebugLightSources { get; set; }

		[ContainerField(521), LayoutImmutable, Blittable, JsonProperty(Order = 521)]
		public bool DrawDebugLightShadowSources { get; set; }

		[ContainerField(522), LayoutImmutable, Blittable, JsonProperty(Order = 522)]
		public bool DrawDebugLightStats { get; set; }

		[ContainerField(523), LayoutImmutable, Blittable, JsonProperty(Order = 523)]
		public bool DrawDebugLightTiles { get; set; }

		[ContainerField(524), LayoutImmutable, Blittable, JsonProperty(Order = 524)]
		public bool DrawDebugLightTileVolumes { get; set; }

		[ContainerField(525), LayoutImmutable, Blittable, JsonProperty(Order = 525)]
		public bool DrawDebugLightTileFbGrid { get; set; }

		[ContainerField(526), LayoutImmutable, Blittable, JsonProperty(Order = 526)]
		public bool DrawDebugLightTileGrid { get; set; }

		[ContainerField(527), LayoutImmutable, Blittable, JsonProperty(Order = 527)]
		public bool DrawDebugLightTileSources { get; set; }

		[ContainerField(528), LayoutImmutable, Blittable, JsonProperty(Order = 528)]
		public bool ApplyShadowmapsEnable { get; set; }

		[ContainerField(529), LayoutImmutable, Blittable, JsonProperty(Order = 529)]
		public bool GenerateShadowmapsEnable { get; set; }

		[ContainerField(530), LayoutImmutable, Blittable, JsonProperty(Order = 530)]
		public bool DxSpotLightShadowmap16BitEnable { get; set; }

		[ContainerField(531), LayoutImmutable, Blittable, JsonProperty(Order = 531)]
		public bool Ps3Shadowmap16BitEnable { get; set; }

		[ContainerField(532), LayoutImmutable, Blittable, JsonProperty(Order = 532)]
		public bool Ps3SpotLightShadowmap16BitEnable { get; set; }

		[ContainerField(533), LayoutImmutable, Blittable, JsonProperty(Order = 533)]
		public bool GenericEntityRendererEnable { get; set; }

		[ContainerField(534), LayoutImmutable, Blittable, JsonProperty(Order = 534)]
		public bool SetupJobEnable { get; set; }

		[ContainerField(535), LayoutImmutable, Blittable, JsonProperty(Order = 535)]
		public bool ShadowmapAccumBilinearEnable { get; set; }

		[ContainerField(536), LayoutImmutable, Blittable, JsonProperty(Order = 536)]
		public bool LightWidthEnable { get; set; }

		[ContainerField(537), LayoutImmutable, Blittable, JsonProperty(Order = 537)]
		public bool LightIntensityNormalizationEnable { get; set; }

		[ContainerField(538), LayoutImmutable, Blittable, JsonProperty(Order = 538)]
		public bool LightCullEnable { get; set; }

		[ContainerField(539), LayoutImmutable, Blittable, JsonProperty(Order = 539)]
		public bool LightDepthCullEnable { get; set; }

		[ContainerField(540), LayoutImmutable, Blittable, JsonProperty(Order = 540)]
		public bool LightNormalCullEnable { get; set; }

		[ContainerField(541), LayoutImmutable, Blittable, JsonProperty(Order = 541)]
		public bool LightConeCullEnable { get; set; }

		[ContainerField(542), LayoutImmutable, Blittable, JsonProperty(Order = 542)]
		public bool LightTileOverlayEnable { get; set; }

		[ContainerField(543), LayoutImmutable, Blittable, JsonProperty(Order = 543)]
		public bool Ps3ShadowmapTilingEnable { get; set; }

		[ContainerField(544), LayoutImmutable, Blittable, JsonProperty(Order = 544)]
		public bool LightAttenuationThresholdEnable { get; set; }

		[ContainerField(545), LayoutImmutable, Blittable, JsonProperty(Order = 545)]
		public bool SkyVisibilityEnvmapScalingEnable { get; set; }

		[ContainerField(546), LayoutImmutable, Blittable, JsonProperty(Order = 546)]
		public bool ZBufferShadowTestEnable { get; set; }

		[ContainerField(547), LayoutImmutable, Blittable, JsonProperty(Order = 547)]
		public bool ShadowmapsEnable { get; set; }

		[ContainerField(548), LayoutImmutable, Blittable, JsonProperty(Order = 548)]
		public bool ShadowmapAccumEnable { get; set; }

		[ContainerField(549), LayoutImmutable, Blittable, JsonProperty(Order = 549)]
		public bool ShadowmapCullVolumeEnable { get; set; }

		[ContainerField(550), LayoutImmutable, Blittable, JsonProperty(Order = 550)]
		public bool OpaqueSortBySolutionEnable { get; set; }

		[ContainerField(551), LayoutImmutable, Blittable, JsonProperty(Order = 551)]
		public bool MainOpaqueZPassEnable { get; set; }

		[ContainerField(552), LayoutImmutable, Blittable, JsonProperty(Order = 552)]
		public bool DrawDebugDecalVolumes { get; set; }

		[ContainerField(553), LayoutImmutable, Blittable, JsonProperty(Order = 553)]
		public bool PlanarReflectionEnable { get; set; }

		[ContainerField(554), LayoutImmutable, Blittable, JsonProperty(Order = 554)]
		public bool TransparencyShadowmapsEnable { get; set; }

		[ContainerField(555), LayoutImmutable, Blittable, JsonProperty(Order = 555)]
		public bool DynamicCullDrawOccludedBoxesEnable { get; set; }

		[ContainerField(556), LayoutImmutable, Blittable, JsonProperty(Order = 556)]
		public bool PlanarReflectionBlur { get; set; }

		[ContainerField(557), LayoutImmutable, Blittable, JsonProperty(Order = 557)]
		public bool DrawDebugPlanarReflectionCullFrustum { get; set; }

		[ContainerField(558), LayoutImmutable, Blittable, JsonProperty(Order = 558)]
		public bool FreezePlanarReflectionCullFrustum { get; set; }

		[ContainerField(559), LayoutImmutable, Blittable, JsonProperty(Order = 559)]
		public bool PlanarReflectionDebugCullMode { get; set; }

		[ContainerField(560), LayoutImmutable, Blittable, JsonProperty(Order = 560)]
		public bool ShadowmapFixedMovementEnable { get; set; }

		[ContainerField(561), LayoutImmutable, Blittable, JsonProperty(Order = 561)]
		public bool DecalVolumeEnable { get; set; }

		[ContainerField(562), LayoutImmutable, Blittable, JsonProperty(Order = 562)]
		public bool DrawDebugPlanarReflection { get; set; }

		[ContainerField(563), LayoutImmutable, Blittable, JsonProperty(Order = 563)]
		public bool FxaaEnable { get; set; }

		[ContainerField(564), LayoutImmutable, Blittable, JsonProperty(Order = 564)]
		public bool DynamicCullSpuJobEnable { get; set; }

		[ContainerField(565), LayoutImmutable, Blittable, JsonProperty(Order = 565)]
		public bool DynamicCullZBufferTestEnable { get; set; }

		[ContainerField(566), LayoutImmutable, Blittable, JsonProperty(Order = 566)]
		public bool ViewFxEnable { get; set; }

	}
}
