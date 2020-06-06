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
	public class AwardableTreeBase : 
		TreeBase
	{
		[ContainerField(12)]
		public CtrRef<StatCategoryTreeCollection> StatCategoryTreeCollection { get; set; } = new CtrRef<StatCategoryTreeCollection>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<CriteriaData> GeneralCriteria { get; set; } = new RefArray<CriteriaData>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool GeneralStatistics { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3707151255:
					StatCategoryTreeCollection = (CtrRef<StatCategoryTreeCollection>) p_Value;
					break;

				case 3769054304:
					GeneralCriteria = (RefArray<CriteriaData>) p_Value;
					break;

				case 3752225974:
					GeneralStatistics = (bool) p_Value;
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
				case 3707151255:
					return StatCategoryTreeCollection;

				case 3769054304:
					return GeneralCriteria;

				case 3752225974:
					return GeneralStatistics;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3707151255:
					return typeof(AwardableTreeBase).GetProperty(nameof(StatCategoryTreeCollection));

				case 3769054304:
					return typeof(AwardableTreeBase).GetProperty(nameof(GeneralCriteria));

				case 3752225974:
					return typeof(AwardableTreeBase).GetProperty(nameof(GeneralStatistics));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
