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
	[ContainerType(16, 208)]
	public class SoldierTestEntityData : 
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<SoldierBlueprint> TestSoldier { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public CtrRef<SoldierSpawnTemplateData> Template { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public CtrRef<VehicleBlueprint> TestVehicle { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float SpecialAnimationIndex { get; set; }

		[ContainerField(112), JsonProperty(Order = 112)]
		public CtrRef<RawFileAsset> UnlocksProfile { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public TeamId Team { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public int RandomSeed { get; set; }

		[ContainerField(124), JsonProperty(Order = 124)]
		public CtrRef<MovementActionData> StartSequence { get; set; } = new();

		[ContainerField(128), JsonProperty(Order = 128)]
		public CtrRef<MovementActionRoot> StartSequenceRoot { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float YawInputVal { get; set; }

		[ContainerField(136), LayoutImmutable, JsonProperty(Order = 136)]
		public string CameraMovementsFilename { get; set; } = string.Empty;

		[ContainerField(140), JsonProperty(Order = 140)]
		public CtrRef<InputRecorderData> InputRecorder { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float ThrottleInputVal { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float FireInputVal { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float StrafeInputVal { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float ProneInputVal { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float PitchInputVal { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float RollInputVal { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float ZoomInputVal { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public float JumpInputVal { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float ActiveInputRecording { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float AuthoritativeAimingActive { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float FireCounterMeasure { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float AuthoritativeYaw { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float AuthoritativePitch { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public bool RunAutomatically { get; set; }

		[ContainerField(197), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
		public bool UseUnlocksProfile { get; set; }

		[ContainerField(198), LayoutImmutable, Blittable, JsonProperty(Order = 198)]
		public bool SprintInputVal { get; set; }

	}
}
