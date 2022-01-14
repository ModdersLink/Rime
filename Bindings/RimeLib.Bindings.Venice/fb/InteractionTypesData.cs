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
	[ContainerType(1, 6)]
	public class InteractionTypesData
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public bool InteractionEntity { get; set; }
		
		[ContainerField(1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
		public bool PickupEntity { get; set; }
		
		[ContainerField(2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
		public bool AmmoCrateEntity { get; set; }
		
		[ContainerField(3), LayoutImmutable, Blittable, JsonProperty(Order = 3)]
		public bool VehicleEntity { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public bool ExplosionPackEntity { get; set; }
		
		[ContainerField(5), LayoutImmutable, Blittable, JsonProperty(Order = 5)]
		public bool SoldierEntity { get; set; }
		
	}
}
