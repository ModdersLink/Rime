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
	public class UIDynamicDataBinding : 
		UIDataBinding
	{
		protected List<UIDataSourceInfo> m_Bindings = new List<UIDataSourceInfo>();
		[ContainerField(8), ContainerFieldNameHash(3867608887)]
		public List<UIDataSourceInfo> Bindings { get { return m_Bindings; } set { if (OnPropertyChanging("UIDynamicDataBinding." + nameof(Bindings), this, m_Bindings, value)) m_Bindings = value; } } // 0x8 (8)
		
		protected bool m_Refresh = new bool();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(1327541432)]
		public bool Refresh { get { return m_Refresh; } set { if (OnPropertyChanging("UIDynamicDataBinding." + nameof(Refresh), this, m_Refresh, value)) m_Refresh = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3867608887:
					Bindings = (List<UIDataSourceInfo>) p_Value;
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
				case 3867608887:
					return Bindings;

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
				case 3867608887:
					return typeof(UIDynamicDataBinding).GetProperty(nameof(Bindings));

				case 1327541432:
					return typeof(UIDynamicDataBinding).GetProperty(nameof(Refresh));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
