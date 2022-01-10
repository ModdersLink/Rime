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
	[ContainerType(4, 12)]
	public class UICreditsPage
	{
		[ContainerField(0), LayoutImmutable]
		public string Header1 { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string Header2 { get; set; } = string.Empty;
		
		[ContainerField(8)]
		public List<UICreditsLine> Lines { get; set; } = new();
		
		public static void Deserialize(UICreditsPage p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Header1 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Header2 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Lines.Clear();
			(RimeReader Reader, uint Count) s_Lines = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Lines.Count; ++i)
			{
				var s_Value = new UICreditsLine();
				fb.UICreditsLine.Deserialize(s_Value, s_Lines.Reader, p_Parser);
				p_Instance.Lines.Add(s_Value);
			}
			
			s_Lines.Reader.Dispose();
		}
	}
}
