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
	[ContainerType(16, 416)]
	public class GlobalPostProcessSettings : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Brightness { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ForceBloomScale { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ForceVignetteColor { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Contrast { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Saturation { get; set; } = new();

		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 FilmGrainTextureScale { get; set; } = new();

		[ContainerField(104), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ForceVignetteScale { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 FilmGrainColorScale { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public uint Ps3EdgeMlaaJobPriority { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public uint BloomBlurIterationCount { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public uint DebugModeStep { get; set; }

		[ContainerField(140)]
		public BlurFilter BloomBlurFilter { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public float LdrBloomRange { get; set; }

		[ContainerField(148)]
		public PostProcessDebugMode DebugMode { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable]
		public float UserBrightnessMin { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float UIBrightnessNorm { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public uint Ps3EdgeMlaaJobCount { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public uint Ps3EdgeMlaaAbsoluteThreshold { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public uint BloomPyramidLevelCount { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public uint BloomPyramidFinalLevel { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float UserBrightnessMax { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float UserBrightnessMulScale { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float UserBrightnessAddScale { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public uint DownsampleAverageStartMipmap { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public uint Ps3EdgeMlaaThresholdFactor { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public uint Ps3EdgeMlaaThresholdBase { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public uint Ps3TiledLdrMipmapCount { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public uint Ps3TiledFloatMipmapCount { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public uint Ps3TiledBloomMipmapCount { get; set; }

		[ContainerField(212)]
		public BlurFilter HbaoGaussianBlurSize { get; set; } = new();

		[ContainerField(216), LayoutImmutable, Blittable]
		public float ForceExposure { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public float ForceBlurAdd { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public int ForceDofEnable { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable]
		public float ForceDofFocusDistance { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable]
		public float ForceDofNearDistanceScale { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public float ForceDofFarDistanceScale { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public float ForceDofScale { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public float ForceDofBlurFilterDeviation { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable]
		public uint HbaoTemporalFilterMaxNumFrames { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable]
		public int HbaoForceVendor { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable]
		public float ForceVignetteExponent { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable]
		public float HbaoTemporalFilterThreshold { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable]
		public int ForceTonemapMethod { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable]
		public float LUTGammaR { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable]
		public float LUTGammaG { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable]
		public float HbaoTemporalFilterThreshold2 { get; set; }

		[ContainerField(280), LayoutImmutable, Blittable]
		public int ForceChromostereopsisEnable { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable]
		public int ForceChromostereopsisOffset { get; set; }

		[ContainerField(288), LayoutImmutable, Blittable]
		public float ForceChromostereopsisScale { get; set; }

		[ContainerField(292), LayoutImmutable, Blittable]
		public uint HbaoBilateralBlurRadius { get; set; }

		[ContainerField(296), LayoutImmutable, Blittable]
		public float ForceMiddleGray { get; set; }

		[ContainerField(300), LayoutImmutable, Blittable]
		public float LUTGammaB { get; set; }

		[ContainerField(304), LayoutImmutable, Blittable]
		public float LUTGammaCurbOffset { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable]
		public float HbaoBilateralBlurSharpness { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable]
		public uint HbaoRandomTextureWidth { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable]
		public float LensScopeFilterColorScale { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable]
		public float HbaoStepCount { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable]
		public float HbaoMaxFootprintRadius { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable]
		public float HbaoDirCount { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable]
		public float Hue { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable]
		public uint HbaoQuality { get; set; }

		[ContainerField(340), LayoutImmutable, Blittable]
		public uint HbaoRandomDirVariationCount { get; set; }

		[ContainerField(344), LayoutImmutable, Blittable]
		public float ForceDiffusionDofPlaneInFocus { get; set; }

		[ContainerField(348), LayoutImmutable, Blittable]
		public float DiffusionDofLuminance { get; set; }

		[ContainerField(352), LayoutImmutable, Blittable]
		public uint HbaoTemporalFilterDebugMode { get; set; }

		[ContainerField(356), LayoutImmutable, Blittable]
		public float ForceDiffusionDofAperture { get; set; }

		[ContainerField(360), LayoutImmutable, Blittable]
		public float ForceDiffusionDofFocalLength { get; set; }

		[ContainerField(364)]
		public DynamicAOMethod DynamicAOMethod { get; set; } = new();

		[ContainerField(368), LayoutImmutable, Blittable]
		public bool DrawDebugInfo { get; set; }

		[ContainerField(369), LayoutImmutable, Blittable]
		public bool ColorGradingForceUpdateAlways { get; set; }

		[ContainerField(370), LayoutImmutable, Blittable]
		public bool BloomBlurEnable { get; set; }

		[ContainerField(371), LayoutImmutable, Blittable]
		public bool HdrBlurEnable { get; set; }

		[ContainerField(372), LayoutImmutable, Blittable]
		public bool BlurBlendEnable { get; set; }

		[ContainerField(373), LayoutImmutable, Blittable]
		public bool DownsampleAverageFromBloomEnable { get; set; }

		[ContainerField(374), LayoutImmutable, Blittable]
		public bool FilmGrainEnable { get; set; }

		[ContainerField(375), LayoutImmutable, Blittable]
		public bool Ldr16BitBloomEnable { get; set; }

		[ContainerField(376), LayoutImmutable, Blittable]
		public bool DynamicAOEnable { get; set; }

		[ContainerField(377), LayoutImmutable, Blittable]
		public bool DiffusionDofEnable { get; set; }

		[ContainerField(378), LayoutImmutable, Blittable]
		public bool HbaoHalfResEnable { get; set; }

		[ContainerField(379), LayoutImmutable, Blittable]
		public bool HbaoHalfResDepthEnable { get; set; }

		[ContainerField(380), LayoutImmutable, Blittable]
		public bool HbaoVectorizedEnable { get; set; }

		[ContainerField(381), LayoutImmutable, Blittable]
		public bool Ps3CompressedRenderTargetsEnable { get; set; }

		[ContainerField(382), LayoutImmutable, Blittable]
		public bool HdrBloomEnable { get; set; }

		[ContainerField(383), LayoutImmutable, Blittable]
		public bool FilmGrainRandomEnable { get; set; }

		[ContainerField(384), LayoutImmutable, Blittable]
		public bool DirectExposureEnable { get; set; }

		[ContainerField(385), LayoutImmutable, Blittable]
		public bool ExposureClampEnable { get; set; }

		[ContainerField(386), LayoutImmutable, Blittable]
		public bool FilmGrainLinearFilteringEnable { get; set; }

		[ContainerField(387), LayoutImmutable, Blittable]
		public bool HbaoBilateralBlurEnable { get; set; }

		[ContainerField(388), LayoutImmutable, Blittable]
		public bool ColorGradingEnable { get; set; }

		[ContainerField(389), LayoutImmutable, Blittable]
		public bool ColorTransformEnable { get; set; }

		[ContainerField(390), LayoutImmutable, Blittable]
		public bool HbaoBilateralBlurCsEnable { get; set; }

		[ContainerField(391), LayoutImmutable, Blittable]
		public bool HbaoTemporalFilterEnable { get; set; }

		[ContainerField(392), LayoutImmutable, Blittable]
		public bool QuarterDownsamplingEnable { get; set; }

		[ContainerField(393), LayoutImmutable, Blittable]
		public bool DrawDebugUserBrightnessLUT { get; set; }

		[ContainerField(394), LayoutImmutable, Blittable]
		public bool BloomPyramidAttenuateEnable { get; set; }

		[ContainerField(395), LayoutImmutable, Blittable]
		public bool DownsampleBeforeBlurEnable { get; set; }

		[ContainerField(396), LayoutImmutable, Blittable]
		public bool HbaoGaussianBlurEnable { get; set; }

		[ContainerField(397), LayoutImmutable, Blittable]
		public bool HbaoGaussianBlurHalfResEnable { get; set; }

		[ContainerField(398), LayoutImmutable, Blittable]
		public bool BloomPyramidEnable { get; set; }

		[ContainerField(399), LayoutImmutable, Blittable]
		public bool UserBrightnessLUTEnable { get; set; }

		[ContainerField(400), LayoutImmutable, Blittable]
		public bool Ps3EdgeMlaaEnable { get; set; }

		[ContainerField(401), LayoutImmutable, Blittable]
		public bool Ps3EdgeMlaaCopyOnly { get; set; }

		[ContainerField(402), LayoutImmutable, Blittable]
		public bool Ps3EdgeMlaaShowEdges { get; set; }

		[ContainerField(403), LayoutImmutable, Blittable]
		public bool Ps3EdgeMlaaRelativeEdgeDetection { get; set; }

		[ContainerField(404), LayoutImmutable, Blittable]
		public bool Ps3EdgeMlaaGpuBlockEnable { get; set; }

		[ContainerField(405), LayoutImmutable, Blittable]
		public bool Ps3BackBufferAsLdrTargetEnable { get; set; }

		[ContainerField(406), LayoutImmutable, Blittable]
		public bool DownsampleLogAverageEnable { get; set; }

		[ContainerField(407), LayoutImmutable, Blittable]
		public bool BloomQuarterResEnable { get; set; }

		[ContainerField(408), LayoutImmutable, Blittable]
		public bool BloomEnable { get; set; }

		[ContainerField(409), LayoutImmutable, Blittable]
		public bool LensScopeFilterEnable { get; set; }

	}
}
