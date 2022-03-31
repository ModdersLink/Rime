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
	public class UIFontMappingCollection :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<UIFontMapping> Fonts { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<UITextDatabase> TextDatabase { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Fonts = p_EbxWriter.GetArrayWriter(Fonts.GetType(), Fonts.Count);
			p_Writer.Write(s_Fonts.ArrayIndex);
			foreach (var s_Entry in Fonts)
			{
				s_Entry.Serialize(s_Fonts.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_TextDatabase = p_EbxWriter.GetArrayWriter(TextDatabase.GetType(), TextDatabase.Count);
			p_Writer.Write(s_TextDatabase.ArrayIndex);
			foreach (var s_Entry in TextDatabase)
			{
				s_TextDatabase.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
