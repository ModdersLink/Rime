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
	public class UITextDataBinding : 
		UIDataBinding
	{
		protected string m_StaticText = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3461853472)]
		public string StaticText { get { return m_StaticText; } set { if (OnPropertyChanging("UITextDataBinding." + nameof(StaticText), this, m_StaticText, value)) m_StaticText = value; } } // 0x8 (8)
		
		protected UIDataSourceInfo m_TextData = new UIDataSourceInfo();
		[ContainerField(12), MemberInfoFlag(41), ContainerFieldNameHash(2028824392)]
		public UIDataSourceInfo TextData { get { return m_TextData; } set { if (OnPropertyChanging("UITextDataBinding." + nameof(TextData), this, m_TextData, value)) m_TextData = value; } } // 0xC (12)
		
		protected UIDataSourceInfo m_Visibility = new UIDataSourceInfo();
		[ContainerField(28), MemberInfoFlag(41), ContainerFieldNameHash(1708270083)]
		public UIDataSourceInfo Visibility { get { return m_Visibility; } set { if (OnPropertyChanging("UITextDataBinding." + nameof(Visibility), this, m_Visibility, value)) m_Visibility = value; } } // 0x1C (28)
		
		protected bool m_Refresh = new bool();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1327541432)]
		public bool Refresh { get { return m_Refresh; } set { if (OnPropertyChanging("UITextDataBinding." + nameof(Refresh), this, m_Refresh, value)) m_Refresh = value; } } // 0x2C (44)
		
		protected bool m_OverrideDirectAccess = new bool();
		[ContainerField(45), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1955548088)]
		public bool OverrideDirectAccess { get { return m_OverrideDirectAccess; } set { if (OnPropertyChanging("UITextDataBinding." + nameof(OverrideDirectAccess), this, m_OverrideDirectAccess, value)) m_OverrideDirectAccess = value; } } // 0x2D (45)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3461853472:
					StaticText = (string) p_Value;
					break;

				case 2028824392:
					TextData = (UIDataSourceInfo) p_Value;
					break;

				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
					break;

				case 1327541432:
					Refresh = (bool) p_Value;
					break;

				case 1955548088:
					OverrideDirectAccess = (bool) p_Value;
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
				case 3461853472:
					return StaticText;

				case 2028824392:
					return TextData;

				case 1708270083:
					return Visibility;

				case 1327541432:
					return Refresh;

				case 1955548088:
					return OverrideDirectAccess;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3461853472:
					return typeof(UITextDataBinding).GetProperty(nameof(StaticText));

				case 2028824392:
					return typeof(UITextDataBinding).GetProperty(nameof(TextData));

				case 1708270083:
					return typeof(UITextDataBinding).GetProperty(nameof(Visibility));

				case 1327541432:
					return typeof(UITextDataBinding).GetProperty(nameof(Refresh));

				case 1955548088:
					return typeof(UITextDataBinding).GetProperty(nameof(OverrideDirectAccess));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
