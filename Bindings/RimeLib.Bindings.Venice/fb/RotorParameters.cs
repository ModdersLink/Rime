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
	[ContainerType(4, 56)]
	public class RotorParameters : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CyclicInputScaleRoll { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float CyclicInputScalePitch { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float CollectiveThrottleInputScale { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float CollectiveBrakeInputScale { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float CollectiveInputIdle { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float HorizontalForceModifier { get; set; }

		[ContainerField(32)]
		public List<Vec2> AngleOfAttack { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public float CyclicFadeOutOffset { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AdditionalGravityModifier { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float HorisontalMinEffectMod { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float HorisontalMinEffectVelocity { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public bool EnableHorisontalMinEffect { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable]
		public bool ReverseThrottle { get; set; }

	}
}
