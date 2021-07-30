///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class UISettingsItem : FrostbiteContainer
	{
		[ContainerField(Name: "NameSid", Offset: 0, NameHash: 3153745340, Flags: 16509), LayoutImmutable]
		public string NameSid { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "StartEndSymbols", Offset: 4, NameHash: 1013788735, Flags: 137)]
		public UISettingSymbols StartEndSymbols { get; set; } = new UISettingSymbols(); // 0x4 (4)
		
		[ContainerField(Name: "Setting", Offset: 8, NameHash: 2752851091, Flags: 53)]
		public CtrRef<ProfileOptionData> Setting { get; set; } = new CtrRef<ProfileOptionData>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3153745340:
					NameSid = (string) p_Value;
					break;

				case 1013788735:
						StartEndSymbols = (UISettingSymbols) Enum.ToObject(typeof(UISettingSymbols), p_Value);
					break;

				case 2752851091:
					Setting = (CtrRef<ProfileOptionData>) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3153745340:
					return NameSid;

				case 1013788735:
					return StartEndSymbols;

				case 2752851091:
					return Setting;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3153745340:
					return typeof(UISettingsItem).GetProperty(nameof(NameSid));

				case 1013788735:
					return typeof(UISettingsItem).GetProperty(nameof(StartEndSymbols));

				case 2752851091:
					return typeof(UISettingsItem).GetProperty(nameof(Setting));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
