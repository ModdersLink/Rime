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
	[ContainerType(4, 44)]
	public class SupplyData
	{
		[ContainerField(0)]
		public SupplyUnitSphereData Healing { get; set; } = new();
		
		[ContainerField(20)]
		public SupplyUnitSphereData Ammo { get; set; } = new();
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool SupplyVehicles { get; set; }
		
		[ContainerField(41), LayoutImmutable, Blittable]
		public bool SupplySoldiers { get; set; }
		
		[ContainerField(42), LayoutImmutable, Blittable]
		public bool TeamSpecific { get; set; }
		
		[ContainerField(43), LayoutImmutable, Blittable]
		public bool ExcludeSelf { get; set; }
		
	}
}
