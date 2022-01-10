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
	public class UISettingsPage
	{
		[ContainerField(0), LayoutImmutable]
		public string NameSid { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public List<UISettingsGroup> SettingsGroups { get; set; } = new();
		
		public static void Deserialize(UISettingsPage p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.NameSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SettingsGroups.Clear();
			(RimeReader Reader, uint Count) s_SettingsGroups = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SettingsGroups.Count; ++i)
			{
				var s_Value = new UISettingsGroup();
				fb.UISettingsGroup.Deserialize(s_Value, s_SettingsGroups.Reader, p_Parser);
				p_Instance.SettingsGroups.Add(s_Value);
			}
			
			s_SettingsGroups.Reader.Dispose();
		}
	}
}
