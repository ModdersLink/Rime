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
	public class PackagingCellData : 
		EntityData
	{
		[ContainerField(12)]
		public RefArray<PackagingRule> Rules { get; set; } = new RefArray<PackagingRule>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<PackagingCellData> Targets { get; set; } = new RefArray<PackagingCellData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public List<Vec2> Shape { get; set; } = new List<Vec2>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229400568:
					Rules = (RefArray<PackagingRule>) p_Value;
					break;

				case 3016537383:
					Targets = (RefArray<PackagingCellData>) p_Value;
					break;

				case 231753450:
					Shape = (List<Vec2>) p_Value;
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
				case 229400568:
					return Rules;

				case 3016537383:
					return Targets;

				case 231753450:
					return Shape;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229400568:
					return typeof(PackagingCellData).GetProperty(nameof(Rules));

				case 3016537383:
					return typeof(PackagingCellData).GetProperty(nameof(Targets));

				case 231753450:
					return typeof(PackagingCellData).GetProperty(nameof(Shape));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
