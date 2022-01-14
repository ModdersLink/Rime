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
	[ContainerType(16, 112)]
	public class CharacterWeaponComponentData : 
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<SoldierWeaponBlueprint> DefaultWeaponBlueprint { get; set; } = new();

		[ContainerField(100), LayoutImmutable, JsonProperty(Order = 100)]
		public string AimBoneName { get; set; } = string.Empty;

		[ContainerField(104), JsonProperty(Order = 104)]
		public CtrRef<SkeletonAsset> WeaponSkeleton { get; set; } = new();

	}
}
