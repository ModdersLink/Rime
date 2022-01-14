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
	[ContainerType(4, 28)]
	public class TeamData : 
		TeamAsset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<SoldierBlueprint> Soldier { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public FactionId Faction { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<SoldierCustomizationAsset> SoldierCustomization { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public RefArray<VehicleCustomizationAsset> VehicleCustomization { get; set; } = new();

	}
}
