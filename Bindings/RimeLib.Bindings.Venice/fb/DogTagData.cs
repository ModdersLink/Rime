///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class DogTagData : 
		UnlockAssetBase
	{
		[ContainerField(40), LayoutImmutable]
		public string NameSID { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable]
		public string DescriptionSID { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable]
		public string ImageName { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable]
		public string SmallImageName { get; set; } // 0x34 (52)
		
		[ContainerField(56)]
		public DogTagCategory Category { get; set; } = new DogTagCategory(); // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool InvertText { get; set; } // 0x3C (60)
		
		[ContainerField(61), LayoutImmutable, Blittable]
		public bool IsAlwaysAvailable { get; set; } // 0x3D (61)
		
		[ContainerField(62), LayoutImmutable, Blittable]
		public bool ExcludedOnXenon { get; set; } // 0x3E (62)
		
		[ContainerField(63), LayoutImmutable, Blittable]
		public bool ExcludedOnPs3 { get; set; } // 0x3F (63)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public bool ExcludedOnWin32 { get; set; } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3153746364:
					NameSID = (string) p_Value;
					break;

				case 1844416573:
					DescriptionSID = (string) p_Value;
					break;

				case 2678981541:
					ImageName = (string) p_Value;
					break;

				case 567066714:
					SmallImageName = (string) p_Value;
					break;

				case 3455858997:
					Category = (DogTagCategory) Enum.ToObject(typeof(DogTagCategory), p_Value);
					break;

				case 3752948714:
					InvertText = (bool) p_Value;
					break;

				case 2894636375:
					IsAlwaysAvailable = (bool) p_Value;
					break;

				case 3068680308:
					ExcludedOnXenon = (bool) p_Value;
					break;

				case 144791190:
					ExcludedOnPs3 = (bool) p_Value;
					break;

				case 3056065655:
					ExcludedOnWin32 = (bool) p_Value;
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
				case 3153746364:
					return NameSID;

				case 1844416573:
					return DescriptionSID;

				case 2678981541:
					return ImageName;

				case 567066714:
					return SmallImageName;

				case 3455858997:
					return Category;

				case 3752948714:
					return InvertText;

				case 2894636375:
					return IsAlwaysAvailable;

				case 3068680308:
					return ExcludedOnXenon;

				case 144791190:
					return ExcludedOnPs3;

				case 3056065655:
					return ExcludedOnWin32;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3153746364:
					return typeof(DogTagData).GetProperty(nameof(NameSID));

				case 1844416573:
					return typeof(DogTagData).GetProperty(nameof(DescriptionSID));

				case 2678981541:
					return typeof(DogTagData).GetProperty(nameof(ImageName));

				case 567066714:
					return typeof(DogTagData).GetProperty(nameof(SmallImageName));

				case 3455858997:
					return typeof(DogTagData).GetProperty(nameof(Category));

				case 3752948714:
					return typeof(DogTagData).GetProperty(nameof(InvertText));

				case 2894636375:
					return typeof(DogTagData).GetProperty(nameof(IsAlwaysAvailable));

				case 3068680308:
					return typeof(DogTagData).GetProperty(nameof(ExcludedOnXenon));

				case 144791190:
					return typeof(DogTagData).GetProperty(nameof(ExcludedOnPs3));

				case 3056065655:
					return typeof(DogTagData).GetProperty(nameof(ExcludedOnWin32));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
