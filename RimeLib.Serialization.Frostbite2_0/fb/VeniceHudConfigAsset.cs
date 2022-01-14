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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 152)]
	public class VeniceHudConfigAsset : 
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<SoundWaveAsset> AmmoPickupSound { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<SoundWaveAsset> WeaponPickupSound { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<SoundWaveAsset> NewObjectiveSound { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<SoundWaveAsset> ObjectiveCompletedSound { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<SoundWaveAsset> ObjectiveUpdatedSound { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<SoundWaveAsset> MPVictorySoundMec { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<SoundWaveAsset> MPVictorySoundUs { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<SoundWaveAsset> MPVictorySoundRu { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public CtrRef<SoundWaveAsset> MPDefeatSoundMec { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public CtrRef<SoundWaveAsset> MPDefeatSoundUs { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<SoundWaveAsset> MPDefeatSoundRu { get; set; } = new();

		[ContainerField(52), JsonProperty(Order = 52)]
		public CtrRef<SoundWaveAsset> ArtilleryAiming { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public CtrRef<SoundWaveAsset> ArtilleryAimingOOA { get; set; } = new();

		[ContainerField(60), JsonProperty(Order = 60)]
		public CtrRef<SoundWaveAsset> MortarStrikeLocking { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public CtrRef<SoundWaveAsset> LaserDesignatorLocked { get; set; } = new();

		[ContainerField(68), JsonProperty(Order = 68)]
		public CtrRef<SoundWaveAsset> LaserDesignatorLocking { get; set; } = new();

		[ContainerField(72), JsonProperty(Order = 72)]
		public RefArray<UINametag> Nametags { get; set; } = new();

		[ContainerField(76), JsonProperty(Order = 76)]
		public List<SpawnScreenWeaponData> SpawnScreenWeapons { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float MaxOrderIconDistance { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float InnerNametagRadius { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float OuterNametagRadius { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float CriticalHealthThreshold { get; set; }

		[ContainerField(96), JsonProperty(Order = 96)]
		public UITaggedVehicleCrosshair TaggedVehicleCrosshair { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public UIMinimapConfig Minimap { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public bool ShowSpawnPointsOnMinimap { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		public bool NametagHealthVisibleForAll { get; set; }

	}
}
