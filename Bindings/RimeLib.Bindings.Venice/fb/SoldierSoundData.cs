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
	[ContainerType(4, 52)]
	public class SoldierSoundData : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SoundAsset> Movement { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<SoundAsset> Death { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<SoundAsset> BulletImpact { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<SoundAsset> Healing { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<SoundAsset> BreathControl { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<SoundAsset> HitIndicator { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<SoundAsset> PickupKit { get; set; } = new();

		[ContainerField(36)]
		public CtrRef<SoundAsset> PickupAmmo { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public float SprintTimeForRecovery { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float MovementThreshold { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float MinHealSoundTime { get; set; }

		public static void Deserialize(SoldierSoundData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Movement.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Death.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BulletImpact.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Healing.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BreathControl.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.HitIndicator.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PickupKit.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PickupAmmo.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SprintTimeForRecovery = p_Reader.ReadSingle();
			p_Instance.MovementThreshold = p_Reader.ReadSingle();
			p_Instance.MinHealSoundTime = p_Reader.ReadSingle();
		}

	}
}
