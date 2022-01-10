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
	[ContainerType(4, 8)]
	public class LevelDescriptionInclusionCategory
	{
		[ContainerField(0), LayoutImmutable]
		public string Category { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public List<string> Mode { get; set; } = new();
		
		public static void Deserialize(LevelDescriptionInclusionCategory p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Category = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Mode.Clear();
			(RimeReader Reader, uint Count) s_Mode = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Mode.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Mode.Reader.ReadUInt32());
				p_Instance.Mode.Add(s_Value);
			}
			
			s_Mode.Reader.Dispose();
		}
	}
}
