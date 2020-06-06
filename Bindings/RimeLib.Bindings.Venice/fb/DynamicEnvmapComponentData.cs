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
	public class DynamicEnvmapComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 KeyColorEnvmap { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 GroundColorEnvmap { get; set; } = new Vec3(); // 0x70 (112)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyColorEnvmap { get; set; } = new Vec3(); // 0x80 (128)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x90 (144)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1689648046:
					KeyColorEnvmap = (Vec3) p_Value;
					break;

				case 3864914716:
					GroundColorEnvmap = (Vec3) p_Value;
					break;

				case 297337912:
					SkyColorEnvmap = (Vec3) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 1689648046:
					return KeyColorEnvmap;

				case 3864914716:
					return GroundColorEnvmap;

				case 297337912:
					return SkyColorEnvmap;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1689648046:
					return typeof(DynamicEnvmapComponentData).GetProperty(nameof(KeyColorEnvmap));

				case 3864914716:
					return typeof(DynamicEnvmapComponentData).GetProperty(nameof(GroundColorEnvmap));

				case 297337912:
					return typeof(DynamicEnvmapComponentData).GetProperty(nameof(SkyColorEnvmap));

				case 2342790116:
					return typeof(DynamicEnvmapComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
