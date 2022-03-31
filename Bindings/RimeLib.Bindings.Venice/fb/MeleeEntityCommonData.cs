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
	[ContainerType(4, 100)]
	public class MeleeEntityCommonData : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CharacterMeleeBinding MeleeBinding { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CharacterMeleeCommonBinding MeleeCommonBinding { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float TriggerDelay { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float DefendWindow { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float KillDelay { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float MeleeEndDelay { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float InvalidMeleeAttackZone { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float MeleeAttackDistance { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float MaxAttackHeightDifference { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float KillDamage { get; set; }

		[ContainerField(88), JsonProperty(Order = 88)]
		public CtrRef<AntEnumeration> ProneAttackType { get; set; } = new();

		[ContainerField(92), JsonProperty(Order = 92)]
		public CtrRef<AntEnumeration> CrouchAttackType { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool EnableAbortPossibility { get; set; }

	}
}
