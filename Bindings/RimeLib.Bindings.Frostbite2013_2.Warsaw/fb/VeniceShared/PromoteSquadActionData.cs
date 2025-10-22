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

[ContainerType(8, 56)]
public class PromoteSquadActionData
	: fb.VeniceShared.CommanderActionBaseData
{
	public PromoteSquadActionData()
	{
		//CommanderActionBaseData
		ActionType = CommanderActionType.CommanderActionType_PromoteSquad;
	}
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int ScoreAmount { get; set; } = 10;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ScoreAmount);
		p_Writer.WriteNullBytes(4);
	}
}

