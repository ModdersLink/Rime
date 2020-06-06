///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class MissileEntityData : 
		MeshProjectileEntityData
	{
		[ContainerField(192), LayoutImmutable, Blittable]
		public float Gravity { get; set; } // 0xC0 (192)
		
		[ContainerField(196)]
		public CtrRef<EffectBlueprint> EngineEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0xC4 (196)
		
		[ContainerField(200)]
		public CtrRef<ExplosionEntityData> DudExplosion { get; set; } = new CtrRef<ExplosionEntityData>(); // 0xC8 (200)
		
		[ContainerField(204)]
		public CtrRef<SoundAsset> FlyBySound { get; set; } = new CtrRef<SoundAsset>(); // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float EngineStrength { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float MaxSpeed { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float EngineTimeToIgnition { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float EngineTimeToLive { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public float TimeToActivateGuidingSystem { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public float TimeToArm { get; set; } // 0xE4 (228)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public float MaxTurnAngle { get; set; } // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public float Drag { get; set; } // 0xEC (236)
		
		[ContainerField(240)]
		public NearTargetDetonationData NearTargetDetonation { get; set; } = new NearTargetDetonationData(); // 0xF0 (240)
		
		[ContainerField(256)]
		public TeamId DefaultTeam { get; set; } = new TeamId(); // 0x100 (256)
		
		[ContainerField(260), LayoutImmutable, Blittable]
		public float FlyBySoundRadius { get; set; } // 0x104 (260)
		
		[ContainerField(264), LayoutImmutable, Blittable]
		public float FlyBySoundSpeed { get; set; } // 0x108 (264)
		
		[ContainerField(268), LayoutImmutable, Blittable]
		public float ImpactImpulse { get; set; } // 0x10C (268)
		
		[ContainerField(272), LayoutImmutable, Blittable]
		public float Damage { get; set; } // 0x110 (272)
		
		[ContainerField(276)]
		public MissileUnguidedData UnguidedData { get; set; } = new MissileUnguidedData(); // 0x114 (276)
		
		[ContainerField(296)]
		public WarnTarget WarnTarget { get; set; } = new WarnTarget(); // 0x128 (296)
		
		[ContainerField(300)]
		public MissileLockableInfoData LockableInfo { get; set; } = new MissileLockableInfoData(); // 0x12C (300)
		
		[ContainerField(308)]
		public CtrRef<LockingControllerData> LockingController { get; set; } = new CtrRef<LockingControllerData>(); // 0x134 (308)
		
		[ContainerField(312), LayoutImmutable, Blittable]
		public bool WarnOnPointingMissile { get; set; } // 0x138 (312)
		
		[ContainerField(313), LayoutImmutable, Blittable]
		public bool ApplyGravityWhenGuided { get; set; } // 0x139 (313)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3295092963:
					Gravity = (float) p_Value;
					break;

				case 2238351068:
					EngineEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 123118469:
					DudExplosion = (CtrRef<ExplosionEntityData>) p_Value;
					break;

				case 3743063886:
					FlyBySound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 1553827310:
					EngineStrength = (float) p_Value;
					break;

				case 396228950:
					MaxSpeed = (float) p_Value;
					break;

				case 916282736:
					EngineTimeToIgnition = (float) p_Value;
					break;

				case 41196403:
					EngineTimeToLive = (float) p_Value;
					break;

				case 2537799752:
					TimeToActivateGuidingSystem = (float) p_Value;
					break;

				case 177776085:
					TimeToArm = (float) p_Value;
					break;

				case 2995598829:
					MaxTurnAngle = (float) p_Value;
					break;

				case 2088752789:
					Drag = (float) p_Value;
					break;

				case 3676526149:
					NearTargetDetonation = (NearTargetDetonationData) p_Value;
					break;

				case 2015081331:
					DefaultTeam = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 3728826774:
					FlyBySoundRadius = (float) p_Value;
					break;

				case 4276155561:
					FlyBySoundSpeed = (float) p_Value;
					break;

				case 59311612:
					ImpactImpulse = (float) p_Value;
					break;

				case 2589892334:
					Damage = (float) p_Value;
					break;

				case 952180624:
					UnguidedData = (MissileUnguidedData) p_Value;
					break;

				case 1103784926:
					WarnTarget = (WarnTarget) Enum.ToObject(typeof(WarnTarget), p_Value);
					break;

				case 632168042:
					LockableInfo = (MissileLockableInfoData) p_Value;
					break;

				case 1783566994:
					LockingController = (CtrRef<LockingControllerData>) p_Value;
					break;

				case 288907718:
					WarnOnPointingMissile = (bool) p_Value;
					break;

				case 407646333:
					ApplyGravityWhenGuided = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3295092963:
					return Gravity;

				case 2238351068:
					return EngineEffect;

				case 123118469:
					return DudExplosion;

				case 3743063886:
					return FlyBySound;

				case 1553827310:
					return EngineStrength;

				case 396228950:
					return MaxSpeed;

				case 916282736:
					return EngineTimeToIgnition;

				case 41196403:
					return EngineTimeToLive;

				case 2537799752:
					return TimeToActivateGuidingSystem;

				case 177776085:
					return TimeToArm;

				case 2995598829:
					return MaxTurnAngle;

				case 2088752789:
					return Drag;

				case 3676526149:
					return NearTargetDetonation;

				case 2015081331:
					return DefaultTeam;

				case 3728826774:
					return FlyBySoundRadius;

				case 4276155561:
					return FlyBySoundSpeed;

				case 59311612:
					return ImpactImpulse;

				case 2589892334:
					return Damage;

				case 952180624:
					return UnguidedData;

				case 1103784926:
					return WarnTarget;

				case 632168042:
					return LockableInfo;

				case 1783566994:
					return LockingController;

				case 288907718:
					return WarnOnPointingMissile;

				case 407646333:
					return ApplyGravityWhenGuided;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3295092963:
					return typeof(MissileEntityData).GetProperty(nameof(Gravity));

				case 2238351068:
					return typeof(MissileEntityData).GetProperty(nameof(EngineEffect));

				case 123118469:
					return typeof(MissileEntityData).GetProperty(nameof(DudExplosion));

				case 3743063886:
					return typeof(MissileEntityData).GetProperty(nameof(FlyBySound));

				case 1553827310:
					return typeof(MissileEntityData).GetProperty(nameof(EngineStrength));

				case 396228950:
					return typeof(MissileEntityData).GetProperty(nameof(MaxSpeed));

				case 916282736:
					return typeof(MissileEntityData).GetProperty(nameof(EngineTimeToIgnition));

				case 41196403:
					return typeof(MissileEntityData).GetProperty(nameof(EngineTimeToLive));

				case 2537799752:
					return typeof(MissileEntityData).GetProperty(nameof(TimeToActivateGuidingSystem));

				case 177776085:
					return typeof(MissileEntityData).GetProperty(nameof(TimeToArm));

				case 2995598829:
					return typeof(MissileEntityData).GetProperty(nameof(MaxTurnAngle));

				case 2088752789:
					return typeof(MissileEntityData).GetProperty(nameof(Drag));

				case 3676526149:
					return typeof(MissileEntityData).GetProperty(nameof(NearTargetDetonation));

				case 2015081331:
					return typeof(MissileEntityData).GetProperty(nameof(DefaultTeam));

				case 3728826774:
					return typeof(MissileEntityData).GetProperty(nameof(FlyBySoundRadius));

				case 4276155561:
					return typeof(MissileEntityData).GetProperty(nameof(FlyBySoundSpeed));

				case 59311612:
					return typeof(MissileEntityData).GetProperty(nameof(ImpactImpulse));

				case 2589892334:
					return typeof(MissileEntityData).GetProperty(nameof(Damage));

				case 952180624:
					return typeof(MissileEntityData).GetProperty(nameof(UnguidedData));

				case 1103784926:
					return typeof(MissileEntityData).GetProperty(nameof(WarnTarget));

				case 632168042:
					return typeof(MissileEntityData).GetProperty(nameof(LockableInfo));

				case 1783566994:
					return typeof(MissileEntityData).GetProperty(nameof(LockingController));

				case 288907718:
					return typeof(MissileEntityData).GetProperty(nameof(WarnOnPointingMissile));

				case 407646333:
					return typeof(MissileEntityData).GetProperty(nameof(ApplyGravityWhenGuided));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
