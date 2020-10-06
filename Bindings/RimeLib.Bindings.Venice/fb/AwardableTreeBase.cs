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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class AwardableTreeBase : 
		TreeBase
	{
		protected CtrRef<StatCategoryTreeCollection> m_StatCategoryTreeCollection = new CtrRef<StatCategoryTreeCollection>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(3707151255), ContainerCtrRef]
		public CtrRef<StatCategoryTreeCollection> StatCategoryTreeCollection { get { return m_StatCategoryTreeCollection; } set { if (OnPropertyChanging("AwardableTreeBase." + nameof(StatCategoryTreeCollection), this, m_StatCategoryTreeCollection, value)) m_StatCategoryTreeCollection = value; } } // 0xC (12)
		
		protected RefArray<CriteriaData> m_GeneralCriteria = new RefArray<CriteriaData>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(3769054304), ContainerRefArray]
		public RefArray<CriteriaData> GeneralCriteria { get { return m_GeneralCriteria; } set { if (OnPropertyChanging("AwardableTreeBase." + nameof(GeneralCriteria), this, m_GeneralCriteria, value)) m_GeneralCriteria = value; } } // 0x10 (16)
		
		protected bool m_GeneralStatistics = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3752225974)]
		public bool GeneralStatistics { get { return m_GeneralStatistics; } set { if (OnPropertyChanging("AwardableTreeBase." + nameof(GeneralStatistics), this, m_GeneralStatistics, value)) m_GeneralStatistics = value; } } // 0x14 (20)
		
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
