///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class WeaponShotModifier : 
		WeaponModifierBase
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialSpeed { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int NumberOfBulletsPerShell { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3681055580:
					InitialSpeed = (Vec3) p_Value;
					break;

				case 464437027:
					NumberOfBulletsPerShell = (int) p_Value;
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
				case 3681055580:
					return InitialSpeed;

				case 464437027:
					return NumberOfBulletsPerShell;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3681055580:
					return typeof(WeaponShotModifier).GetProperty(nameof(InitialSpeed));

				case 464437027:
					return typeof(WeaponShotModifier).GetProperty(nameof(NumberOfBulletsPerShell));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
