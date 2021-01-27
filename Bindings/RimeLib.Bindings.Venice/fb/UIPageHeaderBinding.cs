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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 72)]
	public class UIPageHeaderBinding : 
		UIDataBinding
	{
		protected UIDataSourceInfo m_Header = new UIDataSourceInfo();
		[ContainerField(Name: "Header", Offset: 8, NameHash: 3054345338, Flags: 41)]
		public UIDataSourceInfo Header { get { return m_Header; } set { if (OnPropertyChanging("UIPageHeaderBinding." + nameof(Header), this, m_Header, value)) m_Header = value; } } // 0x8 (8)
		
		protected UIDataSourceInfo m_SubHeader = new UIDataSourceInfo();
		[ContainerField(Name: "SubHeader", Offset: 24, NameHash: 1300890558, Flags: 41)]
		public UIDataSourceInfo SubHeader { get { return m_SubHeader; } set { if (OnPropertyChanging("UIPageHeaderBinding." + nameof(SubHeader), this, m_SubHeader, value)) m_SubHeader = value; } } // 0x18 (24)
		
		protected UIDataSourceInfo m_Icon = new UIDataSourceInfo();
		[ContainerField(Name: "Icon", Offset: 40, NameHash: 2088920302, Flags: 41)]
		public UIDataSourceInfo Icon { get { return m_Icon; } set { if (OnPropertyChanging("UIPageHeaderBinding." + nameof(Icon), this, m_Icon, value)) m_Icon = value; } } // 0x28 (40)
		
		protected string m_StaticHeader = string.Empty;
		[ContainerField(Name: "StaticHeader", Offset: 56, NameHash: 3731955490, Flags: 16509), LayoutImmutable]
		public string StaticHeader { get { return m_StaticHeader; } set { if (OnPropertyChanging("UIPageHeaderBinding." + nameof(StaticHeader), this, m_StaticHeader, value)) m_StaticHeader = value; } } // 0x38 (56)
		
		protected string m_StaticSubHeader = string.Empty;
		[ContainerField(Name: "StaticSubHeader", Offset: 60, NameHash: 2094195686, Flags: 16509), LayoutImmutable]
		public string StaticSubHeader { get { return m_StaticSubHeader; } set { if (OnPropertyChanging("UIPageHeaderBinding." + nameof(StaticSubHeader), this, m_StaticSubHeader, value)) m_StaticSubHeader = value; } } // 0x3C (60)
		
		protected string m_StaticIcon = string.Empty;
		[ContainerField(Name: "StaticIcon", Offset: 64, NameHash: 3462318262, Flags: 16509), LayoutImmutable]
		public string StaticIcon { get { return m_StaticIcon; } set { if (OnPropertyChanging("UIPageHeaderBinding." + nameof(StaticIcon), this, m_StaticIcon, value)) m_StaticIcon = value; } } // 0x40 (64)
		
		protected List<UILevelSpecificPageHeader> m_LevelSpecificHeaders = new List<UILevelSpecificPageHeader>();
		[ContainerField(Name: "LevelSpecificHeaders", Offset: 68, NameHash: 3034846175, Flags: 65)]
		public List<UILevelSpecificPageHeader> LevelSpecificHeaders { get { return m_LevelSpecificHeaders; } set { if (OnPropertyChanging("UIPageHeaderBinding." + nameof(LevelSpecificHeaders), this, m_LevelSpecificHeaders, value)) m_LevelSpecificHeaders = value; } } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3054345338:
					Header = (UIDataSourceInfo) p_Value;
					break;

				case 1300890558:
					SubHeader = (UIDataSourceInfo) p_Value;
					break;

				case 2088920302:
					Icon = (UIDataSourceInfo) p_Value;
					break;

				case 3731955490:
					StaticHeader = (string) p_Value;
					break;

				case 2094195686:
					StaticSubHeader = (string) p_Value;
					break;

				case 3462318262:
					StaticIcon = (string) p_Value;
					break;

				case 3034846175:
					LevelSpecificHeaders = (List<UILevelSpecificPageHeader>) p_Value;
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
				case 3054345338:
					return Header;

				case 1300890558:
					return SubHeader;

				case 2088920302:
					return Icon;

				case 3731955490:
					return StaticHeader;

				case 2094195686:
					return StaticSubHeader;

				case 3462318262:
					return StaticIcon;

				case 3034846175:
					return LevelSpecificHeaders;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3054345338:
					return typeof(UIPageHeaderBinding).GetProperty(nameof(Header));

				case 1300890558:
					return typeof(UIPageHeaderBinding).GetProperty(nameof(SubHeader));

				case 2088920302:
					return typeof(UIPageHeaderBinding).GetProperty(nameof(Icon));

				case 3731955490:
					return typeof(UIPageHeaderBinding).GetProperty(nameof(StaticHeader));

				case 2094195686:
					return typeof(UIPageHeaderBinding).GetProperty(nameof(StaticSubHeader));

				case 3462318262:
					return typeof(UIPageHeaderBinding).GetProperty(nameof(StaticIcon));

				case 3034846175:
					return typeof(UIPageHeaderBinding).GetProperty(nameof(LevelSpecificHeaders));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
