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
	public class FakeSpringData : 
		FakePhysicsData
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Direction { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float Length { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float Acceleration { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float ProgressiveExponent { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float Damping { get; set; } // 0x4C (76)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2698949952:
					Direction = (Vec3) p_Value;
					break;

				case 2906827577:
					Length = (float) p_Value;
					break;

				case 62601415:
					Acceleration = (float) p_Value;
					break;

				case 487101329:
					ProgressiveExponent = (float) p_Value;
					break;

				case 3862601053:
					Damping = (float) p_Value;
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
				case 2698949952:
					return Direction;

				case 2906827577:
					return Length;

				case 62601415:
					return Acceleration;

				case 487101329:
					return ProgressiveExponent;

				case 3862601053:
					return Damping;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2698949952:
					return typeof(FakeSpringData).GetProperty(nameof(Direction));

				case 2906827577:
					return typeof(FakeSpringData).GetProperty(nameof(Length));

				case 62601415:
					return typeof(FakeSpringData).GetProperty(nameof(Acceleration));

				case 487101329:
					return typeof(FakeSpringData).GetProperty(nameof(ProgressiveExponent));

				case 3862601053:
					return typeof(FakeSpringData).GetProperty(nameof(Damping));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
