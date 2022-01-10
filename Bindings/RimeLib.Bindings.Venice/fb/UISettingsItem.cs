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
	public class UISettingsItem
	{
		[ContainerField(0), LayoutImmutable]
		public string NameSid { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public UISettingSymbols StartEndSymbols { get; set; } = new();
		
		[ContainerField(8)]
		public CtrRef<ProfileOptionData> Setting { get; set; } = new();
		
		public static void Deserialize(UISettingsItem p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.NameSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.StartEndSymbols = (UISettingSymbols) p_Reader.ReadInt32();
			p_Instance.Setting.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}
	}
}
