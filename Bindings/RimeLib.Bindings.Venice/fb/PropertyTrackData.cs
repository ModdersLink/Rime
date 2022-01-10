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
	public class PropertyTrackData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int Id { get; set; }

		[ContainerField(12)]
		public List<int> Times { get; set; } = new();

		public static void Deserialize(PropertyTrackData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Id = p_Reader.ReadInt32();
			p_Instance.Times.Clear();
			(RimeReader Reader, uint Count) s_Times = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Times.Count; ++i)
			{
				var s_Value = s_Times.Reader.ReadInt32();
				p_Instance.Times.Add(s_Value);
			}
			
			s_Times.Reader.Dispose();
		}

	}
}
