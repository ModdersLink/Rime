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
	[ContainerType(4, 68)]
	public class InputConfigurationAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<EntryInputActionMapsData> DefaultInputConceptDefinition { get; set; } = new();

		[ContainerField(16)]
		public List<InputConceptIdentifiers> DefaultExclusiveInputConcepts { get; set; } = new();

		[ContainerField(20)]
		public List<EditableActionMap> UserConfigurableActionMaps { get; set; } = new();

		[ContainerField(24)]
		public EntryInputActionEnum TogglePoseAction { get; set; } = new();

		[ContainerField(28)]
		public EntryInputActionEnum CrouchAction { get; set; } = new();

		[ContainerField(32)]
		public EntryInputActionEnum CrouchAndHoldAction { get; set; } = new();

		[ContainerField(36)]
		public EntryInputActionEnum PickupInteractionAction { get; set; } = new();

		[ContainerField(40)]
		public List<PoseTransition> FiringDisablingTransitions { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public float SprintReleaseTime { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float ThrottleInputRequiredForSprint { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public bool StandAutomaticallyIfSprinting { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable]
		public bool ProneToStandOnJump { get; set; }

		[ContainerField(54), LayoutImmutable, Blittable]
		public bool DisableCrawlingWhileReloading { get; set; }

		[ContainerField(55), LayoutImmutable, Blittable]
		public bool DisableFiringWhileDeployingBipod { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public bool DisableFiringWhileJumping { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable]
		public bool DisableSprintingWhileReloading { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable]
		public bool EnableSprintToCrouchTransition { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable]
		public bool StopSprintingWhenReleasingThrottle { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool StopSprintingWhenReleasingSprint { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable]
		public bool WaitForSprintReleaseBeforeSprintAgain { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable]
		public bool VehicleBoostIsToggle { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable]
		public bool InputCurvesEnabled { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public bool DisableCrawlingWhileFiring { get; set; }

	}
}
