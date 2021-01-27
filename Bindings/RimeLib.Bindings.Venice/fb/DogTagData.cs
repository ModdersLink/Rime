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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 68)]
	public class DogTagData : 
		UnlockAssetBase
	{
		protected string m_NameSID = string.Empty;
		[ContainerField(Name: "NameSID", Offset: 40, NameHash: 3153746364, Flags: 16509), LayoutImmutable]
		public string NameSID { get { return m_NameSID; } set { if (OnPropertyChanging("DogTagData." + nameof(NameSID), this, m_NameSID, value)) m_NameSID = value; } } // 0x28 (40)
		
		protected string m_DescriptionSID = string.Empty;
		[ContainerField(Name: "DescriptionSID", Offset: 44, NameHash: 1844416573, Flags: 16509), LayoutImmutable]
		public string DescriptionSID { get { return m_DescriptionSID; } set { if (OnPropertyChanging("DogTagData." + nameof(DescriptionSID), this, m_DescriptionSID, value)) m_DescriptionSID = value; } } // 0x2C (44)
		
		protected string m_ImageName = string.Empty;
		[ContainerField(Name: "ImageName", Offset: 48, NameHash: 2678981541, Flags: 16509), LayoutImmutable]
		public string ImageName { get { return m_ImageName; } set { if (OnPropertyChanging("DogTagData." + nameof(ImageName), this, m_ImageName, value)) m_ImageName = value; } } // 0x30 (48)
		
		protected string m_SmallImageName = string.Empty;
		[ContainerField(Name: "SmallImageName", Offset: 52, NameHash: 567066714, Flags: 16509), LayoutImmutable]
		public string SmallImageName { get { return m_SmallImageName; } set { if (OnPropertyChanging("DogTagData." + nameof(SmallImageName), this, m_SmallImageName, value)) m_SmallImageName = value; } } // 0x34 (52)
		
		protected DogTagCategory m_Category = new DogTagCategory();
		[ContainerField(Name: "Category", Offset: 56, NameHash: 3455858997, Flags: 137)]
		public DogTagCategory Category { get { return m_Category; } set { if (OnPropertyChanging("DogTagData." + nameof(Category), this, m_Category, value)) m_Category = value; } } // 0x38 (56)
		
		protected bool m_InvertText = new bool();
		[ContainerField(Name: "InvertText", Offset: 60, NameHash: 3752948714, Flags: 49325), LayoutImmutable, Blittable]
		public bool InvertText { get { return m_InvertText; } set { if (OnPropertyChanging("DogTagData." + nameof(InvertText), this, m_InvertText, value)) m_InvertText = value; } } // 0x3C (60)
		
		protected bool m_IsAlwaysAvailable = new bool();
		[ContainerField(Name: "IsAlwaysAvailable", Offset: 61, NameHash: 2894636375, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsAlwaysAvailable { get { return m_IsAlwaysAvailable; } set { if (OnPropertyChanging("DogTagData." + nameof(IsAlwaysAvailable), this, m_IsAlwaysAvailable, value)) m_IsAlwaysAvailable = value; } } // 0x3D (61)
		
		protected bool m_ExcludedOnXenon = new bool();
		[ContainerField(Name: "ExcludedOnXenon", Offset: 62, NameHash: 3068680308, Flags: 49325), LayoutImmutable, Blittable]
		public bool ExcludedOnXenon { get { return m_ExcludedOnXenon; } set { if (OnPropertyChanging("DogTagData." + nameof(ExcludedOnXenon), this, m_ExcludedOnXenon, value)) m_ExcludedOnXenon = value; } } // 0x3E (62)
		
		protected bool m_ExcludedOnPs3 = new bool();
		[ContainerField(Name: "ExcludedOnPs3", Offset: 63, NameHash: 144791190, Flags: 49325), LayoutImmutable, Blittable]
		public bool ExcludedOnPs3 { get { return m_ExcludedOnPs3; } set { if (OnPropertyChanging("DogTagData." + nameof(ExcludedOnPs3), this, m_ExcludedOnPs3, value)) m_ExcludedOnPs3 = value; } } // 0x3F (63)
		
		protected bool m_ExcludedOnWin32 = new bool();
		[ContainerField(Name: "ExcludedOnWin32", Offset: 64, NameHash: 3056065655, Flags: 49325), LayoutImmutable, Blittable]
		public bool ExcludedOnWin32 { get { return m_ExcludedOnWin32; } set { if (OnPropertyChanging("DogTagData." + nameof(ExcludedOnWin32), this, m_ExcludedOnWin32, value)) m_ExcludedOnWin32 = value; } } // 0x40 (64)
		
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
