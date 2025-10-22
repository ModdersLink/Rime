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
public class EmitterData
	: fb.Emitter.ProcessorData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<EmitterDocument> EmitterAssets { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_EmitterAssets = p_EbxWriter.GetArrayWriter(EmitterAssets.GetType(), EmitterAssets.Count);
		p_Writer.Write(s_EmitterAssets.ArrayIndex);
		foreach (var s_Entry in EmitterAssets)
		{
			s_EmitterAssets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

