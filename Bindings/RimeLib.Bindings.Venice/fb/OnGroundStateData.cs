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
	public class OnGroundStateData : 
		CharacterStateData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float JumpDelay { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float JumpStaminaPenalty { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float AllowedDistanceFromGround { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool GroundHugging { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool LimitDownwardVelocity { get; set; } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1846535730:
					JumpDelay = (float) p_Value;
					break;

				case 1315207185:
					JumpStaminaPenalty = (float) p_Value;
					break;

				case 639560781:
					AllowedDistanceFromGround = (float) p_Value;
					break;

				case 190843837:
					GroundHugging = (bool) p_Value;
					break;

				case 2249794005:
					LimitDownwardVelocity = (bool) p_Value;
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
				case 1846535730:
					return JumpDelay;

				case 1315207185:
					return JumpStaminaPenalty;

				case 639560781:
					return AllowedDistanceFromGround;

				case 190843837:
					return GroundHugging;

				case 2249794005:
					return LimitDownwardVelocity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1846535730:
					return typeof(OnGroundStateData).GetProperty(nameof(JumpDelay));

				case 1315207185:
					return typeof(OnGroundStateData).GetProperty(nameof(JumpStaminaPenalty));

				case 639560781:
					return typeof(OnGroundStateData).GetProperty(nameof(AllowedDistanceFromGround));

				case 190843837:
					return typeof(OnGroundStateData).GetProperty(nameof(GroundHugging));

				case 2249794005:
					return typeof(OnGroundStateData).GetProperty(nameof(LimitDownwardVelocity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
