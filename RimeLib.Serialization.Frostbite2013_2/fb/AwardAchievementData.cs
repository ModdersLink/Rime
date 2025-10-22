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
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 176)]
public class AwardAchievementData
	: fb.VeniceShared.AwardData
{
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public DurangoAchievementSettings DurangoSpecific { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		DurangoSpecific.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
	}
}

