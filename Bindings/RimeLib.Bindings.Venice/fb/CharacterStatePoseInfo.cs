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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class CharacterStatePoseInfo : 
		DataContainer
	{
		protected CharacterPoseType m_PoseType = new CharacterPoseType();
		[ContainerField(8), MemberInfoFlag(137), ContainerFieldNameHash(3415409588)]
		public CharacterPoseType PoseType { get { return m_PoseType; } set { if (OnPropertyChanging("CharacterStatePoseInfo." + nameof(PoseType), this, m_PoseType, value)) m_PoseType = value; } } // 0x8 (8)
		
		protected float m_Velocity = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3860766482)]
		public float Velocity { get { return m_Velocity; } set { if (OnPropertyChanging("CharacterStatePoseInfo." + nameof(Velocity), this, m_Velocity, value)) m_Velocity = value; } } // 0xC (12)
		
		protected float m_AccelerationGain = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1824913062)]
		public float AccelerationGain { get { return m_AccelerationGain; } set { if (OnPropertyChanging("CharacterStatePoseInfo." + nameof(AccelerationGain), this, m_AccelerationGain, value)) m_AccelerationGain = value; } } // 0x10 (16)
		
		protected float m_DecelerationGain = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1680484485)]
		public float DecelerationGain { get { return m_DecelerationGain; } set { if (OnPropertyChanging("CharacterStatePoseInfo." + nameof(DecelerationGain), this, m_DecelerationGain, value)) m_DecelerationGain = value; } } // 0x14 (20)
		
		protected float m_SprintGain = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1424279590)]
		public float SprintGain { get { return m_SprintGain; } set { if (OnPropertyChanging("CharacterStatePoseInfo." + nameof(SprintGain), this, m_SprintGain, value)) m_SprintGain = value; } } // 0x18 (24)
		
		protected float m_SprintMultiplier = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4088490892)]
		public float SprintMultiplier { get { return m_SprintMultiplier; } set { if (OnPropertyChanging("CharacterStatePoseInfo." + nameof(SprintMultiplier), this, m_SprintMultiplier, value)) m_SprintMultiplier = value; } } // 0x1C (28)
		
		protected SpeedModifierData m_SpeedModifier = new SpeedModifierData();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(2276662581)]
		public SpeedModifierData SpeedModifier { get { return m_SpeedModifier; } set { if (OnPropertyChanging("CharacterStatePoseInfo." + nameof(SpeedModifier), this, m_SpeedModifier, value)) m_SpeedModifier = value; } } // 0x20 (32)
		
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
