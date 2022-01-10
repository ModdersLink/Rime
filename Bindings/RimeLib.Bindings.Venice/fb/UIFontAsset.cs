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
	public class UIFontAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string SourceFile { get; set; } = string.Empty;

		[ContainerField(16)]
		public CtrRef<UITextDatabase> TextDatabase { get; set; } = new();

		[ContainerField(20)]
		public List<string> ScaleformFontName { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool NumericsOnly { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool CompleteKorean { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable]
		public bool CompleteJapanese { get; set; }

		[ContainerField(27), LayoutImmutable, Blittable]
		public bool CompleteTraditionalChinese { get; set; }

		public static void Deserialize(UIFontAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SourceFile = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.TextDatabase.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ScaleformFontName.Clear();
			(RimeReader Reader, uint Count) s_ScaleformFontName = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ScaleformFontName.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_ScaleformFontName.Reader.ReadUInt32());
				p_Instance.ScaleformFontName.Add(s_Value);
			}
			
			s_ScaleformFontName.Reader.Dispose();
			p_Instance.NumericsOnly = p_Reader.ReadBool();
			p_Instance.CompleteKorean = p_Reader.ReadBool();
			p_Instance.CompleteJapanese = p_Reader.ReadBool();
			p_Instance.CompleteTraditionalChinese = p_Reader.ReadBool();
		}

	}
}
