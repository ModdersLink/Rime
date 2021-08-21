///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 320)]
	public class MissileEntityData : 
		MeshProjectileEntityData
	{
		protected float m_Gravity = new float();
		[ContainerField(Name: "Gravity", Offset: 192, NameHash: 3295092963, Flags: 49469), LayoutImmutable, Blittable]
		public float Gravity { get { return m_Gravity; } set { if (OnPropertyChanging("MissileEntityData." + nameof(Gravity), this, m_Gravity, value)) m_Gravity = value; } } // 0xC0 (192)
		
		protected CtrRef<EffectBlueprint> m_EngineEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(Name: "EngineEffect", Offset: 196, NameHash: 2238351068, Flags: 53)]
		public CtrRef<EffectBlueprint> EngineEffect { get { return m_EngineEffect; } set { if (OnPropertyChanging("MissileEntityData." + nameof(EngineEffect), this, m_EngineEffect, value)) m_EngineEffect = value; } } // 0xC4 (196)
		
		protected CtrRef<ExplosionEntityData> m_DudExplosion = new CtrRef<ExplosionEntityData>();
		[ContainerField(Name: "DudExplosion", Offset: 200, NameHash: 123118469, Flags: 53)]
		public CtrRef<ExplosionEntityData> DudExplosion { get { return m_DudExplosion; } set { if (OnPropertyChanging("MissileEntityData." + nameof(DudExplosion), this, m_DudExplosion, value)) m_DudExplosion = value; } } // 0xC8 (200)
		
		protected CtrRef<SoundAsset> m_FlyBySound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "FlyBySound", Offset: 204, NameHash: 3743063886, Flags: 53)]
		public CtrRef<SoundAsset> FlyBySound { get { return m_FlyBySound; } set { if (OnPropertyChanging("MissileEntityData." + nameof(FlyBySound), this, m_FlyBySound, value)) m_FlyBySound = value; } } // 0xCC (204)
		
		protected float m_EngineStrength = new float();
		[ContainerField(Name: "EngineStrength", Offset: 208, NameHash: 1553827310, Flags: 49469), LayoutImmutable, Blittable]
		public float EngineStrength { get { return m_EngineStrength; } set { if (OnPropertyChanging("MissileEntityData." + nameof(EngineStrength), this, m_EngineStrength, value)) m_EngineStrength = value; } } // 0xD0 (208)
		
		protected float m_MaxSpeed = new float();
		[ContainerField(Name: "MaxSpeed", Offset: 212, NameHash: 396228950, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxSpeed { get { return m_MaxSpeed; } set { if (OnPropertyChanging("MissileEntityData." + nameof(MaxSpeed), this, m_MaxSpeed, value)) m_MaxSpeed = value; } } // 0xD4 (212)
		
		protected float m_EngineTimeToIgnition = new float();
		[ContainerField(Name: "EngineTimeToIgnition", Offset: 216, NameHash: 916282736, Flags: 49469), LayoutImmutable, Blittable]
		public float EngineTimeToIgnition { get { return m_EngineTimeToIgnition; } set { if (OnPropertyChanging("MissileEntityData." + nameof(EngineTimeToIgnition), this, m_EngineTimeToIgnition, value)) m_EngineTimeToIgnition = value; } } // 0xD8 (216)
		
		protected float m_EngineTimeToLive = new float();
		[ContainerField(Name: "EngineTimeToLive", Offset: 220, NameHash: 41196403, Flags: 49469), LayoutImmutable, Blittable]
		public float EngineTimeToLive { get { return m_EngineTimeToLive; } set { if (OnPropertyChanging("MissileEntityData." + nameof(EngineTimeToLive), this, m_EngineTimeToLive, value)) m_EngineTimeToLive = value; } } // 0xDC (220)
		
		protected float m_TimeToActivateGuidingSystem = new float();
		[ContainerField(Name: "TimeToActivateGuidingSystem", Offset: 224, NameHash: 2537799752, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeToActivateGuidingSystem { get { return m_TimeToActivateGuidingSystem; } set { if (OnPropertyChanging("MissileEntityData." + nameof(TimeToActivateGuidingSystem), this, m_TimeToActivateGuidingSystem, value)) m_TimeToActivateGuidingSystem = value; } } // 0xE0 (224)
		
		protected float m_TimeToArm = new float();
		[ContainerField(Name: "TimeToArm", Offset: 228, NameHash: 177776085, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeToArm { get { return m_TimeToArm; } set { if (OnPropertyChanging("MissileEntityData." + nameof(TimeToArm), this, m_TimeToArm, value)) m_TimeToArm = value; } } // 0xE4 (228)
		
		protected float m_MaxTurnAngle = new float();
		[ContainerField(Name: "MaxTurnAngle", Offset: 232, NameHash: 2995598829, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxTurnAngle { get { return m_MaxTurnAngle; } set { if (OnPropertyChanging("MissileEntityData." + nameof(MaxTurnAngle), this, m_MaxTurnAngle, value)) m_MaxTurnAngle = value; } } // 0xE8 (232)
		
		protected float m_Drag = new float();
		[ContainerField(Name: "Drag", Offset: 236, NameHash: 2088752789, Flags: 49469), LayoutImmutable, Blittable]
		public float Drag { get { return m_Drag; } set { if (OnPropertyChanging("MissileEntityData." + nameof(Drag), this, m_Drag, value)) m_Drag = value; } } // 0xEC (236)
		
		protected NearTargetDetonationData m_NearTargetDetonation = new NearTargetDetonationData();
		[ContainerField(Name: "NearTargetDetonation", Offset: 240, NameHash: 3676526149, Flags: 41)]
		public NearTargetDetonationData NearTargetDetonation { get { return m_NearTargetDetonation; } set { if (OnPropertyChanging("MissileEntityData." + nameof(NearTargetDetonation), this, m_NearTargetDetonation, value)) m_NearTargetDetonation = value; } } // 0xF0 (240)
		
		protected TeamId m_DefaultTeam = new TeamId();
		[ContainerField(Name: "DefaultTeam", Offset: 256, NameHash: 2015081331, Flags: 137)]
		public TeamId DefaultTeam { get { return m_DefaultTeam; } set { if (OnPropertyChanging("MissileEntityData." + nameof(DefaultTeam), this, m_DefaultTeam, value)) m_DefaultTeam = value; } } // 0x100 (256)
		
		protected float m_FlyBySoundRadius = new float();
		[ContainerField(Name: "FlyBySoundRadius", Offset: 260, NameHash: 3728826774, Flags: 49469), LayoutImmutable, Blittable]
		public float FlyBySoundRadius { get { return m_FlyBySoundRadius; } set { if (OnPropertyChanging("MissileEntityData." + nameof(FlyBySoundRadius), this, m_FlyBySoundRadius, value)) m_FlyBySoundRadius = value; } } // 0x104 (260)
		
		protected float m_FlyBySoundSpeed = new float();
		[ContainerField(Name: "FlyBySoundSpeed", Offset: 264, NameHash: 4276155561, Flags: 49469), LayoutImmutable, Blittable]
		public float FlyBySoundSpeed { get { return m_FlyBySoundSpeed; } set { if (OnPropertyChanging("MissileEntityData." + nameof(FlyBySoundSpeed), this, m_FlyBySoundSpeed, value)) m_FlyBySoundSpeed = value; } } // 0x108 (264)
		
		protected float m_ImpactImpulse = new float();
		[ContainerField(Name: "ImpactImpulse", Offset: 268, NameHash: 59311612, Flags: 49469), LayoutImmutable, Blittable]
		public float ImpactImpulse { get { return m_ImpactImpulse; } set { if (OnPropertyChanging("MissileEntityData." + nameof(ImpactImpulse), this, m_ImpactImpulse, value)) m_ImpactImpulse = value; } } // 0x10C (268)
		
		protected float m_Damage = new float();
		[ContainerField(Name: "Damage", Offset: 272, NameHash: 2589892334, Flags: 49469), LayoutImmutable, Blittable]
		public float Damage { get { return m_Damage; } set { if (OnPropertyChanging("MissileEntityData." + nameof(Damage), this, m_Damage, value)) m_Damage = value; } } // 0x110 (272)
		
		protected MissileUnguidedData m_UnguidedData = new MissileUnguidedData();
		[ContainerField(Name: "UnguidedData", Offset: 276, NameHash: 952180624, Flags: 41)]
		public MissileUnguidedData UnguidedData { get { return m_UnguidedData; } set { if (OnPropertyChanging("MissileEntityData." + nameof(UnguidedData), this, m_UnguidedData, value)) m_UnguidedData = value; } } // 0x114 (276)
		
		protected WarnTarget m_WarnTarget = new WarnTarget();
		[ContainerField(Name: "WarnTarget", Offset: 296, NameHash: 1103784926, Flags: 137)]
		public WarnTarget WarnTarget { get { return m_WarnTarget; } set { if (OnPropertyChanging("MissileEntityData." + nameof(WarnTarget), this, m_WarnTarget, value)) m_WarnTarget = value; } } // 0x128 (296)
		
		protected MissileLockableInfoData m_LockableInfo = new MissileLockableInfoData();
		[ContainerField(Name: "LockableInfo", Offset: 300, NameHash: 632168042, Flags: 41)]
		public MissileLockableInfoData LockableInfo { get { return m_LockableInfo; } set { if (OnPropertyChanging("MissileEntityData." + nameof(LockableInfo), this, m_LockableInfo, value)) m_LockableInfo = value; } } // 0x12C (300)
		
		protected CtrRef<LockingControllerData> m_LockingController = new CtrRef<LockingControllerData>();
		[ContainerField(Name: "LockingController", Offset: 308, NameHash: 1783566994, Flags: 53)]
		public CtrRef<LockingControllerData> LockingController { get { return m_LockingController; } set { if (OnPropertyChanging("MissileEntityData." + nameof(LockingController), this, m_LockingController, value)) m_LockingController = value; } } // 0x134 (308)
		
		protected bool m_WarnOnPointingMissile = new bool();
		[ContainerField(Name: "WarnOnPointingMissile", Offset: 312, NameHash: 288907718, Flags: 49325), LayoutImmutable, Blittable]
		public bool WarnOnPointingMissile { get { return m_WarnOnPointingMissile; } set { if (OnPropertyChanging("MissileEntityData." + nameof(WarnOnPointingMissile), this, m_WarnOnPointingMissile, value)) m_WarnOnPointingMissile = value; } } // 0x138 (312)
		
		protected bool m_ApplyGravityWhenGuided = new bool();
		[ContainerField(Name: "ApplyGravityWhenGuided", Offset: 313, NameHash: 407646333, Flags: 49325), LayoutImmutable, Blittable]
		public bool ApplyGravityWhenGuided { get { return m_ApplyGravityWhenGuided; } set { if (OnPropertyChanging("MissileEntityData." + nameof(ApplyGravityWhenGuided), this, m_ApplyGravityWhenGuided, value)) m_ApplyGravityWhenGuided = value; } } // 0x139 (313)
		
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
