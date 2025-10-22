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
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 80)]
public class SectorJamActionData
	: fb.VeniceShared.CommanderActionBaseData
{
	public SectorJamActionData()
	{
		//CommanderActionBaseData
		ActionType = CommanderActionType.CommanderActionType_SectorJam;
	}
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float JamRadius { get; set; } = 50.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float DamagePulseFrequency { get; set; } = 1.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float EMPGunshipDamagePerSecond { get; set; } = 1000.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float EMPTomahawkDamagePerSecond { get; set; } = 1000.000f;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<PrefabBlueprint> EMPDronePrefabBlueprint { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float PrefabSpawnHeightOffset { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(JamRadius);
		p_Writer.Write(DamagePulseFrequency);
		p_Writer.Write(EMPGunshipDamagePerSecond);
		p_Writer.Write(EMPTomahawkDamagePerSecond);
		p_Writer.Write(p_EbxWriter.WriteImport(EMPDronePrefabBlueprint));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(PrefabSpawnHeightOffset);
		p_Writer.WriteNullBytes(4);
	}
}

