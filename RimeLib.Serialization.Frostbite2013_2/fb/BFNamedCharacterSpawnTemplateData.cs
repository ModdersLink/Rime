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
using fb.GameShared;
using fb.Audio;

namespace fb.VeniceShared;

[ContainerType(8, 80)]
public class BFNamedCharacterSpawnTemplateData
	: fb.GameShared.CharacterSpawnTemplateData
{
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string DisplayName { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool OnHumanSquad { get; set; } = false;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool IsSquadLeader { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(DisplayName));
		p_Writer.Write(OnHumanSquad);
		p_Writer.Write(IsSquadLeader);
		p_Writer.WriteNullBytes(6);
	}
}

