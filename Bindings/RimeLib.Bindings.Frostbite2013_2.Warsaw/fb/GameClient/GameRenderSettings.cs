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

using fb.Core;

namespace fb.GameClient;

[ContainerType(8, 200)]
public class GameRenderSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint InactiveSkipFrameCount { get; set; } = 0;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float ResolutionScale { get; set; } = 1.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public int MantleEnable { get; set; } = -1;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public uint XenonRingBufferSize { get; set; } = 2097152;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint XenonLinearFrameBufferSize { get; set; } = 204800;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint XenonPresentImmediateThreshold { get; set; } = 100;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint XenonGammaRampType { get; set; } = 1;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float Ps3VideoGamma { get; set; } = 1.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint Ps3FrameMainBufferSize { get; set; } = 0;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public uint Ps3FrameLocalBufferSize { get; set; } = 0;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint Ps3VSyncMethod { get; set; } = 1;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float CameraCutMaxFrameTranslation { get; set; } = 2.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float NearPlane { get; set; } = 0.100f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float ViewDistance { get; set; } = 20000.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float ForceFov { get; set; } = -1.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float FovMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float ForceOrthoViewSize { get; set; } = 10.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float EdgeModelScreenAreaScale { get; set; } = 1.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float EdgeModelViewDistance { get; set; } = 50.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public int EdgeModelForceLod { get; set; } = -1;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float EdgeModelLodScale { get; set; } = 1.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public uint EdgeModelMaxVisibleInstanceCount { get; set; } = 2048;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float StaticModelPartOcclusionMaxScreenArea { get; set; } = 0.070f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public uint StaticModelCullJobCount { get; set; } = 6;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public uint SplitScreenTestViewCount { get; set; } = 1;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public uint SplitScreenTestCase { get; set; } = 0;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float ForceBlurAmount { get; set; } = -1.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float ForceWorldFadeAmount { get; set; } = -1.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float StereoCrosshairMaxHitDepth { get; set; } = 100.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float StereoCrosshairRadius { get; set; } = 0.100f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float StereoCrosshairDampingFactor { get; set; } = 0.100f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x8d), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
	public bool NullRendererEnable { get; set; } = false;
	
	[ContainerField(0x8e), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
	public bool JobEnable { get; set; } = true;
	
	[ContainerField(0x8f), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
	public bool BuildJobSyncEnable { get; set; } = false;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public bool EarlyGpuSyncEnable { get; set; } = false;
	
	[ContainerField(0x91), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
	public bool DrawDebugInfo { get; set; } = false;
	
	[ContainerField(0x92), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
	public bool DrawScreenInfo { get; set; } = false;
	
	[ContainerField(0x93), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
	public bool Fullscreen { get; set; } = false;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public bool ForceVSyncEnable { get; set; } = false;
	
	[ContainerField(0x95), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
	public bool MovieVSyncEnable { get; set; } = true;
	
	[ContainerField(0x96), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
	public bool VSyncFlashTestEnable { get; set; } = false;
	
	[ContainerField(0x97), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
	public bool OutputBrightnessTestEnable { get; set; } = false;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public bool XenonBufferTwoFramesEnable { get; set; } = true;
	
	[ContainerField(0x99), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
	public bool XenonRes1280x704Enable { get; set; } = true;
	
	[ContainerField(0x9a), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
	public bool Ps3LinearFrameCmdBufEnable { get; set; } = true;
	
	[ContainerField(0x9b), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
	public bool Ps3CellMemoryTexturesEnable { get; set; } = false;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public bool GcmHudEnable { get; set; } = false;
	
	[ContainerField(0x9d), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
	public bool Ps3Res1280x704Enable { get; set; } = true;
	
	[ContainerField(0x9e), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
	public bool Gen4bColorRemap { get; set; } = true;
	
	[ContainerField(0x9f), LayoutImmutable, Blittable, JsonProperty(Order = 159)]
	public bool GpuTextureCompressorEnable { get; set; } = true;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public bool EmittersEnable { get; set; } = true;
	
	[ContainerField(0xa1), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
	public bool EntityRenderEnable { get; set; } = true;
	
	[ContainerField(0xa2), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
	public bool DebugRendererEnable { get; set; } = true;
	
	[ContainerField(0xa3), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
	public bool DebugRenderServiceEnable { get; set; } = false;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public bool InitialClearEnable { get; set; } = false;
	
	[ContainerField(0xa5), LayoutImmutable, Blittable, JsonProperty(Order = 165)]
	public bool GpuProfilerEnable { get; set; } = true;
	
	[ContainerField(0xa6), LayoutImmutable, Blittable, JsonProperty(Order = 166)]
	public bool ForceOrthoViewEnable { get; set; } = false;
	
	[ContainerField(0xa7), LayoutImmutable, Blittable, JsonProperty(Order = 167)]
	public bool ForceSquareOrthoView { get; set; } = false;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public bool DestructionVolumeDrawEnable { get; set; } = true;
	
	[ContainerField(0xa9), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
	public bool EdgeModelsEnable { get; set; } = true;
	
	[ContainerField(0xaa), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
	public bool EdgeModelCastShadowsEnable { get; set; } = false;
	
	[ContainerField(0xab), LayoutImmutable, Blittable, JsonProperty(Order = 171)]
	public bool EdgeModelDepthBiasEnable { get; set; } = false;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public bool EdgeModelShadowDepthBiasEnable { get; set; } = false;
	
	[ContainerField(0xad), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
	public bool EdgeModelSpuInstancingEnable { get; set; } = false;
	
	[ContainerField(0xae), LayoutImmutable, Blittable, JsonProperty(Order = 174)]
	public bool EdgeModelUseMainLodEnable { get; set; } = false;
	
	[ContainerField(0xaf), LayoutImmutable, Blittable, JsonProperty(Order = 175)]
	public bool EdgeModelUseLodBox { get; set; } = true;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public bool EdgeModelCullEnable { get; set; } = true;
	
	[ContainerField(0xb1), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
	public bool EdgeModelFrustumCullEnable { get; set; } = true;
	
	[ContainerField(0xb2), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
	public bool EdgeModelOcclusionCullEnable { get; set; } = true;
	
	[ContainerField(0xb3), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
	public bool EdgeModelDrawBoxes { get; set; } = false;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public bool EdgeModelDrawStats { get; set; } = false;
	
	[ContainerField(0xb5), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
	public bool StaticModelEnable { get; set; } = true;
	
	[ContainerField(0xb6), LayoutImmutable, Blittable, JsonProperty(Order = 182)]
	public bool StaticModelMeshesEnable { get; set; } = true;
	
	[ContainerField(0xb7), LayoutImmutable, Blittable, JsonProperty(Order = 183)]
	public bool StaticModelZPassEnable { get; set; } = false;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public bool StaticModelPartCullEnable { get; set; } = false;
	
	[ContainerField(0xb9), LayoutImmutable, Blittable, JsonProperty(Order = 185)]
	public bool StaticModelPartFrustumCullEnable { get; set; } = true;
	
	[ContainerField(0xba), LayoutImmutable, Blittable, JsonProperty(Order = 186)]
	public bool StaticModelPartOcclusionCullEnable { get; set; } = true;
	
	[ContainerField(0xbb), LayoutImmutable, Blittable, JsonProperty(Order = 187)]
	public bool StaticModelPartShadowCullEnable { get; set; } = false;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public bool StaticModelDrawBoxes { get; set; } = false;
	
	[ContainerField(0xbd), LayoutImmutable, Blittable, JsonProperty(Order = 189)]
	public bool StaticModelDrawStats { get; set; } = false;
	
	[ContainerField(0xbe), LayoutImmutable, Blittable, JsonProperty(Order = 190)]
	public bool StaticModelCullSpuJobEnable { get; set; } = true;
	
	[ContainerField(0xbf), LayoutImmutable, Blittable, JsonProperty(Order = 191)]
	public bool StaticModelSurfaceShaderTerrainAccessEnable { get; set; } = true;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public bool LockView { get; set; } = false;
	
	[ContainerField(0xc1), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
	public bool ResetLockedView { get; set; } = false;
	
	[ContainerField(0xc2), LayoutImmutable, Blittable, JsonProperty(Order = 194)]
	public bool SecondaryStreamingViewEnable { get; set; } = true;
	
	[ContainerField(0xc3), LayoutImmutable, Blittable, JsonProperty(Order = 195)]
	public bool FadeEnable { get; set; } = true;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public bool FadeWaitingEnable { get; set; } = true;
	
	[ContainerField(0xc5), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
	public bool BlurEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(InactiveSkipFrameCount);
		p_Writer.Write(ResolutionScale);
		p_Writer.Write(MantleEnable);
		p_Writer.Write(XenonRingBufferSize);
		p_Writer.Write(XenonLinearFrameBufferSize);
		p_Writer.Write(XenonPresentImmediateThreshold);
		p_Writer.Write(XenonGammaRampType);
		p_Writer.Write(Ps3VideoGamma);
		p_Writer.Write(Ps3FrameMainBufferSize);
		p_Writer.Write(Ps3FrameLocalBufferSize);
		p_Writer.Write(Ps3VSyncMethod);
		p_Writer.Write(CameraCutMaxFrameTranslation);
		p_Writer.Write(NearPlane);
		p_Writer.Write(ViewDistance);
		p_Writer.Write(ForceFov);
		p_Writer.Write(FovMultiplier);
		p_Writer.Write(ForceOrthoViewSize);
		p_Writer.Write(EdgeModelScreenAreaScale);
		p_Writer.Write(EdgeModelViewDistance);
		p_Writer.Write(EdgeModelForceLod);
		p_Writer.Write(EdgeModelLodScale);
		p_Writer.Write(EdgeModelMaxVisibleInstanceCount);
		p_Writer.Write(StaticModelPartOcclusionMaxScreenArea);
		p_Writer.Write(StaticModelCullJobCount);
		p_Writer.Write(SplitScreenTestViewCount);
		p_Writer.Write(SplitScreenTestCase);
		p_Writer.Write(ForceBlurAmount);
		p_Writer.Write(ForceWorldFadeAmount);
		p_Writer.Write(StereoCrosshairMaxHitDepth);
		p_Writer.Write(StereoCrosshairRadius);
		p_Writer.Write(StereoCrosshairDampingFactor);
		p_Writer.Write(Enable);
		p_Writer.Write(NullRendererEnable);
		p_Writer.Write(JobEnable);
		p_Writer.Write(BuildJobSyncEnable);
		p_Writer.Write(EarlyGpuSyncEnable);
		p_Writer.Write(DrawDebugInfo);
		p_Writer.Write(DrawScreenInfo);
		p_Writer.Write(Fullscreen);
		p_Writer.Write(ForceVSyncEnable);
		p_Writer.Write(MovieVSyncEnable);
		p_Writer.Write(VSyncFlashTestEnable);
		p_Writer.Write(OutputBrightnessTestEnable);
		p_Writer.Write(XenonBufferTwoFramesEnable);
		p_Writer.Write(XenonRes1280x704Enable);
		p_Writer.Write(Ps3LinearFrameCmdBufEnable);
		p_Writer.Write(Ps3CellMemoryTexturesEnable);
		p_Writer.Write(GcmHudEnable);
		p_Writer.Write(Ps3Res1280x704Enable);
		p_Writer.Write(Gen4bColorRemap);
		p_Writer.Write(GpuTextureCompressorEnable);
		p_Writer.Write(EmittersEnable);
		p_Writer.Write(EntityRenderEnable);
		p_Writer.Write(DebugRendererEnable);
		p_Writer.Write(DebugRenderServiceEnable);
		p_Writer.Write(InitialClearEnable);
		p_Writer.Write(GpuProfilerEnable);
		p_Writer.Write(ForceOrthoViewEnable);
		p_Writer.Write(ForceSquareOrthoView);
		p_Writer.Write(DestructionVolumeDrawEnable);
		p_Writer.Write(EdgeModelsEnable);
		p_Writer.Write(EdgeModelCastShadowsEnable);
		p_Writer.Write(EdgeModelDepthBiasEnable);
		p_Writer.Write(EdgeModelShadowDepthBiasEnable);
		p_Writer.Write(EdgeModelSpuInstancingEnable);
		p_Writer.Write(EdgeModelUseMainLodEnable);
		p_Writer.Write(EdgeModelUseLodBox);
		p_Writer.Write(EdgeModelCullEnable);
		p_Writer.Write(EdgeModelFrustumCullEnable);
		p_Writer.Write(EdgeModelOcclusionCullEnable);
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
		p_Writer.Write(StaticModelCullSpuJobEnable);
		p_Writer.Write(StaticModelSurfaceShaderTerrainAccessEnable);
		p_Writer.Write(LockView);
		p_Writer.Write(ResetLockedView);
		p_Writer.Write(SecondaryStreamingViewEnable);
		p_Writer.Write(FadeEnable);
		p_Writer.Write(FadeWaitingEnable);
		p_Writer.Write(BlurEnable);
		p_Writer.WriteNullBytes(2);
	}
}

