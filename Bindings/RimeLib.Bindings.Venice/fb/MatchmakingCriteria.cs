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
	[ContainerType(4, 32)]
	public class MatchmakingCriteria
	{
		[ContainerField(0)]
		public MatchmakingSizeRule SizeRule { get; set; } = new();
		
		[ContainerField(8)]
		public MatchmakingPingSiteRule PingSiteRule { get; set; } = new();
		
		[ContainerField(12)]
		public MatchmakingRankedRule RankedRule { get; set; } = new();
		
		[ContainerField(16)]
		public List<MatchmakingGenericRule> GenericRules { get; set; } = new();
		
		[ContainerField(20)]
		public MatchmakingVirtualizedRule VirtualizedRule { get; set; } = new();
		
		[ContainerField(28)]
		public List<MatchmakingUserExtendedDataRule> UEDRules { get; set; } = new();
		
		public static void Deserialize(MatchmakingCriteria p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.MatchmakingSizeRule.Deserialize(p_Instance.SizeRule, p_Reader, p_Parser);
			fb.MatchmakingPingSiteRule.Deserialize(p_Instance.PingSiteRule, p_Reader, p_Parser);
			fb.MatchmakingRankedRule.Deserialize(p_Instance.RankedRule, p_Reader, p_Parser);
			p_Instance.GenericRules.Clear();
			(RimeReader Reader, uint Count) s_GenericRules = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_GenericRules.Count; ++i)
			{
				var s_Value = new MatchmakingGenericRule();
				fb.MatchmakingGenericRule.Deserialize(s_Value, s_GenericRules.Reader, p_Parser);
				p_Instance.GenericRules.Add(s_Value);
			}
			
			s_GenericRules.Reader.Dispose();
			fb.MatchmakingVirtualizedRule.Deserialize(p_Instance.VirtualizedRule, p_Reader, p_Parser);
			p_Instance.UEDRules.Clear();
			(RimeReader Reader, uint Count) s_UEDRules = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UEDRules.Count; ++i)
			{
				var s_Value = new MatchmakingUserExtendedDataRule();
				fb.MatchmakingUserExtendedDataRule.Deserialize(s_Value, s_UEDRules.Reader, p_Parser);
				p_Instance.UEDRules.Add(s_Value);
			}
			
			s_UEDRules.Reader.Dispose();
		}
	}
}
