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

[ContainerType(8, 64)]
public class VehicleSpawnActionData
	: fb.VeniceShared.CommanderActionBaseData
{
	public VehicleSpawnActionData()
	{
		//CommanderActionBaseData
		ActionType = CommanderActionType.CommanderActionType_VehicleSpawn;
	}
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<PrefabBlueprint> LandVehiclePrefabBlueprint { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<PrefabBlueprint> SeaVehiclePrefabBlueprint { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(LandVehiclePrefabBlueprint));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SeaVehiclePrefabBlueprint));
		p_Writer.WriteNullBytes(4);
	}
}

