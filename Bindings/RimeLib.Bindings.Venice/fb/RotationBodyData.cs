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
	public class RotationBodyData : 
		MovingBodyData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float AngularMomentumMultiplier { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float AngularMomentumThreshold { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float AngularMomentumDamping { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float AngularMomentumDampingAcc { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float AngularMomentumDampingDeacc { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float AngularConstraintMin { get; set; }

		[ContainerField(40)]
		public CtrRef<ExtendedConstraintsData> ExtendedConstraints { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public float AngularConstraintMax { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public int RotationAxis { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public bool UsePostSatisfyConstraints { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable]
		public bool UseAngularMomentumThreshold { get; set; }

		[ContainerField(54), LayoutImmutable, Blittable]
		public bool UseAngularMomentumDamping { get; set; }

		[ContainerField(55), LayoutImmutable, Blittable]
		public bool UseAngularConstraint { get; set; }

	}
}
