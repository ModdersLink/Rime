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
	public class StatsCategoryBaseData : 
		TreeNodeBase
	{
		protected RefArray<StatsCategoryBaseData> m_BaseSubCategories = new RefArray<StatsCategoryBaseData>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(2950064290), ContainerRefArray]
		public RefArray<StatsCategoryBaseData> BaseSubCategories { get { return m_BaseSubCategories; } set { if (OnPropertyChanging("StatsCategoryBaseData." + nameof(BaseSubCategories), this, m_BaseSubCategories, value)) m_BaseSubCategories = value; } } // 0xC (12)
		
		protected string m_Code = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088844616)]
		public string Code { get { return m_Code; } set { if (OnPropertyChanging("StatsCategoryBaseData." + nameof(Code), this, m_Code, value)) m_Code = value; } } // 0x10 (16)
		
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
