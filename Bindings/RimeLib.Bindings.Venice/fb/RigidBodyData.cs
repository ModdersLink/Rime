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
    [ContainerType(16)]
	public class RigidBodyData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InertiaModifier { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32)]
		public RigidBodyType RigidBodyType { get; set; } = new RigidBodyType(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float Mass { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float Restitution { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float Friction { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float AngularVelocityDamping { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float LinearVelocityDamping { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public uint InteractionToolkitCollisionVolumeId { get; set; } // 0x38 (56)
		
		[ContainerField(60)]
		public RigidBodyMotionType MotionType { get; set; } = new RigidBodyMotionType(); // 0x3C (60)
		
		[ContainerField(64)]
		public RigidBodyQualityType QualityType { get; set; } = new RigidBodyQualityType(); // 0x40 (64)
		
		[ContainerField(68)]
		public RigidBodyCollisionLayer CollisionLayer { get; set; } = new RigidBodyCollisionLayer(); // 0x44 (68)
		
		[ContainerField(72)]
		public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new CtrRef<FloatPhysicsData>(); // 0x48 (72)
		
		[ContainerField(76)]
		public RefArray<RigidBodyConstraintData> Constraints { get; set; } = new RefArray<RigidBodyConstraintData>(); // 0x4C (76)
		
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
