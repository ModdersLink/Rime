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
	[ContainerType(16, 288)]
	public partial class ShaderSystemSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _DebugNonFiniteColor = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _DxInstancingBufferHandlingMethod;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _FrameMemoryBufferSize;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private uint _XenonDispatchCmdBufferSize;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private uint _XenonDispatchCmdBufferSegmentSize;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private uint _DxDispatchJobBlocksPerCommandList;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private uint _DxDispatchJobMinBlockCount;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private uint _DxFrameVertexBufferPoolSize;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private int _XenonDispatchOnlyJob;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private uint _DxVsExternalConstantBufferSize;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private uint _DxVsFunctionConstantBufferSize;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private uint _DxPsFunctionConstantBufferSize;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _Ps3GeometryYieldGranularity;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private uint _XenonDispatchJobCount;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private int _DispatchPrepareJobCount;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private uint _Ps3MinMipmap;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private uint _Ps3ZCullInFrontLimit;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private uint _Ps3ZCullBehindLimit;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private int _Ps3DispatchOnlyJob;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private uint _Ps3DispatchJobSpuCount;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private uint _DxMaxInstructionCount;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private uint _OverdrawMaxLayerCount;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private uint _Ps3GeometryJobCount;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private uint _DxMaxInstanceCount;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _Ps3DispatchYieldGranularity;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private uint _DxPsExternalConstantBufferSize;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private uint _XenonDispatchBlocksPerJob;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private uint _Ps3DispatchJobCount;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private int _DxDispatchJobCount;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private uint _DrawCallMultiplier;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private uint _Ps3MaxMipmap;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _MipmapBias;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private uint _MaxAnisotropy;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private uint _ZOnlyMaxAnisotropy;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private uint _XenonTrilinearThreshold;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private uint _Ps3DispatchJobPriority;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private uint _XenonDispatchMinJobBlockCount;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private uint _Ps3GeometryJobSpuCount;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private uint _Ps3DispatchBlocksPerJob;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private uint _Ps3GeometryJobPriority;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private bool _SinglePrimitiveEnable;

		[ObservableProperty]
		[property: ContainerField(189), LayoutImmutable, Blittable, JsonProperty(Order = 189)]
		private bool _SortBlocksEnable;

		[ObservableProperty]
		[property: ContainerField(190), LayoutImmutable, Blittable, JsonProperty(Order = 190)]
		private bool _DrawCallEnable;

		[ObservableProperty]
		[property: ContainerField(191), LayoutImmutable, Blittable, JsonProperty(Order = 191)]
		private bool _GcmReplayMarkersEnable;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private bool _ClipPlanesEnable;

		[ObservableProperty]
		[property: ContainerField(193), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
		private bool _DepthTestEnable;

		[ObservableProperty]
		[property: ContainerField(194), LayoutImmutable, Blittable, JsonProperty(Order = 194)]
		private bool _StencilEnable;

		[ObservableProperty]
		[property: ContainerField(195), LayoutImmutable, Blittable, JsonProperty(Order = 195)]
		private bool _ShaderPixScopeEnable;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private bool _SingleFrameBlockLogEnable;

		[ObservableProperty]
		[property: ContainerField(197), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
		private bool _AlphaBlendEnable;

		[ObservableProperty]
		[property: ContainerField(198), LayoutImmutable, Blittable, JsonProperty(Order = 198)]
		private bool _PixBlockEventsEnable;

		[ObservableProperty]
		[property: ContainerField(199), LayoutImmutable, Blittable, JsonProperty(Order = 199)]
		private bool _SimpleTexturesEnable;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private bool _SimpleVertexShaderEnable;

		[ObservableProperty]
		[property: ContainerField(201), LayoutImmutable, Blittable, JsonProperty(Order = 201)]
		private bool _PseudoInstancingEnable;

		[ObservableProperty]
		[property: ContainerField(202), LayoutImmutable, Blittable, JsonProperty(Order = 202)]
		private bool _StatesEnable;

		[ObservableProperty]
		[property: ContainerField(203), LayoutImmutable, Blittable, JsonProperty(Order = 203)]
		private bool _PixelConstantsEnable;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private bool _VertexConstantsEnable;

		[ObservableProperty]
		[property: ContainerField(205), LayoutImmutable, Blittable, JsonProperty(Order = 205)]
		private bool _PixelConstantRedundancyCheckingEnable;

		[ObservableProperty]
		[property: ContainerField(206), LayoutImmutable, Blittable, JsonProperty(Order = 206)]
		private bool _VertexConstantRedundancyCheckingEnable;

		[ObservableProperty]
		[property: ContainerField(207), LayoutImmutable, Blittable, JsonProperty(Order = 207)]
		private bool _SimpleTextureFilteringEnable;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private bool _DepthWriteEnable;

		[ObservableProperty]
		[property: ContainerField(209), LayoutImmutable, Blittable, JsonProperty(Order = 209)]
		private bool _DispatchDirectEnable;

		[ObservableProperty]
		[property: ContainerField(210), LayoutImmutable, Blittable, JsonProperty(Order = 210)]
		private bool _DrawTileClassifiedBlocks;

		[ObservableProperty]
		[property: ContainerField(211), LayoutImmutable, Blittable, JsonProperty(Order = 211)]
		private bool _DepthEnable;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private bool _DrawStreamedTextureBlocks;

		[ObservableProperty]
		[property: ContainerField(213), LayoutImmutable, Blittable, JsonProperty(Order = 213)]
		private bool _ForcePointFiltering;

		[ObservableProperty]
		[property: ContainerField(214), LayoutImmutable, Blittable, JsonProperty(Order = 214)]
		private bool _LogEnable;

		[ObservableProperty]
		[property: ContainerField(215), LayoutImmutable, Blittable, JsonProperty(Order = 215)]
		private bool _ZeroViewportEnable;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private bool _DrawTransparentDecal;

		[ObservableProperty]
		[property: ContainerField(217), LayoutImmutable, Blittable, JsonProperty(Order = 217)]
		private bool _SingleFrameLogEnable;

		[ObservableProperty]
		[property: ContainerField(218), LayoutImmutable, Blittable, JsonProperty(Order = 218)]
		private bool _SingleFrameLogOverwrite;

		[ObservableProperty]
		[property: ContainerField(219), LayoutImmutable, Blittable, JsonProperty(Order = 219)]
		private bool _ForceDoubleSided;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private bool _OnDemandMonitoringEnable;

		[ObservableProperty]
		[property: ContainerField(221), LayoutImmutable, Blittable, JsonProperty(Order = 221)]
		private bool _Ps3PixelShaderRedundancyCheckingEnable;

		[ObservableProperty]
		[property: ContainerField(222), LayoutImmutable, Blittable, JsonProperty(Order = 222)]
		private bool _Ps3PixelShaderHashStoreEnable;

		[ObservableProperty]
		[property: ContainerField(223), LayoutImmutable, Blittable, JsonProperty(Order = 223)]
		private bool _Ps3DispatchPrepareSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private bool _Ps3DispatchSetupSpuJobEnable;

		[ObservableProperty]
		[property: ContainerField(225), LayoutImmutable, Blittable, JsonProperty(Order = 225)]
		private bool _Ps3GeometryJobEnable;

		[ObservableProperty]
		[property: ContainerField(226), LayoutImmutable, Blittable, JsonProperty(Order = 226)]
		private bool _DatabaseLoadingEnable;

		[ObservableProperty]
		[property: ContainerField(227), LayoutImmutable, Blittable, JsonProperty(Order = 227)]
		private bool _SimplePixelShaderEnable;

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private bool _Ps3GeometryJobWithoutDispatchJobEnable;

		[ObservableProperty]
		[property: ContainerField(229), LayoutImmutable, Blittable, JsonProperty(Order = 229)]
		private bool _Ps3GeometryDebugRenderEnable;

		[ObservableProperty]
		[property: ContainerField(230), LayoutImmutable, Blittable, JsonProperty(Order = 230)]
		private bool _BoneConstantOptimizationEnable;

		[ObservableProperty]
		[property: ContainerField(231), LayoutImmutable, Blittable, JsonProperty(Order = 231)]
		private bool _Ps3DrawEdgeGeometryEnable;

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private bool _Ps3DrawNonEdgeGeometryEnable;

		[ObservableProperty]
		[property: ContainerField(233), LayoutImmutable, Blittable, JsonProperty(Order = 233)]
		private bool _Ps3TriangleCullEnable;

		[ObservableProperty]
		[property: ContainerField(234), LayoutImmutable, Blittable, JsonProperty(Order = 234)]
		private bool _Ps3TriangleFrustumCullEnable;

		[ObservableProperty]
		[property: ContainerField(235), LayoutImmutable, Blittable, JsonProperty(Order = 235)]
		private bool _Ps3TriangleBackfaceCullEnable;

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private bool _Ps3TriangleCullZPassEnable;

		[ObservableProperty]
		[property: ContainerField(237), LayoutImmutable, Blittable, JsonProperty(Order = 237)]
		private bool _Ps3TriangleCullDoubleSidedEnable;

		[ObservableProperty]
		[property: ContainerField(238), LayoutImmutable, Blittable, JsonProperty(Order = 238)]
		private bool _Ps3TriangleCull1BoneSkinningEnable;

		[ObservableProperty]
		[property: ContainerField(239), LayoutImmutable, Blittable, JsonProperty(Order = 239)]
		private bool _Ps3TriangleCull4BoneSkinningEnable;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private bool _Ps3TrianglePartCullEnable;

		[ObservableProperty]
		[property: ContainerField(241), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
		private bool _Ps3DrawBlockCullEnable;

		[ObservableProperty]
		[property: ContainerField(242), LayoutImmutable, Blittable, JsonProperty(Order = 242)]
		private bool _Ps3PartitionFrustumCullEnable;

		[ObservableProperty]
		[property: ContainerField(243), LayoutImmutable, Blittable, JsonProperty(Order = 243)]
		private bool _Ps3PartitionClipPlaneCullEnable;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private bool _Ps3PartitionVolumeCullEnable;

		[ObservableProperty]
		[property: ContainerField(245), LayoutImmutable, Blittable, JsonProperty(Order = 245)]
		private bool _Ps3SpuInstancingEnable;

		[ObservableProperty]
		[property: ContainerField(246), LayoutImmutable, Blittable, JsonProperty(Order = 246)]
		private bool _Ps3SpuClipPlaneRejectEnable;

		[ObservableProperty]
		[property: ContainerField(247), LayoutImmutable, Blittable, JsonProperty(Order = 247)]
		private bool _Ps3SpuCullVolumesEnable;

		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private bool _Ps3DispatchJobEnable;

		[ObservableProperty]
		[property: ContainerField(249), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
		private bool _OnDemandBuildingEnable;

		[ObservableProperty]
		[property: ContainerField(250), LayoutImmutable, Blittable, JsonProperty(Order = 250)]
		private bool _OnDemandPrimingEnable;

		[ObservableProperty]
		[property: ContainerField(251), LayoutImmutable, Blittable, JsonProperty(Order = 251)]
		private bool _DispatchExecuteEnable;

		[ObservableProperty]
		[property: ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		private bool _TextureGammaCorrectionEnable;

		[ObservableProperty]
		[property: ContainerField(253), LayoutImmutable, Blittable, JsonProperty(Order = 253)]
		private bool _TileClassificationEnable;

		[ObservableProperty]
		[property: ContainerField(254), LayoutImmutable, Blittable, JsonProperty(Order = 254)]
		private bool _Ps3DispatchSpuBufferLinkingEnable;

		[ObservableProperty]
		[property: ContainerField(255), LayoutImmutable, Blittable, JsonProperty(Order = 255)]
		private bool _Ps3DispatchFrameBlockEnable;

		[ObservableProperty]
		[property: ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private bool _Ps3SCullEnable;

		[ObservableProperty]
		[property: ContainerField(257), LayoutImmutable, Blittable, JsonProperty(Order = 257)]
		private bool _Ps3ZCullEnable;

		[ObservableProperty]
		[property: ContainerField(258), LayoutImmutable, Blittable, JsonProperty(Order = 258)]
		private bool _DrawInstancedBlocks;

		[ObservableProperty]
		[property: ContainerField(259), LayoutImmutable, Blittable, JsonProperty(Order = 259)]
		private bool _DispatchPrepareBlockEnable;

		[ObservableProperty]
		[property: ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		private bool _DrawNonInstancedBlocks;

		[ObservableProperty]
		[property: ContainerField(261), LayoutImmutable, Blittable, JsonProperty(Order = 261)]
		private bool _DrawNonStreamedTextureBlocks;

		[ObservableProperty]
		[property: ContainerField(262), LayoutImmutable, Blittable, JsonProperty(Order = 262)]
		private bool _Ps3TxpDemotionEnable;

		[ObservableProperty]
		[property: ContainerField(263), LayoutImmutable, Blittable, JsonProperty(Order = 263)]
		private bool _Ps3CmdBufVertexShaderInlineEnable;

		[ObservableProperty]
		[property: ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		private bool _Ps3CmdBufClearEnable;

		[ObservableProperty]
		[property: ContainerField(265), LayoutImmutable, Blittable, JsonProperty(Order = 265)]
		private bool _Ps3SpuYieldingEnable;

		[ObservableProperty]
		[property: ContainerField(266), LayoutImmutable, Blittable, JsonProperty(Order = 266)]
		private bool _XenonDispatchJobEnable;

		[ObservableProperty]
		[property: ContainerField(267), LayoutImmutable, Blittable, JsonProperty(Order = 267)]
		private bool _DrawInlineBlocks;

		[ObservableProperty]
		[property: ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		private bool _Ps3FlushEnable;

		[ObservableProperty]
		[property: ContainerField(269), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
		private bool _Ps3FinishEnable;

		[ObservableProperty]
		[property: ContainerField(270), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
		private bool _DxMultisampleEnable;

		[ObservableProperty]
		[property: ContainerField(271), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
		private bool _DxTransparencySupersamplingEnable;

		[ObservableProperty]
		[property: ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		private bool _DxSamplerStatesEnable;

		[ObservableProperty]
		[property: ContainerField(273), LayoutImmutable, Blittable, JsonProperty(Order = 273)]
		private bool _DxBatchedSamplerStatesEnable;

		[ObservableProperty]
		[property: ContainerField(274), LayoutImmutable, Blittable, JsonProperty(Order = 274)]
		private bool _DxBatchedTexturesEnable;

		[ObservableProperty]
		[property: ContainerField(275), LayoutImmutable, Blittable, JsonProperty(Order = 275)]
		private bool _DxStatesEnable;

		[ObservableProperty]
		[property: ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		private bool _DrawOpaqueAlphaTestSimple;

		[ObservableProperty]
		[property: ContainerField(277), LayoutImmutable, Blittable, JsonProperty(Order = 277)]
		private bool _FlushEnable;

		[ObservableProperty]
		[property: ContainerField(278), LayoutImmutable, Blittable, JsonProperty(Order = 278)]
		private bool _DrawTransparent;

		[ObservableProperty]
		[property: ContainerField(279), LayoutImmutable, Blittable, JsonProperty(Order = 279)]
		private bool _DrawAdvancedStats;

		[ObservableProperty]
		[property: ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		private bool _DxParallelShaderLoadingEnable;

		[ObservableProperty]
		[property: ContainerField(281), LayoutImmutable, Blittable, JsonProperty(Order = 281)]
		private bool _DxDelayedShaderLoadingEnable;

		[ObservableProperty]
		[property: ContainerField(282), LayoutImmutable, Blittable, JsonProperty(Order = 282)]
		private bool _DrawOpaque;

		[ObservableProperty]
		[property: ContainerField(283), LayoutImmutable, Blittable, JsonProperty(Order = 283)]
		private bool _DrawOpaqueAlphaTest;

		[ObservableProperty]
		[property: ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		private bool _XenonHiZEnable;

		[ObservableProperty]
		[property: ContainerField(285), LayoutImmutable, Blittable, JsonProperty(Order = 285)]
		private bool _DrawZOnly;

		[ObservableProperty]
		[property: ContainerField(286), LayoutImmutable, Blittable, JsonProperty(Order = 286)]
		private bool _DrawStats;

		[ObservableProperty]
		[property: ContainerField(287), LayoutImmutable, Blittable, JsonProperty(Order = 287)]
		private bool _XenonDispatchBlockOnCmdBufEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
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
