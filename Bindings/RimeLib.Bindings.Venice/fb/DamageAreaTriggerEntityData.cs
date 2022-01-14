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
	[ContainerType(16, 144)]
	public class DamageAreaTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float DamagePerSecond { get; set; }

		[ContainerField(116), JsonProperty(Order = 116)]
		public TeamId TeamOfImmortalCharacters { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float DamageTime { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public bool DamageVehicles { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		public bool DamageBangers { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
		public bool ExcludeImmortalCharactersInTeam { get; set; }

		[ContainerField(127), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
		public bool DamageCharacters { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public bool ExcludeShieldedSoldiers { get; set; }

	}
}
