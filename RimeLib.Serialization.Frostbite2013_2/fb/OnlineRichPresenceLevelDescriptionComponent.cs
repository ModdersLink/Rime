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

using fb.GameShared;
using fb.Core;

namespace fb.Online;

[ContainerType(8, 32)]
public class OnlineRichPresenceLevelDescriptionComponent
	: fb.GameShared.LevelDescriptionComponent
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<RichPresencePresenceString> PresenceMode { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<RichPresenceContextSetting> ContextValues { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(PresenceMode));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ContextValues = p_EbxWriter.GetArrayWriter(ContextValues.GetType(), ContextValues.Count);
		p_Writer.Write(s_ContextValues.ArrayIndex);
		foreach (var s_Entry in ContextValues)
		{
			s_Entry.Serialize(s_ContextValues.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

