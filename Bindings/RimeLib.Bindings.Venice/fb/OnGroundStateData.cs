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
	public class OnGroundStateData : 
		CharacterStateData
	{
		protected float m_JumpDelay = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1846535730)]
		public float JumpDelay { get { return m_JumpDelay; } set { if (OnPropertyChanging("OnGroundStateData." + nameof(JumpDelay), this, m_JumpDelay, value)) m_JumpDelay = value; } } // 0xC (12)
		
		protected float m_JumpStaminaPenalty = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1315207185)]
		public float JumpStaminaPenalty { get { return m_JumpStaminaPenalty; } set { if (OnPropertyChanging("OnGroundStateData." + nameof(JumpStaminaPenalty), this, m_JumpStaminaPenalty, value)) m_JumpStaminaPenalty = value; } } // 0x10 (16)
		
		protected float m_AllowedDistanceFromGround = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(639560781)]
		public float AllowedDistanceFromGround { get { return m_AllowedDistanceFromGround; } set { if (OnPropertyChanging("OnGroundStateData." + nameof(AllowedDistanceFromGround), this, m_AllowedDistanceFromGround, value)) m_AllowedDistanceFromGround = value; } } // 0x14 (20)
		
		protected bool m_GroundHugging = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(190843837)]
		public bool GroundHugging { get { return m_GroundHugging; } set { if (OnPropertyChanging("OnGroundStateData." + nameof(GroundHugging), this, m_GroundHugging, value)) m_GroundHugging = value; } } // 0x18 (24)
		
		protected bool m_LimitDownwardVelocity = new bool();
		[ContainerField(25), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2249794005)]
		public bool LimitDownwardVelocity { get { return m_LimitDownwardVelocity; } set { if (OnPropertyChanging("OnGroundStateData." + nameof(LimitDownwardVelocity), this, m_LimitDownwardVelocity, value)) m_LimitDownwardVelocity = value; } } // 0x19 (25)
		
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
