///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class EmitterSystemSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint MeshDrawCountLimit { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float TimeScale { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float GlobalResetStartTimeInterval { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float QuadHalfResSlice2ThresholdLow { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float QuadHalfResSlice2ThresholdHigh { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float QuadHalfResSlice1ThresholdLow { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float QuadHalfResSlice1ThresholdHigh { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public int DebugOverdrawCount { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint DrawStats { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float MeshStreamingPriorityMultiplier { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float QuadZOcclusionBias { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public uint DrawBoundingBoxes { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float MinScreenArea { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float QuadNearFadeDistance { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public int QuadTechnique { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float MeshCullingDistance { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public bool EnableFixedTimeStep { get; set; } // 0x48 (72)
		
		[ContainerField(73), LayoutImmutable, Blittable]
		public bool ZBufferCullEnable { get; set; } // 0x49 (73)
		
		[ContainerField(74), LayoutImmutable, Blittable]
		public bool QuadEnableOverdrawRendering { get; set; } // 0x4A (74)
		
		[ContainerField(75), LayoutImmutable, Blittable]
		public bool QuadColorShaderCostsEnable { get; set; } // 0x4B (75)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public bool DrawProjectedBoxes { get; set; } // 0x4C (76)
		
		[ContainerField(77), LayoutImmutable, Blittable]
		public bool QuadSimpleRenderingEnable { get; set; } // 0x4D (77)
		
		[ContainerField(78), LayoutImmutable, Blittable]
		public bool EnableJobs { get; set; } // 0x4E (78)
		
		[ContainerField(79), LayoutImmutable, Blittable]
		public bool EnableRendering { get; set; } // 0x4F (79)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public bool QuadHalfResEnable { get; set; } // 0x50 (80)
		
		[ContainerField(81), LayoutImmutable, Blittable]
		public bool QuadEnableRendering { get; set; } // 0x51 (81)
		
		[ContainerField(82), LayoutImmutable, Blittable]
		public bool EnableFixedDelta { get; set; } // 0x52 (82)
		
		[ContainerField(83), LayoutImmutable, Blittable]
		public bool QuadClipScaleEnable { get; set; } // 0x53 (83)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public bool QuadNiceRenderingEnable { get; set; } // 0x54 (84)
		
		[ContainerField(85), LayoutImmutable, Blittable]
		public bool QuadGroupsJoinAll { get; set; } // 0x55 (85)
		
		[ContainerField(86), LayoutImmutable, Blittable]
		public bool QuadGroupsJoinNone { get; set; } // 0x56 (86)
		
		[ContainerField(87), LayoutImmutable, Blittable]
		public bool QuadGroupsJoinNiceAndSimple { get; set; } // 0x57 (87)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public bool QuadEnableOpaque { get; set; } // 0x58 (88)
		
		[ContainerField(89), LayoutImmutable, Blittable]
		public bool QuadVertexShadowsEnable { get; set; } // 0x59 (89)
		
		[ContainerField(90), LayoutImmutable, Blittable]
		public bool QuadPointLightsEnable { get; set; } // 0x5A (90)
		
		[ContainerField(91), LayoutImmutable, Blittable]
		public bool QuadSpotLightsEnable { get; set; } // 0x5B (91)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public bool QuadEnableSorting { get; set; } // 0x5C (92)
		
		[ContainerField(93), LayoutImmutable, Blittable]
		public bool MeshRenderingEnable { get; set; } // 0x5D (93)
		
		[ContainerField(94), LayoutImmutable, Blittable]
		public bool MeshDrawTransforms { get; set; } // 0x5E (94)
		
		[ContainerField(95), LayoutImmutable, Blittable]
		public bool MeshDrawBoundingBoxes { get; set; } // 0x5F (95)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool MeshShadowEnable { get; set; } // 0x60 (96)
		
		[ContainerField(97), LayoutImmutable, Blittable]
		public bool QuadEnableWireframe { get; set; } // 0x61 (97)
		
		[ContainerField(98), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x62 (98)
		
		[ContainerField(99), LayoutImmutable, Blittable]
		public bool QuadEnableZOcclusion { get; set; } // 0x63 (99)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public bool MeshDrawCullStats { get; set; } // 0x64 (100)
		
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
