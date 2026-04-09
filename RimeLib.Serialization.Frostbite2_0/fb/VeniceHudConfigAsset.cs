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
	[ContainerType(4, 152)]
	public partial class VeniceHudConfigAsset :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private CtrRef<SoundWaveAsset> _AmmoPickupSound = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<SoundWaveAsset> _WeaponPickupSound = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<SoundWaveAsset> _NewObjectiveSound = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<SoundWaveAsset> _ObjectiveCompletedSound = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<SoundWaveAsset> _ObjectiveUpdatedSound = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<SoundWaveAsset> _MPVictorySoundMec = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<SoundWaveAsset> _MPVictorySoundUs = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private CtrRef<SoundWaveAsset> _MPVictorySoundRu = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private CtrRef<SoundWaveAsset> _MPDefeatSoundMec = new();

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private CtrRef<SoundWaveAsset> _MPDefeatSoundUs = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private CtrRef<SoundWaveAsset> _MPDefeatSoundRu = new();

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private CtrRef<SoundWaveAsset> _ArtilleryAiming = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private CtrRef<SoundWaveAsset> _ArtilleryAimingOOA = new();

		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private CtrRef<SoundWaveAsset> _MortarStrikeLocking = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private CtrRef<SoundWaveAsset> _LaserDesignatorLocked = new();

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private CtrRef<SoundWaveAsset> _LaserDesignatorLocking = new();

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private RefArray<UINametag> _Nametags = new();

		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private List<SpawnScreenWeaponData> _SpawnScreenWeapons = new();

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _MaxOrderIconDistance;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _InnerNametagRadius;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _OuterNametagRadius;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _CriticalHealthThreshold;

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private UITaggedVehicleCrosshair _TaggedVehicleCrosshair = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private UIMinimapConfig _Minimap = new();

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private bool _ShowSpawnPointsOnMinimap;

		[ObservableProperty]
		[property: ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		private bool _NametagHealthVisibleForAll;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(p_EbxWriter.WriteImport(AmmoPickupSound));
			p_Writer.Write(p_EbxWriter.WriteImport(WeaponPickupSound));
			p_Writer.Write(p_EbxWriter.WriteImport(NewObjectiveSound));
			p_Writer.Write(p_EbxWriter.WriteImport(ObjectiveCompletedSound));
			p_Writer.Write(p_EbxWriter.WriteImport(ObjectiveUpdatedSound));
			p_Writer.Write(p_EbxWriter.WriteImport(MPVictorySoundMec));
			p_Writer.Write(p_EbxWriter.WriteImport(MPVictorySoundUs));
			p_Writer.Write(p_EbxWriter.WriteImport(MPVictorySoundRu));
			p_Writer.Write(p_EbxWriter.WriteImport(MPDefeatSoundMec));
			p_Writer.Write(p_EbxWriter.WriteImport(MPDefeatSoundUs));
			p_Writer.Write(p_EbxWriter.WriteImport(MPDefeatSoundRu));
			p_Writer.Write(p_EbxWriter.WriteImport(ArtilleryAiming));
			p_Writer.Write(p_EbxWriter.WriteImport(ArtilleryAimingOOA));
			p_Writer.Write(p_EbxWriter.WriteImport(MortarStrikeLocking));
			p_Writer.Write(p_EbxWriter.WriteImport(LaserDesignatorLocked));
			p_Writer.Write(p_EbxWriter.WriteImport(LaserDesignatorLocking));
			(RimeWriter Writer, uint ArrayIndex) s_Nametags = p_EbxWriter.GetArrayWriter(Nametags.GetType(), Nametags.Count);
			p_Writer.Write(s_Nametags.ArrayIndex);
			foreach (var s_Entry in Nametags)
			{
				s_Nametags.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_SpawnScreenWeapons = p_EbxWriter.GetArrayWriter(SpawnScreenWeapons.GetType(), SpawnScreenWeapons.Count);
			p_Writer.Write(s_SpawnScreenWeapons.ArrayIndex);
			foreach (var s_Entry in SpawnScreenWeapons)
			{
				s_Entry.Serialize(s_SpawnScreenWeapons.Writer, p_EbxWriter);
			}
			p_Writer.Write(MaxOrderIconDistance);
			p_Writer.Write(InnerNametagRadius);
			p_Writer.Write(OuterNametagRadius);
			p_Writer.Write(CriticalHealthThreshold);
			TaggedVehicleCrosshair.Serialize(p_Writer, p_EbxWriter);
			Minimap.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ShowSpawnPointsOnMinimap);
			p_Writer.Write(NametagHealthVisibleForAll);
			p_Writer.WriteNullBytes(2);
		}
	}
}
