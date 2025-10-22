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

using fb.Online;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 40)]
public class PresenceGameConfigurationServiceData
	: fb.Online.PresenceServiceData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public OnlineEnvironmentConsoleUrl ConfigUrl { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<GameConfigurationContentMapping> ContentMappings { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		ConfigUrl.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ContentMappings = p_EbxWriter.GetArrayWriter(ContentMappings.GetType(), ContentMappings.Count);
		p_Writer.Write(s_ContentMappings.ArrayIndex);
		foreach (var s_Entry in ContentMappings)
		{
			s_Entry.Serialize(s_ContentMappings.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

