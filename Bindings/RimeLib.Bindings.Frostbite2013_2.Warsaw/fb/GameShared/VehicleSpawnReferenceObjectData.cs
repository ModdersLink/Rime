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

[ContainerType(16, 432)]
public class VehicleSpawnReferenceObjectData
	: fb.GameShared.SpawnReferenceObjectData
{
	public VehicleSpawnReferenceObjectData()
	{
		//SpawnReferenceObjectData
		SpawnAreaRadius = 2.500f;
		InitialAutoSpawn = true;
	}
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public float WreckDuration { get; set; } = 0.000f;
	
	[ContainerField(0x174), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
	public EntryEnterRestriction EnterRestriction { get; set; } = EntryEnterRestriction.EntryEnterRestriction_OnlyPrimaryEntry;
	
	[ContainerField(0x178), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
	public float BotBailWhenHealthBelow { get; set; } = 0.000f;
	
	[ContainerField(0x17c), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
	public float BotBailOutDelay { get; set; } = 0.500f;
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public float RespawnRange { get; set; } = 15.000f;
	
	[ContainerField(0x184), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
	public float TimeUntilAbandoned { get; set; } = 10.000f;
	
	[ContainerField(0x188), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
	public float TimeUntilAbandonedIsDestroyed { get; set; } = 10.000f;
	
	[ContainerField(0x18c), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
	public float KeepAliveRadius { get; set; } = 50.000f;
	
	[ContainerField(0x190), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
	public int ActiveStanceEntryIndex { get; set; } = 0;
	
	[ContainerField(0x194), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
	public int ActiveStance { get; set; } = 0;
	
	[ContainerField(0x198), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
	public float VehicleIsNearDistance { get; set; } = 0.000f;
	
	[ContainerField(0x19c), LayoutImmutable, Blittable, JsonProperty(Order = 412)]
	public bool SetTeamOnSpawn { get; set; } = false;
	
	[ContainerField(0x19d), LayoutImmutable, Blittable, JsonProperty(Order = 413)]
	public bool AffectedByImpulse { get; set; } = true;
	
	[ContainerField(0x19e), LayoutImmutable, Blittable, JsonProperty(Order = 414)]
	public bool AIAllowedToFollowHumanInVehicle { get; set; } = true;
	
	[ContainerField(0x19f), LayoutImmutable, Blittable, JsonProperty(Order = 415)]
	public bool AIUseExitPoints { get; set; } = true;
	
	[ContainerField(0x1a0), LayoutImmutable, Blittable, JsonProperty(Order = 416)]
	public bool ApplyDamageToAbandonedVehicles { get; set; } = false;
	
	[ContainerField(0x1a1), LayoutImmutable, Blittable, JsonProperty(Order = 417)]
	public bool EnableAvailableSeatOutput { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WreckDuration);
		p_Writer.Write((int) EnterRestriction);
		p_Writer.Write(BotBailWhenHealthBelow);
		p_Writer.Write(BotBailOutDelay);
		p_Writer.Write(RespawnRange);
		p_Writer.Write(TimeUntilAbandoned);
		p_Writer.Write(TimeUntilAbandonedIsDestroyed);
		p_Writer.Write(KeepAliveRadius);
		p_Writer.Write(ActiveStanceEntryIndex);
		p_Writer.Write(ActiveStance);
		p_Writer.Write(VehicleIsNearDistance);
		p_Writer.Write(SetTeamOnSpawn);
		p_Writer.Write(AffectedByImpulse);
		p_Writer.Write(AIAllowedToFollowHumanInVehicle);
		p_Writer.Write(AIUseExitPoints);
		p_Writer.Write(ApplyDamageToAbandonedVehicles);
		p_Writer.Write(EnableAvailableSeatOutput);
		p_Writer.WriteNullBytes(14);
	}
}

