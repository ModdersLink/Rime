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
	public class StatsCategoryData : 
		StatsCategoryBaseData
	{
		[ContainerField(20)]
		public RefArray<StatsCategoryData> Categories { get; set; } = new RefArray<StatsCategoryData>(); // 0x14 (20)
		
		[ContainerField(24)]
		public List<string> Members { get; set; } = new List<string>(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1039077843:
					Categories = (RefArray<StatsCategoryData>) p_Value;
					break;

				case 1446896454:
					Members = (List<string>) p_Value;
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
				case 1039077843:
					return Categories;

				case 1446896454:
					return Members;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1039077843:
					return typeof(StatsCategoryData).GetProperty(nameof(Categories));

				case 1446896454:
					return typeof(StatsCategoryData).GetProperty(nameof(Members));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
