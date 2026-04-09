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
	[ContainerType(16, 576)]
	public partial class WorldRenderSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _DynamicEnvmapDefaultPosition = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _SubSurfaceColor = new();

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _ViewportScale;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _ShadowMinScreenArea;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _ShadowViewportScale;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private uint _FxaaQuality;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _CullScreenAreaScale;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _PlanarReflectionCullFOV;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private uint _GenericEntityMaxVisibleEntityCount;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _ShadowmapSizeZScale;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private uint _ShadowmapResolution;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private uint _ShadowmapQuality;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _ShadowmapPoissonFilterScale;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private uint _ShadowmapSliceCount;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _ShadowmapSliceSchemeWeight;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _ShadowmapFirstSliceScale;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _ShadowmapViewDistance;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private uint _PlanarReflectionWidth;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _ShadowmapExtrusionLength;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _ShadowmapMinScreenArea;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _TempPlanarReflectionY;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _SubSurfaceRolloffKeyLight;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private int _FxaaForceVendor;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private uint _PlanarReflectionHeight;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _LightIntensityScale;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _LightLodSpecularFadeAreaEnd;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _ShadowmapMinFov;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _LightLodSpecularFadeAreaStart;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _LightLodRadiusFactor;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _LightForceIntensity;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _LightLodFadeArea;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _LightLodMinArea;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private int _DrawDebugDynamicEnvmapMipLevel;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private uint _MaxDecalVolumeCount;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _MotionBlurScale;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _MotionBlurMax;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _MotionBlurNoiseScale;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private uint _MotionBlurQuality;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private uint _MaxSpotLightShadowCount;

		[ObservableProperty]
		[property: ContainerField(196), JsonProperty(Order = 196)]
		private MipmapFilterMode _DynamicEnvmapFilterMode = new();

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private uint _MotionBlurMaxSampleCount;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private uint _MotionBlurFrameAverageCount;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _MotionBlurMaxFrameTime;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _ForceMotionBlurDepthCutoff;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _ForceMotionBlurCutoffGradientScale;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private uint _MultisampleCount;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private float _MultisampleThreshold;

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private uint _MaxPointLightCount;

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private uint _ReflectionEnvmapSize;

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private float _SpotLightNearPlane;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private float _SpotLightShadowmapPoissonFilterScale;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private int _OnlyShadowmapSlice;

		[ObservableProperty]
		[property: ContainerField(248), JsonProperty(Order = 248)]
		private WorldViewMode _ViewMode = new();

		[ObservableProperty]
		[property: ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		private uint _SpotLightShadowmapResolution;

		[ObservableProperty]
		[property: ContainerField(256), JsonProperty(Order = 256)]
		private QualityLevel _SpotLightShadomapLevel = new();

		[ObservableProperty]
		[property: ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		private uint _SpotLightShadowmapQuality;

		[ObservableProperty]
		[property: ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		private int _OnlyLightTileY;

		[ObservableProperty]
		[property: ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		private int _OnlyLightTileX;

		[ObservableProperty]
		[property: ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		private float _XenonHdrColorScale;

		[ObservableProperty]
		[property: ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		private float _XenonHdrColorScaleFactor;

		[ObservableProperty]
		[property: ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		private uint _Ps3LightTileJobMaxFbTileCount;

		[ObservableProperty]
		[property: ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		private int _OnlyLightTileIndex;

		[ObservableProperty]
		[property: ContainerField(288), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		private uint _Ps3LightTileJobCount;

		[ObservableProperty]
		[property: ContainerField(292), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
		private uint _Ps3LightTileJobPriority;

		[ObservableProperty]
		[property: ContainerField(296), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		private uint _XenonLightTileMaxLineLightCount;

		[ObservableProperty]
		[property: ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		private uint _XenonLightTileMaxSpotLightCount;

		[ObservableProperty]
		[property: ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		private uint _XenonLightTileConstantBufferSize;

		[ObservableProperty]
		[property: ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		private uint _XenonLightTileMaxPointLightCount;

		[ObservableProperty]
		[property: ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		private uint _MaxDestructionVolumeCount;

		[ObservableProperty]
		[property: ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		private float _DynamicEnvmapFilterWidth;

		[ObservableProperty]
		[property: ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		private float _LightTileMinArea;

		[ObservableProperty]
		[property: ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		private uint _DynamicEnvmapResolution;

		[ObservableProperty]
		[property: ContainerField(328), JsonProperty(Order = 328)]
		private ShaderGBufferLayout _GBufferLayout = new();

		[ObservableProperty]
		[property: ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		private int _DrawDebugSkyEnvmapMipLevel;

		[ObservableProperty]
		[property: ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		private float _DecalVolumeScale;

		[ObservableProperty]
		[property: ContainerField(340), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
		private uint _LightOverdrawMaxLayerCount;

		[ObservableProperty]
		[property: ContainerField(344), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
		private float _LightRadiusScale;

		[ObservableProperty]
		[property: ContainerField(348), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
		private float _LightAttenuationThreshold;

		[ObservableProperty]
		[property: ContainerField(352), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		private uint _Ps3LightTileMethod;

		[ObservableProperty]
		[property: ContainerField(356), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
		private float _Ps3LightTileJobYieldGranularity;

		[ObservableProperty]
		[property: ContainerField(360), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
		private uint _OutdoorLightTileBatchCount;

		[ObservableProperty]
		[property: ContainerField(364), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
		private uint _XenonDrawDebugLightTileGridMode;

		[ObservableProperty]
		[property: ContainerField(368), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
		private float _LightStencilMinArea;

		[ObservableProperty]
		[property: ContainerField(372), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
		private uint _MaxSpotLightCount;

		[ObservableProperty]
		[property: ContainerField(376), JsonProperty(Order = 376)]
		private MipmapFilterMode _SkyEnvmapFilterMode = new();

		[ObservableProperty]
		[property: ContainerField(380), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
		private float _SkyEnvmapFilterWidth;

		[ObservableProperty]
		[property: ContainerField(384), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
		private uint _GBufferTestCount;

		[ObservableProperty]
		[property: ContainerField(388), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
		private uint _SkyEnvmapResolution;

		[ObservableProperty]
		[property: ContainerField(392), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
		private uint _SkyEnvmapSidesPerFrameCount;

		[ObservableProperty]
		[property: ContainerField(396), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
		private float _SubSurfaceRolloffLocalLight;

		[ObservableProperty]
		[property: ContainerField(400), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
		private int _OnlyTileIndex;

		[ObservableProperty]
		[property: ContainerField(404), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
		private bool _OccluderMeshZPrepassEnable;

		[ObservableProperty]
		[property: ContainerField(405), LayoutImmutable, Blittable, JsonProperty(Order = 405)]
		private bool _OccluderMeshZPrepassDebugEnable;

		[ObservableProperty]
		[property: ContainerField(406), LayoutImmutable, Blittable, JsonProperty(Order = 406)]
		private bool _WireframeEnable;

		[ObservableProperty]
		[property: ContainerField(407), LayoutImmutable, Blittable, JsonProperty(Order = 407)]
		private bool _HalfResEnable;

		[ObservableProperty]
		[property: ContainerField(408), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
		private bool _HalfResLensFlaresEnable;

		[ObservableProperty]
		[property: ContainerField(409), LayoutImmutable, Blittable, JsonProperty(Order = 409)]
		private bool _ZPassEnable;

		[ObservableProperty]
		[property: ContainerField(410), LayoutImmutable, Blittable, JsonProperty(Order = 410)]
		private bool _ForegroundEnable;

		[ObservableProperty]
		[property: ContainerField(411), LayoutImmutable, Blittable, JsonProperty(Order = 411)]
		private bool _TiledHalfResCompositeEnable;

		[ObservableProperty]
		[property: ContainerField(412), LayoutImmutable, Blittable, JsonProperty(Order = 412)]
		private bool _ForegroundZPassEnable;

		[ObservableProperty]
		[property: ContainerField(413), LayoutImmutable, Blittable, JsonProperty(Order = 413)]
		private bool _DrawDebugVelocityBuffer;

		[ObservableProperty]
		[property: ContainerField(414), LayoutImmutable, Blittable, JsonProperty(Order = 414)]
		private bool _ForegroundDepthClearEnable;

		[ObservableProperty]
		[property: ContainerField(415), LayoutImmutable, Blittable, JsonProperty(Order = 415)]
		private bool _ForegroundAsMainEnable;

		[ObservableProperty]
		[property: ContainerField(416), LayoutImmutable, Blittable, JsonProperty(Order = 416)]
		private bool _CustomEnvmapEnable;

		[ObservableProperty]
		[property: ContainerField(417), LayoutImmutable, Blittable, JsonProperty(Order = 417)]
		private bool _SkyEnvmapEnable;

		[ObservableProperty]
		[property: ContainerField(418), LayoutImmutable, Blittable, JsonProperty(Order = 418)]
		private bool _DrawDebugVisibleEntityTypes;

		[ObservableProperty]
		[property: ContainerField(419), LayoutImmutable, Blittable, JsonProperty(Order = 419)]
		private bool _DrawDebugHalfResEnvironment;

		[ObservableProperty]
		[property: ContainerField(420), LayoutImmutable, Blittable, JsonProperty(Order = 420)]
		private bool _DrawSolidBoundingBoxes;

		[ObservableProperty]
		[property: ContainerField(421), LayoutImmutable, Blittable, JsonProperty(Order = 421)]
		private bool _BilateralHalfResCompositeEnable;

		[ObservableProperty]
		[property: ContainerField(422), LayoutImmutable, Blittable, JsonProperty(Order = 422)]
		private bool _ForegroundTransparentEnable;

		[ObservableProperty]
		[property: ContainerField(423), LayoutImmutable, Blittable, JsonProperty(Order = 423)]
		private bool _TiledHalfResStencilOccludersEnable;

		[ObservableProperty]
		[property: ContainerField(424), LayoutImmutable, Blittable, JsonProperty(Order = 424)]
		private bool _SkyEnvmapUpdateEnable;

		[ObservableProperty]
		[property: ContainerField(425), LayoutImmutable, Blittable, JsonProperty(Order = 425)]
		private bool _SkyEnvmapForceUpdateEnable;

		[ObservableProperty]
		[property: ContainerField(426), LayoutImmutable, Blittable, JsonProperty(Order = 426)]
		private bool _SkyEnvmapUse8BitTexture;

		[ObservableProperty]
		[property: ContainerField(427), LayoutImmutable, Blittable, JsonProperty(Order = 427)]
		private bool _DynamicEnvmapEnable;

		[ObservableProperty]
		[property: ContainerField(428), LayoutImmutable, Blittable, JsonProperty(Order = 428)]
		private bool _ScreenEffectEnable;

		[ObservableProperty]
		[property: ContainerField(429), LayoutImmutable, Blittable, JsonProperty(Order = 429)]
		private bool _DrawDebugZBufferEnable;

		[ObservableProperty]
		[property: ContainerField(430), LayoutImmutable, Blittable, JsonProperty(Order = 430)]
		private bool _MotionBlurStencilPassEnable;

		[ObservableProperty]
		[property: ContainerField(431), LayoutImmutable, Blittable, JsonProperty(Order = 431)]
		private bool _FinalPostEnable;

		[ObservableProperty]
		[property: ContainerField(432), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
		private bool _DrawDebugQuarterShadowmaps;

		[ObservableProperty]
		[property: ContainerField(433), LayoutImmutable, Blittable, JsonProperty(Order = 433)]
		private bool _DrawDebugSkyEnvmap;

		[ObservableProperty]
		[property: ContainerField(434), LayoutImmutable, Blittable, JsonProperty(Order = 434)]
		private bool _DxShadowmap16BitEnable;

		[ObservableProperty]
		[property: ContainerField(435), LayoutImmutable, Blittable, JsonProperty(Order = 435)]
		private bool _DrawDebugTransShadowmap;

		[ObservableProperty]
		[property: ContainerField(436), LayoutImmutable, Blittable, JsonProperty(Order = 436)]
		private bool _DrawDebugSpotLightShadowmaps;

		[ObservableProperty]
		[property: ContainerField(437), LayoutImmutable, Blittable, JsonProperty(Order = 437)]
		private bool _DrawShadowFrustums;

		[ObservableProperty]
		[property: ContainerField(438), LayoutImmutable, Blittable, JsonProperty(Order = 438)]
		private bool _DrawDebugShadowmaps;

		[ObservableProperty]
		[property: ContainerField(439), LayoutImmutable, Blittable, JsonProperty(Order = 439)]
		private bool _SkyEnable;

		[ObservableProperty]
		[property: ContainerField(440), LayoutImmutable, Blittable, JsonProperty(Order = 440)]
		private bool _DrawBoundingSpheres;

		[ObservableProperty]
		[property: ContainerField(441), LayoutImmutable, Blittable, JsonProperty(Order = 441)]
		private bool _DrawFrustums;

		[ObservableProperty]
		[property: ContainerField(442), LayoutImmutable, Blittable, JsonProperty(Order = 442)]
		private bool _StaticEnvmapEnable;

		[ObservableProperty]
		[property: ContainerField(443), LayoutImmutable, Blittable, JsonProperty(Order = 443)]
		private bool _SkyFogEnable;

		[ObservableProperty]
		[property: ContainerField(444), LayoutImmutable, Blittable, JsonProperty(Order = 444)]
		private bool _DrawLineBoundingBoxes;

		[ObservableProperty]
		[property: ContainerField(445), LayoutImmutable, Blittable, JsonProperty(Order = 445)]
		private bool _DrawDebugDestructionVolumes;

		[ObservableProperty]
		[property: ContainerField(446), LayoutImmutable, Blittable, JsonProperty(Order = 446)]
		private bool _LensFlaresEnable;

		[ObservableProperty]
		[property: ContainerField(447), LayoutImmutable, Blittable, JsonProperty(Order = 447)]
		private bool _DrawDebugLensFlareOccluders;

		[ObservableProperty]
		[property: ContainerField(448), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
		private bool _DrawDebugLensFlares;

		[ObservableProperty]
		[property: ContainerField(449), LayoutImmutable, Blittable, JsonProperty(Order = 449)]
		private bool _LensFlareOcclusionEnable;

		[ObservableProperty]
		[property: ContainerField(450), LayoutImmutable, Blittable, JsonProperty(Order = 450)]
		private bool _DrawDebugWorldOcclusions;

		[ObservableProperty]
		[property: ContainerField(451), LayoutImmutable, Blittable, JsonProperty(Order = 451)]
		private bool _CloudShadowEnable;

		[ObservableProperty]
		[property: ContainerField(452), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
		private bool _OverrideDynamicAO;

		[ObservableProperty]
		[property: ContainerField(453), LayoutImmutable, Blittable, JsonProperty(Order = 453)]
		private bool _DrawDebugDynamicAO;

		[ObservableProperty]
		[property: ContainerField(454), LayoutImmutable, Blittable, JsonProperty(Order = 454)]
		private bool _EmissiveEnable;

		[ObservableProperty]
		[property: ContainerField(455), LayoutImmutable, Blittable, JsonProperty(Order = 455)]
		private bool _UnlitEnable;

		[ObservableProperty]
		[property: ContainerField(456), LayoutImmutable, Blittable, JsonProperty(Order = 456)]
		private bool _SkyEnvmapMipmapGenEnable;

		[ObservableProperty]
		[property: ContainerField(457), LayoutImmutable, Blittable, JsonProperty(Order = 457)]
		private bool _DrawLightSources;

		[ObservableProperty]
		[property: ContainerField(458), LayoutImmutable, Blittable, JsonProperty(Order = 458)]
		private bool _GBufferClearEnable;

		[ObservableProperty]
		[property: ContainerField(459), LayoutImmutable, Blittable, JsonProperty(Order = 459)]
		private bool _DxGBufferLight16BitEnable;

		[ObservableProperty]
		[property: ContainerField(460), LayoutImmutable, Blittable, JsonProperty(Order = 460)]
		private bool _DxGBufferNormal16BitEnable;

		[ObservableProperty]
		[property: ContainerField(461), LayoutImmutable, Blittable, JsonProperty(Order = 461)]
		private bool _GBufferAlphaTestSimpleEnable;

		[ObservableProperty]
		[property: ContainerField(462), LayoutImmutable, Blittable, JsonProperty(Order = 462)]
		private bool _SpecularLightingEnable;

		[ObservableProperty]
		[property: ContainerField(463), LayoutImmutable, Blittable, JsonProperty(Order = 463)]
		private bool _SkinLightingEnable;

		[ObservableProperty]
		[property: ContainerField(464), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
		private bool _TranslucencyLightingEnable;

		[ObservableProperty]
		[property: ContainerField(465), LayoutImmutable, Blittable, JsonProperty(Order = 465)]
		private bool _DynamicEnvmapLightingEnable;

		[ObservableProperty]
		[property: ContainerField(466), LayoutImmutable, Blittable, JsonProperty(Order = 466)]
		private bool _OutdoorLightEnable;

		[ObservableProperty]
		[property: ContainerField(467), LayoutImmutable, Blittable, JsonProperty(Order = 467)]
		private bool _PointLightsEnable;

		[ObservableProperty]
		[property: ContainerField(468), LayoutImmutable, Blittable, JsonProperty(Order = 468)]
		private bool _LineLightsEnable;

		[ObservableProperty]
		[property: ContainerField(469), LayoutImmutable, Blittable, JsonProperty(Order = 469)]
		private bool _ConeLightsEnable;

		[ObservableProperty]
		[property: ContainerField(470), LayoutImmutable, Blittable, JsonProperty(Order = 470)]
		private bool _SpotLightsEnable;

		[ObservableProperty]
		[property: ContainerField(471), LayoutImmutable, Blittable, JsonProperty(Order = 471)]
		private bool _LightProbesEnable;

		[ObservableProperty]
		[property: ContainerField(472), LayoutImmutable, Blittable, JsonProperty(Order = 472)]
		private bool _LightStencilMethodEnable;

		[ObservableProperty]
		[property: ContainerField(473), LayoutImmutable, Blittable, JsonProperty(Order = 473)]
		private bool _LightVolumeMethodEnable;

		[ObservableProperty]
		[property: ContainerField(474), LayoutImmutable, Blittable, JsonProperty(Order = 474)]
		private bool _LightVolumeDepthTestEnable;

		[ObservableProperty]
		[property: ContainerField(475), LayoutImmutable, Blittable, JsonProperty(Order = 475)]
		private bool _OutputGammaCorrectionEnable;

		[ObservableProperty]
		[property: ContainerField(476), LayoutImmutable, Blittable, JsonProperty(Order = 476)]
		private bool _DrawDebugMultisampleClassify;

		[ObservableProperty]
		[property: ContainerField(477), LayoutImmutable, Blittable, JsonProperty(Order = 477)]
		private bool _OutdoorKeyLightEnable;

		[ObservableProperty]
		[property: ContainerField(478), LayoutImmutable, Blittable, JsonProperty(Order = 478)]
		private bool _OutdoorSkyLightEnable;

		[ObservableProperty]
		[property: ContainerField(479), LayoutImmutable, Blittable, JsonProperty(Order = 479)]
		private bool _OutdoorLightSpecularEnable;

		[ObservableProperty]
		[property: ContainerField(480), LayoutImmutable, Blittable, JsonProperty(Order = 480)]
		private bool _OutdoorLightTilingEnable;

		[ObservableProperty]
		[property: ContainerField(481), LayoutImmutable, Blittable, JsonProperty(Order = 481)]
		private bool _OutdoorLightTileRenderEnable;

		[ObservableProperty]
		[property: ContainerField(482), LayoutImmutable, Blittable, JsonProperty(Order = 482)]
		private bool _OutdoorLightTileBlendEnable;

		[ObservableProperty]
		[property: ContainerField(483), LayoutImmutable, Blittable, JsonProperty(Order = 483)]
		private bool _OutdoorLightTileSimpleShaderEnable;

		[ObservableProperty]
		[property: ContainerField(484), LayoutImmutable, Blittable, JsonProperty(Order = 484)]
		private bool _Ps3TiledHalfTargetEnable;

		[ObservableProperty]
		[property: ContainerField(485), LayoutImmutable, Blittable, JsonProperty(Order = 485)]
		private bool _XenonOutdoorLightTilingEnable;

		[ObservableProperty]
		[property: ContainerField(486), LayoutImmutable, Blittable, JsonProperty(Order = 486)]
		private bool _XenonPointLightsTilingEnable;

		[ObservableProperty]
		[property: ContainerField(487), LayoutImmutable, Blittable, JsonProperty(Order = 487)]
		private bool _XenonSpotLightsTilingEnable;

		[ObservableProperty]
		[property: ContainerField(488), LayoutImmutable, Blittable, JsonProperty(Order = 488)]
		private bool _XenonLineLightsTilingEnable;

		[ObservableProperty]
		[property: ContainerField(489), LayoutImmutable, Blittable, JsonProperty(Order = 489)]
		private bool _XenonAsyncLightJobsEnable;

		[ObservableProperty]
		[property: ContainerField(490), LayoutImmutable, Blittable, JsonProperty(Order = 490)]
		private bool _XenonLightTileDownsampleSpecularCheckEnable;

		[ObservableProperty]
		[property: ContainerField(491), LayoutImmutable, Blittable, JsonProperty(Order = 491)]
		private bool _XenonLightTileCpuPointLightCullingEnable;

		[ObservableProperty]
		[property: ContainerField(492), LayoutImmutable, Blittable, JsonProperty(Order = 492)]
		private bool _Ps3TiledSSAOTargetsEnable;

		[ObservableProperty]
		[property: ContainerField(493), LayoutImmutable, Blittable, JsonProperty(Order = 493)]
		private bool _Ps3SCullEnable;

		[ObservableProperty]
		[property: ContainerField(494), LayoutImmutable, Blittable, JsonProperty(Order = 494)]
		private bool _Ps3ColorCompressionEnable;

		[ObservableProperty]
		[property: ContainerField(495), LayoutImmutable, Blittable, JsonProperty(Order = 495)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(496), LayoutImmutable, Blittable, JsonProperty(Order = 496)]
		private bool _Ps3TilingEnable;

		[ObservableProperty]
		[property: ContainerField(497), LayoutImmutable, Blittable, JsonProperty(Order = 497)]
		private bool _Ps3DepthBoundsLightCullingEnable;

		[ObservableProperty]
		[property: ContainerField(498), LayoutImmutable, Blittable, JsonProperty(Order = 498)]
		private bool _Ps3ZCullEnable;

		[ObservableProperty]
		[property: ContainerField(499), LayoutImmutable, Blittable, JsonProperty(Order = 499)]
		private bool _ConsoleRenderTargetPoolSharingEnable;

		[ObservableProperty]
		[property: ContainerField(500), LayoutImmutable, Blittable, JsonProperty(Order = 500)]
		private bool _XenonFloatDepthBufferEnable;

		[ObservableProperty]
		[property: ContainerField(501), LayoutImmutable, Blittable, JsonProperty(Order = 501)]
		private bool _Ps3LightTileJobYieldEnable;

		[ObservableProperty]
		[property: ContainerField(502), LayoutImmutable, Blittable, JsonProperty(Order = 502)]
		private bool _Ps3HdrClearEnable;

		[ObservableProperty]
		[property: ContainerField(503), LayoutImmutable, Blittable, JsonProperty(Order = 503)]
		private bool _XenonFastHdrEnable;

		[ObservableProperty]
		[property: ContainerField(504), LayoutImmutable, Blittable, JsonProperty(Order = 504)]
		private bool _ShadowmapViewDistanceScaleEnable;

		[ObservableProperty]
		[property: ContainerField(505), LayoutImmutable, Blittable, JsonProperty(Order = 505)]
		private bool _Ps3RenderTargetPoolGBufferOffsetEnable;

		[ObservableProperty]
		[property: ContainerField(506), LayoutImmutable, Blittable, JsonProperty(Order = 506)]
		private bool _HdrEnable;

		[ObservableProperty]
		[property: ContainerField(507), LayoutImmutable, Blittable, JsonProperty(Order = 507)]
		private bool _SpotLightShadowmapEnable;

		[ObservableProperty]
		[property: ContainerField(508), LayoutImmutable, Blittable, JsonProperty(Order = 508)]
		private bool _SimpleShadowmapsEnable;

		[ObservableProperty]
		[property: ContainerField(509), LayoutImmutable, Blittable, JsonProperty(Order = 509)]
		private bool _DrawTransparent;

		[ObservableProperty]
		[property: ContainerField(510), LayoutImmutable, Blittable, JsonProperty(Order = 510)]
		private bool _DrawTransparentDecal;

		[ObservableProperty]
		[property: ContainerField(511), LayoutImmutable, Blittable, JsonProperty(Order = 511)]
		private bool _ShadowmapFixedDepthEnable;

		[ObservableProperty]
		[property: ContainerField(512), LayoutImmutable, Blittable, JsonProperty(Order = 512)]
		private bool _DrawDebugDynamicEnvmap;

		[ObservableProperty]
		[property: ContainerField(513), LayoutImmutable, Blittable, JsonProperty(Order = 513)]
		private bool _MotionBlurGeometryPassEnable;

		[ObservableProperty]
		[property: ContainerField(514), LayoutImmutable, Blittable, JsonProperty(Order = 514)]
		private bool _DxLinearDepth32BitFormatEnable;

		[ObservableProperty]
		[property: ContainerField(515), LayoutImmutable, Blittable, JsonProperty(Order = 515)]
		private bool _DynamicEnvmapMipmapGenEnable;

		[ObservableProperty]
		[property: ContainerField(516), LayoutImmutable, Blittable, JsonProperty(Order = 516)]
		private bool _MotionBlurEnable;

		[ObservableProperty]
		[property: ContainerField(517), LayoutImmutable, Blittable, JsonProperty(Order = 517)]
		private bool _ColoredShadowmapSlicesEnable;

		[ObservableProperty]
		[property: ContainerField(518), LayoutImmutable, Blittable, JsonProperty(Order = 518)]
		private bool _DxDeferredCsPathEnable;

		[ObservableProperty]
		[property: ContainerField(519), LayoutImmutable, Blittable, JsonProperty(Order = 519)]
		private bool _DrawDebugGBuffer;

		[ObservableProperty]
		[property: ContainerField(520), LayoutImmutable, Blittable, JsonProperty(Order = 520)]
		private bool _DrawDebugLightSources;

		[ObservableProperty]
		[property: ContainerField(521), LayoutImmutable, Blittable, JsonProperty(Order = 521)]
		private bool _DrawDebugLightShadowSources;

		[ObservableProperty]
		[property: ContainerField(522), LayoutImmutable, Blittable, JsonProperty(Order = 522)]
		private bool _DrawDebugLightStats;

		[ObservableProperty]
		[property: ContainerField(523), LayoutImmutable, Blittable, JsonProperty(Order = 523)]
		private bool _DrawDebugLightTiles;

		[ObservableProperty]
		[property: ContainerField(524), LayoutImmutable, Blittable, JsonProperty(Order = 524)]
		private bool _DrawDebugLightTileVolumes;

		[ObservableProperty]
		[property: ContainerField(525), LayoutImmutable, Blittable, JsonProperty(Order = 525)]
		private bool _DrawDebugLightTileFbGrid;

		[ObservableProperty]
		[property: ContainerField(526), LayoutImmutable, Blittable, JsonProperty(Order = 526)]
		private bool _DrawDebugLightTileGrid;

		[ObservableProperty]
		[property: ContainerField(527), LayoutImmutable, Blittable, JsonProperty(Order = 527)]
		private bool _DrawDebugLightTileSources;

		[ObservableProperty]
		[property: ContainerField(528), LayoutImmutable, Blittable, JsonProperty(Order = 528)]
		private bool _ApplyShadowmapsEnable;

		[ObservableProperty]
		[property: ContainerField(529), LayoutImmutable, Blittable, JsonProperty(Order = 529)]
		private bool _GenerateShadowmapsEnable;

		[ObservableProperty]
		[property: ContainerField(530), LayoutImmutable, Blittable, JsonProperty(Order = 530)]
		private bool _DxSpotLightShadowmap16BitEnable;

		[ObservableProperty]
		[property: ContainerField(531), LayoutImmutable, Blittable, JsonProperty(Order = 531)]
		private bool _Ps3Shadowmap16BitEnable;

		[ObservableProperty]
		[property: ContainerField(532), LayoutImmutable, Blittable, JsonProperty(Order = 532)]
		private bool _Ps3SpotLightShadowmap16BitEnable;

		[ObservableProperty]
		[property: ContainerField(533), LayoutImmutable, Blittable, JsonProperty(Order = 533)]
		private bool _GenericEntityRendererEnable;

		[ObservableProperty]
		[property: ContainerField(534), LayoutImmutable, Blittable, JsonProperty(Order = 534)]
		private bool _SetupJobEnable;

		[ObservableProperty]
		[property: ContainerField(535), LayoutImmutable, Blittable, JsonProperty(Order = 535)]
		private bool _ShadowmapAccumBilinearEnable;

		[ObservableProperty]
		[property: ContainerField(536), LayoutImmutable, Blittable, JsonProperty(Order = 536)]
		private bool _LightWidthEnable;

		[ObservableProperty]
		[property: ContainerField(537), LayoutImmutable, Blittable, JsonProperty(Order = 537)]
		private bool _LightIntensityNormalizationEnable;

		[ObservableProperty]
		[property: ContainerField(538), LayoutImmutable, Blittable, JsonProperty(Order = 538)]
		private bool _LightCullEnable;

		[ObservableProperty]
		[property: ContainerField(539), LayoutImmutable, Blittable, JsonProperty(Order = 539)]
		private bool _LightDepthCullEnable;

		[ObservableProperty]
		[property: ContainerField(540), LayoutImmutable, Blittable, JsonProperty(Order = 540)]
		private bool _LightNormalCullEnable;

		[ObservableProperty]
		[property: ContainerField(541), LayoutImmutable, Blittable, JsonProperty(Order = 541)]
		private bool _LightConeCullEnable;

		[ObservableProperty]
		[property: ContainerField(542), LayoutImmutable, Blittable, JsonProperty(Order = 542)]
		private bool _LightTileOverlayEnable;

		[ObservableProperty]
		[property: ContainerField(543), LayoutImmutable, Blittable, JsonProperty(Order = 543)]
		private bool _Ps3ShadowmapTilingEnable;

		[ObservableProperty]
		[property: ContainerField(544), LayoutImmutable, Blittable, JsonProperty(Order = 544)]
		private bool _LightAttenuationThresholdEnable;

		[ObservableProperty]
		[property: ContainerField(545), LayoutImmutable, Blittable, JsonProperty(Order = 545)]
		private bool _SkyVisibilityEnvmapScalingEnable;

		[ObservableProperty]
		[property: ContainerField(546), LayoutImmutable, Blittable, JsonProperty(Order = 546)]
		private bool _ZBufferShadowTestEnable;

		[ObservableProperty]
		[property: ContainerField(547), LayoutImmutable, Blittable, JsonProperty(Order = 547)]
		private bool _ShadowmapsEnable;

		[ObservableProperty]
		[property: ContainerField(548), LayoutImmutable, Blittable, JsonProperty(Order = 548)]
		private bool _ShadowmapAccumEnable;

		[ObservableProperty]
		[property: ContainerField(549), LayoutImmutable, Blittable, JsonProperty(Order = 549)]
		private bool _ShadowmapCullVolumeEnable;

		[ObservableProperty]
		[property: ContainerField(550), LayoutImmutable, Blittable, JsonProperty(Order = 550)]
		private bool _OpaqueSortBySolutionEnable;

		[ObservableProperty]
		[property: ContainerField(551), LayoutImmutable, Blittable, JsonProperty(Order = 551)]
		private bool _MainOpaqueZPassEnable;

		[ObservableProperty]
		[property: ContainerField(552), LayoutImmutable, Blittable, JsonProperty(Order = 552)]
		private bool _DrawDebugDecalVolumes;

		[ObservableProperty]
		[property: ContainerField(553), LayoutImmutable, Blittable, JsonProperty(Order = 553)]
		private bool _PlanarReflectionEnable;

		[ObservableProperty]
		[property: ContainerField(554), LayoutImmutable, Blittable, JsonProperty(Order = 554)]
		private bool _TransparencyShadowmapsEnable;

		[ObservableProperty]
		[property: ContainerField(555), LayoutImmutable, Blittable, JsonProperty(Order = 555)]
		private bool _DynamicCullDrawOccludedBoxesEnable;

		[ObservableProperty]
		[property: ContainerField(556), LayoutImmutable, Blittable, JsonProperty(Order = 556)]
		private bool _PlanarReflectionBlur;

		[ObservableProperty]
		[property: ContainerField(557), LayoutImmutable, Blittable, JsonProperty(Order = 557)]
		private bool _DrawDebugPlanarReflectionCullFrustum;

		[ObservableProperty]
		[property: ContainerField(558), LayoutImmutable, Blittable, JsonProperty(Order = 558)]
		private bool _FreezePlanarReflectionCullFrustum;

		[ObservableProperty]
		[property: ContainerField(559), LayoutImmutable, Blittable, JsonProperty(Order = 559)]
		private bool _PlanarReflectionDebugCullMode;

		[ObservableProperty]
		[property: ContainerField(560), LayoutImmutable, Blittable, JsonProperty(Order = 560)]
		private bool _ShadowmapFixedMovementEnable;

		[ObservableProperty]
		[property: ContainerField(561), LayoutImmutable, Blittable, JsonProperty(Order = 561)]
		private bool _DecalVolumeEnable;

		[ObservableProperty]
		[property: ContainerField(562), LayoutImmutable, Blittable, JsonProperty(Order = 562)]
		private bool _DrawDebugPlanarReflection;

		[ObservableProperty]
		[property: ContainerField(563), LayoutImmutable, Blittable, JsonProperty(Order = 563)]
		private bool _FxaaEnable;

		[ObservableProperty]
		[property: ContainerField(564), LayoutImmutable, Blittable, JsonProperty(Order = 564)]
		private bool _DynamicCullSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(565), LayoutImmutable, Blittable, JsonProperty(Order = 565)]
		private bool _DynamicCullZBufferTestEnable;

		[ObservableProperty]
		[property: ContainerField(566), LayoutImmutable, Blittable, JsonProperty(Order = 566)]
		private bool _ViewFxEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			DynamicEnvmapDefaultPosition.Serialize(p_Writer, p_EbxWriter);
			SubSurfaceColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ViewportScale);
			p_Writer.Write(ShadowMinScreenArea);
			p_Writer.Write(ShadowViewportScale);
			p_Writer.Write(FxaaQuality);
			p_Writer.Write(CullScreenAreaScale);
			p_Writer.Write(PlanarReflectionCullFOV);
			p_Writer.Write(GenericEntityMaxVisibleEntityCount);
			p_Writer.Write(ShadowmapSizeZScale);
			p_Writer.Write(ShadowmapResolution);
			p_Writer.Write(ShadowmapQuality);
			p_Writer.Write(ShadowmapPoissonFilterScale);
			p_Writer.Write(ShadowmapSliceCount);
			p_Writer.Write(ShadowmapSliceSchemeWeight);
			p_Writer.Write(ShadowmapFirstSliceScale);
			p_Writer.Write(ShadowmapViewDistance);
			p_Writer.Write(PlanarReflectionWidth);
			p_Writer.Write(ShadowmapExtrusionLength);
			p_Writer.Write(ShadowmapMinScreenArea);
			p_Writer.Write(TempPlanarReflectionY);
			p_Writer.Write(SubSurfaceRolloffKeyLight);
			p_Writer.Write(FxaaForceVendor);
			p_Writer.Write(PlanarReflectionHeight);
			p_Writer.Write(LightIntensityScale);
			p_Writer.Write(LightLodSpecularFadeAreaEnd);
			p_Writer.Write(ShadowmapMinFov);
			p_Writer.Write(LightLodSpecularFadeAreaStart);
			p_Writer.Write(LightLodRadiusFactor);
			p_Writer.Write(LightForceIntensity);
			p_Writer.Write(LightLodFadeArea);
			p_Writer.Write(LightLodMinArea);
			p_Writer.Write(DrawDebugDynamicEnvmapMipLevel);
			p_Writer.Write(MaxDecalVolumeCount);
			p_Writer.Write(MotionBlurScale);
			p_Writer.Write(MotionBlurMax);
			p_Writer.Write(MotionBlurNoiseScale);
			p_Writer.Write(MotionBlurQuality);
			p_Writer.Write(MaxSpotLightShadowCount);
			p_Writer.Write((int) DynamicEnvmapFilterMode);
			p_Writer.Write(MotionBlurMaxSampleCount);
			p_Writer.Write(MotionBlurFrameAverageCount);
			p_Writer.Write(MotionBlurMaxFrameTime);
			p_Writer.Write(ForceMotionBlurDepthCutoff);
			p_Writer.Write(ForceMotionBlurCutoffGradientScale);
			p_Writer.Write(MultisampleCount);
			p_Writer.Write(MultisampleThreshold);
			p_Writer.Write(MaxPointLightCount);
			p_Writer.Write(ReflectionEnvmapSize);
			p_Writer.Write(SpotLightNearPlane);
			p_Writer.Write(SpotLightShadowmapPoissonFilterScale);
			p_Writer.Write(OnlyShadowmapSlice);
			p_Writer.Write((int) ViewMode);
			p_Writer.Write(SpotLightShadowmapResolution);
			p_Writer.Write((int) SpotLightShadomapLevel);
			p_Writer.Write(SpotLightShadowmapQuality);
			p_Writer.Write(OnlyLightTileY);
			p_Writer.Write(OnlyLightTileX);
			p_Writer.Write(XenonHdrColorScale);
			p_Writer.Write(XenonHdrColorScaleFactor);
			p_Writer.Write(Ps3LightTileJobMaxFbTileCount);
			p_Writer.Write(OnlyLightTileIndex);
			p_Writer.Write(Ps3LightTileJobCount);
			p_Writer.Write(Ps3LightTileJobPriority);
			p_Writer.Write(XenonLightTileMaxLineLightCount);
			p_Writer.Write(XenonLightTileMaxSpotLightCount);
			p_Writer.Write(XenonLightTileConstantBufferSize);
			p_Writer.Write(XenonLightTileMaxPointLightCount);
			p_Writer.Write(MaxDestructionVolumeCount);
			p_Writer.Write(DynamicEnvmapFilterWidth);
			p_Writer.Write(LightTileMinArea);
			p_Writer.Write(DynamicEnvmapResolution);
			p_Writer.Write((int) GBufferLayout);
			p_Writer.Write(DrawDebugSkyEnvmapMipLevel);
			p_Writer.Write(DecalVolumeScale);
			p_Writer.Write(LightOverdrawMaxLayerCount);
			p_Writer.Write(LightRadiusScale);
			p_Writer.Write(LightAttenuationThreshold);
			p_Writer.Write(Ps3LightTileMethod);
			p_Writer.Write(Ps3LightTileJobYieldGranularity);
			p_Writer.Write(OutdoorLightTileBatchCount);
			p_Writer.Write(XenonDrawDebugLightTileGridMode);
			p_Writer.Write(LightStencilMinArea);
			p_Writer.Write(MaxSpotLightCount);
			p_Writer.Write((int) SkyEnvmapFilterMode);
			p_Writer.Write(SkyEnvmapFilterWidth);
			p_Writer.Write(GBufferTestCount);
			p_Writer.Write(SkyEnvmapResolution);
			p_Writer.Write(SkyEnvmapSidesPerFrameCount);
			p_Writer.Write(SubSurfaceRolloffLocalLight);
			p_Writer.Write(OnlyTileIndex);
			p_Writer.Write(OccluderMeshZPrepassEnable);
			p_Writer.Write(OccluderMeshZPrepassDebugEnable);
			p_Writer.Write(WireframeEnable);
			p_Writer.Write(HalfResEnable);
			p_Writer.Write(HalfResLensFlaresEnable);
			p_Writer.Write(ZPassEnable);
			p_Writer.Write(ForegroundEnable);
			p_Writer.Write(TiledHalfResCompositeEnable);
			p_Writer.Write(ForegroundZPassEnable);
			p_Writer.Write(DrawDebugVelocityBuffer);
			p_Writer.Write(ForegroundDepthClearEnable);
			p_Writer.Write(ForegroundAsMainEnable);
			p_Writer.Write(CustomEnvmapEnable);
			p_Writer.Write(SkyEnvmapEnable);
			p_Writer.Write(DrawDebugVisibleEntityTypes);
			p_Writer.Write(DrawDebugHalfResEnvironment);
			p_Writer.Write(DrawSolidBoundingBoxes);
			p_Writer.Write(BilateralHalfResCompositeEnable);
			p_Writer.Write(ForegroundTransparentEnable);
			p_Writer.Write(TiledHalfResStencilOccludersEnable);
			p_Writer.Write(SkyEnvmapUpdateEnable);
			p_Writer.Write(SkyEnvmapForceUpdateEnable);
			p_Writer.Write(SkyEnvmapUse8BitTexture);
			p_Writer.Write(DynamicEnvmapEnable);
			p_Writer.Write(ScreenEffectEnable);
			p_Writer.Write(DrawDebugZBufferEnable);
			p_Writer.Write(MotionBlurStencilPassEnable);
			p_Writer.Write(FinalPostEnable);
			p_Writer.Write(DrawDebugQuarterShadowmaps);
			p_Writer.Write(DrawDebugSkyEnvmap);
			p_Writer.Write(DxShadowmap16BitEnable);
			p_Writer.Write(DrawDebugTransShadowmap);
			p_Writer.Write(DrawDebugSpotLightShadowmaps);
			p_Writer.Write(DrawShadowFrustums);
			p_Writer.Write(DrawDebugShadowmaps);
			p_Writer.Write(SkyEnable);
			p_Writer.Write(DrawBoundingSpheres);
			p_Writer.Write(DrawFrustums);
			p_Writer.Write(StaticEnvmapEnable);
			p_Writer.Write(SkyFogEnable);
			p_Writer.Write(DrawLineBoundingBoxes);
			p_Writer.Write(DrawDebugDestructionVolumes);
			p_Writer.Write(LensFlaresEnable);
			p_Writer.Write(DrawDebugLensFlareOccluders);
			p_Writer.Write(DrawDebugLensFlares);
			p_Writer.Write(LensFlareOcclusionEnable);
			p_Writer.Write(DrawDebugWorldOcclusions);
			p_Writer.Write(CloudShadowEnable);
			p_Writer.Write(OverrideDynamicAO);
			p_Writer.Write(DrawDebugDynamicAO);
			p_Writer.Write(EmissiveEnable);
			p_Writer.Write(UnlitEnable);
			p_Writer.Write(SkyEnvmapMipmapGenEnable);
			p_Writer.Write(DrawLightSources);
			p_Writer.Write(GBufferClearEnable);
			p_Writer.Write(DxGBufferLight16BitEnable);
			p_Writer.Write(DxGBufferNormal16BitEnable);
			p_Writer.Write(GBufferAlphaTestSimpleEnable);
			p_Writer.Write(SpecularLightingEnable);
			p_Writer.Write(SkinLightingEnable);
			p_Writer.Write(TranslucencyLightingEnable);
			p_Writer.Write(DynamicEnvmapLightingEnable);
			p_Writer.Write(OutdoorLightEnable);
			p_Writer.Write(PointLightsEnable);
			p_Writer.Write(LineLightsEnable);
			p_Writer.Write(ConeLightsEnable);
			p_Writer.Write(SpotLightsEnable);
			p_Writer.Write(LightProbesEnable);
			p_Writer.Write(LightStencilMethodEnable);
			p_Writer.Write(LightVolumeMethodEnable);
			p_Writer.Write(LightVolumeDepthTestEnable);
			p_Writer.Write(OutputGammaCorrectionEnable);
			p_Writer.Write(DrawDebugMultisampleClassify);
			p_Writer.Write(OutdoorKeyLightEnable);
			p_Writer.Write(OutdoorSkyLightEnable);
			p_Writer.Write(OutdoorLightSpecularEnable);
			p_Writer.Write(OutdoorLightTilingEnable);
			p_Writer.Write(OutdoorLightTileRenderEnable);
			p_Writer.Write(OutdoorLightTileBlendEnable);
			p_Writer.Write(OutdoorLightTileSimpleShaderEnable);
			p_Writer.Write(Ps3TiledHalfTargetEnable);
			p_Writer.Write(XenonOutdoorLightTilingEnable);
			p_Writer.Write(XenonPointLightsTilingEnable);
			p_Writer.Write(XenonSpotLightsTilingEnable);
			p_Writer.Write(XenonLineLightsTilingEnable);
			p_Writer.Write(XenonAsyncLightJobsEnable);
			p_Writer.Write(XenonLightTileDownsampleSpecularCheckEnable);
			p_Writer.Write(XenonLightTileCpuPointLightCullingEnable);
			p_Writer.Write(Ps3TiledSSAOTargetsEnable);
			p_Writer.Write(Ps3SCullEnable);
			p_Writer.Write(Ps3ColorCompressionEnable);
			p_Writer.Write(Enable);
			p_Writer.Write(Ps3TilingEnable);
			p_Writer.Write(Ps3DepthBoundsLightCullingEnable);
			p_Writer.Write(Ps3ZCullEnable);
			p_Writer.Write(ConsoleRenderTargetPoolSharingEnable);
			p_Writer.Write(XenonFloatDepthBufferEnable);
			p_Writer.Write(Ps3LightTileJobYieldEnable);
			p_Writer.Write(Ps3HdrClearEnable);
			p_Writer.Write(XenonFastHdrEnable);
			p_Writer.Write(ShadowmapViewDistanceScaleEnable);
			p_Writer.Write(Ps3RenderTargetPoolGBufferOffsetEnable);
			p_Writer.Write(HdrEnable);
			p_Writer.Write(SpotLightShadowmapEnable);
			p_Writer.Write(SimpleShadowmapsEnable);
			p_Writer.Write(DrawTransparent);
			p_Writer.Write(DrawTransparentDecal);
			p_Writer.Write(ShadowmapFixedDepthEnable);
			p_Writer.Write(DrawDebugDynamicEnvmap);
			p_Writer.Write(MotionBlurGeometryPassEnable);
			p_Writer.Write(DxLinearDepth32BitFormatEnable);
			p_Writer.Write(DynamicEnvmapMipmapGenEnable);
			p_Writer.Write(MotionBlurEnable);
			p_Writer.Write(ColoredShadowmapSlicesEnable);
			p_Writer.Write(DxDeferredCsPathEnable);
			p_Writer.Write(DrawDebugGBuffer);
			p_Writer.Write(DrawDebugLightSources);
			p_Writer.Write(DrawDebugLightShadowSources);
			p_Writer.Write(DrawDebugLightStats);
			p_Writer.Write(DrawDebugLightTiles);
			p_Writer.Write(DrawDebugLightTileVolumes);
			p_Writer.Write(DrawDebugLightTileFbGrid);
			p_Writer.Write(DrawDebugLightTileGrid);
			p_Writer.Write(DrawDebugLightTileSources);
			p_Writer.Write(ApplyShadowmapsEnable);
			p_Writer.Write(GenerateShadowmapsEnable);
			p_Writer.Write(DxSpotLightShadowmap16BitEnable);
			p_Writer.Write(Ps3Shadowmap16BitEnable);
			p_Writer.Write(Ps3SpotLightShadowmap16BitEnable);
			p_Writer.Write(GenericEntityRendererEnable);
			p_Writer.Write(SetupJobEnable);
			p_Writer.Write(ShadowmapAccumBilinearEnable);
			p_Writer.Write(LightWidthEnable);
			p_Writer.Write(LightIntensityNormalizationEnable);
			p_Writer.Write(LightCullEnable);
			p_Writer.Write(LightDepthCullEnable);
			p_Writer.Write(LightNormalCullEnable);
			p_Writer.Write(LightConeCullEnable);
			p_Writer.Write(LightTileOverlayEnable);
			p_Writer.Write(Ps3ShadowmapTilingEnable);
			p_Writer.Write(LightAttenuationThresholdEnable);
			p_Writer.Write(SkyVisibilityEnvmapScalingEnable);
			p_Writer.Write(ZBufferShadowTestEnable);
			p_Writer.Write(ShadowmapsEnable);
			p_Writer.Write(ShadowmapAccumEnable);
			p_Writer.Write(ShadowmapCullVolumeEnable);
			p_Writer.Write(OpaqueSortBySolutionEnable);
			p_Writer.Write(MainOpaqueZPassEnable);
			p_Writer.Write(DrawDebugDecalVolumes);
			p_Writer.Write(PlanarReflectionEnable);
			p_Writer.Write(TransparencyShadowmapsEnable);
			p_Writer.Write(DynamicCullDrawOccludedBoxesEnable);
			p_Writer.Write(PlanarReflectionBlur);
			p_Writer.Write(DrawDebugPlanarReflectionCullFrustum);
			p_Writer.Write(FreezePlanarReflectionCullFrustum);
			p_Writer.Write(PlanarReflectionDebugCullMode);
			p_Writer.Write(ShadowmapFixedMovementEnable);
			p_Writer.Write(DecalVolumeEnable);
			p_Writer.Write(DrawDebugPlanarReflection);
			p_Writer.Write(FxaaEnable);
			p_Writer.Write(DynamicCullSpuJobEnable);
			p_Writer.Write(DynamicCullZBufferTestEnable);
			p_Writer.Write(ViewFxEnable);
			p_Writer.WriteNullBytes(9);
		}
	}
}
