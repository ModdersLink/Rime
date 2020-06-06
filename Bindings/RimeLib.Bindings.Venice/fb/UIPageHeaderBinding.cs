///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIPageHeaderBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Header { get; set; } = new UIDataSourceInfo(); // 0x8 (8)
		
		[ContainerField(24)]
		public UIDataSourceInfo SubHeader { get; set; } = new UIDataSourceInfo(); // 0x18 (24)
		
		[ContainerField(40)]
		public UIDataSourceInfo Icon { get; set; } = new UIDataSourceInfo(); // 0x28 (40)
		
		[ContainerField(56), LayoutImmutable]
		public string StaticHeader { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable]
		public string StaticSubHeader { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable]
		public string StaticIcon { get; set; } // 0x40 (64)
		
		[ContainerField(68)]
		public List<UILevelSpecificPageHeader> LevelSpecificHeaders { get; set; } = new List<UILevelSpecificPageHeader>(); // 0x44 (68)
		
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
