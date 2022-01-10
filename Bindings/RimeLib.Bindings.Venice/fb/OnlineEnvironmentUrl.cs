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
	[ContainerType(4, 4)]
	public class OnlineEnvironmentUrl
	{
		[ContainerField(0)]
		public List<OnlineEnvironmentUrlData> Urls { get; set; } = new();
		
		public static void Deserialize(OnlineEnvironmentUrl p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Urls.Clear();
			(RimeReader Reader, uint Count) s_Urls = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Urls.Count; ++i)
			{
				var s_Value = new OnlineEnvironmentUrlData();
				fb.OnlineEnvironmentUrlData.Deserialize(s_Value, s_Urls.Reader, p_Parser);
				p_Instance.Urls.Add(s_Value);
			}
			
			s_Urls.Reader.Dispose();
		}
	}
}
