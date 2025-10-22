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


namespace fb.Core;

[ContainerType(8, 56)]
public class DataBusData
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<PropertyConnection> PropertyConnections { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<LinkConnection> LinkConnections { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<DynamicDataContainer> Interface { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public ushort Flags { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_PropertyConnections = p_EbxWriter.GetArrayWriter(PropertyConnections.GetType(), PropertyConnections.Count);
		p_Writer.Write(s_PropertyConnections.ArrayIndex);
		foreach (var s_Entry in PropertyConnections)
		{
			s_Entry.Serialize(s_PropertyConnections.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LinkConnections = p_EbxWriter.GetArrayWriter(LinkConnections.GetType(), LinkConnections.Count);
		p_Writer.Write(s_LinkConnections.ArrayIndex);
		foreach (var s_Entry in LinkConnections)
		{
			s_Entry.Serialize(s_LinkConnections.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Interface));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Flags);
		p_Writer.WriteNullBytes(6);
	}
}

