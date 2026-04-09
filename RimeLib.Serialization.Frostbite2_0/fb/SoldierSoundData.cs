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
	[ContainerType(4, 52)]
	public partial class SoldierSoundData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private CtrRef<SoundAsset> _Movement = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<SoundAsset> _Death = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<SoundAsset> _BulletImpact = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<SoundAsset> _Healing = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<SoundAsset> _BreathControl = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<SoundAsset> _HitIndicator = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<SoundAsset> _PickupKit = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private CtrRef<SoundAsset> _PickupAmmo = new();

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _SprintTimeForRecovery;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _MovementThreshold;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _MinHealSoundTime;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(p_EbxWriter.WriteImport(Movement));
			p_Writer.Write(p_EbxWriter.WriteImport(Death));
			p_Writer.Write(p_EbxWriter.WriteImport(BulletImpact));
			p_Writer.Write(p_EbxWriter.WriteImport(Healing));
			p_Writer.Write(p_EbxWriter.WriteImport(BreathControl));
			p_Writer.Write(p_EbxWriter.WriteImport(HitIndicator));
			p_Writer.Write(p_EbxWriter.WriteImport(PickupKit));
			p_Writer.Write(p_EbxWriter.WriteImport(PickupAmmo));
			p_Writer.Write(SprintTimeForRecovery);
			p_Writer.Write(MovementThreshold);
			p_Writer.Write(MinHealSoundTime);
		}
	}
}
