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
public class NuiSpeechPhrase
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string Tag { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public int NumericId { get; set; } = 0;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public NuiSpeechPhraseType PhraseType { get; set; } = NuiSpeechPhraseType.NuiSpeechPhraseType_InputAction;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string SuccessMessage { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string Description { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public NuiSpeechPhraseHintMode DescriptionMode { get; set; } = NuiSpeechPhraseHintMode.NuiSpeechPhraseType_Always;
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<NuiSpeechConfidencePolicySetup> ConfidencePolicy { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Tag));
		p_Writer.Write(NumericId);
		p_Writer.Write((int) PhraseType);
		p_Writer.Write(p_EbxWriter.WriteString(SuccessMessage));
		p_Writer.Write(p_EbxWriter.WriteString(Description));
		p_Writer.Write((int) DescriptionMode);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ConfidencePolicy));
		p_Writer.WriteNullBytes(4);
	}
}

