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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 40)]
	public class StaticListItem : FrostbiteContainer
	{
		[ContainerField(Name: "ItemName", Offset: 0, NameHash: 2972930359, Flags: 16509), LayoutImmutable]
		public string ItemName { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "DynamicDisable", Offset: 4, NameHash: 2500014788, Flags: 41)]
		public UIDataSourceInfo DynamicDisable { get; set; } = new UIDataSourceInfo(); // 0x4 (4)
		
		[ContainerField(Name: "DynamicNewContent", Offset: 20, NameHash: 3743471429, Flags: 41)]
		public UIDataSourceInfo DynamicNewContent { get; set; } = new UIDataSourceInfo(); // 0x14 (20)
		
		[ContainerField(Name: "AppendPlatformToSID", Offset: 36, NameHash: 4010498481, Flags: 49325), LayoutImmutable, Blittable]
		public bool AppendPlatformToSID { get; set; } // 0x24 (36)
		
		[ContainerField(Name: "ExcludeInRetail", Offset: 37, NameHash: 243223587, Flags: 49325), LayoutImmutable, Blittable]
		public bool ExcludeInRetail { get; set; } // 0x25 (37)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2972930359:
					ItemName = (string) p_Value;
					break;

				case 2500014788:
					DynamicDisable = (UIDataSourceInfo) p_Value;
					break;

				case 3743471429:
					DynamicNewContent = (UIDataSourceInfo) p_Value;
					break;

				case 4010498481:
					AppendPlatformToSID = (bool) p_Value;
					break;

				case 243223587:
					ExcludeInRetail = (bool) p_Value;
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
				case 2972930359:
					return ItemName;

				case 2500014788:
					return DynamicDisable;

				case 3743471429:
					return DynamicNewContent;

				case 4010498481:
					return AppendPlatformToSID;

				case 243223587:
					return ExcludeInRetail;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2972930359:
					return typeof(StaticListItem).GetProperty(nameof(ItemName));

				case 2500014788:
					return typeof(StaticListItem).GetProperty(nameof(DynamicDisable));

				case 3743471429:
					return typeof(StaticListItem).GetProperty(nameof(DynamicNewContent));

				case 4010498481:
					return typeof(StaticListItem).GetProperty(nameof(AppendPlatformToSID));

				case 243223587:
					return typeof(StaticListItem).GetProperty(nameof(ExcludeInRetail));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
