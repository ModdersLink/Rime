///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
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
		[ContainerField(112), LayoutImmutable, Blittable]
		public float DamagePerSecond { get; set; }

		[ContainerField(116)]
		public TeamId TeamOfImmortalCharacters { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public float DamageTime { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool DamageVehicles { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool DamageBangers { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable]
		public bool ExcludeImmortalCharactersInTeam { get; set; }

		[ContainerField(127), LayoutImmutable, Blittable]
		public bool DamageCharacters { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool ExcludeShieldedSoldiers { get; set; }

	}
}
