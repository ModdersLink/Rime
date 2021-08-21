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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class UIVehicleDescription : 
		UIItemDescription
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 16, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("UIVehicleDescription." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x10 (16)
		
		protected string m_Description = string.Empty;
		[ContainerField(Name: "Description", Offset: 20, NameHash: 1636673251, Flags: 16509), LayoutImmutable]
		public string Description { get { return m_Description; } set { if (OnPropertyChanging("UIVehicleDescription." + nameof(Description), this, m_Description, value)) m_Description = value; } } // 0x14 (20)
		
		protected string m_TexturePath = string.Empty;
		[ContainerField(Name: "TexturePath", Offset: 24, NameHash: 3058477943, Flags: 16509), LayoutImmutable]
		public string TexturePath { get { return m_TexturePath; } set { if (OnPropertyChanging("UIVehicleDescription." + nameof(TexturePath), this, m_TexturePath, value)) m_TexturePath = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1636673251:
					Description = (string) p_Value;
					break;

				case 3058477943:
					TexturePath = (string) p_Value;
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
				case 2088949890:
					return Name;

				case 1636673251:
					return Description;

				case 3058477943:
					return TexturePath;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(UIVehicleDescription).GetProperty(nameof(Name));

				case 1636673251:
					return typeof(UIVehicleDescription).GetProperty(nameof(Description));

				case 3058477943:
					return typeof(UIVehicleDescription).GetProperty(nameof(TexturePath));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
