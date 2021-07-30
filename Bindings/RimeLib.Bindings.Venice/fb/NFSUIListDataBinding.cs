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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class NFSUIListDataBinding : 
		UIDataBinding
	{
		protected UIDataSourceInfo m_Refresh = new UIDataSourceInfo();
		[ContainerField(Name: "Refresh", Offset: 8, NameHash: 1327541432, Flags: 41)]
		public UIDataSourceInfo Refresh { get { return m_Refresh; } set { if (OnPropertyChanging("NFSUIListDataBinding." + nameof(Refresh), this, m_Refresh, value)) m_Refresh = value; } } // 0x8 (8)
		
		protected List<UIListItem> m_Items = new List<UIListItem>();
		[ContainerField(Name: "Items", Offset: 24, NameHash: 215446531, Flags: 65)]
		public List<UIListItem> Items { get { return m_Items; } set { if (OnPropertyChanging("NFSUIListDataBinding." + nameof(Items), this, m_Items, value)) m_Items = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1327541432:
					Refresh = (UIDataSourceInfo) p_Value;
					break;

				case 215446531:
					Items = (List<UIListItem>) p_Value;
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
				case 1327541432:
					return Refresh;

				case 215446531:
					return Items;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1327541432:
					return typeof(NFSUIListDataBinding).GetProperty(nameof(Refresh));

				case 215446531:
					return typeof(NFSUIListDataBinding).GetProperty(nameof(Items));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
