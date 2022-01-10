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

		public static void Deserialize(EnlightenRuntimeSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.AlbedoDefaultColor, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LocalLightForceRadius = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugSystemDependenciesEnable = p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.TemporalCoherenceThreshold = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.SkyBoxScale = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MinSystemUpdateCount = p_Reader.ReadUInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.JobCount = p_Reader.ReadUInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugSystemBoundingBoxEnable = p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LightProbeMaxUpdateSolveCount = p_Reader.ReadUInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugLightProbeSize = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.CompensateSunShadowHeightScale = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.SaveRadiosityTexturesEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ShadowsEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LightMapsEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LocalLightsEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LocalLightCullingEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LocalLightCustumFalloff = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LightProbeForceUpdate = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ForceDynamic = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugSystemsEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LightProbeEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LightProbeJobsEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugLightProbes = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugLightProbeOcclusion = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugLightProbeStats = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugLightProbeBoundingBoxes = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawSolveTaskPerformance = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugColoringEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugTextures = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugBackFaces = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugTargetMeshes = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawWarningsEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.AlbedoForceUpdateEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.AlbedoForceColorEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DrawDebugEntities = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.TerrainMapEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.EmissiveEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
