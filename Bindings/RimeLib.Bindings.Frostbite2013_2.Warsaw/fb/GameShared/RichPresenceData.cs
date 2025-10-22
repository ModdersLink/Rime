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

[ContainerType(8, 64)]
public class RichPresenceData
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<RichPresencePresenceString> PresenceModes { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<RichPresencePresenceString> DefaultMode { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<RichPresencePresenceString> InactiveMode { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<RichPresenceContext> Contexts { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<RichPresenceProperty> Properties { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_PresenceModes = p_EbxWriter.GetArrayWriter(PresenceModes.GetType(), PresenceModes.Count);
		p_Writer.Write(s_PresenceModes.ArrayIndex);
		foreach (var s_Entry in PresenceModes)
		{
			s_PresenceModes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultMode));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(InactiveMode));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Contexts = p_EbxWriter.GetArrayWriter(Contexts.GetType(), Contexts.Count);
		p_Writer.Write(s_Contexts.ArrayIndex);
		foreach (var s_Entry in Contexts)
		{
			s_Contexts.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Properties = p_EbxWriter.GetArrayWriter(Properties.GetType(), Properties.Count);
		p_Writer.Write(s_Properties.ArrayIndex);
		foreach (var s_Entry in Properties)
		{
			s_Entry.Serialize(s_Properties.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

