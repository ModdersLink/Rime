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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 416)]
	public class GlobalPostProcessSettings :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 Brightness { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 ForceBloomScale { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec4 ForceVignetteColor { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public Vec3 Contrast { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public Vec3 Saturation { get; set; } = new();

		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec2 FilmGrainTextureScale { get; set; } = new();

		[ContainerField(104), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public Vec2 ForceVignetteScale { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec3 FilmGrainColorScale { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public uint Ps3EdgeMlaaJobPriority { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public uint BloomBlurIterationCount { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public uint DebugModeStep { get; set; }

		[ContainerField(140), JsonProperty(Order = 140)]
		public BlurFilter BloomBlurFilter { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float LdrBloomRange { get; set; }

		[ContainerField(148), JsonProperty(Order = 148)]
		public PostProcessDebugMode DebugMode { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float UserBrightnessMin { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float UIBrightnessNorm { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public uint Ps3EdgeMlaaJobCount { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public uint Ps3EdgeMlaaAbsoluteThreshold { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public uint BloomPyramidLevelCount { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public uint BloomPyramidFinalLevel { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float UserBrightnessMax { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float UserBrightnessMulScale { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float UserBrightnessAddScale { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public uint DownsampleAverageStartMipmap { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public uint Ps3EdgeMlaaThresholdFactor { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public uint Ps3EdgeMlaaThresholdBase { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public uint Ps3TiledLdrMipmapCount { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public uint Ps3TiledFloatMipmapCount { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public uint Ps3TiledBloomMipmapCount { get; set; }

		[ContainerField(212), JsonProperty(Order = 212)]
		public BlurFilter HbaoGaussianBlurSize { get; set; } = new();

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float ForceExposure { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public float ForceBlurAdd { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public int ForceDofEnable { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public float ForceDofFocusDistance { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public float ForceDofNearDistanceScale { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public float ForceDofFarDistanceScale { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public float ForceDofScale { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public float ForceDofBlurFilterDeviation { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		public uint HbaoTemporalFilterMaxNumFrames { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		public int HbaoForceVendor { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public float ForceVignetteExponent { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		public float HbaoTemporalFilterThreshold { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		public int ForceTonemapMethod { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		public float LUTGammaR { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		public float LUTGammaG { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		public float HbaoTemporalFilterThreshold2 { get; set; }

		[ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		public int ForceChromostereopsisEnable { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		public int ForceChromostereopsisOffset { get; set; }

		[ContainerField(288), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		public float ForceChromostereopsisScale { get; set; }

		[ContainerField(292), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
		public uint HbaoBilateralBlurRadius { get; set; }

		[ContainerField(296), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		public float ForceMiddleGray { get; set; }

		[ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		public float LUTGammaB { get; set; }

		[ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		public float LUTGammaCurbOffset { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		public float HbaoBilateralBlurSharpness { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		public uint HbaoRandomTextureWidth { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		public float LensScopeFilterColorScale { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		public float HbaoStepCount { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		public float HbaoMaxFootprintRadius { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		public float HbaoDirCount { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		public float Hue { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		public uint HbaoQuality { get; set; }

		[ContainerField(340), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
		public uint HbaoRandomDirVariationCount { get; set; }

		[ContainerField(344), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
		public float ForceDiffusionDofPlaneInFocus { get; set; }

		[ContainerField(348), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
		public float DiffusionDofLuminance { get; set; }

		[ContainerField(352), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		public uint HbaoTemporalFilterDebugMode { get; set; }

		[ContainerField(356), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
		public float ForceDiffusionDofAperture { get; set; }

		[ContainerField(360), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
		public float ForceDiffusionDofFocalLength { get; set; }

		[ContainerField(364), JsonProperty(Order = 364)]
		public DynamicAOMethod DynamicAOMethod { get; set; } = new();

		[ContainerField(368), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
		public bool DrawDebugInfo { get; set; }

		[ContainerField(369), LayoutImmutable, Blittable, JsonProperty(Order = 369)]
		public bool ColorGradingForceUpdateAlways { get; set; }

		[ContainerField(370), LayoutImmutable, Blittable, JsonProperty(Order = 370)]
		public bool BloomBlurEnable { get; set; }

		[ContainerField(371), LayoutImmutable, Blittable, JsonProperty(Order = 371)]
		public bool HdrBlurEnable { get; set; }

		[ContainerField(372), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
		public bool BlurBlendEnable { get; set; }

		[ContainerField(373), LayoutImmutable, Blittable, JsonProperty(Order = 373)]
		public bool DownsampleAverageFromBloomEnable { get; set; }

		[ContainerField(374), LayoutImmutable, Blittable, JsonProperty(Order = 374)]
		public bool FilmGrainEnable { get; set; }

		[ContainerField(375), LayoutImmutable, Blittable, JsonProperty(Order = 375)]
		public bool Ldr16BitBloomEnable { get; set; }

		[ContainerField(376), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
		public bool DynamicAOEnable { get; set; }

		[ContainerField(377), LayoutImmutable, Blittable, JsonProperty(Order = 377)]
		public bool DiffusionDofEnable { get; set; }

		[ContainerField(378), LayoutImmutable, Blittable, JsonProperty(Order = 378)]
		public bool HbaoHalfResEnable { get; set; }

		[ContainerField(379), LayoutImmutable, Blittable, JsonProperty(Order = 379)]
		public bool HbaoHalfResDepthEnable { get; set; }

		[ContainerField(380), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
		public bool HbaoVectorizedEnable { get; set; }

		[ContainerField(381), LayoutImmutable, Blittable, JsonProperty(Order = 381)]
		public bool Ps3CompressedRenderTargetsEnable { get; set; }

		[ContainerField(382), LayoutImmutable, Blittable, JsonProperty(Order = 382)]
		public bool HdrBloomEnable { get; set; }

		[ContainerField(383), LayoutImmutable, Blittable, JsonProperty(Order = 383)]
		public bool FilmGrainRandomEnable { get; set; }

		[ContainerField(384), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
		public bool DirectExposureEnable { get; set; }

		[ContainerField(385), LayoutImmutable, Blittable, JsonProperty(Order = 385)]
		public bool ExposureClampEnable { get; set; }

		[ContainerField(386), LayoutImmutable, Blittable, JsonProperty(Order = 386)]
		public bool FilmGrainLinearFilteringEnable { get; set; }

		[ContainerField(387), LayoutImmutable, Blittable, JsonProperty(Order = 387)]
		public bool HbaoBilateralBlurEnable { get; set; }

		[ContainerField(388), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
		public bool ColorGradingEnable { get; set; }

		[ContainerField(389), LayoutImmutable, Blittable, JsonProperty(Order = 389)]
		public bool ColorTransformEnable { get; set; }

		[ContainerField(390), LayoutImmutable, Blittable, JsonProperty(Order = 390)]
		public bool HbaoBilateralBlurCsEnable { get; set; }

		[ContainerField(391), LayoutImmutable, Blittable, JsonProperty(Order = 391)]
		public bool HbaoTemporalFilterEnable { get; set; }

		[ContainerField(392), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
		public bool QuarterDownsamplingEnable { get; set; }

		[ContainerField(393), LayoutImmutable, Blittable, JsonProperty(Order = 393)]
		public bool DrawDebugUserBrightnessLUT { get; set; }

		[ContainerField(394), LayoutImmutable, Blittable, JsonProperty(Order = 394)]
		public bool BloomPyramidAttenuateEnable { get; set; }

		[ContainerField(395), LayoutImmutable, Blittable, JsonProperty(Order = 395)]
		public bool DownsampleBeforeBlurEnable { get; set; }

		[ContainerField(396), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
		public bool HbaoGaussianBlurEnable { get; set; }

		[ContainerField(397), LayoutImmutable, Blittable, JsonProperty(Order = 397)]
		public bool HbaoGaussianBlurHalfResEnable { get; set; }

		[ContainerField(398), LayoutImmutable, Blittable, JsonProperty(Order = 398)]
		public bool BloomPyramidEnable { get; set; }

		[ContainerField(399), LayoutImmutable, Blittable, JsonProperty(Order = 399)]
		public bool UserBrightnessLUTEnable { get; set; }

		[ContainerField(400), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
		public bool Ps3EdgeMlaaEnable { get; set; }

		[ContainerField(401), LayoutImmutable, Blittable, JsonProperty(Order = 401)]
		public bool Ps3EdgeMlaaCopyOnly { get; set; }

		[ContainerField(402), LayoutImmutable, Blittable, JsonProperty(Order = 402)]
		public bool Ps3EdgeMlaaShowEdges { get; set; }

		[ContainerField(403), LayoutImmutable, Blittable, JsonProperty(Order = 403)]
		public bool Ps3EdgeMlaaRelativeEdgeDetection { get; set; }

		[ContainerField(404), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
		public bool Ps3EdgeMlaaGpuBlockEnable { get; set; }

		[ContainerField(405), LayoutImmutable, Blittable, JsonProperty(Order = 405)]
		public bool Ps3BackBufferAsLdrTargetEnable { get; set; }

		[ContainerField(406), LayoutImmutable, Blittable, JsonProperty(Order = 406)]
		public bool DownsampleLogAverageEnable { get; set; }

		[ContainerField(407), LayoutImmutable, Blittable, JsonProperty(Order = 407)]
		public bool BloomQuarterResEnable { get; set; }

		[ContainerField(408), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
		public bool BloomEnable { get; set; }

		[ContainerField(409), LayoutImmutable, Blittable, JsonProperty(Order = 409)]
		public bool LensScopeFilterEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			Brightness.Serialize(p_Writer, p_EbxWriter);
			ForceBloomScale.Serialize(p_Writer, p_EbxWriter);
			ForceVignetteColor.Serialize(p_Writer, p_EbxWriter);
			Contrast.Serialize(p_Writer, p_EbxWriter);
			Saturation.Serialize(p_Writer, p_EbxWriter);
			FilmGrainTextureScale.Serialize(p_Writer, p_EbxWriter);
			ForceVignetteScale.Serialize(p_Writer, p_EbxWriter);
			FilmGrainColorScale.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Ps3EdgeMlaaJobPriority);
			p_Writer.Write(BloomBlurIterationCount);
			p_Writer.Write(DebugModeStep);
			p_Writer.Write((int) BloomBlurFilter);
			p_Writer.Write(LdrBloomRange);
			p_Writer.Write((int) DebugMode);
			p_Writer.Write(UserBrightnessMin);
			p_Writer.Write(UIBrightnessNorm);
			p_Writer.Write(Ps3EdgeMlaaJobCount);
			p_Writer.Write(Ps3EdgeMlaaAbsoluteThreshold);
			p_Writer.Write(BloomPyramidLevelCount);
			p_Writer.Write(BloomPyramidFinalLevel);
			p_Writer.Write(UserBrightnessMax);
			p_Writer.Write(UserBrightnessMulScale);
			p_Writer.Write(UserBrightnessAddScale);
			p_Writer.Write(DownsampleAverageStartMipmap);
			p_Writer.Write(Ps3EdgeMlaaThresholdFactor);
			p_Writer.Write(Ps3EdgeMlaaThresholdBase);
			p_Writer.Write(Ps3TiledLdrMipmapCount);
			p_Writer.Write(Ps3TiledFloatMipmapCount);
			p_Writer.Write(Ps3TiledBloomMipmapCount);
			p_Writer.Write((int) HbaoGaussianBlurSize);
			p_Writer.Write(ForceExposure);
			p_Writer.Write(ForceBlurAdd);
			p_Writer.Write(ForceDofEnable);
			p_Writer.Write(ForceDofFocusDistance);
			p_Writer.Write(ForceDofNearDistanceScale);
			p_Writer.Write(ForceDofFarDistanceScale);
			p_Writer.Write(ForceDofScale);
			p_Writer.Write(ForceDofBlurFilterDeviation);
			p_Writer.Write(HbaoTemporalFilterMaxNumFrames);
			p_Writer.Write(HbaoForceVendor);
			p_Writer.Write(ForceVignetteExponent);
			p_Writer.Write(HbaoTemporalFilterThreshold);
			p_Writer.Write(ForceTonemapMethod);
			p_Writer.Write(LUTGammaR);
			p_Writer.Write(LUTGammaG);
			p_Writer.Write(HbaoTemporalFilterThreshold2);
			p_Writer.Write(ForceChromostereopsisEnable);
			p_Writer.Write(ForceChromostereopsisOffset);
			p_Writer.Write(ForceChromostereopsisScale);
			p_Writer.Write(HbaoBilateralBlurRadius);
			p_Writer.Write(ForceMiddleGray);
			p_Writer.Write(LUTGammaB);
			p_Writer.Write(LUTGammaCurbOffset);
			p_Writer.Write(HbaoBilateralBlurSharpness);
			p_Writer.Write(HbaoRandomTextureWidth);
			p_Writer.Write(LensScopeFilterColorScale);
			p_Writer.Write(HbaoStepCount);
			p_Writer.Write(HbaoMaxFootprintRadius);
			p_Writer.Write(HbaoDirCount);
			p_Writer.Write(Hue);
			p_Writer.Write(HbaoQuality);
			p_Writer.Write(HbaoRandomDirVariationCount);
			p_Writer.Write(ForceDiffusionDofPlaneInFocus);
			p_Writer.Write(DiffusionDofLuminance);
			p_Writer.Write(HbaoTemporalFilterDebugMode);
			p_Writer.Write(ForceDiffusionDofAperture);
			p_Writer.Write(ForceDiffusionDofFocalLength);
			p_Writer.Write((int) DynamicAOMethod);
			p_Writer.Write(DrawDebugInfo);
			p_Writer.Write(ColorGradingForceUpdateAlways);
			p_Writer.Write(BloomBlurEnable);
			p_Writer.Write(HdrBlurEnable);
			p_Writer.Write(BlurBlendEnable);
			p_Writer.Write(DownsampleAverageFromBloomEnable);
			p_Writer.Write(FilmGrainEnable);
			p_Writer.Write(Ldr16BitBloomEnable);
			p_Writer.Write(DynamicAOEnable);
			p_Writer.Write(DiffusionDofEnable);
			p_Writer.Write(HbaoHalfResEnable);
			p_Writer.Write(HbaoHalfResDepthEnable);
			p_Writer.Write(HbaoVectorizedEnable);
			p_Writer.Write(Ps3CompressedRenderTargetsEnable);
			p_Writer.Write(HdrBloomEnable);
			p_Writer.Write(FilmGrainRandomEnable);
			p_Writer.Write(DirectExposureEnable);
			p_Writer.Write(ExposureClampEnable);
			p_Writer.Write(FilmGrainLinearFilteringEnable);
			p_Writer.Write(HbaoBilateralBlurEnable);
			p_Writer.Write(ColorGradingEnable);
			p_Writer.Write(ColorTransformEnable);
			p_Writer.Write(HbaoBilateralBlurCsEnable);
			p_Writer.Write(HbaoTemporalFilterEnable);
			p_Writer.Write(QuarterDownsamplingEnable);
			p_Writer.Write(DrawDebugUserBrightnessLUT);
			p_Writer.Write(BloomPyramidAttenuateEnable);
			p_Writer.Write(DownsampleBeforeBlurEnable);
			p_Writer.Write(HbaoGaussianBlurEnable);
			p_Writer.Write(HbaoGaussianBlurHalfResEnable);
			p_Writer.Write(BloomPyramidEnable);
			p_Writer.Write(UserBrightnessLUTEnable);
			p_Writer.Write(Ps3EdgeMlaaEnable);
			p_Writer.Write(Ps3EdgeMlaaCopyOnly);
			p_Writer.Write(Ps3EdgeMlaaShowEdges);
			p_Writer.Write(Ps3EdgeMlaaRelativeEdgeDetection);
			p_Writer.Write(Ps3EdgeMlaaGpuBlockEnable);
			p_Writer.Write(Ps3BackBufferAsLdrTargetEnable);
			p_Writer.Write(DownsampleLogAverageEnable);
			p_Writer.Write(BloomQuarterResEnable);
			p_Writer.Write(BloomEnable);
			p_Writer.Write(LensScopeFilterEnable);
			p_Writer.WriteNullBytes(6);
		}
	}
}
