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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class MatchmakingGenericRule :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Rule { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string MinFitThresHold { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string Setting { get; set; } = string.Empty;
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<MatchmakingRuleString> DesiredValues { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool IgnoreIfDefault { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		public bool MergeValues { get; set; }
		
		[ContainerField(18), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
		public bool SortValues { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Rule));
			p_Writer.Write(p_EbxWriter.WriteString(MinFitThresHold));
			p_Writer.Write(p_EbxWriter.WriteString(Setting));
			(RimeWriter Writer, uint ArrayIndex) s_DesiredValues = p_EbxWriter.GetArrayWriter(DesiredValues.GetType(), DesiredValues.Count);
			p_Writer.Write(s_DesiredValues.ArrayIndex);
			foreach (var s_Entry in DesiredValues)
			{
				s_Entry.Serialize(s_DesiredValues.Writer, p_EbxWriter);
			}
			p_Writer.Write(IgnoreIfDefault);
			p_Writer.Write(MergeValues);
			p_Writer.Write(SortValues);
			p_Writer.WriteNullBytes(1);
		}
	}
}
