///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UISettingsPage : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string NameSid { get; set; } // 0x0 (0)
		
		[ContainerField(4)]
		public List<UISettingsGroup> SettingsGroups { get; set; } = new List<UISettingsGroup>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3153745340:
					NameSid = (string) p_Value;
					break;

				case 2837166892:
					SettingsGroups = (List<UISettingsGroup>) p_Value;
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

				case 2837166892:
					return SettingsGroups;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3153745340:
					return typeof(UISettingsPage).GetProperty(nameof(NameSid));

				case 2837166892:
					return typeof(UISettingsPage).GetProperty(nameof(SettingsGroups));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
