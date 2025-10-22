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

namespace fb.Audio;

[ContainerType(8, 56)]
public class AudioGraphData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<AudioGraphNodeData> Nodes { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<AudioGraphParameter> PublicParameters { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<AudioGraphEvent> PublicEvents { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<AudioGraphAssetParameter> PublicAssetParameters { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public ushort PublicValueCount { get; set; } = 0;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public ushort ValueCount { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Nodes = p_EbxWriter.GetArrayWriter(Nodes.GetType(), Nodes.Count);
		p_Writer.Write(s_Nodes.ArrayIndex);
		foreach (var s_Entry in Nodes)
		{
			s_Nodes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PublicParameters = p_EbxWriter.GetArrayWriter(PublicParameters.GetType(), PublicParameters.Count);
		p_Writer.Write(s_PublicParameters.ArrayIndex);
		foreach (var s_Entry in PublicParameters)
		{
			s_PublicParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PublicEvents = p_EbxWriter.GetArrayWriter(PublicEvents.GetType(), PublicEvents.Count);
		p_Writer.Write(s_PublicEvents.ArrayIndex);
		foreach (var s_Entry in PublicEvents)
		{
			s_PublicEvents.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PublicAssetParameters = p_EbxWriter.GetArrayWriter(PublicAssetParameters.GetType(), PublicAssetParameters.Count);
		p_Writer.Write(s_PublicAssetParameters.ArrayIndex);
		foreach (var s_Entry in PublicAssetParameters)
		{
			s_PublicAssetParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(PublicValueCount);
		p_Writer.Write(ValueCount);
		p_Writer.WriteNullBytes(4);
	}
}

