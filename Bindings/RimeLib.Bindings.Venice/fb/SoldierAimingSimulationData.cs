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
	[ContainerType(4, 120)]
	public class SoldierAimingSimulationData : 
		GameDataContainer
	{
		[ContainerField(8)]
		public RefArray<ZoomLevelData> ZoomLevels { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public float ZoomTransitionTime { get; set; }

		[ContainerField(16)]
		public CtrRef<SoldierAimAssistData> AimAssist { get; set; } = new();

		[ContainerField(20)]
		public AimingPoseData StandPose { get; set; } = new();

		[ContainerField(44)]
		public AimingPoseData CrouchPose { get; set; } = new();

		[ContainerField(68)]
		public AimingPoseData PronePose { get; set; } = new();

		[ContainerField(92)]
		public List<ZoomLevelSpecificTransitionTime> ZoomTransitionTimeArray { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable]
		public float FovTransitionTime { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float FovDelayTime { get; set; }

		[ContainerField(104)]
		public RefArray<AimerModifierData> Modifiers { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public float AimingRange { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float LockAimToTargetSpeed { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public bool ReturnToZoomAfterReload { get; set; }

	}
}
