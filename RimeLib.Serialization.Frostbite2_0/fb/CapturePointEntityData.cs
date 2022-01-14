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
	[ContainerType(16, 192)]
	public class CapturePointEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public int EnemyTicketLossWhenCaptured { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public int MinNrToTakeControl { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public RefArray<ObjectBlueprint> FlagTemplates { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public CtrRef<ObjectBlueprint> CapturePoint { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public TeamId InitialOwnerTeam { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float CaptureRadius { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public int MaxCaptureMultiplier { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public int AreaValue { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public uint SpawnMenuListOrdinal { get; set; }

		[ContainerField(132), JsonProperty(Order = 132)]
		public List<AreaValueTeam> AreaValues { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public int TimeToGetControl { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public int TimeToLoseControl { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float ReturnMultiplier { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public int OnlyTakeableByTeam { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float ShowRadius { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float HideRadius { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float AddedMultiplierPerPlayer { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float Modify3DIconVerticalOffset { get; set; }

		[ContainerField(168), JsonProperty(Order = 168)]
		public CapturableType CapturableType { get; set; } = new();

		[ContainerField(172), LayoutImmutable, JsonProperty(Order = 172)]
		public string IntruderWarningSID { get; set; } = string.Empty;

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public bool IsCapturedInUpperSphere { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
		public bool DisableWhenLosingControl { get; set; }

		[ContainerField(178), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
		public bool LoseControlWhenNotClose { get; set; }

		[ContainerField(179), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
		public bool DisableIfEnemyInside { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public bool IsVisible { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
		public bool ForceSnap { get; set; }

		[ContainerField(182), LayoutImmutable, Blittable, JsonProperty(Order = 182)]
		public bool UseAreaValuesPerTeam { get; set; }

		[ContainerField(183), LayoutImmutable, Blittable, JsonProperty(Order = 183)]
		public bool IntruderWarning { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public bool ShowOnMinimap { get; set; }

		[ContainerField(185), LayoutImmutable, Blittable, JsonProperty(Order = 185)]
		public bool HoistFlag { get; set; }

		[ContainerField(186), LayoutImmutable, Blittable, JsonProperty(Order = 186)]
		public bool StartAtBottom { get; set; }

		[ContainerField(187), LayoutImmutable, Blittable, JsonProperty(Order = 187)]
		public bool RemoveWhenCaptured { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public bool SeesawCapturing { get; set; }

	}
}
