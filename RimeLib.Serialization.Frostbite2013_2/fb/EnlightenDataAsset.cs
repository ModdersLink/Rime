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

[ContainerType(8, 120)]
public class EnlightenDataAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<TextureAsset> DebugChartTexture { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public ResourceRef DatabaseResource { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<TextureAsset> DebugBackFaceTexture { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<TextureAsset> SkyVisibilityTexture { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint SystemGridSize { get; set; } = 64;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int SystemLightmapSize { get; set; } = 128;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public int MaxSystemLightmapSize { get; set; } = 1024;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float SystemInfluenceRadius { get; set; } = 40.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float ClusterSize { get; set; } = 2.500f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public uint IrBudget { get; set; } = 32;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public uint IrradianceQualityMultiplier { get; set; } = 1;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float VisibilityThreshold { get; set; } = 0.250f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float StitchingDistanceMultiplier { get; set; } = -1.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float MaxPixelStitchingAngle { get; set; } = 0.500f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public uint SamplesPerCluster { get; set; } = 32;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public uint MaxCpuThreadCount { get; set; } = 0;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public uint TerrainProbeRes { get; set; } = 5;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool DynamicEnable { get; set; } = true;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public bool LoadDebugData { get; set; } = true;
	
	[ContainerField(0x6e), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
	public bool DynamicXenonEnable { get; set; } = false;
	
	[ContainerField(0x6f), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
	public bool DynamicPs3Enable { get; set; } = false;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool GridBasedSystemGeneration { get; set; } = false;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool VoxelBasedLeafClustering { get; set; } = true;
	
	[ContainerField(0x72), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
	public bool PixelStitchingEnable { get; set; } = true;
	
	[ContainerField(0x73), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
	public bool EdgeStitchingEnable { get; set; } = true;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public bool TerrainEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(DebugChartTexture));
		p_Writer.WriteNullBytes(4);
		DatabaseResource.Serialize(p_Writer);
		p_Writer.Write(p_EbxWriter.WriteImport(DebugBackFaceTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SkyVisibilityTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SystemGridSize);
		p_Writer.Write(SystemLightmapSize);
		p_Writer.Write(MaxSystemLightmapSize);
		p_Writer.Write(SystemInfluenceRadius);
		p_Writer.Write(ClusterSize);
		p_Writer.Write(IrBudget);
		p_Writer.Write(IrradianceQualityMultiplier);
		p_Writer.Write(VisibilityThreshold);
		p_Writer.Write(StitchingDistanceMultiplier);
		p_Writer.Write(MaxPixelStitchingAngle);
		p_Writer.Write(SamplesPerCluster);
		p_Writer.Write(MaxCpuThreadCount);
		p_Writer.Write(TerrainProbeRes);
		p_Writer.Write(DynamicEnable);
		p_Writer.Write(LoadDebugData);
		p_Writer.Write(DynamicXenonEnable);
		p_Writer.Write(DynamicPs3Enable);
		p_Writer.Write(GridBasedSystemGeneration);
		p_Writer.Write(VoxelBasedLeafClustering);
		p_Writer.Write(PixelStitchingEnable);
		p_Writer.Write(EdgeStitchingEnable);
		p_Writer.Write(TerrainEnable);
		p_Writer.WriteNullBytes(3);
	}
}

