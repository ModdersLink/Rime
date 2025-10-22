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

[ContainerType(16, 128)]
public class ClearAreaTriggerEntityData
	: fb.GameShared.TriggerEntityData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public TeamId TeamOfImmortalSoldiers { get; set; } = TeamId.Team1;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public bool RemoveSoldiers { get; set; } = true;
	
	[ContainerField(0x75), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
	public bool RemoveVehicles { get; set; } = true;
	
	[ContainerField(0x76), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
	public bool RemoveBangers { get; set; } = true;
	
	[ContainerField(0x77), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
	public bool RemoveEffects { get; set; } = true;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public bool RemoveMeshProxies { get; set; } = true;
	
	[ContainerField(0x79), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
	public bool RemoveStaticModels { get; set; } = true;
	
	[ContainerField(0x7a), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
	public bool RemoveDebrisClusters { get; set; } = true;
	
	[ContainerField(0x7b), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
	public bool ExcludeImmortalSoldiersInTeam { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) TeamOfImmortalSoldiers);
		p_Writer.Write(RemoveSoldiers);
		p_Writer.Write(RemoveVehicles);
		p_Writer.Write(RemoveBangers);
		p_Writer.Write(RemoveEffects);
		p_Writer.Write(RemoveMeshProxies);
		p_Writer.Write(RemoveStaticModels);
		p_Writer.Write(RemoveDebrisClusters);
		p_Writer.Write(ExcludeImmortalSoldiersInTeam);
		p_Writer.WriteNullBytes(4);
	}
}

