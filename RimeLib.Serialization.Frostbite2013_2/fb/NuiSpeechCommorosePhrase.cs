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

[ContainerType(8, 80)]
public class NuiSpeechCommorosePhrase
	: fb.VeniceShared.NuiSpeechPhrase
{
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string CommoRoseButton { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public NuiSpeechCommoroseApplicabilityCondition ApplicabilityCondition { get; set; } = NuiSpeechCommoroseApplicabilityCondition.NuiSpeechCommoroseApplicabilityCondition_Always;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(CommoRoseButton));
		p_Writer.Write((int) ApplicabilityCondition);
		p_Writer.WriteNullBytes(4);
	}
}

