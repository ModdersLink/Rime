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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class DebugMenuItemEntityData : 
		GameEntityData
	{
		protected DebugMenuItemType m_ItemType = new DebugMenuItemType();
		[ContainerField(96), MemberInfoFlag(137), ContainerFieldNameHash(2972161480)]
		public DebugMenuItemType ItemType { get { return m_ItemType; } set { if (OnPropertyChanging("DebugMenuItemEntityData." + nameof(ItemType), this, m_ItemType, value)) m_ItemType = value; } } // 0x60 (96)
		
		protected string m_Text = string.Empty;
		[ContainerField(100), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2089309304)]
		public string Text { get { return m_Text; } set { if (OnPropertyChanging("DebugMenuItemEntityData." + nameof(Text), this, m_Text, value)) m_Text = value; } } // 0x64 (100)
		
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
