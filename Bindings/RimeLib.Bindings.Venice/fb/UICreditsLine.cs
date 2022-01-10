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
	public class UICreditsLine
	{
		[ContainerField(0)]
		public UICreditsTextType TextType { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable]
		public string Text { get; set; } = string.Empty;
		
		public static void Deserialize(UICreditsLine p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TextType = (UICreditsTextType) p_Reader.ReadInt32();
			p_Instance.Text = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
