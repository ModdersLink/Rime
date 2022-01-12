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
	[ContainerType(4, 36)]
	public class GearBagSpec : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint MaxPrimaryWeapons { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint MaxSecondaryWeapons { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint MaxSidearms { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MaxGadgetsPerSlot { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint GadgetSlots { get; set; }

		[ContainerField(32)]
		public RefArray<GearBagSpec> ChildSpecs { get; set; } = new();

	}
}
