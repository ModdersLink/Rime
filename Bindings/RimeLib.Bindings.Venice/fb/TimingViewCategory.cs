///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class TimingViewCategory : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string CategoryName { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public List<string> Keywords { get; set; } = new List<string>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float SpuBudget { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float CpuBudget { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float GpuBudget { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1997430002:
					CategoryName = (string) p_Value;
					break;

				case 4091618511:
					Keywords = (List<string>) p_Value;
					break;

				case 3212164214:
					SpuBudget = (float) p_Value;
					break;

				case 1659158630:
					CpuBudget = (float) p_Value;
					break;

				case 4164444258:
					GpuBudget = (float) p_Value;
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
				case 1997430002:
					return CategoryName;

				case 4091618511:
					return Keywords;

				case 3212164214:
					return SpuBudget;

				case 1659158630:
					return CpuBudget;

				case 4164444258:
					return GpuBudget;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1997430002:
					return typeof(TimingViewCategory).GetProperty(nameof(CategoryName));

				case 4091618511:
					return typeof(TimingViewCategory).GetProperty(nameof(Keywords));

				case 3212164214:
					return typeof(TimingViewCategory).GetProperty(nameof(SpuBudget));

				case 1659158630:
					return typeof(TimingViewCategory).GetProperty(nameof(CpuBudget));

				case 4164444258:
					return typeof(TimingViewCategory).GetProperty(nameof(GpuBudget));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
