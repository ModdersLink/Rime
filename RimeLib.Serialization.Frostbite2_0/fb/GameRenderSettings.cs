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
	[ContainerType(4, 180)]
	public class GameRenderSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float StereoCrosshairDampingFactor { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint InactiveSkipFrameCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float ForceOrthoViewSize { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float StereoCrosshairRadius { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float StereoCrosshairMaxHitDepth { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ForceBlurAmount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint DrawFpsMethod { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float ForceFov { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float FovMultiplier { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float StaticModelPartOcclusionMaxScreenArea { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public uint StaticModelCullJobCount { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float EdgeModelLodScale { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float EdgeModelScreenAreaScale { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public uint XenonRingBufferSize { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public uint SplitScreenTestViewCount { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public uint XenonPresentImmediateThreshold { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public uint XenonGammaRampType { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public uint Ps3VSyncMethod { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float Ps3VideoGamma { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public uint Ps3FrameMainBufferSize { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public uint Ps3FrameLocalBufferSize { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float ViewDistance { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float CameraCutMaxFrameTranslation { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float NearPlane { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float ForceWorldFadeAmount { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public uint EdgeModelMaxVisibleInstanceCount { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public int EdgeModelForceLod { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float EdgeModelViewDistance { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public bool Ps3LinearFrameCmdBufEnable { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		public bool XenonRes1280x704Enable { get; set; }

		[ContainerField(122), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
		public bool PerfOverlayEnable { get; set; }

		[ContainerField(123), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
		public bool GcmHudEnable { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public bool MovieVSyncEnable { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		public bool Ps3Res1280x704Enable { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
		public bool InitialClearEnable { get; set; }

		[ContainerField(127), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
		public bool GpuProfilerEnable { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public bool Ps3CellMemoryTexturesEnable { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		public bool XenonBufferTwoFramesEnable { get; set; }

		[ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		public bool DrawFpsHistogram { get; set; }

		[ContainerField(131), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
		public bool Fullscreen { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public bool PerfOverlayLatestFrameTimeEnable { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
		public bool JobEnable { get; set; }

		[ContainerField(134), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
		public bool PerfOverlayVisible { get; set; }

		[ContainerField(135), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
		public bool EmittersEnable { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public bool EdgeModelsEnable { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		public bool EdgeModelCastShadowsEnable { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		public bool EdgeModelDepthBiasEnable { get; set; }

		[ContainerField(139), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
		public bool EdgeModelShadowDepthBiasEnable { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public bool VSyncFlashTestEnable { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		public bool EntityRenderEnable { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		public bool EdgeModelSpuInstancingEnable { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		public bool EdgeModelUseMainLodEnable { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public bool DebugRenderServiceEnable { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		public bool EdgeModelUseLodBox { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
		public bool DebugRendererEnable { get; set; }

		[ContainerField(147), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
		public bool ForceVSyncEnable { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public bool EdgeModelCullEnable { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		public bool EdgeModelFrustumCullEnable { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		public bool EdgeModelOcclusionCullEnable { get; set; }

		[ContainerField(151), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
		public bool EdgeModelAdditionalCullEnable { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public bool EdgeModelDrawBoxes { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		public bool EdgeModelDrawStats { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		public bool StaticModelEnable { get; set; }

		[ContainerField(155), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
		public bool StaticModelMeshesEnable { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public bool StaticModelZPassEnable { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		public bool StaticModelPartCullEnable { get; set; }

		[ContainerField(158), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
		public bool StaticModelPartFrustumCullEnable { get; set; }

		[ContainerField(159), LayoutImmutable, Blittable, JsonProperty(Order = 159)]
		public bool StaticModelPartOcclusionCullEnable { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public bool StaticModelPartShadowCullEnable { get; set; }

		[ContainerField(161), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
		public bool StaticModelDrawBoxes { get; set; }

		[ContainerField(162), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
		public bool StaticModelDrawStats { get; set; }

		[ContainerField(163), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
		public bool DrawScreenInfo { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public bool ForceOrthoViewEnable { get; set; }

		[ContainerField(165), LayoutImmutable, Blittable, JsonProperty(Order = 165)]
		public bool StaticModelCullSpuJobEnable { get; set; }

		[ContainerField(166), LayoutImmutable, Blittable, JsonProperty(Order = 166)]
		public bool LockView { get; set; }

		[ContainerField(167), LayoutImmutable, Blittable, JsonProperty(Order = 167)]
		public bool ResetLockedView { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public bool DrawInfo { get; set; }

		[ContainerField(169), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
		public bool FadeEnable { get; set; }

		[ContainerField(170), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
		public bool FadeWaitingEnable { get; set; }

		[ContainerField(171), LayoutImmutable, Blittable, JsonProperty(Order = 171)]
		public bool DrawFps { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public bool DestructionVolumeDrawEnable { get; set; }

		[ContainerField(173), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
		public bool BlurEnable { get; set; }

		[ContainerField(174), LayoutImmutable, Blittable, JsonProperty(Order = 174)]
		public bool BuildJobSyncEnable { get; set; }

		[ContainerField(175), LayoutImmutable, Blittable, JsonProperty(Order = 175)]
		public bool ForceSquareOrthoView { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public bool Enable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(StereoCrosshairDampingFactor);
			p_Writer.Write(InactiveSkipFrameCount);
			p_Writer.Write(ForceOrthoViewSize);
			p_Writer.Write(StereoCrosshairRadius);
			p_Writer.Write(StereoCrosshairMaxHitDepth);
			p_Writer.Write(ForceBlurAmount);
			p_Writer.Write(DrawFpsMethod);
			p_Writer.Write(ForceFov);
			p_Writer.Write(FovMultiplier);
			p_Writer.Write(StaticModelPartOcclusionMaxScreenArea);
			p_Writer.Write(StaticModelCullJobCount);
			p_Writer.Write(EdgeModelLodScale);
			p_Writer.Write(EdgeModelScreenAreaScale);
			p_Writer.Write(XenonRingBufferSize);
			p_Writer.Write(SplitScreenTestViewCount);
			p_Writer.Write(XenonPresentImmediateThreshold);
			p_Writer.Write(XenonGammaRampType);
			p_Writer.Write(Ps3VSyncMethod);
			p_Writer.Write(Ps3VideoGamma);
			p_Writer.Write(Ps3FrameMainBufferSize);
			p_Writer.Write(Ps3FrameLocalBufferSize);
			p_Writer.Write(ViewDistance);
			p_Writer.Write(CameraCutMaxFrameTranslation);
			p_Writer.Write(NearPlane);
			p_Writer.Write(ForceWorldFadeAmount);
			p_Writer.Write(EdgeModelMaxVisibleInstanceCount);
			p_Writer.Write(EdgeModelForceLod);
			p_Writer.Write(EdgeModelViewDistance);
			p_Writer.Write(Ps3LinearFrameCmdBufEnable);
			p_Writer.Write(XenonRes1280x704Enable);
			p_Writer.Write(PerfOverlayEnable);
			p_Writer.Write(GcmHudEnable);
			p_Writer.Write(MovieVSyncEnable);
			p_Writer.Write(Ps3Res1280x704Enable);
			p_Writer.Write(InitialClearEnable);
			p_Writer.Write(GpuProfilerEnable);
			p_Writer.Write(Ps3CellMemoryTexturesEnable);
			p_Writer.Write(XenonBufferTwoFramesEnable);
			p_Writer.Write(DrawFpsHistogram);
			p_Writer.Write(Fullscreen);
			p_Writer.Write(PerfOverlayLatestFrameTimeEnable);
			p_Writer.Write(JobEnable);
			p_Writer.Write(PerfOverlayVisible);
			p_Writer.Write(EmittersEnable);
			p_Writer.Write(EdgeModelsEnable);
			p_Writer.Write(EdgeModelCastShadowsEnable);
			p_Writer.Write(EdgeModelDepthBiasEnable);
			p_Writer.Write(EdgeModelShadowDepthBiasEnable);
			p_Writer.Write(VSyncFlashTestEnable);
			p_Writer.Write(EntityRenderEnable);
			p_Writer.Write(EdgeModelSpuInstancingEnable);
			p_Writer.Write(EdgeModelUseMainLodEnable);
			p_Writer.Write(DebugRenderServiceEnable);
			p_Writer.Write(EdgeModelUseLodBox);
			p_Writer.Write(DebugRendererEnable);
			p_Writer.Write(ForceVSyncEnable);
			p_Writer.Write(EdgeModelCullEnable);
			p_Writer.Write(EdgeModelFrustumCullEnable);
			p_Writer.Write(EdgeModelOcclusionCullEnable);
			p_Writer.Write(EdgeModelAdditionalCullEnable);
			p_Writer.Write(EdgeModelDrawBoxes);
			p_Writer.Write(EdgeModelDrawStats);
			p_Writer.Write(StaticModelEnable);
			p_Writer.Write(StaticModelMeshesEnable);
			p_Writer.Write(StaticModelZPassEnable);
			p_Writer.Write(StaticModelPartCullEnable);
			p_Writer.Write(StaticModelPartFrustumCullEnable);
			p_Writer.Write(StaticModelPartOcclusionCullEnable);
			p_Writer.Write(StaticModelPartShadowCullEnable);
			p_Writer.Write(StaticModelDrawBoxes);
			p_Writer.Write(StaticModelDrawStats);
			p_Writer.Write(DrawScreenInfo);
			p_Writer.Write(ForceOrthoViewEnable);
			p_Writer.Write(StaticModelCullSpuJobEnable);
			p_Writer.Write(LockView);
			p_Writer.Write(ResetLockedView);
			p_Writer.Write(DrawInfo);
			p_Writer.Write(FadeEnable);
			p_Writer.Write(FadeWaitingEnable);
			p_Writer.Write(DrawFps);
			p_Writer.Write(DestructionVolumeDrawEnable);
			p_Writer.Write(BlurEnable);
			p_Writer.Write(BuildJobSyncEnable);
			p_Writer.Write(ForceSquareOrthoView);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(3);
		}
	}
}
