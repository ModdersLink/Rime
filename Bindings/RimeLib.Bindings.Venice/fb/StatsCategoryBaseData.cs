///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class StatsCategoryBaseData : 
		TreeNodeBase
	{
		[ContainerField(12)]
		public RefArray<StatsCategoryBaseData> BaseSubCategories { get; set; } = new RefArray<StatsCategoryBaseData>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string Code { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2950064290:
					BaseSubCategories = (RefArray<StatsCategoryBaseData>) p_Value;
					break;

				case 2088844616:
					Code = (string) p_Value;
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
				case 2950064290:
					return BaseSubCategories;

				case 2088844616:
					return Code;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2950064290:
					return typeof(StatsCategoryBaseData).GetProperty(nameof(BaseSubCategories));

				case 2088844616:
					return typeof(StatsCategoryBaseData).GetProperty(nameof(Code));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
