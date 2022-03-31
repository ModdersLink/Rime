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
	public class UIFontCollection :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public LanguageFormat Language { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<UITextDatabase> TextDatabase { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<UIFontAsset> Fonts { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public ResourceBundleKind BundleKind { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Language);
			p_Writer.Write(p_EbxWriter.WriteImport(TextDatabase));
			(RimeWriter Writer, uint ArrayIndex) s_Fonts = p_EbxWriter.GetArrayWriter(Fonts.GetType(), Fonts.Count);
			p_Writer.Write(s_Fonts.ArrayIndex);
			foreach (var s_Entry in Fonts)
			{
				s_Fonts.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) BundleKind);
		}
	}
}
