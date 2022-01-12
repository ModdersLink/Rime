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
	public class AIDifficultyData : 
		GameAIDifficultyData
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable]
		public float AccuracyIncreaseTimeModifier { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float StartAccuracyModifierStanding { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float StartAccuracyModifierCrouching { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float FinalAccuracyModifierStanding { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float FinalAccuracyModifierCrouching { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ReadinessReactionTimeMultiplier { get; set; }

	}
}
