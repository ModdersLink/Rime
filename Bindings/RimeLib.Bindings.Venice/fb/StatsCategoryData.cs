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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class StatsCategoryData : 
		StatsCategoryBaseData
	{
		protected RefArray<StatsCategoryData> m_Categories = new RefArray<StatsCategoryData>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(1039077843), ContainerRefArray]
		public RefArray<StatsCategoryData> Categories { get { return m_Categories; } set { if (OnPropertyChanging("StatsCategoryData." + nameof(Categories), this, m_Categories, value)) m_Categories = value; } } // 0x14 (20)
		
		protected List<string> m_Members = new List<string>();
		[ContainerField(24), MemberInfoFlag(65), ContainerFieldNameHash(1446896454), ContainerArray]
		public List<string> Members { get { return m_Members; } set { if (OnPropertyChanging("StatsCategoryData." + nameof(Members), this, m_Members, value)) m_Members = value; } } // 0x18 (24)
		
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
