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
	public class LevelSaveData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint SaveSize { get; set; }

		[ContainerField(12)]
		public List<string> SaveNames { get; set; } = new();

		public static void Deserialize(LevelSaveData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SaveSize = p_Reader.ReadUInt32();
			p_Instance.SaveNames.Clear();
			(RimeReader Reader, uint Count) s_SaveNames = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SaveNames.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_SaveNames.Reader.ReadUInt32());
				p_Instance.SaveNames.Add(s_Value);
			}
			
			s_SaveNames.Reader.Dispose();
		}

	}
}
