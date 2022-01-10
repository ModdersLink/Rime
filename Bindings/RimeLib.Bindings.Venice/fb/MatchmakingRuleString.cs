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
	public class MatchmakingRuleString
	{
		[ContainerField(0), LayoutImmutable]
		public string Value { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public MatchmakingPlatform Platform { get; set; } = new();
		
		[ContainerField(8)]
		public List<string> Licenses { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool UseOnlyIfEmpty { get; set; }
		
		public static void Deserialize(MatchmakingRuleString p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Value = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Platform = (MatchmakingPlatform) p_Reader.ReadInt32();
			p_Instance.Licenses.Clear();
			(RimeReader Reader, uint Count) s_Licenses = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Licenses.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Licenses.Reader.ReadUInt32());
				p_Instance.Licenses.Add(s_Value);
			}
			
			s_Licenses.Reader.Dispose();
			p_Instance.UseOnlyIfEmpty = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
