///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class GameRenderSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float StereoCrosshairDampingFactor { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint InactiveSkipFrameCount { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ForceOrthoViewSize { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float StereoCrosshairRadius { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float StereoCrosshairMaxHitDepth { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ForceBlurAmount { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint DrawFpsMethod { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float ForceFov { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float FovMultiplier { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float StaticModelPartOcclusionMaxScreenArea { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public uint StaticModelCullJobCount { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float EdgeModelLodScale { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float EdgeModelScreenAreaScale { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public uint XenonRingBufferSize { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public uint SplitScreenTestViewCount { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public uint XenonPresentImmediateThreshold { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public uint XenonGammaRampType { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public uint Ps3VSyncMethod { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float Ps3VideoGamma { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public uint Ps3FrameMainBufferSize { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public uint Ps3FrameLocalBufferSize { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float CameraCutMaxFrameTranslation { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float NearPlane { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float ForceWorldFadeAmount { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public uint EdgeModelMaxVisibleInstanceCount { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public int EdgeModelForceLod { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float EdgeModelViewDistance { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public bool Ps3LinearFrameCmdBufEnable { get; set; } // 0x78 (120)
		
		[ContainerField(121), LayoutImmutable, Blittable]
		public bool XenonRes1280x704Enable { get; set; } // 0x79 (121)
		
		[ContainerField(122), LayoutImmutable, Blittable]
		public bool PerfOverlayEnable { get; set; } // 0x7A (122)
		
		[ContainerField(123), LayoutImmutable, Blittable]
		public bool GcmHudEnable { get; set; } // 0x7B (123)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool MovieVSyncEnable { get; set; } // 0x7C (124)
		
		[ContainerField(125), LayoutImmutable, Blittable]
		public bool Ps3Res1280x704Enable { get; set; } // 0x7D (125)
		
		[ContainerField(126), LayoutImmutable, Blittable]
		public bool InitialClearEnable { get; set; } // 0x7E (126)
		
		[ContainerField(127), LayoutImmutable, Blittable]
		public bool GpuProfilerEnable { get; set; } // 0x7F (127)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public bool Ps3CellMemoryTexturesEnable { get; set; } // 0x80 (128)
		
		[ContainerField(129), LayoutImmutable, Blittable]
		public bool XenonBufferTwoFramesEnable { get; set; } // 0x81 (129)
		
		[ContainerField(130), LayoutImmutable, Blittable]
		public bool DrawFpsHistogram { get; set; } // 0x82 (130)
		
		[ContainerField(131), LayoutImmutable, Blittable]
		public bool Fullscreen { get; set; } // 0x83 (131)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public bool PerfOverlayLatestFrameTimeEnable { get; set; } // 0x84 (132)
		
		[ContainerField(133), LayoutImmutable, Blittable]
		public bool JobEnable { get; set; } // 0x85 (133)
		
		[ContainerField(134), LayoutImmutable, Blittable]
		public bool PerfOverlayVisible { get; set; } // 0x86 (134)
		
		[ContainerField(135), LayoutImmutable, Blittable]
		public bool EmittersEnable { get; set; } // 0x87 (135)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public bool EdgeModelsEnable { get; set; } // 0x88 (136)
		
		[ContainerField(137), LayoutImmutable, Blittable]
		public bool EdgeModelCastShadowsEnable { get; set; } // 0x89 (137)
		
		[ContainerField(138), LayoutImmutable, Blittable]
		public bool EdgeModelDepthBiasEnable { get; set; } // 0x8A (138)
		
		[ContainerField(139), LayoutImmutable, Blittable]
		public bool EdgeModelShadowDepthBiasEnable { get; set; } // 0x8B (139)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public bool VSyncFlashTestEnable { get; set; } // 0x8C (140)
		
		[ContainerField(141), LayoutImmutable, Blittable]
		public bool EntityRenderEnable { get; set; } // 0x8D (141)
		
		[ContainerField(142), LayoutImmutable, Blittable]
		public bool EdgeModelSpuInstancingEnable { get; set; } // 0x8E (142)
		
		[ContainerField(143), LayoutImmutable, Blittable]
		public bool EdgeModelUseMainLodEnable { get; set; } // 0x8F (143)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public bool DebugRenderServiceEnable { get; set; } // 0x90 (144)
		
		[ContainerField(145), LayoutImmutable, Blittable]
		public bool EdgeModelUseLodBox { get; set; } // 0x91 (145)
		
		[ContainerField(146), LayoutImmutable, Blittable]
		public bool DebugRendererEnable { get; set; } // 0x92 (146)
		
		[ContainerField(147), LayoutImmutable, Blittable]
		public bool ForceVSyncEnable { get; set; } // 0x93 (147)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool EdgeModelCullEnable { get; set; } // 0x94 (148)
		
		[ContainerField(149), LayoutImmutable, Blittable]
		public bool EdgeModelFrustumCullEnable { get; set; } // 0x95 (149)
		
		[ContainerField(150), LayoutImmutable, Blittable]
		public bool EdgeModelOcclusionCullEnable { get; set; } // 0x96 (150)
		
		[ContainerField(151), LayoutImmutable, Blittable]
		public bool EdgeModelAdditionalCullEnable { get; set; } // 0x97 (151)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public bool EdgeModelDrawBoxes { get; set; } // 0x98 (152)
		
		[ContainerField(153), LayoutImmutable, Blittable]
		public bool EdgeModelDrawStats { get; set; } // 0x99 (153)
		
		[ContainerField(154), LayoutImmutable, Blittable]
		public bool StaticModelEnable { get; set; } // 0x9A (154)
		
		[ContainerField(155), LayoutImmutable, Blittable]
		public bool StaticModelMeshesEnable { get; set; } // 0x9B (155)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public bool StaticModelZPassEnable { get; set; } // 0x9C (156)
		
		[ContainerField(157), LayoutImmutable, Blittable]
		public bool StaticModelPartCullEnable { get; set; } // 0x9D (157)
		
		[ContainerField(158), LayoutImmutable, Blittable]
		public bool StaticModelPartFrustumCullEnable { get; set; } // 0x9E (158)
		
		[ContainerField(159), LayoutImmutable, Blittable]
		public bool StaticModelPartOcclusionCullEnable { get; set; } // 0x9F (159)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public bool StaticModelPartShadowCullEnable { get; set; } // 0xA0 (160)
		
		[ContainerField(161), LayoutImmutable, Blittable]
		public bool StaticModelDrawBoxes { get; set; } // 0xA1 (161)
		
		[ContainerField(162), LayoutImmutable, Blittable]
		public bool StaticModelDrawStats { get; set; } // 0xA2 (162)
		
		[ContainerField(163), LayoutImmutable, Blittable]
		public bool DrawScreenInfo { get; set; } // 0xA3 (163)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public bool ForceOrthoViewEnable { get; set; } // 0xA4 (164)
		
		[ContainerField(165), LayoutImmutable, Blittable]
		public bool StaticModelCullSpuJobEnable { get; set; } // 0xA5 (165)
		
		[ContainerField(166), LayoutImmutable, Blittable]
		public bool LockView { get; set; } // 0xA6 (166)
		
		[ContainerField(167), LayoutImmutable, Blittable]
		public bool ResetLockedView { get; set; } // 0xA7 (167)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public bool DrawInfo { get; set; } // 0xA8 (168)
		
		[ContainerField(169), LayoutImmutable, Blittable]
		public bool FadeEnable { get; set; } // 0xA9 (169)
		
		[ContainerField(170), LayoutImmutable, Blittable]
		public bool FadeWaitingEnable { get; set; } // 0xAA (170)
		
		[ContainerField(171), LayoutImmutable, Blittable]
		public bool DrawFps { get; set; } // 0xAB (171)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public bool DestructionVolumeDrawEnable { get; set; } // 0xAC (172)
		
		[ContainerField(173), LayoutImmutable, Blittable]
		public bool BlurEnable { get; set; } // 0xAD (173)
		
		[ContainerField(174), LayoutImmutable, Blittable]
		public bool BuildJobSyncEnable { get; set; } // 0xAE (174)
		
		[ContainerField(175), LayoutImmutable, Blittable]
		public bool ForceSquareOrthoView { get; set; } // 0xAF (175)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0xB0 (176)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3082102470:
					StereoCrosshairDampingFactor = (float) p_Value;
					break;

				case 2655362545:
					InactiveSkipFrameCount = (uint) p_Value;
					break;

				case 3323242110:
					ForceOrthoViewSize = (float) p_Value;
					break;

				case 2441395179:
					StereoCrosshairRadius = (float) p_Value;
					break;

				case 2704522783:
					StereoCrosshairMaxHitDepth = (float) p_Value;
					break;

				case 4248942685:
					ForceBlurAmount = (float) p_Value;
					break;

				case 167743071:
					DrawFpsMethod = (uint) p_Value;
					break;

				case 1152601159:
					ForceFov = (float) p_Value;
					break;

				case 3789653393:
					FovMultiplier = (float) p_Value;
					break;

				case 2191141031:
					StaticModelPartOcclusionMaxScreenArea = (float) p_Value;
					break;

				case 2262716864:
					StaticModelCullJobCount = (uint) p_Value;
					break;

				case 1165587222:
					EdgeModelLodScale = (float) p_Value;
					break;

				case 4227759818:
					EdgeModelScreenAreaScale = (float) p_Value;
					break;

				case 324402816:
					XenonRingBufferSize = (uint) p_Value;
					break;

				case 700075907:
					SplitScreenTestViewCount = (uint) p_Value;
					break;

				case 2639411546:
					XenonPresentImmediateThreshold = (uint) p_Value;
					break;

				case 2019953318:
					XenonGammaRampType = (uint) p_Value;
					break;

				case 4142817563:
					Ps3VSyncMethod = (uint) p_Value;
					break;

				case 2476657891:
					Ps3VideoGamma = (float) p_Value;
					break;

				case 2892170406:
					Ps3FrameMainBufferSize = (uint) p_Value;
					break;

				case 2611594240:
					Ps3FrameLocalBufferSize = (uint) p_Value;
					break;

				case 2201945291:
					ViewDistance = (float) p_Value;
					break;

				case 857495452:
					CameraCutMaxFrameTranslation = (float) p_Value;
					break;

				case 3156145579:
					NearPlane = (float) p_Value;
					break;

				case 3732853520:
					ForceWorldFadeAmount = (float) p_Value;
					break;

				case 1451185241:
					EdgeModelMaxVisibleInstanceCount = (uint) p_Value;
					break;

				case 386262579:
					EdgeModelForceLod = (int) p_Value;
					break;

				case 2290647591:
					EdgeModelViewDistance = (float) p_Value;
					break;

				case 3181089999:
					Ps3LinearFrameCmdBufEnable = (bool) p_Value;
					break;

				case 619543602:
					XenonRes1280x704Enable = (bool) p_Value;
					break;

				case 1531499007:
					PerfOverlayEnable = (bool) p_Value;
					break;

				case 3207867476:
					GcmHudEnable = (bool) p_Value;
					break;

				case 3216962093:
					MovieVSyncEnable = (bool) p_Value;
					break;

				case 1187504528:
					Ps3Res1280x704Enable = (bool) p_Value;
					break;

				case 676050019:
					InitialClearEnable = (bool) p_Value;
					break;

				case 1651467743:
					GpuProfilerEnable = (bool) p_Value;
					break;

				case 1001772351:
					Ps3CellMemoryTexturesEnable = (bool) p_Value;
					break;

				case 609481908:
					XenonBufferTwoFramesEnable = (bool) p_Value;
					break;

				case 109066192:
					DrawFpsHistogram = (bool) p_Value;
					break;

				case 2248877754:
					Fullscreen = (bool) p_Value;
					break;

				case 1529162668:
					PerfOverlayLatestFrameTimeEnable = (bool) p_Value;
					break;

				case 442685923:
					JobEnable = (bool) p_Value;
					break;

				case 2073387536:
					PerfOverlayVisible = (bool) p_Value;
					break;

				case 121284033:
					EmittersEnable = (bool) p_Value;
					break;

				case 928744923:
					EdgeModelsEnable = (bool) p_Value;
					break;

				case 4261856024:
					EdgeModelCastShadowsEnable = (bool) p_Value;
					break;

				case 3070669020:
					EdgeModelDepthBiasEnable = (bool) p_Value;
					break;

				case 3511388634:
					EdgeModelShadowDepthBiasEnable = (bool) p_Value;
					break;

				case 2611047923:
					VSyncFlashTestEnable = (bool) p_Value;
					break;

				case 1701938165:
					EntityRenderEnable = (bool) p_Value;
					break;

				case 2066931218:
					EdgeModelSpuInstancingEnable = (bool) p_Value;
					break;

				case 711389031:
					EdgeModelUseMainLodEnable = (bool) p_Value;
					break;

				case 215748418:
					DebugRenderServiceEnable = (bool) p_Value;
					break;

				case 2867701848:
					EdgeModelUseLodBox = (bool) p_Value;
					break;

				case 4239334696:
					DebugRendererEnable = (bool) p_Value;
					break;

				case 1841857032:
					ForceVSyncEnable = (bool) p_Value;
					break;

				case 1610471710:
					EdgeModelCullEnable = (bool) p_Value;
					break;

				case 3571022816:
					EdgeModelFrustumCullEnable = (bool) p_Value;
					break;

				case 3807955731:
					EdgeModelOcclusionCullEnable = (bool) p_Value;
					break;

				case 2958104775:
					EdgeModelAdditionalCullEnable = (bool) p_Value;
					break;

				case 3437926730:
					EdgeModelDrawBoxes = (bool) p_Value;
					break;

				case 3457602056:
					EdgeModelDrawStats = (bool) p_Value;
					break;

				case 16174035:
					StaticModelEnable = (bool) p_Value;
					break;

				case 3520548374:
					StaticModelMeshesEnable = (bool) p_Value;
					break;

				case 157779288:
					StaticModelZPassEnable = (bool) p_Value;
					break;

				case 756373810:
					StaticModelPartCullEnable = (bool) p_Value;
					break;

				case 2549275532:
					StaticModelPartFrustumCullEnable = (bool) p_Value;
					break;

				case 3865476287:
					StaticModelPartOcclusionCullEnable = (bool) p_Value;
					break;

				case 1569108020:
					StaticModelPartShadowCullEnable = (bool) p_Value;
					break;

				case 2399189489:
					StaticModelDrawBoxes = (bool) p_Value;
					break;

				case 2379235123:
					StaticModelDrawStats = (bool) p_Value;
					break;

				case 2003014247:
					DrawScreenInfo = (bool) p_Value;
					break;

				case 3649401946:
					ForceOrthoViewEnable = (bool) p_Value;
					break;

				case 1653994164:
					StaticModelCullSpuJobEnable = (bool) p_Value;
					break;

				case 1982163459:
					LockView = (bool) p_Value;
					break;

				case 2200752407:
					ResetLockedView = (bool) p_Value;
					break;

				case 3456547147:
					DrawInfo = (bool) p_Value;
					break;

				case 1633100994:
					FadeEnable = (bool) p_Value;
					break;

				case 3804420041:
					FadeWaitingEnable = (bool) p_Value;
					break;

				case 365038176:
					DrawFps = (bool) p_Value;
					break;

				case 3224392434:
					DestructionVolumeDrawEnable = (bool) p_Value;
					break;

				case 1072996973:
					BlurEnable = (bool) p_Value;
					break;

				case 3715134706:
					BuildJobSyncEnable = (bool) p_Value;
					break;

				case 1356920058:
					ForceSquareOrthoView = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 3082102470:
					return StereoCrosshairDampingFactor;

				case 2655362545:
					return InactiveSkipFrameCount;

				case 3323242110:
					return ForceOrthoViewSize;

				case 2441395179:
					return StereoCrosshairRadius;

				case 2704522783:
					return StereoCrosshairMaxHitDepth;

				case 4248942685:
					return ForceBlurAmount;

				case 167743071:
					return DrawFpsMethod;

				case 1152601159:
					return ForceFov;

				case 3789653393:
					return FovMultiplier;

				case 2191141031:
					return StaticModelPartOcclusionMaxScreenArea;

				case 2262716864:
					return StaticModelCullJobCount;

				case 1165587222:
					return EdgeModelLodScale;

				case 4227759818:
					return EdgeModelScreenAreaScale;

				case 324402816:
					return XenonRingBufferSize;

				case 700075907:
					return SplitScreenTestViewCount;

				case 2639411546:
					return XenonPresentImmediateThreshold;

				case 2019953318:
					return XenonGammaRampType;

				case 4142817563:
					return Ps3VSyncMethod;

				case 2476657891:
					return Ps3VideoGamma;

				case 2892170406:
					return Ps3FrameMainBufferSize;

				case 2611594240:
					return Ps3FrameLocalBufferSize;

				case 2201945291:
					return ViewDistance;

				case 857495452:
					return CameraCutMaxFrameTranslation;

				case 3156145579:
					return NearPlane;

				case 3732853520:
					return ForceWorldFadeAmount;

				case 1451185241:
					return EdgeModelMaxVisibleInstanceCount;

				case 386262579:
					return EdgeModelForceLod;

				case 2290647591:
					return EdgeModelViewDistance;

				case 3181089999:
					return Ps3LinearFrameCmdBufEnable;

				case 619543602:
					return XenonRes1280x704Enable;

				case 1531499007:
					return PerfOverlayEnable;

				case 3207867476:
					return GcmHudEnable;

				case 3216962093:
					return MovieVSyncEnable;

				case 1187504528:
					return Ps3Res1280x704Enable;

				case 676050019:
					return InitialClearEnable;

				case 1651467743:
					return GpuProfilerEnable;

				case 1001772351:
					return Ps3CellMemoryTexturesEnable;

				case 609481908:
					return XenonBufferTwoFramesEnable;

				case 109066192:
					return DrawFpsHistogram;

				case 2248877754:
					return Fullscreen;

				case 1529162668:
					return PerfOverlayLatestFrameTimeEnable;

				case 442685923:
					return JobEnable;

				case 2073387536:
					return PerfOverlayVisible;

				case 121284033:
					return EmittersEnable;

				case 928744923:
					return EdgeModelsEnable;

				case 4261856024:
					return EdgeModelCastShadowsEnable;

				case 3070669020:
					return EdgeModelDepthBiasEnable;

				case 3511388634:
					return EdgeModelShadowDepthBiasEnable;

				case 2611047923:
					return VSyncFlashTestEnable;

				case 1701938165:
					return EntityRenderEnable;

				case 2066931218:
					return EdgeModelSpuInstancingEnable;

				case 711389031:
					return EdgeModelUseMainLodEnable;

				case 215748418:
					return DebugRenderServiceEnable;

				case 2867701848:
					return EdgeModelUseLodBox;

				case 4239334696:
					return DebugRendererEnable;

				case 1841857032:
					return ForceVSyncEnable;

				case 1610471710:
					return EdgeModelCullEnable;

				case 3571022816:
					return EdgeModelFrustumCullEnable;

				case 3807955731:
					return EdgeModelOcclusionCullEnable;

				case 2958104775:
					return EdgeModelAdditionalCullEnable;

				case 3437926730:
					return EdgeModelDrawBoxes;

				case 3457602056:
					return EdgeModelDrawStats;

				case 16174035:
					return StaticModelEnable;

				case 3520548374:
					return StaticModelMeshesEnable;

				case 157779288:
					return StaticModelZPassEnable;

				case 756373810:
					return StaticModelPartCullEnable;

				case 2549275532:
					return StaticModelPartFrustumCullEnable;

				case 3865476287:
					return StaticModelPartOcclusionCullEnable;

				case 1569108020:
					return StaticModelPartShadowCullEnable;

				case 2399189489:
					return StaticModelDrawBoxes;

				case 2379235123:
					return StaticModelDrawStats;

				case 2003014247:
					return DrawScreenInfo;

				case 3649401946:
					return ForceOrthoViewEnable;

				case 1653994164:
					return StaticModelCullSpuJobEnable;

				case 1982163459:
					return LockView;

				case 2200752407:
					return ResetLockedView;

				case 3456547147:
					return DrawInfo;

				case 1633100994:
					return FadeEnable;

				case 3804420041:
					return FadeWaitingEnable;

				case 365038176:
					return DrawFps;

				case 3224392434:
					return DestructionVolumeDrawEnable;

				case 1072996973:
					return BlurEnable;

				case 3715134706:
					return BuildJobSyncEnable;

				case 1356920058:
					return ForceSquareOrthoView;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3082102470:
					return typeof(GameRenderSettings).GetProperty(nameof(StereoCrosshairDampingFactor));

				case 2655362545:
					return typeof(GameRenderSettings).GetProperty(nameof(InactiveSkipFrameCount));

				case 3323242110:
					return typeof(GameRenderSettings).GetProperty(nameof(ForceOrthoViewSize));

				case 2441395179:
					return typeof(GameRenderSettings).GetProperty(nameof(StereoCrosshairRadius));

				case 2704522783:
					return typeof(GameRenderSettings).GetProperty(nameof(StereoCrosshairMaxHitDepth));

				case 4248942685:
					return typeof(GameRenderSettings).GetProperty(nameof(ForceBlurAmount));

				case 167743071:
					return typeof(GameRenderSettings).GetProperty(nameof(DrawFpsMethod));

				case 1152601159:
					return typeof(GameRenderSettings).GetProperty(nameof(ForceFov));

				case 3789653393:
					return typeof(GameRenderSettings).GetProperty(nameof(FovMultiplier));

				case 2191141031:
					return typeof(GameRenderSettings).GetProperty(nameof(StaticModelPartOcclusionMaxScreenArea));

				case 2262716864:
					return typeof(GameRenderSettings).GetProperty(nameof(StaticModelCullJobCount));

				case 1165587222:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelLodScale));

				case 4227759818:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelScreenAreaScale));

				case 324402816:
					return typeof(GameRenderSettings).GetProperty(nameof(XenonRingBufferSize));

				case 700075907:
					return typeof(GameRenderSettings).GetProperty(nameof(SplitScreenTestViewCount));

				case 2639411546:
					return typeof(GameRenderSettings).GetProperty(nameof(XenonPresentImmediateThreshold));

				case 2019953318:
					return typeof(GameRenderSettings).GetProperty(nameof(XenonGammaRampType));

				case 4142817563:
					return typeof(GameRenderSettings).GetProperty(nameof(Ps3VSyncMethod));

				case 2476657891:
					return typeof(GameRenderSettings).GetProperty(nameof(Ps3VideoGamma));

				case 2892170406:
					return typeof(GameRenderSettings).GetProperty(nameof(Ps3FrameMainBufferSize));

				case 2611594240:
					return typeof(GameRenderSettings).GetProperty(nameof(Ps3FrameLocalBufferSize));

				case 2201945291:
					return typeof(GameRenderSettings).GetProperty(nameof(ViewDistance));

				case 857495452:
					return typeof(GameRenderSettings).GetProperty(nameof(CameraCutMaxFrameTranslation));

				case 3156145579:
					return typeof(GameRenderSettings).GetProperty(nameof(NearPlane));

				case 3732853520:
					return typeof(GameRenderSettings).GetProperty(nameof(ForceWorldFadeAmount));

				case 1451185241:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelMaxVisibleInstanceCount));

				case 386262579:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelForceLod));

				case 2290647591:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelViewDistance));

				case 3181089999:
					return typeof(GameRenderSettings).GetProperty(nameof(Ps3LinearFrameCmdBufEnable));

				case 619543602:
					return typeof(GameRenderSettings).GetProperty(nameof(XenonRes1280x704Enable));

				case 1531499007:
					return typeof(GameRenderSettings).GetProperty(nameof(PerfOverlayEnable));

				case 3207867476:
					return typeof(GameRenderSettings).GetProperty(nameof(GcmHudEnable));

				case 3216962093:
					return typeof(GameRenderSettings).GetProperty(nameof(MovieVSyncEnable));

				case 1187504528:
					return typeof(GameRenderSettings).GetProperty(nameof(Ps3Res1280x704Enable));

				case 676050019:
					return typeof(GameRenderSettings).GetProperty(nameof(InitialClearEnable));

				case 1651467743:
					return typeof(GameRenderSettings).GetProperty(nameof(GpuProfilerEnable));

				case 1001772351:
					return typeof(GameRenderSettings).GetProperty(nameof(Ps3CellMemoryTexturesEnable));

				case 609481908:
					return typeof(GameRenderSettings).GetProperty(nameof(XenonBufferTwoFramesEnable));

				case 109066192:
					return typeof(GameRenderSettings).GetProperty(nameof(DrawFpsHistogram));

				case 2248877754:
					return typeof(GameRenderSettings).GetProperty(nameof(Fullscreen));

				case 1529162668:
					return typeof(GameRenderSettings).GetProperty(nameof(PerfOverlayLatestFrameTimeEnable));

				case 442685923:
					return typeof(GameRenderSettings).GetProperty(nameof(JobEnable));

				case 2073387536:
					return typeof(GameRenderSettings).GetProperty(nameof(PerfOverlayVisible));

				case 121284033:
					return typeof(GameRenderSettings).GetProperty(nameof(EmittersEnable));

				case 928744923:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelsEnable));

				case 4261856024:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelCastShadowsEnable));

				case 3070669020:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelDepthBiasEnable));

				case 3511388634:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelShadowDepthBiasEnable));

				case 2611047923:
					return typeof(GameRenderSettings).GetProperty(nameof(VSyncFlashTestEnable));

				case 1701938165:
					return typeof(GameRenderSettings).GetProperty(nameof(EntityRenderEnable));

				case 2066931218:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelSpuInstancingEnable));

				case 711389031:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelUseMainLodEnable));

				case 215748418:
					return typeof(GameRenderSettings).GetProperty(nameof(DebugRenderServiceEnable));

				case 2867701848:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelUseLodBox));

				case 4239334696:
					return typeof(GameRenderSettings).GetProperty(nameof(DebugRendererEnable));

				case 1841857032:
					return typeof(GameRenderSettings).GetProperty(nameof(ForceVSyncEnable));

				case 1610471710:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelCullEnable));

				case 3571022816:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelFrustumCullEnable));

				case 3807955731:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelOcclusionCullEnable));

				case 2958104775:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelAdditionalCullEnable));

				case 3437926730:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelDrawBoxes));

				case 3457602056:
					return typeof(GameRenderSettings).GetProperty(nameof(EdgeModelDrawStats));

				case 16174035:
					return typeof(GameRenderSettings).GetProperty(nameof(StaticModelEnable));

				case 3520548374:
					return typeof(GameRenderSettings).GetProperty(nameof(StaticModelMeshesEnable));

				case 157779288:
					return typeof(GameRenderSettings).GetProperty(nameof(StaticModelZPassEnable));

				case 756373810:
					return typeof(GameRenderSettings).GetProperty(nameof(StaticModelPartCullEnable));

				case 2549275532:
					return typeof(GameRenderSettings).GetProperty(nameof(StaticModelPartFrustumCullEnable));

				case 3865476287:
					return typeof(GameRenderSettings).GetProperty(nameof(StaticModelPartOcclusionCullEnable));

				case 1569108020:
					return typeof(GameRenderSettings).GetProperty(nameof(StaticModelPartShadowCullEnable));

				case 2399189489:
					return typeof(GameRenderSettings).GetProperty(nameof(StaticModelDrawBoxes));

				case 2379235123:
					return typeof(GameRenderSettings).GetProperty(nameof(StaticModelDrawStats));

				case 2003014247:
					return typeof(GameRenderSettings).GetProperty(nameof(DrawScreenInfo));

				case 3649401946:
					return typeof(GameRenderSettings).GetProperty(nameof(ForceOrthoViewEnable));

				case 1653994164:
					return typeof(GameRenderSettings).GetProperty(nameof(StaticModelCullSpuJobEnable));

				case 1982163459:
					return typeof(GameRenderSettings).GetProperty(nameof(LockView));

				case 2200752407:
					return typeof(GameRenderSettings).GetProperty(nameof(ResetLockedView));

				case 3456547147:
					return typeof(GameRenderSettings).GetProperty(nameof(DrawInfo));

				case 1633100994:
					return typeof(GameRenderSettings).GetProperty(nameof(FadeEnable));

				case 3804420041:
					return typeof(GameRenderSettings).GetProperty(nameof(FadeWaitingEnable));

				case 365038176:
					return typeof(GameRenderSettings).GetProperty(nameof(DrawFps));

				case 3224392434:
					return typeof(GameRenderSettings).GetProperty(nameof(DestructionVolumeDrawEnable));

				case 1072996973:
					return typeof(GameRenderSettings).GetProperty(nameof(BlurEnable));

				case 3715134706:
					return typeof(GameRenderSettings).GetProperty(nameof(BuildJobSyncEnable));

				case 1356920058:
					return typeof(GameRenderSettings).GetProperty(nameof(ForceSquareOrthoView));

				case 2342790116:
					return typeof(GameRenderSettings).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
