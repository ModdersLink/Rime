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
	public class UIFontMappingCollection : 
		Asset
	{
		protected List<UIFontMapping> m_Fonts = new List<UIFontMapping>();
		[ContainerField(12), ContainerFieldNameHash(206880581)]
		public List<UIFontMapping> Fonts { get { return m_Fonts; } set { if (OnPropertyChanging("UIFontMappingCollection." + nameof(Fonts), this, m_Fonts, value)) m_Fonts = value; } } // 0xC (12)
		
		protected RefArray<UITextDatabase> m_TextDatabase = new RefArray<UITextDatabase>();
		[ContainerField(16), ContainerFieldNameHash(1951250813)]
		public RefArray<UITextDatabase> TextDatabase { get { return m_TextDatabase; } set { if (OnPropertyChanging("UIFontMappingCollection." + nameof(TextDatabase), this, m_TextDatabase, value)) m_TextDatabase = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 206880581:
					Fonts = (List<UIFontMapping>) p_Value;
					break;

				case 1951250813:
					TextDatabase = (RefArray<UITextDatabase>) p_Value;
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
				case 206880581:
					return Fonts;

				case 1951250813:
					return TextDatabase;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 206880581:
					return typeof(UIFontMappingCollection).GetProperty(nameof(Fonts));

				case 1951250813:
					return typeof(UIFontMappingCollection).GetProperty(nameof(TextDatabase));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
