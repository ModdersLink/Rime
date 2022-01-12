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
	public class ChassisComponentData : 
		PartComponentData
	{
		[ContainerField(112)]
		public CtrRef<VehicleConfigData> VehicleConfig { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<GearboxConfigData> GearboxConfig { get; set; } = new();

		[ContainerField(120)]
		public RefArray<VehicleWaterEffectData> WaterStreakEffects { get; set; } = new();

		[ContainerField(124)]
		public RefArray<VehicleWaterEffectData> WaterEffects { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public float TriggerGroundEffectImpulse { get; set; }

		[ContainerField(132)]
		public CtrRef<LandingGearLogicData> LandingGearLogic { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable]
		public bool AlwaysFullThrottle { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable]
		public bool ForceLandingGearsRetract { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable]
		public bool AllowNegativeThrottle { get; set; }

	}
}
