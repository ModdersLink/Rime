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
	[ContainerType(4, 8)]
	public class UIFontMapping
	{
		[ContainerField(0)]
		public List<string> ScaleformFontName { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable]
		public string FontLongName { get; set; } = string.Empty;
		
		public static void Deserialize(UIFontMapping p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ScaleformFontName.Clear();
			(RimeReader Reader, uint Count) s_ScaleformFontName = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ScaleformFontName.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_ScaleformFontName.Reader.ReadUInt32());
				p_Instance.ScaleformFontName.Add(s_Value);
			}
			
			s_ScaleformFontName.Reader.Dispose();
			p_Instance.FontLongName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
