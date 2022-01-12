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
	[ContainerType(4, 36)]
	public class MaterialRelationDamageData : 
		PhysicsPropertyRelationPropertyData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CollisionDamageMultiplier { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float CollisionDamageThreshold { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float DamageProtectionMultiplier { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float DamagePenetrationMultiplier { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float DamageProtectionThreshold { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float ExplosionCoverDamageModifier { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool InflictsDemolitionDamage { get; set; }

	}
}
