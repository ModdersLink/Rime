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
	[ContainerType(4, 64)]
	public class GearboxConfigData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<float> ForwardGearRatios { get; set; } = new();

		[ContainerField(12)]
		public List<float> ForwardGearSpeeds { get; set; } = new();

		[ContainerField(16)]
		public List<float> ReverseGearRatios { get; set; } = new();

		[ContainerField(20)]
		public List<float> ReverseGearSpeeds { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public int GearboxType { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public int GearboxMode { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float GearChangeTime { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float GearDownSpeedFactor { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float OppositeDirGearChangeMaxSpeed { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float OppositeDirGearChangeTime { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float ClutchSpeedFactor { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float TransmissionEfficiency { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float BackwardThrottleLimit { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool UseClassicGearBoxAutoClutch { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable]
		public bool UseNeutralGear { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable]
		public bool LimitBackwardThrottle { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable]
		public bool UseAutoClutch { get; set; }

	}
}
