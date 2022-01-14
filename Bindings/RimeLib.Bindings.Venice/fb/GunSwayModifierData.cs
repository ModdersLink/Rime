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
	[ContainerType(4, 212)]
	public class GunSwayModifierData : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public GunSwayStanceZoomModifierData StandZoomModifier { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public GunSwayStanceZoomModifierData StandNoZoomModifier { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public GunSwayStanceZoomModifierData CrouchZoomModifier { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public GunSwayStanceZoomModifierData CrouchNoZoomModifier { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public GunSwayStanceZoomModifierData ProneZoomModifier { get; set; } = new();

		[ContainerField(176), JsonProperty(Order = 176)]
		public GunSwayStanceZoomModifierData ProneNoZoomModifier { get; set; } = new();

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public bool OnlyInSupportedShooting { get; set; }

		[ContainerField(209), LayoutImmutable, Blittable, JsonProperty(Order = 209)]
		public bool OnlyOnWeaponLightEnabled { get; set; }

	}
}
