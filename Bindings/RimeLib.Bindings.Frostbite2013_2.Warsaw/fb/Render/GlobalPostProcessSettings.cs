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

namespace fb.Render;

[ContainerType(16, 544)]
public class GlobalPostProcessSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public PostProcessDebugMode DebugMode { get; set; } = PostProcessDebugMode.PpdmDefault;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint DebugModeStep { get; set; } = 0;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 ForceBloomScale { get; set; } = new()
	{
		z = -1.000f,
		y = -1.000f,
		x = -1.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec4 ForceVignetteColor { get; set; } = new()
	{
		w = -1.000f,
		z = -1.000f,
		y = -1.000f,
		x = -1.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 FilmGrainColorScale { get; set; } = new()
	{
		z = 0.005f,
		y = 0.005f,
		x = 0.005f,
	};
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec3 Brightness { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 Contrast { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 Saturation { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public BlurFilter BloomBlurFilter { get; set; } = BlurFilter.BfGaussian15Pixels;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public uint BloomBlurIterationCount { get; set; } = 1;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float LdrBloomRange { get; set; } = 0.050f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float ForceMiddleGray { get; set; } = -1.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public uint BloomPyramidLevelCount { get; set; } = 6;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public uint BloomPyramidFinalLevel { get; set; } = 0;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float BloomPyramidAttenuation { get; set; } = 0.500f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public uint DownsampleAverageStartMipmap { get; set; } = 1;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public uint Ps3TiledLdrMipmapCount { get; set; } = 2;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public uint Ps3TiledFloatMipmapCount { get; set; } = 2;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public uint Ps3TiledBloomMipmapCount { get; set; } = 3;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float ForceExposure { get; set; } = -1.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public int ForceDofEnable { get; set; } = -1;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float ForceDofBlurFactor { get; set; } = -1.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float ForceDofBlurAdd { get; set; } = -1.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float ForceDofFocusDistance { get; set; } = -1.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float ForceSimpleDofNearStart { get; set; } = -1.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float ForceSimpleDofNearEnd { get; set; } = -1.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float ForceSimpleDofFarStart { get; set; } = -1.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float ForceSimpleDofFarEnd { get; set; } = -1.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float ForceSimpleDofBlurMax { get; set; } = -1.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float ForceSpriteDofNearStart { get; set; } = -1.000f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float ForceSpriteDofNearEnd { get; set; } = -1.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float ForceSpriteDofFarStart { get; set; } = -1.000f;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float ForceSpriteDofFarEnd { get; set; } = -1.000f;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public float ForceSpriteDofBlurMax { get; set; } = -1.000f;
	
	[ContainerField(0xe8), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public Vec2 ForceVignetteScale { get; set; } = new()
	{
		y = -1.000f,
		x = -1.000f,
	};
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float ForceVignetteExponent { get; set; } = -1.000f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public int ForceTonemapMethod { get; set; } = -1;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public int ForceChromostereopsisEnable { get; set; } = -1;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public int ForceChromostereopsisOffset { get; set; } = -1;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float ForceChromostereopsisScale { get; set; } = -1.000f;
	
	[ContainerField(0x104), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public Vec2 FilmGrainTextureScale { get; set; } = new()
	{
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float LensScopeColorScale { get; set; } = 6.000f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float Hue { get; set; } = 0.000f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float UIBrightnessNorm { get; set; } = 0.500f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float UserBrightnessMin { get; set; } = 0.700f;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public float UserBrightnessMax { get; set; } = 1.300f;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float UserBrightnessAddScale { get; set; } = 0.050f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float UserBrightnessMulScale { get; set; } = 1.000f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public float LUTGammaR { get; set; } = 1.000f;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public float LUTGammaG { get; set; } = 1.000f;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float LUTGammaB { get; set; } = 1.000f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public float LUTGammaCurbOffset { get; set; } = 0.000f;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public DofMethod DofMethod { get; set; } = fb.Render.DofMethod.DofMethod_Gaussian;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public BlurMethod BlurMethod { get; set; } = fb.Render.BlurMethod.BlurMethod_Gaussian;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public float SpriteDofMinRadiusLayer1 { get; set; } = 33.000f;
	
	[ContainerField(0x144), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
	public float SpriteDofMinradiusLayer2 { get; set; } = 33.000f;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public float SpriteDofMergeColorThreshold { get; set; } = 0.200f;
	
	[ContainerField(0x14c), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
	public float SpriteDofMergeRadiusThreshold { get; set; } = 1.000f;
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public float SpriteDofDepthDiscontinuityThreshold { get; set; } = 0.150f;
	
	[ContainerField(0x154), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
	public uint SpriteDofActiveLayer { get; set; } = 7;
	
	[ContainerField(0x158), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
	public float SpriteDofInfocusMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x15c), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
	public float SpriteDofMaxBlurScale { get; set; } = 0.059f;
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float SpriteDofEnergyScaler { get; set; } = 1.000f;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public int SubSurfaceScatteringSampleCount { get; set; } = 8;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public DynamicAOMethod DynamicAOMethod { get; set; } = fb.Render.DynamicAOMethod.DynamicAOMethod_HBAO;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public uint IronsightsDofResolutionFactor { get; set; } = 2;
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public BlurFilter IronsightsBlurFilter { get; set; } = BlurFilter.BfGaussian7Pixels;
	
	[ContainerField(0x174), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
	public BlurFilter IronsightsBlurFilter720p { get; set; } = BlurFilter.BfGaussian5Pixels;
	
	[ContainerField(0x178), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
	public float IronsightsHDRCompression { get; set; } = 1.000f;
	
	[ContainerField(0x17c), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
	public float IronsightsCoCScale { get; set; } = 3.500f;
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public float OverrideIronsightsHipFade { get; set; } = 1.000f;
	
	[ContainerField(0x184), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
	public float OverrideIronsightsStartFade { get; set; } = 0.500f;
	
	[ContainerField(0x188), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
	public float OverrideIronsightsFocalDistance { get; set; } = 1.500f;
	
	[ContainerField(0x18c), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
	public float OverrideIronsightsDofCircleDistance { get; set; } = 0.350f;
	
	[ContainerField(0x190), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
	public uint HbaoRandomDirVariationCount { get; set; } = 1;
	
	[ContainerField(0x194), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
	public uint HbaoQuality { get; set; } = 1;
	
	[ContainerField(0x198), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
	public float HbaoStepCount { get; set; } = 3.000f;
	
	[ContainerField(0x19c), LayoutImmutable, Blittable, JsonProperty(Order = 412)]
	public float HbaoDirCount { get; set; } = 6.000f;
	
	[ContainerField(0x1a0), LayoutImmutable, Blittable, JsonProperty(Order = 416)]
	public uint HbaoRandomTextureWidth { get; set; } = 4;
	
	[ContainerField(0x1a4), LayoutImmutable, Blittable, JsonProperty(Order = 420)]
	public float HbaoMaxFootprintRadius { get; set; } = 0.050f;
	
	[ContainerField(0x1a8), LayoutImmutable, Blittable, JsonProperty(Order = 424)]
	public uint HbaoBilateralBlurRadius { get; set; } = 8;
	
	[ContainerField(0x1ac), LayoutImmutable, Blittable, JsonProperty(Order = 428)]
	public float HbaoBilateralBlurSharpness { get; set; } = 8.000f;
	
	[ContainerField(0x1b0), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
	public float HbaoTemporalFilterThreshold { get; set; } = 0.100f;
	
	[ContainerField(0x1b4), LayoutImmutable, Blittable, JsonProperty(Order = 436)]
	public float HbaoTemporalFilterThreshold2 { get; set; } = 0.050f;
	
	[ContainerField(0x1b8), LayoutImmutable, Blittable, JsonProperty(Order = 440)]
	public uint HbaoTemporalFilterMaxNumFrames { get; set; } = 8;
	
	[ContainerField(0x1bc), LayoutImmutable, Blittable, JsonProperty(Order = 444)]
	public uint HbaoTemporalFilterDebugMode { get; set; } = 0;
	
	[ContainerField(0x1c0), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
	public BlurFilter HbaoGaussianBlurSize { get; set; } = BlurFilter.BfGaussian9Pixels;
	
	[ContainerField(0x1c4), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
	public int HbaoForceVendor { get; set; } = -1;
	
	[ContainerField(0x1c8), LayoutImmutable, Blittable, JsonProperty(Order = 456)]
	public uint Ps3EdgeMlaaThresholdBase { get; set; } = 10;
	
	[ContainerField(0x1cc), LayoutImmutable, Blittable, JsonProperty(Order = 460)]
	public uint Ps3EdgeMlaaThresholdFactor { get; set; } = 89;
	
	[ContainerField(0x1d0), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
	public uint Ps3EdgeMlaaAbsoluteThreshold { get; set; } = 32;
	
	[ContainerField(0x1d4), LayoutImmutable, Blittable, JsonProperty(Order = 468)]
	public uint Ps3EdgeMlaaJobCount { get; set; } = 5;
	
	[ContainerField(0x1d8), LayoutImmutable, Blittable, JsonProperty(Order = 472)]
	public uint Ps3EdgeMlaaJobPriority { get; set; } = 128;
	
	[ContainerField(0x1dc), LayoutImmutable, Blittable, JsonProperty(Order = 476)]
	public bool HdrBlurEnable { get; set; } = false;
	
	[ContainerField(0x1dd), LayoutImmutable, Blittable, JsonProperty(Order = 477)]
	public bool HdrBloomEnable { get; set; } = true;
	
	[ContainerField(0x1de), LayoutImmutable, Blittable, JsonProperty(Order = 478)]
	public bool BloomFastHdrEnable { get; set; } = true;
	
	[ContainerField(0x1df), LayoutImmutable, Blittable, JsonProperty(Order = 479)]
	public bool Ldr16BitBloomEnable { get; set; } = true;
	
	[ContainerField(0x1e0), LayoutImmutable, Blittable, JsonProperty(Order = 480)]
	public bool ExposureClampEnable { get; set; } = true;
	
	[ContainerField(0x1e1), LayoutImmutable, Blittable, JsonProperty(Order = 481)]
	public bool DirectExposureEnable { get; set; } = false;
	
	[ContainerField(0x1e2), LayoutImmutable, Blittable, JsonProperty(Order = 482)]
	public bool DrawDebugInfo { get; set; } = false;
	
	[ContainerField(0x1e3), LayoutImmutable, Blittable, JsonProperty(Order = 483)]
	public bool BlurEnable { get; set; } = true;
	
	[ContainerField(0x1e4), LayoutImmutable, Blittable, JsonProperty(Order = 484)]
	public bool QuarterDownsamplingEnable { get; set; } = false;
	
	[ContainerField(0x1e5), LayoutImmutable, Blittable, JsonProperty(Order = 485)]
	public bool BlurBlendEnable { get; set; } = false;
	
	[ContainerField(0x1e6), LayoutImmutable, Blittable, JsonProperty(Order = 486)]
	public bool BloomEnable { get; set; } = true;
	
	[ContainerField(0x1e7), LayoutImmutable, Blittable, JsonProperty(Order = 487)]
	public bool BloomBlurEnable { get; set; } = true;
	
	[ContainerField(0x1e8), LayoutImmutable, Blittable, JsonProperty(Order = 488)]
	public bool BloomQuarterResEnable { get; set; } = false;
	
	[ContainerField(0x1e9), LayoutImmutable, Blittable, JsonProperty(Order = 489)]
	public bool BloomPyramidEnable { get; set; } = true;
	
	[ContainerField(0x1ea), LayoutImmutable, Blittable, JsonProperty(Order = 490)]
	public bool DownsampleLogAverageEnable { get; set; } = true;
	
	[ContainerField(0x1eb), LayoutImmutable, Blittable, JsonProperty(Order = 491)]
	public bool DownsampleBeforeBlurEnable { get; set; } = true;
	
	[ContainerField(0x1ec), LayoutImmutable, Blittable, JsonProperty(Order = 492)]
	public bool Ps3CompressedRenderTargetsEnable { get; set; } = false;
	
	[ContainerField(0x1ed), LayoutImmutable, Blittable, JsonProperty(Order = 493)]
	public bool VignetteEnable { get; set; } = true;
	
	[ContainerField(0x1ee), LayoutImmutable, Blittable, JsonProperty(Order = 494)]
	public bool ColorGradingEnable { get; set; } = true;
	
	[ContainerField(0x1ef), LayoutImmutable, Blittable, JsonProperty(Order = 495)]
	public bool ColorTransformEnable { get; set; } = true;
	
	[ContainerField(0x1f0), LayoutImmutable, Blittable, JsonProperty(Order = 496)]
	public bool ColorGradingForceUpdateAlways { get; set; } = false;
	
	[ContainerField(0x1f1), LayoutImmutable, Blittable, JsonProperty(Order = 497)]
	public bool FilmGrainEnable { get; set; } = true;
	
	[ContainerField(0x1f2), LayoutImmutable, Blittable, JsonProperty(Order = 498)]
	public bool FilmGrainLinearFilteringEnable { get; set; } = false;
	
	[ContainerField(0x1f3), LayoutImmutable, Blittable, JsonProperty(Order = 499)]
	public bool FilmGrainRandomEnable { get; set; } = false;
	
	[ContainerField(0x1f4), LayoutImmutable, Blittable, JsonProperty(Order = 500)]
	public bool LensScopeEnable { get; set; } = true;
	
	[ContainerField(0x1f5), LayoutImmutable, Blittable, JsonProperty(Order = 501)]
	public bool UserBrightnessLUTEnable { get; set; } = true;
	
	[ContainerField(0x1f6), LayoutImmutable, Blittable, JsonProperty(Order = 502)]
	public bool DrawDebugUserBrightnessLUT { get; set; } = false;
	
	[ContainerField(0x1f7), LayoutImmutable, Blittable, JsonProperty(Order = 503)]
	public bool SpriteDofEnable { get; set; } = false;
	
	[ContainerField(0x1f8), LayoutImmutable, Blittable, JsonProperty(Order = 504)]
	public bool SpriteDofMergeEnable { get; set; } = true;
	
	[ContainerField(0x1f9), LayoutImmutable, Blittable, JsonProperty(Order = 505)]
	public bool SpriteDofDepthFilterEnable { get; set; } = true;
	
	[ContainerField(0x1fa), LayoutImmutable, Blittable, JsonProperty(Order = 506)]
	public bool SpriteDofBuffer32bitEnable { get; set; } = false;
	
	[ContainerField(0x1fb), LayoutImmutable, Blittable, JsonProperty(Order = 507)]
	public bool SpriteDofHalfResolutionEnable { get; set; } = true;
	
	[ContainerField(0x1fc), LayoutImmutable, Blittable, JsonProperty(Order = 508)]
	public bool SpriteDofInstancingEnable { get; set; } = true;
	
	[ContainerField(0x1fd), LayoutImmutable, Blittable, JsonProperty(Order = 509)]
	public bool DynamicAOEnable { get; set; } = true;
	
	[ContainerField(0x1fe), LayoutImmutable, Blittable, JsonProperty(Order = 510)]
	public bool SsaoBlurEnable { get; set; } = true;
	
	[ContainerField(0x1ff), LayoutImmutable, Blittable, JsonProperty(Order = 511)]
	public bool IronsightsDofEnable { get; set; } = true;
	
	[ContainerField(0x200), LayoutImmutable, Blittable, JsonProperty(Order = 512)]
	public bool ForceIronsightsDofActive { get; set; } = false;
	
	[ContainerField(0x201), LayoutImmutable, Blittable, JsonProperty(Order = 513)]
	public bool IronsightsDofShareBloomDownsample { get; set; } = true;
	
	[ContainerField(0x202), LayoutImmutable, Blittable, JsonProperty(Order = 514)]
	public bool OverrideIronsightsDofParams { get; set; } = false;
	
	[ContainerField(0x203), LayoutImmutable, Blittable, JsonProperty(Order = 515)]
	public bool OverrideIronsightsDofCircleBlur { get; set; } = false;
	
	[ContainerField(0x204), LayoutImmutable, Blittable, JsonProperty(Order = 516)]
	public bool ForceLensScopeActive { get; set; } = false;
	
	[ContainerField(0x205), LayoutImmutable, Blittable, JsonProperty(Order = 517)]
	public bool HbaoHalfResEnable { get; set; } = true;
	
	[ContainerField(0x206), LayoutImmutable, Blittable, JsonProperty(Order = 518)]
	public bool HbaoHalfResDepthEnable { get; set; } = true;
	
	[ContainerField(0x207), LayoutImmutable, Blittable, JsonProperty(Order = 519)]
	public bool HbaoVectorizedEnable { get; set; } = true;
	
	[ContainerField(0x208), LayoutImmutable, Blittable, JsonProperty(Order = 520)]
	public bool HbaoBilateralBlurEnable { get; set; } = true;
	
	[ContainerField(0x209), LayoutImmutable, Blittable, JsonProperty(Order = 521)]
	public bool HbaoBilateralBlurCsEnable { get; set; } = false;
	
	[ContainerField(0x20a), LayoutImmutable, Blittable, JsonProperty(Order = 522)]
	public bool HbaoTemporalFilterEnable { get; set; } = true;
	
	[ContainerField(0x20b), LayoutImmutable, Blittable, JsonProperty(Order = 523)]
	public bool HbaoGaussianBlurEnable { get; set; } = false;
	
	[ContainerField(0x20c), LayoutImmutable, Blittable, JsonProperty(Order = 524)]
	public bool HbaoGaussianBlurHalfResEnable { get; set; } = true;
	
	[ContainerField(0x20d), LayoutImmutable, Blittable, JsonProperty(Order = 525)]
	public bool Ps3EdgeMlaaEnable { get; set; } = false;
	
	[ContainerField(0x20e), LayoutImmutable, Blittable, JsonProperty(Order = 526)]
	public bool Ps3EdgeMlaaCopyOnly { get; set; } = false;
	
	[ContainerField(0x20f), LayoutImmutable, Blittable, JsonProperty(Order = 527)]
	public bool Ps3EdgeMlaaShowEdges { get; set; } = false;
	
	[ContainerField(0x210), LayoutImmutable, Blittable, JsonProperty(Order = 528)]
	public bool Ps3EdgeMlaaRelativeEdgeDetection { get; set; } = true;
	
	[ContainerField(0x211), LayoutImmutable, Blittable, JsonProperty(Order = 529)]
	public bool Ps3EdgeMlaaGpuBlockEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) DebugMode);
		p_Writer.Write(DebugModeStep);
		p_Writer.WriteNullBytes(8);
		ForceBloomScale.Serialize(p_Writer, p_EbxWriter);
		ForceVignetteColor.Serialize(p_Writer, p_EbxWriter);
		FilmGrainColorScale.Serialize(p_Writer, p_EbxWriter);
		Brightness.Serialize(p_Writer, p_EbxWriter);
		Contrast.Serialize(p_Writer, p_EbxWriter);
		Saturation.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) BloomBlurFilter);
		p_Writer.Write(BloomBlurIterationCount);
		p_Writer.Write(LdrBloomRange);
		p_Writer.Write(ForceMiddleGray);
		p_Writer.Write(BloomPyramidLevelCount);
		p_Writer.Write(BloomPyramidFinalLevel);
		p_Writer.Write(BloomPyramidAttenuation);
		p_Writer.Write(DownsampleAverageStartMipmap);
		p_Writer.Write(Ps3TiledLdrMipmapCount);
		p_Writer.Write(Ps3TiledFloatMipmapCount);
		p_Writer.Write(Ps3TiledBloomMipmapCount);
		p_Writer.Write(ForceExposure);
		p_Writer.Write(ForceDofEnable);
		p_Writer.Write(ForceDofBlurFactor);
		p_Writer.Write(ForceDofBlurAdd);
		p_Writer.Write(ForceDofFocusDistance);
		p_Writer.Write(ForceSimpleDofNearStart);
		p_Writer.Write(ForceSimpleDofNearEnd);
		p_Writer.Write(ForceSimpleDofFarStart);
		p_Writer.Write(ForceSimpleDofFarEnd);
		p_Writer.Write(ForceSimpleDofBlurMax);
		p_Writer.Write(ForceSpriteDofNearStart);
		p_Writer.Write(ForceSpriteDofNearEnd);
		p_Writer.Write(ForceSpriteDofFarStart);
		p_Writer.Write(ForceSpriteDofFarEnd);
		p_Writer.Write(ForceSpriteDofBlurMax);
		ForceVignetteScale.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ForceVignetteExponent);
		p_Writer.Write(ForceTonemapMethod);
		p_Writer.Write(ForceChromostereopsisEnable);
		p_Writer.Write(ForceChromostereopsisOffset);
		p_Writer.Write(ForceChromostereopsisScale);
		FilmGrainTextureScale.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LensScopeColorScale);
		p_Writer.Write(Hue);
		p_Writer.Write(UIBrightnessNorm);
		p_Writer.Write(UserBrightnessMin);
		p_Writer.Write(UserBrightnessMax);
		p_Writer.Write(UserBrightnessAddScale);
		p_Writer.Write(UserBrightnessMulScale);
		p_Writer.Write(LUTGammaR);
		p_Writer.Write(LUTGammaG);
		p_Writer.Write(LUTGammaB);
		p_Writer.Write(LUTGammaCurbOffset);
		p_Writer.Write((int) DofMethod);
		p_Writer.Write((int) BlurMethod);
		p_Writer.Write(SpriteDofMinRadiusLayer1);
		p_Writer.Write(SpriteDofMinradiusLayer2);
		p_Writer.Write(SpriteDofMergeColorThreshold);
		p_Writer.Write(SpriteDofMergeRadiusThreshold);
		p_Writer.Write(SpriteDofDepthDiscontinuityThreshold);
		p_Writer.Write(SpriteDofActiveLayer);
		p_Writer.Write(SpriteDofInfocusMultiplier);
		p_Writer.Write(SpriteDofMaxBlurScale);
		p_Writer.Write(SpriteDofEnergyScaler);
		p_Writer.Write(SubSurfaceScatteringSampleCount);
		p_Writer.Write((int) DynamicAOMethod);
		p_Writer.Write(IronsightsDofResolutionFactor);
		p_Writer.Write((int) IronsightsBlurFilter);
		p_Writer.Write((int) IronsightsBlurFilter720p);
		p_Writer.Write(IronsightsHDRCompression);
		p_Writer.Write(IronsightsCoCScale);
		p_Writer.Write(OverrideIronsightsHipFade);
		p_Writer.Write(OverrideIronsightsStartFade);
		p_Writer.Write(OverrideIronsightsFocalDistance);
		p_Writer.Write(OverrideIronsightsDofCircleDistance);
		p_Writer.Write(HbaoRandomDirVariationCount);
		p_Writer.Write(HbaoQuality);
		p_Writer.Write(HbaoStepCount);
		p_Writer.Write(HbaoDirCount);
		p_Writer.Write(HbaoRandomTextureWidth);
		p_Writer.Write(HbaoMaxFootprintRadius);
		p_Writer.Write(HbaoBilateralBlurRadius);
		p_Writer.Write(HbaoBilateralBlurSharpness);
		p_Writer.Write(HbaoTemporalFilterThreshold);
		p_Writer.Write(HbaoTemporalFilterThreshold2);
		p_Writer.Write(HbaoTemporalFilterMaxNumFrames);
		p_Writer.Write(HbaoTemporalFilterDebugMode);
		p_Writer.Write((int) HbaoGaussianBlurSize);
		p_Writer.Write(HbaoForceVendor);
		p_Writer.Write(Ps3EdgeMlaaThresholdBase);
		p_Writer.Write(Ps3EdgeMlaaThresholdFactor);
		p_Writer.Write(Ps3EdgeMlaaAbsoluteThreshold);
		p_Writer.Write(Ps3EdgeMlaaJobCount);
		p_Writer.Write(Ps3EdgeMlaaJobPriority);
		p_Writer.Write(HdrBlurEnable);
		p_Writer.Write(HdrBloomEnable);
		p_Writer.Write(BloomFastHdrEnable);
		p_Writer.Write(Ldr16BitBloomEnable);
		p_Writer.Write(ExposureClampEnable);
		p_Writer.Write(DirectExposureEnable);
		p_Writer.Write(DrawDebugInfo);
		p_Writer.Write(BlurEnable);
		p_Writer.Write(QuarterDownsamplingEnable);
		p_Writer.Write(BlurBlendEnable);
		p_Writer.Write(BloomEnable);
		p_Writer.Write(BloomBlurEnable);
		p_Writer.Write(BloomQuarterResEnable);
		p_Writer.Write(BloomPyramidEnable);
		p_Writer.Write(DownsampleLogAverageEnable);
		p_Writer.Write(DownsampleBeforeBlurEnable);
		p_Writer.Write(Ps3CompressedRenderTargetsEnable);
		p_Writer.Write(VignetteEnable);
		p_Writer.Write(ColorGradingEnable);
		p_Writer.Write(ColorTransformEnable);
		p_Writer.Write(ColorGradingForceUpdateAlways);
		p_Writer.Write(FilmGrainEnable);
		p_Writer.Write(FilmGrainLinearFilteringEnable);
		p_Writer.Write(FilmGrainRandomEnable);
		p_Writer.Write(LensScopeEnable);
		p_Writer.Write(UserBrightnessLUTEnable);
		p_Writer.Write(DrawDebugUserBrightnessLUT);
		p_Writer.Write(SpriteDofEnable);
		p_Writer.Write(SpriteDofMergeEnable);
		p_Writer.Write(SpriteDofDepthFilterEnable);
		p_Writer.Write(SpriteDofBuffer32bitEnable);
		p_Writer.Write(SpriteDofHalfResolutionEnable);
		p_Writer.Write(SpriteDofInstancingEnable);
		p_Writer.Write(DynamicAOEnable);
		p_Writer.Write(SsaoBlurEnable);
		p_Writer.Write(IronsightsDofEnable);
		p_Writer.Write(ForceIronsightsDofActive);
		p_Writer.Write(IronsightsDofShareBloomDownsample);
		p_Writer.Write(OverrideIronsightsDofParams);
		p_Writer.Write(OverrideIronsightsDofCircleBlur);
		p_Writer.Write(ForceLensScopeActive);
		p_Writer.Write(HbaoHalfResEnable);
		p_Writer.Write(HbaoHalfResDepthEnable);
		p_Writer.Write(HbaoVectorizedEnable);
		p_Writer.Write(HbaoBilateralBlurEnable);
		p_Writer.Write(HbaoBilateralBlurCsEnable);
		p_Writer.Write(HbaoTemporalFilterEnable);
		p_Writer.Write(HbaoGaussianBlurEnable);
		p_Writer.Write(HbaoGaussianBlurHalfResEnable);
		p_Writer.Write(Ps3EdgeMlaaEnable);
		p_Writer.Write(Ps3EdgeMlaaCopyOnly);
		p_Writer.Write(Ps3EdgeMlaaShowEdges);
		p_Writer.Write(Ps3EdgeMlaaRelativeEdgeDetection);
		p_Writer.Write(Ps3EdgeMlaaGpuBlockEnable);
		p_Writer.WriteNullBytes(14);
	}
}

