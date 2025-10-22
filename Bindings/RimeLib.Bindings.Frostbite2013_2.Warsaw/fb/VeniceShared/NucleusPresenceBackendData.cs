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
public class NucleusPresenceBackendData
	: fb.Online.PresenceBackendData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<NucleusEnvironmentConfiguration> Environments { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<NucleusPlatformConfiguration> Platforms { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Environments = p_EbxWriter.GetArrayWriter(Environments.GetType(), Environments.Count);
		p_Writer.Write(s_Environments.ArrayIndex);
		foreach (var s_Entry in Environments)
		{
			s_Entry.Serialize(s_Environments.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Platforms = p_EbxWriter.GetArrayWriter(Platforms.GetType(), Platforms.Count);
		p_Writer.Write(s_Platforms.ArrayIndex);
		foreach (var s_Entry in Platforms)
		{
			s_Entry.Serialize(s_Platforms.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

