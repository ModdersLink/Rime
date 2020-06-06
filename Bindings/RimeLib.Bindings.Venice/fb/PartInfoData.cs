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
	public class PartInfoData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox Aabb { get; set; } = new AxisAlignedBox(); // 0x0 (0)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Translation { get; set; } = new Vec3(); // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088635333:
					Aabb = (AxisAlignedBox) p_Value;
					break;

				case 2696156750:
					Translation = (Vec3) p_Value;
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
				case 2088635333:
					return Aabb;

				case 2696156750:
					return Translation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088635333:
					return typeof(PartInfoData).GetProperty(nameof(Aabb));

				case 2696156750:
					return typeof(PartInfoData).GetProperty(nameof(Translation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
