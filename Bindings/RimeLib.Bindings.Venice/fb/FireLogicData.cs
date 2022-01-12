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
	[ContainerType(4, 152)]
	public class FireLogicData
	{
		[ContainerField(0)]
		public HoldAndReleaseData HoldAndRelease { get; set; } = new();
		
		[ContainerField(28)]
		public BoltActionData BoltAction { get; set; } = new();
		
		[ContainerField(44)]
		public RecoilData Recoil { get; set; } = new();
		
		[ContainerField(80)]
		public EntryInputActionEnum FireInputAction { get; set; } = new();
		
		[ContainerField(84)]
		public EntryInputActionEnum ReloadInputAction { get; set; } = new();
		
		[ContainerField(88)]
		public EntryInputActionEnum CycleFireModeInputAction { get; set; } = new();
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float TriggerPullWeight { get; set; }
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float RateOfFire { get; set; }
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float RateOfFireForBurst { get; set; }
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float ClientFireRateMultiplier { get; set; }
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float ReloadDelay { get; set; }
		
		[ContainerField(112)]
		public List<FireLogicType> FireLogicTypeArray { get; set; } = new();
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float ReloadThreshold { get; set; }
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float PreFireDelay { get; set; }
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float ReloadTime { get; set; }
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float ReloadTimeBulletsLeft { get; set; }
		
		[ContainerField(132)]
		public FireLogicType FireLogicType { get; set; } = new();
		
		[ContainerField(136)]
		public ReloadLogic ReloadLogic { get; set; } = new();
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float AutomaticDelay { get; set; }
		
		[ContainerField(144)]
		public ReloadType ReloadType { get; set; } = new();
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool HoldOffReloadUntilZoomRelease { get; set; }
		
		[ContainerField(149), LayoutImmutable, Blittable]
		public bool ForceReloadActionOnFireTrigger { get; set; }
		
		[ContainerField(150), LayoutImmutable, Blittable]
		public bool HoldOffReloadUntilFireRelease { get; set; }
		
		[ContainerField(151), LayoutImmutable, Blittable]
		public bool AlwaysAutoReload { get; set; }
		
	}
}
