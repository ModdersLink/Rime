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
	public class UIEventAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string Category { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public List<string> EventList { get; set; } = new List<string>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3455858997:
					Category = (string) p_Value;
					break;

				case 4132327979:
					EventList = (List<string>) p_Value;
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
				case 3455858997:
					return Category;

				case 4132327979:
					return EventList;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3455858997:
					return typeof(UIEventAsset).GetProperty(nameof(Category));

				case 4132327979:
					return typeof(UIEventAsset).GetProperty(nameof(EventList));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
