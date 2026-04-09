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
	[ContainerType(16, 416)]
	public partial class GlobalPostProcessSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _Brightness = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _ForceBloomScale = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec4 _ForceVignetteColor = new();

		[ObservableProperty]
		[property: ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private Vec3 _Contrast = new();

		[ObservableProperty]
		[property: ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private Vec3 _Saturation = new();

		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec2 _FilmGrainTextureScale = new();

		[ObservableProperty]
		[property: ContainerField(104), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private Vec2 _ForceVignetteScale = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec3 _FilmGrainColorScale = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private uint _Ps3EdgeMlaaJobPriority;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private uint _BloomBlurIterationCount;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private uint _DebugModeStep;

		[ObservableProperty]
		[property: ContainerField(140), JsonProperty(Order = 140)]
		private BlurFilter _BloomBlurFilter = new();

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _LdrBloomRange;

		[ObservableProperty]
		[property: ContainerField(148), JsonProperty(Order = 148)]
		private PostProcessDebugMode _DebugMode = new();

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _UserBrightnessMin;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _UIBrightnessNorm;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private uint _Ps3EdgeMlaaJobCount;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private uint _Ps3EdgeMlaaAbsoluteThreshold;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private uint _BloomPyramidLevelCount;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private uint _BloomPyramidFinalLevel;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _UserBrightnessMax;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _UserBrightnessMulScale;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _UserBrightnessAddScale;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private uint _DownsampleAverageStartMipmap;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private uint _Ps3EdgeMlaaThresholdFactor;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private uint _Ps3EdgeMlaaThresholdBase;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private uint _Ps3TiledLdrMipmapCount;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private uint _Ps3TiledFloatMipmapCount;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private uint _Ps3TiledBloomMipmapCount;

		[ObservableProperty]
		[property: ContainerField(212), JsonProperty(Order = 212)]
		private BlurFilter _HbaoGaussianBlurSize = new();

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _ForceExposure;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _ForceBlurAdd;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private int _ForceDofEnable;

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private float _ForceDofFocusDistance;

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private float _ForceDofNearDistanceScale;

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private float _ForceDofFarDistanceScale;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private float _ForceDofScale;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private float _ForceDofBlurFilterDeviation;

		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private uint _HbaoTemporalFilterMaxNumFrames;

		[ObservableProperty]
		[property: ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		private int _HbaoForceVendor;

		[ObservableProperty]
		[property: ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private float _ForceVignetteExponent;

		[ObservableProperty]
		[property: ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		private float _HbaoTemporalFilterThreshold;

		[ObservableProperty]
		[property: ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		private int _ForceTonemapMethod;

		[ObservableProperty]
		[property: ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		private float _LUTGammaR;

		[ObservableProperty]
		[property: ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		private float _LUTGammaG;

		[ObservableProperty]
		[property: ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		private float _HbaoTemporalFilterThreshold2;

		[ObservableProperty]
		[property: ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		private int _ForceChromostereopsisEnable;

		[ObservableProperty]
		[property: ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		private int _ForceChromostereopsisOffset;

		[ObservableProperty]
		[property: ContainerField(288), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
		private float _ForceChromostereopsisScale;

		[ObservableProperty]
		[property: ContainerField(292), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
		private uint _HbaoBilateralBlurRadius;

		[ObservableProperty]
		[property: ContainerField(296), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		private float _ForceMiddleGray;

		[ObservableProperty]
		[property: ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		private float _LUTGammaB;

		[ObservableProperty]
		[property: ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		private float _LUTGammaCurbOffset;

		[ObservableProperty]
		[property: ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		private float _HbaoBilateralBlurSharpness;

		[ObservableProperty]
		[property: ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		private uint _HbaoRandomTextureWidth;

		[ObservableProperty]
		[property: ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		private float _LensScopeFilterColorScale;

		[ObservableProperty]
		[property: ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		private float _HbaoStepCount;

		[ObservableProperty]
		[property: ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		private float _HbaoMaxFootprintRadius;

		[ObservableProperty]
		[property: ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		private float _HbaoDirCount;

		[ObservableProperty]
		[property: ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		private float _Hue;

		[ObservableProperty]
		[property: ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		private uint _HbaoQuality;

		[ObservableProperty]
		[property: ContainerField(340), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
		private uint _HbaoRandomDirVariationCount;

		[ObservableProperty]
		[property: ContainerField(344), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
		private float _ForceDiffusionDofPlaneInFocus;

		[ObservableProperty]
		[property: ContainerField(348), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
		private float _DiffusionDofLuminance;

		[ObservableProperty]
		[property: ContainerField(352), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		private uint _HbaoTemporalFilterDebugMode;

		[ObservableProperty]
		[property: ContainerField(356), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
		private float _ForceDiffusionDofAperture;

		[ObservableProperty]
		[property: ContainerField(360), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
		private float _ForceDiffusionDofFocalLength;

		[ObservableProperty]
		[property: ContainerField(364), JsonProperty(Order = 364)]
		private DynamicAOMethod _DynamicAOMethod = new();

		[ObservableProperty]
		[property: ContainerField(368), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
		private bool _DrawDebugInfo;

		[ObservableProperty]
		[property: ContainerField(369), LayoutImmutable, Blittable, JsonProperty(Order = 369)]
		private bool _ColorGradingForceUpdateAlways;

		[ObservableProperty]
		[property: ContainerField(370), LayoutImmutable, Blittable, JsonProperty(Order = 370)]
		private bool _BloomBlurEnable;

		[ObservableProperty]
		[property: ContainerField(371), LayoutImmutable, Blittable, JsonProperty(Order = 371)]
		private bool _HdrBlurEnable;

		[ObservableProperty]
		[property: ContainerField(372), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
		private bool _BlurBlendEnable;

		[ObservableProperty]
		[property: ContainerField(373), LayoutImmutable, Blittable, JsonProperty(Order = 373)]
		private bool _DownsampleAverageFromBloomEnable;

		[ObservableProperty]
		[property: ContainerField(374), LayoutImmutable, Blittable, JsonProperty(Order = 374)]
		private bool _FilmGrainEnable;

		[ObservableProperty]
		[property: ContainerField(375), LayoutImmutable, Blittable, JsonProperty(Order = 375)]
		private bool _Ldr16BitBloomEnable;

		[ObservableProperty]
		[property: ContainerField(376), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
		private bool _DynamicAOEnable;

		[ObservableProperty]
		[property: ContainerField(377), LayoutImmutable, Blittable, JsonProperty(Order = 377)]
		private bool _DiffusionDofEnable;

		[ObservableProperty]
		[property: ContainerField(378), LayoutImmutable, Blittable, JsonProperty(Order = 378)]
		private bool _HbaoHalfResEnable;

		[ObservableProperty]
		[property: ContainerField(379), LayoutImmutable, Blittable, JsonProperty(Order = 379)]
		private bool _HbaoHalfResDepthEnable;

		[ObservableProperty]
		[property: ContainerField(380), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
		private bool _HbaoVectorizedEnable;

		[ObservableProperty]
		[property: ContainerField(381), LayoutImmutable, Blittable, JsonProperty(Order = 381)]
		private bool _Ps3CompressedRenderTargetsEnable;

		[ObservableProperty]
		[property: ContainerField(382), LayoutImmutable, Blittable, JsonProperty(Order = 382)]
		private bool _HdrBloomEnable;

		[ObservableProperty]
		[property: ContainerField(383), LayoutImmutable, Blittable, JsonProperty(Order = 383)]
		private bool _FilmGrainRandomEnable;

		[ObservableProperty]
		[property: ContainerField(384), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
		private bool _DirectExposureEnable;

		[ObservableProperty]
		[property: ContainerField(385), LayoutImmutable, Blittable, JsonProperty(Order = 385)]
		private bool _ExposureClampEnable;

		[ObservableProperty]
		[property: ContainerField(386), LayoutImmutable, Blittable, JsonProperty(Order = 386)]
		private bool _FilmGrainLinearFilteringEnable;

		[ObservableProperty]
		[property: ContainerField(387), LayoutImmutable, Blittable, JsonProperty(Order = 387)]
		private bool _HbaoBilateralBlurEnable;

		[ObservableProperty]
		[property: ContainerField(388), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
		private bool _ColorGradingEnable;

		[ObservableProperty]
		[property: ContainerField(389), LayoutImmutable, Blittable, JsonProperty(Order = 389)]
		private bool _ColorTransformEnable;

		[ObservableProperty]
		[property: ContainerField(390), LayoutImmutable, Blittable, JsonProperty(Order = 390)]
		private bool _HbaoBilateralBlurCsEnable;

		[ObservableProperty]
		[property: ContainerField(391), LayoutImmutable, Blittable, JsonProperty(Order = 391)]
		private bool _HbaoTemporalFilterEnable;

		[ObservableProperty]
		[property: ContainerField(392), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
		private bool _QuarterDownsamplingEnable;

		[ObservableProperty]
		[property: ContainerField(393), LayoutImmutable, Blittable, JsonProperty(Order = 393)]
		private bool _DrawDebugUserBrightnessLUT;

		[ObservableProperty]
		[property: ContainerField(394), LayoutImmutable, Blittable, JsonProperty(Order = 394)]
		private bool _BloomPyramidAttenuateEnable;

		[ObservableProperty]
		[property: ContainerField(395), LayoutImmutable, Blittable, JsonProperty(Order = 395)]
		private bool _DownsampleBeforeBlurEnable;

		[ObservableProperty]
		[property: ContainerField(396), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
		private bool _HbaoGaussianBlurEnable;

		[ObservableProperty]
		[property: ContainerField(397), LayoutImmutable, Blittable, JsonProperty(Order = 397)]
		private bool _HbaoGaussianBlurHalfResEnable;

		[ObservableProperty]
		[property: ContainerField(398), LayoutImmutable, Blittable, JsonProperty(Order = 398)]
		private bool _BloomPyramidEnable;

		[ObservableProperty]
		[property: ContainerField(399), LayoutImmutable, Blittable, JsonProperty(Order = 399)]
		private bool _UserBrightnessLUTEnable;

		[ObservableProperty]
		[property: ContainerField(400), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
		private bool _Ps3EdgeMlaaEnable;

		[ObservableProperty]
		[property: ContainerField(401), LayoutImmutable, Blittable, JsonProperty(Order = 401)]
		private bool _Ps3EdgeMlaaCopyOnly;

		[ObservableProperty]
		[property: ContainerField(402), LayoutImmutable, Blittable, JsonProperty(Order = 402)]
		private bool _Ps3EdgeMlaaShowEdges;

		[ObservableProperty]
		[property: ContainerField(403), LayoutImmutable, Blittable, JsonProperty(Order = 403)]
		private bool _Ps3EdgeMlaaRelativeEdgeDetection;

		[ObservableProperty]
		[property: ContainerField(404), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
		private bool _Ps3EdgeMlaaGpuBlockEnable;

		[ObservableProperty]
		[property: ContainerField(405), LayoutImmutable, Blittable, JsonProperty(Order = 405)]
		private bool _Ps3BackBufferAsLdrTargetEnable;

		[ObservableProperty]
		[property: ContainerField(406), LayoutImmutable, Blittable, JsonProperty(Order = 406)]
		private bool _DownsampleLogAverageEnable;

		[ObservableProperty]
		[property: ContainerField(407), LayoutImmutable, Blittable, JsonProperty(Order = 407)]
		private bool _BloomQuarterResEnable;

		[ObservableProperty]
		[property: ContainerField(408), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
		private bool _BloomEnable;

		[ObservableProperty]
		[property: ContainerField(409), LayoutImmutable, Blittable, JsonProperty(Order = 409)]
		private bool _LensScopeFilterEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
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
