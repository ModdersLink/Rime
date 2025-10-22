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

namespace fb.Online;

[ContainerType(8, 48)]
public class BlazePresenceBackendData
	: fb.Online.PresenceBackendData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string DefaultRoleName { get; set; } = string.Empty;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<MatchmakingSession> MatchmakingSessions { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool UseDemanglerService { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(DefaultRoleName));
		(RimeWriter Writer, uint ArrayIndex) s_MatchmakingSessions = p_EbxWriter.GetArrayWriter(MatchmakingSessions.GetType(), MatchmakingSessions.Count);
		p_Writer.Write(s_MatchmakingSessions.ArrayIndex);
		foreach (var s_Entry in MatchmakingSessions)
		{
			s_MatchmakingSessions.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(UseDemanglerService);
		p_Writer.WriteNullBytes(7);
	}
}

