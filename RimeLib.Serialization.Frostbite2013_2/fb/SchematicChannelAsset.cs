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

namespace fb.Entity;

[ContainerType(8, 48)]
public class SchematicChannelAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<EventChannel> Events { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<LinkChannel> Links { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<PropertyChannel> Properties { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Events = p_EbxWriter.GetArrayWriter(Events.GetType(), Events.Count);
		p_Writer.Write(s_Events.ArrayIndex);
		foreach (var s_Entry in Events)
		{
			s_Entry.Serialize(s_Events.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Links = p_EbxWriter.GetArrayWriter(Links.GetType(), Links.Count);
		p_Writer.Write(s_Links.ArrayIndex);
		foreach (var s_Entry in Links)
		{
			s_Entry.Serialize(s_Links.Writer, p_EbxWriter);
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

