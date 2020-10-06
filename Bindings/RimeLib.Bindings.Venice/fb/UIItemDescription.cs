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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class UIItemDescription : 
		DataContainer
	{
		protected List<uint> m_ItemIds = new List<uint>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(2693096110), ContainerArray]
		public List<uint> ItemIds { get { return m_ItemIds; } set { if (OnPropertyChanging("UIItemDescription." + nameof(ItemIds), this, m_ItemIds, value)) m_ItemIds = value; } } // 0x8 (8)
		
		protected bool m_IgnoreBuild = new bool();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1608120075)]
		public bool IgnoreBuild { get { return m_IgnoreBuild; } set { if (OnPropertyChanging("UIItemDescription." + nameof(IgnoreBuild), this, m_IgnoreBuild, value)) m_IgnoreBuild = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2693096110:
					ItemIds = (List<uint>) p_Value;
					break;

				case 1608120075:
					IgnoreBuild = (bool) p_Value;
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
				case 2693096110:
					return ItemIds;

				case 1608120075:
					return IgnoreBuild;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2693096110:
					return typeof(UIItemDescription).GetProperty(nameof(ItemIds));

				case 1608120075:
					return typeof(UIItemDescription).GetProperty(nameof(IgnoreBuild));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
