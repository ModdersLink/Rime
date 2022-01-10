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
	[ContainerType(4, 16)]
	public class ServerBackendData : 
		Asset
	{
		[ContainerField(12)]
		public List<ServerBackendAttributeMapping> Mappings { get; set; } = new();

		public static void Deserialize(ServerBackendData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Mappings.Clear();
			(RimeReader Reader, uint Count) s_Mappings = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Mappings.Count; ++i)
			{
				var s_Value = new ServerBackendAttributeMapping();
				fb.ServerBackendAttributeMapping.Deserialize(s_Value, s_Mappings.Reader, p_Parser);
				p_Instance.Mappings.Add(s_Value);
			}
			
			s_Mappings.Reader.Dispose();
		}

	}
}
