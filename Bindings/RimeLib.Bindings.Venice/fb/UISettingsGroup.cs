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
	public class UISettingsGroup
	{
		[ContainerField(0), LayoutImmutable]
		public string NameSid { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int ScreenColumn { get; set; }
		
		[ContainerField(8)]
		public List<UISettingsItem> SettingsItems { get; set; } = new();
		
		public static void Deserialize(UISettingsGroup p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.NameSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ScreenColumn = p_Reader.ReadInt32();
			p_Instance.SettingsItems.Clear();
			(RimeReader Reader, uint Count) s_SettingsItems = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SettingsItems.Count; ++i)
			{
				var s_Value = new UISettingsItem();
				fb.UISettingsItem.Deserialize(s_Value, s_SettingsItems.Reader, p_Parser);
				p_Instance.SettingsItems.Add(s_Value);
			}
			
			s_SettingsItems.Reader.Dispose();
		}
	}
}
