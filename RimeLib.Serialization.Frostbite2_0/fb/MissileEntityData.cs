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

namespace fb
{
	[ContainerType(16, 320)]
	public class MissileEntityData :
		MeshProjectileEntityData
	{
		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float Gravity { get; set; }

		[ContainerField(196), JsonProperty(Order = 196)]
		public CtrRef<EffectBlueprint> EngineEffect { get; set; } = new();

		[ContainerField(200), JsonProperty(Order = 200)]
		public CtrRef<ExplosionEntityData> DudExplosion { get; set; } = new();

		[ContainerField(204), JsonProperty(Order = 204)]
		public CtrRef<SoundAsset> FlyBySound { get; set; } = new();

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float EngineStrength { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public float MaxSpeed { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float EngineTimeToIgnition { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public float EngineTimeToLive { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public float TimeToActivateGuidingSystem { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public float TimeToArm { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public float MaxTurnAngle { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public float Drag { get; set; }

		[ContainerField(240), JsonProperty(Order = 240)]
		public NearTargetDetonationData NearTargetDetonation { get; set; } = new();

		[ContainerField(256), JsonProperty(Order = 256)]
		public TeamId DefaultTeam { get; set; } = new();

		[ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		public float FlyBySoundRadius { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		public float FlyBySoundSpeed { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		public float ImpactImpulse { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		public float Damage { get; set; }

		[ContainerField(276), JsonProperty(Order = 276)]
		public MissileUnguidedData UnguidedData { get; set; } = new();

		[ContainerField(296), JsonProperty(Order = 296)]
		public WarnTarget WarnTarget { get; set; } = new();

		[ContainerField(300), JsonProperty(Order = 300)]
		public MissileLockableInfoData LockableInfo { get; set; } = new();

		[ContainerField(308), JsonProperty(Order = 308)]
		public CtrRef<LockingControllerData> LockingController { get; set; } = new();

		[ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		public bool WarnOnPointingMissile { get; set; }

		[ContainerField(313), LayoutImmutable, Blittable, JsonProperty(Order = 313)]
		public bool ApplyGravityWhenGuided { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Gravity);
			p_Writer.Write(p_EbxWriter.WriteImport(EngineEffect));
			p_Writer.Write(p_EbxWriter.WriteImport(DudExplosion));
			p_Writer.Write(p_EbxWriter.WriteImport(FlyBySound));
			p_Writer.Write(EngineStrength);
			p_Writer.Write(MaxSpeed);
			p_Writer.Write(EngineTimeToIgnition);
			p_Writer.Write(EngineTimeToLive);
			p_Writer.Write(TimeToActivateGuidingSystem);
			p_Writer.Write(TimeToArm);
			p_Writer.Write(MaxTurnAngle);
			p_Writer.Write(Drag);
			NearTargetDetonation.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) DefaultTeam);
			p_Writer.Write(FlyBySoundRadius);
			p_Writer.Write(FlyBySoundSpeed);
			p_Writer.Write(ImpactImpulse);
			p_Writer.Write(Damage);
			UnguidedData.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) WarnTarget);
			LockableInfo.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(LockingController));
			p_Writer.Write(WarnOnPointingMissile);
			p_Writer.Write(ApplyGravityWhenGuided);
			p_Writer.WriteNullBytes(6);
		}
	}
}
