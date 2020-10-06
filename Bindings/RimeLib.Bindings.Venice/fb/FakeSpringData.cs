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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(80), ContainerClass]
	public class FakeSpringData : 
		FakePhysicsData
	{
		protected Vec3 m_Direction = new Vec3();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2698949952)]
		public Vec3 Direction { get { return m_Direction; } set { if (OnPropertyChanging("FakeSpringData." + nameof(Direction), this, m_Direction, value)) m_Direction = value; } } // 0x30 (48)
		
		protected float m_Length = new float();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2906827577)]
		public float Length { get { return m_Length; } set { if (OnPropertyChanging("FakeSpringData." + nameof(Length), this, m_Length, value)) m_Length = value; } } // 0x40 (64)
		
		protected float m_Acceleration = new float();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(62601415)]
		public float Acceleration { get { return m_Acceleration; } set { if (OnPropertyChanging("FakeSpringData." + nameof(Acceleration), this, m_Acceleration, value)) m_Acceleration = value; } } // 0x44 (68)
		
		protected float m_ProgressiveExponent = new float();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(487101329)]
		public float ProgressiveExponent { get { return m_ProgressiveExponent; } set { if (OnPropertyChanging("FakeSpringData." + nameof(ProgressiveExponent), this, m_ProgressiveExponent, value)) m_ProgressiveExponent = value; } } // 0x48 (72)
		
		protected float m_Damping = new float();
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3862601053)]
		public float Damping { get { return m_Damping; } set { if (OnPropertyChanging("FakeSpringData." + nameof(Damping), this, m_Damping, value)) m_Damping = value; } } // 0x4C (76)
		
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
