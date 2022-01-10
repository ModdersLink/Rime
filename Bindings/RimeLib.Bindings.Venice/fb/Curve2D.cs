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
	[ContainerType(4, 12)]
	public class Curve2D : 
		DataContainer
	{
		[ContainerField(8)]
		public List<Vec2> Curve { get; set; } = new();

		public static void Deserialize(Curve2D p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Curve.Clear();
			(RimeReader Reader, uint Count) s_Curve = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Curve.Count; ++i)
			{
				var s_Value = new Vec2();
				fb.Vec2.Deserialize(s_Value, s_Curve.Reader, p_Parser);
				p_Instance.Curve.Add(s_Value);
			}
			
			s_Curve.Reader.Dispose();
		}

	}
}
