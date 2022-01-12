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
	public class SpottingComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float SpottingFov { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float TeamOrderFov { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float SpottingDistance { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float PassiveSpottingTimeInterval { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float TimeRequiredToPassiveSpot { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float OrderNeedAmmoPercentage { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float OrderHealPercentage { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float OrderRepairPercentage { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float PickupOrderDistance { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float HealOrderDistance { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float AmmoOrderDistance { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float RepairOrderDistance { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float CoolDownHistoryTime { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public int CoolDownAllowedSpotsWithinHistory { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public bool OnlyAllowedToHaveOneSpottedPlayer { get; set; }

	}
}
