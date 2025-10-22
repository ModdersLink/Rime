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

using fb.Entity;
using fb.Audio;
using fb.Core;

namespace fb.GameShared;

[ContainerType(16, 288)]
public class DynamicFireEntityData
	: fb.Entity.GameComponentEntityData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float Width { get; set; } = 10.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float Length { get; set; } = 10.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float Height { get; set; } = 10.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float FireTileSize { get; set; } = 1.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float MaxBurnTime { get; set; } = 25.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float MaxHealth { get; set; } = 25.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float DamagePerSecond { get; set; } = 2.000f;
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<DynamicFireCellFXAsset> CellFXAsset { get; set; } = new();
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public uint FireCellDamageRadius { get; set; } = 2;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float FireCellDamagePerSecond { get; set; } = 15.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public uint MaxDamagingCells { get; set; } = 4;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float StartDamageThreshold { get; set; } = 0.350f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float EndDamageThreshold { get; set; } = 0.900f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public uint MaxFireStarters { get; set; } = 15;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float MinFireStarterRadius { get; set; } = 3.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public uint MaxFiresPerFrame { get; set; } = 1;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public uint MaxBurningCells { get; set; } = 300;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public uint QuadrantCellSize { get; set; } = 6;
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public MaterialDecl MaterialPair { get; set; } = new();
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public uint MaxQuadrantSounds { get; set; } = 4;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public uint LargeFireThreshold { get; set; } = 10;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float LargeFireSortFactor { get; set; } = 0.500f;
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<SoundAsset> LargeFireSound { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public uint MediumFireThreshold { get; set; } = 5;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float MediumFireSortFactor { get; set; } = 0.750f;
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public CtrRef<SoundAsset> MediumFireSound { get; set; } = new();
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public CtrRef<SoundAsset> SmallFireSound { get; set; } = new();
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float MediumInThreshold { get; set; } = 0.100f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float LargeInThreshold { get; set; } = 0.300f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float LargeOutThreshold { get; set; } = 0.600f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float MediumOutThreshold { get; set; } = 0.800f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float SmallFireWeight { get; set; } = 0.250f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float MediumFireWeight { get; set; } = 0.500f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float LargeFireWeight { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Width);
		p_Writer.Write(Length);
		p_Writer.Write(Height);
		p_Writer.Write(FireTileSize);
		p_Writer.Write(MaxBurnTime);
		p_Writer.Write(MaxHealth);
		p_Writer.Write(DamagePerSecond);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CellFXAsset));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FireCellDamageRadius);
		p_Writer.Write(FireCellDamagePerSecond);
		p_Writer.Write(MaxDamagingCells);
		p_Writer.Write(StartDamageThreshold);
		p_Writer.Write(EndDamageThreshold);
		p_Writer.Write(MaxFireStarters);
		p_Writer.Write(MinFireStarterRadius);
		p_Writer.Write(MaxFiresPerFrame);
		p_Writer.Write(MaxBurningCells);
		p_Writer.Write(QuadrantCellSize);
		MaterialPair.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxQuadrantSounds);
		p_Writer.Write(LargeFireThreshold);
		p_Writer.Write(LargeFireSortFactor);
		p_Writer.Write(p_EbxWriter.WriteImport(LargeFireSound));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MediumFireThreshold);
		p_Writer.Write(MediumFireSortFactor);
		p_Writer.Write(p_EbxWriter.WriteImport(MediumFireSound));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SmallFireSound));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MediumInThreshold);
		p_Writer.Write(LargeInThreshold);
		p_Writer.Write(LargeOutThreshold);
		p_Writer.Write(MediumOutThreshold);
		p_Writer.Write(SmallFireWeight);
		p_Writer.Write(MediumFireWeight);
		p_Writer.Write(LargeFireWeight);
		p_Writer.WriteNullBytes(4);
	}
}

