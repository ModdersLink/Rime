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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class StatCategoriesBaseTree : 
		TreeBase
	{
		protected RefArray<StatsCategoryBaseData> m_RootBaseCategories = new RefArray<StatsCategoryBaseData>();
		[ContainerField(Name: "RootBaseCategories", Offset: 12, NameHash: 3956513984, Flags: 65)]
		public RefArray<StatsCategoryBaseData> RootBaseCategories { get { return m_RootBaseCategories; } set { if (OnPropertyChanging("StatCategoriesBaseTree." + nameof(RootBaseCategories), this, m_RootBaseCategories, value)) m_RootBaseCategories = value; } } // 0xC (12)
		
		protected RefArray<CriteriaData> m_ParamX = new RefArray<CriteriaData>();
		[ContainerField(Name: "ParamX", Offset: 16, NameHash: 3371566706, Flags: 65)]
		public RefArray<CriteriaData> ParamX { get { return m_ParamX; } set { if (OnPropertyChanging("StatCategoriesBaseTree." + nameof(ParamX), this, m_ParamX, value)) m_ParamX = value; } } // 0x10 (16)
		
		protected RefArray<CriteriaData> m_ParamY = new RefArray<CriteriaData>();
		[ContainerField(Name: "ParamY", Offset: 20, NameHash: 3371566707, Flags: 65)]
		public RefArray<CriteriaData> ParamY { get { return m_ParamY; } set { if (OnPropertyChanging("StatCategoriesBaseTree." + nameof(ParamY), this, m_ParamY, value)) m_ParamY = value; } } // 0x14 (20)
		
		protected bool m_ProcessAllLevelsInTree = new bool();
		[ContainerField(Name: "ProcessAllLevelsInTree", Offset: 24, NameHash: 2812093131, Flags: 49325), LayoutImmutable, Blittable]
		public bool ProcessAllLevelsInTree { get { return m_ProcessAllLevelsInTree; } set { if (OnPropertyChanging("StatCategoriesBaseTree." + nameof(ProcessAllLevelsInTree), this, m_ProcessAllLevelsInTree, value)) m_ProcessAllLevelsInTree = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3956513984:
					RootBaseCategories = (RefArray<StatsCategoryBaseData>) p_Value;
					break;

				case 3371566706:
					ParamX = (RefArray<CriteriaData>) p_Value;
					break;

				case 3371566707:
					ParamY = (RefArray<CriteriaData>) p_Value;
					break;

				case 2812093131:
					ProcessAllLevelsInTree = (bool) p_Value;
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
				case 3956513984:
					return RootBaseCategories;

				case 3371566706:
					return ParamX;

				case 3371566707:
					return ParamY;

				case 2812093131:
					return ProcessAllLevelsInTree;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3956513984:
					return typeof(StatCategoriesBaseTree).GetProperty(nameof(RootBaseCategories));

				case 3371566706:
					return typeof(StatCategoriesBaseTree).GetProperty(nameof(ParamX));

				case 3371566707:
					return typeof(StatCategoriesBaseTree).GetProperty(nameof(ParamY));

				case 2812093131:
					return typeof(StatCategoriesBaseTree).GetProperty(nameof(ProcessAllLevelsInTree));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
