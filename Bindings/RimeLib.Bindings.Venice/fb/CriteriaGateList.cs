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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class CriteriaGateList : 
		Asset
	{
		protected List<float> m_CriteriaGates = new List<float>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(4130539826), ContainerArray]
		public List<float> CriteriaGates { get { return m_CriteriaGates; } set { if (OnPropertyChanging("CriteriaGateList." + nameof(CriteriaGates), this, m_CriteriaGates, value)) m_CriteriaGates = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4130539826:
					CriteriaGates = (List<float>) p_Value;
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
				case 4130539826:
					return CriteriaGates;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4130539826:
					return typeof(CriteriaGateList).GetProperty(nameof(CriteriaGates));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
