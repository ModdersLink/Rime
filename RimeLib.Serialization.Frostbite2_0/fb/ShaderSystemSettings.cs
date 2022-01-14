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
	[ContainerType(16, 288)]
	public class ShaderSystemSettings :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 DebugNonFiniteColor { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint DxInstancingBufferHandlingMethod { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint FrameMemoryBufferSize { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public uint XenonDispatchCmdBufferSize { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public uint XenonDispatchCmdBufferSegmentSize { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public uint DxDispatchJobBlocksPerCommandList { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public uint DxDispatchJobMinBlockCount { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public uint DxFrameVertexBufferPoolSize { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public int XenonDispatchOnlyJob { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public uint DxVsExternalConstantBufferSize { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public uint DxVsFunctionConstantBufferSize { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public uint DxPsFunctionConstantBufferSize { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float Ps3GeometryYieldGranularity { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public uint XenonDispatchJobCount { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public int DispatchPrepareJobCount { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public uint Ps3MinMipmap { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public uint Ps3ZCullInFrontLimit { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public uint Ps3ZCullBehindLimit { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public int Ps3DispatchOnlyJob { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public uint Ps3DispatchJobSpuCount { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public uint DxMaxInstructionCount { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public uint OverdrawMaxLayerCount { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public uint Ps3GeometryJobCount { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public uint DxMaxInstanceCount { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float Ps3DispatchYieldGranularity { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public uint DxPsExternalConstantBufferSize { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public uint XenonDispatchBlocksPerJob { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public uint Ps3DispatchJobCount { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public int DxDispatchJobCount { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public uint DrawCallMultiplier { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public uint Ps3MaxMipmap { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float MipmapBias { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public uint MaxAnisotropy { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public uint ZOnlyMaxAnisotropy { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public uint XenonTrilinearThreshold { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public uint Ps3DispatchJobPriority { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public uint XenonDispatchMinJobBlockCount { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public uint Ps3GeometryJobSpuCount { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public uint Ps3DispatchBlocksPerJob { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public uint Ps3GeometryJobPriority { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public bool SinglePrimitiveEnable { get; set; }

		[ContainerField(189), LayoutImmutable, Blittable, JsonProperty(Order = 189)]
		public bool SortBlocksEnable { get; set; }

		[ContainerField(190), LayoutImmutable, Blittable, JsonProperty(Order = 190)]
		public bool DrawCallEnable { get; set; }

		[ContainerField(191), LayoutImmutable, Blittable, JsonProperty(Order = 191)]
		public bool GcmReplayMarkersEnable { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public bool ClipPlanesEnable { get; set; }

		[ContainerField(193), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
		public bool DepthTestEnable { get; set; }

		[ContainerField(194), LayoutImmutable, Blittable, JsonProperty(Order = 194)]
		public bool StencilEnable { get; set; }

		[ContainerField(195), LayoutImmutable, Blittable, JsonProperty(Order = 195)]
		public bool ShaderPixScopeEnable { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public bool SingleFrameBlockLogEnable { get; set; }

		[ContainerField(197), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
		public bool AlphaBlendEnable { get; set; }

		[ContainerField(198), LayoutImmutable, Blittable, JsonProperty(Order = 198)]
		public bool PixBlockEventsEnable { get; set; }

		[ContainerField(199), LayoutImmutable, Blittable, JsonProperty(Order = 199)]
		public bool SimpleTexturesEnable { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public bool SimpleVertexShaderEnable { get; set; }

		[ContainerField(201), LayoutImmutable, Blittable, JsonProperty(Order = 201)]
		public bool PseudoInstancingEnable { get; set; }

		[ContainerField(202), LayoutImmutable, Blittable, JsonProperty(Order = 202)]
		public bool StatesEnable { get; set; }

		[ContainerField(203), LayoutImmutable, Blittable, JsonProperty(Order = 203)]
		public bool PixelConstantsEnable { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public bool VertexConstantsEnable { get; set; }

		[ContainerField(205), LayoutImmutable, Blittable, JsonProperty(Order = 205)]
		public bool PixelConstantRedundancyCheckingEnable { get; set; }

		[ContainerField(206), LayoutImmutable, Blittable, JsonProperty(Order = 206)]
		public bool VertexConstantRedundancyCheckingEnable { get; set; }

		[ContainerField(207), LayoutImmutable, Blittable, JsonProperty(Order = 207)]
		public bool SimpleTextureFilteringEnable { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public bool DepthWriteEnable { get; set; }

		[ContainerField(209), LayoutImmutable, Blittable, JsonProperty(Order = 209)]
		public bool DispatchDirectEnable { get; set; }

		[ContainerField(210), LayoutImmutable, Blittable, JsonProperty(Order = 210)]
		public bool DrawTileClassifiedBlocks { get; set; }

		[ContainerField(211), LayoutImmutable, Blittable, JsonProperty(Order = 211)]
		public bool DepthEnable { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public bool DrawStreamedTextureBlocks { get; set; }

		[ContainerField(213), LayoutImmutable, Blittable, JsonProperty(Order = 213)]
		public bool ForcePointFiltering { get; set; }

		[ContainerField(214), LayoutImmutable, Blittable, JsonProperty(Order = 214)]
		public bool LogEnable { get; set; }

		[ContainerField(215), LayoutImmutable, Blittable, JsonProperty(Order = 215)]
		public bool ZeroViewportEnable { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public bool DrawTransparentDecal { get; set; }

		[ContainerField(217), LayoutImmutable, Blittable, JsonProperty(Order = 217)]
		public bool SingleFrameLogEnable { get; set; }

		[ContainerField(218), LayoutImmutable, Blittable, JsonProperty(Order = 218)]
		public bool SingleFrameLogOverwrite { get; set; }

		[ContainerField(219), LayoutImmutable, Blittable, JsonProperty(Order = 219)]
		public bool ForceDoubleSided { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public bool OnDemandMonitoringEnable { get; set; }

		[ContainerField(221), LayoutImmutable, Blittable, JsonProperty(Order = 221)]
		public bool Ps3PixelShaderRedundancyCheckingEnable { get; set; }

		[ContainerField(222), LayoutImmutable, Blittable, JsonProperty(Order = 222)]
		public bool Ps3PixelShaderHashStoreEnable { get; set; }

		[ContainerField(223), LayoutImmutable, Blittable, JsonProperty(Order = 223)]
		public bool Ps3DispatchPrepareSpuJobEnable { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public bool Ps3DispatchSetupSpuJobEnable { get; set; }

		[ContainerField(225), LayoutImmutable, Blittable, JsonProperty(Order = 225)]
		public bool Ps3GeometryJobEnable { get; set; }

		[ContainerField(226), LayoutImmutable, Blittable, JsonProperty(Order = 226)]
		public bool DatabaseLoadingEnable { get; set; }

		[ContainerField(227), LayoutImmutable, Blittable, JsonProperty(Order = 227)]
		public bool SimplePixelShaderEnable { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public bool Ps3GeometryJobWithoutDispatchJobEnable { get; set; }

		[ContainerField(229), LayoutImmutable, Blittable, JsonProperty(Order = 229)]
		public bool Ps3GeometryDebugRenderEnable { get; set; }

		[ContainerField(230), LayoutImmutable, Blittable, JsonProperty(Order = 230)]
		public bool BoneConstantOptimizationEnable { get; set; }

		[ContainerField(231), LayoutImmutable, Blittable, JsonProperty(Order = 231)]
		public bool Ps3DrawEdgeGeometryEnable { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public bool Ps3DrawNonEdgeGeometryEnable { get; set; }

		[ContainerField(233), LayoutImmutable, Blittable, JsonProperty(Order = 233)]
		public bool Ps3TriangleCullEnable { get; set; }

		[ContainerField(234), LayoutImmutable, Blittable, JsonProperty(Order = 234)]
		public bool Ps3TriangleFrustumCullEnable { get; set; }

		[ContainerField(235), LayoutImmutable, Blittable, JsonProperty(Order = 235)]
		public bool Ps3TriangleBackfaceCullEnable { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public bool Ps3TriangleCullZPassEnable { get; set; }

		[ContainerField(237), LayoutImmutable, Blittable, JsonProperty(Order = 237)]
		public bool Ps3TriangleCullDoubleSidedEnable { get; set; }

		[ContainerField(238), LayoutImmutable, Blittable, JsonProperty(Order = 238)]
		public bool Ps3TriangleCull1BoneSkinningEnable { get; set; }

		[ContainerField(239), LayoutImmutable, Blittable, JsonProperty(Order = 239)]
		public bool Ps3TriangleCull4BoneSkinningEnable { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public bool Ps3TrianglePartCullEnable { get; set; }

		[ContainerField(241), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
		public bool Ps3DrawBlockCullEnable { get; set; }

		[ContainerField(242), LayoutImmutable, Blittable, JsonProperty(Order = 242)]
		public bool Ps3PartitionFrustumCullEnable { get; set; }

		[ContainerField(243), LayoutImmutable, Blittable, JsonProperty(Order = 243)]
		public bool Ps3PartitionClipPlaneCullEnable { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public bool Ps3PartitionVolumeCullEnable { get; set; }

		[ContainerField(245), LayoutImmutable, Blittable, JsonProperty(Order = 245)]
		public bool Ps3SpuInstancingEnable { get; set; }

		[ContainerField(246), LayoutImmutable, Blittable, JsonProperty(Order = 246)]
		public bool Ps3SpuClipPlaneRejectEnable { get; set; }

		[ContainerField(247), LayoutImmutable, Blittable, JsonProperty(Order = 247)]
		public bool Ps3SpuCullVolumesEnable { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		public bool Ps3DispatchJobEnable { get; set; }

		[ContainerField(249), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
		public bool OnDemandBuildingEnable { get; set; }

		[ContainerField(250), LayoutImmutable, Blittable, JsonProperty(Order = 250)]
		public bool OnDemandPrimingEnable { get; set; }

		[ContainerField(251), LayoutImmutable, Blittable, JsonProperty(Order = 251)]
		public bool DispatchExecuteEnable { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		public bool TextureGammaCorrectionEnable { get; set; }

		[ContainerField(253), LayoutImmutable, Blittable, JsonProperty(Order = 253)]
		public bool TileClassificationEnable { get; set; }

		[ContainerField(254), LayoutImmutable, Blittable, JsonProperty(Order = 254)]
		public bool Ps3DispatchSpuBufferLinkingEnable { get; set; }

		[ContainerField(255), LayoutImmutable, Blittable, JsonProperty(Order = 255)]
		public bool Ps3DispatchFrameBlockEnable { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public bool Ps3SCullEnable { get; set; }

		[ContainerField(257), LayoutImmutable, Blittable, JsonProperty(Order = 257)]
		public bool Ps3ZCullEnable { get; set; }

		[ContainerField(258), LayoutImmutable, Blittable, JsonProperty(Order = 258)]
		public bool DrawInstancedBlocks { get; set; }

		[ContainerField(259), LayoutImmutable, Blittable, JsonProperty(Order = 259)]
		public bool DispatchPrepareBlockEnable { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		public bool DrawNonInstancedBlocks { get; set; }

		[ContainerField(261), LayoutImmutable, Blittable, JsonProperty(Order = 261)]
		public bool DrawNonStreamedTextureBlocks { get; set; }

		[ContainerField(262), LayoutImmutable, Blittable, JsonProperty(Order = 262)]
		public bool Ps3TxpDemotionEnable { get; set; }

		[ContainerField(263), LayoutImmutable, Blittable, JsonProperty(Order = 263)]
		public bool Ps3CmdBufVertexShaderInlineEnable { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		public bool Ps3CmdBufClearEnable { get; set; }

		[ContainerField(265), LayoutImmutable, Blittable, JsonProperty(Order = 265)]
		public bool Ps3SpuYieldingEnable { get; set; }

		[ContainerField(266), LayoutImmutable, Blittable, JsonProperty(Order = 266)]
		public bool XenonDispatchJobEnable { get; set; }

		[ContainerField(267), LayoutImmutable, Blittable, JsonProperty(Order = 267)]
		public bool DrawInlineBlocks { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		public bool Ps3FlushEnable { get; set; }

		[ContainerField(269), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
		public bool Ps3FinishEnable { get; set; }

		[ContainerField(270), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
		public bool DxMultisampleEnable { get; set; }

		[ContainerField(271), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
		public bool DxTransparencySupersamplingEnable { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		public bool DxSamplerStatesEnable { get; set; }

		[ContainerField(273), LayoutImmutable, Blittable, JsonProperty(Order = 273)]
		public bool DxBatchedSamplerStatesEnable { get; set; }

		[ContainerField(274), LayoutImmutable, Blittable, JsonProperty(Order = 274)]
		public bool DxBatchedTexturesEnable { get; set; }

		[ContainerField(275), LayoutImmutable, Blittable, JsonProperty(Order = 275)]
		public bool DxStatesEnable { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		public bool DrawOpaqueAlphaTestSimple { get; set; }

		[ContainerField(277), LayoutImmutable, Blittable, JsonProperty(Order = 277)]
		public bool FlushEnable { get; set; }

		[ContainerField(278), LayoutImmutable, Blittable, JsonProperty(Order = 278)]
		public bool DrawTransparent { get; set; }

		[ContainerField(279), LayoutImmutable, Blittable, JsonProperty(Order = 279)]
		public bool DrawAdvancedStats { get; set; }

		[ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		public bool DxParallelShaderLoadingEnable { get; set; }

		[ContainerField(281), LayoutImmutable, Blittable, JsonProperty(Order = 281)]
		public bool DxDelayedShaderLoadingEnable { get; set; }

		[ContainerField(282), LayoutImmutable, Blittable, JsonProperty(Order = 282)]
		public bool DrawOpaque { get; set; }

		[ContainerField(283), LayoutImmutable, Blittable, JsonProperty(Order = 283)]
		public bool DrawOpaqueAlphaTest { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		public bool XenonHiZEnable { get; set; }

		[ContainerField(285), LayoutImmutable, Blittable, JsonProperty(Order = 285)]
		public bool DrawZOnly { get; set; }

		[ContainerField(286), LayoutImmutable, Blittable, JsonProperty(Order = 286)]
		public bool DrawStats { get; set; }

		[ContainerField(287), LayoutImmutable, Blittable, JsonProperty(Order = 287)]
		public bool XenonDispatchBlockOnCmdBufEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			DebugNonFiniteColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DxInstancingBufferHandlingMethod);
			p_Writer.Write(FrameMemoryBufferSize);
			p_Writer.Write(XenonDispatchCmdBufferSize);
			p_Writer.Write(XenonDispatchCmdBufferSegmentSize);
			p_Writer.Write(DxDispatchJobBlocksPerCommandList);
			p_Writer.Write(DxDispatchJobMinBlockCount);
			p_Writer.Write(DxFrameVertexBufferPoolSize);
			p_Writer.Write(XenonDispatchOnlyJob);
			p_Writer.Write(DxVsExternalConstantBufferSize);
			p_Writer.Write(DxVsFunctionConstantBufferSize);
			p_Writer.Write(DxPsFunctionConstantBufferSize);
			p_Writer.Write(Ps3GeometryYieldGranularity);
			p_Writer.Write(XenonDispatchJobCount);
			p_Writer.Write(DispatchPrepareJobCount);
			p_Writer.Write(Ps3MinMipmap);
			p_Writer.Write(Ps3ZCullInFrontLimit);
			p_Writer.Write(Ps3ZCullBehindLimit);
			p_Writer.Write(Ps3DispatchOnlyJob);
			p_Writer.Write(Ps3DispatchJobSpuCount);
			p_Writer.Write(DxMaxInstructionCount);
			p_Writer.Write(OverdrawMaxLayerCount);
			p_Writer.Write(Ps3GeometryJobCount);
			p_Writer.Write(DxMaxInstanceCount);
			p_Writer.Write(Ps3DispatchYieldGranularity);
			p_Writer.Write(DxPsExternalConstantBufferSize);
			p_Writer.Write(XenonDispatchBlocksPerJob);
			p_Writer.Write(Ps3DispatchJobCount);
			p_Writer.Write(DxDispatchJobCount);
			p_Writer.Write(DrawCallMultiplier);
			p_Writer.Write(Ps3MaxMipmap);
			p_Writer.Write(MipmapBias);
			p_Writer.Write(MaxAnisotropy);
			p_Writer.Write(ZOnlyMaxAnisotropy);
			p_Writer.Write(XenonTrilinearThreshold);
			p_Writer.Write(Ps3DispatchJobPriority);
			p_Writer.Write(XenonDispatchMinJobBlockCount);
			p_Writer.Write(Ps3GeometryJobSpuCount);
			p_Writer.Write(Ps3DispatchBlocksPerJob);
			p_Writer.Write(Ps3GeometryJobPriority);
			p_Writer.Write(SinglePrimitiveEnable);
			p_Writer.Write(SortBlocksEnable);
			p_Writer.Write(DrawCallEnable);
			p_Writer.Write(GcmReplayMarkersEnable);
			p_Writer.Write(ClipPlanesEnable);
			p_Writer.Write(DepthTestEnable);
			p_Writer.Write(StencilEnable);
			p_Writer.Write(ShaderPixScopeEnable);
			p_Writer.Write(SingleFrameBlockLogEnable);
			p_Writer.Write(AlphaBlendEnable);
			p_Writer.Write(PixBlockEventsEnable);
			p_Writer.Write(SimpleTexturesEnable);
			p_Writer.Write(SimpleVertexShaderEnable);
			p_Writer.Write(PseudoInstancingEnable);
			p_Writer.Write(StatesEnable);
			p_Writer.Write(PixelConstantsEnable);
			p_Writer.Write(VertexConstantsEnable);
			p_Writer.Write(PixelConstantRedundancyCheckingEnable);
			p_Writer.Write(VertexConstantRedundancyCheckingEnable);
			p_Writer.Write(SimpleTextureFilteringEnable);
			p_Writer.Write(DepthWriteEnable);
			p_Writer.Write(DispatchDirectEnable);
			p_Writer.Write(DrawTileClassifiedBlocks);
			p_Writer.Write(DepthEnable);
			p_Writer.Write(DrawStreamedTextureBlocks);
			p_Writer.Write(ForcePointFiltering);
			p_Writer.Write(LogEnable);
			p_Writer.Write(ZeroViewportEnable);
			p_Writer.Write(DrawTransparentDecal);
			p_Writer.Write(SingleFrameLogEnable);
			p_Writer.Write(SingleFrameLogOverwrite);
			p_Writer.Write(ForceDoubleSided);
			p_Writer.Write(OnDemandMonitoringEnable);
			p_Writer.Write(Ps3PixelShaderRedundancyCheckingEnable);
			p_Writer.Write(Ps3PixelShaderHashStoreEnable);
			p_Writer.Write(Ps3DispatchPrepareSpuJobEnable);
			p_Writer.Write(Ps3DispatchSetupSpuJobEnable);
			p_Writer.Write(Ps3GeometryJobEnable);
			p_Writer.Write(DatabaseLoadingEnable);
			p_Writer.Write(SimplePixelShaderEnable);
			p_Writer.Write(Ps3GeometryJobWithoutDispatchJobEnable);
			p_Writer.Write(Ps3GeometryDebugRenderEnable);
			p_Writer.Write(BoneConstantOptimizationEnable);
			p_Writer.Write(Ps3DrawEdgeGeometryEnable);
			p_Writer.Write(Ps3DrawNonEdgeGeometryEnable);
			p_Writer.Write(Ps3TriangleCullEnable);
			p_Writer.Write(Ps3TriangleFrustumCullEnable);
			p_Writer.Write(Ps3TriangleBackfaceCullEnable);
			p_Writer.Write(Ps3TriangleCullZPassEnable);
			p_Writer.Write(Ps3TriangleCullDoubleSidedEnable);
			p_Writer.Write(Ps3TriangleCull1BoneSkinningEnable);
			p_Writer.Write(Ps3TriangleCull4BoneSkinningEnable);
			p_Writer.Write(Ps3TrianglePartCullEnable);
			p_Writer.Write(Ps3DrawBlockCullEnable);
			p_Writer.Write(Ps3PartitionFrustumCullEnable);
			p_Writer.Write(Ps3PartitionClipPlaneCullEnable);
			p_Writer.Write(Ps3PartitionVolumeCullEnable);
			p_Writer.Write(Ps3SpuInstancingEnable);
			p_Writer.Write(Ps3SpuClipPlaneRejectEnable);
			p_Writer.Write(Ps3SpuCullVolumesEnable);
			p_Writer.Write(Ps3DispatchJobEnable);
			p_Writer.Write(OnDemandBuildingEnable);
			p_Writer.Write(OnDemandPrimingEnable);
			p_Writer.Write(DispatchExecuteEnable);
			p_Writer.Write(TextureGammaCorrectionEnable);
			p_Writer.Write(TileClassificationEnable);
			p_Writer.Write(Ps3DispatchSpuBufferLinkingEnable);
			p_Writer.Write(Ps3DispatchFrameBlockEnable);
			p_Writer.Write(Ps3SCullEnable);
			p_Writer.Write(Ps3ZCullEnable);
			p_Writer.Write(DrawInstancedBlocks);
			p_Writer.Write(DispatchPrepareBlockEnable);
			p_Writer.Write(DrawNonInstancedBlocks);
			p_Writer.Write(DrawNonStreamedTextureBlocks);
			p_Writer.Write(Ps3TxpDemotionEnable);
			p_Writer.Write(Ps3CmdBufVertexShaderInlineEnable);
			p_Writer.Write(Ps3CmdBufClearEnable);
			p_Writer.Write(Ps3SpuYieldingEnable);
			p_Writer.Write(XenonDispatchJobEnable);
			p_Writer.Write(DrawInlineBlocks);
			p_Writer.Write(Ps3FlushEnable);
			p_Writer.Write(Ps3FinishEnable);
			p_Writer.Write(DxMultisampleEnable);
			p_Writer.Write(DxTransparencySupersamplingEnable);
			p_Writer.Write(DxSamplerStatesEnable);
			p_Writer.Write(DxBatchedSamplerStatesEnable);
			p_Writer.Write(DxBatchedTexturesEnable);
			p_Writer.Write(DxStatesEnable);
			p_Writer.Write(DrawOpaqueAlphaTestSimple);
			p_Writer.Write(FlushEnable);
			p_Writer.Write(DrawTransparent);
			p_Writer.Write(DrawAdvancedStats);
			p_Writer.Write(DxParallelShaderLoadingEnable);
			p_Writer.Write(DxDelayedShaderLoadingEnable);
			p_Writer.Write(DrawOpaque);
			p_Writer.Write(DrawOpaqueAlphaTest);
			p_Writer.Write(XenonHiZEnable);
			p_Writer.Write(DrawZOnly);
			p_Writer.Write(DrawStats);
			p_Writer.Write(XenonDispatchBlockOnCmdBufEnable);
		}
	}
}
