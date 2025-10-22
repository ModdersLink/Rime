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

[ContainerType(8, 64)]
public class MusicOverlayData
	: fb.Audio.MusicPlayableData
{
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<MusicOverlayVariation> Variations { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Variations = p_EbxWriter.GetArrayWriter(Variations.GetType(), Variations.Count);
		p_Writer.Write(s_Variations.ArrayIndex);
		foreach (var s_Entry in Variations)
		{
			s_Entry.Serialize(s_Variations.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

