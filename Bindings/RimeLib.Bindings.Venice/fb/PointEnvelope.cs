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
	public class PointEnvelope : 
		DataContainer
	{
		[ContainerField(8)]
		public List<PointEnvelopePoint> Points { get; set; } = new();

		public static void Deserialize(PointEnvelope p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Points.Clear();
			(RimeReader Reader, uint Count) s_Points = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Points.Count; ++i)
			{
				var s_Value = new PointEnvelopePoint();
				fb.PointEnvelopePoint.Deserialize(s_Value, s_Points.Reader, p_Parser);
				p_Instance.Points.Add(s_Value);
			}
			
			s_Points.Reader.Dispose();
		}

	}
}
