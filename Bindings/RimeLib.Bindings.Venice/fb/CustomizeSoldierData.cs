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
	[ContainerType(4, 48)]
	public class CustomizeSoldierData : 
		CustomizeCharacterData
	{
		[ContainerField(32), JsonProperty(Order = 32)]
		public List<UnlockWeaponAndSlot> Weapons { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public WeaponSlot ActiveSlot { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public CtrRef<PickupEntityAsset> DeathPickup { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool RemoveAllExistingWeapons { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		public bool DisableDeathPickup { get; set; }

	}
}
