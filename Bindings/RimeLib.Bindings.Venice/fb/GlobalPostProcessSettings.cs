///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16)]
	public class GlobalPostProcessSettings : 
		DataContainer
	{
		protected Vec3 m_Brightness = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2298333740)]
		public Vec3 Brightness { get { return m_Brightness; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Brightness), this, m_Brightness, value)) m_Brightness = value; } } // 0x10 (16)
		
		protected Vec3 m_ForceBloomScale = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(1167733187)]
		public Vec3 ForceBloomScale { get { return m_ForceBloomScale; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceBloomScale), this, m_ForceBloomScale, value)) m_ForceBloomScale = value; } } // 0x20 (32)
		
		protected Vec4 m_ForceVignetteColor = new Vec4();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(1913810643)]
		public Vec4 ForceVignetteColor { get { return m_ForceVignetteColor; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceVignetteColor), this, m_ForceVignetteColor, value)) m_ForceVignetteColor = value; } } // 0x30 (48)
		
		protected Vec3 m_Contrast = new Vec3();
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(332991719)]
		public Vec3 Contrast { get { return m_Contrast; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Contrast), this, m_Contrast, value)) m_Contrast = value; } } // 0x40 (64)
		
		protected Vec3 m_Saturation = new Vec3();
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2572315705)]
		public Vec3 Saturation { get { return m_Saturation; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Saturation), this, m_Saturation, value)) m_Saturation = value; } } // 0x50 (80)
		
		protected Vec2 m_FilmGrainTextureScale = new Vec2();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(698171103)]
		public Vec2 FilmGrainTextureScale { get { return m_FilmGrainTextureScale; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(FilmGrainTextureScale), this, m_FilmGrainTextureScale, value)) m_FilmGrainTextureScale = value; } } // 0x60 (96)
		
		protected Vec2 m_ForceVignetteScale = new Vec2();
		[ContainerField(104), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(1933210934)]
		public Vec2 ForceVignetteScale { get { return m_ForceVignetteScale; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceVignetteScale), this, m_ForceVignetteScale, value)) m_ForceVignetteScale = value; } } // 0x68 (104)
		
		protected Vec3 m_FilmGrainColorScale = new Vec3();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2297646077)]
		public Vec3 FilmGrainColorScale { get { return m_FilmGrainColorScale; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(FilmGrainColorScale), this, m_FilmGrainColorScale, value)) m_FilmGrainColorScale = value; } } // 0x70 (112)
		
		protected uint m_Ps3EdgeMlaaJobPriority = new uint();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(2531442370)]
		public uint Ps3EdgeMlaaJobPriority { get { return m_Ps3EdgeMlaaJobPriority; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3EdgeMlaaJobPriority), this, m_Ps3EdgeMlaaJobPriority, value)) m_Ps3EdgeMlaaJobPriority = value; } } // 0x80 (128)
		
		protected uint m_BloomBlurIterationCount = new uint();
		[ContainerField(132), LayoutImmutable, Blittable, ContainerFieldNameHash(559176571)]
		public uint BloomBlurIterationCount { get { return m_BloomBlurIterationCount; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(BloomBlurIterationCount), this, m_BloomBlurIterationCount, value)) m_BloomBlurIterationCount = value; } } // 0x84 (132)
		
		protected uint m_DebugModeStep = new uint();
		[ContainerField(136), LayoutImmutable, Blittable, ContainerFieldNameHash(4013667205)]
		public uint DebugModeStep { get { return m_DebugModeStep; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DebugModeStep), this, m_DebugModeStep, value)) m_DebugModeStep = value; } } // 0x88 (136)
		
		protected BlurFilter m_BloomBlurFilter = new BlurFilter();
		[ContainerField(140), ContainerFieldNameHash(1641766607)]
		public BlurFilter BloomBlurFilter { get { return m_BloomBlurFilter; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(BloomBlurFilter), this, m_BloomBlurFilter, value)) m_BloomBlurFilter = value; } } // 0x8C (140)
		
		protected float m_LdrBloomRange = new float();
		[ContainerField(144), LayoutImmutable, Blittable, ContainerFieldNameHash(3302789155)]
		public float LdrBloomRange { get { return m_LdrBloomRange; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(LdrBloomRange), this, m_LdrBloomRange, value)) m_LdrBloomRange = value; } } // 0x90 (144)
		
		protected PostProcessDebugMode m_DebugMode = new PostProcessDebugMode();
		[ContainerField(148), ContainerFieldNameHash(859984823)]
		public PostProcessDebugMode DebugMode { get { return m_DebugMode; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DebugMode), this, m_DebugMode, value)) m_DebugMode = value; } } // 0x94 (148)
		
		protected float m_UserBrightnessMin = new float();
		[ContainerField(152), LayoutImmutable, Blittable, ContainerFieldNameHash(2984710295)]
		public float UserBrightnessMin { get { return m_UserBrightnessMin; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(UserBrightnessMin), this, m_UserBrightnessMin, value)) m_UserBrightnessMin = value; } } // 0x98 (152)
		
		protected float m_UIBrightnessNorm = new float();
		[ContainerField(156), LayoutImmutable, Blittable, ContainerFieldNameHash(3718973230)]
		public float UIBrightnessNorm { get { return m_UIBrightnessNorm; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(UIBrightnessNorm), this, m_UIBrightnessNorm, value)) m_UIBrightnessNorm = value; } } // 0x9C (156)
		
		protected uint m_Ps3EdgeMlaaJobCount = new uint();
		[ContainerField(160), LayoutImmutable, Blittable, ContainerFieldNameHash(3203807475)]
		public uint Ps3EdgeMlaaJobCount { get { return m_Ps3EdgeMlaaJobCount; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3EdgeMlaaJobCount), this, m_Ps3EdgeMlaaJobCount, value)) m_Ps3EdgeMlaaJobCount = value; } } // 0xA0 (160)
		
		protected uint m_Ps3EdgeMlaaAbsoluteThreshold = new uint();
		[ContainerField(164), LayoutImmutable, Blittable, ContainerFieldNameHash(3239984215)]
		public uint Ps3EdgeMlaaAbsoluteThreshold { get { return m_Ps3EdgeMlaaAbsoluteThreshold; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3EdgeMlaaAbsoluteThreshold), this, m_Ps3EdgeMlaaAbsoluteThreshold, value)) m_Ps3EdgeMlaaAbsoluteThreshold = value; } } // 0xA4 (164)
		
		protected uint m_BloomPyramidLevelCount = new uint();
		[ContainerField(168), LayoutImmutable, Blittable, ContainerFieldNameHash(3447104137)]
		public uint BloomPyramidLevelCount { get { return m_BloomPyramidLevelCount; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(BloomPyramidLevelCount), this, m_BloomPyramidLevelCount, value)) m_BloomPyramidLevelCount = value; } } // 0xA8 (168)
		
		protected uint m_BloomPyramidFinalLevel = new uint();
		[ContainerField(172), LayoutImmutable, Blittable, ContainerFieldNameHash(3067494054)]
		public uint BloomPyramidFinalLevel { get { return m_BloomPyramidFinalLevel; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(BloomPyramidFinalLevel), this, m_BloomPyramidFinalLevel, value)) m_BloomPyramidFinalLevel = value; } } // 0xAC (172)
		
		protected float m_UserBrightnessMax = new float();
		[ContainerField(176), LayoutImmutable, Blittable, ContainerFieldNameHash(2984710025)]
		public float UserBrightnessMax { get { return m_UserBrightnessMax; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(UserBrightnessMax), this, m_UserBrightnessMax, value)) m_UserBrightnessMax = value; } } // 0xB0 (176)
		
		protected float m_UserBrightnessMulScale = new float();
		[ContainerField(180), LayoutImmutable, Blittable, ContainerFieldNameHash(3175574289)]
		public float UserBrightnessMulScale { get { return m_UserBrightnessMulScale; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(UserBrightnessMulScale), this, m_UserBrightnessMulScale, value)) m_UserBrightnessMulScale = value; } } // 0xB4 (180)
		
		protected float m_UserBrightnessAddScale = new float();
		[ContainerField(184), LayoutImmutable, Blittable, ContainerFieldNameHash(2118006468)]
		public float UserBrightnessAddScale { get { return m_UserBrightnessAddScale; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(UserBrightnessAddScale), this, m_UserBrightnessAddScale, value)) m_UserBrightnessAddScale = value; } } // 0xB8 (184)
		
		protected uint m_DownsampleAverageStartMipmap = new uint();
		[ContainerField(188), LayoutImmutable, Blittable, ContainerFieldNameHash(3334314874)]
		public uint DownsampleAverageStartMipmap { get { return m_DownsampleAverageStartMipmap; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DownsampleAverageStartMipmap), this, m_DownsampleAverageStartMipmap, value)) m_DownsampleAverageStartMipmap = value; } } // 0xBC (188)
		
		protected uint m_Ps3EdgeMlaaThresholdFactor = new uint();
		[ContainerField(192), LayoutImmutable, Blittable, ContainerFieldNameHash(1293096493)]
		public uint Ps3EdgeMlaaThresholdFactor { get { return m_Ps3EdgeMlaaThresholdFactor; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3EdgeMlaaThresholdFactor), this, m_Ps3EdgeMlaaThresholdFactor, value)) m_Ps3EdgeMlaaThresholdFactor = value; } } // 0xC0 (192)
		
		protected uint m_Ps3EdgeMlaaThresholdBase = new uint();
		[ContainerField(196), LayoutImmutable, Blittable, ContainerFieldNameHash(2710541461)]
		public uint Ps3EdgeMlaaThresholdBase { get { return m_Ps3EdgeMlaaThresholdBase; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3EdgeMlaaThresholdBase), this, m_Ps3EdgeMlaaThresholdBase, value)) m_Ps3EdgeMlaaThresholdBase = value; } } // 0xC4 (196)
		
		protected uint m_Ps3TiledLdrMipmapCount = new uint();
		[ContainerField(200), LayoutImmutable, Blittable, ContainerFieldNameHash(2148079284)]
		public uint Ps3TiledLdrMipmapCount { get { return m_Ps3TiledLdrMipmapCount; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3TiledLdrMipmapCount), this, m_Ps3TiledLdrMipmapCount, value)) m_Ps3TiledLdrMipmapCount = value; } } // 0xC8 (200)
		
		protected uint m_Ps3TiledFloatMipmapCount = new uint();
		[ContainerField(204), LayoutImmutable, Blittable, ContainerFieldNameHash(1166085150)]
		public uint Ps3TiledFloatMipmapCount { get { return m_Ps3TiledFloatMipmapCount; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3TiledFloatMipmapCount), this, m_Ps3TiledFloatMipmapCount, value)) m_Ps3TiledFloatMipmapCount = value; } } // 0xCC (204)
		
		protected uint m_Ps3TiledBloomMipmapCount = new uint();
		[ContainerField(208), LayoutImmutable, Blittable, ContainerFieldNameHash(969308909)]
		public uint Ps3TiledBloomMipmapCount { get { return m_Ps3TiledBloomMipmapCount; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3TiledBloomMipmapCount), this, m_Ps3TiledBloomMipmapCount, value)) m_Ps3TiledBloomMipmapCount = value; } } // 0xD0 (208)
		
		protected BlurFilter m_HbaoGaussianBlurSize = new BlurFilter();
		[ContainerField(212), ContainerFieldNameHash(2138453560)]
		public BlurFilter HbaoGaussianBlurSize { get { return m_HbaoGaussianBlurSize; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoGaussianBlurSize), this, m_HbaoGaussianBlurSize, value)) m_HbaoGaussianBlurSize = value; } } // 0xD4 (212)
		
		protected float m_ForceExposure = new float();
		[ContainerField(216), LayoutImmutable, Blittable, ContainerFieldNameHash(3271822859)]
		public float ForceExposure { get { return m_ForceExposure; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceExposure), this, m_ForceExposure, value)) m_ForceExposure = value; } } // 0xD8 (216)
		
		protected float m_ForceBlurAdd = new float();
		[ContainerField(220), LayoutImmutable, Blittable, ContainerFieldNameHash(2796023760)]
		public float ForceBlurAdd { get { return m_ForceBlurAdd; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceBlurAdd), this, m_ForceBlurAdd, value)) m_ForceBlurAdd = value; } } // 0xDC (220)
		
		protected int m_ForceDofEnable = new int();
		[ContainerField(224), LayoutImmutable, Blittable, ContainerFieldNameHash(1234693812)]
		public int ForceDofEnable { get { return m_ForceDofEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceDofEnable), this, m_ForceDofEnable, value)) m_ForceDofEnable = value; } } // 0xE0 (224)
		
		protected float m_ForceDofFocusDistance = new float();
		[ContainerField(228), LayoutImmutable, Blittable, ContainerFieldNameHash(773536698)]
		public float ForceDofFocusDistance { get { return m_ForceDofFocusDistance; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceDofFocusDistance), this, m_ForceDofFocusDistance, value)) m_ForceDofFocusDistance = value; } } // 0xE4 (228)
		
		protected float m_ForceDofNearDistanceScale = new float();
		[ContainerField(232), LayoutImmutable, Blittable, ContainerFieldNameHash(1756776310)]
		public float ForceDofNearDistanceScale { get { return m_ForceDofNearDistanceScale; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceDofNearDistanceScale), this, m_ForceDofNearDistanceScale, value)) m_ForceDofNearDistanceScale = value; } } // 0xE8 (232)
		
		protected float m_ForceDofFarDistanceScale = new float();
		[ContainerField(236), LayoutImmutable, Blittable, ContainerFieldNameHash(67724763)]
		public float ForceDofFarDistanceScale { get { return m_ForceDofFarDistanceScale; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceDofFarDistanceScale), this, m_ForceDofFarDistanceScale, value)) m_ForceDofFarDistanceScale = value; } } // 0xEC (236)
		
		protected float m_ForceDofScale = new float();
		[ContainerField(240), LayoutImmutable, Blittable, ContainerFieldNameHash(150495693)]
		public float ForceDofScale { get { return m_ForceDofScale; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceDofScale), this, m_ForceDofScale, value)) m_ForceDofScale = value; } } // 0xF0 (240)
		
		protected float m_ForceDofBlurFilterDeviation = new float();
		[ContainerField(244), LayoutImmutable, Blittable, ContainerFieldNameHash(2506033663)]
		public float ForceDofBlurFilterDeviation { get { return m_ForceDofBlurFilterDeviation; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceDofBlurFilterDeviation), this, m_ForceDofBlurFilterDeviation, value)) m_ForceDofBlurFilterDeviation = value; } } // 0xF4 (244)
		
		protected uint m_HbaoTemporalFilterMaxNumFrames = new uint();
		[ContainerField(248), LayoutImmutable, Blittable, ContainerFieldNameHash(3572552369)]
		public uint HbaoTemporalFilterMaxNumFrames { get { return m_HbaoTemporalFilterMaxNumFrames; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoTemporalFilterMaxNumFrames), this, m_HbaoTemporalFilterMaxNumFrames, value)) m_HbaoTemporalFilterMaxNumFrames = value; } } // 0xF8 (248)
		
		protected int m_HbaoForceVendor = new int();
		[ContainerField(252), LayoutImmutable, Blittable, ContainerFieldNameHash(2257925048)]
		public int HbaoForceVendor { get { return m_HbaoForceVendor; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoForceVendor), this, m_HbaoForceVendor, value)) m_HbaoForceVendor = value; } } // 0xFC (252)
		
		protected float m_ForceVignetteExponent = new float();
		[ContainerField(256), LayoutImmutable, Blittable, ContainerFieldNameHash(119843677)]
		public float ForceVignetteExponent { get { return m_ForceVignetteExponent; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceVignetteExponent), this, m_ForceVignetteExponent, value)) m_ForceVignetteExponent = value; } } // 0x100 (256)
		
		protected float m_HbaoTemporalFilterThreshold = new float();
		[ContainerField(260), LayoutImmutable, Blittable, ContainerFieldNameHash(1604474378)]
		public float HbaoTemporalFilterThreshold { get { return m_HbaoTemporalFilterThreshold; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoTemporalFilterThreshold), this, m_HbaoTemporalFilterThreshold, value)) m_HbaoTemporalFilterThreshold = value; } } // 0x104 (260)
		
		protected int m_ForceTonemapMethod = new int();
		[ContainerField(264), LayoutImmutable, Blittable, ContainerFieldNameHash(2295468203)]
		public int ForceTonemapMethod { get { return m_ForceTonemapMethod; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceTonemapMethod), this, m_ForceTonemapMethod, value)) m_ForceTonemapMethod = value; } } // 0x108 (264)
		
		protected float m_LUTGammaR = new float();
		[ContainerField(268), LayoutImmutable, Blittable, ContainerFieldNameHash(3798210365)]
		public float LUTGammaR { get { return m_LUTGammaR; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(LUTGammaR), this, m_LUTGammaR, value)) m_LUTGammaR = value; } } // 0x10C (268)
		
		protected float m_LUTGammaG = new float();
		[ContainerField(272), LayoutImmutable, Blittable, ContainerFieldNameHash(3798210344)]
		public float LUTGammaG { get { return m_LUTGammaG; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(LUTGammaG), this, m_LUTGammaG, value)) m_LUTGammaG = value; } } // 0x110 (272)
		
		protected float m_HbaoTemporalFilterThreshold2 = new float();
		[ContainerField(276), LayoutImmutable, Blittable, ContainerFieldNameHash(1408046968)]
		public float HbaoTemporalFilterThreshold2 { get { return m_HbaoTemporalFilterThreshold2; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoTemporalFilterThreshold2), this, m_HbaoTemporalFilterThreshold2, value)) m_HbaoTemporalFilterThreshold2 = value; } } // 0x114 (276)
		
		protected int m_ForceChromostereopsisEnable = new int();
		[ContainerField(280), LayoutImmutable, Blittable, ContainerFieldNameHash(3269666222)]
		public int ForceChromostereopsisEnable { get { return m_ForceChromostereopsisEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceChromostereopsisEnable), this, m_ForceChromostereopsisEnable, value)) m_ForceChromostereopsisEnable = value; } } // 0x118 (280)
		
		protected int m_ForceChromostereopsisOffset = new int();
		[ContainerField(284), LayoutImmutable, Blittable, ContainerFieldNameHash(2740580066)]
		public int ForceChromostereopsisOffset { get { return m_ForceChromostereopsisOffset; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceChromostereopsisOffset), this, m_ForceChromostereopsisOffset, value)) m_ForceChromostereopsisOffset = value; } } // 0x11C (284)
		
		protected float m_ForceChromostereopsisScale = new float();
		[ContainerField(288), LayoutImmutable, Blittable, ContainerFieldNameHash(3890443543)]
		public float ForceChromostereopsisScale { get { return m_ForceChromostereopsisScale; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceChromostereopsisScale), this, m_ForceChromostereopsisScale, value)) m_ForceChromostereopsisScale = value; } } // 0x120 (288)
		
		protected uint m_HbaoBilateralBlurRadius = new uint();
		[ContainerField(292), LayoutImmutable, Blittable, ContainerFieldNameHash(2029554424)]
		public uint HbaoBilateralBlurRadius { get { return m_HbaoBilateralBlurRadius; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoBilateralBlurRadius), this, m_HbaoBilateralBlurRadius, value)) m_HbaoBilateralBlurRadius = value; } } // 0x124 (292)
		
		protected float m_ForceMiddleGray = new float();
		[ContainerField(296), LayoutImmutable, Blittable, ContainerFieldNameHash(235090328)]
		public float ForceMiddleGray { get { return m_ForceMiddleGray; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceMiddleGray), this, m_ForceMiddleGray, value)) m_ForceMiddleGray = value; } } // 0x128 (296)
		
		protected float m_LUTGammaB = new float();
		[ContainerField(300), LayoutImmutable, Blittable, ContainerFieldNameHash(3798210349)]
		public float LUTGammaB { get { return m_LUTGammaB; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(LUTGammaB), this, m_LUTGammaB, value)) m_LUTGammaB = value; } } // 0x12C (300)
		
		protected float m_LUTGammaCurbOffset = new float();
		[ContainerField(304), LayoutImmutable, Blittable, ContainerFieldNameHash(2241568676)]
		public float LUTGammaCurbOffset { get { return m_LUTGammaCurbOffset; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(LUTGammaCurbOffset), this, m_LUTGammaCurbOffset, value)) m_LUTGammaCurbOffset = value; } } // 0x130 (304)
		
		protected float m_HbaoBilateralBlurSharpness = new float();
		[ContainerField(308), LayoutImmutable, Blittable, ContainerFieldNameHash(1816381715)]
		public float HbaoBilateralBlurSharpness { get { return m_HbaoBilateralBlurSharpness; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoBilateralBlurSharpness), this, m_HbaoBilateralBlurSharpness, value)) m_HbaoBilateralBlurSharpness = value; } } // 0x134 (308)
		
		protected uint m_HbaoRandomTextureWidth = new uint();
		[ContainerField(312), LayoutImmutable, Blittable, ContainerFieldNameHash(636926051)]
		public uint HbaoRandomTextureWidth { get { return m_HbaoRandomTextureWidth; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoRandomTextureWidth), this, m_HbaoRandomTextureWidth, value)) m_HbaoRandomTextureWidth = value; } } // 0x138 (312)
		
		protected float m_LensScopeFilterColorScale = new float();
		[ContainerField(316), LayoutImmutable, Blittable, ContainerFieldNameHash(567563134)]
		public float LensScopeFilterColorScale { get { return m_LensScopeFilterColorScale; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(LensScopeFilterColorScale), this, m_LensScopeFilterColorScale, value)) m_LensScopeFilterColorScale = value; } } // 0x13C (316)
		
		protected float m_HbaoStepCount = new float();
		[ContainerField(320), LayoutImmutable, Blittable, ContainerFieldNameHash(3117304240)]
		public float HbaoStepCount { get { return m_HbaoStepCount; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoStepCount), this, m_HbaoStepCount, value)) m_HbaoStepCount = value; } } // 0x140 (320)
		
		protected float m_HbaoMaxFootprintRadius = new float();
		[ContainerField(324), LayoutImmutable, Blittable, ContainerFieldNameHash(312723150)]
		public float HbaoMaxFootprintRadius { get { return m_HbaoMaxFootprintRadius; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoMaxFootprintRadius), this, m_HbaoMaxFootprintRadius, value)) m_HbaoMaxFootprintRadius = value; } } // 0x144 (324)
		
		protected float m_HbaoDirCount = new float();
		[ContainerField(328), LayoutImmutable, Blittable, ContainerFieldNameHash(199681341)]
		public float HbaoDirCount { get { return m_HbaoDirCount; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoDirCount), this, m_HbaoDirCount, value)) m_HbaoDirCount = value; } } // 0x148 (328)
		
		protected float m_Hue = new float();
		[ContainerField(332), LayoutImmutable, Blittable, ContainerFieldNameHash(193458845)]
		public float Hue { get { return m_Hue; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Hue), this, m_Hue, value)) m_Hue = value; } } // 0x14C (332)
		
		protected uint m_HbaoQuality = new uint();
		[ContainerField(336), LayoutImmutable, Blittable, ContainerFieldNameHash(658038220)]
		public uint HbaoQuality { get { return m_HbaoQuality; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoQuality), this, m_HbaoQuality, value)) m_HbaoQuality = value; } } // 0x150 (336)
		
		protected uint m_HbaoRandomDirVariationCount = new uint();
		[ContainerField(340), LayoutImmutable, Blittable, ContainerFieldNameHash(3036070167)]
		public uint HbaoRandomDirVariationCount { get { return m_HbaoRandomDirVariationCount; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoRandomDirVariationCount), this, m_HbaoRandomDirVariationCount, value)) m_HbaoRandomDirVariationCount = value; } } // 0x154 (340)
		
		protected float m_ForceDiffusionDofPlaneInFocus = new float();
		[ContainerField(344), LayoutImmutable, Blittable, ContainerFieldNameHash(3422420331)]
		public float ForceDiffusionDofPlaneInFocus { get { return m_ForceDiffusionDofPlaneInFocus; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceDiffusionDofPlaneInFocus), this, m_ForceDiffusionDofPlaneInFocus, value)) m_ForceDiffusionDofPlaneInFocus = value; } } // 0x158 (344)
		
		protected float m_DiffusionDofLuminance = new float();
		[ContainerField(348), LayoutImmutable, Blittable, ContainerFieldNameHash(761872977)]
		public float DiffusionDofLuminance { get { return m_DiffusionDofLuminance; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DiffusionDofLuminance), this, m_DiffusionDofLuminance, value)) m_DiffusionDofLuminance = value; } } // 0x15C (348)
		
		protected uint m_HbaoTemporalFilterDebugMode = new uint();
		[ContainerField(352), LayoutImmutable, Blittable, ContainerFieldNameHash(506800047)]
		public uint HbaoTemporalFilterDebugMode { get { return m_HbaoTemporalFilterDebugMode; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoTemporalFilterDebugMode), this, m_HbaoTemporalFilterDebugMode, value)) m_HbaoTemporalFilterDebugMode = value; } } // 0x160 (352)
		
		protected float m_ForceDiffusionDofAperture = new float();
		[ContainerField(356), LayoutImmutable, Blittable, ContainerFieldNameHash(1045199206)]
		public float ForceDiffusionDofAperture { get { return m_ForceDiffusionDofAperture; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceDiffusionDofAperture), this, m_ForceDiffusionDofAperture, value)) m_ForceDiffusionDofAperture = value; } } // 0x164 (356)
		
		protected float m_ForceDiffusionDofFocalLength = new float();
		[ContainerField(360), LayoutImmutable, Blittable, ContainerFieldNameHash(3489263661)]
		public float ForceDiffusionDofFocalLength { get { return m_ForceDiffusionDofFocalLength; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ForceDiffusionDofFocalLength), this, m_ForceDiffusionDofFocalLength, value)) m_ForceDiffusionDofFocalLength = value; } } // 0x168 (360)
		
		protected DynamicAOMethod m_DynamicAOMethod = new DynamicAOMethod();
		[ContainerField(364), ContainerFieldNameHash(3208923969)]
		public DynamicAOMethod DynamicAOMethod { get { return m_DynamicAOMethod; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DynamicAOMethod), this, m_DynamicAOMethod, value)) m_DynamicAOMethod = value; } } // 0x16C (364)
		
		protected bool m_DrawDebugInfo = new bool();
		[ContainerField(368), LayoutImmutable, Blittable, ContainerFieldNameHash(727053050)]
		public bool DrawDebugInfo { get { return m_DrawDebugInfo; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DrawDebugInfo), this, m_DrawDebugInfo, value)) m_DrawDebugInfo = value; } } // 0x170 (368)
		
		protected bool m_ColorGradingForceUpdateAlways = new bool();
		[ContainerField(369), LayoutImmutable, Blittable, ContainerFieldNameHash(1921841397)]
		public bool ColorGradingForceUpdateAlways { get { return m_ColorGradingForceUpdateAlways; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ColorGradingForceUpdateAlways), this, m_ColorGradingForceUpdateAlways, value)) m_ColorGradingForceUpdateAlways = value; } } // 0x171 (369)
		
		protected bool m_BloomBlurEnable = new bool();
		[ContainerField(370), LayoutImmutable, Blittable, ContainerFieldNameHash(1610321454)]
		public bool BloomBlurEnable { get { return m_BloomBlurEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(BloomBlurEnable), this, m_BloomBlurEnable, value)) m_BloomBlurEnable = value; } } // 0x172 (370)
		
		protected bool m_HdrBlurEnable = new bool();
		[ContainerField(371), LayoutImmutable, Blittable, ContainerFieldNameHash(1500746835)]
		public bool HdrBlurEnable { get { return m_HdrBlurEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HdrBlurEnable), this, m_HdrBlurEnable, value)) m_HdrBlurEnable = value; } } // 0x173 (371)
		
		protected bool m_BlurBlendEnable = new bool();
		[ContainerField(372), LayoutImmutable, Blittable, ContainerFieldNameHash(2574022316)]
		public bool BlurBlendEnable { get { return m_BlurBlendEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(BlurBlendEnable), this, m_BlurBlendEnable, value)) m_BlurBlendEnable = value; } } // 0x174 (372)
		
		protected bool m_DownsampleAverageFromBloomEnable = new bool();
		[ContainerField(373), LayoutImmutable, Blittable, ContainerFieldNameHash(1220691910)]
		public bool DownsampleAverageFromBloomEnable { get { return m_DownsampleAverageFromBloomEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DownsampleAverageFromBloomEnable), this, m_DownsampleAverageFromBloomEnable, value)) m_DownsampleAverageFromBloomEnable = value; } } // 0x175 (373)
		
		protected bool m_FilmGrainEnable = new bool();
		[ContainerField(374), LayoutImmutable, Blittable, ContainerFieldNameHash(1422577945)]
		public bool FilmGrainEnable { get { return m_FilmGrainEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(FilmGrainEnable), this, m_FilmGrainEnable, value)) m_FilmGrainEnable = value; } } // 0x176 (374)
		
		protected bool m_Ldr16BitBloomEnable = new bool();
		[ContainerField(375), LayoutImmutable, Blittable, ContainerFieldNameHash(3738080069)]
		public bool Ldr16BitBloomEnable { get { return m_Ldr16BitBloomEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ldr16BitBloomEnable), this, m_Ldr16BitBloomEnable, value)) m_Ldr16BitBloomEnable = value; } } // 0x177 (375)
		
		protected bool m_DynamicAOEnable = new bool();
		[ContainerField(376), LayoutImmutable, Blittable, ContainerFieldNameHash(3514386399)]
		public bool DynamicAOEnable { get { return m_DynamicAOEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DynamicAOEnable), this, m_DynamicAOEnable, value)) m_DynamicAOEnable = value; } } // 0x178 (376)
		
		protected bool m_DiffusionDofEnable = new bool();
		[ContainerField(377), LayoutImmutable, Blittable, ContainerFieldNameHash(830589130)]
		public bool DiffusionDofEnable { get { return m_DiffusionDofEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DiffusionDofEnable), this, m_DiffusionDofEnable, value)) m_DiffusionDofEnable = value; } } // 0x179 (377)
		
		protected bool m_HbaoHalfResEnable = new bool();
		[ContainerField(378), LayoutImmutable, Blittable, ContainerFieldNameHash(993231463)]
		public bool HbaoHalfResEnable { get { return m_HbaoHalfResEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoHalfResEnable), this, m_HbaoHalfResEnable, value)) m_HbaoHalfResEnable = value; } } // 0x17A (378)
		
		protected bool m_HbaoHalfResDepthEnable = new bool();
		[ContainerField(379), LayoutImmutable, Blittable, ContainerFieldNameHash(3557347146)]
		public bool HbaoHalfResDepthEnable { get { return m_HbaoHalfResDepthEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoHalfResDepthEnable), this, m_HbaoHalfResDepthEnable, value)) m_HbaoHalfResDepthEnable = value; } } // 0x17B (379)
		
		protected bool m_HbaoVectorizedEnable = new bool();
		[ContainerField(380), LayoutImmutable, Blittable, ContainerFieldNameHash(3608945675)]
		public bool HbaoVectorizedEnable { get { return m_HbaoVectorizedEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoVectorizedEnable), this, m_HbaoVectorizedEnable, value)) m_HbaoVectorizedEnable = value; } } // 0x17C (380)
		
		protected bool m_Ps3CompressedRenderTargetsEnable = new bool();
		[ContainerField(381), LayoutImmutable, Blittable, ContainerFieldNameHash(2404166427)]
		public bool Ps3CompressedRenderTargetsEnable { get { return m_Ps3CompressedRenderTargetsEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3CompressedRenderTargetsEnable), this, m_Ps3CompressedRenderTargetsEnable, value)) m_Ps3CompressedRenderTargetsEnable = value; } } // 0x17D (381)
		
		protected bool m_HdrBloomEnable = new bool();
		[ContainerField(382), LayoutImmutable, Blittable, ContainerFieldNameHash(2031748249)]
		public bool HdrBloomEnable { get { return m_HdrBloomEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HdrBloomEnable), this, m_HdrBloomEnable, value)) m_HdrBloomEnable = value; } } // 0x17E (382)
		
		protected bool m_FilmGrainRandomEnable = new bool();
		[ContainerField(383), LayoutImmutable, Blittable, ContainerFieldNameHash(2060964098)]
		public bool FilmGrainRandomEnable { get { return m_FilmGrainRandomEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(FilmGrainRandomEnable), this, m_FilmGrainRandomEnable, value)) m_FilmGrainRandomEnable = value; } } // 0x17F (383)
		
		protected bool m_DirectExposureEnable = new bool();
		[ContainerField(384), LayoutImmutable, Blittable, ContainerFieldNameHash(883851546)]
		public bool DirectExposureEnable { get { return m_DirectExposureEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DirectExposureEnable), this, m_DirectExposureEnable, value)) m_DirectExposureEnable = value; } } // 0x180 (384)
		
		protected bool m_ExposureClampEnable = new bool();
		[ContainerField(385), LayoutImmutable, Blittable, ContainerFieldNameHash(982365156)]
		public bool ExposureClampEnable { get { return m_ExposureClampEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ExposureClampEnable), this, m_ExposureClampEnable, value)) m_ExposureClampEnable = value; } } // 0x181 (385)
		
		protected bool m_FilmGrainLinearFilteringEnable = new bool();
		[ContainerField(386), LayoutImmutable, Blittable, ContainerFieldNameHash(751424836)]
		public bool FilmGrainLinearFilteringEnable { get { return m_FilmGrainLinearFilteringEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(FilmGrainLinearFilteringEnable), this, m_FilmGrainLinearFilteringEnable, value)) m_FilmGrainLinearFilteringEnable = value; } } // 0x182 (386)
		
		protected bool m_HbaoBilateralBlurEnable = new bool();
		[ContainerField(387), LayoutImmutable, Blittable, ContainerFieldNameHash(1609473089)]
		public bool HbaoBilateralBlurEnable { get { return m_HbaoBilateralBlurEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoBilateralBlurEnable), this, m_HbaoBilateralBlurEnable, value)) m_HbaoBilateralBlurEnable = value; } } // 0x183 (387)
		
		protected bool m_ColorGradingEnable = new bool();
		[ContainerField(388), LayoutImmutable, Blittable, ContainerFieldNameHash(1205773449)]
		public bool ColorGradingEnable { get { return m_ColorGradingEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ColorGradingEnable), this, m_ColorGradingEnable, value)) m_ColorGradingEnable = value; } } // 0x184 (388)
		
		protected bool m_ColorTransformEnable = new bool();
		[ContainerField(389), LayoutImmutable, Blittable, ContainerFieldNameHash(1095107349)]
		public bool ColorTransformEnable { get { return m_ColorTransformEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(ColorTransformEnable), this, m_ColorTransformEnable, value)) m_ColorTransformEnable = value; } } // 0x185 (389)
		
		protected bool m_HbaoBilateralBlurCsEnable = new bool();
		[ContainerField(390), LayoutImmutable, Blittable, ContainerFieldNameHash(1787893969)]
		public bool HbaoBilateralBlurCsEnable { get { return m_HbaoBilateralBlurCsEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoBilateralBlurCsEnable), this, m_HbaoBilateralBlurCsEnable, value)) m_HbaoBilateralBlurCsEnable = value; } } // 0x186 (390)
		
		protected bool m_HbaoTemporalFilterEnable = new bool();
		[ContainerField(391), LayoutImmutable, Blittable, ContainerFieldNameHash(569736956)]
		public bool HbaoTemporalFilterEnable { get { return m_HbaoTemporalFilterEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoTemporalFilterEnable), this, m_HbaoTemporalFilterEnable, value)) m_HbaoTemporalFilterEnable = value; } } // 0x187 (391)
		
		protected bool m_QuarterDownsamplingEnable = new bool();
		[ContainerField(392), LayoutImmutable, Blittable, ContainerFieldNameHash(2460614977)]
		public bool QuarterDownsamplingEnable { get { return m_QuarterDownsamplingEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(QuarterDownsamplingEnable), this, m_QuarterDownsamplingEnable, value)) m_QuarterDownsamplingEnable = value; } } // 0x188 (392)
		
		protected bool m_DrawDebugUserBrightnessLUT = new bool();
		[ContainerField(393), LayoutImmutable, Blittable, ContainerFieldNameHash(4051730177)]
		public bool DrawDebugUserBrightnessLUT { get { return m_DrawDebugUserBrightnessLUT; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DrawDebugUserBrightnessLUT), this, m_DrawDebugUserBrightnessLUT, value)) m_DrawDebugUserBrightnessLUT = value; } } // 0x189 (393)
		
		protected bool m_BloomPyramidAttenuateEnable = new bool();
		[ContainerField(394), LayoutImmutable, Blittable, ContainerFieldNameHash(1368610322)]
		public bool BloomPyramidAttenuateEnable { get { return m_BloomPyramidAttenuateEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(BloomPyramidAttenuateEnable), this, m_BloomPyramidAttenuateEnable, value)) m_BloomPyramidAttenuateEnable = value; } } // 0x18A (394)
		
		protected bool m_DownsampleBeforeBlurEnable = new bool();
		[ContainerField(395), LayoutImmutable, Blittable, ContainerFieldNameHash(3596142400)]
		public bool DownsampleBeforeBlurEnable { get { return m_DownsampleBeforeBlurEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DownsampleBeforeBlurEnable), this, m_DownsampleBeforeBlurEnable, value)) m_DownsampleBeforeBlurEnable = value; } } // 0x18B (395)
		
		protected bool m_HbaoGaussianBlurEnable = new bool();
		[ContainerField(396), LayoutImmutable, Blittable, ContainerFieldNameHash(1146018076)]
		public bool HbaoGaussianBlurEnable { get { return m_HbaoGaussianBlurEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoGaussianBlurEnable), this, m_HbaoGaussianBlurEnable, value)) m_HbaoGaussianBlurEnable = value; } } // 0x18C (396)
		
		protected bool m_HbaoGaussianBlurHalfResEnable = new bool();
		[ContainerField(397), LayoutImmutable, Blittable, ContainerFieldNameHash(2411002971)]
		public bool HbaoGaussianBlurHalfResEnable { get { return m_HbaoGaussianBlurHalfResEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(HbaoGaussianBlurHalfResEnable), this, m_HbaoGaussianBlurHalfResEnable, value)) m_HbaoGaussianBlurHalfResEnable = value; } } // 0x18D (397)
		
		protected bool m_BloomPyramidEnable = new bool();
		[ContainerField(398), LayoutImmutable, Blittable, ContainerFieldNameHash(3107191069)]
		public bool BloomPyramidEnable { get { return m_BloomPyramidEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(BloomPyramidEnable), this, m_BloomPyramidEnable, value)) m_BloomPyramidEnable = value; } } // 0x18E (398)
		
		protected bool m_UserBrightnessLUTEnable = new bool();
		[ContainerField(399), LayoutImmutable, Blittable, ContainerFieldNameHash(2817018737)]
		public bool UserBrightnessLUTEnable { get { return m_UserBrightnessLUTEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(UserBrightnessLUTEnable), this, m_UserBrightnessLUTEnable, value)) m_UserBrightnessLUTEnable = value; } } // 0x18F (399)
		
		protected bool m_Ps3EdgeMlaaEnable = new bool();
		[ContainerField(400), LayoutImmutable, Blittable, ContainerFieldNameHash(3539499382)]
		public bool Ps3EdgeMlaaEnable { get { return m_Ps3EdgeMlaaEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3EdgeMlaaEnable), this, m_Ps3EdgeMlaaEnable, value)) m_Ps3EdgeMlaaEnable = value; } } // 0x190 (400)
		
		protected bool m_Ps3EdgeMlaaCopyOnly = new bool();
		[ContainerField(401), LayoutImmutable, Blittable, ContainerFieldNameHash(550522886)]
		public bool Ps3EdgeMlaaCopyOnly { get { return m_Ps3EdgeMlaaCopyOnly; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3EdgeMlaaCopyOnly), this, m_Ps3EdgeMlaaCopyOnly, value)) m_Ps3EdgeMlaaCopyOnly = value; } } // 0x191 (401)
		
		protected bool m_Ps3EdgeMlaaShowEdges = new bool();
		[ContainerField(402), LayoutImmutable, Blittable, ContainerFieldNameHash(1583173380)]
		public bool Ps3EdgeMlaaShowEdges { get { return m_Ps3EdgeMlaaShowEdges; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3EdgeMlaaShowEdges), this, m_Ps3EdgeMlaaShowEdges, value)) m_Ps3EdgeMlaaShowEdges = value; } } // 0x192 (402)
		
		protected bool m_Ps3EdgeMlaaRelativeEdgeDetection = new bool();
		[ContainerField(403), LayoutImmutable, Blittable, ContainerFieldNameHash(1826009647)]
		public bool Ps3EdgeMlaaRelativeEdgeDetection { get { return m_Ps3EdgeMlaaRelativeEdgeDetection; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3EdgeMlaaRelativeEdgeDetection), this, m_Ps3EdgeMlaaRelativeEdgeDetection, value)) m_Ps3EdgeMlaaRelativeEdgeDetection = value; } } // 0x193 (403)
		
		protected bool m_Ps3EdgeMlaaGpuBlockEnable = new bool();
		[ContainerField(404), LayoutImmutable, Blittable, ContainerFieldNameHash(507429533)]
		public bool Ps3EdgeMlaaGpuBlockEnable { get { return m_Ps3EdgeMlaaGpuBlockEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3EdgeMlaaGpuBlockEnable), this, m_Ps3EdgeMlaaGpuBlockEnable, value)) m_Ps3EdgeMlaaGpuBlockEnable = value; } } // 0x194 (404)
		
		protected bool m_Ps3BackBufferAsLdrTargetEnable = new bool();
		[ContainerField(405), LayoutImmutable, Blittable, ContainerFieldNameHash(2463474662)]
		public bool Ps3BackBufferAsLdrTargetEnable { get { return m_Ps3BackBufferAsLdrTargetEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(Ps3BackBufferAsLdrTargetEnable), this, m_Ps3BackBufferAsLdrTargetEnable, value)) m_Ps3BackBufferAsLdrTargetEnable = value; } } // 0x195 (405)
		
		protected bool m_DownsampleLogAverageEnable = new bool();
		[ContainerField(406), LayoutImmutable, Blittable, ContainerFieldNameHash(3775842167)]
		public bool DownsampleLogAverageEnable { get { return m_DownsampleLogAverageEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(DownsampleLogAverageEnable), this, m_DownsampleLogAverageEnable, value)) m_DownsampleLogAverageEnable = value; } } // 0x196 (406)
		
		protected bool m_BloomQuarterResEnable = new bool();
		[ContainerField(407), LayoutImmutable, Blittable, ContainerFieldNameHash(1900886743)]
		public bool BloomQuarterResEnable { get { return m_BloomQuarterResEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(BloomQuarterResEnable), this, m_BloomQuarterResEnable, value)) m_BloomQuarterResEnable = value; } } // 0x197 (407)
		
		protected bool m_BloomEnable = new bool();
		[ContainerField(408), LayoutImmutable, Blittable, ContainerFieldNameHash(931235495)]
		public bool BloomEnable { get { return m_BloomEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(BloomEnable), this, m_BloomEnable, value)) m_BloomEnable = value; } } // 0x198 (408)
		
		protected bool m_LensScopeFilterEnable = new bool();
		[ContainerField(409), LayoutImmutable, Blittable, ContainerFieldNameHash(1425211290)]
		public bool LensScopeFilterEnable { get { return m_LensScopeFilterEnable; } set { if (OnPropertyChanging("GlobalPostProcessSettings." + nameof(LensScopeFilterEnable), this, m_LensScopeFilterEnable, value)) m_LensScopeFilterEnable = value; } } // 0x199 (409)
		
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
