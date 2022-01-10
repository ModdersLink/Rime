///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 28)]
	public class UIFontCollection : 
		Asset
	{
		[ContainerField(12)]
		public LanguageFormat Language { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<UITextDatabase> TextDatabase { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<UIFontAsset>> Fonts { get; set; } = new();

		[ContainerField(24)]
		public ResourceBundleKind BundleKind { get; set; } = new();

		public static void Deserialize(UIFontCollection p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Language = (LanguageFormat) p_Reader.ReadInt32();
			p_Instance.TextDatabase.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Fonts.Clear();
			(RimeReader Reader, uint Count) s_Fonts = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Fonts.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UIFontAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Fonts.Reader.ReadUInt32()));
				p_Instance.Fonts.Add(s_CtrRef);
			}
			
			s_Fonts.Reader.Dispose();
			p_Instance.BundleKind = (ResourceBundleKind) p_Reader.ReadInt32();
		}

	}
}
