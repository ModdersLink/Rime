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

namespace fb.Render;

[ContainerType(16, 384)]
public class ShaderSystemSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint FrameMemoryBufferSize { get; set; } = 3145728;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public QualityLevel ShaderQualityLevel { get; set; } = QualityLevel.QualityLevel_Low;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 DebugNonFiniteColor { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float MipmapBias { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float MinMipmap { get; set; } = 0.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float MaxMipmap { get; set; } = 16.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int ForceMaxAnisotropy { get; set; } = -1;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint MaxAnisotropyLow { get; set; } = 2;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public uint MaxAnisotropyMedium { get; set; } = 2;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public uint MaxAnisotropyHigh { get; set; } = 2;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public uint MaxAnisotropyUltra { get; set; } = 2;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public uint XenonTrilinearThreshold { get; set; } = 3;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public uint DrawCallMultiplier { get; set; } = 1;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public uint OverdrawMaxLayerCount { get; set; } = 30;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public uint DxMaxInstructionCount { get; set; } = 250;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float DistortionMaxValueScale { get; set; } = 0.150f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float SubSurfaceScatteringMaxWidth { get; set; } = 5.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public int DispatchPrepareJobCount { get; set; } = -1;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public uint XenonDispatchJobCount { get; set; } = 12;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public uint XenonDispatchJobPriority { get; set; } = 0;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public uint XenonDispatchBlocksPerJob { get; set; } = 128;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public uint XenonDispatchMinJobBlockCount { get; set; } = 40;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public int XenonDispatchOnlyJob { get; set; } = -1;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public uint XenonDispatchCmdBufferSegmentSize { get; set; } = 32768;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public uint XenonDispatchCmdBufferSize { get; set; } = 0;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public uint Ps3GeometryJobCount { get; set; } = 6;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public uint Ps3GeometryJobPriority { get; set; } = 255;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public uint Ps3DispatchJobCount { get; set; } = 6;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public uint Ps3DispatchJobPriority { get; set; } = 255;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public int Ps3DispatchOnlyJob { get; set; } = -1;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public uint Ps3DispatchBlocksPerJob { get; set; } = 16;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public uint Ps3ZCullInFrontLimit { get; set; } = 50;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public uint Ps3ZCullBehindLimit { get; set; } = 2000;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public uint Ps3MinMipmap { get; set; } = 0;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public uint Ps3MaxMipmap { get; set; } = 12;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float Ps3GeometryYieldGranularity { get; set; } = 1.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float Ps3GeometryYieldAggressiveGranularity { get; set; } = 0.050f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float Ps3DispatchYieldGranularity { get; set; } = 1.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float Ps3DispatchYieldAggressiveGranularity { get; set; } = 0.050f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public uint MaxInstanceCount { get; set; } = 0;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public uint DxVsFunctionConstantBufferSize { get; set; } = 512;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public uint DxPsFunctionConstantBufferSize { get; set; } = 92;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public uint DxVsExternalConstantBufferSize { get; set; } = 32;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public uint DxPsExternalConstantBufferSize { get; set; } = 64;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public uint DxDispatchJobMinBlockCount { get; set; } = 1;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public uint DxDispatchJobBlocksPerCommandList { get; set; } = 100;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public uint DxInstancingBufferMethod { get; set; } = 0;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public uint DxConstantBufferMethod { get; set; } = 0;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public int OrbisDispatchJobCount { get; set; } = -1;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public uint OrbisDispatchJobMinBlockCount { get; set; } = 4;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public uint OrbisDispatchJobBlockSize { get; set; } = 64;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float OrbisDispatchYieldGranularity { get; set; } = 0.500f;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public string OrbisPm4DisasmDispatch { get; set; } = string.Empty;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public uint MantleDispatchJobMinBlockCount { get; set; } = 4;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public uint MantleDispatchJobBlockSize { get; set; } = 64;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public bool FlushEnable { get; set; } = true;
	
	[ContainerField(0x109), LayoutImmutable, Blittable, JsonProperty(Order = 265)]
	public bool DispatchDirectEnable { get; set; } = true;
	
	[ContainerField(0x10a), LayoutImmutable, Blittable, JsonProperty(Order = 266)]
	public bool DrawStats { get; set; } = false;
	
