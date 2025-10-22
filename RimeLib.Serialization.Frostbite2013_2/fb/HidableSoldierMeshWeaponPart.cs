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
using fb.Entity;
using fb.Render;

namespace fb.SoldierShared;

[ContainerType(8, 32)]
public class HidableSoldierMeshWeaponPart
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public CtrRef<SkinnedMeshAsset> WeaponMesh { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public CtrRef<ObjectBlueprint> WeaponMeshBlueprint { get; set; } = new();
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string BoneName { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public bool HideAlways { get; set; } = false;
	
	[ContainerField(0x19), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
	public bool HideInVehicleEntries { get; set; } = false;
	
}

