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
	[ContainerType(4, 180)]
	public class GameRenderSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float StereoCrosshairDampingFactor { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint InactiveSkipFrameCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float ForceOrthoViewSize { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float StereoCrosshairRadius { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float StereoCrosshairMaxHitDepth { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float ForceBlurAmount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint DrawFpsMethod { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float ForceFov { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float FovMultiplier { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float StaticModelPartOcclusionMaxScreenArea { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public uint StaticModelCullJobCount { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float EdgeModelLodScale { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float EdgeModelScreenAreaScale { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public uint XenonRingBufferSize { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public uint SplitScreenTestViewCount { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public uint XenonPresentImmediateThreshold { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public uint XenonGammaRampType { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public uint Ps3VSyncMethod { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float Ps3VideoGamma { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public uint Ps3FrameMainBufferSize { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public uint Ps3FrameLocalBufferSize { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float CameraCutMaxFrameTranslation { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float NearPlane { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float ForceWorldFadeAmount { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public uint EdgeModelMaxVisibleInstanceCount { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public int EdgeModelForceLod { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float EdgeModelViewDistance { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public bool Ps3LinearFrameCmdBufEnable { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable]
		public bool XenonRes1280x704Enable { get; set; }

		[ContainerField(122), LayoutImmutable, Blittable]
		public bool PerfOverlayEnable { get; set; }

		[ContainerField(123), LayoutImmutable, Blittable]
		public bool GcmHudEnable { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool MovieVSyncEnable { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool Ps3Res1280x704Enable { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable]
		public bool InitialClearEnable { get; set; }

		[ContainerField(127), LayoutImmutable, Blittable]
		public bool GpuProfilerEnable { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool Ps3CellMemoryTexturesEnable { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable]
		public bool XenonBufferTwoFramesEnable { get; set; }

		[ContainerField(130), LayoutImmutable, Blittable]
		public bool DrawFpsHistogram { get; set; }

		[ContainerField(131), LayoutImmutable, Blittable]
		public bool Fullscreen { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public bool PerfOverlayLatestFrameTimeEnable { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable]
		public bool JobEnable { get; set; }

		[ContainerField(134), LayoutImmutable, Blittable]
		public bool PerfOverlayVisible { get; set; }

		[ContainerField(135), LayoutImmutable, Blittable]
		public bool EmittersEnable { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public bool EdgeModelsEnable { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable]
		public bool EdgeModelCastShadowsEnable { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable]
		public bool EdgeModelDepthBiasEnable { get; set; }

		[ContainerField(139), LayoutImmutable, Blittable]
		public bool EdgeModelShadowDepthBiasEnable { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public bool VSyncFlashTestEnable { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable]
		public bool EntityRenderEnable { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable]
		public bool EdgeModelSpuInstancingEnable { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable]
		public bool EdgeModelUseMainLodEnable { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool DebugRenderServiceEnable { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable]
		public bool EdgeModelUseLodBox { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable]
		public bool DebugRendererEnable { get; set; }

		[ContainerField(147), LayoutImmutable, Blittable]
		public bool ForceVSyncEnable { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public bool EdgeModelCullEnable { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable]
		public bool EdgeModelFrustumCullEnable { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable]
		public bool EdgeModelOcclusionCullEnable { get; set; }

		[ContainerField(151), LayoutImmutable, Blittable]
		public bool EdgeModelAdditionalCullEnable { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public bool EdgeModelDrawBoxes { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable]
		public bool EdgeModelDrawStats { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable]
		public bool StaticModelEnable { get; set; }

		[ContainerField(155), LayoutImmutable, Blittable]
		public bool StaticModelMeshesEnable { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public bool StaticModelZPassEnable { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable]
		public bool StaticModelPartCullEnable { get; set; }

		[ContainerField(158), LayoutImmutable, Blittable]
		public bool StaticModelPartFrustumCullEnable { get; set; }

		[ContainerField(159), LayoutImmutable, Blittable]
		public bool StaticModelPartOcclusionCullEnable { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public bool StaticModelPartShadowCullEnable { get; set; }

		[ContainerField(161), LayoutImmutable, Blittable]
		public bool StaticModelDrawBoxes { get; set; }

		[ContainerField(162), LayoutImmutable, Blittable]
		public bool StaticModelDrawStats { get; set; }

		[ContainerField(163), LayoutImmutable, Blittable]
		public bool DrawScreenInfo { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public bool ForceOrthoViewEnable { get; set; }

		[ContainerField(165), LayoutImmutable, Blittable]
		public bool StaticModelCullSpuJobEnable { get; set; }

		[ContainerField(166), LayoutImmutable, Blittable]
		public bool LockView { get; set; }

		[ContainerField(167), LayoutImmutable, Blittable]
		public bool ResetLockedView { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public bool DrawInfo { get; set; }

		[ContainerField(169), LayoutImmutable, Blittable]
		public bool FadeEnable { get; set; }

		[ContainerField(170), LayoutImmutable, Blittable]
		public bool FadeWaitingEnable { get; set; }

		[ContainerField(171), LayoutImmutable, Blittable]
		public bool DrawFps { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public bool DestructionVolumeDrawEnable { get; set; }

		[ContainerField(173), LayoutImmutable, Blittable]
		public bool BlurEnable { get; set; }

		[ContainerField(174), LayoutImmutable, Blittable]
		public bool BuildJobSyncEnable { get; set; }

		[ContainerField(175), LayoutImmutable, Blittable]
		public bool ForceSquareOrthoView { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

	}
}
