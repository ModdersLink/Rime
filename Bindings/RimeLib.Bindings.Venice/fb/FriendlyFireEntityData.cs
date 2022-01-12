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
	[ContainerType(4, 36)]
	public class FriendlyFireEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<TeamId> Teams { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float EnemyCommitmentAllocation { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float FriendlyCommitmentAllocation { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxCommitment { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float FailureThreshold { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float DecayRate { get; set; }

	}
}
