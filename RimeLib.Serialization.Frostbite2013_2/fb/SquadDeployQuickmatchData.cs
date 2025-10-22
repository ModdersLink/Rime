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

namespace fb.VeniceShared;

[ContainerType(8, 32)]
public class SquadDeployQuickmatchData
	: fb.VeniceShared.CustomOptionData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<SquadDeployMapPackData> MapPacks { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_MapPacks = p_EbxWriter.GetArrayWriter(MapPacks.GetType(), MapPacks.Count);
		p_Writer.Write(s_MapPacks.ArrayIndex);
		foreach (var s_Entry in MapPacks)
		{
			s_Entry.Serialize(s_MapPacks.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

