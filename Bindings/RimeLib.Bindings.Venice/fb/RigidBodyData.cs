///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 80)]
	public class RigidBodyData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InertiaModifier { get; set; } = new();

		[ContainerField(32)]
		public RigidBodyType RigidBodyType { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Mass { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float Restitution { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float Friction { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float AngularVelocityDamping { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float LinearVelocityDamping { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public uint InteractionToolkitCollisionVolumeId { get; set; }

		[ContainerField(60)]
		public RigidBodyMotionType MotionType { get; set; } = new();

		[ContainerField(64)]
		public RigidBodyQualityType QualityType { get; set; } = new();

		[ContainerField(68)]
		public RigidBodyCollisionLayer CollisionLayer { get; set; } = new();

		[ContainerField(72)]
		public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new();

		[ContainerField(76)]
		public RefArray<RigidBodyConstraintData> Constraints { get; set; } = new();

	}
}
