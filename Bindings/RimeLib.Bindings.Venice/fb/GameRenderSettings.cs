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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class GameRenderSettings : 
		DataContainer
	{
		protected float m_StereoCrosshairDampingFactor = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3082102470)]
		public float StereoCrosshairDampingFactor { get { return m_StereoCrosshairDampingFactor; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StereoCrosshairDampingFactor), this, m_StereoCrosshairDampingFactor, value)) m_StereoCrosshairDampingFactor = value; } } // 0x8 (8)
		
		protected uint m_InactiveSkipFrameCount = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2655362545)]
		public uint InactiveSkipFrameCount { get { return m_InactiveSkipFrameCount; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(InactiveSkipFrameCount), this, m_InactiveSkipFrameCount, value)) m_InactiveSkipFrameCount = value; } } // 0xC (12)
		
		protected float m_ForceOrthoViewSize = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3323242110)]
		public float ForceOrthoViewSize { get { return m_ForceOrthoViewSize; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(ForceOrthoViewSize), this, m_ForceOrthoViewSize, value)) m_ForceOrthoViewSize = value; } } // 0x10 (16)
		
		protected float m_StereoCrosshairRadius = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2441395179)]
		public float StereoCrosshairRadius { get { return m_StereoCrosshairRadius; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StereoCrosshairRadius), this, m_StereoCrosshairRadius, value)) m_StereoCrosshairRadius = value; } } // 0x14 (20)
		
		protected float m_StereoCrosshairMaxHitDepth = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2704522783)]
		public float StereoCrosshairMaxHitDepth { get { return m_StereoCrosshairMaxHitDepth; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StereoCrosshairMaxHitDepth), this, m_StereoCrosshairMaxHitDepth, value)) m_StereoCrosshairMaxHitDepth = value; } } // 0x18 (24)
		
		protected float m_ForceBlurAmount = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4248942685)]
		public float ForceBlurAmount { get { return m_ForceBlurAmount; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(ForceBlurAmount), this, m_ForceBlurAmount, value)) m_ForceBlurAmount = value; } } // 0x1C (28)
		
		protected uint m_DrawFpsMethod = new uint();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(167743071)]
		public uint DrawFpsMethod { get { return m_DrawFpsMethod; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(DrawFpsMethod), this, m_DrawFpsMethod, value)) m_DrawFpsMethod = value; } } // 0x20 (32)
		
		protected float m_ForceFov = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1152601159)]
		public float ForceFov { get { return m_ForceFov; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(ForceFov), this, m_ForceFov, value)) m_ForceFov = value; } } // 0x24 (36)
		
		protected float m_FovMultiplier = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3789653393)]
		public float FovMultiplier { get { return m_FovMultiplier; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(FovMultiplier), this, m_FovMultiplier, value)) m_FovMultiplier = value; } } // 0x28 (40)
		
		protected float m_StaticModelPartOcclusionMaxScreenArea = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2191141031)]
		public float StaticModelPartOcclusionMaxScreenArea { get { return m_StaticModelPartOcclusionMaxScreenArea; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StaticModelPartOcclusionMaxScreenArea), this, m_StaticModelPartOcclusionMaxScreenArea, value)) m_StaticModelPartOcclusionMaxScreenArea = value; } } // 0x2C (44)
		
		protected uint m_StaticModelCullJobCount = new uint();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2262716864)]
		public uint StaticModelCullJobCount { get { return m_StaticModelCullJobCount; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StaticModelCullJobCount), this, m_StaticModelCullJobCount, value)) m_StaticModelCullJobCount = value; } } // 0x30 (48)
		
		protected float m_EdgeModelLodScale = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1165587222)]
		public float EdgeModelLodScale { get { return m_EdgeModelLodScale; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelLodScale), this, m_EdgeModelLodScale, value)) m_EdgeModelLodScale = value; } } // 0x34 (52)
		
		protected float m_EdgeModelScreenAreaScale = new float();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4227759818)]
		public float EdgeModelScreenAreaScale { get { return m_EdgeModelScreenAreaScale; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelScreenAreaScale), this, m_EdgeModelScreenAreaScale, value)) m_EdgeModelScreenAreaScale = value; } } // 0x38 (56)
		
		protected uint m_XenonRingBufferSize = new uint();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(324402816)]
		public uint XenonRingBufferSize { get { return m_XenonRingBufferSize; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(XenonRingBufferSize), this, m_XenonRingBufferSize, value)) m_XenonRingBufferSize = value; } } // 0x3C (60)
		
		protected uint m_SplitScreenTestViewCount = new uint();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(700075907)]
		public uint SplitScreenTestViewCount { get { return m_SplitScreenTestViewCount; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(SplitScreenTestViewCount), this, m_SplitScreenTestViewCount, value)) m_SplitScreenTestViewCount = value; } } // 0x40 (64)
		
		protected uint m_XenonPresentImmediateThreshold = new uint();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2639411546)]
		public uint XenonPresentImmediateThreshold { get { return m_XenonPresentImmediateThreshold; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(XenonPresentImmediateThreshold), this, m_XenonPresentImmediateThreshold, value)) m_XenonPresentImmediateThreshold = value; } } // 0x44 (68)
		
		protected uint m_XenonGammaRampType = new uint();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2019953318)]
		public uint XenonGammaRampType { get { return m_XenonGammaRampType; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(XenonGammaRampType), this, m_XenonGammaRampType, value)) m_XenonGammaRampType = value; } } // 0x48 (72)
		
		protected uint m_Ps3VSyncMethod = new uint();
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4142817563)]
		public uint Ps3VSyncMethod { get { return m_Ps3VSyncMethod; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(Ps3VSyncMethod), this, m_Ps3VSyncMethod, value)) m_Ps3VSyncMethod = value; } } // 0x4C (76)
		
		protected float m_Ps3VideoGamma = new float();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2476657891)]
		public float Ps3VideoGamma { get { return m_Ps3VideoGamma; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(Ps3VideoGamma), this, m_Ps3VideoGamma, value)) m_Ps3VideoGamma = value; } } // 0x50 (80)
		
		protected uint m_Ps3FrameMainBufferSize = new uint();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2892170406)]
		public uint Ps3FrameMainBufferSize { get { return m_Ps3FrameMainBufferSize; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(Ps3FrameMainBufferSize), this, m_Ps3FrameMainBufferSize, value)) m_Ps3FrameMainBufferSize = value; } } // 0x54 (84)
		
		protected uint m_Ps3FrameLocalBufferSize = new uint();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2611594240)]
		public uint Ps3FrameLocalBufferSize { get { return m_Ps3FrameLocalBufferSize; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(Ps3FrameLocalBufferSize), this, m_Ps3FrameLocalBufferSize, value)) m_Ps3FrameLocalBufferSize = value; } } // 0x58 (88)
		
		protected float m_ViewDistance = new float();
		[ContainerField(92), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2201945291)]
		public float ViewDistance { get { return m_ViewDistance; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(ViewDistance), this, m_ViewDistance, value)) m_ViewDistance = value; } } // 0x5C (92)
		
		protected float m_CameraCutMaxFrameTranslation = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(857495452)]
		public float CameraCutMaxFrameTranslation { get { return m_CameraCutMaxFrameTranslation; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(CameraCutMaxFrameTranslation), this, m_CameraCutMaxFrameTranslation, value)) m_CameraCutMaxFrameTranslation = value; } } // 0x60 (96)
		
		protected float m_NearPlane = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3156145579)]
		public float NearPlane { get { return m_NearPlane; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(NearPlane), this, m_NearPlane, value)) m_NearPlane = value; } } // 0x64 (100)
		
		protected float m_ForceWorldFadeAmount = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3732853520)]
		public float ForceWorldFadeAmount { get { return m_ForceWorldFadeAmount; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(ForceWorldFadeAmount), this, m_ForceWorldFadeAmount, value)) m_ForceWorldFadeAmount = value; } } // 0x68 (104)
		
		protected uint m_EdgeModelMaxVisibleInstanceCount = new uint();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1451185241)]
		public uint EdgeModelMaxVisibleInstanceCount { get { return m_EdgeModelMaxVisibleInstanceCount; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelMaxVisibleInstanceCount), this, m_EdgeModelMaxVisibleInstanceCount, value)) m_EdgeModelMaxVisibleInstanceCount = value; } } // 0x6C (108)
		
		protected int m_EdgeModelForceLod = new int();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(386262579)]
		public int EdgeModelForceLod { get { return m_EdgeModelForceLod; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelForceLod), this, m_EdgeModelForceLod, value)) m_EdgeModelForceLod = value; } } // 0x70 (112)
		
		protected float m_EdgeModelViewDistance = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2290647591)]
		public float EdgeModelViewDistance { get { return m_EdgeModelViewDistance; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelViewDistance), this, m_EdgeModelViewDistance, value)) m_EdgeModelViewDistance = value; } } // 0x74 (116)
		
		protected bool m_Ps3LinearFrameCmdBufEnable = new bool();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3181089999)]
		public bool Ps3LinearFrameCmdBufEnable { get { return m_Ps3LinearFrameCmdBufEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(Ps3LinearFrameCmdBufEnable), this, m_Ps3LinearFrameCmdBufEnable, value)) m_Ps3LinearFrameCmdBufEnable = value; } } // 0x78 (120)
		
		protected bool m_XenonRes1280x704Enable = new bool();
		[ContainerField(121), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(619543602)]
		public bool XenonRes1280x704Enable { get { return m_XenonRes1280x704Enable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(XenonRes1280x704Enable), this, m_XenonRes1280x704Enable, value)) m_XenonRes1280x704Enable = value; } } // 0x79 (121)
		
		protected bool m_PerfOverlayEnable = new bool();
		[ContainerField(122), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1531499007)]
		public bool PerfOverlayEnable { get { return m_PerfOverlayEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(PerfOverlayEnable), this, m_PerfOverlayEnable, value)) m_PerfOverlayEnable = value; } } // 0x7A (122)
		
		protected bool m_GcmHudEnable = new bool();
		[ContainerField(123), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3207867476)]
		public bool GcmHudEnable { get { return m_GcmHudEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(GcmHudEnable), this, m_GcmHudEnable, value)) m_GcmHudEnable = value; } } // 0x7B (123)
		
		protected bool m_MovieVSyncEnable = new bool();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3216962093)]
		public bool MovieVSyncEnable { get { return m_MovieVSyncEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(MovieVSyncEnable), this, m_MovieVSyncEnable, value)) m_MovieVSyncEnable = value; } } // 0x7C (124)
		
		protected bool m_Ps3Res1280x704Enable = new bool();
		[ContainerField(125), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1187504528)]
		public bool Ps3Res1280x704Enable { get { return m_Ps3Res1280x704Enable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(Ps3Res1280x704Enable), this, m_Ps3Res1280x704Enable, value)) m_Ps3Res1280x704Enable = value; } } // 0x7D (125)
		
		protected bool m_InitialClearEnable = new bool();
		[ContainerField(126), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(676050019)]
		public bool InitialClearEnable { get { return m_InitialClearEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(InitialClearEnable), this, m_InitialClearEnable, value)) m_InitialClearEnable = value; } } // 0x7E (126)
		
		protected bool m_GpuProfilerEnable = new bool();
		[ContainerField(127), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1651467743)]
		public bool GpuProfilerEnable { get { return m_GpuProfilerEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(GpuProfilerEnable), this, m_GpuProfilerEnable, value)) m_GpuProfilerEnable = value; } } // 0x7F (127)
		
		protected bool m_Ps3CellMemoryTexturesEnable = new bool();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1001772351)]
		public bool Ps3CellMemoryTexturesEnable { get { return m_Ps3CellMemoryTexturesEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(Ps3CellMemoryTexturesEnable), this, m_Ps3CellMemoryTexturesEnable, value)) m_Ps3CellMemoryTexturesEnable = value; } } // 0x80 (128)
		
		protected bool m_XenonBufferTwoFramesEnable = new bool();
		[ContainerField(129), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(609481908)]
		public bool XenonBufferTwoFramesEnable { get { return m_XenonBufferTwoFramesEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(XenonBufferTwoFramesEnable), this, m_XenonBufferTwoFramesEnable, value)) m_XenonBufferTwoFramesEnable = value; } } // 0x81 (129)
		
		protected bool m_DrawFpsHistogram = new bool();
		[ContainerField(130), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(109066192)]
		public bool DrawFpsHistogram { get { return m_DrawFpsHistogram; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(DrawFpsHistogram), this, m_DrawFpsHistogram, value)) m_DrawFpsHistogram = value; } } // 0x82 (130)
		
		protected bool m_Fullscreen = new bool();
		[ContainerField(131), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2248877754)]
		public bool Fullscreen { get { return m_Fullscreen; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(Fullscreen), this, m_Fullscreen, value)) m_Fullscreen = value; } } // 0x83 (131)
		
		protected bool m_PerfOverlayLatestFrameTimeEnable = new bool();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1529162668)]
		public bool PerfOverlayLatestFrameTimeEnable { get { return m_PerfOverlayLatestFrameTimeEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(PerfOverlayLatestFrameTimeEnable), this, m_PerfOverlayLatestFrameTimeEnable, value)) m_PerfOverlayLatestFrameTimeEnable = value; } } // 0x84 (132)
		
		protected bool m_JobEnable = new bool();
		[ContainerField(133), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(442685923)]
		public bool JobEnable { get { return m_JobEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(JobEnable), this, m_JobEnable, value)) m_JobEnable = value; } } // 0x85 (133)
		
		protected bool m_PerfOverlayVisible = new bool();
		[ContainerField(134), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2073387536)]
		public bool PerfOverlayVisible { get { return m_PerfOverlayVisible; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(PerfOverlayVisible), this, m_PerfOverlayVisible, value)) m_PerfOverlayVisible = value; } } // 0x86 (134)
		
		protected bool m_EmittersEnable = new bool();
		[ContainerField(135), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(121284033)]
		public bool EmittersEnable { get { return m_EmittersEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EmittersEnable), this, m_EmittersEnable, value)) m_EmittersEnable = value; } } // 0x87 (135)
		
		protected bool m_EdgeModelsEnable = new bool();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(928744923)]
		public bool EdgeModelsEnable { get { return m_EdgeModelsEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelsEnable), this, m_EdgeModelsEnable, value)) m_EdgeModelsEnable = value; } } // 0x88 (136)
		
		protected bool m_EdgeModelCastShadowsEnable = new bool();
		[ContainerField(137), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4261856024)]
		public bool EdgeModelCastShadowsEnable { get { return m_EdgeModelCastShadowsEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelCastShadowsEnable), this, m_EdgeModelCastShadowsEnable, value)) m_EdgeModelCastShadowsEnable = value; } } // 0x89 (137)
		
		protected bool m_EdgeModelDepthBiasEnable = new bool();
		[ContainerField(138), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3070669020)]
		public bool EdgeModelDepthBiasEnable { get { return m_EdgeModelDepthBiasEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelDepthBiasEnable), this, m_EdgeModelDepthBiasEnable, value)) m_EdgeModelDepthBiasEnable = value; } } // 0x8A (138)
		
		protected bool m_EdgeModelShadowDepthBiasEnable = new bool();
		[ContainerField(139), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3511388634)]
		public bool EdgeModelShadowDepthBiasEnable { get { return m_EdgeModelShadowDepthBiasEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelShadowDepthBiasEnable), this, m_EdgeModelShadowDepthBiasEnable, value)) m_EdgeModelShadowDepthBiasEnable = value; } } // 0x8B (139)
		
		protected bool m_VSyncFlashTestEnable = new bool();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2611047923)]
		public bool VSyncFlashTestEnable { get { return m_VSyncFlashTestEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(VSyncFlashTestEnable), this, m_VSyncFlashTestEnable, value)) m_VSyncFlashTestEnable = value; } } // 0x8C (140)
		
		protected bool m_EntityRenderEnable = new bool();
		[ContainerField(141), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1701938165)]
		public bool EntityRenderEnable { get { return m_EntityRenderEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EntityRenderEnable), this, m_EntityRenderEnable, value)) m_EntityRenderEnable = value; } } // 0x8D (141)
		
		protected bool m_EdgeModelSpuInstancingEnable = new bool();
		[ContainerField(142), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2066931218)]
		public bool EdgeModelSpuInstancingEnable { get { return m_EdgeModelSpuInstancingEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelSpuInstancingEnable), this, m_EdgeModelSpuInstancingEnable, value)) m_EdgeModelSpuInstancingEnable = value; } } // 0x8E (142)
		
		protected bool m_EdgeModelUseMainLodEnable = new bool();
		[ContainerField(143), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(711389031)]
		public bool EdgeModelUseMainLodEnable { get { return m_EdgeModelUseMainLodEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelUseMainLodEnable), this, m_EdgeModelUseMainLodEnable, value)) m_EdgeModelUseMainLodEnable = value; } } // 0x8F (143)
		
		protected bool m_DebugRenderServiceEnable = new bool();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(215748418)]
		public bool DebugRenderServiceEnable { get { return m_DebugRenderServiceEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(DebugRenderServiceEnable), this, m_DebugRenderServiceEnable, value)) m_DebugRenderServiceEnable = value; } } // 0x90 (144)
		
		protected bool m_EdgeModelUseLodBox = new bool();
		[ContainerField(145), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2867701848)]
		public bool EdgeModelUseLodBox { get { return m_EdgeModelUseLodBox; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelUseLodBox), this, m_EdgeModelUseLodBox, value)) m_EdgeModelUseLodBox = value; } } // 0x91 (145)
		
		protected bool m_DebugRendererEnable = new bool();
		[ContainerField(146), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4239334696)]
		public bool DebugRendererEnable { get { return m_DebugRendererEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(DebugRendererEnable), this, m_DebugRendererEnable, value)) m_DebugRendererEnable = value; } } // 0x92 (146)
		
		protected bool m_ForceVSyncEnable = new bool();
		[ContainerField(147), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1841857032)]
		public bool ForceVSyncEnable { get { return m_ForceVSyncEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(ForceVSyncEnable), this, m_ForceVSyncEnable, value)) m_ForceVSyncEnable = value; } } // 0x93 (147)
		
		protected bool m_EdgeModelCullEnable = new bool();
		[ContainerField(148), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1610471710)]
		public bool EdgeModelCullEnable { get { return m_EdgeModelCullEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelCullEnable), this, m_EdgeModelCullEnable, value)) m_EdgeModelCullEnable = value; } } // 0x94 (148)
		
		protected bool m_EdgeModelFrustumCullEnable = new bool();
		[ContainerField(149), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3571022816)]
		public bool EdgeModelFrustumCullEnable { get { return m_EdgeModelFrustumCullEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelFrustumCullEnable), this, m_EdgeModelFrustumCullEnable, value)) m_EdgeModelFrustumCullEnable = value; } } // 0x95 (149)
		
		protected bool m_EdgeModelOcclusionCullEnable = new bool();
		[ContainerField(150), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3807955731)]
		public bool EdgeModelOcclusionCullEnable { get { return m_EdgeModelOcclusionCullEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelOcclusionCullEnable), this, m_EdgeModelOcclusionCullEnable, value)) m_EdgeModelOcclusionCullEnable = value; } } // 0x96 (150)
		
		protected bool m_EdgeModelAdditionalCullEnable = new bool();
		[ContainerField(151), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2958104775)]
		public bool EdgeModelAdditionalCullEnable { get { return m_EdgeModelAdditionalCullEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelAdditionalCullEnable), this, m_EdgeModelAdditionalCullEnable, value)) m_EdgeModelAdditionalCullEnable = value; } } // 0x97 (151)
		
		protected bool m_EdgeModelDrawBoxes = new bool();
		[ContainerField(152), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3437926730)]
		public bool EdgeModelDrawBoxes { get { return m_EdgeModelDrawBoxes; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelDrawBoxes), this, m_EdgeModelDrawBoxes, value)) m_EdgeModelDrawBoxes = value; } } // 0x98 (152)
		
		protected bool m_EdgeModelDrawStats = new bool();
		[ContainerField(153), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3457602056)]
		public bool EdgeModelDrawStats { get { return m_EdgeModelDrawStats; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(EdgeModelDrawStats), this, m_EdgeModelDrawStats, value)) m_EdgeModelDrawStats = value; } } // 0x99 (153)
		
		protected bool m_StaticModelEnable = new bool();
		[ContainerField(154), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(16174035)]
		public bool StaticModelEnable { get { return m_StaticModelEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StaticModelEnable), this, m_StaticModelEnable, value)) m_StaticModelEnable = value; } } // 0x9A (154)
		
		protected bool m_StaticModelMeshesEnable = new bool();
		[ContainerField(155), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3520548374)]
		public bool StaticModelMeshesEnable { get { return m_StaticModelMeshesEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StaticModelMeshesEnable), this, m_StaticModelMeshesEnable, value)) m_StaticModelMeshesEnable = value; } } // 0x9B (155)
		
		protected bool m_StaticModelZPassEnable = new bool();
		[ContainerField(156), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(157779288)]
		public bool StaticModelZPassEnable { get { return m_StaticModelZPassEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StaticModelZPassEnable), this, m_StaticModelZPassEnable, value)) m_StaticModelZPassEnable = value; } } // 0x9C (156)
		
		protected bool m_StaticModelPartCullEnable = new bool();
		[ContainerField(157), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(756373810)]
		public bool StaticModelPartCullEnable { get { return m_StaticModelPartCullEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StaticModelPartCullEnable), this, m_StaticModelPartCullEnable, value)) m_StaticModelPartCullEnable = value; } } // 0x9D (157)
		
		protected bool m_StaticModelPartFrustumCullEnable = new bool();
		[ContainerField(158), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2549275532)]
		public bool StaticModelPartFrustumCullEnable { get { return m_StaticModelPartFrustumCullEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StaticModelPartFrustumCullEnable), this, m_StaticModelPartFrustumCullEnable, value)) m_StaticModelPartFrustumCullEnable = value; } } // 0x9E (158)
		
		protected bool m_StaticModelPartOcclusionCullEnable = new bool();
		[ContainerField(159), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3865476287)]
		public bool StaticModelPartOcclusionCullEnable { get { return m_StaticModelPartOcclusionCullEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StaticModelPartOcclusionCullEnable), this, m_StaticModelPartOcclusionCullEnable, value)) m_StaticModelPartOcclusionCullEnable = value; } } // 0x9F (159)
		
		protected bool m_StaticModelPartShadowCullEnable = new bool();
		[ContainerField(160), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1569108020)]
		public bool StaticModelPartShadowCullEnable { get { return m_StaticModelPartShadowCullEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StaticModelPartShadowCullEnable), this, m_StaticModelPartShadowCullEnable, value)) m_StaticModelPartShadowCullEnable = value; } } // 0xA0 (160)
		
		protected bool m_StaticModelDrawBoxes = new bool();
		[ContainerField(161), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2399189489)]
		public bool StaticModelDrawBoxes { get { return m_StaticModelDrawBoxes; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StaticModelDrawBoxes), this, m_StaticModelDrawBoxes, value)) m_StaticModelDrawBoxes = value; } } // 0xA1 (161)
		
		protected bool m_StaticModelDrawStats = new bool();
		[ContainerField(162), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2379235123)]
		public bool StaticModelDrawStats { get { return m_StaticModelDrawStats; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StaticModelDrawStats), this, m_StaticModelDrawStats, value)) m_StaticModelDrawStats = value; } } // 0xA2 (162)
		
		protected bool m_DrawScreenInfo = new bool();
		[ContainerField(163), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2003014247)]
		public bool DrawScreenInfo { get { return m_DrawScreenInfo; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(DrawScreenInfo), this, m_DrawScreenInfo, value)) m_DrawScreenInfo = value; } } // 0xA3 (163)
		
		protected bool m_ForceOrthoViewEnable = new bool();
		[ContainerField(164), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3649401946)]
		public bool ForceOrthoViewEnable { get { return m_ForceOrthoViewEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(ForceOrthoViewEnable), this, m_ForceOrthoViewEnable, value)) m_ForceOrthoViewEnable = value; } } // 0xA4 (164)
		
		protected bool m_StaticModelCullSpuJobEnable = new bool();
		[ContainerField(165), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1653994164)]
		public bool StaticModelCullSpuJobEnable { get { return m_StaticModelCullSpuJobEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(StaticModelCullSpuJobEnable), this, m_StaticModelCullSpuJobEnable, value)) m_StaticModelCullSpuJobEnable = value; } } // 0xA5 (165)
		
		protected bool m_LockView = new bool();
		[ContainerField(166), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1982163459)]
		public bool LockView { get { return m_LockView; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(LockView), this, m_LockView, value)) m_LockView = value; } } // 0xA6 (166)
		
		protected bool m_ResetLockedView = new bool();
		[ContainerField(167), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2200752407)]
		public bool ResetLockedView { get { return m_ResetLockedView; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(ResetLockedView), this, m_ResetLockedView, value)) m_ResetLockedView = value; } } // 0xA7 (167)
		
		protected bool m_DrawInfo = new bool();
		[ContainerField(168), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3456547147)]
		public bool DrawInfo { get { return m_DrawInfo; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(DrawInfo), this, m_DrawInfo, value)) m_DrawInfo = value; } } // 0xA8 (168)
		
		protected bool m_FadeEnable = new bool();
		[ContainerField(169), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1633100994)]
		public bool FadeEnable { get { return m_FadeEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(FadeEnable), this, m_FadeEnable, value)) m_FadeEnable = value; } } // 0xA9 (169)
		
		protected bool m_FadeWaitingEnable = new bool();
		[ContainerField(170), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3804420041)]
		public bool FadeWaitingEnable { get { return m_FadeWaitingEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(FadeWaitingEnable), this, m_FadeWaitingEnable, value)) m_FadeWaitingEnable = value; } } // 0xAA (170)
		
		protected bool m_DrawFps = new bool();
		[ContainerField(171), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(365038176)]
		public bool DrawFps { get { return m_DrawFps; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(DrawFps), this, m_DrawFps, value)) m_DrawFps = value; } } // 0xAB (171)
		
		protected bool m_DestructionVolumeDrawEnable = new bool();
		[ContainerField(172), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3224392434)]
		public bool DestructionVolumeDrawEnable { get { return m_DestructionVolumeDrawEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(DestructionVolumeDrawEnable), this, m_DestructionVolumeDrawEnable, value)) m_DestructionVolumeDrawEnable = value; } } // 0xAC (172)
		
		protected bool m_BlurEnable = new bool();
		[ContainerField(173), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1072996973)]
		public bool BlurEnable { get { return m_BlurEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(BlurEnable), this, m_BlurEnable, value)) m_BlurEnable = value; } } // 0xAD (173)
		
		protected bool m_BuildJobSyncEnable = new bool();
		[ContainerField(174), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3715134706)]
		public bool BuildJobSyncEnable { get { return m_BuildJobSyncEnable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(BuildJobSyncEnable), this, m_BuildJobSyncEnable, value)) m_BuildJobSyncEnable = value; } } // 0xAE (174)
		
		protected bool m_ForceSquareOrthoView = new bool();
		[ContainerField(175), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1356920058)]
		public bool ForceSquareOrthoView { get { return m_ForceSquareOrthoView; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(ForceSquareOrthoView), this, m_ForceSquareOrthoView, value)) m_ForceSquareOrthoView = value; } } // 0xAF (175)
		
		protected bool m_Enable = new bool();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("GameRenderSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0xB0 (176)
		
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
