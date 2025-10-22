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

using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 48)]
public class MaterialRelationDamageData
	: fb.Entity.PhysicsPropertyRelationPropertyData
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float CollisionDamageMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float CollisionDamageThreshold { get; set; } = 30.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float DamageProtectionMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float DamagePenetrationMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float DamageProtectionThreshold { get; set; } = 2.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float ExplosionCoverDamageModifier { get; set; } = 1.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool InflictsDemolitionDamage { get; set; } = true;
	
	[ContainerField(0x29), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
	public bool AllowClientDestruction { get; set; } = false;
	
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
		p_Writer.Write(AllowClientDestruction);
		p_Writer.WriteNullBytes(6);
	}
}

