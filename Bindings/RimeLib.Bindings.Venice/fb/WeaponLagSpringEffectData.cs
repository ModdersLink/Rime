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
	[ContainerType(16, 208)]
	public class WeaponLagSpringEffectData : 
		DataContainer
	{
		[ContainerField(8)]
		public WeaponLagEffectSpringVector OffsetSprings { get; set; } = new();

		[ContainerField(32)]
		public WeaponLagEffectSpringVector RotationSprings { get; set; } = new();

		[ContainerField(64)]
		public WeaponLagEffectForceData JumpForces { get; set; } = new();

		[ContainerField(96)]
		public WeaponLagEffectForceData LandForces { get; set; } = new();

		[ContainerField(128)]
		public WeaponLagEffectForceData PoseUpForces { get; set; } = new();

		[ContainerField(160)]
		public WeaponLagEffectForceData PoseDownForces { get; set; } = new();

		[ContainerField(192), LayoutImmutable, Blittable]
		public float ZoomForceModifier { get; set; }

	}
}
