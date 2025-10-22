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
using fb.GameShared;

namespace fb.Venice;

[ContainerType(8, 40)]
public class LogLinesMessageEntityInfo
	: fb.GameShared.MessageEntityInfo
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string MessageSid { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float DisplayTime { get; set; } = 5.000f;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<MessageLineData> AdditionalMessages { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(MessageSid));
		p_Writer.Write(DisplayTime);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_AdditionalMessages = p_EbxWriter.GetArrayWriter(AdditionalMessages.GetType(), AdditionalMessages.Count);
		p_Writer.Write(s_AdditionalMessages.ArrayIndex);
		foreach (var s_Entry in AdditionalMessages)
		{
			s_Entry.Serialize(s_AdditionalMessages.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

