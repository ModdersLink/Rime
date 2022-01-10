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
	public class GroundHeightData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 HeightSpan { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float WorldSize { get; set; }
		
		[ContainerField(12)]
		public List<ushort> Data { get; set; } = new();
		
		public static void Deserialize(GroundHeightData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec2.Deserialize(p_Instance.HeightSpan, p_Reader, p_Parser);
			p_Instance.WorldSize = p_Reader.ReadSingle();
			p_Instance.Data.Clear();
			(RimeReader Reader, uint Count) s_Data = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Data.Count; ++i)
			{
				var s_Value = s_Data.Reader.ReadUInt16();
				p_Instance.Data.Add(s_Value);
			}
			
			s_Data.Reader.Dispose();
		}
	}
}
