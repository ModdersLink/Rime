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

namespace fb.GameShared;

[ContainerType(8, 96)]
public class SoundSettings
	: fb.Core.SystemSettings
{
	public SoundSettings()
	{
		//SystemSettings
		Name = @"Sound";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string AudioSystemUri { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string VOCommon { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string VOEnglish { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string VOSpanish { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string VOFrench { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string VOGerman { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string VOItalian { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public bool Enable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(AudioSystemUri));
		p_Writer.Write(p_EbxWriter.WriteString(VOCommon));
		p_Writer.Write(p_EbxWriter.WriteString(VOEnglish));
		p_Writer.Write(p_EbxWriter.WriteString(VOSpanish));
		p_Writer.Write(p_EbxWriter.WriteString(VOFrench));
		p_Writer.Write(p_EbxWriter.WriteString(VOGerman));
		p_Writer.Write(p_EbxWriter.WriteString(VOItalian));
		p_Writer.Write(Enable);
		p_Writer.WriteNullBytes(7);
	}
}

