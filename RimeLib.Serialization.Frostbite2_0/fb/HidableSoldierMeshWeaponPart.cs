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
	[ContainerType(4, 16)]
	public class HidableSoldierMeshWeaponPart
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public CtrRef<SkinnedMeshAsset> WeaponMesh { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public CtrRef<ObjectBlueprint> WeaponMeshBlueprint { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string BoneName { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public bool HideAlways { get; set; }
		
		[ContainerField(13), LayoutImmutable, Blittable, JsonProperty(Order = 13)]
		public bool HideInVehicleEntries { get; set; }
		
	}
}
