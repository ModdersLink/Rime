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
	[ContainerType(1, 6)]
	public class InteractionTypesData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public bool InteractionEntity { get; set; }
		
		[ContainerField(1), LayoutImmutable, Blittable]
		public bool PickupEntity { get; set; }
		
		[ContainerField(2), LayoutImmutable, Blittable]
		public bool AmmoCrateEntity { get; set; }
		
		[ContainerField(3), LayoutImmutable, Blittable]
		public bool VehicleEntity { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public bool ExplosionPackEntity { get; set; }
		
		[ContainerField(5), LayoutImmutable, Blittable]
		public bool SoldierEntity { get; set; }
		
	}
}
