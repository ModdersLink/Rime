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

using fb.Core;

namespace fb.SoldierShared;

[ContainerType(8, 40)]
public class SupplyData
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public CtrRef<HealingSupplyUnitSphereData> Healing { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public CtrRef<AmmoSupplyUnitSphereData> Ammo { get; set; } = new();
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float ExclusionTimeout { get; set; } = 0.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float ExcludeDamagedSoldierTime { get; set; } = 0.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float ExcludeSuppressedSoldierTime { get; set; } = 0.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public bool SupplySoldiers { get; set; } = true;
	
	[ContainerField(0x1d), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
	public bool SupplyVehicles { get; set; } = false;
	
	[ContainerField(0x1e), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
	public bool TeamSpecific { get; set; } = true;
	
	[ContainerField(0x1f), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
	public bool ExcludeSelf { get; set; } = true;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool ExcludeSoldiersUnderwater { get; set; } = true;
	
	[ContainerField(0x21), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
	public bool ExcludeSoldierIfInMelee { get; set; } = true;
	
}

