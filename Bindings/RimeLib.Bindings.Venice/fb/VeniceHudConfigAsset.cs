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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 152)]
	public class VeniceHudConfigAsset : 
		DataContainer
	{
		protected CtrRef<SoundWaveAsset> m_AmmoPickupSound = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "AmmoPickupSound", Offset: 8, NameHash: 1035113052, Flags: 53)]
		public CtrRef<SoundWaveAsset> AmmoPickupSound { get { return m_AmmoPickupSound; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(AmmoPickupSound), this, m_AmmoPickupSound, value)) m_AmmoPickupSound = value; } } // 0x8 (8)
		
		protected CtrRef<SoundWaveAsset> m_WeaponPickupSound = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "WeaponPickupSound", Offset: 12, NameHash: 574181488, Flags: 53)]
		public CtrRef<SoundWaveAsset> WeaponPickupSound { get { return m_WeaponPickupSound; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(WeaponPickupSound), this, m_WeaponPickupSound, value)) m_WeaponPickupSound = value; } } // 0xC (12)
		
		protected CtrRef<SoundWaveAsset> m_NewObjectiveSound = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "NewObjectiveSound", Offset: 16, NameHash: 1841129077, Flags: 53)]
		public CtrRef<SoundWaveAsset> NewObjectiveSound { get { return m_NewObjectiveSound; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(NewObjectiveSound), this, m_NewObjectiveSound, value)) m_NewObjectiveSound = value; } } // 0x10 (16)
		
		protected CtrRef<SoundWaveAsset> m_ObjectiveCompletedSound = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "ObjectiveCompletedSound", Offset: 20, NameHash: 2161871908, Flags: 53)]
		public CtrRef<SoundWaveAsset> ObjectiveCompletedSound { get { return m_ObjectiveCompletedSound; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(ObjectiveCompletedSound), this, m_ObjectiveCompletedSound, value)) m_ObjectiveCompletedSound = value; } } // 0x14 (20)
		
		protected CtrRef<SoundWaveAsset> m_ObjectiveUpdatedSound = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "ObjectiveUpdatedSound", Offset: 24, NameHash: 3617975644, Flags: 53)]
		public CtrRef<SoundWaveAsset> ObjectiveUpdatedSound { get { return m_ObjectiveUpdatedSound; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(ObjectiveUpdatedSound), this, m_ObjectiveUpdatedSound, value)) m_ObjectiveUpdatedSound = value; } } // 0x18 (24)
		
		protected CtrRef<SoundWaveAsset> m_MPVictorySoundMec = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "MPVictorySoundMec", Offset: 28, NameHash: 397160828, Flags: 53)]
		public CtrRef<SoundWaveAsset> MPVictorySoundMec { get { return m_MPVictorySoundMec; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MPVictorySoundMec), this, m_MPVictorySoundMec, value)) m_MPVictorySoundMec = value; } } // 0x1C (28)
		
		protected CtrRef<SoundWaveAsset> m_MPVictorySoundUs = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "MPVictorySoundUs", Offset: 32, NameHash: 1313539633, Flags: 53)]
		public CtrRef<SoundWaveAsset> MPVictorySoundUs { get { return m_MPVictorySoundUs; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MPVictorySoundUs), this, m_MPVictorySoundUs, value)) m_MPVictorySoundUs = value; } } // 0x20 (32)
		
		protected CtrRef<SoundWaveAsset> m_MPVictorySoundRu = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "MPVictorySoundRu", Offset: 36, NameHash: 1313539792, Flags: 53)]
		public CtrRef<SoundWaveAsset> MPVictorySoundRu { get { return m_MPVictorySoundRu; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MPVictorySoundRu), this, m_MPVictorySoundRu, value)) m_MPVictorySoundRu = value; } } // 0x24 (36)
		
		protected CtrRef<SoundWaveAsset> m_MPDefeatSoundMec = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "MPDefeatSoundMec", Offset: 40, NameHash: 3033616263, Flags: 53)]
		public CtrRef<SoundWaveAsset> MPDefeatSoundMec { get { return m_MPDefeatSoundMec; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MPDefeatSoundMec), this, m_MPDefeatSoundMec, value)) m_MPDefeatSoundMec = value; } } // 0x28 (40)
		
		protected CtrRef<SoundWaveAsset> m_MPDefeatSoundUs = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "MPDefeatSoundUs", Offset: 44, NameHash: 3996444266, Flags: 53)]
		public CtrRef<SoundWaveAsset> MPDefeatSoundUs { get { return m_MPDefeatSoundUs; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MPDefeatSoundUs), this, m_MPDefeatSoundUs, value)) m_MPDefeatSoundUs = value; } } // 0x2C (44)
		
		protected CtrRef<SoundWaveAsset> m_MPDefeatSoundRu = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "MPDefeatSoundRu", Offset: 48, NameHash: 3996444363, Flags: 53)]
		public CtrRef<SoundWaveAsset> MPDefeatSoundRu { get { return m_MPDefeatSoundRu; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MPDefeatSoundRu), this, m_MPDefeatSoundRu, value)) m_MPDefeatSoundRu = value; } } // 0x30 (48)
		
		protected CtrRef<SoundWaveAsset> m_ArtilleryAiming = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "ArtilleryAiming", Offset: 52, NameHash: 2653209888, Flags: 53)]
		public CtrRef<SoundWaveAsset> ArtilleryAiming { get { return m_ArtilleryAiming; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(ArtilleryAiming), this, m_ArtilleryAiming, value)) m_ArtilleryAiming = value; } } // 0x34 (52)
		
		protected CtrRef<SoundWaveAsset> m_ArtilleryAimingOOA = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "ArtilleryAimingOOA", Offset: 56, NameHash: 129857345, Flags: 53)]
		public CtrRef<SoundWaveAsset> ArtilleryAimingOOA { get { return m_ArtilleryAimingOOA; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(ArtilleryAimingOOA), this, m_ArtilleryAimingOOA, value)) m_ArtilleryAimingOOA = value; } } // 0x38 (56)
		
		protected CtrRef<SoundWaveAsset> m_MortarStrikeLocking = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "MortarStrikeLocking", Offset: 60, NameHash: 2962838539, Flags: 53)]
		public CtrRef<SoundWaveAsset> MortarStrikeLocking { get { return m_MortarStrikeLocking; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MortarStrikeLocking), this, m_MortarStrikeLocking, value)) m_MortarStrikeLocking = value; } } // 0x3C (60)
		
		protected CtrRef<SoundWaveAsset> m_LaserDesignatorLocked = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "LaserDesignatorLocked", Offset: 64, NameHash: 2363796156, Flags: 53)]
		public CtrRef<SoundWaveAsset> LaserDesignatorLocked { get { return m_LaserDesignatorLocked; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(LaserDesignatorLocked), this, m_LaserDesignatorLocked, value)) m_LaserDesignatorLocked = value; } } // 0x40 (64)
		
		protected CtrRef<SoundWaveAsset> m_LaserDesignatorLocking = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "LaserDesignatorLocking", Offset: 68, NameHash: 695857437, Flags: 53)]
		public CtrRef<SoundWaveAsset> LaserDesignatorLocking { get { return m_LaserDesignatorLocking; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(LaserDesignatorLocking), this, m_LaserDesignatorLocking, value)) m_LaserDesignatorLocking = value; } } // 0x44 (68)
		
		protected RefArray<UINametag> m_Nametags = new RefArray<UINametag>();
		[ContainerField(Name: "Nametags", Offset: 72, NameHash: 995562467, Flags: 65)]
		public RefArray<UINametag> Nametags { get { return m_Nametags; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(Nametags), this, m_Nametags, value)) m_Nametags = value; } } // 0x48 (72)
		
		protected List<SpawnScreenWeaponData> m_SpawnScreenWeapons = new List<SpawnScreenWeaponData>();
		[ContainerField(Name: "SpawnScreenWeapons", Offset: 76, NameHash: 683915459, Flags: 65)]
		public List<SpawnScreenWeaponData> SpawnScreenWeapons { get { return m_SpawnScreenWeapons; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(SpawnScreenWeapons), this, m_SpawnScreenWeapons, value)) m_SpawnScreenWeapons = value; } } // 0x4C (76)
		
		protected float m_MaxOrderIconDistance = new float();
		[ContainerField(Name: "MaxOrderIconDistance", Offset: 80, NameHash: 1785001655, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxOrderIconDistance { get { return m_MaxOrderIconDistance; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MaxOrderIconDistance), this, m_MaxOrderIconDistance, value)) m_MaxOrderIconDistance = value; } } // 0x50 (80)
		
		protected float m_InnerNametagRadius = new float();
		[ContainerField(Name: "InnerNametagRadius", Offset: 84, NameHash: 2232877206, Flags: 49469), LayoutImmutable, Blittable]
		public float InnerNametagRadius { get { return m_InnerNametagRadius; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(InnerNametagRadius), this, m_InnerNametagRadius, value)) m_InnerNametagRadius = value; } } // 0x54 (84)
		
		protected float m_OuterNametagRadius = new float();
		[ContainerField(Name: "OuterNametagRadius", Offset: 88, NameHash: 2112874321, Flags: 49469), LayoutImmutable, Blittable]
		public float OuterNametagRadius { get { return m_OuterNametagRadius; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(OuterNametagRadius), this, m_OuterNametagRadius, value)) m_OuterNametagRadius = value; } } // 0x58 (88)
		
		protected float m_CriticalHealthThreshold = new float();
		[ContainerField(Name: "CriticalHealthThreshold", Offset: 92, NameHash: 3436084165, Flags: 49469), LayoutImmutable, Blittable]
		public float CriticalHealthThreshold { get { return m_CriticalHealthThreshold; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(CriticalHealthThreshold), this, m_CriticalHealthThreshold, value)) m_CriticalHealthThreshold = value; } } // 0x5C (92)
		
		protected UITaggedVehicleCrosshair m_TaggedVehicleCrosshair = new UITaggedVehicleCrosshair();
		[ContainerField(Name: "TaggedVehicleCrosshair", Offset: 96, NameHash: 4212658085, Flags: 41)]
		public UITaggedVehicleCrosshair TaggedVehicleCrosshair { get { return m_TaggedVehicleCrosshair; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(TaggedVehicleCrosshair), this, m_TaggedVehicleCrosshair, value)) m_TaggedVehicleCrosshair = value; } } // 0x60 (96)
		
		protected UIMinimapConfig m_Minimap = new UIMinimapConfig();
		[ContainerField(Name: "Minimap", Offset: 112, NameHash: 1011406874, Flags: 41)]
		public UIMinimapConfig Minimap { get { return m_Minimap; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(Minimap), this, m_Minimap, value)) m_Minimap = value; } } // 0x70 (112)
		
		protected bool m_ShowSpawnPointsOnMinimap = new bool();
		[ContainerField(Name: "ShowSpawnPointsOnMinimap", Offset: 148, NameHash: 569271516, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowSpawnPointsOnMinimap { get { return m_ShowSpawnPointsOnMinimap; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(ShowSpawnPointsOnMinimap), this, m_ShowSpawnPointsOnMinimap, value)) m_ShowSpawnPointsOnMinimap = value; } } // 0x94 (148)
		
		protected bool m_NametagHealthVisibleForAll = new bool();
		[ContainerField(Name: "NametagHealthVisibleForAll", Offset: 149, NameHash: 312850008, Flags: 49325), LayoutImmutable, Blittable]
		public bool NametagHealthVisibleForAll { get { return m_NametagHealthVisibleForAll; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(NametagHealthVisibleForAll), this, m_NametagHealthVisibleForAll, value)) m_NametagHealthVisibleForAll = value; } } // 0x95 (149)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1035113052:
					AmmoPickupSound = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 574181488:
					WeaponPickupSound = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 1841129077:
					NewObjectiveSound = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 2161871908:
					ObjectiveCompletedSound = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 3617975644:
					ObjectiveUpdatedSound = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 397160828:
					MPVictorySoundMec = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 1313539633:
					MPVictorySoundUs = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 1313539792:
					MPVictorySoundRu = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 3033616263:
					MPDefeatSoundMec = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 3996444266:
					MPDefeatSoundUs = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 3996444363:
					MPDefeatSoundRu = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 2653209888:
					ArtilleryAiming = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 129857345:
					ArtilleryAimingOOA = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 2962838539:
					MortarStrikeLocking = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 2363796156:
					LaserDesignatorLocked = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 695857437:
					LaserDesignatorLocking = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 995562467:
					Nametags = (RefArray<UINametag>) p_Value;
					break;

				case 683915459:
					SpawnScreenWeapons = (List<SpawnScreenWeaponData>) p_Value;
					break;

				case 1785001655:
					MaxOrderIconDistance = (float) p_Value;
					break;

				case 2232877206:
					InnerNametagRadius = (float) p_Value;
					break;

				case 2112874321:
					OuterNametagRadius = (float) p_Value;
					break;

				case 3436084165:
					CriticalHealthThreshold = (float) p_Value;
					break;

				case 4212658085:
					TaggedVehicleCrosshair = (UITaggedVehicleCrosshair) p_Value;
					break;

				case 1011406874:
					Minimap = (UIMinimapConfig) p_Value;
					break;

				case 569271516:
					ShowSpawnPointsOnMinimap = (bool) p_Value;
					break;

				case 312850008:
					NametagHealthVisibleForAll = (bool) p_Value;
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
				case 1035113052:
					return AmmoPickupSound;

				case 574181488:
					return WeaponPickupSound;

				case 1841129077:
					return NewObjectiveSound;

				case 2161871908:
					return ObjectiveCompletedSound;

				case 3617975644:
					return ObjectiveUpdatedSound;

				case 397160828:
					return MPVictorySoundMec;

				case 1313539633:
					return MPVictorySoundUs;

				case 1313539792:
					return MPVictorySoundRu;

				case 3033616263:
					return MPDefeatSoundMec;

				case 3996444266:
					return MPDefeatSoundUs;

				case 3996444363:
					return MPDefeatSoundRu;

				case 2653209888:
					return ArtilleryAiming;

				case 129857345:
					return ArtilleryAimingOOA;

				case 2962838539:
					return MortarStrikeLocking;

				case 2363796156:
					return LaserDesignatorLocked;

				case 695857437:
					return LaserDesignatorLocking;

				case 995562467:
					return Nametags;

				case 683915459:
					return SpawnScreenWeapons;

				case 1785001655:
					return MaxOrderIconDistance;

				case 2232877206:
					return InnerNametagRadius;

				case 2112874321:
					return OuterNametagRadius;

				case 3436084165:
					return CriticalHealthThreshold;

				case 4212658085:
					return TaggedVehicleCrosshair;

				case 1011406874:
					return Minimap;

				case 569271516:
					return ShowSpawnPointsOnMinimap;

				case 312850008:
					return NametagHealthVisibleForAll;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1035113052:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(AmmoPickupSound));

				case 574181488:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(WeaponPickupSound));

				case 1841129077:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(NewObjectiveSound));

				case 2161871908:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(ObjectiveCompletedSound));

				case 3617975644:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(ObjectiveUpdatedSound));

				case 397160828:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(MPVictorySoundMec));

				case 1313539633:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(MPVictorySoundUs));

				case 1313539792:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(MPVictorySoundRu));

				case 3033616263:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(MPDefeatSoundMec));

				case 3996444266:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(MPDefeatSoundUs));

				case 3996444363:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(MPDefeatSoundRu));

				case 2653209888:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(ArtilleryAiming));

				case 129857345:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(ArtilleryAimingOOA));

				case 2962838539:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(MortarStrikeLocking));

				case 2363796156:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(LaserDesignatorLocked));

				case 695857437:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(LaserDesignatorLocking));

				case 995562467:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(Nametags));

				case 683915459:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(SpawnScreenWeapons));

				case 1785001655:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(MaxOrderIconDistance));

				case 2232877206:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(InnerNametagRadius));

				case 2112874321:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(OuterNametagRadius));

				case 3436084165:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(CriticalHealthThreshold));

				case 4212658085:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(TaggedVehicleCrosshair));

				case 1011406874:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(Minimap));

				case 569271516:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(ShowSpawnPointsOnMinimap));

				case 312850008:
					return typeof(VeniceHudConfigAsset).GetProperty(nameof(NametagHealthVisibleForAll));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
