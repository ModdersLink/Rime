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
	[ContainerType(4, 32)]
	public class UIMapmarkerCompData : 
		UIComponentData
	{
		[ContainerField(28)]
		public List<int> ProximityIntervals { get; set; } = new();

		public static void Deserialize(UIMapmarkerCompData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ProximityIntervals.Clear();
			(RimeReader Reader, uint Count) s_ProximityIntervals = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ProximityIntervals.Count; ++i)
			{
				var s_Value = s_ProximityIntervals.Reader.ReadInt32();
				p_Instance.ProximityIntervals.Add(s_Value);
			}
			
			s_ProximityIntervals.Reader.Dispose();
		}

	}
}
