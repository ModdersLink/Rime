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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class UISettingsCompData : 
		UIComponentData
	{
		protected List<UISettingsPage> m_SettingsPages = new List<UISettingsPage>();
		[ContainerField(28), MemberInfoFlag(65), ContainerFieldNameHash(3477862144), ContainerArray]
		public List<UISettingsPage> SettingsPages { get { return m_SettingsPages; } set { if (OnPropertyChanging("UISettingsCompData." + nameof(SettingsPages), this, m_SettingsPages, value)) m_SettingsPages = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3477862144:
					SettingsPages = (List<UISettingsPage>) p_Value;
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
				case 3477862144:
					return SettingsPages;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3477862144:
					return typeof(UISettingsCompData).GetProperty(nameof(SettingsPages));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
