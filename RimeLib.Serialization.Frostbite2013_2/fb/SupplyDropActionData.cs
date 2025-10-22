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
public class SupplyDropActionData
	: fb.VeniceShared.CommanderActionBaseData
{
	public SupplyDropActionData()
	{
		//CommanderActionBaseData
		ActionType = CommanderActionType.CommanderActionType_SupplyDrop;
	}
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<PrefabBlueprint> CratePrefabBlueprint { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float CrateTimeToLive { get; set; } = 300.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(CratePrefabBlueprint));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CrateTimeToLive);
		p_Writer.WriteNullBytes(4);
	}
}

