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
	[ContainerType(4, 44)]
	public class SupplyData
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public SupplyUnitSphereData Healing { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public SupplyUnitSphereData Ammo { get; set; } = new();
		
		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool SupplyVehicles { get; set; }
		
		[ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		public bool SupplySoldiers { get; set; }
		
		[ContainerField(42), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
		public bool TeamSpecific { get; set; }
		
		[ContainerField(43), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
		public bool ExcludeSelf { get; set; }
		
	}
}
