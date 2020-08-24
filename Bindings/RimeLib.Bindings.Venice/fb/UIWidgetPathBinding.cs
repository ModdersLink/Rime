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
	public class UIWidgetPathBinding : 
		UIDataBinding
	{
		protected UIDataSourceInfo m_WidgetPathQuery = new UIDataSourceInfo();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(4285486446)]
		public UIDataSourceInfo WidgetPathQuery { get { return m_WidgetPathQuery; } set { if (OnPropertyChanging("UIWidgetPathBinding." + nameof(WidgetPathQuery), this, m_WidgetPathQuery, value)) m_WidgetPathQuery = value; } } // 0x8 (8)
		
		protected UIDataSourceInfo m_Visibility = new UIDataSourceInfo();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(1708270083)]
		public UIDataSourceInfo Visibility { get { return m_Visibility; } set { if (OnPropertyChanging("UIWidgetPathBinding." + nameof(Visibility), this, m_Visibility, value)) m_Visibility = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4285486446:
					WidgetPathQuery = (UIDataSourceInfo) p_Value;
					break;

				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
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
				case 4285486446:
					return WidgetPathQuery;

				case 1708270083:
					return Visibility;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4285486446:
					return typeof(UIWidgetPathBinding).GetProperty(nameof(WidgetPathQuery));

				case 1708270083:
					return typeof(UIWidgetPathBinding).GetProperty(nameof(Visibility));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
