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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 272)]
	public partial class BulletEntityData :
		MeshProjectileEntityData
	{
		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _Stamina;

		[ObservableProperty]
		[property: ContainerField(196), JsonProperty(Order = 196)]
		private CtrRef<SoundAsset> _FlyBySound = new();

		[ObservableProperty]
		[property: ContainerField(200), JsonProperty(Order = 200)]
		private CtrRef<ExplosionEntityData> _DudExplosion = new();

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private float _Gravity;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _ImpactImpulse;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _DetonationTimeVariation;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _VehicleDetonationRadius;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _VehicleDetonationActivationDelay;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private float _FlyBySoundRadius;

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private float _FlyBySoundSpeed;

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private float _FirstFrameTravelDistance;

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private float _DistributeDamageOverTime;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private float _StartDamage;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private float _EndDamage;

		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private float _DamageFalloffStartDistance;

		[ObservableProperty]
		[property: ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		private float _DamageFalloffEndDistance;

		[ObservableProperty]
		[property: ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private float _TimeToArmExplosion;

		[ObservableProperty]
		[property: ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		private bool _HasVehicleDetonation;

		[ObservableProperty]
		[property: ContainerField(261), LayoutImmutable, Blittable, JsonProperty(Order = 261)]
		private bool _InstantHit;

		[ObservableProperty]
		[property: ContainerField(262), LayoutImmutable, Blittable, JsonProperty(Order = 262)]
		private bool _StopTrailEffectOnUnspawn;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Stamina);
			p_Writer.Write(p_EbxWriter.WriteImport(FlyBySound));
			p_Writer.Write(p_EbxWriter.WriteImport(DudExplosion));
			p_Writer.Write(Gravity);
			p_Writer.Write(ImpactImpulse);
			p_Writer.Write(DetonationTimeVariation);
			p_Writer.Write(VehicleDetonationRadius);
			p_Writer.Write(VehicleDetonationActivationDelay);
			p_Writer.Write(FlyBySoundRadius);
			p_Writer.Write(FlyBySoundSpeed);
			p_Writer.Write(FirstFrameTravelDistance);
			p_Writer.Write(DistributeDamageOverTime);
			p_Writer.Write(StartDamage);
			p_Writer.Write(EndDamage);
			p_Writer.Write(DamageFalloffStartDistance);
			p_Writer.Write(DamageFalloffEndDistance);
			p_Writer.Write(TimeToArmExplosion);
			p_Writer.Write(HasVehicleDetonation);
			p_Writer.Write(InstantHit);
			p_Writer.Write(StopTrailEffectOnUnspawn);
			p_Writer.WriteNullBytes(9);
		}
	}
}
