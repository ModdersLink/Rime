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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(48), ContainerClass]
	public class UIButtonDataBinding : 
		UIDataBinding
	{
		protected UIDataSourceInfo m_ButtonsDatasource = new UIDataSourceInfo();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(3642323661)]
		public UIDataSourceInfo ButtonsDatasource { get { return m_ButtonsDatasource; } set { if (OnPropertyChanging("UIButtonDataBinding." + nameof(ButtonsDatasource), this, m_ButtonsDatasource, value)) m_ButtonsDatasource = value; } } // 0x8 (8)
		
		protected UIButtonSet m_DefaultButtonSet = new UIButtonSet();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(1682159194)]
		public UIButtonSet DefaultButtonSet { get { return m_DefaultButtonSet; } set { if (OnPropertyChanging("UIButtonDataBinding." + nameof(DefaultButtonSet), this, m_DefaultButtonSet, value)) m_DefaultButtonSet = value; } } // 0x18 (24)
		
		protected UIDataSourceInfo m_Visibility = new UIDataSourceInfo();
		[ContainerField(28), MemberInfoFlag(41), ContainerFieldNameHash(1708270083)]
		public UIDataSourceInfo Visibility { get { return m_Visibility; } set { if (OnPropertyChanging("UIButtonDataBinding." + nameof(Visibility), this, m_Visibility, value)) m_Visibility = value; } } // 0x1C (28)
		
		protected bool m_InvertVisible = new bool();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(301381369)]
		public bool InvertVisible { get { return m_InvertVisible; } set { if (OnPropertyChanging("UIButtonDataBinding." + nameof(InvertVisible), this, m_InvertVisible, value)) m_InvertVisible = value; } } // 0x2C (44)
		
		protected bool m_Visible = new bool();
		[ContainerField(45), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(901540267)]
		public bool Visible { get { return m_Visible; } set { if (OnPropertyChanging("UIButtonDataBinding." + nameof(Visible), this, m_Visible, value)) m_Visible = value; } } // 0x2D (45)
		
		protected bool m_InputOnRelease = new bool();
		[ContainerField(46), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1481400763)]
		public bool InputOnRelease { get { return m_InputOnRelease; } set { if (OnPropertyChanging("UIButtonDataBinding." + nameof(InputOnRelease), this, m_InputOnRelease, value)) m_InputOnRelease = value; } } // 0x2E (46)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3642323661:
					ButtonsDatasource = (UIDataSourceInfo) p_Value;
					break;

				case 1682159194:
					DefaultButtonSet = (UIButtonSet) p_Value;
					break;

				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
					break;

				case 301381369:
					InvertVisible = (bool) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
					break;

				case 1481400763:
					InputOnRelease = (bool) p_Value;
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
				case 3642323661:
					return ButtonsDatasource;

				case 1682159194:
					return DefaultButtonSet;

				case 1708270083:
					return Visibility;

				case 301381369:
					return InvertVisible;

				case 901540267:
					return Visible;

				case 1481400763:
					return InputOnRelease;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3642323661:
					return typeof(UIButtonDataBinding).GetProperty(nameof(ButtonsDatasource));

				case 1682159194:
					return typeof(UIButtonDataBinding).GetProperty(nameof(DefaultButtonSet));

				case 1708270083:
					return typeof(UIButtonDataBinding).GetProperty(nameof(Visibility));

				case 301381369:
					return typeof(UIButtonDataBinding).GetProperty(nameof(InvertVisible));

				case 901540267:
					return typeof(UIButtonDataBinding).GetProperty(nameof(Visible));

				case 1481400763:
					return typeof(UIButtonDataBinding).GetProperty(nameof(InputOnRelease));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
