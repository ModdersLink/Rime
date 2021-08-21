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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class StatCategoriesTree : 
		StatCategoriesBaseTree
	{
		protected RefArray<StatsCategoryData> m_Categories = new RefArray<StatsCategoryData>();
		[ContainerField(Name: "Categories", Offset: 28, NameHash: 1039077843, Flags: 65)]
		public RefArray<StatsCategoryData> Categories { get { return m_Categories; } set { if (OnPropertyChanging("StatCategoriesTree." + nameof(Categories), this, m_Categories, value)) m_Categories = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1039077843:
					Categories = (RefArray<StatsCategoryData>) p_Value;
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

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1039077843:
					return typeof(StatCategoriesTree).GetProperty(nameof(Categories));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
