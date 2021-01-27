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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 288)]
	public class ShaderSystemSettings : 
		DataContainer
	{
		protected Vec3 m_DebugNonFiniteColor = new Vec3();
		[ContainerField(Name: "DebugNonFiniteColor", Offset: 16, NameHash: 23224639, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DebugNonFiniteColor { get { return m_DebugNonFiniteColor; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DebugNonFiniteColor), this, m_DebugNonFiniteColor, value)) m_DebugNonFiniteColor = value; } } // 0x10 (16)
		
		protected uint m_DxInstancingBufferHandlingMethod = new uint();
		[ContainerField(Name: "DxInstancingBufferHandlingMethod", Offset: 32, NameHash: 3987003333, Flags: 49421), LayoutImmutable, Blittable]
		public uint DxInstancingBufferHandlingMethod { get { return m_DxInstancingBufferHandlingMethod; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxInstancingBufferHandlingMethod), this, m_DxInstancingBufferHandlingMethod, value)) m_DxInstancingBufferHandlingMethod = value; } } // 0x20 (32)
		
		protected uint m_FrameMemoryBufferSize = new uint();
		[ContainerField(Name: "FrameMemoryBufferSize", Offset: 36, NameHash: 2099352572, Flags: 49421), LayoutImmutable, Blittable]
		public uint FrameMemoryBufferSize { get { return m_FrameMemoryBufferSize; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(FrameMemoryBufferSize), this, m_FrameMemoryBufferSize, value)) m_FrameMemoryBufferSize = value; } } // 0x24 (36)
		
		protected uint m_XenonDispatchCmdBufferSize = new uint();
		[ContainerField(Name: "XenonDispatchCmdBufferSize", Offset: 40, NameHash: 1663632488, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonDispatchCmdBufferSize { get { return m_XenonDispatchCmdBufferSize; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(XenonDispatchCmdBufferSize), this, m_XenonDispatchCmdBufferSize, value)) m_XenonDispatchCmdBufferSize = value; } } // 0x28 (40)
		
		protected uint m_XenonDispatchCmdBufferSegmentSize = new uint();
		[ContainerField(Name: "XenonDispatchCmdBufferSegmentSize", Offset: 44, NameHash: 3045510795, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonDispatchCmdBufferSegmentSize { get { return m_XenonDispatchCmdBufferSegmentSize; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(XenonDispatchCmdBufferSegmentSize), this, m_XenonDispatchCmdBufferSegmentSize, value)) m_XenonDispatchCmdBufferSegmentSize = value; } } // 0x2C (44)
		
		protected uint m_DxDispatchJobBlocksPerCommandList = new uint();
		[ContainerField(Name: "DxDispatchJobBlocksPerCommandList", Offset: 48, NameHash: 1025892758, Flags: 49421), LayoutImmutable, Blittable]
		public uint DxDispatchJobBlocksPerCommandList { get { return m_DxDispatchJobBlocksPerCommandList; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxDispatchJobBlocksPerCommandList), this, m_DxDispatchJobBlocksPerCommandList, value)) m_DxDispatchJobBlocksPerCommandList = value; } } // 0x30 (48)
		
		protected uint m_DxDispatchJobMinBlockCount = new uint();
		[ContainerField(Name: "DxDispatchJobMinBlockCount", Offset: 52, NameHash: 4110158894, Flags: 49421), LayoutImmutable, Blittable]
		public uint DxDispatchJobMinBlockCount { get { return m_DxDispatchJobMinBlockCount; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxDispatchJobMinBlockCount), this, m_DxDispatchJobMinBlockCount, value)) m_DxDispatchJobMinBlockCount = value; } } // 0x34 (52)
		
		protected uint m_DxFrameVertexBufferPoolSize = new uint();
		[ContainerField(Name: "DxFrameVertexBufferPoolSize", Offset: 56, NameHash: 3016412405, Flags: 49421), LayoutImmutable, Blittable]
		public uint DxFrameVertexBufferPoolSize { get { return m_DxFrameVertexBufferPoolSize; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxFrameVertexBufferPoolSize), this, m_DxFrameVertexBufferPoolSize, value)) m_DxFrameVertexBufferPoolSize = value; } } // 0x38 (56)
		
		protected int m_XenonDispatchOnlyJob = new int();
		[ContainerField(Name: "XenonDispatchOnlyJob", Offset: 60, NameHash: 2675609140, Flags: 49405), LayoutImmutable, Blittable]
		public int XenonDispatchOnlyJob { get { return m_XenonDispatchOnlyJob; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(XenonDispatchOnlyJob), this, m_XenonDispatchOnlyJob, value)) m_XenonDispatchOnlyJob = value; } } // 0x3C (60)
		
		protected uint m_DxVsExternalConstantBufferSize = new uint();
		[ContainerField(Name: "DxVsExternalConstantBufferSize", Offset: 64, NameHash: 1293203898, Flags: 49421), LayoutImmutable, Blittable]
		public uint DxVsExternalConstantBufferSize { get { return m_DxVsExternalConstantBufferSize; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxVsExternalConstantBufferSize), this, m_DxVsExternalConstantBufferSize, value)) m_DxVsExternalConstantBufferSize = value; } } // 0x40 (64)
		
		protected uint m_DxVsFunctionConstantBufferSize = new uint();
		[ContainerField(Name: "DxVsFunctionConstantBufferSize", Offset: 68, NameHash: 2035486405, Flags: 49421), LayoutImmutable, Blittable]
		public uint DxVsFunctionConstantBufferSize { get { return m_DxVsFunctionConstantBufferSize; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxVsFunctionConstantBufferSize), this, m_DxVsFunctionConstantBufferSize, value)) m_DxVsFunctionConstantBufferSize = value; } } // 0x44 (68)
		
		protected uint m_DxPsFunctionConstantBufferSize = new uint();
		[ContainerField(Name: "DxPsFunctionConstantBufferSize", Offset: 72, NameHash: 4091032707, Flags: 49421), LayoutImmutable, Blittable]
		public uint DxPsFunctionConstantBufferSize { get { return m_DxPsFunctionConstantBufferSize; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxPsFunctionConstantBufferSize), this, m_DxPsFunctionConstantBufferSize, value)) m_DxPsFunctionConstantBufferSize = value; } } // 0x48 (72)
		
		protected float m_Ps3GeometryYieldGranularity = new float();
		[ContainerField(Name: "Ps3GeometryYieldGranularity", Offset: 76, NameHash: 3678416454, Flags: 49469), LayoutImmutable, Blittable]
		public float Ps3GeometryYieldGranularity { get { return m_Ps3GeometryYieldGranularity; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3GeometryYieldGranularity), this, m_Ps3GeometryYieldGranularity, value)) m_Ps3GeometryYieldGranularity = value; } } // 0x4C (76)
		
		protected uint m_XenonDispatchJobCount = new uint();
		[ContainerField(Name: "XenonDispatchJobCount", Offset: 80, NameHash: 3325122691, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonDispatchJobCount { get { return m_XenonDispatchJobCount; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(XenonDispatchJobCount), this, m_XenonDispatchJobCount, value)) m_XenonDispatchJobCount = value; } } // 0x50 (80)
		
		protected int m_DispatchPrepareJobCount = new int();
		[ContainerField(Name: "DispatchPrepareJobCount", Offset: 84, NameHash: 351213840, Flags: 49405), LayoutImmutable, Blittable]
		public int DispatchPrepareJobCount { get { return m_DispatchPrepareJobCount; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DispatchPrepareJobCount), this, m_DispatchPrepareJobCount, value)) m_DispatchPrepareJobCount = value; } } // 0x54 (84)
		
		protected uint m_Ps3MinMipmap = new uint();
		[ContainerField(Name: "Ps3MinMipmap", Offset: 88, NameHash: 1329842871, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3MinMipmap { get { return m_Ps3MinMipmap; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3MinMipmap), this, m_Ps3MinMipmap, value)) m_Ps3MinMipmap = value; } } // 0x58 (88)
		
		protected uint m_Ps3ZCullInFrontLimit = new uint();
		[ContainerField(Name: "Ps3ZCullInFrontLimit", Offset: 92, NameHash: 1161949834, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3ZCullInFrontLimit { get { return m_Ps3ZCullInFrontLimit; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3ZCullInFrontLimit), this, m_Ps3ZCullInFrontLimit, value)) m_Ps3ZCullInFrontLimit = value; } } // 0x5C (92)
		
		protected uint m_Ps3ZCullBehindLimit = new uint();
		[ContainerField(Name: "Ps3ZCullBehindLimit", Offset: 96, NameHash: 1558768672, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3ZCullBehindLimit { get { return m_Ps3ZCullBehindLimit; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3ZCullBehindLimit), this, m_Ps3ZCullBehindLimit, value)) m_Ps3ZCullBehindLimit = value; } } // 0x60 (96)
		
		protected int m_Ps3DispatchOnlyJob = new int();
		[ContainerField(Name: "Ps3DispatchOnlyJob", Offset: 100, NameHash: 2506625750, Flags: 49405), LayoutImmutable, Blittable]
		public int Ps3DispatchOnlyJob { get { return m_Ps3DispatchOnlyJob; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DispatchOnlyJob), this, m_Ps3DispatchOnlyJob, value)) m_Ps3DispatchOnlyJob = value; } } // 0x64 (100)
		
		protected uint m_Ps3DispatchJobSpuCount = new uint();
		[ContainerField(Name: "Ps3DispatchJobSpuCount", Offset: 104, NameHash: 3777464055, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3DispatchJobSpuCount { get { return m_Ps3DispatchJobSpuCount; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DispatchJobSpuCount), this, m_Ps3DispatchJobSpuCount, value)) m_Ps3DispatchJobSpuCount = value; } } // 0x68 (104)
		
		protected uint m_DxMaxInstructionCount = new uint();
		[ContainerField(Name: "DxMaxInstructionCount", Offset: 108, NameHash: 896565718, Flags: 49421), LayoutImmutable, Blittable]
		public uint DxMaxInstructionCount { get { return m_DxMaxInstructionCount; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxMaxInstructionCount), this, m_DxMaxInstructionCount, value)) m_DxMaxInstructionCount = value; } } // 0x6C (108)
		
		protected uint m_OverdrawMaxLayerCount = new uint();
		[ContainerField(Name: "OverdrawMaxLayerCount", Offset: 112, NameHash: 2040865183, Flags: 49421), LayoutImmutable, Blittable]
		public uint OverdrawMaxLayerCount { get { return m_OverdrawMaxLayerCount; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(OverdrawMaxLayerCount), this, m_OverdrawMaxLayerCount, value)) m_OverdrawMaxLayerCount = value; } } // 0x70 (112)
		
		protected uint m_Ps3GeometryJobCount = new uint();
		[ContainerField(Name: "Ps3GeometryJobCount", Offset: 116, NameHash: 1339109483, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3GeometryJobCount { get { return m_Ps3GeometryJobCount; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3GeometryJobCount), this, m_Ps3GeometryJobCount, value)) m_Ps3GeometryJobCount = value; } } // 0x74 (116)
		
		protected uint m_DxMaxInstanceCount = new uint();
		[ContainerField(Name: "DxMaxInstanceCount", Offset: 120, NameHash: 3951925415, Flags: 49421), LayoutImmutable, Blittable]
		public uint DxMaxInstanceCount { get { return m_DxMaxInstanceCount; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxMaxInstanceCount), this, m_DxMaxInstanceCount, value)) m_DxMaxInstanceCount = value; } } // 0x78 (120)
		
		protected float m_Ps3DispatchYieldGranularity = new float();
		[ContainerField(Name: "Ps3DispatchYieldGranularity", Offset: 124, NameHash: 1313266572, Flags: 49469), LayoutImmutable, Blittable]
		public float Ps3DispatchYieldGranularity { get { return m_Ps3DispatchYieldGranularity; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DispatchYieldGranularity), this, m_Ps3DispatchYieldGranularity, value)) m_Ps3DispatchYieldGranularity = value; } } // 0x7C (124)
		
		protected uint m_DxPsExternalConstantBufferSize = new uint();
		[ContainerField(Name: "DxPsExternalConstantBufferSize", Offset: 128, NameHash: 2367594364, Flags: 49421), LayoutImmutable, Blittable]
		public uint DxPsExternalConstantBufferSize { get { return m_DxPsExternalConstantBufferSize; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxPsExternalConstantBufferSize), this, m_DxPsExternalConstantBufferSize, value)) m_DxPsExternalConstantBufferSize = value; } } // 0x80 (128)
		
		protected uint m_XenonDispatchBlocksPerJob = new uint();
		[ContainerField(Name: "XenonDispatchBlocksPerJob", Offset: 132, NameHash: 2818002173, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonDispatchBlocksPerJob { get { return m_XenonDispatchBlocksPerJob; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(XenonDispatchBlocksPerJob), this, m_XenonDispatchBlocksPerJob, value)) m_XenonDispatchBlocksPerJob = value; } } // 0x84 (132)
		
		protected uint m_Ps3DispatchJobCount = new uint();
		[ContainerField(Name: "Ps3DispatchJobCount", Offset: 136, NameHash: 596433441, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3DispatchJobCount { get { return m_Ps3DispatchJobCount; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DispatchJobCount), this, m_Ps3DispatchJobCount, value)) m_Ps3DispatchJobCount = value; } } // 0x88 (136)
		
		protected int m_DxDispatchJobCount = new int();
		[ContainerField(Name: "DxDispatchJobCount", Offset: 140, NameHash: 1428253645, Flags: 49405), LayoutImmutable, Blittable]
		public int DxDispatchJobCount { get { return m_DxDispatchJobCount; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxDispatchJobCount), this, m_DxDispatchJobCount, value)) m_DxDispatchJobCount = value; } } // 0x8C (140)
		
		protected uint m_DrawCallMultiplier = new uint();
		[ContainerField(Name: "DrawCallMultiplier", Offset: 144, NameHash: 1068468236, Flags: 49421), LayoutImmutable, Blittable]
		public uint DrawCallMultiplier { get { return m_DrawCallMultiplier; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawCallMultiplier), this, m_DrawCallMultiplier, value)) m_DrawCallMultiplier = value; } } // 0x90 (144)
		
		protected uint m_Ps3MaxMipmap = new uint();
		[ContainerField(Name: "Ps3MaxMipmap", Offset: 148, NameHash: 1346293929, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3MaxMipmap { get { return m_Ps3MaxMipmap; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3MaxMipmap), this, m_Ps3MaxMipmap, value)) m_Ps3MaxMipmap = value; } } // 0x94 (148)
		
		protected float m_MipmapBias = new float();
		[ContainerField(Name: "MipmapBias", Offset: 152, NameHash: 196267572, Flags: 49469), LayoutImmutable, Blittable]
		public float MipmapBias { get { return m_MipmapBias; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(MipmapBias), this, m_MipmapBias, value)) m_MipmapBias = value; } } // 0x98 (152)
		
		protected uint m_MaxAnisotropy = new uint();
		[ContainerField(Name: "MaxAnisotropy", Offset: 156, NameHash: 4067026955, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxAnisotropy { get { return m_MaxAnisotropy; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(MaxAnisotropy), this, m_MaxAnisotropy, value)) m_MaxAnisotropy = value; } } // 0x9C (156)
		
		protected uint m_ZOnlyMaxAnisotropy = new uint();
		[ContainerField(Name: "ZOnlyMaxAnisotropy", Offset: 160, NameHash: 3045055205, Flags: 49421), LayoutImmutable, Blittable]
		public uint ZOnlyMaxAnisotropy { get { return m_ZOnlyMaxAnisotropy; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(ZOnlyMaxAnisotropy), this, m_ZOnlyMaxAnisotropy, value)) m_ZOnlyMaxAnisotropy = value; } } // 0xA0 (160)
		
		protected uint m_XenonTrilinearThreshold = new uint();
		[ContainerField(Name: "XenonTrilinearThreshold", Offset: 164, NameHash: 1386781874, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonTrilinearThreshold { get { return m_XenonTrilinearThreshold; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(XenonTrilinearThreshold), this, m_XenonTrilinearThreshold, value)) m_XenonTrilinearThreshold = value; } } // 0xA4 (164)
		
		protected uint m_Ps3DispatchJobPriority = new uint();
		[ContainerField(Name: "Ps3DispatchJobPriority", Offset: 168, NameHash: 4233096400, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3DispatchJobPriority { get { return m_Ps3DispatchJobPriority; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DispatchJobPriority), this, m_Ps3DispatchJobPriority, value)) m_Ps3DispatchJobPriority = value; } } // 0xA8 (168)
		
		protected uint m_XenonDispatchMinJobBlockCount = new uint();
		[ContainerField(Name: "XenonDispatchMinJobBlockCount", Offset: 172, NameHash: 1718814144, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonDispatchMinJobBlockCount { get { return m_XenonDispatchMinJobBlockCount; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(XenonDispatchMinJobBlockCount), this, m_XenonDispatchMinJobBlockCount, value)) m_XenonDispatchMinJobBlockCount = value; } } // 0xAC (172)
		
		protected uint m_Ps3GeometryJobSpuCount = new uint();
		[ContainerField(Name: "Ps3GeometryJobSpuCount", Offset: 176, NameHash: 1554833789, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3GeometryJobSpuCount { get { return m_Ps3GeometryJobSpuCount; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3GeometryJobSpuCount), this, m_Ps3GeometryJobSpuCount, value)) m_Ps3GeometryJobSpuCount = value; } } // 0xB0 (176)
		
		protected uint m_Ps3DispatchBlocksPerJob = new uint();
		[ContainerField(Name: "Ps3DispatchBlocksPerJob", Offset: 180, NameHash: 4009989599, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3DispatchBlocksPerJob { get { return m_Ps3DispatchBlocksPerJob; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DispatchBlocksPerJob), this, m_Ps3DispatchBlocksPerJob, value)) m_Ps3DispatchBlocksPerJob = value; } } // 0xB4 (180)
		
		protected uint m_Ps3GeometryJobPriority = new uint();
		[ContainerField(Name: "Ps3GeometryJobPriority", Offset: 184, NameHash: 2180130138, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3GeometryJobPriority { get { return m_Ps3GeometryJobPriority; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3GeometryJobPriority), this, m_Ps3GeometryJobPriority, value)) m_Ps3GeometryJobPriority = value; } } // 0xB8 (184)
		
		protected bool m_SinglePrimitiveEnable = new bool();
		[ContainerField(Name: "SinglePrimitiveEnable", Offset: 188, NameHash: 3384211263, Flags: 49325), LayoutImmutable, Blittable]
		public bool SinglePrimitiveEnable { get { return m_SinglePrimitiveEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(SinglePrimitiveEnable), this, m_SinglePrimitiveEnable, value)) m_SinglePrimitiveEnable = value; } } // 0xBC (188)
		
		protected bool m_SortBlocksEnable = new bool();
		[ContainerField(Name: "SortBlocksEnable", Offset: 189, NameHash: 1220513028, Flags: 49325), LayoutImmutable, Blittable]
		public bool SortBlocksEnable { get { return m_SortBlocksEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(SortBlocksEnable), this, m_SortBlocksEnable, value)) m_SortBlocksEnable = value; } } // 0xBD (189)
		
		protected bool m_DrawCallEnable = new bool();
		[ContainerField(Name: "DrawCallEnable", Offset: 190, NameHash: 1808690598, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawCallEnable { get { return m_DrawCallEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawCallEnable), this, m_DrawCallEnable, value)) m_DrawCallEnable = value; } } // 0xBE (190)
		
		protected bool m_GcmReplayMarkersEnable = new bool();
		[ContainerField(Name: "GcmReplayMarkersEnable", Offset: 191, NameHash: 104325775, Flags: 49325), LayoutImmutable, Blittable]
		public bool GcmReplayMarkersEnable { get { return m_GcmReplayMarkersEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(GcmReplayMarkersEnable), this, m_GcmReplayMarkersEnable, value)) m_GcmReplayMarkersEnable = value; } } // 0xBF (191)
		
		protected bool m_ClipPlanesEnable = new bool();
		[ContainerField(Name: "ClipPlanesEnable", Offset: 192, NameHash: 2835056503, Flags: 49325), LayoutImmutable, Blittable]
		public bool ClipPlanesEnable { get { return m_ClipPlanesEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(ClipPlanesEnable), this, m_ClipPlanesEnable, value)) m_ClipPlanesEnable = value; } } // 0xC0 (192)
		
		protected bool m_DepthTestEnable = new bool();
		[ContainerField(Name: "DepthTestEnable", Offset: 193, NameHash: 856474303, Flags: 49325), LayoutImmutable, Blittable]
		public bool DepthTestEnable { get { return m_DepthTestEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DepthTestEnable), this, m_DepthTestEnable, value)) m_DepthTestEnable = value; } } // 0xC1 (193)
		
		protected bool m_StencilEnable = new bool();
		[ContainerField(Name: "StencilEnable", Offset: 194, NameHash: 3861842670, Flags: 49325), LayoutImmutable, Blittable]
		public bool StencilEnable { get { return m_StencilEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(StencilEnable), this, m_StencilEnable, value)) m_StencilEnable = value; } } // 0xC2 (194)
		
		protected bool m_ShaderPixScopeEnable = new bool();
		[ContainerField(Name: "ShaderPixScopeEnable", Offset: 195, NameHash: 1177023110, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShaderPixScopeEnable { get { return m_ShaderPixScopeEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(ShaderPixScopeEnable), this, m_ShaderPixScopeEnable, value)) m_ShaderPixScopeEnable = value; } } // 0xC3 (195)
		
		protected bool m_SingleFrameBlockLogEnable = new bool();
		[ContainerField(Name: "SingleFrameBlockLogEnable", Offset: 196, NameHash: 1375442894, Flags: 49325), LayoutImmutable, Blittable]
		public bool SingleFrameBlockLogEnable { get { return m_SingleFrameBlockLogEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(SingleFrameBlockLogEnable), this, m_SingleFrameBlockLogEnable, value)) m_SingleFrameBlockLogEnable = value; } } // 0xC4 (196)
		
		protected bool m_AlphaBlendEnable = new bool();
		[ContainerField(Name: "AlphaBlendEnable", Offset: 197, NameHash: 1065772849, Flags: 49325), LayoutImmutable, Blittable]
		public bool AlphaBlendEnable { get { return m_AlphaBlendEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(AlphaBlendEnable), this, m_AlphaBlendEnable, value)) m_AlphaBlendEnable = value; } } // 0xC5 (197)
		
		protected bool m_PixBlockEventsEnable = new bool();
		[ContainerField(Name: "PixBlockEventsEnable", Offset: 198, NameHash: 4262956787, Flags: 49325), LayoutImmutable, Blittable]
		public bool PixBlockEventsEnable { get { return m_PixBlockEventsEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(PixBlockEventsEnable), this, m_PixBlockEventsEnable, value)) m_PixBlockEventsEnable = value; } } // 0xC6 (198)
		
		protected bool m_SimpleTexturesEnable = new bool();
		[ContainerField(Name: "SimpleTexturesEnable", Offset: 199, NameHash: 3995657318, Flags: 49325), LayoutImmutable, Blittable]
		public bool SimpleTexturesEnable { get { return m_SimpleTexturesEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(SimpleTexturesEnable), this, m_SimpleTexturesEnable, value)) m_SimpleTexturesEnable = value; } } // 0xC7 (199)
		
		protected bool m_SimpleVertexShaderEnable = new bool();
		[ContainerField(Name: "SimpleVertexShaderEnable", Offset: 200, NameHash: 2993514187, Flags: 49325), LayoutImmutable, Blittable]
		public bool SimpleVertexShaderEnable { get { return m_SimpleVertexShaderEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(SimpleVertexShaderEnable), this, m_SimpleVertexShaderEnable, value)) m_SimpleVertexShaderEnable = value; } } // 0xC8 (200)
		
		protected bool m_PseudoInstancingEnable = new bool();
		[ContainerField(Name: "PseudoInstancingEnable", Offset: 201, NameHash: 355059856, Flags: 49325), LayoutImmutable, Blittable]
		public bool PseudoInstancingEnable { get { return m_PseudoInstancingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(PseudoInstancingEnable), this, m_PseudoInstancingEnable, value)) m_PseudoInstancingEnable = value; } } // 0xC9 (201)
		
		protected bool m_StatesEnable = new bool();
		[ContainerField(Name: "StatesEnable", Offset: 202, NameHash: 449924128, Flags: 49325), LayoutImmutable, Blittable]
		public bool StatesEnable { get { return m_StatesEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(StatesEnable), this, m_StatesEnable, value)) m_StatesEnable = value; } } // 0xCA (202)
		
		protected bool m_PixelConstantsEnable = new bool();
		[ContainerField(Name: "PixelConstantsEnable", Offset: 203, NameHash: 3949301121, Flags: 49325), LayoutImmutable, Blittable]
		public bool PixelConstantsEnable { get { return m_PixelConstantsEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(PixelConstantsEnable), this, m_PixelConstantsEnable, value)) m_PixelConstantsEnable = value; } } // 0xCB (203)
		
		protected bool m_VertexConstantsEnable = new bool();
		[ContainerField(Name: "VertexConstantsEnable", Offset: 204, NameHash: 1590655137, Flags: 49325), LayoutImmutable, Blittable]
		public bool VertexConstantsEnable { get { return m_VertexConstantsEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(VertexConstantsEnable), this, m_VertexConstantsEnable, value)) m_VertexConstantsEnable = value; } } // 0xCC (204)
		
		protected bool m_PixelConstantRedundancyCheckingEnable = new bool();
		[ContainerField(Name: "PixelConstantRedundancyCheckingEnable", Offset: 205, NameHash: 3456434157, Flags: 49325), LayoutImmutable, Blittable]
		public bool PixelConstantRedundancyCheckingEnable { get { return m_PixelConstantRedundancyCheckingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(PixelConstantRedundancyCheckingEnable), this, m_PixelConstantRedundancyCheckingEnable, value)) m_PixelConstantRedundancyCheckingEnable = value; } } // 0xCD (205)
		
		protected bool m_VertexConstantRedundancyCheckingEnable = new bool();
		[ContainerField(Name: "VertexConstantRedundancyCheckingEnable", Offset: 206, NameHash: 90990669, Flags: 49325), LayoutImmutable, Blittable]
		public bool VertexConstantRedundancyCheckingEnable { get { return m_VertexConstantRedundancyCheckingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(VertexConstantRedundancyCheckingEnable), this, m_VertexConstantRedundancyCheckingEnable, value)) m_VertexConstantRedundancyCheckingEnable = value; } } // 0xCE (206)
		
		protected bool m_SimpleTextureFilteringEnable = new bool();
		[ContainerField(Name: "SimpleTextureFilteringEnable", Offset: 207, NameHash: 2920178357, Flags: 49325), LayoutImmutable, Blittable]
		public bool SimpleTextureFilteringEnable { get { return m_SimpleTextureFilteringEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(SimpleTextureFilteringEnable), this, m_SimpleTextureFilteringEnable, value)) m_SimpleTextureFilteringEnable = value; } } // 0xCF (207)
		
		protected bool m_DepthWriteEnable = new bool();
		[ContainerField(Name: "DepthWriteEnable", Offset: 208, NameHash: 2382302452, Flags: 49325), LayoutImmutable, Blittable]
		public bool DepthWriteEnable { get { return m_DepthWriteEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DepthWriteEnable), this, m_DepthWriteEnable, value)) m_DepthWriteEnable = value; } } // 0xD0 (208)
		
		protected bool m_DispatchDirectEnable = new bool();
		[ContainerField(Name: "DispatchDirectEnable", Offset: 209, NameHash: 505268473, Flags: 49325), LayoutImmutable, Blittable]
		public bool DispatchDirectEnable { get { return m_DispatchDirectEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DispatchDirectEnable), this, m_DispatchDirectEnable, value)) m_DispatchDirectEnable = value; } } // 0xD1 (209)
		
		protected bool m_DrawTileClassifiedBlocks = new bool();
		[ContainerField(Name: "DrawTileClassifiedBlocks", Offset: 210, NameHash: 1450821346, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawTileClassifiedBlocks { get { return m_DrawTileClassifiedBlocks; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawTileClassifiedBlocks), this, m_DrawTileClassifiedBlocks, value)) m_DrawTileClassifiedBlocks = value; } } // 0xD2 (210)
		
		protected bool m_DepthEnable = new bool();
		[ContainerField(Name: "DepthEnable", Offset: 211, NameHash: 2635953449, Flags: 49325), LayoutImmutable, Blittable]
		public bool DepthEnable { get { return m_DepthEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DepthEnable), this, m_DepthEnable, value)) m_DepthEnable = value; } } // 0xD3 (211)
		
		protected bool m_DrawStreamedTextureBlocks = new bool();
		[ContainerField(Name: "DrawStreamedTextureBlocks", Offset: 212, NameHash: 4198440541, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawStreamedTextureBlocks { get { return m_DrawStreamedTextureBlocks; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawStreamedTextureBlocks), this, m_DrawStreamedTextureBlocks, value)) m_DrawStreamedTextureBlocks = value; } } // 0xD4 (212)
		
		protected bool m_ForcePointFiltering = new bool();
		[ContainerField(Name: "ForcePointFiltering", Offset: 213, NameHash: 4030356532, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForcePointFiltering { get { return m_ForcePointFiltering; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(ForcePointFiltering), this, m_ForcePointFiltering, value)) m_ForcePointFiltering = value; } } // 0xD5 (213)
		
		protected bool m_LogEnable = new bool();
		[ContainerField(Name: "LogEnable", Offset: 214, NameHash: 1242750240, Flags: 49325), LayoutImmutable, Blittable]
		public bool LogEnable { get { return m_LogEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(LogEnable), this, m_LogEnable, value)) m_LogEnable = value; } } // 0xD6 (214)
		
		protected bool m_ZeroViewportEnable = new bool();
		[ContainerField(Name: "ZeroViewportEnable", Offset: 215, NameHash: 967736082, Flags: 49325), LayoutImmutable, Blittable]
		public bool ZeroViewportEnable { get { return m_ZeroViewportEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(ZeroViewportEnable), this, m_ZeroViewportEnable, value)) m_ZeroViewportEnable = value; } } // 0xD7 (215)
		
		protected bool m_DrawTransparentDecal = new bool();
		[ContainerField(Name: "DrawTransparentDecal", Offset: 216, NameHash: 954292812, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawTransparentDecal { get { return m_DrawTransparentDecal; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawTransparentDecal), this, m_DrawTransparentDecal, value)) m_DrawTransparentDecal = value; } } // 0xD8 (216)
		
		protected bool m_SingleFrameLogEnable = new bool();
		[ContainerField(Name: "SingleFrameLogEnable", Offset: 217, NameHash: 286069959, Flags: 49325), LayoutImmutable, Blittable]
		public bool SingleFrameLogEnable { get { return m_SingleFrameLogEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(SingleFrameLogEnable), this, m_SingleFrameLogEnable, value)) m_SingleFrameLogEnable = value; } } // 0xD9 (217)
		
		protected bool m_SingleFrameLogOverwrite = new bool();
		[ContainerField(Name: "SingleFrameLogOverwrite", Offset: 218, NameHash: 23154741, Flags: 49325), LayoutImmutable, Blittable]
		public bool SingleFrameLogOverwrite { get { return m_SingleFrameLogOverwrite; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(SingleFrameLogOverwrite), this, m_SingleFrameLogOverwrite, value)) m_SingleFrameLogOverwrite = value; } } // 0xDA (218)
		
		protected bool m_ForceDoubleSided = new bool();
		[ContainerField(Name: "ForceDoubleSided", Offset: 219, NameHash: 1019746770, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceDoubleSided { get { return m_ForceDoubleSided; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(ForceDoubleSided), this, m_ForceDoubleSided, value)) m_ForceDoubleSided = value; } } // 0xDB (219)
		
		protected bool m_OnDemandMonitoringEnable = new bool();
		[ContainerField(Name: "OnDemandMonitoringEnable", Offset: 220, NameHash: 389992558, Flags: 49325), LayoutImmutable, Blittable]
		public bool OnDemandMonitoringEnable { get { return m_OnDemandMonitoringEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(OnDemandMonitoringEnable), this, m_OnDemandMonitoringEnable, value)) m_OnDemandMonitoringEnable = value; } } // 0xDC (220)
		
		protected bool m_Ps3PixelShaderRedundancyCheckingEnable = new bool();
		[ContainerField(Name: "Ps3PixelShaderRedundancyCheckingEnable", Offset: 221, NameHash: 817341418, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3PixelShaderRedundancyCheckingEnable { get { return m_Ps3PixelShaderRedundancyCheckingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3PixelShaderRedundancyCheckingEnable), this, m_Ps3PixelShaderRedundancyCheckingEnable, value)) m_Ps3PixelShaderRedundancyCheckingEnable = value; } } // 0xDD (221)
		
		protected bool m_Ps3PixelShaderHashStoreEnable = new bool();
		[ContainerField(Name: "Ps3PixelShaderHashStoreEnable", Offset: 222, NameHash: 807537816, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3PixelShaderHashStoreEnable { get { return m_Ps3PixelShaderHashStoreEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3PixelShaderHashStoreEnable), this, m_Ps3PixelShaderHashStoreEnable, value)) m_Ps3PixelShaderHashStoreEnable = value; } } // 0xDE (222)
		
		protected bool m_Ps3DispatchPrepareSpuJobEnable = new bool();
		[ContainerField(Name: "Ps3DispatchPrepareSpuJobEnable", Offset: 223, NameHash: 1952514164, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3DispatchPrepareSpuJobEnable { get { return m_Ps3DispatchPrepareSpuJobEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DispatchPrepareSpuJobEnable), this, m_Ps3DispatchPrepareSpuJobEnable, value)) m_Ps3DispatchPrepareSpuJobEnable = value; } } // 0xDF (223)
		
		protected bool m_Ps3DispatchSetupSpuJobEnable = new bool();
		[ContainerField(Name: "Ps3DispatchSetupSpuJobEnable", Offset: 224, NameHash: 4264301426, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3DispatchSetupSpuJobEnable { get { return m_Ps3DispatchSetupSpuJobEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DispatchSetupSpuJobEnable), this, m_Ps3DispatchSetupSpuJobEnable, value)) m_Ps3DispatchSetupSpuJobEnable = value; } } // 0xE0 (224)
		
		protected bool m_Ps3GeometryJobEnable = new bool();
		[ContainerField(Name: "Ps3GeometryJobEnable", Offset: 225, NameHash: 1161033513, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3GeometryJobEnable { get { return m_Ps3GeometryJobEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3GeometryJobEnable), this, m_Ps3GeometryJobEnable, value)) m_Ps3GeometryJobEnable = value; } } // 0xE1 (225)
		
		protected bool m_DatabaseLoadingEnable = new bool();
		[ContainerField(Name: "DatabaseLoadingEnable", Offset: 226, NameHash: 2824850887, Flags: 49325), LayoutImmutable, Blittable]
		public bool DatabaseLoadingEnable { get { return m_DatabaseLoadingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DatabaseLoadingEnable), this, m_DatabaseLoadingEnable, value)) m_DatabaseLoadingEnable = value; } } // 0xE2 (226)
		
		protected bool m_SimplePixelShaderEnable = new bool();
		[ContainerField(Name: "SimplePixelShaderEnable", Offset: 227, NameHash: 3273843563, Flags: 49325), LayoutImmutable, Blittable]
		public bool SimplePixelShaderEnable { get { return m_SimplePixelShaderEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(SimplePixelShaderEnable), this, m_SimplePixelShaderEnable, value)) m_SimplePixelShaderEnable = value; } } // 0xE3 (227)
		
		protected bool m_Ps3GeometryJobWithoutDispatchJobEnable = new bool();
		[ContainerField(Name: "Ps3GeometryJobWithoutDispatchJobEnable", Offset: 228, NameHash: 2116626642, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3GeometryJobWithoutDispatchJobEnable { get { return m_Ps3GeometryJobWithoutDispatchJobEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3GeometryJobWithoutDispatchJobEnable), this, m_Ps3GeometryJobWithoutDispatchJobEnable, value)) m_Ps3GeometryJobWithoutDispatchJobEnable = value; } } // 0xE4 (228)
		
		protected bool m_Ps3GeometryDebugRenderEnable = new bool();
		[ContainerField(Name: "Ps3GeometryDebugRenderEnable", Offset: 229, NameHash: 4017933973, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3GeometryDebugRenderEnable { get { return m_Ps3GeometryDebugRenderEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3GeometryDebugRenderEnable), this, m_Ps3GeometryDebugRenderEnable, value)) m_Ps3GeometryDebugRenderEnable = value; } } // 0xE5 (229)
		
		protected bool m_BoneConstantOptimizationEnable = new bool();
		[ContainerField(Name: "BoneConstantOptimizationEnable", Offset: 230, NameHash: 1779871005, Flags: 49325), LayoutImmutable, Blittable]
		public bool BoneConstantOptimizationEnable { get { return m_BoneConstantOptimizationEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(BoneConstantOptimizationEnable), this, m_BoneConstantOptimizationEnable, value)) m_BoneConstantOptimizationEnable = value; } } // 0xE6 (230)
		
		protected bool m_Ps3DrawEdgeGeometryEnable = new bool();
		[ContainerField(Name: "Ps3DrawEdgeGeometryEnable", Offset: 231, NameHash: 1049907917, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3DrawEdgeGeometryEnable { get { return m_Ps3DrawEdgeGeometryEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DrawEdgeGeometryEnable), this, m_Ps3DrawEdgeGeometryEnable, value)) m_Ps3DrawEdgeGeometryEnable = value; } } // 0xE7 (231)
		
		protected bool m_Ps3DrawNonEdgeGeometryEnable = new bool();
		[ContainerField(Name: "Ps3DrawNonEdgeGeometryEnable", Offset: 232, NameHash: 4096042498, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3DrawNonEdgeGeometryEnable { get { return m_Ps3DrawNonEdgeGeometryEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DrawNonEdgeGeometryEnable), this, m_Ps3DrawNonEdgeGeometryEnable, value)) m_Ps3DrawNonEdgeGeometryEnable = value; } } // 0xE8 (232)
		
		protected bool m_Ps3TriangleCullEnable = new bool();
		[ContainerField(Name: "Ps3TriangleCullEnable", Offset: 233, NameHash: 907581676, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3TriangleCullEnable { get { return m_Ps3TriangleCullEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3TriangleCullEnable), this, m_Ps3TriangleCullEnable, value)) m_Ps3TriangleCullEnable = value; } } // 0xE9 (233)
		
		protected bool m_Ps3TriangleFrustumCullEnable = new bool();
		[ContainerField(Name: "Ps3TriangleFrustumCullEnable", Offset: 234, NameHash: 2693409042, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3TriangleFrustumCullEnable { get { return m_Ps3TriangleFrustumCullEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3TriangleFrustumCullEnable), this, m_Ps3TriangleFrustumCullEnable, value)) m_Ps3TriangleFrustumCullEnable = value; } } // 0xEA (234)
		
		protected bool m_Ps3TriangleBackfaceCullEnable = new bool();
		[ContainerField(Name: "Ps3TriangleBackfaceCullEnable", Offset: 235, NameHash: 2172207942, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3TriangleBackfaceCullEnable { get { return m_Ps3TriangleBackfaceCullEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3TriangleBackfaceCullEnable), this, m_Ps3TriangleBackfaceCullEnable, value)) m_Ps3TriangleBackfaceCullEnable = value; } } // 0xEB (235)
		
		protected bool m_Ps3TriangleCullZPassEnable = new bool();
		[ContainerField(Name: "Ps3TriangleCullZPassEnable", Offset: 236, NameHash: 1829559303, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3TriangleCullZPassEnable { get { return m_Ps3TriangleCullZPassEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3TriangleCullZPassEnable), this, m_Ps3TriangleCullZPassEnable, value)) m_Ps3TriangleCullZPassEnable = value; } } // 0xEC (236)
		
		protected bool m_Ps3TriangleCullDoubleSidedEnable = new bool();
		[ContainerField(Name: "Ps3TriangleCullDoubleSidedEnable", Offset: 237, NameHash: 750843238, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3TriangleCullDoubleSidedEnable { get { return m_Ps3TriangleCullDoubleSidedEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3TriangleCullDoubleSidedEnable), this, m_Ps3TriangleCullDoubleSidedEnable, value)) m_Ps3TriangleCullDoubleSidedEnable = value; } } // 0xED (237)
		
		protected bool m_Ps3TriangleCull1BoneSkinningEnable = new bool();
		[ContainerField(Name: "Ps3TriangleCull1BoneSkinningEnable", Offset: 238, NameHash: 2282356842, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3TriangleCull1BoneSkinningEnable { get { return m_Ps3TriangleCull1BoneSkinningEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3TriangleCull1BoneSkinningEnable), this, m_Ps3TriangleCull1BoneSkinningEnable, value)) m_Ps3TriangleCull1BoneSkinningEnable = value; } } // 0xEE (238)
		
		protected bool m_Ps3TriangleCull4BoneSkinningEnable = new bool();
		[ContainerField(Name: "Ps3TriangleCull4BoneSkinningEnable", Offset: 239, NameHash: 4038567215, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3TriangleCull4BoneSkinningEnable { get { return m_Ps3TriangleCull4BoneSkinningEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3TriangleCull4BoneSkinningEnable), this, m_Ps3TriangleCull4BoneSkinningEnable, value)) m_Ps3TriangleCull4BoneSkinningEnable = value; } } // 0xEF (239)
		
		protected bool m_Ps3TrianglePartCullEnable = new bool();
		[ContainerField(Name: "Ps3TrianglePartCullEnable", Offset: 240, NameHash: 2508417883, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3TrianglePartCullEnable { get { return m_Ps3TrianglePartCullEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3TrianglePartCullEnable), this, m_Ps3TrianglePartCullEnable, value)) m_Ps3TrianglePartCullEnable = value; } } // 0xF0 (240)
		
		protected bool m_Ps3DrawBlockCullEnable = new bool();
		[ContainerField(Name: "Ps3DrawBlockCullEnable", Offset: 241, NameHash: 3383477611, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3DrawBlockCullEnable { get { return m_Ps3DrawBlockCullEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DrawBlockCullEnable), this, m_Ps3DrawBlockCullEnable, value)) m_Ps3DrawBlockCullEnable = value; } } // 0xF1 (241)
		
		protected bool m_Ps3PartitionFrustumCullEnable = new bool();
		[ContainerField(Name: "Ps3PartitionFrustumCullEnable", Offset: 242, NameHash: 1828084478, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3PartitionFrustumCullEnable { get { return m_Ps3PartitionFrustumCullEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3PartitionFrustumCullEnable), this, m_Ps3PartitionFrustumCullEnable, value)) m_Ps3PartitionFrustumCullEnable = value; } } // 0xF2 (242)
		
		protected bool m_Ps3PartitionClipPlaneCullEnable = new bool();
		[ContainerField(Name: "Ps3PartitionClipPlaneCullEnable", Offset: 243, NameHash: 953623744, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3PartitionClipPlaneCullEnable { get { return m_Ps3PartitionClipPlaneCullEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3PartitionClipPlaneCullEnable), this, m_Ps3PartitionClipPlaneCullEnable, value)) m_Ps3PartitionClipPlaneCullEnable = value; } } // 0xF3 (243)
		
		protected bool m_Ps3PartitionVolumeCullEnable = new bool();
		[ContainerField(Name: "Ps3PartitionVolumeCullEnable", Offset: 244, NameHash: 1172266568, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3PartitionVolumeCullEnable { get { return m_Ps3PartitionVolumeCullEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3PartitionVolumeCullEnable), this, m_Ps3PartitionVolumeCullEnable, value)) m_Ps3PartitionVolumeCullEnable = value; } } // 0xF4 (244)
		
		protected bool m_Ps3SpuInstancingEnable = new bool();
		[ContainerField(Name: "Ps3SpuInstancingEnable", Offset: 245, NameHash: 4085224878, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3SpuInstancingEnable { get { return m_Ps3SpuInstancingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3SpuInstancingEnable), this, m_Ps3SpuInstancingEnable, value)) m_Ps3SpuInstancingEnable = value; } } // 0xF5 (245)
		
		protected bool m_Ps3SpuClipPlaneRejectEnable = new bool();
		[ContainerField(Name: "Ps3SpuClipPlaneRejectEnable", Offset: 246, NameHash: 40145229, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3SpuClipPlaneRejectEnable { get { return m_Ps3SpuClipPlaneRejectEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3SpuClipPlaneRejectEnable), this, m_Ps3SpuClipPlaneRejectEnable, value)) m_Ps3SpuClipPlaneRejectEnable = value; } } // 0xF6 (246)
		
		protected bool m_Ps3SpuCullVolumesEnable = new bool();
		[ContainerField(Name: "Ps3SpuCullVolumesEnable", Offset: 247, NameHash: 2312942799, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3SpuCullVolumesEnable { get { return m_Ps3SpuCullVolumesEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3SpuCullVolumesEnable), this, m_Ps3SpuCullVolumesEnable, value)) m_Ps3SpuCullVolumesEnable = value; } } // 0xF7 (247)
		
		protected bool m_Ps3DispatchJobEnable = new bool();
		[ContainerField(Name: "Ps3DispatchJobEnable", Offset: 248, NameHash: 2569607715, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3DispatchJobEnable { get { return m_Ps3DispatchJobEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DispatchJobEnable), this, m_Ps3DispatchJobEnable, value)) m_Ps3DispatchJobEnable = value; } } // 0xF8 (248)
		
		protected bool m_OnDemandBuildingEnable = new bool();
		[ContainerField(Name: "OnDemandBuildingEnable", Offset: 249, NameHash: 3142983540, Flags: 49325), LayoutImmutable, Blittable]
		public bool OnDemandBuildingEnable { get { return m_OnDemandBuildingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(OnDemandBuildingEnable), this, m_OnDemandBuildingEnable, value)) m_OnDemandBuildingEnable = value; } } // 0xF9 (249)
		
		protected bool m_OnDemandPrimingEnable = new bool();
		[ContainerField(Name: "OnDemandPrimingEnable", Offset: 250, NameHash: 1031717924, Flags: 49325), LayoutImmutable, Blittable]
		public bool OnDemandPrimingEnable { get { return m_OnDemandPrimingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(OnDemandPrimingEnable), this, m_OnDemandPrimingEnable, value)) m_OnDemandPrimingEnable = value; } } // 0xFA (250)
		
		protected bool m_DispatchExecuteEnable = new bool();
		[ContainerField(Name: "DispatchExecuteEnable", Offset: 251, NameHash: 3821627435, Flags: 49325), LayoutImmutable, Blittable]
		public bool DispatchExecuteEnable { get { return m_DispatchExecuteEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DispatchExecuteEnable), this, m_DispatchExecuteEnable, value)) m_DispatchExecuteEnable = value; } } // 0xFB (251)
		
		protected bool m_TextureGammaCorrectionEnable = new bool();
		[ContainerField(Name: "TextureGammaCorrectionEnable", Offset: 252, NameHash: 501150250, Flags: 49325), LayoutImmutable, Blittable]
		public bool TextureGammaCorrectionEnable { get { return m_TextureGammaCorrectionEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(TextureGammaCorrectionEnable), this, m_TextureGammaCorrectionEnable, value)) m_TextureGammaCorrectionEnable = value; } } // 0xFC (252)
		
		protected bool m_TileClassificationEnable = new bool();
		[ContainerField(Name: "TileClassificationEnable", Offset: 253, NameHash: 67079238, Flags: 49325), LayoutImmutable, Blittable]
		public bool TileClassificationEnable { get { return m_TileClassificationEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(TileClassificationEnable), this, m_TileClassificationEnable, value)) m_TileClassificationEnable = value; } } // 0xFD (253)
		
		protected bool m_Ps3DispatchSpuBufferLinkingEnable = new bool();
		[ContainerField(Name: "Ps3DispatchSpuBufferLinkingEnable", Offset: 254, NameHash: 3696968498, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3DispatchSpuBufferLinkingEnable { get { return m_Ps3DispatchSpuBufferLinkingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DispatchSpuBufferLinkingEnable), this, m_Ps3DispatchSpuBufferLinkingEnable, value)) m_Ps3DispatchSpuBufferLinkingEnable = value; } } // 0xFE (254)
		
		protected bool m_Ps3DispatchFrameBlockEnable = new bool();
		[ContainerField(Name: "Ps3DispatchFrameBlockEnable", Offset: 255, NameHash: 336125968, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3DispatchFrameBlockEnable { get { return m_Ps3DispatchFrameBlockEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3DispatchFrameBlockEnable), this, m_Ps3DispatchFrameBlockEnable, value)) m_Ps3DispatchFrameBlockEnable = value; } } // 0xFF (255)
		
		protected bool m_Ps3SCullEnable = new bool();
		[ContainerField(Name: "Ps3SCullEnable", Offset: 256, NameHash: 3556523217, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3SCullEnable { get { return m_Ps3SCullEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3SCullEnable), this, m_Ps3SCullEnable, value)) m_Ps3SCullEnable = value; } } // 0x100 (256)
		
		protected bool m_Ps3ZCullEnable = new bool();
		[ContainerField(Name: "Ps3ZCullEnable", Offset: 257, NameHash: 3239977624, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3ZCullEnable { get { return m_Ps3ZCullEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3ZCullEnable), this, m_Ps3ZCullEnable, value)) m_Ps3ZCullEnable = value; } } // 0x101 (257)
		
		protected bool m_DrawInstancedBlocks = new bool();
		[ContainerField(Name: "DrawInstancedBlocks", Offset: 258, NameHash: 738344370, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawInstancedBlocks { get { return m_DrawInstancedBlocks; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawInstancedBlocks), this, m_DrawInstancedBlocks, value)) m_DrawInstancedBlocks = value; } } // 0x102 (258)
		
		protected bool m_DispatchPrepareBlockEnable = new bool();
		[ContainerField(Name: "DispatchPrepareBlockEnable", Offset: 259, NameHash: 736860092, Flags: 49325), LayoutImmutable, Blittable]
		public bool DispatchPrepareBlockEnable { get { return m_DispatchPrepareBlockEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DispatchPrepareBlockEnable), this, m_DispatchPrepareBlockEnable, value)) m_DispatchPrepareBlockEnable = value; } } // 0x103 (259)
		
		protected bool m_DrawNonInstancedBlocks = new bool();
		[ContainerField(Name: "DrawNonInstancedBlocks", Offset: 260, NameHash: 3032987357, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawNonInstancedBlocks { get { return m_DrawNonInstancedBlocks; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawNonInstancedBlocks), this, m_DrawNonInstancedBlocks, value)) m_DrawNonInstancedBlocks = value; } } // 0x104 (260)
		
		protected bool m_DrawNonStreamedTextureBlocks = new bool();
		[ContainerField(Name: "DrawNonStreamedTextureBlocks", Offset: 261, NameHash: 149509938, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawNonStreamedTextureBlocks { get { return m_DrawNonStreamedTextureBlocks; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawNonStreamedTextureBlocks), this, m_DrawNonStreamedTextureBlocks, value)) m_DrawNonStreamedTextureBlocks = value; } } // 0x105 (261)
		
		protected bool m_Ps3TxpDemotionEnable = new bool();
		[ContainerField(Name: "Ps3TxpDemotionEnable", Offset: 262, NameHash: 2998678519, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3TxpDemotionEnable { get { return m_Ps3TxpDemotionEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3TxpDemotionEnable), this, m_Ps3TxpDemotionEnable, value)) m_Ps3TxpDemotionEnable = value; } } // 0x106 (262)
		
		protected bool m_Ps3CmdBufVertexShaderInlineEnable = new bool();
		[ContainerField(Name: "Ps3CmdBufVertexShaderInlineEnable", Offset: 263, NameHash: 3297671015, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3CmdBufVertexShaderInlineEnable { get { return m_Ps3CmdBufVertexShaderInlineEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3CmdBufVertexShaderInlineEnable), this, m_Ps3CmdBufVertexShaderInlineEnable, value)) m_Ps3CmdBufVertexShaderInlineEnable = value; } } // 0x107 (263)
		
		protected bool m_Ps3CmdBufClearEnable = new bool();
		[ContainerField(Name: "Ps3CmdBufClearEnable", Offset: 264, NameHash: 1284811158, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3CmdBufClearEnable { get { return m_Ps3CmdBufClearEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3CmdBufClearEnable), this, m_Ps3CmdBufClearEnable, value)) m_Ps3CmdBufClearEnable = value; } } // 0x108 (264)
		
		protected bool m_Ps3SpuYieldingEnable = new bool();
		[ContainerField(Name: "Ps3SpuYieldingEnable", Offset: 265, NameHash: 2296106943, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3SpuYieldingEnable { get { return m_Ps3SpuYieldingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3SpuYieldingEnable), this, m_Ps3SpuYieldingEnable, value)) m_Ps3SpuYieldingEnable = value; } } // 0x109 (265)
		
		protected bool m_XenonDispatchJobEnable = new bool();
		[ContainerField(Name: "XenonDispatchJobEnable", Offset: 266, NameHash: 2578580993, Flags: 49325), LayoutImmutable, Blittable]
		public bool XenonDispatchJobEnable { get { return m_XenonDispatchJobEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(XenonDispatchJobEnable), this, m_XenonDispatchJobEnable, value)) m_XenonDispatchJobEnable = value; } } // 0x10A (266)
		
		protected bool m_DrawInlineBlocks = new bool();
		[ContainerField(Name: "DrawInlineBlocks", Offset: 267, NameHash: 1067967350, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawInlineBlocks { get { return m_DrawInlineBlocks; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawInlineBlocks), this, m_DrawInlineBlocks, value)) m_DrawInlineBlocks = value; } } // 0x10B (267)
		
		protected bool m_Ps3FlushEnable = new bool();
		[ContainerField(Name: "Ps3FlushEnable", Offset: 268, NameHash: 968981744, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3FlushEnable { get { return m_Ps3FlushEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3FlushEnable), this, m_Ps3FlushEnable, value)) m_Ps3FlushEnable = value; } } // 0x10C (268)
		
		protected bool m_Ps3FinishEnable = new bool();
		[ContainerField(Name: "Ps3FinishEnable", Offset: 269, NameHash: 2727001447, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3FinishEnable { get { return m_Ps3FinishEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(Ps3FinishEnable), this, m_Ps3FinishEnable, value)) m_Ps3FinishEnable = value; } } // 0x10D (269)
		
		protected bool m_DxMultisampleEnable = new bool();
		[ContainerField(Name: "DxMultisampleEnable", Offset: 270, NameHash: 60513815, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxMultisampleEnable { get { return m_DxMultisampleEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxMultisampleEnable), this, m_DxMultisampleEnable, value)) m_DxMultisampleEnable = value; } } // 0x10E (270)
		
		protected bool m_DxTransparencySupersamplingEnable = new bool();
		[ContainerField(Name: "DxTransparencySupersamplingEnable", Offset: 271, NameHash: 3389290418, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxTransparencySupersamplingEnable { get { return m_DxTransparencySupersamplingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxTransparencySupersamplingEnable), this, m_DxTransparencySupersamplingEnable, value)) m_DxTransparencySupersamplingEnable = value; } } // 0x10F (271)
		
		protected bool m_DxSamplerStatesEnable = new bool();
		[ContainerField(Name: "DxSamplerStatesEnable", Offset: 272, NameHash: 2484234024, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxSamplerStatesEnable { get { return m_DxSamplerStatesEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxSamplerStatesEnable), this, m_DxSamplerStatesEnable, value)) m_DxSamplerStatesEnable = value; } } // 0x110 (272)
		
		protected bool m_DxBatchedSamplerStatesEnable = new bool();
		[ContainerField(Name: "DxBatchedSamplerStatesEnable", Offset: 273, NameHash: 3806413589, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxBatchedSamplerStatesEnable { get { return m_DxBatchedSamplerStatesEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxBatchedSamplerStatesEnable), this, m_DxBatchedSamplerStatesEnable, value)) m_DxBatchedSamplerStatesEnable = value; } } // 0x111 (273)
		
		protected bool m_DxBatchedTexturesEnable = new bool();
		[ContainerField(Name: "DxBatchedTexturesEnable", Offset: 274, NameHash: 3898873385, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxBatchedTexturesEnable { get { return m_DxBatchedTexturesEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxBatchedTexturesEnable), this, m_DxBatchedTexturesEnable, value)) m_DxBatchedTexturesEnable = value; } } // 0x112 (274)
		
		protected bool m_DxStatesEnable = new bool();
		[ContainerField(Name: "DxStatesEnable", Offset: 275, NameHash: 541903900, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxStatesEnable { get { return m_DxStatesEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxStatesEnable), this, m_DxStatesEnable, value)) m_DxStatesEnable = value; } } // 0x113 (275)
		
		protected bool m_DrawOpaqueAlphaTestSimple = new bool();
		[ContainerField(Name: "DrawOpaqueAlphaTestSimple", Offset: 276, NameHash: 394966582, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawOpaqueAlphaTestSimple { get { return m_DrawOpaqueAlphaTestSimple; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawOpaqueAlphaTestSimple), this, m_DrawOpaqueAlphaTestSimple, value)) m_DrawOpaqueAlphaTestSimple = value; } } // 0x114 (276)
		
		protected bool m_FlushEnable = new bool();
		[ContainerField(Name: "FlushEnable", Offset: 277, NameHash: 3206413920, Flags: 49325), LayoutImmutable, Blittable]
		public bool FlushEnable { get { return m_FlushEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(FlushEnable), this, m_FlushEnable, value)) m_FlushEnable = value; } } // 0x115 (277)
		
		protected bool m_DrawTransparent = new bool();
		[ContainerField(Name: "DrawTransparent", Offset: 278, NameHash: 3651089763, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawTransparent { get { return m_DrawTransparent; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawTransparent), this, m_DrawTransparent, value)) m_DrawTransparent = value; } } // 0x116 (278)
		
		protected bool m_DrawAdvancedStats = new bool();
		[ContainerField(Name: "DrawAdvancedStats", Offset: 279, NameHash: 4051955738, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawAdvancedStats { get { return m_DrawAdvancedStats; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawAdvancedStats), this, m_DrawAdvancedStats, value)) m_DrawAdvancedStats = value; } } // 0x117 (279)
		
		protected bool m_DxParallelShaderLoadingEnable = new bool();
		[ContainerField(Name: "DxParallelShaderLoadingEnable", Offset: 280, NameHash: 1057678812, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxParallelShaderLoadingEnable { get { return m_DxParallelShaderLoadingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxParallelShaderLoadingEnable), this, m_DxParallelShaderLoadingEnable, value)) m_DxParallelShaderLoadingEnable = value; } } // 0x118 (280)
		
		protected bool m_DxDelayedShaderLoadingEnable = new bool();
		[ContainerField(Name: "DxDelayedShaderLoadingEnable", Offset: 281, NameHash: 167211107, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxDelayedShaderLoadingEnable { get { return m_DxDelayedShaderLoadingEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DxDelayedShaderLoadingEnable), this, m_DxDelayedShaderLoadingEnable, value)) m_DxDelayedShaderLoadingEnable = value; } } // 0x119 (281)
		
		protected bool m_DrawOpaque = new bool();
		[ContainerField(Name: "DrawOpaque", Offset: 282, NameHash: 1897318426, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawOpaque { get { return m_DrawOpaque; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawOpaque), this, m_DrawOpaque, value)) m_DrawOpaque = value; } } // 0x11A (282)
		
		protected bool m_DrawOpaqueAlphaTest = new bool();
		[ContainerField(Name: "DrawOpaqueAlphaTest", Offset: 283, NameHash: 1044040856, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawOpaqueAlphaTest { get { return m_DrawOpaqueAlphaTest; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawOpaqueAlphaTest), this, m_DrawOpaqueAlphaTest, value)) m_DrawOpaqueAlphaTest = value; } } // 0x11B (283)
		
		protected bool m_XenonHiZEnable = new bool();
		[ContainerField(Name: "XenonHiZEnable", Offset: 284, NameHash: 3737851501, Flags: 49325), LayoutImmutable, Blittable]
		public bool XenonHiZEnable { get { return m_XenonHiZEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(XenonHiZEnable), this, m_XenonHiZEnable, value)) m_XenonHiZEnable = value; } } // 0x11C (284)
		
		protected bool m_DrawZOnly = new bool();
		[ContainerField(Name: "DrawZOnly", Offset: 285, NameHash: 2420560875, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawZOnly { get { return m_DrawZOnly; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawZOnly), this, m_DrawZOnly, value)) m_DrawZOnly = value; } } // 0x11D (285)
		
		protected bool m_DrawStats = new bool();
		[ContainerField(Name: "DrawStats", Offset: 286, NameHash: 2413142628, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawStats { get { return m_DrawStats; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(DrawStats), this, m_DrawStats, value)) m_DrawStats = value; } } // 0x11E (286)
		
		protected bool m_XenonDispatchBlockOnCmdBufEnable = new bool();
		[ContainerField(Name: "XenonDispatchBlockOnCmdBufEnable", Offset: 287, NameHash: 3499933781, Flags: 49325), LayoutImmutable, Blittable]
		public bool XenonDispatchBlockOnCmdBufEnable { get { return m_XenonDispatchBlockOnCmdBufEnable; } set { if (OnPropertyChanging("ShaderSystemSettings." + nameof(XenonDispatchBlockOnCmdBufEnable), this, m_XenonDispatchBlockOnCmdBufEnable, value)) m_XenonDispatchBlockOnCmdBufEnable = value; } } // 0x11F (287)
		
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
