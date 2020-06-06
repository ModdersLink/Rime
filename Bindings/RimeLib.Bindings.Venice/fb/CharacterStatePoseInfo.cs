///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class CharacterStatePoseInfo : 
		DataContainer
	{
		[ContainerField(8)]
		public CharacterPoseType PoseType { get; set; } = new CharacterPoseType(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Velocity { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float AccelerationGain { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float DecelerationGain { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float SprintGain { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float SprintMultiplier { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public SpeedModifierData SpeedModifier { get; set; } = new SpeedModifierData(); // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3415409588:
					PoseType = (CharacterPoseType) Enum.ToObject(typeof(CharacterPoseType), p_Value);
					break;

				case 3860766482:
					Velocity = (float) p_Value;
					break;

				case 1824913062:
					AccelerationGain = (float) p_Value;
					break;

				case 1680484485:
					DecelerationGain = (float) p_Value;
					break;

				case 1424279590:
					SprintGain = (float) p_Value;
					break;

				case 4088490892:
					SprintMultiplier = (float) p_Value;
					break;

				case 2276662581:
					SpeedModifier = (SpeedModifierData) p_Value;
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
				case 3415409588:
					return PoseType;

				case 3860766482:
					return Velocity;

				case 1824913062:
					return AccelerationGain;

				case 1680484485:
					return DecelerationGain;

				case 1424279590:
					return SprintGain;

				case 4088490892:
					return SprintMultiplier;

				case 2276662581:
					return SpeedModifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3415409588:
					return typeof(CharacterStatePoseInfo).GetProperty(nameof(PoseType));

				case 3860766482:
					return typeof(CharacterStatePoseInfo).GetProperty(nameof(Velocity));

				case 1824913062:
					return typeof(CharacterStatePoseInfo).GetProperty(nameof(AccelerationGain));

				case 1680484485:
					return typeof(CharacterStatePoseInfo).GetProperty(nameof(DecelerationGain));

				case 1424279590:
					return typeof(CharacterStatePoseInfo).GetProperty(nameof(SprintGain));

				case 4088490892:
					return typeof(CharacterStatePoseInfo).GetProperty(nameof(SprintMultiplier));

				case 2276662581:
					return typeof(CharacterStatePoseInfo).GetProperty(nameof(SpeedModifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
