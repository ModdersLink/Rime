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

namespace fb.Online;

[ContainerType(8, 64)]
public class Ps4PresenceBackendData
	: fb.Online.PresenceBackendData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public Ps4TitleData DefaultTitleData { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<Ps4TitleData> TitleData { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public Ps4AgeSettings AgeSettings { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		DefaultTitleData.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_TitleData = p_EbxWriter.GetArrayWriter(TitleData.GetType(), TitleData.Count);
		p_Writer.Write(s_TitleData.ArrayIndex);
		foreach (var s_Entry in TitleData)
		{
			s_Entry.Serialize(s_TitleData.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		AgeSettings.Serialize(p_Writer, p_EbxWriter);
	}
}

