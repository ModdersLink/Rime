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

using fb.Entity;
using fb.Core;
using fb.WorldRender;

namespace fb.GameShared;

[ContainerType(16, 208)]
public class ExplosionEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<EffectBlueprint> DetonationEffect { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<EffectBlueprint> DetonationEffectForFriendlies { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<MaskVolumeEntityData> MaskVolume { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<DestructionMaskVolumeEntityData> DestructionMaskVolume { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public MaterialDecl MaterialPair { get; set; } = new();
	
	[ContainerField(0x84), JsonProperty(Order = 132)]
	public MaterialDecl SecondaryMaterialPair { get; set; } = new();
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public DamageIndicationType DamageIndicationType { get; set; } = fb.GameShared.DamageIndicationType.DamageIndicationType_GiverPlayer;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float EmpTime { get; set; } = 0.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float MaxOcclusionRaycastRadius { get; set; } = 0.500f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float InnerBlastRadius { get; set; } = 1.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float BlastDamage { get; set; } = 100.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float BlastRadius { get; set; } = 5.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float BlastImpulse { get; set; } = 5000.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float ShockwaveDamage { get; set; } = 1.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float ShockwaveRadius { get; set; } = 15.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float ShockwaveImpulse { get; set; } = 500.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float ShockwaveTime { get; set; } = 0.250f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float CameraShockwaveRadius { get; set; } = 3.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float SpawnDelay { get; set; } = 0.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public bool NoFriendliesEffectOnEnabledFriendlyFire { get; set; } = true;
	
	[ContainerField(0xbd), LayoutImmutable, Blittable, JsonProperty(Order = 189)]
	public bool UseEntityTransformForDetonationEffect { get; set; } = false;
	
	[ContainerField(0xbe), LayoutImmutable, Blittable, JsonProperty(Order = 190)]
	public bool SecondaryMaterialsActive { get; set; } = false;
	
	[ContainerField(0xbf), LayoutImmutable, Blittable, JsonProperty(Order = 191)]
	public bool HasStunEffect { get; set; } = false;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public bool DisableOcclusion { get; set; } = false;
	
	[ContainerField(0xc1), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
	public bool DisableStaticEntityOcclusion { get; set; } = false;
	
	[ContainerField(0xc2), LayoutImmutable, Blittable, JsonProperty(Order = 194)]
	public bool TriggerImpairedHearing { get; set; } = true;
	
	[ContainerField(0xc3), LayoutImmutable, Blittable, JsonProperty(Order = 195)]
	public bool Enabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(DetonationEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DetonationEffectForFriendlies));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MaskVolume));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DestructionMaskVolume));
		p_Writer.WriteNullBytes(4);
		MaterialPair.Serialize(p_Writer, p_EbxWriter);
		SecondaryMaterialPair.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) DamageIndicationType);
		p_Writer.Write(EmpTime);
		p_Writer.Write(MaxOcclusionRaycastRadius);
		p_Writer.Write(InnerBlastRadius);
		p_Writer.Write(BlastDamage);
		p_Writer.Write(BlastRadius);
		p_Writer.Write(BlastImpulse);
		p_Writer.Write(ShockwaveDamage);
		p_Writer.Write(ShockwaveRadius);
		p_Writer.Write(ShockwaveImpulse);
		p_Writer.Write(ShockwaveTime);
		p_Writer.Write(CameraShockwaveRadius);
		p_Writer.Write(SpawnDelay);
		p_Writer.Write(NoFriendliesEffectOnEnabledFriendlyFire);
		p_Writer.Write(UseEntityTransformForDetonationEffect);
		p_Writer.Write(SecondaryMaterialsActive);
		p_Writer.Write(HasStunEffect);
		p_Writer.Write(DisableOcclusion);
		p_Writer.Write(DisableStaticEntityOcclusion);
		p_Writer.Write(TriggerImpairedHearing);
		p_Writer.Write(Enabled);
		p_Writer.WriteNullBytes(12);
	}
}

