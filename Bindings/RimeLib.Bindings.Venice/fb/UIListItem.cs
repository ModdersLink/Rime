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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 72)]
	public class UIListItem : FrostbiteContainer
	{
		[ContainerField(Name: "Label", Offset: 0, NameHash: 218105699, Flags: 16509), LayoutImmutable]
		public string Label { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "IsEnabled", Offset: 4, NameHash: 2323834330, Flags: 41)]
		public UIDataSourceInfo IsEnabled { get; set; } = new UIDataSourceInfo(); // 0x4 (4)
		
		[ContainerField(Name: "IsVisible", Offset: 20, NameHash: 4174428017, Flags: 41)]
		public UIDataSourceInfo IsVisible { get; set; } = new UIDataSourceInfo(); // 0x14 (20)
		
		[ContainerField(Name: "ToggleItems", Offset: 36, NameHash: 1972979281, Flags: 41)]
		public UIDataSourceInfo ToggleItems { get; set; } = new UIDataSourceInfo(); // 0x24 (36)
		
		[ContainerField(Name: "DataUpdate", Offset: 52, NameHash: 3436913316, Flags: 41)]
		public UIDataSourceInfo DataUpdate { get; set; } = new UIDataSourceInfo(); // 0x34 (52)
		
		[ContainerField(Name: "DefaultIsVisible", Offset: 68, NameHash: 606137530, Flags: 49325), LayoutImmutable, Blittable]
		public bool DefaultIsVisible { get; set; } // 0x44 (68)
		
		[ContainerField(Name: "DefaultIsEnabled", Offset: 69, NameHash: 1109158225, Flags: 49325), LayoutImmutable, Blittable]
		public bool DefaultIsEnabled { get; set; } // 0x45 (69)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 218105699:
					Label = (string) p_Value;
					break;

				case 2323834330:
					IsEnabled = (UIDataSourceInfo) p_Value;
					break;

				case 4174428017:
					IsVisible = (UIDataSourceInfo) p_Value;
					break;

				case 1972979281:
					ToggleItems = (UIDataSourceInfo) p_Value;
					break;

				case 3436913316:
					DataUpdate = (UIDataSourceInfo) p_Value;
					break;

				case 606137530:
					DefaultIsVisible = (bool) p_Value;
					break;

				case 1109158225:
					DefaultIsEnabled = (bool) p_Value;
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
				case 218105699:
					return Label;

				case 2323834330:
					return IsEnabled;

				case 4174428017:
					return IsVisible;

				case 1972979281:
					return ToggleItems;

				case 3436913316:
					return DataUpdate;

				case 606137530:
					return DefaultIsVisible;

				case 1109158225:
					return DefaultIsEnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 218105699:
					return typeof(UIListItem).GetProperty(nameof(Label));

				case 2323834330:
					return typeof(UIListItem).GetProperty(nameof(IsEnabled));

				case 4174428017:
					return typeof(UIListItem).GetProperty(nameof(IsVisible));

				case 1972979281:
					return typeof(UIListItem).GetProperty(nameof(ToggleItems));

				case 3436913316:
					return typeof(UIListItem).GetProperty(nameof(DataUpdate));

				case 606137530:
					return typeof(UIListItem).GetProperty(nameof(DefaultIsVisible));

				case 1109158225:
					return typeof(UIListItem).GetProperty(nameof(DefaultIsEnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
