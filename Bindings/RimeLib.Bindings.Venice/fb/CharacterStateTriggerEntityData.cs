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
	[ContainerType(16, 160)]
	public class CharacterStateTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public uint ActiveWeaponSlot { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float Pitch { get; set; }

		[ContainerField(120)]
		public CharacterPoseAction CharacterPose { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable]
		public uint AmmoToSet { get; set; }

		[ContainerField(128)]
		public CharacterPoseAction PoseToCheck { get; set; } = new();

		[ContainerField(132)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable]
		public uint HealthToSet { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public uint HealthToCheck { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public uint SeatIndex { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public bool ExcludeConnectedVehicles { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable]
		public bool ContinueToCheckIfHoldingWrongWeapon { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable]
		public bool StayInVehicleOnMove { get; set; }

		[ContainerField(151), LayoutImmutable, Blittable]
		public bool CheckHealthGreaterOrEqual { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public bool CheckAllWeapons { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable]
		public bool ShouldCheckSeatIndex { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable]
		public bool UseExitPointWhenLeavingVehicle { get; set; }

		[ContainerField(155), LayoutImmutable, Blittable]
		public bool DisablePhysicsWhenLeavingVehicle { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public bool UsePitch { get; set; }

	}
}
