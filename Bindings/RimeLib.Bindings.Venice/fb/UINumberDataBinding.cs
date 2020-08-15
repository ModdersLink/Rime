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
	public class UINumberDataBinding : 
		UIDataBinding
	{
		protected UIDataSourceInfo m_Value = new UIDataSourceInfo();
		[ContainerField(8), ContainerFieldNameHash(225375086)]
		public UIDataSourceInfo Value { get { return m_Value; } set { if (OnPropertyChanging("UINumberDataBinding." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x8 (8)
		
		protected int m_NumValue = new int();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(768702008)]
		public int NumValue { get { return m_NumValue; } set { if (OnPropertyChanging("UINumberDataBinding." + nameof(NumValue), this, m_NumValue, value)) m_NumValue = value; } } // 0x18 (24)
		
		protected bool m_Refresh = new bool();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(1327541432)]
		public bool Refresh { get { return m_Refresh; } set { if (OnPropertyChanging("UINumberDataBinding." + nameof(Refresh), this, m_Refresh, value)) m_Refresh = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (UIDataSourceInfo) p_Value;
					break;

				case 768702008:
					NumValue = (int) p_Value;
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
				case 225375086:
					return Value;

				case 768702008:
					return NumValue;

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
				case 225375086:
					return typeof(UINumberDataBinding).GetProperty(nameof(Value));

				case 768702008:
					return typeof(UINumberDataBinding).GetProperty(nameof(NumValue));

				case 1327541432:
					return typeof(UINumberDataBinding).GetProperty(nameof(Refresh));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
