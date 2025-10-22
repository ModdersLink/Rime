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

[ContainerType(16, 144)]
public class CombatAreaTriggerEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public uint TimeToReturn { get; set; } = 10;
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<BulletEntityData> DeserterProjectile { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float SpawnHeight { get; set; } = 50.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float MaxRandomSpawnHeight { get; set; } = 100.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float StrikeRadius { get; set; } = 5.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float InitalSpeed { get; set; } = 100.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public TeamId Team { get; set; } = TeamId.TeamNeutral;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public bool IsAiAllowedOutside { get; set; } = true;
	
	[ContainerField(0x85), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
	public bool IsTeamSpecific { get; set; } = false;
	
	[ContainerField(0x86), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
	public bool Enabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TimeToReturn);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DeserterProjectile));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SpawnHeight);
		p_Writer.Write(MaxRandomSpawnHeight);
		p_Writer.Write(StrikeRadius);
		p_Writer.Write(InitalSpeed);
		p_Writer.Write((int) Team);
		p_Writer.Write(IsAiAllowedOutside);
		p_Writer.Write(IsTeamSpecific);
		p_Writer.Write(Enabled);
		p_Writer.WriteNullBytes(9);
	}
}

