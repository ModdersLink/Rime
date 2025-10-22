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

namespace fb.VeniceShared;

[ContainerType(16, 160)]
public class SoldierSuppressionComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public SuppressionReactionData ReactionToSuppression { get; set; } = new();
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float SuppressionResistModifier { get; set; } = 1.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float SuppressionBoostModifier { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float SuppressionDecay { get; set; } = 1.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float SuppressionSphereRadius { get; set; } = 2.500f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float FallOffDelay { get; set; } = 2.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float FallOffMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float SuppressedEffectTimescale { get; set; } = 0.100f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public bool SuppressionAbortsHealthRegeneration { get; set; } = false;
	
	[ContainerField(0x99), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
	public bool CheckLineOfSight { get; set; } = true;
	
	[ContainerField(0x9a), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
	public bool SuppressionLevelWriteEnabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		ReactionToSuppression.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SuppressionResistModifier);
		p_Writer.Write(SuppressionBoostModifier);
		p_Writer.Write(SuppressionDecay);
		p_Writer.Write(SuppressionSphereRadius);
		p_Writer.Write(FallOffDelay);
		p_Writer.Write(FallOffMultiplier);
		p_Writer.Write(SuppressedEffectTimescale);
		p_Writer.Write(SuppressionAbortsHealthRegeneration);
		p_Writer.Write(CheckLineOfSight);
		p_Writer.Write(SuppressionLevelWriteEnabled);
		p_Writer.WriteNullBytes(5);
	}
}

