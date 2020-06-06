///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class ShaderSystemSettings : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DebugNonFiniteColor { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint DxInstancingBufferHandlingMethod { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint FrameMemoryBufferSize { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint XenonDispatchCmdBufferSize { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public uint XenonDispatchCmdBufferSegmentSize { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public uint DxDispatchJobBlocksPerCommandList { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public uint DxDispatchJobMinBlockCount { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public uint DxFrameVertexBufferPoolSize { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public int XenonDispatchOnlyJob { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public uint DxVsExternalConstantBufferSize { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public uint DxVsFunctionConstantBufferSize { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public uint DxPsFunctionConstantBufferSize { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float Ps3GeometryYieldGranularity { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public uint XenonDispatchJobCount { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public int DispatchPrepareJobCount { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public uint Ps3MinMipmap { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public uint Ps3ZCullInFrontLimit { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public uint Ps3ZCullBehindLimit { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public int Ps3DispatchOnlyJob { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public uint Ps3DispatchJobSpuCount { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public uint DxMaxInstructionCount { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public uint OverdrawMaxLayerCount { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public uint Ps3GeometryJobCount { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public uint DxMaxInstanceCount { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float Ps3DispatchYieldGranularity { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public uint DxPsExternalConstantBufferSize { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public uint XenonDispatchBlocksPerJob { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public uint Ps3DispatchJobCount { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public int DxDispatchJobCount { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public uint DrawCallMultiplier { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public uint Ps3MaxMipmap { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float MipmapBias { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public uint MaxAnisotropy { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public uint ZOnlyMaxAnisotropy { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public uint XenonTrilinearThreshold { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public uint Ps3DispatchJobPriority { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public uint XenonDispatchMinJobBlockCount { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public uint Ps3GeometryJobSpuCount { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public uint Ps3DispatchBlocksPerJob { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public uint Ps3GeometryJobPriority { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public bool SinglePrimitiveEnable { get; set; } // 0xBC (188)
		
		[ContainerField(189), LayoutImmutable, Blittable]
		public bool SortBlocksEnable { get; set; } // 0xBD (189)
		
		[ContainerField(190), LayoutImmutable, Blittable]
		public bool DrawCallEnable { get; set; } // 0xBE (190)
		
		[ContainerField(191), LayoutImmutable, Blittable]
		public bool GcmReplayMarkersEnable { get; set; } // 0xBF (191)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public bool ClipPlanesEnable { get; set; } // 0xC0 (192)
		
		[ContainerField(193), LayoutImmutable, Blittable]
		public bool DepthTestEnable { get; set; } // 0xC1 (193)
		
		[ContainerField(194), LayoutImmutable, Blittable]
		public bool StencilEnable { get; set; } // 0xC2 (194)
		
		[ContainerField(195), LayoutImmutable, Blittable]
		public bool ShaderPixScopeEnable { get; set; } // 0xC3 (195)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public bool SingleFrameBlockLogEnable { get; set; } // 0xC4 (196)
		
		[ContainerField(197), LayoutImmutable, Blittable]
		public bool AlphaBlendEnable { get; set; } // 0xC5 (197)
		
		[ContainerField(198), LayoutImmutable, Blittable]
		public bool PixBlockEventsEnable { get; set; } // 0xC6 (198)
		
		[ContainerField(199), LayoutImmutable, Blittable]
		public bool SimpleTexturesEnable { get; set; } // 0xC7 (199)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public bool SimpleVertexShaderEnable { get; set; } // 0xC8 (200)
		
		[ContainerField(201), LayoutImmutable, Blittable]
		public bool PseudoInstancingEnable { get; set; } // 0xC9 (201)
		
		[ContainerField(202), LayoutImmutable, Blittable]
		public bool StatesEnable { get; set; } // 0xCA (202)
		
		[ContainerField(203), LayoutImmutable, Blittable]
		public bool PixelConstantsEnable { get; set; } // 0xCB (203)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public bool VertexConstantsEnable { get; set; } // 0xCC (204)
		
		[ContainerField(205), LayoutImmutable, Blittable]
		public bool PixelConstantRedundancyCheckingEnable { get; set; } // 0xCD (205)
		
		[ContainerField(206), LayoutImmutable, Blittable]
		public bool VertexConstantRedundancyCheckingEnable { get; set; } // 0xCE (206)
		
		[ContainerField(207), LayoutImmutable, Blittable]
		public bool SimpleTextureFilteringEnable { get; set; } // 0xCF (207)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public bool DepthWriteEnable { get; set; } // 0xD0 (208)
		
		[ContainerField(209), LayoutImmutable, Blittable]
		public bool DispatchDirectEnable { get; set; } // 0xD1 (209)
		
		[ContainerField(210), LayoutImmutable, Blittable]
		public bool DrawTileClassifiedBlocks { get; set; } // 0xD2 (210)
		
		[ContainerField(211), LayoutImmutable, Blittable]
		public bool DepthEnable { get; set; } // 0xD3 (211)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public bool DrawStreamedTextureBlocks { get; set; } // 0xD4 (212)
		
		[ContainerField(213), LayoutImmutable, Blittable]
		public bool ForcePointFiltering { get; set; } // 0xD5 (213)
		
		[ContainerField(214), LayoutImmutable, Blittable]
		public bool LogEnable { get; set; } // 0xD6 (214)
		
		[ContainerField(215), LayoutImmutable, Blittable]
		public bool ZeroViewportEnable { get; set; } // 0xD7 (215)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public bool DrawTransparentDecal { get; set; } // 0xD8 (216)
		
		[ContainerField(217), LayoutImmutable, Blittable]
		public bool SingleFrameLogEnable { get; set; } // 0xD9 (217)
		
		[ContainerField(218), LayoutImmutable, Blittable]
		public bool SingleFrameLogOverwrite { get; set; } // 0xDA (218)
		
		[ContainerField(219), LayoutImmutable, Blittable]
		public bool ForceDoubleSided { get; set; } // 0xDB (219)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public bool OnDemandMonitoringEnable { get; set; } // 0xDC (220)
		
		[ContainerField(221), LayoutImmutable, Blittable]
		public bool Ps3PixelShaderRedundancyCheckingEnable { get; set; } // 0xDD (221)
		
		[ContainerField(222), LayoutImmutable, Blittable]
		public bool Ps3PixelShaderHashStoreEnable { get; set; } // 0xDE (222)
		
		[ContainerField(223), LayoutImmutable, Blittable]
		public bool Ps3DispatchPrepareSpuJobEnable { get; set; } // 0xDF (223)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public bool Ps3DispatchSetupSpuJobEnable { get; set; } // 0xE0 (224)
		
		[ContainerField(225), LayoutImmutable, Blittable]
		public bool Ps3GeometryJobEnable { get; set; } // 0xE1 (225)
		
		[ContainerField(226), LayoutImmutable, Blittable]
		public bool DatabaseLoadingEnable { get; set; } // 0xE2 (226)
		
		[ContainerField(227), LayoutImmutable, Blittable]
		public bool SimplePixelShaderEnable { get; set; } // 0xE3 (227)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public bool Ps3GeometryJobWithoutDispatchJobEnable { get; set; } // 0xE4 (228)
		
		[ContainerField(229), LayoutImmutable, Blittable]
		public bool Ps3GeometryDebugRenderEnable { get; set; } // 0xE5 (229)
		
		[ContainerField(230), LayoutImmutable, Blittable]
		public bool BoneConstantOptimizationEnable { get; set; } // 0xE6 (230)
		
		[ContainerField(231), LayoutImmutable, Blittable]
		public bool Ps3DrawEdgeGeometryEnable { get; set; } // 0xE7 (231)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public bool Ps3DrawNonEdgeGeometryEnable { get; set; } // 0xE8 (232)
		
		[ContainerField(233), LayoutImmutable, Blittable]
		public bool Ps3TriangleCullEnable { get; set; } // 0xE9 (233)
		
		[ContainerField(234), LayoutImmutable, Blittable]
		public bool Ps3TriangleFrustumCullEnable { get; set; } // 0xEA (234)
		
		[ContainerField(235), LayoutImmutable, Blittable]
		public bool Ps3TriangleBackfaceCullEnable { get; set; } // 0xEB (235)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public bool Ps3TriangleCullZPassEnable { get; set; } // 0xEC (236)
		
		[ContainerField(237), LayoutImmutable, Blittable]
		public bool Ps3TriangleCullDoubleSidedEnable { get; set; } // 0xED (237)
		
		[ContainerField(238), LayoutImmutable, Blittable]
		public bool Ps3TriangleCull1BoneSkinningEnable { get; set; } // 0xEE (238)
		
		[ContainerField(239), LayoutImmutable, Blittable]
		public bool Ps3TriangleCull4BoneSkinningEnable { get; set; } // 0xEF (239)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public bool Ps3TrianglePartCullEnable { get; set; } // 0xF0 (240)
		
		[ContainerField(241), LayoutImmutable, Blittable]
		public bool Ps3DrawBlockCullEnable { get; set; } // 0xF1 (241)
		
		[ContainerField(242), LayoutImmutable, Blittable]
		public bool Ps3PartitionFrustumCullEnable { get; set; } // 0xF2 (242)
		
		[ContainerField(243), LayoutImmutable, Blittable]
		public bool Ps3PartitionClipPlaneCullEnable { get; set; } // 0xF3 (243)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public bool Ps3PartitionVolumeCullEnable { get; set; } // 0xF4 (244)
		
		[ContainerField(245), LayoutImmutable, Blittable]
		public bool Ps3SpuInstancingEnable { get; set; } // 0xF5 (245)
		
		[ContainerField(246), LayoutImmutable, Blittable]
		public bool Ps3SpuClipPlaneRejectEnable { get; set; } // 0xF6 (246)
		
		[ContainerField(247), LayoutImmutable, Blittable]
		public bool Ps3SpuCullVolumesEnable { get; set; } // 0xF7 (247)
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public bool Ps3DispatchJobEnable { get; set; } // 0xF8 (248)
		
		[ContainerField(249), LayoutImmutable, Blittable]
		public bool OnDemandBuildingEnable { get; set; } // 0xF9 (249)
		
		[ContainerField(250), LayoutImmutable, Blittable]
		public bool OnDemandPrimingEnable { get; set; } // 0xFA (250)
		
		[ContainerField(251), LayoutImmutable, Blittable]
		public bool DispatchExecuteEnable { get; set; } // 0xFB (251)
		
		[ContainerField(252), LayoutImmutable, Blittable]
		public bool TextureGammaCorrectionEnable { get; set; } // 0xFC (252)
		
		[ContainerField(253), LayoutImmutable, Blittable]
		public bool TileClassificationEnable { get; set; } // 0xFD (253)
		
		[ContainerField(254), LayoutImmutable, Blittable]
		public bool Ps3DispatchSpuBufferLinkingEnable { get; set; } // 0xFE (254)
		
		[ContainerField(255), LayoutImmutable, Blittable]
		public bool Ps3DispatchFrameBlockEnable { get; set; } // 0xFF (255)
		
		[ContainerField(256), LayoutImmutable, Blittable]
		public bool Ps3SCullEnable { get; set; } // 0x100 (256)
		
		[ContainerField(257), LayoutImmutable, Blittable]
		public bool Ps3ZCullEnable { get; set; } // 0x101 (257)
		
		[ContainerField(258), LayoutImmutable, Blittable]
		public bool DrawInstancedBlocks { get; set; } // 0x102 (258)
		
		[ContainerField(259), LayoutImmutable, Blittable]
		public bool DispatchPrepareBlockEnable { get; set; } // 0x103 (259)
		
		[ContainerField(260), LayoutImmutable, Blittable]
		public bool DrawNonInstancedBlocks { get; set; } // 0x104 (260)
		
		[ContainerField(261), LayoutImmutable, Blittable]
		public bool DrawNonStreamedTextureBlocks { get; set; } // 0x105 (261)
		
		[ContainerField(262), LayoutImmutable, Blittable]
		public bool Ps3TxpDemotionEnable { get; set; } // 0x106 (262)
		
		[ContainerField(263), LayoutImmutable, Blittable]
		public bool Ps3CmdBufVertexShaderInlineEnable { get; set; } // 0x107 (263)
		
		[ContainerField(264), LayoutImmutable, Blittable]
		public bool Ps3CmdBufClearEnable { get; set; } // 0x108 (264)
		
		[ContainerField(265), LayoutImmutable, Blittable]
		public bool Ps3SpuYieldingEnable { get; set; } // 0x109 (265)
		
		[ContainerField(266), LayoutImmutable, Blittable]
		public bool XenonDispatchJobEnable { get; set; } // 0x10A (266)
		
		[ContainerField(267), LayoutImmutable, Blittable]
		public bool DrawInlineBlocks { get; set; } // 0x10B (267)
		
		[ContainerField(268), LayoutImmutable, Blittable]
		public bool Ps3FlushEnable { get; set; } // 0x10C (268)
		
		[ContainerField(269), LayoutImmutable, Blittable]
		public bool Ps3FinishEnable { get; set; } // 0x10D (269)
		
		[ContainerField(270), LayoutImmutable, Blittable]
		public bool DxMultisampleEnable { get; set; } // 0x10E (270)
		
		[ContainerField(271), LayoutImmutable, Blittable]
		public bool DxTransparencySupersamplingEnable { get; set; } // 0x10F (271)
		
		[ContainerField(272), LayoutImmutable, Blittable]
		public bool DxSamplerStatesEnable { get; set; } // 0x110 (272)
		
		[ContainerField(273), LayoutImmutable, Blittable]
		public bool DxBatchedSamplerStatesEnable { get; set; } // 0x111 (273)
		
		[ContainerField(274), LayoutImmutable, Blittable]
		public bool DxBatchedTexturesEnable { get; set; } // 0x112 (274)
		
		[ContainerField(275), LayoutImmutable, Blittable]
		public bool DxStatesEnable { get; set; } // 0x113 (275)
		
		[ContainerField(276), LayoutImmutable, Blittable]
		public bool DrawOpaqueAlphaTestSimple { get; set; } // 0x114 (276)
		
		[ContainerField(277), LayoutImmutable, Blittable]
		public bool FlushEnable { get; set; } // 0x115 (277)
		
		[ContainerField(278), LayoutImmutable, Blittable]
		public bool DrawTransparent { get; set; } // 0x116 (278)
		
		[ContainerField(279), LayoutImmutable, Blittable]
		public bool DrawAdvancedStats { get; set; } // 0x117 (279)
		
		[ContainerField(280), LayoutImmutable, Blittable]
		public bool DxParallelShaderLoadingEnable { get; set; } // 0x118 (280)
		
		[ContainerField(281), LayoutImmutable, Blittable]
		public bool DxDelayedShaderLoadingEnable { get; set; } // 0x119 (281)
		
		[ContainerField(282), LayoutImmutable, Blittable]
		public bool DrawOpaque { get; set; } // 0x11A (282)
		
		[ContainerField(283), LayoutImmutable, Blittable]
		public bool DrawOpaqueAlphaTest { get; set; } // 0x11B (283)
		
		[ContainerField(284), LayoutImmutable, Blittable]
		public bool XenonHiZEnable { get; set; } // 0x11C (284)
		
		[ContainerField(285), LayoutImmutable, Blittable]
		public bool DrawZOnly { get; set; } // 0x11D (285)
		
		[ContainerField(286), LayoutImmutable, Blittable]
		public bool DrawStats { get; set; } // 0x11E (286)
		
		[ContainerField(287), LayoutImmutable, Blittable]
		public bool XenonDispatchBlockOnCmdBufEnable { get; set; } // 0x11F (287)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 23224639:
					DebugNonFiniteColor = (Vec3) p_Value;
					break;

				case 3987003333:
					DxInstancingBufferHandlingMethod = (uint) p_Value;
					break;

				case 2099352572:
					FrameMemoryBufferSize = (uint) p_Value;
					break;

				case 1663632488:
					XenonDispatchCmdBufferSize = (uint) p_Value;
					break;

				case 3045510795:
					XenonDispatchCmdBufferSegmentSize = (uint) p_Value;
					break;

				case 1025892758:
					DxDispatchJobBlocksPerCommandList = (uint) p_Value;
					break;

				case 4110158894:
					DxDispatchJobMinBlockCount = (uint) p_Value;
					break;

				case 3016412405:
					DxFrameVertexBufferPoolSize = (uint) p_Value;
					break;

				case 2675609140:
					XenonDispatchOnlyJob = (int) p_Value;
					break;

				case 1293203898:
					DxVsExternalConstantBufferSize = (uint) p_Value;
					break;

				case 2035486405:
					DxVsFunctionConstantBufferSize = (uint) p_Value;
					break;

				case 4091032707:
					DxPsFunctionConstantBufferSize = (uint) p_Value;
					break;

				case 3678416454:
					Ps3GeometryYieldGranularity = (float) p_Value;
					break;

				case 3325122691:
					XenonDispatchJobCount = (uint) p_Value;
					break;

				case 351213840:
					DispatchPrepareJobCount = (int) p_Value;
					break;

				case 1329842871:
					Ps3MinMipmap = (uint) p_Value;
					break;

				case 1161949834:
					Ps3ZCullInFrontLimit = (uint) p_Value;
					break;

				case 1558768672:
					Ps3ZCullBehindLimit = (uint) p_Value;
					break;

				case 2506625750:
					Ps3DispatchOnlyJob = (int) p_Value;
					break;

				case 3777464055:
					Ps3DispatchJobSpuCount = (uint) p_Value;
					break;

				case 896565718:
					DxMaxInstructionCount = (uint) p_Value;
					break;

				case 2040865183:
					OverdrawMaxLayerCount = (uint) p_Value;
					break;

				case 1339109483:
					Ps3GeometryJobCount = (uint) p_Value;
					break;

				case 3951925415:
					DxMaxInstanceCount = (uint) p_Value;
					break;

				case 1313266572:
					Ps3DispatchYieldGranularity = (float) p_Value;
					break;

				case 2367594364:
					DxPsExternalConstantBufferSize = (uint) p_Value;
					break;

				case 2818002173:
					XenonDispatchBlocksPerJob = (uint) p_Value;
					break;

				case 596433441:
					Ps3DispatchJobCount = (uint) p_Value;
					break;

				case 1428253645:
					DxDispatchJobCount = (int) p_Value;
					break;

				case 1068468236:
					DrawCallMultiplier = (uint) p_Value;
					break;

				case 1346293929:
					Ps3MaxMipmap = (uint) p_Value;
					break;

				case 196267572:
					MipmapBias = (float) p_Value;
					break;

				case 4067026955:
					MaxAnisotropy = (uint) p_Value;
					break;

				case 3045055205:
					ZOnlyMaxAnisotropy = (uint) p_Value;
					break;

				case 1386781874:
					XenonTrilinearThreshold = (uint) p_Value;
					break;

				case 4233096400:
					Ps3DispatchJobPriority = (uint) p_Value;
					break;

				case 1718814144:
					XenonDispatchMinJobBlockCount = (uint) p_Value;
					break;

				case 1554833789:
					Ps3GeometryJobSpuCount = (uint) p_Value;
					break;

				case 4009989599:
					Ps3DispatchBlocksPerJob = (uint) p_Value;
					break;

				case 2180130138:
					Ps3GeometryJobPriority = (uint) p_Value;
					break;

				case 3384211263:
					SinglePrimitiveEnable = (bool) p_Value;
					break;

				case 1220513028:
					SortBlocksEnable = (bool) p_Value;
					break;

				case 1808690598:
					DrawCallEnable = (bool) p_Value;
					break;

				case 104325775:
					GcmReplayMarkersEnable = (bool) p_Value;
					break;

				case 2835056503:
					ClipPlanesEnable = (bool) p_Value;
					break;

				case 856474303:
					DepthTestEnable = (bool) p_Value;
					break;

				case 3861842670:
					StencilEnable = (bool) p_Value;
					break;

				case 1177023110:
					ShaderPixScopeEnable = (bool) p_Value;
					break;

				case 1375442894:
					SingleFrameBlockLogEnable = (bool) p_Value;
					break;

				case 1065772849:
					AlphaBlendEnable = (bool) p_Value;
					break;

				case 4262956787:
					PixBlockEventsEnable = (bool) p_Value;
					break;

				case 3995657318:
					SimpleTexturesEnable = (bool) p_Value;
					break;

				case 2993514187:
					SimpleVertexShaderEnable = (bool) p_Value;
					break;

				case 355059856:
					PseudoInstancingEnable = (bool) p_Value;
					break;

				case 449924128:
					StatesEnable = (bool) p_Value;
					break;

				case 3949301121:
					PixelConstantsEnable = (bool) p_Value;
					break;

				case 1590655137:
					VertexConstantsEnable = (bool) p_Value;
					break;

				case 3456434157:
					PixelConstantRedundancyCheckingEnable = (bool) p_Value;
					break;

				case 90990669:
					VertexConstantRedundancyCheckingEnable = (bool) p_Value;
					break;

				case 2920178357:
					SimpleTextureFilteringEnable = (bool) p_Value;
					break;

				case 2382302452:
					DepthWriteEnable = (bool) p_Value;
					break;

				case 505268473:
					DispatchDirectEnable = (bool) p_Value;
					break;

				case 1450821346:
					DrawTileClassifiedBlocks = (bool) p_Value;
					break;

				case 2635953449:
					DepthEnable = (bool) p_Value;
					break;

				case 4198440541:
					DrawStreamedTextureBlocks = (bool) p_Value;
					break;

				case 4030356532:
					ForcePointFiltering = (bool) p_Value;
					break;

				case 1242750240:
					LogEnable = (bool) p_Value;
					break;

				case 967736082:
					ZeroViewportEnable = (bool) p_Value;
					break;

				case 954292812:
					DrawTransparentDecal = (bool) p_Value;
					break;

				case 286069959:
					SingleFrameLogEnable = (bool) p_Value;
					break;

				case 23154741:
					SingleFrameLogOverwrite = (bool) p_Value;
					break;

				case 1019746770:
					ForceDoubleSided = (bool) p_Value;
					break;

				case 389992558:
					OnDemandMonitoringEnable = (bool) p_Value;
					break;

				case 817341418:
					Ps3PixelShaderRedundancyCheckingEnable = (bool) p_Value;
					break;

				case 807537816:
					Ps3PixelShaderHashStoreEnable = (bool) p_Value;
					break;

				case 1952514164:
					Ps3DispatchPrepareSpuJobEnable = (bool) p_Value;
					break;

				case 4264301426:
					Ps3DispatchSetupSpuJobEnable = (bool) p_Value;
					break;

				case 1161033513:
					Ps3GeometryJobEnable = (bool) p_Value;
					break;

				case 2824850887:
					DatabaseLoadingEnable = (bool) p_Value;
					break;

				case 3273843563:
					SimplePixelShaderEnable = (bool) p_Value;
					break;

				case 2116626642:
					Ps3GeometryJobWithoutDispatchJobEnable = (bool) p_Value;
					break;

				case 4017933973:
					Ps3GeometryDebugRenderEnable = (bool) p_Value;
					break;

				case 1779871005:
					BoneConstantOptimizationEnable = (bool) p_Value;
					break;

				case 1049907917:
					Ps3DrawEdgeGeometryEnable = (bool) p_Value;
					break;

				case 4096042498:
					Ps3DrawNonEdgeGeometryEnable = (bool) p_Value;
					break;

				case 907581676:
					Ps3TriangleCullEnable = (bool) p_Value;
					break;

				case 2693409042:
					Ps3TriangleFrustumCullEnable = (bool) p_Value;
					break;

				case 2172207942:
					Ps3TriangleBackfaceCullEnable = (bool) p_Value;
					break;

				case 1829559303:
					Ps3TriangleCullZPassEnable = (bool) p_Value;
					break;

				case 750843238:
					Ps3TriangleCullDoubleSidedEnable = (bool) p_Value;
					break;

				case 2282356842:
					Ps3TriangleCull1BoneSkinningEnable = (bool) p_Value;
					break;

				case 4038567215:
					Ps3TriangleCull4BoneSkinningEnable = (bool) p_Value;
					break;

				case 2508417883:
					Ps3TrianglePartCullEnable = (bool) p_Value;
					break;

				case 3383477611:
					Ps3DrawBlockCullEnable = (bool) p_Value;
					break;

				case 1828084478:
					Ps3PartitionFrustumCullEnable = (bool) p_Value;
					break;

				case 953623744:
					Ps3PartitionClipPlaneCullEnable = (bool) p_Value;
					break;

				case 1172266568:
					Ps3PartitionVolumeCullEnable = (bool) p_Value;
					break;

				case 4085224878:
					Ps3SpuInstancingEnable = (bool) p_Value;
					break;

				case 40145229:
					Ps3SpuClipPlaneRejectEnable = (bool) p_Value;
					break;

				case 2312942799:
					Ps3SpuCullVolumesEnable = (bool) p_Value;
					break;

				case 2569607715:
					Ps3DispatchJobEnable = (bool) p_Value;
					break;

				case 3142983540:
					OnDemandBuildingEnable = (bool) p_Value;
					break;

				case 1031717924:
					OnDemandPrimingEnable = (bool) p_Value;
					break;

				case 3821627435:
					DispatchExecuteEnable = (bool) p_Value;
					break;

				case 501150250:
					TextureGammaCorrectionEnable = (bool) p_Value;
					break;

				case 67079238:
					TileClassificationEnable = (bool) p_Value;
					break;

				case 3696968498:
					Ps3DispatchSpuBufferLinkingEnable = (bool) p_Value;
					break;

				case 336125968:
					Ps3DispatchFrameBlockEnable = (bool) p_Value;
					break;

				case 3556523217:
					Ps3SCullEnable = (bool) p_Value;
					break;

				case 3239977624:
					Ps3ZCullEnable = (bool) p_Value;
					break;

				case 738344370:
					DrawInstancedBlocks = (bool) p_Value;
					break;

				case 736860092:
					DispatchPrepareBlockEnable = (bool) p_Value;
					break;

				case 3032987357:
					DrawNonInstancedBlocks = (bool) p_Value;
					break;

				case 149509938:
					DrawNonStreamedTextureBlocks = (bool) p_Value;
					break;

				case 2998678519:
					Ps3TxpDemotionEnable = (bool) p_Value;
					break;

				case 3297671015:
					Ps3CmdBufVertexShaderInlineEnable = (bool) p_Value;
					break;

				case 1284811158:
					Ps3CmdBufClearEnable = (bool) p_Value;
					break;

				case 2296106943:
					Ps3SpuYieldingEnable = (bool) p_Value;
					break;

				case 2578580993:
					XenonDispatchJobEnable = (bool) p_Value;
					break;

				case 1067967350:
					DrawInlineBlocks = (bool) p_Value;
					break;

				case 968981744:
					Ps3FlushEnable = (bool) p_Value;
					break;

				case 2727001447:
					Ps3FinishEnable = (bool) p_Value;
					break;

				case 60513815:
					DxMultisampleEnable = (bool) p_Value;
					break;

				case 3389290418:
					DxTransparencySupersamplingEnable = (bool) p_Value;
					break;

				case 2484234024:
					DxSamplerStatesEnable = (bool) p_Value;
					break;

				case 3806413589:
					DxBatchedSamplerStatesEnable = (bool) p_Value;
					break;

				case 3898873385:
					DxBatchedTexturesEnable = (bool) p_Value;
					break;

				case 541903900:
					DxStatesEnable = (bool) p_Value;
					break;

				case 394966582:
					DrawOpaqueAlphaTestSimple = (bool) p_Value;
					break;

				case 3206413920:
					FlushEnable = (bool) p_Value;
					break;

				case 3651089763:
					DrawTransparent = (bool) p_Value;
					break;

				case 4051955738:
					DrawAdvancedStats = (bool) p_Value;
					break;

				case 1057678812:
					DxParallelShaderLoadingEnable = (bool) p_Value;
					break;

				case 167211107:
					DxDelayedShaderLoadingEnable = (bool) p_Value;
					break;

				case 1897318426:
					DrawOpaque = (bool) p_Value;
					break;

				case 1044040856:
					DrawOpaqueAlphaTest = (bool) p_Value;
					break;

				case 3737851501:
					XenonHiZEnable = (bool) p_Value;
					break;

				case 2420560875:
					DrawZOnly = (bool) p_Value;
					break;

				case 2413142628:
					DrawStats = (bool) p_Value;
					break;

				case 3499933781:
					XenonDispatchBlockOnCmdBufEnable = (bool) p_Value;
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
				case 23224639:
					return DebugNonFiniteColor;

				case 3987003333:
					return DxInstancingBufferHandlingMethod;

				case 2099352572:
					return FrameMemoryBufferSize;

				case 1663632488:
					return XenonDispatchCmdBufferSize;

				case 3045510795:
					return XenonDispatchCmdBufferSegmentSize;

				case 1025892758:
					return DxDispatchJobBlocksPerCommandList;

				case 4110158894:
					return DxDispatchJobMinBlockCount;

				case 3016412405:
					return DxFrameVertexBufferPoolSize;

				case 2675609140:
					return XenonDispatchOnlyJob;

				case 1293203898:
					return DxVsExternalConstantBufferSize;

				case 2035486405:
					return DxVsFunctionConstantBufferSize;

				case 4091032707:
					return DxPsFunctionConstantBufferSize;

				case 3678416454:
					return Ps3GeometryYieldGranularity;

				case 3325122691:
					return XenonDispatchJobCount;

				case 351213840:
					return DispatchPrepareJobCount;

				case 1329842871:
					return Ps3MinMipmap;

				case 1161949834:
					return Ps3ZCullInFrontLimit;

				case 1558768672:
					return Ps3ZCullBehindLimit;

				case 2506625750:
					return Ps3DispatchOnlyJob;

				case 3777464055:
					return Ps3DispatchJobSpuCount;

				case 896565718:
					return DxMaxInstructionCount;

				case 2040865183:
					return OverdrawMaxLayerCount;

				case 1339109483:
					return Ps3GeometryJobCount;

				case 3951925415:
					return DxMaxInstanceCount;

				case 1313266572:
					return Ps3DispatchYieldGranularity;

				case 2367594364:
					return DxPsExternalConstantBufferSize;

				case 2818002173:
					return XenonDispatchBlocksPerJob;

				case 596433441:
					return Ps3DispatchJobCount;

				case 1428253645:
					return DxDispatchJobCount;

				case 1068468236:
					return DrawCallMultiplier;

				case 1346293929:
					return Ps3MaxMipmap;

				case 196267572:
					return MipmapBias;

				case 4067026955:
					return MaxAnisotropy;

				case 3045055205:
					return ZOnlyMaxAnisotropy;

				case 1386781874:
					return XenonTrilinearThreshold;

				case 4233096400:
					return Ps3DispatchJobPriority;

				case 1718814144:
					return XenonDispatchMinJobBlockCount;

				case 1554833789:
					return Ps3GeometryJobSpuCount;

				case 4009989599:
					return Ps3DispatchBlocksPerJob;

				case 2180130138:
					return Ps3GeometryJobPriority;

				case 3384211263:
					return SinglePrimitiveEnable;

				case 1220513028:
					return SortBlocksEnable;

				case 1808690598:
					return DrawCallEnable;

				case 104325775:
					return GcmReplayMarkersEnable;

				case 2835056503:
					return ClipPlanesEnable;

				case 856474303:
					return DepthTestEnable;

				case 3861842670:
					return StencilEnable;

				case 1177023110:
					return ShaderPixScopeEnable;

				case 1375442894:
					return SingleFrameBlockLogEnable;

				case 1065772849:
					return AlphaBlendEnable;

				case 4262956787:
					return PixBlockEventsEnable;

				case 3995657318:
					return SimpleTexturesEnable;

				case 2993514187:
					return SimpleVertexShaderEnable;

				case 355059856:
					return PseudoInstancingEnable;

				case 449924128:
					return StatesEnable;

				case 3949301121:
					return PixelConstantsEnable;

				case 1590655137:
					return VertexConstantsEnable;

				case 3456434157:
					return PixelConstantRedundancyCheckingEnable;

				case 90990669:
					return VertexConstantRedundancyCheckingEnable;

				case 2920178357:
					return SimpleTextureFilteringEnable;

				case 2382302452:
					return DepthWriteEnable;

				case 505268473:
					return DispatchDirectEnable;

				case 1450821346:
					return DrawTileClassifiedBlocks;

				case 2635953449:
					return DepthEnable;

				case 4198440541:
					return DrawStreamedTextureBlocks;

				case 4030356532:
					return ForcePointFiltering;

				case 1242750240:
					return LogEnable;

				case 967736082:
					return ZeroViewportEnable;

				case 954292812:
					return DrawTransparentDecal;

				case 286069959:
					return SingleFrameLogEnable;

				case 23154741:
					return SingleFrameLogOverwrite;

				case 1019746770:
					return ForceDoubleSided;

				case 389992558:
					return OnDemandMonitoringEnable;

				case 817341418:
					return Ps3PixelShaderRedundancyCheckingEnable;

				case 807537816:
					return Ps3PixelShaderHashStoreEnable;

				case 1952514164:
					return Ps3DispatchPrepareSpuJobEnable;

				case 4264301426:
					return Ps3DispatchSetupSpuJobEnable;

				case 1161033513:
					return Ps3GeometryJobEnable;

				case 2824850887:
					return DatabaseLoadingEnable;

				case 3273843563:
					return SimplePixelShaderEnable;

				case 2116626642:
					return Ps3GeometryJobWithoutDispatchJobEnable;

				case 4017933973:
					return Ps3GeometryDebugRenderEnable;

				case 1779871005:
					return BoneConstantOptimizationEnable;

				case 1049907917:
					return Ps3DrawEdgeGeometryEnable;

				case 4096042498:
					return Ps3DrawNonEdgeGeometryEnable;

				case 907581676:
					return Ps3TriangleCullEnable;

				case 2693409042:
					return Ps3TriangleFrustumCullEnable;

				case 2172207942:
					return Ps3TriangleBackfaceCullEnable;

				case 1829559303:
					return Ps3TriangleCullZPassEnable;

				case 750843238:
					return Ps3TriangleCullDoubleSidedEnable;

				case 2282356842:
					return Ps3TriangleCull1BoneSkinningEnable;

				case 4038567215:
					return Ps3TriangleCull4BoneSkinningEnable;

				case 2508417883:
					return Ps3TrianglePartCullEnable;

				case 3383477611:
					return Ps3DrawBlockCullEnable;

				case 1828084478:
					return Ps3PartitionFrustumCullEnable;

				case 953623744:
					return Ps3PartitionClipPlaneCullEnable;

				case 1172266568:
					return Ps3PartitionVolumeCullEnable;

				case 4085224878:
					return Ps3SpuInstancingEnable;

				case 40145229:
					return Ps3SpuClipPlaneRejectEnable;

				case 2312942799:
					return Ps3SpuCullVolumesEnable;

				case 2569607715:
					return Ps3DispatchJobEnable;

				case 3142983540:
					return OnDemandBuildingEnable;

				case 1031717924:
					return OnDemandPrimingEnable;

				case 3821627435:
					return DispatchExecuteEnable;

				case 501150250:
					return TextureGammaCorrectionEnable;

				case 67079238:
					return TileClassificationEnable;

				case 3696968498:
					return Ps3DispatchSpuBufferLinkingEnable;

				case 336125968:
					return Ps3DispatchFrameBlockEnable;

				case 3556523217:
					return Ps3SCullEnable;

				case 3239977624:
					return Ps3ZCullEnable;

				case 738344370:
					return DrawInstancedBlocks;

				case 736860092:
					return DispatchPrepareBlockEnable;

				case 3032987357:
					return DrawNonInstancedBlocks;

				case 149509938:
					return DrawNonStreamedTextureBlocks;

				case 2998678519:
					return Ps3TxpDemotionEnable;

				case 3297671015:
					return Ps3CmdBufVertexShaderInlineEnable;

				case 1284811158:
					return Ps3CmdBufClearEnable;

				case 2296106943:
					return Ps3SpuYieldingEnable;

				case 2578580993:
					return XenonDispatchJobEnable;

				case 1067967350:
					return DrawInlineBlocks;

				case 968981744:
					return Ps3FlushEnable;

				case 2727001447:
					return Ps3FinishEnable;

				case 60513815:
					return DxMultisampleEnable;

				case 3389290418:
					return DxTransparencySupersamplingEnable;

				case 2484234024:
					return DxSamplerStatesEnable;

				case 3806413589:
					return DxBatchedSamplerStatesEnable;

				case 3898873385:
					return DxBatchedTexturesEnable;

				case 541903900:
					return DxStatesEnable;

				case 394966582:
					return DrawOpaqueAlphaTestSimple;

				case 3206413920:
					return FlushEnable;

				case 3651089763:
					return DrawTransparent;

				case 4051955738:
					return DrawAdvancedStats;

				case 1057678812:
					return DxParallelShaderLoadingEnable;

				case 167211107:
					return DxDelayedShaderLoadingEnable;

				case 1897318426:
					return DrawOpaque;

				case 1044040856:
					return DrawOpaqueAlphaTest;

				case 3737851501:
					return XenonHiZEnable;

				case 2420560875:
					return DrawZOnly;

				case 2413142628:
					return DrawStats;

				case 3499933781:
					return XenonDispatchBlockOnCmdBufEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 23224639:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DebugNonFiniteColor));

				case 3987003333:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxInstancingBufferHandlingMethod));

				case 2099352572:
					return typeof(ShaderSystemSettings).GetProperty(nameof(FrameMemoryBufferSize));

				case 1663632488:
					return typeof(ShaderSystemSettings).GetProperty(nameof(XenonDispatchCmdBufferSize));

				case 3045510795:
					return typeof(ShaderSystemSettings).GetProperty(nameof(XenonDispatchCmdBufferSegmentSize));

				case 1025892758:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxDispatchJobBlocksPerCommandList));

				case 4110158894:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxDispatchJobMinBlockCount));

				case 3016412405:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxFrameVertexBufferPoolSize));

				case 2675609140:
					return typeof(ShaderSystemSettings).GetProperty(nameof(XenonDispatchOnlyJob));

				case 1293203898:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxVsExternalConstantBufferSize));

				case 2035486405:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxVsFunctionConstantBufferSize));

				case 4091032707:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxPsFunctionConstantBufferSize));

				case 3678416454:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3GeometryYieldGranularity));

				case 3325122691:
					return typeof(ShaderSystemSettings).GetProperty(nameof(XenonDispatchJobCount));

				case 351213840:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DispatchPrepareJobCount));

				case 1329842871:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3MinMipmap));

				case 1161949834:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3ZCullInFrontLimit));

				case 1558768672:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3ZCullBehindLimit));

				case 2506625750:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DispatchOnlyJob));

				case 3777464055:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DispatchJobSpuCount));

				case 896565718:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxMaxInstructionCount));

				case 2040865183:
					return typeof(ShaderSystemSettings).GetProperty(nameof(OverdrawMaxLayerCount));

				case 1339109483:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3GeometryJobCount));

				case 3951925415:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxMaxInstanceCount));

				case 1313266572:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DispatchYieldGranularity));

				case 2367594364:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxPsExternalConstantBufferSize));

				case 2818002173:
					return typeof(ShaderSystemSettings).GetProperty(nameof(XenonDispatchBlocksPerJob));

				case 596433441:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DispatchJobCount));

				case 1428253645:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxDispatchJobCount));

				case 1068468236:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawCallMultiplier));

				case 1346293929:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3MaxMipmap));

				case 196267572:
					return typeof(ShaderSystemSettings).GetProperty(nameof(MipmapBias));

				case 4067026955:
					return typeof(ShaderSystemSettings).GetProperty(nameof(MaxAnisotropy));

				case 3045055205:
					return typeof(ShaderSystemSettings).GetProperty(nameof(ZOnlyMaxAnisotropy));

				case 1386781874:
					return typeof(ShaderSystemSettings).GetProperty(nameof(XenonTrilinearThreshold));

				case 4233096400:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DispatchJobPriority));

				case 1718814144:
					return typeof(ShaderSystemSettings).GetProperty(nameof(XenonDispatchMinJobBlockCount));

				case 1554833789:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3GeometryJobSpuCount));

				case 4009989599:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DispatchBlocksPerJob));

				case 2180130138:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3GeometryJobPriority));

				case 3384211263:
					return typeof(ShaderSystemSettings).GetProperty(nameof(SinglePrimitiveEnable));

				case 1220513028:
					return typeof(ShaderSystemSettings).GetProperty(nameof(SortBlocksEnable));

				case 1808690598:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawCallEnable));

				case 104325775:
					return typeof(ShaderSystemSettings).GetProperty(nameof(GcmReplayMarkersEnable));

				case 2835056503:
					return typeof(ShaderSystemSettings).GetProperty(nameof(ClipPlanesEnable));

				case 856474303:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DepthTestEnable));

				case 3861842670:
					return typeof(ShaderSystemSettings).GetProperty(nameof(StencilEnable));

				case 1177023110:
					return typeof(ShaderSystemSettings).GetProperty(nameof(ShaderPixScopeEnable));

				case 1375442894:
					return typeof(ShaderSystemSettings).GetProperty(nameof(SingleFrameBlockLogEnable));

				case 1065772849:
					return typeof(ShaderSystemSettings).GetProperty(nameof(AlphaBlendEnable));

				case 4262956787:
					return typeof(ShaderSystemSettings).GetProperty(nameof(PixBlockEventsEnable));

				case 3995657318:
					return typeof(ShaderSystemSettings).GetProperty(nameof(SimpleTexturesEnable));

				case 2993514187:
					return typeof(ShaderSystemSettings).GetProperty(nameof(SimpleVertexShaderEnable));

				case 355059856:
					return typeof(ShaderSystemSettings).GetProperty(nameof(PseudoInstancingEnable));

				case 449924128:
					return typeof(ShaderSystemSettings).GetProperty(nameof(StatesEnable));

				case 3949301121:
					return typeof(ShaderSystemSettings).GetProperty(nameof(PixelConstantsEnable));

				case 1590655137:
					return typeof(ShaderSystemSettings).GetProperty(nameof(VertexConstantsEnable));

				case 3456434157:
					return typeof(ShaderSystemSettings).GetProperty(nameof(PixelConstantRedundancyCheckingEnable));

				case 90990669:
					return typeof(ShaderSystemSettings).GetProperty(nameof(VertexConstantRedundancyCheckingEnable));

				case 2920178357:
					return typeof(ShaderSystemSettings).GetProperty(nameof(SimpleTextureFilteringEnable));

				case 2382302452:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DepthWriteEnable));

				case 505268473:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DispatchDirectEnable));

				case 1450821346:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawTileClassifiedBlocks));

				case 2635953449:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DepthEnable));

				case 4198440541:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawStreamedTextureBlocks));

				case 4030356532:
					return typeof(ShaderSystemSettings).GetProperty(nameof(ForcePointFiltering));

				case 1242750240:
					return typeof(ShaderSystemSettings).GetProperty(nameof(LogEnable));

				case 967736082:
					return typeof(ShaderSystemSettings).GetProperty(nameof(ZeroViewportEnable));

				case 954292812:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawTransparentDecal));

				case 286069959:
					return typeof(ShaderSystemSettings).GetProperty(nameof(SingleFrameLogEnable));

				case 23154741:
					return typeof(ShaderSystemSettings).GetProperty(nameof(SingleFrameLogOverwrite));

				case 1019746770:
					return typeof(ShaderSystemSettings).GetProperty(nameof(ForceDoubleSided));

				case 389992558:
					return typeof(ShaderSystemSettings).GetProperty(nameof(OnDemandMonitoringEnable));

				case 817341418:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3PixelShaderRedundancyCheckingEnable));

				case 807537816:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3PixelShaderHashStoreEnable));

				case 1952514164:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DispatchPrepareSpuJobEnable));

				case 4264301426:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DispatchSetupSpuJobEnable));

				case 1161033513:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3GeometryJobEnable));

				case 2824850887:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DatabaseLoadingEnable));

				case 3273843563:
					return typeof(ShaderSystemSettings).GetProperty(nameof(SimplePixelShaderEnable));

				case 2116626642:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3GeometryJobWithoutDispatchJobEnable));

				case 4017933973:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3GeometryDebugRenderEnable));

				case 1779871005:
					return typeof(ShaderSystemSettings).GetProperty(nameof(BoneConstantOptimizationEnable));

				case 1049907917:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DrawEdgeGeometryEnable));

				case 4096042498:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DrawNonEdgeGeometryEnable));

				case 907581676:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3TriangleCullEnable));

				case 2693409042:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3TriangleFrustumCullEnable));

				case 2172207942:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3TriangleBackfaceCullEnable));

				case 1829559303:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3TriangleCullZPassEnable));

				case 750843238:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3TriangleCullDoubleSidedEnable));

				case 2282356842:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3TriangleCull1BoneSkinningEnable));

				case 4038567215:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3TriangleCull4BoneSkinningEnable));

				case 2508417883:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3TrianglePartCullEnable));

				case 3383477611:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DrawBlockCullEnable));

				case 1828084478:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3PartitionFrustumCullEnable));

				case 953623744:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3PartitionClipPlaneCullEnable));

				case 1172266568:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3PartitionVolumeCullEnable));

				case 4085224878:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3SpuInstancingEnable));

				case 40145229:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3SpuClipPlaneRejectEnable));

				case 2312942799:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3SpuCullVolumesEnable));

				case 2569607715:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DispatchJobEnable));

				case 3142983540:
					return typeof(ShaderSystemSettings).GetProperty(nameof(OnDemandBuildingEnable));

				case 1031717924:
					return typeof(ShaderSystemSettings).GetProperty(nameof(OnDemandPrimingEnable));

				case 3821627435:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DispatchExecuteEnable));

				case 501150250:
					return typeof(ShaderSystemSettings).GetProperty(nameof(TextureGammaCorrectionEnable));

				case 67079238:
					return typeof(ShaderSystemSettings).GetProperty(nameof(TileClassificationEnable));

				case 3696968498:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DispatchSpuBufferLinkingEnable));

				case 336125968:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3DispatchFrameBlockEnable));

				case 3556523217:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3SCullEnable));

				case 3239977624:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3ZCullEnable));

				case 738344370:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawInstancedBlocks));

				case 736860092:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DispatchPrepareBlockEnable));

				case 3032987357:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawNonInstancedBlocks));

				case 149509938:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawNonStreamedTextureBlocks));

				case 2998678519:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3TxpDemotionEnable));

				case 3297671015:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3CmdBufVertexShaderInlineEnable));

				case 1284811158:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3CmdBufClearEnable));

				case 2296106943:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3SpuYieldingEnable));

				case 2578580993:
					return typeof(ShaderSystemSettings).GetProperty(nameof(XenonDispatchJobEnable));

				case 1067967350:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawInlineBlocks));

				case 968981744:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3FlushEnable));

				case 2727001447:
					return typeof(ShaderSystemSettings).GetProperty(nameof(Ps3FinishEnable));

				case 60513815:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxMultisampleEnable));

				case 3389290418:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxTransparencySupersamplingEnable));

				case 2484234024:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxSamplerStatesEnable));

				case 3806413589:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxBatchedSamplerStatesEnable));

				case 3898873385:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxBatchedTexturesEnable));

				case 541903900:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxStatesEnable));

				case 394966582:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawOpaqueAlphaTestSimple));

				case 3206413920:
					return typeof(ShaderSystemSettings).GetProperty(nameof(FlushEnable));

				case 3651089763:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawTransparent));

				case 4051955738:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawAdvancedStats));

				case 1057678812:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxParallelShaderLoadingEnable));

				case 167211107:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DxDelayedShaderLoadingEnable));

				case 1897318426:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawOpaque));

				case 1044040856:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawOpaqueAlphaTest));

				case 3737851501:
					return typeof(ShaderSystemSettings).GetProperty(nameof(XenonHiZEnable));

				case 2420560875:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawZOnly));

				case 2413142628:
					return typeof(ShaderSystemSettings).GetProperty(nameof(DrawStats));

				case 3499933781:
					return typeof(ShaderSystemSettings).GetProperty(nameof(XenonDispatchBlockOnCmdBufEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
