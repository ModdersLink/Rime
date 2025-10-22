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

namespace fb.WorldRender;

[ContainerType(16, 160)]
public class EnlightenRuntimeSettings
	: fb.Core.SystemSettings
{
	public EnlightenRuntimeSettings()
	{
		//SystemSettings
		Name = @"Enlighten";
	}
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 AlbedoDefaultColor { get; set; } = new()
	{
		z = 0.300f,
		y = 0.300f,
		x = 0.300f,
	};
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float TemporalCoherenceThreshold { get; set; } = 0.010f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float SkyBoxScale { get; set; } = 1.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float MaxPerFrameSolveTime { get; set; } = 5.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public uint MinSystemUpdateCount { get; set; } = 3;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint JobCount { get; set; } = 16;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public uint CubeMapMaxUpdateCount { get; set; } = 1;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public uint CubeMapConvolutionSampleCount { get; set; } = 32;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float CubeMapForceGlobalScale { get; set; } = -1.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public uint LightProbeMaxSourceSolveCount { get; set; } = 1024;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public uint LightProbeMaxInstanceUpdateCount { get; set; } = 512;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public uint LightProbeLookupTableGridRes { get; set; } = 32;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float LocalLightForceRadius { get; set; } = 1.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public int DrawDebugSystemDependenciesEnable { get; set; } = -1;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public int DrawDebugSystemBoundingBoxEnable { get; set; } = -1;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float DrawDebugLightProbeSize { get; set; } = 0.500f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public bool ForceDynamic { get; set; } = false;
	
	[ContainerField(0x6e), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
	public bool ForceUpdateStaticLightingBuffersEnable { get; set; } = false;
	
	[ContainerField(0x6f), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
	public bool AllowLightmapTextureOverride { get; set; } = true;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool SaveRadiosityTexturesEnable { get; set; } = false;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool JobsEnable { get; set; } = true;
	
	[ContainerField(0x72), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
	public bool ShadowsEnable { get; set; } = true;
	
	[ContainerField(0x73), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
	public bool SpotLightShadowsEnable { get; set; } = true;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public bool CubeMapsEnable { get; set; } = true;
	
	[ContainerField(0x75), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
	public bool CubeMapMip0OnlyEnable { get; set; } = false;
	
	[ContainerField(0x76), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
	public bool CubeMapCpuMipMapGenerationEnable { get; set; } = true;
	
	[ContainerField(0x77), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
	public bool CubeMapConvolutionEnable { get; set; } = false;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public bool CompensateSunShadowHeightScale { get; set; } = true;
	
	[ContainerField(0x79), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
	public bool LightMapsEnable { get; set; } = true;
	
	[ContainerField(0x7a), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
	public bool LightProbeEnable { get; set; } = true;
	
	[ContainerField(0x7b), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
	public bool LightProbeNewSamplingEnable { get; set; } = true;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public bool LightProbeForceUpdate { get; set; } = false;
	
	[ContainerField(0x7d), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
	public bool LightProbeJobsEnable { get; set; } = true;
	
	[ContainerField(0x7e), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
	public bool LocalLightsEnable { get; set; } = true;
	
	[ContainerField(0x7f), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
	public bool LocalLightCullingEnable { get; set; } = true;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public bool LocalLightCustumFalloff { get; set; } = false;
	
	[ContainerField(0x81), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
	public bool DrawDebugCubeMaps { get; set; } = false;
	
	[ContainerField(0x82), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
	public bool DrawDebugEntities { get; set; } = false;
	
	[ContainerField(0x83), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
	public bool DrawDebugSystemsEnable { get; set; } = false;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public bool DrawDebugLightProbes { get; set; } = false;
	
	[ContainerField(0x85), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
	public bool DrawDebugLightProbeGrid { get; set; } = false;
	
	[ContainerField(0x86), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
	public bool DrawDebugLightProbeOcclusion { get; set; } = false;
	
	[ContainerField(0x87), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
	public bool DrawDebugLightProbeStats { get; set; } = false;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public bool DrawDebugLightProbeBoundingBoxes { get; set; } = false;
	
	[ContainerField(0x89), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
	public bool DrawSolveTaskPerformance { get; set; } = false;
	
	[ContainerField(0x8a), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
	public bool DrawDebugColoringEnable { get; set; } = false;
	
	[ContainerField(0x8b), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
	public bool DrawDebugTextures { get; set; } = false;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public bool DrawDebugBackFaces { get; set; } = false;
	
	[ContainerField(0x8d), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
	public bool DrawDebugTargetMeshes { get; set; } = true;
	
	[ContainerField(0x8e), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
	public bool DrawWarningsEnable { get; set; } = true;
	
	[ContainerField(0x8f), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
	public bool AlbedoForceUpdateEnable { get; set; } = false;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public bool AlbedoForceColorEnable { get; set; } = false;
	
	[ContainerField(0x91), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
	public bool TerrainMapEnable { get; set; } = true;
	
	[ContainerField(0x92), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
	public bool EmissiveEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		AlbedoDefaultColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TemporalCoherenceThreshold);
		p_Writer.Write(SkyBoxScale);
		p_Writer.Write(MaxPerFrameSolveTime);
		p_Writer.Write(MinSystemUpdateCount);
		p_Writer.Write(JobCount);
		p_Writer.Write(CubeMapMaxUpdateCount);
		p_Writer.Write(CubeMapConvolutionSampleCount);
		p_Writer.Write(CubeMapForceGlobalScale);
		p_Writer.Write(LightProbeMaxSourceSolveCount);
		p_Writer.Write(LightProbeMaxInstanceUpdateCount);
		p_Writer.Write(LightProbeLookupTableGridRes);
		p_Writer.Write(LocalLightForceRadius);
		p_Writer.Write(DrawDebugSystemDependenciesEnable);
		p_Writer.Write(DrawDebugSystemBoundingBoxEnable);
		p_Writer.Write(DrawDebugLightProbeSize);
		p_Writer.Write(Enable);
		p_Writer.Write(ForceDynamic);
		p_Writer.Write(ForceUpdateStaticLightingBuffersEnable);
		p_Writer.Write(AllowLightmapTextureOverride);
		p_Writer.Write(SaveRadiosityTexturesEnable);
		p_Writer.Write(JobsEnable);
		p_Writer.Write(ShadowsEnable);
		p_Writer.Write(SpotLightShadowsEnable);
		p_Writer.Write(CubeMapsEnable);
		p_Writer.Write(CubeMapMip0OnlyEnable);
		p_Writer.Write(CubeMapCpuMipMapGenerationEnable);
		p_Writer.Write(CubeMapConvolutionEnable);
		p_Writer.Write(CompensateSunShadowHeightScale);
		p_Writer.Write(LightMapsEnable);
		p_Writer.Write(LightProbeEnable);
		p_Writer.Write(LightProbeNewSamplingEnable);
		p_Writer.Write(LightProbeForceUpdate);
		p_Writer.Write(LightProbeJobsEnable);
		p_Writer.Write(LocalLightsEnable);
		p_Writer.Write(LocalLightCullingEnable);
		p_Writer.Write(LocalLightCustumFalloff);
		p_Writer.Write(DrawDebugCubeMaps);
		p_Writer.Write(DrawDebugEntities);
		p_Writer.Write(DrawDebugSystemsEnable);
		p_Writer.Write(DrawDebugLightProbes);
		p_Writer.Write(DrawDebugLightProbeGrid);
		p_Writer.Write(DrawDebugLightProbeOcclusion);
		p_Writer.Write(DrawDebugLightProbeStats);
		p_Writer.Write(DrawDebugLightProbeBoundingBoxes);
		p_Writer.Write(DrawSolveTaskPerformance);
		p_Writer.Write(DrawDebugColoringEnable);
		p_Writer.Write(DrawDebugTextures);
		p_Writer.Write(DrawDebugBackFaces);
		p_Writer.Write(DrawDebugTargetMeshes);
		p_Writer.Write(DrawWarningsEnable);
		p_Writer.Write(AlbedoForceUpdateEnable);
		p_Writer.Write(AlbedoForceColorEnable);
		p_Writer.Write(TerrainMapEnable);
		p_Writer.Write(EmissiveEnable);
		p_Writer.WriteNullBytes(13);
	}
}

