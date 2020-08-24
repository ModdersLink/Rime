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
	public class UIBarDataBinding : 
		UIDataBinding
	{
		protected UIDataSourceInfo m_Visibility = new UIDataSourceInfo();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(1708270083)]
		public UIDataSourceInfo Visibility { get { return m_Visibility; } set { if (OnPropertyChanging("UIBarDataBinding." + nameof(Visibility), this, m_Visibility, value)) m_Visibility = value; } } // 0x8 (8)
		
		protected UIDataSourceInfo m_Value = new UIDataSourceInfo();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(225375086)]
		public UIDataSourceInfo Value { get { return m_Value; } set { if (OnPropertyChanging("UIBarDataBinding." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x18 (24)
		
		protected UIDataSourceInfo m_Color = new UIDataSourceInfo();
		[ContainerField(40), MemberInfoFlag(41), ContainerFieldNameHash(212387320)]
		public UIDataSourceInfo Color { get { return m_Color; } set { if (OnPropertyChanging("UIBarDataBinding." + nameof(Color), this, m_Color, value)) m_Color = value; } } // 0x28 (40)
		
		protected bool m_Refresh = new bool();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1327541432)]
		public bool Refresh { get { return m_Refresh; } set { if (OnPropertyChanging("UIBarDataBinding." + nameof(Refresh), this, m_Refresh, value)) m_Refresh = value; } } // 0x38 (56)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
					break;

				case 225375086:
					Value = (UIDataSourceInfo) p_Value;
					break;

				case 212387320:
					Color = (UIDataSourceInfo) p_Value;
					break;

				case 1327541432:
					Refresh = (bool) p_Value;
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
				case 1708270083:
					return Visibility;

				case 225375086:
					return Value;

				case 212387320:
					return Color;

				case 1327541432:
					return Refresh;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1708270083:
					return typeof(UIBarDataBinding).GetProperty(nameof(Visibility));

				case 225375086:
					return typeof(UIBarDataBinding).GetProperty(nameof(Value));

				case 212387320:
					return typeof(UIBarDataBinding).GetProperty(nameof(Color));

				case 1327541432:
					return typeof(UIBarDataBinding).GetProperty(nameof(Refresh));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
