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

namespace fb.WorldRender;

[ContainerType(16, 704)]
public class WorldRenderSettings
	: fb.WorldRender.WorldRenderSettingsBase
{
	[ContainerField(0x150), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public Vec4 OverlayColor { get; set; } = new()
	{
		w = 0.350f,
		z = 0.000f,
		y = 0.400f,
		x = 1.000f,
	};
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public uint GenericEntityMaxVisibleEntityCount { get; set; } = 10000;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public uint DrawDebugGroundHeight { get; set; } = 0;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public float DecalVolumeScale { get; set; } = 1.000f;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public uint GBufferLayout { get; set; } = 0;
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public uint GBufferTestCount { get; set; } = 0;
	
	[ContainerField(0x174), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
	public float GBufferAlphaTestSimpleSmoothness { get; set; } = 0.300f;
	
	[ContainerField(0x178), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
	public float GBufferForceSmoothness { get; set; } = -1.000f;
	
	[ContainerField(0x17c), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
	public float GBufferForceSpecularAlbedo { get; set; } = -1.000f;
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public QualityLevel SpotLightsAsConeLightsLevel { get; set; } = QualityLevel.QualityLevel_Low;
	
	[ContainerField(0x184), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
	public float LightTileMinArea { get; set; } = 0.030f;
	
	[ContainerField(0x188), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
	public float LightStencilMinArea { get; set; } = 0.100f;
	
	[ContainerField(0x18c), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
	public float LightNarrowAngleThreshold { get; set; } = 1.000f;
	
	[ContainerField(0x190), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
	public uint OutdoorLightTileBatchCount { get; set; } = 4;
	
	[ContainerField(0x194), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
	public uint XenonDrawDebugLightTileGridMode { get; set; } = 0;
	
	[ContainerField(0x198), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
	public uint XenonLightTileConstantBufferSize { get; set; } = 2097152;
	
	[ContainerField(0x19c), LayoutImmutable, Blittable, JsonProperty(Order = 412)]
	public uint XenonLightTileMaxPointLightCount { get; set; } = 256;
	
	[ContainerField(0x1a0), LayoutImmutable, Blittable, JsonProperty(Order = 416)]
	public uint XenonLightTileMaxLineLightCount { get; set; } = 256;
	
	[ContainerField(0x1a4), LayoutImmutable, Blittable, JsonProperty(Order = 420)]
	public uint XenonLightTileMaxSpotLightCount { get; set; } = 256;
	
	[ContainerField(0x1a8), LayoutImmutable, Blittable, JsonProperty(Order = 424)]
	public uint Ps3LightTileMethod { get; set; } = 1;
	
	[ContainerField(0x1ac), LayoutImmutable, Blittable, JsonProperty(Order = 428)]
	public uint Ps3LightTileJobCount { get; set; } = 6;
	
	[ContainerField(0x1b0), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
	public uint Ps3LightTileJobPriority { get; set; } = 128;
	
	[ContainerField(0x1b4), LayoutImmutable, Blittable, JsonProperty(Order = 436)]
	public float Ps3LightTileJobYieldGranularity { get; set; } = 1.000f;
	
	[ContainerField(0x1b8), LayoutImmutable, Blittable, JsonProperty(Order = 440)]
	public float Ps3LightTileJobYieldAggressiveGranularity { get; set; } = 0.050f;
	
	[ContainerField(0x1bc), LayoutImmutable, Blittable, JsonProperty(Order = 444)]
	public uint Ps3LightTileJobMaxFbTileCount { get; set; } = 0;
	
	[ContainerField(0x1c0), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
	public int OnlyLightTileIndex { get; set; } = -1;
	
	[ContainerField(0x1c4), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
	public uint SpotLightShadowmapResolution { get; set; } = 512;
	
	[ContainerField(0x1c8), LayoutImmutable, Blittable, JsonProperty(Order = 456)]
	public uint SpotLightShadowmapQuality { get; set; } = 1;
	
	[ContainerField(0x1cc), LayoutImmutable, Blittable, JsonProperty(Order = 460)]
	public float SpotLightShadowmapPoissonFilterScale { get; set; } = 3.000f;
	
	[ContainerField(0x1d0), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
	public QualityLevel SpotLightShadowmapLevel { get; set; } = QualityLevel.QualityLevel_Low;
	
	[ContainerField(0x1d4), LayoutImmutable, Blittable, JsonProperty(Order = 468)]
	public uint MaxPointLightCount { get; set; } = 256;
	
	[ContainerField(0x1d8), LayoutImmutable, Blittable, JsonProperty(Order = 472)]
	public uint MaxSpotLightCount { get; set; } = 256;
	
	[ContainerField(0x1dc), LayoutImmutable, Blittable, JsonProperty(Order = 476)]
	public uint MaxSpotLightShadowCount { get; set; } = 4;
	
	[ContainerField(0x1e0), LayoutImmutable, Blittable, JsonProperty(Order = 480)]
	public uint MaxDestructionVolumeCount { get; set; } = 256;
	
	[ContainerField(0x1e4), LayoutImmutable, Blittable, JsonProperty(Order = 484)]
	public uint MaxDecalVolumeCount { get; set; } = 256;
	
	[ContainerField(0x1e8), LayoutImmutable, Blittable, JsonProperty(Order = 488)]
	public float SpotLightNearPlane { get; set; } = 0.100f;
	
	[ContainerField(0x1ec), LayoutImmutable, Blittable, JsonProperty(Order = 492)]
	public uint LightTileCsAvgLightCountPerTile { get; set; } = 64;
	
	[ContainerField(0x1f0), LayoutImmutable, Blittable, JsonProperty(Order = 496)]
	public float LightLodFadeArea { get; set; } = 0.010f;
	
	[ContainerField(0x1f4), LayoutImmutable, Blittable, JsonProperty(Order = 500)]
	public float LightLodMinArea { get; set; } = 0.005f;
	
	[ContainerField(0x1f8), LayoutImmutable, Blittable, JsonProperty(Order = 504)]
	public float LightLodRadiusFactor { get; set; } = 1.000f;
	
	[ContainerField(0x1fc), LayoutImmutable, Blittable, JsonProperty(Order = 508)]
	public float LightLodSpecularFadeAreaStart { get; set; } = 0.010f;
	
	[ContainerField(0x200), LayoutImmutable, Blittable, JsonProperty(Order = 512)]
	public float LightLodSpecularFadeAreaEnd { get; set; } = 0.005f;
	
	[ContainerField(0x204), LayoutImmutable, Blittable, JsonProperty(Order = 516)]
	public float LightForceIntensity { get; set; } = -1.000f;
	
	[ContainerField(0x208), LayoutImmutable, Blittable, JsonProperty(Order = 520)]
	public float LightIntensityScale { get; set; } = 1.000f;
	
	[ContainerField(0x20c), LayoutImmutable, Blittable, JsonProperty(Order = 524)]
	public float LightRadiusScale { get; set; } = 1.000f;
	
	[ContainerField(0x210), LayoutImmutable, Blittable, JsonProperty(Order = 528)]
	public float LightAttenuationThreshold { get; set; } = 0.010f;
	
	[ContainerField(0x214), LayoutImmutable, Blittable, JsonProperty(Order = 532)]
	public uint ShadowOcclusionCullingWidth { get; set; } = 256;
	
	[ContainerField(0x218), LayoutImmutable, Blittable, JsonProperty(Order = 536)]
	public uint ShadowOcclusionCullingHeight { get; set; } = 128;
	
	[ContainerField(0x21c), LayoutImmutable, Blittable, JsonProperty(Order = 540)]
	public uint ShadowOcclusionTriangleCount { get; set; } = 5000;
	
	[ContainerField(0x220), LayoutImmutable, Blittable, JsonProperty(Order = 544)]
	public float FrustumSilhouetteCullingPadding { get; set; } = 0.000f;
	
	[ContainerField(0x224), LayoutImmutable, Blittable, JsonProperty(Order = 548)]
	public int OnlyTileIndex { get; set; } = -1;
	
	[ContainerField(0x228), LayoutImmutable, Blittable, JsonProperty(Order = 552)]
	public float PlanarReflectionViewScale { get; set; } = 0.400f;
	
	[ContainerField(0x22c), LayoutImmutable, Blittable, JsonProperty(Order = 556)]
	public float PlanarReflectionCullFOV { get; set; } = 0.500f;
	
	[ContainerField(0x230), LayoutImmutable, Blittable, JsonProperty(Order = 560)]
	public float PlanarReflectionFarPlane { get; set; } = 200.000f;
	
	[ContainerField(0x234), LayoutImmutable, Blittable, JsonProperty(Order = 564)]
	public uint DrawDebugPlanarReflectionMode { get; set; } = 0;
	
	[ContainerField(0x238), LayoutImmutable, Blittable, JsonProperty(Order = 568)]
	public float ReflectionLodScale { get; set; } = 0.100f;
	
	[ContainerField(0x23c), LayoutImmutable, Blittable, JsonProperty(Order = 572)]
	public PostProcessAAMode PostProcessAntialiasingMode { get; set; } = PostProcessAAMode.PostProcessAAMode_None;
	
	[ContainerField(0x240), LayoutImmutable, Blittable, JsonProperty(Order = 576)]
	public int FxaaForceVendor { get; set; } = -1;
	
	[ContainerField(0x244), LayoutImmutable, Blittable, JsonProperty(Order = 580)]
	public ScaleResampleMode RenderScaleResampleMode { get; set; } = ScaleResampleMode.ScaleResampleMode_LanczosSeparable;
	
	[ContainerField(0x248), LayoutImmutable, Blittable, JsonProperty(Order = 584)]
	public float LightCubeMapStencilMinArea { get; set; } = 0.900f;
	
	[ContainerField(0x24c), LayoutImmutable, Blittable, JsonProperty(Order = 588)]
	public uint DrawDebugIndirectCubeMapMipLevel { get; set; } = 0;
	
	[ContainerField(0x250), LayoutImmutable, Blittable, JsonProperty(Order = 592)]
	public uint DrawDebugIndirectCubeMapIndex { get; set; } = 0;
	
	[ContainerField(0x254), LayoutImmutable, Blittable, JsonProperty(Order = 596)]
	public bool SimpleRenderingEnable { get; set; } = false;
	
	[ContainerField(0x255), LayoutImmutable, Blittable, JsonProperty(Order = 597)]
	public bool GenericEntityRendererEnable { get; set; } = true;
	
	[ContainerField(0x256), LayoutImmutable, Blittable, JsonProperty(Order = 598)]
	public bool ZBufferShadowTestEnable { get; set; } = true;
	
	[ContainerField(0x257), LayoutImmutable, Blittable, JsonProperty(Order = 599)]
	public bool DecalVolumeEnable { get; set; } = false;
	
	[ContainerField(0x258), LayoutImmutable, Blittable, JsonProperty(Order = 600)]
	public bool DrawDebugDecalVolumes { get; set; } = false;
	
	[ContainerField(0x259), LayoutImmutable, Blittable, JsonProperty(Order = 601)]
	public bool DrawDebugDestructionVolumes { get; set; } = false;
	
	[ContainerField(0x25a), LayoutImmutable, Blittable, JsonProperty(Order = 602)]
	public bool LensFlaresEnable { get; set; } = true;
	
	[ContainerField(0x25b), LayoutImmutable, Blittable, JsonProperty(Order = 603)]
	public bool DrawDebugLensFlareOccluders { get; set; } = false;
	
	[ContainerField(0x25c), LayoutImmutable, Blittable, JsonProperty(Order = 604)]
	public bool DrawDebugLensFlares { get; set; } = false;
	
	[ContainerField(0x25d), LayoutImmutable, Blittable, JsonProperty(Order = 605)]
	public bool LensFlareOcclusionEnable { get; set; } = true;
	
	[ContainerField(0x25e), LayoutImmutable, Blittable, JsonProperty(Order = 606)]
	public bool CloudShadowEnable { get; set; } = true;
	
	[ContainerField(0x25f), LayoutImmutable, Blittable, JsonProperty(Order = 607)]
	public bool OverrideDynamicAO { get; set; } = true;
	
	[ContainerField(0x260), LayoutImmutable, Blittable, JsonProperty(Order = 608)]
	public bool DrawDebugDynamicAO { get; set; } = false;
	
	[ContainerField(0x261), LayoutImmutable, Blittable, JsonProperty(Order = 609)]
	public bool EmissiveEnable { get; set; } = true;
	
	[ContainerField(0x262), LayoutImmutable, Blittable, JsonProperty(Order = 610)]
	public bool UnlitEnable { get; set; } = true;
	
	[ContainerField(0x263), LayoutImmutable, Blittable, JsonProperty(Order = 611)]
	public bool GBufferClearEnable { get; set; } = false;
	
	[ContainerField(0x264), LayoutImmutable, Blittable, JsonProperty(Order = 612)]
	public bool DxGBufferLight16BitEnable { get; set; } = false;
	
	[ContainerField(0x265), LayoutImmutable, Blittable, JsonProperty(Order = 613)]
	public bool DxGBufferNormal16BitEnable { get; set; } = false;
	
	[ContainerField(0x266), LayoutImmutable, Blittable, JsonProperty(Order = 614)]
	public bool GBufferAlphaTestSimpleEnable { get; set; } = true;
	
	[ContainerField(0x267), LayoutImmutable, Blittable, JsonProperty(Order = 615)]
	public bool Gen4aEsramEnable { get; set; } = true;
	
	[ContainerField(0x268), LayoutImmutable, Blittable, JsonProperty(Order = 616)]
	public bool SpecularLightingEnable { get; set; } = true;
	
	[ContainerField(0x269), LayoutImmutable, Blittable, JsonProperty(Order = 617)]
	public bool SkinLightingEnable { get; set; } = true;
	
	[ContainerField(0x26a), LayoutImmutable, Blittable, JsonProperty(Order = 618)]
	public bool TranslucencyLightingEnable { get; set; } = true;
	
	[ContainerField(0x26b), LayoutImmutable, Blittable, JsonProperty(Order = 619)]
	public bool DynamicEnvmapLightingEnable { get; set; } = true;
	
	[ContainerField(0x26c), LayoutImmutable, Blittable, JsonProperty(Order = 620)]
	public bool OutdoorLightEnable { get; set; } = true;
	
	[ContainerField(0x26d), LayoutImmutable, Blittable, JsonProperty(Order = 621)]
	public bool PointLightsEnable { get; set; } = true;
	
	[ContainerField(0x26e), LayoutImmutable, Blittable, JsonProperty(Order = 622)]
	public bool LineLightsEnable { get; set; } = true;
	
	[ContainerField(0x26f), LayoutImmutable, Blittable, JsonProperty(Order = 623)]
	public bool ConeLightsEnable { get; set; } = true;
	
	[ContainerField(0x270), LayoutImmutable, Blittable, JsonProperty(Order = 624)]
	public bool SpotLightsEnable { get; set; } = true;
	
	[ContainerField(0x271), LayoutImmutable, Blittable, JsonProperty(Order = 625)]
	public bool LightProbesEnable { get; set; } = true;
	
	[ContainerField(0x272), LayoutImmutable, Blittable, JsonProperty(Order = 626)]
	public bool LightStencilMethodEnable { get; set; } = true;
	
	[ContainerField(0x273), LayoutImmutable, Blittable, JsonProperty(Order = 627)]
	public bool LightVolumeMethodEnable { get; set; } = true;
	
	[ContainerField(0x274), LayoutImmutable, Blittable, JsonProperty(Order = 628)]
	public bool LightVolumeDepthTestEnable { get; set; } = true;
	
	[ContainerField(0x275), LayoutImmutable, Blittable, JsonProperty(Order = 629)]
	public bool OutdoorKeyLightEnable { get; set; } = true;
	
	[ContainerField(0x276), LayoutImmutable, Blittable, JsonProperty(Order = 630)]
	public bool OutdoorSkyLightEnable { get; set; } = true;
	
	[ContainerField(0x277), LayoutImmutable, Blittable, JsonProperty(Order = 631)]
	public bool OutdoorLightTilingEnable { get; set; } = true;
	
	[ContainerField(0x278), LayoutImmutable, Blittable, JsonProperty(Order = 632)]
	public bool OutdoorLightTileRenderEnable { get; set; } = true;
	
	[ContainerField(0x279), LayoutImmutable, Blittable, JsonProperty(Order = 633)]
	public bool OutdoorLightTileBlendEnable { get; set; } = true;
	
	[ContainerField(0x27a), LayoutImmutable, Blittable, JsonProperty(Order = 634)]
	public bool OutdoorLightTileSimpleShaderEnable { get; set; } = false;
	
	[ContainerField(0x27b), LayoutImmutable, Blittable, JsonProperty(Order = 635)]
	public bool XenonOutdoorLightTilingEnable { get; set; } = true;
	
	[ContainerField(0x27c), LayoutImmutable, Blittable, JsonProperty(Order = 636)]
	public bool XenonPointLightsTilingEnable { get; set; } = true;
	
	[ContainerField(0x27d), LayoutImmutable, Blittable, JsonProperty(Order = 637)]
	public bool XenonSpotLightsTilingEnable { get; set; } = true;
	
	[ContainerField(0x27e), LayoutImmutable, Blittable, JsonProperty(Order = 638)]
	public bool XenonLineLightsTilingEnable { get; set; } = true;
	
	[ContainerField(0x27f), LayoutImmutable, Blittable, JsonProperty(Order = 639)]
	public bool XenonAsyncLightJobsEnable { get; set; } = true;
	
	[ContainerField(0x280), LayoutImmutable, Blittable, JsonProperty(Order = 640)]
	public bool XenonLightTileDownsampleSpecularCheckEnable { get; set; } = false;
	
	[ContainerField(0x281), LayoutImmutable, Blittable, JsonProperty(Order = 641)]
	public bool XenonLightTileCpuPointLightCullingEnable { get; set; } = true;
	
	[ContainerField(0x282), LayoutImmutable, Blittable, JsonProperty(Order = 642)]
	public bool XenonLightTileCpuSpotLightCullingEnable { get; set; } = true;
	
	[ContainerField(0x283), LayoutImmutable, Blittable, JsonProperty(Order = 643)]
	public bool Ps3DepthBoundsLightCullingEnable { get; set; } = true;
	
	[ContainerField(0x284), LayoutImmutable, Blittable, JsonProperty(Order = 644)]
	public bool Ps3LightTileJobYieldEnable { get; set; } = true;
	
	[ContainerField(0x285), LayoutImmutable, Blittable, JsonProperty(Order = 645)]
	public bool Ps3LightTileClearAllEnable { get; set; } = false;
	
	[ContainerField(0x286), LayoutImmutable, Blittable, JsonProperty(Order = 646)]
	public bool Ps3LightCullSpuJob { get; set; } = true;
	
	[ContainerField(0x287), LayoutImmutable, Blittable, JsonProperty(Order = 647)]
	public bool SpotLightShadowmapEnable { get; set; } = true;
	
	[ContainerField(0x288), LayoutImmutable, Blittable, JsonProperty(Order = 648)]
	public bool RadiositySpotLightShadowCullingEnable { get; set; } = true;
	
	[ContainerField(0x289), LayoutImmutable, Blittable, JsonProperty(Order = 649)]
	public bool LightTileCsPathEnable { get; set; } = true;
	
	[ContainerField(0x28a), LayoutImmutable, Blittable, JsonProperty(Order = 650)]
	public bool LightTileMinMaxUseHTile { get; set; } = false;
	
	[ContainerField(0x28b), LayoutImmutable, Blittable, JsonProperty(Order = 651)]
	public bool LightTileSplitCullingAndLighting { get; set; } = true;
	
	[ContainerField(0x28c), LayoutImmutable, Blittable, JsonProperty(Order = 652)]
	public bool DrawDebugGBuffer { get; set; } = false;
	
	[ContainerField(0x28d), LayoutImmutable, Blittable, JsonProperty(Order = 653)]
	public bool DrawDebugLightSources { get; set; } = false;
	
	[ContainerField(0x28e), LayoutImmutable, Blittable, JsonProperty(Order = 654)]
	public bool DrawDebugLightShadowSources { get; set; } = false;
	
	[ContainerField(0x28f), LayoutImmutable, Blittable, JsonProperty(Order = 655)]
	public bool DrawDebugLightTextureSources { get; set; } = false;
	
	[ContainerField(0x290), LayoutImmutable, Blittable, JsonProperty(Order = 656)]
	public bool DrawDebugLightStats { get; set; } = false;
	
	[ContainerField(0x291), LayoutImmutable, Blittable, JsonProperty(Order = 657)]
	public bool DrawDebugLightTiles { get; set; } = false;
	
	[ContainerField(0x292), LayoutImmutable, Blittable, JsonProperty(Order = 658)]
	public bool DrawDebugLightTileVolumes { get; set; } = false;
	
	[ContainerField(0x293), LayoutImmutable, Blittable, JsonProperty(Order = 659)]
	public bool DrawDebugLightTileFbGrid { get; set; } = false;
	
	[ContainerField(0x294), LayoutImmutable, Blittable, JsonProperty(Order = 660)]
	public bool DrawDebugLightTileGrid { get; set; } = false;
	
	[ContainerField(0x295), LayoutImmutable, Blittable, JsonProperty(Order = 661)]
	public bool DrawDebugLightTileSources { get; set; } = false;
	
	[ContainerField(0x296), LayoutImmutable, Blittable, JsonProperty(Order = 662)]
	public bool LightWidthEnable { get; set; } = true;
	
	[ContainerField(0x297), LayoutImmutable, Blittable, JsonProperty(Order = 663)]
	public bool LightIntensityNormalizationEnable { get; set; } = false;
	
	[ContainerField(0x298), LayoutImmutable, Blittable, JsonProperty(Order = 664)]
	public bool LightCullEnable { get; set; } = true;
	
	[ContainerField(0x299), LayoutImmutable, Blittable, JsonProperty(Order = 665)]
	public bool LightOcclusionCullEnable { get; set; } = true;
	
	[ContainerField(0x29a), LayoutImmutable, Blittable, JsonProperty(Order = 666)]
	public bool LightDepthCullEnable { get; set; } = true;
	
	[ContainerField(0x29b), LayoutImmutable, Blittable, JsonProperty(Order = 667)]
	public bool LightNormalCullEnable { get; set; } = true;
	
	[ContainerField(0x29c), LayoutImmutable, Blittable, JsonProperty(Order = 668)]
	public bool LightConeCullEnable { get; set; } = true;
	
	[ContainerField(0x29d), LayoutImmutable, Blittable, JsonProperty(Order = 669)]
	public bool LightTileOverlayEnable { get; set; } = true;
	
	[ContainerField(0x29e), LayoutImmutable, Blittable, JsonProperty(Order = 670)]
	public bool LightAttenuationThresholdEnable { get; set; } = true;
	
	[ContainerField(0x29f), LayoutImmutable, Blittable, JsonProperty(Order = 671)]
	public bool SkyVisibilityEnvmapScalingEnable { get; set; } = true;
	
	[ContainerField(0x2a0), LayoutImmutable, Blittable, JsonProperty(Order = 672)]
	public bool ShadowOcclusionCullingEnable { get; set; } = true;
	
	[ContainerField(0x2a1), LayoutImmutable, Blittable, JsonProperty(Order = 673)]
	public bool FrustumSilhouetteCullingEnable { get; set; } = false;
	
	[ContainerField(0x2a2), LayoutImmutable, Blittable, JsonProperty(Order = 674)]
	public bool SubSurfaceScatteringEnable { get; set; } = false;
	
	[ContainerField(0x2a3), LayoutImmutable, Blittable, JsonProperty(Order = 675)]
	public bool OpaqueSortBySolutionEnable { get; set; } = true;
	
	[ContainerField(0x2a4), LayoutImmutable, Blittable, JsonProperty(Order = 676)]
	public bool MainOpaqueZPassEnable { get; set; } = false;
	
	[ContainerField(0x2a5), LayoutImmutable, Blittable, JsonProperty(Order = 677)]
	public bool PlanarReflectionEnable { get; set; } = true;
	
	[ContainerField(0x2a6), LayoutImmutable, Blittable, JsonProperty(Order = 678)]
	public bool PlanarReflectionFastHdrEnable { get; set; } = true;
	
	[ContainerField(0x2a7), LayoutImmutable, Blittable, JsonProperty(Order = 679)]
	public bool PlanarReflectionBlur { get; set; } = true;
	
	[ContainerField(0x2a8), LayoutImmutable, Blittable, JsonProperty(Order = 680)]
	public bool PlanarReflectionClippingEnable { get; set; } = true;
	
	[ContainerField(0x2a9), LayoutImmutable, Blittable, JsonProperty(Order = 681)]
	public bool DrawDebugPlanarReflection { get; set; } = false;
	
	[ContainerField(0x2aa), LayoutImmutable, Blittable, JsonProperty(Order = 682)]
	public bool DrawDebugPlanarReflectionCullFrustum { get; set; } = false;
	
	[ContainerField(0x2ab), LayoutImmutable, Blittable, JsonProperty(Order = 683)]
	public bool OverlayEnable { get; set; } = true;
	
	[ContainerField(0x2ac), LayoutImmutable, Blittable, JsonProperty(Order = 684)]
	public bool SmaaVelocityReprojectionEnable { get; set; } = true;
	
	[ContainerField(0x2ad), LayoutImmutable, Blittable, JsonProperty(Order = 685)]
	public bool SmaaUseStencil { get; set; } = true;
	
	[ContainerField(0x2ae), LayoutImmutable, Blittable, JsonProperty(Order = 686)]
	public bool SmaaPredicatedThresholdingEnable { get; set; } = true;
	
	[ContainerField(0x2af), LayoutImmutable, Blittable, JsonProperty(Order = 687)]
	public bool ViewFxEnable { get; set; } = true;
	
	[ContainerField(0x2b0), LayoutImmutable, Blittable, JsonProperty(Order = 688)]
	public bool RenderScaleResampleEnable { get; set; } = true;
	
	[ContainerField(0x2b1), LayoutImmutable, Blittable, JsonProperty(Order = 689)]
	public bool LightCubeMapStencilEnable { get; set; } = true;
	
	[ContainerField(0x2b2), LayoutImmutable, Blittable, JsonProperty(Order = 690)]
	public bool DrawDebugIndirectCubeMapEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		OverlayColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(GenericEntityMaxVisibleEntityCount);
		p_Writer.Write(DrawDebugGroundHeight);
		p_Writer.Write(DecalVolumeScale);
		p_Writer.Write(GBufferLayout);
		p_Writer.Write(GBufferTestCount);
		p_Writer.Write(GBufferAlphaTestSimpleSmoothness);
		p_Writer.Write(GBufferForceSmoothness);
		p_Writer.Write(GBufferForceSpecularAlbedo);
		p_Writer.Write((int) SpotLightsAsConeLightsLevel);
		p_Writer.Write(LightTileMinArea);
		p_Writer.Write(LightStencilMinArea);
		p_Writer.Write(LightNarrowAngleThreshold);
		p_Writer.Write(OutdoorLightTileBatchCount);
		p_Writer.Write(XenonDrawDebugLightTileGridMode);
		p_Writer.Write(XenonLightTileConstantBufferSize);
		p_Writer.Write(XenonLightTileMaxPointLightCount);
		p_Writer.Write(XenonLightTileMaxLineLightCount);
		p_Writer.Write(XenonLightTileMaxSpotLightCount);
		p_Writer.Write(Ps3LightTileMethod);
		p_Writer.Write(Ps3LightTileJobCount);
		p_Writer.Write(Ps3LightTileJobPriority);
		p_Writer.Write(Ps3LightTileJobYieldGranularity);
		p_Writer.Write(Ps3LightTileJobYieldAggressiveGranularity);
		p_Writer.Write(Ps3LightTileJobMaxFbTileCount);
		p_Writer.Write(OnlyLightTileIndex);
		p_Writer.Write(SpotLightShadowmapResolution);
		p_Writer.Write(SpotLightShadowmapQuality);
		p_Writer.Write(SpotLightShadowmapPoissonFilterScale);
		p_Writer.Write((int) SpotLightShadowmapLevel);
		p_Writer.Write(MaxPointLightCount);
		p_Writer.Write(MaxSpotLightCount);
		p_Writer.Write(MaxSpotLightShadowCount);
		p_Writer.Write(MaxDestructionVolumeCount);
		p_Writer.Write(MaxDecalVolumeCount);
		p_Writer.Write(SpotLightNearPlane);
		p_Writer.Write(LightTileCsAvgLightCountPerTile);
		p_Writer.Write(LightLodFadeArea);
		p_Writer.Write(LightLodMinArea);
		p_Writer.Write(LightLodRadiusFactor);
		p_Writer.Write(LightLodSpecularFadeAreaStart);
		p_Writer.Write(LightLodSpecularFadeAreaEnd);
		p_Writer.Write(LightForceIntensity);
		p_Writer.Write(LightIntensityScale);
		p_Writer.Write(LightRadiusScale);
		p_Writer.Write(LightAttenuationThreshold);
		p_Writer.Write(ShadowOcclusionCullingWidth);
		p_Writer.Write(ShadowOcclusionCullingHeight);
		p_Writer.Write(ShadowOcclusionTriangleCount);
		p_Writer.Write(FrustumSilhouetteCullingPadding);
		p_Writer.Write(OnlyTileIndex);
		p_Writer.Write(PlanarReflectionViewScale);
		p_Writer.Write(PlanarReflectionCullFOV);
		p_Writer.Write(PlanarReflectionFarPlane);
		p_Writer.Write(DrawDebugPlanarReflectionMode);
		p_Writer.Write(ReflectionLodScale);
		p_Writer.Write((int) PostProcessAntialiasingMode);
		p_Writer.Write(FxaaForceVendor);
		p_Writer.Write((int) RenderScaleResampleMode);
		p_Writer.Write(LightCubeMapStencilMinArea);
		p_Writer.Write(DrawDebugIndirectCubeMapMipLevel);
		p_Writer.Write(DrawDebugIndirectCubeMapIndex);
		p_Writer.Write(SimpleRenderingEnable);
		p_Writer.Write(GenericEntityRendererEnable);
		p_Writer.Write(ZBufferShadowTestEnable);
		p_Writer.Write(DecalVolumeEnable);
		p_Writer.Write(DrawDebugDecalVolumes);
		p_Writer.Write(DrawDebugDestructionVolumes);
		p_Writer.Write(LensFlaresEnable);
		p_Writer.Write(DrawDebugLensFlareOccluders);
		p_Writer.Write(DrawDebugLensFlares);
		p_Writer.Write(LensFlareOcclusionEnable);
		p_Writer.Write(CloudShadowEnable);
		p_Writer.Write(OverrideDynamicAO);
		p_Writer.Write(DrawDebugDynamicAO);
		p_Writer.Write(EmissiveEnable);
		p_Writer.Write(UnlitEnable);
		p_Writer.Write(GBufferClearEnable);
		p_Writer.Write(DxGBufferLight16BitEnable);
		p_Writer.Write(DxGBufferNormal16BitEnable);
		p_Writer.Write(GBufferAlphaTestSimpleEnable);
		p_Writer.Write(Gen4aEsramEnable);
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
		p_Writer.Write(OutdoorKeyLightEnable);
		p_Writer.Write(OutdoorSkyLightEnable);
		p_Writer.Write(OutdoorLightTilingEnable);
		p_Writer.Write(OutdoorLightTileRenderEnable);
		p_Writer.Write(OutdoorLightTileBlendEnable);
		p_Writer.Write(OutdoorLightTileSimpleShaderEnable);
		p_Writer.Write(XenonOutdoorLightTilingEnable);
		p_Writer.Write(XenonPointLightsTilingEnable);
		p_Writer.Write(XenonSpotLightsTilingEnable);
		p_Writer.Write(XenonLineLightsTilingEnable);
		p_Writer.Write(XenonAsyncLightJobsEnable);
		p_Writer.Write(XenonLightTileDownsampleSpecularCheckEnable);
		p_Writer.Write(XenonLightTileCpuPointLightCullingEnable);
		p_Writer.Write(XenonLightTileCpuSpotLightCullingEnable);
		p_Writer.Write(Ps3DepthBoundsLightCullingEnable);
		p_Writer.Write(Ps3LightTileJobYieldEnable);
		p_Writer.Write(Ps3LightTileClearAllEnable);
		p_Writer.Write(Ps3LightCullSpuJob);
		p_Writer.Write(SpotLightShadowmapEnable);
		p_Writer.Write(RadiositySpotLightShadowCullingEnable);
		p_Writer.Write(LightTileCsPathEnable);
		p_Writer.Write(LightTileMinMaxUseHTile);
		p_Writer.Write(LightTileSplitCullingAndLighting);
		p_Writer.Write(DrawDebugGBuffer);
		p_Writer.Write(DrawDebugLightSources);
		p_Writer.Write(DrawDebugLightShadowSources);
		p_Writer.Write(DrawDebugLightTextureSources);
		p_Writer.Write(DrawDebugLightStats);
		p_Writer.Write(DrawDebugLightTiles);
		p_Writer.Write(DrawDebugLightTileVolumes);
		p_Writer.Write(DrawDebugLightTileFbGrid);
		p_Writer.Write(DrawDebugLightTileGrid);
		p_Writer.Write(DrawDebugLightTileSources);
		p_Writer.Write(LightWidthEnable);
		p_Writer.Write(LightIntensityNormalizationEnable);
		p_Writer.Write(LightCullEnable);
		p_Writer.Write(LightOcclusionCullEnable);
		p_Writer.Write(LightDepthCullEnable);
		p_Writer.Write(LightNormalCullEnable);
		p_Writer.Write(LightConeCullEnable);
		p_Writer.Write(LightTileOverlayEnable);
		p_Writer.Write(LightAttenuationThresholdEnable);
		p_Writer.Write(SkyVisibilityEnvmapScalingEnable);
		p_Writer.Write(ShadowOcclusionCullingEnable);
		p_Writer.Write(FrustumSilhouetteCullingEnable);
		p_Writer.Write(SubSurfaceScatteringEnable);
		p_Writer.Write(OpaqueSortBySolutionEnable);
		p_Writer.Write(MainOpaqueZPassEnable);
		p_Writer.Write(PlanarReflectionEnable);
		p_Writer.Write(PlanarReflectionFastHdrEnable);
		p_Writer.Write(PlanarReflectionBlur);
		p_Writer.Write(PlanarReflectionClippingEnable);
		p_Writer.Write(DrawDebugPlanarReflection);
		p_Writer.Write(DrawDebugPlanarReflectionCullFrustum);
		p_Writer.Write(OverlayEnable);
		p_Writer.Write(SmaaVelocityReprojectionEnable);
		p_Writer.Write(SmaaUseStencil);
		p_Writer.Write(SmaaPredicatedThresholdingEnable);
		p_Writer.Write(ViewFxEnable);
		p_Writer.Write(RenderScaleResampleEnable);
		p_Writer.Write(LightCubeMapStencilEnable);
		p_Writer.Write(DrawDebugIndirectCubeMapEnable);
		p_Writer.WriteNullBytes(13);
	}
}

