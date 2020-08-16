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
	[ContainerType(4)]
	public class UILicenseDescription : 
		UIItemDescription
	{
		protected string m_LicenseId = string.Empty;
		[ContainerField(16), LayoutImmutable, ContainerFieldNameHash(1538246483)]
		public string LicenseId { get { return m_LicenseId; } set { if (OnPropertyChanging("UILicenseDescription." + nameof(LicenseId), this, m_LicenseId, value)) m_LicenseId = value; } } // 0x10 (16)
		
		protected string m_PopupText = string.Empty;
		[ContainerField(20), LayoutImmutable, ContainerFieldNameHash(1817045074)]
		public string PopupText { get { return m_PopupText; } set { if (OnPropertyChanging("UILicenseDescription." + nameof(PopupText), this, m_PopupText, value)) m_PopupText = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1538246483:
					LicenseId = (string) p_Value;
					break;

				case 1817045074:
					PopupText = (string) p_Value;
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
				case 1538246483:
					return LicenseId;

				case 1817045074:
					return PopupText;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1538246483:
					return typeof(UILicenseDescription).GetProperty(nameof(LicenseId));

				case 1817045074:
					return typeof(UILicenseDescription).GetProperty(nameof(PopupText));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
