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
	[ContainerType(4, 16)]
	public class UICreditsAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<UICreditsPage> Pages { get; set; } = new();

		public static void Deserialize(UICreditsAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Pages.Clear();
			(RimeReader Reader, uint Count) s_Pages = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Pages.Count; ++i)
			{
				var s_Value = new UICreditsPage();
				fb.UICreditsPage.Deserialize(s_Value, s_Pages.Reader, p_Parser);
				p_Instance.Pages.Add(s_Value);
			}
			
			s_Pages.Reader.Dispose();
		}

	}
}
