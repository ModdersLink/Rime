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
	[ContainerType(4, 24)]
	public class TransformPropertyTrackData : 
		SimplePropertyTrackData
	{
		[ContainerField(20)]
		public List<LinearTransform> Values { get; set; } = new();

		public static void Deserialize(TransformPropertyTrackData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Values.Clear();
			(RimeReader Reader, uint Count) s_Values = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Values.Count; ++i)
			{
				var s_Value = new LinearTransform();
				fb.LinearTransform.Deserialize(s_Value, s_Values.Reader, p_Parser);
				p_Instance.Values.Add(s_Value);
			}
			
			s_Values.Reader.Dispose();
		}

	}
}
