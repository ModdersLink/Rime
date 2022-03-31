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
	[ContainerType(4, 28)]
	public class UIFontAsset :
		Asset
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string SourceFile { get; set; } = string.Empty;

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<UITextDatabase> TextDatabase { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<string> ScaleformFontName { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public bool NumericsOnly { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		public bool CompleteKorean { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
		public bool CompleteJapanese { get; set; }

		[ContainerField(27), LayoutImmutable, Blittable, JsonProperty(Order = 27)]
		public bool CompleteTraditionalChinese { get; set; }

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
