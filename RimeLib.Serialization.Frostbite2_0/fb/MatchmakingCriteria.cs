///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class MatchmakingCriteria :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public MatchmakingSizeRule SizeRule { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public MatchmakingPingSiteRule PingSiteRule { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public MatchmakingRankedRule RankedRule { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public List<MatchmakingGenericRule> GenericRules { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public MatchmakingVirtualizedRule VirtualizedRule { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public List<MatchmakingUserExtendedDataRule> UEDRules { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			SizeRule.Serialize(p_Writer, p_EbxWriter);
			PingSiteRule.Serialize(p_Writer, p_EbxWriter);
			RankedRule.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_GenericRules = p_EbxWriter.GetArrayWriter(GenericRules.GetType(), GenericRules.Count);
			p_Writer.Write(s_GenericRules.ArrayIndex);
			foreach (var s_Entry in GenericRules)
			{
				s_Entry.Serialize(s_GenericRules.Writer, p_EbxWriter);
			}
			VirtualizedRule.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_UEDRules = p_EbxWriter.GetArrayWriter(UEDRules.GetType(), UEDRules.Count);
			p_Writer.Write(s_UEDRules.ArrayIndex);
			foreach (var s_Entry in UEDRules)
			{
				s_Entry.Serialize(s_UEDRules.Writer, p_EbxWriter);
			}
		}
	}
}
