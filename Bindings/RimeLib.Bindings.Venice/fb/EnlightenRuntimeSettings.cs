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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 96)]
	public class EnlightenRuntimeSettings : 
		SystemSettings
	{
		protected Vec3 m_AlbedoDefaultColor = new Vec3();
		[ContainerField(Name: "AlbedoDefaultColor", Offset: 16, NameHash: 3820495154, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AlbedoDefaultColor { get { return m_AlbedoDefaultColor; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(AlbedoDefaultColor), this, m_AlbedoDefaultColor, value)) m_AlbedoDefaultColor = value; } } // 0x10 (16)
		
		protected float m_LocalLightForceRadius = new float();
		[ContainerField(Name: "LocalLightForceRadius", Offset: 32, NameHash: 1661259219, Flags: 49469), LayoutImmutable, Blittable]
		public float LocalLightForceRadius { get { return m_LocalLightForceRadius; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(LocalLightForceRadius), this, m_LocalLightForceRadius, value)) m_LocalLightForceRadius = value; } } // 0x20 (32)
		
		protected int m_DrawDebugSystemDependenciesEnable = new int();
		[ContainerField(Name: "DrawDebugSystemDependenciesEnable", Offset: 36, NameHash: 1925101337, Flags: 49405), LayoutImmutable, Blittable]
		public int DrawDebugSystemDependenciesEnable { get { return m_DrawDebugSystemDependenciesEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugSystemDependenciesEnable), this, m_DrawDebugSystemDependenciesEnable, value)) m_DrawDebugSystemDependenciesEnable = value; } } // 0x24 (36)
		
		protected float m_TemporalCoherenceThreshold = new float();
		[ContainerField(Name: "TemporalCoherenceThreshold", Offset: 40, NameHash: 2382770096, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalCoherenceThreshold { get { return m_TemporalCoherenceThreshold; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(TemporalCoherenceThreshold), this, m_TemporalCoherenceThreshold, value)) m_TemporalCoherenceThreshold = value; } } // 0x28 (40)
		
		protected float m_SkyBoxScale = new float();
		[ContainerField(Name: "SkyBoxScale", Offset: 44, NameHash: 1351420009, Flags: 49469), LayoutImmutable, Blittable]
		public float SkyBoxScale { get { return m_SkyBoxScale; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(SkyBoxScale), this, m_SkyBoxScale, value)) m_SkyBoxScale = value; } } // 0x2C (44)
		
		protected uint m_MinSystemUpdateCount = new uint();
		[ContainerField(Name: "MinSystemUpdateCount", Offset: 48, NameHash: 1072001624, Flags: 49421), LayoutImmutable, Blittable]
		public uint MinSystemUpdateCount { get { return m_MinSystemUpdateCount; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(MinSystemUpdateCount), this, m_MinSystemUpdateCount, value)) m_MinSystemUpdateCount = value; } } // 0x30 (48)
		
		protected uint m_JobCount = new uint();
		[ContainerField(Name: "JobCount", Offset: 52, NameHash: 4166996065, Flags: 49421), LayoutImmutable, Blittable]
		public uint JobCount { get { return m_JobCount; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(JobCount), this, m_JobCount, value)) m_JobCount = value; } } // 0x34 (52)
		
		protected int m_DrawDebugSystemBoundingBoxEnable = new int();
		[ContainerField(Name: "DrawDebugSystemBoundingBoxEnable", Offset: 56, NameHash: 3930191639, Flags: 49405), LayoutImmutable, Blittable]
		public int DrawDebugSystemBoundingBoxEnable { get { return m_DrawDebugSystemBoundingBoxEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugSystemBoundingBoxEnable), this, m_DrawDebugSystemBoundingBoxEnable, value)) m_DrawDebugSystemBoundingBoxEnable = value; } } // 0x38 (56)
		
		protected uint m_LightProbeMaxUpdateSolveCount = new uint();
		[ContainerField(Name: "LightProbeMaxUpdateSolveCount", Offset: 60, NameHash: 4045454228, Flags: 49421), LayoutImmutable, Blittable]
		public uint LightProbeMaxUpdateSolveCount { get { return m_LightProbeMaxUpdateSolveCount; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(LightProbeMaxUpdateSolveCount), this, m_LightProbeMaxUpdateSolveCount, value)) m_LightProbeMaxUpdateSolveCount = value; } } // 0x3C (60)
		
		protected float m_DrawDebugLightProbeSize = new float();
		[ContainerField(Name: "DrawDebugLightProbeSize", Offset: 64, NameHash: 360414469, Flags: 49469), LayoutImmutable, Blittable]
		public float DrawDebugLightProbeSize { get { return m_DrawDebugLightProbeSize; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugLightProbeSize), this, m_DrawDebugLightProbeSize, value)) m_DrawDebugLightProbeSize = value; } } // 0x40 (64)
		
		protected bool m_CompensateSunShadowHeightScale = new bool();
		[ContainerField(Name: "CompensateSunShadowHeightScale", Offset: 68, NameHash: 3725127637, Flags: 49325), LayoutImmutable, Blittable]
		public bool CompensateSunShadowHeightScale { get { return m_CompensateSunShadowHeightScale; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(CompensateSunShadowHeightScale), this, m_CompensateSunShadowHeightScale, value)) m_CompensateSunShadowHeightScale = value; } } // 0x44 (68)
		
		protected bool m_SaveRadiosityTexturesEnable = new bool();
		[ContainerField(Name: "SaveRadiosityTexturesEnable", Offset: 69, NameHash: 948182575, Flags: 49325), LayoutImmutable, Blittable]
		public bool SaveRadiosityTexturesEnable { get { return m_SaveRadiosityTexturesEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(SaveRadiosityTexturesEnable), this, m_SaveRadiosityTexturesEnable, value)) m_SaveRadiosityTexturesEnable = value; } } // 0x45 (69)
		
		protected bool m_ShadowsEnable = new bool();
		[ContainerField(Name: "ShadowsEnable", Offset: 70, NameHash: 36465329, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShadowsEnable { get { return m_ShadowsEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(ShadowsEnable), this, m_ShadowsEnable, value)) m_ShadowsEnable = value; } } // 0x46 (70)
		
		protected bool m_LightMapsEnable = new bool();
		[ContainerField(Name: "LightMapsEnable", Offset: 71, NameHash: 3525788341, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightMapsEnable { get { return m_LightMapsEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(LightMapsEnable), this, m_LightMapsEnable, value)) m_LightMapsEnable = value; } } // 0x47 (71)
		
		protected bool m_LocalLightsEnable = new bool();
		[ContainerField(Name: "LocalLightsEnable", Offset: 72, NameHash: 1526403524, Flags: 49325), LayoutImmutable, Blittable]
		public bool LocalLightsEnable { get { return m_LocalLightsEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(LocalLightsEnable), this, m_LocalLightsEnable, value)) m_LocalLightsEnable = value; } } // 0x48 (72)
		
		protected bool m_LocalLightCullingEnable = new bool();
		[ContainerField(Name: "LocalLightCullingEnable", Offset: 73, NameHash: 1076113089, Flags: 49325), LayoutImmutable, Blittable]
		public bool LocalLightCullingEnable { get { return m_LocalLightCullingEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(LocalLightCullingEnable), this, m_LocalLightCullingEnable, value)) m_LocalLightCullingEnable = value; } } // 0x49 (73)
		
		protected bool m_LocalLightCustumFalloff = new bool();
		[ContainerField(Name: "LocalLightCustumFalloff", Offset: 74, NameHash: 158906263, Flags: 49325), LayoutImmutable, Blittable]
		public bool LocalLightCustumFalloff { get { return m_LocalLightCustumFalloff; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(LocalLightCustumFalloff), this, m_LocalLightCustumFalloff, value)) m_LocalLightCustumFalloff = value; } } // 0x4A (74)
		
		protected bool m_LightProbeForceUpdate = new bool();
		[ContainerField(Name: "LightProbeForceUpdate", Offset: 75, NameHash: 692374557, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightProbeForceUpdate { get { return m_LightProbeForceUpdate; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(LightProbeForceUpdate), this, m_LightProbeForceUpdate, value)) m_LightProbeForceUpdate = value; } } // 0x4B (75)
		
		protected bool m_ForceDynamic = new bool();
		[ContainerField(Name: "ForceDynamic", Offset: 76, NameHash: 1000990669, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceDynamic { get { return m_ForceDynamic; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(ForceDynamic), this, m_ForceDynamic, value)) m_ForceDynamic = value; } } // 0x4C (76)
		
		protected bool m_DrawDebugSystemsEnable = new bool();
		[ContainerField(Name: "DrawDebugSystemsEnable", Offset: 77, NameHash: 304890243, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugSystemsEnable { get { return m_DrawDebugSystemsEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugSystemsEnable), this, m_DrawDebugSystemsEnable, value)) m_DrawDebugSystemsEnable = value; } } // 0x4D (77)
		
		protected bool m_LightProbeEnable = new bool();
		[ContainerField(Name: "LightProbeEnable", Offset: 78, NameHash: 2325410768, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightProbeEnable { get { return m_LightProbeEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(LightProbeEnable), this, m_LightProbeEnable, value)) m_LightProbeEnable = value; } } // 0x4E (78)
		
		protected bool m_LightProbeJobsEnable = new bool();
		[ContainerField(Name: "LightProbeJobsEnable", Offset: 79, NameHash: 471706404, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightProbeJobsEnable { get { return m_LightProbeJobsEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(LightProbeJobsEnable), this, m_LightProbeJobsEnable, value)) m_LightProbeJobsEnable = value; } } // 0x4F (79)
		
		protected bool m_DrawDebugLightProbes = new bool();
		[ContainerField(Name: "DrawDebugLightProbes", Offset: 80, NameHash: 811150195, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLightProbes { get { return m_DrawDebugLightProbes; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugLightProbes), this, m_DrawDebugLightProbes, value)) m_DrawDebugLightProbes = value; } } // 0x50 (80)
		
		protected bool m_DrawDebugLightProbeOcclusion = new bool();
		[ContainerField(Name: "DrawDebugLightProbeOcclusion", Offset: 81, NameHash: 547358317, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLightProbeOcclusion { get { return m_DrawDebugLightProbeOcclusion; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugLightProbeOcclusion), this, m_DrawDebugLightProbeOcclusion, value)) m_DrawDebugLightProbeOcclusion = value; } } // 0x51 (81)
		
		protected bool m_DrawDebugLightProbeStats = new bool();
		[ContainerField(Name: "DrawDebugLightProbeStats", Offset: 82, NameHash: 3303024193, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLightProbeStats { get { return m_DrawDebugLightProbeStats; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugLightProbeStats), this, m_DrawDebugLightProbeStats, value)) m_DrawDebugLightProbeStats = value; } } // 0x52 (82)
		
		protected bool m_DrawDebugLightProbeBoundingBoxes = new bool();
		[ContainerField(Name: "DrawDebugLightProbeBoundingBoxes", Offset: 83, NameHash: 2194295825, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLightProbeBoundingBoxes { get { return m_DrawDebugLightProbeBoundingBoxes; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugLightProbeBoundingBoxes), this, m_DrawDebugLightProbeBoundingBoxes, value)) m_DrawDebugLightProbeBoundingBoxes = value; } } // 0x53 (83)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 84, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x54 (84)
		
		protected bool m_DrawSolveTaskPerformance = new bool();
		[ContainerField(Name: "DrawSolveTaskPerformance", Offset: 85, NameHash: 4291020115, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawSolveTaskPerformance { get { return m_DrawSolveTaskPerformance; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawSolveTaskPerformance), this, m_DrawSolveTaskPerformance, value)) m_DrawSolveTaskPerformance = value; } } // 0x55 (85)
		
		protected bool m_DrawDebugColoringEnable = new bool();
		[ContainerField(Name: "DrawDebugColoringEnable", Offset: 86, NameHash: 3572679944, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugColoringEnable { get { return m_DrawDebugColoringEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugColoringEnable), this, m_DrawDebugColoringEnable, value)) m_DrawDebugColoringEnable = value; } } // 0x56 (86)
		
		protected bool m_DrawDebugTextures = new bool();
		[ContainerField(Name: "DrawDebugTextures", Offset: 87, NameHash: 1701718488, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugTextures { get { return m_DrawDebugTextures; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugTextures), this, m_DrawDebugTextures, value)) m_DrawDebugTextures = value; } } // 0x57 (87)
		
		protected bool m_DrawDebugBackFaces = new bool();
		[ContainerField(Name: "DrawDebugBackFaces", Offset: 88, NameHash: 59426509, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugBackFaces { get { return m_DrawDebugBackFaces; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugBackFaces), this, m_DrawDebugBackFaces, value)) m_DrawDebugBackFaces = value; } } // 0x58 (88)
		
		protected bool m_DrawDebugTargetMeshes = new bool();
		[ContainerField(Name: "DrawDebugTargetMeshes", Offset: 89, NameHash: 1427693792, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugTargetMeshes { get { return m_DrawDebugTargetMeshes; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugTargetMeshes), this, m_DrawDebugTargetMeshes, value)) m_DrawDebugTargetMeshes = value; } } // 0x59 (89)
		
		protected bool m_DrawWarningsEnable = new bool();
		[ContainerField(Name: "DrawWarningsEnable", Offset: 90, NameHash: 415895421, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawWarningsEnable { get { return m_DrawWarningsEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawWarningsEnable), this, m_DrawWarningsEnable, value)) m_DrawWarningsEnable = value; } } // 0x5A (90)
		
		protected bool m_AlbedoForceUpdateEnable = new bool();
		[ContainerField(Name: "AlbedoForceUpdateEnable", Offset: 91, NameHash: 1748300073, Flags: 49325), LayoutImmutable, Blittable]
		public bool AlbedoForceUpdateEnable { get { return m_AlbedoForceUpdateEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(AlbedoForceUpdateEnable), this, m_AlbedoForceUpdateEnable, value)) m_AlbedoForceUpdateEnable = value; } } // 0x5B (91)
		
		protected bool m_AlbedoForceColorEnable = new bool();
		[ContainerField(Name: "AlbedoForceColorEnable", Offset: 92, NameHash: 2779748037, Flags: 49325), LayoutImmutable, Blittable]
		public bool AlbedoForceColorEnable { get { return m_AlbedoForceColorEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(AlbedoForceColorEnable), this, m_AlbedoForceColorEnable, value)) m_AlbedoForceColorEnable = value; } } // 0x5C (92)
		
		protected bool m_DrawDebugEntities = new bool();
		[ContainerField(Name: "DrawDebugEntities", Offset: 93, NameHash: 3783622473, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugEntities { get { return m_DrawDebugEntities; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(DrawDebugEntities), this, m_DrawDebugEntities, value)) m_DrawDebugEntities = value; } } // 0x5D (93)
		
		protected bool m_TerrainMapEnable = new bool();
		[ContainerField(Name: "TerrainMapEnable", Offset: 94, NameHash: 161713839, Flags: 49325), LayoutImmutable, Blittable]
		public bool TerrainMapEnable { get { return m_TerrainMapEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(TerrainMapEnable), this, m_TerrainMapEnable, value)) m_TerrainMapEnable = value; } } // 0x5E (94)
		
		protected bool m_EmissiveEnable = new bool();
		[ContainerField(Name: "EmissiveEnable", Offset: 95, NameHash: 3278293887, Flags: 49325), LayoutImmutable, Blittable]
		public bool EmissiveEnable { get { return m_EmissiveEnable; } set { if (OnPropertyChanging("EnlightenRuntimeSettings." + nameof(EmissiveEnable), this, m_EmissiveEnable, value)) m_EmissiveEnable = value; } } // 0x5F (95)
		
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
