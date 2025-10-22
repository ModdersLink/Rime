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
public class UIMatchMakingMapPackDescription
	: fb.VeniceShared.UIItemDescription
{
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string Identifier { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string NameSid { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string DescriptionSid { get; set; } = string.Empty;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<string> LevelPaths { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string ImagePath { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Identifier));
		p_Writer.Write(p_EbxWriter.WriteString(NameSid));
		p_Writer.Write(p_EbxWriter.WriteString(DescriptionSid));
		(RimeWriter Writer, uint ArrayIndex) s_LevelPaths = p_EbxWriter.GetArrayWriter(LevelPaths.GetType(), LevelPaths.Count);
		p_Writer.Write(s_LevelPaths.ArrayIndex);
		foreach (var s_Entry in LevelPaths)
		{
			s_LevelPaths.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(ImagePath));
	}
}