	[ContainerField(0x10b), LayoutImmutable, Blittable, JsonProperty(Order = 267)]
	public bool DrawAdvancedStats { get; set; } = false;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public bool DrawZOnly { get; set; } = true;
	
	[ContainerField(0x10d), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
	public bool DrawOpaque { get; set; } = true;
	
	[ContainerField(0x10e), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
	public bool DrawOpaqueAlphaTest { get; set; } = true;
	
	[ContainerField(0x10f), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
	public bool DrawOpaqueAlphaTestSimple { get; set; } = true;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public bool DrawTransparent { get; set; } = true;
	
	[ContainerField(0x111), LayoutImmutable, Blittable, JsonProperty(Order = 273)]
	public bool DrawTransparentDecal { get; set; } = true;
	
	[ContainerField(0x112), LayoutImmutable, Blittable, JsonProperty(Order = 274)]
	public bool DrawTransparentDepth { get; set; } = true;
	
	[ContainerField(0x113), LayoutImmutable, Blittable, JsonProperty(Order = 275)]
	public bool DrawInlineBlocks { get; set; } = true;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public bool DrawStreamedTextureBlocks { get; set; } = true;
	
	[ContainerField(0x115), LayoutImmutable, Blittable, JsonProperty(Order = 277)]
	public bool DrawNonStreamedTextureBlocks { get; set; } = true;
	
	[ContainerField(0x116), LayoutImmutable, Blittable, JsonProperty(Order = 278)]
	public bool DrawInstancedBlocks { get; set; } = true;
	
	[ContainerField(0x117), LayoutImmutable, Blittable, JsonProperty(Order = 279)]
	public bool DrawNonInstancedBlocks { get; set; } = true;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public bool DrawTileClassifiedBlocks { get; set; } = true;
	
	[ContainerField(0x119), LayoutImmutable, Blittable, JsonProperty(Order = 281)]
	public bool TileClassificationEnable { get; set; } = true;
	
	[ContainerField(0x11a), LayoutImmutable, Blittable, JsonProperty(Order = 282)]
	public bool OnDemandBuildingEnable { get; set; } = false;
	
	[ContainerField(0x11b), LayoutImmutable, Blittable, JsonProperty(Order = 283)]
	public bool OnDemandPrimingEnable { get; set; } = true;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public bool OnDemandMonitoringEnable { get; set; } = true;
	
	[ContainerField(0x11d), LayoutImmutable, Blittable, JsonProperty(Order = 285)]
	public bool DatabaseLoadingEnable { get; set; } = true;
	
	[ContainerField(0x11e), LayoutImmutable, Blittable, JsonProperty(Order = 286)]
	public bool AlphaBlendEnable { get; set; } = true;
	
	[ContainerField(0x11f), LayoutImmutable, Blittable, JsonProperty(Order = 287)]
	public bool ForceDoubleSided { get; set; } = false;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public bool ForcePointFiltering { get; set; } = false;
	
	[ContainerField(0x121), LayoutImmutable, Blittable, JsonProperty(Order = 289)]
	public bool ZeroViewportEnable { get; set; } = false;
	
	[ContainerField(0x122), LayoutImmutable, Blittable, JsonProperty(Order = 290)]
	public bool DepthEnable { get; set; } = true;
	
	[ContainerField(0x123), LayoutImmutable, Blittable, JsonProperty(Order = 291)]
	public bool DepthWriteEnable { get; set; } = true;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public bool DepthTestEnable { get; set; } = true;
	
	[ContainerField(0x125), LayoutImmutable, Blittable, JsonProperty(Order = 293)]
	public bool StencilEnable { get; set; } = true;
	
	[ContainerField(0x126), LayoutImmutable, Blittable, JsonProperty(Order = 294)]
	public bool ClipPlanesEnable { get; set; } = true;
	
	[ContainerField(0x127), LayoutImmutable, Blittable, JsonProperty(Order = 295)]
	public bool SinglePrimitiveEnable { get; set; } = false;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public bool DrawCallEnable { get; set; } = true;
	
	[ContainerField(0x129), LayoutImmutable, Blittable, JsonProperty(Order = 297)]
	public bool PixBlockEventsEnable { get; set; } = true;
	
	[ContainerField(0x12a), LayoutImmutable, Blittable, JsonProperty(Order = 298)]
	public bool ShaderPixScopeEnable { get; set; } = false;
	
	[ContainerField(0x12b), LayoutImmutable, Blittable, JsonProperty(Order = 299)]
	public bool GcmReplayMarkersEnable { get; set; } = false;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public bool SortBlocksEnable { get; set; } = true;
	
	[ContainerField(0x12d), LayoutImmutable, Blittable, JsonProperty(Order = 301)]
	public bool SimpleTexturesEnable { get; set; } = false;
	
	[ContainerField(0x12e), LayoutImmutable, Blittable, JsonProperty(Order = 302)]
	public bool SimpleTextureFilteringEnable { get; set; } = false;
	
	[ContainerField(0x12f), LayoutImmutable, Blittable, JsonProperty(Order = 303)]
	public bool LogEnable { get; set; } = false;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public bool SingleFrameLogEnable { get; set; } = false;
	
	[ContainerField(0x131), LayoutImmutable, Blittable, JsonProperty(Order = 305)]
	public bool SingleFrameLogOverwrite { get; set; } = false;
	
	[ContainerField(0x132), LayoutImmutable, Blittable, JsonProperty(Order = 306)]
	public bool SingleFrameBlockLogEnable { get; set; } = false;
	
	[ContainerField(0x133), LayoutImmutable, Blittable, JsonProperty(Order = 307)]
	public bool ExternalConstantsEnable { get; set; } = true;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public bool SimplePixelShaderEnable { get; set; } = false;
	
	[ContainerField(0x135), LayoutImmutable, Blittable, JsonProperty(Order = 309)]
	public bool SimpleVertexShaderEnable { get; set; } = false;
	
	[ContainerField(0x136), LayoutImmutable, Blittable, JsonProperty(Order = 310)]
	public bool PseudoInstancingEnable { get; set; } = true;
	
	[ContainerField(0x137), LayoutImmutable, Blittable, JsonProperty(Order = 311)]
	public bool StatesEnable { get; set; } = true;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public bool PixelConstantsEnable { get; set; } = true;
	
	[ContainerField(0x139), LayoutImmutable, Blittable, JsonProperty(Order = 313)]
	public bool VertexConstantsEnable { get; set; } = true;
	
	[ContainerField(0x13a), LayoutImmutable, Blittable, JsonProperty(Order = 314)]
	public bool PixelConstantRedundancyCheckingEnable { get; set; } = true;
	
	[ContainerField(0x13b), LayoutImmutable, Blittable, JsonProperty(Order = 315)]
	public bool VertexConstantRedundancyCheckingEnable { get; set; } = true;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public bool BoneConstantOptimizationEnable { get; set; } = true;
	
	[ContainerField(0x13d), LayoutImmutable, Blittable, JsonProperty(Order = 317)]
	public bool TextureGammaCorrectionEnable { get; set; } = true;
	
	[ContainerField(0x13e), LayoutImmutable, Blittable, JsonProperty(Order = 318)]
	public bool DispatchExecuteEnable { get; set; } = true;
	
	[ContainerField(0x13f), LayoutImmutable, Blittable, JsonProperty(Order = 319)]
	public bool DispatchSetupJobEnable { get; set; } = true;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public bool DispatchPrepareBlockEnable { get; set; } = false;
	
	[ContainerField(0x141), LayoutImmutable, Blittable, JsonProperty(Order = 321)]
	public bool XenonDispatchJobEnable { get; set; } = true;
	
	[ContainerField(0x142), LayoutImmutable, Blittable, JsonProperty(Order = 322)]
	public bool XenonDispatchAsyncCmdBufEnable { get; set; } = true;
	
	[ContainerField(0x143), LayoutImmutable, Blittable, JsonProperty(Order = 323)]
	public bool XenonDispatchBlockOnCmdBufEnable { get; set; } = false;
	
	[ContainerField(0x144), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
	public bool XenonHiZEnable { get; set; } = true;
	
	[ContainerField(0x145), LayoutImmutable, Blittable, JsonProperty(Order = 325)]
	public bool Ps3PixelShaderRedundancyCheckingEnable { get; set; } = true;
	
	[ContainerField(0x146), LayoutImmutable, Blittable, JsonProperty(Order = 326)]
	public bool Ps3PixelShaderHashStoreEnable { get; set; } = true;
	
	[ContainerField(0x147), LayoutImmutable, Blittable, JsonProperty(Order = 327)]
	public bool Ps3DispatchPrepareSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public bool Ps3DispatchSetupSpuJobEnable { get; set; } = true;
	
	[ContainerField(0x149), LayoutImmutable, Blittable, JsonProperty(Order = 329)]
	public bool Ps3GeometryJobEnable { get; set; } = true;
	
	[ContainerField(0x14a), LayoutImmutable, Blittable, JsonProperty(Order = 330)]
	public bool Ps3GeometryJobWithoutDispatchJobEnable { get; set; } = false;
	
	[ContainerField(0x14b), LayoutImmutable, Blittable, JsonProperty(Order = 331)]
	public bool Ps3GeometryDebugRenderEnable { get; set; } = false;
	
	[ContainerField(0x14c), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
	public bool Ps3DrawEdgeGeometryEnable { get; set; } = true;
	
	[ContainerField(0x14d), LayoutImmutable, Blittable, JsonProperty(Order = 333)]
	public bool Ps3DrawNonEdgeGeometryEnable { get; set; } = true;
	
	[ContainerField(0x14e), LayoutImmutable, Blittable, JsonProperty(Order = 334)]
	public bool Ps3TriangleCullEnable { get; set; } = true;
	
	[ContainerField(0x14f), LayoutImmutable, Blittable, JsonProperty(Order = 335)]
	public bool Ps3TriangleFrustumCullEnable { get; set; } = true;
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public bool Ps3TriangleBackfaceCullEnable { get; set; } = true;
	
	[ContainerField(0x151), LayoutImmutable, Blittable, JsonProperty(Order = 337)]
	public bool Ps3TriangleCullZPassEnable { get; set; } = true;
	
	[ContainerField(0x152), LayoutImmutable, Blittable, JsonProperty(Order = 338)]
	public bool Ps3TriangleCullDoubleSidedEnable { get; set; } = true;
	
	[ContainerField(0x153), LayoutImmutable, Blittable, JsonProperty(Order = 339)]
	public bool Ps3TriangleCull1BoneSkinningEnable { get; set; } = true;
	
	[ContainerField(0x154), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
	public bool Ps3TriangleCull4BoneSkinningEnable { get; set; } = true;
	
	[ContainerField(0x155), LayoutImmutable, Blittable, JsonProperty(Order = 341)]
	public bool Ps3TrianglePartCullEnable { get; set; } = true;
	
	[ContainerField(0x156), LayoutImmutable, Blittable, JsonProperty(Order = 342)]
	public bool Ps3DrawBlockCullEnable { get; set; } = true;
	
	[ContainerField(0x157), LayoutImmutable, Blittable, JsonProperty(Order = 343)]
	public bool Ps3PartitionFrustumCullEnable { get; set; } = true;
	
	[ContainerField(0x158), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
	public bool Ps3PartitionClipPlaneCullEnable { get; set; } = true;
	
	[ContainerField(0x159), LayoutImmutable, Blittable, JsonProperty(Order = 345)]
	public bool Ps3PartitionVolumeCullEnable { get; set; } = true;
	
	[ContainerField(0x15a), LayoutImmutable, Blittable, JsonProperty(Order = 346)]
	public bool Ps3SpuInstancingEnable { get; set; } = true;
	
	[ContainerField(0x15b), LayoutImmutable, Blittable, JsonProperty(Order = 347)]
	public bool Ps3SpuClipPlaneRejectEnable { get; set; } = true;
	
	[ContainerField(0x15c), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
	public bool Ps3SpuCullVolumesEnable { get; set; } = true;
	
	[ContainerField(0x15d), LayoutImmutable, Blittable, JsonProperty(Order = 349)]
	public bool Ps3DispatchJobEnable { get; set; } = true;
	
	[ContainerField(0x15e), LayoutImmutable, Blittable, JsonProperty(Order = 350)]
	public bool Ps3DispatchSpuBufferLinkingEnable { get; set; } = true;
	
	[ContainerField(0x15f), LayoutImmutable, Blittable, JsonProperty(Order = 351)]
	public bool Ps3DispatchFrameBlockEnable { get; set; } = false;
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public bool Ps3FrameGpuWaitEnable { get; set; } = true;
	
	[ContainerField(0x161), LayoutImmutable, Blittable, JsonProperty(Order = 353)]
	public bool Ps3SCullEnable { get; set; } = true;
	
	[ContainerField(0x162), LayoutImmutable, Blittable, JsonProperty(Order = 354)]
	public bool Ps3ZCullEnable { get; set; } = true;
	
	[ContainerField(0x163), LayoutImmutable, Blittable, JsonProperty(Order = 355)]
	public bool Ps3TxpDemotionEnable { get; set; } = false;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public bool Ps3CmdBufVertexShaderInlineEnable { get; set; } = false;
	
	[ContainerField(0x165), LayoutImmutable, Blittable, JsonProperty(Order = 357)]
	public bool Ps3CmdBufClearEnable { get; set; } = false;
	
	[ContainerField(0x166), LayoutImmutable, Blittable, JsonProperty(Order = 358)]
	public bool Ps3SpuYieldingEnable { get; set; } = true;
	
	[ContainerField(0x167), LayoutImmutable, Blittable, JsonProperty(Order = 359)]
	public bool MultisampleEnable { get; set; } = true;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public bool ParallelShaderLoadingEnable { get; set; } = true;
	
	[ContainerField(0x169), LayoutImmutable, Blittable, JsonProperty(Order = 361)]
	public bool DxTransparencySupersamplingEnable { get; set; } = false;
	
	[ContainerField(0x16a), LayoutImmutable, Blittable, JsonProperty(Order = 362)]
	public bool DxSamplerStatesEnable { get; set; } = true;
	
	[ContainerField(0x16b), LayoutImmutable, Blittable, JsonProperty(Order = 363)]
	public bool DxBatchedSamplerStatesEnable { get; set; } = false;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public bool DxBatchedTexturesEnable { get; set; } = false;
	
	[ContainerField(0x16d), LayoutImmutable, Blittable, JsonProperty(Order = 365)]
	public bool DxDispatchJobEnable { get; set; } = false;
	
	[ContainerField(0x16e), LayoutImmutable, Blittable, JsonProperty(Order = 366)]
	public bool DxDispatchAsync { get; set; } = true;
	
	[ContainerField(0x16f), LayoutImmutable, Blittable, JsonProperty(Order = 367)]
	public bool DxNullContextEnable { get; set; } = false;
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public bool OrbisDispatchAsync { get; set; } = true;
	
	[ContainerField(0x171), LayoutImmutable, Blittable, JsonProperty(Order = 369)]
	public bool Gen4aPlacementConstantBufferEnable { get; set; } = true;
	
	[ContainerField(0x172), LayoutImmutable, Blittable, JsonProperty(Order = 370)]
	public bool MantlePrimePipelinesEnable { get; set; } = true;
	
	[ContainerField(0x173), LayoutImmutable, Blittable, JsonProperty(Order = 371)]
	public bool MantleDispatchJobEnable { get; set; } = true;
	
	[ContainerField(0x174), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
	public bool MantleDispatchAsyncEnable { get; set; } = true;
	
	[ContainerField(0x175), LayoutImmutable, Blittable, JsonProperty(Order = 373)]
	public bool MantleReZEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FrameMemoryBufferSize);
		p_Writer.Write((int) ShaderQualityLevel);
		p_Writer.WriteNullBytes(8);
		DebugNonFiniteColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MipmapBias);
		p_Writer.Write(MinMipmap);
		p_Writer.Write(MaxMipmap);
		p_Writer.Write(ForceMaxAnisotropy);
		p_Writer.Write(MaxAnisotropyLow);
		p_Writer.Write(MaxAnisotropyMedium);
		p_Writer.Write(MaxAnisotropyHigh);
		p_Writer.Write(MaxAnisotropyUltra);
		p_Writer.Write(XenonTrilinearThreshold);
		p_Writer.Write(DrawCallMultiplier);
		p_Writer.Write(OverdrawMaxLayerCount);
		p_Writer.Write(DxMaxInstructionCount);
		p_Writer.Write(DistortionMaxValueScale);
		p_Writer.Write(SubSurfaceScatteringMaxWidth);
		p_Writer.Write(DispatchPrepareJobCount);
		p_Writer.Write(XenonDispatchJobCount);
		p_Writer.Write(XenonDispatchJobPriority);
		p_Writer.Write(XenonDispatchBlocksPerJob);
		p_Writer.Write(XenonDispatchMinJobBlockCount);
		p_Writer.Write(XenonDispatchOnlyJob);
		p_Writer.Write(XenonDispatchCmdBufferSegmentSize);
		p_Writer.Write(XenonDispatchCmdBufferSize);
		p_Writer.Write(Ps3GeometryJobCount);
		p_Writer.Write(Ps3GeometryJobPriority);
		p_Writer.Write(Ps3DispatchJobCount);
		p_Writer.Write(Ps3DispatchJobPriority);
		p_Writer.Write(Ps3DispatchOnlyJob);
		p_Writer.Write(Ps3DispatchBlocksPerJob);
		p_Writer.Write(Ps3ZCullInFrontLimit);
		p_Writer.Write(Ps3ZCullBehindLimit);
		p_Writer.Write(Ps3MinMipmap);
		p_Writer.Write(Ps3MaxMipmap);
		p_Writer.Write(Ps3GeometryYieldGranularity);
		p_Writer.Write(Ps3GeometryYieldAggressiveGranularity);
		p_Writer.Write(Ps3DispatchYieldGranularity);
		p_Writer.Write(Ps3DispatchYieldAggressiveGranularity);
		p_Writer.Write(MaxInstanceCount);
		p_Writer.Write(DxVsFunctionConstantBufferSize);
		p_Writer.Write(DxPsFunctionConstantBufferSize);
		p_Writer.Write(DxVsExternalConstantBufferSize);
		p_Writer.Write(DxPsExternalConstantBufferSize);
		p_Writer.Write(DxDispatchJobMinBlockCount);
		p_Writer.Write(DxDispatchJobBlocksPerCommandList);
		p_Writer.Write(DxInstancingBufferMethod);
		p_Writer.Write(DxConstantBufferMethod);
		p_Writer.Write(OrbisDispatchJobCount);
		p_Writer.Write(OrbisDispatchJobMinBlockCount);
		p_Writer.Write(OrbisDispatchJobBlockSize);
		p_Writer.Write(OrbisDispatchYieldGranularity);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(OrbisPm4DisasmDispatch));
		p_Writer.Write(MantleDispatchJobMinBlockCount);
		p_Writer.Write(MantleDispatchJobBlockSize);
		p_Writer.Write(FlushEnable);
		p_Writer.Write(DispatchDirectEnable);
		p_Writer.Write(DrawStats);
		p_Writer.Write(DrawAdvancedStats);
		p_Writer.Write(DrawZOnly);
		p_Writer.Write(DrawOpaque);
		p_Writer.Write(DrawOpaqueAlphaTest);
		p_Writer.Write(DrawOpaqueAlphaTestSimple);
		p_Writer.Write(DrawTransparent);
		p_Writer.Write(DrawTransparentDecal);
		p_Writer.Write(DrawTransparentDepth);
		p_Writer.Write(DrawInlineBlocks);
		p_Writer.Write(DrawStreamedTextureBlocks);
		p_Writer.Write(DrawNonStreamedTextureBlocks);
		p_Writer.Write(DrawInstancedBlocks);
		p_Writer.Write(DrawNonInstancedBlocks);
		p_Writer.Write(DrawTileClassifiedBlocks);
		p_Writer.Write(TileClassificationEnable);
		p_Writer.Write(OnDemandBuildingEnable);
		p_Writer.Write(OnDemandPrimingEnable);
		p_Writer.Write(OnDemandMonitoringEnable);
		p_Writer.Write(DatabaseLoadingEnable);
		p_Writer.Write(AlphaBlendEnable);
		p_Writer.Write(ForceDoubleSided);
		p_Writer.Write(ForcePointFiltering);
		p_Writer.Write(ZeroViewportEnable);
		p_Writer.Write(DepthEnable);
		p_Writer.Write(DepthWriteEnable);
		p_Writer.Write(DepthTestEnable);
		p_Writer.Write(StencilEnable);
		p_Writer.Write(ClipPlanesEnable);
		p_Writer.Write(SinglePrimitiveEnable);
		p_Writer.Write(DrawCallEnable);
		p_Writer.Write(PixBlockEventsEnable);
		p_Writer.Write(ShaderPixScopeEnable);
		p_Writer.Write(GcmReplayMarkersEnable);
		p_Writer.Write(SortBlocksEnable);
		p_Writer.Write(SimpleTexturesEnable);
		p_Writer.Write(SimpleTextureFilteringEnable);
		p_Writer.Write(LogEnable);
		p_Writer.Write(SingleFrameLogEnable);
		p_Writer.Write(SingleFrameLogOverwrite);
		p_Writer.Write(SingleFrameBlockLogEnable);
		p_Writer.Write(ExternalConstantsEnable);
		p_Writer.Write(SimplePixelShaderEnable);
		p_Writer.Write(SimpleVertexShaderEnable);
		p_Writer.Write(PseudoInstancingEnable);
		p_Writer.Write(StatesEnable);
		p_Writer.Write(PixelConstantsEnable);
		p_Writer.Write(VertexConstantsEnable);
		p_Writer.Write(PixelConstantRedundancyCheckingEnable);
		p_Writer.Write(VertexConstantRedundancyCheckingEnable);
		p_Writer.Write(BoneConstantOptimizationEnable);
		p_Writer.Write(TextureGammaCorrectionEnable);
		p_Writer.Write(DispatchExecuteEnable);
		p_Writer.Write(DispatchSetupJobEnable);
		p_Writer.Write(DispatchPrepareBlockEnable);
		p_Writer.Write(XenonDispatchJobEnable);
		p_Writer.Write(XenonDispatchAsyncCmdBufEnable);
		p_Writer.Write(XenonDispatchBlockOnCmdBufEnable);
		p_Writer.Write(XenonHiZEnable);
		p_Writer.Write(Ps3PixelShaderRedundancyCheckingEnable);
		p_Writer.Write(Ps3PixelShaderHashStoreEnable);
		p_Writer.Write(Ps3DispatchPrepareSpuJobEnable);
		p_Writer.Write(Ps3DispatchSetupSpuJobEnable);
		p_Writer.Write(Ps3GeometryJobEnable);
		p_Writer.Write(Ps3GeometryJobWithoutDispatchJobEnable);
		p_Writer.Write(Ps3GeometryDebugRenderEnable);
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
		p_Writer.Write(Ps3DispatchSpuBufferLinkingEnable);
		p_Writer.Write(Ps3DispatchFrameBlockEnable);
		p_Writer.Write(Ps3FrameGpuWaitEnable);
		p_Writer.Write(Ps3SCullEnable);
		p_Writer.Write(Ps3ZCullEnable);
		p_Writer.Write(Ps3TxpDemotionEnable);
		p_Writer.Write(Ps3CmdBufVertexShaderInlineEnable);
		p_Writer.Write(Ps3CmdBufClearEnable);
		p_Writer.Write(Ps3SpuYieldingEnable);
		p_Writer.Write(MultisampleEnable);
		p_Writer.Write(ParallelShaderLoadingEnable);
		p_Writer.Write(DxTransparencySupersamplingEnable);
		p_Writer.Write(DxSamplerStatesEnable);
		p_Writer.Write(DxBatchedSamplerStatesEnable);
		p_Writer.Write(DxBatchedTexturesEnable);
		p_Writer.Write(DxDispatchJobEnable);
		p_Writer.Write(DxDispatchAsync);
		p_Writer.Write(DxNullContextEnable);
		p_Writer.Write(OrbisDispatchAsync);
		p_Writer.Write(Gen4aPlacementConstantBufferEnable);
		p_Writer.Write(MantlePrimePipelinesEnable);
		p_Writer.Write(MantleDispatchJobEnable);
		p_Writer.Write(MantleDispatchAsyncEnable);
		p_Writer.Write(MantleReZEnable);
		p_Writer.WriteNullBytes(10);
	}
}

