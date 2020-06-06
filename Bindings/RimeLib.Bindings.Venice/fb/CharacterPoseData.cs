///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class CharacterPoseData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 EyePosition { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CollisionBoxMaxExpand { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CollisionBoxMinExpand { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float Height { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float StepHeight { get; set; } // 0x44 (68)
		
		[ContainerField(72)]
		public List<Vec2> ThrottleModifierCurve { get; set; } = new List<Vec2>(); // 0x48 (72)
		
		[ContainerField(76)]
		public CharacterPoseType PoseType { get; set; } = new CharacterPoseType(); // 0x4C (76)
		
		[ContainerField(80)]
		public CharacterPoseCollisionType CollisionType { get; set; } = new CharacterPoseCollisionType(); // 0x50 (80)
		
		[ContainerField(84)]
		public LookConstraintsData LookConstraints { get; set; } = new LookConstraintsData(); // 0x54 (84)
		
		[ContainerField(100)]
		public List<PoseTransitionTime> TransitionTimes { get; set; } = new List<PoseTransitionTime>(); // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2695753445:
					EyePosition = (Vec3) p_Value;
					break;

				case 337502076:
					CollisionBoxMaxExpand = (Vec3) p_Value;
					break;

				case 917028322:
					CollisionBoxMinExpand = (Vec3) p_Value;
					break;

				case 3054065626:
					Height = (float) p_Value;
					break;

				case 54303016:
					StepHeight = (float) p_Value;
					break;

				case 708363949:
					ThrottleModifierCurve = (List<Vec2>) p_Value;
					break;

				case 3415409588:
					PoseType = (CharacterPoseType) Enum.ToObject(typeof(CharacterPoseType), p_Value);
					break;

				case 2884836771:
					CollisionType = (CharacterPoseCollisionType) Enum.ToObject(typeof(CharacterPoseCollisionType), p_Value);
					break;

				case 2301802932:
					LookConstraints = (LookConstraintsData) p_Value;
					break;

				case 2389730764:
					TransitionTimes = (List<PoseTransitionTime>) p_Value;
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
				case 2695753445:
					return EyePosition;

				case 337502076:
					return CollisionBoxMaxExpand;

				case 917028322:
					return CollisionBoxMinExpand;

				case 3054065626:
					return Height;

				case 54303016:
					return StepHeight;

				case 708363949:
					return ThrottleModifierCurve;

				case 3415409588:
					return PoseType;

				case 2884836771:
					return CollisionType;

				case 2301802932:
					return LookConstraints;

				case 2389730764:
					return TransitionTimes;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2695753445:
					return typeof(CharacterPoseData).GetProperty(nameof(EyePosition));

				case 337502076:
					return typeof(CharacterPoseData).GetProperty(nameof(CollisionBoxMaxExpand));

				case 917028322:
					return typeof(CharacterPoseData).GetProperty(nameof(CollisionBoxMinExpand));

				case 3054065626:
					return typeof(CharacterPoseData).GetProperty(nameof(Height));

				case 54303016:
					return typeof(CharacterPoseData).GetProperty(nameof(StepHeight));

				case 708363949:
					return typeof(CharacterPoseData).GetProperty(nameof(ThrottleModifierCurve));

				case 3415409588:
					return typeof(CharacterPoseData).GetProperty(nameof(PoseType));

				case 2884836771:
					return typeof(CharacterPoseData).GetProperty(nameof(CollisionType));

				case 2301802932:
					return typeof(CharacterPoseData).GetProperty(nameof(LookConstraints));

				case 2389730764:
					return typeof(CharacterPoseData).GetProperty(nameof(TransitionTimes));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
