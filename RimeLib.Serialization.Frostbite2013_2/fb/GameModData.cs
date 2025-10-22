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
public class GameModData
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<BFModMaskMapping> ModMaskMappings { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ModMaskMappings = p_EbxWriter.GetArrayWriter(ModMaskMappings.GetType(), ModMaskMappings.Count);
		p_Writer.Write(s_ModMaskMappings.ArrayIndex);
		foreach (var s_Entry in ModMaskMappings)
		{
			s_Entry.Serialize(s_ModMaskMappings.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

