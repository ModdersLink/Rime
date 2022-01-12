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
	public class CapturePointEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public int EnemyTicketLossWhenCaptured { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public int MinNrToTakeControl { get; set; }

		[ContainerField(104)]
		public RefArray<ObjectBlueprint> FlagTemplates { get; set; } = new();

		[ContainerField(108)]
		public CtrRef<ObjectBlueprint> CapturePoint { get; set; } = new();

		[ContainerField(112)]
		public TeamId InitialOwnerTeam { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public float CaptureRadius { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public int MaxCaptureMultiplier { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public int AreaValue { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public uint SpawnMenuListOrdinal { get; set; }

		[ContainerField(132)]
		public List<AreaValueTeam> AreaValues { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable]
		public int TimeToGetControl { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public int TimeToLoseControl { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float ReturnMultiplier { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public int OnlyTakeableByTeam { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float ShowRadius { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float HideRadius { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float AddedMultiplierPerPlayer { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float Modify3DIconVerticalOffset { get; set; }

		[ContainerField(168)]
		public CapturableType CapturableType { get; set; } = new();

		[ContainerField(172), LayoutImmutable]
		public string IntruderWarningSID { get; set; } = string.Empty;

		[ContainerField(176), LayoutImmutable, Blittable]
		public bool IsCapturedInUpperSphere { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable]
		public bool DisableWhenLosingControl { get; set; }

		[ContainerField(178), LayoutImmutable, Blittable]
		public bool LoseControlWhenNotClose { get; set; }

		[ContainerField(179), LayoutImmutable, Blittable]
		public bool DisableIfEnemyInside { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public bool IsVisible { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable]
		public bool ForceSnap { get; set; }

		[ContainerField(182), LayoutImmutable, Blittable]
		public bool UseAreaValuesPerTeam { get; set; }

		[ContainerField(183), LayoutImmutable, Blittable]
		public bool IntruderWarning { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public bool ShowOnMinimap { get; set; }

		[ContainerField(185), LayoutImmutable, Blittable]
		public bool HoistFlag { get; set; }

		[ContainerField(186), LayoutImmutable, Blittable]
		public bool StartAtBottom { get; set; }

		[ContainerField(187), LayoutImmutable, Blittable]
		public bool RemoveWhenCaptured { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public bool SeesawCapturing { get; set; }

	}
}
