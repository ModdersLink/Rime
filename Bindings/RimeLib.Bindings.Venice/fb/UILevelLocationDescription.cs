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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class UILevelLocationDescription : 
		UIItemDescription
	{
		protected string m_Name = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("UILevelLocationDescription." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x10 (16)
		
		protected string m_Description = string.Empty;
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1636673251)]
		public string Description { get { return m_Description; } set { if (OnPropertyChanging("UILevelLocationDescription." + nameof(Description), this, m_Description, value)) m_Description = value; } } // 0x14 (20)
		
		protected string m_TexturePath = string.Empty;
		[ContainerField(24), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3058477943)]
		public string TexturePath { get { return m_TexturePath; } set { if (OnPropertyChanging("UILevelLocationDescription." + nameof(TexturePath), this, m_TexturePath, value)) m_TexturePath = value; } } // 0x18 (24)
		
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
					return typeof(UILevelLocationDescription).GetProperty(nameof(Name));

				case 1636673251:
					return typeof(UILevelLocationDescription).GetProperty(nameof(Description));

				case 3058477943:
					return typeof(UILevelLocationDescription).GetProperty(nameof(TexturePath));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
