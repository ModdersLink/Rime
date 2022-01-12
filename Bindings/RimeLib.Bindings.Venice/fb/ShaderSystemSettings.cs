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
	[ContainerType(16, 288)]
	public class ShaderSystemSettings : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DebugNonFiniteColor { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint DxInstancingBufferHandlingMethod { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint FrameMemoryBufferSize { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint XenonDispatchCmdBufferSize { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public uint XenonDispatchCmdBufferSegmentSize { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public uint DxDispatchJobBlocksPerCommandList { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public uint DxDispatchJobMinBlockCount { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public uint DxFrameVertexBufferPoolSize { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public int XenonDispatchOnlyJob { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public uint DxVsExternalConstantBufferSize { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public uint DxVsFunctionConstantBufferSize { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public uint DxPsFunctionConstantBufferSize { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float Ps3GeometryYieldGranularity { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public uint XenonDispatchJobCount { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public int DispatchPrepareJobCount { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public uint Ps3MinMipmap { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public uint Ps3ZCullInFrontLimit { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public uint Ps3ZCullBehindLimit { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public int Ps3DispatchOnlyJob { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public uint Ps3DispatchJobSpuCount { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public uint DxMaxInstructionCount { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public uint OverdrawMaxLayerCount { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public uint Ps3GeometryJobCount { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public uint DxMaxInstanceCount { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float Ps3DispatchYieldGranularity { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public uint DxPsExternalConstantBufferSize { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public uint XenonDispatchBlocksPerJob { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public uint Ps3DispatchJobCount { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public int DxDispatchJobCount { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public uint DrawCallMultiplier { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public uint Ps3MaxMipmap { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float MipmapBias { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public uint MaxAnisotropy { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public uint ZOnlyMaxAnisotropy { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public uint XenonTrilinearThreshold { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public uint Ps3DispatchJobPriority { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public uint XenonDispatchMinJobBlockCount { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public uint Ps3GeometryJobSpuCount { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public uint Ps3DispatchBlocksPerJob { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public uint Ps3GeometryJobPriority { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public bool SinglePrimitiveEnable { get; set; }

		[ContainerField(189), LayoutImmutable, Blittable]
		public bool SortBlocksEnable { get; set; }

		[ContainerField(190), LayoutImmutable, Blittable]
		public bool DrawCallEnable { get; set; }

		[ContainerField(191), LayoutImmutable, Blittable]
		public bool GcmReplayMarkersEnable { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public bool ClipPlanesEnable { get; set; }

		[ContainerField(193), LayoutImmutable, Blittable]
		public bool DepthTestEnable { get; set; }

		[ContainerField(194), LayoutImmutable, Blittable]
		public bool StencilEnable { get; set; }

		[ContainerField(195), LayoutImmutable, Blittable]
		public bool ShaderPixScopeEnable { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public bool SingleFrameBlockLogEnable { get; set; }

		[ContainerField(197), LayoutImmutable, Blittable]
		public bool AlphaBlendEnable { get; set; }

		[ContainerField(198), LayoutImmutable, Blittable]
		public bool PixBlockEventsEnable { get; set; }

		[ContainerField(199), LayoutImmutable, Blittable]
		public bool SimpleTexturesEnable { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public bool SimpleVertexShaderEnable { get; set; }

		[ContainerField(201), LayoutImmutable, Blittable]
		public bool PseudoInstancingEnable { get; set; }

		[ContainerField(202), LayoutImmutable, Blittable]
		public bool StatesEnable { get; set; }

		[ContainerField(203), LayoutImmutable, Blittable]
		public bool PixelConstantsEnable { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public bool VertexConstantsEnable { get; set; }

		[ContainerField(205), LayoutImmutable, Blittable]
		public bool PixelConstantRedundancyCheckingEnable { get; set; }

		[ContainerField(206), LayoutImmutable, Blittable]
		public bool VertexConstantRedundancyCheckingEnable { get; set; }

		[ContainerField(207), LayoutImmutable, Blittable]
		public bool SimpleTextureFilteringEnable { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public bool DepthWriteEnable { get; set; }

		[ContainerField(209), LayoutImmutable, Blittable]
		public bool DispatchDirectEnable { get; set; }

		[ContainerField(210), LayoutImmutable, Blittable]
		public bool DrawTileClassifiedBlocks { get; set; }

		[ContainerField(211), LayoutImmutable, Blittable]
		public bool DepthEnable { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public bool DrawStreamedTextureBlocks { get; set; }

		[ContainerField(213), LayoutImmutable, Blittable]
		public bool ForcePointFiltering { get; set; }

		[ContainerField(214), LayoutImmutable, Blittable]
		public bool LogEnable { get; set; }

		[ContainerField(215), LayoutImmutable, Blittable]
		public bool ZeroViewportEnable { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public bool DrawTransparentDecal { get; set; }

		[ContainerField(217), LayoutImmutable, Blittable]
		public bool SingleFrameLogEnable { get; set; }

		[ContainerField(218), LayoutImmutable, Blittable]
		public bool SingleFrameLogOverwrite { get; set; }

		[ContainerField(219), LayoutImmutable, Blittable]
		public bool ForceDoubleSided { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public bool OnDemandMonitoringEnable { get; set; }

		[ContainerField(221), LayoutImmutable, Blittable]
		public bool Ps3PixelShaderRedundancyCheckingEnable { get; set; }

		[ContainerField(222), LayoutImmutable, Blittable]
		public bool Ps3PixelShaderHashStoreEnable { get; set; }

		[ContainerField(223), LayoutImmutable, Blittable]
		public bool Ps3DispatchPrepareSpuJobEnable { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public bool Ps3DispatchSetupSpuJobEnable { get; set; }

		[ContainerField(225), LayoutImmutable, Blittable]
		public bool Ps3GeometryJobEnable { get; set; }

		[ContainerField(226), LayoutImmutable, Blittable]
		public bool DatabaseLoadingEnable { get; set; }

		[ContainerField(227), LayoutImmutable, Blittable]
		public bool SimplePixelShaderEnable { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable]
		public bool Ps3GeometryJobWithoutDispatchJobEnable { get; set; }

		[ContainerField(229), LayoutImmutable, Blittable]
		public bool Ps3GeometryDebugRenderEnable { get; set; }

		[ContainerField(230), LayoutImmutable, Blittable]
		public bool BoneConstantOptimizationEnable { get; set; }

		[ContainerField(231), LayoutImmutable, Blittable]
		public bool Ps3DrawEdgeGeometryEnable { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable]
		public bool Ps3DrawNonEdgeGeometryEnable { get; set; }

		[ContainerField(233), LayoutImmutable, Blittable]
		public bool Ps3TriangleCullEnable { get; set; }

		[ContainerField(234), LayoutImmutable, Blittable]
		public bool Ps3TriangleFrustumCullEnable { get; set; }

		[ContainerField(235), LayoutImmutable, Blittable]
		public bool Ps3TriangleBackfaceCullEnable { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public bool Ps3TriangleCullZPassEnable { get; set; }

		[ContainerField(237), LayoutImmutable, Blittable]
		public bool Ps3TriangleCullDoubleSidedEnable { get; set; }

		[ContainerField(238), LayoutImmutable, Blittable]
		public bool Ps3TriangleCull1BoneSkinningEnable { get; set; }

		[ContainerField(239), LayoutImmutable, Blittable]
		public bool Ps3TriangleCull4BoneSkinningEnable { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public bool Ps3TrianglePartCullEnable { get; set; }

		[ContainerField(241), LayoutImmutable, Blittable]
		public bool Ps3DrawBlockCullEnable { get; set; }

		[ContainerField(242), LayoutImmutable, Blittable]
		public bool Ps3PartitionFrustumCullEnable { get; set; }

		[ContainerField(243), LayoutImmutable, Blittable]
		public bool Ps3PartitionClipPlaneCullEnable { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public bool Ps3PartitionVolumeCullEnable { get; set; }

		[ContainerField(245), LayoutImmutable, Blittable]
		public bool Ps3SpuInstancingEnable { get; set; }

		[ContainerField(246), LayoutImmutable, Blittable]
		public bool Ps3SpuClipPlaneRejectEnable { get; set; }

		[ContainerField(247), LayoutImmutable, Blittable]
		public bool Ps3SpuCullVolumesEnable { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable]
		public bool Ps3DispatchJobEnable { get; set; }

		[ContainerField(249), LayoutImmutable, Blittable]
		public bool OnDemandBuildingEnable { get; set; }

		[ContainerField(250), LayoutImmutable, Blittable]
		public bool OnDemandPrimingEnable { get; set; }

		[ContainerField(251), LayoutImmutable, Blittable]
		public bool DispatchExecuteEnable { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable]
		public bool TextureGammaCorrectionEnable { get; set; }

		[ContainerField(253), LayoutImmutable, Blittable]
		public bool TileClassificationEnable { get; set; }

		[ContainerField(254), LayoutImmutable, Blittable]
		public bool Ps3DispatchSpuBufferLinkingEnable { get; set; }

		[ContainerField(255), LayoutImmutable, Blittable]
		public bool Ps3DispatchFrameBlockEnable { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable]
		public bool Ps3SCullEnable { get; set; }

		[ContainerField(257), LayoutImmutable, Blittable]
		public bool Ps3ZCullEnable { get; set; }

		[ContainerField(258), LayoutImmutable, Blittable]
		public bool DrawInstancedBlocks { get; set; }

		[ContainerField(259), LayoutImmutable, Blittable]
		public bool DispatchPrepareBlockEnable { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable]
		public bool DrawNonInstancedBlocks { get; set; }

		[ContainerField(261), LayoutImmutable, Blittable]
		public bool DrawNonStreamedTextureBlocks { get; set; }

		[ContainerField(262), LayoutImmutable, Blittable]
		public bool Ps3TxpDemotionEnable { get; set; }

		[ContainerField(263), LayoutImmutable, Blittable]
		public bool Ps3CmdBufVertexShaderInlineEnable { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable]
		public bool Ps3CmdBufClearEnable { get; set; }

		[ContainerField(265), LayoutImmutable, Blittable]
		public bool Ps3SpuYieldingEnable { get; set; }

		[ContainerField(266), LayoutImmutable, Blittable]
		public bool XenonDispatchJobEnable { get; set; }

		[ContainerField(267), LayoutImmutable, Blittable]
		public bool DrawInlineBlocks { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable]
		public bool Ps3FlushEnable { get; set; }

		[ContainerField(269), LayoutImmutable, Blittable]
		public bool Ps3FinishEnable { get; set; }

		[ContainerField(270), LayoutImmutable, Blittable]
		public bool DxMultisampleEnable { get; set; }

		[ContainerField(271), LayoutImmutable, Blittable]
		public bool DxTransparencySupersamplingEnable { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable]
		public bool DxSamplerStatesEnable { get; set; }

		[ContainerField(273), LayoutImmutable, Blittable]
		public bool DxBatchedSamplerStatesEnable { get; set; }

		[ContainerField(274), LayoutImmutable, Blittable]
		public bool DxBatchedTexturesEnable { get; set; }

		[ContainerField(275), LayoutImmutable, Blittable]
		public bool DxStatesEnable { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable]
		public bool DrawOpaqueAlphaTestSimple { get; set; }

		[ContainerField(277), LayoutImmutable, Blittable]
		public bool FlushEnable { get; set; }

		[ContainerField(278), LayoutImmutable, Blittable]
		public bool DrawTransparent { get; set; }

		[ContainerField(279), LayoutImmutable, Blittable]
		public bool DrawAdvancedStats { get; set; }

		[ContainerField(280), LayoutImmutable, Blittable]
		public bool DxParallelShaderLoadingEnable { get; set; }

		[ContainerField(281), LayoutImmutable, Blittable]
		public bool DxDelayedShaderLoadingEnable { get; set; }

		[ContainerField(282), LayoutImmutable, Blittable]
		public bool DrawOpaque { get; set; }

		[ContainerField(283), LayoutImmutable, Blittable]
		public bool DrawOpaqueAlphaTest { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable]
		public bool XenonHiZEnable { get; set; }

		[ContainerField(285), LayoutImmutable, Blittable]
		public bool DrawZOnly { get; set; }

		[ContainerField(286), LayoutImmutable, Blittable]
		public bool DrawStats { get; set; }

		[ContainerField(287), LayoutImmutable, Blittable]
		public bool XenonDispatchBlockOnCmdBufEnable { get; set; }

	}
}
