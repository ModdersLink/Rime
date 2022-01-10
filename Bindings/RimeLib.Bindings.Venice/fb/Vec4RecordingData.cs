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
	public class Vec4RecordingData : 
		PropertyRecordingData
	{
		[ContainerField(12)]
		public List<Vec4> Values { get; set; } = new();

		public static void Deserialize(Vec4RecordingData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Values.Clear();
			(RimeReader Reader, uint Count) s_Values = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Values.Count; ++i)
			{
				var s_Value = new Vec4();
				fb.Vec4.Deserialize(s_Value, s_Values.Reader, p_Parser);
				p_Instance.Values.Add(s_Value);
			}
			
			s_Values.Reader.Dispose();
		}

	}
}
