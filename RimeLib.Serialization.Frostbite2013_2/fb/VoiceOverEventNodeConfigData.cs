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

namespace fb.Audio;

[ContainerType(8, 40)]
public class VoiceOverEventNodeConfigData
	: fb.Audio.VoiceOverNodeConfigData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<VoiceOverValueRedirect> Redirects { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<VoiceOverEvent> Event { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Redirects = p_EbxWriter.GetArrayWriter(Redirects.GetType(), Redirects.Count);
		p_Writer.Write(s_Redirects.ArrayIndex);
		foreach (var s_Entry in Redirects)
		{
			s_Redirects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Event));
		p_Writer.WriteNullBytes(4);
	}
}

