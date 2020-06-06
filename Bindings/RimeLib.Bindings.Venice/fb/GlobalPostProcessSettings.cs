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
	public class GlobalPostProcessSettings : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Brightness { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ForceBloomScale { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ForceVignetteColor { get; set; } = new Vec4(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Contrast { get; set; } = new Vec3(); // 0x40 (64)
		
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Saturation { get; set; } = new Vec3(); // 0x50 (80)
		
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 FilmGrainTextureScale { get; set; } = new Vec2(); // 0x60 (96)
		
		[ContainerField(104), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ForceVignetteScale { get; set; } = new Vec2(); // 0x68 (104)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 FilmGrainColorScale { get; set; } = new Vec3(); // 0x70 (112)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public uint Ps3EdgeMlaaJobPriority { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public uint BloomBlurIterationCount { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public uint DebugModeStep { get; set; } // 0x88 (136)
		
		[ContainerField(140)]
		public BlurFilter BloomBlurFilter { get; set; } = new BlurFilter(); // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float LdrBloomRange { get; set; } // 0x90 (144)
		
		[ContainerField(148)]
		public PostProcessDebugMode DebugMode { get; set; } = new PostProcessDebugMode(); // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float UserBrightnessMin { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float UIBrightnessNorm { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public uint Ps3EdgeMlaaJobCount { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public uint Ps3EdgeMlaaAbsoluteThreshold { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public uint BloomPyramidLevelCount { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public uint BloomPyramidFinalLevel { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float UserBrightnessMax { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float UserBrightnessMulScale { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float UserBrightnessAddScale { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public uint DownsampleAverageStartMipmap { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public uint Ps3EdgeMlaaThresholdFactor { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public uint Ps3EdgeMlaaThresholdBase { get; set; } // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public uint Ps3TiledLdrMipmapCount { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public uint Ps3TiledFloatMipmapCount { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public uint Ps3TiledBloomMipmapCount { get; set; } // 0xD0 (208)
		
		[ContainerField(212)]
		public BlurFilter HbaoGaussianBlurSize { get; set; } = new BlurFilter(); // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float ForceExposure { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float ForceBlurAdd { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public int ForceDofEnable { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public float ForceDofFocusDistance { get; set; } // 0xE4 (228)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public float ForceDofNearDistanceScale { get; set; } // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public float ForceDofFarDistanceScale { get; set; } // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public float ForceDofScale { get; set; } // 0xF0 (240)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public float ForceDofBlurFilterDeviation { get; set; } // 0xF4 (244)
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public uint HbaoTemporalFilterMaxNumFrames { get; set; } // 0xF8 (248)
		
		[ContainerField(252), LayoutImmutable, Blittable]
		public int HbaoForceVendor { get; set; } // 0xFC (252)
		
		[ContainerField(256), LayoutImmutable, Blittable]
		public float ForceVignetteExponent { get; set; } // 0x100 (256)
		
		[ContainerField(260), LayoutImmutable, Blittable]
		public float HbaoTemporalFilterThreshold { get; set; } // 0x104 (260)
		
		[ContainerField(264), LayoutImmutable, Blittable]
		public int ForceTonemapMethod { get; set; } // 0x108 (264)
		
		[ContainerField(268), LayoutImmutable, Blittable]
		public float LUTGammaR { get; set; } // 0x10C (268)
		
		[ContainerField(272), LayoutImmutable, Blittable]
		public float LUTGammaG { get; set; } // 0x110 (272)
		
		[ContainerField(276), LayoutImmutable, Blittable]
		public float HbaoTemporalFilterThreshold2 { get; set; } // 0x114 (276)
		
		[ContainerField(280), LayoutImmutable, Blittable]
		public int ForceChromostereopsisEnable { get; set; } // 0x118 (280)
		
		[ContainerField(284), LayoutImmutable, Blittable]
		public int ForceChromostereopsisOffset { get; set; } // 0x11C (284)
		
		[ContainerField(288), LayoutImmutable, Blittable]
		public float ForceChromostereopsisScale { get; set; } // 0x120 (288)
		
		[ContainerField(292), LayoutImmutable, Blittable]
		public uint HbaoBilateralBlurRadius { get; set; } // 0x124 (292)
		
		[ContainerField(296), LayoutImmutable, Blittable]
		public float ForceMiddleGray { get; set; } // 0x128 (296)
		
		[ContainerField(300), LayoutImmutable, Blittable]
		public float LUTGammaB { get; set; } // 0x12C (300)
		
		[ContainerField(304), LayoutImmutable, Blittable]
		public float LUTGammaCurbOffset { get; set; } // 0x130 (304)
		
		[ContainerField(308), LayoutImmutable, Blittable]
		public float HbaoBilateralBlurSharpness { get; set; } // 0x134 (308)
		
		[ContainerField(312), LayoutImmutable, Blittable]
		public uint HbaoRandomTextureWidth { get; set; } // 0x138 (312)
		
		[ContainerField(316), LayoutImmutable, Blittable]
		public float LensScopeFilterColorScale { get; set; } // 0x13C (316)
		
		[ContainerField(320), LayoutImmutable, Blittable]
		public float HbaoStepCount { get; set; } // 0x140 (320)
		
		[ContainerField(324), LayoutImmutable, Blittable]
		public float HbaoMaxFootprintRadius { get; set; } // 0x144 (324)
		
		[ContainerField(328), LayoutImmutable, Blittable]
		public float HbaoDirCount { get; set; } // 0x148 (328)
		
		[ContainerField(332), LayoutImmutable, Blittable]
		public float Hue { get; set; } // 0x14C (332)
		
		[ContainerField(336), LayoutImmutable, Blittable]
		public uint HbaoQuality { get; set; } // 0x150 (336)
		
		[ContainerField(340), LayoutImmutable, Blittable]
		public uint HbaoRandomDirVariationCount { get; set; } // 0x154 (340)
		
		[ContainerField(344), LayoutImmutable, Blittable]
		public float ForceDiffusionDofPlaneInFocus { get; set; } // 0x158 (344)
		
		[ContainerField(348), LayoutImmutable, Blittable]
		public float DiffusionDofLuminance { get; set; } // 0x15C (348)
		
		[ContainerField(352), LayoutImmutable, Blittable]
		public uint HbaoTemporalFilterDebugMode { get; set; } // 0x160 (352)
		
		[ContainerField(356), LayoutImmutable, Blittable]
		public float ForceDiffusionDofAperture { get; set; } // 0x164 (356)
		
		[ContainerField(360), LayoutImmutable, Blittable]
		public float ForceDiffusionDofFocalLength { get; set; } // 0x168 (360)
		
		[ContainerField(364)]
		public DynamicAOMethod DynamicAOMethod { get; set; } = new DynamicAOMethod(); // 0x16C (364)
		
		[ContainerField(368), LayoutImmutable, Blittable]
		public bool DrawDebugInfo { get; set; } // 0x170 (368)
		
		[ContainerField(369), LayoutImmutable, Blittable]
		public bool ColorGradingForceUpdateAlways { get; set; } // 0x171 (369)
		
		[ContainerField(370), LayoutImmutable, Blittable]
		public bool BloomBlurEnable { get; set; } // 0x172 (370)
		
		[ContainerField(371), LayoutImmutable, Blittable]
		public bool HdrBlurEnable { get; set; } // 0x173 (371)
		
		[ContainerField(372), LayoutImmutable, Blittable]
		public bool BlurBlendEnable { get; set; } // 0x174 (372)
		
		[ContainerField(373), LayoutImmutable, Blittable]
		public bool DownsampleAverageFromBloomEnable { get; set; } // 0x175 (373)
		
		[ContainerField(374), LayoutImmutable, Blittable]
		public bool FilmGrainEnable { get; set; } // 0x176 (374)
		
		[ContainerField(375), LayoutImmutable, Blittable]
		public bool Ldr16BitBloomEnable { get; set; } // 0x177 (375)
		
		[ContainerField(376), LayoutImmutable, Blittable]
		public bool DynamicAOEnable { get; set; } // 0x178 (376)
		
		[ContainerField(377), LayoutImmutable, Blittable]
		public bool DiffusionDofEnable { get; set; } // 0x179 (377)
		
		[ContainerField(378), LayoutImmutable, Blittable]
		public bool HbaoHalfResEnable { get; set; } // 0x17A (378)
		
		[ContainerField(379), LayoutImmutable, Blittable]
		public bool HbaoHalfResDepthEnable { get; set; } // 0x17B (379)
		
		[ContainerField(380), LayoutImmutable, Blittable]
		public bool HbaoVectorizedEnable { get; set; } // 0x17C (380)
		
		[ContainerField(381), LayoutImmutable, Blittable]
		public bool Ps3CompressedRenderTargetsEnable { get; set; } // 0x17D (381)
		
		[ContainerField(382), LayoutImmutable, Blittable]
		public bool HdrBloomEnable { get; set; } // 0x17E (382)
		
		[ContainerField(383), LayoutImmutable, Blittable]
		public bool FilmGrainRandomEnable { get; set; } // 0x17F (383)
		
		[ContainerField(384), LayoutImmutable, Blittable]
		public bool DirectExposureEnable { get; set; } // 0x180 (384)
		
		[ContainerField(385), LayoutImmutable, Blittable]
		public bool ExposureClampEnable { get; set; } // 0x181 (385)
		
		[ContainerField(386), LayoutImmutable, Blittable]
		public bool FilmGrainLinearFilteringEnable { get; set; } // 0x182 (386)
		
		[ContainerField(387), LayoutImmutable, Blittable]
		public bool HbaoBilateralBlurEnable { get; set; } // 0x183 (387)
		
		[ContainerField(388), LayoutImmutable, Blittable]
		public bool ColorGradingEnable { get; set; } // 0x184 (388)
		
		[ContainerField(389), LayoutImmutable, Blittable]
		public bool ColorTransformEnable { get; set; } // 0x185 (389)
		
		[ContainerField(390), LayoutImmutable, Blittable]
		public bool HbaoBilateralBlurCsEnable { get; set; } // 0x186 (390)
		
		[ContainerField(391), LayoutImmutable, Blittable]
		public bool HbaoTemporalFilterEnable { get; set; } // 0x187 (391)
		
		[ContainerField(392), LayoutImmutable, Blittable]
		public bool QuarterDownsamplingEnable { get; set; } // 0x188 (392)
		
		[ContainerField(393), LayoutImmutable, Blittable]
		public bool DrawDebugUserBrightnessLUT { get; set; } // 0x189 (393)
		
		[ContainerField(394), LayoutImmutable, Blittable]
		public bool BloomPyramidAttenuateEnable { get; set; } // 0x18A (394)
		
		[ContainerField(395), LayoutImmutable, Blittable]
		public bool DownsampleBeforeBlurEnable { get; set; } // 0x18B (395)
		
		[ContainerField(396), LayoutImmutable, Blittable]
		public bool HbaoGaussianBlurEnable { get; set; } // 0x18C (396)
		
		[ContainerField(397), LayoutImmutable, Blittable]
		public bool HbaoGaussianBlurHalfResEnable { get; set; } // 0x18D (397)
		
		[ContainerField(398), LayoutImmutable, Blittable]
		public bool BloomPyramidEnable { get; set; } // 0x18E (398)
		
		[ContainerField(399), LayoutImmutable, Blittable]
		public bool UserBrightnessLUTEnable { get; set; } // 0x18F (399)
		
		[ContainerField(400), LayoutImmutable, Blittable]
		public bool Ps3EdgeMlaaEnable { get; set; } // 0x190 (400)
		
		[ContainerField(401), LayoutImmutable, Blittable]
		public bool Ps3EdgeMlaaCopyOnly { get; set; } // 0x191 (401)
		
		[ContainerField(402), LayoutImmutable, Blittable]
		public bool Ps3EdgeMlaaShowEdges { get; set; } // 0x192 (402)
		
		[ContainerField(403), LayoutImmutable, Blittable]
		public bool Ps3EdgeMlaaRelativeEdgeDetection { get; set; } // 0x193 (403)
		
		[ContainerField(404), LayoutImmutable, Blittable]
		public bool Ps3EdgeMlaaGpuBlockEnable { get; set; } // 0x194 (404)
		
		[ContainerField(405), LayoutImmutable, Blittable]
		public bool Ps3BackBufferAsLdrTargetEnable { get; set; } // 0x195 (405)
		
		[ContainerField(406), LayoutImmutable, Blittable]
		public bool DownsampleLogAverageEnable { get; set; } // 0x196 (406)
		
		[ContainerField(407), LayoutImmutable, Blittable]
		public bool BloomQuarterResEnable { get; set; } // 0x197 (407)
		
		[ContainerField(408), LayoutImmutable, Blittable]
		public bool BloomEnable { get; set; } // 0x198 (408)
		
		[ContainerField(409), LayoutImmutable, Blittable]
		public bool LensScopeFilterEnable { get; set; } // 0x199 (409)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2298333740:
					Brightness = (Vec3) p_Value;
					break;

				case 1167733187:
					ForceBloomScale = (Vec3) p_Value;
					break;

				case 1913810643:
					ForceVignetteColor = (Vec4) p_Value;
					break;

				case 332991719:
					Contrast = (Vec3) p_Value;
					break;

				case 2572315705:
					Saturation = (Vec3) p_Value;
					break;

				case 698171103:
					FilmGrainTextureScale = (Vec2) p_Value;
					break;

				case 1933210934:
					ForceVignetteScale = (Vec2) p_Value;
					break;

				case 2297646077:
					FilmGrainColorScale = (Vec3) p_Value;
					break;

				case 2531442370:
					Ps3EdgeMlaaJobPriority = (uint) p_Value;
					break;

				case 559176571:
					BloomBlurIterationCount = (uint) p_Value;
					break;

				case 4013667205:
					DebugModeStep = (uint) p_Value;
					break;

				case 1641766607:
					BloomBlurFilter = (BlurFilter) Enum.ToObject(typeof(BlurFilter), p_Value);
					break;

				case 3302789155:
					LdrBloomRange = (float) p_Value;
					break;

				case 859984823:
					DebugMode = (PostProcessDebugMode) Enum.ToObject(typeof(PostProcessDebugMode), p_Value);
					break;

				case 2984710295:
					UserBrightnessMin = (float) p_Value;
					break;

				case 3718973230:
					UIBrightnessNorm = (float) p_Value;
					break;

				case 3203807475:
					Ps3EdgeMlaaJobCount = (uint) p_Value;
					break;

				case 3239984215:
					Ps3EdgeMlaaAbsoluteThreshold = (uint) p_Value;
					break;

				case 3447104137:
					BloomPyramidLevelCount = (uint) p_Value;
					break;

				case 3067494054:
					BloomPyramidFinalLevel = (uint) p_Value;
					break;

				case 2984710025:
					UserBrightnessMax = (float) p_Value;
					break;

				case 3175574289:
					UserBrightnessMulScale = (float) p_Value;
					break;

				case 2118006468:
					UserBrightnessAddScale = (float) p_Value;
					break;

				case 3334314874:
					DownsampleAverageStartMipmap = (uint) p_Value;
					break;

				case 1293096493:
					Ps3EdgeMlaaThresholdFactor = (uint) p_Value;
					break;

				case 2710541461:
					Ps3EdgeMlaaThresholdBase = (uint) p_Value;
					break;

				case 2148079284:
					Ps3TiledLdrMipmapCount = (uint) p_Value;
					break;

				case 1166085150:
					Ps3TiledFloatMipmapCount = (uint) p_Value;
					break;

				case 969308909:
					Ps3TiledBloomMipmapCount = (uint) p_Value;
					break;

				case 2138453560:
					HbaoGaussianBlurSize = (BlurFilter) Enum.ToObject(typeof(BlurFilter), p_Value);
					break;

				case 3271822859:
					ForceExposure = (float) p_Value;
					break;

				case 2796023760:
					ForceBlurAdd = (float) p_Value;
					break;

				case 1234693812:
					ForceDofEnable = (int) p_Value;
					break;

				case 773536698:
					ForceDofFocusDistance = (float) p_Value;
					break;

				case 1756776310:
					ForceDofNearDistanceScale = (float) p_Value;
					break;

				case 67724763:
					ForceDofFarDistanceScale = (float) p_Value;
					break;

				case 150495693:
					ForceDofScale = (float) p_Value;
					break;

				case 2506033663:
					ForceDofBlurFilterDeviation = (float) p_Value;
					break;

				case 3572552369:
					HbaoTemporalFilterMaxNumFrames = (uint) p_Value;
					break;

				case 2257925048:
					HbaoForceVendor = (int) p_Value;
					break;

				case 119843677:
					ForceVignetteExponent = (float) p_Value;
					break;

				case 1604474378:
					HbaoTemporalFilterThreshold = (float) p_Value;
					break;

				case 2295468203:
					ForceTonemapMethod = (int) p_Value;
					break;

				case 3798210365:
					LUTGammaR = (float) p_Value;
					break;

				case 3798210344:
					LUTGammaG = (float) p_Value;
					break;

				case 1408046968:
					HbaoTemporalFilterThreshold2 = (float) p_Value;
					break;

				case 3269666222:
					ForceChromostereopsisEnable = (int) p_Value;
					break;

				case 2740580066:
					ForceChromostereopsisOffset = (int) p_Value;
					break;

				case 3890443543:
					ForceChromostereopsisScale = (float) p_Value;
					break;

				case 2029554424:
					HbaoBilateralBlurRadius = (uint) p_Value;
					break;

				case 235090328:
					ForceMiddleGray = (float) p_Value;
					break;

				case 3798210349:
					LUTGammaB = (float) p_Value;
					break;

				case 2241568676:
					LUTGammaCurbOffset = (float) p_Value;
					break;

				case 1816381715:
					HbaoBilateralBlurSharpness = (float) p_Value;
					break;

				case 636926051:
					HbaoRandomTextureWidth = (uint) p_Value;
					break;

				case 567563134:
					LensScopeFilterColorScale = (float) p_Value;
					break;

				case 3117304240:
					HbaoStepCount = (float) p_Value;
					break;

				case 312723150:
					HbaoMaxFootprintRadius = (float) p_Value;
					break;

				case 199681341:
					HbaoDirCount = (float) p_Value;
					break;

				case 193458845:
					Hue = (float) p_Value;
					break;

				case 658038220:
					HbaoQuality = (uint) p_Value;
					break;

				case 3036070167:
					HbaoRandomDirVariationCount = (uint) p_Value;
					break;

				case 3422420331:
					ForceDiffusionDofPlaneInFocus = (float) p_Value;
					break;

				case 761872977:
					DiffusionDofLuminance = (float) p_Value;
					break;

				case 506800047:
					HbaoTemporalFilterDebugMode = (uint) p_Value;
					break;

				case 1045199206:
					ForceDiffusionDofAperture = (float) p_Value;
					break;

				case 3489263661:
					ForceDiffusionDofFocalLength = (float) p_Value;
					break;

				case 3208923969:
					DynamicAOMethod = (DynamicAOMethod) Enum.ToObject(typeof(DynamicAOMethod), p_Value);
					break;

				case 727053050:
					DrawDebugInfo = (bool) p_Value;
					break;

				case 1921841397:
					ColorGradingForceUpdateAlways = (bool) p_Value;
					break;

				case 1610321454:
					BloomBlurEnable = (bool) p_Value;
					break;

				case 1500746835:
					HdrBlurEnable = (bool) p_Value;
					break;

				case 2574022316:
					BlurBlendEnable = (bool) p_Value;
					break;

				case 1220691910:
					DownsampleAverageFromBloomEnable = (bool) p_Value;
					break;

				case 1422577945:
					FilmGrainEnable = (bool) p_Value;
					break;

				case 3738080069:
					Ldr16BitBloomEnable = (bool) p_Value;
					break;

				case 3514386399:
					DynamicAOEnable = (bool) p_Value;
					break;

				case 830589130:
					DiffusionDofEnable = (bool) p_Value;
					break;

				case 993231463:
					HbaoHalfResEnable = (bool) p_Value;
					break;

				case 3557347146:
					HbaoHalfResDepthEnable = (bool) p_Value;
					break;

				case 3608945675:
					HbaoVectorizedEnable = (bool) p_Value;
					break;

				case 2404166427:
					Ps3CompressedRenderTargetsEnable = (bool) p_Value;
					break;

				case 2031748249:
					HdrBloomEnable = (bool) p_Value;
					break;

				case 2060964098:
					FilmGrainRandomEnable = (bool) p_Value;
					break;

				case 883851546:
					DirectExposureEnable = (bool) p_Value;
					break;

				case 982365156:
					ExposureClampEnable = (bool) p_Value;
					break;

				case 751424836:
					FilmGrainLinearFilteringEnable = (bool) p_Value;
					break;

				case 1609473089:
					HbaoBilateralBlurEnable = (bool) p_Value;
					break;

				case 1205773449:
					ColorGradingEnable = (bool) p_Value;
					break;

				case 1095107349:
					ColorTransformEnable = (bool) p_Value;
					break;

				case 1787893969:
					HbaoBilateralBlurCsEnable = (bool) p_Value;
					break;

				case 569736956:
					HbaoTemporalFilterEnable = (bool) p_Value;
					break;

				case 2460614977:
					QuarterDownsamplingEnable = (bool) p_Value;
					break;

				case 4051730177:
					DrawDebugUserBrightnessLUT = (bool) p_Value;
					break;

				case 1368610322:
					BloomPyramidAttenuateEnable = (bool) p_Value;
					break;

				case 3596142400:
					DownsampleBeforeBlurEnable = (bool) p_Value;
					break;

				case 1146018076:
					HbaoGaussianBlurEnable = (bool) p_Value;
					break;

				case 2411002971:
					HbaoGaussianBlurHalfResEnable = (bool) p_Value;
					break;

				case 3107191069:
					BloomPyramidEnable = (bool) p_Value;
					break;

				case 2817018737:
					UserBrightnessLUTEnable = (bool) p_Value;
					break;

				case 3539499382:
					Ps3EdgeMlaaEnable = (bool) p_Value;
					break;

				case 550522886:
					Ps3EdgeMlaaCopyOnly = (bool) p_Value;
					break;

				case 1583173380:
					Ps3EdgeMlaaShowEdges = (bool) p_Value;
					break;

				case 1826009647:
					Ps3EdgeMlaaRelativeEdgeDetection = (bool) p_Value;
					break;

				case 507429533:
					Ps3EdgeMlaaGpuBlockEnable = (bool) p_Value;
					break;

				case 2463474662:
					Ps3BackBufferAsLdrTargetEnable = (bool) p_Value;
					break;

				case 3775842167:
					DownsampleLogAverageEnable = (bool) p_Value;
					break;

				case 1900886743:
					BloomQuarterResEnable = (bool) p_Value;
					break;

				case 931235495:
					BloomEnable = (bool) p_Value;
					break;

				case 1425211290:
					LensScopeFilterEnable = (bool) p_Value;
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
				case 2298333740:
					return Brightness;

				case 1167733187:
					return ForceBloomScale;

				case 1913810643:
					return ForceVignetteColor;

				case 332991719:
					return Contrast;

				case 2572315705:
					return Saturation;

				case 698171103:
					return FilmGrainTextureScale;

				case 1933210934:
					return ForceVignetteScale;

				case 2297646077:
					return FilmGrainColorScale;

				case 2531442370:
					return Ps3EdgeMlaaJobPriority;

				case 559176571:
					return BloomBlurIterationCount;

				case 4013667205:
					return DebugModeStep;

				case 1641766607:
					return BloomBlurFilter;

				case 3302789155:
					return LdrBloomRange;

				case 859984823:
					return DebugMode;

				case 2984710295:
					return UserBrightnessMin;

				case 3718973230:
					return UIBrightnessNorm;

				case 3203807475:
					return Ps3EdgeMlaaJobCount;

				case 3239984215:
					return Ps3EdgeMlaaAbsoluteThreshold;

				case 3447104137:
					return BloomPyramidLevelCount;

				case 3067494054:
					return BloomPyramidFinalLevel;

				case 2984710025:
					return UserBrightnessMax;

				case 3175574289:
					return UserBrightnessMulScale;

				case 2118006468:
					return UserBrightnessAddScale;

				case 3334314874:
					return DownsampleAverageStartMipmap;

				case 1293096493:
					return Ps3EdgeMlaaThresholdFactor;

				case 2710541461:
					return Ps3EdgeMlaaThresholdBase;

				case 2148079284:
					return Ps3TiledLdrMipmapCount;

				case 1166085150:
					return Ps3TiledFloatMipmapCount;

				case 969308909:
					return Ps3TiledBloomMipmapCount;

				case 2138453560:
					return HbaoGaussianBlurSize;

				case 3271822859:
					return ForceExposure;

				case 2796023760:
					return ForceBlurAdd;

				case 1234693812:
					return ForceDofEnable;

				case 773536698:
					return ForceDofFocusDistance;

				case 1756776310:
					return ForceDofNearDistanceScale;

				case 67724763:
					return ForceDofFarDistanceScale;

				case 150495693:
					return ForceDofScale;

				case 2506033663:
					return ForceDofBlurFilterDeviation;

				case 3572552369:
					return HbaoTemporalFilterMaxNumFrames;

				case 2257925048:
					return HbaoForceVendor;

				case 119843677:
					return ForceVignetteExponent;

				case 1604474378:
					return HbaoTemporalFilterThreshold;

				case 2295468203:
					return ForceTonemapMethod;

				case 3798210365:
					return LUTGammaR;

				case 3798210344:
					return LUTGammaG;

				case 1408046968:
					return HbaoTemporalFilterThreshold2;

				case 3269666222:
					return ForceChromostereopsisEnable;

				case 2740580066:
					return ForceChromostereopsisOffset;

				case 3890443543:
					return ForceChromostereopsisScale;

				case 2029554424:
					return HbaoBilateralBlurRadius;

				case 235090328:
					return ForceMiddleGray;

				case 3798210349:
					return LUTGammaB;

				case 2241568676:
					return LUTGammaCurbOffset;

				case 1816381715:
					return HbaoBilateralBlurSharpness;

				case 636926051:
					return HbaoRandomTextureWidth;

				case 567563134:
					return LensScopeFilterColorScale;

				case 3117304240:
					return HbaoStepCount;

				case 312723150:
					return HbaoMaxFootprintRadius;

				case 199681341:
					return HbaoDirCount;

				case 193458845:
					return Hue;

				case 658038220:
					return HbaoQuality;

				case 3036070167:
					return HbaoRandomDirVariationCount;

				case 3422420331:
					return ForceDiffusionDofPlaneInFocus;

				case 761872977:
					return DiffusionDofLuminance;

				case 506800047:
					return HbaoTemporalFilterDebugMode;

				case 1045199206:
					return ForceDiffusionDofAperture;

				case 3489263661:
					return ForceDiffusionDofFocalLength;

				case 3208923969:
					return DynamicAOMethod;

				case 727053050:
					return DrawDebugInfo;

				case 1921841397:
					return ColorGradingForceUpdateAlways;

				case 1610321454:
					return BloomBlurEnable;

				case 1500746835:
					return HdrBlurEnable;

				case 2574022316:
					return BlurBlendEnable;

				case 1220691910:
					return DownsampleAverageFromBloomEnable;

				case 1422577945:
					return FilmGrainEnable;

				case 3738080069:
					return Ldr16BitBloomEnable;

				case 3514386399:
					return DynamicAOEnable;

				case 830589130:
					return DiffusionDofEnable;

				case 993231463:
					return HbaoHalfResEnable;

				case 3557347146:
					return HbaoHalfResDepthEnable;

				case 3608945675:
					return HbaoVectorizedEnable;

				case 2404166427:
					return Ps3CompressedRenderTargetsEnable;

				case 2031748249:
					return HdrBloomEnable;

				case 2060964098:
					return FilmGrainRandomEnable;

				case 883851546:
					return DirectExposureEnable;

				case 982365156:
					return ExposureClampEnable;

				case 751424836:
					return FilmGrainLinearFilteringEnable;

				case 1609473089:
					return HbaoBilateralBlurEnable;

				case 1205773449:
					return ColorGradingEnable;

				case 1095107349:
					return ColorTransformEnable;

				case 1787893969:
					return HbaoBilateralBlurCsEnable;

				case 569736956:
					return HbaoTemporalFilterEnable;

				case 2460614977:
					return QuarterDownsamplingEnable;

				case 4051730177:
					return DrawDebugUserBrightnessLUT;

				case 1368610322:
					return BloomPyramidAttenuateEnable;

				case 3596142400:
					return DownsampleBeforeBlurEnable;

				case 1146018076:
					return HbaoGaussianBlurEnable;

				case 2411002971:
					return HbaoGaussianBlurHalfResEnable;

				case 3107191069:
					return BloomPyramidEnable;

				case 2817018737:
					return UserBrightnessLUTEnable;

				case 3539499382:
					return Ps3EdgeMlaaEnable;

				case 550522886:
					return Ps3EdgeMlaaCopyOnly;

				case 1583173380:
					return Ps3EdgeMlaaShowEdges;

				case 1826009647:
					return Ps3EdgeMlaaRelativeEdgeDetection;

				case 507429533:
					return Ps3EdgeMlaaGpuBlockEnable;

				case 2463474662:
					return Ps3BackBufferAsLdrTargetEnable;

				case 3775842167:
					return DownsampleLogAverageEnable;

				case 1900886743:
					return BloomQuarterResEnable;

				case 931235495:
					return BloomEnable;

				case 1425211290:
					return LensScopeFilterEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2298333740:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Brightness));

				case 1167733187:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceBloomScale));

				case 1913810643:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceVignetteColor));

				case 332991719:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Contrast));

				case 2572315705:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Saturation));

				case 698171103:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(FilmGrainTextureScale));

				case 1933210934:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceVignetteScale));

				case 2297646077:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(FilmGrainColorScale));

				case 2531442370:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3EdgeMlaaJobPriority));

				case 559176571:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(BloomBlurIterationCount));

				case 4013667205:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DebugModeStep));

				case 1641766607:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(BloomBlurFilter));

				case 3302789155:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(LdrBloomRange));

				case 859984823:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DebugMode));

				case 2984710295:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(UserBrightnessMin));

				case 3718973230:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(UIBrightnessNorm));

				case 3203807475:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3EdgeMlaaJobCount));

				case 3239984215:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3EdgeMlaaAbsoluteThreshold));

				case 3447104137:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(BloomPyramidLevelCount));

				case 3067494054:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(BloomPyramidFinalLevel));

				case 2984710025:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(UserBrightnessMax));

				case 3175574289:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(UserBrightnessMulScale));

				case 2118006468:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(UserBrightnessAddScale));

				case 3334314874:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DownsampleAverageStartMipmap));

				case 1293096493:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3EdgeMlaaThresholdFactor));

				case 2710541461:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3EdgeMlaaThresholdBase));

				case 2148079284:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3TiledLdrMipmapCount));

				case 1166085150:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3TiledFloatMipmapCount));

				case 969308909:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3TiledBloomMipmapCount));

				case 2138453560:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoGaussianBlurSize));

				case 3271822859:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceExposure));

				case 2796023760:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceBlurAdd));

				case 1234693812:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceDofEnable));

				case 773536698:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceDofFocusDistance));

				case 1756776310:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceDofNearDistanceScale));

				case 67724763:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceDofFarDistanceScale));

				case 150495693:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceDofScale));

				case 2506033663:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceDofBlurFilterDeviation));

				case 3572552369:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoTemporalFilterMaxNumFrames));

				case 2257925048:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoForceVendor));

				case 119843677:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceVignetteExponent));

				case 1604474378:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoTemporalFilterThreshold));

				case 2295468203:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceTonemapMethod));

				case 3798210365:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(LUTGammaR));

				case 3798210344:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(LUTGammaG));

				case 1408046968:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoTemporalFilterThreshold2));

				case 3269666222:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceChromostereopsisEnable));

				case 2740580066:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceChromostereopsisOffset));

				case 3890443543:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceChromostereopsisScale));

				case 2029554424:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoBilateralBlurRadius));

				case 235090328:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceMiddleGray));

				case 3798210349:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(LUTGammaB));

				case 2241568676:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(LUTGammaCurbOffset));

				case 1816381715:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoBilateralBlurSharpness));

				case 636926051:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoRandomTextureWidth));

				case 567563134:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(LensScopeFilterColorScale));

				case 3117304240:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoStepCount));

				case 312723150:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoMaxFootprintRadius));

				case 199681341:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoDirCount));

				case 193458845:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Hue));

				case 658038220:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoQuality));

				case 3036070167:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoRandomDirVariationCount));

				case 3422420331:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceDiffusionDofPlaneInFocus));

				case 761872977:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DiffusionDofLuminance));

				case 506800047:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoTemporalFilterDebugMode));

				case 1045199206:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceDiffusionDofAperture));

				case 3489263661:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ForceDiffusionDofFocalLength));

				case 3208923969:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DynamicAOMethod));

				case 727053050:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DrawDebugInfo));

				case 1921841397:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ColorGradingForceUpdateAlways));

				case 1610321454:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(BloomBlurEnable));

				case 1500746835:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HdrBlurEnable));

				case 2574022316:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(BlurBlendEnable));

				case 1220691910:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DownsampleAverageFromBloomEnable));

				case 1422577945:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(FilmGrainEnable));

				case 3738080069:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ldr16BitBloomEnable));

				case 3514386399:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DynamicAOEnable));

				case 830589130:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DiffusionDofEnable));

				case 993231463:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoHalfResEnable));

				case 3557347146:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoHalfResDepthEnable));

				case 3608945675:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoVectorizedEnable));

				case 2404166427:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3CompressedRenderTargetsEnable));

				case 2031748249:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HdrBloomEnable));

				case 2060964098:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(FilmGrainRandomEnable));

				case 883851546:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DirectExposureEnable));

				case 982365156:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ExposureClampEnable));

				case 751424836:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(FilmGrainLinearFilteringEnable));

				case 1609473089:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoBilateralBlurEnable));

				case 1205773449:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ColorGradingEnable));

				case 1095107349:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(ColorTransformEnable));

				case 1787893969:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoBilateralBlurCsEnable));

				case 569736956:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoTemporalFilterEnable));

				case 2460614977:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(QuarterDownsamplingEnable));

				case 4051730177:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DrawDebugUserBrightnessLUT));

				case 1368610322:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(BloomPyramidAttenuateEnable));

				case 3596142400:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DownsampleBeforeBlurEnable));

				case 1146018076:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoGaussianBlurEnable));

				case 2411002971:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(HbaoGaussianBlurHalfResEnable));

				case 3107191069:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(BloomPyramidEnable));

				case 2817018737:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(UserBrightnessLUTEnable));

				case 3539499382:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3EdgeMlaaEnable));

				case 550522886:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3EdgeMlaaCopyOnly));

				case 1583173380:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3EdgeMlaaShowEdges));

				case 1826009647:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3EdgeMlaaRelativeEdgeDetection));

				case 507429533:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3EdgeMlaaGpuBlockEnable));

				case 2463474662:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(Ps3BackBufferAsLdrTargetEnable));

				case 3775842167:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(DownsampleLogAverageEnable));

				case 1900886743:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(BloomQuarterResEnable));

				case 931235495:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(BloomEnable));

				case 1425211290:
					return typeof(GlobalPostProcessSettings).GetProperty(nameof(LensScopeFilterEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
