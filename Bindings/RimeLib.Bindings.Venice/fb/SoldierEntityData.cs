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
	[ContainerType(16)]
	public class SoldierEntityData : 
		CharacterEntityData
	{
		protected Vec3 m_FLIRKeyColor = new Vec3();
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(844334526)]
		public Vec3 FLIRKeyColor { get { return m_FLIRKeyColor; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(FLIRKeyColor), this, m_FLIRKeyColor, value)) m_FLIRKeyColor = value; } } // 0xA0 (160)
		
		protected CtrRef<MaterialContainerPair> m_HeadMaterialPair = new CtrRef<MaterialContainerPair>();
		[ContainerField(176), ContainerFieldNameHash(1872530092)]
		public CtrRef<MaterialContainerPair> HeadMaterialPair { get { return m_HeadMaterialPair; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(HeadMaterialPair), this, m_HeadMaterialPair, value)) m_HeadMaterialPair = value; } } // 0xB0 (176)
		
		protected RefArray<BoneFakePhysicsData> m_BoneFakePhysics = new RefArray<BoneFakePhysicsData>();
		[ContainerField(180), ContainerFieldNameHash(2227758113)]
		public RefArray<BoneFakePhysicsData> BoneFakePhysics { get { return m_BoneFakePhysics; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(BoneFakePhysics), this, m_BoneFakePhysics, value)) m_BoneFakePhysics = value; } } // 0xB4 (180)
		
		protected CtrRef<SoldierAutoAimData> m_AutoAim = new CtrRef<SoldierAutoAimData>();
		[ContainerField(184), ContainerFieldNameHash(888098479)]
		public CtrRef<SoldierAutoAimData> AutoAim { get { return m_AutoAim; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(AutoAim), this, m_AutoAim, value)) m_AutoAim = value; } } // 0xB8 (184)
		
		protected CtrRef<SoldierAimingConstraintsData> m_AimingConstraints = new CtrRef<SoldierAimingConstraintsData>();
		[ContainerField(188), ContainerFieldNameHash(1523178198)]
		public CtrRef<SoldierAimingConstraintsData> AimingConstraints { get { return m_AimingConstraints; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(AimingConstraints), this, m_AimingConstraints, value)) m_AimingConstraints = value; } } // 0xBC (188)
		
		protected CtrRef<SoldierHeadCollisionData> m_HeadCollision = new CtrRef<SoldierHeadCollisionData>();
		[ContainerField(192), ContainerFieldNameHash(964117651)]
		public CtrRef<SoldierHeadCollisionData> HeadCollision { get { return m_HeadCollision; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(HeadCollision), this, m_HeadCollision, value)) m_HeadCollision = value; } } // 0xC0 (192)
		
		protected CtrRef<CharacterPhysicsData> m_CharacterPhysics = new CtrRef<CharacterPhysicsData>();
		[ContainerField(196), ContainerFieldNameHash(4032988407)]
		public CtrRef<CharacterPhysicsData> CharacterPhysics { get { return m_CharacterPhysics; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(CharacterPhysics), this, m_CharacterPhysics, value)) m_CharacterPhysics = value; } } // 0xC4 (196)
		
		protected CtrRef<MaterialContainerPair> m_FootMaterialPair = new CtrRef<MaterialContainerPair>();
		[ContainerField(200), ContainerFieldNameHash(3867460534)]
		public CtrRef<MaterialContainerPair> FootMaterialPair { get { return m_FootMaterialPair; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(FootMaterialPair), this, m_FootMaterialPair, value)) m_FootMaterialPair = value; } } // 0xC8 (200)
		
		protected CtrRef<SoldierSprintSettingsData> m_SprintSettings = new CtrRef<SoldierSprintSettingsData>();
		[ContainerField(204), ContainerFieldNameHash(1580077506)]
		public CtrRef<SoldierSprintSettingsData> SprintSettings { get { return m_SprintSettings; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(SprintSettings), this, m_SprintSettings, value)) m_SprintSettings = value; } } // 0xCC (204)
		
		protected List<SoldierMeshData> m_Meshes1p = new List<SoldierMeshData>();
		[ContainerField(208), ContainerFieldNameHash(1821360225)]
		public List<SoldierMeshData> Meshes1p { get { return m_Meshes1p; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(Meshes1p), this, m_Meshes1p, value)) m_Meshes1p = value; } } // 0xD0 (208)
		
		protected List<SoldierMeshData> m_Meshes3p = new List<SoldierMeshData>();
		[ContainerField(212), ContainerFieldNameHash(1821360163)]
		public List<SoldierMeshData> Meshes3p { get { return m_Meshes3p; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(Meshes3p), this, m_Meshes3p, value)) m_Meshes3p = value; } } // 0xD4 (212)
		
		protected List<HidableSoldierMeshWeaponPart> m_HidableMeshParts = new List<HidableSoldierMeshWeaponPart>();
		[ContainerField(216), ContainerFieldNameHash(4062781021)]
		public List<HidableSoldierMeshWeaponPart> HidableMeshParts { get { return m_HidableMeshParts; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(HidableMeshParts), this, m_HidableMeshParts, value)) m_HidableMeshParts = value; } } // 0xD8 (216)
		
		protected CtrRef<SoldierSoundData> m_Sound = new CtrRef<SoldierSoundData>();
		[ContainerField(220), ContainerFieldNameHash(231353798)]
		public CtrRef<SoldierSoundData> Sound { get { return m_Sound; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(Sound), this, m_Sound, value)) m_Sound = value; } } // 0xDC (220)
		
		protected CtrRef<StreamGroupData> m_StreamGroup1p = new CtrRef<StreamGroupData>();
		[ContainerField(224), ContainerFieldNameHash(3004812039)]
		public CtrRef<StreamGroupData> StreamGroup1p { get { return m_StreamGroup1p; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(StreamGroup1p), this, m_StreamGroup1p, value)) m_StreamGroup1p = value; } } // 0xE0 (224)
		
		protected float m_ImpulseReactionTime = new float();
		[ContainerField(228), LayoutImmutable, Blittable, ContainerFieldNameHash(712696098)]
		public float ImpulseReactionTime { get { return m_ImpulseReactionTime; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(ImpulseReactionTime), this, m_ImpulseReactionTime, value)) m_ImpulseReactionTime = value; } } // 0xE4 (228)
		
		protected CtrRef<SoldierHealthModuleData> m_HealthModule = new CtrRef<SoldierHealthModuleData>();
		[ContainerField(232), ContainerFieldNameHash(2786810819)]
		public CtrRef<SoldierHealthModuleData> HealthModule { get { return m_HealthModule; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(HealthModule), this, m_HealthModule, value)) m_HealthModule = value; } } // 0xE8 (232)
		
		protected float m_MaxHealth = new float();
		[ContainerField(236), LayoutImmutable, Blittable, ContainerFieldNameHash(1153188365)]
		public float MaxHealth { get { return m_MaxHealth; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(MaxHealth), this, m_MaxHealth, value)) m_MaxHealth = value; } } // 0xEC (236)
		
		protected CtrRef<CollisionData> m_CollisionInfo = new CtrRef<CollisionData>();
		[ContainerField(240), ContainerFieldNameHash(2885020053)]
		public CtrRef<CollisionData> CollisionInfo { get { return m_CollisionInfo; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(CollisionInfo), this, m_CollisionInfo, value)) m_CollisionInfo = value; } } // 0xF0 (240)
		
		protected CtrRef<EntityVoiceOverInfo> m_VoiceOverInfo = new CtrRef<EntityVoiceOverInfo>();
		[ContainerField(244), ContainerFieldNameHash(1260547539)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get { return m_VoiceOverInfo; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(VoiceOverInfo), this, m_VoiceOverInfo, value)) m_VoiceOverInfo = value; } } // 0xF4 (244)
		
		protected float m_FLIRValue = new float();
		[ContainerField(248), LayoutImmutable, Blittable, ContainerFieldNameHash(3325471103)]
		public float FLIRValue { get { return m_FLIRValue; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(FLIRValue), this, m_FLIRValue, value)) m_FLIRValue = value; } } // 0xF8 (248)
		
		protected RefArray<BreathControlData> m_BreathControl = new RefArray<BreathControlData>();
		[ContainerField(252), ContainerFieldNameHash(2325792682)]
		public RefArray<BreathControlData> BreathControl { get { return m_BreathControl; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(BreathControl), this, m_BreathControl, value)) m_BreathControl = value; } } // 0xFC (252)
		
		protected float m_ExplosionDamageModifier = new float();
		[ContainerField(256), LayoutImmutable, Blittable, ContainerFieldNameHash(874268012)]
		public float ExplosionDamageModifier { get { return m_ExplosionDamageModifier; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(ExplosionDamageModifier), this, m_ExplosionDamageModifier, value)) m_ExplosionDamageModifier = value; } } // 0x100 (256)
		
		protected RefArray<UIPartData> m_UIParts = new RefArray<UIPartData>();
		[ContainerField(260), ContainerFieldNameHash(187481405)]
		public RefArray<UIPartData> UIParts { get { return m_UIParts; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(UIParts), this, m_UIParts, value)) m_UIParts = value; } } // 0x104 (260)
		
		protected float m_RegenerationDelayModifier = new float();
		[ContainerField(264), LayoutImmutable, Blittable, ContainerFieldNameHash(2924338326)]
		public float RegenerationDelayModifier { get { return m_RegenerationDelayModifier; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(RegenerationDelayModifier), this, m_RegenerationDelayModifier, value)) m_RegenerationDelayModifier = value; } } // 0x108 (264)
		
		protected bool m_FreeSpaceCheck = new bool();
		[ContainerField(268), LayoutImmutable, Blittable, ContainerFieldNameHash(1181198163)]
		public bool FreeSpaceCheck { get { return m_FreeSpaceCheck; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(FreeSpaceCheck), this, m_FreeSpaceCheck, value)) m_FreeSpaceCheck = value; } } // 0x10C (268)
		
		protected bool m_ProximityCheck = new bool();
		[ContainerField(269), LayoutImmutable, Blittable, ContainerFieldNameHash(4271686838)]
		public bool ProximityCheck { get { return m_ProximityCheck; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(ProximityCheck), this, m_ProximityCheck, value)) m_ProximityCheck = value; } } // 0x10D (269)
		
		protected bool m_EnableGroundmapLighting = new bool();
		[ContainerField(270), LayoutImmutable, Blittable, ContainerFieldNameHash(1278245411)]
		public bool EnableGroundmapLighting { get { return m_EnableGroundmapLighting; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(EnableGroundmapLighting), this, m_EnableGroundmapLighting, value)) m_EnableGroundmapLighting = value; } } // 0x10E (270)
		
		protected bool m_ShowWeaponWhenDead = new bool();
		[ContainerField(271), LayoutImmutable, Blittable, ContainerFieldNameHash(3915982996)]
		public bool ShowWeaponWhenDead { get { return m_ShowWeaponWhenDead; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(ShowWeaponWhenDead), this, m_ShowWeaponWhenDead, value)) m_ShowWeaponWhenDead = value; } } // 0x10F (271)
		
		protected bool m_LowerGunOnOwnTeam = new bool();
		[ContainerField(272), LayoutImmutable, Blittable, ContainerFieldNameHash(3271387216)]
		public bool LowerGunOnOwnTeam { get { return m_LowerGunOnOwnTeam; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(LowerGunOnOwnTeam), this, m_LowerGunOnOwnTeam, value)) m_LowerGunOnOwnTeam = value; } } // 0x110 (272)
		
		protected bool m_UseSpineXRotation = new bool();
		[ContainerField(273), LayoutImmutable, Blittable, ContainerFieldNameHash(3042773355)]
		public bool UseSpineXRotation { get { return m_UseSpineXRotation; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(UseSpineXRotation), this, m_UseSpineXRotation, value)) m_UseSpineXRotation = value; } } // 0x111 (273)
		
		protected bool m_CollisionEnabled = new bool();
		[ContainerField(274), LayoutImmutable, Blittable, ContainerFieldNameHash(134809118)]
		public bool CollisionEnabled { get { return m_CollisionEnabled; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(CollisionEnabled), this, m_CollisionEnabled, value)) m_CollisionEnabled = value; } } // 0x112 (274)
		
		protected bool m_PhysicsControlled = new bool();
		[ContainerField(275), LayoutImmutable, Blittable, ContainerFieldNameHash(3834786116)]
		public bool PhysicsControlled { get { return m_PhysicsControlled; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(PhysicsControlled), this, m_PhysicsControlled, value)) m_PhysicsControlled = value; } } // 0x113 (275)
		
		protected bool m_IsPushable = new bool();
		[ContainerField(276), LayoutImmutable, Blittable, ContainerFieldNameHash(3202802347)]
		public bool IsPushable { get { return m_IsPushable; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(IsPushable), this, m_IsPushable, value)) m_IsPushable = value; } } // 0x114 (276)
		
		protected bool m_HumanPlayerControlled = new bool();
		[ContainerField(277), LayoutImmutable, Blittable, ContainerFieldNameHash(3591714019)]
		public bool HumanPlayerControlled { get { return m_HumanPlayerControlled; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(HumanPlayerControlled), this, m_HumanPlayerControlled, value)) m_HumanPlayerControlled = value; } } // 0x115 (277)
		
		protected bool m_InteractiveManDownAllowed = new bool();
		[ContainerField(278), LayoutImmutable, Blittable, ContainerFieldNameHash(283015237)]
		public bool InteractiveManDownAllowed { get { return m_InteractiveManDownAllowed; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(InteractiveManDownAllowed), this, m_InteractiveManDownAllowed, value)) m_InteractiveManDownAllowed = value; } } // 0x116 (278)
		
		protected bool m_ShowNametag = new bool();
		[ContainerField(279), LayoutImmutable, Blittable, ContainerFieldNameHash(4065911763)]
		public bool ShowNametag { get { return m_ShowNametag; } set { if (OnPropertyChanging("SoldierEntityData." + nameof(ShowNametag), this, m_ShowNametag, value)) m_ShowNametag = value; } } // 0x117 (279)
		
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
