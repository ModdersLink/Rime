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
	public class BFServerConfigurationSchedule
	{
		[ContainerField(0)]
		public List<string> Licenses { get; set; } = new();
		
		[ContainerField(4)]
		public List<string> Levels { get; set; } = new();
		
		[ContainerField(8)]
		public BFServerConfigurationData Data { get; set; } = new();
		
		public static void Deserialize(BFServerConfigurationSchedule p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Licenses.Clear();
			(RimeReader Reader, uint Count) s_Licenses = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Licenses.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Licenses.Reader.ReadUInt32());
				p_Instance.Licenses.Add(s_Value);
			}
			
			s_Licenses.Reader.Dispose();
			p_Instance.Levels.Clear();
			(RimeReader Reader, uint Count) s_Levels = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Levels.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Levels.Reader.ReadUInt32());
				p_Instance.Levels.Add(s_Value);
			}
			
			s_Levels.Reader.Dispose();
			fb.BFServerConfigurationData.Deserialize(p_Instance.Data, p_Reader, p_Parser);
		}
	}
}
