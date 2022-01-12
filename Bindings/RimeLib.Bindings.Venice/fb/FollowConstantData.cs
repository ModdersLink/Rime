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
	[ContainerType(4, 44)]
	public class FollowConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float DistanceFromPlayerBeforeTeleport { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float FollowHumanMaxDistance { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float FollowHumanInCombatMaxDistance { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float FollowAiMaxDistance { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float FollowAiInCombatMaxDistance { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float FollowMimicPoseDistance { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float FollowInertia { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float LookAwayAngle { get; set; }

	}
}
