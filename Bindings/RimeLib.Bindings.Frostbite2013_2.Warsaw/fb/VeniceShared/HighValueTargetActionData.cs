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

[ContainerType(8, 56)]
public class HighValueTargetActionData
	: fb.VeniceShared.CommanderActionBaseData
{
	public HighValueTargetActionData()
	{
		//CommanderActionBaseData
		ActionType = CommanderActionType.CommanderActionType_HighValueTarget;
	}
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<PrefabBlueprint> HVTPrefabBlueprint { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(HVTPrefabBlueprint));
		p_Writer.WriteNullBytes(4);
	}
}

