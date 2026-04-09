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
	[ContainerType(16, 320)]
	public partial class MissileEntityData :
		MeshProjectileEntityData
	{
		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _Gravity;

		[ObservableProperty]
		[property: ContainerField(196), JsonProperty(Order = 196)]
		private CtrRef<EffectBlueprint> _EngineEffect = new();

		[ObservableProperty]
		[property: ContainerField(200), JsonProperty(Order = 200)]
		private CtrRef<ExplosionEntityData> _DudExplosion = new();

		[ObservableProperty]
		[property: ContainerField(204), JsonProperty(Order = 204)]
		private CtrRef<SoundAsset> _FlyBySound = new();

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _EngineStrength;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _MaxSpeed;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _EngineTimeToIgnition;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _EngineTimeToLive;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private float _TimeToActivateGuidingSystem;

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private float _TimeToArm;

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private float _MaxTurnAngle;

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private float _Drag;

		[ObservableProperty]
		[property: ContainerField(240), JsonProperty(Order = 240)]
		private NearTargetDetonationData _NearTargetDetonation = new();

		[ObservableProperty]
		[property: ContainerField(256), JsonProperty(Order = 256)]
		private TeamId _DefaultTeam = new();

		[ObservableProperty]
		[property: ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		private float _FlyBySoundRadius;

		[ObservableProperty]
		[property: ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		private float _FlyBySoundSpeed;

		[ObservableProperty]
		[property: ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		private float _ImpactImpulse;

		[ObservableProperty]
		[property: ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		private float _Damage;

		[ObservableProperty]
		[property: ContainerField(276), JsonProperty(Order = 276)]
		private MissileUnguidedData _UnguidedData = new();

		[ObservableProperty]
		[property: ContainerField(296), JsonProperty(Order = 296)]
		private WarnTarget _WarnTarget = new();

		[ObservableProperty]
		[property: ContainerField(300), JsonProperty(Order = 300)]
		private MissileLockableInfoData _LockableInfo = new();

		[ObservableProperty]
		[property: ContainerField(308), JsonProperty(Order = 308)]
		private CtrRef<LockingControllerData> _LockingController = new();

		[ObservableProperty]
		[property: ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		private bool _WarnOnPointingMissile;

		[ObservableProperty]
		[property: ContainerField(313), LayoutImmutable, Blittable, JsonProperty(Order = 313)]
		private bool _ApplyGravityWhenGuided;

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
