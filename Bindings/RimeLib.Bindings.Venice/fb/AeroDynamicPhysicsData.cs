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
	public class AeroDynamicPhysicsData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BodyDrag { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BodyDragOffsetYZ { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BodyDragOffsetXZ { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BodyDragOffsetXY { get; set; } = new Vec3(); // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1687378661:
					BodyDrag = (Vec3) p_Value;
					break;

				case 2051746155:
					BodyDragOffsetYZ = (Vec3) p_Value;
					break;

				case 2051746122:
					BodyDragOffsetXZ = (Vec3) p_Value;
					break;

				case 2051746121:
					BodyDragOffsetXY = (Vec3) p_Value;
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
				case 1687378661:
					return BodyDrag;

				case 2051746155:
					return BodyDragOffsetYZ;

				case 2051746122:
					return BodyDragOffsetXZ;

				case 2051746121:
					return BodyDragOffsetXY;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1687378661:
					return typeof(AeroDynamicPhysicsData).GetProperty(nameof(BodyDrag));

				case 2051746155:
					return typeof(AeroDynamicPhysicsData).GetProperty(nameof(BodyDragOffsetYZ));

				case 2051746122:
					return typeof(AeroDynamicPhysicsData).GetProperty(nameof(BodyDragOffsetXZ));

				case 2051746121:
					return typeof(AeroDynamicPhysicsData).GetProperty(nameof(BodyDragOffsetXY));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
