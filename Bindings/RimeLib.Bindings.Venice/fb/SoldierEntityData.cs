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
	[ContainerType(16, 288)]
	public class SoldierEntityData : 
		CharacterEntityData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 FLIRKeyColor { get; set; } = new();

		[ContainerField(176)]
		public CtrRef<MaterialContainerPair> HeadMaterialPair { get; set; } = new();

		[ContainerField(180)]
		public RefArray<BoneFakePhysicsData> BoneFakePhysics { get; set; } = new();

		[ContainerField(184)]
		public CtrRef<SoldierAutoAimData> AutoAim { get; set; } = new();

		[ContainerField(188)]
		public CtrRef<SoldierAimingConstraintsData> AimingConstraints { get; set; } = new();

		[ContainerField(192)]
		public CtrRef<SoldierHeadCollisionData> HeadCollision { get; set; } = new();

		[ContainerField(196)]
		public CtrRef<CharacterPhysicsData> CharacterPhysics { get; set; } = new();

		[ContainerField(200)]
		public CtrRef<MaterialContainerPair> FootMaterialPair { get; set; } = new();

		[ContainerField(204)]
		public CtrRef<SoldierSprintSettingsData> SprintSettings { get; set; } = new();

		[ContainerField(208)]
		public List<SoldierMeshData> Meshes1p { get; set; } = new();

		[ContainerField(212)]
		public List<SoldierMeshData> Meshes3p { get; set; } = new();

		[ContainerField(216)]
		public List<HidableSoldierMeshWeaponPart> HidableMeshParts { get; set; } = new();

		[ContainerField(220)]
		public CtrRef<SoldierSoundData> Sound { get; set; } = new();

		[ContainerField(224)]
		public CtrRef<StreamGroupData> StreamGroup1p { get; set; } = new();

		[ContainerField(228), LayoutImmutable, Blittable]
		public float ImpulseReactionTime { get; set; }

		[ContainerField(232)]
		public CtrRef<SoldierHealthModuleData> HealthModule { get; set; } = new();

		[ContainerField(236), LayoutImmutable, Blittable]
		public float MaxHealth { get; set; }

		[ContainerField(240)]
		public CtrRef<CollisionData> CollisionInfo { get; set; } = new();

		[ContainerField(244)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new();

		[ContainerField(248), LayoutImmutable, Blittable]
		public float FLIRValue { get; set; }

		[ContainerField(252)]
		public RefArray<BreathControlData> BreathControl { get; set; } = new();

		[ContainerField(256), LayoutImmutable, Blittable]
		public float ExplosionDamageModifier { get; set; }

		[ContainerField(260)]
		public RefArray<UIPartData> UIParts { get; set; } = new();

		[ContainerField(264), LayoutImmutable, Blittable]
		public float RegenerationDelayModifier { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable]
		public bool FreeSpaceCheck { get; set; }

		[ContainerField(269), LayoutImmutable, Blittable]
		public bool ProximityCheck { get; set; }

		[ContainerField(270), LayoutImmutable, Blittable]
		public bool EnableGroundmapLighting { get; set; }

		[ContainerField(271), LayoutImmutable, Blittable]
		public bool ShowWeaponWhenDead { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable]
		public bool LowerGunOnOwnTeam { get; set; }

		[ContainerField(273), LayoutImmutable, Blittable]
		public bool UseSpineXRotation { get; set; }

		[ContainerField(274), LayoutImmutable, Blittable]
		public bool CollisionEnabled { get; set; }

		[ContainerField(275), LayoutImmutable, Blittable]
		public bool PhysicsControlled { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable]
		public bool IsPushable { get; set; }

		[ContainerField(277), LayoutImmutable, Blittable]
		public bool HumanPlayerControlled { get; set; }

		[ContainerField(278), LayoutImmutable, Blittable]
		public bool InteractiveManDownAllowed { get; set; }

		[ContainerField(279), LayoutImmutable, Blittable]
		public bool ShowNametag { get; set; }

	}
}
