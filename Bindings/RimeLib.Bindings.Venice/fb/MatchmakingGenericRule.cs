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
	[ContainerType(4, 20)]
	public class MatchmakingGenericRule
	{
		[ContainerField(0), LayoutImmutable]
		public string Rule { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string MinFitThresHold { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string Setting { get; set; } = string.Empty;
		
		[ContainerField(12)]
		public List<MatchmakingRuleString> DesiredValues { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool IgnoreIfDefault { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool MergeValues { get; set; }
		
		[ContainerField(18), LayoutImmutable, Blittable]
		public bool SortValues { get; set; }
		
		public static void Deserialize(MatchmakingGenericRule p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Rule = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.MinFitThresHold = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Setting = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.DesiredValues.Clear();
			(RimeReader Reader, uint Count) s_DesiredValues = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_DesiredValues.Count; ++i)
			{
				var s_Value = new MatchmakingRuleString();
				fb.MatchmakingRuleString.Deserialize(s_Value, s_DesiredValues.Reader, p_Parser);
				p_Instance.DesiredValues.Add(s_Value);
			}
			
			s_DesiredValues.Reader.Dispose();
			p_Instance.IgnoreIfDefault = p_Reader.ReadBool();
			p_Instance.MergeValues = p_Reader.ReadBool();
			p_Instance.SortValues = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}
	}
}
