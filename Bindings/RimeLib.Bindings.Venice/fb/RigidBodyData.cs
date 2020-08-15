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
	public class RigidBodyData : 
		DataContainer
	{
		protected Vec3 m_InertiaModifier = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(3532865534)]
		public Vec3 InertiaModifier { get { return m_InertiaModifier; } set { if (OnPropertyChanging("RigidBodyData." + nameof(InertiaModifier), this, m_InertiaModifier, value)) m_InertiaModifier = value; } } // 0x10 (16)
		
		protected RigidBodyType m_RigidBodyType = new RigidBodyType();
		[ContainerField(32), ContainerFieldNameHash(2892215548)]
		public RigidBodyType RigidBodyType { get { return m_RigidBodyType; } set { if (OnPropertyChanging("RigidBodyData." + nameof(RigidBodyType), this, m_RigidBodyType, value)) m_RigidBodyType = value; } } // 0x20 (32)
		
		protected float m_Mass = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(2088779625)]
		public float Mass { get { return m_Mass; } set { if (OnPropertyChanging("RigidBodyData." + nameof(Mass), this, m_Mass, value)) m_Mass = value; } } // 0x24 (36)
		
		protected float m_Restitution = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(2298929185)]
		public float Restitution { get { return m_Restitution; } set { if (OnPropertyChanging("RigidBodyData." + nameof(Restitution), this, m_Restitution, value)) m_Restitution = value; } } // 0x28 (40)
		
		protected float m_Friction = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(306207591)]
		public float Friction { get { return m_Friction; } set { if (OnPropertyChanging("RigidBodyData." + nameof(Friction), this, m_Friction, value)) m_Friction = value; } } // 0x2C (44)
		
		protected float m_AngularVelocityDamping = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(2367237320)]
		public float AngularVelocityDamping { get { return m_AngularVelocityDamping; } set { if (OnPropertyChanging("RigidBodyData." + nameof(AngularVelocityDamping), this, m_AngularVelocityDamping, value)) m_AngularVelocityDamping = value; } } // 0x30 (48)
		
		protected float m_LinearVelocityDamping = new float();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(1004384727)]
		public float LinearVelocityDamping { get { return m_LinearVelocityDamping; } set { if (OnPropertyChanging("RigidBodyData." + nameof(LinearVelocityDamping), this, m_LinearVelocityDamping, value)) m_LinearVelocityDamping = value; } } // 0x34 (52)
		
		protected uint m_InteractionToolkitCollisionVolumeId = new uint();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(92982954)]
		public uint InteractionToolkitCollisionVolumeId { get { return m_InteractionToolkitCollisionVolumeId; } set { if (OnPropertyChanging("RigidBodyData." + nameof(InteractionToolkitCollisionVolumeId), this, m_InteractionToolkitCollisionVolumeId, value)) m_InteractionToolkitCollisionVolumeId = value; } } // 0x38 (56)
		
		protected RigidBodyMotionType m_MotionType = new RigidBodyMotionType();
		[ContainerField(60), ContainerFieldNameHash(2158618691)]
		public RigidBodyMotionType MotionType { get { return m_MotionType; } set { if (OnPropertyChanging("RigidBodyData." + nameof(MotionType), this, m_MotionType, value)) m_MotionType = value; } } // 0x3C (60)
		
		protected RigidBodyQualityType m_QualityType = new RigidBodyQualityType();
		[ContainerField(64), ContainerFieldNameHash(2856027376)]
		public RigidBodyQualityType QualityType { get { return m_QualityType; } set { if (OnPropertyChanging("RigidBodyData." + nameof(QualityType), this, m_QualityType, value)) m_QualityType = value; } } // 0x40 (64)
		
		protected RigidBodyCollisionLayer m_CollisionLayer = new RigidBodyCollisionLayer();
		[ContainerField(68), ContainerFieldNameHash(719540408)]
		public RigidBodyCollisionLayer CollisionLayer { get { return m_CollisionLayer; } set { if (OnPropertyChanging("RigidBodyData." + nameof(CollisionLayer), this, m_CollisionLayer, value)) m_CollisionLayer = value; } } // 0x44 (68)
		
		protected CtrRef<FloatPhysicsData> m_FloatPhysics = new CtrRef<FloatPhysicsData>();
		[ContainerField(72), ContainerFieldNameHash(2331402366)]
		public CtrRef<FloatPhysicsData> FloatPhysics { get { return m_FloatPhysics; } set { if (OnPropertyChanging("RigidBodyData." + nameof(FloatPhysics), this, m_FloatPhysics, value)) m_FloatPhysics = value; } } // 0x48 (72)
		
		protected RefArray<RigidBodyConstraintData> m_Constraints = new RefArray<RigidBodyConstraintData>();
		[ContainerField(76), ContainerFieldNameHash(1187639635)]
		public RefArray<RigidBodyConstraintData> Constraints { get { return m_Constraints; } set { if (OnPropertyChanging("RigidBodyData." + nameof(Constraints), this, m_Constraints, value)) m_Constraints = value; } } // 0x4C (76)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3532865534:
					InertiaModifier = (Vec3) p_Value;
					break;

				case 2892215548:
					RigidBodyType = (RigidBodyType) Enum.ToObject(typeof(RigidBodyType), p_Value);
					break;

				case 2088779625:
					Mass = (float) p_Value;
					break;

				case 2298929185:
					Restitution = (float) p_Value;
					break;

				case 306207591:
					Friction = (float) p_Value;
					break;

				case 2367237320:
					AngularVelocityDamping = (float) p_Value;
					break;

				case 1004384727:
					LinearVelocityDamping = (float) p_Value;
					break;

				case 92982954:
					InteractionToolkitCollisionVolumeId = (uint) p_Value;
					break;

				case 2158618691:
					MotionType = (RigidBodyMotionType) Enum.ToObject(typeof(RigidBodyMotionType), p_Value);
					break;

				case 2856027376:
					QualityType = (RigidBodyQualityType) Enum.ToObject(typeof(RigidBodyQualityType), p_Value);
					break;

				case 719540408:
					CollisionLayer = (RigidBodyCollisionLayer) Enum.ToObject(typeof(RigidBodyCollisionLayer), p_Value);
					break;

				case 2331402366:
					FloatPhysics = (CtrRef<FloatPhysicsData>) p_Value;
					break;

				case 1187639635:
					Constraints = (RefArray<RigidBodyConstraintData>) p_Value;
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
				case 3532865534:
					return InertiaModifier;

				case 2892215548:
					return RigidBodyType;

				case 2088779625:
					return Mass;

				case 2298929185:
					return Restitution;

				case 306207591:
					return Friction;

				case 2367237320:
					return AngularVelocityDamping;

				case 1004384727:
					return LinearVelocityDamping;

				case 92982954:
					return InteractionToolkitCollisionVolumeId;

				case 2158618691:
					return MotionType;

				case 2856027376:
					return QualityType;

				case 719540408:
					return CollisionLayer;

				case 2331402366:
					return FloatPhysics;

				case 1187639635:
					return Constraints;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3532865534:
					return typeof(RigidBodyData).GetProperty(nameof(InertiaModifier));

				case 2892215548:
					return typeof(RigidBodyData).GetProperty(nameof(RigidBodyType));

				case 2088779625:
					return typeof(RigidBodyData).GetProperty(nameof(Mass));

				case 2298929185:
					return typeof(RigidBodyData).GetProperty(nameof(Restitution));

				case 306207591:
					return typeof(RigidBodyData).GetProperty(nameof(Friction));

				case 2367237320:
					return typeof(RigidBodyData).GetProperty(nameof(AngularVelocityDamping));

				case 1004384727:
					return typeof(RigidBodyData).GetProperty(nameof(LinearVelocityDamping));

				case 92982954:
					return typeof(RigidBodyData).GetProperty(nameof(InteractionToolkitCollisionVolumeId));

				case 2158618691:
					return typeof(RigidBodyData).GetProperty(nameof(MotionType));

				case 2856027376:
					return typeof(RigidBodyData).GetProperty(nameof(QualityType));

				case 719540408:
					return typeof(RigidBodyData).GetProperty(nameof(CollisionLayer));

				case 2331402366:
					return typeof(RigidBodyData).GetProperty(nameof(FloatPhysics));

				case 1187639635:
					return typeof(RigidBodyData).GetProperty(nameof(Constraints));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
