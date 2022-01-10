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
	public class ChunkStreamerCell
	{
		[ContainerField(0)]
		public List<Vec2> Shape { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable]
		public string BundleName { get; set; } = string.Empty;
		
		public static void Deserialize(ChunkStreamerCell p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Shape.Clear();
			(RimeReader Reader, uint Count) s_Shape = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Shape.Count; ++i)
			{
				var s_Value = new Vec2();
				fb.Vec2.Deserialize(s_Value, s_Shape.Reader, p_Parser);
				p_Instance.Shape.Add(s_Value);
			}
			
			s_Shape.Reader.Dispose();
			p_Instance.BundleName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
