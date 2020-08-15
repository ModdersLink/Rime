///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16)]
	public class CharacterPoseData : 
		DataContainer
	{
		protected Vec3 m_EyePosition = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2695753445)]
		public Vec3 EyePosition { get { return m_EyePosition; } set { if (OnPropertyChanging("CharacterPoseData." + nameof(EyePosition), this, m_EyePosition, value)) m_EyePosition = value; } } // 0x10 (16)
		
		protected Vec3 m_CollisionBoxMaxExpand = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(337502076)]
		public Vec3 CollisionBoxMaxExpand { get { return m_CollisionBoxMaxExpand; } set { if (OnPropertyChanging("CharacterPoseData." + nameof(CollisionBoxMaxExpand), this, m_CollisionBoxMaxExpand, value)) m_CollisionBoxMaxExpand = value; } } // 0x20 (32)
		
		protected Vec3 m_CollisionBoxMinExpand = new Vec3();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(917028322)]
		public Vec3 CollisionBoxMinExpand { get { return m_CollisionBoxMinExpand; } set { if (OnPropertyChanging("CharacterPoseData." + nameof(CollisionBoxMinExpand), this, m_CollisionBoxMinExpand, value)) m_CollisionBoxMinExpand = value; } } // 0x30 (48)
		
		protected float m_Height = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(3054065626)]
		public float Height { get { return m_Height; } set { if (OnPropertyChanging("CharacterPoseData." + nameof(Height), this, m_Height, value)) m_Height = value; } } // 0x40 (64)
		
		protected float m_StepHeight = new float();
		[ContainerField(68), LayoutImmutable, Blittable, ContainerFieldNameHash(54303016)]
		public float StepHeight { get { return m_StepHeight; } set { if (OnPropertyChanging("CharacterPoseData." + nameof(StepHeight), this, m_StepHeight, value)) m_StepHeight = value; } } // 0x44 (68)
		
		protected List<Vec2> m_ThrottleModifierCurve = new List<Vec2>();
		[ContainerField(72), ContainerFieldNameHash(708363949)]
		public List<Vec2> ThrottleModifierCurve { get { return m_ThrottleModifierCurve; } set { if (OnPropertyChanging("CharacterPoseData." + nameof(ThrottleModifierCurve), this, m_ThrottleModifierCurve, value)) m_ThrottleModifierCurve = value; } } // 0x48 (72)
		
		protected CharacterPoseType m_PoseType = new CharacterPoseType();
		[ContainerField(76), ContainerFieldNameHash(3415409588)]
		public CharacterPoseType PoseType { get { return m_PoseType; } set { if (OnPropertyChanging("CharacterPoseData." + nameof(PoseType), this, m_PoseType, value)) m_PoseType = value; } } // 0x4C (76)
		
		protected CharacterPoseCollisionType m_CollisionType = new CharacterPoseCollisionType();
		[ContainerField(80), ContainerFieldNameHash(2884836771)]
		public CharacterPoseCollisionType CollisionType { get { return m_CollisionType; } set { if (OnPropertyChanging("CharacterPoseData." + nameof(CollisionType), this, m_CollisionType, value)) m_CollisionType = value; } } // 0x50 (80)
		
		protected LookConstraintsData m_LookConstraints = new LookConstraintsData();
		[ContainerField(84), ContainerFieldNameHash(2301802932)]
		public LookConstraintsData LookConstraints { get { return m_LookConstraints; } set { if (OnPropertyChanging("CharacterPoseData." + nameof(LookConstraints), this, m_LookConstraints, value)) m_LookConstraints = value; } } // 0x54 (84)
		
		protected List<PoseTransitionTime> m_TransitionTimes = new List<PoseTransitionTime>();
		[ContainerField(100), ContainerFieldNameHash(2389730764)]
		public List<PoseTransitionTime> TransitionTimes { get { return m_TransitionTimes; } set { if (OnPropertyChanging("CharacterPoseData." + nameof(TransitionTimes), this, m_TransitionTimes, value)) m_TransitionTimes = value; } } // 0x64 (100)
		
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
