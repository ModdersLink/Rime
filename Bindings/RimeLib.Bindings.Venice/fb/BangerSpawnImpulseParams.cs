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
	public class BangerSpawnImpulseParams : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MinHorizontalAngle { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float MaxHorizontalAngle { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float MinVerticalAngle { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float MaxVerticalAngle { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MinStrength { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxStrength { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float WaterStrengthModifier { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float LinearDamping { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AngularDamping { get; set; }

	}
}
