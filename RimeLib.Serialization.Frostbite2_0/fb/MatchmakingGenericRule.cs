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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 20)]
	public partial class MatchmakingGenericRule :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _Rule = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		private string _MinFitThresHold = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _Setting = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<MatchmakingRuleString> _DesiredValues = new();
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private bool _IgnoreIfDefault;
		
		[ObservableProperty]
		[property: ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		private bool _MergeValues;
		
		[ObservableProperty]
		[property: ContainerField(18), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
		private bool _SortValues;
		
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
