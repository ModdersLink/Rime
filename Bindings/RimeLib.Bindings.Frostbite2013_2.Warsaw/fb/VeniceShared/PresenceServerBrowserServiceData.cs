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
using fb.Online;

namespace fb.VeniceShared;

[ContainerType(8, 144)]
public class PresenceServerBrowserServiceData
	: fb.Online.PresenceServiceData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public MatchmakingCriteria FilterCriterias { get; set; } = new();
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public uint ListCapacity { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		FilterCriterias.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ListCapacity);
		p_Writer.WriteNullBytes(4);
	}
}

