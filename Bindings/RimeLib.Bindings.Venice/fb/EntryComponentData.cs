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
	public class EntryComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SoldierOffset { get; set; } = new();

		[ContainerField(112)]
		public CtrRef<GameAIEntryData> AIData { get; set; } = new();

		[ContainerField(116)]
		public EntryClass EntryClass { get; set; } = new();

		[ContainerField(120)]
		public CtrRef<EntryInputActionMapsData> InputConceptDefinition { get; set; } = new();

		[ContainerField(124)]
		public CtrRef<InputActionMappingsData> InputMapping { get; set; } = new();

		[ContainerField(128)]
		public RefArray<InputCurveData> InputCurves { get; set; } = new();

		[ContainerField(132)]
		public EntryComponentHudData HudData { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public int EntryOrderNumber { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float EnterImpulse { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float EntryRadius { get; set; }

		[ContainerField(156)]
		public EntryInputActionEnum TriggerEventOnKey { get; set; } = new();

		[ContainerField(160)]
		public EntrySpottingSettings EntrySpottingSettings { get; set; } = new();

		[ContainerField(164)]
		public PoseConstraintsData PoseConstraints { get; set; } = new();

		[ContainerField(168), LayoutImmutable, Blittable]
		public float SoldierTransitionInvisbleTime { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public int NumberOfStances { get; set; }

		[ContainerField(176)]
		public CtrRef<EntryComponentSoundData> EntryComponentSound { get; set; } = new();

		[ContainerField(180), LayoutImmutable, Blittable]
		public bool LockSoldierAimingToEntry { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable]
		public bool IsAllowedToExitInAir { get; set; }

		[ContainerField(182), LayoutImmutable, Blittable]
		public bool Show1pSoldierInEntry { get; set; }

		[ContainerField(183), LayoutImmutable, Blittable]
		public bool StancesEnabled { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public bool Show1pSoldierInEntryForPlayerOnly { get; set; }

		[ContainerField(185), LayoutImmutable, Blittable]
		public bool HideSoldierForPassengers { get; set; }

		[ContainerField(186), LayoutImmutable, Blittable]
		public bool Show3pSoldierWeaponInEntry { get; set; }

		[ContainerField(187), LayoutImmutable, Blittable]
		public bool ShowSoldierGearInEntry { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public bool IsShielded { get; set; }

		[ContainerField(189), LayoutImmutable, Blittable]
		public bool ForbiddenForHuman { get; set; }

		[ContainerField(190), LayoutImmutable, Blittable]
		public bool ShowSoldierWeaponInEntry { get; set; }

		[ContainerField(191), LayoutImmutable, Blittable]
		public bool ShowSoldierInEntry { get; set; }

	}
}
