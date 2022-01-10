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
	public class GameTipAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<GameTipData> Tips { get; set; } = new();

		public static void Deserialize(GameTipAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Tips.Clear();
			(RimeReader Reader, uint Count) s_Tips = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Tips.Count; ++i)
			{
				var s_Value = new GameTipData();
				fb.GameTipData.Deserialize(s_Value, s_Tips.Reader, p_Parser);
				p_Instance.Tips.Add(s_Value);
			}
			
			s_Tips.Reader.Dispose();
		}

	}
}
