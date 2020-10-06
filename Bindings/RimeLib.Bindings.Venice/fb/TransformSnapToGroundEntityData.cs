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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class TransformSnapToGroundEntityData : 
		EntityData
	{
		protected LinearTransform m_In = new LinearTransform();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(5862146)]
		public LinearTransform In { get { return m_In; } set { if (OnPropertyChanging("TransformSnapToGroundEntityData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x10 (16)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(80), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("TransformSnapToGroundEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x50 (80)
		
		protected float m_DistanceToGround = new float();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3638863832)]
		public float DistanceToGround { get { return m_DistanceToGround; } set { if (OnPropertyChanging("TransformSnapToGroundEntityData." + nameof(DistanceToGround), this, m_DistanceToGround, value)) m_DistanceToGround = value; } } // 0x54 (84)
		
		protected float m_RayCastLength = new float();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2786399190)]
		public float RayCastLength { get { return m_RayCastLength; } set { if (OnPropertyChanging("TransformSnapToGroundEntityData." + nameof(RayCastLength), this, m_RayCastLength, value)) m_RayCastLength = value; } } // 0x58 (88)
		
		protected float m_RayCastUpOffset = new float();
		[ContainerField(92), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2052773058)]
		public float RayCastUpOffset { get { return m_RayCastUpOffset; } set { if (OnPropertyChanging("TransformSnapToGroundEntityData." + nameof(RayCastUpOffset), this, m_RayCastUpOffset, value)) m_RayCastUpOffset = value; } } // 0x5C (92)
		
		protected bool m_AlignWithGroundNormal = new bool();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(387843516)]
		public bool AlignWithGroundNormal { get { return m_AlignWithGroundNormal; } set { if (OnPropertyChanging("TransformSnapToGroundEntityData." + nameof(AlignWithGroundNormal), this, m_AlignWithGroundNormal, value)) m_AlignWithGroundNormal = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (LinearTransform) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3638863832:
					DistanceToGround = (float) p_Value;
					break;

				case 2786399190:
					RayCastLength = (float) p_Value;
					break;

				case 2052773058:
					RayCastUpOffset = (float) p_Value;
					break;

				case 387843516:
					AlignWithGroundNormal = (bool) p_Value;
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
				case 5862146:
					return In;

				case 229961746:
					return Realm;

				case 3638863832:
					return DistanceToGround;

				case 2786399190:
					return RayCastLength;

				case 2052773058:
					return RayCastUpOffset;

				case 387843516:
					return AlignWithGroundNormal;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(TransformSnapToGroundEntityData).GetProperty(nameof(In));

				case 229961746:
					return typeof(TransformSnapToGroundEntityData).GetProperty(nameof(Realm));

				case 3638863832:
					return typeof(TransformSnapToGroundEntityData).GetProperty(nameof(DistanceToGround));

				case 2786399190:
					return typeof(TransformSnapToGroundEntityData).GetProperty(nameof(RayCastLength));

				case 2052773058:
					return typeof(TransformSnapToGroundEntityData).GetProperty(nameof(RayCastUpOffset));

				case 387843516:
					return typeof(TransformSnapToGroundEntityData).GetProperty(nameof(AlignWithGroundNormal));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
