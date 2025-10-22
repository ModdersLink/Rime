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
using fb.Entity;
using fb.Render;
using fb.Physics;

namespace fb.GameShared;

[ContainerType(16, 496)]
public class MissileEntityData
	: fb.GameShared.GhostedProjectileEntityData
{
	public MissileEntityData()
	{
		//GameComponentEntityData
		Enabled = false;
	}
	
	[ContainerField(0x130), JsonProperty(Order = 304)]
	public CtrRef<EffectBlueprint> EngineEffect { get; set; } = new();
	
	[ContainerField(0x138), JsonProperty(Order = 312)]
	public CtrRef<ExplosionEntityData> DudExplosion { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public CtrRef<SoundAsset> FlyBySound { get; set; } = new();
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public float EngineStrength { get; set; } = 100.000f;
	
	[ContainerField(0x14c), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
	public float MaxSpeed { get; set; } = 100.000f;
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public float EngineTimeToIgnition { get; set; } = 0.000f;
	
	[ContainerField(0x154), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
	public float EngineTimeToLive { get; set; } = 40.000f;
	
	[ContainerField(0x158), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
	public float TimeToActivateGuidingSystem { get; set; } = 0.000f;
	
	[ContainerField(0x15c), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
	public float TimeToArm { get; set; } = 0.000f;
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float MaxTurnAngle { get; set; } = 90.000f;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public float MinTurnAngle { get; set; } = -1.000f;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public float TurnAngleMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public float Drag { get; set; } = 10.000f;
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public float Gravity { get; set; } = -9.800f;
	
	[ContainerField(0x174), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
	public float FlyBySoundRadius { get; set; } = 5.000f;
	
	[ContainerField(0x178), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
	public float FlyBySoundSpeed { get; set; } = 10.000f;
	
	[ContainerField(0x17c), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
	public float ImpactImpulse { get; set; } = 50.000f;
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public float Damage { get; set; } = 20.000f;
	
	[ContainerField(0x184), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
	public TeamId DefaultTeam { get; set; } = TeamId.TeamNeutral;
	
	[ContainerField(0x188), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
	public WarnTarget WarnTarget { get; set; } = fb.GameShared.WarnTarget.wtWarnNone;
	
	[ContainerField(0x190), JsonProperty(Order = 400)]
	public CtrRef<LockingControllerData> LockingController { get; set; } = new();
	
	[ContainerField(0x198), JsonProperty(Order = 408)]
	public MissileLockableInfoData LockableInfo { get; set; } = new();
	
	[ContainerField(0x1a0), JsonProperty(Order = 416)]
	public MissileUnguidedData UnguidedData { get; set; } = new();
	
	[ContainerField(0x1b4), JsonProperty(Order = 436)]
	public NearTargetDetonationData NearTargetDetonation { get; set; } = new();
	
	[ContainerField(0x1c4), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
	public float MaxBankAngle { get; set; } = 90.000f;
	
	[ContainerField(0x1c8), LayoutImmutable, Blittable, JsonProperty(Order = 456)]
	public float BankingSpeed { get; set; } = 1.000f;
	
	[ContainerField(0x1d0), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
	public string Icon { get; set; } = string.Empty;
	
	[ContainerField(0x1d8), LayoutImmutable, Blittable, JsonProperty(Order = 472)]
	public string TargetIcon { get; set; } = string.Empty;
	
	[ContainerField(0x1e0), LayoutImmutable, Blittable, JsonProperty(Order = 480)]
	public string TargetIconEnemy { get; set; } = string.Empty;
	
	[ContainerField(0x1e8), LayoutImmutable, Blittable, JsonProperty(Order = 488)]
	public float MinGhostFrequency { get; set; } = 0.000f;
	
	[ContainerField(0x1ec), LayoutImmutable, Blittable, JsonProperty(Order = 492)]
	public bool ApplyGravityWhenGuided { get; set; } = false;
	
	[ContainerField(0x1ed), LayoutImmutable, Blittable, JsonProperty(Order = 493)]
	public bool WarnOnPointingMissile { get; set; } = false;
	
	[ContainerField(0x1ee), LayoutImmutable, Blittable, JsonProperty(Order = 494)]
	public bool EnableBanking { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(EngineEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DudExplosion));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FlyBySound));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(EngineStrength);
		p_Writer.Write(MaxSpeed);
		p_Writer.Write(EngineTimeToIgnition);
		p_Writer.Write(EngineTimeToLive);
		p_Writer.Write(TimeToActivateGuidingSystem);
		p_Writer.Write(TimeToArm);
		p_Writer.Write(MaxTurnAngle);
		p_Writer.Write(MinTurnAngle);
		p_Writer.Write(TurnAngleMultiplier);
		p_Writer.Write(Drag);
		p_Writer.Write(Gravity);
		p_Writer.Write(FlyBySoundRadius);
		p_Writer.Write(FlyBySoundSpeed);
		p_Writer.Write(ImpactImpulse);
		p_Writer.Write(Damage);
		p_Writer.Write((int) DefaultTeam);
		p_Writer.Write((int) WarnTarget);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LockingController));
		p_Writer.WriteNullBytes(4);
		LockableInfo.Serialize(p_Writer, p_EbxWriter);
		UnguidedData.Serialize(p_Writer, p_EbxWriter);
		NearTargetDetonation.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxBankAngle);
		p_Writer.Write(BankingSpeed);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(Icon));
		p_Writer.Write(p_EbxWriter.WriteString(TargetIcon));
		p_Writer.Write(p_EbxWriter.WriteString(TargetIconEnemy));
		p_Writer.Write(MinGhostFrequency);
		p_Writer.Write(ApplyGravityWhenGuided);
		p_Writer.Write(WarnOnPointingMissile);
		p_Writer.Write(EnableBanking);
		p_Writer.WriteNullBytes(1);
	}
}

