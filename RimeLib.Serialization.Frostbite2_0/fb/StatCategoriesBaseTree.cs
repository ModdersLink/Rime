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
	public partial class StatCategoriesBaseTree :
		TreeBase
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<StatsCategoryBaseData> _RootBaseCategories = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<CriteriaData> _ParamX = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<CriteriaData> _ParamY = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _ProcessAllLevelsInTree;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_RootBaseCategories = p_EbxWriter.GetArrayWriter(RootBaseCategories.GetType(), RootBaseCategories.Count);
			p_Writer.Write(s_RootBaseCategories.ArrayIndex);
			foreach (var s_Entry in RootBaseCategories)
			{
				s_RootBaseCategories.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_ParamX = p_EbxWriter.GetArrayWriter(ParamX.GetType(), ParamX.Count);
			p_Writer.Write(s_ParamX.ArrayIndex);
			foreach (var s_Entry in ParamX)
			{
				s_ParamX.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_ParamY = p_EbxWriter.GetArrayWriter(ParamY.GetType(), ParamY.Count);
			p_Writer.Write(s_ParamY.ArrayIndex);
			foreach (var s_Entry in ParamY)
			{
				s_ParamY.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(ProcessAllLevelsInTree);
			p_Writer.WriteNullBytes(3);
		}
	}
}
