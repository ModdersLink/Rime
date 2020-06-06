///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class BulletEntityData : 
		MeshProjectileEntityData
	{
		[ContainerField(192), LayoutImmutable, Blittable]
		public float Stamina { get; set; } // 0xC0 (192)
		
		[ContainerField(196)]
		public CtrRef<SoundAsset> FlyBySound { get; set; } = new CtrRef<SoundAsset>(); // 0xC4 (196)
		
		[ContainerField(200)]
		public CtrRef<ExplosionEntityData> DudExplosion { get; set; } = new CtrRef<ExplosionEntityData>(); // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float Gravity { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float ImpactImpulse { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float DetonationTimeVariation { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float VehicleDetonationRadius { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float VehicleDetonationActivationDelay { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public float FlyBySoundRadius { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public float FlyBySoundSpeed { get; set; } // 0xE4 (228)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public float FirstFrameTravelDistance { get; set; } // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public float DistributeDamageOverTime { get; set; } // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public float StartDamage { get; set; } // 0xF0 (240)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public float EndDamage { get; set; } // 0xF4 (244)
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public float DamageFalloffStartDistance { get; set; } // 0xF8 (248)
		
		[ContainerField(252), LayoutImmutable, Blittable]
		public float DamageFalloffEndDistance { get; set; } // 0xFC (252)
		
		[ContainerField(256), LayoutImmutable, Blittable]
		public float TimeToArmExplosion { get; set; } // 0x100 (256)
		
		[ContainerField(260), LayoutImmutable, Blittable]
		public bool HasVehicleDetonation { get; set; } // 0x104 (260)
		
		[ContainerField(261), LayoutImmutable, Blittable]
		public bool InstantHit { get; set; } // 0x105 (261)
		
		[ContainerField(262), LayoutImmutable, Blittable]
		public bool StopTrailEffectOnUnspawn { get; set; } // 0x106 (262)
		
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
