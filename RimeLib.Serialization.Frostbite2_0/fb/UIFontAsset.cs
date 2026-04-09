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
	public partial class UIFontAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _SourceFile = string.Empty;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<UITextDatabase> _TextDatabase = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private List<string> _ScaleformFontName = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _NumericsOnly;

		[ObservableProperty]
		[property: ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		private bool _CompleteKorean;

		[ObservableProperty]
		[property: ContainerField(26), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
		private bool _CompleteJapanese;

		[ObservableProperty]
		[property: ContainerField(27), LayoutImmutable, Blittable, JsonProperty(Order = 27)]
		private bool _CompleteTraditionalChinese;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(SourceFile));
			p_Writer.Write(p_EbxWriter.WriteImport(TextDatabase));
			(RimeWriter Writer, uint ArrayIndex) s_ScaleformFontName = p_EbxWriter.GetArrayWriter(ScaleformFontName.GetType(), ScaleformFontName.Count);
			p_Writer.Write(s_ScaleformFontName.ArrayIndex);
			foreach (var s_Entry in ScaleformFontName)
			{
				s_ScaleformFontName.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(NumericsOnly);
			p_Writer.Write(CompleteKorean);
			p_Writer.Write(CompleteJapanese);
			p_Writer.Write(CompleteTraditionalChinese);
		}
	}
}
