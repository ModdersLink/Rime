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
	public class SoldierTestEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<SoldierBlueprint> TestSoldier { get; set; } = new();

		[ContainerField(100)]
		public CtrRef<SoldierSpawnTemplateData> Template { get; set; } = new();

		[ContainerField(104)]
		public CtrRef<VehicleBlueprint> TestVehicle { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public float SpecialAnimationIndex { get; set; }

		[ContainerField(112)]
		public CtrRef<RawFileAsset> UnlocksProfile { get; set; } = new();

		[ContainerField(116)]
		public TeamId Team { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public int RandomSeed { get; set; }

		[ContainerField(124)]
		public CtrRef<MovementActionData> StartSequence { get; set; } = new();

		[ContainerField(128)]
		public CtrRef<MovementActionRoot> StartSequenceRoot { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable]
		public float YawInputVal { get; set; }

		[ContainerField(136), LayoutImmutable]
		public string CameraMovementsFilename { get; set; } = string.Empty;

		[ContainerField(140)]
		public CtrRef<InputRecorderData> InputRecorder { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public float ThrottleInputVal { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float FireInputVal { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float StrafeInputVal { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float ProneInputVal { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float PitchInputVal { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float RollInputVal { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float ZoomInputVal { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public float JumpInputVal { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float ActiveInputRecording { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float AuthoritativeAimingActive { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float FireCounterMeasure { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public float AuthoritativeYaw { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public float AuthoritativePitch { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public bool RunAutomatically { get; set; }

		[ContainerField(197), LayoutImmutable, Blittable]
		public bool UseUnlocksProfile { get; set; }

		[ContainerField(198), LayoutImmutable, Blittable]
		public bool SprintInputVal { get; set; }

	}
}
