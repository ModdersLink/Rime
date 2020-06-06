///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SoldierEntityData : 
		CharacterEntityData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 FLIRKeyColor { get; set; } = new Vec3(); // 0xA0 (160)
		
		[ContainerField(176)]
		public CtrRef<MaterialContainerPair> HeadMaterialPair { get; set; } = new CtrRef<MaterialContainerPair>(); // 0xB0 (176)
		
		[ContainerField(180)]
		public RefArray<BoneFakePhysicsData> BoneFakePhysics { get; set; } = new RefArray<BoneFakePhysicsData>(); // 0xB4 (180)
		
		[ContainerField(184)]
		public CtrRef<SoldierAutoAimData> AutoAim { get; set; } = new CtrRef<SoldierAutoAimData>(); // 0xB8 (184)
		
		[ContainerField(188)]
		public CtrRef<SoldierAimingConstraintsData> AimingConstraints { get; set; } = new CtrRef<SoldierAimingConstraintsData>(); // 0xBC (188)
		
		[ContainerField(192)]
		public CtrRef<SoldierHeadCollisionData> HeadCollision { get; set; } = new CtrRef<SoldierHeadCollisionData>(); // 0xC0 (192)
		
		[ContainerField(196)]
		public CtrRef<CharacterPhysicsData> CharacterPhysics { get; set; } = new CtrRef<CharacterPhysicsData>(); // 0xC4 (196)
		
		[ContainerField(200)]
		public CtrRef<MaterialContainerPair> FootMaterialPair { get; set; } = new CtrRef<MaterialContainerPair>(); // 0xC8 (200)
		
		[ContainerField(204)]
		public CtrRef<SoldierSprintSettingsData> SprintSettings { get; set; } = new CtrRef<SoldierSprintSettingsData>(); // 0xCC (204)
		
		[ContainerField(208)]
		public List<SoldierMeshData> Meshes1p { get; set; } = new List<SoldierMeshData>(); // 0xD0 (208)
		
		[ContainerField(212)]
		public List<SoldierMeshData> Meshes3p { get; set; } = new List<SoldierMeshData>(); // 0xD4 (212)
		
		[ContainerField(216)]
		public List<HidableSoldierMeshWeaponPart> HidableMeshParts { get; set; } = new List<HidableSoldierMeshWeaponPart>(); // 0xD8 (216)
		
		[ContainerField(220)]
		public CtrRef<SoldierSoundData> Sound { get; set; } = new CtrRef<SoldierSoundData>(); // 0xDC (220)
		
		[ContainerField(224)]
		public CtrRef<StreamGroupData> StreamGroup1p { get; set; } = new CtrRef<StreamGroupData>(); // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public float ImpulseReactionTime { get; set; } // 0xE4 (228)
		
		[ContainerField(232)]
		public CtrRef<SoldierHealthModuleData> HealthModule { get; set; } = new CtrRef<SoldierHealthModuleData>(); // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public float MaxHealth { get; set; } // 0xEC (236)
		
		[ContainerField(240)]
		public CtrRef<CollisionData> CollisionInfo { get; set; } = new CtrRef<CollisionData>(); // 0xF0 (240)
		
		[ContainerField(244)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new CtrRef<EntityVoiceOverInfo>(); // 0xF4 (244)
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public float FLIRValue { get; set; } // 0xF8 (248)
		
		[ContainerField(252)]
		public RefArray<BreathControlData> BreathControl { get; set; } = new RefArray<BreathControlData>(); // 0xFC (252)
		
		[ContainerField(256), LayoutImmutable, Blittable]
		public float ExplosionDamageModifier { get; set; } // 0x100 (256)
		
		[ContainerField(260)]
		public RefArray<UIPartData> UIParts { get; set; } = new RefArray<UIPartData>(); // 0x104 (260)
		
		[ContainerField(264), LayoutImmutable, Blittable]
		public float RegenerationDelayModifier { get; set; } // 0x108 (264)
		
		[ContainerField(268), LayoutImmutable, Blittable]
		public bool FreeSpaceCheck { get; set; } // 0x10C (268)
		
		[ContainerField(269), LayoutImmutable, Blittable]
		public bool ProximityCheck { get; set; } // 0x10D (269)
		
		[ContainerField(270), LayoutImmutable, Blittable]
		public bool EnableGroundmapLighting { get; set; } // 0x10E (270)
		
		[ContainerField(271), LayoutImmutable, Blittable]
		public bool ShowWeaponWhenDead { get; set; } // 0x10F (271)
		
		[ContainerField(272), LayoutImmutable, Blittable]
		public bool LowerGunOnOwnTeam { get; set; } // 0x110 (272)
		
		[ContainerField(273), LayoutImmutable, Blittable]
		public bool UseSpineXRotation { get; set; } // 0x111 (273)
		
		[ContainerField(274), LayoutImmutable, Blittable]
		public bool CollisionEnabled { get; set; } // 0x112 (274)
		
		[ContainerField(275), LayoutImmutable, Blittable]
		public bool PhysicsControlled { get; set; } // 0x113 (275)
		
		[ContainerField(276), LayoutImmutable, Blittable]
		public bool IsPushable { get; set; } // 0x114 (276)
		
		[ContainerField(277), LayoutImmutable, Blittable]
		public bool HumanPlayerControlled { get; set; } // 0x115 (277)
		
		[ContainerField(278), LayoutImmutable, Blittable]
		public bool InteractiveManDownAllowed { get; set; } // 0x116 (278)
		
		[ContainerField(279), LayoutImmutable, Blittable]
		public bool ShowNametag { get; set; } // 0x117 (279)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 844334526:
					FLIRKeyColor = (Vec3) p_Value;
					break;

				case 1872530092:
					HeadMaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 2227758113:
					BoneFakePhysics = (RefArray<BoneFakePhysicsData>) p_Value;
					break;

				case 888098479:
					AutoAim = (CtrRef<SoldierAutoAimData>) p_Value;
					break;

				case 1523178198:
					AimingConstraints = (CtrRef<SoldierAimingConstraintsData>) p_Value;
					break;

				case 964117651:
					HeadCollision = (CtrRef<SoldierHeadCollisionData>) p_Value;
					break;

				case 4032988407:
					CharacterPhysics = (CtrRef<CharacterPhysicsData>) p_Value;
					break;

				case 3867460534:
					FootMaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 1580077506:
					SprintSettings = (CtrRef<SoldierSprintSettingsData>) p_Value;
					break;

				case 1821360225:
					Meshes1p = (List<SoldierMeshData>) p_Value;
					break;

				case 1821360163:
					Meshes3p = (List<SoldierMeshData>) p_Value;
					break;

				case 4062781021:
					HidableMeshParts = (List<HidableSoldierMeshWeaponPart>) p_Value;
					break;

				case 231353798:
					Sound = (CtrRef<SoldierSoundData>) p_Value;
					break;

				case 3004812039:
					StreamGroup1p = (CtrRef<StreamGroupData>) p_Value;
					break;

				case 712696098:
					ImpulseReactionTime = (float) p_Value;
					break;

				case 2786810819:
					HealthModule = (CtrRef<SoldierHealthModuleData>) p_Value;
					break;

				case 1153188365:
					MaxHealth = (float) p_Value;
					break;

				case 2885020053:
					CollisionInfo = (CtrRef<CollisionData>) p_Value;
					break;

				case 1260547539:
					VoiceOverInfo = (CtrRef<EntityVoiceOverInfo>) p_Value;
					break;

				case 3325471103:
					FLIRValue = (float) p_Value;
					break;

				case 2325792682:
					BreathControl = (RefArray<BreathControlData>) p_Value;
					break;

				case 874268012:
					ExplosionDamageModifier = (float) p_Value;
					break;

				case 187481405:
					UIParts = (RefArray<UIPartData>) p_Value;
					break;

				case 2924338326:
					RegenerationDelayModifier = (float) p_Value;
					break;

				case 1181198163:
					FreeSpaceCheck = (bool) p_Value;
					break;

				case 4271686838:
					ProximityCheck = (bool) p_Value;
					break;

				case 1278245411:
					EnableGroundmapLighting = (bool) p_Value;
					break;

				case 3915982996:
					ShowWeaponWhenDead = (bool) p_Value;
					break;

				case 3271387216:
					LowerGunOnOwnTeam = (bool) p_Value;
					break;

				case 3042773355:
					UseSpineXRotation = (bool) p_Value;
					break;

				case 134809118:
					CollisionEnabled = (bool) p_Value;
					break;

				case 3834786116:
					PhysicsControlled = (bool) p_Value;
					break;

				case 3202802347:
					IsPushable = (bool) p_Value;
					break;

				case 3591714019:
					HumanPlayerControlled = (bool) p_Value;
					break;

				case 283015237:
					InteractiveManDownAllowed = (bool) p_Value;
					break;

				case 4065911763:
					ShowNametag = (bool) p_Value;
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
				case 844334526:
					return FLIRKeyColor;

				case 1872530092:
					return HeadMaterialPair;

				case 2227758113:
					return BoneFakePhysics;

				case 888098479:
					return AutoAim;

				case 1523178198:
					return AimingConstraints;

				case 964117651:
					return HeadCollision;

				case 4032988407:
					return CharacterPhysics;

				case 3867460534:
					return FootMaterialPair;

				case 1580077506:
					return SprintSettings;

				case 1821360225:
					return Meshes1p;

				case 1821360163:
					return Meshes3p;

				case 4062781021:
					return HidableMeshParts;

				case 231353798:
					return Sound;

				case 3004812039:
					return StreamGroup1p;

				case 712696098:
					return ImpulseReactionTime;

				case 2786810819:
					return HealthModule;

				case 1153188365:
					return MaxHealth;

				case 2885020053:
					return CollisionInfo;

				case 1260547539:
					return VoiceOverInfo;

				case 3325471103:
					return FLIRValue;

				case 2325792682:
					return BreathControl;

				case 874268012:
					return ExplosionDamageModifier;

				case 187481405:
					return UIParts;

				case 2924338326:
					return RegenerationDelayModifier;

				case 1181198163:
					return FreeSpaceCheck;

				case 4271686838:
					return ProximityCheck;

				case 1278245411:
					return EnableGroundmapLighting;

				case 3915982996:
					return ShowWeaponWhenDead;

				case 3271387216:
					return LowerGunOnOwnTeam;

				case 3042773355:
					return UseSpineXRotation;

				case 134809118:
					return CollisionEnabled;

				case 3834786116:
					return PhysicsControlled;

				case 3202802347:
					return IsPushable;

				case 3591714019:
					return HumanPlayerControlled;

				case 283015237:
					return InteractiveManDownAllowed;

				case 4065911763:
					return ShowNametag;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 844334526:
					return typeof(SoldierEntityData).GetProperty(nameof(FLIRKeyColor));

				case 1872530092:
					return typeof(SoldierEntityData).GetProperty(nameof(HeadMaterialPair));

				case 2227758113:
					return typeof(SoldierEntityData).GetProperty(nameof(BoneFakePhysics));

				case 888098479:
					return typeof(SoldierEntityData).GetProperty(nameof(AutoAim));

				case 1523178198:
					return typeof(SoldierEntityData).GetProperty(nameof(AimingConstraints));

				case 964117651:
					return typeof(SoldierEntityData).GetProperty(nameof(HeadCollision));

				case 4032988407:
					return typeof(SoldierEntityData).GetProperty(nameof(CharacterPhysics));

				case 3867460534:
					return typeof(SoldierEntityData).GetProperty(nameof(FootMaterialPair));

				case 1580077506:
					return typeof(SoldierEntityData).GetProperty(nameof(SprintSettings));

				case 1821360225:
					return typeof(SoldierEntityData).GetProperty(nameof(Meshes1p));

				case 1821360163:
					return typeof(SoldierEntityData).GetProperty(nameof(Meshes3p));

				case 4062781021:
					return typeof(SoldierEntityData).GetProperty(nameof(HidableMeshParts));

				case 231353798:
					return typeof(SoldierEntityData).GetProperty(nameof(Sound));

				case 3004812039:
					return typeof(SoldierEntityData).GetProperty(nameof(StreamGroup1p));

				case 712696098:
					return typeof(SoldierEntityData).GetProperty(nameof(ImpulseReactionTime));

				case 2786810819:
					return typeof(SoldierEntityData).GetProperty(nameof(HealthModule));

				case 1153188365:
					return typeof(SoldierEntityData).GetProperty(nameof(MaxHealth));

				case 2885020053:
					return typeof(SoldierEntityData).GetProperty(nameof(CollisionInfo));

				case 1260547539:
					return typeof(SoldierEntityData).GetProperty(nameof(VoiceOverInfo));

				case 3325471103:
					return typeof(SoldierEntityData).GetProperty(nameof(FLIRValue));

				case 2325792682:
					return typeof(SoldierEntityData).GetProperty(nameof(BreathControl));

				case 874268012:
					return typeof(SoldierEntityData).GetProperty(nameof(ExplosionDamageModifier));

				case 187481405:
					return typeof(SoldierEntityData).GetProperty(nameof(UIParts));

				case 2924338326:
					return typeof(SoldierEntityData).GetProperty(nameof(RegenerationDelayModifier));

				case 1181198163:
					return typeof(SoldierEntityData).GetProperty(nameof(FreeSpaceCheck));

				case 4271686838:
					return typeof(SoldierEntityData).GetProperty(nameof(ProximityCheck));

				case 1278245411:
					return typeof(SoldierEntityData).GetProperty(nameof(EnableGroundmapLighting));

				case 3915982996:
					return typeof(SoldierEntityData).GetProperty(nameof(ShowWeaponWhenDead));

				case 3271387216:
					return typeof(SoldierEntityData).GetProperty(nameof(LowerGunOnOwnTeam));

				case 3042773355:
					return typeof(SoldierEntityData).GetProperty(nameof(UseSpineXRotation));

				case 134809118:
					return typeof(SoldierEntityData).GetProperty(nameof(CollisionEnabled));

				case 3834786116:
					return typeof(SoldierEntityData).GetProperty(nameof(PhysicsControlled));

				case 3202802347:
					return typeof(SoldierEntityData).GetProperty(nameof(IsPushable));

				case 3591714019:
					return typeof(SoldierEntityData).GetProperty(nameof(HumanPlayerControlled));

				case 283015237:
					return typeof(SoldierEntityData).GetProperty(nameof(InteractiveManDownAllowed));

				case 4065911763:
					return typeof(SoldierEntityData).GetProperty(nameof(ShowNametag));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
