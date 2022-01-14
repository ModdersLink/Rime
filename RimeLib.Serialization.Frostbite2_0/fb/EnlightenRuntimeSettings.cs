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
	[ContainerType(16, 96)]
	public class EnlightenRuntimeSettings :
		SystemSettings
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 AlbedoDefaultColor { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float LocalLightForceRadius { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public int DrawDebugSystemDependenciesEnable { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float TemporalCoherenceThreshold { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float SkyBoxScale { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public uint MinSystemUpdateCount { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public uint JobCount { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public int DrawDebugSystemBoundingBoxEnable { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public uint LightProbeMaxUpdateSolveCount { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float DrawDebugLightProbeSize { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool CompensateSunShadowHeightScale { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		public bool SaveRadiosityTexturesEnable { get; set; }

		[ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		public bool ShadowsEnable { get; set; }

		[ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		public bool LightMapsEnable { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public bool LocalLightsEnable { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		public bool LocalLightCullingEnable { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		public bool LocalLightCustumFalloff { get; set; }

		[ContainerField(75), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
		public bool LightProbeForceUpdate { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public bool ForceDynamic { get; set; }

		[ContainerField(77), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
		public bool DrawDebugSystemsEnable { get; set; }

		[ContainerField(78), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
		public bool LightProbeEnable { get; set; }

		[ContainerField(79), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
		public bool LightProbeJobsEnable { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public bool DrawDebugLightProbes { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		public bool DrawDebugLightProbeOcclusion { get; set; }

		[ContainerField(82), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
		public bool DrawDebugLightProbeStats { get; set; }

		[ContainerField(83), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
		public bool DrawDebugLightProbeBoundingBoxes { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public bool Enable { get; set; }

		[ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		public bool DrawSolveTaskPerformance { get; set; }

		[ContainerField(86), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
		public bool DrawDebugColoringEnable { get; set; }

		[ContainerField(87), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
		public bool DrawDebugTextures { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public bool DrawDebugBackFaces { get; set; }

		[ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		public bool DrawDebugTargetMeshes { get; set; }

		[ContainerField(90), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
		public bool DrawWarningsEnable { get; set; }

		[ContainerField(91), LayoutImmutable, Blittable, JsonProperty(Order = 91)]
		public bool AlbedoForceUpdateEnable { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public bool AlbedoForceColorEnable { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		public bool DrawDebugEntities { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		public bool TerrainMapEnable { get; set; }

		[ContainerField(95), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
		public bool EmissiveEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			AlbedoDefaultColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(LocalLightForceRadius);
			p_Writer.Write(DrawDebugSystemDependenciesEnable);
			p_Writer.Write(TemporalCoherenceThreshold);
			p_Writer.Write(SkyBoxScale);
			p_Writer.Write(MinSystemUpdateCount);
			p_Writer.Write(JobCount);
			p_Writer.Write(DrawDebugSystemBoundingBoxEnable);
			p_Writer.Write(LightProbeMaxUpdateSolveCount);
			p_Writer.Write(DrawDebugLightProbeSize);
			p_Writer.Write(CompensateSunShadowHeightScale);
			p_Writer.Write(SaveRadiosityTexturesEnable);
			p_Writer.Write(ShadowsEnable);
			p_Writer.Write(LightMapsEnable);
			p_Writer.Write(LocalLightsEnable);
			p_Writer.Write(LocalLightCullingEnable);
			p_Writer.Write(LocalLightCustumFalloff);
			p_Writer.Write(LightProbeForceUpdate);
			p_Writer.Write(ForceDynamic);
			p_Writer.Write(DrawDebugSystemsEnable);
			p_Writer.Write(LightProbeEnable);
			p_Writer.Write(LightProbeJobsEnable);
			p_Writer.Write(DrawDebugLightProbes);
			p_Writer.Write(DrawDebugLightProbeOcclusion);
			p_Writer.Write(DrawDebugLightProbeStats);
			p_Writer.Write(DrawDebugLightProbeBoundingBoxes);
			p_Writer.Write(Enable);
			p_Writer.Write(DrawSolveTaskPerformance);
			p_Writer.Write(DrawDebugColoringEnable);
			p_Writer.Write(DrawDebugTextures);
			p_Writer.Write(DrawDebugBackFaces);
			p_Writer.Write(DrawDebugTargetMeshes);
			p_Writer.Write(DrawWarningsEnable);
			p_Writer.Write(AlbedoForceUpdateEnable);
			p_Writer.Write(AlbedoForceColorEnable);
			p_Writer.Write(DrawDebugEntities);
			p_Writer.Write(TerrainMapEnable);
			p_Writer.Write(EmissiveEnable);
		}
	}
}
