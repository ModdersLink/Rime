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
using fb.Audio;
using fb.Render;
using fb.Entity;
using fb.Physics;

namespace fb.GameShared;

[ContainerType(16, 368)]
public class BulletEntityData
	: fb.GameShared.MeshProjectileEntityData
{
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public CtrRef<SoundAsset> FlyBySound { get; set; } = new();
	
	[ContainerField(0x128), JsonProperty(Order = 296)]
	public CtrRef<ExplosionEntityData> DudExplosion { get; set; } = new();
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float Gravity { get; set; } = 0.000f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public float ImpactImpulse { get; set; } = 50.000f;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public float DetonationTimeVariation { get; set; } = 0.000f;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public float VehicleDetonationRadius { get; set; } = 0.000f;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public float VehicleDetonationActivationDelay { get; set; } = 0.000f;
	
	[ContainerField(0x144), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
	public float FlyBySoundRadius { get; set; } = 5.000f;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public float FlyBySoundSpeed { get; set; } = 20.000f;
	
	[ContainerField(0x14c), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
	public float Stamina { get; set; } = 0.000f;
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public float DistributeDamageOverTime { get; set; } = 0.000f;
	
	[ContainerField(0x154), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
	public float StartDamage { get; set; } = 20.000f;
	
	[ContainerField(0x158), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
	public float EndDamage { get; set; } = 10.000f;
	
	[ContainerField(0x15c), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
	public float DamageFalloffStartDistance { get; set; } = 100.000f;
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float DamageFalloffEndDistance { get; set; } = 200.000f;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public float TimeToArmExplosion { get; set; } = 0.000f;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public float FirstFrameTravelDistance { get; set; } = 0.000f;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public bool HasVehicleDetonation { get; set; } = false;
	
	[ContainerField(0x16d), LayoutImmutable, Blittable, JsonProperty(Order = 365)]
	public bool InstantHit { get; set; } = false;
	
	[ContainerField(0x16e), LayoutImmutable, Blittable, JsonProperty(Order = 366)]
	public bool StopTrailEffectOnUnspawn { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(FlyBySound));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DudExplosion));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Gravity);
		p_Writer.Write(ImpactImpulse);
		p_Writer.Write(DetonationTimeVariation);
		p_Writer.Write(VehicleDetonationRadius);
		p_Writer.Write(VehicleDetonationActivationDelay);
		p_Writer.Write(FlyBySoundRadius);
		p_Writer.Write(FlyBySoundSpeed);
		p_Writer.Write(Stamina);
		p_Writer.Write(DistributeDamageOverTime);
		p_Writer.Write(StartDamage);
		p_Writer.Write(EndDamage);
		p_Writer.Write(DamageFalloffStartDistance);
		p_Writer.Write(DamageFalloffEndDistance);
		p_Writer.Write(TimeToArmExplosion);
		p_Writer.Write(FirstFrameTravelDistance);
		p_Writer.Write(HasVehicleDetonation);
		p_Writer.Write(InstantHit);
		p_Writer.Write(StopTrailEffectOnUnspawn);
		p_Writer.WriteNullBytes(1);
	}
}

