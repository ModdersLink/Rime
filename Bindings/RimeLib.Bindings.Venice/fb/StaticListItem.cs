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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(40), ContainerStruct]
	public class StaticListItem : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string ItemName { get; set; } // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(41)]
		public UIDataSourceInfo DynamicDisable { get; set; } = new UIDataSourceInfo(); // 0x4 (4)
		
		[ContainerField(20), MemberInfoFlag(41)]
		public UIDataSourceInfo DynamicNewContent { get; set; } = new UIDataSourceInfo(); // 0x14 (20)
		
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool AppendPlatformToSID { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
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
