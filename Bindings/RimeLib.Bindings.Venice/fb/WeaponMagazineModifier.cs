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
	public class WeaponMagazineModifier : 
		WeaponModifierBase
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int MagazineCapacity { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int NumberOfMagazines { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1634670339:
					MagazineCapacity = (int) p_Value;
					break;

				case 2684433166:
					NumberOfMagazines = (int) p_Value;
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
				case 1634670339:
					return MagazineCapacity;

				case 2684433166:
					return NumberOfMagazines;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1634670339:
					return typeof(WeaponMagazineModifier).GetProperty(nameof(MagazineCapacity));

				case 2684433166:
					return typeof(WeaponMagazineModifier).GetProperty(nameof(NumberOfMagazines));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
