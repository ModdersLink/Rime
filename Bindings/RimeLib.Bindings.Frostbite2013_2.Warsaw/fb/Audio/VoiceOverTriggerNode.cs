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

[ContainerType(8, 48)]
public class VoiceOverTriggerNode
	: fb.Audio.VoiceOverStructureNode
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<VoiceOverTriggerParameter> Parameters { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float Delay { get; set; } = 0.000f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<VoiceOverEvent> Event { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Parameters = p_EbxWriter.GetArrayWriter(Parameters.GetType(), Parameters.Count);
		p_Writer.Write(s_Parameters.ArrayIndex);
		foreach (var s_Entry in Parameters)
		{
			s_Parameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Delay);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Event));
		p_Writer.WriteNullBytes(4);
	}
}

