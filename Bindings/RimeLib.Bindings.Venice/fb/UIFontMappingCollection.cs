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
	[ContainerType(4, 20)]
	public class UIFontMappingCollection : 
		Asset
	{
		[ContainerField(12)]
		public List<UIFontMapping> Fonts { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<UITextDatabase>> TextDatabase { get; set; } = new();

		public static void Deserialize(UIFontMappingCollection p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Fonts.Clear();
			(RimeReader Reader, uint Count) s_Fonts = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Fonts.Count; ++i)
			{
				var s_Value = new UIFontMapping();
				fb.UIFontMapping.Deserialize(s_Value, s_Fonts.Reader, p_Parser);
				p_Instance.Fonts.Add(s_Value);
			}
			
			s_Fonts.Reader.Dispose();
			p_Instance.TextDatabase.Clear();
			(RimeReader Reader, uint Count) s_TextDatabase = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TextDatabase.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UITextDatabase>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_TextDatabase.Reader.ReadUInt32()));
				p_Instance.TextDatabase.Add(s_CtrRef);
			}
			
			s_TextDatabase.Reader.Dispose();
		}

	}
}
