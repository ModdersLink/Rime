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

namespace fb.Emitter;

[ContainerType(8, 48)]
public class UpdateClipScaleData
	: fb.Emitter.ProcessorData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<short> Lookup { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Lookup = p_EbxWriter.GetArrayWriter(Lookup.GetType(), Lookup.Count);
		p_Writer.Write(s_Lookup.ArrayIndex);
		foreach (var s_Entry in Lookup)
		{
			s_Lookup.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
	}
}

