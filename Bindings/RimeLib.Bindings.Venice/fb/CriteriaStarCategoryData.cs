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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class CriteriaStarCategoryData : 
		DataContainer
	{
		protected List<CriteriaStarCategoryInstance> m_CriteriaInstances = new List<CriteriaStarCategoryInstance>();
		[ContainerField(Name: "CriteriaInstances", Offset: 8, NameHash: 686038796, Flags: 65)]
		public List<CriteriaStarCategoryInstance> CriteriaInstances { get { return m_CriteriaInstances; } set { if (OnPropertyChanging("CriteriaStarCategoryData." + nameof(CriteriaInstances), this, m_CriteriaInstances, value)) m_CriteriaInstances = value; } } // 0x8 (8)
		
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
