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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 36)]
	public class MaterialRelationDamageData :
		PhysicsPropertyRelationPropertyData
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float CollisionDamageMultiplier { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float CollisionDamageThreshold { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float DamageProtectionMultiplier { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float DamagePenetrationMultiplier { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float DamageProtectionThreshold { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ExplosionCoverDamageModifier { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool InflictsDemolitionDamage { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CollisionDamageMultiplier);
			p_Writer.Write(CollisionDamageThreshold);
			p_Writer.Write(DamageProtectionMultiplier);
			p_Writer.Write(DamagePenetrationMultiplier);
			p_Writer.Write(DamageProtectionThreshold);
			p_Writer.Write(ExplosionCoverDamageModifier);
			p_Writer.Write(InflictsDemolitionDamage);
			p_Writer.WriteNullBytes(3);
		}
	}
}
