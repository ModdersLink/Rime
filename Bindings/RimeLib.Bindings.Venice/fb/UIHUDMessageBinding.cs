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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class UIHUDMessageBinding : 
		UIDataBinding
	{
		protected UIDataSourceInfo m_MessageQuery = new UIDataSourceInfo();
		[ContainerField(Name: "MessageQuery", Offset: 8, NameHash: 501651684, Flags: 41)]
		public UIDataSourceInfo MessageQuery { get { return m_MessageQuery; } set { if (OnPropertyChanging("UIHUDMessageBinding." + nameof(MessageQuery), this, m_MessageQuery, value)) m_MessageQuery = value; } } // 0x8 (8)
		
		protected UIDataSourceInfo m_VisibilityQuery = new UIDataSourceInfo();
		[ContainerField(Name: "VisibilityQuery", Offset: 24, NameHash: 734252745, Flags: 41)]
		public UIDataSourceInfo VisibilityQuery { get { return m_VisibilityQuery; } set { if (OnPropertyChanging("UIHUDMessageBinding." + nameof(VisibilityQuery), this, m_VisibilityQuery, value)) m_VisibilityQuery = value; } } // 0x18 (24)
		
		protected int m_NumberOfRows = new int();
		[ContainerField(Name: "NumberOfRows", Offset: 40, NameHash: 2507942582, Flags: 49405), LayoutImmutable, Blittable]
		public int NumberOfRows { get { return m_NumberOfRows; } set { if (OnPropertyChanging("UIHUDMessageBinding." + nameof(NumberOfRows), this, m_NumberOfRows, value)) m_NumberOfRows = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 501651684:
					MessageQuery = (UIDataSourceInfo) p_Value;
					break;

				case 734252745:
					VisibilityQuery = (UIDataSourceInfo) p_Value;
					break;

				case 2507942582:
					NumberOfRows = (int) p_Value;
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
				case 501651684:
					return MessageQuery;

				case 734252745:
					return VisibilityQuery;

				case 2507942582:
					return NumberOfRows;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 501651684:
					return typeof(UIHUDMessageBinding).GetProperty(nameof(MessageQuery));

				case 734252745:
					return typeof(UIHUDMessageBinding).GetProperty(nameof(VisibilityQuery));

				case 2507942582:
					return typeof(UIHUDMessageBinding).GetProperty(nameof(NumberOfRows));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
