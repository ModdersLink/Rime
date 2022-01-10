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
	[ContainerType(4, 8)]
	public class MatchmakingSizeRule
	{
		[ContainerField(0), LayoutImmutable]
		public string Setting { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public List<MatchmakingSizeConfiguration> Configurations { get; set; } = new();
		
		public static void Deserialize(MatchmakingSizeRule p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Setting = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Configurations.Clear();
			(RimeReader Reader, uint Count) s_Configurations = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Configurations.Count; ++i)
			{
				var s_Value = new MatchmakingSizeConfiguration();
				fb.MatchmakingSizeConfiguration.Deserialize(s_Value, s_Configurations.Reader, p_Parser);
				p_Instance.Configurations.Add(s_Value);
			}
			
			s_Configurations.Reader.Dispose();
		}
	}
}
