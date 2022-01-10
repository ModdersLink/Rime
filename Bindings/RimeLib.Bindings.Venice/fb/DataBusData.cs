///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class DataBusData : 
		Asset
	{
		[ContainerField(12)]
		public List<PropertyConnection> PropertyConnections { get; set; } = new();

		[ContainerField(16)]
		public List<LinkConnection> LinkConnections { get; set; } = new();

		public static void Deserialize(DataBusData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PropertyConnections.Clear();
			(RimeReader Reader, uint Count) s_PropertyConnections = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PropertyConnections.Count; ++i)
			{
				var s_Value = new PropertyConnection();
				fb.PropertyConnection.Deserialize(s_Value, s_PropertyConnections.Reader, p_Parser);
				p_Instance.PropertyConnections.Add(s_Value);
			}
			
			s_PropertyConnections.Reader.Dispose();
			p_Instance.LinkConnections.Clear();
			(RimeReader Reader, uint Count) s_LinkConnections = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LinkConnections.Count; ++i)
			{
				var s_Value = new LinkConnection();
				fb.LinkConnection.Deserialize(s_Value, s_LinkConnections.Reader, p_Parser);
				p_Instance.LinkConnections.Add(s_Value);
			}
			
			s_LinkConnections.Reader.Dispose();
		}

	}
}
