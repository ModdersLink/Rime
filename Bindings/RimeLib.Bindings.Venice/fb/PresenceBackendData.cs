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
	public class PresenceBackendData : 
		Asset
	{
		[ContainerField(12)]
		public List<PresenceRequest> Requests { get; set; } = new();

		public static void Deserialize(PresenceBackendData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Requests.Clear();
			(RimeReader Reader, uint Count) s_Requests = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Requests.Count; ++i)
			{
				var s_Value = (PresenceRequest) s_Requests.Reader.ReadInt32();
				p_Instance.Requests.Add(s_Value);
			}
			
			s_Requests.Reader.Dispose();
		}

	}
}
