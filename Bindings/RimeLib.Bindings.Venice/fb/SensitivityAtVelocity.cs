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
	public class SensitivityAtVelocity : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float SteeringSensitivity { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Velocity { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1426555133:
					SteeringSensitivity = (float) p_Value;
					break;

				case 3860766482:
					Velocity = (float) p_Value;
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
				case 1426555133:
					return SteeringSensitivity;

				case 3860766482:
					return Velocity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1426555133:
					return typeof(SensitivityAtVelocity).GetProperty(nameof(SteeringSensitivity));

				case 3860766482:
					return typeof(SensitivityAtVelocity).GetProperty(nameof(Velocity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
