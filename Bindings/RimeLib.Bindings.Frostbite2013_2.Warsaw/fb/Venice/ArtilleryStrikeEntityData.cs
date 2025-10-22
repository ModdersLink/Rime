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
using fb.GameShared;
using fb.Entity;

namespace fb.Venice;

[ContainerType(16, 160)]
public class ArtilleryStrikeEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<MissileEntityData> MissileData { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float MissileSpawnRadius { get; set; } = 5.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float DurationOfArtilleryStrike { get; set; } = 0.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float MaxDelayBetweenProjectiles { get; set; } = 1.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float MinDelayBetweenProjectiles { get; set; } = 1.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float MaxDelayBetweenStrikes { get; set; } = 1.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float MinDelayBetweenStrikes { get; set; } = 1.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float MinRadiusToSoldier { get; set; } = 0.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float RadiusWhenFollowingSoldier { get; set; } = 10.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float HeightOffsetWhenFollowingSoldier { get; set; } = 50.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public uint NumberOfStrikes { get; set; } = 0;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public uint MaxProjectilesPerStrike { get; set; } = 1;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public uint MinProjectilesPerStrike { get; set; } = 1;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public bool FollowSoldier { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(MissileData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MissileSpawnRadius);
		p_Writer.Write(DurationOfArtilleryStrike);
		p_Writer.Write(MaxDelayBetweenProjectiles);
		p_Writer.Write(MinDelayBetweenProjectiles);
		p_Writer.Write(MaxDelayBetweenStrikes);
		p_Writer.Write(MinDelayBetweenStrikes);
		p_Writer.Write(MinRadiusToSoldier);
		p_Writer.Write(RadiusWhenFollowingSoldier);
		p_Writer.Write(HeightOffsetWhenFollowingSoldier);
		p_Writer.Write(NumberOfStrikes);
		p_Writer.Write(MaxProjectilesPerStrike);
		p_Writer.Write(MinProjectilesPerStrike);
		p_Writer.Write(FollowSoldier);
		p_Writer.WriteNullBytes(7);
	}
}

