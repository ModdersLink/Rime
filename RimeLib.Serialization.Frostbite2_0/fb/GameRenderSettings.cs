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
	[ContainerType(4, 180)]
	public partial class GameRenderSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _StereoCrosshairDampingFactor;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _InactiveSkipFrameCount;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _ForceOrthoViewSize;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _StereoCrosshairRadius;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _StereoCrosshairMaxHitDepth;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _ForceBlurAmount;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _DrawFpsMethod;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _ForceFov;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _FovMultiplier;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _StaticModelPartOcclusionMaxScreenArea;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private uint _StaticModelCullJobCount;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _EdgeModelLodScale;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _EdgeModelScreenAreaScale;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private uint _XenonRingBufferSize;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private uint _SplitScreenTestViewCount;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private uint _XenonPresentImmediateThreshold;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private uint _XenonGammaRampType;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private uint _Ps3VSyncMethod;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _Ps3VideoGamma;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private uint _Ps3FrameMainBufferSize;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private uint _Ps3FrameLocalBufferSize;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _ViewDistance;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _CameraCutMaxFrameTranslation;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _NearPlane;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _ForceWorldFadeAmount;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private uint _EdgeModelMaxVisibleInstanceCount;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private int _EdgeModelForceLod;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _EdgeModelViewDistance;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private bool _Ps3LinearFrameCmdBufEnable;

		[ObservableProperty]
		[property: ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		private bool _XenonRes1280x704Enable;

		[ObservableProperty]
		[property: ContainerField(122), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
		private bool _PerfOverlayEnable;

		[ObservableProperty]
		[property: ContainerField(123), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
		private bool _GcmHudEnable;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private bool _MovieVSyncEnable;

		[ObservableProperty]
		[property: ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		private bool _Ps3Res1280x704Enable;

		[ObservableProperty]
		[property: ContainerField(126), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
		private bool _InitialClearEnable;

		[ObservableProperty]
		[property: ContainerField(127), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
		private bool _GpuProfilerEnable;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private bool _Ps3CellMemoryTexturesEnable;

		[ObservableProperty]
		[property: ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		private bool _XenonBufferTwoFramesEnable;

		[ObservableProperty]
		[property: ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		private bool _DrawFpsHistogram;

		[ObservableProperty]
		[property: ContainerField(131), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
		private bool _Fullscreen;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private bool _PerfOverlayLatestFrameTimeEnable;

		[ObservableProperty]
		[property: ContainerField(133), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
		private bool _JobEnable;

		[ObservableProperty]
		[property: ContainerField(134), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
		private bool _PerfOverlayVisible;

		[ObservableProperty]
		[property: ContainerField(135), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
		private bool _EmittersEnable;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private bool _EdgeModelsEnable;

		[ObservableProperty]
		[property: ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		private bool _EdgeModelCastShadowsEnable;

		[ObservableProperty]
		[property: ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		private bool _EdgeModelDepthBiasEnable;

		[ObservableProperty]
		[property: ContainerField(139), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
		private bool _EdgeModelShadowDepthBiasEnable;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private bool _VSyncFlashTestEnable;

		[ObservableProperty]
		[property: ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		private bool _EntityRenderEnable;

		[ObservableProperty]
		[property: ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		private bool _EdgeModelSpuInstancingEnable;

		[ObservableProperty]
		[property: ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		private bool _EdgeModelUseMainLodEnable;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private bool _DebugRenderServiceEnable;

		[ObservableProperty]
		[property: ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		private bool _EdgeModelUseLodBox;

		[ObservableProperty]
		[property: ContainerField(146), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
		private bool _DebugRendererEnable;

		[ObservableProperty]
		[property: ContainerField(147), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
		private bool _ForceVSyncEnable;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private bool _EdgeModelCullEnable;

		[ObservableProperty]
		[property: ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		private bool _EdgeModelFrustumCullEnable;

		[ObservableProperty]
		[property: ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		private bool _EdgeModelOcclusionCullEnable;

		[ObservableProperty]
		[property: ContainerField(151), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
		private bool _EdgeModelAdditionalCullEnable;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private bool _EdgeModelDrawBoxes;

		[ObservableProperty]
		[property: ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		private bool _EdgeModelDrawStats;

		[ObservableProperty]
		[property: ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		private bool _StaticModelEnable;

		[ObservableProperty]
		[property: ContainerField(155), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
		private bool _StaticModelMeshesEnable;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private bool _StaticModelZPassEnable;

		[ObservableProperty]
		[property: ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		private bool _StaticModelPartCullEnable;

		[ObservableProperty]
		[property: ContainerField(158), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
		private bool _StaticModelPartFrustumCullEnable;

		[ObservableProperty]
		[property: ContainerField(159), LayoutImmutable, Blittable, JsonProperty(Order = 159)]
		private bool _StaticModelPartOcclusionCullEnable;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private bool _StaticModelPartShadowCullEnable;

		[ObservableProperty]
		[property: ContainerField(161), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
		private bool _StaticModelDrawBoxes;

		[ObservableProperty]
		[property: ContainerField(162), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
		private bool _StaticModelDrawStats;

		[ObservableProperty]
		[property: ContainerField(163), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
		private bool _DrawScreenInfo;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private bool _ForceOrthoViewEnable;

		[ObservableProperty]
		[property: ContainerField(165), LayoutImmutable, Blittable, JsonProperty(Order = 165)]
		private bool _StaticModelCullSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(166), LayoutImmutable, Blittable, JsonProperty(Order = 166)]
		private bool _LockView;

		[ObservableProperty]
		[property: ContainerField(167), LayoutImmutable, Blittable, JsonProperty(Order = 167)]
		private bool _ResetLockedView;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private bool _DrawInfo;

		[ObservableProperty]
		[property: ContainerField(169), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
		private bool _FadeEnable;

		[ObservableProperty]
		[property: ContainerField(170), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
		private bool _FadeWaitingEnable;

		[ObservableProperty]
		[property: ContainerField(171), LayoutImmutable, Blittable, JsonProperty(Order = 171)]
		private bool _DrawFps;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private bool _DestructionVolumeDrawEnable;

		[ObservableProperty]
		[property: ContainerField(173), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
		private bool _BlurEnable;

		[ObservableProperty]
		[property: ContainerField(174), LayoutImmutable, Blittable, JsonProperty(Order = 174)]
		private bool _BuildJobSyncEnable;

		[ObservableProperty]
		[property: ContainerField(175), LayoutImmutable, Blittable, JsonProperty(Order = 175)]
		private bool _ForceSquareOrthoView;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private bool _Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
