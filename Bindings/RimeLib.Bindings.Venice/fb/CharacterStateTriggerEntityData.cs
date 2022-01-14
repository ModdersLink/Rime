///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 160)]
	public class CharacterStateTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public uint ActiveWeaponSlot { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float Pitch { get; set; }

		[ContainerField(120), JsonProperty(Order = 120)]
		public CharacterPoseAction CharacterPose { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public uint AmmoToSet { get; set; }

		[ContainerField(128), JsonProperty(Order = 128)]
		public CharacterPoseAction PoseToCheck { get; set; } = new();

		[ContainerField(132), JsonProperty(Order = 132)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public uint HealthToSet { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public uint HealthToCheck { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public uint SeatIndex { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public bool ExcludeConnectedVehicles { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		public bool ContinueToCheckIfHoldingWrongWeapon { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		public bool StayInVehicleOnMove { get; set; }

		[ContainerField(151), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
		public bool CheckHealthGreaterOrEqual { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public bool CheckAllWeapons { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		public bool ShouldCheckSeatIndex { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		public bool UseExitPointWhenLeavingVehicle { get; set; }

		[ContainerField(155), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
		public bool DisablePhysicsWhenLeavingVehicle { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public bool UsePitch { get; set; }

	}
}
