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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class UIModDescription : 
		UIItemDescription
	{
		protected string m_Identifier = string.Empty;
		[ContainerField(Name: "Identifier", Offset: 16, NameHash: 3512790342, Flags: 16509), LayoutImmutable]
		public string Identifier { get { return m_Identifier; } set { if (OnPropertyChanging("UIModDescription." + nameof(Identifier), this, m_Identifier, value)) m_Identifier = value; } } // 0x10 (16)
		
		protected string m_ShortName = string.Empty;
		[ContainerField(Name: "ShortName", Offset: 20, NameHash: 1803010032, Flags: 16509), LayoutImmutable]
		public string ShortName { get { return m_ShortName; } set { if (OnPropertyChanging("UIModDescription." + nameof(ShortName), this, m_ShortName, value)) m_ShortName = value; } } // 0x14 (20)
		
		protected string m_FullName = string.Empty;
		[ContainerField(Name: "FullName", Offset: 24, NameHash: 4054333169, Flags: 16509), LayoutImmutable]
		public string FullName { get { return m_FullName; } set { if (OnPropertyChanging("UIModDescription." + nameof(FullName), this, m_FullName, value)) m_FullName = value; } } // 0x18 (24)
		
		protected string m_Desc = string.Empty;
		[ContainerField(Name: "Desc", Offset: 28, NameHash: 2088734996, Flags: 16509), LayoutImmutable]
		public string Desc { get { return m_Desc; } set { if (OnPropertyChanging("UIModDescription." + nameof(Desc), this, m_Desc, value)) m_Desc = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3512790342:
					Identifier = (string) p_Value;
					break;

				case 1803010032:
					ShortName = (string) p_Value;
					break;

				case 4054333169:
					FullName = (string) p_Value;
					break;

				case 2088734996:
					Desc = (string) p_Value;
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
				case 3512790342:
					return Identifier;

				case 1803010032:
					return ShortName;

				case 4054333169:
					return FullName;

				case 2088734996:
					return Desc;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3512790342:
					return typeof(UIModDescription).GetProperty(nameof(Identifier));

				case 1803010032:
					return typeof(UIModDescription).GetProperty(nameof(ShortName));

				case 4054333169:
					return typeof(UIModDescription).GetProperty(nameof(FullName));

				case 2088734996:
					return typeof(UIModDescription).GetProperty(nameof(Desc));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
