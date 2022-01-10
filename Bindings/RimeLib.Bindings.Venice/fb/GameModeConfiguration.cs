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
	public class GameModeConfiguration : 
		Asset
	{
		[ContainerField(12)]
		public List<GameModeInformation> Information { get; set; } = new();

		public static void Deserialize(GameModeConfiguration p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Information.Clear();
			(RimeReader Reader, uint Count) s_Information = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Information.Count; ++i)
			{
				var s_Value = new GameModeInformation();
				fb.GameModeInformation.Deserialize(s_Value, s_Information.Reader, p_Parser);
				p_Instance.Information.Add(s_Value);
			}
			
			s_Information.Reader.Dispose();
		}

	}
}
