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
	public class UIPartPropertyList : 
		DataContainer
	{
		[ContainerField(8)]
		public List<UIPartProperties> HudPropertyList { get; set; } = new();

		public static void Deserialize(UIPartPropertyList p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.HudPropertyList.Clear();
			(RimeReader Reader, uint Count) s_HudPropertyList = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_HudPropertyList.Count; ++i)
			{
				var s_Value = new UIPartProperties();
				fb.UIPartProperties.Deserialize(s_Value, s_HudPropertyList.Reader, p_Parser);
				p_Instance.HudPropertyList.Add(s_Value);
			}
			
			s_HudPropertyList.Reader.Dispose();
		}

	}
}
