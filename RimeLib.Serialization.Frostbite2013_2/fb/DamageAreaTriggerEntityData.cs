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
public class DamageAreaTriggerEntityData
	: fb.GameShared.TriggerEntityData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float DamagePerSecond { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float DamageTime { get; set; } = 0.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public TeamId TeamOfImmortalCharacters { get; set; } = TeamId.Team1;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public bool DamageCharacters { get; set; } = true;
	
	[ContainerField(0x7d), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
	public bool DamageVehicles { get; set; } = true;
	
	[ContainerField(0x7e), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
	public bool DamageBangers { get; set; } = true;
	
	[ContainerField(0x7f), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
	public bool DamageProjectiles { get; set; } = false;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public bool ExcludeImmortalCharactersInTeam { get; set; } = false;
	
	[ContainerField(0x81), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
	public bool ExcludeShieldedSoldiers { get; set; } = false;
	
	[ContainerField(0x82), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
	public bool IsNeverTriggeredByPlayer { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DamagePerSecond);
		p_Writer.Write(DamageTime);
		p_Writer.Write((int) TeamOfImmortalCharacters);
		p_Writer.Write(DamageCharacters);
		p_Writer.Write(DamageVehicles);
		p_Writer.Write(DamageBangers);
		p_Writer.Write(DamageProjectiles);
		p_Writer.Write(ExcludeImmortalCharactersInTeam);
		p_Writer.Write(ExcludeShieldedSoldiers);
		p_Writer.Write(IsNeverTriggeredByPlayer);
		p_Writer.WriteNullBytes(13);
	}
}

