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
	[ContainerType(4, 40)]
	public partial class LevelDescriptionAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _LevelName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<LevelDescriptionInclusionCategory> _Categories = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private LevelDescription _Description = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private List<string> _StartPoints = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(LevelName));
			(RimeWriter Writer, uint ArrayIndex) s_Categories = p_EbxWriter.GetArrayWriter(Categories.GetType(), Categories.Count);
			p_Writer.Write(s_Categories.ArrayIndex);
			foreach (var s_Entry in Categories)
			{
				s_Entry.Serialize(s_Categories.Writer, p_EbxWriter);
			}
			Description.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_StartPoints = p_EbxWriter.GetArrayWriter(StartPoints.GetType(), StartPoints.Count);
			p_Writer.Write(s_StartPoints.ArrayIndex);
			foreach (var s_Entry in StartPoints)
			{
				s_StartPoints.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
		}
	}
}
