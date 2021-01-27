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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class StatCategoryTreeCollection : 
		Asset
	{
		protected RefArray<StatCategoriesBaseTree> m_CategoryTrees = new RefArray<StatCategoriesBaseTree>();
		[ContainerField(Name: "CategoryTrees", Offset: 12, NameHash: 1465205664, Flags: 65)]
		public RefArray<StatCategoriesBaseTree> CategoryTrees { get { return m_CategoryTrees; } set { if (OnPropertyChanging("StatCategoryTreeCollection." + nameof(CategoryTrees), this, m_CategoryTrees, value)) m_CategoryTrees = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1465205664:
					CategoryTrees = (RefArray<StatCategoriesBaseTree>) p_Value;
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
				case 1465205664:
					return CategoryTrees;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1465205664:
					return typeof(StatCategoryTreeCollection).GetProperty(nameof(CategoryTrees));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
