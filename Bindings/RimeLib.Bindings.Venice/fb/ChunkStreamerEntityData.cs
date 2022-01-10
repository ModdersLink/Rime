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
	public class ChunkStreamerEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<ChunkStreamerCell> Cells { get; set; } = new();

		public static void Deserialize(ChunkStreamerEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Cells.Clear();
			(RimeReader Reader, uint Count) s_Cells = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Cells.Count; ++i)
			{
				var s_Value = new ChunkStreamerCell();
				fb.ChunkStreamerCell.Deserialize(s_Value, s_Cells.Reader, p_Parser);
				p_Instance.Cells.Add(s_Value);
			}
			
			s_Cells.Reader.Dispose();
		}

	}
}
