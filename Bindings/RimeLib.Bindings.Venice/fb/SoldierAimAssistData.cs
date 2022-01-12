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
	[ContainerType(16, 192)]
	public class SoldierAimAssistData : 
		GameDataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 EyePosOffset { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 StickyBoxScale { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SnapDistanceScale { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SnapBoxScale { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 StickyDistanceScale { get; set; } = new();

		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 MaxAcceleration { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public float AccelerationDamping { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float AccelerationInputThreshold { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float AccelerationMultiplier { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float SquaredAcceleration { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float YawSpeedStrength { get; set; }

		[ContainerField(124)]
		public List<float> ZoomedInputPolynomial { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public float AccelerationTimeThreshold { get; set; }

		[ContainerField(132)]
		public List<float> AttractDistanceFallOff { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable]
		public float AttractUserInputMultiplier { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float AttractOwnSpeedInfluence { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float AttractTargetSpeedInfluence { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float AttractOwnRequiredMovementForMaximumAttract { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float AttractStartInputThreshold { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float AttractZoomingMultiplier { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float AttractZoomingPostTime { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float AttractYawStrength { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float AttractPitchStrength { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public float PitchSpeedStrength { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float AttractSoftZone { get; set; }

		[ContainerField(180)]
		public List<float> InputPolynomial { get; set; } = new();

		[ContainerField(184), LayoutImmutable, Blittable]
		public bool UseYawAcceleration { get; set; }

		[ContainerField(185), LayoutImmutable, Blittable]
		public bool UsePitchAcceleration { get; set; }

	}
}
