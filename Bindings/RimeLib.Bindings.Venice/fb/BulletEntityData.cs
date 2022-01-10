///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 272)]
	public class BulletEntityData : 
		MeshProjectileEntityData
	{
		[ContainerField(192), LayoutImmutable, Blittable]
		public float Stamina { get; set; }

		[ContainerField(196)]
		public CtrRef<SoundAsset> FlyBySound { get; set; } = new();

		[ContainerField(200)]
		public CtrRef<ExplosionEntityData> DudExplosion { get; set; } = new();

		[ContainerField(204), LayoutImmutable, Blittable]
		public float Gravity { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public float ImpactImpulse { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public float DetonationTimeVariation { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public float VehicleDetonationRadius { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public float VehicleDetonationActivationDelay { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public float FlyBySoundRadius { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable]
		public float FlyBySoundSpeed { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable]
		public float FirstFrameTravelDistance { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public float DistributeDamageOverTime { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public float StartDamage { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public float EndDamage { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable]
		public float DamageFalloffStartDistance { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable]
		public float DamageFalloffEndDistance { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable]
		public float TimeToArmExplosion { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable]
		public bool HasVehicleDetonation { get; set; }

		[ContainerField(261), LayoutImmutable, Blittable]
		public bool InstantHit { get; set; }

		[ContainerField(262), LayoutImmutable, Blittable]
		public bool StopTrailEffectOnUnspawn { get; set; }

		public static void Deserialize(BulletEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Stamina = p_Reader.ReadSingle();
			p_Instance.FlyBySound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DudExplosion.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Gravity = p_Reader.ReadSingle();
			p_Instance.ImpactImpulse = p_Reader.ReadSingle();
			p_Instance.DetonationTimeVariation = p_Reader.ReadSingle();
			p_Instance.VehicleDetonationRadius = p_Reader.ReadSingle();
			p_Instance.VehicleDetonationActivationDelay = p_Reader.ReadSingle();
			p_Instance.FlyBySoundRadius = p_Reader.ReadSingle();
			p_Instance.FlyBySoundSpeed = p_Reader.ReadSingle();
			p_Instance.FirstFrameTravelDistance = p_Reader.ReadSingle();
			p_Instance.DistributeDamageOverTime = p_Reader.ReadSingle();
			p_Instance.StartDamage = p_Reader.ReadSingle();
			p_Instance.EndDamage = p_Reader.ReadSingle();
			p_Instance.DamageFalloffStartDistance = p_Reader.ReadSingle();
			p_Instance.DamageFalloffEndDistance = p_Reader.ReadSingle();
			p_Instance.TimeToArmExplosion = p_Reader.ReadSingle();
			p_Instance.HasVehicleDetonation = p_Reader.ReadBool();
			p_Instance.InstantHit = p_Reader.ReadBool();
			p_Instance.StopTrailEffectOnUnspawn = p_Reader.ReadBool();
			p_Reader.Seek(9, SeekOrigin.Current);
		}

	}
}
