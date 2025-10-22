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

[ContainerType(8, 64)]
public class NuiSpeechCompiledGrammar
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<NuiSpeechGrammarBundleAsset> GrammarBundle { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Dialect Dialect { get; set; } = fb.VeniceShared.Dialect.Dialect_DE;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<NuiSpeechPhraseVariation> PhraseVariations { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<byte> Data { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint Size { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(GrammarBundle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Dialect);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PhraseVariations = p_EbxWriter.GetArrayWriter(PhraseVariations.GetType(), PhraseVariations.Count);
		p_Writer.Write(s_PhraseVariations.ArrayIndex);
		foreach (var s_Entry in PhraseVariations)
		{
			s_PhraseVariations.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Data = p_EbxWriter.GetArrayWriter(Data.GetType(), Data.Count);
		p_Writer.Write(s_Data.ArrayIndex);
		foreach (var s_Entry in Data)
		{
			s_Data.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Size);
		p_Writer.WriteNullBytes(4);
	}
}

