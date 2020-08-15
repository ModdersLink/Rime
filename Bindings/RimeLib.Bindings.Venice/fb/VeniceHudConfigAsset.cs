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
	[ContainerType(4)]
	public class VeniceHudConfigAsset : 
		DataContainer
	{
		protected CtrRef<SoundWaveAsset> m_AmmoPickupSound = new CtrRef<SoundWaveAsset>();
		[ContainerField(8), ContainerFieldNameHash(1035113052)]
		public CtrRef<SoundWaveAsset> AmmoPickupSound { get { return m_AmmoPickupSound; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(AmmoPickupSound), this, m_AmmoPickupSound, value)) m_AmmoPickupSound = value; } } // 0x8 (8)
		
		protected CtrRef<SoundWaveAsset> m_WeaponPickupSound = new CtrRef<SoundWaveAsset>();
		[ContainerField(12), ContainerFieldNameHash(574181488)]
		public CtrRef<SoundWaveAsset> WeaponPickupSound { get { return m_WeaponPickupSound; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(WeaponPickupSound), this, m_WeaponPickupSound, value)) m_WeaponPickupSound = value; } } // 0xC (12)
		
		protected CtrRef<SoundWaveAsset> m_NewObjectiveSound = new CtrRef<SoundWaveAsset>();
		[ContainerField(16), ContainerFieldNameHash(1841129077)]
		public CtrRef<SoundWaveAsset> NewObjectiveSound { get { return m_NewObjectiveSound; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(NewObjectiveSound), this, m_NewObjectiveSound, value)) m_NewObjectiveSound = value; } } // 0x10 (16)
		
		protected CtrRef<SoundWaveAsset> m_ObjectiveCompletedSound = new CtrRef<SoundWaveAsset>();
		[ContainerField(20), ContainerFieldNameHash(2161871908)]
		public CtrRef<SoundWaveAsset> ObjectiveCompletedSound { get { return m_ObjectiveCompletedSound; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(ObjectiveCompletedSound), this, m_ObjectiveCompletedSound, value)) m_ObjectiveCompletedSound = value; } } // 0x14 (20)
		
		protected CtrRef<SoundWaveAsset> m_ObjectiveUpdatedSound = new CtrRef<SoundWaveAsset>();
		[ContainerField(24), ContainerFieldNameHash(3617975644)]
		public CtrRef<SoundWaveAsset> ObjectiveUpdatedSound { get { return m_ObjectiveUpdatedSound; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(ObjectiveUpdatedSound), this, m_ObjectiveUpdatedSound, value)) m_ObjectiveUpdatedSound = value; } } // 0x18 (24)
		
		protected CtrRef<SoundWaveAsset> m_MPVictorySoundMec = new CtrRef<SoundWaveAsset>();
		[ContainerField(28), ContainerFieldNameHash(397160828)]
		public CtrRef<SoundWaveAsset> MPVictorySoundMec { get { return m_MPVictorySoundMec; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MPVictorySoundMec), this, m_MPVictorySoundMec, value)) m_MPVictorySoundMec = value; } } // 0x1C (28)
		
		protected CtrRef<SoundWaveAsset> m_MPVictorySoundUs = new CtrRef<SoundWaveAsset>();
		[ContainerField(32), ContainerFieldNameHash(1313539633)]
		public CtrRef<SoundWaveAsset> MPVictorySoundUs { get { return m_MPVictorySoundUs; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MPVictorySoundUs), this, m_MPVictorySoundUs, value)) m_MPVictorySoundUs = value; } } // 0x20 (32)
		
		protected CtrRef<SoundWaveAsset> m_MPVictorySoundRu = new CtrRef<SoundWaveAsset>();
		[ContainerField(36), ContainerFieldNameHash(1313539792)]
		public CtrRef<SoundWaveAsset> MPVictorySoundRu { get { return m_MPVictorySoundRu; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MPVictorySoundRu), this, m_MPVictorySoundRu, value)) m_MPVictorySoundRu = value; } } // 0x24 (36)
		
		protected CtrRef<SoundWaveAsset> m_MPDefeatSoundMec = new CtrRef<SoundWaveAsset>();
		[ContainerField(40), ContainerFieldNameHash(3033616263)]
		public CtrRef<SoundWaveAsset> MPDefeatSoundMec { get { return m_MPDefeatSoundMec; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MPDefeatSoundMec), this, m_MPDefeatSoundMec, value)) m_MPDefeatSoundMec = value; } } // 0x28 (40)
		
		protected CtrRef<SoundWaveAsset> m_MPDefeatSoundUs = new CtrRef<SoundWaveAsset>();
		[ContainerField(44), ContainerFieldNameHash(3996444266)]
		public CtrRef<SoundWaveAsset> MPDefeatSoundUs { get { return m_MPDefeatSoundUs; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MPDefeatSoundUs), this, m_MPDefeatSoundUs, value)) m_MPDefeatSoundUs = value; } } // 0x2C (44)
		
		protected CtrRef<SoundWaveAsset> m_MPDefeatSoundRu = new CtrRef<SoundWaveAsset>();
		[ContainerField(48), ContainerFieldNameHash(3996444363)]
		public CtrRef<SoundWaveAsset> MPDefeatSoundRu { get { return m_MPDefeatSoundRu; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MPDefeatSoundRu), this, m_MPDefeatSoundRu, value)) m_MPDefeatSoundRu = value; } } // 0x30 (48)
		
		protected CtrRef<SoundWaveAsset> m_ArtilleryAiming = new CtrRef<SoundWaveAsset>();
		[ContainerField(52), ContainerFieldNameHash(2653209888)]
		public CtrRef<SoundWaveAsset> ArtilleryAiming { get { return m_ArtilleryAiming; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(ArtilleryAiming), this, m_ArtilleryAiming, value)) m_ArtilleryAiming = value; } } // 0x34 (52)
		
		protected CtrRef<SoundWaveAsset> m_ArtilleryAimingOOA = new CtrRef<SoundWaveAsset>();
		[ContainerField(56), ContainerFieldNameHash(129857345)]
		public CtrRef<SoundWaveAsset> ArtilleryAimingOOA { get { return m_ArtilleryAimingOOA; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(ArtilleryAimingOOA), this, m_ArtilleryAimingOOA, value)) m_ArtilleryAimingOOA = value; } } // 0x38 (56)
		
		protected CtrRef<SoundWaveAsset> m_MortarStrikeLocking = new CtrRef<SoundWaveAsset>();
		[ContainerField(60), ContainerFieldNameHash(2962838539)]
		public CtrRef<SoundWaveAsset> MortarStrikeLocking { get { return m_MortarStrikeLocking; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MortarStrikeLocking), this, m_MortarStrikeLocking, value)) m_MortarStrikeLocking = value; } } // 0x3C (60)
		
		protected CtrRef<SoundWaveAsset> m_LaserDesignatorLocked = new CtrRef<SoundWaveAsset>();
		[ContainerField(64), ContainerFieldNameHash(2363796156)]
		public CtrRef<SoundWaveAsset> LaserDesignatorLocked { get { return m_LaserDesignatorLocked; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(LaserDesignatorLocked), this, m_LaserDesignatorLocked, value)) m_LaserDesignatorLocked = value; } } // 0x40 (64)
		
		protected CtrRef<SoundWaveAsset> m_LaserDesignatorLocking = new CtrRef<SoundWaveAsset>();
		[ContainerField(68), ContainerFieldNameHash(695857437)]
		public CtrRef<SoundWaveAsset> LaserDesignatorLocking { get { return m_LaserDesignatorLocking; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(LaserDesignatorLocking), this, m_LaserDesignatorLocking, value)) m_LaserDesignatorLocking = value; } } // 0x44 (68)
		
		protected RefArray<UINametag> m_Nametags = new RefArray<UINametag>();
		[ContainerField(72), ContainerFieldNameHash(995562467)]
		public RefArray<UINametag> Nametags { get { return m_Nametags; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(Nametags), this, m_Nametags, value)) m_Nametags = value; } } // 0x48 (72)
		
		protected List<SpawnScreenWeaponData> m_SpawnScreenWeapons = new List<SpawnScreenWeaponData>();
		[ContainerField(76), ContainerFieldNameHash(683915459)]
		public List<SpawnScreenWeaponData> SpawnScreenWeapons { get { return m_SpawnScreenWeapons; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(SpawnScreenWeapons), this, m_SpawnScreenWeapons, value)) m_SpawnScreenWeapons = value; } } // 0x4C (76)
		
		protected float m_MaxOrderIconDistance = new float();
		[ContainerField(80), LayoutImmutable, Blittable, ContainerFieldNameHash(1785001655)]
		public float MaxOrderIconDistance { get { return m_MaxOrderIconDistance; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(MaxOrderIconDistance), this, m_MaxOrderIconDistance, value)) m_MaxOrderIconDistance = value; } } // 0x50 (80)
		
		protected float m_InnerNametagRadius = new float();
		[ContainerField(84), LayoutImmutable, Blittable, ContainerFieldNameHash(2232877206)]
		public float InnerNametagRadius { get { return m_InnerNametagRadius; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(InnerNametagRadius), this, m_InnerNametagRadius, value)) m_InnerNametagRadius = value; } } // 0x54 (84)
		
		protected float m_OuterNametagRadius = new float();
		[ContainerField(88), LayoutImmutable, Blittable, ContainerFieldNameHash(2112874321)]
		public float OuterNametagRadius { get { return m_OuterNametagRadius; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(OuterNametagRadius), this, m_OuterNametagRadius, value)) m_OuterNametagRadius = value; } } // 0x58 (88)
		
		protected float m_CriticalHealthThreshold = new float();
		[ContainerField(92), LayoutImmutable, Blittable, ContainerFieldNameHash(3436084165)]
		public float CriticalHealthThreshold { get { return m_CriticalHealthThreshold; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(CriticalHealthThreshold), this, m_CriticalHealthThreshold, value)) m_CriticalHealthThreshold = value; } } // 0x5C (92)
		
		protected UITaggedVehicleCrosshair m_TaggedVehicleCrosshair = new UITaggedVehicleCrosshair();
		[ContainerField(96), ContainerFieldNameHash(4212658085)]
		public UITaggedVehicleCrosshair TaggedVehicleCrosshair { get { return m_TaggedVehicleCrosshair; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(TaggedVehicleCrosshair), this, m_TaggedVehicleCrosshair, value)) m_TaggedVehicleCrosshair = value; } } // 0x60 (96)
		
		protected UIMinimapConfig m_Minimap = new UIMinimapConfig();
		[ContainerField(112), ContainerFieldNameHash(1011406874)]
		public UIMinimapConfig Minimap { get { return m_Minimap; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(Minimap), this, m_Minimap, value)) m_Minimap = value; } } // 0x70 (112)
		
		protected bool m_ShowSpawnPointsOnMinimap = new bool();
		[ContainerField(148), LayoutImmutable, Blittable, ContainerFieldNameHash(569271516)]
		public bool ShowSpawnPointsOnMinimap { get { return m_ShowSpawnPointsOnMinimap; } set { if (OnPropertyChanging("VeniceHudConfigAsset." + nameof(ShowSpawnPointsOnMinimap), this, m_ShowSpawnPointsOnMinimap, value)) m_ShowSpawnPointsOnMinimap = value; } } // 0x94 (148)
		
		protected bool m_NametagHealthVisibleForAll = new bool();
		[ContainerField(149), LayoutImmutable, Blittable, ContainerFieldNameHash(312850008)]
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
