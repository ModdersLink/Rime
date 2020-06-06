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
	public class MotionDampingData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 LinearModifier { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float Pitch { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float Yaw { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float Roll { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float Linear { get; set; } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2104370415:
					LinearModifier = (Vec3) p_Value;
					break;

				case 232604323:
					Pitch = (float) p_Value;
					break;

				case 193468618:
					Yaw = (float) p_Value;
					break;

				case 2089387576:
					Roll = (float) p_Value;
					break;

				case 2893456344:
					Linear = (float) p_Value;
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
				case 2104370415:
					return LinearModifier;

				case 232604323:
					return Pitch;

				case 193468618:
					return Yaw;

				case 2089387576:
					return Roll;

				case 2893456344:
					return Linear;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2104370415:
					return typeof(MotionDampingData).GetProperty(nameof(LinearModifier));

				case 232604323:
					return typeof(MotionDampingData).GetProperty(nameof(Pitch));

				case 193468618:
					return typeof(MotionDampingData).GetProperty(nameof(Yaw));

				case 2089387576:
					return typeof(MotionDampingData).GetProperty(nameof(Roll));

				case 2893456344:
					return typeof(MotionDampingData).GetProperty(nameof(Linear));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
