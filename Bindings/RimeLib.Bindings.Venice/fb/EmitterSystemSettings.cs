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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 104)]
	public class EmitterSystemSettings : 
		DataContainer
	{
		protected uint m_MeshDrawCountLimit = new uint();
		[ContainerField(Name: "MeshDrawCountLimit", Offset: 8, NameHash: 3584341216, Flags: 49421), LayoutImmutable, Blittable]
		public uint MeshDrawCountLimit { get { return m_MeshDrawCountLimit; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(MeshDrawCountLimit), this, m_MeshDrawCountLimit, value)) m_MeshDrawCountLimit = value; } } // 0x8 (8)
		
		protected float m_TimeScale = new float();
		[ContainerField(Name: "TimeScale", Offset: 12, NameHash: 169511528, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeScale { get { return m_TimeScale; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(TimeScale), this, m_TimeScale, value)) m_TimeScale = value; } } // 0xC (12)
		
		protected float m_GlobalResetStartTimeInterval = new float();
		[ContainerField(Name: "GlobalResetStartTimeInterval", Offset: 16, NameHash: 191922705, Flags: 49469), LayoutImmutable, Blittable]
		public float GlobalResetStartTimeInterval { get { return m_GlobalResetStartTimeInterval; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(GlobalResetStartTimeInterval), this, m_GlobalResetStartTimeInterval, value)) m_GlobalResetStartTimeInterval = value; } } // 0x10 (16)
		
		protected float m_QuadHalfResSlice2ThresholdLow = new float();
		[ContainerField(Name: "QuadHalfResSlice2ThresholdLow", Offset: 20, NameHash: 248249250, Flags: 49469), LayoutImmutable, Blittable]
		public float QuadHalfResSlice2ThresholdLow { get { return m_QuadHalfResSlice2ThresholdLow; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadHalfResSlice2ThresholdLow), this, m_QuadHalfResSlice2ThresholdLow, value)) m_QuadHalfResSlice2ThresholdLow = value; } } // 0x14 (20)
		
		protected float m_QuadHalfResSlice2ThresholdHigh = new float();
		[ContainerField(Name: "QuadHalfResSlice2ThresholdHigh", Offset: 24, NameHash: 3897404056, Flags: 49469), LayoutImmutable, Blittable]
		public float QuadHalfResSlice2ThresholdHigh { get { return m_QuadHalfResSlice2ThresholdHigh; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadHalfResSlice2ThresholdHigh), this, m_QuadHalfResSlice2ThresholdHigh, value)) m_QuadHalfResSlice2ThresholdHigh = value; } } // 0x18 (24)
		
		protected float m_QuadHalfResSlice1ThresholdLow = new float();
		[ContainerField(Name: "QuadHalfResSlice1ThresholdLow", Offset: 28, NameHash: 332076321, Flags: 49469), LayoutImmutable, Blittable]
		public float QuadHalfResSlice1ThresholdLow { get { return m_QuadHalfResSlice1ThresholdLow; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadHalfResSlice1ThresholdLow), this, m_QuadHalfResSlice1ThresholdLow, value)) m_QuadHalfResSlice1ThresholdLow = value; } } // 0x1C (28)
		
		protected float m_QuadHalfResSlice1ThresholdHigh = new float();
		[ContainerField(Name: "QuadHalfResSlice1ThresholdHigh", Offset: 32, NameHash: 2368726075, Flags: 49469), LayoutImmutable, Blittable]
		public float QuadHalfResSlice1ThresholdHigh { get { return m_QuadHalfResSlice1ThresholdHigh; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadHalfResSlice1ThresholdHigh), this, m_QuadHalfResSlice1ThresholdHigh, value)) m_QuadHalfResSlice1ThresholdHigh = value; } } // 0x20 (32)
		
		protected int m_DebugOverdrawCount = new int();
		[ContainerField(Name: "DebugOverdrawCount", Offset: 36, NameHash: 955445401, Flags: 49405), LayoutImmutable, Blittable]
		public int DebugOverdrawCount { get { return m_DebugOverdrawCount; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(DebugOverdrawCount), this, m_DebugOverdrawCount, value)) m_DebugOverdrawCount = value; } } // 0x24 (36)
		
		protected uint m_DrawStats = new uint();
		[ContainerField(Name: "DrawStats", Offset: 40, NameHash: 2413142628, Flags: 49421), LayoutImmutable, Blittable]
		public uint DrawStats { get { return m_DrawStats; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(DrawStats), this, m_DrawStats, value)) m_DrawStats = value; } } // 0x28 (40)
		
		protected float m_MeshStreamingPriorityMultiplier = new float();
		[ContainerField(Name: "MeshStreamingPriorityMultiplier", Offset: 44, NameHash: 1971206387, Flags: 49469), LayoutImmutable, Blittable]
		public float MeshStreamingPriorityMultiplier { get { return m_MeshStreamingPriorityMultiplier; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(MeshStreamingPriorityMultiplier), this, m_MeshStreamingPriorityMultiplier, value)) m_MeshStreamingPriorityMultiplier = value; } } // 0x2C (44)
		
		protected float m_QuadZOcclusionBias = new float();
		[ContainerField(Name: "QuadZOcclusionBias", Offset: 48, NameHash: 158175114, Flags: 49469), LayoutImmutable, Blittable]
		public float QuadZOcclusionBias { get { return m_QuadZOcclusionBias; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadZOcclusionBias), this, m_QuadZOcclusionBias, value)) m_QuadZOcclusionBias = value; } } // 0x30 (48)
		
		protected uint m_DrawBoundingBoxes = new uint();
		[ContainerField(Name: "DrawBoundingBoxes", Offset: 52, NameHash: 256065972, Flags: 49421), LayoutImmutable, Blittable]
		public uint DrawBoundingBoxes { get { return m_DrawBoundingBoxes; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(DrawBoundingBoxes), this, m_DrawBoundingBoxes, value)) m_DrawBoundingBoxes = value; } } // 0x34 (52)
		
		protected float m_MinScreenArea = new float();
		[ContainerField(Name: "MinScreenArea", Offset: 56, NameHash: 81136980, Flags: 49469), LayoutImmutable, Blittable]
		public float MinScreenArea { get { return m_MinScreenArea; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(MinScreenArea), this, m_MinScreenArea, value)) m_MinScreenArea = value; } } // 0x38 (56)
		
		protected float m_QuadNearFadeDistance = new float();
		[ContainerField(Name: "QuadNearFadeDistance", Offset: 60, NameHash: 1063747929, Flags: 49469), LayoutImmutable, Blittable]
		public float QuadNearFadeDistance { get { return m_QuadNearFadeDistance; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadNearFadeDistance), this, m_QuadNearFadeDistance, value)) m_QuadNearFadeDistance = value; } } // 0x3C (60)
		
		protected int m_QuadTechnique = new int();
		[ContainerField(Name: "QuadTechnique", Offset: 64, NameHash: 481029528, Flags: 49405), LayoutImmutable, Blittable]
		public int QuadTechnique { get { return m_QuadTechnique; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadTechnique), this, m_QuadTechnique, value)) m_QuadTechnique = value; } } // 0x40 (64)
		
		protected float m_MeshCullingDistance = new float();
		[ContainerField(Name: "MeshCullingDistance", Offset: 68, NameHash: 2057455619, Flags: 49469), LayoutImmutable, Blittable]
		public float MeshCullingDistance { get { return m_MeshCullingDistance; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(MeshCullingDistance), this, m_MeshCullingDistance, value)) m_MeshCullingDistance = value; } } // 0x44 (68)
		
		protected bool m_EnableFixedTimeStep = new bool();
		[ContainerField(Name: "EnableFixedTimeStep", Offset: 72, NameHash: 3426148757, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnableFixedTimeStep { get { return m_EnableFixedTimeStep; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(EnableFixedTimeStep), this, m_EnableFixedTimeStep, value)) m_EnableFixedTimeStep = value; } } // 0x48 (72)
		
		protected bool m_ZBufferCullEnable = new bool();
		[ContainerField(Name: "ZBufferCullEnable", Offset: 73, NameHash: 2454313224, Flags: 49325), LayoutImmutable, Blittable]
		public bool ZBufferCullEnable { get { return m_ZBufferCullEnable; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(ZBufferCullEnable), this, m_ZBufferCullEnable, value)) m_ZBufferCullEnable = value; } } // 0x49 (73)
		
		protected bool m_QuadEnableOverdrawRendering = new bool();
		[ContainerField(Name: "QuadEnableOverdrawRendering", Offset: 74, NameHash: 2026766721, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadEnableOverdrawRendering { get { return m_QuadEnableOverdrawRendering; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadEnableOverdrawRendering), this, m_QuadEnableOverdrawRendering, value)) m_QuadEnableOverdrawRendering = value; } } // 0x4A (74)
		
		protected bool m_QuadColorShaderCostsEnable = new bool();
		[ContainerField(Name: "QuadColorShaderCostsEnable", Offset: 75, NameHash: 583045289, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadColorShaderCostsEnable { get { return m_QuadColorShaderCostsEnable; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadColorShaderCostsEnable), this, m_QuadColorShaderCostsEnable, value)) m_QuadColorShaderCostsEnable = value; } } // 0x4B (75)
		
		protected bool m_DrawProjectedBoxes = new bool();
		[ContainerField(Name: "DrawProjectedBoxes", Offset: 76, NameHash: 3600370386, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawProjectedBoxes { get { return m_DrawProjectedBoxes; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(DrawProjectedBoxes), this, m_DrawProjectedBoxes, value)) m_DrawProjectedBoxes = value; } } // 0x4C (76)
		
		protected bool m_QuadSimpleRenderingEnable = new bool();
		[ContainerField(Name: "QuadSimpleRenderingEnable", Offset: 77, NameHash: 2930079169, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadSimpleRenderingEnable { get { return m_QuadSimpleRenderingEnable; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadSimpleRenderingEnable), this, m_QuadSimpleRenderingEnable, value)) m_QuadSimpleRenderingEnable = value; } } // 0x4D (77)
		
		protected bool m_EnableJobs = new bool();
		[ContainerField(Name: "EnableJobs", Offset: 78, NameHash: 1190923856, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnableJobs { get { return m_EnableJobs; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(EnableJobs), this, m_EnableJobs, value)) m_EnableJobs = value; } } // 0x4E (78)
		
		protected bool m_EnableRendering = new bool();
		[ContainerField(Name: "EnableRendering", Offset: 79, NameHash: 40741518, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnableRendering { get { return m_EnableRendering; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(EnableRendering), this, m_EnableRendering, value)) m_EnableRendering = value; } } // 0x4F (79)
		
		protected bool m_QuadHalfResEnable = new bool();
		[ContainerField(Name: "QuadHalfResEnable", Offset: 80, NameHash: 780819106, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadHalfResEnable { get { return m_QuadHalfResEnable; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadHalfResEnable), this, m_QuadHalfResEnable, value)) m_QuadHalfResEnable = value; } } // 0x50 (80)
		
		protected bool m_QuadEnableRendering = new bool();
		[ContainerField(Name: "QuadEnableRendering", Offset: 81, NameHash: 468998543, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadEnableRendering { get { return m_QuadEnableRendering; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadEnableRendering), this, m_QuadEnableRendering, value)) m_QuadEnableRendering = value; } } // 0x51 (81)
		
		protected bool m_EnableFixedDelta = new bool();
		[ContainerField(Name: "EnableFixedDelta", Offset: 82, NameHash: 3036744842, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnableFixedDelta { get { return m_EnableFixedDelta; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(EnableFixedDelta), this, m_EnableFixedDelta, value)) m_EnableFixedDelta = value; } } // 0x52 (82)
		
		protected bool m_QuadClipScaleEnable = new bool();
		[ContainerField(Name: "QuadClipScaleEnable", Offset: 83, NameHash: 2519874955, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadClipScaleEnable { get { return m_QuadClipScaleEnable; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadClipScaleEnable), this, m_QuadClipScaleEnable, value)) m_QuadClipScaleEnable = value; } } // 0x53 (83)
		
		protected bool m_QuadNiceRenderingEnable = new bool();
		[ContainerField(Name: "QuadNiceRenderingEnable", Offset: 84, NameHash: 4038089934, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadNiceRenderingEnable { get { return m_QuadNiceRenderingEnable; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadNiceRenderingEnable), this, m_QuadNiceRenderingEnable, value)) m_QuadNiceRenderingEnable = value; } } // 0x54 (84)
		
		protected bool m_QuadGroupsJoinAll = new bool();
		[ContainerField(Name: "QuadGroupsJoinAll", Offset: 85, NameHash: 3752191243, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadGroupsJoinAll { get { return m_QuadGroupsJoinAll; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadGroupsJoinAll), this, m_QuadGroupsJoinAll, value)) m_QuadGroupsJoinAll = value; } } // 0x55 (85)
		
		protected bool m_QuadGroupsJoinNone = new bool();
		[ContainerField(Name: "QuadGroupsJoinNone", Offset: 86, NameHash: 3563197984, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadGroupsJoinNone { get { return m_QuadGroupsJoinNone; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadGroupsJoinNone), this, m_QuadGroupsJoinNone, value)) m_QuadGroupsJoinNone = value; } } // 0x56 (86)
		
		protected bool m_QuadGroupsJoinNiceAndSimple = new bool();
		[ContainerField(Name: "QuadGroupsJoinNiceAndSimple", Offset: 87, NameHash: 2729389326, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadGroupsJoinNiceAndSimple { get { return m_QuadGroupsJoinNiceAndSimple; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadGroupsJoinNiceAndSimple), this, m_QuadGroupsJoinNiceAndSimple, value)) m_QuadGroupsJoinNiceAndSimple = value; } } // 0x57 (87)
		
		protected bool m_QuadEnableOpaque = new bool();
		[ContainerField(Name: "QuadEnableOpaque", Offset: 88, NameHash: 1334058906, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadEnableOpaque { get { return m_QuadEnableOpaque; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadEnableOpaque), this, m_QuadEnableOpaque, value)) m_QuadEnableOpaque = value; } } // 0x58 (88)
		
		protected bool m_QuadVertexShadowsEnable = new bool();
		[ContainerField(Name: "QuadVertexShadowsEnable", Offset: 89, NameHash: 2940509112, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadVertexShadowsEnable { get { return m_QuadVertexShadowsEnable; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadVertexShadowsEnable), this, m_QuadVertexShadowsEnable, value)) m_QuadVertexShadowsEnable = value; } } // 0x59 (89)
		
		protected bool m_QuadPointLightsEnable = new bool();
		[ContainerField(Name: "QuadPointLightsEnable", Offset: 90, NameHash: 1678550564, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadPointLightsEnable { get { return m_QuadPointLightsEnable; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadPointLightsEnable), this, m_QuadPointLightsEnable, value)) m_QuadPointLightsEnable = value; } } // 0x5A (90)
		
		protected bool m_QuadSpotLightsEnable = new bool();
		[ContainerField(Name: "QuadSpotLightsEnable", Offset: 91, NameHash: 2807602672, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadSpotLightsEnable { get { return m_QuadSpotLightsEnable; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadSpotLightsEnable), this, m_QuadSpotLightsEnable, value)) m_QuadSpotLightsEnable = value; } } // 0x5B (91)
		
		protected bool m_QuadEnableSorting = new bool();
		[ContainerField(Name: "QuadEnableSorting", Offset: 92, NameHash: 2931738335, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadEnableSorting { get { return m_QuadEnableSorting; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadEnableSorting), this, m_QuadEnableSorting, value)) m_QuadEnableSorting = value; } } // 0x5C (92)
		
		protected bool m_MeshRenderingEnable = new bool();
		[ContainerField(Name: "MeshRenderingEnable", Offset: 93, NameHash: 2979790077, Flags: 49325), LayoutImmutable, Blittable]
		public bool MeshRenderingEnable { get { return m_MeshRenderingEnable; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(MeshRenderingEnable), this, m_MeshRenderingEnable, value)) m_MeshRenderingEnable = value; } } // 0x5D (93)
		
		protected bool m_MeshDrawTransforms = new bool();
		[ContainerField(Name: "MeshDrawTransforms", Offset: 94, NameHash: 67393161, Flags: 49325), LayoutImmutable, Blittable]
		public bool MeshDrawTransforms { get { return m_MeshDrawTransforms; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(MeshDrawTransforms), this, m_MeshDrawTransforms, value)) m_MeshDrawTransforms = value; } } // 0x5E (94)
		
		protected bool m_MeshDrawBoundingBoxes = new bool();
		[ContainerField(Name: "MeshDrawBoundingBoxes", Offset: 95, NameHash: 1284065831, Flags: 49325), LayoutImmutable, Blittable]
		public bool MeshDrawBoundingBoxes { get { return m_MeshDrawBoundingBoxes; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(MeshDrawBoundingBoxes), this, m_MeshDrawBoundingBoxes, value)) m_MeshDrawBoundingBoxes = value; } } // 0x5F (95)
		
		protected bool m_MeshShadowEnable = new bool();
		[ContainerField(Name: "MeshShadowEnable", Offset: 96, NameHash: 418824849, Flags: 49325), LayoutImmutable, Blittable]
		public bool MeshShadowEnable { get { return m_MeshShadowEnable; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(MeshShadowEnable), this, m_MeshShadowEnable, value)) m_MeshShadowEnable = value; } } // 0x60 (96)
		
		protected bool m_QuadEnableWireframe = new bool();
		[ContainerField(Name: "QuadEnableWireframe", Offset: 97, NameHash: 1089239377, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadEnableWireframe { get { return m_QuadEnableWireframe; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadEnableWireframe), this, m_QuadEnableWireframe, value)) m_QuadEnableWireframe = value; } } // 0x61 (97)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 98, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x62 (98)
		
		protected bool m_QuadEnableZOcclusion = new bool();
		[ContainerField(Name: "QuadEnableZOcclusion", Offset: 99, NameHash: 1606935154, Flags: 49325), LayoutImmutable, Blittable]
		public bool QuadEnableZOcclusion { get { return m_QuadEnableZOcclusion; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(QuadEnableZOcclusion), this, m_QuadEnableZOcclusion, value)) m_QuadEnableZOcclusion = value; } } // 0x63 (99)
		
		protected bool m_MeshDrawCullStats = new bool();
		[ContainerField(Name: "MeshDrawCullStats", Offset: 100, NameHash: 2146509665, Flags: 49325), LayoutImmutable, Blittable]
		public bool MeshDrawCullStats { get { return m_MeshDrawCullStats; } set { if (OnPropertyChanging("EmitterSystemSettings." + nameof(MeshDrawCullStats), this, m_MeshDrawCullStats, value)) m_MeshDrawCullStats = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3584341216:
					MeshDrawCountLimit = (uint) p_Value;
					break;

				case 169511528:
					TimeScale = (float) p_Value;
					break;

				case 191922705:
					GlobalResetStartTimeInterval = (float) p_Value;
					break;

				case 248249250:
					QuadHalfResSlice2ThresholdLow = (float) p_Value;
					break;

				case 3897404056:
					QuadHalfResSlice2ThresholdHigh = (float) p_Value;
					break;

				case 332076321:
					QuadHalfResSlice1ThresholdLow = (float) p_Value;
					break;

				case 2368726075:
					QuadHalfResSlice1ThresholdHigh = (float) p_Value;
					break;

				case 955445401:
					DebugOverdrawCount = (int) p_Value;
					break;

				case 2413142628:
					DrawStats = (uint) p_Value;
					break;

				case 1971206387:
					MeshStreamingPriorityMultiplier = (float) p_Value;
					break;

				case 158175114:
					QuadZOcclusionBias = (float) p_Value;
					break;

				case 256065972:
					DrawBoundingBoxes = (uint) p_Value;
					break;

				case 81136980:
					MinScreenArea = (float) p_Value;
					break;

				case 1063747929:
					QuadNearFadeDistance = (float) p_Value;
					break;

				case 481029528:
					QuadTechnique = (int) p_Value;
					break;

				case 2057455619:
					MeshCullingDistance = (float) p_Value;
					break;

				case 3426148757:
					EnableFixedTimeStep = (bool) p_Value;
					break;

				case 2454313224:
					ZBufferCullEnable = (bool) p_Value;
					break;

				case 2026766721:
					QuadEnableOverdrawRendering = (bool) p_Value;
					break;

				case 583045289:
					QuadColorShaderCostsEnable = (bool) p_Value;
					break;

				case 3600370386:
					DrawProjectedBoxes = (bool) p_Value;
					break;

				case 2930079169:
					QuadSimpleRenderingEnable = (bool) p_Value;
					break;

				case 1190923856:
					EnableJobs = (bool) p_Value;
					break;

				case 40741518:
					EnableRendering = (bool) p_Value;
					break;

				case 780819106:
					QuadHalfResEnable = (bool) p_Value;
					break;

				case 468998543:
					QuadEnableRendering = (bool) p_Value;
					break;

				case 3036744842:
					EnableFixedDelta = (bool) p_Value;
					break;

				case 2519874955:
					QuadClipScaleEnable = (bool) p_Value;
					break;

				case 4038089934:
					QuadNiceRenderingEnable = (bool) p_Value;
					break;

				case 3752191243:
					QuadGroupsJoinAll = (bool) p_Value;
					break;

				case 3563197984:
					QuadGroupsJoinNone = (bool) p_Value;
					break;

				case 2729389326:
					QuadGroupsJoinNiceAndSimple = (bool) p_Value;
					break;

				case 1334058906:
					QuadEnableOpaque = (bool) p_Value;
					break;

				case 2940509112:
					QuadVertexShadowsEnable = (bool) p_Value;
					break;

				case 1678550564:
					QuadPointLightsEnable = (bool) p_Value;
					break;

				case 2807602672:
					QuadSpotLightsEnable = (bool) p_Value;
					break;

				case 2931738335:
					QuadEnableSorting = (bool) p_Value;
					break;

				case 2979790077:
					MeshRenderingEnable = (bool) p_Value;
					break;

				case 67393161:
					MeshDrawTransforms = (bool) p_Value;
					break;

				case 1284065831:
					MeshDrawBoundingBoxes = (bool) p_Value;
					break;

				case 418824849:
					MeshShadowEnable = (bool) p_Value;
					break;

				case 1089239377:
					QuadEnableWireframe = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 1606935154:
					QuadEnableZOcclusion = (bool) p_Value;
					break;

				case 2146509665:
					MeshDrawCullStats = (bool) p_Value;
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
				case 3584341216:
					return MeshDrawCountLimit;

				case 169511528:
					return TimeScale;

				case 191922705:
					return GlobalResetStartTimeInterval;

				case 248249250:
					return QuadHalfResSlice2ThresholdLow;

				case 3897404056:
					return QuadHalfResSlice2ThresholdHigh;

				case 332076321:
					return QuadHalfResSlice1ThresholdLow;

				case 2368726075:
					return QuadHalfResSlice1ThresholdHigh;

				case 955445401:
					return DebugOverdrawCount;

				case 2413142628:
					return DrawStats;

				case 1971206387:
					return MeshStreamingPriorityMultiplier;

				case 158175114:
					return QuadZOcclusionBias;

				case 256065972:
					return DrawBoundingBoxes;

				case 81136980:
					return MinScreenArea;

				case 1063747929:
					return QuadNearFadeDistance;

				case 481029528:
					return QuadTechnique;

				case 2057455619:
					return MeshCullingDistance;

				case 3426148757:
					return EnableFixedTimeStep;

				case 2454313224:
					return ZBufferCullEnable;

				case 2026766721:
					return QuadEnableOverdrawRendering;

				case 583045289:
					return QuadColorShaderCostsEnable;

				case 3600370386:
					return DrawProjectedBoxes;

				case 2930079169:
					return QuadSimpleRenderingEnable;

				case 1190923856:
					return EnableJobs;

				case 40741518:
					return EnableRendering;

				case 780819106:
					return QuadHalfResEnable;

				case 468998543:
					return QuadEnableRendering;

				case 3036744842:
					return EnableFixedDelta;

				case 2519874955:
					return QuadClipScaleEnable;

				case 4038089934:
					return QuadNiceRenderingEnable;

				case 3752191243:
					return QuadGroupsJoinAll;

				case 3563197984:
					return QuadGroupsJoinNone;

				case 2729389326:
					return QuadGroupsJoinNiceAndSimple;

				case 1334058906:
					return QuadEnableOpaque;

				case 2940509112:
					return QuadVertexShadowsEnable;

				case 1678550564:
					return QuadPointLightsEnable;

				case 2807602672:
					return QuadSpotLightsEnable;

				case 2931738335:
					return QuadEnableSorting;

				case 2979790077:
					return MeshRenderingEnable;

				case 67393161:
					return MeshDrawTransforms;

				case 1284065831:
					return MeshDrawBoundingBoxes;

				case 418824849:
					return MeshShadowEnable;

				case 1089239377:
					return QuadEnableWireframe;

				case 2342790116:
					return Enable;

				case 1606935154:
					return QuadEnableZOcclusion;

				case 2146509665:
					return MeshDrawCullStats;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3584341216:
					return typeof(EmitterSystemSettings).GetProperty(nameof(MeshDrawCountLimit));

				case 169511528:
					return typeof(EmitterSystemSettings).GetProperty(nameof(TimeScale));

				case 191922705:
					return typeof(EmitterSystemSettings).GetProperty(nameof(GlobalResetStartTimeInterval));

				case 248249250:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadHalfResSlice2ThresholdLow));

				case 3897404056:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadHalfResSlice2ThresholdHigh));

				case 332076321:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadHalfResSlice1ThresholdLow));

				case 2368726075:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadHalfResSlice1ThresholdHigh));

				case 955445401:
					return typeof(EmitterSystemSettings).GetProperty(nameof(DebugOverdrawCount));

				case 2413142628:
					return typeof(EmitterSystemSettings).GetProperty(nameof(DrawStats));

				case 1971206387:
					return typeof(EmitterSystemSettings).GetProperty(nameof(MeshStreamingPriorityMultiplier));

				case 158175114:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadZOcclusionBias));

				case 256065972:
					return typeof(EmitterSystemSettings).GetProperty(nameof(DrawBoundingBoxes));

				case 81136980:
					return typeof(EmitterSystemSettings).GetProperty(nameof(MinScreenArea));

				case 1063747929:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadNearFadeDistance));

				case 481029528:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadTechnique));

				case 2057455619:
					return typeof(EmitterSystemSettings).GetProperty(nameof(MeshCullingDistance));

				case 3426148757:
					return typeof(EmitterSystemSettings).GetProperty(nameof(EnableFixedTimeStep));

				case 2454313224:
					return typeof(EmitterSystemSettings).GetProperty(nameof(ZBufferCullEnable));

				case 2026766721:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadEnableOverdrawRendering));

				case 583045289:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadColorShaderCostsEnable));

				case 3600370386:
					return typeof(EmitterSystemSettings).GetProperty(nameof(DrawProjectedBoxes));

				case 2930079169:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadSimpleRenderingEnable));

				case 1190923856:
					return typeof(EmitterSystemSettings).GetProperty(nameof(EnableJobs));

				case 40741518:
					return typeof(EmitterSystemSettings).GetProperty(nameof(EnableRendering));

				case 780819106:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadHalfResEnable));

				case 468998543:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadEnableRendering));

				case 3036744842:
					return typeof(EmitterSystemSettings).GetProperty(nameof(EnableFixedDelta));

				case 2519874955:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadClipScaleEnable));

				case 4038089934:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadNiceRenderingEnable));

				case 3752191243:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadGroupsJoinAll));

				case 3563197984:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadGroupsJoinNone));

				case 2729389326:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadGroupsJoinNiceAndSimple));

				case 1334058906:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadEnableOpaque));

				case 2940509112:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadVertexShadowsEnable));

				case 1678550564:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadPointLightsEnable));

				case 2807602672:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadSpotLightsEnable));

				case 2931738335:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadEnableSorting));

				case 2979790077:
					return typeof(EmitterSystemSettings).GetProperty(nameof(MeshRenderingEnable));

				case 67393161:
					return typeof(EmitterSystemSettings).GetProperty(nameof(MeshDrawTransforms));

				case 1284065831:
					return typeof(EmitterSystemSettings).GetProperty(nameof(MeshDrawBoundingBoxes));

				case 418824849:
					return typeof(EmitterSystemSettings).GetProperty(nameof(MeshShadowEnable));

				case 1089239377:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadEnableWireframe));

				case 2342790116:
					return typeof(EmitterSystemSettings).GetProperty(nameof(Enable));

				case 1606935154:
					return typeof(EmitterSystemSettings).GetProperty(nameof(QuadEnableZOcclusion));

				case 2146509665:
					return typeof(EmitterSystemSettings).GetProperty(nameof(MeshDrawCullStats));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
