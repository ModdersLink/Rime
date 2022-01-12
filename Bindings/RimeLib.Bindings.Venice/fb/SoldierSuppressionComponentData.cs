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
	[ContainerType(16, 144)]
	public class SoldierSuppressionComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SuppressionReactionData ReactionToSuppression { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public float SuppressionResistModifier { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float SuppressionBoostModifier { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float SuppressionDecay { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float SuppressionSphereRadius { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float FallOffDelay { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float FallOffMultiplier { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public bool SuppressionAbortsHealthRegeneration { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable]
		public bool CheckLineOfSight { get; set; }

	}
}
