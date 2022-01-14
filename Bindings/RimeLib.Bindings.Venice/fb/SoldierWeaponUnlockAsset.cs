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
	[ContainerType(4, 52)]
	public class SoldierWeaponUnlockAsset : 
		UnlockAssetBase
	{
		[ContainerField(40), JsonProperty(Order = 40)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public CtrRef<UnlockAssetBase> Extra { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public uint WeaponIdentifier { get; set; }

	}
}
