///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
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
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 InertiaModifier { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public RigidBodyType RigidBodyType { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float Mass { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float Restitution { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float Friction { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float AngularVelocityDamping { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float LinearVelocityDamping { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public uint InteractionToolkitCollisionVolumeId { get; set; }

		[ContainerField(60), JsonProperty(Order = 60)]
		public RigidBodyMotionType MotionType { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public RigidBodyQualityType QualityType { get; set; } = new();

		[ContainerField(68), JsonProperty(Order = 68)]
		public RigidBodyCollisionLayer CollisionLayer { get; set; } = new();

		[ContainerField(72), JsonProperty(Order = 72)]
		public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new();

		[ContainerField(76), JsonProperty(Order = 76)]
		public RefArray<RigidBodyConstraintData> Constraints { get; set; } = new();

	}
}
