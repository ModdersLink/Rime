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

namespace fb.VeniceShared;

[ContainerType(8, 64)]
public class GunshipDeployActionData
	: fb.VeniceShared.CommanderActionBaseData
{
	public GunshipDeployActionData()
	{
		//CommanderActionBaseData
		ActionType = CommanderActionType.CommanderActionType_GunshipDeploy;
		ExecutionDuration = -1.000f;
	}
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<PrefabBlueprint> GunshipPrefabBlueprint { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float DamageFromEnemyOwnershipFrequency { get; set; } = 1.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float DamageFromEnemyOwnershipPerSecond { get; set; } = 100.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(GunshipPrefabBlueprint));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DamageFromEnemyOwnershipFrequency);
		p_Writer.Write(DamageFromEnemyOwnershipPerSecond);
	}
}

