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
	public class AIEntryData : 
		GameAIEntryData
	{
		[ContainerField(12)]
		public CtrRef<AIVehicleBehaviourData> EquipmentType { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<ArmamentData> Armament { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<MobilityData> Mobility { get; set; } = new();

		[ContainerField(24)]
		public StrengthType StrengthType { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public float ReuseTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool Forbidden { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool HasExposedSoldier { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable]
		public bool InterludeOnly { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable]
		public bool InvalidForAI { get; set; }

	}
}
