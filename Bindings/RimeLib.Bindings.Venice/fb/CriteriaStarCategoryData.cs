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
	public class CriteriaStarCategoryData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CriteriaStarCategoryInstance> CriteriaInstances { get; set; } = new List<CriteriaStarCategoryInstance>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 686038796:
					CriteriaInstances = (List<CriteriaStarCategoryInstance>) p_Value;
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
				case 686038796:
					return CriteriaInstances;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 686038796:
					return typeof(CriteriaStarCategoryData).GetProperty(nameof(CriteriaInstances));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
