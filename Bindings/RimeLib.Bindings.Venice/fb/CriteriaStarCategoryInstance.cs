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
	public class CriteriaStarCategoryInstance : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(4)]
		public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new CtrRef<StatsCategoryBaseData>(); // 0x4 (4)
		
		[ContainerField(8)]
		public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new CtrRef<StatsCategoryBaseData>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 3371566706:
					ParamX = (CtrRef<StatsCategoryBaseData>) p_Value;
					break;

				case 3371566707:
					ParamY = (CtrRef<StatsCategoryBaseData>) p_Value;
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
				case 2088949890:
					return Name;

				case 3371566706:
					return ParamX;

				case 3371566707:
					return ParamY;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(CriteriaStarCategoryInstance).GetProperty(nameof(Name));

				case 3371566706:
					return typeof(CriteriaStarCategoryInstance).GetProperty(nameof(ParamX));

				case 3371566707:
					return typeof(CriteriaStarCategoryInstance).GetProperty(nameof(ParamY));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
