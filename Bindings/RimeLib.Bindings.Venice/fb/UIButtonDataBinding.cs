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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 48)]
	public class UIButtonDataBinding : 
		UIDataBinding
	{
		protected UIDataSourceInfo m_ButtonsDatasource = new UIDataSourceInfo();
		[ContainerField(Name: "ButtonsDatasource", Offset: 8, NameHash: 3642323661, Flags: 41)]
		public UIDataSourceInfo ButtonsDatasource { get { return m_ButtonsDatasource; } set { if (OnPropertyChanging("UIButtonDataBinding." + nameof(ButtonsDatasource), this, m_ButtonsDatasource, value)) m_ButtonsDatasource = value; } } // 0x8 (8)
		
		protected UIButtonSet m_DefaultButtonSet = new UIButtonSet();
		[ContainerField(Name: "DefaultButtonSet", Offset: 24, NameHash: 1682159194, Flags: 41)]
		public UIButtonSet DefaultButtonSet { get { return m_DefaultButtonSet; } set { if (OnPropertyChanging("UIButtonDataBinding." + nameof(DefaultButtonSet), this, m_DefaultButtonSet, value)) m_DefaultButtonSet = value; } } // 0x18 (24)
		
		protected UIDataSourceInfo m_Visibility = new UIDataSourceInfo();
		[ContainerField(Name: "Visibility", Offset: 28, NameHash: 1708270083, Flags: 41)]
		public UIDataSourceInfo Visibility { get { return m_Visibility; } set { if (OnPropertyChanging("UIButtonDataBinding." + nameof(Visibility), this, m_Visibility, value)) m_Visibility = value; } } // 0x1C (28)
		
		protected bool m_InvertVisible = new bool();
		[ContainerField(Name: "InvertVisible", Offset: 44, NameHash: 301381369, Flags: 49325), LayoutImmutable, Blittable]
		public bool InvertVisible { get { return m_InvertVisible; } set { if (OnPropertyChanging("UIButtonDataBinding." + nameof(InvertVisible), this, m_InvertVisible, value)) m_InvertVisible = value; } } // 0x2C (44)
		
		protected bool m_Visible = new bool();
		[ContainerField(Name: "Visible", Offset: 45, NameHash: 901540267, Flags: 49325), LayoutImmutable, Blittable]
		public bool Visible { get { return m_Visible; } set { if (OnPropertyChanging("UIButtonDataBinding." + nameof(Visible), this, m_Visible, value)) m_Visible = value; } } // 0x2D (45)
		
		protected bool m_InputOnRelease = new bool();
		[ContainerField(Name: "InputOnRelease", Offset: 46, NameHash: 1481400763, Flags: 49325), LayoutImmutable, Blittable]
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
