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
using fb.Render;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 224)]
public class WeaponComponentData
	: fb.GameShared.BoneComponentData
{
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 ProjectileSpawnOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 TargetPositionOverride { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<MeshAsset> WeaponMesh { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public CtrRef<WeaponFiringData> WeaponFiring { get; set; } = new();
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public string DamageGiverName { get; set; } = string.Empty;
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<GameAIWeaponData> AIData { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<WeaponData> CustomWeaponType { get; set; } = new();
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float ImpulseStrength { get; set; } = 0.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public WeaponClassification Classification { get; set; } = WeaponClassification.WCNone;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float ReloadTimeMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float DamageMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float ExplosionDamageMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float OverheatDropPerSecondMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float LockTimeMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float LockingAcceptanceAngleMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public uint WeaponItemHash { get; set; } = 0;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public bool SequentialFiring { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		ProjectileSpawnOffset.Serialize(p_Writer, p_EbxWriter);
		TargetPositionOverride.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(WeaponMesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(WeaponFiring));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(DamageGiverName));
		p_Writer.Write(p_EbxWriter.WriteImport(AIData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CustomWeaponType));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ImpulseStrength);
		p_Writer.Write((int) Classification);
		p_Writer.Write(ReloadTimeMultiplier);
		p_Writer.Write(DamageMultiplier);
		p_Writer.Write(ExplosionDamageMultiplier);
		p_Writer.Write(OverheatDropPerSecondMultiplier);
		p_Writer.Write(LockTimeMultiplier);
		p_Writer.Write(LockingAcceptanceAngleMultiplier);
		p_Writer.Write(WeaponItemHash);
		p_Writer.Write(SequentialFiring);
		p_Writer.WriteNullBytes(3);
	}
}

