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
	[ContainerType(4)]
	public class SubWorldInclusion : 
		Asset
	{
		protected RefArray<SubWorldInclusionCriterion> m_Criteria = new RefArray<SubWorldInclusionCriterion>();
		[ContainerField(12), ContainerFieldNameHash(335452726)]
		public RefArray<SubWorldInclusionCriterion> Criteria { get { return m_Criteria; } set { if (OnPropertyChanging("SubWorldInclusion." + nameof(Criteria), this, m_Criteria, value)) m_Criteria = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 335452726:
					Criteria = (RefArray<SubWorldInclusionCriterion>) p_Value;
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
				case 335452726:
					return Criteria;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 335452726:
					return typeof(SubWorldInclusion).GetProperty(nameof(Criteria));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
