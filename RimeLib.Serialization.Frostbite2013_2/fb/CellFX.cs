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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 176)]
public class CellFX
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public QualityScalableFloat SpawnProbability { get; set; } = new()
	{
		Ultra = 0.500f,
		High = 0.500f,
		Medium = 0.500f,
		Low = 0.500f,
	};
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public QualityScalableInt MinSpawnCount { get; set; } = new()
	{
		Ultra = 1,
		High = 1,
		Medium = 1,
		Low = 1,
	};
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public QualityScalableInt MaxSpawnCount { get; set; } = new()
	{
		Ultra = 1,
		High = 1,
		Medium = 1,
		Low = 1,
	};
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float PeakBurnPercent { get; set; } = 0.500f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float MinPeakFlickerPercent { get; set; } = 0.250f;
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec3 MinSpawnScale { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 MaxSpawnScale { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float MaxPeakFlickerPercent { get; set; } = 0.250f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float MinFlickerAmplitude { get; set; } = 0.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float MaxFlickerAmplitude { get; set; } = 0.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float MinFlickerFreq { get; set; } = 0.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float MaxFlickerFreq { get; set; } = 0.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float SpawnScaleMultiplierX { get; set; } = 1.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float SpawnScaleMultiplierY { get; set; } = 0.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float SpawnScaleMultiplierZ { get; set; } = 1.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float PeakGrowthPercent { get; set; } = 0.500f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float GrowthOffset { get; set; } = 0.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float BurnTimeMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<ObjectBlueprint> EffectMesh { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public QualityScalableBool Enabled { get; set; } = new()
	{
		Ultra = true,
		High = true,
		Medium = true,
		Low = true,
	};
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public bool AlignToTerrainNormal { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		SpawnProbability.Serialize(p_Writer, p_EbxWriter);
		MinSpawnCount.Serialize(p_Writer, p_EbxWriter);
		MaxSpawnCount.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PeakBurnPercent);
		p_Writer.Write(MinPeakFlickerPercent);
		p_Writer.WriteNullBytes(8);
		MinSpawnScale.Serialize(p_Writer, p_EbxWriter);
		MaxSpawnScale.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxPeakFlickerPercent);
		p_Writer.Write(MinFlickerAmplitude);
		p_Writer.Write(MaxFlickerAmplitude);
		p_Writer.Write(MinFlickerFreq);
		p_Writer.Write(MaxFlickerFreq);
		p_Writer.Write(SpawnScaleMultiplierX);
		p_Writer.Write(SpawnScaleMultiplierY);
		p_Writer.Write(SpawnScaleMultiplierZ);
		p_Writer.Write(PeakGrowthPercent);
		p_Writer.Write(GrowthOffset);
		p_Writer.Write(BurnTimeMultiplier);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(EffectMesh));
		p_Writer.WriteNullBytes(4);
		Enabled.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AlignToTerrainNormal);
		p_Writer.WriteNullBytes(3);
	}
}

