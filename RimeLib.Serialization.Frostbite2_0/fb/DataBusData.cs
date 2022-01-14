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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class DataBusData :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<PropertyConnection> PropertyConnections { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<LinkConnection> LinkConnections { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_PropertyConnections = p_EbxWriter.GetArrayWriter(PropertyConnections.GetType(), PropertyConnections.Count);
			p_Writer.Write(s_PropertyConnections.ArrayIndex);
			foreach (var s_Entry in PropertyConnections)
			{
				s_Entry.Serialize(s_PropertyConnections.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_LinkConnections = p_EbxWriter.GetArrayWriter(LinkConnections.GetType(), LinkConnections.Count);
			p_Writer.Write(s_LinkConnections.ArrayIndex);
			foreach (var s_Entry in LinkConnections)
			{
				s_Entry.Serialize(s_LinkConnections.Writer, p_EbxWriter);
			}
		}
	}
}
