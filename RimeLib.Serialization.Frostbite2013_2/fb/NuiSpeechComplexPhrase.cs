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

[ContainerType(8, 72)]
public class NuiSpeechComplexPhrase
	: fb.VeniceShared.NuiSpeechPhrase
{
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public RefArray<NuiSpeechPhraseComponent> PhraseComponents { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_PhraseComponents = p_EbxWriter.GetArrayWriter(PhraseComponents.GetType(), PhraseComponents.Count);
		p_Writer.Write(s_PhraseComponents.ArrayIndex);
		foreach (var s_Entry in PhraseComponents)
		{
			s_PhraseComponents.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

