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
	[ContainerType(4, 36)]
	public class StatsCategoryWeaponData : 
		StatsCategoryGuidData
	{
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint SoldierWeaponId { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<CriteriaGateList> AccessoryUnlockGates { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public List<BasicUnlockInfo> UnlocksInfo { get; set; } = new();

	}
}
