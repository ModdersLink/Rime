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
	public class CriteriaStarData : 
		CriteriaData
	{
		[ContainerField(52)]
		public CtrRef<CriteriaStarCategoryData> StarTemplate { get; set; } = new CtrRef<CriteriaStarCategoryData>(); // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 982112673:
					StarTemplate = (CtrRef<CriteriaStarCategoryData>) p_Value;
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
				case 982112673:
					return StarTemplate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 982112673:
					return typeof(CriteriaStarData).GetProperty(nameof(StarTemplate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
