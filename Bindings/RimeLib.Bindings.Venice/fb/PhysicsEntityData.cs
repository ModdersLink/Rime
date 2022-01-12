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
	public class PhysicsEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InertiaModifier { get; set; } = new();

		[ContainerField(32)]
		public RefArray<HavokAsset> ScaledAssets { get; set; } = new();

		[ContainerField(36)]
		public RefArray<RigidBodyData> RigidBodies { get; set; } = new();

		[ContainerField(40)]
		public CtrRef<HavokAsset> Asset { get; set; } = new();

		[ContainerField(44)]
		public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public float Mass { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float Restitution { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float Friction { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float LinearVelocityDamping { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float AngularVelocityDamping { get; set; }

		[ContainerField(68)]
		public CtrRef<ProximityData> Proximity { get; set; } = new();

		[ContainerField(72)]
		public RefArray<RigidBodyConstraintData> Constraints { get; set; } = new();

		[ContainerField(76), LayoutImmutable, Blittable]
		public bool EncapsulatePartsInLists { get; set; }

		[ContainerField(77), LayoutImmutable, Blittable]
		public bool MovableParts { get; set; }

	}
}
