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
	public class StatsCategoryScoreboardPositionData : 
		StatsCategoryBaseData
	{
		[ContainerField(20)]
		public List<ScoreboardPosition> Positions { get; set; } = new();

		public static void Deserialize(StatsCategoryScoreboardPositionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Positions.Clear();
			(RimeReader Reader, uint Count) s_Positions = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Positions.Count; ++i)
			{
				var s_Value = (ScoreboardPosition) s_Positions.Reader.ReadInt32();
				p_Instance.Positions.Add(s_Value);
			}
			
			s_Positions.Reader.Dispose();
		}

	}
}
