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

namespace fb.SpartaShared;

[ContainerType(8, 32)]
public class SpartaPresenceBackendData
	: fb.Online.PresenceBackendData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<SpartaPs4Service> Services { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Services = p_EbxWriter.GetArrayWriter(Services.GetType(), Services.Count);
		p_Writer.Write(s_Services.ArrayIndex);
		foreach (var s_Entry in Services)
		{
			s_Entry.Serialize(s_Services.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

