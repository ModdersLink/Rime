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
	public class UIEventAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string Category { get; set; } = string.Empty;

		[ContainerField(16)]
		public List<string> EventList { get; set; } = new();

		public static void Deserialize(UIEventAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Category = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.EventList.Clear();
			(RimeReader Reader, uint Count) s_EventList = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_EventList.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_EventList.Reader.ReadUInt32());
				p_Instance.EventList.Add(s_Value);
			}
			
			s_EventList.Reader.Dispose();
		}

	}
}
