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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class PS3StoreImageSD : 
		UIItemDescription
	{
		protected string m_Identifier = string.Empty;
		[ContainerField(Name: "Identifier", Offset: 16, NameHash: 3512790342, Flags: 16509), LayoutImmutable]
		public string Identifier { get { return m_Identifier; } set { if (OnPropertyChanging("PS3StoreImageSD." + nameof(Identifier), this, m_Identifier, value)) m_Identifier = value; } } // 0x10 (16)
		
		protected string m_ImagePath = string.Empty;
		[ContainerField(Name: "ImagePath", Offset: 20, NameHash: 2679336655, Flags: 16509), LayoutImmutable]
		public string ImagePath { get { return m_ImagePath; } set { if (OnPropertyChanging("PS3StoreImageSD." + nameof(ImagePath), this, m_ImagePath, value)) m_ImagePath = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3512790342:
					Identifier = (string) p_Value;
					break;

				case 2679336655:
					ImagePath = (string) p_Value;
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

				case 2679336655:
					return ImagePath;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3512790342:
					return typeof(PS3StoreImageSD).GetProperty(nameof(Identifier));

				case 2679336655:
					return typeof(PS3StoreImageSD).GetProperty(nameof(ImagePath));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
