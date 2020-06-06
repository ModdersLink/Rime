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
	public class StatCategoriesBaseTree : 
		TreeBase
	{
		[ContainerField(12)]
		public RefArray<StatsCategoryBaseData> RootBaseCategories { get; set; } = new RefArray<StatsCategoryBaseData>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<CriteriaData> ParamX { get; set; } = new RefArray<CriteriaData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<CriteriaData> ParamY { get; set; } = new RefArray<CriteriaData>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool ProcessAllLevelsInTree { get; set; } // 0x18 (24)
		
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
