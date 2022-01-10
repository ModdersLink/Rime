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
	public class NFSUIListDataBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Refresh { get; set; } = new();

		[ContainerField(24)]
		public List<UIListItem> Items { get; set; } = new();

		public static void Deserialize(NFSUIListDataBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.UIDataSourceInfo.Deserialize(p_Instance.Refresh, p_Reader, p_Parser);
			p_Instance.Items.Clear();
			(RimeReader Reader, uint Count) s_Items = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Items.Count; ++i)
			{
				var s_Value = new UIListItem();
				fb.UIListItem.Deserialize(s_Value, s_Items.Reader, p_Parser);
				p_Instance.Items.Add(s_Value);
			}
			
			s_Items.Reader.Dispose();
		}

	}
}
