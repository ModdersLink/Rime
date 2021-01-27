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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 272)]
	public class BulletEntityData : 
		MeshProjectileEntityData
	{
		protected float m_Stamina = new float();
		[ContainerField(Name: "Stamina", Offset: 192, NameHash: 2176368840, Flags: 49469), LayoutImmutable, Blittable]
		public float Stamina { get { return m_Stamina; } set { if (OnPropertyChanging("BulletEntityData." + nameof(Stamina), this, m_Stamina, value)) m_Stamina = value; } } // 0xC0 (192)
		
		protected CtrRef<SoundAsset> m_FlyBySound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "FlyBySound", Offset: 196, NameHash: 3743063886, Flags: 53)]
		public CtrRef<SoundAsset> FlyBySound { get { return m_FlyBySound; } set { if (OnPropertyChanging("BulletEntityData." + nameof(FlyBySound), this, m_FlyBySound, value)) m_FlyBySound = value; } } // 0xC4 (196)
		
		protected CtrRef<ExplosionEntityData> m_DudExplosion = new CtrRef<ExplosionEntityData>();
		[ContainerField(Name: "DudExplosion", Offset: 200, NameHash: 123118469, Flags: 53)]
		public CtrRef<ExplosionEntityData> DudExplosion { get { return m_DudExplosion; } set { if (OnPropertyChanging("BulletEntityData." + nameof(DudExplosion), this, m_DudExplosion, value)) m_DudExplosion = value; } } // 0xC8 (200)
		
		protected float m_Gravity = new float();
		[ContainerField(Name: "Gravity", Offset: 204, NameHash: 3295092963, Flags: 49469), LayoutImmutable, Blittable]
		public float Gravity { get { return m_Gravity; } set { if (OnPropertyChanging("BulletEntityData." + nameof(Gravity), this, m_Gravity, value)) m_Gravity = value; } } // 0xCC (204)
		
		protected float m_ImpactImpulse = new float();
		[ContainerField(Name: "ImpactImpulse", Offset: 208, NameHash: 59311612, Flags: 49469), LayoutImmutable, Blittable]
		public float ImpactImpulse { get { return m_ImpactImpulse; } set { if (OnPropertyChanging("BulletEntityData." + nameof(ImpactImpulse), this, m_ImpactImpulse, value)) m_ImpactImpulse = value; } } // 0xD0 (208)
		
		protected float m_DetonationTimeVariation = new float();
		[ContainerField(Name: "DetonationTimeVariation", Offset: 212, NameHash: 246395272, Flags: 49469), LayoutImmutable, Blittable]
		public float DetonationTimeVariation { get { return m_DetonationTimeVariation; } set { if (OnPropertyChanging("BulletEntityData." + nameof(DetonationTimeVariation), this, m_DetonationTimeVariation, value)) m_DetonationTimeVariation = value; } } // 0xD4 (212)
		
		protected float m_VehicleDetonationRadius = new float();
		[ContainerField(Name: "VehicleDetonationRadius", Offset: 216, NameHash: 1470001196, Flags: 49469), LayoutImmutable, Blittable]
		public float VehicleDetonationRadius { get { return m_VehicleDetonationRadius; } set { if (OnPropertyChanging("BulletEntityData." + nameof(VehicleDetonationRadius), this, m_VehicleDetonationRadius, value)) m_VehicleDetonationRadius = value; } } // 0xD8 (216)
		
		protected float m_VehicleDetonationActivationDelay = new float();
		[ContainerField(Name: "VehicleDetonationActivationDelay", Offset: 220, NameHash: 4100261205, Flags: 49469), LayoutImmutable, Blittable]
		public float VehicleDetonationActivationDelay { get { return m_VehicleDetonationActivationDelay; } set { if (OnPropertyChanging("BulletEntityData." + nameof(VehicleDetonationActivationDelay), this, m_VehicleDetonationActivationDelay, value)) m_VehicleDetonationActivationDelay = value; } } // 0xDC (220)
		
		protected float m_FlyBySoundRadius = new float();
		[ContainerField(Name: "FlyBySoundRadius", Offset: 224, NameHash: 3728826774, Flags: 49469), LayoutImmutable, Blittable]
		public float FlyBySoundRadius { get { return m_FlyBySoundRadius; } set { if (OnPropertyChanging("BulletEntityData." + nameof(FlyBySoundRadius), this, m_FlyBySoundRadius, value)) m_FlyBySoundRadius = value; } } // 0xE0 (224)
		
		protected float m_FlyBySoundSpeed = new float();
		[ContainerField(Name: "FlyBySoundSpeed", Offset: 228, NameHash: 4276155561, Flags: 49469), LayoutImmutable, Blittable]
		public float FlyBySoundSpeed { get { return m_FlyBySoundSpeed; } set { if (OnPropertyChanging("BulletEntityData." + nameof(FlyBySoundSpeed), this, m_FlyBySoundSpeed, value)) m_FlyBySoundSpeed = value; } } // 0xE4 (228)
		
		protected float m_FirstFrameTravelDistance = new float();
		[ContainerField(Name: "FirstFrameTravelDistance", Offset: 232, NameHash: 3753755161, Flags: 49469), LayoutImmutable, Blittable]
		public float FirstFrameTravelDistance { get { return m_FirstFrameTravelDistance; } set { if (OnPropertyChanging("BulletEntityData." + nameof(FirstFrameTravelDistance), this, m_FirstFrameTravelDistance, value)) m_FirstFrameTravelDistance = value; } } // 0xE8 (232)
		
		protected float m_DistributeDamageOverTime = new float();
		[ContainerField(Name: "DistributeDamageOverTime", Offset: 236, NameHash: 3294703682, Flags: 49469), LayoutImmutable, Blittable]
		public float DistributeDamageOverTime { get { return m_DistributeDamageOverTime; } set { if (OnPropertyChanging("BulletEntityData." + nameof(DistributeDamageOverTime), this, m_DistributeDamageOverTime, value)) m_DistributeDamageOverTime = value; } } // 0xEC (236)
		
		protected float m_StartDamage = new float();
		[ContainerField(Name: "StartDamage", Offset: 240, NameHash: 4249391310, Flags: 49469), LayoutImmutable, Blittable]
		public float StartDamage { get { return m_StartDamage; } set { if (OnPropertyChanging("BulletEntityData." + nameof(StartDamage), this, m_StartDamage, value)) m_StartDamage = value; } } // 0xF0 (240)
		
		protected float m_EndDamage = new float();
		[ContainerField(Name: "EndDamage", Offset: 244, NameHash: 3080388609, Flags: 49469), LayoutImmutable, Blittable]
		public float EndDamage { get { return m_EndDamage; } set { if (OnPropertyChanging("BulletEntityData." + nameof(EndDamage), this, m_EndDamage, value)) m_EndDamage = value; } } // 0xF4 (244)
		
		protected float m_DamageFalloffStartDistance = new float();
		[ContainerField(Name: "DamageFalloffStartDistance", Offset: 248, NameHash: 170301445, Flags: 49469), LayoutImmutable, Blittable]
		public float DamageFalloffStartDistance { get { return m_DamageFalloffStartDistance; } set { if (OnPropertyChanging("BulletEntityData." + nameof(DamageFalloffStartDistance), this, m_DamageFalloffStartDistance, value)) m_DamageFalloffStartDistance = value; } } // 0xF8 (248)
		
		protected float m_DamageFalloffEndDistance = new float();
		[ContainerField(Name: "DamageFalloffEndDistance", Offset: 252, NameHash: 2644592906, Flags: 49469), LayoutImmutable, Blittable]
		public float DamageFalloffEndDistance { get { return m_DamageFalloffEndDistance; } set { if (OnPropertyChanging("BulletEntityData." + nameof(DamageFalloffEndDistance), this, m_DamageFalloffEndDistance, value)) m_DamageFalloffEndDistance = value; } } // 0xFC (252)
		
		protected float m_TimeToArmExplosion = new float();
		[ContainerField(Name: "TimeToArmExplosion", Offset: 256, NameHash: 3533655904, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeToArmExplosion { get { return m_TimeToArmExplosion; } set { if (OnPropertyChanging("BulletEntityData." + nameof(TimeToArmExplosion), this, m_TimeToArmExplosion, value)) m_TimeToArmExplosion = value; } } // 0x100 (256)
		
		protected bool m_HasVehicleDetonation = new bool();
		[ContainerField(Name: "HasVehicleDetonation", Offset: 260, NameHash: 2164993390, Flags: 49325), LayoutImmutable, Blittable]
		public bool HasVehicleDetonation { get { return m_HasVehicleDetonation; } set { if (OnPropertyChanging("BulletEntityData." + nameof(HasVehicleDetonation), this, m_HasVehicleDetonation, value)) m_HasVehicleDetonation = value; } } // 0x104 (260)
		
		protected bool m_InstantHit = new bool();
		[ContainerField(Name: "InstantHit", Offset: 261, NameHash: 3819550411, Flags: 49325), LayoutImmutable, Blittable]
		public bool InstantHit { get { return m_InstantHit; } set { if (OnPropertyChanging("BulletEntityData." + nameof(InstantHit), this, m_InstantHit, value)) m_InstantHit = value; } } // 0x105 (261)
		
		protected bool m_StopTrailEffectOnUnspawn = new bool();
		[ContainerField(Name: "StopTrailEffectOnUnspawn", Offset: 262, NameHash: 2737808201, Flags: 49325), LayoutImmutable, Blittable]
		public bool StopTrailEffectOnUnspawn { get { return m_StopTrailEffectOnUnspawn; } set { if (OnPropertyChanging("BulletEntityData." + nameof(StopTrailEffectOnUnspawn), this, m_StopTrailEffectOnUnspawn, value)) m_StopTrailEffectOnUnspawn = value; } } // 0x106 (262)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2176368840:
					Stamina = (float) p_Value;
					break;

				case 3743063886:
					FlyBySound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 123118469:
					DudExplosion = (CtrRef<ExplosionEntityData>) p_Value;
					break;

				case 3295092963:
					Gravity = (float) p_Value;
					break;

				case 59311612:
					ImpactImpulse = (float) p_Value;
					break;

				case 246395272:
					DetonationTimeVariation = (float) p_Value;
					break;

				case 1470001196:
					VehicleDetonationRadius = (float) p_Value;
					break;

				case 4100261205:
					VehicleDetonationActivationDelay = (float) p_Value;
					break;

				case 3728826774:
					FlyBySoundRadius = (float) p_Value;
					break;

				case 4276155561:
					FlyBySoundSpeed = (float) p_Value;
					break;

				case 3753755161:
					FirstFrameTravelDistance = (float) p_Value;
					break;

				case 3294703682:
					DistributeDamageOverTime = (float) p_Value;
					break;

				case 4249391310:
					StartDamage = (float) p_Value;
					break;

				case 3080388609:
					EndDamage = (float) p_Value;
					break;

				case 170301445:
					DamageFalloffStartDistance = (float) p_Value;
					break;

				case 2644592906:
					DamageFalloffEndDistance = (float) p_Value;
					break;

				case 3533655904:
					TimeToArmExplosion = (float) p_Value;
					break;

				case 2164993390:
					HasVehicleDetonation = (bool) p_Value;
					break;

				case 3819550411:
					InstantHit = (bool) p_Value;
					break;

				case 2737808201:
					StopTrailEffectOnUnspawn = (bool) p_Value;
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
				case 2176368840:
					return Stamina;

				case 3743063886:
					return FlyBySound;

				case 123118469:
					return DudExplosion;

				case 3295092963:
					return Gravity;

				case 59311612:
					return ImpactImpulse;

				case 246395272:
					return DetonationTimeVariation;

				case 1470001196:
					return VehicleDetonationRadius;

				case 4100261205:
					return VehicleDetonationActivationDelay;

				case 3728826774:
					return FlyBySoundRadius;

				case 4276155561:
					return FlyBySoundSpeed;

				case 3753755161:
					return FirstFrameTravelDistance;

				case 3294703682:
					return DistributeDamageOverTime;

				case 4249391310:
					return StartDamage;

				case 3080388609:
					return EndDamage;

				case 170301445:
					return DamageFalloffStartDistance;

				case 2644592906:
					return DamageFalloffEndDistance;

				case 3533655904:
					return TimeToArmExplosion;

				case 2164993390:
					return HasVehicleDetonation;

				case 3819550411:
					return InstantHit;

				case 2737808201:
					return StopTrailEffectOnUnspawn;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2176368840:
					return typeof(BulletEntityData).GetProperty(nameof(Stamina));

				case 3743063886:
					return typeof(BulletEntityData).GetProperty(nameof(FlyBySound));

				case 123118469:
					return typeof(BulletEntityData).GetProperty(nameof(DudExplosion));

				case 3295092963:
					return typeof(BulletEntityData).GetProperty(nameof(Gravity));

				case 59311612:
					return typeof(BulletEntityData).GetProperty(nameof(ImpactImpulse));

				case 246395272:
					return typeof(BulletEntityData).GetProperty(nameof(DetonationTimeVariation));

				case 1470001196:
					return typeof(BulletEntityData).GetProperty(nameof(VehicleDetonationRadius));

				case 4100261205:
					return typeof(BulletEntityData).GetProperty(nameof(VehicleDetonationActivationDelay));

				case 3728826774:
					return typeof(BulletEntityData).GetProperty(nameof(FlyBySoundRadius));

				case 4276155561:
					return typeof(BulletEntityData).GetProperty(nameof(FlyBySoundSpeed));

				case 3753755161:
					return typeof(BulletEntityData).GetProperty(nameof(FirstFrameTravelDistance));

				case 3294703682:
					return typeof(BulletEntityData).GetProperty(nameof(DistributeDamageOverTime));

				case 4249391310:
					return typeof(BulletEntityData).GetProperty(nameof(StartDamage));

				case 3080388609:
					return typeof(BulletEntityData).GetProperty(nameof(EndDamage));

				case 170301445:
					return typeof(BulletEntityData).GetProperty(nameof(DamageFalloffStartDistance));

				case 2644592906:
					return typeof(BulletEntityData).GetProperty(nameof(DamageFalloffEndDistance));

				case 3533655904:
					return typeof(BulletEntityData).GetProperty(nameof(TimeToArmExplosion));

				case 2164993390:
					return typeof(BulletEntityData).GetProperty(nameof(HasVehicleDetonation));

				case 3819550411:
					return typeof(BulletEntityData).GetProperty(nameof(InstantHit));

				case 2737808201:
					return typeof(BulletEntityData).GetProperty(nameof(StopTrailEffectOnUnspawn));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
