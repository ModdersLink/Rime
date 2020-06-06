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
	public class EnlightenRuntimeSettings : 
		SystemSettings
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AlbedoDefaultColor { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float LocalLightForceRadius { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public int DrawDebugSystemDependenciesEnable { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float TemporalCoherenceThreshold { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float SkyBoxScale { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public uint MinSystemUpdateCount { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public uint JobCount { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public int DrawDebugSystemBoundingBoxEnable { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public uint LightProbeMaxUpdateSolveCount { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float DrawDebugLightProbeSize { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool CompensateSunShadowHeightScale { get; set; } // 0x44 (68)
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool SaveRadiosityTexturesEnable { get; set; } // 0x45 (69)
		
		[ContainerField(70), LayoutImmutable, Blittable]
		public bool ShadowsEnable { get; set; } // 0x46 (70)
		
		[ContainerField(71), LayoutImmutable, Blittable]
		public bool LightMapsEnable { get; set; } // 0x47 (71)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public bool LocalLightsEnable { get; set; } // 0x48 (72)
		
		[ContainerField(73), LayoutImmutable, Blittable]
		public bool LocalLightCullingEnable { get; set; } // 0x49 (73)
		
		[ContainerField(74), LayoutImmutable, Blittable]
		public bool LocalLightCustumFalloff { get; set; } // 0x4A (74)
		
		[ContainerField(75), LayoutImmutable, Blittable]
		public bool LightProbeForceUpdate { get; set; } // 0x4B (75)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public bool ForceDynamic { get; set; } // 0x4C (76)
		
		[ContainerField(77), LayoutImmutable, Blittable]
		public bool DrawDebugSystemsEnable { get; set; } // 0x4D (77)
		
		[ContainerField(78), LayoutImmutable, Blittable]
		public bool LightProbeEnable { get; set; } // 0x4E (78)
		
		[ContainerField(79), LayoutImmutable, Blittable]
		public bool LightProbeJobsEnable { get; set; } // 0x4F (79)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public bool DrawDebugLightProbes { get; set; } // 0x50 (80)
		
		[ContainerField(81), LayoutImmutable, Blittable]
		public bool DrawDebugLightProbeOcclusion { get; set; } // 0x51 (81)
		
		[ContainerField(82), LayoutImmutable, Blittable]
		public bool DrawDebugLightProbeStats { get; set; } // 0x52 (82)
		
		[ContainerField(83), LayoutImmutable, Blittable]
		public bool DrawDebugLightProbeBoundingBoxes { get; set; } // 0x53 (83)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x54 (84)
		
		[ContainerField(85), LayoutImmutable, Blittable]
		public bool DrawSolveTaskPerformance { get; set; } // 0x55 (85)
		
		[ContainerField(86), LayoutImmutable, Blittable]
		public bool DrawDebugColoringEnable { get; set; } // 0x56 (86)
		
		[ContainerField(87), LayoutImmutable, Blittable]
		public bool DrawDebugTextures { get; set; } // 0x57 (87)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public bool DrawDebugBackFaces { get; set; } // 0x58 (88)
		
		[ContainerField(89), LayoutImmutable, Blittable]
		public bool DrawDebugTargetMeshes { get; set; } // 0x59 (89)
		
		[ContainerField(90), LayoutImmutable, Blittable]
		public bool DrawWarningsEnable { get; set; } // 0x5A (90)
		
		[ContainerField(91), LayoutImmutable, Blittable]
		public bool AlbedoForceUpdateEnable { get; set; } // 0x5B (91)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public bool AlbedoForceColorEnable { get; set; } // 0x5C (92)
		
		[ContainerField(93), LayoutImmutable, Blittable]
		public bool DrawDebugEntities { get; set; } // 0x5D (93)
		
		[ContainerField(94), LayoutImmutable, Blittable]
		public bool TerrainMapEnable { get; set; } // 0x5E (94)
		
		[ContainerField(95), LayoutImmutable, Blittable]
		public bool EmissiveEnable { get; set; } // 0x5F (95)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3820495154:
					AlbedoDefaultColor = (Vec3) p_Value;
					break;

				case 1661259219:
					LocalLightForceRadius = (float) p_Value;
					break;

				case 1925101337:
					DrawDebugSystemDependenciesEnable = (int) p_Value;
					break;

				case 2382770096:
					TemporalCoherenceThreshold = (float) p_Value;
					break;

				case 1351420009:
					SkyBoxScale = (float) p_Value;
					break;

				case 1072001624:
					MinSystemUpdateCount = (uint) p_Value;
					break;

				case 4166996065:
					JobCount = (uint) p_Value;
					break;

				case 3930191639:
					DrawDebugSystemBoundingBoxEnable = (int) p_Value;
					break;

				case 4045454228:
					LightProbeMaxUpdateSolveCount = (uint) p_Value;
					break;

				case 360414469:
					DrawDebugLightProbeSize = (float) p_Value;
					break;

				case 3725127637:
					CompensateSunShadowHeightScale = (bool) p_Value;
					break;

				case 948182575:
					SaveRadiosityTexturesEnable = (bool) p_Value;
					break;

				case 36465329:
					ShadowsEnable = (bool) p_Value;
					break;

				case 3525788341:
					LightMapsEnable = (bool) p_Value;
					break;

				case 1526403524:
					LocalLightsEnable = (bool) p_Value;
					break;

				case 1076113089:
					LocalLightCullingEnable = (bool) p_Value;
					break;

				case 158906263:
					LocalLightCustumFalloff = (bool) p_Value;
					break;

				case 692374557:
					LightProbeForceUpdate = (bool) p_Value;
					break;

				case 1000990669:
					ForceDynamic = (bool) p_Value;
					break;

				case 304890243:
					DrawDebugSystemsEnable = (bool) p_Value;
					break;

				case 2325410768:
					LightProbeEnable = (bool) p_Value;
					break;

				case 471706404:
					LightProbeJobsEnable = (bool) p_Value;
					break;

				case 811150195:
					DrawDebugLightProbes = (bool) p_Value;
					break;

				case 547358317:
					DrawDebugLightProbeOcclusion = (bool) p_Value;
					break;

				case 3303024193:
					DrawDebugLightProbeStats = (bool) p_Value;
					break;

				case 2194295825:
					DrawDebugLightProbeBoundingBoxes = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 4291020115:
					DrawSolveTaskPerformance = (bool) p_Value;
					break;

				case 3572679944:
					DrawDebugColoringEnable = (bool) p_Value;
					break;

				case 1701718488:
					DrawDebugTextures = (bool) p_Value;
					break;

				case 59426509:
					DrawDebugBackFaces = (bool) p_Value;
					break;

				case 1427693792:
					DrawDebugTargetMeshes = (bool) p_Value;
					break;

				case 415895421:
					DrawWarningsEnable = (bool) p_Value;
					break;

				case 1748300073:
					AlbedoForceUpdateEnable = (bool) p_Value;
					break;

				case 2779748037:
					AlbedoForceColorEnable = (bool) p_Value;
					break;

				case 3783622473:
					DrawDebugEntities = (bool) p_Value;
					break;

				case 161713839:
					TerrainMapEnable = (bool) p_Value;
					break;

				case 3278293887:
					EmissiveEnable = (bool) p_Value;
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
				case 3820495154:
					return AlbedoDefaultColor;

				case 1661259219:
					return LocalLightForceRadius;

				case 1925101337:
					return DrawDebugSystemDependenciesEnable;

				case 2382770096:
					return TemporalCoherenceThreshold;

				case 1351420009:
					return SkyBoxScale;

				case 1072001624:
					return MinSystemUpdateCount;

				case 4166996065:
					return JobCount;

				case 3930191639:
					return DrawDebugSystemBoundingBoxEnable;

				case 4045454228:
					return LightProbeMaxUpdateSolveCount;

				case 360414469:
					return DrawDebugLightProbeSize;

				case 3725127637:
					return CompensateSunShadowHeightScale;

				case 948182575:
					return SaveRadiosityTexturesEnable;

				case 36465329:
					return ShadowsEnable;

				case 3525788341:
					return LightMapsEnable;

				case 1526403524:
					return LocalLightsEnable;

				case 1076113089:
					return LocalLightCullingEnable;

				case 158906263:
					return LocalLightCustumFalloff;

				case 692374557:
					return LightProbeForceUpdate;

				case 1000990669:
					return ForceDynamic;

				case 304890243:
					return DrawDebugSystemsEnable;

				case 2325410768:
					return LightProbeEnable;

				case 471706404:
					return LightProbeJobsEnable;

				case 811150195:
					return DrawDebugLightProbes;

				case 547358317:
					return DrawDebugLightProbeOcclusion;

				case 3303024193:
					return DrawDebugLightProbeStats;

				case 2194295825:
					return DrawDebugLightProbeBoundingBoxes;

				case 2342790116:
					return Enable;

				case 4291020115:
					return DrawSolveTaskPerformance;

				case 3572679944:
					return DrawDebugColoringEnable;

				case 1701718488:
					return DrawDebugTextures;

				case 59426509:
					return DrawDebugBackFaces;

				case 1427693792:
					return DrawDebugTargetMeshes;

				case 415895421:
					return DrawWarningsEnable;

				case 1748300073:
					return AlbedoForceUpdateEnable;

				case 2779748037:
					return AlbedoForceColorEnable;

				case 3783622473:
					return DrawDebugEntities;

				case 161713839:
					return TerrainMapEnable;

				case 3278293887:
					return EmissiveEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3820495154:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(AlbedoDefaultColor));

				case 1661259219:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(LocalLightForceRadius));

				case 1925101337:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugSystemDependenciesEnable));

				case 2382770096:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(TemporalCoherenceThreshold));

				case 1351420009:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(SkyBoxScale));

				case 1072001624:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(MinSystemUpdateCount));

				case 4166996065:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(JobCount));

				case 3930191639:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugSystemBoundingBoxEnable));

				case 4045454228:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(LightProbeMaxUpdateSolveCount));

				case 360414469:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugLightProbeSize));

				case 3725127637:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(CompensateSunShadowHeightScale));

				case 948182575:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(SaveRadiosityTexturesEnable));

				case 36465329:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(ShadowsEnable));

				case 3525788341:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(LightMapsEnable));

				case 1526403524:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(LocalLightsEnable));

				case 1076113089:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(LocalLightCullingEnable));

				case 158906263:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(LocalLightCustumFalloff));

				case 692374557:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(LightProbeForceUpdate));

				case 1000990669:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(ForceDynamic));

				case 304890243:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugSystemsEnable));

				case 2325410768:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(LightProbeEnable));

				case 471706404:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(LightProbeJobsEnable));

				case 811150195:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugLightProbes));

				case 547358317:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugLightProbeOcclusion));

				case 3303024193:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugLightProbeStats));

				case 2194295825:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugLightProbeBoundingBoxes));

				case 2342790116:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(Enable));

				case 4291020115:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawSolveTaskPerformance));

				case 3572679944:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugColoringEnable));

				case 1701718488:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugTextures));

				case 59426509:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugBackFaces));

				case 1427693792:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugTargetMeshes));

				case 415895421:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawWarningsEnable));

				case 1748300073:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(AlbedoForceUpdateEnable));

				case 2779748037:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(AlbedoForceColorEnable));

				case 3783622473:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(DrawDebugEntities));

				case 161713839:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(TerrainMapEnable));

				case 3278293887:
					return typeof(EnlightenRuntimeSettings).GetProperty(nameof(EmissiveEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
