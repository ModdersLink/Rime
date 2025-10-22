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

[ContainerType(8, 40)]
public class GameModeSettings
	: fb.Core.SystemSettings
{
	public GameModeSettings()
	{
		//SystemSettings
		Name = @"GameMode";
	}
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<GameModeInformation> Information { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Information = p_EbxWriter.GetArrayWriter(Information.GetType(), Information.Count);
		p_Writer.Write(s_Information.ArrayIndex);
		foreach (var s_Entry in Information)
		{
			s_Entry.Serialize(s_Information.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

