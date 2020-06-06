///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class DebugMenuItemEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public DebugMenuItemType ItemType { get; set; } = new DebugMenuItemType(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable]
		public string Text { get; set; } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2972161480:
					ItemType = (DebugMenuItemType) Enum.ToObject(typeof(DebugMenuItemType), p_Value);
					break;

				case 2089309304:
					Text = (string) p_Value;
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
				case 2972161480:
					return ItemType;

				case 2089309304:
					return Text;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2972161480:
					return typeof(DebugMenuItemEntityData).GetProperty(nameof(ItemType));

				case 2089309304:
					return typeof(DebugMenuItemEntityData).GetProperty(nameof(Text));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
