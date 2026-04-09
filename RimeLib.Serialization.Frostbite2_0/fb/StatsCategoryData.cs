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
	[ContainerType(4, 28)]
	public partial class StatsCategoryData :
		StatsCategoryBaseData
	{
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<StatsCategoryData> _Categories = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private List<string> _Members = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Categories = p_EbxWriter.GetArrayWriter(Categories.GetType(), Categories.Count);
			p_Writer.Write(s_Categories.ArrayIndex);
			foreach (var s_Entry in Categories)
			{
				s_Categories.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Members = p_EbxWriter.GetArrayWriter(Members.GetType(), Members.Count);
			p_Writer.Write(s_Members.ArrayIndex);
			foreach (var s_Entry in Members)
			{
				s_Members.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
		}
	}
}
