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

using fb.Core;
using fb.Audio;
using fb.GameShared;

namespace fb.SoldierShared;

[ContainerType(8, 96)]
public class SoldierSoundData
	: fb.GameShared.CharacterSoundData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<SoundAsset> Death { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<SoundAsset> BulletImpact { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<SoundAsset> Healing { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<SoundAsset> BreathControl { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<SoundAsset> HitIndicator { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<SoundAsset> PickupKit { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<SoundAsset> PickupAmmo { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float SprintTimeForRecovery { get; set; } = 5.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float MovementThreshold { get; set; } = 0.100f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float MinHealSoundTime { get; set; } = 0.500f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Death));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(BulletImpact));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Healing));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(BreathControl));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HitIndicator));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PickupKit));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PickupAmmo));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SprintTimeForRecovery);
		p_Writer.Write(MovementThreshold);
		p_Writer.Write(MinHealSoundTime);
		p_Writer.WriteNullBytes(4);
	}
}

