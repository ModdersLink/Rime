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
	[ContainerType(16, 96)]
	public class EnlightenRuntimeSettings : 
		SystemSettings
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AlbedoDefaultColor { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float LocalLightForceRadius { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public int DrawDebugSystemDependenciesEnable { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float TemporalCoherenceThreshold { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float SkyBoxScale { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public uint MinSystemUpdateCount { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public uint JobCount { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public int DrawDebugSystemBoundingBoxEnable { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public uint LightProbeMaxUpdateSolveCount { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float DrawDebugLightProbeSize { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public bool CompensateSunShadowHeightScale { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable]
		public bool SaveRadiosityTexturesEnable { get; set; }

		[ContainerField(70), LayoutImmutable, Blittable]
		public bool ShadowsEnable { get; set; }

		[ContainerField(71), LayoutImmutable, Blittable]
		public bool LightMapsEnable { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public bool LocalLightsEnable { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable]
		public bool LocalLightCullingEnable { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable]
		public bool LocalLightCustumFalloff { get; set; }

		[ContainerField(75), LayoutImmutable, Blittable]
		public bool LightProbeForceUpdate { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public bool ForceDynamic { get; set; }

		[ContainerField(77), LayoutImmutable, Blittable]
		public bool DrawDebugSystemsEnable { get; set; }

		[ContainerField(78), LayoutImmutable, Blittable]
		public bool LightProbeEnable { get; set; }

		[ContainerField(79), LayoutImmutable, Blittable]
		public bool LightProbeJobsEnable { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public bool DrawDebugLightProbes { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable]
		public bool DrawDebugLightProbeOcclusion { get; set; }

		[ContainerField(82), LayoutImmutable, Blittable]
		public bool DrawDebugLightProbeStats { get; set; }

		[ContainerField(83), LayoutImmutable, Blittable]
		public bool DrawDebugLightProbeBoundingBoxes { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(85), LayoutImmutable, Blittable]
		public bool DrawSolveTaskPerformance { get; set; }

		[ContainerField(86), LayoutImmutable, Blittable]
		public bool DrawDebugColoringEnable { get; set; }

		[ContainerField(87), LayoutImmutable, Blittable]
		public bool DrawDebugTextures { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public bool DrawDebugBackFaces { get; set; }

		[ContainerField(89), LayoutImmutable, Blittable]
		public bool DrawDebugTargetMeshes { get; set; }

		[ContainerField(90), LayoutImmutable, Blittable]
		public bool DrawWarningsEnable { get; set; }

		[ContainerField(91), LayoutImmutable, Blittable]
		public bool AlbedoForceUpdateEnable { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public bool AlbedoForceColorEnable { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable]
		public bool DrawDebugEntities { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable]
		public bool TerrainMapEnable { get; set; }

		[ContainerField(95), LayoutImmutable, Blittable]
		public bool EmissiveEnable { get; set; }

	}
}
