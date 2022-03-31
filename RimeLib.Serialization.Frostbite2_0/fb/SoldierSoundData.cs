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

namespace fb
{
	[ContainerType(4, 52)]
	public class SoldierSoundData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<SoundAsset> Movement { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<SoundAsset> Death { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<SoundAsset> BulletImpact { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<SoundAsset> Healing { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<SoundAsset> BreathControl { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<SoundAsset> HitIndicator { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<SoundAsset> PickupKit { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<SoundAsset> PickupAmmo { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float SprintTimeForRecovery { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float MovementThreshold { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float MinHealSoundTime { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
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
