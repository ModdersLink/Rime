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
    [ContainerType(4)]
	public class VeniceHudConfigAsset : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SoundWaveAsset> AmmoPickupSound { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<SoundWaveAsset> WeaponPickupSound { get; set; } = new CtrRef<SoundWaveAsset>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<SoundWaveAsset> NewObjectiveSound { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<SoundWaveAsset> ObjectiveCompletedSound { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<SoundWaveAsset> ObjectiveUpdatedSound { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<SoundWaveAsset> MPVictorySoundMec { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<SoundWaveAsset> MPVictorySoundUs { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x20 (32)
		
		[ContainerField(36)]
		public CtrRef<SoundWaveAsset> MPVictorySoundRu { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x24 (36)
		
		[ContainerField(40)]
		public CtrRef<SoundWaveAsset> MPDefeatSoundMec { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x28 (40)
		
		[ContainerField(44)]
		public CtrRef<SoundWaveAsset> MPDefeatSoundUs { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x2C (44)
		
		[ContainerField(48)]
		public CtrRef<SoundWaveAsset> MPDefeatSoundRu { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x30 (48)
		
		[ContainerField(52)]
		public CtrRef<SoundWaveAsset> ArtilleryAiming { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x34 (52)
		
		[ContainerField(56)]
		public CtrRef<SoundWaveAsset> ArtilleryAimingOOA { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x38 (56)
		
		[ContainerField(60)]
		public CtrRef<SoundWaveAsset> MortarStrikeLocking { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x3C (60)
		
		[ContainerField(64)]
		public CtrRef<SoundWaveAsset> LaserDesignatorLocked { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x40 (64)
		
		[ContainerField(68)]
		public CtrRef<SoundWaveAsset> LaserDesignatorLocking { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x44 (68)
		
		[ContainerField(72)]
		public RefArray<UINametag> Nametags { get; set; } = new RefArray<UINametag>(); // 0x48 (72)
		
		[ContainerField(76)]
		public List<SpawnScreenWeaponData> SpawnScreenWeapons { get; set; } = new List<SpawnScreenWeaponData>(); // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float MaxOrderIconDistance { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float InnerNametagRadius { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float OuterNametagRadius { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float CriticalHealthThreshold { get; set; } // 0x5C (92)
		
		[ContainerField(96)]
		public UITaggedVehicleCrosshair TaggedVehicleCrosshair { get; set; } = new UITaggedVehicleCrosshair(); // 0x60 (96)
		
		[ContainerField(112)]
		public UIMinimapConfig Minimap { get; set; } = new UIMinimapConfig(); // 0x70 (112)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool ShowSpawnPointsOnMinimap { get; set; } // 0x94 (148)
		
		[ContainerField(149), LayoutImmutable, Blittable]
		public bool NametagHealthVisibleForAll { get; set; } // 0x95 (149)
		
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
