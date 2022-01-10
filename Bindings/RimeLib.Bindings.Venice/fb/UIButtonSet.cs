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
	[ContainerType(4, 4)]
	public class UIButtonSet
	{
		[ContainerField(0)]
		public List<UIButton> Buttons { get; set; } = new();
		
		public static void Deserialize(UIButtonSet p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Buttons.Clear();
			(RimeReader Reader, uint Count) s_Buttons = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Buttons.Count; ++i)
			{
				var s_Value = new UIButton();
				fb.UIButton.Deserialize(s_Value, s_Buttons.Reader, p_Parser);
				p_Instance.Buttons.Add(s_Value);
			}
			
			s_Buttons.Reader.Dispose();
		}
	}
}
