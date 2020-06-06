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
	public class UIItemDescription : 
		DataContainer
	{
		[ContainerField(8)]
		public List<uint> ItemIds { get; set; } = new List<uint>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool IgnoreBuild { get; set; } // 0xC (12)
		
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
