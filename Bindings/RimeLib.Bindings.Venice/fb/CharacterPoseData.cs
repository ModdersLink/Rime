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
	[ContainerType(16, 112)]
	public class CharacterPoseData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 EyePosition { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CollisionBoxMaxExpand { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CollisionBoxMinExpand { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable]
		public float Height { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float StepHeight { get; set; }

		[ContainerField(72)]
		public List<Vec2> ThrottleModifierCurve { get; set; } = new();

		[ContainerField(76)]
		public CharacterPoseType PoseType { get; set; } = new();

		[ContainerField(80)]
		public CharacterPoseCollisionType CollisionType { get; set; } = new();

		[ContainerField(84)]
		public LookConstraintsData LookConstraints { get; set; } = new();

		[ContainerField(100)]
		public List<PoseTransitionTime> TransitionTimes { get; set; } = new();

	}
}
